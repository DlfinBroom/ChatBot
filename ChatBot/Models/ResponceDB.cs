using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot
{
    public static class ResponceDB
    {
        /// <summary>
        /// Grabs one responce from the database with the same Id given,
        /// Throws a KeyNotFoundException if not found
        /// </summary>
        /// <returns>
        /// Returns the responce with the same Id
        /// </returns>
        internal static Responce GetOneResponce(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs all responces that have an input, and returns that as a list.
        /// if no such input exists, returns an empty list
        /// </summary>
        /// <returns>
        /// Returns a list of all responces with the same input given,
        /// returns an empty list if no responces have that input
        /// </returns>
        public static List<Responce> GetSomeResponces(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs all responces from the database.
        /// </summary>
        /// <returns>
        /// Returns a list of all responces from the database
        /// </returns>
        public static List<Responce> GetAllResponces(ChatbotContext context)
        {
            IEnumerable<Responce> res = from r in context.Responce
                                 select new Responce
                                 {
                                     Input = r.Input,
                                     Output = r.Output
                                 };
            return (List<Responce>)res;
        }

        /// <summary>
        /// Adds the responce given to the database.
        /// </summary>
        /// <returns>
        /// Returns true if responce was added to the database succesfully,
        /// returns false otherwise
        /// </returns>
        public static bool AddResponce(Responce res, ChatbotContext context)
        {
            context.Responce.Add(res);
            if(context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes the responce givin from the database, if it exists.
        /// </summary>
        /// <returns>
        /// Returns true if responce existed and was deleted succesfully,
        /// returns false otherwise.
        /// </returns>
        public static bool DeleteResponce(Responce res, ChatbotContext context)
        {
            context.Responce.Remove(res);
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes the first responce given from the database, and
        /// adds the second responce given if the first was deleted.
        /// </summary>
        /// <returns>
        /// Returns true if responces are deleted and added in succesfully,
        /// returns false otherwise.
        /// </returns>
        public static bool UpdateResponce(Responce res, ChatbotContext context)
        {
            context.Responce.Update(res);
            if (context.SaveChanges() == 1)
            {
                return true;
            }
            return false;
        }
    }
}
