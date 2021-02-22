namespace crud
{
    partial class NuevoCliente
    {
        private System.ComponentModel.IContainer components = null;

        
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

        private void InitializeComponent()
        {
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btguardar = new System.Windows.Forms.Button();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtgenero = new System.Windows.Forms.TextBox();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnatras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(194, 162);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 47;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btguardar
            // 
            this.btguardar.Location = new System.Drawing.Point(79, 162);
            this.btguardar.Name = "btguardar";
            this.btguardar.Size = new System.Drawing.Size(75, 23);
            this.btguardar.TabIndex = 46;
            this.btguardar.Text = "Guardar";
            this.btguardar.UseVisualStyleBackColor = true;
            this.btguardar.Click += new System.EventHandler(this.btguardar_Click_1);
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(142, 110);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 45;
            // 
            // txtgenero
            // 
            this.txtgenero.Location = new System.Drawing.Point(142, 84);
            this.txtgenero.Name = "txtgenero";
            this.txtgenero.Size = new System.Drawing.Size(100, 20);
            this.txtgenero.TabIndex = 44;
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(142, 58);
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(100, 20);
            this.txtapellidos.TabIndex = 43;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(142, 32);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(100, 20);
            this.txtnombres.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(65, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "EDAD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "GENERO:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(65, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 38;
            this.label8.Text = "APELLIDOS:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(65, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "NOMBRES:";
            // 
            // btnatras
            // 
            this.btnatras.Location = new System.Drawing.Point(133, 209);
            this.btnatras.Name = "btnatras";
            this.btnatras.Size = new System.Drawing.Size(75, 23);
            this.btnatras.TabIndex = 48;
            this.btnatras.Text = "Atras";
            this.btnatras.UseVisualStyleBackColor = true;
            this.btnatras.Click += new System.EventHandler(this.btnatras_Click);
            // 
            // NuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 261);
            this.Controls.Add(this.btnatras);
            this.Controls.Add(this.btguardar);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtgenero);
            this.Controls.Add(this.txtapellidos);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnlimpiar);
            this.Name = "NuevoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.NuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btguardar;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtgenero;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnatras;
    }
}