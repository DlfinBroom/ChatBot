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
        private readonly ChatbotContext context;

        public ChatBotController(ChatbotContext dbContext)
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
        [HttpPost]
        public IActionResult ChatBot(Responce res)
        {
            res.Input = res.Input.Trim();
            if (res.Input != "" && res.Input.Length < 200)
            {
                List<Responce> responces = ResponceDB.GetSomeResponces(res.Input, context);
                if (responces.Count() == 0)
                {
                    Responce filler = new Responce();
                    filler.Input = res.Input;
                    /* ToDo: get a random responce out from the
                     database istead of just having 'filler text' */
                    filler.Output = "Filler Text";
                    responces.Add(filler);
                }
                /* ToDo: set res to a random responce 
                 from responces instead of always [0] */
                Responce responce = responces[0];
                ViewData["Responce"] = responce.Output;
            }
            return View(res);
        }

        /// <summary>
        /// Page for editing all responces within the database
        /// </summary>
        public IActionResult Responces()
        {
            List<Responce> res = ResponceDB.GetAllResponces(context);
            return View(res);
        }

        /// <summary>
        /// Adds a new Responce to the database after the user fills out a form
        /// </summary>
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
                ViewData["Added"] = "Responce was added!";
                return View();
            }
            return View(res);
        }

        /// <summary>
        /// Edits a responce in the database after the user fills out a form
        /// </summary>
        [HttpGet]
        public IActionResult Edit(int responceID)
        {
            Responce res = ResponceDB.GetOneResponce(responceID, context);
            return View(res);
        }
        [HttpPost]
        public IActionResult Edit(Responce res)
        {
            if (ModelState.IsValid)
            {
                ResponceDB.UpdateResponce(res, context);
                ViewData["Updated"] = "Responce was Updated";
            }
            return View(res);
        }

        /// <summary>
        /// Deletes a responce from the database after the user confirms
        /// </summary>
        [HttpGet]
        public IActionResult Delete(int responceID)
        {
            Responce res = ResponceDB.GetOneResponce(responceID, context);
            return View(res);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int responceID)
        {
            Responce res = ResponceDB.GetOneResponce(responceID, context);
            ResponceDB.DeleteResponce(res, context);
            return RedirectToAction("Responce");
        }
    }
}