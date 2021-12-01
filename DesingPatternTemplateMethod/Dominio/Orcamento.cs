using System.Collections.Generic;

namespace DesingPatternTemplateMethod.Dominio
{
    public class Orcamento
    {
        public Orcamento(double valor)
        {
            Valor = valor;
            this.Itens = new List<Item>();
        }

        public double Valor { get; private set; }
        public IList<Item> Itens { get; private set; }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
