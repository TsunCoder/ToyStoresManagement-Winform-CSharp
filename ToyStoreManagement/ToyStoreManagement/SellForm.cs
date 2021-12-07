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

        public SellForm()
        {
            InitializeComponent();
        }
<<<<<<< HEAD
        public void GetDataToFLP()
        {
             toyBL = new ToyBL();
            listToy = toyBL.GetAll();

            foreach (var toy in listToy)
            {
                

                PictureBox pic = new PictureBox();
                pic.Width = 180;
                pic.Height = 200;
                pic.BackgroundImageLayout = ImageLayout.Stretch;
                pic.Tag = toy;
                pic.Click += Pic_Click;
               


                if (toy.HinhAnh != null)
                {
                    MemoryStream ms = new MemoryStream(toy.HinhAnh);
                    Bitmap bmp = new Bitmap(ms);
                    pic.BackgroundImage = bmp;

                }
                else
                {
                    Image img = new Bitmap(@"C:\Users\Nhat Huy\Desktop\LTCSDL\ToyStoresManagement-Winform-CSharp\Resources\x.jpg");
                    pic.BackgroundImage = img;
                }
                //Giá bán
                price = new Label();
                price.Text = toy.GiaBan.ToString();
                price.BackColor = Color.FromArgb(113, 223, 231);
                price.ForeColor = Color.White;
                price.TextAlign = ContentAlignment.MiddleCenter;
                price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                price.Size = new System.Drawing.Size(100, 25);
                price.Location = new System.Drawing.Point(80, 180);
                //Tên
                name = new Label();
                name.Text = toy.TenDoChoi;
                name.BackColor = Color.FromArgb(113, 223, 231);
                name.ForeColor = Color.White;
                name.TextAlign = ContentAlignment.MiddleCenter;
                name.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                name.Size = new System.Drawing.Size(150, 25);
                name.Tag = toy;
               

                //ID
                ID = new Label();
                ID.Text = toy.Id.ToString();

                //Button
                /*btnAdd = new Button();
                btnAdd.Text = "Add";
                btnAdd.Tag = toy.Id;*/
                
               
                
                pic.Controls.Add(btnAdd);
                pic.Controls.Add(name);
                pic.Controls.Add(price);
                flpDsToy.Controls.Add(pic);



            }

        }

        private void Pic_Click(object sender, EventArgs e)
        {
            int toy= (sender as Toy).Id;

            Panel panel = new Panel();
            panel.Width = 100;
            panel.Height = 30;

            //Giá bán
            price = new Label();
           // price.Text = toy.GiaBan.ToString();
            price.BackColor = Color.FromArgb(113, 223, 231);
            price.ForeColor = Color.White;
            price.TextAlign = ContentAlignment.MiddleCenter;
            price.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           // price.Size = new System.Drawing.Size(100, 25);
            //price.Location = new System.Drawing.Point(80, 180);

            panel.Controls.Add(price);
            flpToyOder.Controls.Add(panel);
            throw new NotImplementedException();
        }

        /* private void btnAddToBills_Click(object sender, EventArgs e)
{


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
            GetDataToFLP();
        }

        
=======

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
>>>>>>> 84b3e4a6c807ef13b7a7cdc4f83af91917b03ede
    }

}
