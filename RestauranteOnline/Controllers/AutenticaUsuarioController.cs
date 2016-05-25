using RestauranteOnline.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Controllers
{
    public class AutenticaUsuarioController : Controller
    {

        public JsonResult AutenticacaoUsuario(string Login, string Senha)
        {
            if (RepositorioUsuarios.AutenticarUsuario(Login, Senha))
            {
                return Json(new { OK = true, Mensagem = "Usuario encontrado Redirecionando..." },
                    JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { OK = false, Mensagem = "Usuario não encontrado" },
                JsonRequestBehavior.AllowGet);
            }
        }
    }
}