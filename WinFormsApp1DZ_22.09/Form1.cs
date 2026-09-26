namespace WinFormsApp1DZ_22._09
{
    public partial class Form1 : Form
    {
        WeatherStacion weatherStation = new WeatherStacion();
        WeatherDisplay weatherDisplay = new WeatherDisplay();
        private BankAccount account;
        private BankClient client;
        public Form1()
        {
            InitializeComponent();
            client = new BankClient("Artem", label1);
            account = new BankAccount("123456987",1000);
            weatherStation.HumidityChanged += weatherDisplay.DisplayWeatherTemp;
            weatherStation.TemperatureChanged += weatherDisplay.DisplayWeatherHum;
            account.DepositEvent+=client.OnDeposit;
            account.WithdrawEvent+=client.OnWithdraw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            weatherStation.SetTemperature(25);
            label1.Text = ($"Temperature: {weatherStation.Temperature.ToString()} C");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            weatherStation.SetHumidity(50);
            label1.Text = ($"Humidity: {weatherStation.Humidity.ToString()} %");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            account.Deposit(500);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            account.Withdraw(500);
        }
    }
}
