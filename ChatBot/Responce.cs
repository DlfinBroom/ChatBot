using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Responce
    {
        public string Input { get; set; }
        public string Output { get; set; }
    }

    public class RandomResponce
    {
        public Responce GetResponce(List<Responce> responces)
        {
            Random rand = new Random();
            int index = rand.Next(0, responces.Count);
            return responces[index];
        }
    }
}
