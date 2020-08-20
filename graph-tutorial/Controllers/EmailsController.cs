using graph_tutorial.Helpers;
using System;
using System.Threading.Tasks;
using System.Web.Mvc;


namespace graph_tutorial.Controllers
{
    public class EmailsController : BaseController
    {
        // GET: Calendar
        [Authorize]
        public async Task<ActionResult> Index()
        {
            var emails = await GraphHelper.GetmessagesAsync();
            return View(emails);
        }
    }
}
