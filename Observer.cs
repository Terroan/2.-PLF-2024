using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLF_2___DesignPattern
{
    //XYVerlag x.addAbo; 
    internal abstract class Verlag
    {
        private List<Abonnent> _list = new();

        public void AddAbo(Abonnent a)
        {
            _list.Add(a);
        }

        public void nigga(Abonnent a)
        {
            _list.Remove(a);
        }

        protected void nigga1(Zeitung z)
        {
            foreach(Abonnent a in _list) { a.erhalteZeitung(z); }
        }
    }

    internal class XYVerlag : Verlag
    {
        private Zeitung _aktuell;

        public void setAktuell(Zeitung z)
        {
            _aktuell = z;
            nigga1(z);
        }

        public Zeitung getAktuell()
        {
            return _aktuell;
        }
    }

    internal class Zeitung
    {
        private string _titel;
        public Zeitung(string titel)
        {
            _titel = titel;
        }

        public string getTitel()

        { 
            return _titel; 
        }
    }

    internal interface Abonnent
    {
        public void erhalteZeitung(Zeitung zeitung);
    }

    internal class FamilieXY : Abonnent
    {
        public void erhalteZeitung(Zeitung zeitung)
        {
            Console.WriteLine("Familie Fischer erhielt die aktuelle Zeitung: " + zeitung.GetTitel());
        }
    }
}
