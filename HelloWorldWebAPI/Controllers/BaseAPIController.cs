using System;
using System.Collections.Generic;
using System.Configuration;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldWebAPI.Controllers
{
    public partial class BaseAPIController : ApiController
    {
        public string WriteToDatabase(string message)
        {
           var status = string.Empty;
           HelloWorldEntityModel model = new HelloWorldEntityModel();
         
           //Use for future writing to the database
            return status;
        }

        public void WriteToLogFile(string message)
        {
            string mydocpath = ConfigurationManager.AppSettings["LogFileLocation"];

            
            using (StreamWriter outputFile = new StreamWriter(mydocpath + @"\LogFile.txt", true))
            {
                outputFile.WriteLine(message);
            }
        }
    }
}
