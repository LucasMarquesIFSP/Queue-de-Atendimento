using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projQueue
{
    class Senhas
    {
        private int proximoAtendimento;
        private Queue<Senha> filaSenhas;

        public Senhas()
        {
            filaSenhas = new Queue<Senha>();
            this.proximoAtendimento = 0;
        }

        public void gerar()
        {
            this.filaSenhas.Enqueue(new Senha(++proximoAtendimento));
        }

        public void remove()
        {
            this.filaSenhas.Dequeue();
        }
        
        public Queue<Senha> getSenhas()
        {
            return filaSenhas;
        }
    }
}
