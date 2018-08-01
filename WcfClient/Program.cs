using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfClient
{
	public class Program
	{
		static void Main(string[] args)
		{
			var sw = new Stopwatch();

			using (var myService = new MyServiceClient.MyServiceClient())
			{
				for (int i = 1; i <= 20; i++)
				{
					sw.Restart();

					var result = myService.Echo("Blaaah!");

					Console.WriteLine($"{i}\t{sw.ElapsedMilliseconds:n0}ms");
				}
			}

			Console.ReadLine();
			
		}
	}
}
