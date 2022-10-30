using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Negocio
{
    public class DALEstado
    {
        public static int DameIdEstado(string estado)
        {
            int idEstado = 0;
            String query = "SELECT Id_Estado FROM Estado WHERE Descripcion = @estado";
            SqlCommand command = new SqlCommand(query);
            command.Parameters.AddWithValue("@estado", estado);
            idEstado = Acceso.Instance.ExecuteScalar(command);
            if (idEstado == 0)
            {
                System.Windows.Forms.MessageBox.Show("Error al tratar de conseguir el Estado");
            }
            return idEstado;
        }
    }
}
