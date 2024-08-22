namespace FormularioContacto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            EtiquetaNombre = new Label();
            EtiquetaEmail = new Label();
            EtiquetaMensaje = new Label();
            TextBoxNombre = new TextBox();
            TextBoxEmail = new TextBox();
            TextBoxMensaje = new TextBox();
            ButtonEnviar = new Button();
            label1 = new Label();
            LabelEstado = new Label();
            SuspendLayout();
            // 
            // EtiquetaNombre
            // 
            EtiquetaNombre.AutoSize = true;
            EtiquetaNombre.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaNombre.Location = new Point(347, 70);
            EtiquetaNombre.Name = "EtiquetaNombre";
            EtiquetaNombre.Size = new Size(63, 17);
            EtiquetaNombre.TabIndex = 0;
            EtiquetaNombre.Text = "Nombre";
            // 
            // EtiquetaEmail
            // 
            EtiquetaEmail.AutoSize = true;
            EtiquetaEmail.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaEmail.Location = new Point(308, 153);
            EtiquetaEmail.Name = "EtiquetaEmail";
            EtiquetaEmail.Size = new Size(153, 17);
            EtiquetaEmail.TabIndex = 1;
            EtiquetaEmail.Text = "Correo Electrónico";
            EtiquetaEmail.Click += label2_Click;
            // 
            // EtiquetaMensaje
            // 
            EtiquetaMensaje.AutoSize = true;
            EtiquetaMensaje.Font = new Font("Showcard Gothic", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EtiquetaMensaje.Location = new Point(350, 240);
            EtiquetaMensaje.Name = "EtiquetaMensaje";
            EtiquetaMensaje.Size = new Size(63, 17);
            EtiquetaMensaje.TabIndex = 2;
            EtiquetaMensaje.Text = "Mensaje";
            // 
            // TextBoxNombre
            // 
            TextBoxNombre.BackColor = SystemColors.ControlLightLight;
            TextBoxNombre.Location = new Point(273, 87);
            TextBoxNombre.Name = "TextBoxNombre";
            TextBoxNombre.Size = new Size(216, 27);
            TextBoxNombre.TabIndex = 3;
            TextBoxNombre.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxEmail
            // 
            TextBoxEmail.BackColor = SystemColors.ControlLightLight;
            TextBoxEmail.Location = new Point(268, 173);
            TextBoxEmail.Name = "TextBoxEmail";
            TextBoxEmail.Size = new Size(226, 27);
            TextBoxEmail.TabIndex = 4;
            TextBoxEmail.TextAlign = HorizontalAlignment.Center;
            // 
            // TextBoxMensaje
            // 
            TextBoxMensaje.BackColor = SystemColors.ControlLightLight;
            TextBoxMensaje.Location = new Point(227, 258);
            TextBoxMensaje.Multiline = true;
            TextBoxMensaje.Name = "TextBoxMensaje";
            TextBoxMensaje.Size = new Size(309, 27);
            TextBoxMensaje.TabIndex = 5;
            TextBoxMensaje.TextAlign = HorizontalAlignment.Center;
            // 
            // ButtonEnviar
            // 
            ButtonEnviar.BackColor = SystemColors.ActiveCaptionText;
            ButtonEnviar.Font = new Font("Showcard Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ButtonEnviar.ForeColor = SystemColors.ButtonFace;
            ButtonEnviar.Location = new Point(310, 334);
            ButtonEnviar.Name = "ButtonEnviar";
            ButtonEnviar.Size = new Size(150, 51);
            ButtonEnviar.TabIndex = 6;
            ButtonEnviar.Text = "Enviar";
            ButtonEnviar.UseVisualStyleBackColor = false;
            ButtonEnviar.Click += ButtonEnviar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(319, 29);
            label1.TabIndex = 7;
            label1.Text = "Formulario De Contacto";
            // 
            // LabelEstado
            // 
            LabelEstado.AutoSize = true;
            LabelEstado.Font = new Font("Showcard Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LabelEstado.Location = new Point(236, 406);
            LabelEstado.Name = "LabelEstado";
            LabelEstado.Size = new Size(0, 18);
            LabelEstado.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(LabelEstado);
            Controls.Add(label1);
            Controls.Add(ButtonEnviar);
            Controls.Add(TextBoxMensaje);
            Controls.Add(TextBoxEmail);
            Controls.Add(TextBoxNombre);
            Controls.Add(EtiquetaMensaje);
            Controls.Add(EtiquetaEmail);
            Controls.Add(EtiquetaNombre);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EtiquetaNombre;
        private Label EtiquetaEmail;
        private Label EtiquetaMensaje;
        private TextBox TextBoxNombre;
        private TextBox TextBoxEmail;
        private TextBox TextBoxMensaje;
        private Button ButtonEnviar;
        private Label label1;
        private Label LabelEstado;
    }
}
