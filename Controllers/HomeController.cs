using HWA3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HWA3.Controllers
{
    public class HomeController : Controller
    {

        public static List<FileModel> files = new List<FileModel>(); //List of all files
        
        public ActionResult Index() //returns the index view 
        {
            return View();
        }
        [HttpPost] 
        public ActionResult Index(HttpPostedFileBase file, string ch)
        {
            Random random = new Random();

            if (ch == "doc") //recieves option and file from view 
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName); //create the path being saved 

                        FileModel item = new FileModel();

                        item.Link = "~/UploadedFiles/" + _FileName; 
                        item.FileName = _FileName;
                        item.id = random.Next(10000); //generates a random number as id of whatever file is uploaded 
                        item.type = "doc";
                        files.Add(item);
                        Session["files"] = files; //stores the list 
                        file.SaveAs(_path); //saves file in correct order 
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            if (ch == "img")
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);
                        
                        FileModel item = new FileModel();
                      
                        item.Link = "~/UploadedFiles/" + _FileName;
                        item.FileName = _FileName;
                        item.id = random.Next(10000);
                        item.type = "img";
                        files.Add(item);
                        Session["files"] = files;
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            if (ch == "vid")
            {
                try
                {
                    if (file.ContentLength > 0)
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UploadedFiles"), _FileName);

                        FileModel item = new FileModel();
                        item.Link = "~/UploadedFiles/" + _FileName;
                        item.FileName = _FileName;
                        item.id = random.Next(10000);
                        item.type = "vid";
                        files.Add(item);
                        Session["files"] = files;
                        file.SaveAs(_path);
                    }
                    ViewBag.Message = "File Uploaded Successfully!!";
                    return View();
                }
                catch
                {
                    ViewBag.Message = "File upload failed!!";
                    return View();
                }
            }
            return View();

        }
     

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}