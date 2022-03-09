
namespace GoodFood
{
    partial class Optiuni
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.calculator_kcal = new System.Windows.Forms.TabPage();
            this.label_kcal = new System.Windows.Forms.Label();
            this.label_info = new System.Windows.Forms.Label();
            this.btn_calculeaza = new System.Windows.Forms.Button();
            this.textBox_inaltime = new System.Windows.Forms.TextBox();
            this.textBox_greutate = new System.Windows.Forms.TextBox();
            this.label_greutate = new System.Windows.Forms.Label();
            this.label_inaltime = new System.Windows.Forms.Label();
            this.label_varsta = new System.Windows.Forms.Label();
            this.textBox_varsta = new System.Windows.Forms.TextBox();
            this.comanda = new System.Windows.Forms.TabPage();
            this.generare_meniu = new System.Windows.Forms.TabPage();
            this.grafic_kcal = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.calculator_kcal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.calculator_kcal);
            this.tabControl1.Controls.Add(this.comanda);
            this.tabControl1.Controls.Add(this.generare_meniu);
            this.tabControl1.Controls.Add(this.grafic_kcal);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 455);
            this.tabControl1.TabIndex = 0;
            // 
            // calculator_kcal
            // 
            this.calculator_kcal.BackColor = System.Drawing.Color.Silver;
            this.calculator_kcal.Controls.Add(this.label_kcal);
            this.calculator_kcal.Controls.Add(this.label_info);
            this.calculator_kcal.Controls.Add(this.btn_calculeaza);
            this.calculator_kcal.Controls.Add(this.textBox_inaltime);
            this.calculator_kcal.Controls.Add(this.textBox_greutate);
            this.calculator_kcal.Controls.Add(this.label_greutate);
            this.calculator_kcal.Controls.Add(this.label_inaltime);
            this.calculator_kcal.Controls.Add(this.label_varsta);
            this.calculator_kcal.Controls.Add(this.textBox_varsta);
            this.calculator_kcal.Location = new System.Drawing.Point(4, 22);
            this.calculator_kcal.Name = "calculator_kcal";
            this.calculator_kcal.Padding = new System.Windows.Forms.Padding(3);
            this.calculator_kcal.Size = new System.Drawing.Size(797, 429);
            this.calculator_kcal.TabIndex = 0;
            this.calculator_kcal.Text = "CalculatorKcal";
            // 
            // label_kcal
            // 
            this.label_kcal.AutoSize = true;
            this.label_kcal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_kcal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kcal.Location = new System.Drawing.Point(272, 281);
            this.label_kcal.Name = "label_kcal";
            this.label_kcal.Size = new System.Drawing.Size(2, 18);
            this.label_kcal.TabIndex = 8;
            // 
            // label_info
            // 
            this.label_info.AutoSize = true;
            this.label_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_info.Location = new System.Drawing.Point(147, 281);
            this.label_info.Name = "label_info";
            this.label_info.Size = new System.Drawing.Size(92, 16);
            this.label_info.TabIndex = 7;
            this.label_info.Text = "Necesar zilnic";
            // 
            // btn_calculeaza
            // 
            this.btn_calculeaza.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_calculeaza.Location = new System.Drawing.Point(684, 371);
            this.btn_calculeaza.Name = "btn_calculeaza";
            this.btn_calculeaza.Size = new System.Drawing.Size(100, 45);
            this.btn_calculeaza.TabIndex = 6;
            this.btn_calculeaza.Text = "Calculeaza";
            this.btn_calculeaza.UseVisualStyleBackColor = false;
            this.btn_calculeaza.Click += new System.EventHandler(this.btn_calculeaza_Click);
            // 
            // textBox_inaltime
            // 
            this.textBox_inaltime.Location = new System.Drawing.Point(275, 133);
            this.textBox_inaltime.Name = "textBox_inaltime";
            this.textBox_inaltime.Size = new System.Drawing.Size(128, 20);
            this.textBox_inaltime.TabIndex = 5;
            // 
            // textBox_greutate
            // 
            this.textBox_greutate.Location = new System.Drawing.Point(275, 170);
            this.textBox_greutate.Name = "textBox_greutate";
            this.textBox_greutate.Size = new System.Drawing.Size(128, 20);
            this.textBox_greutate.TabIndex = 4;
            // 
            // label_greutate
            // 
            this.label_greutate.AutoSize = true;
            this.label_greutate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_greutate.Location = new System.Drawing.Point(147, 171);
            this.label_greutate.Name = "label_greutate";
            this.label_greutate.Size = new System.Drawing.Size(85, 16);
            this.label_greutate.TabIndex = 3;
            this.label_greutate.Text = "Greutate (kg)";
            // 
            // label_inaltime
            // 
            this.label_inaltime.AutoSize = true;
            this.label_inaltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_inaltime.Location = new System.Drawing.Point(147, 134);
            this.label_inaltime.Name = "label_inaltime";
            this.label_inaltime.Size = new System.Drawing.Size(83, 16);
            this.label_inaltime.TabIndex = 2;
            this.label_inaltime.Text = "Inaltime (cm)";
            // 
            // label_varsta
            // 
            this.label_varsta.AutoSize = true;
            this.label_varsta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_varsta.Location = new System.Drawing.Point(147, 100);
            this.label_varsta.Name = "label_varsta";
            this.label_varsta.Size = new System.Drawing.Size(76, 16);
            this.label_varsta.TabIndex = 1;
            this.label_varsta.Text = "Varsta (ani)";
            // 
            // textBox_varsta
            // 
            this.textBox_varsta.Location = new System.Drawing.Point(275, 99);
            this.textBox_varsta.Name = "textBox_varsta";
            this.textBox_varsta.Size = new System.Drawing.Size(128, 20);
            this.textBox_varsta.TabIndex = 0;
            // 
            // comanda
            // 
            this.comanda.BackColor = System.Drawing.Color.Silver;
            this.comanda.Location = new System.Drawing.Point(4, 22);
            this.comanda.Name = "comanda";
            this.comanda.Padding = new System.Windows.Forms.Padding(3);
            this.comanda.Size = new System.Drawing.Size(797, 429);
            this.comanda.TabIndex = 1;
            this.comanda.Text = "Comanda";
            // 
            // generare_meniu
            // 
            this.generare_meniu.BackColor = System.Drawing.Color.Silver;
            this.generare_meniu.Location = new System.Drawing.Point(4, 22);
            this.generare_meniu.Name = "generare_meniu";
            this.generare_meniu.Size = new System.Drawing.Size(797, 429);
            this.generare_meniu.TabIndex = 2;
            this.generare_meniu.Text = "Generare Meniu";
            // 
            // grafic_kcal
            // 
            this.grafic_kcal.BackColor = System.Drawing.Color.Silver;
            this.grafic_kcal.Location = new System.Drawing.Point(4, 22);
            this.grafic_kcal.Name = "grafic_kcal";
            this.grafic_kcal.Size = new System.Drawing.Size(797, 429);
            this.grafic_kcal.TabIndex = 3;
            this.grafic_kcal.Text = "Grafic Kcal";
            // 
            // Optiuni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Optiuni";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.calculator_kcal.ResumeLayout(false);
            this.calculator_kcal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage calculator_kcal;
        private System.Windows.Forms.TabPage comanda;
        private System.Windows.Forms.TabPage generare_meniu;
        private System.Windows.Forms.TabPage grafic_kcal;
        private System.Windows.Forms.Button btn_calculeaza;
        private System.Windows.Forms.TextBox textBox_inaltime;
        private System.Windows.Forms.TextBox textBox_greutate;
        private System.Windows.Forms.Label label_greutate;
        private System.Windows.Forms.Label label_inaltime;
        private System.Windows.Forms.Label label_varsta;
        private System.Windows.Forms.TextBox textBox_varsta;
        private System.Windows.Forms.Label label_info;
        private System.Windows.Forms.Label label_kcal;
    }
}