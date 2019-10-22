namespace EjerciciosFinales
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnH = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnNotas = new System.Windows.Forms.Button();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnD = new System.Windows.Forms.Button();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnEdad = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSemana = new System.Windows.Forms.Button();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnAno = new System.Windows.Forms.Button();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.listNumeros = new System.Windows.Forms.ListBox();
            this.btnNumeros = new System.Windows.Forms.Button();
            this.valor1 = new System.Windows.Forms.NumericUpDown();
            this.valor2 = new System.Windows.Forms.NumericUpDown();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(589, 456);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(581, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ejercicio1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(450, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digitar la base y la altura de un triángulo y calcular e imprimir la hipotenusa.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valor2);
            this.groupBox1.Controls.Add(this.btnH);
            this.groupBox1.Controls.Add(this.valor1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(65, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculando";
            // 
            // btnH
            // 
            this.btnH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnH.Location = new System.Drawing.Point(267, 29);
            this.btnH.Name = "btnH";
            this.btnH.Size = new System.Drawing.Size(132, 23);
            this.btnH.TabIndex = 3;
            this.btnH.Text = "Calcular hipotenusa";
            this.btnH.UseVisualStyleBackColor = true;
            this.btnH.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(581, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ejercicio2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digitar 4 notas y calcular e imprimir el promedio.";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnNotas);
            this.groupBox2.Controls.Add(this.txtNota4);
            this.groupBox2.Controls.Add(this.txtNota3);
            this.groupBox2.Controls.Add(this.txtNota2);
            this.groupBox2.Controls.Add(this.txtNota1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(58, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(414, 293);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notas";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(46, 16);
            this.label11.TabIndex = 8;
            this.label11.Text = "Nota 4";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 7;
            this.label10.Text = "Nota 3";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Nota 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nota 1";
            // 
            // btnNotas
            // 
            this.btnNotas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNotas.Location = new System.Drawing.Point(33, 254);
            this.btnNotas.Name = "btnNotas";
            this.btnNotas.Size = new System.Drawing.Size(351, 23);
            this.btnNotas.TabIndex = 4;
            this.btnNotas.Text = "Calcular las Notas";
            this.btnNotas.UseVisualStyleBackColor = true;
            this.btnNotas.Click += new System.EventHandler(this.btnNotas_Click);
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(33, 215);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(351, 22);
            this.txtNota4.TabIndex = 3;
            this.txtNota4.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(33, 156);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(351, 22);
            this.txtNota3.TabIndex = 2;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(33, 100);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(351, 22);
            this.txtNota2.TabIndex = 1;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(33, 43);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(351, 22);
            this.txtNota1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(581, 430);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ejercicio3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-4, 414);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(366, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calcular la distancia recorrida (Buscar formula de la distancia)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnD);
            this.groupBox3.Controls.Add(this.txtT);
            this.groupBox3.Controls.Add(this.txtS);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(52, 63);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(385, 69);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "La distancia rrecorida";
            // 
            // btnD
            // 
            this.btnD.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnD.Location = new System.Drawing.Point(231, 30);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(144, 23);
            this.btnD.TabIndex = 2;
            this.btnD.Text = "Calcular la distancia";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(125, 31);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(100, 22);
            this.txtT.TabIndex = 1;
            this.txtT.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // txtS
            // 
            this.txtS.Location = new System.Drawing.Point(19, 30);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(100, 22);
            this.txtS.TabIndex = 0;
            this.txtS.TextChanged += new System.EventHandler(this.txtS_TextChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(581, 430);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ejercicio4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-3, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Digitar el año de nacimiento e imprimir la edad actual";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAno);
            this.groupBox4.Controls.Add(this.btnEdad);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(36, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(258, 73);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "El año nacimiento";
            // 
            // btnEdad
            // 
            this.btnEdad.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdad.Location = new System.Drawing.Point(143, 36);
            this.btnEdad.Name = "btnEdad";
            this.btnEdad.Size = new System.Drawing.Size(108, 23);
            this.btnEdad.TabIndex = 1;
            this.btnEdad.Text = "Ver tu edad";
            this.btnEdad.UseVisualStyleBackColor = true;
            this.btnEdad.Click += new System.EventHandler(this.btnEdad_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(581, 430);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Ejercicio5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSemana);
            this.groupBox5.Controls.Add(this.txtDia);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(52, 34);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(278, 72);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Dia de la semana";
            // 
            // btnSemana
            // 
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSemana.Location = new System.Drawing.Point(112, 33);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(156, 23);
            this.btnSemana.TabIndex = 1;
            this.btnSemana.Text = "Ver el dia de la semana";
            this.btnSemana.UseVisualStyleBackColor = true;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(6, 34);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(100, 22);
            this.txtDia.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-3, 394);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(526, 36);
            this.label5.TabIndex = 0;
            this.label5.Text = "Digitar un número y mostrar qué día de la semana es. Validar que no se pueda digi" +
    "tar un número que no sea mayor que 7 o menor que 1.";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox6);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(581, 430);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ejercicio6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnAno);
            this.groupBox6.Controls.Add(this.txtMes);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(68, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 69);
            this.groupBox6.TabIndex = 1;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Meses del año";
            // 
            // btnAno
            // 
            this.btnAno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAno.Location = new System.Drawing.Point(124, 33);
            this.btnAno.Name = "btnAno";
            this.btnAno.Size = new System.Drawing.Size(116, 23);
            this.btnAno.TabIndex = 1;
            this.btnAno.Text = "Ver mes del año";
            this.btnAno.UseVisualStyleBackColor = true;
            this.btnAno.Click += new System.EventHandler(this.btnAno_Click);
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(18, 33);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 22);
            this.txtMes.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(-3, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(542, 35);
            this.label6.TabIndex = 0;
            this.label6.Text = "Digitar un número y mostrar qué mes del año es. Validar que no se pueda digitar u" +
    "n número que no sea mayor que 12 o menor que 1.";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Controls.Add(this.groupBox7);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(581, 430);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Ejercicio7";
            this.tabPage7.UseVisualStyleBackColor = true;
            this.tabPage7.Click += new System.EventHandler(this.tabPage7_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 414);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(240, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Imprimir los números pares del 1 al 100.";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.listNumeros);
            this.groupBox7.Controls.Add(this.btnNumeros);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(48, 41);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(391, 293);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Los numeros pares del 1 al 100";
            // 
            // listNumeros
            // 
            this.listNumeros.FormattingEnabled = true;
            this.listNumeros.ItemHeight = 16;
            this.listNumeros.Location = new System.Drawing.Point(6, 59);
            this.listNumeros.Name = "listNumeros";
            this.listNumeros.Size = new System.Drawing.Size(379, 228);
            this.listNumeros.TabIndex = 4;
            // 
            // btnNumeros
            // 
            this.btnNumeros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNumeros.Location = new System.Drawing.Point(6, 30);
            this.btnNumeros.Name = "btnNumeros";
            this.btnNumeros.Size = new System.Drawing.Size(379, 23);
            this.btnNumeros.TabIndex = 1;
            this.btnNumeros.Text = "Ver ";
            this.btnNumeros.UseVisualStyleBackColor = true;
            this.btnNumeros.Click += new System.EventHandler(this.btnNumeros_Click);
            // 
            // valor1
            // 
            this.valor1.Location = new System.Drawing.Point(15, 29);
            this.valor1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valor1.Name = "valor1";
            this.valor1.Size = new System.Drawing.Size(120, 22);
            this.valor1.TabIndex = 5;
            // 
            // valor2
            // 
            this.valor2.Location = new System.Drawing.Point(141, 30);
            this.valor2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.valor2.Name = "valor2";
            this.valor2.Size = new System.Drawing.Size(120, 22);
            this.valor2.TabIndex = 6;
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(19, 36);
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(118, 22);
            this.txtAno.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 480);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "EjerciciosFinales";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.valor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnH;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnNotas;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnEdad;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnAno;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox listNumeros;
        private System.Windows.Forms.Button btnNumeros;
        private System.Windows.Forms.NumericUpDown valor2;
        private System.Windows.Forms.NumericUpDown valor1;
        private System.Windows.Forms.TextBox txtAno;
    }
}

