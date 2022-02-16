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
        
        public string Verificacitta(string citta)
        {   
            string output = string.Empty;
            int index = 0;
            foreach(var lista in ElencoMaratona)
            {
                if(citta == lista.CittàMaratona)
                {
                    index++;
                    string temp = string.Empty;
                    for(int a = 0; a<= index; a++)
                    {
                        temp = lista.NomeAtleta;
                        output = string.Join(" ", temp);
                    }
                    return output;
                }
                else
                {
                    return output = "Ricerca fallita prova ad inserire una città valida";
                }
            }
            return null;
        }
    }
}