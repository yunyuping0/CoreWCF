﻿using System.ServiceModel;

namespace ClientContract
{
	[ServiceContract, XmlSerializerFormat]
	public interface SCInterfaceAB_1144850 : SCInterfaceA_1144850, SCInterfaceB_1144850
	{
		[OperationContract]
		string StringMethodAB(string str);
	}
}
