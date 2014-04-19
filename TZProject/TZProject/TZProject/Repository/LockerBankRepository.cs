using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TZProject.TZService;

namespace TZProject.Repository
{
    public class LockerBankRepository : ILockerBankRepository
    {
        private readonly string TZServiceEndpotinBindingName = "BasicHttpBinding_ITZService";

        public string GetLockerBankXML()
        {
            using (TZServiceClient client = new TZServiceClient(TZServiceEndpotinBindingName))
            {
                return client.GetLockerBankXML();
            }
        }
    }
}