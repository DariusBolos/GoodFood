namespace GoodFood
{
    partial class Start
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
            this.btn_inregistrare = new System.Windows.Forms.Button();
            this.btn_autentificare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_inregistrare
            // 
            this.btn_inregistrare.Location = new System.Drawing.Point(12, 401);
            this.btn_inregistrare.Name = "btn_inregistrare";
            this.btn_inregistrare.Size = new System.Drawing.Size(97, 37);
            this.btn_inregistrare.TabIndex = 0;
            this.btn_inregistrare.Text = "Inregistrare";
            this.btn_inregistrare.UseVisualStyleBackColor = true;
            this.btn_inregistrare.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_autentificare
            // 
            this.btn_autentificare.Location = new System.Drawing.Point(687, 401);
            this.btn_autentificare.Name = "btn_autentificare";
            this.btn_autentificare.Size = new System.Drawing.Size(101, 37);
            this.btn_autentificare.TabIndex = 1;
            this.btn_autentificare.Text = "Autentificare";
            this.btn_autentificare.UseVisualStyleBackColor = true;
            this.btn_autentificare.Click += new System.EventHandler(this.btn_autentificare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(500, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cea mai buna varietate de mancare gatita pe care o veti gasi!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodFood.Properties.Resources.good_food_3;
            this.pictureBox1.Location = new System.Drawing.Point(219, 129);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(357, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_autentificare);
            this.Controls.Add(this.btn_inregistrare);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inregistrare;
        private System.Windows.Forms.Button btn_autentificare;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

