namespace DataObjects.Interfaces
{
    /// <summary>
    /// Defines methods to access and maintain Application data.
    /// This is a database-independent interface. 
    /// The implementations will be database specific.
    /// </summary>
    public interface ITodaysDataDao
    {
        /// <summary>
        /// Gets a TodaysData.
        /// </summary>
        /// <returns>TodaysData.</returns>
        string GetTodaysData();
    }
}
