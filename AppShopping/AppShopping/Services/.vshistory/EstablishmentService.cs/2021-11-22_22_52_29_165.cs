using System;
using System.Collections.Generic;
using System.Text;
using AppShopping.Models;

namespace AppShopping.Services
{
    public class EstablishmentService
    {
        public List<Establishment> GetEstablishments ()
        {
            //poderia buscar da api os dados.
            var establishments = new List<Establishment>()
            {
                new Establishment()
                {

                }
            };

            return establishments;
        }
    }
}
