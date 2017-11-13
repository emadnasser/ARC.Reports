using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.DXperience.Demos;
using DevExpress.XtraPrinting.Native;


namespace XtraPrintingDemos
{
	public class MainFeaturesControl : TutorialControlBase {
		private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
		private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
		private RichTextBox rtbFeatures;
		private System.ComponentModel.IContainer components = null;

		public MainFeaturesControl()
		{
			// This call is required by the Windows Form Designer.
			InitializeComponent();

            // TODO: Add any initialization after the InitializeComponent call
            System.IO.Stream stream = LoadResource("XtraPrintingDemos.BaseForms.PrintingAbout.rtf");
            rtbFeatures.LoadFile(stream, RichTextBoxStreamType.RichText);
        }
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
			this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
			this.rtbFeatures = new System.Windows.Forms.RichTextBox();
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
			this.xtraTabControl1.SuspendLayout();
			this.xtraTabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// xtraTabControl1
			// 
			this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
			this.xtraTabControl1.Name = "xtraTabControl1";
			this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
			this.xtraTabControl1.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
			this.xtraTabControl1.Size = new System.Drawing.Size(184, 124);
			this.xtraTabControl1.TabIndex = 0;
			this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
			this.xtraTabControl1.Text = "xtraTabControl1";
			// 
			// xtraTabPage1
			// 
			this.xtraTabPage1.Controls.Add(this.rtbFeatures);
			this.xtraTabPage1.Name = "xtraTabPage1";
			this.xtraTabPage1.Size = new System.Drawing.Size(175, 115);
			this.xtraTabPage1.Text = "xtraTabPage1";
			// 
			// rtbFeatures
			// 
			this.rtbFeatures.BackColor = System.Drawing.Color.White;
			this.rtbFeatures.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtbFeatures.Dock = System.Windows.Forms.DockStyle.Fill;
			this.rtbFeatures.ForeColor = System.Drawing.Color.Black;
			this.rtbFeatures.Location = new System.Drawing.Point(0, 0);
			this.rtbFeatures.Name = "rtbFeatures";
			this.rtbFeatures.ReadOnly = true;
			this.rtbFeatures.Size = new System.Drawing.Size(175, 115);
			this.rtbFeatures.TabIndex = 1;
			this.rtbFeatures.Text = "";
            this.rtbFeatures.LinkClicked += new LinkClickedEventHandler(rtbFeatures_LinkClicked);
			// 
			// MainFeaturesControl
			// 
			this.Controls.Add(this.xtraTabControl1);
			this.Name = "MainFeaturesControl";
			this.Size = new System.Drawing.Size(184, 124);
			((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
			this.xtraTabControl1.ResumeLayout(false);
			this.xtraTabPage1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
        #endregion

        void rtbFeatures_LinkClicked(object sender, LinkClickedEventArgs e) {
            ProcessLaunchHelper.StartProcess(e.LinkText);
        }

        static System.IO.Stream LoadResource(string name) {
            return FindStream(name, System.Reflection.Assembly.GetExecutingAssembly());
        }
        static System.IO.Stream FindStream(string name, System.Reflection.Assembly asm) {
            System.IO.Stream stream = asm.GetManifestResourceStream(name);
            if(stream == null) {
                string[] names = name.Split('.');
                if(names.Length >= 2)
                    stream = asm.GetManifestResourceStream(string.Format("{0}.{1}", names.GetValue(names.Length - 2), names.GetValue(names.Length - 1)));
            }
            return stream;
        }
    }
}

