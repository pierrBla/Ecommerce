using Ecommerce.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure
{

    
   public class InstanceLocator
    {
        public MainViewModel Main { get; set; }

        public InstanceLocator()
        {
            Main = new MainViewModel();
        }
    }
}
