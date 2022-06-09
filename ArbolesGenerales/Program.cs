namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");

            Nodo nodoB = arbol.InsertarHijo(arbol.Raiz,"B");

            string elArbol = arbol.ObtenerArbol();
            Console.WriteLine(elArbol);

        }
    }
}
