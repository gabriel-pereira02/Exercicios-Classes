using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    public class Funcionarios
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiqudo()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto * ((porcentagem/100) + 1);
            Console.WriteLine($"Dados Atualizados: {Nome}, R${SalarioLiqudo()}");
        }

        public override string ToString()
        {
            return $"{Nome}, R${SalarioLiqudo()}"; 
        }
    }
}
