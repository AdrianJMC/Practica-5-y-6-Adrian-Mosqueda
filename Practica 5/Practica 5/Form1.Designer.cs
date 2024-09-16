namespace Practica_5
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
            this.Titulo = new System.Windows.Forms.Label();
            this.Instruccion = new System.Windows.Forms.Label();
            this.PonerCantidad = new System.Windows.Forms.TextBox();
            this.BotonObtener = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.PagarCon = new System.Windows.Forms.Label();
            this.Pago = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(307, 18);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(150, 32);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Practica 5";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // Instruccion
            // 
            this.Instruccion.AutoSize = true;
            this.Instruccion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Instruccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Instruccion.ForeColor = System.Drawing.Color.White;
            this.Instruccion.Location = new System.Drawing.Point(265, 61);
            this.Instruccion.Name = "Instruccion";
            this.Instruccion.Size = new System.Drawing.Size(241, 29);
            this.Instruccion.TabIndex = 1;
            this.Instruccion.Text = "Ingresa una cantidad:";
            this.Instruccion.Click += new System.EventHandler(this.label2_Click);
            // 
            // PonerCantidad
            // 
            this.PonerCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.PonerCantidad.Location = new System.Drawing.Point(295, 100);
            this.PonerCantidad.Name = "PonerCantidad";
            this.PonerCantidad.Size = new System.Drawing.Size(189, 22);
            this.PonerCantidad.TabIndex = 2;
            this.PonerCantidad.Text = "Cantidad";
            this.PonerCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PonerCantidad.TextChanged += new System.EventHandler(this.PonerCantidad_TextChanged);
            // 
            // BotonObtener
            // 
            this.BotonObtener.BackColor = System.Drawing.Color.Lime;
            this.BotonObtener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotonObtener.Location = new System.Drawing.Point(332, 212);
            this.BotonObtener.Name = "BotonObtener";
            this.BotonObtener.Size = new System.Drawing.Size(111, 40);
            this.BotonObtener.TabIndex = 3;
            this.BotonObtener.Text = "Obtener";
            this.BotonObtener.UseVisualStyleBackColor = false;
            this.BotonObtener.Click += new System.EventHandler(this.BotonObtener_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.ForeColor = System.Drawing.Color.White;
            this.Resultado.Location = new System.Drawing.Point(284, 268);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(99, 20);
            this.Resultado.TabIndex = 5;
            this.Resultado.Text = "Resultado:";
            this.Resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Resultado.Click += new System.EventHandler(this.Resultado_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(776, 429);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // PagarCon
            // 
            this.PagarCon.AutoSize = true;
            this.PagarCon.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PagarCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PagarCon.ForeColor = System.Drawing.Color.White;
            this.PagarCon.Location = new System.Drawing.Point(221, 137);
            this.PagarCon.Name = "PagarCon";
            this.PagarCon.Size = new System.Drawing.Size(342, 29);
            this.PagarCon.TabIndex = 7;
            this.PagarCon.Text = "Ingresar con cuanto se pagara:";
            this.PagarCon.Click += new System.EventHandler(this.PagarCon_Click);
            // 
            // Pago
            // 
            this.Pago.ForeColor = System.Drawing.Color.DimGray;
            this.Pago.Location = new System.Drawing.Point(296, 176);
            this.Pago.Name = "Pago";
            this.Pago.Size = new System.Drawing.Size(189, 22);
            this.Pago.TabIndex = 8;
            this.Pago.Text = "Pago";
            this.Pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pago.TextChanged += new System.EventHandler(this.Pago_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pago);
            this.Controls.Add(this.PagarCon);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.BotonObtener);
            this.Controls.Add(this.PonerCantidad);
            this.Controls.Add(this.Instruccion);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label Instruccion;
        private System.Windows.Forms.TextBox PonerCantidad;
        private System.Windows.Forms.Button BotonObtener;
        private System.Windows.Forms.Label Resultado;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label PagarCon;
        private System.Windows.Forms.TextBox Pago;
    }
}

