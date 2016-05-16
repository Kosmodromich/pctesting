﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pctesting.DBService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DBService.IDataService")]
    public interface IDataService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/saveFileDataToDB", ReplyAction="http://tempuri.org/IDataService/saveFileDataToDBResponse")]
        void saveFileDataToDB(string name, string path, string ext, long time, string type, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/saveFileDataToDB", ReplyAction="http://tempuri.org/IDataService/saveFileDataToDBResponse")]
        System.Threading.Tasks.Task saveFileDataToDBAsync(string name, string path, string ext, long time, string type, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/saveTrafficDataToDB", ReplyAction="http://tempuri.org/IDataService/saveTrafficDataToDBResponse")]
        void saveTrafficDataToDB(string URL, string host, string referer, long time, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/saveTrafficDataToDB", ReplyAction="http://tempuri.org/IDataService/saveTrafficDataToDBResponse")]
        System.Threading.Tasks.Task saveTrafficDataToDBAsync(string URL, string host, string referer, long time, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/login", ReplyAction="http://tempuri.org/IDataService/loginResponse")]
        string login(string name, string password, string compMAC, string compName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/login", ReplyAction="http://tempuri.org/IDataService/loginResponse")]
        System.Threading.Tasks.Task<string> loginAsync(string name, string password, string compMAC, string compName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveActivityToDB", ReplyAction="http://tempuri.org/IDataService/SaveActivityToDBResponse")]
        void SaveActivityToDB(System.TimeSpan AllTime, System.TimeSpan ActivityTime, System.TimeSpan NotActivityTime, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveActivityToDB", ReplyAction="http://tempuri.org/IDataService/SaveActivityToDBResponse")]
        System.Threading.Tasks.Task SaveActivityToDBAsync(System.TimeSpan AllTime, System.TimeSpan ActivityTime, System.TimeSpan NotActivityTime, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveProcessesToDB", ReplyAction="http://tempuri.org/IDataService/SaveProcessesToDBResponse")]
        void SaveProcessesToDB(string Name, System.DateTime StartTime, System.DateTime ExitTime, System.TimeSpan GeneralTime, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveProcessesToDB", ReplyAction="http://tempuri.org/IDataService/SaveProcessesToDBResponse")]
        System.Threading.Tasks.Task SaveProcessesToDBAsync(string Name, System.DateTime StartTime, System.DateTime ExitTime, System.TimeSpan GeneralTime, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/makeReport", ReplyAction="http://tempuri.org/IDataService/makeReportResponse")]
        bool makeReport();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/makeReport", ReplyAction="http://tempuri.org/IDataService/makeReportResponse")]
        System.Threading.Tasks.Task<bool> makeReportAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/addUser", ReplyAction="http://tempuri.org/IDataService/addUserResponse")]
        bool addUser(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/addUser", ReplyAction="http://tempuri.org/IDataService/addUserResponse")]
        System.Threading.Tasks.Task<bool> addUserAsync(string name, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/getUsers", ReplyAction="http://tempuri.org/IDataService/getUsersResponse")]
        string[] getUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/getUsers", ReplyAction="http://tempuri.org/IDataService/getUsersResponse")]
        System.Threading.Tasks.Task<string[]> getUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveTestCharacteristic", ReplyAction="http://tempuri.org/IDataService/SaveTestCharacteristicResponse")]
        void SaveTestCharacteristic(System.DateTime time, int teapots, string RAM, string freeRAM, string CPU, string VideoRAM, string comp, string user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDataService/SaveTestCharacteristic", ReplyAction="http://tempuri.org/IDataService/SaveTestCharacteristicResponse")]
        System.Threading.Tasks.Task SaveTestCharacteristicAsync(System.DateTime time, int teapots, string RAM, string freeRAM, string CPU, string VideoRAM, string comp, string user);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDataServiceChannel : pctesting.DBService.IDataService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DataServiceClient : System.ServiceModel.ClientBase<pctesting.DBService.IDataService>, pctesting.DBService.IDataService {
        
        public DataServiceClient() {
        }
        
        public DataServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DataServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DataServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void saveFileDataToDB(string name, string path, string ext, long time, string type, string comp, string user) {
            base.Channel.saveFileDataToDB(name, path, ext, time, type, comp, user);
        }
        
        public System.Threading.Tasks.Task saveFileDataToDBAsync(string name, string path, string ext, long time, string type, string comp, string user) {
            return base.Channel.saveFileDataToDBAsync(name, path, ext, time, type, comp, user);
        }
        
        public void saveTrafficDataToDB(string URL, string host, string referer, long time, string comp, string user) {
            base.Channel.saveTrafficDataToDB(URL, host, referer, time, comp, user);
        }
        
        public System.Threading.Tasks.Task saveTrafficDataToDBAsync(string URL, string host, string referer, long time, string comp, string user) {
            return base.Channel.saveTrafficDataToDBAsync(URL, host, referer, time, comp, user);
        }
        
        public string login(string name, string password, string compMAC, string compName) {
            return base.Channel.login(name, password, compMAC, compName);
        }
        
        public System.Threading.Tasks.Task<string> loginAsync(string name, string password, string compMAC, string compName) {
            return base.Channel.loginAsync(name, password, compMAC, compName);
        }
        
        public void SaveActivityToDB(System.TimeSpan AllTime, System.TimeSpan ActivityTime, System.TimeSpan NotActivityTime, string comp, string user) {
            base.Channel.SaveActivityToDB(AllTime, ActivityTime, NotActivityTime, comp, user);
        }
        
        public System.Threading.Tasks.Task SaveActivityToDBAsync(System.TimeSpan AllTime, System.TimeSpan ActivityTime, System.TimeSpan NotActivityTime, string comp, string user) {
            return base.Channel.SaveActivityToDBAsync(AllTime, ActivityTime, NotActivityTime, comp, user);
        }
        
        public void SaveProcessesToDB(string Name, System.DateTime StartTime, System.DateTime ExitTime, System.TimeSpan GeneralTime, string comp, string user) {
            base.Channel.SaveProcessesToDB(Name, StartTime, ExitTime, GeneralTime, comp, user);
        }
        
        public System.Threading.Tasks.Task SaveProcessesToDBAsync(string Name, System.DateTime StartTime, System.DateTime ExitTime, System.TimeSpan GeneralTime, string comp, string user) {
            return base.Channel.SaveProcessesToDBAsync(Name, StartTime, ExitTime, GeneralTime, comp, user);
        }
        
        public bool makeReport() {
            return base.Channel.makeReport();
        }
        
        public System.Threading.Tasks.Task<bool> makeReportAsync() {
            return base.Channel.makeReportAsync();
        }
        
        public bool addUser(string name, string password) {
            return base.Channel.addUser(name, password);
        }
        
        public System.Threading.Tasks.Task<bool> addUserAsync(string name, string password) {
            return base.Channel.addUserAsync(name, password);
        }
        
        public string[] getUsers() {
            return base.Channel.getUsers();
        }
        
        public System.Threading.Tasks.Task<string[]> getUsersAsync() {
            return base.Channel.getUsersAsync();
        }
        
        public void SaveTestCharacteristic(System.DateTime time, int teapots, string RAM, string freeRAM, string CPU, string VideoRAM, string comp, string user) {
            base.Channel.SaveTestCharacteristic(time, teapots, RAM, freeRAM, CPU, VideoRAM, comp, user);
        }
        
        public System.Threading.Tasks.Task SaveTestCharacteristicAsync(System.DateTime time, int teapots, string RAM, string freeRAM, string CPU, string VideoRAM, string comp, string user) {
            return base.Channel.SaveTestCharacteristicAsync(time, teapots, RAM, freeRAM, CPU, VideoRAM, comp, user);
        }
    }
}
