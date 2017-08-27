using DataObjects.Interfaces;

namespace DataObjects.AdoNet.SqlServer
{
    /// <summary>
    /// SQLServer specific data access object that handles data access
    /// of TodaysData. The details are stubbed out (in a crude way) but should be 
    /// relatively easy to implement as they are similar to MS Access and 
    /// Sql Server Data access objects.
    ///
    /// Enterprise Design Pattern: Service Stub.
    /// </summary>
    public class SqlServerTodaysDataDao : ITodaysDataDao
    {
        // <summary>
        /// Gets a TodaysData
        /// </summary>
        /// <returns>Hello World.</returns>
        public string GetTodaysData()
        {
            return "Hello World";
        }
    }
}
