using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatBot.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChatBot.Controllers
{
    public class ChatBotController : Controller
    {
        private readonly ChatBotContext context;

        public ChatBotController(ChatBotContext dbContext)
        {
            context = dbContext;
        }

        /// <summary>
        /// Main page for interacting with the chatbot
        /// </summary>
        public IActionResult ChatBot()
        {
            return View();
        }

        /// <summary>
        /// Page for editing all responces within the database
        /// </summary>
        public IActionResult Responces()
        {
            List<Responce> res = ResponceDB.GetAllResponces();
            return View(res);
        }

        /// <summary>
        /// Page for adding a new responce into the database
        /// </summary>
        /// <returns></returns>
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
                ResponceDB.AddResponce(res, context);
                ViewData["Message"] = "Responce was added!";
                return View();
            }
            return View(res);
        }

        /// <summary>
        /// Page for editing a responce in the database
        /// </summary>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Responce res = ResponceDB.GetOneResponce(id);
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(Responce res)
        {
            if (ModelState.IsValid)
            {
                ResponceDB.UpdateResponce(res, context);
                ViewData["Message"] = "Responce was changed!";
                return View();
            }
            return View(res);
        }

        /// <summary>
        /// Page for removing a responce from the database
        /// </summary>
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Responce res = ResponceDB.GetOneResponce(id);
            return View(res);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            Responce res = ResponceDB.GetOneResponce(id);
            ResponceDB.DeleteResponce(res, context);
            return RedirectToAction("Responces");
        }
    }
}