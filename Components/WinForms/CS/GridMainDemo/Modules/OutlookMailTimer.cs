using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraBars.Alerter;
using DevExpress.Utils;
using DevExpress.XtraBars;

namespace DevExpress.XtraGrid.Demos {
    public class MailTimer {
        List<Message> list;
        AlertControl control;
        Form form;
        int delay = 15000;
        Timer timer;
        ImageCollection images32;
        Random rnd;
        public MailTimer(List<Message> list, AlertControl control, Form form) {
            this.list = list;
            this.control = control;
            this.form = form;
            timer = new Timer();
            timer.Interval = 5000;
            timer.Tick += new EventHandler(timer_Tick);
            rnd = new Random();
        }

        ImageCollection Images32 {
            get {
                if(images32 == null)
                    images32 = DevExpress.Utils.Controls.ImageHelper.CreateImageCollectionFromResources("DevExpress.XtraGrid.Demos.Images.mail.png", typeof(frmMain).Assembly, new Size(32, 32));
                return images32;
            }
        }

        Image GetMailImage(int data) {
            if(0.Equals(data)) return Images32.Images[1];
            return Images32.Images[0];
        }
        void timer_Tick(object sender, EventArgs e) {
            Timer timer = sender as Timer;
            if(list.Count > 0) {
                Message message = list[rnd.Next(list.Count - 1)];
                ShowAlert(message);
            }
            if(timer.Interval < delay) timer.Interval = delay;
        }

        public void ShowAlert(Message message) {
            InitButtonsStyle(message);
            control.Show(form, message.From, message.Subject, null, GetMailImage(message.Attachment), message);
        }

        void InitButtonsStyle(Message message) {
            control.Buttons["Read"].Down = 1.Equals(message.Read);
            control.Buttons["Attachment"].Visible = 1.Equals(message.Attachment);
        }

        internal void Start() {
            timer.Start();
        }

        internal void Stop() {
            timer.Stop();
        }
    }
}
