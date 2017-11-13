using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid.Data;
using DevExpress.Utils;
using System.IO;
using DevExpress.XtraPivotGrid;
using DevExpress.XtraEditors;

namespace PivotGridOlapBrowser.Dialogs {
	public partial class ConnectionDesigner : XtraForm {
        static string sampleFileName;
        static string GetNorthwindFileName() {
            return "Data\\Northwind.cub";
        }

        readonly AdomdMetaGetter metaGetter;		
        readonly ExistingConnections connections;		

		public ConnectionDesigner() {
			InitializeComponent();
            this.metaGetter = new AdomdMetaGetter();
			UpdateControls();
			buttonSample.Visible = !string.IsNullOrEmpty(SampleFileName);
            this.connections = new ExistingConnections();
            this.connections.FillList(existingList, false);
            if(existingList.Items.Count > 0) {
                chkExisting.Checked = true;
                existingList.Focus();
                existingList.SelectedIndex = 0;
            } else {
                chkNew.Checked = true;
                radioServer.Focus();
                ShowHideConnections(false);
            }
		}
        void ShowHideConnections(bool show) {
            if(chkExisting.Enabled == show) return;
            chkExisting.Enabled = show;
            existingList.Visible = show;
            int sign = show ? +1 : -1;
            foreach(Control control in Controls) {
                if(control == existingList || control is SimpleButton) continue;
                if(control.Top > existingList.Top)
                    control.Top += sign * (existingList.Height + 16);
            }
            Height += sign * (existingList.Height + 16);
        }

        public string ConnectionString {
            get {
                if(chkNew.Checked)
                    return "Provider=msolap;Data Source=" + editServer.Text +
                        ";Initial Catalog=" + (string)listCatalog.EditValue +
                        ";Cube Name=" + (string)listCube.EditValue;
                else
                    return (string)existingList.SelectedItem;
            }
        }
        public static string SampleConnectionString {
            get {
                if(string.IsNullOrEmpty(SampleFileName)) return null;
                return "Provider=msolap;Data Source=" + SampleFileName + ";Initial Catalog=Northwind;Cube Name=Northwind";
            }
        }
        protected static string SampleFileName {
            get {
                if(string.IsNullOrEmpty(sampleFileName)) {
                    string fileName = FilesHelper.FindingFileName(Application.StartupPath, GetNorthwindFileName());
                    if(File.Exists(fileName)) {
                        sampleFileName = Path.GetFullPath(fileName);
						if(File.Exists(sampleFileName))
							try {
								File.SetAttributes(sampleFileName, FileAttributes.Normal);
							} catch { }
                    }
                }
                return sampleFileName;
            }
        }

        protected override void OnClosing(CancelEventArgs e) {
            base.OnClosing(e);
            this.metaGetter.Dispose();
        }
        
		void radioButton_CheckedChanged(object sender, EventArgs e) {
			UpdateControls();
		}

		bool wasServer = true;
		string serverName, fileName;
		void UpdateControls() {
			if(wasServer) serverName = editServer.Text;
			else fileName = editServer.Text;

			bool useServer = radioServer.Checked;			
			editServer.Properties.Buttons[0].Visible = !useServer;
			editServer.Text = useServer ? serverName : fileName;
			labelServer.Text = useServer ? "Server" : "File";
			listCatalog.Enabled = useServer;
			labelCatalog.Enabled = useServer;
			listCube.Enabled = useServer;
			labelCube.Enabled = useServer;			
			wasServer = useServer;
		}

		private void editServer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e) {
			using(OpenFileDialog dialog = new OpenFileDialog()) {
				dialog.Filter = "Cube files (*.cub)|*.cub";
				if(dialog.ShowDialog() == DialogResult.OK) {
					OpenCubeFile(dialog.FileName);
				}
			}
		}

		bool OpenCubeFile(string fileName) {
			return OpenCubeFile(fileName, true);
		}
		bool OpenCubeFile(string fileName, bool showBalloons) {
			try {
				editServer.Text = fileName;
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) {
					if(showBalloons) ShowBalloon("Invalid cube file.", "Error", editServer);
					return false;
				}
				List<string> catalogs = metaGetter.GetCatalogs();
				if(catalogs == null || catalogs.Count == 0) {
					if(showBalloons) ShowBalloon("There is no catalogs in the cube file.", "Error", editServer);
					return false;
				}
				listCatalog.EditValue = catalogs[0];
				List<string> cubes = metaGetter.GetCubes(catalogs[0]);
				if(cubes == null || cubes.Count == 0) {
					if(showBalloons) ShowBalloon("There is no cubes in the cube file.", "Error", editServer);
					return false;
				}
				listCube.EditValue = cubes[0];
				return true;
			} finally {
				metaGetter.Connected = false;
			}
		}

		void ShowBalloon(string text, string caption, Control control) {
			ToolTipControllerShowEventArgs eShow = toolTipController1.CreateShowArgs();
			eShow.ToolTip = text;
			eShow.Title = caption;
			eShow.IconType = ToolTipIconType.Error;
			eShow.IconSize = ToolTipIconSize.Small;
			toolTipController1.ShowHint(eShow, control);
		}

		void listCatalog_QueryPopUp(object sender, CancelEventArgs e) {
			if(!String.IsNullOrEmpty(editServer.Text)) {
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) ShowBalloon("Couldn't connect to the server.", "Error", editServer);
				List<string> catalogs = metaGetter.GetCatalogs();
				if(catalogs != null) {
					listCatalog.Properties.Items.Clear();
					listCatalog.Properties.Items.AddRange(catalogs);
					e.Cancel = false;
				} else e.Cancel = true;
			} else e.Cancel = true;
		}

		void listCube_QueryPopUp(object sender, CancelEventArgs e) {
			if(!String.IsNullOrEmpty(editServer.Text)) {
				metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
				if(!metaGetter.Connected) {
					ShowBalloon("Couldn't connect to the server.", "Error", editServer);
					e.Cancel = true;
					return;
				}
				string catalogName = null;
				if(!String.IsNullOrEmpty((string)listCatalog.EditValue)) {
					catalogName = (string)listCatalog.EditValue;
					metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;
				}
				if(!metaGetter.Connected) {
					ShowBalloon("Couldn't connect to the \"" + catalogName + "\" database.", "Error", listCatalog);
					e.Cancel = true;
					return;
				}
				List<string> cubes = metaGetter.GetCubes(catalogName);
				if(cubes != null) {
					listCube.Properties.Items.Clear();
					if(cubes.Count == 0) {
						ShowBalloon("There are no cubes in the \"" + catalogName + "\" database.", "Error", listCube);
						e.Cancel = true;
						return;
					}
					listCube.Properties.Items.AddRange(cubes);
					e.Cancel = false;
				} else e.Cancel = true;
			} else e.Cancel = true;
		}

		void simpleButton1_Click(object sender, EventArgs e) {						
			radioFile.Checked = true;
			if(OpenCubeFile(sampleFileName))
				DialogResult = DialogResult.OK;
		}

		void buttonOK_Click(object sender, EventArgs e) {
            if(chkNew.Checked) {
                if(radioServer.Checked)
                    ConnectToServer();
                else
                    ConnectToCubeFile();
            } else {
                if(string.IsNullOrEmpty((string)existingList.SelectedItem)) {
                    ShowBalloon("Please select connection string.", "Error", existingList);
                    return;
                }
                DialogResult = DialogResult.OK;
            }
		}

		void ConnectToCubeFile() {
			if(string.IsNullOrEmpty(editServer.Text) ||
				string.IsNullOrEmpty(listCatalog.EditValue as string) || string.IsNullOrEmpty(listCube.EditValue as string)) return;
            AddConnectionString();
			DialogResult = DialogResult.OK;            
		}
		void ConnectToServer() {
			string server = radioServer.Checked ? "server" : "cube file";
			if(String.IsNullOrEmpty(editServer.Text)) {
				ShowBalloon("Please specify the " + server + ".", "Error", editServer);
				return;
			}
			metaGetter.ConnectionString = "Provider=msolap;Data Source=" + editServer.Text;
			if(!metaGetter.Connected) {
				ShowBalloon("Couldn't connect to the " + server + ". Please check that it is correct.", "Error", editServer);
				return;
			}
			string catalogName = (string)listCatalog.EditValue;
			if(!String.IsNullOrEmpty(catalogName))
				metaGetter.ConnectionString += ";Initial Catalog=" + catalogName;
			else {
				ShowBalloon("Please specify the database name.", "Error", listCatalog);
				return;
			}
			if(!metaGetter.Connected) {
				ShowBalloon("Couldn't connect to the \"" + catalogName + "\" database. Please check that it is correct.", "Error", listCatalog);
				return;
			}
			List<string> cubes = metaGetter.GetCubes(catalogName);
			if(cubes != null) {
				string cubeName = (string)listCube.EditValue;
				if(string.IsNullOrEmpty(cubeName)) {
					ShowBalloon("Please specify the cube name.", "Error", listCube);
					return;
				}
				if(!cubes.Contains(cubeName)) {
					ShowBalloon("Couldn't connect to the \"" + cubeName + "\" cube. Please check that it is correct.", "Error", listCube);
					return;
				}
			}
            AddConnectionString();
			DialogResult = DialogResult.OK;
		}
        void AddConnectionString() {
            this.connections.Add(existingList, ConnectionString);
            ShowHideConnections(true);
        }
        void listCatalog_SelectedValueChanged(object sender, EventArgs e) {
			listCube.EditValue = "";
		}
        void editServer_EditValueChanged(object sender, EventArgs e) {
            chkNew.Checked = true;
        }
        void listCatalog_EditValueChanged(object sender, EventArgs e) {
            chkNew.Checked = true;
        }
        void listCube_EditValueChanged(object sender, EventArgs e) {
            chkNew.Checked = true;
        }
        void radioServer_EditValueChanged(object sender, EventArgs e) {
            chkNew.Checked = true;
        }
	}

    class ExistingConnections {
        string fileName;
        string FileName {
            get {
                if(string.IsNullOrEmpty(fileName)) {
                    const string csFile = "connection_strings.txt";
                    using(FileStream fs = GetType().Assembly.GetFiles()[0]) {
                        string dir = Path.GetDirectoryName(fs.Name);
                        fileName = Path.Combine(dir, csFile);
                    }
                }
                return fileName;
            }
        }

        public void FillList(ListBoxControl listBox, bool clearingRequired) {
            List<string> list = Load();
            if(clearingRequired) listBox.Items.Clear();
            listBox.Items.AddRange(list.ToArray());
        }
        public void Add(ListBoxControl listBox, string connectionString) {
            if(Add(connectionString))
                listBox.Items.Add(connectionString);
        }
        protected bool Add(string connectionString) {
            List<string> list = Load();
            bool notContains = !list.Contains(connectionString);
            if(notContains) {
                list.Add(connectionString);
                Save(list);
            }
            return notContains;
        }

        List<string> Load() {
            List<string> list = new List<string>();
            if(!File.Exists(FileName))
                return list;
            using(StreamReader reader = new StreamReader(FileName)) {
                while(!reader.EndOfStream) {
                    string line = reader.ReadLine();
                    list.Add(line);
                }
            }
            return list;
        }
        void Save(List<string> list) {
            using(StreamWriter writer = new StreamWriter(FileName, false)) {
                foreach(string str in list) {
                    writer.WriteLine(str);
                }
            }
        }
    }
}

