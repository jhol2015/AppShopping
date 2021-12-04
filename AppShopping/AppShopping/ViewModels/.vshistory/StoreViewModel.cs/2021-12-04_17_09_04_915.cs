using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using AppShopping.Libraries.Enums;

namespace AppShopping.ViewModels
{
    internal class StoreViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        public List<Establishment> Establishments { get; set; }
       
        public StoreViewModel()
        {
            SearchCommand = new Command(Search);

            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store).ToList();
            Establishments = allStores;
        }

        private void Search()
        {
            //Todo - Logica de filtar a lista de lojas.
        }

    }
}
