namespace en
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruno = 0, dogru = 0, yanlis = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = false;

            soruno++;
            label4.Text = soruno.ToString();

            if (soruno == 1)
            {

                richTextBox1.Text = "Cumhuriyet ka� y�l�nda ilan edilmi�tir?";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1922";
                button4.Text = "1923";
                label7.Text = "1923";
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Hangi il Ege B�lgemizde bulunmaz?";
                button1.Text = "�zmir";
                button2.Text = "Bal�kesir";
                button3.Text = "Ayd�n";
                button4.Text = "Manisa";
                label7.Text = "Bal�kesir";
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Son Ku�lar kitab� hangi yazar�m�za aittir?";
                button1.Text = "Sait Faik Abas�yan�k";
                button2.Text = "Cemal S�reya";
                button3.Text = "Atilla �lhan";
                button4.Text = "Re�at Nuri G�ltekin";
                label7.Text = "Sait Faik Abas�yan�k";
                button5.Text = "Sonu�lar";
            }
            if (soruno == 4)
            {
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;

                MessageBox.Show("Do�ru:" + dogru + " \n " + "Yanl��:" + yanlis);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button1.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button2.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button3.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;

            label8.Text = button4.Text;
            if (label7.Text == label8.Text)
            {
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
            }
        }
    }
}
