
namespace ToyStoreManagement
{
    partial class CustomerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.dgvDSCustomer = new Guna.UI.WinForms.GunaDataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnSreach = new Guna.UI.WinForms.GunaButton();
            this.txtSDTCustomer = new Guna.UI.WinForms.GunaTextBox();
            this.txtNameCustomer = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCustomer)).BeginInit();
            this.panel1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.gunaGroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1261, 726);
            this.panel2.TabIndex = 3;
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.dgvDSCustomer);
            this.gunaGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGroupBox1.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Radius = 15;
            this.gunaGroupBox1.Size = new System.Drawing.Size(1261, 726);
            this.gunaGroupBox1.TabIndex = 0;
            this.gunaGroupBox1.Text = "Danh sách khách hàng";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(400, 5);
            // 
            // dgvDSCustomer
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvDSCustomer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDSCustomer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSCustomer.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgvDSCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDSCustomer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSCustomer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDSCustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDSCustomer.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDSCustomer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDSCustomer.EnableHeadersVisualStyles = false;
            this.dgvDSCustomer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCustomer.Location = new System.Drawing.Point(13, 45);
            this.dgvDSCustomer.Name = "dgvDSCustomer";
            this.dgvDSCustomer.RowHeadersVisible = false;
            this.dgvDSCustomer.RowHeadersWidth = 51;
            this.dgvDSCustomer.RowTemplate.Height = 24;
            this.dgvDSCustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSCustomer.Size = new System.Drawing.Size(1248, 669);
            this.dgvDSCustomer.TabIndex = 0;
            this.dgvDSCustomer.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgvDSCustomer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCustomer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDSCustomer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDSCustomer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDSCustomer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDSCustomer.ThemeStyle.BackColor = System.Drawing.Color.LightGray;
            this.dgvDSCustomer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDSCustomer.ThemeStyle.HeaderStyle.Height = 4;
            this.dgvDSCustomer.ThemeStyle.ReadOnly = false;
            this.dgvDSCustomer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDSCustomer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDSCustomer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDSCustomer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDSCustomer.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDSCustomer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDSCustomer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.gunaGroupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1261, 122);
            this.panel1.TabIndex = 2;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.White;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.btnSreach);
            this.gunaGroupBox2.Controls.Add(this.txtSDTCustomer);
            this.gunaGroupBox2.Controls.Add(this.txtNameCustomer);
            this.gunaGroupBox2.Controls.Add(this.label3);
            this.gunaGroupBox2.Controls.Add(this.label2);
            this.gunaGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGroupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.gunaGroupBox2.ForeColor = System.Drawing.Color.White;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(223)))), ((int)(((byte)(231)))));
            this.gunaGroupBox2.Location = new System.Drawing.Point(0, 0);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Radius = 20;
            this.gunaGroupBox2.Size = new System.Drawing.Size(1261, 122);
            this.gunaGroupBox2.TabIndex = 1;
            this.gunaGroupBox2.Text = "Tìm kiếm";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(430, 4);
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
            this.btnSreach.Location = new System.Drawing.Point(1109, 39);
            this.btnSreach.Name = "btnSreach";
            this.btnSreach.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSreach.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSreach.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSreach.OnHoverImage = null;
            this.btnSreach.OnPressedColor = System.Drawing.Color.Black;
            this.btnSreach.Radius = 20;
            this.btnSreach.Size = new System.Drawing.Size(68, 57);
            this.btnSreach.TabIndex = 14;
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
            this.txtSDTCustomer.Location = new System.Drawing.Point(719, 50);
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
            this.txtNameCustomer.Location = new System.Drawing.Point(205, 50);
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
            this.label3.Location = new System.Drawing.Point(564, 56);
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
            this.label2.Location = new System.Drawing.Point(34, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên khách hàng";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1261, 854);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.panel2.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSCustomer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaDataGridView dgvDSCustomer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaButton btnSreach;
        private Guna.UI.WinForms.GunaTextBox txtSDTCustomer;
        private Guna.UI.WinForms.GunaTextBox txtNameCustomer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}