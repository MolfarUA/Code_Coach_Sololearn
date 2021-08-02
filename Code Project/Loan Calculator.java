import java.util.Scanner;

public class Program
{
	public static void main(String[] args) {
		Scanner scanner = new Scanner(System.in);
		int amount = scanner.nextInt();
		//your code goes here
	 int rem_amt = amount;
		for (int i = 1 ; i <= 6 ; i++) {
    int paid = (int)Math.ceil(rem_amt);
    rem_amt = paid ;
    }
System.out.println(rem_amt*729/1000);
	}
}
