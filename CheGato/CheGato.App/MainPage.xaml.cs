namespace CheGato.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCounterClicked(object sender, EventArgs e)
        {
            CounterBtn.Text = "Conectando a la API...";

            try
            {
                using HttpClient client = new HttpClient();
                string apiUrl = "https://localhost:7151/api/Conexion/ping";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    CounterBtn.Text = "¡API Conectada! 🐾";
                }
                else
                {
                    CounterBtn.Text = $"Error: {response.StatusCode}";
                }
            }
            catch (Exception ex)
            {
                CounterBtn.Text = "Error de red ❌";
                Console.WriteLine(ex.Message);
            }

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }
}