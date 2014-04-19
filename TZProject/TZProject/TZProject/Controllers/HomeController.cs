using System;
using System.IO;
using System.Web.Mvc;
using System.Xml.Serialization;
using TZProject.Models;
using TZProject.Repository;

namespace TZProject.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Locker bank repository which can provide the locker information.
        /// </summary>
        private ILockerBankRepository _lockerBankRepository;

        /// <summary>
        /// Home controller for the locker bank ui.
        /// </summary>
        /// <param name="lockerBankRepository"></param>
        public HomeController(ILockerBankRepository lockerBankRepository)
        {
            _lockerBankRepository = lockerBankRepository;
        }

        /// <summary>
        /// The index action to render the locker ui.
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            try
            {
                XmlSerializer mySerializer = new XmlSerializer(typeof(LockerBank));
                // Get the xml from locker bank.
                string xml = _lockerBankRepository.GetLockerBankXML();
                using (TextReader reader = new StringReader(xml))
                {
                    //Deserialize xml to locker bank object, which is the model of the view.
                    LockerBank lockerBank = (LockerBank)mySerializer.Deserialize(reader);
                    return View(lockerBank);
                }
            }
            catch
            {
                // Any exception will lead to the error page.
                return View("~/Views/Shared/Error.cshtml");
            }        
        }
    }
}
