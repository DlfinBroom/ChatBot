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
            List<Responce> res = ResponceDB.GetAllResponces();
            return View(res);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Responce res)
        {
            if (ModelState.IsValid)
            {
                // Add responce to the DB
                // ResponceDB.AddResponce(res);
                return View();
            }
            return View(res);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Responce res = ResponceDB.GetOneResponce(int id);
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(Responce res)
        {
            if (ModelState.IsValid)
            {
                // Edit responce in the DB
                // ResponceDB.EditResponce(id, res);
                return View();
            }
            return View(res);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Responce res = ResponceDB.GetOneResponce(int id);
            return View(res);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Delete(Responce res)
        {
            if (ModelState.IsValid)
            {
                // Delete responce in the DB
                // ResponceDB.DeleteResponce(id, res);
                return View();
            }
            return View(res);
        }
    }
}