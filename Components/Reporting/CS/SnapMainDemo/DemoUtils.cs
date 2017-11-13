using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DevExpress.Snap;
using DevExpress.XtraEditors;
using DevExpress.XtraRichEdit;

namespace SnapDemos {
    public class SnapDemoExceptionsHandler {
        readonly SnapControl control;
        public SnapDemoExceptionsHandler(SnapControl control) {
            this.control = control;
        }
        public void Install() {
            if (control != null)
                control.UnhandledException += OnSnapControlUnhandledException;
        }

        protected virtual void OnSnapControlUnhandledException(object sender, RichEditUnhandledExceptionEventArgs e) {
            try {
                if (e.Exception != null)
                    throw e.Exception;
            }
            catch (RichEditUnsupportedFormatException ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (ExternalException ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
            catch (IOException ex) {
                XtraMessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
    }
}
