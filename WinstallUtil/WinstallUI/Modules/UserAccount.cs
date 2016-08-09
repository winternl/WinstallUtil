using System.Diagnostics;
using System.DirectoryServices.AccountManagement;

namespace WinstallUI.Modules
{
    public static class clsUserAccount
    {
        public static void Create(string strUsername, string strPassword, bool bAdmin)
        {
            if (string.IsNullOrEmpty(strUsername) ||
                strUsername.Length > 104 ||
                string.IsNullOrEmpty(strPassword) ||
                 strPassword.Length > 127)
                return;

            PrincipalContext pContext = new PrincipalContext(ContextType.Machine);

            if (UserPrincipal.FindByIdentity(pContext, strUsername) != null)
            {
                return;
            }

            UserPrincipal user = new UserPrincipal(pContext)
            {
                Enabled = true,
                Name = strUsername,
                UserCannotChangePassword = false,
                PasswordNeverExpires = true,
                PasswordNotRequired = false
            };

            user.SetPassword(strPassword);
            user.Save();

            if (bAdmin)
            {

                var grpAdmin = GroupPrincipal.FindByIdentity(pContext, IdentityType.SamAccountName, "Administrators");
                Debugger.Break();
            }

            //bool bIsAlreadyUser = false;
            //bool bIsAlreadyAdmin = false;

            //foreach (Principal p in user.GetAuthorizationGroups())
            //{
            //    if (p is GroupPrincipal)
            //    {
            //        var gp = (GroupPrincipal)p;

            //        if (gp.SamAccountName == "Users")
            //            bIsAlreadyUser = true;

            //        if (gp.SamAccountName == "Administrators")
            //            bIsAlreadyAdmin = true;
            //    }
            //}

            //foreach (Principal p in user.GetAuthorizationGroups())
            //{
            //    if (p is GroupPrincipal)
            //    {
            //        var gp = (GroupPrincipal)p;

            //        //if (gp.SamAccountName == "Users" && !bIsAlreadyUser)
            //        //    gp.Members.Add(user);

            //        if (gp.SamAccountName == "Administrators" && !bIsAlreadyAdmin)
            //            gp.Members.Add(user);
            //    }
            //}
        }
    }
}