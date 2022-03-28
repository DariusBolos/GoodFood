
namespace GoodFood
{
    partial class Autentificare_clienti
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
            this.label_email = new System.Windows.Forms.Label();
            this.label_parola = new System.Windows.Forms.Label();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.btn_autentificare = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_email
            // 
            this.label_email.AutoSize = true;
            this.label_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_email.Location = new System.Drawing.Point(122, 100);
            this.label_email.Name = "label_email";
            this.label_email.Size = new System.Drawing.Size(96, 15);
            this.label_email.TabIndex = 0;
            this.label_email.Text = "Adresa de email";
            // 
            // label_parola
            // 
            this.label_parola.AutoSize = true;
            this.label_parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_parola.Location = new System.Drawing.Point(122, 186);
            this.label_parola.Name = "label_parola";
            this.label_parola.Size = new System.Drawing.Size(43, 15);
            this.label_parola.TabIndex = 1;
            this.label_parola.Text = "Parola";
            // 
            // textBox_email
            // 
            this.textBox_email.Location = new System.Drawing.Point(256, 99);
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(173, 20);
            this.textBox_email.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(256, 185);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(173, 20);
            this.textBox_password.TabIndex = 3;
            // 
            // btn_autentificare
            // 
            this.btn_autentificare.Location = new System.Drawing.Point(681, 408);
            this.btn_autentificare.Name = "btn_autentificare";
            this.btn_autentificare.Size = new System.Drawing.Size(107, 30);
            this.btn_autentificare.TabIndex = 4;
            this.btn_autentificare.Text = "Intra in cont";
            this.btn_autentificare.UseVisualStyleBackColor = true;
            this.btn_autentificare.Click += new System.EventHandler(this.btn_autentificare_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 408);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(107, 30);
            this.btn_back.TabIndex = 5;
            this.btn_back.Text = "Inapoi";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Autentificare_clienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_autentificare);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.label_parola);
            this.Controls.Add(this.label_email);
            this.Name = "Autentificare_clienti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_email;
        private System.Windows.Forms.Label label_parola;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button btn_autentificare;
        private System.Windows.Forms.Button btn_back;
    }
}