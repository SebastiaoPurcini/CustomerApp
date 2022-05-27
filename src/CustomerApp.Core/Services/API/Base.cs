using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Core.Services.API
{
    public static class Base
    {
        public static string baseUrl 
        {
            get => "https://servicodados.ibge.gov.br/api/v1/localidades/";
        }
    }
}
