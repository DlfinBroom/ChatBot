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
    }
}