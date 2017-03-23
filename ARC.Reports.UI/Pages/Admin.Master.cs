using System;
using System.Linq;
using System.Web.Security;

namespace ARC.Reports.Pages
{
    public partial class AdminMaster : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //IsExist();
        }

        private void IsExist()
        {
            try
            {
                if (Request.LogonUserIdentity?.User != null)
                {
                    string id = Request.LogonUserIdentity.Name.Trim();

                    if (Membership.GetUser(id) == null)
                    {
                        Server.Transfer("~/Public/Unauthorized.aspx");
                    }
                    else
                    {
                        if (!Roles.GetRolesForUser(id).Contains("Admins"))
                        {
                            Server.Transfer("~/Public/Unauthorized.aspx");
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}