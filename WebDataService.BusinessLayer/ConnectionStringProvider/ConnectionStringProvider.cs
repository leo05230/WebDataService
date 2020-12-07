using WebDataService.Domain.Interfaces.ConnectionStringProvider;

namespace WebDataService.BusinessLayer.ConnectionStringProvider
{
    public class ConnectionStringProvider : IConnectionStringProvider
    {
        public string _ConnectionString { get; set; }

        public ConnectionStringProvider(string ConnectionString)
        {

            this._ConnectionString = ConnectionString;

        }
    }
}
