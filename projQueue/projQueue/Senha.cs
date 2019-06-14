using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projQueue
{
    class Senha
    {
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;

        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now;
            this.horaGerac = DateTime.Now;
        }

        public Senha()
        {
            new Senha(0);
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public int getID()
        {
            return this.id;
        }

        public void setDataGerac(DateTime dataGerac)
        {
            this.dataGerac = dataGerac;
        }

        public DateTime getdataGerac()
        {
            return this.dataGerac;
        }

        public void sethoraGerac(DateTime horaGerac)
        {
            this.horaGerac = horaGerac;
        }

        public DateTime gethoraGerac()
        {
            return this.horaGerac;
        }

        public void setdataAtend(DateTime dataAtend)
        {
            this.dataAtend = dataAtend;
        }

        public DateTime getdataAtend()
        {
            return this.dataAtend;
        }

        public void sethoraAtend(DateTime horaAtend)
        {
            this.horaAtend = horaAtend;
        }

        public DateTime gethoraAtend()
        {
            return this.horaAtend;
        }

        public String dadosParciais()
        {
            string data = Convert.ToString(this.dataGerac.Day) + "/" + Convert.ToString(this.dataGerac.Month) + "/" + Convert.ToString(this.dataGerac.Year);
            string hora = Convert.ToString(this.dataGerac.Hour) + ":" + Convert.ToString(this.dataGerac.Minute) + ":" + Convert.ToString(this.dataGerac.Second);

            return this.id + " - " + data + " - " + hora;
        }

        public String dadosCompletos()
        {
            string data = Convert.ToString(this.dataGerac.Day) + "/" + Convert.ToString(this.dataGerac.Month) + "/" + Convert.ToString(this.dataGerac.Year);
            string hora = Convert.ToString(this.dataGerac.Hour) + ":" + Convert.ToString(this.dataGerac.Minute) + ":" + Convert.ToString(this.dataGerac.Second);
            string dataAtend = Convert.ToString(this.dataAtend.Day) + "/" + Convert.ToString(this.dataAtend.Month) + "/" + Convert.ToString(this.dataAtend.Year);
            string horaAtend = Convert.ToString(this.horaAtend.Hour) + ":" + Convert.ToString(this.horaAtend.Minute) + ":" + Convert.ToString(this.horaAtend.Second);

            return this.id + "-" + data + " - " + hora + " - " + dataAtend + " - " + horaAtend;
        }
    }
}
