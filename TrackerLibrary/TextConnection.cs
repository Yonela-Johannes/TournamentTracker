using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TextConnection : IDataConnection
    {
        // TODO - Wire up the CreatePrize for Text files.
        /// <summary>
        /// Save a new prize to a text file
        /// </summary>
        /// <param name="model">The prize information.</param>
        /// <returns>The prize information including the inique identifier.</returns>
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;
            return model;
        }
    }
}
