using System;

namespace Exercicio4_NotasAlunos
{
    public class Aluno
    {
        public static double NotaDeCorte = 7;
        private double _nota;
        public string Nome { get; set; }
        public double Nota 
        {
            get => _nota; 
            set 
            {
                if ((value < 0) || (value > 10))
                    throw new Exception("Nota inválida");

                _nota = value;
            }
        }

        public bool AlunoAprovado() =>
            Nota > NotaDeCorte;
    }
}
