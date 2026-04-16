using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
//para usar as duas bibliotecas tem que baixar as referencias


//herança herda coisas de uma certa classe ou namespace, ou seja, a classe filha herda as características da classe pai, e pode ter suas próprias características, ou seja, seus próprios métodos e atributos.

namespace POO
{
    internal class ApresentacaoForm : Form //-- herança, ou seja, a classe ApresentacaoForm é filha da classe Form, ou seja, ApresentacaoForm herda as características da classe Form, ou seja, ApresentacaoForm é um tipo de Form, ou seja, ApresentacaoForm é um formulário do Windows Forms.
    {
        //toda classe tem um construtor
        // criar um objeto label e botao
        //Button botao1 = new Button();
        Label titulo1 = new Label();
        Label titulo2 = new Label();
        Automovel obj1 = new Automovel();
        
        //CONSTRUTOR: é um método especial que é chamado quando um objeto é criado, ou seja, quando uma instância da classe é criada, o construtor é chamado automaticamente, e é usado para inicializar os atributos do objeto, ou seja, para dar valores iniciais aos atributos do objeto, ou seja, para configurar o objeto de acordo com as necessidades do programa.
        public ApresentacaoForm() {//visibilidade de uma classe
                this.Text = "Apresentação";    
            this.Size = new Size(500, 500);
            titulo1.Text = "BEM VINDO A APRESENTAÇÃO DE ELEMENTOS EM CLASSE!";
            titulo1.Font = new Font("Arial", 16);
            titulo1.AutoSize = true; //fazer o label se ajustar ao tamanho do texto
            titulo1.Location = new Point(50, 50); //definir a posição/coordendas do label na tela

            obj1.Marca = "Ford";
            titulo2.Text = obj1.Marca;
            titulo2.Size = new Size(300, 200);
            titulo2.Location = new Point(100, 100);

            Button botao1 = new Button();
            botao1.Text = "Clique";
            botao1.Location = new Point(100,150);
            botao1.Click += clique; 
            this.Controls.Add(botao1);

            Control[] elementos = { titulo1, titulo2 };
            this.Controls.AddRange(elementos); 

        }

        private void clique(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no botão!");
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ApresentacaoForm
            // 
            this.ClientSize = new System.Drawing.Size(825, 244);
            this.Name = "ApresentacaoForm";
            this.Load += new System.EventHandler(this.ApresentacaoForm_Load);
            this.ResumeLayout(false);

        }

        private void ApresentacaoForm_Load(object sender, EventArgs e)
        {

        }
    }
}
