using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBBDD
{
    public partial class ConexionSQL : Form
    {
        public ConexionSQL()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Si el botón Conectar está habilitado, cambiamos el texto a "Conectado"
        /// Si está deshabilitado, cambiamos el texto a "Desconectado"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEstadoBBDD_TextChanged(object sender, EventArgs e)
        {
            if (btnConectar.Enabled == true)
                txtEstadoBBDD.Text = "Conectado";
            else 
                txtEstadoBBDD.Text = "Desconectado";
        }
    }
}
