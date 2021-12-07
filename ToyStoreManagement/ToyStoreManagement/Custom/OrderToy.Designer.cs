namespace ToyStoreManagement.Custom
{
    partial class OrderToy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nmrCount = new Guna.UI.WinForms.GunaNumeric();
            this.lbDate = new Guna.UI.WinForms.GunaLabel();
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.pbDelete = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLinePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // nmrCount
            // 
            this.nmrCount.BackColor = System.Drawing.Color.Transparent;
            this.nmrCount.BaseColor = System.Drawing.Color.White;
            this.nmrCount.BorderColor = System.Drawing.Color.Tomato;
            this.nmrCount.ButtonColor = System.Drawing.Color.Tomato;
            this.nmrCount.ButtonForeColor = System.Drawing.Color.White;
            this.nmrCount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nmrCount.ForeColor = System.Drawing.Color.Black;
            this.nmrCount.Location = new System.Drawing.Point(261, 35);
            this.nmrCount.Maximum = ((long)(9999999));
            this.nmrCount.Minimum = ((long)(0));
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Radius = 5;
            this.nmrCount.Size = new System.Drawing.Size(75, 30);
            this.nmrCount.TabIndex = 0;
            this.nmrCount.Text = "1";
            this.nmrCount.Value = ((long)(1));
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lbDate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbDate.Location = new System.Drawing.Point(105, 62);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(96, 19);
            this.lbDate.TabIndex = 7;
            this.lbDate.Text = "@00/00/0000";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(105, 36);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 21);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Title order";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbPrice.Location = new System.Drawing.Point(363, 36);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(52, 20);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "25.000";
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.Controls.Add(this.pbDelete);
            this.gunaLinePanel1.Controls.Add(this.lbPrice);
            this.gunaLinePanel1.Controls.Add(this.nmrCount);
            this.gunaLinePanel1.LineBottom = 1;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.Gray;
            this.gunaLinePanel1.LineLeft = 1;
            this.gunaLinePanel1.LineRight = 1;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.Location = new System.Drawing.Point(1, 1);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(449, 104);
            this.gunaLinePanel1.TabIndex = 9;
            // 
            // pbDelete
            // 
            this.pbDelete.BaseColor = System.Drawing.Color.White;
            this.pbDelete.Image = global::ToyStoreManagement.Properties.Resources.add;
            this.pbDelete.Location = new System.Drawing.Point(36, 31);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(42, 42);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 8;
            this.pbDelete.TabStop = false;
            // 
            // OrderToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "OrderToy";
            this.Size = new System.Drawing.Size(450, 105);
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaNumeric nmrCount;
        private Guna.UI.WinForms.GunaPictureBox pbDelete;
        private Guna.UI.WinForms.GunaLabel lbDate;
        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
    }
}
