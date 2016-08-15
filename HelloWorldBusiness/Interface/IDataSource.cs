using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldBusiness.Interface
{
    public interface IDataSource
    {
        //Method to read Data File and Get Data.
        String getDataString();
    }
}
