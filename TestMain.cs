using StudyPOO;
using ClassAbs;
using Circuitos;
namespace Tester;
class Study
{
    public static void Main()
    {
        #region Herencia y Polimorfismo
        Cuenta personal = new Cuenta("Personal", 0);
        CuentaTransferencia familia = new CuentaTransferencia("Familia", 2000);
        familia.Transfiere(1000,personal);
        System.Console.WriteLine(personal.Saldo);
        System.Console.WriteLine(familia.Saldo);
        System.Console.WriteLine();
        CuentaCredito test = new CuentaCredito("test", 500);
        test.Extraer(200);
        System.Console.WriteLine(test.Saldo);
        test.Extraer(1000);
        System.Console.WriteLine(test.Saldo);
        
        #endregion

        // clases abstractas
        Triangulo hola = new Triangulo(3);
        System.Console.WriteLine(hola.Perimetro);

        System.Console.WriteLine("PRUEBA DE CIRCUITOS");

        //      El ejemplo introducido representa un circuito en paralelo que está formado por un circuito
        //  en serie (compuesto por una resistencia y un inductor) y por un capacitor.
        Circuito c = new Paralelo   (new Serie(
                                                new Resistencia(4),
                                                new Inductor(3)),
                                    new Capacitor(2));    
            
        //      Redondeo el valor recibido a 3 cifras significativas.
        System.Console.WriteLine(Math.Round(c.Impedancia(5),3));


    }
}