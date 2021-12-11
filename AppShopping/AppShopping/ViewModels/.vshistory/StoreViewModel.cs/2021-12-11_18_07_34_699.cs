using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using AppShopping.Libraries.Enums;
using AppShopping.Libraries.Helpers.MVVM;

namespace AppShopping.ViewModels
{
    internal class StoreViewModel : BaseViewModel
    {
        public string SearchWord { get; set; }
        public ICommand SearchCommand { get; set; }
        private List<Establishment> _establishments;
        public List<Establishment> Establishments { 
            get {
                return _establishments;   
            }
            set {
                SetProperty (ref _establishments, value);
            } 
        }

        private List<Establishment> _allEstablishments;

        public ICommand DetailCommand { get; set; }
       
        //Construtor
        public StoreViewModel()
        {
            SearchCommand = new Command(Search);
            DetailCommand = new Command(Detail);

            //Representa a busca na API
            var allEstablishment = new EstablishmentService().GetEstablishments();
            var allStores = allEstablishment.Where(a => a.Type == EstablishmentType.Store).ToList();

            Establishments = allStores;
            _allEstablishments = allStores;
        }

        private void Search()
        {
            Establishments =  _allEstablishments.Where(a => a.Name.ToLower().Contains(SearchWord.ToLower())).ToList();   
        }

        private void Detail()
        {
            // TODO -> Shell -> GoTo -> EstablishmentDetail
            Shell.Current.GoToAsync("establishment/detail");
        }
    }
}
