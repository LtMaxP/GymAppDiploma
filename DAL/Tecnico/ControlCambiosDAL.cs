using BE;
using BE.Tecnico;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Tecnico
{
    public class ControlCambiosDAL
    {
        /// <summary>
        /// Ejecuta el SP para grabar el recupero del Control de Cambios
        /// </summary>
        /// <param name="rCC"></param>
        public static void GrabarCC(ControlCambio rCC)
        {
            try
            {
                var sqlCmd = Acceso.Instance.CrearCommandStoredProcedure("[dbo].[ControlCambiosRecupero]");
                sqlCmd.Parameters.Add("@IdEntidad", SqlDbType.Int).Value = rCC.idEntidad;
                sqlCmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = rCC.descripcion;
                sqlCmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = rCC.valor;
                sqlCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = rCC.cantidad;
                sqlCmd.Parameters.Add("@Operacion", SqlDbType.VarChar).Value = rCC.operacion;
                //sqlCmd.Parameters.Add("@Secuencia", SqlDbType.Int).Value = rCC.secuencia;
                sqlCmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = rCC.usuarioID;
                Acceso.Instance.ExecuteNonQuery(sqlCmd);
            }
            catch
            { }
        }
        /// <summary>
        /// Trae todo CC
        /// </summary>
        /// <param name="rCC"></param>
        /// <returns></returns>
        public static List<BE.Tecnico.ControlCambio> TTCC()
        {
            List<BE.Tecnico.ControlCambio> controldeCambios = new List<BE.Tecnico.ControlCambio>();

            try
            {
                string query = "select * from [GymApp].[dbo].[ItemHistoricoCC]";// AS itemH left join [GymApp].[dbo].[Item] AS itemO on itemO.Id_Item = itemH.Id_Item";
                SqlCommand comm = new SqlCommand(query);
                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow row in dt.Rows)
                {
                    BE.Tecnico.ControlCambio cc = new BE.Tecnico.ControlCambio();
                    cc.idEntidad = (int)row[0];
                    cc.descripcion = row[1].ToString();
                    cc.valor = (decimal)row[2];
                    cc.cantidad = (int)row[3];
                    cc.fechaModificacion = DateTime.Parse(row[4].ToString());
                    cc.usuarioID = (int)row[5];
                    cc.operacion = row[6].ToString();
                    cc.secuencia = (int)row[7];

                    controldeCambios.Add(cc);
                }
            }
            catch { }
            return controldeCambios;
        }
        /// <summary>
        /// Grabar Historico por CC pasado
        /// </summary>
        /// <param name="itm"></param>
        public static void GrabarHistoricoCC(BE.Tecnico.ControlCambio itm)
        {
            try
            {
                var sqlCmd = Acceso.Instance.CrearCommandStoredProcedure("[dbo].[ControlCambiosGrabar]");
                sqlCmd.Parameters.Add("@IdEntidad", SqlDbType.Int).Value = itm.idEntidad;
                sqlCmd.Parameters.Add("@Descripcion", SqlDbType.VarChar).Value = itm.descripcion;
                sqlCmd.Parameters.Add("@Valor", SqlDbType.Decimal).Value = itm.valor;
                sqlCmd.Parameters.Add("@Cantidad", SqlDbType.Int).Value = itm.cantidad;
                sqlCmd.Parameters.Add("@Operacion", SqlDbType.VarChar).Value = itm.operacion;
                sqlCmd.Parameters.Add("@IdUsuario", SqlDbType.Int).Value = Servicios.Sesion.GetInstance.usuario.IdUsuario;
                Acceso.Instance.ExecuteNonQuery(sqlCmd);
            }
            catch
            { }
        }
    }
}
