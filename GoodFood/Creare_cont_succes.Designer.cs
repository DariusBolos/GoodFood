namespace GoodFood
{
    partial class Creare_cont_succes
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
            this.label_succes = new System.Windows.Forms.Label();
            this.button_succes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_succes
            // 
            this.label_succes.AutoSize = true;
            this.label_succes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_succes.Location = new System.Drawing.Point(268, 187);
            this.label_succes.Name = "label_succes";
            this.label_succes.Size = new System.Drawing.Size(254, 24);
            this.label_succes.TabIndex = 0;
            this.label_succes.Text = "Contul a fost creat cu succes!";
            // 
            // button_succes
            // 
            this.button_succes.BackColor = System.Drawing.Color.SkyBlue;
            this.button_succes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_succes.Location = new System.Drawing.Point(669, 392);
            this.button_succes.Name = "button_succes";
            this.button_succes.Size = new System.Drawing.Size(119, 46);
            this.button_succes.TabIndex = 1;
            this.button_succes.Text = "Autentificare";
            this.button_succes.UseVisualStyleBackColor = false;
            this.button_succes.Click += new System.EventHandler(this.button_succes_Click);
            // 
            // Creare_cont_succes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_succes);
            this.Controls.Add(this.label_succes);
            this.Name = "Creare_cont_succes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_succes;
        private System.Windows.Forms.Button button_succes;
    }
}