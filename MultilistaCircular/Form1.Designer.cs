namespace MultilistaCircular
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Antecesor = new System.Windows.Forms.Button();
            this.Sucesor = new System.Windows.Forms.Button();
            this.textNombreBrigada = new System.Windows.Forms.TextBox();
            this.textIDBrigada = new System.Windows.Forms.TextBox();
            this.numBrigada = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.InsertarBrigadas = new System.Windows.Forms.Button();
            this.InsertarTrabajadores = new System.Windows.Forms.Button();
            this.oficioTrab = new System.Windows.Forms.TextBox();
            this.nombreTrab = new System.Windows.Forms.TextBox();
            this.textIDTrabajador = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ultimo = new System.Windows.Forms.Button();
            this.Primero = new System.Windows.Forms.Button();
            this.viewLabel = new System.Windows.Forms.Label();
            this.eliminarBrigada = new System.Windows.Forms.Button();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eliminarTrabajador = new System.Windows.Forms.Button();
            this.numeroDeBrigadas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Limpiar
            // 
            this.Limpiar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Limpiar.Location = new System.Drawing.Point(555, 69);
            this.Limpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(95, 30);
            this.Limpiar.TabIndex = 50;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = false;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Antecesor
            // 
            this.Antecesor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Antecesor.Location = new System.Drawing.Point(665, 314);
            this.Antecesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Antecesor.Name = "Antecesor";
            this.Antecesor.Size = new System.Drawing.Size(95, 30);
            this.Antecesor.TabIndex = 49;
            this.Antecesor.Text = "Antecesor";
            this.Antecesor.UseVisualStyleBackColor = false;
            this.Antecesor.Click += new System.EventHandler(this.Antecesor_Click);
            // 
            // Sucesor
            // 
            this.Sucesor.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Sucesor.Location = new System.Drawing.Point(665, 277);
            this.Sucesor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sucesor.Name = "Sucesor";
            this.Sucesor.Size = new System.Drawing.Size(95, 30);
            this.Sucesor.TabIndex = 48;
            this.Sucesor.Text = "Sucesor";
            this.Sucesor.UseVisualStyleBackColor = false;
            this.Sucesor.Click += new System.EventHandler(this.Sucesor_Click);
            // 
            // textNombreBrigada
            // 
            this.textNombreBrigada.BackColor = System.Drawing.Color.Snow;
            this.textNombreBrigada.Location = new System.Drawing.Point(387, 111);
            this.textNombreBrigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textNombreBrigada.Name = "textNombreBrigada";
            this.textNombreBrigada.Size = new System.Drawing.Size(100, 22);
            this.textNombreBrigada.TabIndex = 47;
            // 
            // textIDBrigada
            // 
            this.textIDBrigada.BackColor = System.Drawing.Color.Snow;
            this.textIDBrigada.Location = new System.Drawing.Point(387, 73);
            this.textIDBrigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIDBrigada.Name = "textIDBrigada";
            this.textIDBrigada.Size = new System.Drawing.Size(100, 22);
            this.textIDBrigada.TabIndex = 46;
            // 
            // numBrigada
            // 
            this.numBrigada.BackColor = System.Drawing.Color.Snow;
            this.numBrigada.Location = new System.Drawing.Point(387, 37);
            this.numBrigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numBrigada.Name = "numBrigada";
            this.numBrigada.Size = new System.Drawing.Size(100, 22);
            this.numBrigada.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label4.Location = new System.Drawing.Point(284, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label5.Location = new System.Drawing.Point(284, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.TabIndex = 43;
            this.label5.Text = "ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label6.Location = new System.Drawing.Point(284, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 42;
            this.label6.Text = "N_Brigada";
            // 
            // InsertarBrigadas
            // 
            this.InsertarBrigadas.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InsertarBrigadas.Location = new System.Drawing.Point(509, 37);
            this.InsertarBrigadas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertarBrigadas.Name = "InsertarBrigadas";
            this.InsertarBrigadas.Size = new System.Drawing.Size(95, 30);
            this.InsertarBrigadas.TabIndex = 41;
            this.InsertarBrigadas.Text = "Insertar";
            this.InsertarBrigadas.UseVisualStyleBackColor = false;
            this.InsertarBrigadas.Click += new System.EventHandler(this.InsertarBrigadas_Click);
            // 
            // InsertarTrabajadores
            // 
            this.InsertarTrabajadores.BackColor = System.Drawing.Color.PaleTurquoise;
            this.InsertarTrabajadores.Location = new System.Drawing.Point(147, 394);
            this.InsertarTrabajadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertarTrabajadores.Name = "InsertarTrabajadores";
            this.InsertarTrabajadores.Size = new System.Drawing.Size(95, 30);
            this.InsertarTrabajadores.TabIndex = 39;
            this.InsertarTrabajadores.Text = "Insertar";
            this.InsertarTrabajadores.UseVisualStyleBackColor = false;
            this.InsertarTrabajadores.Click += new System.EventHandler(this.InsertarTrabajadores_Click);
            // 
            // oficioTrab
            // 
            this.oficioTrab.BackColor = System.Drawing.Color.Snow;
            this.oficioTrab.Location = new System.Drawing.Point(147, 105);
            this.oficioTrab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.oficioTrab.Name = "oficioTrab";
            this.oficioTrab.Size = new System.Drawing.Size(100, 22);
            this.oficioTrab.TabIndex = 38;
            // 
            // nombreTrab
            // 
            this.nombreTrab.BackColor = System.Drawing.Color.Snow;
            this.nombreTrab.Location = new System.Drawing.Point(147, 70);
            this.nombreTrab.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nombreTrab.Name = "nombreTrab";
            this.nombreTrab.Size = new System.Drawing.Size(100, 22);
            this.nombreTrab.TabIndex = 37;
            // 
            // textIDTrabajador
            // 
            this.textIDTrabajador.BackColor = System.Drawing.Color.Snow;
            this.textIDTrabajador.Location = new System.Drawing.Point(147, 34);
            this.textIDTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textIDTrabajador.Name = "textIDTrabajador";
            this.textIDTrabajador.Size = new System.Drawing.Size(100, 22);
            this.textIDTrabajador.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label3.Location = new System.Drawing.Point(43, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Oficio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Location = new System.Drawing.Point(43, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Identificador";
            // 
            // Ultimo
            // 
            this.Ultimo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Ultimo.Location = new System.Drawing.Point(665, 210);
            this.Ultimo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ultimo.Name = "Ultimo";
            this.Ultimo.Size = new System.Drawing.Size(95, 30);
            this.Ultimo.TabIndex = 51;
            this.Ultimo.Text = "Ultimo";
            this.Ultimo.UseVisualStyleBackColor = false;
            this.Ultimo.Click += new System.EventHandler(this.Ultimo_Click);
            // 
            // Primero
            // 
            this.Primero.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Primero.Location = new System.Drawing.Point(665, 181);
            this.Primero.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Primero.Name = "Primero";
            this.Primero.Size = new System.Drawing.Size(95, 30);
            this.Primero.TabIndex = 52;
            this.Primero.Text = "Primero";
            this.Primero.UseVisualStyleBackColor = false;
            this.Primero.Click += new System.EventHandler(this.Primero_Click);
            // 
            // viewLabel
            // 
            this.viewLabel.AutoSize = true;
            this.viewLabel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.viewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewLabel.ForeColor = System.Drawing.Color.Black;
            this.viewLabel.Location = new System.Drawing.Point(507, 117);
            this.viewLabel.Name = "viewLabel";
            this.viewLabel.Size = new System.Drawing.Size(58, 18);
            this.viewLabel.TabIndex = 53;
            this.viewLabel.Text = "Brigada";
            this.viewLabel.Click += new System.EventHandler(this.primeroLabel_Click);
            // 
            // eliminarBrigada
            // 
            this.eliminarBrigada.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eliminarBrigada.Location = new System.Drawing.Point(609, 37);
            this.eliminarBrigada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarBrigada.Name = "eliminarBrigada";
            this.eliminarBrigada.Size = new System.Drawing.Size(95, 30);
            this.eliminarBrigada.TabIndex = 54;
            this.eliminarBrigada.Text = "Eliminar";
            this.eliminarBrigada.UseVisualStyleBackColor = false;
            this.eliminarBrigada.Click += new System.EventHandler(this.eliminarBrigada_Click);
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToOrderColumns = true;
            this.DataGridView.BackgroundColor = System.Drawing.Color.MintCream;
            this.DataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.Nombre,
            this.Oficio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridView.Location = new System.Drawing.Point(25, 146);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(604, 241);
            this.DataGridView.TabIndex = 32;
            this.DataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellClick);
            this.DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView_CellContentClick);
            // 
            // Identificador
            // 
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.MinimumWidth = 6;
            this.Identificador.Name = "Identificador";
            this.Identificador.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 130;
            // 
            // Oficio
            // 
            this.Oficio.HeaderText = "Oficio";
            this.Oficio.MinimumWidth = 6;
            this.Oficio.Name = "Oficio";
            this.Oficio.Width = 130;
            // 
            // eliminarTrabajador
            // 
            this.eliminarTrabajador.BackColor = System.Drawing.Color.PaleTurquoise;
            this.eliminarTrabajador.Location = new System.Drawing.Point(325, 394);
            this.eliminarTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.eliminarTrabajador.Name = "eliminarTrabajador";
            this.eliminarTrabajador.Size = new System.Drawing.Size(95, 30);
            this.eliminarTrabajador.TabIndex = 57;
            this.eliminarTrabajador.Text = "Eliminar";
            this.eliminarTrabajador.UseVisualStyleBackColor = false;
            this.eliminarTrabajador.Click += new System.EventHandler(this.eliminarTrabajador_Click);
            // 
            // numeroDeBrigadas
            // 
            this.numeroDeBrigadas.AutoSize = true;
            this.numeroDeBrigadas.BackColor = System.Drawing.Color.DarkTurquoise;
            this.numeroDeBrigadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroDeBrigadas.ForeColor = System.Drawing.Color.Black;
            this.numeroDeBrigadas.Location = new System.Drawing.Point(459, 406);
            this.numeroDeBrigadas.Name = "numeroDeBrigadas";
            this.numeroDeBrigadas.Size = new System.Drawing.Size(164, 18);
            this.numeroDeBrigadas.TabIndex = 58;
            this.numeroDeBrigadas.Text = "Número de Brigadas:  0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numeroDeBrigadas);
            this.Controls.Add(this.eliminarTrabajador);
            this.Controls.Add(this.eliminarBrigada);
            this.Controls.Add(this.viewLabel);
            this.Controls.Add(this.Primero);
            this.Controls.Add(this.Ultimo);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Antecesor);
            this.Controls.Add(this.Sucesor);
            this.Controls.Add(this.textNombreBrigada);
            this.Controls.Add(this.textIDBrigada);
            this.Controls.Add(this.numBrigada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.InsertarBrigadas);
            this.Controls.Add(this.InsertarTrabajadores);
            this.Controls.Add(this.oficioTrab);
            this.Controls.Add(this.nombreTrab);
            this.Controls.Add(this.textIDTrabajador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Button Antecesor;
        private System.Windows.Forms.Button Sucesor;
        private System.Windows.Forms.TextBox textNombreBrigada;
        private System.Windows.Forms.TextBox textIDBrigada;
        private System.Windows.Forms.TextBox numBrigada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button InsertarBrigadas;
        private System.Windows.Forms.Button InsertarTrabajadores;
        private System.Windows.Forms.TextBox oficioTrab;
        private System.Windows.Forms.TextBox nombreTrab;
        private System.Windows.Forms.TextBox textIDTrabajador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ultimo;
        private System.Windows.Forms.Button Primero;
        private System.Windows.Forms.Label viewLabel;
        private System.Windows.Forms.Button eliminarBrigada;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button eliminarTrabajador;
        private System.Windows.Forms.Label numeroDeBrigadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oficio;
    }
}

