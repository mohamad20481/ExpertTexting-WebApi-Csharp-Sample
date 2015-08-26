﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34209.
// 
#pragma warning disable 1591

namespace ExpertTexting_API_Sample_Csharp.com.experttexting.www {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="ExptTextingAPISoap", Namespace="http://www.experttexting.com")]
    public partial class ExptTextingAPI : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback SendSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback SendMultilingualSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback ScheduleSMSOperationCompleted;
        
        private System.Threading.SendOrPostCallback QueryBalanceOperationCompleted;
        
        private System.Threading.SendOrPostCallback MsgStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUnreadInboxOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPriceListOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPriceListWithNetworksOperationCompleted;
        
        private System.Threading.SendOrPostCallback getPriceWithNetworksOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public ExptTextingAPI() {
            this.Url = global::ExpertTexting_API_Sample_Csharp.Properties.Settings.Default.ExpertTexting_API_Sample_Csharp_com_experttexting_www_ExptTextingAPI;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event SendSMSCompletedEventHandler SendSMSCompleted;
        
        /// <remarks/>
        public event SendMultilingualSMSCompletedEventHandler SendMultilingualSMSCompleted;
        
        /// <remarks/>
        public event ScheduleSMSCompletedEventHandler ScheduleSMSCompleted;
        
        /// <remarks/>
        public event QueryBalanceCompletedEventHandler QueryBalanceCompleted;
        
        /// <remarks/>
        public event MsgStatusCompletedEventHandler MsgStatusCompleted;
        
        /// <remarks/>
        public event getUnreadInboxCompletedEventHandler getUnreadInboxCompleted;
        
        /// <remarks/>
        public event getPriceListCompletedEventHandler getPriceListCompleted;
        
        /// <remarks/>
        public event getPriceListWithNetworksCompletedEventHandler getPriceListWithNetworksCompleted;
        
        /// <remarks/>
        public event getPriceWithNetworksCompletedEventHandler getPriceWithNetworksCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/SendSMS", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode SendSMS(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG) {
            object[] results = this.Invoke("SendSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void SendSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG) {
            this.SendSMSAsync(UserID, PWD, APIKEY, FROM, TO, MSG, null);
        }
        
        /// <remarks/>
        public void SendSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG, object userState) {
            if ((this.SendSMSOperationCompleted == null)) {
                this.SendSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendSMSOperationCompleted);
            }
            this.InvokeAsync("SendSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG}, this.SendSMSOperationCompleted, userState);
        }
        
        private void OnSendSMSOperationCompleted(object arg) {
            if ((this.SendSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendSMSCompleted(this, new SendSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/SendSMSUnicode", RequestElementName="SendSMSUnicode", RequestNamespace="http://www.experttexting.com", ResponseElementName="SendSMSUnicodeResponse", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("SendSMSUnicodeResult")]
        public System.Xml.XmlNode SendMultilingualSMS(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG) {
            object[] results = this.Invoke("SendMultilingualSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void SendMultilingualSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG) {
            this.SendMultilingualSMSAsync(UserID, PWD, APIKEY, FROM, TO, MSG, null);
        }
        
        /// <remarks/>
        public void SendMultilingualSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG, object userState) {
            if ((this.SendMultilingualSMSOperationCompleted == null)) {
                this.SendMultilingualSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSendMultilingualSMSOperationCompleted);
            }
            this.InvokeAsync("SendMultilingualSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG}, this.SendMultilingualSMSOperationCompleted, userState);
        }
        
        private void OnSendMultilingualSMSOperationCompleted(object arg) {
            if ((this.SendMultilingualSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SendMultilingualSMSCompleted(this, new SendMultilingualSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/ScheduleSMS", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode ScheduleSMS(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG, System.DateTime ESTScheduleDatetime) {
            object[] results = this.Invoke("ScheduleSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG,
                        ESTScheduleDatetime});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void ScheduleSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG, System.DateTime ESTScheduleDatetime) {
            this.ScheduleSMSAsync(UserID, PWD, APIKEY, FROM, TO, MSG, ESTScheduleDatetime, null);
        }
        
        /// <remarks/>
        public void ScheduleSMSAsync(string UserID, string PWD, string APIKEY, string FROM, string TO, string MSG, System.DateTime ESTScheduleDatetime, object userState) {
            if ((this.ScheduleSMSOperationCompleted == null)) {
                this.ScheduleSMSOperationCompleted = new System.Threading.SendOrPostCallback(this.OnScheduleSMSOperationCompleted);
            }
            this.InvokeAsync("ScheduleSMS", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        FROM,
                        TO,
                        MSG,
                        ESTScheduleDatetime}, this.ScheduleSMSOperationCompleted, userState);
        }
        
        private void OnScheduleSMSOperationCompleted(object arg) {
            if ((this.ScheduleSMSCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ScheduleSMSCompleted(this, new ScheduleSMSCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/QueryBalance", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode QueryBalance(string UserID, string PWD, string APIKEY) {
            object[] results = this.Invoke("QueryBalance", new object[] {
                        UserID,
                        PWD,
                        APIKEY});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void QueryBalanceAsync(string UserID, string PWD, string APIKEY) {
            this.QueryBalanceAsync(UserID, PWD, APIKEY, null);
        }
        
        /// <remarks/>
        public void QueryBalanceAsync(string UserID, string PWD, string APIKEY, object userState) {
            if ((this.QueryBalanceOperationCompleted == null)) {
                this.QueryBalanceOperationCompleted = new System.Threading.SendOrPostCallback(this.OnQueryBalanceOperationCompleted);
            }
            this.InvokeAsync("QueryBalance", new object[] {
                        UserID,
                        PWD,
                        APIKEY}, this.QueryBalanceOperationCompleted, userState);
        }
        
        private void OnQueryBalanceOperationCompleted(object arg) {
            if ((this.QueryBalanceCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.QueryBalanceCompleted(this, new QueryBalanceCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/MsgStatus", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode MsgStatus(string UserID, string PWD, string APIKEY, string MsgId) {
            object[] results = this.Invoke("MsgStatus", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        MsgId});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void MsgStatusAsync(string UserID, string PWD, string APIKEY, string MsgId) {
            this.MsgStatusAsync(UserID, PWD, APIKEY, MsgId, null);
        }
        
        /// <remarks/>
        public void MsgStatusAsync(string UserID, string PWD, string APIKEY, string MsgId, object userState) {
            if ((this.MsgStatusOperationCompleted == null)) {
                this.MsgStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnMsgStatusOperationCompleted);
            }
            this.InvokeAsync("MsgStatus", new object[] {
                        UserID,
                        PWD,
                        APIKEY,
                        MsgId}, this.MsgStatusOperationCompleted, userState);
        }
        
        private void OnMsgStatusOperationCompleted(object arg) {
            if ((this.MsgStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.MsgStatusCompleted(this, new MsgStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/getUnreadInbox", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode getUnreadInbox(string UserID, string PWD, string APIKEY) {
            object[] results = this.Invoke("getUnreadInbox", new object[] {
                        UserID,
                        PWD,
                        APIKEY});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void getUnreadInboxAsync(string UserID, string PWD, string APIKEY) {
            this.getUnreadInboxAsync(UserID, PWD, APIKEY, null);
        }
        
        /// <remarks/>
        public void getUnreadInboxAsync(string UserID, string PWD, string APIKEY, object userState) {
            if ((this.getUnreadInboxOperationCompleted == null)) {
                this.getUnreadInboxOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUnreadInboxOperationCompleted);
            }
            this.InvokeAsync("getUnreadInbox", new object[] {
                        UserID,
                        PWD,
                        APIKEY}, this.getUnreadInboxOperationCompleted, userState);
        }
        
        private void OngetUnreadInboxOperationCompleted(object arg) {
            if ((this.getUnreadInboxCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUnreadInboxCompleted(this, new getUnreadInboxCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/getPriceList", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode getPriceList(string UserID, string PWD, string APIKEY) {
            object[] results = this.Invoke("getPriceList", new object[] {
                        UserID,
                        PWD,
                        APIKEY});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void getPriceListAsync(string UserID, string PWD, string APIKEY) {
            this.getPriceListAsync(UserID, PWD, APIKEY, null);
        }
        
        /// <remarks/>
        public void getPriceListAsync(string UserID, string PWD, string APIKEY, object userState) {
            if ((this.getPriceListOperationCompleted == null)) {
                this.getPriceListOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPriceListOperationCompleted);
            }
            this.InvokeAsync("getPriceList", new object[] {
                        UserID,
                        PWD,
                        APIKEY}, this.getPriceListOperationCompleted, userState);
        }
        
        private void OngetPriceListOperationCompleted(object arg) {
            if ((this.getPriceListCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPriceListCompleted(this, new getPriceListCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/getPriceListWithNetworks", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode getPriceListWithNetworks() {
            object[] results = this.Invoke("getPriceListWithNetworks", new object[0]);
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void getPriceListWithNetworksAsync() {
            this.getPriceListWithNetworksAsync(null);
        }
        
        /// <remarks/>
        public void getPriceListWithNetworksAsync(object userState) {
            if ((this.getPriceListWithNetworksOperationCompleted == null)) {
                this.getPriceListWithNetworksOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPriceListWithNetworksOperationCompleted);
            }
            this.InvokeAsync("getPriceListWithNetworks", new object[0], this.getPriceListWithNetworksOperationCompleted, userState);
        }
        
        private void OngetPriceListWithNetworksOperationCompleted(object arg) {
            if ((this.getPriceListWithNetworksCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPriceListWithNetworksCompleted(this, new getPriceListWithNetworksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.experttexting.com/getPriceWithNetworks", RequestNamespace="http://www.experttexting.com", ResponseNamespace="http://www.experttexting.com", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Xml.XmlNode getPriceWithNetworks(string COUNTRYNAME) {
            object[] results = this.Invoke("getPriceWithNetworks", new object[] {
                        COUNTRYNAME});
            return ((System.Xml.XmlNode)(results[0]));
        }
        
        /// <remarks/>
        public void getPriceWithNetworksAsync(string COUNTRYNAME) {
            this.getPriceWithNetworksAsync(COUNTRYNAME, null);
        }
        
        /// <remarks/>
        public void getPriceWithNetworksAsync(string COUNTRYNAME, object userState) {
            if ((this.getPriceWithNetworksOperationCompleted == null)) {
                this.getPriceWithNetworksOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetPriceWithNetworksOperationCompleted);
            }
            this.InvokeAsync("getPriceWithNetworks", new object[] {
                        COUNTRYNAME}, this.getPriceWithNetworksOperationCompleted, userState);
        }
        
        private void OngetPriceWithNetworksOperationCompleted(object arg) {
            if ((this.getPriceWithNetworksCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getPriceWithNetworksCompleted(this, new getPriceWithNetworksCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SendSMSCompletedEventHandler(object sender, SendSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void SendMultilingualSMSCompletedEventHandler(object sender, SendMultilingualSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class SendMultilingualSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal SendMultilingualSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void ScheduleSMSCompletedEventHandler(object sender, ScheduleSMSCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ScheduleSMSCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ScheduleSMSCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void QueryBalanceCompletedEventHandler(object sender, QueryBalanceCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class QueryBalanceCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal QueryBalanceCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void MsgStatusCompletedEventHandler(object sender, MsgStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class MsgStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal MsgStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getUnreadInboxCompletedEventHandler(object sender, getUnreadInboxCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUnreadInboxCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUnreadInboxCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getPriceListCompletedEventHandler(object sender, getPriceListCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPriceListCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPriceListCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getPriceListWithNetworksCompletedEventHandler(object sender, getPriceListWithNetworksCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPriceListWithNetworksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPriceListWithNetworksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    public delegate void getPriceWithNetworksCompletedEventHandler(object sender, getPriceWithNetworksCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.34209")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getPriceWithNetworksCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getPriceWithNetworksCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Xml.XmlNode Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Xml.XmlNode)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591