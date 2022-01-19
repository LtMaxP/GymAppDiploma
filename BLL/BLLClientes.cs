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
        private enum Estado
        {
            Alta = 1,
            Baja = 2,
        }
        public string[] dameEstados()
        {
            String[] ret = { Estado.Alta.ToString(), Estado.Baja.ToString() };
            return ret;
        }
        public List<BE_Provincia> dameProvincias()
        {
            List<BE_Provincia> prov = new List<BE_Provincia>();
            DALProvincia dalprov = new DALProvincia();
            DataTable data = dalprov.DameProvincias();
            foreach (DataRow provin in data.Rows)
            {
                BE_Provincia provinciaActual = new BE_Provincia();
                provinciaActual.Id_Provincia = int.Parse(provin.ItemArray[0].ToString());
                provinciaActual.Descripcion = provin.ItemArray[1].ToString();
                prov.Add(provinciaActual);
            }
            return prov;
        }
        public List<BE_Localidad> DameLocalidad(string prov)
        {
            List<BE_Localidad> loc = new List<BE_Localidad>();
            DALLocalidad dalloc = new DALLocalidad();
            int provId = DameIdProv(prov);
            DataTable data = dalloc.DameLocalidad(provId);
            foreach (BE_Localidad loca in data.Rows)
            {
                loc.Add(loca);
            }
            return loc;
        }
        public int DameIdProv(string prov)
        {
            DALProvincia dalprov = new DALProvincia();
            int idprov = dalprov.DameIdProvincias(prov);
            return idprov;
        }

        public bool Alta(Cliente valAlta)
        {
            return cligym.Alta(valAlta);
        }

        public bool Baja(Cliente valBaja)
        {
            return true;
        }

        
        public List<BE.Cliente> Leer(Cliente valBuscar)
        {
            List<BE.Cliente> listadoCliente = new List<Cliente>();
            foreach (DataRow fila in cligym.MostrarCliente(valBuscar).Rows)
            {
                BE.Cliente formaCliente = new BE.Cliente();
                formaCliente._IDCliente = int.Parse(fila[0].ToString());
                formaCliente._IDSucursal = int.Parse(fila[1].ToString());
                formaCliente._IDEmpleado = int.Parse(fila[2].ToString());
                formaCliente._nombre = fila[3].ToString();
                formaCliente._apellido = fila[4].ToString();
                formaCliente._pesokg = int.Parse(fila[5].ToString());
                formaCliente._idEstado = int.Parse(fila[6].ToString());
                formaCliente._dni = int.Parse(fila[7].ToString());
                formaCliente._calle = fila[8].ToString();
                formaCliente._numero = int.Parse(fila[9].ToString());
                formaCliente._codPostal = int.Parse(fila[10].ToString());
                formaCliente._telefono = int.Parse(fila[11].ToString());
                formaCliente._fechaNacimiento = DateTime.Parse(fila[12].ToString());
                listadoCliente.Add(formaCliente);
            }
            return listadoCliente;
        }
        //Para el Mostrar
        public BE.Cliente MostrarCliente(Cliente valBuscar)
        {
            BE.Cliente formaCliente = new BE.Cliente();
            foreach (DataRow fila in cligym.MostrarCliente(valBuscar).Rows)
            {
                formaCliente._IDCliente = int.Parse(fila[0].ToString());
                formaCliente._IDSucursal = int.Parse(fila[1].ToString());
                formaCliente._IDEmpleado = int.Parse(fila[2].ToString());
                formaCliente._nombre = fila[3].ToString();
                formaCliente._apellido = fila[4].ToString();
                formaCliente._pesokg = int.Parse(fila[5].ToString());
                formaCliente._idEstado = int.Parse(fila[6].ToString());
                formaCliente._dni = int.Parse(fila[7].ToString());
                formaCliente._calle = fila[8].ToString();
                formaCliente._numero = int.Parse(fila[9].ToString());
                formaCliente._codPostal = int.Parse(fila[10].ToString());
                formaCliente._telefono = int.Parse(fila[11].ToString());
                formaCliente._fechaNacimiento = DateTime.Parse(fila[12].ToString());
            }
            return formaCliente;
        }
        public List<BE.Cliente> AccionBusqueda(Cliente valBuscar)
        {

            List<BE.Cliente> listadoCliente = new List<Cliente>();
            foreach (DataRow fila in cligym.Leer(valBuscar).Rows)
            {
                BE.Cliente formaCliente = new BE.Cliente();
                formaCliente._nombre = fila[1].ToString();
                formaCliente._apellido = fila[2].ToString();
                formaCliente._dni = int.Parse(fila[3].ToString());
                listadoCliente.Add(formaCliente);
            }
            return listadoCliente;
        }

        public bool Modificar(Cliente valMod)
        {
            return true;
        }

        public bool ValidarSiExiste(Cliente cli)
        {
            DALClientes dalCli = new DALClientes();
            return dalCli.ValidarSiExisteDAL(cli);
        }
    }
}
