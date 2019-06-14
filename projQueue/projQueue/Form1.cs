using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projQueue
{
    public partial class Form1 : Form
    {
        Senhas senhas = new Senhas();
        Guiches guiches = new Guiches();

        public Form1()
        {
            InitializeComponent();            
        }

        private void btn_gerar_Click(object sender, EventArgs e)
        {
            senhas.gerar();
        }

        private void btn_listSenha_Click(object sender, EventArgs e)
        {
            list_senha.Items.Clear();
            
            
            foreach (Senha local in senhas.getSenhas())
            {
                list_senha.Items.Add(local.dadosParciais());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            guiches.Adicionar(new Guiche(guiches.qtdGuiches()+1));

            cb_guiche.Items.Clear();

            for(int a = 1; a < guiches.qtdGuiches()+1; a++)
            {
                cb_guiche.Items.Add(a.ToString());
            }
            lbl_guiche.Text = guiches.qtdGuiches().ToString();
        }

        private void btn_chamar_Click(object sender, EventArgs e)
        {
            foreach (Guiche x in guiches.getGuiche())
            {
                if (x.getID() == int.Parse(cb_guiche.Text))
                {
                    x.Chamar(senhas.getSenhas());
                }
            }
        }

        private void btn_listAtend_Click(object sender, EventArgs e)
        {
            list_chamadas.Items.Clear();

            foreach (Guiche local in guiches.getGuiche())
            {
                //if(local.)  //não lembro oq faz isso
                foreach(Senha x in local.getAtendimento())
                {
                    list_chamadas.Items.Add(x.dadosCompletos());
                }
            }

        }
    }
}
