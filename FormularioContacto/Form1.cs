namespace FormularioContacto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEnviar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNombre.Text) ||
                string.IsNullOrEmpty(TextBoxEmail.Text) ||
                string.IsNullOrEmpty(TextBoxMensaje.Text))

            {
                LabelEstado.Text = "Por favor complete todos los campos";
                LabelEstado.ForeColor = System.Drawing.Color.Red;
            }
            else 
            {
                LabelEstado.Text = "Formulario Enviado Correctamente";
                LabelEstado.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
