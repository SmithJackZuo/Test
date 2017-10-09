using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CenterWebMake.Fliters
{
    public class AuthorizePlusAttribute : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            if (filterContext.HttpContext.Session["UserName"] != null && filterContext.HttpContext.Session["password"] != null)
            {
                //验证成功
               
            }
            else
            {
                //验证失败
                filterContext.HttpContext.Response.Redirect("~/BackStage/Login");
            }
        }
    }
}
