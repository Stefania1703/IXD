using System.Configuration;

namespace FreeBook
{
    class SqlDataAccess
    {
        public static string GetCartiString()
        {
            return ConfigurationManager.AppSettings["carti"];
        }
    }
}