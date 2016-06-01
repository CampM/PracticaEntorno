namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.tbContraseña = new System.Windows.Forms.TextBox();
            this.lbContrseña = new System.Windows.Forms.Label();
            this.lbPista = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbContraseña
            // 
            this.tbContraseña.Location = new System.Drawing.Point(95, 97);
            this.tbContraseña.Name = "tbContraseña";
            this.tbContraseña.PasswordChar = '*';
            this.tbContraseña.Size = new System.Drawing.Size(100, 20);
            this.tbContraseña.TabIndex = 0;
            // 
            // lbContrseña
            // 
            this.lbContrseña.AutoSize = true;
            this.lbContrseña.Location = new System.Drawing.Point(83, 54);
            this.lbContrseña.Name = "lbContrseña";
            this.lbContrseña.Size = new System.Drawing.Size(124, 13);
            this.lbContrseña.TabIndex = 1;
            this.lbContrseña.Text = "Introduzca la contraseña";
            // 
            // lbPista
            // 
            this.lbPista.AutoSize = true;
            this.lbPista.Location = new System.Drawing.Point(35, 193);
            this.lbPista.Name = "lbPista";
            this.lbPista.Size = new System.Drawing.Size(224, 13);
            this.lbPista.TabIndex = 2;
            this.lbPista.Text = "La contraseña secreta no tan secreta es: daw";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(108, 144);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 277);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lbPista);
            this.Controls.Add(this.lbContrseña);
            this.Controls.Add(this.tbContraseña);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbContraseña;
        private System.Windows.Forms.Label lbContrseña;
        private System.Windows.Forms.Label lbPista;
        private System.Windows.Forms.Button btnAceptar;
    }
}

