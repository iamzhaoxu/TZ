using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TZWCFProject.Repository;

namespace TZWCFProject.Repository
{
    public class ServiceModule : NinjectModule
    {
        public override void Load()
        {
            //Register the Lock Bank xml repository to the interface.
            this.Bind<ILockBankXMLRepository>().To<LockBankXMLRepository>();
            //this.Bind<ILockBankXMLRepository>().To<MockedLockerBankRepository>();
        }
    }
}