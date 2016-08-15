using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Web;
using System.Configuration;
using System.Threading.Tasks;
using HelloWorldBusiness.Interface;
using System.Web.Hosting;

namespace HelloWorldBusiness.Service
{
    public class DataSource : IDataSource
    {
        public String getDataString()
        {
            String dataString = String.Empty;
            try
            {
                //Set File Path..
                String filePath = HostingEnvironment.MapPath("~/Data/DataString.txt");

                if (!String.IsNullOrEmpty(filePath))
                {
                    // Get the file path
                    var reader = new StreamReader(filePath);

                    //Read the File
                    dataString = reader.ReadToEnd().ToString();
                }
            }catch(Exception ex)
            {
                throw ex;
            }
            return dataString;
        }
    }
}
