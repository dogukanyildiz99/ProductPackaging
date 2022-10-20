using DevExpress.Data.Filtering.Helpers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProductBoxing
{
    public partial class Form2 : Form
    {
        int boxTotal = 0;
        Product product = new Product();
        BoxDetail boxDetail = new BoxDetail();
        BoxMaster boxMaster2 = new BoxMaster();

        public Form2(Product product, BoxMaster boxMaster)
        {
            InitializeComponent();
            this.product = product;
            this.boxMaster2 = boxMaster;
            
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            label1.Text = product.BoxingNumber.ToString();
            labelsInBox.DataSource = null;
            createBoxBtn.Enabled = false;
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (boxMaster2.BoxTotal == -1)
            {
                MessageBox.Show("Box discarded.");
            }
            else
            {
                OpenBoxCreate();
            }
        }

        // Adding the label from textbox to grid
        private void addLblBtn_Click(object sender, EventArgs e)
        {
            createBoxBtn.Enabled = true;
            boxMaster2.ProductID = product.ProductID;
            if (Convert.ToInt32(label1.Text) > 0)
            {
                using (ProductDBEntities db = new ProductDBEntities())
                {
                    int count = Convert.ToInt32(label1.Text);
                    boxDetail.BoxMasterID = boxMaster2.BoxMasterID;
                    boxDetail.LabelNo = DateTime.Now.ToString("L-yyyyMMddHHmmssfff");
                    boxDetail.Date = DateTime.Now;
                    db.BoxDetail.Add(boxDetail);
                    db.SaveChanges();
                    count--;
                    boxTotal++;
                    label1.Text = count.ToString();
                    if (count == 0)
                    {
                        CreateBox();
                        addLblBtn.Enabled = false;
                    }
                }
                PopulateDataGridView();
            }
            else
            {
                return;
            }
        }

        private void createBoxBtn_Click(object sender, EventArgs e)
        {
            CreateBox();
            InfoLabel();
            addLblBtn.Enabled = false;
        }

        // Destroy the box
        private void cancelBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel", "Create Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                boxMaster2.BoxTotal = -1;
                using (ProductDBEntities db = new ProductDBEntities())
                {
                    db.Entry(boxMaster2).State = EntityState.Deleted;
                    db.SaveChanges();
                    PopulateDataGridView();
                }
                this.Close();
            }
        }

        private void mainPageBtn_Click(object sender, EventArgs e)
        {
            OpenBoxCreate();
            PopulateDataGridView();
            this.Close();
        }

        // Display info when box created
        void InfoLabel()
        {
            PopulateDataGridView();
            Form1 form1 = new Form1();
            form1.PopulateDataGridView();
            infoLbl.Text = "BOX CREATED SUCCESSFULLY!";
        }

        // Create box by modifiyng
        void CreateBox()
        {
            if (product.BoxingNumber > 1)
            {
                boxMaster2.ProductID = product.ProductID;
                boxMaster2.BoxTotal = product.BoxingNumber;
                boxMaster2.Date = DateTime.Now;
                boxMaster2.StatusID = 1;
                boxMaster2.LabelNo = DateTime.Now.ToString("E-yyyyMMddHHmmssfff");

                using (ProductDBEntities db = new ProductDBEntities())
                {
                    db.Entry(boxMaster2).State = EntityState.Modified;
                    db.SaveChanges();
                }
                PopulateDataGridView();
                InfoLabel();
                createBoxBtn.Enabled = false;
                cancelBtn.Enabled = false;
            }
        }

        // Create an open box
        void OpenBoxCreate()
        {
            boxMaster2.BoxTotal = boxTotal;
            boxMaster2.Date = DateTime.Now;
            boxMaster2.LabelNo = DateTime.Now.ToString("E-yyyyMMddHHmmssfff");
            using (ProductDBEntities db = new ProductDBEntities())
            {
                db.Entry(boxMaster2).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Detail table
        void PopulateDataGridView()
        {
            labelsInBox.AutoGenerateColumns = false;
            using (ProductDBEntities db = new ProductDBEntities())
            {
                var list = db.BoxDetail.Where(x => x.BoxMasterID == boxMaster2.BoxMasterID).ToList();
                labelsInBox.DataSource = list;
            }
        }
    }
}
