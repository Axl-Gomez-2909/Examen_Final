using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Examen_Final.ViewModels
{
    public partial class CirculoViewModel : ObservableObject
    {
        public const double PI = 3.1415926535897931;
        [ObservableProperty]
        private double radio;

        [ObservableProperty]
        private double resultado;
        [RelayCommand]
        private void Calcular()
        {
            try
            {
                if (Radio==0)
                {
                    Application.Current.MainPage.DisplayAlert("Campo Vacío", $"El campo '{Radio}' no puede estar vacío.", "OK");
                }
                else
                {
                    Resultado = PI * Math.Pow(Radio, 2);
                }
                

            }
            catch (Exception ex)
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert("ERROR", ex.Message, "Aceptar"));
            }
        }

        [RelayCommand]
        private void Limpiar()
        {
            Radio = Resultado = 0;
        }
    }
}
