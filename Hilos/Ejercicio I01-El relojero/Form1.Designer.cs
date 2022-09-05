
namespace Ejercicio_I01_El_relojero
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_Hora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_DetenerReloj = new System.Windows.Forms.Button();
            this.btn_IniciarReloj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(49, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(627, 332);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // lbl_Hora
            // 
            this.lbl_Hora.AutoSize = true;
            this.lbl_Hora.Location = new System.Drawing.Point(49, 22);
            this.lbl_Hora.Name = "lbl_Hora";
            this.lbl_Hora.Size = new System.Drawing.Size(0, 15);
            this.lbl_Hora.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // btn_DetenerReloj
            // 
            this.btn_DetenerReloj.Location = new System.Drawing.Point(576, 12);
            this.btn_DetenerReloj.Name = "btn_DetenerReloj";
            this.btn_DetenerReloj.Size = new System.Drawing.Size(145, 23);
            this.btn_DetenerReloj.TabIndex = 2;
            this.btn_DetenerReloj.Text = "Detener Reloj";
            this.btn_DetenerReloj.UseVisualStyleBackColor = true;
            this.btn_DetenerReloj.Click += new System.EventHandler(this.btn_DetenerReloj_Click);
            // 
            // btn_IniciarReloj
            // 
            this.btn_IniciarReloj.Location = new System.Drawing.Point(425, 12);
            this.btn_IniciarReloj.Name = "btn_IniciarReloj";
            this.btn_IniciarReloj.Size = new System.Drawing.Size(145, 23);
            this.btn_IniciarReloj.TabIndex = 3;
            this.btn_IniciarReloj.Text = "Iniciar Reloj";
            this.btn_IniciarReloj.UseVisualStyleBackColor = true;
            this.btn_IniciarReloj.Click += new System.EventHandler(this.btn_IniciarReloj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 442);
            this.Controls.Add(this.btn_IniciarReloj);
            this.Controls.Add(this.btn_DetenerReloj);
            this.Controls.Add(this.lbl_Hora);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lbl_Hora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_DetenerReloj;
        private System.Windows.Forms.Button btn_IniciarReloj;
    }
}

