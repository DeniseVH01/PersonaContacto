using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonaContacto_C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTNlimpiar_Click(object sender, EventArgs e)
        {
            TXTnombre.Clear();
            TXTapp.Clear();
            TXTapm.Clear();
            TXTtelef.Clear();
            TXTcorreoe.Clear();
            DTPfn.ResetText();
        }

        private void BTNmostrar_Click(object sender, EventArgs e)
        {
            var Nombre = TXTnombre.Text;
            var ApellidoP = TXTapp.Text;
            var ApellidoM = TXTapm.Text;
            var Telefono = TXTtelef.Text;
            var CorreoE = TXTcorreoe.Text;
            var FechaN = DTPfn.Value;
            string RFC= null ;
            Contacto Contacto1 = new Contacto(Nombre, ApellidoP, ApellidoM, FechaN,RFC , Telefono, CorreoE);
            MessageBox.Show(Contacto1.Info, "Contacto");
        }
    }
}
