using EventoApp.Models;
using Microsoft.Maui.Controls;

namespace EventoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Método para capturar os dados do formulário e criar um novo evento
        private void OnCadastrarEventoClicked(object sender, EventArgs e)
        {
            // Verificando se os campos obrigatórios estão preenchidos e se a data de término é posterior à de início
            if (string.IsNullOrWhiteSpace(NomeEntry.Text) ||
                DataInicioPicker.Date > DataTerminoPicker.Date ||
                string.IsNullOrWhiteSpace(NumeroParticipantesEntry.Text) ||
                string.IsNullOrWhiteSpace(CustoEntry.Text) ||
                string.IsNullOrWhiteSpace(LocalEntry.Text))
            {
                // Exibir uma mensagem de erro se algum campo estiver vazio ou se a data de término for inválida
                DisplayAlert("Erro", "Por favor, preencha todos os campos corretamente.", "OK");
                return;
            }

            // Validar se os valores numéricos são válidos
            if (!int.TryParse(NumeroParticipantesEntry.Text, out int numeroParticipantes))
            {
                DisplayAlert("Erro", "Número de participantes inválido.", "OK");
                return;
            }

            if (!decimal.TryParse(CustoEntry.Text, out decimal custoPorParticipante))
            {
                DisplayAlert("Erro", "Custo por participante inválido.", "OK");
                return;
            }

            // Criando o objeto Evento com os dados da interface
            var evento = new Evento
            {
                Nome = NomeEntry.Text,
                DataInicio = DataInicioPicker.Date,
                DataTermino = DataTerminoPicker.Date,
                NumeroParticipantes = numeroParticipantes,
                Local = LocalEntry.Text,
                CustoPorParticipante = custoPorParticipante
            };

            // Navegar para a página de resumo passando o evento
            Navigation.PushAsync(new ResumoPage(evento));
        }
    }
}







