﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLojaABC
{
    public class Pessoa
    {
        private string nome;
        private string email;
        private int idade;
        //método construtor
        public Pessoa()
        {

        }

        public void imprimirValores()
        {

        }
        public int calculaIdade(int idade)
        {
            return this.idade = idade + 1;
        }
    }
}
