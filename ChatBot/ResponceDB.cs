using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatBot
{
    public class ResponceDB
    {
        /// <summary>
        /// Grabs all responces that have an input, and returns that as a list.
        /// if no input exists, will grab a random responce from the database and
        /// returns that in a list.
        /// </summary>
        /// <returns>
        /// Returns a list of all responces with the same input given,
        /// returns a list with one random responce otherwise
        /// </returns>
        public List<Responce> GetSomeResponces(string input)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Grabs all responces from the database.
        /// </summary>
        /// <returns>
        /// Returns a list of all responces from the database
        /// </returns>
        public List<Responce> GetAllResponces()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Adds the responce given to the database.
        /// </summary>
        /// <returns>
        /// Returns true if responce was added to the database succesfully,
        /// returns false otherwise
        /// </returns>
        public bool AddResponce(Responce res)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the responce givin from the database, if it exists.
        /// </summary>
        /// <returns>
        /// Returns true if responce existed and was deleted succesfully,
        /// returns false otherwise.
        /// </returns>
        public bool DeleteResponce(Responce res)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the first responce given from the database, and
        /// adds the second responce given if the first was deleted.
        /// </summary>
        /// <returns>
        /// Returns true if responces are deleted and added in succesfully,
        /// returns false otherwise.
        /// </returns>
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
