namespace Ejercicios
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.grNumeros = new System.Windows.Forms.GroupBox();
            this.grColor = new System.Windows.Forms.GroupBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numR = new System.Windows.Forms.NumericUpDown();
            this.numG = new System.Windows.Forms.NumericUpDown();
            this.numB = new System.Windows.Forms.NumericUpDown();
            this.barR = new System.Windows.Forms.TrackBar();
            this.barG = new System.Windows.Forms.TrackBar();
            this.barB = new System.Windows.Forms.TrackBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.grNumeros.SuspendLayout();
            this.grColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(14, 50);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 22);
            this.txtNumero.TabIndex = 1;
            // 
            // btnVerificar
            // 
            this.btnVerificar.BackColor = System.Drawing.Color.White;
            this.btnVerificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVerificar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerificar.Location = new System.Drawing.Point(120, 50);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 23);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = false;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // grNumeros
            // 
            this.grNumeros.Controls.Add(this.btnVerificar);
            this.grNumeros.Controls.Add(this.txtNumero);
            this.grNumeros.Controls.Add(this.label1);
            this.grNumeros.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grNumeros.Location = new System.Drawing.Point(12, 22);
            this.grNumeros.Name = "grNumeros";
            this.grNumeros.Size = new System.Drawing.Size(260, 100);
            this.grNumeros.TabIndex = 3;
            this.grNumeros.TabStop = false;
            this.grNumeros.Text = "Numeros impares y pares";
            // 
            // grColor
            // 
            this.grColor.Controls.Add(this.progressBar3);
            this.grColor.Controls.Add(this.progressBar2);
            this.grColor.Controls.Add(this.progressBar1);
            this.grColor.Controls.Add(this.barB);
            this.grColor.Controls.Add(this.barG);
            this.grColor.Controls.Add(this.barR);
            this.grColor.Controls.Add(this.numB);
            this.grColor.Controls.Add(this.numG);
            this.grColor.Controls.Add(this.numR);
            this.grColor.Controls.Add(this.label4);
            this.grColor.Controls.Add(this.label3);
            this.grColor.Controls.Add(this.btnColor);
            this.grColor.Controls.Add(this.label2);
            this.grColor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grColor.Location = new System.Drawing.Point(12, 140);
            this.grColor.Name = "grColor";
            this.grColor.Size = new System.Drawing.Size(591, 194);
            this.grColor.TabIndex = 4;
            this.grColor.TabStop = false;
            this.grColor.Text = "Cambiar color de fondo";
            // 
            // btnColor
            // 
            this.btnColor.BackColor = System.Drawing.Color.White;
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnColor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.Location = new System.Drawing.Point(46, 159);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(149, 23);
            this.btnColor.TabIndex = 2;
            this.btnColor.Text = "Cambiar de color";
            this.btnColor.UseVisualStyleBackColor = false;
            this.btnColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "R:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "G:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "B:";
            // 
            // numR
            // 
            this.numR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numR.Location = new System.Drawing.Point(75, 24);
            this.numR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numR.Name = "numR";
            this.numR.Size = new System.Drawing.Size(120, 22);
            this.numR.TabIndex = 5;
            this.numR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numG
            // 
            this.numG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numG.Location = new System.Drawing.Point(75, 70);
            this.numG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(120, 22);
            this.numG.TabIndex = 6;
            this.numG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // numB
            // 
            this.numB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numB.Location = new System.Drawing.Point(75, 118);
            this.numB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numB.Name = "numB";
            this.numB.Size = new System.Drawing.Size(120, 22);
            this.numB.TabIndex = 7;
            this.numB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            // 
            // barR
            // 
            this.barR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barR.Location = new System.Drawing.Point(201, 21);
            this.barR.Maximum = 255;
            this.barR.Name = "barR";
            this.barR.Size = new System.Drawing.Size(203, 45);
            this.barR.TabIndex = 8;
            this.barR.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // barG
            // 
            this.barG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barG.Location = new System.Drawing.Point(201, 70);
            this.barG.Maximum = 255;
            this.barG.Name = "barG";
            this.barG.Size = new System.Drawing.Size(203, 45);
            this.barG.TabIndex = 9;
            this.barG.Scroll += new System.EventHandler(this.barG_Scroll);
            // 
            // barB
            // 
            this.barB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.barB.Location = new System.Drawing.Point(201, 116);
            this.barB.Maximum = 255;
            this.barB.Name = "barB";
            this.barB.Size = new System.Drawing.Size(203, 45);
            this.barB.TabIndex = 10;
            this.barB.Scroll += new System.EventHandler(this.barB_Scroll);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(411, 24);
            this.progressBar1.Maximum = 255;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 11;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(411, 68);
            this.progressBar2.Maximum = 255;
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(100, 23);
            this.progressBar2.TabIndex = 12;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(411, 116);
            this.progressBar3.Maximum = 255;
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(100, 23);
            this.progressBar3.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 395);
            this.Controls.Add(this.grColor);
            this.Controls.Add(this.grNumeros);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grNumeros.ResumeLayout(false);
            this.grNumeros.PerformLayout();
            this.grColor.ResumeLayout(false);
            this.grColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.GroupBox grNumeros;
        private System.Windows.Forms.GroupBox grColor;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar barB;
        private System.Windows.Forms.TrackBar barG;
        private System.Windows.Forms.TrackBar barR;
        private System.Windows.Forms.NumericUpDown numB;
        private System.Windows.Forms.NumericUpDown numG;
        private System.Windows.Forms.NumericUpDown numR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar1;




    }
}

