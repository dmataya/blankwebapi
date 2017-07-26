using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DWservice.Models
{
    /// <summary>
    /// This model will hold a collection of all tables that contain data for a given institution along with as many asof dates as we have data for.
    /// </summary>
    public class DataSetsModel
    {
        public Guid institutionid { get; set; }
        public string institutionname { get; set; }
        public string message { get; set; }
        public bool success { get; set; }

        List<DataSetInfo> _datasets = new List<DataSetInfo>();
        public List<DataSetInfo> datasets {
            get { return _datasets; }
        }

        public static DataSetsModel sample(string institutionID)
        {
            DataSetInfo info = new DataSetInfo { tablename = "loanandnotesdataset", asofdate = DateTime.Now };
            DataSetsModel model = new Models.DataSetsModel {
                institutionid = new Guid(institutionID),
                institutionname = "Sample Institution",
                success = true,
                message = "",};
            model.datasets.Add(info);
            return model;
        }
        
    }

    /// <summary>
    /// Information about a specific data set
    /// </summary>
    public class DataSetInfo
    {
         /// <summary>
        /// This is the object name of the table in the data warehouse entity datamodel. 
        /// </summary>
        public string tablename { get; set; }
        public DateTime asofdate { get; set; }
    }
}