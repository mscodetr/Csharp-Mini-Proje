namespace Dikdortgen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton_alan_CheckedChanged(object sender, EventArgs e)
        {
            int alan;
            alan = Convert.ToInt32(textBox_kisa.Text) * Convert.ToInt32(textBox_uzun.Text);
            if (radioButton_alan.Checked)
            {
                label_sonuc.Text = Convert.ToString(alan);
            }
        }

        private void radioButton_cevre_CheckedChanged(object sender, EventArgs e)
        {
            int cevre;
            cevre = Convert.ToInt32(textBox_kisa.Text) * 2 + Convert.ToInt32(textBox_uzun.Text) * 2;

            if (radioButton_cevre.Checked)
            {
                label_sonuc.Text = Convert.ToString(cevre);
            }
        }
    }
}
