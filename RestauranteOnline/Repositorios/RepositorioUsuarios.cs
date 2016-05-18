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
                else {
                    RepositorioCookies.RegitraCookie(QueryAutencaUsuario.IDUsuario);
                    return true;
                }
                            }
            catch(Exception) {
                return false;
            }
        }
    }
}