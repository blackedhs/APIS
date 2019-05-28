using EnvioMails;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormEnvioMails
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            txtClave.PasswordChar = '•';
        }
        private void btnEnviar_Click(object sender, EventArgs e)
        {
            DialogResult rta= DialogResult.OK;
            if (string.IsNullOrEmpty(txtCuenta.Text))
            {
                MessageBox.Show("Falta completar campo 'cuenta'"); return;
            }
            if (!txtCuenta.Text.Contains('@') || !txtCuenta.Text.Contains('.'))
            {
                txtCuenta.Text += "@gmail.com";
            }
            if (string.IsNullOrEmpty(txtClave.Text))
            {
                MessageBox.Show("Falta completar campo 'Clave'");
                return;
            }
            if (txtClave.Text.Trim().Length < 6)
            {
                MessageBox.Show("El campo 'Clave' está incompleto");
                return;
            }
            if (string.IsNullOrEmpty(txtAsunto.Text) && !string.IsNullOrEmpty(txtCuerpo.Text))
            {
                rta = MessageBox.Show("El mail no tiene 'asunto', desea enviarlo de todos modos?", "Confirmar", MessageBoxButtons.OKCancel);
            }
            if (string.IsNullOrEmpty(txtCuerpo.Text) && !string.IsNullOrEmpty(txtAsunto.Text))
            {
                rta = MessageBox.Show("El mail no tiene 'cuerpo', desea enviarlo de todos modos?", "Confirmar", MessageBoxButtons.OKCancel);
            }
            if (string.IsNullOrEmpty(txtCuerpo.Text) && string.IsNullOrEmpty(txtAsunto.Text))
            {
                MessageBox.Show("No puede enviar un mail vacío.");
                return;
            }
            if (rta == DialogResult.OK)
            {
                try
                {

                    Dato dato = new Dato(txtCuenta.Text, txtClave.Text, txtAsunto.Text, txtCuerpo.Text, null);
                    Proceso proceso = new Proceso();
                    if(proceso.Iniciar(dato))
                        MessageBox.Show("Mails enviados exitosamente!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdjunto_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }
}
