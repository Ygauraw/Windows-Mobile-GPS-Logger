﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4214
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.CompactFramework.Design.Data, Version 2.0.50727.4214.
// 
namespace WindowsMobileGPSLogger.GPSLogger {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LoggerSoap", Namespace="http://tempuri.org/")]
    public partial class Logger : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Logger() {
            this.Url = "http://localhost:61165/Logger.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Log", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public bool Log(string deviceId, string x, string y, string time) {
            object[] results = this.Invoke("Log", new object[] {
                        deviceId,
                        x,
                        y,
                        time});
            return ((bool)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginLog(string deviceId, string x, string y, string time, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Log", new object[] {
                        deviceId,
                        x,
                        y,
                        time}, callback, asyncState);
        }
        
        /// <remarks/>
        public bool EndLog(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((bool)(results[0]));
        }
    }
}
