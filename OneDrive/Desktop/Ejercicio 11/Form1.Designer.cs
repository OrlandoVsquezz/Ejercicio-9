namespace Ejercicio_11
{
    partial class fmrDescuento
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
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gbResultados = new System.Windows.Forms.GroupBox();
            this.pnlImagen = new System.Windows.Forms.Panel();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnRealizarOtro = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConDesceunto = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbDatos.SuspendLayout();
            this.gbResultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnSalir);
            this.gbDatos.Controls.Add(this.btnRealizarOtro);
            this.gbDatos.Controls.Add(this.btnCalcular);
            this.gbDatos.Controls.Add(this.lblError);
            this.gbDatos.Controls.Add(this.txtPrecio);
            this.gbDatos.Controls.Add(this.lblDescuento);
            this.gbDatos.Controls.Add(this.lblDescripcion);
            this.gbDatos.Location = new System.Drawing.Point(12, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(792, 272);
            this.gbDatos.TabIndex = 0;
            this.gbDatos.TabStop = false;
            // 
            // gbResultados
            // 
            this.gbResultados.Controls.Add(this.txtConDesceunto);
            this.gbResultados.Controls.Add(this.label5);
            this.gbResultados.Controls.Add(this.lblResultado);
            this.gbResultados.Location = new System.Drawing.Point(12, 290);
            this.gbResultados.Name = "gbResultados";
            this.gbResultados.Size = new System.Drawing.Size(543, 241);
            this.gbResultados.TabIndex = 1;
            this.gbResultados.TabStop = false;
            // 
            // pnlImagen
            // 
            this.pnlImagen.BackgroundImage = global::Ejercicio_11.Properties.Resources.stonks;
            this.pnlImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlImagen.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnlImagen.Location = new System.Drawing.Point(561, 290);
            this.pnlImagen.Name = "pnlImagen";
            this.pnlImagen.Size = new System.Drawing.Size(243, 241);
            this.pnlImagen.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 28);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(457, 23);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Este programa calcula un producto con descuento";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(15, 91);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(289, 23);
            this.lblDescuento.TabIndex = 1;
            this.lblDescuento.Text = "Ingresa el precio sin descuento:";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(19, 137);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(427, 32);
            this.txtPrecio.TabIndex = 2;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 208);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(56, 23);
            this.lblError.TabIndex = 3;
            this.lblError.Text = "Error";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCalcular.Location = new System.Drawing.Point(513, 43);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(246, 55);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnRealizarOtro
            // 
            this.btnRealizarOtro.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRealizarOtro.Location = new System.Drawing.Point(513, 114);
            this.btnRealizarOtro.Name = "btnRealizarOtro";
            this.btnRealizarOtro.Size = new System.Drawing.Size(246, 55);
            this.btnRealizarOtro.TabIndex = 5;
            this.btnRealizarOtro.Text = "Realizar otro calculo";
            this.btnRealizarOtro.UseVisualStyleBackColor = false;
            this.btnRealizarOtro.Click += new System.EventHandler(this.btnRealizarOtro_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(15, 28);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(98, 23);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(370, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "El precio del producto con descuento es:";
            // 
            // txtConDesceunto
            // 
            this.txtConDesceunto.Location = new System.Drawing.Point(19, 159);
            this.txtConDesceunto.Name = "txtConDesceunto";
            this.txtConDesceunto.ReadOnly = true;
            this.txtConDesceunto.Size = new System.Drawing.Size(427, 32);
            this.txtConDesceunto.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(513, 192);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(246, 55);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // fmrDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(816, 543);
            this.Controls.Add(this.pnlImagen);
            this.Controls.Add(this.gbResultados);
            this.Controls.Add(this.gbDatos);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "fmrDescuento";
            this.Text = "Calcular descuento de un producto";
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbResultados.ResumeLayout(false);
            this.gbResultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Button btnRealizarOtro;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbResultados;
        private System.Windows.Forms.TextBox txtConDesceunto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Panel pnlImagen;
        private System.Windows.Forms.Button btnSalir;
    }
}

