﻿ using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    internal class SqlConnector : IDataConnection
    {
        // TODO - Make the create prize method actually save to the database
        /// <summary>
        /// Save a new prize to database
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
