using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    //ADO.Conectado
    public class ABMUsuariosDAL : ICRUD<BE_Usuario>
    {
        public bool Alta(BE_Usuario valAlta)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();

                comm.CommandText = "INSERT INTO Usuario (Usuario.Usuario, Usuario.Password, Usuario.Id_Idioma, Usuario.Id_Estado, Usuario.DVH ) VALUES (@NombreUsuario, @Contraseña, @IdIdioma, @IdEstado, @dvh)"; //INSERT INTO Usuario (Usuario.Usuario, Usuario.Password, Usuario.Id_Idioma, Usuario.Id_Estado, Usuario.Rol ) VALUES ('Pepe','123123','1','1', 'Prueba')

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valAlta.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter2 = new SqlParameter();
                parameter2.ParameterName = "@Contraseña";
                parameter2.Value = valAlta.Pass;
                parameter2.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@IdIdioma";
                parameter3.Value = valAlta.Idioma.Id;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = valAlta.idEstado;
                parameter4.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter5 = new SqlParameter();
                parameter4.ParameterName = "@dvh";
                parameter4.Value = valAlta._DVH;
                parameter4.SqlDbType = System.Data.SqlDbType.VarChar;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter2);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);

                int result = Acceso.Instance.ExecuteNonQuery(comm);


                BitacoraDAL.NewRegistrarBitacora(new Bitacora("Creacion de usuario: " + valAlta.User, "Ninguno"));
                ret = true;
            }
            catch
            {
                System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de alta al Usuario {0}.", valAlta.User);
                //Servicios.BitacoraServicio.CrearMovimiento(new Bitacora("Alta", "Fallo"));
            }
            return ret;
        }



        //ADO.Conectado
        public bool Baja(BE_Usuario valBaja)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();

                comm.CommandText = "UPDATE Usuario SET Usuario.Id_Estado = @IdEstado WHERE Usuario.Usuario = @NombreUsuario AND Usuario.Password = @Pass";

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valBaja.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter parameter2 = new SqlParameter();
                parameter1.ParameterName = "@Pass";
                parameter1.Value = valBaja.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;
                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = "2";
                parameter4.SqlDbType = System.Data.SqlDbType.Int;


                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter2);
                comm.Parameters.Add(parameter4);

                int result = Acceso.Instance.ExecuteNonQuery(comm);
                ret = true;
                BitacoraDAL.NewRegistrarBitacora(new Bitacora("Baja de usuario: " + valBaja.User, "Ninguno"));
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de dar de baja el Usuario {0}.", valBaja.User); }
            return ret;
        }

        public DataTable TraerOpciones(string cmb)
        {
            string query = string.Empty;
            switch (cmb)
            {
                case "Rol":
                    query = "SELECT Nombre from PerfilPyF";
                    break;
                case "Idioma":
                    query = "SELECT Idioma from [Idioma]";
                    break;
            }
            DataTable dt = new DataTable();
            try
            {
                SqlCommand comm = new SqlCommand(query);
                dt = Acceso.Instance.ExecuteDataTable(comm);

            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            return dt;
        }

        public BE_Usuario Leer(BE_Usuario valBuscar)
        {
            BE_Usuario UserRet = new BE_Usuario();
            try
            {

                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT Usuario, Password, Id_Idioma, Id_Estado FROM Usuario WHERE Usuario.Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", valBuscar.User);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    UserRet.User = dr[0].ToString();
                    UserRet.Pass = dr[1].ToString();
                    UserRet.Idioma = new BE.ObserverIdioma.BE_Idioma();
                    UserRet.Idioma.Id = (int)dr[2];
                    UserRet.idEstado = (int)dr[3];
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            return UserRet;
        }


        //ADO.Desconectado
        public List<BE_Usuario> Leer2(BE_Usuario valBuscar)
        {
            List<BE_Usuario> listUser = new List<BE_Usuario>();
            try
            {

                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT Usuario, Id_Idioma, Id_Estado FROM Usuario WHERE Usuario.Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", valBuscar.User);

                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow dr in dt.Rows)
                {
                    BE_Usuario user = new BE_Usuario();
                    user.User = dr[0].ToString();
                    user.Idioma = new BE.ObserverIdioma.BE_Idioma();
                    user.Idioma.Id = (int)dr[1];
                    user.idEstado = (int)dr[2];
                    listUser.Add(user);
                }
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }

            return listUser;
        }

        //ADO.Conectado
        public bool Modificar(BE_Usuario valModificar)
        {
            bool ret = false;
            try
            {
                SqlCommand comm = new SqlCommand();

                if (!string.IsNullOrEmpty(valModificar.Pass))
                {
                    comm.CommandText = "UPDATE Usuario SET Usuario.Password = @Contraseña, Usuario.DVH = @DVH, Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado WHERE Usuario.Usuario = @NombreUsuario";

                    SqlParameter parameter2 = new SqlParameter();
                    parameter2.ParameterName = "@Contraseña";
                    parameter2.Value = valModificar.Pass;
                    parameter2.SqlDbType = System.Data.SqlDbType.VarChar;
                    comm.Parameters.Add(parameter2);
                }
                else { comm.CommandText = "UPDATE Usuario SET Usuario.Id_Idioma = @IdIdioma, Usuario.Id_Estado = @IdEstado WHERE Usuario.Usuario = @NombreUsuario"; }

                SqlParameter parameter1 = new SqlParameter();
                parameter1.ParameterName = "@NombreUsuario";
                parameter1.Value = valModificar.User;
                parameter1.SqlDbType = System.Data.SqlDbType.VarChar;

                SqlParameter parameter3 = new SqlParameter();
                parameter3.ParameterName = "@IdIdioma";
                parameter3.Value = valModificar.Idioma.Id;
                parameter3.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter4 = new SqlParameter();
                parameter4.ParameterName = "@IdEstado";
                parameter4.Value = valModificar.idEstado;
                parameter4.SqlDbType = System.Data.SqlDbType.Int;

                SqlParameter parameter5 = new SqlParameter();
                parameter5.ParameterName = "@DVH";
                parameter5.Value = valModificar._DVH;
                parameter5.SqlDbType = System.Data.SqlDbType.VarChar;

                comm.Parameters.Add(parameter1);
                comm.Parameters.Add(parameter3);
                comm.Parameters.Add(parameter4);
                comm.Parameters.Add(parameter5);

                int result = Acceso.Instance.ExecuteNonQuery(comm);
                ret = true;
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de modificar el Usuario. {0}.", valModificar.User); }
            return ret;
        }

        //ADO.Desconectado
        public bool ValidarExistenciaDeUsuario(BE_Usuario usuari)
        {
            bool respuesta = false;
            try
            {
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "select CASE WHEN count(1) > 0 THEN 'true' ELSE 'false' END from Usuario where Usuario = @nombre";
                comm.Parameters.AddWithValue("@nombre", usuari.User);

                respuesta = Acceso.Instance.ExecuteScalarBool(comm);
            }
            catch { System.Windows.Forms.MessageBox.Show("Problema al tratar de Leer la tabla."); }
            return respuesta;
        }


    }
}
