using System;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using ProyectoEFE.Models;

namespace ProyectoEFE.Account
{
    public partial class Register : Page
    {


        protected void CreateUser_Click(object sender, EventArgs e)
        {
            string picture = null;
            if (this.selectgender.Value.ToString() == "Hombre")
            {
                picture = "/images/Male.png";
            }
            else
            {
                picture = "/images/Woman.png";
            }



            DateTime birthday = Convert.ToDateTime(BirthDay.Text);

            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text, FirstName = FirstName.Text, LastName = LastName.Text, BirthDay = birthday, NickName = NickName.Text, Role = this.selectRol.Value.ToString(), ProfilePicture = picture,  Gender = this.selectgender.Value.ToString() };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}