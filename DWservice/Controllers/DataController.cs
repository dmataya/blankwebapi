using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DWservice.Models;

namespace DWservice.Controllers
{
    public class DataController : ApiController
    {

        /// <summary>
        /// Gets the list of data sets available for a given institutionid.
        /// </summary>
        /// <param name="institutionid"></param>
        /// <returns>DataSetsModel</returns>
        [Route("GetDataSets/{institutionid}")]
        [HttpGet]
        public DataSetsModel GetDataSets(string institutionid)
        {
            Guid instid;
            try
            {
                instid = new Guid(institutionid);
            }
            catch (Exception e)
            {
                return new DataSetsModel() { message = string.Concat("Error converting institutionid. Message= ", e.Message), success = false };
            }

            return DataSetsModel.sample(institutionid);

        }
    }
}
