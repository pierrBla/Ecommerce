using Ecommerce.Paginas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Servicios
{
    public class NavigationService
    {
        public async Task Navigate(string pageName)
        {
            App.Master.IsPresented = false;
            switch (pageName)
            {
                case "Productos":
                  await  App.Navigator.PushAsync(new Productos());
                    break;

                case "Clientes":
                    await App.Navigator.PushAsync(new Clientes());
                    break;

                case "Pedidos":
                    await App.Navigator.PushAsync(new Pedidos());
                    break;

                case "Configuraciones":
                    await App.Navigator.PushAsync(new Configuraciones());
                    break;

                case "UserPage":
                    await App.Navigator.PushAsync(new UserPage());
                    break;
                default:
                    break;
            }
        }

    }
}