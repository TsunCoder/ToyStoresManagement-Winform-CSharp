
namespace ToyStoreManagement
{
    partial class MainForm
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
            this.pn_Menu = new Guna.UI.WinForms.GunaPanel();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.btnCustomer = new Guna.UI.WinForms.GunaButton();
            this.btnStatistic = new Guna.UI.WinForms.GunaButton();
            this.btnBills = new Guna.UI.WinForms.GunaButton();
            this.btnLogout = new Guna.UI.WinForms.GunaButton();
            this.btnManager = new Guna.UI.WinForms.GunaButton();
            this.btnSell = new Guna.UI.WinForms.GunaButton();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.pnlTong = new System.Windows.Forms.Panel();
            this.pn_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pn_Menu
            // 
            this.pn_Menu.BackColor = System.Drawing.Color.White;
            this.pn_Menu.Controls.Add(this.lblNameUser);
            this.pn_Menu.Controls.Add(this.gunaPictureBox1);
            this.pn_Menu.Controls.Add(this.btnCustomer);
            this.pn_Menu.Controls.Add(this.btnStatistic);
            this.pn_Menu.Controls.Add(this.btnBills);
            this.pn_Menu.Controls.Add(this.btnLogout);
            this.pn_Menu.Controls.Add(this.btnManager);
            this.pn_Menu.Controls.Add(this.btnSell);
            this.pn_Menu.Controls.Add(this.gunaSeparator1);
            this.pn_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Menu.Location = new System.Drawing.Point(0, 0);
            this.pn_Menu.Name = "pn_Menu";
            this.pn_Menu.Size = new System.Drawing.Size(269, 854);
            this.pn_Menu.TabIndex = 0;
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Location = new System.Drawing.Point(88, 126);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(57, 16);
            this.lblNameUser.TabIndex = 8;
            this.lblNameUser.Text = "thienson";
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::ToyStoreManagement.Properties.Resources.user;
            this.gunaPictureBox1.Location = new System.Drawing.Point(80, 42);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(79, 67);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox1.TabIndex = 7;
            this.gunaPictureBox1.TabStop = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.AnimationHoverSpeed = 0.07F;
            this.btnCustomer.AnimationSpeed = 0.03F;
            this.btnCustomer.BaseColor = System.Drawing.Color.White;
            this.btnCustomer.BorderColor = System.Drawing.Color.Black;
            this.btnCustomer.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.btnCustomer.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnCustomer.Image = global::ToyStoreManagement.Properties.Resources.group_users;
            this.btnCustomer.ImageOffsetX = 5;
            this.btnCustomer.ImageSize = new System.Drawing.Size(30, 30);
            this.btnCustomer.Location = new System.Drawing.Point(21, 460);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnCustomer.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCustomer.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCustomer.OnHoverImage = null;
            this.btnCustomer.OnPressedColor = System.Drawing.Color.Black;
            this.btnCustomer.Size = new System.Drawing.Size(219, 55);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnStatistic
            // 
            this.btnStatistic.AnimationHoverSpeed = 0.07F;
            this.btnStatistic.AnimationSpeed = 0.03F;
            this.btnStatistic.BaseColor = System.Drawing.Color.White;
            this.btnStatistic.BorderColor = System.Drawing.Color.Black;
            this.btnStatistic.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnStatistic.FocusedColor = System.Drawing.Color.Empty;
            this.btnStatistic.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnStatistic.Image = global::ToyStoreManagement.Properties.Resources.bar_chart;
            this.btnStatistic.ImageOffsetX = 5;
            this.btnStatistic.ImageSize = new System.Drawing.Size(30, 30);
            this.btnStatistic.Location = new System.Drawing.Point(21, 399);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnStatistic.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnStatistic.OnHoverForeColor = System.Drawing.Color.White;
            this.btnStatistic.OnHoverImage = null;
            this.btnStatistic.OnPressedColor = System.Drawing.Color.Black;
            this.btnStatistic.Size = new System.Drawing.Size(219, 55);
            this.btnStatistic.TabIndex = 5;
            this.btnStatistic.Text = "Statistic";
            this.btnStatistic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBills
            // 
            this.btnBills.AnimationHoverSpeed = 0.07F;
            this.btnBills.AnimationSpeed = 0.03F;
            this.btnBills.BaseColor = System.Drawing.Color.White;
            this.btnBills.BorderColor = System.Drawing.Color.Black;
            this.btnBills.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBills.FocusedColor = System.Drawing.Color.Empty;
            this.btnBills.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnBills.Image = global::ToyStoreManagement.Properties.Resources.bill;
            this.btnBills.ImageOffsetX = 5;
            this.btnBills.ImageSize = new System.Drawing.Size(30, 30);
            this.btnBills.Location = new System.Drawing.Point(21, 338);
            this.btnBills.Name = "btnBills";
            this.btnBills.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnBills.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBills.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBills.OnHoverImage = null;
            this.btnBills.OnPressedColor = System.Drawing.Color.Black;
            this.btnBills.Size = new System.Drawing.Size(219, 55);
            this.btnBills.TabIndex = 4;
            this.btnBills.Text = "Bills";
            this.btnBills.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationHoverSpeed = 0.07F;
            this.btnLogout.AnimationSpeed = 0.03F;
            this.btnLogout.BaseColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.Black;
            this.btnLogout.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogout.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogout.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnLogout.Image = global::ToyStoreManagement.Properties.Resources.sign_out;
            this.btnLogout.ImageOffsetX = 5;
            this.btnLogout.ImageSize = new System.Drawing.Size(30, 30);
            this.btnLogout.Location = new System.Drawing.Point(21, 679);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnLogout.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogout.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogout.OnHoverImage = null;
            this.btnLogout.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogout.Size = new System.Drawing.Size(219, 55);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Log out";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnManager
            // 
            this.btnManager.AnimationHoverSpeed = 0.07F;
            this.btnManager.AnimationSpeed = 0.03F;
            this.btnManager.BackColor = System.Drawing.Color.Transparent;
            this.btnManager.BaseColor = System.Drawing.Color.White;
            this.btnManager.BorderColor = System.Drawing.Color.Black;
            this.btnManager.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnManager.FocusedColor = System.Drawing.Color.Empty;
            this.btnManager.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManager.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnManager.Image = global::ToyStoreManagement.Properties.Resources.data_management;
            this.btnManager.ImageOffsetX = 5;
            this.btnManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btnManager.Location = new System.Drawing.Point(21, 270);
            this.btnManager.Name = "btnManager";
            this.btnManager.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnManager.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnManager.OnHoverForeColor = System.Drawing.Color.White;
            this.btnManager.OnHoverImage = null;
            this.btnManager.OnPressedColor = System.Drawing.Color.Black;
            this.btnManager.Size = new System.Drawing.Size(219, 55);
            this.btnManager.TabIndex = 2;
            this.btnManager.Text = "Manager";
            this.btnManager.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnSell
            // 
            this.btnSell.AnimationHoverSpeed = 0.07F;
            this.btnSell.AnimationSpeed = 0.03F;
            this.btnSell.BaseColor = System.Drawing.Color.White;
            this.btnSell.BorderColor = System.Drawing.Color.Black;
            this.btnSell.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSell.FocusedColor = System.Drawing.Color.Empty;
            this.btnSell.Font = new System.Drawing.Font("Book Antiqua", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.btnSell.Image = global::ToyStoreManagement.Properties.Resources.add;
            this.btnSell.ImageOffsetX = 5;
            this.btnSell.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSell.Location = new System.Drawing.Point(21, 209);
            this.btnSell.Name = "btnSell";
            this.btnSell.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.btnSell.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSell.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSell.OnHoverImage = null;
            this.btnSell.OnPressedColor = System.Drawing.Color.Black;
            this.btnSell.Size = new System.Drawing.Size(219, 55);
            this.btnSell.TabIndex = 1;
            this.btnSell.Text = "Sell";
            this.btnSell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.Silver;
            this.gunaSeparator1.Location = new System.Drawing.Point(12, 164);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(238, 11);
            this.gunaSeparator1.TabIndex = 0;
            // 
            // pnlTong
            // 
            this.pnlTong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTong.BackColor = System.Drawing.Color.White;
            this.pnlTong.Location = new System.Drawing.Point(275, 0);
            this.pnlTong.Name = "pnlTong";
            this.pnlTong.Size = new System.Drawing.Size(1272, 854);
            this.pnlTong.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1548, 854);
            this.Controls.Add(this.pnlTong);
            this.Controls.Add(this.pn_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pn_Menu.ResumeLayout(false);
            this.pn_Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaPanel pn_Menu;
        private Guna.UI.WinForms.GunaButton btnSell;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private Guna.UI.WinForms.GunaButton btnManager;
        private Guna.UI.WinForms.GunaButton btnLogout;
        private Guna.UI.WinForms.GunaButton btnCustomer;
        private Guna.UI.WinForms.GunaButton btnStatistic;
        private Guna.UI.WinForms.GunaButton btnBills;
        private System.Windows.Forms.Label lblNameUser;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Panel pnlTong;
    }
}