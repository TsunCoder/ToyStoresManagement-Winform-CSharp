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
            this.lbTitle = new Guna.UI.WinForms.GunaLabel();
            this.nmrCount = new Guna.UI.WinForms.GunaNumeric();
            this.lbPrice = new Guna.UI.WinForms.GunaLabel();
            this.pbDelete = new Guna.UI.WinForms.GunaPictureBox();
            this.gunaLinePanel1 = new Guna.UI.WinForms.GunaLinePanel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).BeginInit();
            this.gunaLinePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 9.2F, System.Drawing.FontStyle.Bold);
            this.lbTitle.Location = new System.Drawing.Point(62, 25);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(89, 21);
            this.lbTitle.TabIndex = 6;
            this.lbTitle.Text = "Title order";
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
            this.nmrCount.Location = new System.Drawing.Point(366, 33);
            this.nmrCount.Maximum = ((long)(9999999));
            this.nmrCount.Minimum = ((long)(0));
            this.nmrCount.Name = "nmrCount";
            this.nmrCount.Radius = 5;
            this.nmrCount.Size = new System.Drawing.Size(75, 30);
            this.nmrCount.TabIndex = 0;
            this.nmrCount.Text = "1";
            this.nmrCount.Value = ((long)(1));
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.Location = new System.Drawing.Point(100, 46);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(65, 23);
            this.lbPrice.TabIndex = 4;
            this.lbPrice.Text = "25.000";
            // 
            // pbDelete
            // 
            this.pbDelete.BaseColor = System.Drawing.Color.White;
            this.pbDelete.Image = global::ToyStoreManagement.Properties.Resources.add;
            this.pbDelete.Location = new System.Drawing.Point(14, 25);
            this.pbDelete.Name = "pbDelete";
            this.pbDelete.Size = new System.Drawing.Size(42, 42);
            this.pbDelete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDelete.TabIndex = 8;
            this.pbDelete.TabStop = false;
            // 
            // gunaLinePanel1
            // 
            this.gunaLinePanel1.BackColor = System.Drawing.Color.White;
            this.gunaLinePanel1.Controls.Add(this.label1);
            this.gunaLinePanel1.Controls.Add(this.nmrCount);
            this.gunaLinePanel1.Controls.Add(this.lbPrice);
            this.gunaLinePanel1.Controls.Add(this.pbDelete);
            this.gunaLinePanel1.Controls.Add(this.lbTitle);
            this.gunaLinePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaLinePanel1.LineBottom = 3;
            this.gunaLinePanel1.LineColor = System.Drawing.Color.DeepSkyBlue;
            this.gunaLinePanel1.LineLeft = 3;
            this.gunaLinePanel1.LineRight = 3;
            this.gunaLinePanel1.LineStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaLinePanel1.LineTop = 3;
            this.gunaLinePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaLinePanel1.Name = "gunaLinePanel1";
            this.gunaLinePanel1.Size = new System.Drawing.Size(485, 99);
            this.gunaLinePanel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Giá:";
            // 
            // OrderToy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaLinePanel1);
            this.Name = "OrderToy";
            this.Size = new System.Drawing.Size(485, 99);
            ((System.ComponentModel.ISupportInitialize)(this.pbDelete)).EndInit();
            this.gunaLinePanel1.ResumeLayout(false);
            this.gunaLinePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaLabel lbTitle;
        private Guna.UI.WinForms.GunaNumeric nmrCount;
        private Guna.UI.WinForms.GunaLabel lbPrice;
        private Guna.UI.WinForms.GunaPictureBox pbDelete;
        private Guna.UI.WinForms.GunaLinePanel gunaLinePanel1;
        private System.Windows.Forms.Label label1;
    }
}
