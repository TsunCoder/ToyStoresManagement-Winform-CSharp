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

namespace ToyStoreManagement.Custom
{
    public partial class OrderToy : UserControl
    {
        int toyId, billId, billDetailsId;
        public OrderToy()
        {
            InitializeComponent();
        }

        //private int UpdateBillDetail(int quantity)
        //{
        //    BillDetails billDetails = new BillDetails();
        //    billDetails.ID = billdetailsId;
        //    billDetails.ID_HoaDon = billID;
        //    billDetails.SoLuong = quantity;

        //    BillDetailsBL bL = new BillDetailsBL();
        //    return bL.Update(BillDetails)

        //}

        public void initUI(string title, string date, int price, int quantity, int foodId, int billId, int billDetailId)
        {
            this.billDetailsId = billDetailId;
            this.toyId = foodId;
            this.billId = billId;

            lbTitle.Text = title;
            lbDate.Text = date;
            lbPrice.Text = (price * quantity).ToString();
            nmrCount.Text = quantity.ToString();
        }

        public int GetSoLuong()
        {
            return int.Parse(nmrCount.Text);
        }
    }
}
