namespace WindowsFormsApplication1
{
    partial class Principal
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
            this.components = new System.ComponentModel.Container();
            this.gbGrados = new System.Windows.Forms.GroupBox();
            this.rbFahrenheit = new System.Windows.Forms.RadioButton();
            this.rbCentigrados = new System.Windows.Forms.RadioButton();
            this.gbModos = new System.Windows.Forms.GroupBox();
            this.gbNonStop = new System.Windows.Forms.GroupBox();
            this.rbApagarNS = new System.Windows.Forms.RadioButton();
            this.rbEncenderNS = new System.Windows.Forms.RadioButton();
            this.rbVacaciones = new System.Windows.Forms.RadioButton();
            this.rbCongelador = new System.Windows.Forms.RadioButton();
            this.rbFrigorifico = new System.Windows.Forms.RadioButton();
            this.gbSensores = new System.Windows.Forms.GroupBox();
            this.tbPiloto = new System.Windows.Forms.TextBox();
            this.tbVtm = new System.Windows.Forms.TextBox();
            this.tbVtc = new System.Windows.Forms.TextBox();
            this.tbVta = new System.Windows.Forms.TextBox();
            this.lbPiloto = new System.Windows.Forms.Label();
            this.lbTempControl = new System.Windows.Forms.Label();
            this.lbSimulacion = new System.Windows.Forms.Label();
            this.lbTempAmbiente = new System.Windows.Forms.Label();
            this.gbTemperatura = new System.Windows.Forms.GroupBox();
            this.btnReducirT = new System.Windows.Forms.Button();
            this.btnAumentarT = new System.Windows.Forms.Button();
            this.btnPausaM = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdEncenderC = new System.Windows.Forms.RadioButton();
            this.rdApagarC = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerPausa = new System.Windows.Forms.Timer(this.components);
            this.gbGrados.SuspendLayout();
            this.gbModos.SuspendLayout();
            this.gbNonStop.SuspendLayout();
            this.gbSensores.SuspendLayout();
            this.gbTemperatura.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrados
            // 
            this.gbGrados.Controls.Add(this.rbFahrenheit);
            this.gbGrados.Controls.Add(this.rbCentigrados);
            this.gbGrados.Location = new System.Drawing.Point(324, 6);
            this.gbGrados.Name = "gbGrados";
            this.gbGrados.Size = new System.Drawing.Size(96, 82);
            this.gbGrados.TabIndex = 1;
            this.gbGrados.TabStop = false;
            this.gbGrados.Text = "Grados";
            // 
            // rbFahrenheit
            // 
            this.rbFahrenheit.AutoSize = true;
            this.rbFahrenheit.Location = new System.Drawing.Point(6, 48);
            this.rbFahrenheit.Name = "rbFahrenheit";
            this.rbFahrenheit.Size = new System.Drawing.Size(75, 17);
            this.rbFahrenheit.TabIndex = 6;
            this.rbFahrenheit.Text = "Fahrenheit";
            this.rbFahrenheit.UseVisualStyleBackColor = true;
            this.rbFahrenheit.CheckedChanged += new System.EventHandler(this.rbFahrenheit_CheckedChanged);
            // 
            // rbCentigrados
            // 
            this.rbCentigrados.AutoSize = true;
            this.rbCentigrados.Checked = true;
            this.rbCentigrados.Location = new System.Drawing.Point(6, 25);
            this.rbCentigrados.Name = "rbCentigrados";
            this.rbCentigrados.Size = new System.Drawing.Size(81, 17);
            this.rbCentigrados.TabIndex = 6;
            this.rbCentigrados.TabStop = true;
            this.rbCentigrados.Text = "Centigrados";
            this.rbCentigrados.UseVisualStyleBackColor = true;
            this.rbCentigrados.CheckedChanged += new System.EventHandler(this.rbCentigrados_CheckedChanged);
            // 
            // gbModos
            // 
            this.gbModos.Controls.Add(this.gbNonStop);
            this.gbModos.Controls.Add(this.rbVacaciones);
            this.gbModos.Controls.Add(this.rbCongelador);
            this.gbModos.Controls.Add(this.rbFrigorifico);
            this.gbModos.Location = new System.Drawing.Point(6, 142);
            this.gbModos.Name = "gbModos";
            this.gbModos.Size = new System.Drawing.Size(274, 100);
            this.gbModos.TabIndex = 1;
            this.gbModos.TabStop = false;
            this.gbModos.Text = "Modo de funcionamiento:";
            // 
            // gbNonStop
            // 
            this.gbNonStop.Controls.Add(this.rbApagarNS);
            this.gbNonStop.Controls.Add(this.rbEncenderNS);
            this.gbNonStop.Location = new System.Drawing.Point(20, 49);
            this.gbNonStop.Name = "gbNonStop";
            this.gbNonStop.Size = new System.Drawing.Size(208, 51);
            this.gbNonStop.TabIndex = 1;
            this.gbNonStop.TabStop = false;
            this.gbNonStop.Text = "Non-Stop";
            // 
            // rbApagarNS
            // 
            this.rbApagarNS.AutoSize = true;
            this.rbApagarNS.Checked = true;
            this.rbApagarNS.Location = new System.Drawing.Point(111, 19);
            this.rbApagarNS.Name = "rbApagarNS";
            this.rbApagarNS.Size = new System.Drawing.Size(59, 17);
            this.rbApagarNS.TabIndex = 6;
            this.rbApagarNS.TabStop = true;
            this.rbApagarNS.Text = "Apagar";
            this.rbApagarNS.UseVisualStyleBackColor = true;
            this.rbApagarNS.CheckedChanged += new System.EventHandler(this.rbApagarNS_CheckedChanged);
            // 
            // rbEncenderNS
            // 
            this.rbEncenderNS.AutoSize = true;
            this.rbEncenderNS.Location = new System.Drawing.Point(11, 19);
            this.rbEncenderNS.Name = "rbEncenderNS";
            this.rbEncenderNS.Size = new System.Drawing.Size(71, 17);
            this.rbEncenderNS.TabIndex = 6;
            this.rbEncenderNS.Text = "Encender";
            this.rbEncenderNS.UseVisualStyleBackColor = true;
            this.rbEncenderNS.CheckedChanged += new System.EventHandler(this.rbEncenderNS_CheckedChanged);
            // 
            // rbVacaciones
            // 
            this.rbVacaciones.AutoSize = true;
            this.rbVacaciones.Location = new System.Drawing.Point(174, 26);
            this.rbVacaciones.Name = "rbVacaciones";
            this.rbVacaciones.Size = new System.Drawing.Size(81, 17);
            this.rbVacaciones.TabIndex = 6;
            this.rbVacaciones.Text = "Vacaciones";
            this.rbVacaciones.UseVisualStyleBackColor = true;
            this.rbVacaciones.CheckedChanged += new System.EventHandler(this.rbVacaciones_CheckedChanged);
            // 
            // rbCongelador
            // 
            this.rbCongelador.AutoSize = true;
            this.rbCongelador.Location = new System.Drawing.Point(97, 26);
            this.rbCongelador.Name = "rbCongelador";
            this.rbCongelador.Size = new System.Drawing.Size(79, 17);
            this.rbCongelador.TabIndex = 6;
            this.rbCongelador.Text = "Congelador";
            this.rbCongelador.UseVisualStyleBackColor = true;
            this.rbCongelador.CheckedChanged += new System.EventHandler(this.rbCongelador_CheckedChanged);
            // 
            // rbFrigorifico
            // 
            this.rbFrigorifico.AutoSize = true;
            this.rbFrigorifico.Checked = true;
            this.rbFrigorifico.Location = new System.Drawing.Point(20, 26);
            this.rbFrigorifico.Name = "rbFrigorifico";
            this.rbFrigorifico.Size = new System.Drawing.Size(70, 17);
            this.rbFrigorifico.TabIndex = 6;
            this.rbFrigorifico.TabStop = true;
            this.rbFrigorifico.Text = "Frigorifico";
            this.rbFrigorifico.UseVisualStyleBackColor = true;
            this.rbFrigorifico.CheckedChanged += new System.EventHandler(this.rbFrigorifico_CheckedChanged);
            // 
            // gbSensores
            // 
            this.gbSensores.Controls.Add(this.tbPiloto);
            this.gbSensores.Controls.Add(this.tbVtm);
            this.gbSensores.Controls.Add(this.tbVtc);
            this.gbSensores.Controls.Add(this.tbVta);
            this.gbSensores.Controls.Add(this.lbPiloto);
            this.gbSensores.Controls.Add(this.lbTempControl);
            this.gbSensores.Controls.Add(this.lbSimulacion);
            this.gbSensores.Controls.Add(this.lbTempAmbiente);
            this.gbSensores.Location = new System.Drawing.Point(12, 24);
            this.gbSensores.Name = "gbSensores";
            this.gbSensores.Size = new System.Drawing.Size(306, 219);
            this.gbSensores.TabIndex = 2;
            this.gbSensores.TabStop = false;
            this.gbSensores.Text = "Sensores";
            // 
            // tbPiloto
            // 
            this.tbPiloto.BackColor = System.Drawing.Color.White;
            this.tbPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPiloto.ForeColor = System.Drawing.Color.Red;
            this.tbPiloto.Location = new System.Drawing.Point(236, 120);
            this.tbPiloto.Name = "tbPiloto";
            this.tbPiloto.ReadOnly = true;
            this.tbPiloto.Size = new System.Drawing.Size(64, 23);
            this.tbPiloto.TabIndex = 9;
            this.tbPiloto.Text = "Apagado";
            // 
            // tbVtm
            // 
            this.tbVtm.BackColor = System.Drawing.Color.White;
            this.tbVtm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVtm.ForeColor = System.Drawing.Color.Black;
            this.tbVtm.Location = new System.Drawing.Point(236, 88);
            this.tbVtm.Name = "tbVtm";
            this.tbVtm.ReadOnly = true;
            this.tbVtm.Size = new System.Drawing.Size(64, 26);
            this.tbVtm.TabIndex = 8;
            this.tbVtm.Text = "00,00";
            // 
            // tbVtc
            // 
            this.tbVtc.BackColor = System.Drawing.Color.White;
            this.tbVtc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVtc.ForeColor = System.Drawing.Color.Black;
            this.tbVtc.Location = new System.Drawing.Point(236, 56);
            this.tbVtc.Name = "tbVtc";
            this.tbVtc.ReadOnly = true;
            this.tbVtc.Size = new System.Drawing.Size(64, 26);
            this.tbVtc.TabIndex = 7;
            this.tbVtc.Text = "00,00";
            // 
            // tbVta
            // 
            this.tbVta.BackColor = System.Drawing.Color.White;
            this.tbVta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbVta.ForeColor = System.Drawing.Color.Black;
            this.tbVta.Location = new System.Drawing.Point(236, 24);
            this.tbVta.Name = "tbVta";
            this.tbVta.ReadOnly = true;
            this.tbVta.Size = new System.Drawing.Size(64, 26);
            this.tbVta.TabIndex = 6;
            this.tbVta.Text = "00,00";
            // 
            // lbPiloto
            // 
            this.lbPiloto.AutoSize = true;
            this.lbPiloto.Location = new System.Drawing.Point(6, 125);
            this.lbPiloto.Name = "lbPiloto";
            this.lbPiloto.Size = new System.Drawing.Size(181, 13);
            this.lbPiloto.TabIndex = 0;
            this.lbPiloto.Text = "Piloto de funcionamiento de motores:";
            // 
            // lbTempControl
            // 
            this.lbTempControl.AutoSize = true;
            this.lbTempControl.Location = new System.Drawing.Point(6, 95);
            this.lbTempControl.Name = "lbTempControl";
            this.lbTempControl.Size = new System.Drawing.Size(205, 13);
            this.lbTempControl.TabIndex = 0;
            this.lbTempControl.Text = "Temperatura preestablecida o modificada:";
            // 
            // lbSimulacion
            // 
            this.lbSimulacion.AutoSize = true;
            this.lbSimulacion.Location = new System.Drawing.Point(6, 64);
            this.lbSimulacion.Name = "lbSimulacion";
            this.lbSimulacion.Size = new System.Drawing.Size(223, 13);
            this.lbSimulacion.TabIndex = 0;
            this.lbSimulacion.Text = "Temperatura simulada de la camara frigorifica:";
            // 
            // lbTempAmbiente
            // 
            this.lbTempAmbiente.AutoSize = true;
            this.lbTempAmbiente.Location = new System.Drawing.Point(6, 31);
            this.lbTempAmbiente.Name = "lbTempAmbiente";
            this.lbTempAmbiente.Size = new System.Drawing.Size(162, 13);
            this.lbTempAmbiente.TabIndex = 0;
            this.lbTempAmbiente.Text = "Temperatura exterior o ambiente:";
            // 
            // gbTemperatura
            // 
            this.gbTemperatura.Controls.Add(this.btnReducirT);
            this.gbTemperatura.Controls.Add(this.btnAumentarT);
            this.gbTemperatura.Location = new System.Drawing.Point(26, 23);
            this.gbTemperatura.Name = "gbTemperatura";
            this.gbTemperatura.Size = new System.Drawing.Size(131, 88);
            this.gbTemperatura.TabIndex = 3;
            this.gbTemperatura.TabStop = false;
            this.gbTemperatura.Text = "Modificar temperatura";
            // 
            // btnReducirT
            // 
            this.btnReducirT.Location = new System.Drawing.Point(17, 52);
            this.btnReducirT.Name = "btnReducirT";
            this.btnReducirT.Size = new System.Drawing.Size(75, 23);
            this.btnReducirT.TabIndex = 0;
            this.btnReducirT.Text = "Reducir";
            this.btnReducirT.UseVisualStyleBackColor = true;
            this.btnReducirT.Click += new System.EventHandler(this.btnReducirT_Click);
            // 
            // btnAumentarT
            // 
            this.btnAumentarT.Location = new System.Drawing.Point(17, 20);
            this.btnAumentarT.Name = "btnAumentarT";
            this.btnAumentarT.Size = new System.Drawing.Size(75, 23);
            this.btnAumentarT.TabIndex = 0;
            this.btnAumentarT.Text = "Aumentar";
            this.btnAumentarT.UseVisualStyleBackColor = true;
            this.btnAumentarT.Click += new System.EventHandler(this.btnAumentarT_Click);
            // 
            // btnPausaM
            // 
            this.btnPausaM.Location = new System.Drawing.Point(184, 99);
            this.btnPausaM.Name = "btnPausaM";
            this.btnPausaM.Size = new System.Drawing.Size(120, 37);
            this.btnPausaM.TabIndex = 4;
            this.btnPausaM.Text = "Pausa de 10 minutos";
            this.btnPausaM.UseVisualStyleBackColor = true;
            this.btnPausaM.Click += new System.EventHandler(this.btnPausaM_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbModos);
            this.groupBox1.Controls.Add(this.rdEncenderC);
            this.groupBox1.Controls.Add(this.rdApagarC);
            this.groupBox1.Controls.Add(this.btnPausaM);
            this.groupBox1.Controls.Add(this.gbTemperatura);
            this.groupBox1.Location = new System.Drawing.Point(426, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 261);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sistema de Control de la Camara:";
            // 
            // rdEncenderC
            // 
            this.rdEncenderC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdEncenderC.AutoSize = true;
            this.rdEncenderC.Location = new System.Drawing.Point(201, 30);
            this.rdEncenderC.Name = "rdEncenderC";
            this.rdEncenderC.Size = new System.Drawing.Size(103, 23);
            this.rdEncenderC.TabIndex = 6;
            this.rdEncenderC.Text = "Encender Sistema";
            this.rdEncenderC.UseVisualStyleBackColor = true;
            this.rdEncenderC.CheckedChanged += new System.EventHandler(this.rdEncenderApagarC_CheckedChanged);
            // 
            // rdApagarC
            // 
            this.rdApagarC.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdApagarC.AutoSize = true;
            this.rdApagarC.Checked = true;
            this.rdApagarC.Location = new System.Drawing.Point(201, 56);
            this.rdApagarC.Name = "rdApagarC";
            this.rdApagarC.Size = new System.Drawing.Size(91, 23);
            this.rdApagarC.TabIndex = 6;
            this.rdApagarC.TabStop = true;
            this.rdApagarC.Text = "Apagar Sistema";
            this.rdApagarC.UseVisualStyleBackColor = true;
            this.rdApagarC.CheckedChanged += new System.EventHandler(this.rdEncenderApagarC_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 60000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerPausa
            // 
            this.timerPausa.Interval = 600000;
            this.timerPausa.Tick += new System.EventHandler(this.timerPausa_Tick);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 261);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSensores);
            this.Controls.Add(this.gbGrados);
            this.Name = "Principal";
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.gbGrados.ResumeLayout(false);
            this.gbGrados.PerformLayout();
            this.gbModos.ResumeLayout(false);
            this.gbModos.PerformLayout();
            this.gbNonStop.ResumeLayout(false);
            this.gbNonStop.PerformLayout();
            this.gbSensores.ResumeLayout(false);
            this.gbSensores.PerformLayout();
            this.gbTemperatura.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbGrados;
        private System.Windows.Forms.GroupBox gbModos;
        private System.Windows.Forms.GroupBox gbNonStop;
        private System.Windows.Forms.GroupBox gbSensores;
        private System.Windows.Forms.Label lbSimulacion;
        private System.Windows.Forms.Label lbTempAmbiente;
        private System.Windows.Forms.GroupBox gbTemperatura;
        private System.Windows.Forms.Button btnReducirT;
        private System.Windows.Forms.Button btnAumentarT;
        private System.Windows.Forms.Button btnPausaM;
        private System.Windows.Forms.Label lbPiloto;
        private System.Windows.Forms.Label lbTempControl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbVta;
        private System.Windows.Forms.TextBox tbPiloto;
        private System.Windows.Forms.TextBox tbVtm;
        private System.Windows.Forms.TextBox tbVtc;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RadioButton rbCentigrados;
        private System.Windows.Forms.RadioButton rbFahrenheit;
        private System.Windows.Forms.RadioButton rbApagarNS;
        private System.Windows.Forms.RadioButton rbEncenderNS;
        private System.Windows.Forms.RadioButton rbVacaciones;
        private System.Windows.Forms.RadioButton rbCongelador;
        private System.Windows.Forms.RadioButton rbFrigorifico;
        private System.Windows.Forms.RadioButton rdEncenderC;
        private System.Windows.Forms.RadioButton rdApagarC;
        private System.Windows.Forms.Timer timerPausa;
    }
}