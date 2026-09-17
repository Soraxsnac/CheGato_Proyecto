using CheGato.App.Models;
using System.Net.Http.Json;

namespace CheGato.App
{
    public partial class MainPage : ContentPage
    {
        private readonly HttpClient _client = new HttpClient();

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnCargarClicked(object sender, EventArgs e)
        {
            try
            {
                // Recuerda verificar si tu puerto de Swagger es 7151 u otro
                string apiUrl = "https://localhost:7151/api/Productos";
                var productos = await _client.GetFromJsonAsync<List<Producto>>(apiUrl);
                ListaProductos.ItemsSource = productos;
            }
            catch (Exception ex)
            {
                await DisplayAlertAsync("Error", $"No se pudo conectar a la API: {ex.Message}", "OK");
            }
        }
    }
}