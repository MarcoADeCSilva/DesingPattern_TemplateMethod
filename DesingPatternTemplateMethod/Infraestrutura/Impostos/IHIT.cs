using DesingPatternTemplateMethod.Dominio;
using System.Linq;

namespace DesingPatternTemplateMethod.Infraestrutura.Impostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool DeveUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.GroupBy(a => a.Nome).Any(a => a.Count() > 1);
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.13) + 100);
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.01) * orcamento.Itens.Count());
        }
    }
}
