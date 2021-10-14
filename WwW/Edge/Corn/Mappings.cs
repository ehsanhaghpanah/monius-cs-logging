/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

namespace monius.Logging.WwW.ServiceProxys
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://monius.logging/soap/mappings", ConfigurationName = "Mappings")]
	public interface Mappings
	{
		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetOneById", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetOneByIdResponse")]
		ObjectModel.Mapping GetOneById(long id);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetOneById", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetOneByIdResponse")]
		System.Threading.Tasks.Task<ObjectModel.Mapping> GetOneByIdAsync(long id);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetOneByKy", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetOneByKyResponse")]
		ObjectModel.Mapping GetOneByKy(string ky);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetOneByKy", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetOneByKyResponse")]
		System.Threading.Tasks.Task<ObjectModel.Mapping> GetOneByKyAsync(string ky);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetAll", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetAllResponse")]
		ObjectModel.Mapping[] GetAll(int count);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/GetAll", ReplyAction = "http://monius.logging/soap/mappings/Mappings/GetAllResponse")]
		System.Threading.Tasks.Task<ObjectModel.Mapping[]> GetAllAsync(int count);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/AddOne", ReplyAction = "http://monius.logging/soap/mappings/Mappings/AddOneResponse")]
		ObjectModel.Mapping AddOne(string code, string text, string comments, string mappedTo);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/AddOne", ReplyAction = "http://monius.logging/soap/mappings/Mappings/AddOneResponse")]
		System.Threading.Tasks.Task<ObjectModel.Mapping> AddOneAsync(string code, string text, string comments, string mappedTo);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/Change", ReplyAction = "http://monius.logging/soap/mappings/Mappings/ChangeResponse")]
		ObjectModel.Mapping Change(ObjectModel.Mapping item);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/Change", ReplyAction = "http://monius.logging/soap/mappings/Mappings/ChangeResponse")]
		System.Threading.Tasks.Task<ObjectModel.Mapping> ChangeAsync(ObjectModel.Mapping item);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/Remove", ReplyAction = "http://monius.logging/soap/mappings/Mappings/RemoveResponse")]
		void Remove(ObjectModel.Mapping item);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/mappings/Mappings/Remove", ReplyAction = "http://monius.logging/soap/mappings/Mappings/RemoveResponse")]
		System.Threading.Tasks.Task RemoveAsync(ObjectModel.Mapping item);
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface MappingsChannel : Mappings, System.ServiceModel.IClientChannel
	{
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public class MappingsClient : System.ServiceModel.ClientBase<Mappings>, Mappings
	{
		public MappingsClient()
		{
		}

		public MappingsClient(string endpointConfigurationName) :
			base(endpointConfigurationName)
		{
		}

		public MappingsClient(string endpointConfigurationName, string remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		public MappingsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		public MappingsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
		{
		}

		public ObjectModel.Mapping GetOneById(long id)
		{
			return Channel.GetOneById(id);
		}

		public System.Threading.Tasks.Task<ObjectModel.Mapping> GetOneByIdAsync(long id)
		{
			return Channel.GetOneByIdAsync(id);
		}

		public ObjectModel.Mapping GetOneByKy(string ky)
		{
			return Channel.GetOneByKy(ky);
		}

		public System.Threading.Tasks.Task<ObjectModel.Mapping> GetOneByKyAsync(string ky)
		{
			return Channel.GetOneByKyAsync(ky);
		}

		public ObjectModel.Mapping[] GetAll(int count)
		{
			return Channel.GetAll(count);
		}

		public System.Threading.Tasks.Task<ObjectModel.Mapping[]> GetAllAsync(int count)
		{
			return Channel.GetAllAsync(count);
		}

		public ObjectModel.Mapping AddOne(string code, string text, string comments, string mappedTo)
		{
			return Channel.AddOne(code, text, comments, mappedTo);
		}

		public System.Threading.Tasks.Task<ObjectModel.Mapping> AddOneAsync(string code, string text, string comments, string mappedTo)
		{
			return Channel.AddOneAsync(code, text, comments, mappedTo);
		}

		public ObjectModel.Mapping Change(ObjectModel.Mapping item)
		{
			return Channel.Change(item);
		}

		public System.Threading.Tasks.Task<ObjectModel.Mapping> ChangeAsync(ObjectModel.Mapping item)
		{
			return Channel.ChangeAsync(item);
		}

		public void Remove(ObjectModel.Mapping item)
		{
			Channel.Remove(item);
		}

		public System.Threading.Tasks.Task RemoveAsync(ObjectModel.Mapping item)
		{
			return Channel.RemoveAsync(item);
		}
	}
}