using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Ecommerce.ViewModels
{
    public  class MainViewModel
    {

        #region Propiedades
        public ObservableCollection<MenuItemViewModel> Menu { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            Menu = new ObservableCollection<MenuItemViewModel>();
            LoadMenu();
        }
        #endregion

        #region Methodos
        private void LoadMenu()
        {
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_launcher_Gym.png",
                PageName = "Productos",
                Title = "Productos",

            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_launcher_Clientes.png",
                PageName = "Clientes",
                Title = "Clientes",

            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_launcher_Pedido.png",
                PageName = "Pedidos",
                Title = "Pedidos",

            });

            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_launcher_Configuraciones.png",
                PageName = "Configuraciones",
                Title = "Configuraciones",

            });
            Menu.Add(new MenuItemViewModel
            {
                Icon = "ic_launcher_Salir.png",
                PageName = "Salir",
                Title = "Salir",

            });


        }
        #endregion

    }
}
