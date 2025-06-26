namespace Ejercicio_9
{
    partial class fmrCalcularCambio
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
            this.gbCalcular = new System.Windows.Forms.GroupBox();
            this.btnOperacion = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.txtCambioEntregar = new System.Windows.Forms.TextBox();
            this.lblCambio = new System.Windows.Forms.Label();
            this.lblDineroEntregado = new System.Windows.Forms.Label();
            this.txtDineroCliente = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.gbOpciones = new System.Windows.Forms.GroupBox();
            this.lblOpciones = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.gbCalcular.SuspendLayout();
            this.gbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbCalcular
            // 
            this.gbCalcular.Controls.Add(this.btnOperacion);
            this.gbCalcular.Controls.Add(this.lblError);
            this.gbCalcular.Controls.Add(this.txtCambioEntregar);
            this.gbCalcular.Controls.Add(this.lblCambio);
            this.gbCalcular.Controls.Add(this.lblDineroEntregado);
            this.gbCalcular.Controls.Add(this.txtDineroCliente);
            this.gbCalcular.Controls.Add(this.lblPrecio);
            this.gbCalcular.Controls.Add(this.txtPrecioProducto);
            this.gbCalcular.Controls.Add(this.lblDescripcion);
            this.gbCalcular.ForeColor = System.Drawing.SystemColors.Control;
            this.gbCalcular.Location = new System.Drawing.Point(12, 12);
            this.gbCalcular.Name = "gbCalcular";
            this.gbCalcular.Size = new System.Drawing.Size(504, 514);
            this.gbCalcular.TabIndex = 0;
            this.gbCalcular.TabStop = false;
            // 
            // btnOperacion
            // 
            this.btnOperacion.BackColor = System.Drawing.SystemColors.ControlText;
            this.btnOperacion.Location = new System.Drawing.Point(95, 273);
            this.btnOperacion.Name = "btnOperacion";
            this.btnOperacion.Size = new System.Drawing.Size(224, 35);
            this.btnOperacion.TabIndex = 8;
            this.btnOperacion.Text = "Realizar operación";
            this.btnOperacion.UseVisualStyleBackColor = false;
            this.btnOperacion.Click += new System.EventHandler(this.btnOperacion_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(15, 458);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(47, 21);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Error";
            // 
            // txtCambioEntregar
            // 
            this.txtCambioEntregar.Location = new System.Drawing.Point(19, 394);
            this.txtCambioEntregar.Name = "txtCambioEntregar";
            this.txtCambioEntregar.Size = new System.Drawing.Size(389, 28);
            this.txtCambioEntregar.TabIndex = 6;
            // 
            // lblCambio
            // 
            this.lblCambio.AutoSize = true;
            this.lblCambio.Location = new System.Drawing.Point(15, 352);
            this.lblCambio.Name = "lblCambio";
            this.lblCambio.Size = new System.Drawing.Size(191, 21);
            this.lblCambio.TabIndex = 5;
            this.lblCambio.Text = "El cambio a entregar es:";
            // 
            // lblDineroEntregado
            // 
            this.lblDineroEntregado.AutoSize = true;
            this.lblDineroEntregado.Location = new System.Drawing.Point(15, 179);
            this.lblDineroEntregado.Name = "lblDineroEntregado";
            this.lblDineroEntregado.Size = new System.Drawing.Size(329, 21);
            this.lblDineroEntregado.TabIndex = 4;
            this.lblDineroEntregado.Text = "Ingrese el dinero entregado por el cliente:";
            // 
            // txtDineroCliente
            // 
            this.txtDineroCliente.Location = new System.Drawing.Point(19, 217);
            this.txtDineroCliente.Name = "txtDineroCliente";
            this.txtDineroCliente.Size = new System.Drawing.Size(389, 28);
            this.txtDineroCliente.TabIndex = 3;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(15, 76);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(237, 21);
            this.lblPrecio.TabIndex = 2;
            this.lblPrecio.Text = "Ingrese el valor del producto: ";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(19, 113);
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(389, 28);
            this.txtPrecioProducto.TabIndex = 1;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(15, 24);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(441, 21);
            this.lblDescripcion.TabIndex = 0;
            this.lblDescripcion.Text = "Este programa calcula el cambio despues de una compra";
            // 
            // gbOpciones
            // 
            this.gbOpciones.Controls.Add(this.lblOpciones);
            this.gbOpciones.Controls.Add(this.btnSalir);
            this.gbOpciones.Controls.Add(this.btnReiniciar);
            this.gbOpciones.ForeColor = System.Drawing.SystemColors.Control;
            this.gbOpciones.Location = new System.Drawing.Point(522, 12);
            this.gbOpciones.Name = "gbOpciones";
            this.gbOpciones.Size = new System.Drawing.Size(276, 514);
            this.gbOpciones.TabIndex = 1;
            this.gbOpciones.TabStop = false;
            // 
            // lblOpciones
            // 
            this.lblOpciones.AutoSize = true;
            this.lblOpciones.Location = new System.Drawing.Point(98, 65);
            this.lblOpciones.Name = "lblOpciones";
            this.lblOpciones.Size = new System.Drawing.Size(81, 21);
            this.lblOpciones.TabIndex = 9;
            this.lblOpciones.Text = "Opciones";
            // 
            // btnSalir
            // 
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Image = global::Ejercicio_9.Properties.Resources.icons8_open_door_50;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(36, 276);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 100);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir del programa";
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReiniciar.Image = global::Ejercicio_9.Properties.Resources.icons8_intercambio_de_tarjetas_50;
            this.btnReiniciar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReiniciar.Location = new System.Drawing.Point(36, 140);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(207, 99);
            this.btnReiniciar.TabIndex = 0;
            this.btnReiniciar.Text = "Hacer otra cuenta";
            this.btnReiniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // fmrCalcularCambio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(810, 546);
            this.Controls.Add(this.gbOpciones);
            this.Controls.Add(this.gbCalcular);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "fmrCalcularCambio";
            this.Text = "Calcular el cambio segun la compra";
            this.gbCalcular.ResumeLayout(false);
            this.gbCalcular.PerformLayout();
            this.gbOpciones.ResumeLayout(false);
            this.gbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCalcular;
        private System.Windows.Forms.Label lblDineroEntregado;
        private System.Windows.Forms.TextBox txtDineroCliente;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.GroupBox gbOpciones;
        private System.Windows.Forms.Label lblCambio;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtCambioEntregar;
        private System.Windows.Forms.Button btnOperacion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblOpciones;
    }
}

