namespace WindowsTimer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            decimal seconds = numericUpDown1.Value * 3600 + numericUpDown2.Value * 60 + numericUpDown3.Value;

            if (seconds > 0)
            {
                string command = $"shutdown /s /t {seconds}";

                cmd_settings.ExecuteCommand(command);
                MessageBox.Show($"Таймер вимкнення встановлений на {seconds} секунд.");
            }
            else
            {
                MessageBox.Show("Некоректне значення. Спробуйте ще раз.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string command = $"shutdown /a";
            cmd_settings.ExecuteCommand(command);
            MessageBox.Show("Таймер скасовано");
        }
    }
}
