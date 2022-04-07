namespace TAPU2_Ejemplo11
{
    partial class frmEjecucion
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
            this.btnCrearControl = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnCrearCajas = new System.Windows.Forms.Button();
            this.tbCantidad = new System.Windows.Forms.TrackBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCrearControl
            // 
            this.btnCrearControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearControl.Location = new System.Drawing.Point(12, 26);
            this.btnCrearControl.Name = "btnCrearControl";
            this.btnCrearControl.Size = new System.Drawing.Size(143, 54);
            this.btnCrearControl.TabIndex = 0;
            this.btnCrearControl.Text = "Crear control";
            this.btnCrearControl.UseVisualStyleBackColor = true;
            this.btnCrearControl.Click += new System.EventHandler(this.btnCrearControl_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCrearCajas
            // 
            this.btnCrearCajas.Location = new System.Drawing.Point(15, 283);
            this.btnCrearCajas.Name = "btnCrearCajas";
            this.btnCrearCajas.Size = new System.Drawing.Size(140, 64);
            this.btnCrearCajas.TabIndex = 2;
            this.btnCrearCajas.Text = "Crear cajas";
            this.btnCrearCajas.UseVisualStyleBackColor = true;
            this.btnCrearCajas.Click += new System.EventHandler(this.btnCrearCajas_Click);
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(15, 365);
            this.tbCantidad.Maximum = 15;
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(137, 45);
            this.tbCantidad.TabIndex = 3;
            this.tbCantidad.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbCantidad.Scroll += new System.EventHandler(this.tbCantidad_Scroll);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Copperplate Gothic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(159, 378);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 13);
            this.lblCantidad.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(317, 321);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 140);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmEjecucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(549, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.btnCrearCajas);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCrearControl);
            this.Name = "frmEjecucion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejecucion";
            this.Load += new System.EventHandler(this.frmEjecucion_Load);
            this.DoubleClick += new System.EventHandler(this.frmEjecucion_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.tbCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearControl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCrearCajas;
        private System.Windows.Forms.TrackBar tbCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

