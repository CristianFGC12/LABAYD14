﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioTendencia.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.LabServiceSoap")]
    public interface LabServiceSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento a del espacio de nombres http://tempuri.org/ no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PedirPermiso", ReplyAction="*")]
        SitioTendencia.ServiceReference1.PedirPermisoResponse PedirPermiso(SitioTendencia.ServiceReference1.PedirPermisoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/PedirPermiso", ReplyAction="*")]
        System.Threading.Tasks.Task<SitioTendencia.ServiceReference1.PedirPermisoResponse> PedirPermisoAsync(SitioTendencia.ServiceReference1.PedirPermisoRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PedirPermisoRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PedirPermiso", Namespace="http://tempuri.org/", Order=0)]
        public SitioTendencia.ServiceReference1.PedirPermisoRequestBody Body;
        
        public PedirPermisoRequest() {
        }
        
        public PedirPermisoRequest(SitioTendencia.ServiceReference1.PedirPermisoRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PedirPermisoRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string a;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string b;
        
        public PedirPermisoRequestBody() {
        }
        
        public PedirPermisoRequestBody(string a, string b) {
            this.a = a;
            this.b = b;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class PedirPermisoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="PedirPermisoResponse", Namespace="http://tempuri.org/", Order=0)]
        public SitioTendencia.ServiceReference1.PedirPermisoResponseBody Body;
        
        public PedirPermisoResponse() {
        }
        
        public PedirPermisoResponse(SitioTendencia.ServiceReference1.PedirPermisoResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class PedirPermisoResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public bool PedirPermisoResult;
        
        public PedirPermisoResponseBody() {
        }
        
        public PedirPermisoResponseBody(bool PedirPermisoResult) {
            this.PedirPermisoResult = PedirPermisoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface LabServiceSoapChannel : SitioTendencia.ServiceReference1.LabServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LabServiceSoapClient : System.ServiceModel.ClientBase<SitioTendencia.ServiceReference1.LabServiceSoap>, SitioTendencia.ServiceReference1.LabServiceSoap {
        
        public LabServiceSoapClient() {
        }
        
        public LabServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LabServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LabServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SitioTendencia.ServiceReference1.PedirPermisoResponse SitioTendencia.ServiceReference1.LabServiceSoap.PedirPermiso(SitioTendencia.ServiceReference1.PedirPermisoRequest request) {
            return base.Channel.PedirPermiso(request);
        }
        
        public bool PedirPermiso(string a, string b) {
            SitioTendencia.ServiceReference1.PedirPermisoRequest inValue = new SitioTendencia.ServiceReference1.PedirPermisoRequest();
            inValue.Body = new SitioTendencia.ServiceReference1.PedirPermisoRequestBody();
            inValue.Body.a = a;
            inValue.Body.b = b;
            SitioTendencia.ServiceReference1.PedirPermisoResponse retVal = ((SitioTendencia.ServiceReference1.LabServiceSoap)(this)).PedirPermiso(inValue);
            return retVal.Body.PedirPermisoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SitioTendencia.ServiceReference1.PedirPermisoResponse> SitioTendencia.ServiceReference1.LabServiceSoap.PedirPermisoAsync(SitioTendencia.ServiceReference1.PedirPermisoRequest request) {
            return base.Channel.PedirPermisoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SitioTendencia.ServiceReference1.PedirPermisoResponse> PedirPermisoAsync(string a, string b) {
            SitioTendencia.ServiceReference1.PedirPermisoRequest inValue = new SitioTendencia.ServiceReference1.PedirPermisoRequest();
            inValue.Body = new SitioTendencia.ServiceReference1.PedirPermisoRequestBody();
            inValue.Body.a = a;
            inValue.Body.b = b;
            return ((SitioTendencia.ServiceReference1.LabServiceSoap)(this)).PedirPermisoAsync(inValue);
        }
    }
}
