namespace ProductBoxing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.products = new System.Windows.Forms.Label();
            this.boxesGridView = new System.Windows.Forms.DataGridView();
            this.BoxMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boxes = new System.Windows.Forms.Label();
            this.productsGridView = new System.Windows.Forms.DataGridView();
            this.ProductsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReferenceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBtn = new System.Windows.Forms.Button();
            this.addProductBtn = new System.Windows.Forms.Button();
            this.deleteUpdateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.boxesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // products
            // 
            this.products.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.products.AutoSize = true;
            this.products.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.products.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.products.Location = new System.Drawing.Point(76, 86);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(98, 26);
            this.products.TabIndex = 1;
            this.products.Text = "Products";
            // 
            // boxesGridView
            // 
            this.boxesGridView.AllowUserToDeleteRows = false;
            this.boxesGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxesGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.boxesGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.boxesGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.boxesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.boxesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoxMasterID,
            this.ProductID,
            this.Date,
            this.BoxTotal,
            this.LabelNo,
            this.StatusID});
            this.boxesGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.boxesGridView.Location = new System.Drawing.Point(477, 116);
            this.boxesGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.boxesGridView.MultiSelect = false;
            this.boxesGridView.Name = "boxesGridView";
            this.boxesGridView.ReadOnly = true;
            this.boxesGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.boxesGridView.RowHeadersWidth = 25;
            this.boxesGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.boxesGridView.RowTemplate.Height = 28;
            this.boxesGridView.Size = new System.Drawing.Size(771, 514);
            this.boxesGridView.TabIndex = 3;
            this.boxesGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.boxesGridView_CellClick);
            // 
            // BoxMasterID
            // 
            this.BoxMasterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BoxMasterID.DataPropertyName = "BoxMasterID";
            this.BoxMasterID.HeaderText = "Box ID";
            this.BoxMasterID.MinimumWidth = 8;
            this.BoxMasterID.Name = "BoxMasterID";
            this.BoxMasterID.ReadOnly = true;
            this.BoxMasterID.Width = 93;
            // 
            // ProductID
            // 
            this.ProductID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.MinimumWidth = 8;
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Width = 112;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 80;
            // 
            // BoxTotal
            // 
            this.BoxTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BoxTotal.DataPropertyName = "BoxTotal";
            this.BoxTotal.HeaderText = "Box Total";
            this.BoxTotal.MinimumWidth = 8;
            this.BoxTotal.Name = "BoxTotal";
            this.BoxTotal.ReadOnly = true;
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LabelNo.DataPropertyName = "LabelNo";
            this.LabelNo.HeaderText = "Box Label No";
            this.LabelNo.MinimumWidth = 8;
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.ReadOnly = true;
            this.LabelNo.Width = 110;
            // 
            // StatusID
            // 
            this.StatusID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.StatusID.DataPropertyName = "StatusID";
            this.StatusID.HeaderText = "Status";
            this.StatusID.MinimumWidth = 8;
            this.StatusID.Name = "StatusID";
            this.StatusID.ReadOnly = true;
            this.StatusID.Width = 92;
            // 
            // boxes
            // 
            this.boxes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxes.AutoSize = true;
            this.boxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.boxes.Location = new System.Drawing.Point(472, 86);
            this.boxes.Name = "boxes";
            this.boxes.Size = new System.Drawing.Size(73, 26);
            this.boxes.TabIndex = 4;
            this.boxes.Text = "Boxes";
            // 
            // productsGridView
            // 
            this.productsGridView.AllowUserToDeleteRows = false;
            this.productsGridView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.productsGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productsGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductsID,
            this.ReferenceCode,
            this.BoxLimit});
            this.productsGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.productsGridView.Location = new System.Drawing.Point(81, 116);
            this.productsGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.productsGridView.MultiSelect = false;
            this.productsGridView.Name = "productsGridView";
            this.productsGridView.ReadOnly = true;
            this.productsGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.productsGridView.RowHeadersWidth = 25;
            this.productsGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.productsGridView.RowTemplate.Height = 28;
            this.productsGridView.Size = new System.Drawing.Size(347, 345);
            this.productsGridView.TabIndex = 5;
            this.productsGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productsGridView_CellClick);
            // 
            // ProductsID
            // 
            this.ProductsID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ProductsID.DataPropertyName = "ProductID";
            this.ProductsID.HeaderText = "ID";
            this.ProductsID.MinimumWidth = 8;
            this.ProductsID.Name = "ProductsID";
            this.ProductsID.ReadOnly = true;
            this.ProductsID.Width = 62;
            // 
            // ReferenceCode
            // 
            this.ReferenceCode.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ReferenceCode.DataPropertyName = "ReferenceCode";
            this.ReferenceCode.HeaderText = "Reference";
            this.ReferenceCode.MinimumWidth = 8;
            this.ReferenceCode.Name = "ReferenceCode";
            this.ReferenceCode.ReadOnly = true;
            this.ReferenceCode.Width = 120;
            // 
            // BoxLimit
            // 
            this.BoxLimit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BoxLimit.DataPropertyName = "BoxingNumber";
            this.BoxLimit.HeaderText = "Box Limit";
            this.BoxLimit.MinimumWidth = 8;
            this.BoxLimit.Name = "BoxLimit";
            this.BoxLimit.ReadOnly = true;
            // 
            // createBtn
            // 
            this.createBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.createBtn.Location = new System.Drawing.Point(81, 488);
            this.createBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(347, 42);
            this.createBtn.TabIndex = 2;
            this.createBtn.Text = "Box Create";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // addProductBtn
            // 
            this.addProductBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.addProductBtn.FlatAppearance.BorderSize = 0;
            this.addProductBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addProductBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.addProductBtn.Location = new System.Drawing.Point(81, 588);
            this.addProductBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addProductBtn.Name = "addProductBtn";
            this.addProductBtn.Size = new System.Drawing.Size(347, 42);
            this.addProductBtn.TabIndex = 6;
            this.addProductBtn.Text = "Add Product";
            this.addProductBtn.UseVisualStyleBackColor = false;
            this.addProductBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // deleteUpdateBtn
            // 
            this.deleteUpdateBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteUpdateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.deleteUpdateBtn.FlatAppearance.BorderSize = 0;
            this.deleteUpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteUpdateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.deleteUpdateBtn.Location = new System.Drawing.Point(81, 538);
            this.deleteUpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteUpdateBtn.Name = "deleteUpdateBtn";
            this.deleteUpdateBtn.Size = new System.Drawing.Size(347, 42);
            this.deleteUpdateBtn.TabIndex = 6;
            this.deleteUpdateBtn.Text = "Update / Delete";
            this.deleteUpdateBtn.UseVisualStyleBackColor = false;
            this.deleteUpdateBtn.Click += new System.EventHandler(this.deleteUpdateBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1294, 702);
            this.Controls.Add(this.deleteUpdateBtn);
            this.Controls.Add(this.addProductBtn);
            this.Controls.Add(this.productsGridView);
            this.Controls.Add(this.boxes);
            this.Controls.Add(this.boxesGridView);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.products);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.boxesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label products;
        private System.Windows.Forms.DataGridView boxesGridView;
        private System.Windows.Forms.Label boxes;
        public System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button addProductBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReferenceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxLimit;
        private System.Windows.Forms.Button deleteUpdateBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusID;
    }
}

