﻿using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using MapSource;

namespace BussinesLogic
{
    public class UsuarioBL
    {

        #region CONSTANTES

            private const string _USUARIO_NO_EXISTE = "El Usuario No Existe";
            private const string _CONTRASENA_NO_COINCIDE = "La Contraseña No Coincide";

        #endregion
        
        readonly Lazy<UsuarioDAL> _usuarioLazy = new Lazy<UsuarioDAL>(() => new UsuarioDAL());
        UsuarioDAL UsuarioLazy { get { return _usuarioLazy.Value; } }

        public Session Login(string nombreUsuario, string contrasena)
        {
            var usuario = UsuarioLazy.GetUsuarioByNombreUsuario(nombreUsuario).FirstOrDefault();
            var session = new Session();
            if (usuario == null)
            {
                session.Error = _USUARIO_NO_EXISTE;
            }
            else
            {
                if (!usuario.Contrasena.Equals(contrasena))
                {
                    session.Error = _USUARIO_NO_EXISTE;
                }
                else
                {
                    session.Usuario = new Usuario
                    {
                        Id = usuario.Id,
                        NombreUsuario = usuario.Nombre_Usuario,
                        Vistas = new List<Vistas>()
                    };
                }
            }
            return session;
        }
    }
}
