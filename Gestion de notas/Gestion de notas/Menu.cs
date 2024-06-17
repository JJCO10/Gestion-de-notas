using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_notas
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void gestionEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionEstudiantes"];


            if (frmOpen == null)
            {
                frmGestionEstudiantes frmGestionEstudiantes = new frmGestionEstudiantes();
                frmGestionEstudiantes.MdiParent = this;
                frmGestionEstudiantes.Show();
            }

        }

        private void gestionDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionDocentes frmGestionDocentes = new frmGestionDocentes();
                frmGestionDocentes.MdiParent = this;
                frmGestionDocentes.Show();
            }

        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionGrados frmGestionGrados = new frmGestionGrados();
                frmGestionGrados.MdiParent = this;
                frmGestionGrados.Show();
            }

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionMaterias frmGestionMaterias = new frmGestionMaterias();
                frmGestionMaterias.MdiParent = this;
                frmGestionMaterias.Show();
            }

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionNotas frmGestionNotas = new frmGestionNotas();
                frmGestionNotas.MdiParent = this;
                frmGestionNotas.Show();
            }

        }
    }
}
