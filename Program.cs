using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
//para usar as duas bibliotecas tem que baixar as referencias

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //primeira classe a ser chamada:
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ApresentacaoForm()); 
        }
    }
}
