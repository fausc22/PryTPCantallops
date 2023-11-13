using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryTPCantallops
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
        }

        clsBD objBD = new clsBD();

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            objBD.CargarTreeView(tvEmpleados);
        }

        private void tvEmpleados_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void tvEmpleados_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string codEmpleado = e.Node.Text;

            objBD.MostrarDatos(codEmpleado, rtbInfo);
        }
    }
}
