﻿using CMS.DB.Contract;
using CMS.DB.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    class Program
    {


        public Program()
        {
           // clientRequestAliasRepository = new ClientRequestAliasRepository();
        }

        static void Main(string[] args)
        {
            try
            {

                IClientRequestAliasRepository clientRequestAliasRepository = new ClientRequestAliasRepository();
                var enumarableSourceValueObject = clientRequestAliasRepository.GetAllClientAlias();
            }
            catch (Exception ex)
            {

                throw;
            }

            Console.Read();
        }
    }
}