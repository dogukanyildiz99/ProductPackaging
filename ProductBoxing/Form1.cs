using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductBoxing
{
    public partial class Form1 : Form
    {
        bool updateBtnStatus = false;
        public Product product = new Product();
        BoxMaster boxMaster = new BoxMaster();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            createBtn.Text = "Please select a product";
            createBtn.Enabled = false;
            deleteUpdateBtn.Enabled = false;
        }

        // Display create box page
        private void createBtn_Click(object sender, EventArgs e)
        {
            int rowIndex = boxesGridView.Rows.Count - 1;
            int columnIndex = 0;
            // box properties
            boxMaster.ProductID = product.ProductID;
            boxMaster.BoxTotal = 0;
            boxMaster.Date = DateTime.Now;
            boxMaster.LabelNo = DateTime.Now.ToString("E-yyyyMMddHHmmssfff");
            boxMaster.StatusID = 0;

            using (ProductDBEntities db = new ProductDBEntities())
            {
                db.BoxMaster.Add(boxMaster);
                db.SaveChanges();
            }

            // Display label page
            Form2 form2 = new Form2(product, boxMaster);
            form2.ShowDialog();

            // Level the box if it is empty
            if (boxMaster.BoxTotal == 0)
            {
                using (ProductDBEntities db = new ProductDBEntities())
                {
                    db.Entry(boxMaster).State = EntityState.Deleted;
                    db.SaveChanges();
                }
            }

            boxesGridView.ClearSelection();
            PopulateDataGridView();

            boxesGridView.Rows[rowIndex].Selected = true;
            boxesGridView.Rows[rowIndex].Cells[columnIndex].Selected = true;
            // to scroll down
            boxesGridView.FirstDisplayedScrollingRowIndex = rowIndex;

            productsGridView.ClearSelection();
            createBtn.Text = "Please select a product";
            deleteUpdateBtn.Enabled = false;
            createBtn.Enabled = false;
        }

        // Display add product page
        private void addProductBtn_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(product, updateBtnStatus);
            form3.ShowDialog();
            PopulateDataGridView();
            productsGridView.ClearSelection();
            createBtn.Text = "Please select a product";
            createBtn.Enabled = false;
            deleteUpdateBtn.Enabled = false;
            updateBtnStatus = false;
        }

        // Update or delete selected product
        private void deleteUpdateBtn_Click(object sender, EventArgs e)
        {
            updateBtnStatus = true;
            Form3 form3 = new Form3(product, updateBtnStatus);
            form3.ShowDialog();
            PopulateDataGridView();
            productsGridView.ClearSelection();
            createBtn.Text = "Please select a product";
            createBtn.Enabled = false;
            deleteUpdateBtn.Enabled = false;
            updateBtnStatus = false;

        }

        // Gets data from the clicked cell in products table
        private void productsGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productsGridView.CurrentRow.Index >= 0)
            {
                product.ProductID = Convert.ToInt32(productsGridView.CurrentRow.Cells["ProductsID"].Value);
                using (ProductDBEntities db = new ProductDBEntities())
                {
                    product = db.Product.FirstOrDefault(x => x.ProductID == product.ProductID);
                }
                createBtn.Text = "Create Box";
                createBtn.Enabled = true;
                deleteUpdateBtn.Enabled = true;
            }
        }

        // Gets data from the clicked cell in boxes table !!! not finished !!!
        private void boxesGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (boxesGridView.CurrentRow.Index >= 0)
            {
                boxMaster.BoxMasterID = Convert.ToInt32(boxesGridView.CurrentRow.Cells["BoxMasterID"].Value);
                using (ProductDBEntities db = new ProductDBEntities())
                {
                    boxMaster = db.BoxMaster.FirstOrDefault(x => x.BoxMasterID == boxMaster.BoxMasterID);
                }
                if (boxMaster.StatusID == 0)
                {
                    createBtn.Enabled = true;
                }
                else
                {
                    createBtn.Enabled = false;
                }
            }
        }

        // Box and Product tables
        public void PopulateDataGridView()
        {
            productsGridView.AutoGenerateColumns = false;
            using (ProductDBEntities db = new ProductDBEntities())
            {
                var list = db.Product.OrderBy(x => x.ProductID).ToList();
                productsGridView.DataSource = list;
            }

            boxesGridView.AutoGenerateColumns = false;
            using (ProductDBEntities db = new ProductDBEntities())
            {
                var list = db.BoxMaster.OrderBy(x => x.BoxMasterID).ToList();
                boxesGridView.DataSource = list;
            }
        }
    }
}
