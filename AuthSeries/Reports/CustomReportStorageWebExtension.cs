using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.XtraReports.UI;
using Microsoft.AspNetCore.Hosting;
using StudentWebAPI.Reports;

namespace StudentWebAPI
{ 
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        readonly string ReportDirectory;
        const string FileExtension = ".repx";
        public CustomReportStorageWebExtension(IWebHostEnvironment env) {
            ReportDirectory = Path.Combine(env.ContentRootPath, "Reports");
            if (!Directory.Exists(ReportDirectory)) {
                Directory.CreateDirectory(ReportDirectory);
            }
        }

        private bool IsWithinReportsFolder(string url, string folder) {
            var rootDirectory = new DirectoryInfo(folder);
            var fileInfo = new FileInfo(Path.Combine(folder, url));
            return fileInfo.Directory.FullName.ToLower().StartsWith(rootDirectory.FullName.ToLower());
        }

        public override bool CanSetData(string url) {
            // Determines whether or not it is possible to store a report by a given URL. 
            // For instance, make the CanSetData method return false for reports that should be read-only in your storage. 
            // This method is called only for valid URLs (i.e., if the IsValidUrl method returned true) before the SetData method is called.

            return true;
        }

        public override bool IsValidUrl(string url) {
            // Determines whether or not the URL passed to the current Report Storage is valid. 
            // For instance, implement your own logic to prohibit URLs that contain white spaces or some other special characters. 
            // This method is called before the CanSetData and GetData methods.

            return Path.GetFileName(url) == url;
        }

        public override byte[] GetData(string url) {
            // Returns report layout data stored in a Report Storage using the specified URL. 
            // This method is called only for valid URLs after the IsValidUrl method is called.
            try {
                if (Directory.EnumerateFiles(ReportDirectory).Select(Path.GetFileNameWithoutExtension).Contains(url))
                {
                    return File.ReadAllBytes(Path.Combine(ReportDirectory, url + FileExtension));
                }
                string reportName = url;
                string[] parameter = new string[20];
                string paramName = "";
                string paramValue = "";
                if (url.IndexOf("?")!=-1)
                {
                    reportName = url.Substring(0, url.IndexOf("?"));
                   
                    //var report = ReportsFactory.Reports[url]();
                    parameter = url.Substring(url.IndexOf("?") + 1, url.Length - reportName.Length-1).Split('&');
                    
                }
                var report = ReportsFactory.Reports[reportName]();

                //if (ReportsFactory.Reports.ContainsKey(reportName))
                if (ReportsFactory.Reports.ContainsKey(reportName))
                // if (report.)
                {
                                       using (MemoryStream ms = new MemoryStream()) {
                        // ReportsFactory.Reports[url]().RequestParameters = false;
                        //ReportsFactory.Reports[url]().SaveLayoutToXml(ms);
                        if (parameter.Length>0)
                        {
                            for (int i = 0; i < parameter.Length; i++)
                            {
                                paramName = parameter[i].Split('=')[0];
                                paramValue = parameter[i].Split('=')[1];
                                report.Parameters[paramName].Value = paramValue;
                                report.Parameters[paramName].Visible = true;
                            }
                           
                            report.RequestParameters = false;
                        }
                        
                        //report.SaveLayoutToXml(ms);
                        //return stream.ToArray();
                        //XtraReport1 report = new XtraReport1();
                        //report.RequestParameters = false;
                        report.SaveLayoutToXml(ms);
                        return ms.ToArray();
                    }
                }
            } catch (Exception ex) {
                throw new DevExpress.XtraReports.Web.ClientControls.FaultException("Could not get report data.", ex);
            }
            throw new DevExpress.XtraReports.Web.ClientControls.FaultException(string.Format("Could not find report '{0}'.", url));
        }

        public override Dictionary<string, string> GetUrls() {
            // Returns a dictionary of the existing report URLs and display names. 
            // This method is called when running the Report Designer, 
            // before the Open Report and Save Report dialogs are shown and after a new report is saved to a storage.
            
            return Directory.GetFiles(ReportDirectory, "*" + FileExtension)
                                     .Select(Path.GetFileNameWithoutExtension)
                                     .Union(ReportsFactory.Reports.Select(x => x.Key))
                                     .ToDictionary<string, string>(x => x);
        }

        public override void SetData(XtraReport report, string url) {
            // Stores the specified report to a Report Storage using the specified URL. 
            // This method is called only after the IsValidUrl and CanSetData methods are called.
            if(!IsWithinReportsFolder(url, ReportDirectory))
                throw new DevExpress.XtraReports.Web.ClientControls.FaultException("Invalid report name.");
            report.SaveLayoutToXml(Path.Combine(ReportDirectory, url + FileExtension));
        }

        public override string SetNewData(XtraReport report, string defaultUrl) {
            // Stores the specified report using a new URL. 
            // The IsValidUrl and CanSetData methods are never called before this method. 
            // You can validate and correct the specified URL directly in the SetNewData method implementation 
            // and return the resulting URL used to save a report in your storage.
            SetData(report, defaultUrl);
            return defaultUrl;
        }
    }
}