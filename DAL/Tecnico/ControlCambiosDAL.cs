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
        /// Trae listado de CC
        /// </summary>
        /// <param name="rCC"></param>
        /// <returns></returns>
        public static List<BE.Tecnico.ControlCambio> TraerCC()
        {
            List<BE.Tecnico.ControlCambio> controldeCambios = new List<BE.Tecnico.ControlCambio>();

            try
            {
                string query = "SELECT itemH.[Id_Item], itemH.[Descripcion], itemH.[Valor], itemO.[Cantidad], itemH.[Cantidad], itemH.[FechaCC], itemH.[UsuarioID], itemH.[Operacion], [Secuencia] FROM [GymApp].[dbo].[ItemHistoricoCC] AS itemH left join [GymApp].[dbo].[Item] AS itemO on itemO.Id_Item = itemH.Id_Item";
                SqlCommand comm = new SqlCommand(query);
                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow row in dt.Rows)
                {
                    BE.Tecnico.ControlCambio cc = new BE.Tecnico.ControlCambio();
                    cc.idEntidad = (int)row[0];
                    cc.descripcion = row[1].ToString();
                    cc.campo = row[2].ToString();
                    cc.valorNuevo = row[3].ToString();//
                    cc.valorOriginal = row[4].ToString();//
                    cc.fechaModificacion = DateTime.Parse(row[5].ToString());
                    cc.UsuarioID = (int)row[6];//
                    cc.Operacion = row[7].ToString();//
                    cc.secuencia = (int)row[8];

                    controldeCambios.Add(cc);
                }
            }
            catch { }
            return controldeCambios;
        }
        /// <summary>
        /// Trae en base a un CC especifico el resultado ??
        /// </summary>
        /// <param name="rCC"></param>
        /// <returns></returns>
        public static List<BE.Tecnico.ControlCambio> TraerCCPorCC(BE.Tecnico.ControlCambio rCC)
        {
            List<BE.Tecnico.ControlCambio> controldeCambios = new List<BE.Tecnico.ControlCambio>();

            try
            {
                string query = "SELECT itemH.[Id_Item], itemH.[Descripcion], itemH.[Valor], itemO.[Valor], itemH.[Cantidad], itemH.[FechaCC], itemH.[UsuarioID], itemH.[Operacion] FROM [ItemHistoricoCC] AS itemH left join Item AS itemO on itemO.Id_Item = itemH.Id_Item";
                SqlCommand comm = new SqlCommand(query);
                DataTable dt = Acceso.Instance.ExecuteDataTable(comm);
                foreach (DataRow row in dt.Rows)
                {
                    BE.Tecnico.ControlCambio cc = new BE.Tecnico.ControlCambio();
                    cc.idEntidad = (int)row[0];
                    cc.descripcion = row[1].ToString();
                    cc.campo = row[2].ToString();
                    cc.valorOriginal = row[3].ToString();
                    cc.valorNuevo = row[4].ToString();
                    cc.fechaModificacion = (DateTime)row[5];
                    cc.secuencia = (int)row[6];
                    cc.Operacion = row[7].ToString();
                    cc.UsuarioID = (int)row[8];

                    controldeCambios.Add(cc);
                }
            }
            catch { }
            return controldeCambios;
        }
    }
}
