using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.IO;

namespace convertLink.Models
{
    public class converter
    {
         public string linkJS { get; set; }
         public string projectname { get; set; }


        public bool creatNameListJsFile() {
            string storePath = ConfigurationManager.AppSettings["folderPath"];
            string storeData="";

            storeData = linkJS;
            try {
                StreamWriter sr = File.CreateText(storePath +"\\link_convert.js"); 
                sr.Write(storeData);
                sr.Flush();
                sr.Close();
                return true;
            }
            catch(Exception e){
                return false;

            }
         }


    }
}