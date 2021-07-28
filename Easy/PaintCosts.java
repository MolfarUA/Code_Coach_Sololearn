import java.util.Scanner ;
 class Program
{
    public static void main(String[] args) {
     Scanner num=new Scanner(System.in);
     int colour = num.nextInt();
     double price = ((40.00+(colour*5))*110);
     int rprice = (int)Math.round((price/100));
     System.out.print(rprice);
    }
}
