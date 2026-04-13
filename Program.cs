using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
