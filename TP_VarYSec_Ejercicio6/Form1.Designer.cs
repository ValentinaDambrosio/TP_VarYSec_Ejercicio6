namespace TP_VarYSec_Ejercicio6
{
    partial class fSala
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
            this.bCerrar = new System.Windows.Forms.Button();
            this.bOcupacion = new System.Windows.Forms.Button();
            this.bSalida = new System.Windows.Forms.Button();
            this.bEntrada = new System.Windows.Forms.Button();
            this.lCapacidad = new System.Windows.Forms.Label();
            this.lCupoActual = new System.Windows.Forms.Label();
            this.tCapacidad = new System.Windows.Forms.TextBox();
            this.tCupoActual = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bCerrar
            // 
            this.bCerrar.Location = new System.Drawing.Point(461, 252);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(75, 23);
            this.bCerrar.TabIndex = 0;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // bOcupacion
            // 
            this.bOcupacion.Location = new System.Drawing.Point(380, 252);
            this.bOcupacion.Name = "bOcupacion";
            this.bOcupacion.Size = new System.Drawing.Size(75, 23);
            this.bOcupacion.TabIndex = 1;
            this.bOcupacion.Text = "Ocupación";
            this.bOcupacion.UseVisualStyleBackColor = true;
            this.bOcupacion.Click += new System.EventHandler(this.bOcupacion_Click);
            // 
            // bSalida
            // 
            this.bSalida.Location = new System.Drawing.Point(299, 252);
            this.bSalida.Name = "bSalida";
            this.bSalida.Size = new System.Drawing.Size(75, 23);
            this.bSalida.TabIndex = 2;
            this.bSalida.Text = "Salida";
            this.bSalida.UseVisualStyleBackColor = true;
            this.bSalida.Click += new System.EventHandler(this.bSalida_Click);
            // 
            // bEntrada
            // 
            this.bEntrada.Location = new System.Drawing.Point(218, 252);
            this.bEntrada.Name = "bEntrada";
            this.bEntrada.Size = new System.Drawing.Size(75, 23);
            this.bEntrada.TabIndex = 3;
            this.bEntrada.Text = "Entrada";
            this.bEntrada.UseVisualStyleBackColor = true;
            this.bEntrada.Click += new System.EventHandler(this.bEntrada_Click);
            // 
            // lCapacidad
            // 
            this.lCapacidad.AutoSize = true;
            this.lCapacidad.Location = new System.Drawing.Point(50, 41);
            this.lCapacidad.Name = "lCapacidad";
            this.lCapacidad.Size = new System.Drawing.Size(84, 13);
            this.lCapacidad.TabIndex = 4;
            this.lCapacidad.Text = "Capacidad total:";
            // 
            // lCupoActual
            // 
            this.lCupoActual.AutoSize = true;
            this.lCupoActual.Location = new System.Drawing.Point(67, 82);
            this.lCupoActual.Name = "lCupoActual";
            this.lCupoActual.Size = new System.Drawing.Size(67, 13);
            this.lCupoActual.TabIndex = 5;
            this.lCupoActual.Text = "Cupo actual:";
            // 
            // tCapacidad
            // 
            this.tCapacidad.Location = new System.Drawing.Point(140, 41);
            this.tCapacidad.Name = "tCapacidad";
            this.tCapacidad.Size = new System.Drawing.Size(100, 20);
            this.tCapacidad.TabIndex = 6;
            // 
            // tCupoActual
            // 
            this.tCupoActual.Location = new System.Drawing.Point(140, 79);
            this.tCupoActual.Name = "tCupoActual";
            this.tCupoActual.Size = new System.Drawing.Size(100, 20);
            this.tCupoActual.TabIndex = 7;
            // 
            // fSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 287);
            this.Controls.Add(this.tCupoActual);
            this.Controls.Add(this.tCapacidad);
            this.Controls.Add(this.lCupoActual);
            this.Controls.Add(this.lCapacidad);
            this.Controls.Add(this.bEntrada);
            this.Controls.Add(this.bSalida);
            this.Controls.Add(this.bOcupacion);
            this.Controls.Add(this.bCerrar);
            this.Name = "fSala";
            this.Text = "Sala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Button bOcupacion;
        private System.Windows.Forms.Button bSalida;
        private System.Windows.Forms.Button bEntrada;
        private System.Windows.Forms.Label lCapacidad;
        private System.Windows.Forms.Label lCupoActual;
        private System.Windows.Forms.TextBox tCapacidad;
        private System.Windows.Forms.TextBox tCupoActual;
    }
}

