using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class ChatBotContext : DbContext
    {
        public ChatBotContext (DbContextOptions<ChatBotContext> options) : base(options) { }

        public DbSet<Responce> Responce { get; set; }
    }
}
