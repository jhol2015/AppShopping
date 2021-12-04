using System;
using System.Collections.Generic;
using System.Text;
using AppShopping.Models;
using AppShopping.Libraries.Enums;

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
                    Id = 1,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Renner",
                    Description = "A Lojas Renner S.A",
                    Address = "3º Andar - Loja 10 - Setor bueno",
                    Phone = "(62) 99999-9999" 
                }
            };

            return establishments;
        }
    }
}
