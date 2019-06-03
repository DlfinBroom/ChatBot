using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class ChatbotContext : DbContext
    {
        public ChatbotContext(DbContextOptions<ChatbotContext> options) : base(options) {
        }

        public DbSet<Responce> Responce { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Responce>().ToTable("Responce");
        }
    }
}
