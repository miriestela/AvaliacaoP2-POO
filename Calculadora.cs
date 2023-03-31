public class Calculadora{
    
     public  double area, raio, pi=3.1459;

     public Calculadora(double area, double raio){

        this.area = area;
        this.raio = raio;
     }

     public double Area(){
        double a;
        return a = Math.Sqrt(Math.Pow(raio,2)*pi);
     }

    public double Circunferencia(){
        double c;
        return c = (2*pi*raio);
    }

    public double Diametro(){
        double d;
        return d = (2*raio);
    }
}