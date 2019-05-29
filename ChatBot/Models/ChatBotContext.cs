using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class ChatbotContext : DbContext
    {
        public ChatbotContext () : base() { }

        public DbSet<Responce> Responce { get; set; }
    }
}
