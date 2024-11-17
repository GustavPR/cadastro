using EventoApp.Models;
using Microsoft.Maui.Controls;

namespace EventoApp
{
    public partial class ResumoPage : ContentPage
    {
        public ResumoPage(Evento evento)
        {
            InitializeComponent();

            // Exibir as informações do evento
            NomeLabel.Text = evento.Nome;
            DataInicioLabel.Text = evento.DataInicio.ToString("dd/MM/yyyy");
            DataTerminoLabel.Text = evento.DataTermino.ToString("dd/MM/yyyy");
            DuracaoLabel.Text = $"{evento.DuracaoEvento} dias"; // Usando a propriedade DuracaoEvento que é calculada
            NumeroParticipantesLabel.Text = evento.NumeroParticipantes.ToString();
            LocalLabel.Text = evento.Local;
            CustoLabel.Text = evento.CustoTotal.ToString("C"); // Formatando como moeda
        }

        private async void OnVoltarClicked(object sender, EventArgs e)
        {
            // Voltar para a página anterior
            await Navigation.PopAsync();
        }
    }
}
