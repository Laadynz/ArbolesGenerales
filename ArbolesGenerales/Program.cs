namespace ArbolesGenerales
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral arbol = new ArbolGeneral("A");

            Nodo nodoB = arbol.InsertarHijo(arbol.Raiz,"B");
            Nodo nodoC = arbol.InsertarHijo(arbol.Raiz,"C");

            Nodo nodoD = arbol.InsertarHijo(nodoB,"D");
            Nodo nodoE = arbol.InsertarHijo(nodoB,"E"); 
            Nodo nodoF = arbol.InsertarHijo(nodoB,"F");

            Nodo nodoI = arbol.InsertarHijo(nodoD,"I");

            Nodo nodoJ = arbol.InsertarHijo(nodoF,"J");
            Nodo nodoK = arbol.InsertarHijo(nodoF,"K");

            string elArbol = arbol.ObtenerArbol();
            Console.WriteLine(elArbol);

        }
    }
}
