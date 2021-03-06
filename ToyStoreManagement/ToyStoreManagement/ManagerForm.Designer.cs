namespace ToyStoreManagement
{
    partial class ManagerFrm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.lvToy = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Age = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.XuatXu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThuongHieu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaBan = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaNhap = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4 = new System.Windows.Forms.Panel();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPictureBox2 = new Guna.UI.WinForms.GunaPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.txtToyId = new Guna.UI.WinForms.GunaTextBox();
            this.cbbType = new Guna.UI.WinForms.GunaComboBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnChooseImg = new Guna.UI.WinForms.GunaButton();
            this.txtGiaNhap = new Guna.UI.WinForms.GunaTextBox();
            this.txtGiaBan = new Guna.UI.WinForms.GunaTextBox();
            this.txtSoLuong = new Guna.UI.WinForms.GunaTextBox();
            this.txtAge = new Guna.UI.WinForms.GunaTextBox();
            this.txtNhaCC = new Guna.UI.WinForms.GunaTextBox();
            this.txtXX = new Guna.UI.WinForms.GunaTextBox();
            this.txtToyName = new Guna.UI.WinForms.GunaTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImg = new Guna.UI.WinForms.GunaPictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaGroupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 363);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 491);
            this.panel1.TabIndex = 0;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.lvToy);
            this.gunaGroupBox1.Controls.Add(this.panel4);
            this.gunaGroupBox1.Controls.Add(this.panel3);
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(3, 3);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 20;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1258, 485);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Danh sách đồ chơi";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(400, 4);
            // 
            // lvToy
            // 
            this.lvToy.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.name,
            this.Type,
            this.Age,
            this.XuatXu,
            this.ThuongHieu,
            this.SoLuong,
            this.GiaBan,
            this.GiaNhap});
            this.lvToy.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvToy.FullRowSelect = true;
            this.lvToy.GridLines = true;
            this.lvToy.HideSelection = false;
            this.lvToy.Location = new System.Drawing.Point(-3, 95);
            this.lvToy.Name = "lvToy";
            this.lvToy.Size = new System.Drawing.Size(1261, 393);
            this.lvToy.TabIndex = 10;
            this.lvToy.UseCompatibleStateImageBehavior = false;
            this.lvToy.View = System.Windows.Forms.View.Details;
            this.lvToy.Click += new System.EventHandler(this.lvToy_Click);
            // 
            // ID
            // 
            this.ID.Text = "Mã đồ chơi";
            this.ID.Width = 103;
            // 
            // name
            // 
            this.name.Text = "Tên đồ chơi";
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name.Width = 130;
            // 
            // Type
            // 
            this.Type.Text = "Loại";
            this.Type.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Type.Width = 86;
            // 
            // Age
            // 
            this.Age.Text = "Độ tuổi";
            this.Age.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Age.Width = 115;
            // 
            // XuatXu
            // 
            this.XuatXu.Text = "Xuất xứ";
            this.XuatXu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.XuatXu.Width = 125;
            // 
            // ThuongHieu
            // 
            this.ThuongHieu.Text = "Thương hiệu";
            this.ThuongHieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ThuongHieu.Width = 132;
            // 
            // SoLuong
            // 
            this.SoLuong.Text = "Số lượng";
            this.SoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoLuong.Width = 110;
            // 
            // GiaBan
            // 
            this.GiaBan.Text = "Giá bán";
            this.GiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaBan.Width = 107;
            // 
            // GiaNhap
            // 
            this.GiaNhap.Text = "Giá Nhập";
            this.GiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.GiaNhap.Width = 111;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.gunaComboBox2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(870, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(376, 45);
            this.panel4.TabIndex = 9;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Items.AddRange(new object[] {
            "Tên",
            "Giá",
            "Số lượng tồn"});
            this.gunaComboBox2.Location = new System.Drawing.Point(197, 8);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Radius = 5;
            this.gunaComboBox2.Size = new System.Drawing.Size(137, 28);
            this.gunaComboBox2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(98, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sắp Xếp";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.gunaComboBox1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.gunaPictureBox2);
            this.panel3.Location = new System.Drawing.Point(12, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(606, 50);
            this.panel3.TabIndex = 8;
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Tên",
            "Giá",
            "Số lượng tồn"});
            this.gunaComboBox1.Location = new System.Drawing.Point(430, 12);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Radius = 5;
            this.gunaComboBox1.Size = new System.Drawing.Size(137, 28);
            this.gunaComboBox1.TabIndex = 3;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Book Antiqua", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(56, 11);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 10;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(357, 31);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Text = "Search";
            this.txtSearch.TextOffsetX = 20;
            // 
            // gunaPictureBox2
            // 
            this.gunaPictureBox2.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox2.Image = global::ToyStoreManagement.Properties.Resources.search;
            this.gunaPictureBox2.Location = new System.Drawing.Point(17, 10);
            this.gunaPictureBox2.Name = "gunaPictureBox2";
            this.gunaPictureBox2.Size = new System.Drawing.Size(30, 28);
            this.gunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gunaPictureBox2.TabIndex = 2;
            this.gunaPictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaGroupBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 357);
            this.panel2.TabIndex = 1;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.txtToyId);
            this.gunaGroupBox2.Controls.Add(this.cbbType);
            this.gunaGroupBox2.Controls.Add(this.btnSave);
            this.gunaGroupBox2.Controls.Add(this.btnChooseImg);
            this.gunaGroupBox2.Controls.Add(this.txtGiaNhap);
            this.gunaGroupBox2.Controls.Add(this.txtGiaBan);
            this.gunaGroupBox2.Controls.Add(this.txtSoLuong);
            this.gunaGroupBox2.Controls.Add(this.txtAge);
            this.gunaGroupBox2.Controls.Add(this.txtNhaCC);
            this.gunaGroupBox2.Controls.Add(this.txtXX);
            this.gunaGroupBox2.Controls.Add(this.txtToyName);
            this.gunaGroupBox2.Controls.Add(this.label10);
            this.gunaGroupBox2.Controls.Add(this.label9);
            this.gunaGroupBox2.Controls.Add(this.label8);
            this.gunaGroupBox2.Controls.Add(this.label7);
            this.gunaGroupBox2.Controls.Add(this.label6);
            this.gunaGroupBox2.Controls.Add(this.label5);
            this.gunaGroupBox2.Controls.Add(this.label4);
            this.gunaGroupBox2.Controls.Add(this.label3);
            this.gunaGroupBox2.Controls.Add(this.label1);
            this.gunaGroupBox2.Controls.Add(this.pbImg);
            this.gunaGroupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(3, 4);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 20;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1255, 350);
            this.gunaGroupBox2.TabIndex = 0;
            this.gunaGroupBox2.Text = "Thông tin đồ chơi";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(400, 4);
            // 
            // txtToyId
            // 
            this.txtToyId.BackColor = System.Drawing.Color.Transparent;
            this.txtToyId.BaseColor = System.Drawing.Color.White;
            this.txtToyId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtToyId.BorderSize = 1;
            this.txtToyId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToyId.FocusedBaseColor = System.Drawing.Color.White;
            this.txtToyId.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtToyId.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToyId.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToyId.Location = new System.Drawing.Point(433, 42);
            this.txtToyId.Name = "txtToyId";
            this.txtToyId.PasswordChar = '\0';
            this.txtToyId.Radius = 5;
            this.txtToyId.SelectedText = "";
            this.txtToyId.Size = new System.Drawing.Size(310, 33);
            this.txtToyId.TabIndex = 28;
            // 
            // cbbType
            // 
            this.cbbType.BackColor = System.Drawing.Color.Transparent;
            this.cbbType.BaseColor = System.Drawing.Color.White;
            this.cbbType.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.cbbType.BorderSize = 1;
            this.cbbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbType.FocusedColor = System.Drawing.Color.Empty;
            this.cbbType.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbType.ForeColor = System.Drawing.Color.Black;
            this.cbbType.FormattingEnabled = true;
            this.cbbType.Items.AddRange(new object[] {
            "Tên",
            "Giá",
            "Số lượng tồn"});
            this.cbbType.Location = new System.Drawing.Point(912, 42);
            this.cbbType.Name = "cbbType";
            this.cbbType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbType.Radius = 5;
            this.cbbType.Size = new System.Drawing.Size(292, 28);
            this.cbbType.TabIndex = 27;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(1084, 293);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 15;
            this.btnSave.Size = new System.Drawing.Size(120, 41);
            this.btnSave.TabIndex = 26;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnChooseImg
            // 
            this.btnChooseImg.AnimationHoverSpeed = 0.07F;
            this.btnChooseImg.AnimationSpeed = 0.03F;
            this.btnChooseImg.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseImg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(185)))), ((int)(((byte)(195)))));
            this.btnChooseImg.BorderColor = System.Drawing.Color.Black;
            this.btnChooseImg.BorderSize = 1;
            this.btnChooseImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChooseImg.FocusedColor = System.Drawing.Color.Empty;
            this.btnChooseImg.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnChooseImg.ForeColor = System.Drawing.Color.White;
            this.btnChooseImg.Image = null;
            this.btnChooseImg.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChooseImg.Location = new System.Drawing.Point(138, 293);
            this.btnChooseImg.Name = "btnChooseImg";
            this.btnChooseImg.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnChooseImg.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChooseImg.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChooseImg.OnHoverImage = null;
            this.btnChooseImg.OnPressedColor = System.Drawing.Color.Black;
            this.btnChooseImg.Radius = 15;
            this.btnChooseImg.Size = new System.Drawing.Size(120, 41);
            this.btnChooseImg.TabIndex = 25;
            this.btnChooseImg.Text = "Chọn ảnh";
            this.btnChooseImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChooseImg.Click += new System.EventHandler(this.btnChooseImg_Click);
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaNhap.BaseColor = System.Drawing.Color.White;
            this.txtGiaNhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtGiaNhap.BorderSize = 1;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGiaNhap.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaNhap.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGiaNhap.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaNhap.Location = new System.Drawing.Point(433, 129);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.PasswordChar = '\0';
            this.txtGiaNhap.Radius = 5;
            this.txtGiaNhap.SelectedText = "";
            this.txtGiaNhap.Size = new System.Drawing.Size(310, 33);
            this.txtGiaNhap.TabIndex = 21;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.Transparent;
            this.txtGiaBan.BaseColor = System.Drawing.Color.White;
            this.txtGiaBan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtGiaBan.BorderSize = 1;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.FocusedBaseColor = System.Drawing.Color.White;
            this.txtGiaBan.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaBan.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtGiaBan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaBan.Location = new System.Drawing.Point(912, 129);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.PasswordChar = '\0';
            this.txtGiaBan.Radius = 5;
            this.txtGiaBan.SelectedText = "";
            this.txtGiaBan.Size = new System.Drawing.Size(292, 33);
            this.txtGiaBan.TabIndex = 20;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.Transparent;
            this.txtSoLuong.BaseColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtSoLuong.BorderSize = 1;
            this.txtSoLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSoLuong.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSoLuong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSoLuong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSoLuong.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(912, 86);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.PasswordChar = '\0';
            this.txtSoLuong.Radius = 5;
            this.txtSoLuong.SelectedText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(292, 33);
            this.txtSoLuong.TabIndex = 19;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.Transparent;
            this.txtAge.BaseColor = System.Drawing.Color.White;
            this.txtAge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtAge.BorderSize = 1;
            this.txtAge.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAge.FocusedBaseColor = System.Drawing.Color.White;
            this.txtAge.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtAge.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAge.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(433, 215);
            this.txtAge.Name = "txtAge";
            this.txtAge.PasswordChar = '\0';
            this.txtAge.Radius = 5;
            this.txtAge.SelectedText = "";
            this.txtAge.Size = new System.Drawing.Size(310, 33);
            this.txtAge.TabIndex = 17;
            // 
            // txtNhaCC
            // 
            this.txtNhaCC.BackColor = System.Drawing.Color.Transparent;
            this.txtNhaCC.BaseColor = System.Drawing.Color.White;
            this.txtNhaCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtNhaCC.BorderSize = 1;
            this.txtNhaCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNhaCC.FocusedBaseColor = System.Drawing.Color.White;
            this.txtNhaCC.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtNhaCC.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNhaCC.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhaCC.Location = new System.Drawing.Point(433, 172);
            this.txtNhaCC.Name = "txtNhaCC";
            this.txtNhaCC.PasswordChar = '\0';
            this.txtNhaCC.Radius = 5;
            this.txtNhaCC.SelectedText = "";
            this.txtNhaCC.Size = new System.Drawing.Size(310, 33);
            this.txtNhaCC.TabIndex = 16;
            // 
            // txtXX
            // 
            this.txtXX.BackColor = System.Drawing.Color.Transparent;
            this.txtXX.BaseColor = System.Drawing.Color.White;
            this.txtXX.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtXX.BorderSize = 1;
            this.txtXX.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtXX.FocusedBaseColor = System.Drawing.Color.White;
            this.txtXX.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtXX.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtXX.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtXX.Location = new System.Drawing.Point(912, 170);
            this.txtXX.Name = "txtXX";
            this.txtXX.PasswordChar = '\0';
            this.txtXX.Radius = 5;
            this.txtXX.SelectedText = "";
            this.txtXX.Size = new System.Drawing.Size(292, 33);
            this.txtXX.TabIndex = 15;
            // 
            // txtToyName
            // 
            this.txtToyName.BackColor = System.Drawing.Color.Transparent;
            this.txtToyName.BaseColor = System.Drawing.Color.White;
            this.txtToyName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.txtToyName.BorderSize = 1;
            this.txtToyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtToyName.FocusedBaseColor = System.Drawing.Color.White;
            this.txtToyName.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtToyName.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtToyName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtToyName.Location = new System.Drawing.Point(433, 86);
            this.txtToyName.Name = "txtToyName";
            this.txtToyName.PasswordChar = '\0';
            this.txtToyName.Radius = 5;
            this.txtToyName.SelectedText = "";
            this.txtToyName.Size = new System.Drawing.Size(310, 33);
            this.txtToyName.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(296, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Thương Hiệu";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(792, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Loại";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(792, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 23);
            this.label8.TabIndex = 10;
            this.label8.Text = "Xuất xứ";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(296, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 23);
            this.label7.TabIndex = 9;
            this.label7.Text = "Độ tuổi";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(788, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "Số lượng tồn";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(296, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã số đồ chơi";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(297, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tên đồ chơi";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(299, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Giá nhập";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(792, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Giá bán";
            // 
            // pbImg
            // 
            this.pbImg.BaseColor = System.Drawing.Color.White;
            this.pbImg.Location = new System.Drawing.Point(10, 40);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(260, 237);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // ManagerFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagerFrm";
            this.Text = "Manager";
            this.Load += new System.EventHandler(this.ManagerFrm_Load);
            this.panel1.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox pbImg;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI.WinForms.GunaTextBox txtSoLuong;
        private Guna.UI.WinForms.GunaTextBox txtAge;
        private Guna.UI.WinForms.GunaTextBox txtNhaCC;
        private Guna.UI.WinForms.GunaTextBox txtXX;
        private Guna.UI.WinForms.GunaTextBox txtToyName;
        private Guna.UI.WinForms.GunaTextBox txtGiaNhap;
        private Guna.UI.WinForms.GunaTextBox txtGiaBan;
        private Guna.UI.WinForms.GunaButton btnChooseImg;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
        private System.Windows.Forms.ListView lvToy;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Age;
        private System.Windows.Forms.ColumnHeader XuatXu;
        private System.Windows.Forms.ColumnHeader ThuongHieu;
        private System.Windows.Forms.ColumnHeader SoLuong;
        private System.Windows.Forms.ColumnHeader GiaBan;
        private System.Windows.Forms.ColumnHeader GiaNhap;
        private Guna.UI.WinForms.GunaComboBox cbbType;
        private Guna.UI.WinForms.GunaTextBox txtToyId;
    }
}