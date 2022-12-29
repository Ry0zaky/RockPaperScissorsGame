namespace RockPaperScissors1
{
    public partial class Form1 : Form
    {
        //Its constants for the different options
        const int ROCK = 1;
        const int PAPER = 2;
        const int SCISSORS = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //I Set the default selected option to rock
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //To get the player's choice
            int UserChoice;
            if (radioButton1.Checked)
            {
                UserChoice = ROCK;
            }
            else if (radioButton2.Checked)
            {
                UserChoice = PAPER;
            }
            else
            {
                UserChoice = SCISSORS;
            }

            //To Generate the bot's choice
            Random random = new Random();
            int BotChoice = random.Next(1, 4);

            //To display Bot choice
            switch(BotChoice)
            {
                case ROCK:
                    label2.Text = "Computer choosed Rock";
                    break;
                case PAPER:
                    label2.Text = "Computer choosed Paper";
                    break;
                default:
                    label2.Text = "Computer choosed Scissors";
                    break;
            }

            //To Determine the winner
            if (UserChoice == BotChoice)
            {
                label1.Text = "Draw!";
            }
            else if (UserChoice == ROCK && BotChoice == SCISSORS ||
                     UserChoice == PAPER && BotChoice == ROCK ||
                     UserChoice == SCISSORS && BotChoice == PAPER)
            {
                label1.Text = "You won!";
            }
            else
            {
                label1.Text = "Computer won!";
            }
        }
    }
}