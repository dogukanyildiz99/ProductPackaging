namespace ProductBoxing
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.referenceTxtBox = new System.Windows.Forms.TextBox();
            this.boxTotalTxtBox = new System.Windows.Forms.TextBox();
            this.referenceLbl = new System.Windows.Forms.Label();
            this.boxTotalLbl = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // referenceTxtBox
            // 
            this.referenceTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.referenceTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.referenceTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.referenceTxtBox.Location = new System.Drawing.Point(197, 136);
            this.referenceTxtBox.Multiline = true;
            this.referenceTxtBox.Name = "referenceTxtBox";
            this.referenceTxtBox.Size = new System.Drawing.Size(177, 40);
            this.referenceTxtBox.TabIndex = 0;
            this.referenceTxtBox.TextChanged += new System.EventHandler(this.referenceTxtBox_TextChanged);
            this.referenceTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.referenceTxtBox_KeyPress);
            // 
            // boxTotalTxtBox
            // 
            this.boxTotalTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxTotalTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(210)))), ((int)(((byte)(198)))));
            this.boxTotalTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxTotalTxtBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.boxTotalTxtBox.Location = new System.Drawing.Point(197, 189);
            this.boxTotalTxtBox.Multiline = true;
            this.boxTotalTxtBox.Name = "boxTotalTxtBox";
            this.boxTotalTxtBox.Size = new System.Drawing.Size(177, 40);
            this.boxTotalTxtBox.TabIndex = 1;
            this.boxTotalTxtBox.TextChanged += new System.EventHandler(this.boxTotalTxtBox_TextChanged);
            this.boxTotalTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.boxTotalTxtBox_KeyPress);
            // 
            // referenceLbl
            // 
            this.referenceLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.referenceLbl.AutoSize = true;
            this.referenceLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.referenceLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.referenceLbl.Location = new System.Drawing.Point(21, 136);
            this.referenceLbl.Name = "referenceLbl";
            this.referenceLbl.Size = new System.Drawing.Size(170, 26);
            this.referenceLbl.TabIndex = 2;
            this.referenceLbl.Text = "Reference Code";
            // 
            // boxTotalLbl
            // 
            this.boxTotalLbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxTotalLbl.AutoSize = true;
            this.boxTotalLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.boxTotalLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.boxTotalLbl.Location = new System.Drawing.Point(21, 189);
            this.boxTotalLbl.Name = "boxTotalLbl";
            this.boxTotalLbl.Size = new System.Drawing.Size(103, 26);
            this.boxTotalLbl.TabIndex = 2;
            this.boxTotalLbl.Text = "Box Total";
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.saveBtn.Location = new System.Drawing.Point(197, 266);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(177, 47);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(21, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please enter product attributes";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(186)))), ((int)(((byte)(185)))));
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(218)))), ((int)(((byte)(193)))));
            this.deleteBtn.Location = new System.Drawing.Point(197, 318);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(177, 47);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 435);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.boxTotalLbl);
            this.Controls.Add(this.referenceLbl);
            this.Controls.Add(this.boxTotalTxtBox);
            this.Controls.Add(this.referenceTxtBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox referenceTxtBox;
        private System.Windows.Forms.TextBox boxTotalTxtBox;
        private System.Windows.Forms.Label referenceLbl;
        private System.Windows.Forms.Label boxTotalLbl;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
    }
}