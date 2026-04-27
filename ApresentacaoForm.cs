using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
//para usar as duas bibliotecas tem que baixar as referencias


//herança herda coisas de uma certa classe ou namespace, ou seja, a classe filha herda as características da classe pai, e pode ter suas próprias características, ou seja, seus próprios métodos e atributos.

namespace POO
{
    internal class ApresentacaoForm : Form //-- herança, ou seja, a classe ApresentacaoForm é filha da classe Form, ou seja, ApresentacaoForm herda as características da classe Form, ou seja, ApresentacaoForm é um tipo de Form, ou seja, ApresentacaoForm é um formulário do Windows Forms.
    {
        
        //CONSTRUTOR: é um método especial que é chamado quando um objeto é criado, ou seja, quando uma instância da classe é criada, o construtor é chamado automaticamente, e é usado para inicializar os atributos do objeto, ou seja, para dar valores iniciais aos atributos do objeto, ou seja, para configurar o objeto de acordo com as necessidades do programa.
        public ApresentacaoForm() {//visibilidade de uma classe
            this.Text = "Apresentação";
            //criar obj automovel
            Automovel carro01 = new Automovel();

            //objeto
            Label txtMarca = new Label();
            Label txtTipo = new Label();
            Label txtModelo = new Label();
            Label txtAno = new Label();
            Label lblVelocidade = new Label();
            Button botao1 = new Button();

            //toda classe tem um construtor
            // criar um objeto label e botao
            //Button botao1 = new Button();
            Label titulo1 = new Label();
            Label titulo2 = new Label();
            Automovel obj1 = new Automovel();

            PictureBox pictureBox1 = new PictureBox();

            obj1.SetMarca("Ford");
            titulo2.Text = obj1.GetMarca();
            titulo2.Size = new Size(300, 200);
            titulo2.Location = new Point(100, 100);

            Button botao1 = new Button();
            botao1.Text = "Clique";
            botao1.Location = new Point(100,150);
            botao1.Click += clique; 
            this.Controls.Add(botao1);

            Control[] elementos = { titulo1, titulo2 };
            this.Controls.AddRange(elementos);

            //fazer apresenttação de carro01
            carro01.SetMarca("Fiat");
            this.txtMarca.Text = carro01.GetMarca();
            this.txtMarca.Location = new Point(200, 200);

            this.Controls.AddRange(new Control[] { txtMarca, txtModelo, txtAno, txtTipo, txtVelocidade, botao1 });

        }

        private void clique(object sender, EventArgs e)
        {
            MessageBox.Show("Você clicou no botão!");
            carro01.Marca = "Fiat";
            carro01.Ano = 2020;
            carro01.Modelo = "Uno";
            carro01.Velocidade = "200 km/h";

            txtMarca.Text = "Marca: " + carro01.Marca;
            txtModelo.Text = "Modelo: " + carro01.Modelo;
            txtAno.Text = "Ano: " + carro01.Ano;
            txtVelocidade.Text = "Velocidade: " + carro01.Velocidade;

            this.txtMarca.Location = new Point(200, 200);
            this.txtModelo.Location = new Point(200, 230);  
            this.txtAno.Location = new Point(200, 260);
            this.txtVelocidade.Location = new Point(200, 290);

            //colocar imagem
            img.Image = Image.FromFile("C:\\Users\\marce\\OneDrive\\Documentos\\GitHub\\POO\\jao.jpg");
            img.SizeMode = new Size(200, 200);
            img.Widht = 200;
            img.Height = 200;
            this.img.Location = new Point(400, 200);
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
