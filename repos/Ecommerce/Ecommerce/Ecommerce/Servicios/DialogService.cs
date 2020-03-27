using System.Threading.Tasks;

namespace Ecommerce.Servicios
{
    public class DialogService
    {
        public async Task ShowMessage(string title,string message)
        {
        await App.Current.MainPage.DisplayAlert(title, message, "Aceptar");
        }
    }
}
