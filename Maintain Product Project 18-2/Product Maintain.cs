using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Maintain_Product_Project_18_2
{
    public partial class productMaintenance : Form
    {
        public productMaintenance()
        {
            InitializeComponent();
        }
      // An event handler that save changes and add new record to a database
        private void productsBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            if (productsBindingSource.Count > 0)
            {
                //Validata each input enter by the user
                if (IsValidData())
                {
                    try
                    {                       
                        this.productsBindingSource.EndEdit();
                        this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);
                        productCodeTextBox.Focus();//Focus the cursor in the productCodeTextBox
                    }
                    catch (ConstraintException)
                    {
                        MessageBox.Show("Please enter a unique primary key", "Contraint Error has Occured", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (DBConcurrencyException)
                    {
                        MessageBox.Show("Two processing is done at the same time", "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    catch (DataException)
                    {
                        MessageBox.Show("Error occur while trying to save record", "Data Exception Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        productsBindingSource.CancelEdit();//Cancel the what whatever that was to be saved.

                    }
                    catch (ArgumentException)
                    {
                        MessageBox.Show("An argument doesn't meet paramenter specification", "Argument Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        productsBindingSource.CancelEdit();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Error connecting to database", "Connection error...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }

            }
            else
            {
                try
                {
                    this.tableAdapterManager.UpdateAll(this.techSupport_DataDataSet);
                }
                catch (DBConcurrencyException)
                {
                    MessageBox.Show("Database concurrency Error has occured", "Concurrency Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                catch (SqlException)
                {
                    MessageBox.Show("Database Error", "Error connecting...", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }
        
        //The form load event that loads the databse into the datagridview
        private void Form1_Load(object sender, EventArgs e)
        {
          
            this.productsTableAdapter.Fill(this.techSupport_DataDataSet.Products);
            fillByProductCodeToolStrip.Focus();

        }
        //An event handler that finds a particular product base on the productCode
        private void fillByProductCodeToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                string productCode = productCodeToolStripTextBox.Text;//Assigning the productCode to the productCode variable
                this.productsTableAdapter.FillByProductCode(this.techSupport_DataDataSet.Products, productCode);
            }
            catch (Exception)
            {
               MessageBox.Show("An error has occured", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }
        // An event handler that set the productCode textbox to accept text
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            productCodeTextBox.ReadOnly = false;
            productCodeTextBox.Focus();
       }
    //A method the validates the various controls on the form
        public bool IsValidData()
        {
            return IsPresent(productCodeTextBox, "ProductCode") &&
                IsPresent(nameTextBox, "Name") &&
                IsPresent(versionTextBox, "Version") &&
                IsDecimal(versionTextBox, "Version") &&
                IsPresent(releaseDateTextBox, "Release Date") &&
                IsValidDate(releaseDateTextBox, "Release Date");
        }
      
//A method that checks to make sure the textbox is not empty. If the text box is empty, prompt the user to enter a value
  private bool IsPresent(TextBox controlName, string name)
        {
            if(controlName.Text != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " is a required field", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                controlName.Focus();
                controlName.Clear();
                return false;
            }
        }
        // A method that checks to see if the user enter the valid date. If the user doen't enter a valid date, prompt the user to enter the appropriate date
        private bool IsValidDate(TextBox controlName, string name)
        {
            DateTime date;
            if(DateTime.TryParse(controlName.Text, out date))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be valid date", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controlName.Focus();
                controlName.Clear();
                return false;
            }
        }
    // A method that checks to see if the version is in the right format if not, prompt the user to enter the appropriate format for the version
        private bool IsDecimal(TextBox controlName, string name)
        {
            decimal value;
            if(Decimal.TryParse(controlName.Text, out value))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " must be in decimal format", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                controlName.Focus();
                controlName.Clear();
                return false;
            }
            
        }
        

        }
        
    }


