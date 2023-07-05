﻿using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fAddNguoiDung : Form
    {
        public fAddNguoiDung()
        {
            InitializeComponent();
        }
        private void Bind()
        {
            var dsNND = BUSNhomNguoiDung.Instance.GetAllNhomNguoiDung();
            foreach(var n in dsNND)
            {
                n.TenNhomNguoiDung = n.TenNhomNguoiDung + "(" + n.MaNhomNguoiDung + ")";
            }
            comboNhomND.DataSource = dsNND;
            comboNhomND.ValueMember = "id";
            comboNhomND.DisplayMember = "TenNhomNguoiDung";
        }
    }
}
