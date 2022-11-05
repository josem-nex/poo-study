using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//Ejemplo práctico de clases abstractas con figuras geométricas
namespace ClassAbs
{
    public abstract class Figura
    {
        public abstract double Perimetro{get; }
        public abstract double Area {get; }
        
    }
    public class Circulo : Figura{
        public double Radio{get; set; }
        public Circulo(double radio){
            this.Radio= radio;
        }
        public override double Perimetro => 2*Math.PI*Radio;
        public override double Area => Math.PI*Radio*Radio;
    }
    public class Rectangulo : Figura{
        public double Ancho{get; set;}
        public double Largo{get; set;}

        public Rectangulo(double ancho, double largo){
            this.Largo=largo;
            this.Ancho=ancho;
        }
        public override double Perimetro => 2*Ancho+2*Largo;
        public override double Area => Ancho*Largo;
    }
    public class Triangulo : Figura{
        public double baset {get; set;}
        public double lado1{get; set;}
        public double lado2{get; set;}
        public double altura {get; set;}
        public Triangulo(double lado){
            // triangulo equilatero
            this.baset=lado;
        }
        public Triangulo(double baset, double altura, double lado1, double lado2){
            //triangulo no equilatero
            this.baset=baset;
            this.altura=altura;
            this.lado1=lado1;
            this.lado2=lado2;
        }
        public override double Perimetro{
            get{
                if(altura==0) return baset*3;
                else return baset+lado1+lado2;
            }
        }
        public override double Area{
            get{
                if(altura==0){
                    return (Math.Sqrt(3)*baset*baset)/4;
                }
                else return (baset*altura)/2;
            }
        }
    }
}