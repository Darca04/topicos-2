using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Numero.Dominio.Validaciones
{
    public class ValidarNumero
    {
        public bool elNumeroEsValidoEnLaBase(string elNumero, int laBase)
        {
            bool elResultado = true;
            for(int i = 0; (i < elNumero.Length)&(elResultado==true); i++)
            {
                elResultado = elDigitoEsValidoEnLaBase(elNumero[i], laBase);
            }
            return (elResultado);
        }

        private bool elDigitoEsValidoEnLaBase(char elDigito, int laBase)
        {
            bool elResultado;
            //TO DO;
            elResultado = true;
            return (elResultado);
        }
    }
}
