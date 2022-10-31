using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BLL
{
    public class BLLClientes
    {
        DALClientes cligym = new DALClientes();
        public enum Estado
        {
            Alta = 1,
            Baja = 2,
            Pendiente = 3,
        }
        /// <summary>
        /// Dame estados enum
        /// </summary>
        /// <returns></returns>
        public string[] dameEstados()
        {
            String[] ret = { Estado.Alta.ToString(), Estado.Baja.ToString(), Estado.Pendiente.ToString() };
            return ret;
        }

        #region no va es un recuerdo <3
        //public List<BE_Provincia> dameTodasProvincias()
        //{
        //    List<BE_Provincia> prov = new List<BE_Provincia>();
        //    DALProvincia dalprov = new DALProvincia();
        //    DataTable data = dalprov.DameProvincias();
        //    foreach (DataRow provin in data.Rows)
        //    {
        //        BE_Provincia provinciaActual = new BE_Provincia();
        //        provinciaActual.Id_Provincia = int.Parse(provin.ItemArray[0].ToString());
        //        provinciaActual.Descripcion = provin.ItemArray[1].ToString();
        //        prov.Add(provinciaActual);
        //    }
        //    return prov;
        //}
        //public List<BE_Localidad> DameLocalidad(string prov)
        //{
        //    List<BE_Localidad> loc = new List<BE_Localidad>();
        //    DALLocalidad dalloc = new DALLocalidad();
        //    int provId = DameIdProv(prov);
        //    DataTable data = dalloc.DameLocalidad(provId);
        //    foreach (DataRow locRow in data.Rows)
        //    {
        //        BE_Localidad beLocalidad = new BE_Localidad();
        //        beLocalidad.Id_Localidad = int.Parse(locRow.ItemArray[0].ToString());
        //        beLocalidad.Descripcion = locRow.ItemArray[1].ToString();
        //        loc.Add(beLocalidad);
        //    }
        //    return loc;
        //}

        //public List<BE_Sucursal> DameSucursales(string localid)
        //{
        //    List<BE_Sucursal> suc = new List<BE_Sucursal>();
        //    DALSucursal dalsuc = new DALSucursal();
        //    int locId = DameIdLoc(localid);
        //    DataTable data = dalsuc.DameSucursal(locId);
        //    foreach (DataRow sucRow in data.Rows)
        //    {
        //        BE_Sucursal beSucursal = new BE_Sucursal();
        //        beSucursal.Id_Sucursal = int.Parse(sucRow.ItemArray[0].ToString());
        //        beSucursal.Descripcion = sucRow.ItemArray[1].ToString();
        //        suc.Add(beSucursal);
        //    }
        //    return suc;
        //}

        //public int DameIdProv(string prov)
        //{
        //    DALProvincia dalprov = new DALProvincia();
        //    int idprov = dalprov.DameIdProvincias(prov);
        //    return idprov;
        //}
        //public int DameIdLoc(string Loc)
        //{
        //    DALLocalidad dalloc = new DALLocalidad();
        //    int idLoc = dalloc.DameIdLocalidad(Loc);
        //    return idLoc;
        //}
        //public int DameIdSuc(string suc)
        //{
        //    DALSucursal dalsuc = new DALSucursal();
        //    int idSuc = dalsuc.DameIdSucursal(suc);
        //    return idSuc;
        //}


        //public void llenarLocalidadProvincia(int idCliente)
        //{
        //    DALSucursal dalsucursal = new DALSucursal();
        //    DataRow dr = dalsucursal.DameLocacionTotalSucursal(idCliente).Rows[0]; //se descontinuo_?

        //    ///////////////////////////////////////////////////////
        //}
        #endregion

        public bool Alta(Cliente valAlta)
        {
            return cligym.Alta(valAlta);
        }

        public bool Baja(Cliente valBaja)
        {
            return cligym.Baja(valBaja);

        }

        /// <summary>
        /// Devuelve el id del cliente por el nombre
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public int DameIdCliente(BE.Cliente cliente)
        {
            return cligym.DameIdCliente(cliente);
        }
        
        public List<BE.Cliente> Leer(Cliente valBuscar)
        {
            List<BE.Cliente> listadoCliente = new List<Cliente>();
            //foreach (DataRow fila in cligym.MostrarCliente(valBuscar).Rows)
            //{
            //    BE.Cliente formaCliente = new BE.Cliente();
            //    formaCliente.Nombre = fila["Nombre"].ToString();
            //    formaCliente.Apellido = fila["Apellido"].ToString();
            //    formaCliente._pesokg = float.Parse(fila["PesoKg"].ToString());
            //    formaCliente.Dni = int.Parse(fila["Dni"].ToString());
            //    formaCliente._calle = fila["Calle"].ToString();
            //    formaCliente._numero = int.Parse(fila["Numero"].ToString());
            //    formaCliente._codPostal = int.Parse(fila["CodPostal"].ToString());
            //    formaCliente._telefono = int.Parse(fila["Telefono"].ToString());
            //    formaCliente._fechaNacimiento = DateTime.Parse(fila["Fecha_Nac"].ToString());
            //    formaCliente.Membresia = int.Parse(fila["Id_Membresia"].ToString());
            //    formaCliente.Id_Estado = int.Parse(fila["Id_Estado"].ToString());
            //    formaCliente.Certificado = bool.Parse(fila["Certificado"].ToString());
            //    formaCliente.Descuento = int.Parse(fila["Descuento"].ToString());
            //    formaCliente.Altura = float.Parse(fila["Altura"].ToString());

            //    listadoCliente.Add(formaCliente);
            //}
            return listadoCliente;
        }

        //Para el Mostrar
        public BE.Cliente MostrarCliente(Cliente valBuscar)
        {
            return cligym.MostrarCliente(valBuscar);
        }

        public List<BE.Cliente> AccionBusqueda(Cliente valBuscar)
        {
            List<BE.Cliente> listadoCliente = new List<Cliente>();
            foreach (DataRow fila in cligym.BuscarUsuarios(valBuscar).Rows)
            {
                BE.Cliente formaCliente = new BE.Cliente();
                formaCliente.Nombre = fila["Nombre"].ToString();
                formaCliente.Apellido = fila["Apellido"].ToString();
                formaCliente.Dni = int.Parse(fila["Dni"].ToString());
                listadoCliente.Add(formaCliente);
            }
            return listadoCliente;
        }

        public bool Modificar(Cliente valMod)
        {
            return cligym.Modificar(valMod);
        }

        public bool ValidarSiExiste(Cliente cli)
        {
            return cligym.ValidarSiExisteDAL(cli);
        }
    }
}
