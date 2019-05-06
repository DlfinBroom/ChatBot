using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot
{
    public class ResponceDB
    {
        public List<Responce> GetSomeResponces(string input)
        {
            throw new NotImplementedException();
        }

        public List<Responce> GetAllResponces()
        {
            throw new NotImplementedException();
        }

        public bool AddResponce(Responce res)
        {
            throw new NotImplementedException();
        }

        public bool DeleteResponce(Responce res)
        {
            throw new NotImplementedException();
        }

        public bool UpdateResponce(Responce oldRes, Responce newRes)
        {
            if (DeleteResponce(oldRes))
            {
                return AddResponce(newRes);
            }
            return false;
        }
    }
}
