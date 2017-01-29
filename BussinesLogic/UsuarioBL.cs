using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
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

        public List<string> Login(string nombreUsuario, string contrasena)
        {
            var usuario = UsuarioLazy.GetUsuarioByNombreUsuario(nombreUsuario).FirstOrDefault();
            var errores = new List<string>();
            if (usuario == null)
            {
                errores.Add(_USUARIO_NO_EXISTE);
            }
            else
            {
                if (!usuario.Contrasena.Equals(contrasena))
                {
                    errores.Add(_CONTRASENA_NO_COINCIDE);
                }
            }
            return errores;
        }
    }
}
