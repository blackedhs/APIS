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
    public partial class FrmSender : Form
    {
        private ManejadorEmails manejador;
        public FrmSender()
        {
            InitializeComponent();
            manejador = new ManejadorEmails();
            CargaChk();
        }
        public void CargaChk()
        {
            try
            {
                manejador.Emails = new DataBase().Abrir();
            }
            catch (MiException miexec)
            {
                MessageBox.Show(miexec.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (Email email in manejador.Emails)
            {
                if (email.Avaible != 0)
                {
                    chkEmails.Items.Add(email);
                    manejador.Cant++;
                }
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            FrmAgregar frm = new FrmAgregar(manejador);
            frm.Show();
            frm.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ActualizarChk);
        }
        private void ActualizarChk(object sender, EventArgs e)
        {
            chkEmails.Items.Clear();
            foreach (Email email in manejador.Emails)
            {
                if (email.Avaible != 0)
                    chkEmails.Items.Add(email);
            }
        }

        private void BrnEliminar_Click(object sender, EventArgs e)
        {
            if (chkEmails.CheckedItems.Count==0)
                MessageBox.Show("Debe seleccionar un elemento");
            else
            {
                foreach (Email email in chkEmails.CheckedItems)
                {
                    if (manejador - email)
                        MessageBox.Show(email.DireccionEmail + " --Eliminado--");
                }
                ActualizarChk(sender, e);
            }
        }

        private void BtnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <manejador.Cant; i++)
            {
                chkEmails.SetItemChecked(i, true);
            }
        }

        private void BtnCancelAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < manejador.Cant; i++)
            {
                chkEmails.SetItemChecked(i, false);
            }
        }

        private void FrmSender_FormClosing(object sender, FormClosingEventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.Guardar(manejador.Emails);
        }
    }

}
