/**
 * Copyright (C) moniüs, 2017.
 * All rights reserved.
 * E. Haghpanah; haghpanah@monius.net
 */

namespace monius.Logging.WwW.ServiceProxys
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://monius.logging/soap/traffics", ConfigurationName = "Traffics")]
	public interface Traffics
	{
		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/traffics/Traffics/GetAll", ReplyAction = "http://monius.logging/soap/traffics/Traffics/GetAllResponse")]
		ObjectModel.Traffic[] GetAll(int count);

		[System.ServiceModel.OperationContractAttribute(Action = "http://monius.logging/soap/traffics/Traffics/GetAll", ReplyAction = "http://monius.logging/soap/traffics/Traffics/GetAllResponse")]
		System.Threading.Tasks.Task<ObjectModel.Traffic[]> GetAllAsync(int count);
	}

	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public interface TrafficsChannel : Traffics, System.ServiceModel.IClientChannel
	{
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	public class TrafficsClient : System.ServiceModel.ClientBase<Traffics>, Traffics
	{
		public TrafficsClient()
		{
		}

		public TrafficsClient(string endpointConfigurationName) :
			base(endpointConfigurationName)
		{
		}

		public TrafficsClient(string endpointConfigurationName, string remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		public TrafficsClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) :
			base(endpointConfigurationName, remoteAddress)
		{
		}

		public TrafficsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
			base(binding, remoteAddress)
		{
		}

		public ObjectModel.Traffic[] GetAll(int count)
		{
			return Channel.GetAll(count);
		}

		public System.Threading.Tasks.Task<ObjectModel.Traffic[]> GetAllAsync(int count)
		{
			return Channel.GetAllAsync(count);
		}
	}
}