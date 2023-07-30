﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnlineLearningSystem.userServiceRef {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/userService")]
    [System.SerializableAttribute()]
    public partial class Course : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string descField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string durationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int priceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string profField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ratingField;
        
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
        public string desc {
            get {
                return this.descField;
            }
            set {
                if ((object.ReferenceEquals(this.descField, value) != true)) {
                    this.descField = value;
                    this.RaisePropertyChanged("desc");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string duration {
            get {
                return this.durationField;
            }
            set {
                if ((object.ReferenceEquals(this.durationField, value) != true)) {
                    this.durationField = value;
                    this.RaisePropertyChanged("duration");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int price {
            get {
                return this.priceField;
            }
            set {
                if ((this.priceField.Equals(value) != true)) {
                    this.priceField = value;
                    this.RaisePropertyChanged("price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string prof {
            get {
                return this.profField;
            }
            set {
                if ((object.ReferenceEquals(this.profField, value) != true)) {
                    this.profField = value;
                    this.RaisePropertyChanged("prof");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int rating {
            get {
                return this.ratingField;
            }
            set {
                if ((this.ratingField.Equals(value) != true)) {
                    this.ratingField = value;
                    this.RaisePropertyChanged("rating");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="userServiceRef.IwcfUser")]
    public interface IwcfUser {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/RegisterUser", ReplyAction="http://tempuri.org/IwcfUser/RegisterUserResponse")]
        string RegisterUser(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/RegisterUser", ReplyAction="http://tempuri.org/IwcfUser/RegisterUserResponse")]
        System.Threading.Tasks.Task<string> RegisterUserAsync(string name, string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/LoginUser", ReplyAction="http://tempuri.org/IwcfUser/LoginUserResponse")]
        string LoginUser(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/LoginUser", ReplyAction="http://tempuri.org/IwcfUser/LoginUserResponse")]
        System.Threading.Tasks.Task<string> LoginUserAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/ViewCourses", ReplyAction="http://tempuri.org/IwcfUser/ViewCoursesResponse")]
        OnlineLearningSystem.userServiceRef.Course[] ViewCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/ViewCourses", ReplyAction="http://tempuri.org/IwcfUser/ViewCoursesResponse")]
        System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course[]> ViewCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/ViewCart", ReplyAction="http://tempuri.org/IwcfUser/ViewCartResponse")]
        OnlineLearningSystem.userServiceRef.Course[] ViewCart(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/ViewCart", ReplyAction="http://tempuri.org/IwcfUser/ViewCartResponse")]
        System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course[]> ViewCartAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/delete_item", ReplyAction="http://tempuri.org/IwcfUser/delete_itemResponse")]
        void delete_item(int course_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/delete_item", ReplyAction="http://tempuri.org/IwcfUser/delete_itemResponse")]
        System.Threading.Tasks.Task delete_itemAsync(int course_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/save_to_cart", ReplyAction="http://tempuri.org/IwcfUser/save_to_cartResponse")]
        void save_to_cart(int course_id, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/save_to_cart", ReplyAction="http://tempuri.org/IwcfUser/save_to_cartResponse")]
        System.Threading.Tasks.Task save_to_cartAsync(int course_id, int user_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/isValidCreditCard", ReplyAction="http://tempuri.org/IwcfUser/isValidCreditCardResponse")]
        bool isValidCreditCard(long cardNo, int secCode, int expMonth, int expYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/isValidCreditCard", ReplyAction="http://tempuri.org/IwcfUser/isValidCreditCardResponse")]
        System.Threading.Tasks.Task<bool> isValidCreditCardAsync(long cardNo, int secCode, int expMonth, int expYear);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/getEnrollmentDate_pattern", ReplyAction="http://tempuri.org/IwcfUser/getEnrollmentDate_patternResponse")]
        string getEnrollmentDate_pattern();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/getEnrollmentDate_pattern", ReplyAction="http://tempuri.org/IwcfUser/getEnrollmentDate_patternResponse")]
        System.Threading.Tasks.Task<string> getEnrollmentDate_patternAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/action_to_validCard", ReplyAction="http://tempuri.org/IwcfUser/action_to_validCardResponse")]
        void action_to_validCard(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/action_to_validCard", ReplyAction="http://tempuri.org/IwcfUser/action_to_validCardResponse")]
        System.Threading.Tasks.Task action_to_validCardAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/GetUserIdFromToken", ReplyAction="http://tempuri.org/IwcfUser/GetUserIdFromTokenResponse")]
        int GetUserIdFromToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/GetUserIdFromToken", ReplyAction="http://tempuri.org/IwcfUser/GetUserIdFromTokenResponse")]
        System.Threading.Tasks.Task<int> GetUserIdFromTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/GetCourseById", ReplyAction="http://tempuri.org/IwcfUser/GetCourseByIdResponse")]
        OnlineLearningSystem.userServiceRef.Course GetCourseById(int courseId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IwcfUser/GetCourseById", ReplyAction="http://tempuri.org/IwcfUser/GetCourseByIdResponse")]
        System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course> GetCourseByIdAsync(int courseId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IwcfUserChannel : OnlineLearningSystem.userServiceRef.IwcfUser, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IwcfUserClient : System.ServiceModel.ClientBase<OnlineLearningSystem.userServiceRef.IwcfUser>, OnlineLearningSystem.userServiceRef.IwcfUser {
        
        public IwcfUserClient() {
        }
        
        public IwcfUserClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IwcfUserClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfUserClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IwcfUserClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string RegisterUser(string name, string email, string password) {
            return base.Channel.RegisterUser(name, email, password);
        }
        
        public System.Threading.Tasks.Task<string> RegisterUserAsync(string name, string email, string password) {
            return base.Channel.RegisterUserAsync(name, email, password);
        }
        
        public string LoginUser(string email, string password) {
            return base.Channel.LoginUser(email, password);
        }
        
        public System.Threading.Tasks.Task<string> LoginUserAsync(string email, string password) {
            return base.Channel.LoginUserAsync(email, password);
        }
        
        public OnlineLearningSystem.userServiceRef.Course[] ViewCourses() {
            return base.Channel.ViewCourses();
        }
        
        public System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course[]> ViewCoursesAsync() {
            return base.Channel.ViewCoursesAsync();
        }
        
        public OnlineLearningSystem.userServiceRef.Course[] ViewCart(string token) {
            return base.Channel.ViewCart(token);
        }
        
        public System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course[]> ViewCartAsync(string token) {
            return base.Channel.ViewCartAsync(token);
        }
        
        public void delete_item(int course_id) {
            base.Channel.delete_item(course_id);
        }
        
        public System.Threading.Tasks.Task delete_itemAsync(int course_id) {
            return base.Channel.delete_itemAsync(course_id);
        }
        
        public void save_to_cart(int course_id, int user_id) {
            base.Channel.save_to_cart(course_id, user_id);
        }
        
        public System.Threading.Tasks.Task save_to_cartAsync(int course_id, int user_id) {
            return base.Channel.save_to_cartAsync(course_id, user_id);
        }
        
        public bool isValidCreditCard(long cardNo, int secCode, int expMonth, int expYear) {
            return base.Channel.isValidCreditCard(cardNo, secCode, expMonth, expYear);
        }
        
        public System.Threading.Tasks.Task<bool> isValidCreditCardAsync(long cardNo, int secCode, int expMonth, int expYear) {
            return base.Channel.isValidCreditCardAsync(cardNo, secCode, expMonth, expYear);
        }
        
        public string getEnrollmentDate_pattern() {
            return base.Channel.getEnrollmentDate_pattern();
        }
        
        public System.Threading.Tasks.Task<string> getEnrollmentDate_patternAsync() {
            return base.Channel.getEnrollmentDate_patternAsync();
        }
        
        public void action_to_validCard(string token) {
            base.Channel.action_to_validCard(token);
        }
        
        public System.Threading.Tasks.Task action_to_validCardAsync(string token) {
            return base.Channel.action_to_validCardAsync(token);
        }
        
        public int GetUserIdFromToken(string token) {
            return base.Channel.GetUserIdFromToken(token);
        }
        
        public System.Threading.Tasks.Task<int> GetUserIdFromTokenAsync(string token) {
            return base.Channel.GetUserIdFromTokenAsync(token);
        }
        
        public OnlineLearningSystem.userServiceRef.Course GetCourseById(int courseId) {
            return base.Channel.GetCourseById(courseId);
        }
        
        public System.Threading.Tasks.Task<OnlineLearningSystem.userServiceRef.Course> GetCourseByIdAsync(int courseId) {
            return base.Channel.GetCourseByIdAsync(courseId);
        }
    }
}