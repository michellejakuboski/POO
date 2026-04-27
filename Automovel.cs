using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    internal class Automovel
    {
        private string Marca { get; set; };
        private string Modelo { get; set; };
        private string Velociade { get; set; };
        private int Ano { get; set; };
        private string imagen { get; set; };

        //public void SetMarca(string marca)
        //{
        //    Marca = marca;
        //}

        //  public string GetMarca()
        // {
        //   return Marca;
        // }

        public Automovel()
        {
          
         }

        public Automovel(string marca)
        {
            this.Marca = marca;
        }
    }
    //visibilidade de uma classe: public, private, protected, internal, protected internal, private protected
    // private - pode ser acessado apenas dentro da própria classe, ou seja, não pode ser acessado por outras classes, ou seja, é o mais restritivo dos modificadores de acesso.
    // public - pode ser acessado qualquer classe
    //protected - só acessada pela propria classe e pela classes derivadas
    //internal - só pode ser acessado pelo mesmo assembly
    // criar um construtor/

    // o que a gnt fazia antes: 

    //private string marca; //atributo privado, ou seja, só pode ser acessado dentro da própria classe

    //metodo de acesso:
    //public void SetMarca( string x)
    // {
    //  Marca = x;
    // }
    //public string GetMarca()
    //
    // agora:

}
