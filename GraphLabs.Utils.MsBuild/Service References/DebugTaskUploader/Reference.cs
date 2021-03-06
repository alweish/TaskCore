﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591
namespace GraphLabs.Utils.MsBuild.DebugTaskUploader {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DebugTaskData", Namespace="http://schemas.datacontract.org/2004/07/GraphLabs.WcfServices.DebugTaskUploader")]
    [System.SerializableAttribute()]
    public partial class DebugTaskData : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LabVariantIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private long LabWorkIdField;
        
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
        public long LabVariantId {
            get {
                return this.LabVariantIdField;
            }
            set {
                if ((this.LabVariantIdField.Equals(value) != true)) {
                    this.LabVariantIdField = value;
                    this.RaisePropertyChanged("LabVariantId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public long LabWorkId {
            get {
                return this.LabWorkIdField;
            }
            set {
                if ((this.LabWorkIdField.Equals(value) != true)) {
                    this.LabWorkIdField = value;
                    this.RaisePropertyChanged("LabWorkId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DebugTaskUploader.IDebugTaskUploader")]
    public interface IDebugTaskUploader {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDebugTaskUploader/UploadDebugTask", ReplyAction="http://tempuri.org/IDebugTaskUploader/UploadDebugTaskResponse")]
        GraphLabs.Utils.MsBuild.DebugTaskUploader.DebugTaskData UploadDebugTask(byte[] taskData, byte[] variantData);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDebugTaskUploader/UploadDebugTask", ReplyAction="http://tempuri.org/IDebugTaskUploader/UploadDebugTaskResponse")]
        System.Threading.Tasks.Task<GraphLabs.Utils.MsBuild.DebugTaskUploader.DebugTaskData> UploadDebugTaskAsync(byte[] taskData, byte[] variantData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDebugTaskUploaderChannel : GraphLabs.Utils.MsBuild.DebugTaskUploader.IDebugTaskUploader, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DebugTaskUploaderClient : System.ServiceModel.ClientBase<GraphLabs.Utils.MsBuild.DebugTaskUploader.IDebugTaskUploader>, GraphLabs.Utils.MsBuild.DebugTaskUploader.IDebugTaskUploader {
        
        public DebugTaskUploaderClient() {
        }
        
        public DebugTaskUploaderClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DebugTaskUploaderClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DebugTaskUploaderClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DebugTaskUploaderClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public GraphLabs.Utils.MsBuild.DebugTaskUploader.DebugTaskData UploadDebugTask(byte[] taskData, byte[] variantData) {
            return base.Channel.UploadDebugTask(taskData, variantData);
        }
        
        public System.Threading.Tasks.Task<GraphLabs.Utils.MsBuild.DebugTaskUploader.DebugTaskData> UploadDebugTaskAsync(byte[] taskData, byte[] variantData) {
            return base.Channel.UploadDebugTaskAsync(taskData, variantData);
        }
    }
}
#pragma warning restore 1591
