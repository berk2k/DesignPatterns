using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class ConfigurationManager
    {
        public string GetConnectionString()
        {
            
            return "Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;";
        }
    }
}
