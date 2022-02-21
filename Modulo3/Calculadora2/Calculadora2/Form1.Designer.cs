namespace Calculadora2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Labetxt1 = new System.Windows.Forms.TextBox();
            this.Labetxt2 = new System.Windows.Forms.TextBox();
            this.resultado = new System.Windows.Forms.Label();
            this.Labetxt3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(24, 29);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(66, 15);
            this.Label.TabIndex = 0;
            this.Label.Text = "Numero1";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(24, 89);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(66, 15);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Numero2";
            this.Label2.Click += new System.EventHandler(this.LabelNumero2_Click);
            // 
            // Labetxt1
            // 
            this.Labetxt1.Location = new System.Drawing.Point(140, 21);
            this.Labetxt1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Labetxt1.Name = "Labetxt1";
            this.Labetxt1.Size = new System.Drawing.Size(144, 21);
            this.Labetxt1.TabIndex = 2;
            // 
            // Labetxt2
            // 
            this.Labetxt2.Location = new System.Drawing.Point(140, 81);
            this.Labetxt2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Labetxt2.Name = "Labetxt2";
            this.Labetxt2.Size = new System.Drawing.Size(144, 21);
            this.Labetxt2.TabIndex = 3;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(17, 152);
            this.resultado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(72, 15);
            this.resultado.TabIndex = 4;
            this.resultado.Text = "Resultado";
            // 
            // Labetxt3
            // 
            this.Labetxt3.Location = new System.Drawing.Point(140, 152);
            this.Labetxt3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Labetxt3.Name = "Labetxt3";
            this.Labetxt3.Size = new System.Drawing.Size(144, 21);
            this.Labetxt3.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 215);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 40);
            this.button1.TabIndex = 6;
            this.button1.Text = "+ SUMAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(176, 215);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "- RESTA";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(21, 277);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "* MULTI";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(176, 277);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "/ DIVISION";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(339, 369);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Labetxt3);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.Labetxt2);
            this.Controls.Add(this.Labetxt1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Calculadora ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox Labetxt1;
        private System.Windows.Forms.TextBox Labetxt2;
        private System.Windows.Forms.Label resultado;
        private System.Windows.Forms.TextBox Labetxt3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

