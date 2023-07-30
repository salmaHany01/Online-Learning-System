﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineLearningSystem.AdminService {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AdminService.AdminSrvSoap")]
    public interface AdminSrvSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addCourse", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void addCourse(string name, string prof, string desc, int price, string duration, int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addCourse", ReplyAction="*")]
        System.Threading.Tasks.Task addCourseAsync(string name, string prof, string desc, int price, string duration, int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCourses2", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable getCourses2();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCourses2", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> getCourses2Async();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCourses", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        OnlineLearningSystem.AdminService.Courses[] getCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/getCourses", ReplyAction="*")]
        System.Threading.Tasks.Task<OnlineLearningSystem.AdminService.Courses[]> getCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateCourse", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void updateCourse(int id, string name, string prof, string desc, int price, string duration, int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateCourse", ReplyAction="*")]
        System.Threading.Tasks.Task updateCourseAsync(int id, string name, string prof, string desc, int price, string duration, int rating);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteCourse", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        void deleteCourse(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteCourse", ReplyAction="*")]
        System.Threading.Tasks.Task deleteCourseAsync(int id);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9037.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class Courses : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int idField;
        
        private string nameField;
        
        private string profField;
        
        private string descField;
        
        private int priceField;
        
        private string durationField;
        
        private int ratingField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int id {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
                this.RaisePropertyChanged("id");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
                this.RaisePropertyChanged("name");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string prof {
            get {
                return this.profField;
            }
            set {
                this.profField = value;
                this.RaisePropertyChanged("prof");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string desc {
            get {
                return this.descField;
            }
            set {
                this.descField = value;
                this.RaisePropertyChanged("desc");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int price {
            get {
                return this.priceField;
            }
            set {
                this.priceField = value;
                this.RaisePropertyChanged("price");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
                this.RaisePropertyChanged("duration");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public int rating {
            get {
                return this.ratingField;
            }
            set {
                this.ratingField = value;
                this.RaisePropertyChanged("rating");
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
    public interface AdminSrvSoapChannel : OnlineLearningSystem.AdminService.AdminSrvSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AdminSrvSoapClient : System.ServiceModel.ClientBase<OnlineLearningSystem.AdminService.AdminSrvSoap>, OnlineLearningSystem.AdminService.AdminSrvSoap {
        
        public AdminSrvSoapClient() {
        }
        
        public AdminSrvSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AdminSrvSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminSrvSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AdminSrvSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void addCourse(string name, string prof, string desc, int price, string duration, int rating) {
            base.Channel.addCourse(name, prof, desc, price, duration, rating);
        }
        
        public System.Threading.Tasks.Task addCourseAsync(string name, string prof, string desc, int price, string duration, int rating) {
            return base.Channel.addCourseAsync(name, prof, desc, price, duration, rating);
        }
        
        public System.Data.DataTable getCourses2() {
            return base.Channel.getCourses2();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> getCourses2Async() {
            return base.Channel.getCourses2Async();
        }
        
        public OnlineLearningSystem.AdminService.Courses[] getCourses() {
            return base.Channel.getCourses();
        }
        
        public System.Threading.Tasks.Task<OnlineLearningSystem.AdminService.Courses[]> getCoursesAsync() {
            return base.Channel.getCoursesAsync();
        }
        
        public void updateCourse(int id, string name, string prof, string desc, int price, string duration, int rating) {
            base.Channel.updateCourse(id, name, prof, desc, price, duration, rating);
        }
        
        public System.Threading.Tasks.Task updateCourseAsync(int id, string name, string prof, string desc, int price, string duration, int rating) {
            return base.Channel.updateCourseAsync(id, name, prof, desc, price, duration, rating);
        }
        
        public void deleteCourse(int id) {
            base.Channel.deleteCourse(id);
        }
        
        public System.Threading.Tasks.Task deleteCourseAsync(int id) {
            return base.Channel.deleteCourseAsync(id);
        }
    }
}
