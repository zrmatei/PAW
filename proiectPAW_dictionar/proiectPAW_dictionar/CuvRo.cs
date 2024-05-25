using System;
using System.Collections.Generic;

namespace proiectPAW_dictionar
{
    [Serializable]
    public class CuvRo
    {
        private string cuvant;
        private string gen;
        private string expl;
        private DateTime dataInreg;
        private List<CuvEng> translations;

        public CuvRo()
        {
            translations = new List<CuvEng>();
        }

        public CuvRo(string cuvant, string gen, string expl, DateTime dataInreg) : this()
        {
            this.cuvant = cuvant;
            this.gen = gen;
            this.expl = expl;
            this.dataInreg = dataInreg;
        }

        public string Cuvant { get => cuvant; set => cuvant = value; }
        public string Gen { get => gen; set => gen = value; }
        public string Expl { get => expl; set => expl = value; }
        public DateTime DataInreg { get => dataInreg; set => dataInreg = value; }
        public List<CuvEng> Translations { get => translations; set => translations = value; }


        public void AdaugTrans(CuvEng cEng)
        {
            if (cEng != null)
                translations.Add(cEng);
        }
    }
}
