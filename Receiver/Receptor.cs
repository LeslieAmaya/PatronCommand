using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Receiver
{
    public class Receptor
    {
        public void MayusculasActivadas(bool mayus, char tecla)
        {
            Console.WriteLine
                (
                mayus ? $"Receptor: La siguiente tecla {tecla} será mayúscula" : " Receptor (Mayus) No voy a interferir"
                );
        }
        public void NumLockActivadas(bool numlock)
        {
            Console.WriteLine
                (
                numlock ? "Receptor: El siguiente número de Numpad será registrado" : "Receptor (Numlock) No voy a interferir"
                );
        }

    }
}
