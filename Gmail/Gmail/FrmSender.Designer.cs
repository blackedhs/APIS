namespace Gmail
{
    partial class FrmSender
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.richLog = new System.Windows.Forms.RichTextBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.chkEmails = new System.Windows.Forms.CheckedListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.brnEliminar = new System.Windows.Forms.Button();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnCancelAll = new System.Windows.Forms.Button();
            this.gbxConexion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.gbxConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // richLog
            // 
            this.richLog.Location = new System.Drawing.Point(12, 302);
            this.richLog.Name = "richLog";
            this.richLog.Size = new System.Drawing.Size(608, 136);
            this.richLog.TabIndex = 0;
            this.richLog.Text = "";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(639, 303);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(140, 47);
            this.btnIniciar.TabIndex = 1;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            // 
            // btnDetener
            // 
            this.btnDetener.Location = new System.Drawing.Point(639, 374);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(140, 47);
            this.btnDetener.TabIndex = 2;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = true;
            // 
            // chkEmails
            // 
            this.chkEmails.FormattingEnabled = true;
            this.chkEmails.Location = new System.Drawing.Point(12, 27);
            this.chkEmails.Name = "chkEmails";
            this.chkEmails.Size = new System.Drawing.Size(453, 259);
            this.chkEmails.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(487, 27);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Agregar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // brnEliminar
            // 
            this.brnEliminar.Location = new System.Drawing.Point(487, 56);
            this.brnEliminar.Name = "brnEliminar";
            this.brnEliminar.Size = new System.Drawing.Size(75, 23);
            this.brnEliminar.TabIndex = 5;
            this.brnEliminar.Text = "Eliminar";
            this.brnEliminar.UseVisualStyleBackColor = true;
            this.brnEliminar.Click += new System.EventHandler(this.BrnEliminar_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmail.Location = new System.Drawing.Point(12, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(92, 13);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Lista de Emails";
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(487, 85);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(75, 44);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = "Seleccion Todo";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.BtnSelectAll_Click);
            // 
            // btnCancelAll
            // 
            this.btnCancelAll.Location = new System.Drawing.Point(487, 135);
            this.btnCancelAll.Name = "btnCancelAll";
            this.btnCancelAll.Size = new System.Drawing.Size(75, 47);
            this.btnCancelAll.TabIndex = 9;
            this.btnCancelAll.Text = "Cancelar Seleccion";
            this.btnCancelAll.UseVisualStyleBackColor = true;
            this.btnCancelAll.Click += new System.EventHandler(this.BtnCancelAll_Click);
            // 
            // gbxConexion
            // 
            this.gbxConexion.Controls.Add(this.btnDesconectar);
            this.gbxConexion.Controls.Add(this.btnConectar);
            this.gbxConexion.Controls.Add(this.txtContraseña);
            this.gbxConexion.Controls.Add(this.txtEmail);
            this.gbxConexion.Controls.Add(this.label2);
            this.gbxConexion.Controls.Add(this.label1);
            this.gbxConexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxConexion.ForeColor = System.Drawing.SystemColors.Control;
            this.gbxConexion.Location = new System.Drawing.Point(579, 12);
            this.gbxConexion.Name = "gbxConexion";
            this.gbxConexion.Size = new System.Drawing.Size(199, 134);
            this.gbxConexion.TabIndex = 10;
            this.gbxConexion.TabStop = false;
            this.gbxConexion.Text = "Conexion Cuenta de correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Direccion de correo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(6, 33);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(187, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(6, 73);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(187, 20);
            this.txtContraseña.TabIndex = 3;
            // 
            // btnConectar
            // 
            this.btnConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConectar.Location = new System.Drawing.Point(6, 99);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(92, 23);
            this.btnConectar.TabIndex = 4;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDesconectar.Location = new System.Drawing.Point(104, 99);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(89, 23);
            this.btnDesconectar.TabIndex = 5;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            // 
            // FrmSender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxConexion);
            this.Controls.Add(this.btnCancelAll);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.brnEliminar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkEmails);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.richLog);
            this.Name = "FrmSender";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmailSender";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSender_FormClosing);
            this.gbxConexion.ResumeLayout(false);
            this.gbxConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richLog;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.CheckedListBox chkEmails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button brnEliminar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnCancelAll;
        private System.Windows.Forms.GroupBox gbxConexion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtEmail;
    }
}

