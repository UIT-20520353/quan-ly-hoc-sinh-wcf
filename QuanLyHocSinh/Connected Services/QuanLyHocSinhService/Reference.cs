﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyHocSinh.QuanLyHocSinhService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="QuanLyHocSinhService.IBUS_HocSinh")]
    public interface IBUS_HocSinh {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/LayDanhSachHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/LayDanhSachHocSinhResponse")]
        System.Data.DataTable LayDanhSachHocSinh();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/LayDanhSachHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/LayDanhSachHocSinhResponse")]
        System.Threading.Tasks.Task<System.Data.DataTable> LayDanhSachHocSinhAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/ThemHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/ThemHocSinhResponse")]
        bool ThemHocSinh(DTO.DTO_HocSinh hs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/ThemHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/ThemHocSinhResponse")]
        System.Threading.Tasks.Task<bool> ThemHocSinhAsync(DTO.DTO_HocSinh hs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/XoaHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/XoaHocSinhResponse")]
        bool XoaHocSinh(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/XoaHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/XoaHocSinhResponse")]
        System.Threading.Tasks.Task<bool> XoaHocSinhAsync(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/SuaHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/SuaHocSinhResponse")]
        bool SuaHocSinh(DTO.DTO_HocSinh hs);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBUS_HocSinh/SuaHocSinh", ReplyAction="http://tempuri.org/IBUS_HocSinh/SuaHocSinhResponse")]
        System.Threading.Tasks.Task<bool> SuaHocSinhAsync(DTO.DTO_HocSinh hs);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBUS_HocSinhChannel : QuanLyHocSinh.QuanLyHocSinhService.IBUS_HocSinh, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BUS_HocSinhClient : System.ServiceModel.ClientBase<QuanLyHocSinh.QuanLyHocSinhService.IBUS_HocSinh>, QuanLyHocSinh.QuanLyHocSinhService.IBUS_HocSinh {
        
        public BUS_HocSinhClient() {
        }
        
        public BUS_HocSinhClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BUS_HocSinhClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BUS_HocSinhClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BUS_HocSinhClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable LayDanhSachHocSinh() {
            return base.Channel.LayDanhSachHocSinh();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> LayDanhSachHocSinhAsync() {
            return base.Channel.LayDanhSachHocSinhAsync();
        }
        
        public bool ThemHocSinh(DTO.DTO_HocSinh hs) {
            return base.Channel.ThemHocSinh(hs);
        }
        
        public System.Threading.Tasks.Task<bool> ThemHocSinhAsync(DTO.DTO_HocSinh hs) {
            return base.Channel.ThemHocSinhAsync(hs);
        }
        
        public bool XoaHocSinh(string id) {
            return base.Channel.XoaHocSinh(id);
        }
        
        public System.Threading.Tasks.Task<bool> XoaHocSinhAsync(string id) {
            return base.Channel.XoaHocSinhAsync(id);
        }
        
        public bool SuaHocSinh(DTO.DTO_HocSinh hs) {
            return base.Channel.SuaHocSinh(hs);
        }
        
        public System.Threading.Tasks.Task<bool> SuaHocSinhAsync(DTO.DTO_HocSinh hs) {
            return base.Channel.SuaHocSinhAsync(hs);
        }
    }
}
