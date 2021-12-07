using DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ToyStoreManagement.SellForm;

namespace ToyStoreManagement.Custom
{
    public partial class ToyDetails : UserControl
    {
        private Toy toyCurrent;
        public ReceiveToys send;
        public ToyDetails()
        {
            InitializeComponent();
        }

        public ToyDetails(ReceiveToys sender)
        {
            InitializeComponent();
            this.send = sender;
        }

        public void LoadToy(string name, int price, Toy toy)
        {
            this.toyCurrent = toy;
            lblPrice.Text = price.ToString();
            lbToyName.Text = name;
            MemoryStream ms = new MemoryStream(toyCurrent.HinhAnh);
            ptbImageToy.Image = Image.FromStream(ms);
            btnValid.Visible = true;

        }

        private void btnValid_Click(object sender, EventArgs e)
        {
            this.send(toyCurrent);
        }
    }
}
