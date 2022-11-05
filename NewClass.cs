namespace StudyPOO{
    public class Cuenta{
        public string titular{ get; private set;}
        public float Saldo{ get; protected set;}
        public Cuenta(string Titular, float saldoinicial){
            this.titular = Titular;
            if(saldoinicial<0) throw new Exception("El saldo inicial debe ser mayor que 0");
            this.Saldo= saldoinicial;
        }
        public void Depositar(float cantidad){
            if(cantidad<=0) throw new Exception("El saldo a depositar debe ser mayor que 0");
            Saldo+=cantidad;
        }
        public virtual void Extraer(float cantidad){
            if(cantidad <=0) throw new Exception("La cantidad a extraer debe ser mayor que cero");
            else if(Saldo-cantidad<0) throw new Exception("No hay suficiente saldo para extraer");
            Saldo-=cantidad;
        }
    }
    public class CuentaTransferencia: Cuenta{
        public CuentaTransferencia(string Titular, float saldoinicial):base(Titular,saldoinicial){}
        public void Transfiere(float cantidad, Cuenta cuentadestino){
            if(cantidad<=0) throw new Exception("La cantidad debe ser mayor que 0");
            else if(Saldo<cantidad) throw new Exception("No hay suficiente saldo para extraer");
            Extraer(cantidad);
            cuentadestino.Depositar(cantidad);
        }
    }
    public class CuentaConjunta: Cuenta{
        public string Cotitular{ get; protected set;}
        public CuentaConjunta(string titular, string Cotitular, float saldoinicial):base(titular,saldoinicial){
            this.Cotitular= Cotitular;
        }
    }
    public class CuentaCredito: Cuenta{
        public CuentaCredito(string titular, float saldoinicial):base(titular,saldoinicial){}
        public override void Extraer(float cantidad){
            if(cantidad<=0) throw new Exception("No puede extraer una cantidad menor o igual a 0");
            else if(Saldo>=cantidad) Saldo-=cantidad;
            else{
                Saldo-=cantidad+ (cantidad*(5/100));
            }
        }
    }
}