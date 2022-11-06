using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Circuitos
{
    public abstract class Circuito{
        public abstract float Impedancia(float frecuencia);
        //      Un circuito recibe el valor de la frecuencia aplicada para determinar su impedancia.
        //  El método impedancia solo se implementa en el valor más bajo de la cadena: las resistencias,
        //  inductores y capacitores donde se calcula debido al tipo de circuito.
    }
    public abstract class CircuitoSimple : Circuito{
        //      Un circuito simple tiene el valor de su impedancia (c) como requisito obligatorio.
        protected float c;
        protected CircuitoSimple(float constante){ this.c=constante; }
    }
    public abstract class CircuitoCompuesto : Circuito{
        protected Circuito c1;
        protected Circuito c2;
        protected CircuitoCompuesto(Circuito c1,Circuito c2){
            //      Un circuito compuesto está formado por dos circuitos que pueden ser en Serie o Paralelo.
            this.c1 = c1;    this.c2 = c2;
        }
    }
    class Resistencia : CircuitoSimple{
        //      En una resistencia la impedancia es constante.
        public Resistencia(float constante):base(constante){}
        public override float Impedancia(float Resistencia) => c;
    }
    class Inductor : CircuitoSimple{
        //      En un Inductor la impedancia es directamente proporcional a la frecuencia.
        public Inductor(float constante):base(constante){}
        public override float Impedancia(float frecuencia) => c*frecuencia;
    }
    class Capacitor : CircuitoSimple{
        //      En un Capacitor la impedancia es inversamente proporcional a la frecuencia.
        public Capacitor(float constante):base(constante){}
        public override float Impedancia(float frecuencia) => c/frecuencia;
    }
    class Serie : CircuitoCompuesto{
        //      En un Circuito en Serie la impedancia se calcula como la suma de la impedancia de cada
        // uno de sus circuitos constituyentes.
        public Serie(Circuito c1, Circuito c2):base(c1,c2){}
        public override float Impedancia(float frecuencia){
            return c1.Impedancia(frecuencia)+c2.Impedancia(frecuencia);
        }
    }
    class Paralelo : CircuitoCompuesto{
        //      En un Circuito en Paralelo la impedancia se calcula como el inverso de la suma de los 
        // inversos de las impedancias de sus circuitos constituyentes.
        public Paralelo(Circuito c1, Circuito c2):base(c1,c2){}
        public override float Impedancia(float frecuencia){
            return 1/(1/c1.Impedancia(frecuencia)+1/c2.Impedancia(frecuencia));
        }
    }

}