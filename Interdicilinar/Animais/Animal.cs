﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interdicilinar.Animais
{
    public abstract class Animal
    {
       // private int codigo;
        private string nome;
        private DateTime nascimento;
        private char sexo;
        private bool carnivoro;
        private bool peconheto;

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public DateTime Nascimento
        {
            get
            {
                return nascimento;
            }
            set
            {
                if(value == DateTime.Now)
                {
                    throw new Exception("A data de nascimento não pode ser hoje");
                }
                else
                {
                    nascimento = value;
                }
            }
        }

        public char Sexo
        {
            get
            {
                return sexo;
            }
            set
            {
                char _sexo = value;
                if(value == 'M' || value == 'F')
                {
                    sexo = value;
                }
                else
                {
                    throw new Exception("Sexo invalido");
                }
            }
        }

        public bool Carnivoro
        {
            get
            {
                return carnivoro;
            }
            set
            {
                carnivoro = value;
            }
        }

        public bool Peconhento
        {
            get
            {
                return peconheto;
            }
            set
            {
                peconheto = value;
            }
        }

        public int Idade()
        {
            return DateTime.Now.Year - nascimento.Year;
        }

        public abstract string Movimentar();

        public abstract string Comunicar();

        public abstract string Alimentar();

    }
}
