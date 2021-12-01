using DesingPatternTemplateMethod.Dominio;
using DesingPatternTemplateMethod.Interface;
using System;

namespace DesingPatternTemplateMethod.Servico
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, IImposto imposto)
        {
            double valor = imposto.Calcula(orcamento);

            Console.WriteLine(valor);
        }
    }
}
