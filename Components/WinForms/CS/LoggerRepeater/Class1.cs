using System;

using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using System.IO;
using DevExpress.Xpo.DB;
using DevExpress.Xpo;

namespace LoggerRepeater {
	public class Logger : DataStoreLogger {
		public Logger()
			: base(XpoDefault.GetConnectionProvider(AutoCreateOption.DatabaseAndSchema), Console.Out) {
			Console.WriteLine("Logger created.");
		}
		~Logger() {
			Console.WriteLine("Logger finalized.");
		}
	}

	class Program {
		public static int Port = 4001;
		public static string ObjectUri = "Server";
		public static bool RemotingParametersPassed = false;
		public static string RemotingConfigFileName = Assembly.GetExecutingAssembly().Location + ".config";
		static void Main(string[] args) {
			try {
				ParseArgs(args);
				ConfigureRemoting();
				Console.WriteLine("Log requests for {0}", XpoDefault.ActiveConnectionString);
				LogUrls();
				Console.ReadLine();
			} catch(Exception e) {
				Console.WriteLine();
				Console.WriteLine("Exception: {0}", e);
				Console.WriteLine();
			}
		}
		public static void LogUrls() {
			Console.WriteLine("Listen for requests on:");
			foreach(WellKnownServiceTypeEntry wksty in RemotingConfiguration.GetRegisteredWellKnownServiceTypes()) {
				foreach(IChannel ch in ChannelServices.RegisteredChannels) {
					IChannelReceiver rch = ch as IChannelReceiver;
					if(rch == null)
						continue;
					foreach(string s in rch.GetUrlsForUri(wksty.ObjectUri)) {
						Console.WriteLine("\t{0}", s);
					}
				}
			}
		}

		public const string InvalidArgumentText = @"command-line args
LoggedProviderConnectionString
/u:ObjectUri
/p:TcpPort

LoggedProviderConnectionStrings may be something like
tcp://localhost:4001/Server
XpoProvider=MSSqlServer;data source=(local);integrated security=SSPI;initial catalog=MyTestDatabase
etc...";

		static void ParseArgs(string[] args) {
			if(args == null)
				return;
			foreach(string arg in args) {
				if(arg.StartsWith("/")) {
					if(arg.Length < 2)
						throw new ApplicationException(InvalidArgumentText);
					char switcher = char.ToLower(arg[1]);
					string argValue = arg.Substring(2);
					if(argValue.StartsWith(":"))
						argValue = argValue.Substring(1);
					if(argValue.Length == 0)
						throw new ApplicationException(InvalidArgumentText);
					switch(switcher) {
						case 'p':
							Port = Int32.Parse(argValue);
							RemotingParametersPassed = true;
							break;
						case 'u':
							ObjectUri = argValue;
							RemotingParametersPassed = true;
							break;
						default:
							throw new ApplicationException(InvalidArgumentText);
					}
				} else {
					if(XpoDefault.ConnectionString != null)
						throw new ApplicationException(InvalidArgumentText);
					XpoDefault.ConnectionString = arg;
				}
			}
		}

		public static void ConfigureRemoting() {
			if(!RemotingParametersPassed && !File.Exists(RemotingConfigFileName))
				RemotingParametersPassed = true;
			if(RemotingParametersPassed) {
				ChannelServices.RegisterChannel(new TcpChannel(Port), false);
				RemotingConfiguration.RegisterWellKnownServiceType(typeof(Logger), ObjectUri, WellKnownObjectMode.Singleton);
			} else {
				RemotingConfiguration.Configure(RemotingConfigFileName, false);
			}
		}

	}
}
