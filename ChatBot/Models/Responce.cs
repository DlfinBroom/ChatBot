using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot.Models
{
    public class Responce
    {
        [Key]
        public int ResponceID { get; set; }

        /// <summary>
        /// What the user inputs into the textbox
        /// </summary>
        [MaxLength(200)]
        public string Input { get; set; }

        /// <summary>
        /// What the Chatbot responds with
        /// </summary>
        [MaxLength(200)]
        public string Output { get; set; }
    }
}
