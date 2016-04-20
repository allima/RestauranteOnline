using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestauranteOnline.Helpers
{
    public static class HelperImagens
    {

        public static MvcHtmlString ExibeImagens(this HtmlHelper hp)
        {
            string str =    "<div style =\"width:100%; text-align:center; padding:10px\">" +
                            "<div style=\"width:300px; height:168px; margin:5px; display:inline-block\"> "+
                            "<img src=\"Imagens/ComidaMineira.png\" /></div>" + 
                            "<div style=\"width:300px; height:168px; margin:5px; display:inline-block\"> "+
                            "<img src=\"Imagens/Pizza.png\" /></div>" + 
                            "<div style=\"width:300px; height:168px; margin:5px; display:inline-block\"> " +
                            "<img src=\"Imagens/Hamburger.png\" /></div>" +
                            "</div>";
            return new MvcHtmlString(str);
        }

    }

}