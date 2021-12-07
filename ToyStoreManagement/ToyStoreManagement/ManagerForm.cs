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
using BusinessLogic;
using DataAccess;

namespace ToyStoreManagement
{

    public partial class ManagerFrm : Form
    {
        List<Toy> listToy = new List<Toy>();
        List<TypeToy> listType = new List<TypeToy>();
        Toy ToyCurrent = new Toy();
        string imgLocation = "";
        byte[] img = null;

        public ManagerFrm()
        {
            InitializeComponent();
        }

        private void btnChooseImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open File Image";
            dlg.FileName = "Hãy chọn File";
            dlg.Filter = "Image Files (JPEG, GIF, BMP, etc.)|"
                            + ".jpg;.jpeg;*.gif;*.bmp;"
                            + ".tif;.tiff;*.png|"
                            + "JPEG files (.jpg;.jpeg)|*.jpg;*.jpeg|"
                            + "GIF files (.gif)|.gif|"
                            + "BMP files (.bmp)|.bmp|"
                            + "TIFF files (.tif;.tiff)|*.tif;*.tiff|"
                            + "PNG files (.png)|.png|"
                            + "All files (.)|*.*";

            dlg.InitialDirectory = Environment.CurrentDirectory;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dlg.FileName.ToString();
                pbImg.ImageLocation = imgLocation;
            }
        }
        public void LoadToyDataToDGV()
        {
            ToyBL toyBL = new ToyBL();
            listToy = toyBL.GetAll();
            int count = 1;
            lvToy.Items.Clear();
            foreach(var toy in listToy)
            {
                ListViewItem item = lvToy.Items.Add(count.ToString());
                item.SubItems.Add(toy.TenDoChoi);
               // string toyName = listType.Find(x => x.Id == toy.ID_Loai).TenLoai;
                item.SubItems.Add(toy.TenDoChoi);
                item.SubItems.Add(toy.DoTuoi);
                item.SubItems.Add(toy.XuatXu);
                item.SubItems.Add(toy.ThuongHieu);
                item.SubItems.Add(toy.SoLuong.ToString());
                item.SubItems.Add(toy.GiaBan.ToString());
                item.SubItems.Add(toy.GiaNhap.ToString());

                count++;


            }
        }

        private void lvToy_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvToy.Items.Count; i++)
            {
                if (lvToy.Items[i].Selected)
                {
                    ToyCurrent = listToy[i];
                    txtToyId.Text = ToyCurrent.Id.ToString();
                    txtToyName.Text = ToyCurrent.TenDoChoi;
                    txtGiaBan.Text = ToyCurrent.GiaBan.ToString();
                    txtGiaNhap.Text = ToyCurrent.GiaNhap.ToString();
                    txtAge.Text = ToyCurrent.DoTuoi;
                    txtNhaCC.Text = ToyCurrent.ThuongHieu;
                    txtXX.Text = ToyCurrent.XuatXu;
                    txtSoLuong.Text = ToyCurrent.SoLuong.ToString();
                    cbbType.SelectedValue = ToyCurrent.ID_Loai;
                    //LoadImg
                    if (ToyCurrent.HinhAnh == null)
                    {
                        pbImg.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(ToyCurrent.HinhAnh);
                        pbImg.Image = Image.FromStream(ms);
                    }
                    
                }
            }

        }
        private void LoadTypeToLV()
        {
            TypeBL typeBL = new TypeBL();
            listType = typeBL.GetAll();
            cbbType.DataSource = listType;
            cbbType.ValueMember = "ID";
            cbbType.DisplayMember = "TenLoai";
        }

        private void ManagerFrm_Load(object sender, EventArgs e)
        {
            LoadToyDataToDGV();
            LoadTypeToLV();
        }
    
      
        public int UpdateToy()
        {
            Toy toy = ToyCurrent;
            if (txtGiaBan.Text == "" || txtToyName.Text == "" || txtGiaNhap.Text == "" || txtXX.Text == "" || txtNhaCC.Text == "" || txtAge.Text == "")
            {
                MessageBox.Show("Chưa nhập dữ liệu cho các ô");
            }
            else
            {
                int giaban = 0;
                try
                {
                    giaban = int.Parse(txtGiaBan.Text);
                }
                catch
                {
                    giaban = 0;
                }
                int gianhap = 0;
                try
                {
                    gianhap = int.Parse(txtGiaNhap.Text);
                }
                catch
                {
                    giaban = 0;
                }
                int soluong = 0;
                try
                {
                    soluong = int.Parse(txtSoLuong.Text);
                }
                catch
                {
                    soluong = 0;
                }
                toy.GiaBan = giaban;
                toy.GiaNhap = gianhap;
                toy.SoLuong = soluong;
                toy.TenDoChoi = txtToyName.Text;
                toy.ThuongHieu = txtNhaCC.Text;
                toy.XuatXu = txtXX.Text;
                toy.DoTuoi = txtAge.Text;
                toy.ID_Loai = int.Parse(cbbType.SelectedValue.ToString());
                //Hình ảnh
                
                FileStream stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
                BinaryReader binary = new BinaryReader(stream);
                img = binary.ReadBytes((int)stream.Length);
                toy.HinhAnh = img;
              

                ToyBL toyBL = new ToyBL();
                return toyBL.Update(toy);

                
            }
            return -1;
                
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            int result = UpdateToy();
            if(result > 0)
            {
                MessageBox.Show("Cập nhật dữ liệu thành công");
                LoadToyDataToDGV();
            }
            else
            {
                MessageBox.Show("Cập nhật không thành công. Vui lòng kiểm tra lại");
            }
            

        }
    }
}
