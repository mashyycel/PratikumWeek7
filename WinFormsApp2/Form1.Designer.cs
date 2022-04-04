
namespace WinFormsApp2
{
    partial class FormQuizPanda
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
            this.lblKalimat = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHasil = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtBoxKalimat = new System.Windows.Forms.TextBox();
            this.txtBoxHuruf = new System.Windows.Forms.TextBox();
            this.txtMenjadi = new System.Windows.Forms.TextBox();
            this.btnKonversi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKalimat
            // 
            this.lblKalimat.AutoSize = true;
            this.lblKalimat.Location = new System.Drawing.Point(29, 33);
            this.lblKalimat.Name = "lblKalimat";
            this.lblKalimat.Size = new System.Drawing.Size(132, 20);
            this.lblKalimat.TabIndex = 0;
            this.lblKalimat.Text = "Masukkan Kalimat:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Masukkan Huruf:";
            // 
            // lblHasil
            // 
            this.lblHasil.AutoSize = true;
            this.lblHasil.Location = new System.Drawing.Point(29, 207);
            this.lblHasil.Name = "lblHasil";
            this.lblHasil.Size = new System.Drawing.Size(45, 20);
            this.lblHasil.TabIndex = 2;
            this.lblHasil.Text = "Hasil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(415, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Menjadi:";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(179, 207);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(50, 20);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "label5";
            // 
            // txtBoxKalimat
            // 
            this.txtBoxKalimat.Location = new System.Drawing.Point(179, 30);
            this.txtBoxKalimat.Name = "txtBoxKalimat";
            this.txtBoxKalimat.Size = new System.Drawing.Size(523, 27);
            this.txtBoxKalimat.TabIndex = 5;
            // 
            // txtBoxHuruf
            // 
            this.txtBoxHuruf.Location = new System.Drawing.Point(179, 94);
            this.txtBoxHuruf.Name = "txtBoxHuruf";
            this.txtBoxHuruf.Size = new System.Drawing.Size(199, 27);
            this.txtBoxHuruf.TabIndex = 6;
            // 
            // txtMenjadi
            // 
            this.txtMenjadi.Location = new System.Drawing.Point(503, 97);
            this.txtMenjadi.Name = "txtMenjadi";
            this.txtMenjadi.Size = new System.Drawing.Size(199, 27);
            this.txtMenjadi.TabIndex = 7;
            // 
            // btnKonversi
            // 
            this.btnKonversi.Location = new System.Drawing.Point(179, 153);
            this.btnKonversi.Name = "btnKonversi";
            this.btnKonversi.Size = new System.Drawing.Size(523, 31);
            this.btnKonversi.TabIndex = 8;
            this.btnKonversi.Text = "Konversi";
            this.btnKonversi.UseVisualStyleBackColor = true;
            this.btnKonversi.Click += new System.EventHandler(this.btnKonversi_Click);
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKonversi);
            this.Controls.Add(this.txtMenjadi);
            this.Controls.Add(this.txtBoxHuruf);
            this.Controls.Add(this.txtBoxKalimat);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHasil);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblKalimat);
            this.Name = "FormQuizPanda";
            this.Text = "Form Quiz Panda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalimat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHasil;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtBoxKalimat;
        private System.Windows.Forms.TextBox txtBoxHuruf;
        private System.Windows.Forms.TextBox txtMenjadi;
        private System.Windows.Forms.Button btnKonversi;
    }
}

