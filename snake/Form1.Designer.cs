﻿namespace snake
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Puntaje = new System.Windows.Forms.Label();
            this.Puntos = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.canvas = new System.Windows.Forms.PictureBox();
            this.Velocity = new System.Windows.Forms.Label();
            this.Velocidad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.SuspendLayout();
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.Location = new System.Drawing.Point(6, 286);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(113, 33);
            this.Puntaje.TabIndex = 1;
            this.Puntaje.Text = "Puntos:";
            this.Puntaje.Click += new System.EventHandler(this.Puntaje_Click);
            // 
            // Puntos
            // 
            this.Puntos.AutoSize = true;
            this.Puntos.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntos.Location = new System.Drawing.Point(111, 288);
            this.Puntos.Name = "Puntos";
            this.Puntos.Size = new System.Drawing.Size(31, 33);
            this.Puntos.TabIndex = 2;
            this.Puntos.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.SystemColors.Control;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(660, 260);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.Click += new System.EventHandler(this.canvas_Click);
            // 
            // Velocity
            // 
            this.Velocity.AutoSize = true;
            this.Velocity.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocity.Location = new System.Drawing.Point(286, 286);
            this.Velocity.Name = "Velocity";
            this.Velocity.Size = new System.Drawing.Size(150, 32);
            this.Velocity.TabIndex = 3;
            this.Velocity.Text = "Velocidad:";
            // 
            // Velocidad
            // 
            this.Velocidad.AutoSize = true;
            this.Velocidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocidad.Location = new System.Drawing.Point(427, 287);
            this.Velocidad.Name = "Velocidad";
            this.Velocidad.Size = new System.Drawing.Size(31, 32);
            this.Velocidad.TabIndex = 4;
            this.Velocidad.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 361);
            this.Controls.Add(this.Velocidad);
            this.Controls.Add(this.Velocity);
            this.Controls.Add(this.Puntos);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Culebrita";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Label Puntaje;
        private System.Windows.Forms.Label Puntos;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Velocity;
        private System.Windows.Forms.Label Velocidad;
    }
}

