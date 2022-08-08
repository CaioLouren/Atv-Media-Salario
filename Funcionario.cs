using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Funcionario()
        {
        }

        public Funcionario(string nome, double salario)
        {
            Nome = nome;
            Salario = salario;
        }

        public double Media(Funcionario s1, Funcionario s2)
        {
            return (s1.Salario + s2.Salario) / 2;
        }
    }
}
