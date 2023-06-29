
namespace POO
{
    internal class Triangulo
    {
        //Classe é a definição do tipo, utilizada para guardar atributos como os abaixo, criar metodos e funçôes.
        public double A;
        public double B;
        public double C;
        //Public significa que esses atributos podem ser acessados em outros arquivos


        public double Area()
        {
            double p = (A+B+C)/2.0;
            double raiz = Math.Sqrt(p*(p-A)*(p-B)*(p-C));
            return raiz;
        }
    }
}
