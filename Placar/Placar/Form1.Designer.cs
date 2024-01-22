namespace Placar
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pb_corinthians = new PictureBox();
            pb_palmeiras = new PictureBox();
            lbl_cronometro = new Label();
            lbl_corinthians = new Label();
            lbl_palmeiras = new Label();
            lbl_placar_corinthians = new Label();
            lbl_placar_palmeiras = new Label();
            btn_mais_corinthians = new Button();
            btn_menos_corinthians = new Button();
            btn_mais_palmeiras = new Button();
            btn_menos_palmeiras = new Button();
            cronometro = new System.Windows.Forms.Timer(components);
            lbl_parte_do_jogo = new Label();
            btn_start = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_corinthians).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_palmeiras).BeginInit();
            SuspendLayout();
            // 
            // pb_corinthians
            // 
            pb_corinthians.Image = (Image)resources.GetObject("pb_corinthians.Image");
            pb_corinthians.Location = new Point(62, 12);
            pb_corinthians.Name = "pb_corinthians";
            pb_corinthians.Size = new Size(171, 171);
            pb_corinthians.SizeMode = PictureBoxSizeMode.Zoom;
            pb_corinthians.TabIndex = 0;
            pb_corinthians.TabStop = false;
            pb_corinthians.Click += pictureBox1_Click;
            // 
            // pb_palmeiras
            // 
            pb_palmeiras.Image = (Image)resources.GetObject("pb_palmeiras.Image");
            pb_palmeiras.Location = new Point(561, 12);
            pb_palmeiras.Name = "pb_palmeiras";
            pb_palmeiras.Size = new Size(171, 171);
            pb_palmeiras.SizeMode = PictureBoxSizeMode.Zoom;
            pb_palmeiras.TabIndex = 1;
            pb_palmeiras.TabStop = false;
            // 
            // lbl_cronometro
            // 
            lbl_cronometro.AutoSize = true;
            lbl_cronometro.Font = new Font("Segoe UI", 40F);
            lbl_cronometro.Location = new Point(317, 60);
            lbl_cronometro.Name = "lbl_cronometro";
            lbl_cronometro.Size = new Size(158, 72);
            lbl_cronometro.TabIndex = 2;
            lbl_cronometro.Text = "00:00";
            // 
            // lbl_corinthians
            // 
            lbl_corinthians.AutoSize = true;
            lbl_corinthians.Font = new Font("Segoe UI", 12F);
            lbl_corinthians.Location = new Point(93, 231);
            lbl_corinthians.Name = "lbl_corinthians";
            lbl_corinthians.Size = new Size(90, 21);
            lbl_corinthians.TabIndex = 3;
            lbl_corinthians.Text = "Corinthians";
            // 
            // lbl_palmeiras
            // 
            lbl_palmeiras.AutoSize = true;
            lbl_palmeiras.Font = new Font("Segoe UI", 12F);
            lbl_palmeiras.Location = new Point(620, 231);
            lbl_palmeiras.Name = "lbl_palmeiras";
            lbl_palmeiras.Size = new Size(77, 21);
            lbl_palmeiras.TabIndex = 4;
            lbl_palmeiras.Text = "Palmeiras";
            // 
            // lbl_placar_corinthians
            // 
            lbl_placar_corinthians.AutoSize = true;
            lbl_placar_corinthians.BackColor = Color.White;
            lbl_placar_corinthians.Font = new Font("Segoe UI", 12F);
            lbl_placar_corinthians.Location = new Point(126, 275);
            lbl_placar_corinthians.Name = "lbl_placar_corinthians";
            lbl_placar_corinthians.Size = new Size(19, 21);
            lbl_placar_corinthians.TabIndex = 5;
            lbl_placar_corinthians.Text = "1";
            // 
            // lbl_placar_palmeiras
            // 
            lbl_placar_palmeiras.AutoSize = true;
            lbl_placar_palmeiras.BackColor = Color.White;
            lbl_placar_palmeiras.Font = new Font("Segoe UI", 12F);
            lbl_placar_palmeiras.Location = new Point(642, 275);
            lbl_placar_palmeiras.Name = "lbl_placar_palmeiras";
            lbl_placar_palmeiras.Size = new Size(19, 21);
            lbl_placar_palmeiras.TabIndex = 6;
            lbl_placar_palmeiras.Text = "0";
            // 
            // btn_mais_corinthians
            // 
            btn_mais_corinthians.Enabled = false;
            btn_mais_corinthians.Location = new Point(93, 326);
            btn_mais_corinthians.Name = "btn_mais_corinthians";
            btn_mais_corinthians.Size = new Size(30, 30);
            btn_mais_corinthians.TabIndex = 7;
            btn_mais_corinthians.Text = "+";
            btn_mais_corinthians.UseVisualStyleBackColor = true;
            btn_mais_corinthians.Click += btn_mais_corinthians_Click;
            // 
            // btn_menos_corinthians
            // 
            btn_menos_corinthians.Enabled = false;
            btn_menos_corinthians.Location = new Point(139, 326);
            btn_menos_corinthians.Name = "btn_menos_corinthians";
            btn_menos_corinthians.Size = new Size(30, 30);
            btn_menos_corinthians.TabIndex = 8;
            btn_menos_corinthians.Text = "-";
            btn_menos_corinthians.UseVisualStyleBackColor = true;
            btn_menos_corinthians.Click += btn_menos_corinthians_Click;
            // 
            // btn_mais_palmeiras
            // 
            btn_mais_palmeiras.Enabled = false;
            btn_mais_palmeiras.Location = new Point(620, 326);
            btn_mais_palmeiras.Name = "btn_mais_palmeiras";
            btn_mais_palmeiras.Size = new Size(30, 30);
            btn_mais_palmeiras.TabIndex = 9;
            btn_mais_palmeiras.Text = "+";
            btn_mais_palmeiras.UseVisualStyleBackColor = true;
            btn_mais_palmeiras.Click += btn_mais_palmeiras_Click;
            // 
            // btn_menos_palmeiras
            // 
            btn_menos_palmeiras.Enabled = false;
            btn_menos_palmeiras.Location = new Point(667, 326);
            btn_menos_palmeiras.Name = "btn_menos_palmeiras";
            btn_menos_palmeiras.Size = new Size(30, 30);
            btn_menos_palmeiras.TabIndex = 10;
            btn_menos_palmeiras.Text = "-";
            btn_menos_palmeiras.UseVisualStyleBackColor = true;
            btn_menos_palmeiras.Click += btn_menos_palmeiras_Click;
            // 
            // cronometro
            // 
            cronometro.Interval = 1000;
            cronometro.Tick += cronometro_Tick;
            // 
            // lbl_parte_do_jogo
            // 
            lbl_parte_do_jogo.AutoSize = true;
            lbl_parte_do_jogo.Font = new Font("Segoe UI", 25F);
            lbl_parte_do_jogo.Location = new Point(271, 168);
            lbl_parte_do_jogo.Name = "lbl_parte_do_jogo";
            lbl_parte_do_jogo.Size = new Size(257, 46);
            lbl_parte_do_jogo.TabIndex = 11;
            lbl_parte_do_jogo.Text = "Primeiro Tempo";
            // 
            // btn_start
            // 
            btn_start.Location = new Point(327, 232);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(116, 23);
            btn_start.TabIndex = 12;
            btn_start.Text = "Iniciar/Parar";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 403);
            Controls.Add(btn_start);
            Controls.Add(lbl_parte_do_jogo);
            Controls.Add(btn_menos_palmeiras);
            Controls.Add(btn_mais_palmeiras);
            Controls.Add(btn_menos_corinthians);
            Controls.Add(btn_mais_corinthians);
            Controls.Add(lbl_placar_palmeiras);
            Controls.Add(lbl_placar_corinthians);
            Controls.Add(lbl_palmeiras);
            Controls.Add(lbl_corinthians);
            Controls.Add(lbl_cronometro);
            Controls.Add(pb_palmeiras);
            Controls.Add(pb_corinthians);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pb_corinthians).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_palmeiras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pb_corinthians;
        private PictureBox pb_palmeiras;
        private Label lbl_cronometro;
        private Label lbl_corinthians;
        private Label lbl_palmeiras;
        private Label lbl_placar_corinthians;
        private Label lbl_placar_palmeiras;
        private Button btn_mais_corinthians;
        private Button btn_menos_corinthians;
        private Button btn_mais_palmeiras;
        private Button btn_menos_palmeiras;
        private System.Windows.Forms.Timer cronometro;
        private Label lbl_parte_do_jogo;
        private Button btn_start;
    }
}
