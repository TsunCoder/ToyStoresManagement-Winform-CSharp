using BusinessLogic;
using DataAccess;
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
    public partial class SellForm : Form
    {
        public SellForm()
        {
            InitializeComponent();
        }

        public void LoadToys()
        {
            List<Toy> toys = new List<Toy>();
            flpToyList.Controls.Clear();

            ToyBL toyBL = new ToyBL();
            toys = toyBL.GetAll();

            foreach (var toy in toys)
            {
                var item = new Custom.ToyDetails();
                item.LoadToy(toy.TenDoChoi, toy.GiaBan, toy.HinhAnh, toy);
                flpToyList.Controls.Add(item);
            }
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            LoadToys();
        }
    }
}
