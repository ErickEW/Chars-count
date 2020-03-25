using System;
using System.Linq;
using System.Collections.Generic;

namespace Charles
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "sabiduria japonesa: si no es tuyo, no lo tomes. si no es correcto, no lo hagas. si no es verdad, no lo digas. si no sabes, calla.";
            //string data = "gwvuv syrbk sjrwf yspsm akpki yhznw wkpbt kpboq rjlpe nejku sxteo ihufz lgsiu jlypa lgqin ubave hjxav mgoeu gddnp mdicm dynxu pkcyf plubt aotmi ymbtr yczgi eacns oklwp buvve naymc wrbgv yjdif fjcgp xcyxs pnlcx fgrjt jvuzh pcvqq zhgwq keuyd cwdam weptg uidvz pfoug uvmaq wuzho utbln arsoj nnwid bjfeu mnqmp mziej phacb nymoz uqbzr fdzjp gmshg ckvjs jyeik xfgyp";
            
            Dictionary <char, int> countByChar = new Dictionary<char,int>();

            foreach (var c in data)
            {
              if (c == ' ') 
              {
                  continue;
              }
               if (c == ':') 
              {
                  continue;
              }
               if (c == ',') 
              {
                  continue;
              }
               if (c == '.') 
              {
                  continue;
              }
              if (countByChar.ContainsKey(c))
              {
                countByChar.TryGetValue(c, out int currentCount);
                int nextCount = currentCount + 1;

                countByChar.Remove(c);

                countByChar.Add(c, nextCount);
              }
              else
              {
                  countByChar.Add(c, 1);
              }
            }

            char cMasRepetido = ' ';
            int numeroMasRepetido = 0;

            char cMenosRepetida = ' ';
            int numeroMenosRepetido = 129;
            
            foreach (var item in countByChar)
            {
              if (item.Value > numeroMasRepetido) 
              {
                cMasRepetido = item.Key;
                numeroMasRepetido = item.Value;
              }
              if (item.Value < numeroMenosRepetido) 
              {
                cMenosRepetida = item.Key;
                numeroMenosRepetido = item.Value;
              }
              System.Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            System.Console.WriteLine($"Highest Count: {cMasRepetido} -> {numeroMasRepetido}");
            System.Console.WriteLine($"Lowest Count: {cMenosRepetida} -> {numeroMenosRepetido}");
            Console.WriteLine("Tamaño del string " + data.Length);

        }
    }
}
