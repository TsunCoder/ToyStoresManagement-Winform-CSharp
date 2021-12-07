using BusinessLogic;
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

namespace ToyStoreManagement
{
    public partial class SellForm : Form
    {
        List<Toy> listToy;
        ToyBL toyBL;
        private Label price;
        private Label name;
        private Label ID;
        private Button btnAdd;
        Toy ToyCurrent;
        private string curBill, curBillDetails;

        public delegate void ReceiveToys(Toy toy);

        public SellForm()
        {
            InitializeComponent();
        }

        private int InsertBillDetail(string billId, int toyId, int quantity)
        {
            BillDetailsBL bdBL = new BillDetailsBL();
            BillDetails bd = new BillDetails();
            if (billId == null) return -1;
            else
            {
                bd.ID = 0;
                bd.ID_HoaDon = int.Parse(billId);
                bd.ToyID = toyId;
                bd.SoLuong = quantity;
            }
            return bdBL.Insert(bd);
        }

        private void SetToy(Toy value)
        {
            var item = new Custom.OrderToy();

            InsertBillDetail(curBill, value.Id, item.GetSoLuong());
            item.initUI(value.TenDoChoi, value.GiaBan, 1, value.Id);
            flpToyOder.Controls.Add(item);

        }
        private void LoadToys()
        {
            List<Toy> toys = new List<Toy>();
            flpDsToy.Controls.Clear();

            ToyBL toyBL = new ToyBL();
            toys = toyBL.GetAll();

            foreach (var toy in toys)
            {
                var item = new Custom.ToyDetails(SetToy);
                item.LoadToy(toy.TenDoChoi, toy.GiaBan, toy);
                flpDsToy.Controls.Add(item);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            List<Toy> toys = new List<Toy>();

            flpDsToy.Controls.Clear();

            ToyBL toyBL = new ToyBL();

            toys = toyBL.Find(txtSearch.Text);
            foreach (var toy in toys)
            {
                var item = new Custom.ToyDetails(SetToy);
                item.LoadToy(toy.TenDoChoi, toy.GiaBan, toy);

                flpDsToy.Controls.Add(item);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
        }


        //private void Pic_Click(object sender, EventArgs e)
        //{
        //    int toy= (sender as Toy).Id;

        //    Panel panel = new Panel();
        //    panel.Width = 100;
        //    panel.Height = 30;

        //    //Giá bán
        //    price = new Label();
        //   // price.Text = toy.GiaBan.ToString();
        //    price.BackColor = Color.FromArgb(113, 223, 231);
        //    price.ForeColor = Color.White;
        //    price.TextAlign = ContentAlignment.MiddleCenter;
        //    price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //   // price.Size = new System.Drawing.Size(100, 25);
        //    //price.Location = new System.Drawing.Point(80, 180);

        //    panel.Controls.Add(price);
        //    flpToyOder.Controls.Add(panel);
        //    throw new NotImplementedException();
        //}

        /* private void btnAddToBills_Click(object sender, EventArgs e)
        //Giá bán
        price = new Label();
        price.Text = ToyCurrent.GiaBan.ToString();
        price.BackColor = Color.FromArgb(113, 223, 231);
        price.ForeColor = Color.White;
        price.TextAlign = ContentAlignment.MiddleCenter;
        price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        //price.Size = new System.Drawing.Size(100, 25);
        //price.Location = new System.Drawing.Point(80, 180);
        panel.Controls.Add(price);
        flpToyOder.Controls.Add(panel);
        }*/

        private void SellForm_Load(object sender, EventArgs e)
        {
            //GetDataToFLP();
            LoadToys();
        }

        
    }

}
