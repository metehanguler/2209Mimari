using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2209Mimari.ORM
{
    public class ORMBase<TT> : IORM<TT>
    {
        Type TipGetir
        {
            get
            {
                return typeof(TT);
            }
        }

        public DataTable Listele()
        {
            SqlDataAdapter adp = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Tools.Baglanti;
            cmd.CommandText = string.Format("{0}_Listele",TipGetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            adp.SelectCommand = cmd;
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
        }

        public bool Ekle(TT entity)
        {
            SqlCommand cmd = new SqlCommand(string.Format("{0}_Ekle", TipGetir.Name),Tools.Baglanti);
            cmd.CommandText = string.Format("{0}_Ekle", TipGetir.Name);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection
        }

        public bool Guncelle(TT entity)
        {
            throw new NotImplementedException();
        }

        public bool Sil(int id)
        {
            throw new NotImplementedException();
        }
    }
}
