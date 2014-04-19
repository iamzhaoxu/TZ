using System.IO;
using System.Web.Hosting;

namespace TZWCFProject.Repository
{
    /// <summary>
    /// The repository to provide locker bank xml.
    /// </summary>
    public class LockBankXMLRepository : ILockBankXMLRepository
    {
        /// <summary>
        /// Get locker bank data from the xml file.
        /// </summary>
        /// <returns></returns>
        public string GetLockerBankXML()
        {
            string path = HostingEnvironment.MapPath("~/app_data/LockerBank.xml");
            string xml = string.Empty;
            if (File.Exists(path))
            {
                xml = File.ReadAllText(path);
            }
            return xml;
        }
    }
}