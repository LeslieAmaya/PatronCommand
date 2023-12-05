﻿using PatronCommand.Command.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronCommand.Command
{
    public class ComandoSimple : IComando
    {
        private bool _mayus, _numlock;
        public ComandoSimple(bool mayus, bool numlock)
        {
            _mayus= mayus;
            _numlock= numlock;
        }
        public void Ejecutar()
        {
            Console.WriteLine($"Comando Simple: Visualmente voy a prender" + 
                $"\nEl foco mayus: " + _mayus + 
                $"\nEl foco numlock: " + _numlock);
        }
    }
}
