using System;
using System.Text.RegularExpressions;

namespace Quiron.LojaVirtual.Web.Models
{
    public class Paginacao
    {
        //quantos itens no banco
        public int ItensTotal { get; set; }
        //itens por página
        public int ItensPorPagina { get; set; }
        //página exibida no momento
        public int PaginaAtual { get; set; }
        //total de páginas
        public int TotalDePaginas {
            get { return (int) Math.Ceiling((decimal) ItensTotal/ItensPorPagina); }
        }

    }
}