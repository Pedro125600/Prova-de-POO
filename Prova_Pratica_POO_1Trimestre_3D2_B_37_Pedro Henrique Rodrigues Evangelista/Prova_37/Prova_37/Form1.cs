using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova_37
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Atendente atendente = new Atendente();
        Cliente cliente = new Cliente();


        private void btnVender_Click(object sender, EventArgs e)
        {
            
            string nome, sesao;
            double valor;
            int QuantidadeIngresso;
            bool ValidarCompra;


            nome = txtNomeFilme.Text;
            sesao = txtSesao.Text;
            valor = double.Parse(txtValor.Text);
            QuantidadeIngresso = int.Parse(txtQuantidade.Text);



            nome = atendente.nomeFilme(nome);
            sesao = atendente.Sesao(sesao);
            valor = atendente.IngressoValor(valor);
            QuantidadeIngresso = atendente.QuantidadeIngresso(QuantidadeIngresso);
            
            ValidarCompra = atendente.VendaIngresso(nome , sesao , valor , QuantidadeIngresso);

            if  (ValidarCompra == true)
            {
                MessageBox.Show("compra feita");
            }

            else
            {
                MessageBox.Show("Erro na compra");
            }

        }

        private void btnVisualizar_Click(object sender, EventArgs e)
        {

            double valor , Valortotal;
            int QuantidadeIngresso;
            string total;
            valor = double.Parse(txtValor.Text);
            QuantidadeIngresso = int.Parse(txtQuantidade.Text);

            Valortotal = cliente.ValorTotal(valor, QuantidadeIngresso);

           total = Valortotal.ToString();


            MessageBox.Show(total, "R$");
        

   
           



        }
    }
}
