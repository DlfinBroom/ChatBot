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
        /*
        private readonly ChatbotContext context;

        public ChatBotController(ChatbotContext dbContext)
        {
            context = dbContext;
        }
        */

        /// <summary>
        /// Main page for interacting with the chatbot
        /// </summary>
        public IActionResult ChatBot()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ChatBot(string input)
        {
            //input = input.Trim();
            //if(input != "" && input.Length < 200)
            if(false) // the code below is broken, so this here is temperary to problem solve this
            {
                List<Responce> responces = ResponceDB.GetSomeResponces(input);
                if(responces.Count() == 0)
                {
                    Responce filler = new Responce();
                    filler.Input = input;
                    /* ToDo: get a random responce out from the
                     database istead of just having 'filler text' */
                    filler.Output = "Filler Text";
                    responces.Add(filler);
                }
                /* ToDo: set res to a random responce 
                 from responces instead of always [0] */
                Responce res = responces[0];
                ViewData["Responce"] = res.Output;
                return View();
            }
            return View(input);
        }

        /// <summary>
        /// Page for editing all responces within the database
        /// </summary>
        public IActionResult Responces()
        {
            /*
            List<Responce> res = ResponceDB.GetAllResponces(context);
            return View(res);
            */
            return View();
        }
    }
}