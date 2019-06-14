using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projQueue
{
    class Guiche
    {
        private int id;
        private Queue<Senha> atendimento;

        public Guiche()
        {
            this.atendimento = new Queue<Senha>();
            this.id = 1;
        }

        public Guiche(int id)
        {
            this.atendimento = new Queue<Senha>();
            this.id = id;
        }

        public bool Chamar(Queue<Senha> filaSenhas)
        {
            bool retorno = false;
            if (filaSenhas.First().gethoraAtend() != new DateTime())
            {
                filaSenhas.First().setdataAtend(DateTime.Now);
                filaSenhas.First().sethoraAtend(DateTime.Now);
                atendimento.Enqueue(filaSenhas.Dequeue());
                retorno = true;
            }
            return retorno;
        }
        public int getID()
        {
            return this.id;
        }
        
        public Queue<Senha> getAtendimento()
        {
            return atendimento;
        }

    }
}
