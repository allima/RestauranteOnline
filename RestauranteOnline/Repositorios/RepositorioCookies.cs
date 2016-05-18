using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestauranteOnline.Repositorios
{
    public class RepositorioCookies
    {
        public static void RegitraCookie(long IDUsuario)
        {
            HttpCookie UserCookie = new HttpCookie("CookieUsuario");
            UserCookie.Values["IDUsuario"] = IDUsuario.ToString();
            UserCookie.Expires = DateTime.Now.AddDays(1);
            HttpContext.Current.Response.Cookies.Add(UserCookie);
        }
    }
}