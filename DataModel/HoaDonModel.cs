﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModel
{
    public class HoaDonModel
    {
        public int MaHoaDon { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public DateTime NgayTao { get; set; }
        public List<ChiTietHoaDonModel> list_json_chitiethoadon { get; set; }
    }

    public class ChiTietHoaDonModel
    {
        public int MaChiTietHoaDon { get; set; }
        public int MaHoaDon { get; set; }
        public int MaSanPham { get; set; }
        public int SoLuong { get; set; }
        public double Gia { get; set; }
    }
}