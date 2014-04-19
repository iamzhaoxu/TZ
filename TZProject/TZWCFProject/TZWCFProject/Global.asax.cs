using Ninject;
using Ninject.Web.Common;
using TZWCFProject.Repository;

namespace TZWCFProject
{
    public class Global : NinjectHttpApplication
    {
        protected override IKernel CreateKernel()
        {
            return new StandardKernel(new ServiceModule());
        }
    }
}