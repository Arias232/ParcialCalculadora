namespace ParcialCalculadora
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraGrande = new System.Windows.Forms.TextBox();
            this.uno = new ParcialCalculadora.ClsBotonCircular();
            this.dos = new ParcialCalculadora.ClsBotonCircular();
            this.tres = new ParcialCalculadora.ClsBotonCircular();
            this.sumar = new ParcialCalculadora.ClsBotonCircular();
            this.cuatro = new ParcialCalculadora.ClsBotonCircular();
            this.cinco = new ParcialCalculadora.ClsBotonCircular();
            this.seis = new ParcialCalculadora.ClsBotonCircular();
            this.restar = new ParcialCalculadora.ClsBotonCircular();
            this.siete = new ParcialCalculadora.ClsBotonCircular();
            this.ocho = new ParcialCalculadora.ClsBotonCircular();
            this.nueve = new ParcialCalculadora.ClsBotonCircular();
            this.multiplicar = new ParcialCalculadora.ClsBotonCircular();
            this.c = new ParcialCalculadora.ClsBotonCircular();
            this.dividir = new ParcialCalculadora.ClsBotonCircular();
            this.cero = new ParcialCalculadora.ClsBotonCircular();
            this.punto = new ParcialCalculadora.ClsBotonCircular();
            this.ce = new ParcialCalculadora.ClsBotonCircular();
            this.igual = new ParcialCalculadora.ClsBotonCircular();
            this.historial = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BarraGrande
            // 
            this.BarraGrande.Font = new System.Drawing.Font("Segoe UI Symbol", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BarraGrande.ForeColor = System.Drawing.Color.Black;
            this.BarraGrande.Location = new System.Drawing.Point(12, 32);
            this.BarraGrande.Multiline = true;
            this.BarraGrande.Name = "BarraGrande";
            this.BarraGrande.Size = new System.Drawing.Size(298, 114);
            this.BarraGrande.TabIndex = 0;
            this.BarraGrande.Text = "0";
            this.BarraGrande.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BarraGrande.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uno
            // 
            this.uno.Location = new System.Drawing.Point(12, 377);
            this.uno.Name = "uno";
            this.uno.Size = new System.Drawing.Size(70, 68);
            this.uno.TabIndex = 1;
            this.uno.Text = "1";
            this.uno.UseVisualStyleBackColor = true;
            this.uno.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // dos
            // 
            this.dos.Location = new System.Drawing.Point(88, 377);
            this.dos.Name = "dos";
            this.dos.Size = new System.Drawing.Size(70, 68);
            this.dos.TabIndex = 4;
            this.dos.Text = "2";
            this.dos.UseVisualStyleBackColor = true;
            this.dos.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // tres
            // 
            this.tres.Location = new System.Drawing.Point(164, 377);
            this.tres.Name = "tres";
            this.tres.Size = new System.Drawing.Size(70, 68);
            this.tres.TabIndex = 5;
            this.tres.Text = "3";
            this.tres.UseVisualStyleBackColor = true;
            this.tres.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // sumar
            // 
            this.sumar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.sumar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sumar.Location = new System.Drawing.Point(240, 380);
            this.sumar.Name = "sumar";
            this.sumar.Size = new System.Drawing.Size(70, 68);
            this.sumar.TabIndex = 6;
            this.sumar.Tag = "+";
            this.sumar.Text = "+";
            this.sumar.UseVisualStyleBackColor = false;
            this.sumar.Click += new System.EventHandler(this.ingresaroperador);
            // 
            // cuatro
            // 
            this.cuatro.Location = new System.Drawing.Point(12, 303);
            this.cuatro.Name = "cuatro";
            this.cuatro.Size = new System.Drawing.Size(70, 68);
            this.cuatro.TabIndex = 7;
            this.cuatro.Text = "4";
            this.cuatro.UseVisualStyleBackColor = true;
            this.cuatro.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // cinco
            // 
            this.cinco.Location = new System.Drawing.Point(88, 303);
            this.cinco.Name = "cinco";
            this.cinco.Size = new System.Drawing.Size(70, 68);
            this.cinco.TabIndex = 8;
            this.cinco.Text = "5";
            this.cinco.UseVisualStyleBackColor = true;
            this.cinco.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // seis
            // 
            this.seis.Location = new System.Drawing.Point(164, 303);
            this.seis.Name = "seis";
            this.seis.Size = new System.Drawing.Size(70, 68);
            this.seis.TabIndex = 9;
            this.seis.Text = "6";
            this.seis.UseVisualStyleBackColor = true;
            this.seis.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // restar
            // 
            this.restar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.restar.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.restar.Location = new System.Drawing.Point(240, 303);
            this.restar.Name = "restar";
            this.restar.Size = new System.Drawing.Size(70, 68);
            this.restar.TabIndex = 10;
            this.restar.Tag = "-";
            this.restar.Text = "-";
            this.restar.UseVisualStyleBackColor = false;
            this.restar.Click += new System.EventHandler(this.ingresaroperador);
            // 
            // siete
            // 
            this.siete.Location = new System.Drawing.Point(12, 229);
            this.siete.Name = "siete";
            this.siete.Size = new System.Drawing.Size(70, 68);
            this.siete.TabIndex = 11;
            this.siete.Text = "7";
            this.siete.UseVisualStyleBackColor = true;
            this.siete.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // ocho
            // 
            this.ocho.Location = new System.Drawing.Point(88, 229);
            this.ocho.Name = "ocho";
            this.ocho.Size = new System.Drawing.Size(70, 68);
            this.ocho.TabIndex = 12;
            this.ocho.Text = "8";
            this.ocho.UseVisualStyleBackColor = true;
            this.ocho.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // nueve
            // 
            this.nueve.Location = new System.Drawing.Point(164, 229);
            this.nueve.Name = "nueve";
            this.nueve.Size = new System.Drawing.Size(70, 68);
            this.nueve.TabIndex = 13;
            this.nueve.Text = "9";
            this.nueve.UseVisualStyleBackColor = true;
            this.nueve.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // multiplicar
            // 
            this.multiplicar.BackColor = System.Drawing.Color.PaleTurquoise;
            this.multiplicar.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.multiplicar.Location = new System.Drawing.Point(240, 229);
            this.multiplicar.Name = "multiplicar";
            this.multiplicar.Size = new System.Drawing.Size(70, 68);
            this.multiplicar.TabIndex = 14;
            this.multiplicar.Tag = "x";
            this.multiplicar.Text = "x";
            this.multiplicar.UseVisualStyleBackColor = false;
            this.multiplicar.Click += new System.EventHandler(this.ingresaroperador);
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Bisque;
            this.c.Location = new System.Drawing.Point(164, 152);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(70, 68);
            this.c.TabIndex = 17;
            this.c.Text = "C";
            this.c.UseVisualStyleBackColor = false;
            this.c.Click += new System.EventHandler(this.clsBotonCircular15_Click);
            // 
            // dividir
            // 
            this.dividir.BackColor = System.Drawing.Color.PaleTurquoise;
            this.dividir.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dividir.Location = new System.Drawing.Point(240, 152);
            this.dividir.Name = "dividir";
            this.dividir.Size = new System.Drawing.Size(71, 71);
            this.dividir.TabIndex = 18;
            this.dividir.Tag = "/";
            this.dividir.Text = "/";
            this.dividir.UseVisualStyleBackColor = false;
            this.dividir.Click += new System.EventHandler(this.ingresaroperador);
            // 
            // cero
            // 
            this.cero.Location = new System.Drawing.Point(12, 451);
            this.cero.Name = "cero";
            this.cero.Size = new System.Drawing.Size(70, 68);
            this.cero.TabIndex = 19;
            this.cero.Text = "0";
            this.cero.UseVisualStyleBackColor = true;
            this.cero.Click += new System.EventHandler(this.ingresarcantidades);
            // 
            // punto
            // 
            this.punto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.punto.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.punto.Location = new System.Drawing.Point(88, 451);
            this.punto.Name = "punto";
            this.punto.Size = new System.Drawing.Size(70, 68);
            this.punto.TabIndex = 20;
            this.punto.Tag = ".";
            this.punto.Text = ".";
            this.punto.UseVisualStyleBackColor = true;
            this.punto.Click += new System.EventHandler(this.clsBotonCircular18_Click);
            // 
            // ce
            // 
            this.ce.BackColor = System.Drawing.Color.Bisque;
            this.ce.Location = new System.Drawing.Point(164, 451);
            this.ce.Name = "ce";
            this.ce.Size = new System.Drawing.Size(70, 68);
            this.ce.TabIndex = 21;
            this.ce.Text = "CE";
            this.ce.UseVisualStyleBackColor = false;
            this.ce.Click += new System.EventHandler(this.ce_Click);
            // 
            // igual
            // 
            this.igual.BackColor = System.Drawing.Color.Black;
            this.igual.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.igual.ForeColor = System.Drawing.Color.Azure;
            this.igual.Location = new System.Drawing.Point(236, 451);
            this.igual.Name = "igual";
            this.igual.Size = new System.Drawing.Size(70, 68);
            this.igual.TabIndex = 22;
            this.igual.Text = "=";
            this.igual.UseVisualStyleBackColor = false;
            this.igual.Click += new System.EventHandler(this.iguals);
            // 
            // historial
            // 
            this.historial.AutoSize = true;
            this.historial.Location = new System.Drawing.Point(12, 149);
            this.historial.Name = "historial";
            this.historial.Size = new System.Drawing.Size(0, 20);
            this.historial.TabIndex = 23;
            this.historial.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(323, 561);
            this.Controls.Add(this.historial);
            this.Controls.Add(this.igual);
            this.Controls.Add(this.ce);
            this.Controls.Add(this.punto);
            this.Controls.Add(this.cero);
            this.Controls.Add(this.dividir);
            this.Controls.Add(this.c);
            this.Controls.Add(this.multiplicar);
            this.Controls.Add(this.nueve);
            this.Controls.Add(this.ocho);
            this.Controls.Add(this.siete);
            this.Controls.Add(this.restar);
            this.Controls.Add(this.seis);
            this.Controls.Add(this.cinco);
            this.Controls.Add(this.cuatro);
            this.Controls.Add(this.sumar);
            this.Controls.Add(this.tres);
            this.Controls.Add(this.dos);
            this.Controls.Add(this.uno);
            this.Controls.Add(this.BarraGrande);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox BarraGrande;
        private ClsBotonCircular uno;
        private ClsBotonCircular dos;
        private ClsBotonCircular tres;
        private ClsBotonCircular sumar;
        private ClsBotonCircular cuatro;
        private ClsBotonCircular cinco;
        private ClsBotonCircular seis;
        private ClsBotonCircular restar;
        private ClsBotonCircular siete;
        private ClsBotonCircular ocho;
        private ClsBotonCircular nueve;
        private ClsBotonCircular multiplicar;
        private ClsBotonCircular c;
        private ClsBotonCircular dividir;
        private ClsBotonCircular cero;
        private ClsBotonCircular punto;
        private ClsBotonCircular ce;
        private ClsBotonCircular igual;
        private Label historial;
    }
}