using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MignoneMaratona
{
    class Maratone
    {
        public List<Maratona> ElencoMaratona;

        public Maratone()
        {
            ElencoMaratona = new List<Maratona>();
        }

        public void Aggiungi(Maratona maratona)
        {
            ElencoMaratona.Add(maratona);
        }

        public void LeggiDati()
        {

            using (FileStream flussoDati = new FileStream("Maratone.txt", FileMode.Open, FileAccess.Read))
            {
                using (StreamReader lettoreDati = new StreamReader(flussoDati))
                {
                    while (!lettoreDati.EndOfStream)
                    {

                        string linea = lettoreDati.ReadLine();
                        string[] campi = linea.Split('%');

                        Maratona maratona = new Maratona();
                        maratona.NomeAtleta = campi[0];
                        maratona.Società = campi[1];
                        maratona.TempoImpiegato = campi[2];
                        maratona.CittàMaratona = campi[3];

                        Aggiungi(maratona);
                    }
                }
            }
        } 
    }
}
