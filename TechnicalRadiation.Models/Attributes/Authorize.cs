using System.Web.Mvc;

namespace TechnicalRadiation.Models.Attributes
{
    public class Authorize : ActionFilterAttribute
    {
        string key = "";
        string value = "";
/* 
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            // pre-processing
            Debug.WriteLine("ACTION 1 DEBUG pre-processing logging");
        }
*/
    }
}