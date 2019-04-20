using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void UserControl11_Load(object sender, EventArgs e)
        {

        }

        private void UcUser1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (ucUser.Text == "thaeny1" + "" && ucPassword.Text == "2410")
            {
                //ENTRE NO SISTEMA
                Frm_MenuPrincipal novo = new Frm_MenuPrincipal();
                novo.Show();
            }
            else if (ucUser.Text == "Usuario2" && ucPassword.Text == "Senha2")
            {
                //ENTRE NO SISTEMA
                Frm_MenuPrincipal novo = new Frm_MenuPrincipal();
                novo.Show();
            }


            else
            {
                MessageBox.Show("Usuário não cadastrado");
            }
        }
    }
}
