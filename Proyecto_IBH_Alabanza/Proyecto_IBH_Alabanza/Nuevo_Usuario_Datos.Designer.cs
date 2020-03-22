namespace Proyecto_IBH_Alabanza
{
    partial class Nuevo_Usuario_Datos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nuevo_Usuario_Datos));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckOtros = new System.Windows.Forms.CheckBox();
            this.ckSana = new System.Windows.Forms.CheckBox();
            this.ckLecciones = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ckOtros2 = new System.Windows.Forms.CheckBox();
            this.ckAudio = new System.Windows.Forms.CheckBox();
            this.ckBateria = new System.Windows.Forms.CheckBox();
            this.ckBajo = new System.Windows.Forms.CheckBox();
            this.ckPiano = new System.Windows.Forms.CheckBox();
            this.ckGuitarra = new System.Windows.Forms.CheckBox();
            this.ckCanto = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnSi = new System.Windows.Forms.RadioButton();
            this.rbtnNo = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbDias = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtObs = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(144, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(325, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datos del Miembro";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(496, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 128);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Estado: ";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(147, 118);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(184, 28);
            this.cmbEstado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "¿Está Bautizado? ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckOtros);
            this.groupBox2.Controls.Add(this.ckSana);
            this.groupBox2.Controls.Add(this.ckLecciones);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(41, 276);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 91);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discipulados Recibidos: ";
            // 
            // ckOtros
            // 
            this.ckOtros.AutoSize = true;
            this.ckOtros.Location = new System.Drawing.Point(442, 41);
            this.ckOtros.Name = "ckOtros";
            this.ckOtros.Size = new System.Drawing.Size(67, 24);
            this.ckOtros.TabIndex = 3;
            this.ckOtros.Text = "Otros";
            this.ckOtros.UseVisualStyleBackColor = true;
            // 
            // ckSana
            // 
            this.ckSana.AutoSize = true;
            this.ckSana.Location = new System.Drawing.Point(189, 41);
            this.ckSana.Name = "ckSana";
            this.ckSana.Size = new System.Drawing.Size(220, 24);
            this.ckSana.TabIndex = 1;
            this.ckSana.Text = "¿Qué es una Iglesía Sana?";
            this.ckSana.UseVisualStyleBackColor = true;
            // 
            // ckLecciones
            // 
            this.ckLecciones.AutoSize = true;
            this.ckLecciones.Location = new System.Drawing.Point(36, 41);
            this.ckLecciones.Name = "ckLecciones";
            this.ckLecciones.Size = new System.Drawing.Size(122, 24);
            this.ckLecciones.TabIndex = 0;
            this.ckLecciones.Text = "12 Lecciones";
            this.ckLecciones.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ckOtros2);
            this.groupBox3.Controls.Add(this.ckAudio);
            this.groupBox3.Controls.Add(this.ckBateria);
            this.groupBox3.Controls.Add(this.ckBajo);
            this.groupBox3.Controls.Add(this.ckPiano);
            this.groupBox3.Controls.Add(this.ckGuitarra);
            this.groupBox3.Controls.Add(this.ckCanto);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(41, 373);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 148);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Talento:";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // ckOtros2
            // 
            this.ckOtros2.AutoSize = true;
            this.ckOtros2.Location = new System.Drawing.Point(208, 83);
            this.ckOtros2.Name = "ckOtros2";
            this.ckOtros2.Size = new System.Drawing.Size(67, 24);
            this.ckOtros2.TabIndex = 11;
            this.ckOtros2.Text = "Otros";
            this.ckOtros2.UseVisualStyleBackColor = true;
            // 
            // ckAudio
            // 
            this.ckAudio.AutoSize = true;
            this.ckAudio.Location = new System.Drawing.Point(208, 37);
            this.ckAudio.Name = "ckAudio";
            this.ckAudio.Size = new System.Drawing.Size(69, 24);
            this.ckAudio.TabIndex = 6;
            this.ckAudio.Text = "Audio";
            this.ckAudio.UseVisualStyleBackColor = true;
            this.ckAudio.CheckedChanged += new System.EventHandler(this.ckAudio_CheckedChanged);
            // 
            // ckBateria
            // 
            this.ckBateria.AutoSize = true;
            this.ckBateria.Location = new System.Drawing.Point(120, 83);
            this.ckBateria.Name = "ckBateria";
            this.ckBateria.Size = new System.Drawing.Size(79, 24);
            this.ckBateria.TabIndex = 5;
            this.ckBateria.Text = "Bateria";
            this.ckBateria.UseVisualStyleBackColor = true;
            // 
            // ckBajo
            // 
            this.ckBajo.AutoSize = true;
            this.ckBajo.Location = new System.Drawing.Point(36, 83);
            this.ckBajo.Name = "ckBajo";
            this.ckBajo.Size = new System.Drawing.Size(60, 24);
            this.ckBajo.TabIndex = 4;
            this.ckBajo.Text = "Bajo";
            this.ckBajo.UseVisualStyleBackColor = true;
            // 
            // ckPiano
            // 
            this.ckPiano.AutoSize = true;
            this.ckPiano.Location = new System.Drawing.Point(120, 37);
            this.ckPiano.Name = "ckPiano";
            this.ckPiano.Size = new System.Drawing.Size(68, 24);
            this.ckPiano.TabIndex = 3;
            this.ckPiano.Text = "Piano";
            this.ckPiano.UseVisualStyleBackColor = true;
            // 
            // ckGuitarra
            // 
            this.ckGuitarra.AutoSize = true;
            this.ckGuitarra.Location = new System.Drawing.Point(299, 37);
            this.ckGuitarra.Name = "ckGuitarra";
            this.ckGuitarra.Size = new System.Drawing.Size(86, 24);
            this.ckGuitarra.TabIndex = 2;
            this.ckGuitarra.Text = "Guitarra";
            this.ckGuitarra.UseVisualStyleBackColor = true;
            // 
            // ckCanto
            // 
            this.ckCanto.AutoSize = true;
            this.ckCanto.Location = new System.Drawing.Point(36, 37);
            this.ckCanto.Name = "ckCanto";
            this.ckCanto.Size = new System.Drawing.Size(71, 24);
            this.ckCanto.TabIndex = 1;
            this.ckCanto.Text = "Canto";
            this.ckCanto.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnSi);
            this.groupBox1.Controls.Add(this.rbtnNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 89);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bautizo";
            // 
            // rbtnSi
            // 
            this.rbtnSi.AutoSize = true;
            this.rbtnSi.Location = new System.Drawing.Point(312, 37);
            this.rbtnSi.Name = "rbtnSi";
            this.rbtnSi.Size = new System.Drawing.Size(41, 24);
            this.rbtnSi.TabIndex = 2;
            this.rbtnSi.TabStop = true;
            this.rbtnSi.Text = "Si";
            this.rbtnSi.UseVisualStyleBackColor = true;
            // 
            // rbtnNo
            // 
            this.rbtnNo.AutoSize = true;
            this.rbtnNo.Location = new System.Drawing.Point(207, 37);
            this.rbtnNo.Name = "rbtnNo";
            this.rbtnNo.Size = new System.Drawing.Size(47, 24);
            this.rbtnNo.TabIndex = 1;
            this.rbtnNo.TabStop = true;
            this.rbtnNo.Text = "No";
            this.rbtnNo.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbDias);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(41, 531);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 97);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Disponibilidad: ";
            // 
            // cmbDias
            // 
            this.cmbDias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDias.FormattingEnabled = true;
            this.cmbDias.Location = new System.Drawing.Point(347, 36);
            this.cmbDias.Name = "cmbDias";
            this.cmbDias.Size = new System.Drawing.Size(183, 28);
            this.cmbDias.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(308, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "¿Días que tiene Disponibilidad para servir?";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(512, 666);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(74, 55);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(622, 666);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(74, 55);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 635);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Observacion: ";
            // 
            // txtObs
            // 
            this.txtObs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObs.Location = new System.Drawing.Point(44, 661);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(350, 60);
            this.txtObs.TabIndex = 13;
            // 
            // Nuevo_Usuario_Datos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 781);
            this.Controls.Add(this.txtObs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Nuevo_Usuario_Datos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Usuario | IBH Alabanza";
            this.Load += new System.EventHandler(this.Nuevo_Usuario_Datos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckOtros;
        private System.Windows.Forms.CheckBox ckSana;
        private System.Windows.Forms.CheckBox ckLecciones;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox ckOtros2;
        private System.Windows.Forms.CheckBox ckAudio;
        private System.Windows.Forms.CheckBox ckBateria;
        private System.Windows.Forms.CheckBox ckBajo;
        private System.Windows.Forms.CheckBox ckPiano;
        private System.Windows.Forms.CheckBox ckGuitarra;
        private System.Windows.Forms.CheckBox ckCanto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnSi;
        private System.Windows.Forms.RadioButton rbtnNo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmbDias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtObs;
    }
}