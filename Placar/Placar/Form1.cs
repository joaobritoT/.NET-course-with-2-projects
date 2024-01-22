namespace Placar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
      
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_mais_corinthians_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_placar_corinthians.Text);
            score++;
            lbl_placar_corinthians.Text = score.ToString();
        }

        private void btn_menos_corinthians_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_placar_corinthians.Text);
            if (score != 0)
            {
                score--;
                lbl_placar_corinthians.Text = score.ToString();
            }

        }

        private void btn_mais_palmeiras_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_placar_palmeiras.Text);
            score++;
            lbl_placar_palmeiras.Text = score.ToString();
        }

        private void btn_menos_palmeiras_Click(object sender, EventArgs e)
        {
            int score = int.Parse(lbl_placar_palmeiras.Text);
            if (score != 0)
            {
                score--;
                lbl_placar_palmeiras.Text = score.ToString();
            }

        }
        int min = 89, seg = 55;
        private void cronometro_Tick(object sender, EventArgs e)
        {
            string texto = "";
            if (min < 10)
            {
                texto += "0" + min;
            }
            else
            {
                texto += min;
            }

            if (seg < 10)
            {
                texto += ":0" + seg;
            }
            else
            {
                texto += ":" + seg;
            }
            lbl_cronometro.Text = texto;
            seg++;
            if (seg == 60)
            {
                min++;
                seg = 0;
            }
            if ((min == 45 && seg == 1) || (min == 90 && seg == 1))
            {
                cronometro.Enabled = false;

            }
            if (min >= 45 && seg > 0)
            {
                lbl_parte_do_jogo.Text = "Segundo Tempo";
            }
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            if(min == 90 && seg == 1)
            {
                min = 0;
                seg = 0;
                lbl_placar_corinthians.Text = "0";
                lbl_placar_palmeiras.Text = "0";

            }
            if (min >= 45 && seg > 0)
            {
                lbl_parte_do_jogo.Text = "Segundo Tempo";
            }
            else
            {
                lbl_parte_do_jogo.Text = "Primeiro Tempo";
            }
            if (cronometro.Enabled == true)
            {
                cronometro.Enabled = false;
                DesativarBotoes();
            }
            else
            {
                cronometro.Enabled = true;
                AtivarBotoes();
            }
            

        }

        private void AtivarBotoes()
        {
            btn_mais_corinthians.Enabled = true;
            btn_menos_corinthians.Enabled = true;
            btn_mais_palmeiras.Enabled = true;
            btn_menos_palmeiras.Enabled = true;
        }
        private void DesativarBotoes()
        {
            btn_mais_corinthians.Enabled = false;
            btn_menos_corinthians.Enabled = false;
            btn_mais_palmeiras.Enabled = false;
            btn_menos_palmeiras.Enabled = false;
        }
    }
}
