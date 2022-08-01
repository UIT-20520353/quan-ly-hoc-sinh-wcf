using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using DTO;

namespace BUS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IBUS_HocSinh" in both code and config file together.
    [ServiceContract]
    public interface IBUS_HocSinh
    {
        [OperationContract]
        DataTable LayDanhSachHocSinh();
        [OperationContract]
        bool ThemHocSinh(DTO_HocSinh hs);
        [OperationContract]
        bool XoaHocSinh(string id);
        [OperationContract]
        bool SuaHocSinh(DTO_HocSinh hs);
    }
}
