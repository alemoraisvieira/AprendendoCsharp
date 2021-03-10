﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _11_LacoRepeticaoFor
{
    class Pessoa
    {
   
        private string nome;
        private DateTime dataNascimento;
        private float altura;


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
        public DateTime DataNascimento
        {
            get
            {
                return dataNascimento;
            }

            set
            {
                dataNascimento = value;
            }
        }

        public float Altura
        {
            get
            {
                return altura;
            }

            set
            {
                altura = value;
            }
        }

        public void ImprimirDados()
        {
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("Data de Nascimento: " + dataNascimento);
            Console.WriteLine("Altura: " + altura);
        }

        public int CalcularIdade()
        {
            return DateTime.Today.Year - dataNascimento.Year;
        }
    }
}

