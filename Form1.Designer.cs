namespace Datagridview_C_
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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lbBajoPeso = new System.Windows.Forms.Label();
            this.lbObesidad = new System.Windows.Forms.Label();
            this.lbSobrepeso = new System.Windows.Forms.Label();
            this.lbPesoNormal = new System.Windows.Forms.Label();
            this.btCalcular = new System.Windows.Forms.Button();
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btGenerar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lbBajoPeso);
            this.GroupBox1.Controls.Add(this.lbObesidad);
            this.GroupBox1.Controls.Add(this.lbSobrepeso);
            this.GroupBox1.Controls.Add(this.lbPesoNormal);
            this.GroupBox1.Location = new System.Drawing.Point(66, 479);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(607, 186);
            this.GroupBox1.TabIndex = 13;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Totales";
            // 
            // lbBajoPeso
            // 
            this.lbBajoPeso.AutoSize = true;
            this.lbBajoPeso.Location = new System.Drawing.Point(261, 64);
            this.lbBajoPeso.Name = "lbBajoPeso";
            this.lbBajoPeso.Size = new System.Drawing.Size(0, 25);
            this.lbBajoPeso.TabIndex = 3;
            // 
            // lbObesidad
            // 
            this.lbObesidad.AutoSize = true;
            this.lbObesidad.Location = new System.Drawing.Point(28, 145);
            this.lbObesidad.Name = "lbObesidad";
            this.lbObesidad.Size = new System.Drawing.Size(0, 25);
            this.lbObesidad.TabIndex = 2;
            // 
            // lbSobrepeso
            // 
            this.lbSobrepeso.AutoSize = true;
            this.lbSobrepeso.Location = new System.Drawing.Point(28, 82);
            this.lbSobrepeso.Name = "lbSobrepeso";
            this.lbSobrepeso.Size = new System.Drawing.Size(0, 25);
            this.lbSobrepeso.TabIndex = 1;
            // 
            // lbPesoNormal
            // 
            this.lbPesoNormal.AutoSize = true;
            this.lbPesoNormal.Location = new System.Drawing.Point(28, 26);
            this.lbPesoNormal.Name = "lbPesoNormal";
            this.lbPesoNormal.Size = new System.Drawing.Size(0, 25);
            this.lbPesoNormal.TabIndex = 0;
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(679, 543);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(162, 43);
            this.btCalcular.TabIndex = 12;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(66, 170);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.RowHeadersWidth = 51;
            this.dgvPersonas.RowTemplate.Height = 24;
            this.dgvPersonas.Size = new System.Drawing.Size(716, 286);
            this.dgvPersonas.TabIndex = 11;
            this.dgvPersonas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonas_CellContentClick);
            // 
            // btGenerar
            // 
            this.btGenerar.Location = new System.Drawing.Point(587, 99);
            this.btGenerar.Name = "btGenerar";
            this.btGenerar.Size = new System.Drawing.Size(137, 38);
            this.btGenerar.TabIndex = 10;
            this.btGenerar.Text = "Generar";
            this.btGenerar.UseVisualStyleBackColor = true;
            this.btGenerar.Click += new System.EventHandler(this.btGenerar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(315, 101);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(144, 30);
            this.txtCantidad.TabIndex = 9;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(61, 99);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(209, 25);
            this.Label2.TabIndex = 8;
            this.Label2.Text = "Cantidad de Pacientes";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(292, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(199, 25);
            this.Label1.TabIndex = 7;
            this.Label1.Text = "Registro de pacientes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 690);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btCalcular);
            this.Controls.Add(this.dgvPersonas);
            this.Controls.Add(this.btGenerar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "DatagridView";
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lbObesidad;
        internal System.Windows.Forms.Label lbSobrepeso;
        internal System.Windows.Forms.Label lbPesoNormal;
        internal System.Windows.Forms.Button btCalcular;
        internal System.Windows.Forms.DataGridView dgvPersonas;
        internal System.Windows.Forms.Button btGenerar;
        internal System.Windows.Forms.TextBox txtCantidad;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label lbBajoPeso;
    }
}

