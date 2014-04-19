using TZWCFProject.Repository;

namespace TZWCFProject
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class TZService : ITZService
    {
        private ILockBankXMLRepository _lockBankXMLRepository;

        public TZService(ILockBankXMLRepository lockBankXMLRepository)
        {
            _lockBankXMLRepository = lockBankXMLRepository;
        }

        /// <summary>
        /// Web inferface which can get locker bank xml.
        /// </summary>
        /// <returns></returns>
        public string GetLockerBankXML()
        {
            return _lockBankXMLRepository.GetLockerBankXML();
        }
    }
}
