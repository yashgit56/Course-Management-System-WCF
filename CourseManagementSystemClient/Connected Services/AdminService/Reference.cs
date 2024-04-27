﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManagementSystemClient.AdminService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Admin", Namespace="http://schemas.datacontract.org/2004/07/CourseManagementSystemWCF")]
    [System.SerializableAttribute()]
    public partial class Admin : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AdminIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UsernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AdminId {
            get {
                return this.AdminIdField;
            }
            set {
                if ((this.AdminIdField.Equals(value) != true)) {
                    this.AdminIdField = value;
                    this.RaisePropertyChanged("AdminId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username {
            get {
                return this.UsernameField;
            }
            set {
                if ((object.ReferenceEquals(this.UsernameField, value) != true)) {
                    this.UsernameField = value;
                    this.RaisePropertyChanged("Username");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.IAdminService")]
    public interface IAdminService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminByUsername", ReplyAction="http://tempuri.org/IAdminService/GetAdminByUsernameResponse")]
        CourseManagementSystemClient.AdminService.Admin GetAdminByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminByUsername", ReplyAction="http://tempuri.org/IAdminService/GetAdminByUsernameResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin> GetAdminByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminByAdminId", ReplyAction="http://tempuri.org/IAdminService/GetAdminByAdminIdResponse")]
        CourseManagementSystemClient.AdminService.Admin GetAdminByAdminId(int adminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAdminByAdminId", ReplyAction="http://tempuri.org/IAdminService/GetAdminByAdminIdResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin> GetAdminByAdminIdAsync(int adminId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllAdmins", ReplyAction="http://tempuri.org/IAdminService/GetAllAdminsResponse")]
        CourseManagementSystemClient.AdminService.Admin[] GetAllAdmins();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/GetAllAdmins", ReplyAction="http://tempuri.org/IAdminService/GetAllAdminsResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin[]> GetAllAdminsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/LoginAdmin", ReplyAction="http://tempuri.org/IAdminService/LoginAdminResponse")]
        bool LoginAdmin(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAdminService/LoginAdmin", ReplyAction="http://tempuri.org/IAdminService/LoginAdminResponse")]
        System.Threading.Tasks.Task<bool> LoginAdminAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAdminServiceChannel : CourseManagementSystemClient.AdminService.IAdminService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminServiceClient : System.ServiceModel.ClientBase<CourseManagementSystemClient.AdminService.IAdminService>, CourseManagementSystemClient.AdminService.IAdminService {
        
        public AdminServiceClient() {
        }
        
        public AdminServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CourseManagementSystemClient.AdminService.Admin GetAdminByUsername(string username) {
            return base.Channel.GetAdminByUsername(username);
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin> GetAdminByUsernameAsync(string username) {
            return base.Channel.GetAdminByUsernameAsync(username);
        }
        
        public CourseManagementSystemClient.AdminService.Admin GetAdminByAdminId(int adminId) {
            return base.Channel.GetAdminByAdminId(adminId);
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin> GetAdminByAdminIdAsync(int adminId) {
            return base.Channel.GetAdminByAdminIdAsync(adminId);
        }
        
        public CourseManagementSystemClient.AdminService.Admin[] GetAllAdmins() {
            return base.Channel.GetAllAdmins();
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.AdminService.Admin[]> GetAllAdminsAsync() {
            return base.Channel.GetAllAdminsAsync();
        }
        
        public bool LoginAdmin(string username, string password) {
            return base.Channel.LoginAdmin(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAdminAsync(string username, string password) {
            return base.Channel.LoginAdminAsync(username, password);
        }
    }
}
