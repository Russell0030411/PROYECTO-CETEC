﻿namespace CineTEC.Vistas.Contenedores
{
    partial class VistaSalas
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
            this.lblCINETEC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCINETEC
            // 
            this.lblCINETEC.AutoSize = true;
            this.lblCINETEC.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCINETEC.Location = new System.Drawing.Point(324, 9);
            this.lblCINETEC.Name = "lblCINETEC";
            this.lblCINETEC.Size = new System.Drawing.Size(122, 24);
            this.lblCINETEC.TabIndex = 1;
            this.lblCINETEC.Text = "CINECTEC";
            // 
            // VistaSalas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCINETEC);
            this.Name = "VistaSalas";
            this.Text = "VistaSalas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCINETEC;
    }
}