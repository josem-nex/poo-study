using StudyPOO;
namespace Tester;
class Study
{
    public static void Main()
    {
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

        
        


    }
}