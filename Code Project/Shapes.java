import java.util.Scanner;
abstract class Shape {
    int width;
    abstract void area();
}

class Square extends Shape{
   public int area2;
   public  Square(int x)
    {
        width=x;
    }
    public void area()
    {
         area2=width*width;
         System.out.println(area2);
    
    }
}
class Circle extends Shape {
    public double area1;
  public   Circle(int y)
    {
        width=y;
    }
    public void area()
    {
        area1=Math.PI*width*width;
        System.out.println(area1);
    }
}

public class Program {
    public static void main(String[ ] args) {
        Scanner sc = new Scanner(System.in);
        int x = sc.nextInt();
        int y = sc.nextInt();
      
        Square a = new Square(x);
        Circle b = new Circle(y);
        a.area();
        b.area();
    }
}
