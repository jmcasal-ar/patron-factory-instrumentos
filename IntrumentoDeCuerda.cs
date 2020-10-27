using System;
namespace PatronFactoryInstrumentos
{
    public abstract class IntrumentoDeCuerda: IInstrumento
    {
        //variables que recibimos como parametros
        private string _modelo;
        private int _cantidadCuerdas;

        public IntrumentoDeCuerda(string Modelo, int CantidadCuerdas)
        {
            _modelo = Modelo;
            _cantidadCuerdas = CantidadCuerdas;
        }

        /*Le tenemos que agregar la palabra virtual para que los instrumentos
        hijos puedan hacer polimorfismo con ese metodo
        */
        public void Tocar()
        {

        }

        public void ImprimirCuerdas()
        {
            Console.WriteLine("La cantidad de cuerdas que posee es " + _cantidadCuerdas);
        }
    }
}