﻿namespace Gestion_de_notas
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionEstudiantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDocentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(5, 2, 5, 4);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionEstudiantesToolStripMenuItem,
            this.gestionDocentesToolStripMenuItem,
            this.gradosToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionEstudiantesToolStripMenuItem
            // 
            this.gestionEstudiantesToolStripMenuItem.Image = global::Gestion_de_notas.Properties.Resources.gestionEstudiante;
            this.gestionEstudiantesToolStripMenuItem.Name = "gestionEstudiantesToolStripMenuItem";
            this.gestionEstudiantesToolStripMenuItem.Size = new System.Drawing.Size(158, 21);
            this.gestionEstudiantesToolStripMenuItem.Text = "Gestion Estudiantes";
            // 
            // gestionDocentesToolStripMenuItem
            // 
            this.gestionDocentesToolStripMenuItem.Image = global::Gestion_de_notas.Properties.Resources.gestionDocente;
            this.gestionDocentesToolStripMenuItem.Name = "gestionDocentesToolStripMenuItem";
            this.gestionDocentesToolStripMenuItem.Size = new System.Drawing.Size(145, 21);
            this.gestionDocentesToolStripMenuItem.Text = "Gestion Docentes";
            // 
            // gradosToolStripMenuItem
            // 
            this.gradosToolStripMenuItem.Image = global::Gestion_de_notas.Properties.Resources.Grados;
            this.gradosToolStripMenuItem.Name = "gradosToolStripMenuItem";
            this.gradosToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.gradosToolStripMenuItem.Text = "Grados";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Image = global::Gestion_de_notas.Properties.Resources.materias;
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.Image = global::Gestion_de_notas.Properties.Resources.notas;
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionEstudiantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDocentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
    }
}