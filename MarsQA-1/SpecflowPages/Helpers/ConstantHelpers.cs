using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AventStack.ExtentReports;
namespace MarsQA_1.Helpers
{
    public class ConstantHelpers
    {
        //Base Url
        public static string Url = "http://192.168.99.100:5000/";
        
        //ScreenshotPath
        public static string ScreenshotPath = @"C:\Advance task\MarsQA-1\TestReports\Screenshots\Dhanashree";

        //ExtentReportsPath
        public static string ReportsPath = @"C:\Advance task\MarsQA-1\TestReports\MyReport.html";

        //ReportXML Path
        public static string ReportXMLPath = @"C:\Advance task\MarsQA-1\Helpers\AdvanceTask_XMLFile.xml";
        
    }
}