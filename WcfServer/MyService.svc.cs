using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServer
{
	public class MyService : IMyService
	{
		public string Echo(string input)
		{
			return input;
		}
	}
}
