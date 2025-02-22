﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication6_2.Models;

namespace WebApplication6_2.Controllers
{
    public class FileController : Controller
    {
        [HttpGet]
        public IActionResult DownloadFile()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DownloadFile(string first_name, string second_name, string filename)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                TextWriter writer = new StreamWriter(ms);
                writer.WriteLine($"{first_name} {second_name}");
                writer.Flush();
                return File(ms.GetBuffer(), "text/plain", $"{filename}.txt");
            }
        }
    }
}
