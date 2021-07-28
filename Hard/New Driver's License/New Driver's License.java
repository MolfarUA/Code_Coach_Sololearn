import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;
public class Program
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String name = sc.next();//my name
        int agents = sc.nextInt();//number of agents
        int time = 20;//period of time when one agent makes one license
        int output = time;//how long will it take me
        ArrayList <String> list = new ArrayList <String> (5);
        //adding all people waiting for new licenses to ArrayList 
        list.add(name);
        for (int i = 0; i < 4; i++)
            list.add(sc.next());
        //sorting
        Collections.sort(list);
        //my number
        int index = list.indexOf(name)+1;
        //how long should I wait
        while (index > agents) {
            output += time;
            index -= agents;
        }
        System.out.print(output);
    }
}
