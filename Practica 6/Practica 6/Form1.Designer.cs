namespace Practica_6
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
            this.LabelNumeroDiscos = new System.Windows.Forms.Label();
            this.TextBoxNumeroDiscos = new System.Windows.Forms.TextBox();
            this.BotonResolver = new System.Windows.Forms.Button();
            this.TextBoxResultado = new System.Windows.Forms.TextBox();
            this.InstruccionResultado = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Black;
            this.Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.ForeColor = System.Drawing.Color.White;
            this.Titulo.Location = new System.Drawing.Point(291, 22);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(161, 29);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "PRACTICA 6";
            this.Titulo.Click += new System.EventHandler(this.Titulo_Click);
            // 
            // LabelNumeroDiscos
            // 
            this.LabelNumeroDiscos.AutoSize = true;
            this.LabelNumeroDiscos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNumeroDiscos.ForeColor = System.Drawing.Color.White;
            this.LabelNumeroDiscos.Location = new System.Drawing.Point(276, 43);
            this.LabelNumeroDiscos.Name = "LabelNumeroDiscos";
            this.LabelNumeroDiscos.Size = new System.Drawing.Size(175, 25);
            this.LabelNumeroDiscos.TabIndex = 1;
            this.LabelNumeroDiscos.Text = "Número de discos:";
            this.LabelNumeroDiscos.Click += new System.EventHandler(this.LabelNumeroDiscos_Click);
            // 
            // TextBoxNumeroDiscos
            // 
            this.TextBoxNumeroDiscos.Location = new System.Drawing.Point(272, 81);
            this.TextBoxNumeroDiscos.Name = "TextBoxNumeroDiscos";
            this.TextBoxNumeroDiscos.Size = new System.Drawing.Size(178, 22);
            this.TextBoxNumeroDiscos.TabIndex = 2;
            this.TextBoxNumeroDiscos.TextChanged += new System.EventHandler(this.TextBoxNumeroDiscos_TextChanged);
            // 
            // BotonResolver
            // 
            this.BotonResolver.BackColor = System.Drawing.Color.Lime;
            this.BotonResolver.ForeColor = System.Drawing.Color.Black;
            this.BotonResolver.Location = new System.Drawing.Point(318, 109);
            this.BotonResolver.Name = "BotonResolver";
            this.BotonResolver.Size = new System.Drawing.Size(97, 40);
            this.BotonResolver.TabIndex = 3;
            this.BotonResolver.Text = "Resolver";
            this.BotonResolver.UseVisualStyleBackColor = false;
            this.BotonResolver.Click += new System.EventHandler(this.BotonResolver_Click);
            // 
            // TextBoxResultado
            // 
            this.TextBoxResultado.Location = new System.Drawing.Point(281, 202);
            this.TextBoxResultado.Multiline = true;
            this.TextBoxResultado.Name = "TextBoxResultado";
            this.TextBoxResultado.ReadOnly = true;
            this.TextBoxResultado.Size = new System.Drawing.Size(181, 199);
            this.TextBoxResultado.TabIndex = 4;
            this.TextBoxResultado.TextChanged += new System.EventHandler(this.TextBoxResultado_TextChanged);
            // 
            // InstruccionResultado
            // 
            this.InstruccionResultado.AutoSize = true;
            this.InstruccionResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstruccionResultado.ForeColor = System.Drawing.Color.White;
            this.InstruccionResultado.Location = new System.Drawing.Point(313, 165);
            this.InstruccionResultado.Name = "InstruccionResultado";
            this.InstruccionResultado.Size = new System.Drawing.Size(105, 25);
            this.InstruccionResultado.TabIndex = 5;
            this.InstruccionResultado.Text = "Resultado:";
            this.InstruccionResultado.Click += new System.EventHandler(this.InstruccionResultado_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.InstruccionResultado);
            this.panel1.Controls.Add(this.TextBoxResultado);
            this.panel1.Controls.Add(this.BotonResolver);
            this.panel1.Controls.Add(this.TextBoxNumeroDiscos);
            this.panel1.Controls.Add(this.LabelNumeroDiscos);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 422);
            this.panel1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Titulo);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label LabelNumeroDiscos;
        private System.Windows.Forms.TextBox TextBoxNumeroDiscos;
        private System.Windows.Forms.Button BotonResolver;
        private System.Windows.Forms.TextBox TextBoxResultado;
        private System.Windows.Forms.Label InstruccionResultado;
        private System.Windows.Forms.Panel panel1;
    }
}

