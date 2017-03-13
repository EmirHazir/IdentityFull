using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPot.Models
{
    [AttributeUsage(AttributeTargets.Method)]
    public class CostumAuthorizeAttribute : AuthorizeAttribute
    {
        public string ViewName { get; set; }

        public CostumAuthorizeAttribute()
        {
            ViewName = "AutorizeFailed";
        }

        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            base.OnAuthorization(filterContext);
            IsUserAuthorized(filterContext);
        }

        void IsUserAuthorized(AuthorizationContext filterContext)
        {
            //kullanıcı authorized
            if (filterContext.Result == null)
            {
                return;
            }

            if (filterContext.HttpContext.User.Identity.IsAuthenticated)
            {
                ViewDataDictionary dic = new ViewDataDictionary();
                dic.Add("Message", "Bu alan için yetki sahibi değilsiniz");
                var result = new ViewResult() { ViewName = this.ViewName, ViewData = dic };
                filterContext.Result = result;
            }
        }
    }
}