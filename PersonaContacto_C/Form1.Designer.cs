namespace PersonaContacto_C
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
            this.BTNlimpiar = new System.Windows.Forms.Button();
            this.BTNmostrar = new System.Windows.Forms.Button();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.TXTcorreoe = new System.Windows.Forms.TextBox();
            this.TXTtelef = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.DTPfn = new System.Windows.Forms.DateTimePicker();
            this.TXTapp = new System.Windows.Forms.TextBox();
            this.TXTapm = new System.Windows.Forms.TextBox();
            this.TXTnombre = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNlimpiar
            // 
            this.BTNlimpiar.Location = new System.Drawing.Point(25, 201);
            this.BTNlimpiar.Name = "BTNlimpiar";
            this.BTNlimpiar.Size = new System.Drawing.Size(75, 23);
            this.BTNlimpiar.TabIndex = 32;
            this.BTNlimpiar.Text = "Limpiar";
            this.BTNlimpiar.UseVisualStyleBackColor = true;
            // 
            // BTNmostrar
            // 
            this.BTNmostrar.Location = new System.Drawing.Point(528, 201);
            this.BTNmostrar.Name = "BTNmostrar";
            this.BTNmostrar.Size = new System.Drawing.Size(75, 23);
            this.BTNmostrar.TabIndex = 31;
            this.BTNmostrar.Text = "Mostrar";
            this.BTNmostrar.UseVisualStyleBackColor = true;
            this.BTNmostrar.Click += new System.EventHandler(this.BTNmostrar_Click);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(328, 162);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(94, 13);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "Correo Electrónico";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(328, 126);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(49, 13);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Telefono";
            // 
            // TXTcorreoe
            // 
            this.TXTcorreoe.Location = new System.Drawing.Point(442, 162);
            this.TXTcorreoe.Name = "TXTcorreoe";
            this.TXTcorreoe.Size = new System.Drawing.Size(161, 20);
            this.TXTcorreoe.TabIndex = 28;
            // 
            // TXTtelef
            // 
            this.TXTtelef.Location = new System.Drawing.Point(442, 126);
            this.TXTtelef.Name = "TXTtelef";
            this.TXTtelef.Size = new System.Drawing.Size(161, 20);
            this.TXTtelef.TabIndex = 27;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(328, 89);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(108, 13);
            this.Label6.TabIndex = 26;
            this.Label6.Text = "Fecha de Nacimiento";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(22, 165);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(86, 13);
            this.Label5.TabIndex = 25;
            this.Label5.Text = "Apellido Materno";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(22, 126);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(84, 13);
            this.Label4.TabIndex = 24;
            this.Label4.Text = "Apellido Paterno";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(22, 90);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(44, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Nombre";
            // 
            // DTPfn
            // 
            this.DTPfn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTPfn.Location = new System.Drawing.Point(442, 83);
            this.DTPfn.Name = "DTPfn";
            this.DTPfn.Size = new System.Drawing.Size(100, 20);
            this.DTPfn.TabIndex = 22;
            // 
            // TXTapp
            // 
            this.TXTapp.Location = new System.Drawing.Point(136, 126);
            this.TXTapp.Name = "TXTapp";
            this.TXTapp.Size = new System.Drawing.Size(163, 20);
            this.TXTapp.TabIndex = 21;
            // 
            // TXTapm
            // 
            this.TXTapm.Location = new System.Drawing.Point(136, 162);
            this.TXTapm.Name = "TXTapm";
            this.TXTapm.Size = new System.Drawing.Size(163, 20);
            this.TXTapm.TabIndex = 20;
            // 
            // TXTnombre
            // 
            this.TXTnombre.Location = new System.Drawing.Point(136, 90);
            this.TXTnombre.Name = "TXTnombre";
            this.TXTnombre.Size = new System.Drawing.Size(163, 20);
            this.TXTnombre.TabIndex = 19;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(209, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(227, 35);
            this.Label1.TabIndex = 18;
            this.Label1.Text = "Datos de Usuario";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(616, 229);
            this.Controls.Add(this.BTNlimpiar);
            this.Controls.Add(this.BTNmostrar);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.TXTcorreoe);
            this.Controls.Add(this.TXTtelef);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.DTPfn);
            this.Controls.Add(this.TXTapp);
            this.Controls.Add(this.TXTapm);
            this.Controls.Add(this.TXTnombre);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button BTNlimpiar;
        internal System.Windows.Forms.Button BTNmostrar;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.TextBox TXTcorreoe;
        internal System.Windows.Forms.TextBox TXTtelef;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.DateTimePicker DTPfn;
        internal System.Windows.Forms.TextBox TXTapp;
        internal System.Windows.Forms.TextBox TXTapm;
        internal System.Windows.Forms.TextBox TXTnombre;
        internal System.Windows.Forms.Label Label1;
    }
}

