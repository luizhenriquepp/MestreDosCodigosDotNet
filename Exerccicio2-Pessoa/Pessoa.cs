using System;

namespace Exerccicio2_Pessoa
{
    public class Pessoa
    {
        private string _nome;
        private DateTime _dataNascimento;
        private double _altura;

        public string Nome 
        { 
            get => _nome;
            set
            {
                if (value == String.Empty)
                    throw new Exception("Nome inválido.");

                _nome = value;
            }
        }

        public DateTime DataNascimento 
        { 
            get => _dataNascimento;
            set
            {
                if (value.Date > DateTime.Today)
                    throw new Exception("Data inválida.");

                _dataNascimento = value;
            }
        }

        public double Altura
        { 
            get => _altura;
            set
            {
                if (value < 0)
                    throw new Exception("Altura inválida.");

                _altura = value;
            }
        }

        public void ImprmirDadosPessoa()
        {
            Console.WriteLine("Dados da pessoa");
            Console.WriteLine($"Nome: {_nome}");
            Console.WriteLine($"Data de nascimento: {_dataNascimento:dd/MM/yyyy}");
            Console.WriteLine($"Idade: {GetIdade()}");
            Console.WriteLine($"Altura: {_altura:0.00}");
        }

        public int GetIdade()
        {
            var idade = DateTime.Today.Year - _dataNascimento.Year;

            if (DateTime.Today < _dataNascimento.AddYears(idade))
                idade--;

            return idade;
        }
    }
}
