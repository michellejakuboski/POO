using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Net.Http.Headers;

namespace POO
{
    class Apresentacao : Form
    {
        // criar um objeto do automovel
        Automovel carr01 = new Automovel();


        // Objeto
        PictureBox img = new PictureBox();
        Label txtMarca = new Label();
        Label txtTipo = new Label();
        Label txtAno = new Label();
        Label txtVelocidade = new Label();
        Label txtModelo = new Label();

        Button btobj01 = new Button();
        Button btobj02 = new Button();

        // toda classe tem um construtor
        public Apresentacao()
        {
            this.Text = "Titulo ";
            this.Size = new Size(600, 600);
            btobj01.Text = " Clicar ";
            btobj01.Location = new Point(50, 50);
            btobj01.Click += clicar;

            btobj02.Text = "Opala";
            btobj02.Location = new Point(50, 100);
            btobj02.Click += clicar2;

            // Control[] controles = new Control[] { txtMarca, btobj01 }; 
            //this.Controls.Add(btobj01);
            this.Controls.AddRange(new Control[] { txtMarca, btobj01, txtVelocidade
            , txtTipo, txtAno, txtModelo, img, btobj02});

        }

        // metodo de Evento
        private void clicar(object sender, EventArgs e)
        {
            MessageBox.Show("Metodo de Evento");
            // fazer apresentação da carro01
            //carr01.SetMarca("Fiat");
            // this.txtMarca.Text = " Marca : " + carr01.GetMarca();
            carr01.Marca = "Fiat";
            carr01.Ano = 2020;
            carr01.Modelo = "Uno";
            carr01.Velocidade = "200 km/h";

            txtMarca.Text = " Marca : " + carr01.Marca;
            txtModelo.Text = "Tipo :" + carr01.Modelo;
            txtAno.Text = " Ano : " + carr01.Ano;
            txtVelocidade.Text = " Velocidade : " + carr01.Velocidade;

            this.txtMarca.Location = new Point(100, 100);
            this.txtAno.Location = new Point(100, 130);
            this.txtModelo.Location = new Point(100, 150);
            this.txtVelocidade.Location = new Point(100, 180);

            // COLOCAR IMAGEM
            img.Image = Image.FromFile(@"C:\Users\LabInfo\source\repos\POO\img1\jaodivo.jpg");
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Width = 200;
            img.Height = 150;
            this.img.Location = new Point(100, 200);


        }

        private void clicar2(object sender, EventArgs e)
        {
            carr01.Marca = "Chevrollet";
            carr01.Ano = 1980;
            carr01.Modelo = "Opala Coupe";
            carr01.Velocidade = "300 km/h";

            txtMarca.Text = " Marca : " + carr01.Marca;
            txtModelo.Text = "Tipo :" + carr01.Modelo;
            txtAno.Text = " Ano : " + carr01.Ano;
            txtVelocidade.Text = " Velocidade : " + carr01.Velocidade;

            this.txtMarca.Location = new Point(100, 100);
            this.txtAno.Location = new Point(100, 130);
            this.txtModelo.Location = new Point(100, 150);
            this.txtVelocidade.Location = new Point(100, 180);

            // COLOCAR IMAGEM
            img.Image = Image.FromFile(@"C:\Users\LabInfo\source\repos\POO\img1\conangray.jpg");
            img.SizeMode = PictureBoxSizeMode.AutoSize;
            img.Width = 200;
            img.Height = 150;
            this.img.Location = new Point(100, 200);


        }
    }
}