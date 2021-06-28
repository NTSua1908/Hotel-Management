﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management.Controller
{
    class BillController
    {
        KHACHSANEntities entities = new KHACHSANEntities();

        public dynamic getAll()
        {
            var data = from c in entities.CHITIETHOADONs
                       select new
                       {
                           ID = c.MAHOADON,
                           PaymentDay = c.HOADON.NGAYTHANHTOAN,
                           Value = c.HOADON.TRIGIA,
                           RentalDays = c.SONGAYTHUE,
                           RoomName = c.PHONG.TENPHONG,
                           RoomID = c.PHONG.MAPHONG,
                           UnitPrice = c.DONGIA,
                           CustomerID = c.HOADON.KHACHHANG.MAKHACHHANG,
                           CustomerName = c.HOADON.KHACHHANG.TENKHACHHANG,                                                     
                       };

            return data.ToList();
        }

        public void addBill(HOADON hd, CHITIETHOADON cthd)
        {
            entities.HOADONs.Add(hd);
            entities.SaveChanges();
            cthd.MAHOADON = hd.MAHOADON;
            entities.CHITIETHOADONs.Add(cthd);
            entities.SaveChanges();
        }

        public void updateBill(HOADON hd, CHITIETHOADON cthd)
        {
            HOADON h = entities.HOADONs.Find(hd.MAHOADON);
            CHITIETHOADON c = entities.CHITIETHOADONs.Where(x => x.MAHOADON == hd.MAHOADON).SingleOrDefault();
            h.NGAYTHANHTOAN = hd.NGAYTHANHTOAN;
            h.TRIGIA = hd.TRIGIA;
            cthd.DONGIA = c.DONGIA;
            cthd.SONGAYTHUE = c.SONGAYTHUE;
            cthd.MAPHONG = c.MAPHONG;
            h.MAKHACHHANG = hd.MAKHACHHANG;       
            entities.SaveChanges();
        }

        public void deleteBill(int ID)
        {
            //MessageBox.Show("" + ID);
            HOADON hd = entities.HOADONs.Find(ID);
            if (hd != null)
            {
                CHITIETHOADON ct = entities.CHITIETHOADONs.Where(p => p.MAHOADON == ID).SingleOrDefault();
                entities.CHITIETHOADONs.Remove(ct);
                entities.HOADONs.Remove(hd);
                entities.SaveChanges();
            }
        }
    }
}