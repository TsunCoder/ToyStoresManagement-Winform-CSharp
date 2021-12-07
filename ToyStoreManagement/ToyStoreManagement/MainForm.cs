using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToyStoreManagement
{

    public partial class MainForm : Form
    {
        private Form activeForm;
        private GunaButton currentButton;
        public MainForm()
        {
            InitializeComponent();
        }

        private const int CS_DropShadow = 0x00020000;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DropShadow;
                return cp;
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in pn_Menu.Controls)
            {
                if (previousBtn.GetType() == typeof(GunaButton))
                {
                    previousBtn.BackColor = Color.FromArgb(0, 117, 214);
                    previousBtn.ForeColor = Color.Gainsboro;
                    //
                }

            }
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (GunaButton)btnSender)
                {
                    DisableButton();
                    Color color = new Color();
                    currentButton = (GunaButton)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.Black;
                    //currentButton.Font = new System.Drawing.Font("Bernard MT Condensed", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {

            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlTong.Controls.Add(childForm);
            this.pnlTong.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SellForm frm = new SellForm();
            frm.TopLevel = false;
            pnlTong.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SellForm(), sender);
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManagerFrm(), sender);
        }

        private void btnBills_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BillsForm(), sender);

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CustomerForm(), sender);
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new StatisticForm(), sender);
        }
    }
}
