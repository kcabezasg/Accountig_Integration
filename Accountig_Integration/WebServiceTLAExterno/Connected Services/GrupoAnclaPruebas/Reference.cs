﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceTLAExterno.GrupoAnclaPruebas {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="GrupoAnclaPruebas.WebService_GrupoAnclaSoap")]
    public interface WebService_GrupoAnclaSoap {
        
        // CODEGEN: Generating message contract since element name Json from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/OrdenesExpedicion_03", ReplyAction="*")]
        WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response OrdenesExpedicion_03(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/OrdenesExpedicion_03", ReplyAction="*")]
        System.IAsyncResult BeginOrdenesExpedicion_03(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request request, System.AsyncCallback callback, object asyncState);
        
        WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response EndOrdenesExpedicion_03(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrdenesExpedicion_03Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OrdenesExpedicion_03", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03RequestBody Body;
        
        public OrdenesExpedicion_03Request() {
        }
        
        public OrdenesExpedicion_03Request(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OrdenesExpedicion_03RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Json;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public OrdenesExpedicion_03RequestBody() {
        }
        
        public OrdenesExpedicion_03RequestBody(string Json, string data) {
            this.Json = Json;
            this.data = data;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class OrdenesExpedicion_03Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="OrdenesExpedicion_03Response", Namespace="http://tempuri.org/", Order=0)]
        public WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03ResponseBody Body;
        
        public OrdenesExpedicion_03Response() {
        }
        
        public OrdenesExpedicion_03Response(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class OrdenesExpedicion_03ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool OrdenesExpedicion_03Result;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string data;
        
        public OrdenesExpedicion_03ResponseBody() {
        }
        
        public OrdenesExpedicion_03ResponseBody(bool OrdenesExpedicion_03Result, string data) {
            this.OrdenesExpedicion_03Result = OrdenesExpedicion_03Result;
            this.data = data;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService_GrupoAnclaSoapChannel : WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class OrdenesExpedicion_03CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public OrdenesExpedicion_03CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string data {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService_GrupoAnclaSoapClient : System.ServiceModel.ClientBase<WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap>, WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap {
        
        private BeginOperationDelegate onBeginOrdenesExpedicion_03Delegate;
        
        private EndOperationDelegate onEndOrdenesExpedicion_03Delegate;
        
        private System.Threading.SendOrPostCallback onOrdenesExpedicion_03CompletedDelegate;
        
        public WebService_GrupoAnclaSoapClient() {
        }
        
        public WebService_GrupoAnclaSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService_GrupoAnclaSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService_GrupoAnclaSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService_GrupoAnclaSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<OrdenesExpedicion_03CompletedEventArgs> OrdenesExpedicion_03Completed;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap.OrdenesExpedicion_03(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request request) {
            return base.Channel.OrdenesExpedicion_03(request);
        }
        
        public bool OrdenesExpedicion_03(string Json, ref string data) {
            WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request inValue = new WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request();
            inValue.Body = new WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03RequestBody();
            inValue.Body.Json = Json;
            inValue.Body.data = data;
            WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response retVal = ((WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap)(this)).OrdenesExpedicion_03(inValue);
            data = retVal.Body.data;
            return retVal.Body.OrdenesExpedicion_03Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap.BeginOrdenesExpedicion_03(WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginOrdenesExpedicion_03(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginOrdenesExpedicion_03(string Json, string data, System.AsyncCallback callback, object asyncState) {
            WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request inValue = new WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Request();
            inValue.Body = new WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03RequestBody();
            inValue.Body.Json = Json;
            inValue.Body.data = data;
            return ((WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap)(this)).BeginOrdenesExpedicion_03(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap.EndOrdenesExpedicion_03(System.IAsyncResult result) {
            return base.Channel.EndOrdenesExpedicion_03(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public bool EndOrdenesExpedicion_03(System.IAsyncResult result, out string data) {
            WebServiceTLAExterno.GrupoAnclaPruebas.OrdenesExpedicion_03Response retVal = ((WebServiceTLAExterno.GrupoAnclaPruebas.WebService_GrupoAnclaSoap)(this)).EndOrdenesExpedicion_03(result);
            data = retVal.Body.data;
            return retVal.Body.OrdenesExpedicion_03Result;
        }
        
        private System.IAsyncResult OnBeginOrdenesExpedicion_03(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string Json = ((string)(inValues[0]));
            string data = ((string)(inValues[1]));
            return this.BeginOrdenesExpedicion_03(Json, data, callback, asyncState);
        }
        
        private object[] OnEndOrdenesExpedicion_03(System.IAsyncResult result) {
            string data = this.GetDefaultValueForInitialization<string>();
            bool retVal = this.EndOrdenesExpedicion_03(result, out data);
            return new object[] {
                    data,
                    retVal};
        }
        
        private void OnOrdenesExpedicion_03Completed(object state) {
            if ((this.OrdenesExpedicion_03Completed != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OrdenesExpedicion_03Completed(this, new OrdenesExpedicion_03CompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OrdenesExpedicion_03Async(string Json, string data) {
            this.OrdenesExpedicion_03Async(Json, data, null);
        }
        
        public void OrdenesExpedicion_03Async(string Json, string data, object userState) {
            if ((this.onBeginOrdenesExpedicion_03Delegate == null)) {
                this.onBeginOrdenesExpedicion_03Delegate = new BeginOperationDelegate(this.OnBeginOrdenesExpedicion_03);
            }
            if ((this.onEndOrdenesExpedicion_03Delegate == null)) {
                this.onEndOrdenesExpedicion_03Delegate = new EndOperationDelegate(this.OnEndOrdenesExpedicion_03);
            }
            if ((this.onOrdenesExpedicion_03CompletedDelegate == null)) {
                this.onOrdenesExpedicion_03CompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOrdenesExpedicion_03Completed);
            }
            base.InvokeAsync(this.onBeginOrdenesExpedicion_03Delegate, new object[] {
                        Json,
                        data}, this.onEndOrdenesExpedicion_03Delegate, this.onOrdenesExpedicion_03CompletedDelegate, userState);
        }
    }
}