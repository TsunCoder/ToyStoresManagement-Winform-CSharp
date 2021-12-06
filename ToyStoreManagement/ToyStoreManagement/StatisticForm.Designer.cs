
namespace ToyStoreManagement
{
    partial class StatisticForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSreach = new Guna.UI.WinForms.GunaGroupBox();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.dtpToTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.dtpFromTime = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtProfit = new Guna.UI.WinForms.GunaTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalRevenue = new Guna.UI.WinForms.GunaTextBox();
            this.txtAmountDc = new Guna.UI.WinForms.GunaTextBox();
            this.txtCost = new Guna.UI.WinForms.GunaTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCountBills = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDsHoaDon = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1.SuspendLayout();
            this.btnSreach.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnSreach);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 156);
            this.panel1.TabIndex = 0;
            // 
            // btnSreach
            // 
            this.btnSreach.BackColor = System.Drawing.Color.Transparent;
            this.btnSreach.BaseColor = System.Drawing.Color.White;
            this.btnSreach.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSreach.Controls.Add(this.gunaButton1);
            this.btnSreach.Controls.Add(this.dtpToTime);
            this.btnSreach.Controls.Add(this.dtpFromTime);
            this.btnSreach.Controls.Add(this.label1);
            this.btnSreach.Controls.Add(this.label5);
            this.btnSreach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSreach.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnSreach.ForeColor = System.Drawing.Color.White;
            this.btnSreach.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.btnSreach.Location = new System.Drawing.Point(0, 0);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.Radius = 20;
            this.btnSreach.Size = new System.Drawing.Size(1261, 156);
            this.btnSreach.TabIndex = 1;
            this.btnSreach.Text = "Tìm kiếm";
            this.btnSreach.TextLocation = new System.Drawing.Point(430, 4);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(1110, 57);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Radius = 20;
            this.gunaButton1.Size = new System.Drawing.Size(68, 57);
            this.gunaButton1.TabIndex = 16;
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
            this.dtpToTime.Location = new System.Drawing.Point(699, 70);
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
            this.dtpFromTime.Location = new System.Drawing.Point(230, 70);
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(586, 75);
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
            this.label5.Location = new System.Drawing.Point(102, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = " Từ ngày";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaGroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 162);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 692);
            this.panel2.TabIndex = 1;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.txtProfit);
            this.gunaGroupBox1.Controls.Add(this.label7);
            this.gunaGroupBox1.Controls.Add(this.txtTotalRevenue);
            this.gunaGroupBox1.Controls.Add(this.txtAmountDc);
            this.gunaGroupBox1.Controls.Add(this.txtCost);
            this.gunaGroupBox1.Controls.Add(this.label6);
            this.gunaGroupBox1.Controls.Add(this.label4);
            this.gunaGroupBox1.Controls.Add(this.label3);
            this.gunaGroupBox1.Controls.Add(this.txtCountBills);
            this.gunaGroupBox1.Controls.Add(this.label2);
            this.gunaGroupBox1.Controls.Add(this.dgvDsHoaDon);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(1261, 692);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Thống kê doanh thu";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(400, 5);
            // 
            // txtProfit
            // 
            this.txtProfit.BackColor = System.Drawing.Color.Transparent;
            this.txtProfit.BaseColor = System.Drawing.Color.White;
            this.txtProfit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtProfit.BorderSize = 1;
            this.txtProfit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProfit.FocusedBaseColor = System.Drawing.Color.White;
            this.txtProfit.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtProfit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtProfit.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(487, 232);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.PasswordChar = '\0';
            this.txtProfit.Radius = 5;
            this.txtProfit.SelectedText = "";
            this.txtProfit.Size = new System.Drawing.Size(310, 33);
            this.txtProfit.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(231, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 23);
            this.label7.TabIndex = 20;
            this.label7.Text = "LỢI NHUẬN";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.txtTotalRevenue.BaseColor = System.Drawing.Color.White;
            this.txtTotalRevenue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtTotalRevenue.BorderSize = 1;
            this.txtTotalRevenue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotalRevenue.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTotalRevenue.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTotalRevenue.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTotalRevenue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalRevenue.Location = new System.Drawing.Point(487, 193);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.PasswordChar = '\0';
            this.txtTotalRevenue.Radius = 5;
            this.txtTotalRevenue.SelectedText = "";
            this.txtTotalRevenue.Size = new System.Drawing.Size(310, 33);
            this.txtTotalRevenue.TabIndex = 19;
            // 
            // txtAmountDc
            // 
            this.txtAmountDc.BackColor = System.Drawing.Color.Transparent;
            this.txtAmountDc.BaseColor = System.Drawing.Color.White;
            this.txtAmountDc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtAmountDc.BorderSize = 1;
            this.txtAmountDc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAmountDc.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAmountDc.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAmountDc.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAmountDc.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountDc.Location = new System.Drawing.Point(487, 147);
            this.txtAmountDc.Name = "txtAmountDc";
            this.txtAmountDc.PasswordChar = '\0';
            this.txtAmountDc.Radius = 5;
            this.txtAmountDc.SelectedText = "";
            this.txtAmountDc.Size = new System.Drawing.Size(310, 33);
            this.txtAmountDc.TabIndex = 18;
            // 
            // txtCost
            // 
            this.txtCost.BackColor = System.Drawing.Color.Transparent;
            this.txtCost.BaseColor = System.Drawing.Color.White;
            this.txtCost.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtCost.BorderSize = 1;
            this.txtCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCost.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCost.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCost.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCost.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCost.Location = new System.Drawing.Point(487, 97);
            this.txtCost.Name = "txtCost";
            this.txtCost.PasswordChar = '\0';
            this.txtCost.Radius = 5;
            this.txtCost.SelectedText = "";
            this.txtCost.Size = new System.Drawing.Size(310, 33);
            this.txtCost.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(227, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Tổng tiền khuyến mãi";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(226, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tổng doanh thu bán hàng";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(228, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "Chi phí nhập hàng";
            // 
            // txtCountBills
            // 
            this.txtCountBills.BackColor = System.Drawing.Color.Transparent;
            this.txtCountBills.BaseColor = System.Drawing.Color.White;
            this.txtCountBills.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtCountBills.BorderSize = 1;
            this.txtCountBills.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCountBills.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCountBills.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCountBills.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCountBills.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCountBills.Location = new System.Drawing.Point(487, 49);
            this.txtCountBills.Name = "txtCountBills";
            this.txtCountBills.PasswordChar = '\0';
            this.txtCountBills.Radius = 5;
            this.txtCountBills.SelectedText = "";
            this.txtCountBills.Size = new System.Drawing.Size(310, 33);
            this.txtCountBills.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(231, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Số đơn hàng";
            // 
            // dgvDsHoaDon
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDsHoaDon.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDsHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDsHoaDon.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDsHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDsHoaDon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsHoaDon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDsHoaDon.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDsHoaDon.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDsHoaDon.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDsHoaDon.EnableHeadersVisualStyles = false;
            this.dgvDsHoaDon.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsHoaDon.Location = new System.Drawing.Point(12, 288);
            this.dgvDsHoaDon.Name = "dgvDsHoaDon";
            this.dgvDsHoaDon.RowHeadersVisible = false;
            this.dgvDsHoaDon.RowHeadersWidth = 51;
            this.dgvDsHoaDon.RowTemplate.Height = 24;
            this.dgvDsHoaDon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDsHoaDon.Size = new System.Drawing.Size(1249, 392);
            this.dgvDsHoaDon.TabIndex = 0;
            this.dgvDsHoaDon.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDsHoaDon.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsHoaDon.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDsHoaDon.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDsHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDsHoaDon.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDsHoaDon.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvDsHoaDon.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDsHoaDon.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDsHoaDon.ThemeStyle.ReadOnly = false;
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDsHoaDon.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1261, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatisticForm";
            this.Text = "StatisticForm";
            this.panel1.ResumeLayout(false);
            this.btnSreach.ResumeLayout(false);
            this.btnSreach.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDsHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvDsHoaDon;
        private Guna.UI.WinForms.GunaGroupBox btnSreach;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaDateTimePicker dtpToTime;
        private Guna.UI.WinForms.GunaDateTimePicker dtpFromTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txtProfit;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox txtTotalRevenue;
        private Guna.UI.WinForms.GunaTextBox txtAmountDc;
        private Guna.UI.WinForms.GunaTextBox txtCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaTextBox txtCountBills;
    }
}