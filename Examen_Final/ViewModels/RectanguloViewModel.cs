using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Windows.Devices.Radios;

namespace Examen_Final.ViewModels
{
    public partial class RectanguloViewModel : ObservableObject
    {
        [ObservableProperty]
        private double baser;

        [ObservableProperty]
        private double altura;

        [ObservableProperty]
        private double resultado;
        [RelayCommand]
        private void Ejecutar()
        {
            try
            {
                if (Baser == 0 || Altura==0 )
                {
                    if (Baser == 0)
                    {
                        Application.Current.MainPage.DisplayAlert("Campo Vacío", $"El campo '{Baser}' no puede estar vacío.", "OK");
                    }
                    if (Altura==0)
                    {
                        Application.Current.MainPage.DisplayAlert("Campo Vacío", $"El campo '{Altura}' no puede estar vacío.", "OK");
                    }
                   
                }
                else
                {
                    Resultado = Baser*Altura;
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
            Baser=Altura = Resultado = 0;
        }
    }
}

