using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace _2209Mimari.ORM
{
    //Singleton Pattern
    class Tools
    {
        private static SqlConnection baglanti;

        public static SqlConnection Baglanti
        {
            get {
                if (baglanti == null)
                {
                    baglanti = new SqlConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
                    
                }
                //baglanti = baglanti ?? new SqlConnection();
                return baglanti; }
            set { baglanti = value; }
        }
        
    }
}
