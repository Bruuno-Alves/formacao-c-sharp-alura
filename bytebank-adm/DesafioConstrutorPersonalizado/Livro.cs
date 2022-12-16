using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioConstrutorPersonalizado
{
    internal class Livro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
        public int AnoPublicacao { get; set; }
        public string EstiloLiterario { get; set; }
        public int NumeroPaginas { get; set; }
        public string PaisPublicacao { get; set; }
        
        public Livro(string titulo, string isbn) { 
            this.Titulo = titulo;
            this.Isbn = isbn;
        }

        public override string ToString()
        {
            return $"Titulo: {this.Titulo}, ISBN: {this.Isbn}";
        }
    }
}
