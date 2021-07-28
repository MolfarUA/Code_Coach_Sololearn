import java.util.Scanner;
public class Program
{
    public static void main(String[] args) {
        int l,i,nc=0,spc=0;
        char c;
        Scanner sc = new Scanner(System.in);
        String p = sc.nextLine();
        l=p.length();
        if(l<7)
        {
            System.out.println("Weak");
            System.exit(0);
        }
        for(i=0;i<l;i++)
        {
            c=p.charAt(i);
            if(c>=48 && c<=57)
                nc++;
            if(c=='!' || c=='@' || c=='#' || c=='$' || c=='%' || c=='&' || c=='*')
            spc++;
        }
        if(nc>=2 && spc>=2)
          System.out.println("Strong"); 
        else
          System.out.println("Weak");
    }
}
