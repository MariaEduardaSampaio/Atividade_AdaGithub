using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace githubProjeto
{
    internal class ContribuicaoSuellen
    {
        public string Nome {  get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Olá! Meu nome é {Nome}. Sejam bem vindos ao nosso repositório.");
        }
    }
}
