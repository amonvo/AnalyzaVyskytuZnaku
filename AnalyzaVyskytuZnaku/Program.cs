using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnalyzaVyskytuZnaku
{

   

    class Program
    {
        static void Main(string[] args)
        {
            // řetězec, který chceme analyzovat
            string s = "";
            string[] poleVet = {"Kdo lže, ten krade (a do pekla se hrabe)", "Oheň je dobrý sluha, ale zlý pán", "Ranní ptáče dál doskáče", "Darovanému koni na zuby nehleď.", "Dvakrát měř, jednou řež."};
            Random rnd = new Random();
            
            s = s.ToLower();
            

            // inicializace počítadel
            int pocetSamohlasek = 0;
            int pocetSouhlasek = 0;
            int pocetSlov = 1;
            int vylosovanaVeta;

            // definice typů znaků
            string samohlasky = "aeiouyáéěíóúůý";
            string souhlasky = "bcčdďfghjklmnpqrřsštťvwxzž";
            string mezera = " ";

            // hlavní cyklus
			while (true) {
            	pocetSamohlasek = 0;
            	pocetSouhlasek = 0;
            	pocetSlov = 1;
            	
	            vylosovanaVeta = rnd.Next(0,5);
	            s = poleVet[vylosovanaVeta];
	            Console.WriteLine(s);
	            foreach (char c in s)
	            {
	            	if (samohlasky.Contains(c)){
	            		pocetSamohlasek++;	
	            	}
	                else if (souhlasky.Contains(c)){
	                	pocetSouhlasek++;
	                }
	                else if (mezera.Contains(c)) {
	                	pocetSlov++;
	                }
	                
	            }
	
	            // Výpisy
	            Console.WriteLine("Samohlásek: " + pocetSamohlasek);
	            Console.WriteLine("Souhlásek: {0}", pocetSouhlasek);
	            Console.WriteLine("Nepísmenných znaků: {0}", s.Length - (pocetSamohlasek + pocetSouhlasek));
	            Console.WriteLine("Celkový počet znaků:{0}", s.Length);
	            Console.WriteLine("Počet slov: {0}", pocetSlov);
	            Console.ReadKey();
	            Console.WriteLine();
	            Console.Clear();
        	}
        }
    }
}
