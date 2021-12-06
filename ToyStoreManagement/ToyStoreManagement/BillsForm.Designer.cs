
namespace ToyStoreManagement
{
    partial class BillsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BillsForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grbox = new Guna.UI.WinForms.GunaGroupBox();
            this.btnSreach = new Guna.UI.WinForms.GunaButton();
            this.dtpToTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFromTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.txtSDTCustomer = new Guna.UI.WinForms.GunaTextBox();
            this.txtNameCustomer = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvDSHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.grbox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.grbox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 242);
            this.panel1.TabIndex = 0;
            // 
            // grbox
            // 
            this.grbox.BackColor = System.Drawing.Color.Transparent;
            this.grbox.BaseColor = System.Drawing.Color.White;
            this.grbox.BorderColor = System.Drawing.Color.Gainsboro;
            this.grbox.Controls.Add(this.btnSreach);
            this.grbox.Controls.Add(this.dtpToTime);
            this.grbox.Controls.Add(this.dtpFromTime);
            this.grbox.Controls.Add(this.txtSDTCustomer);
            this.grbox.Controls.Add(this.txtNameCustomer);
            this.grbox.Controls.Add(this.label3);
            this.grbox.Controls.Add(this.label2);
            this.grbox.Controls.Add(this.label1);
            this.grbox.Controls.Add(this.label5);
            this.grbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbox.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.grbox.ForeColor = System.Drawing.Color.White;
            this.grbox.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.grbox.Location = new System.Drawing.Point(0, 0);
            this.grbox.Name = "grbox";
            this.grbox.Radius = 20;
            this.grbox.Size = new System.Drawing.Size(1261, 242);
            this.grbox.TabIndex = 0;
            this.grbox.Text = "Tìm kiếm";
            this.grbox.TextLocation = new System.Drawing.Point(430, 4);
            // 
            // btnSreach
            // 
            this.btnSreach.AnimationHoverSpeed = 0.07F;
            this.btnSreach.AnimationSpeed = 0.03F;
            this.btnSreach.BackColor = System.Drawing.Color.Transparent;
            this.btnSreach.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnSreach.BorderColor = System.Drawing.Color.Black;
            this.btnSreach.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSreach.FocusedColor = System.Drawing.Color.Empty;
            this.btnSreach.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSreach.ForeColor = System.Drawing.Color.White;
            this.btnSreach.Image = ((System.Drawing.Image)(resources.GetObject("btnSreach.Image")));
            this.btnSreach.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSreach.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSreach.Location = new System.Drawing.Point(1110, 57);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSreach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSreach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSreach.OnHoverImage = null;
            this.btnSreach.OnPressedColor = System.Drawing.Color.Black;
            this.btnSreach.Radius = 20;
            this.btnSreach.Size = new System.Drawing.Size(68, 57);
            this.btnSreach.TabIndex = 16;
            // 
            // dtpToTime
            // 
            this.dtpToTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpToTime.BaseColor = System.Drawing.Color.White;
            this.dtpToTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.dtpToTime.BorderSize = 1;
            this.dtpToTime.CustomFormat = "dd/MM/yyyy";
            this.dtpToTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpToTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpToTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpToTime.ForeColor = System.Drawing.Color.Black;
            this.dtpToTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToTime.Location = new System.Drawing.Point(272, 97);
            this.dtpToTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpToTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpToTime.Name = "dtpToTime";
            this.dtpToTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpToTime.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpToTime.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpToTime.OnPressedColor = System.Drawing.Color.Black;
            this.dtpToTime.Radius = 5;
            this.dtpToTime.Size = new System.Drawing.Size(280, 35);
            this.dtpToTime.TabIndex = 15;
            this.dtpToTime.Text = "05/12/2021";
            this.dtpToTime.Value = new System.DateTime(2021, 12, 5, 15, 48, 58, 327);
            // 
            // dtpFromTime
            // 
            this.dtpFromTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpFromTime.BaseColor = System.Drawing.Color.White;
            this.dtpFromTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.dtpFromTime.BorderSize = 1;
            this.dtpFromTime.CustomFormat = "dd/MM/yyyy";
            this.dtpFromTime.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFromTime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFromTime.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtpFromTime.ForeColor = System.Drawing.Color.Black;
            this.dtpFromTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromTime.Location = new System.Drawing.Point(272, 46);
            this.dtpFromTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFromTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFromTime.Name = "dtpFromTime";
            this.dtpFromTime.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpFromTime.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFromTime.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpFromTime.OnPressedColor = System.Drawing.Color.Black;
            this.dtpFromTime.Radius = 5;
            this.dtpFromTime.Size = new System.Drawing.Size(280, 35);
            this.dtpFromTime.TabIndex = 14;
            this.dtpFromTime.Text = "05/12/2021";
            this.dtpFromTime.Value = new System.DateTime(2021, 12, 5, 15, 48, 58, 327);
            // 
            // txtSDTCustomer
            // 
            this.txtSDTCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtSDTCustomer.BaseColor = System.Drawing.Color.White;
            this.txtSDTCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtSDTCustomer.BorderSize = 1;
            this.txtSDTCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDTCustomer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSDTCustomer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDTCustomer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDTCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDTCustomer.Location = new System.Drawing.Point(751, 97);
            this.txtSDTCustomer.Name = "txtSDTCustomer";
            this.txtSDTCustomer.PasswordChar = '\0';
            this.txtSDTCustomer.Radius = 5;
            this.txtSDTCustomer.SelectedText = "";
            this.txtSDTCustomer.Size = new System.Drawing.Size(310, 33);
            this.txtSDTCustomer.TabIndex = 13;
            // 
            // txtNameCustomer
            // 
            this.txtNameCustomer.BackColor = System.Drawing.Color.Transparent;
            this.txtNameCustomer.BaseColor = System.Drawing.Color.White;
            this.txtNameCustomer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtNameCustomer.BorderSize = 1;
            this.txtNameCustomer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameCustomer.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNameCustomer.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNameCustomer.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNameCustomer.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCustomer.Location = new System.Drawing.Point(751, 46);
            this.txtNameCustomer.Name = "txtNameCustomer";
            this.txtNameCustomer.PasswordChar = '\0';
            this.txtNameCustomer.Radius = 5;
            this.txtNameCustomer.SelectedText = "";
            this.txtNameCustomer.Size = new System.Drawing.Size(310, 33);
            this.txtNameCustomer.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(578, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(578, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(155, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Đến ngày";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(155, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Lập từ ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaGroupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 606);
            this.panel2.TabIndex = 1;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.gunaGroupBox2.Controls.Add(this.dgvDSHoaDon);
            this.gunaGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 20;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1261, 606);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Danh sách hóa đơn";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(400, 4);
            // 
            // dgvDSHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSHoaDon.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDSHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSHoaDon.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDSHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSHoaDon.Location = new System.Drawing.Point(13, 45);
            this.dgvDSHoaDon.Name = "dgvDSHoaDon";
            this.dgvDSHoaDon.RowHeadersVisible = false;
            this.dgvDSHoaDon.RowHeadersWidth = 51;
            this.dgvDSHoaDon.RowTemplate.Height = 24;
            this.dgvDSHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSHoaDon.Size = new System.Drawing.Size(1245, 549);
            this.dgvDSHoaDon.TabIndex = 0;
            this.dgvDSHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDSHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSHoaDon.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvDSHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSHoaDon.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDSHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // BillsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BillsForm";
            this.Text = "BillsForm";
            this.panel1.ResumeLayout(false);
            this.grbox.ResumeLayout(false);
            this.grbox.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGroupBox grbox;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaDataGridView dgvDSHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtSDTCustomer;
        private Guna.UI.WinForms.GunaTextBox txtNameCustomer;
        private Guna.UI.WinForms.GunaDateTimePicker dtpToTime;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFromTime;
        private Guna.UI.WinForms.GunaButton btnSreach;
    }
}