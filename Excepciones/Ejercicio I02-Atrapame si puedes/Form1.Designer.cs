
namespace Ejercicio_I02_Atrapame_si_puedes
{
    partial class form_Calculador
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
            this.lbl_Kilometros = new System.Windows.Forms.Label();
            this.lbl_Litros = new System.Windows.Forms.Label();
            this.txt_Kilometros = new System.Windows.Forms.TextBox();
            this.txt_Litros = new System.Windows.Forms.TextBox();
            this.btn_Calcular = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbl_Kilometros
            // 
            this.lbl_Kilometros.AutoSize = true;
            this.lbl_Kilometros.Location = new System.Drawing.Point(12, 9);
            this.lbl_Kilometros.Name = "lbl_Kilometros";
            this.lbl_Kilometros.Size = new System.Drawing.Size(64, 15);
            this.lbl_Kilometros.TabIndex = 0;
            this.lbl_Kilometros.Text = "Kilometros";
            // 
            // lbl_Litros
            // 
            this.lbl_Litros.AutoSize = true;
            this.lbl_Litros.Location = new System.Drawing.Point(12, 63);
            this.lbl_Litros.Name = "lbl_Litros";
            this.lbl_Litros.Size = new System.Drawing.Size(36, 15);
            this.lbl_Litros.TabIndex = 1;
            this.lbl_Litros.Text = "Litros";
            // 
            // txt_Kilometros
            // 
            this.txt_Kilometros.Location = new System.Drawing.Point(12, 27);
            this.txt_Kilometros.Name = "txt_Kilometros";
            this.txt_Kilometros.Size = new System.Drawing.Size(146, 23);
            this.txt_Kilometros.TabIndex = 2;
            // 
            // txt_Litros
            // 
            this.txt_Litros.Location = new System.Drawing.Point(12, 81);
            this.txt_Litros.Name = "txt_Litros";
            this.txt_Litros.Size = new System.Drawing.Size(146, 23);
            this.txt_Litros.TabIndex = 3;
            // 
            // btn_Calcular
            // 
            this.btn_Calcular.Location = new System.Drawing.Point(12, 128);
            this.btn_Calcular.Name = "btn_Calcular";
            this.btn_Calcular.Size = new System.Drawing.Size(146, 23);
            this.btn_Calcular.TabIndex = 4;
            this.btn_Calcular.Text = "Calcular";
            this.btn_Calcular.UseVisualStyleBackColor = true;
            this.btn_Calcular.Click += new System.EventHandler(this.btn_Calcular_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(210, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(162, 139);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // form_Calculador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 163);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btn_Calcular);
            this.Controls.Add(this.txt_Litros);
            this.Controls.Add(this.txt_Kilometros);
            this.Controls.Add(this.lbl_Litros);
            this.Controls.Add(this.lbl_Kilometros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_Calculador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Kilometros;
        private System.Windows.Forms.Label lbl_Litros;
        private System.Windows.Forms.TextBox txt_Kilometros;
        private System.Windows.Forms.TextBox txt_Litros;
        private System.Windows.Forms.Button btn_Calcular;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

