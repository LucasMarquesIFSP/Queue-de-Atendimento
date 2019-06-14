using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projQueue
{
    class Guiches
    {
        private Queue<Guiche> listaGuiches;

        public Guiches()
        {
            listaGuiches = new Queue<Guiche>();
        }

        public void Adicionar(Guiche guiche)
        {
            listaGuiches.Enqueue(guiche);
        }

        public int qtdGuiches()
        {
            return this.listaGuiches.Count();
        }

        public Queue<Guiche> getGuiche()
        {
            return listaGuiches;
        }
        
    }
}
