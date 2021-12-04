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
                },

                new Establishment()
                {
                    Id = 2,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Hering Store",
                    Description = "Company",
                    Address = "2º Andar - Loja 05 - Setor bueno",
                    Phone = "(62) 88888-8888"
                }

                new Establishment()
                {
                    Id = 3,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Calvin Klein",
                    Description = "Fashion Company",
                    Address = "1º Andar - Loja 02 - Setor bueno",
                    Phone = "(62) 77777-7777"
                }
            };

            return establishments;
        }
    }
}
