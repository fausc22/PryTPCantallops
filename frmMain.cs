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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        int reloj = 0;
        private void timerHora_Tick(object sender, EventArgs e)
        {
            reloj += 1000;
            toolHora.Text = Convert.ToString(DateTime.Now);
        }

        private void registroDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmpleados frm = new frmEmpleados();
            frm.ShowDialog();
        }
    }
}
