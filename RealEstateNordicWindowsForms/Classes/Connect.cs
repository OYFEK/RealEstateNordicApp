using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateNordicWindowsForms
{
    public static class Connect
    {
            public static string connectionString = ConfigurationManager.ConnectionStrings["RealEstateNordicWindowsForms.Properties.Settings.RealEstateNordicDBConnectionString"].ConnectionString;
    }
}
