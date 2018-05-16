// Application created on April 10, 2018
// Finished on April 26, 2018
// Created by Christopher Garrick, Logan Mullet, and Marc Navia
// Purpose: View, maintain, and update product information  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Major_Assignment_3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            //close app with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void productBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.vendorProductDatabase1DataSet);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendorProductDatabase1DataSet.Vendor' table. You can move, or remove it, as needed.
            this.vendorTableAdapter.Fill(this.vendorProductDatabase1DataSet.Vendor);
            // TODO: This line of code loads data into the 'vendorProductDatabase1DataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.vendorProductDatabase1DataSet.Product);

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            vendorList.Items.Clear();
            //initialize variables
            string name;
            double amount = 0, purchasesTotal = 0, average = 0, counter = 0;

            //foreach loop that calculates purchase amount
            foreach (DataRow dr in vendorProductDatabase1DataSet.Product.Rows)
            {
                amount = double.Parse(dr["YTDPurchases"].ToString());
                purchasesTotal += amount;
                //counter used for finding average purchase
                counter++;

            }

            //foreach loop that displays info in listview
            foreach (DataRow dr in this.vendorProductDatabase1DataSet.Product.Rows)
            {
                name = dr["ProductName"].ToString();
                amount = double.Parse(dr["YTDPurchases"].ToString());

                //creates array to store name and purchase amount
                string[] fieldsArray = new string[2];
                fieldsArray[0] = name;
                fieldsArray[1] = amount.ToString("C2");

                //displays array in listview
                ListViewItem showsLVI = new ListViewItem(fieldsArray);
                vendorList.Items.Add(showsLVI);
            }


            //calculates average purchases
            average = purchasesTotal / counter;

            //displays outputs in labels
            totalPurchasesLabel.Text = purchasesTotal.ToString("C2");
            averagePurchasesLabel.Text = average.ToString("C2");

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //this resets form
            this.productTableAdapter.Fill(this.vendorProductDatabase1DataSet.Product);
            //this clears the listbox and the labels that display total and average purchases
            vendorList.Items.Clear();
            totalPurchasesLabel.Text = null;
            averagePurchasesLabel.Text = null;

            //clears filter and search textbox and enables calculate button
            productBindingSource.Filter = null;
            calcButton.Enabled = true;
            searchTextBox.Text = null;
        }

        private void productsSourcedInTheUSAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //runs query which shows products sources in US
            this.productTableAdapter.FillBySourcedInUSA(this.vendorProductDatabase1DataSet.Product);
            
        }

        private void productsSourcedInChinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //runs query which shows products sources in China
            this.productTableAdapter.FillBySourcedInChina(this.vendorProductDatabase1DataSet.Product);
        }

        private void totalCostAndSalesByToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //runs query which shows sorts by total cost
            this.productTableAdapter.FillByCostAndSales(this.vendorProductDatabase1DataSet.Product);
        }

        private void productNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //productBindingSource.Sort = "ProductName ASC";
            //runs query which sorts by product name
            this.productTableAdapter.FillBySortByProductName(this.vendorProductDatabase1DataSet.Product);
        }

        private void productPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //productBindingSource.Sort = "ProductUnitPrice ASC";
            //runs query which sorts by product price
            this.productTableAdapter.FillBySortByProductPrice(this.vendorProductDatabase1DataSet.Product);
        }

        private void productCostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // productBindingSource.Sort = "ProductCost DESC";
            //runs query which sorts by product cost
            this.productTableAdapter.FillBySortByProductCost(this.vendorProductDatabase1DataSet.Product);

        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            //Initializes variables
            string searchName;
            searchName = searchTextBox.Text;

            try
            {
                //filters product name by names like what is entered in the seach text box
                productBindingSource.Filter = "ProductName LIKE " + "'" + searchName + "*'";

                //throws and exception if search text box is empty
                if (string.IsNullOrWhiteSpace(searchTextBox.Text))
                {
                    throw new Exception();
                }
                //throws exception if search returns no results
                else if (productBindingSource.Count == 0)
                {
                    throw new Exception();
                }
            }
            catch
            {
                //shows message box if there is an exception
                MessageBox.Show("No results for search characters", "Empty Input");
                //resets focus
                searchTextBox.Focus();
                //clears textbox and filter
                searchTextBox.Text = null;
                productBindingSource.Filter = null;
            }

            //disables calculate button
            calcButton.Enabled = false;

        }

        private void toolStripTextBox1_TextChanged(object sender, EventArgs e)
        {
            //clears list view if text in searchbox text is changed
            vendorList.Items.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //close app with confirmation
            DialogResult dialog = MessageBox.Show("Are you sure you want to exit?", this.Text,
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
                this.Close();
        }

        private void searchTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            searchTextBox.SelectAll();

        }

        private void searchTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            searchTextBox.SelectAll();
        }

        private void productIDTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productIDTextBox.SelectAll();
        }

        private void productIDTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productIDTextBox.SelectAll();
        }

        private void productUnitPriceTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productUnitPriceTextBox.SelectAll();
        }

        private void productUnitPriceTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productUnitPriceTextBox.SelectAll();
        }

        private void productCostTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productCostTextBox.SelectAll();
        }

        private void productCostTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productCostTextBox.SelectAll();
        }

        private void quantityOnOrderTextBox1_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            quantityOnOrderTextBox1.SelectAll();
        }

        private void quantityOnOrderTextBox1_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            quantityOnOrderTextBox1.SelectAll();
        }

        private void quantityOnHandTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            quantityOnHandTextBox.SelectAll();
        }

        private void quantityOnHandTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            quantityOnHandTextBox.SelectAll();
        }

        private void productLeadTimeTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productLeadTimeTextBox.SelectAll();
        }

        private void productLeadTimeTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productLeadTimeTextBox.SelectAll();
        }

        private void productReorderLevelTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productReorderLevelTextBox.SelectAll();
        }

        private void productReorderLevelTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productReorderLevelTextBox.SelectAll();
        }

        private void productLineTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            productLeadTimeTextBox.SelectAll();
        }

        private void productLineTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            productLeadTimeTextBox.SelectAll();
        }

        private void brandTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            brandTextBox.SelectAll();
        }

        private void brandTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            brandTextBox.SelectAll();
        }

        private void discountPercentTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            discountPercentTextBox.SelectAll();
        }

        private void discountPercentTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            discountPercentTextBox.SelectAll();
        }

        private void yTDPurchasesTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            yTDPurchasesTextBox.SelectAll();
        }

        private void yTDPurchasesTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            yTDPurchasesTextBox.SelectAll();
        }

        private void yTDSalesTextBox_Enter(object sender, EventArgs e)
        {
            //selects all when textbox is tabbed to
            yTDSalesTextBox.SelectAll();
        }

        private void yTDSalesTextBox_Click(object sender, EventArgs e)
        {
            //selects all when textbox is clicked to
            yTDSalesTextBox.SelectAll();
        }

        private void productsPricedOver55ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.productTableAdapter.FillByUnitPrice(this.vendorProductDatabase1DataSet.Product);
        }

        private void searchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only letters, periods, and control key presses in text box
            if (!char.IsLetter(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void vendorIDComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productUnitPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productCostTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }
        private void quantityOnOrderTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void quantityOnHandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productLeadTimeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productReorderLevelTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void discountPercentTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void yTDPurchasesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void yTDSalesTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only numbers, periods, and control key presses in text box
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productNameComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only letters, periods, and control key presses in text box
            if (!char.IsLetter(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void productLineTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only letters, periods, and control key presses in text box
            if (!char.IsLetter(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

        private void brandTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //allows only letters, periods, and control key presses in text box
            if (!char.IsLetter(e.KeyChar)
                && !char.IsControl(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }
        }

    }
}
