using System.Web.Mvc;

namespace Sealtech.Weixin.Web.Areas.WeixinManage
{
    public class WeixinManageAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "WeixinManage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "WeixinManage_default",
                "WeixinManage/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}