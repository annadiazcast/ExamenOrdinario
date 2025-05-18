namespace ExamenOrdinario
{
    partial class Inicio
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
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnImportar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewId = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(13, 15);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersWidth = 51;
            this.dgDatos.RowTemplate.Height = 24;
            this.dgDatos.Size = new System.Drawing.Size(1095, 259);
            this.dgDatos.TabIndex = 0;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(476, 308);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(109, 23);
            this.btnMostrar.TabIndex = 1;
            this.btnMostrar.Text = "MOSTRAR";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(637, 308);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(109, 23);
            this.btnExportar.TabIndex = 2;
            this.btnExportar.Text = "EXPORTAR";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(309, 308);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(109, 23);
            this.btnImportar.TabIndex = 3;
            this.btnImportar.Text = "IMPORTAR";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(49, 377);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(122, 22);
            this.txtId.TabIndex = 5;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(72, 414);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 342);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID";
            // 
            // txtNewId
            // 
            this.txtNewId.Location = new System.Drawing.Point(901, 361);
            this.txtNewId.Name = "txtNewId";
            this.txtNewId.Size = new System.Drawing.Size(122, 22);
            this.txtNewId.TabIndex = 8;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(901, 414);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(122, 22);
            this.txtMarca.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(934, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "MARCA";
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(901, 463);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(122, 22);
            this.txtModelo.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(930, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "MODELO";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(901, 513);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(122, 22);
            this.txtAnio.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(946, 494);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "AÑO";
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(901, 568);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(122, 22);
            this.txtColor.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(934, 549);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "COLOR";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(901, 623);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(122, 22);
            this.txtPrecio.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(934, 604);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "PRECIO";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(901, 677);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(122, 22);
            this.txtEstado.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(931, 658);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "ESTADO";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(849, 720);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 21;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(977, 720);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(115, 23);
            this.btnActualizar.TabIndex = 22;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 766);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtModelo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNewId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.dgDatos);
            this.Name = "Inicio";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNewId;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnActualizar;
    }
}