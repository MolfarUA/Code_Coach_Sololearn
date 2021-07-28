import java.util.Scanner;

public class Main {

   public static void main(String[] args) {
       Scanner scanner = new Scanner(System.in);
       int math = scanner.nextInt();
       int history = scanner.nextInt();
       int geometry = scanner.nextInt();
       
       //your code goes here
       int totalTimeSpent = 
       math + history + geometry;
       
       int hourValue = 60;
       
       int firstLineValue = totalTimeSpent / hourValue;
       
       int secondLineValue = totalTimeSpent % hourValue;
       
       System.out.println(firstLineValue);
       
       System.out.println(secondLineValue);
    
       
       
   }
}
