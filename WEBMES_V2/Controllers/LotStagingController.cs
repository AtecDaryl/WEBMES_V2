using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WEBMES_V2.Controllers
{
    [Authorize(Policy = "UserCred")]
    public class LotStagingController : Controller
    {
        #region Lot Transaction Staging

        public IActionResult LotTransactionStaging()
        {
            return View();
        }



        #endregion
    }
}
