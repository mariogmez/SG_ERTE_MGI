﻿
namespace SG_ERTE_MGI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mntsPrincipal = new System.Windows.Forms.MenuStrip();
            this.aDMINISTRARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eRTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iNFORMESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mntsPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mntsPrincipal
            // 
            this.mntsPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aDMINISTRARToolStripMenuItem,
            this.eRTESToolStripMenuItem,
            this.iNFORMESToolStripMenuItem,
            this.sALIRToolStripMenuItem});
            this.mntsPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mntsPrincipal.Name = "mntsPrincipal";
            this.mntsPrincipal.Size = new System.Drawing.Size(800, 24);
            this.mntsPrincipal.TabIndex = 0;
            this.mntsPrincipal.Text = "menuStrip1";
            // 
            // aDMINISTRARToolStripMenuItem
            // 
            this.aDMINISTRARToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empresasToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.aDMINISTRARToolStripMenuItem.Name = "aDMINISTRARToolStripMenuItem";
            this.aDMINISTRARToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.aDMINISTRARToolStripMenuItem.Text = "ADMINISTRAR";
            // 
            // empresasToolStripMenuItem
            // 
            this.empresasToolStripMenuItem.Name = "empresasToolStripMenuItem";
            this.empresasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empresasToolStripMenuItem.Text = "Empresas";
            this.empresasToolStripMenuItem.Click += new System.EventHandler(this.empresasToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // eRTESToolStripMenuItem
            // 
            this.eRTESToolStripMenuItem.Name = "eRTESToolStripMenuItem";
            this.eRTESToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.eRTESToolStripMenuItem.Text = "ERTES";
            this.eRTESToolStripMenuItem.Click += new System.EventHandler(this.eRTESToolStripMenuItem_Click);
            // 
            // iNFORMESToolStripMenuItem
            // 
            this.iNFORMESToolStripMenuItem.Name = "iNFORMESToolStripMenuItem";
            this.iNFORMESToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.iNFORMESToolStripMenuItem.Text = "INFORMES";
            this.iNFORMESToolStripMenuItem.Click += new System.EventHandler(this.iNFORMESToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mntsPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mntsPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPrincipal";
            this.mntsPrincipal.ResumeLayout(false);
            this.mntsPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mntsPrincipal;
        private System.Windows.Forms.ToolStripMenuItem aDMINISTRARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eRTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iNFORMESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
    }
}

