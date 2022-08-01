using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using DTO;
using DAL;

namespace BUS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BUS_HocSinh" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BUS_HocSinh.svc or BUS_HocSinh.svc.cs at the Solution Explorer and start debugging.
    public class BUS_HocSinh : IBUS_HocSinh
    {
        DAL_HocSinh dal = new DAL_HocSinh();
        public DataTable LayDanhSachHocSinh()
        {
            return dal.LayDanhSachHocSinh();
        }

        public bool ThemHocSinh(DTO_HocSinh hs)
        {
            return dal.ThemHocSinh(hs);
        }

        public bool XoaHocSinh(string id)
        {
            return dal.XoaHocSinh(id);
        }

        public bool SuaHocSinh(DTO_HocSinh hs)
        {
            return dal.SuaHocSinh(hs);
        }
    }
}
