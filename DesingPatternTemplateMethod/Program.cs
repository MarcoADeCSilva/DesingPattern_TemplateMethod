using DesingPatternTemplateMethod.Dominio;
using DesingPatternTemplateMethod.Infraestrutura.Impostos;
using DesingPatternTemplateMethod.Interface;
using DesingPatternTemplateMethod.Servico;
using System;

namespace DesingPatternTemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento(550);
            orcamento.AdicionaItem(new Item("CANETA", 300));
            orcamento.AdicionaItem(new Item("LAPIS", 250));

            CalculadorDeImpostos imposto = new CalculadorDeImpostos();
            IImposto ikcv = new IKCV();
            IImposto icpp = new ICPP();
            IImposto ihit = new IHIT();

            imposto.RealizaCalculo(orcamento, ikcv);
            imposto.RealizaCalculo(orcamento, icpp);
            imposto.RealizaCalculo(orcamento, ihit);
        }
    }
}
