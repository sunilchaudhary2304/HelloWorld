
using DataObjects.Interfaces;

namespace DataObjects
{
    // <summary>
    /// Abstract factory class that creates data access objects.
    /// </summary>
    /// <remarks>
    /// GoF Design Pattern: Factory.
    /// </remarks>
    /// 
    public abstract class DaoFactory
    {
        public abstract ITodaysDataDao TodaysDataDao { get; }
    }
}
