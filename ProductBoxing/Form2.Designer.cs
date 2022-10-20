namespace ProductBoxing
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.boxLabels = new System.Windows.Forms.Label();
            this.labelsInBox = new System.Windows.Forms.DataGridView();
            this.BoxDetailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BoxMasterID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LabelNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createBoxBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addLblBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPageBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.labelsInBox)).BeginInit();
            this.SuspendLayout();
            // 
            // boxLabels
            // 
            this.boxLabels.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxLabels.AutoSize = true;
            this.boxLabels.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxLabels.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.boxLabels.Location = new System.Drawing.Point(84, 65);
            this.boxLabels.Name = "boxLabels";
            this.boxLabels.Size = new System.Drawing.Size(195, 25);
            this.boxLabels.TabIndex = 0;
            this.boxLabels.Text = "Labels inside the box";
            // 
            // labelsInBox
            // 
            this.labelsInBox.AllowUserToDeleteRows = false;
            this.labelsInBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelsInBox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.labelsInBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelsInBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.labelsInBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BoxDetailID,
            this.BoxMasterID,
            this.LabelNo,
            this.Date});
            this.labelsInBox.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.labelsInBox.Location = new System.Drawing.Point(89, 94);
            this.labelsInBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelsInBox.Name = "labelsInBox";
            this.labelsInBox.ReadOnly = true;
            this.labelsInBox.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.labelsInBox.RowHeadersWidth = 25;
            this.labelsInBox.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.labelsInBox.RowTemplate.Height = 28;
            this.labelsInBox.Size = new System.Drawing.Size(586, 383);
            this.labelsInBox.TabIndex = 1;
            // 
            // BoxDetailID
            // 
            this.BoxDetailID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.BoxDetailID.DataPropertyName = "BoxDetailID";
            this.BoxDetailID.HeaderText = "ID";
            this.BoxDetailID.MinimumWidth = 8;
            this.BoxDetailID.Name = "BoxDetailID";
            this.BoxDetailID.ReadOnly = true;
            this.BoxDetailID.Width = 62;
            // 
            // BoxMasterID
            // 
            this.BoxMasterID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BoxMasterID.DataPropertyName = "BoxMasterID";
            this.BoxMasterID.HeaderText = "Box Master ID";
            this.BoxMasterID.MinimumWidth = 8;
            this.BoxMasterID.Name = "BoxMasterID";
            this.BoxMasterID.ReadOnly = true;
            // 
            // LabelNo
            // 
            this.LabelNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LabelNo.DataPropertyName = "LabelNo";
            this.LabelNo.HeaderText = "Label No";
            this.LabelNo.MinimumWidth = 8;
            this.LabelNo.Name = "LabelNo";
            this.LabelNo.ReadOnly = true;
            this.LabelNo.Width = 108;
            // 
            // Date
            // 
            this.Date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 8;
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // createBoxBtn
            // 
            this.createBoxBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createBoxBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.createBoxBtn.FlatAppearance.BorderSize = 0;
            this.createBoxBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBoxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createBoxBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.createBoxBtn.Location = new System.Drawing.Point(724, 159);
            this.createBoxBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createBoxBtn.Name = "createBoxBtn";
            this.createBoxBtn.Size = new System.Drawing.Size(180, 42);
            this.createBoxBtn.TabIndex = 3;
            this.createBoxBtn.Text = "Create Box";
            this.createBoxBtn.UseVisualStyleBackColor = false;
            this.createBoxBtn.Click += new System.EventHandler(this.createBoxBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.cancelBtn.Location = new System.Drawing.Point(724, 223);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(180, 42);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addLblBtn
            // 
            this.addLblBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addLblBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.addLblBtn.FlatAppearance.BorderSize = 0;
            this.addLblBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLblBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addLblBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.addLblBtn.Location = new System.Drawing.Point(724, 94);
            this.addLblBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addLblBtn.Name = "addLblBtn";
            this.addLblBtn.Size = new System.Drawing.Size(180, 42);
            this.addLblBtn.TabIndex = 5;
            this.addLblBtn.Text = "Add Label";
            this.addLblBtn.UseVisualStyleBackColor = false;
            this.addLblBtn.Click += new System.EventHandler(this.addLblBtn_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(555, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Box Limit:";
            // 
            // mainPageBtn
            // 
            this.mainPageBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPageBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.mainPageBtn.FlatAppearance.BorderSize = 0;
            this.mainPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mainPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mainPageBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.mainPageBtn.Location = new System.Drawing.Point(724, 435);
            this.mainPageBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPageBtn.Name = "mainPageBtn";
            this.mainPageBtn.Size = new System.Drawing.Size(180, 42);
            this.mainPageBtn.TabIndex = 8;
            this.mainPageBtn.Text = "Main Page";
            this.mainPageBtn.UseVisualStyleBackColor = false;
            this.mainPageBtn.Click += new System.EventHandler(this.mainPageBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(658, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = " ";
            // 
            // infoLbl
            // 
            this.infoLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.infoLbl.AutoSize = true;
            this.infoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.infoLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.infoLbl.Location = new System.Drawing.Point(84, 494);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(0, 29);
            this.infoLbl.TabIndex = 10;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 574);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainPageBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addLblBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.createBoxBtn);
            this.Controls.Add(this.labelsInBox);
            this.Controls.Add(this.boxLabels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Box";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.labelsInBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label boxLabels;
        private System.Windows.Forms.DataGridView labelsInBox;
        private System.Windows.Forms.Button createBoxBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addLblBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button mainPageBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxDetailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BoxMasterID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LabelNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}