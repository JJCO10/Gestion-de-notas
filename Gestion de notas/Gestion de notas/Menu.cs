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
                frmGestionEstudiantes.StartPosition = FormStartPosition.Manual;
                frmGestionEstudiantes.Location = new Point(0, 0);
                frmGestionEstudiantes.Show();
            }
            else
            {
                frmOpen.BringToFront();
            }

        }

        private void gestionDocentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionDocentes frmGestionDocentes = new frmGestionDocentes();
                frmGestionDocentes.MdiParent = this;
                frmGestionDocentes.StartPosition = FormStartPosition.Manual;
                frmGestionDocentes.Location = new Point(0, 0);
                frmGestionDocentes.Show();
            }
            else
            {
                frmOpen.BringToFront();
            }

        }

        private void gradosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionGrados frmGestionGrados = new frmGestionGrados();
                frmGestionGrados.MdiParent = this;
                frmGestionGrados.StartPosition = FormStartPosition.Manual;
                frmGestionGrados.Location = new Point(0, 0);
                frmGestionGrados.Show();
            }
            else
            {
                frmOpen.BringToFront();
            }

        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionMaterias frmGestionMaterias = new frmGestionMaterias();
                frmGestionMaterias.MdiParent = this;
                frmGestionMaterias.StartPosition = FormStartPosition.Manual;
                frmGestionMaterias.Location = new Point(0, 0);
                frmGestionMaterias.Show();
            }
            else
            {
                frmOpen.BringToFront();
            }

        }

        private void notasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmOpen = Application.OpenForms["frmGestionDocentes"];

            if (frmOpen == null)
            {
                frmGestionNotas frmGestionNotas = new frmGestionNotas();
                frmGestionNotas.MdiParent = this;
                frmGestionNotas.StartPosition = FormStartPosition.Manual;
                frmGestionNotas.Location = new Point(0, 0);
                frmGestionNotas.Show();
            }
            else
            {
                frmOpen.BringToFront();
            }

        }
    }
}
