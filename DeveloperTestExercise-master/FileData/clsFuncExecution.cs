using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThirdPartyTools;

namespace FileData
{
    public class clsFuncExecution
    {
        public string funcexecution(string ftype, string filename)
        {
            string returnValue;
            FileDetails obj = new FileDetails();
            switch (ftype)
            {
                case "-v":
                    returnValue = String.Format("File Version: {0}", obj.Version(filename));
                    break;
                case "--v":
                    returnValue = String.Format("File Version: {0}", obj.Version(filename));
                    break;
                case "/v":
                    returnValue = String.Format("File Version: {0}", obj.Version(filename));
                    break;
                case "--version":
                    returnValue = String.Format("File Version: {0}", obj.Version(filename));
                    break;


                case "-s":
                    returnValue = String.Format("File Size: {0}", obj.Size(filename)); 
                    break;
                case "--s":
                    returnValue = String.Format("File Size: {0}", obj.Size(filename));
                    break;
                case "/s":
                    returnValue = String.Format("File Size: {0}", obj.Size(filename));
                    break;
                case "--size":
                    returnValue = String.Format("File Size: {0}", obj.Size(filename));
                    break;
                default:
                    returnValue = string.Format("Please enter correct values {0}", ftype);
                    break;
            }
            return returnValue;
        }
    }
}

