﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consumidor.WebServer {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WebServer.WebServiceSoap")]
    public interface WebServiceSoap {
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento HelloWorldResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        Consumidor.WebServer.HelloWorldResponse HelloWorld(Consumidor.WebServer.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumidor.WebServer.HelloWorldResponse> HelloWorldAsync(Consumidor.WebServer.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculadora", ReplyAction="*")]
        decimal calculadora(decimal valor1, decimal valor2, char operador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/calculadora", ReplyAction="*")]
        System.Threading.Tasks.Task<decimal> calculadoraAsync(decimal valor1, decimal valor2, char operador);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fatorial", ReplyAction="*")]
        long fatorial(int valor);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/fatorial", ReplyAction="*")]
        System.Threading.Tasks.Task<long> fatorialAsync(int valor);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento imcResult no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/imc", ReplyAction="*")]
        Consumidor.WebServer.imcResponse imc(Consumidor.WebServer.imcRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/imc", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumidor.WebServer.imcResponse> imcAsync(Consumidor.WebServer.imcRequest request);
        
        // CODEGEN: Gerando contrato de mensagem porque o nome do elemento tipoMedida no namespace http://tempuri.org/ não está marcado como nulo
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/conversor", ReplyAction="*")]
        Consumidor.WebServer.conversorResponse conversor(Consumidor.WebServer.conversorRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/conversor", ReplyAction="*")]
        System.Threading.Tasks.Task<Consumidor.WebServer.conversorResponse> conversorAsync(Consumidor.WebServer.conversorRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(Consumidor.WebServer.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(Consumidor.WebServer.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class imcRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="imc", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.imcRequestBody Body;
        
        public imcRequest() {
        }
        
        public imcRequest(Consumidor.WebServer.imcRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class imcRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal altura;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public decimal peso;
        
        public imcRequestBody() {
        }
        
        public imcRequestBody(decimal altura, decimal peso) {
            this.altura = altura;
            this.peso = peso;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class imcResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="imcResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.imcResponseBody Body;
        
        public imcResponse() {
        }
        
        public imcResponse(Consumidor.WebServer.imcResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class imcResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string imcResult;
        
        public imcResponseBody() {
        }
        
        public imcResponseBody(string imcResult) {
            this.imcResult = imcResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class conversorRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="conversor", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.conversorRequestBody Body;
        
        public conversorRequest() {
        }
        
        public conversorRequest(Consumidor.WebServer.conversorRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class conversorRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal valorMetros;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string tipoMedida;
        
        public conversorRequestBody() {
        }
        
        public conversorRequestBody(decimal valorMetros, string tipoMedida) {
            this.valorMetros = valorMetros;
            this.tipoMedida = tipoMedida;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class conversorResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="conversorResponse", Namespace="http://tempuri.org/", Order=0)]
        public Consumidor.WebServer.conversorResponseBody Body;
        
        public conversorResponse() {
        }
        
        public conversorResponse(Consumidor.WebServer.conversorResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class conversorResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public decimal conversorResult;
        
        public conversorResponseBody() {
        }
        
        public conversorResponseBody(decimal conversorResult) {
            this.conversorResult = conversorResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebServiceSoapChannel : Consumidor.WebServer.WebServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebServiceSoapClient : System.ServiceModel.ClientBase<Consumidor.WebServer.WebServiceSoap>, Consumidor.WebServer.WebServiceSoap {
        
        public WebServiceSoapClient() {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumidor.WebServer.HelloWorldResponse Consumidor.WebServer.WebServiceSoap.HelloWorld(Consumidor.WebServer.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            Consumidor.WebServer.HelloWorldRequest inValue = new Consumidor.WebServer.HelloWorldRequest();
            inValue.Body = new Consumidor.WebServer.HelloWorldRequestBody();
            Consumidor.WebServer.HelloWorldResponse retVal = ((Consumidor.WebServer.WebServiceSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumidor.WebServer.HelloWorldResponse> Consumidor.WebServer.WebServiceSoap.HelloWorldAsync(Consumidor.WebServer.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumidor.WebServer.HelloWorldResponse> HelloWorldAsync() {
            Consumidor.WebServer.HelloWorldRequest inValue = new Consumidor.WebServer.HelloWorldRequest();
            inValue.Body = new Consumidor.WebServer.HelloWorldRequestBody();
            return ((Consumidor.WebServer.WebServiceSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public decimal calculadora(decimal valor1, decimal valor2, char operador) {
            return base.Channel.calculadora(valor1, valor2, operador);
        }
        
        public System.Threading.Tasks.Task<decimal> calculadoraAsync(decimal valor1, decimal valor2, char operador) {
            return base.Channel.calculadoraAsync(valor1, valor2, operador);
        }
        
        public long fatorial(int valor) {
            return base.Channel.fatorial(valor);
        }
        
        public System.Threading.Tasks.Task<long> fatorialAsync(int valor) {
            return base.Channel.fatorialAsync(valor);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumidor.WebServer.imcResponse Consumidor.WebServer.WebServiceSoap.imc(Consumidor.WebServer.imcRequest request) {
            return base.Channel.imc(request);
        }
        
        public string imc(decimal altura, decimal peso) {
            Consumidor.WebServer.imcRequest inValue = new Consumidor.WebServer.imcRequest();
            inValue.Body = new Consumidor.WebServer.imcRequestBody();
            inValue.Body.altura = altura;
            inValue.Body.peso = peso;
            Consumidor.WebServer.imcResponse retVal = ((Consumidor.WebServer.WebServiceSoap)(this)).imc(inValue);
            return retVal.Body.imcResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumidor.WebServer.imcResponse> Consumidor.WebServer.WebServiceSoap.imcAsync(Consumidor.WebServer.imcRequest request) {
            return base.Channel.imcAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumidor.WebServer.imcResponse> imcAsync(decimal altura, decimal peso) {
            Consumidor.WebServer.imcRequest inValue = new Consumidor.WebServer.imcRequest();
            inValue.Body = new Consumidor.WebServer.imcRequestBody();
            inValue.Body.altura = altura;
            inValue.Body.peso = peso;
            return ((Consumidor.WebServer.WebServiceSoap)(this)).imcAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Consumidor.WebServer.conversorResponse Consumidor.WebServer.WebServiceSoap.conversor(Consumidor.WebServer.conversorRequest request) {
            return base.Channel.conversor(request);
        }
        
        public decimal conversor(decimal valorMetros, string tipoMedida) {
            Consumidor.WebServer.conversorRequest inValue = new Consumidor.WebServer.conversorRequest();
            inValue.Body = new Consumidor.WebServer.conversorRequestBody();
            inValue.Body.valorMetros = valorMetros;
            inValue.Body.tipoMedida = tipoMedida;
            Consumidor.WebServer.conversorResponse retVal = ((Consumidor.WebServer.WebServiceSoap)(this)).conversor(inValue);
            return retVal.Body.conversorResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Consumidor.WebServer.conversorResponse> Consumidor.WebServer.WebServiceSoap.conversorAsync(Consumidor.WebServer.conversorRequest request) {
            return base.Channel.conversorAsync(request);
        }
        
        public System.Threading.Tasks.Task<Consumidor.WebServer.conversorResponse> conversorAsync(decimal valorMetros, string tipoMedida) {
            Consumidor.WebServer.conversorRequest inValue = new Consumidor.WebServer.conversorRequest();
            inValue.Body = new Consumidor.WebServer.conversorRequestBody();
            inValue.Body.valorMetros = valorMetros;
            inValue.Body.tipoMedida = tipoMedida;
            return ((Consumidor.WebServer.WebServiceSoap)(this)).conversorAsync(inValue);
        }
    }
}
