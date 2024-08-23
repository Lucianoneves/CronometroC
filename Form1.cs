
namespace CronometroC_;

    public partial class Form1 : Form
    {
        int time = 0;
        int minuto = 0;
        int segundo = 0;
        bool isContdown = false;
       
        private readonly object textBox1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            timer1.Interval = 1000;
           
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)

        {
            pictureBox1.Visible = false;
         

            if (int.TryParse(textBox1.Text, out time) && time > 0)
            {

                if (label3.Text == "00:00")
                {
                    if (time >= 60)
                    {
                        minuto = time / 60;
                        segundo = time % 60;

                    }
                    else
                    {
                        minuto = 0;
                        segundo = time;
                    }

                     label3.Text = String.Format("{0:00}:{1:00}", minuto, segundo);
                timer1.Enabled = true;
                 
            }
                timer1.Enabled = true;
            }
            else if(isContdown)
            {

                MessageBox.Show(" Por favor insira um número válido maior que zero", " Entrada Inválida! ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else 
        {
            timer1.Start();
        }

        }


    private void Stopwatch()
    {
        throw new NotImplementedException();
    }

    private void timer1_Tick(object sender, EventArgs e)
        {

      
            segundo--;

            if (minuto > 0 && segundo < 0)
            {

                segundo = 59;
                minuto--;
            }

            label3.Text = String.Format("{0:00}:{1:00}", minuto, segundo);
          

            if (minuto == 0 && segundo == 0)
            {
                timer1.Stop();
                pictureBox1.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
          



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();          
            minuto = 0;
            segundo = 0;
            label3.Text = "00:00";
            textBox1.Text = "";
            pictureBox1.Visible = false;
         
        }

        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            timer1.Stop();
          
            minuto = 0;
            segundo = 0;
            time = 0;
            label3.Text = "00:00";
            textBox1.Text = "";
            pictureBox1.Visible = false;
        

    }

     
    }


