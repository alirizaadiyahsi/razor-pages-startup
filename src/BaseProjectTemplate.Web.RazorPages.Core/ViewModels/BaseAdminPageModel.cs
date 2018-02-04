using BaseProjectTemplate.Web.Core.Models;

namespace BaseProjectTemplate.Web.Core.ViewModels
{
    public class BaseAdminPageModel : BasePageModel
    {
        public void SetViewMessage(ViewMessage viewMessage)
        {
            TempData["StatusMessage"] = viewMessage;
        }
    }
}