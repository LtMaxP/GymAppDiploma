using BE;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BitacoraDAL
    {
        /// <summary>
        /// Traer dt bitacora total
        /// </summary>
        /// <returns></returns>
        public DataTable TraerBitacora()
        {
            DataTable bitacoraTable;
            String query = "SELECT FechaDelMov, Movimiento, NivelDelProblema FROM Bitacora";
            SqlCommand command = new SqlCommand(query);
            bitacoraTable = Acceso.Instance.ExecuteDataTable(command);
            return bitacoraTable;
        }

        public static List<Bitacora> CargarBitacoraConFiltrado(Bitacora bitacor, DateTime dt1, DateTime dt2)
        {
            List<Bitacora> btlist = new List<Bitacora>();
            String query = "SELECT * FROM Bitacora WHERE [Usuario] = @user AND [NivelDelProblema] = @problema AND FechaDelMov > @FechaMovD AND FechaDelMov < @FechaMovU";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@user", bitacor.Usuario);
            command.Parameters.AddWithValue("@problema", bitacor.NivelDeProblema);
            command.Parameters.AddWithValue("@FechaMovD", dt1);
            command.Parameters.AddWithValue("@FechaMovU", dt2);
            DataTable dt = Acceso.Instance.ExecuteDataTable(command);
            foreach (DataRow dr in dt.Rows)
            {
                Bitacora bt = new Bitacora();
                bt.IdBitacora = int.Parse(dr["Id_Bitacora"].ToString());
                bt.Fecha = DateTime.Parse(dr["FechaDelMov"].ToString());
                bt.Movimiento = dr["Movimiento"].ToString();
                bt.NivelDeProblema = dr["NivelDelProblema"].ToString();
                bt.Usuario = dr["Usuario"].ToString();
                btlist.Add(bt);
            }
            return btlist;
        }

        /// <summary>
        /// Insertar registro en Bitacora DB
        /// </summary>
        /// <param name="bitacora"></param>
        public static void NewRegistrarBitacora(BE.Bitacora bitacora)
        {
            
            String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema, Usuario) VALUES (@FechaMov, @Mov, @NivelDelP, @Usuario)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FechaMov", bitacora.Fecha);
            command.Parameters.AddWithValue("@Mov", bitacora.Movimiento);
            command.Parameters.AddWithValue("@NivelDelP", bitacora.NivelDeProblema);
            command.Parameters.AddWithValue("@Usuario", bitacora.Usuario);
            Acceso.Instance.ExecuteNonQuery(command);
        }
        /// <summary>
        /// Traer bitacora por fechas
        /// </summary>
        /// <param name="dt1"></param>
        /// <param name="dt2"></param>
        /// <returns></returns>
        public static List<Bitacora> TraerBitacoraPorFecha(DateTime dt1, DateTime dt2)
        {
            List<Bitacora> btlist = new List<Bitacora>();
            String query = "SELECT * FROM Bitacora WHERE FechaDelMov > @FechaMovD AND FechaDelMov < @FechaMovU";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FechaMovD", dt1);
            command.Parameters.AddWithValue("@FechaMovU", dt2);
            DataTable dt = Acceso.Instance.ExecuteDataTable(command);
            foreach (DataRow dr in dt.Rows)
            {
                Bitacora bt = new Bitacora();
                bt.IdBitacora = int.Parse(dr["Id_Bitacora"].ToString());
                bt.Fecha = DateTime.Parse(dr["FechaDelMov"].ToString());
                bt.Movimiento = dr["Movimiento"].ToString();
                bt.NivelDeProblema = dr["NivelDelProblema"].ToString();
                bt.Usuario = dr["Usuario"].ToString();
                btlist.Add(bt);
            }
            return btlist;
        }
    }
}
