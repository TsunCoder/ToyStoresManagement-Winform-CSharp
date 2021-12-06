﻿using DataAccess;
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
    public partial class ToyDetails : UserControl
    {
        private Toy currentToy;
        public ToyDetails()
        {
            InitializeComponent();
        }

        public void LoadToy(string name, int price, string img, Toy toy)
        {
            this.currentToy = toy;
            lbNameToy.Text = name;
            lbPrice.Text = price.ToString();
            this.BackgroundImage = Image.FromFile(img);
        }
    }
}