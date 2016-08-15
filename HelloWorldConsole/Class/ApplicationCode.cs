using HelloWorldConsole.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldConsole.Class
{
    public class ApplicationCode
    {
        IServiceAccess serviceAccess;

        public ApplicationCode()
        {

        }

        public ApplicationCode(IServiceAccess serviceAccess)
        {
            this.serviceAccess = serviceAccess;
        }

        public String Run()
        {
            try
            {
                if(serviceAccess==null)
                serviceAccess = new ServiceAccess();

                return serviceAccess.getDataString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Source);
            }
            return String.Empty;
        }
    }
}
