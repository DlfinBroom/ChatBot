using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Controllers
{
    public class ChatBotController : Controller
    {
        public IActionResult ChatBot()
        {
            return View();
        }

        public IActionResult Responces()
        {
            // List<Responce> res = ResponceDB.GetAllResponces();
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Edit(Responce res)
        {
            return View();
        }

        public IActionResult Delete(Responce res)
        {
            return View();
        }
    }
}