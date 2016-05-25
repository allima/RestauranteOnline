using RestauranteOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Repositorios
{
    public class RepositorioUsuarios
    {
        public static bool AutenticarUsuario(string Login, string Senha)
        {
            try
            {
                RestauranteBDEntities db = new RestauranteBDEntities();
                var QueryAutencaUsuario = db.Usuario.Where(x => x.Login == Login &&
                 x.Senha == Senha).SingleOrDefault();
                if (QueryAutencaUsuario == null)
                {
                    return false;

                }
                else
                {
                    RepositorioCookies.RegitraCookie(QueryAutencaUsuario.IDUsuario);
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Usuario RecuperaUsuario(long IDUsuario)
        {
            try
            {
                RestauranteBDEntities db = new RestauranteBDEntities();
                var usuario = db.Usuario.Where(u => u.IDUsuario == IDUsuario).SingleOrDefault();
                return usuario;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Usuario VerificaStatusUsuario()
        {
            var usuario = HttpContext.Current.Request.Cookies["CookieUsuario"];
            if (usuario == null)
            {
                return null;
            }
            else
            {
                long IDUsuario = Convert.ToInt64(usuario.Values["IDUsuario"]);
                var usuarioRetornado = RecuperaUsuario(IDUsuario);
                return usuarioRetornado;
            }
        }
    }
}