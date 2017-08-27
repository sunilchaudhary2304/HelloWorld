using DataObjects.Interfaces;

namespace DataObjects.AdoNet.SqlServer
{
    /// <summary>
    /// SQLServer specific factory that creates SQLServer specific data access objects.
    /// 
    /// GoF Design Pattern: Factory.
    /// </summary>
    public class SqlServerDaoFactory: DaoFactory
    {
        public override ITodaysDataDao TodaysDataDao 
        {
            get { return new SqlServerTodaysDataDao(); }
        }
    }
}
