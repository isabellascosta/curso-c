using System;

namespace TopicosEspeciais
{
    class program
    {
        static void Main(string[] args)
        {
            string original = "abcde FGIHJ ABC abc DEFG    ";
            //converte tudo para maiuculo
            string s1 = original.ToUpper();
            //convertendo tudo para minusculo
            string s2 = original.ToLower();
            //apaga os campos vazios
            string s3 = original.Trim();
            //descobrir as ocorrencias dentro de original
            int n1 = original.IndexOf("bc");
            //ultima ocorrencia 
            int n2 = original.LastIndexOf("bc");
            //recortando a string primeiro numero corta o começo, segundo numero corta o fim
            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);
            //mudando um caractere por outro
            string s6 = original.Replace('a', 'x');
            //mudando dados do tipo string 
            string s7 = original.Replace("abc", "xy");
            //tentando se a string está vazia
            bool b1 = string.IsNullOrEmpty(original);
            //verificando se a string tem espaços em branco
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine($"Original - {original} -");
            Console.WriteLine($"ToUpper: - {s1}  -");
            Console.WriteLine($"Tolower: - {s2} -");
            Console.WriteLine($"Trim: - {s3} -");
            Console.WriteLine($"IndexOf('bc'): - {n1}  -");
            Console.WriteLine($"LastIndexOf('bc'): - {n2}  -");
            Console.WriteLine($"Substring (3): -{s4}-");
            Console.WriteLine($"Substring (3,5): -{s5}-");
            Console.WriteLine($"replace ('a','x'): - {s6}  -");
            Console.WriteLine($"replace ('abc','xy'): - {s7}  -");
            Console.WriteLine($"IsNullOrEmpty: - {b1}  -");
            Console.WriteLine($"IsNullOrWhiteSpace: - {b2}  -");
        }
    }
}
