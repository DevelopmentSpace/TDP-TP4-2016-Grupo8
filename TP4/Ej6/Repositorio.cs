﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ6
{
    public class Repositorio : IRepositorioUsuarios
    {
        IList<Usuario> iUsuarios = new List<Usuario> { };

        public void Agregar(Usuario pUsuario)
        {
            iUsuarios.Add(pUsuario);
        }

        public void Actualizar(Usuario pUsuario)
        {
            
            
        }

        public void Eliminar(string pCodigo)
        {
            iUsuarios.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerTodos()
        {
            return iUsuarios.Values.ToList();
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            return iUsuarios[pCodigo];
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = iUsuarios.Values.ToList();
            lista.Sort(pComparador);
            return lista;
        }
    }



    public class OrdenarPorNombreDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    public class OrdenarPorNombreAsc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return -String.Compare(x.NombreCompleto, y.NombreCompleto);
        }
    }

    public class OrdenarPorCorreoElectronicoDesc : IComparer<Usuario>
    {
        public int Compare(Usuario x, Usuario y)
        {
            return String.Compare(x.CorreoElectronico, y.CorreoElectronico);
        }
    }







}
