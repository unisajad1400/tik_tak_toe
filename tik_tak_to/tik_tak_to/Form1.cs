namespace tik_tak_to
{
    public partial class Form1 : Form
    {

        Button[,] dokmeha;
        int ply;
        public Form1()
        {
            InitializeComponent();

            ply = 1;

            dokmeha = new Button[3, 3] { {button1, button2, button3},
                                         {button4, button5, button6},
                                         {button7, button8, button9}};
            new_game();

            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                    dokmeha[i, j].Text = "";

                }

            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Button this_button = (sender as Button);

            if (this_button.Text == "")
            {
                if (ply == 1)
                {
                    this_button.Text = "X";
                    this_button.ForeColor = Color.Green;
                    this_button.BackColor = Color.LightGreen;
                    ply = 2;
                }
                else if (ply == 2)
                {
                    this_button.Text = "0";
                    this_button.ForeColor = Color.Red;
                    this_button.BackColor = Color.Pink;
                    ply = 1;
                }
            }
            check_game();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            new_game();

        }

        private void new_game()
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dokmeha[i, j].Text = "";
                    dokmeha[i, j].BackColor = Color.SkyBlue;
                }

            }
        }

        private void check_game()
        {
            int counOne = 0;
            int counTwo = 0;
            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[i, j].Text == "X")
                    {
                        counOne++;
                    }
                }
                if (counOne == 3)
                {
                    MessageBox.Show("بازیکن شماره 1 برنده است");
                }
                counOne = 0;
            }
        
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (dokmeha[j, i].Text == "X")
                    {
                        counTwo++;
                    }
                }
                if (counTwo == 3)
                {
                    MessageBox.Show("بازیکن شماره 1 برنده است");
                }
                counTwo = 0;
            }
               
        }
    }
}   