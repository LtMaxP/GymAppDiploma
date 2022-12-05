﻿using BE;
using BE.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Tecnico
{
    public class PermisosBLL
    {
        DAL.CompositeyPermisosDAL CyPDAL = new DAL.CompositeyPermisosDAL();
        public BE.Composite.Component TraerComponentesFyP()
        {
            return CyPDAL.TraerTodoFamiliasOPatentesDALNEW();
        }
        public BE.Composite.Component TraerAgrupadosDAL()
        {
            return CyPDAL.TraerComponentesAgrupadosDAL();
        }

        public BE.BE_Usuario TraerUsuarioConPermisos(BE.BE_Usuario user)
        {
            return CyPDAL.PermisosPorUsuario(user);
        }

        public bool CrearFamilia(BE.Composite.Composite newFamilia, string familiaNombre)
        {
            return CyPDAL.CrearFamilia(newFamilia, familiaNombre);
        }
        /// <summary>
        /// Eliminar la familia por el nombre, si el id es menor a 50 es un permiso ya definido para el sistema
        /// </summary>
        /// <param name="nombreFamilia"></param>
        /// <returns></returns>
        public bool EliminarFamilia(string nombreFamilia)
        {
            bool ret = false;
            int idFam = CyPDAL.DameIdPorNombre(nombreFamilia);
            if (idFam != 404 && idFam >= 1050)
            {
                ret = CyPDAL.EliminarFamilia(idFam);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("No se pueden eliminar las Familias del sistema");
            }
            return ret;
        }

        public bool GuardarP(Component pAsig, BE_Usuario user)
        {
            CyPDAL.QuitarPermisosUsuario(user);
            return CyPDAL.GuardarPermisosAsignados(pAsig, user);
        }

        public bool ValidarNombreFamilia(string familiaNombre)
        {
            return CyPDAL.ValidarSiYaExiste(familiaNombre);
        }

        public void ModificarFamilia(Composite family, string familiaNombre)
        {
            int fam = CyPDAL.DameIdPorNombre(familiaNombre);
            CyPDAL.EliminarPermisosFamilia(fam);
            CyPDAL.GenerarRelacionesPatenteFamilia(family, fam);
        }
    }
}
