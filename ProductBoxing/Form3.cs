using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductBoxing
{
    public partial class Form3 : Form
    {
        Product product = new Product();
        bool updateBtnStatus = false;
        public Form3(Product product, bool updateBtnStatus)
        {
            InitializeComponent();
            this.product = product;
            this.updateBtnStatus = updateBtnStatus;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            if (updateBtnStatus)
            {
                referenceTxtBox.Text = product.ReferenceCode;
                boxTotalTxtBox.Text = product.BoxingNumber.ToString();
                deleteBtn.Enabled = true;
            }
            else
            {
                referenceTxtBox.Clear();
                boxTotalTxtBox.Clear();
                deleteBtn.Enabled = false;
            }
        }

        // Add a product row to the database
        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(referenceTxtBox.Text) || string.IsNullOrEmpty(boxTotalTxtBox.Text))
            {
                return;
            }
            product.ReferenceCode = referenceTxtBox.Text;
            product.BoxingNumber = Convert.ToInt32(boxTotalTxtBox.Text);

            using (ProductDBEntities db = new ProductDBEntities())
            {
                if (updateBtnStatus)
                {
                    db.Entry(product).State = EntityState.Modified;
                }
                else
                {
                    db.Product.Add(product);
                }
                db.SaveChanges();
            }
            this.Close();
        }

        // Delete selected product !!! not finished !!!
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (ProductDBEntities db = new ProductDBEntities())
            {
                db.Entry(product).State = EntityState.Deleted;
                db.Product.Remove(product);
                db.SaveChanges();
            }
            this.Close();
        }

        // Only accepts letters and numbers
        private void referenceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // the task is handled do not take any action
                e.Handled = true;
            }
        }

        // Only accepts numbers
        private void boxTotalTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void referenceTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (referenceTxtBox.Text == product.ReferenceCode)
            {
                saveBtn.Text = "Save";
                deleteBtn.Enabled = true;
            }
            else if (updateBtnStatus)
            {
                saveBtn.Text = "Update";
                deleteBtn.Enabled = false;
            }
        }

        private void boxTotalTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (boxTotalTxtBox.Text == product.BoxingNumber.ToString())
            {
                saveBtn.Text = "Save";
                deleteBtn.Enabled = true;
            }
            else
            {
                saveBtn.Text = "Update";
                deleteBtn.Enabled = false;
            }
        }
    }
}
