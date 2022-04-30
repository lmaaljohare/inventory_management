using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace inventory_management.ViewModels
{
    public class AddItemViewModels
    {

        public ICommand AddItemsCommand { get; private set; }
        public ICommand ViewAllProductCommand { get; private set; }
    }
}
