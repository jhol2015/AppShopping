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
                },

                new Establishment()
                {
                    Id = 3,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Calvin Klein",
                    Description = "A Calvin Klein é uma casa de moda de luxo americana criada em 1968. É especializada em couro, acessórios de estilo de vida, artigos de decoração, perfumaria, joalharia, relógios e pronto-a-vestir. A empresa tem participação de mercado substancial em linhas de varejo e comerciais, bem como roupas de alta costura.",
                    Address = "1º Andar - Loja 02 - Setor bueno",
                    Phone = "(62) 77777-7777"
                },

                new Establishment()
                {
                    Id = 4,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Dolce & Gabbana",
                    Description = "Fashion Company",
                    Address = "3º Andar - Loja 12 - Setor bueno",
                    Phone = "(62) 66666-6666"
                }, 
                
                new Establishment()
                {
                    Id = 5,
                    Type = EstablishmentType.Store,
                    Logo = "",
                    Name = "Puma",
                    Description = "Puma SE, com a marca Puma, é uma empresa multinacional alemã que projeta e fabrica calçados, roupas e acessórios esportivos e casuais, com sede em Herzogenaurach, Baviera, Alemanha.",
                    Address = "2º Andar - Loja 08 - Setor bueno",
                    Phone = "(62) 55555-5555"
                }
            };

            return establishments;
        }
    }
}
