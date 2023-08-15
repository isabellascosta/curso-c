using System;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Diagnostics;

namespace GenericsSetDicionary
{
    class Program
    {
        static void Main(string[] args)
        { 
            //o primeiro valor a passar nos dicionarios é a chave, o segundo é o valor. o tipo da chave e do valor são strings
            Dictionary<string,string> cookies = new Dictionary<string,string>();
            //
            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            //dictionary não aceita que a mesma chave tenha dois valores, então se você por dois valores ele vai sobrescrever com o ultimo valor
            cookies["phone"] = "99712234" + "99348923";
            //cookies["phone"] = "83737388";
            Console.WriteLine(cookies["phone"]);
            //ATENTE-SE, USA PARENTESES. remover a chave email 
            cookies.Remove("email");
            //imprimindo o tamanho
            Console.WriteLine("size: "+cookies.Count);
            Console.WriteLine("All cookies:");
            //OUTRA SINTAXE SERIA POR SOMENTE "VAR" AO INVES DE "KeyValuePair<string,string>"
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key+": "+item.Value);
            }
        }
    }
}