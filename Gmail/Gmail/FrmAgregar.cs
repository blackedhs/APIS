using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gmail
{
    public partial class FrmAgregar : Form
    {
        ManejadorEmails manejador;
        public FrmAgregar(ManejadorEmails manejadorEmails)
        {
            InitializeComponent();
            this.manejador = manejadorEmails;
            
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (manejador + new Email(txtName.Text, txtEmail.Text, richDescripcion.Text, 1))
            {
                MessageBox.Show("La oparacion fue exitosa");
                this.Close();
            }
            else
            {
                MessageBox.Show("El email ingresado es invalido o esta repedio.Vuelva a intentar nuevamente");
            }               
        }
    }
}
