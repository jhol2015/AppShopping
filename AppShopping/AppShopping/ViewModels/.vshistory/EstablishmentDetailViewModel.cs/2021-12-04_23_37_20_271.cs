using AppShopping.Libraries.Helpers.MVVM;
using AppShopping.Models;
using AppShopping.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppShopping.ViewModels
{
    internal class EstablishmentDetailViewModel : BaseViewModel
    {
        public Establishment Establishment { get; set; }
        public EstablishmentDetailViewModel()
        {
            Establishment = new EstablishmentService().GetEstablishments().First() ;
        }
    }
}
