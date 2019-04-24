using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot
{
    public class Responce
    {
        private string _input;
        private string _output;

        public string Input {
            get { return _input; }
            set {
                if (value == "")
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length > 200)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Input = value;
                }
            }
        }
        public string Output {
            get { return _output; }
            set {
                if (value == "")
                {
                    throw new ArgumentNullException();
                }
                else if (value.Length > 200)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    Output = value;
                }
            }
        }
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
