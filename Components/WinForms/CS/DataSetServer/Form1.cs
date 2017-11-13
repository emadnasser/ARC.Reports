using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using System.IO;
using System.Reflection;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
using DevExpress.Xpo.DB;

namespace DataSetServerDemo {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public partial class Form1 : System.Windows.Forms.Form {
        [STAThread]
        static void Main(string[] args) {
            try {
                ParseParameters(args);
                ReadDatabase();
                ConfigureRemoting();

                Application.Run(new Form1());
            }
            catch(Exception e) {
                MessageBox.Show(e.ToString(), "DataSetServerDemo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
        public static string DataSetFileName = Assembly.GetExecutingAssembly().Location + ".DataSet";
        public static string RemotingConfigFileName = Assembly.GetExecutingAssembly().Location + ".config";
        public static DataSet Data = new DataSet("DataSetServerDemo");
        public static string ObjectUri = "Server";
        public static int Port = 4001;
        public static bool RemotingParametersPassed = false;
        public const string InvalidArgumentText = @"command-line args
/d:DataSetFileName
/u:ObjectUri
/p:TcpPort";
        public Form1() {
            InitializeComponent();

            string urls = string.Empty;
            foreach(WellKnownServiceTypeEntry wksty in RemotingConfiguration.GetRegisteredWellKnownServiceTypes()) {
                foreach(IChannel ch in ChannelServices.RegisteredChannels) {
                    IChannelReceiver rch = ch as IChannelReceiver;
                    if(rch == null)
                        continue;
                    foreach(string s in rch.GetUrlsForUri(wksty.ObjectUri)) {
                        urls += s + ' ';
                    }
                }
            }

            this.Text = urls + "- DataSetServer demo";
        }

        private void btnTerminate_Click(object sender, System.EventArgs e) {
            this.Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e) {
            SaveDatabase();
        }

        private void btnExit_Click(object sender, System.EventArgs e) {
            SaveDatabase();
            this.Close();
        }

        public static void SaveDatabase() {
            lock(Data) {
                Data.WriteXml(DataSetFileName, XmlWriteMode.WriteSchema);
            }
        }

        public static void ReadDatabase() {
            lock(Data) {
                try {
                    Data.ReadXml(DataSetFileName, XmlReadMode.ReadSchema);
                }
                catch(System.IO.FileNotFoundException) {
                    //Console.Write("{0}\tFile not found, using empty DataSet", Environment.NewLine);
                }
                /*
            catch(Exception e) {
                Console.WriteLine("Exception:{0}{1}", Environment.NewLine, e);
                return;
            }
                 */
            }
        }

        public static void ConfigureRemoting() {
            if(!RemotingParametersPassed && !File.Exists(RemotingConfigFileName))
                RemotingParametersPassed = true;
            if(RemotingParametersPassed) {
                ChannelServices.RegisterChannel(new TcpChannel(Port), false);
                RemotingConfiguration.RegisterWellKnownServiceType(typeof(DataSetServer), ObjectUri, WellKnownObjectMode.Singleton);
            }
            else {
                RemotingConfiguration.Configure(RemotingConfigFileName, false);
            }
        }



        public static void ParseParameters(string[] args) {
            if(args == null)
                return;
            foreach(string arg in args) {
                if(arg.Length < 2 || arg[0] != '/')
                    throw new ApplicationException(InvalidArgumentText);
                char switcher = char.ToLower(arg[1]);
                string argValue = arg.Substring(2);
                if(argValue.StartsWith(":"))
                    argValue = argValue.Substring(1);
                if(argValue.Length == 0)
                    throw new ApplicationException(InvalidArgumentText);
                switch(switcher) {
                    case 'd':
                        DataSetFileName = argValue;
                        break;
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
            }
        }

    }

    /*
    public class DataSetServer : ConnectionProviderCacheRoot {
        public DataSetServer()
            : base(new InMemoryConnectionProvider(Form1.Data, AutoCreateOption.SchemaOnly)) { }
    }
    */

    public class DataSetServer : DataSetDataStore {
        public DataSetServer()
            : base(Form1.Data, AutoCreateOption.SchemaOnly) { }
    }
}
