﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CourseManagementSystemClient.TeacherService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Teacher", Namespace="http://schemas.datacontract.org/2004/07/CourseManagementSystemWCF")]
    [System.SerializableAttribute()]
    public partial class Teacher : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TeacherIdField;
        
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
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
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
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TeacherId {
            get {
                return this.TeacherIdField;
            }
            set {
                if ((this.TeacherIdField.Equals(value) != true)) {
                    this.TeacherIdField = value;
                    this.RaisePropertyChanged("TeacherId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TeacherService.ITeacherService")]
    public interface ITeacherService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/GetTeacherByUsername", ReplyAction="http://tempuri.org/ITeacherService/GetTeacherByUsernameResponse")]
        CourseManagementSystemClient.TeacherService.Teacher GetTeacherByUsername(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/GetTeacherByUsername", ReplyAction="http://tempuri.org/ITeacherService/GetTeacherByUsernameResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher> GetTeacherByUsernameAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/GetTeacherById", ReplyAction="http://tempuri.org/ITeacherService/GetTeacherByIdResponse")]
        CourseManagementSystemClient.TeacherService.Teacher GetTeacherById(int teacherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/GetTeacherById", ReplyAction="http://tempuri.org/ITeacherService/GetTeacherByIdResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher> GetTeacherByIdAsync(int teacherId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/getAllTeachers", ReplyAction="http://tempuri.org/ITeacherService/getAllTeachersResponse")]
        CourseManagementSystemClient.TeacherService.Teacher[] getAllTeachers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/getAllTeachers", ReplyAction="http://tempuri.org/ITeacherService/getAllTeachersResponse")]
        System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher[]> getAllTeachersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/AddTeacher", ReplyAction="http://tempuri.org/ITeacherService/AddTeacherResponse")]
        bool AddTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/AddTeacher", ReplyAction="http://tempuri.org/ITeacherService/AddTeacherResponse")]
        System.Threading.Tasks.Task<bool> AddTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/UpdateTeacher", ReplyAction="http://tempuri.org/ITeacherService/UpdateTeacherResponse")]
        bool UpdateTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/UpdateTeacher", ReplyAction="http://tempuri.org/ITeacherService/UpdateTeacherResponse")]
        System.Threading.Tasks.Task<bool> UpdateTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/DeleteTeacher", ReplyAction="http://tempuri.org/ITeacherService/DeleteTeacherResponse")]
        bool DeleteTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/DeleteTeacher", ReplyAction="http://tempuri.org/ITeacherService/DeleteTeacherResponse")]
        System.Threading.Tasks.Task<bool> DeleteTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/LoginTeacher", ReplyAction="http://tempuri.org/ITeacherService/LoginTeacherResponse")]
        bool LoginTeacher(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ITeacherService/LoginTeacher", ReplyAction="http://tempuri.org/ITeacherService/LoginTeacherResponse")]
        System.Threading.Tasks.Task<bool> LoginTeacherAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ITeacherServiceChannel : CourseManagementSystemClient.TeacherService.ITeacherService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TeacherServiceClient : System.ServiceModel.ClientBase<CourseManagementSystemClient.TeacherService.ITeacherService>, CourseManagementSystemClient.TeacherService.ITeacherService {
        
        public TeacherServiceClient() {
        }
        
        public TeacherServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TeacherServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeacherServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TeacherServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public CourseManagementSystemClient.TeacherService.Teacher GetTeacherByUsername(string username) {
            return base.Channel.GetTeacherByUsername(username);
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher> GetTeacherByUsernameAsync(string username) {
            return base.Channel.GetTeacherByUsernameAsync(username);
        }
        
        public CourseManagementSystemClient.TeacherService.Teacher GetTeacherById(int teacherId) {
            return base.Channel.GetTeacherById(teacherId);
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher> GetTeacherByIdAsync(int teacherId) {
            return base.Channel.GetTeacherByIdAsync(teacherId);
        }
        
        public CourseManagementSystemClient.TeacherService.Teacher[] getAllTeachers() {
            return base.Channel.getAllTeachers();
        }
        
        public System.Threading.Tasks.Task<CourseManagementSystemClient.TeacherService.Teacher[]> getAllTeachersAsync() {
            return base.Channel.getAllTeachersAsync();
        }
        
        public bool AddTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.AddTeacher(teacher);
        }
        
        public System.Threading.Tasks.Task<bool> AddTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.AddTeacherAsync(teacher);
        }
        
        public bool UpdateTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.UpdateTeacher(teacher);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.UpdateTeacherAsync(teacher);
        }
        
        public bool DeleteTeacher(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.DeleteTeacher(teacher);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteTeacherAsync(CourseManagementSystemClient.TeacherService.Teacher teacher) {
            return base.Channel.DeleteTeacherAsync(teacher);
        }
        
        public bool LoginTeacher(string username, string password) {
            return base.Channel.LoginTeacher(username, password);
        }
        
        public System.Threading.Tasks.Task<bool> LoginTeacherAsync(string username, string password) {
            return base.Channel.LoginTeacherAsync(username, password);
        }
    }
}
