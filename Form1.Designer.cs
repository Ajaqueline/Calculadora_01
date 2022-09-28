namespace SOMA_1
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
            this.label1num1 = new System.Windows.Forms.Label();
            this.label2num2 = new System.Windows.Forms.Label();
            this.textBox1num1 = new System.Windows.Forms.TextBox();
            this.textBox2num2 = new System.Windows.Forms.TextBox();
            this.button1soma = new System.Windows.Forms.Button();
            this.label1resul = new System.Windows.Forms.Label();
            this.label2calc = new System.Windows.Forms.Label();
            this.button1sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1num1
            // 
            this.label1num1.AutoSize = true;
            this.label1num1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1num1.Location = new System.Drawing.Point(37, 50);
            this.label1num1.Name = "label1num1";
            this.label1num1.Size = new System.Drawing.Size(199, 16);
            this.label1num1.TabIndex = 1;
            this.label1num1.Text = "Digite o Primeiro Numero";
            // 
            // label2num2
            // 
            this.label2num2.AutoSize = true;
            this.label2num2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2num2.Location = new System.Drawing.Point(37, 133);
            this.label2num2.Name = "label2num2";
            this.label2num2.Size = new System.Drawing.Size(191, 16);
            this.label2num2.TabIndex = 2;
            this.label2num2.Text = "Digite o Segundo Numero";
            this.label2num2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1num1
            // 
            this.textBox1num1.Location = new System.Drawing.Point(81, 79);
            this.textBox1num1.Name = "textBox1num1";
            this.textBox1num1.Size = new System.Drawing.Size(100, 23);
            this.textBox1num1.TabIndex = 3;
            this.textBox1num1.TextChanged += new System.EventHandler(this.textBox1num1_TextChanged);
            // 
            // textBox2num2
            // 
            this.textBox2num2.Location = new System.Drawing.Point(81, 162);
            this.textBox2num2.Name = "textBox2num2";
            this.textBox2num2.Size = new System.Drawing.Size(100, 23);
            this.textBox2num2.TabIndex = 4;
            this.textBox2num2.TextChanged += new System.EventHandler(this.textBox2num2_TextChanged);
            // 
            // button1soma
            // 
            this.button1soma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1soma.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1soma.Location = new System.Drawing.Point(81, 209);
            this.button1soma.Name = "button1soma";
            this.button1soma.Size = new System.Drawing.Size(90, 28);
            this.button1soma.TabIndex = 5;
            this.button1soma.Text = "SOMA";
            this.button1soma.UseVisualStyleBackColor = false;
            this.button1soma.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1resul
            // 
            this.label1resul.AutoSize = true;
            this.label1resul.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1resul.Location = new System.Drawing.Point(24, 282);
            this.label1resul.Name = "label1resul";
            this.label1resul.Size = new System.Drawing.Size(79, 16);
            this.label1resul.TabIndex = 6;
            this.label1resul.Text = "Resultado";
            // 
            // label2calc
            // 
            this.label2calc.AutoSize = true;
            this.label2calc.Location = new System.Drawing.Point(121, 284);
            this.label2calc.Name = "label2calc";
            this.label2calc.Size = new System.Drawing.Size(13, 15);
            this.label2calc.TabIndex = 7;
            this.label2calc.Text = "0";
            this.label2calc.Click += new System.EventHandler(this.label2calc_Click);
            // 
            // button1sair
            // 
            this.button1sair.BackColor = System.Drawing.Color.Gray;
            this.button1sair.Location = new System.Drawing.Point(96, 317);
            this.button1sair.Name = "button1sair";
            this.button1sair.Size = new System.Drawing.Size(75, 23);
            this.button1sair.TabIndex = 8;
            this.button1sair.Text = "SAIR";
            this.button1sair.UseVisualStyleBackColor = false;
            this.button1sair.Click += new System.EventHandler(this.button1sair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "SISTEMA DE CALCULAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(266, 351);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1sair);
            this.Controls.Add(this.label2calc);
            this.Controls.Add(this.label1resul);
            this.Controls.Add(this.button1soma);
            this.Controls.Add(this.textBox2num2);
            this.Controls.Add(this.textBox1num1);
            this.Controls.Add(this.label2num2);
            this.Controls.Add(this.label1num1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1num1;
        private Label label2num2;
        private TextBox textBox1num1;
        private TextBox textBox2num2;
        private Button button1soma;
        private Label label1resul;
        private Label label2calc;
        private Button button1sair;
        private Label label1;
    }
}