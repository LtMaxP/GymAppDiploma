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
        public void RegistrarBitacora(string movimiento, string nivelDeProblema, DateTime fecha)
        {
            String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema) VALUES (@FechaMov, @Mov, @NivelDelP)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FechaMov", fecha);
            command.Parameters.AddWithValue("@Mov", movimiento);
            command.Parameters.AddWithValue("@NivelDelP", nivelDeProblema);
            Acceso.Instance.ExecuteNonQuery(command);

        }

        public DataTable TraerBitacora()
        {
            DataTable bitacoraTable;
            String query = "SELECT FechaDelMov, Movimiento, NivelDelProblema FROM Bitacora";
            SqlCommand command = new SqlCommand(query);

            bitacoraTable = Acceso.Instance.ExecuteDataTable(command);

            return bitacoraTable;
        }

        public static void NewRegistrarBitacora(BE.Bitacora bitacora)
        {
            bitacora = Servicios.BitacoraServicio.CrearMovimiento(bitacora);
            String query = "INSERT INTO Bitacora (FechaDelMov, Movimiento, NivelDelProblema, Usuario) VALUES (@FechaMov, @Mov, @NivelDelP, @Usuario)";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@FechaMov", bitacora.Fecha);
            command.Parameters.AddWithValue("@Mov", bitacora.Movimiento);
            command.Parameters.AddWithValue("@NivelDelP", bitacora.NivelDeProblema);
            command.Parameters.AddWithValue("@Usuario", bitacora.Usuario);
            Acceso.Instance.ExecuteNonQuery(command);
        }

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
