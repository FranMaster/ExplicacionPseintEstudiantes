namespace EJEMPLO
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
            this.TxtDni = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnIngresar = new System.Windows.Forms.Button();
            this.ListaAlumnosVisual = new System.Windows.Forms.DataGridView();
            this.BtnEliminarPrimero = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnEjecutar = new System.Windows.Forms.Button();
            this.BtnEliminarUnico = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosVisual)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtDni
            // 
            this.TxtDni.Location = new System.Drawing.Point(81, 99);
            this.TxtDni.Name = "TxtDni";
            this.TxtDni.Size = new System.Drawing.Size(234, 26);
            this.TxtDni.TabIndex = 0;
            this.TxtDni.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(81, 131);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(234, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtApellido
            // 
            this.TxtApellido.Location = new System.Drawing.Point(81, 163);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(234, 26);
            this.TxtApellido.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Apellido:";
            // 
            // BtnIngresar
            // 
            this.BtnIngresar.Location = new System.Drawing.Point(11, 211);
            this.BtnIngresar.Name = "BtnIngresar";
            this.BtnIngresar.Size = new System.Drawing.Size(304, 37);
            this.BtnIngresar.TabIndex = 6;
            this.BtnIngresar.Text = "Ingresar";
            this.BtnIngresar.UseVisualStyleBackColor = true;
            this.BtnIngresar.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // ListaAlumnosVisual
            // 
            this.ListaAlumnosVisual.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListaAlumnosVisual.Location = new System.Drawing.Point(334, 12);
            this.ListaAlumnosVisual.Name = "ListaAlumnosVisual";
            this.ListaAlumnosVisual.RowHeadersWidth = 62;
            this.ListaAlumnosVisual.RowTemplate.Height = 28;
            this.ListaAlumnosVisual.Size = new System.Drawing.Size(603, 360);
            this.ListaAlumnosVisual.TabIndex = 7;
            // 
            // BtnEliminarPrimero
            // 
            this.BtnEliminarPrimero.Location = new System.Drawing.Point(11, 254);
            this.BtnEliminarPrimero.Name = "BtnEliminarPrimero";
            this.BtnEliminarPrimero.Size = new System.Drawing.Size(304, 37);
            this.BtnEliminarPrimero.TabIndex = 8;
            this.BtnEliminarPrimero.Text = "Eliminar Primero";
            this.BtnEliminarPrimero.UseVisualStyleBackColor = true;
            this.BtnEliminarPrimero.Click += new System.EventHandler(this.BtnEliminarPrimero_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(11, 297);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(304, 37);
            this.BtnEliminar.TabIndex = 9;
            this.BtnEliminar.Text = "Eliminar Ultimo";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Search:";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(78, 13);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(234, 26);
            this.TxtSearch.TabIndex = 11;
            // 
            // BtnEjecutar
            // 
            this.BtnEjecutar.Location = new System.Drawing.Point(17, 45);
            this.BtnEjecutar.Name = "BtnEjecutar";
            this.BtnEjecutar.Size = new System.Drawing.Size(298, 35);
            this.BtnEjecutar.TabIndex = 12;
            this.BtnEjecutar.Text = "Buscar";
            this.BtnEjecutar.UseVisualStyleBackColor = true;
            this.BtnEjecutar.Click += new System.EventHandler(this.BtnEjecutar_Click);
            // 
            // BtnEliminarUnico
            // 
            this.BtnEliminarUnico.Location = new System.Drawing.Point(11, 340);
            this.BtnEliminarUnico.Name = "BtnEliminarUnico";
            this.BtnEliminarUnico.Size = new System.Drawing.Size(304, 37);
            this.BtnEliminarUnico.TabIndex = 13;
            this.BtnEliminarUnico.Text = "Eliminar Unico";
            this.BtnEliminarUnico.UseVisualStyleBackColor = true;
            this.BtnEliminarUnico.Click += new System.EventHandler(this.BtnEliminarUnico_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 398);
            this.Controls.Add(this.BtnEliminarUnico);
            this.Controls.Add(this.BtnEjecutar);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnEliminarPrimero);
            this.Controls.Add(this.ListaAlumnosVisual);
            this.Controls.Add(this.BtnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtDni);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ListaAlumnosVisual)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDni;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnIngresar;
        private System.Windows.Forms.DataGridView ListaAlumnosVisual;
        private System.Windows.Forms.Button BtnEliminarPrimero;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnEjecutar;
        private System.Windows.Forms.Button BtnEliminarUnico;
    }
}

