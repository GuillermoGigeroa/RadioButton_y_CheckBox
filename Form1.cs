using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton_y_CheckBox
{
    public partial class Ventana : Form
    {
        public Ventana()
        {
            InitializeComponent();
        }
        private void ValidarOk()
        {
            //Habilita el botón, siempre y cuando el textbox tenga datos.
            BotonOK.Enabled = (txtNombre.BackColor != Color.Red);
        }
        private void BotonOK_Click(object sender, EventArgs e)
        {
            String salida;

            salida = "Nombre: " + txtNombre.Text + "\r\n";
            salida += "Ocupación: " + (string)(CheckProgramador.Checked ? "Programador" : "No es programador") + "\r\n";
            salida += "Sexo: " + (string)(RadioButtonHombre.Checked ? "Hombre" : "Mujer") + "\r\n";

            txtSalida.Text   = salida;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
                tb.BackColor = Color.Red;
            else
                tb.BackColor = System.Drawing.SystemColors.Window;

            ValidarOk();
        }

        private void Ventana_Load(object sender, EventArgs e)
        {
            //Deshabilito el boton OK.
            BotonOK.Enabled = false;
        }
    }
}
