using StudyPOO;
namespace Tester;
public class MyStopwatch{
    long arrancada;
    long parada;
    bool andando;
    public MyStopwatch(){
        arrancada=0;
        parada=0;
        andando=false;
    }
    public bool Andando{ get; private set; }
    public long Arrancada{ get; set; }
    public long ElapsedMilliseconds{
        get{
            if(andando) return Environment.TickCount64 - arrancada;
            else return parada-arrancada;
        } 
    }
    public void Restart(){
        this.arrancada=0;
        this.parada=0;
        this.andando= true;

    }
    public void Stop(){
        this.parada= Environment.TickCount64;
        this.andando = false;
    }
    public void Start(){
        this.arrancada = Environment.TickCount64;
        this.andando = true;
    }
}
class Study
{
    public static void Main()
    {
        Cuenta personal = new Cuenta("Miguel", 0);
        CuentaTransferencia familia = new CuentaTransferencia("Familia", 2000);
        familia.Transfiere(1000,personal);
        System.Console.WriteLine(personal.Saldo);
        System.Console.WriteLine(familia.Saldo);
        System.Console.WriteLine();
        CuentaCredito probando = new CuentaCredito("probando", 500);
        probando.Extraer(200);
        System.Console.WriteLine(probando.Saldo);
        probando.Extraer(1000);
        System.Console.WriteLine(probando.Saldo);

        
        /* 
        MyStopwatch a = new MyStopwatch();
        Stopwatch crono = new Stopwatch();
        a.Start();
        crono.Start();
        System.Console.WriteLine();
        a.Stop();
        crono.Stop();
        System.Console.WriteLine(a.ElapsedMilliseconds);
        System.Console.WriteLine(crono.ElapsedMilliseconds); */


    }
}