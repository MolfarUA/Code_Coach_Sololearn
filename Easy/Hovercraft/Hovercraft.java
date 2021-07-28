import java.util.Scanner;
import java.math.BigDecimal;
import java.math.RoundingMode;

public class Hovercraft {
    public static void main(String[] args) {
        final var scanner = new Scanner(System.in);
        final var sales = scanner.nextBigDecimal();
        
        final var hovercraftMonth = new BigDecimal(10);
        final var hovercraftCosts = new BigDecimal(2_000_000);
        final var hovercraftPrice = new BigDecimal(3_000_000);
        final var insuranceMonth = new BigDecimal(1_000_000);
        final var spentMonth = hovercraftMonth.multiply(hovercraftCosts).add(insuranceMonth);
        final var incomeMonth = sales.multiply(hovercraftPrice);
        
        System.out.print(monthlyReport(incomeMonth, spentMonth));
    }
    
    private static String monthlyReport(BigDecimal incomeMonth, BigDecimal spentMonth) {
    	switch (incomeMonth.compareTo(spentMonth)) {
        	case -1: return "Loss";
        	case  1: return "Profit";
        	default: return "Broke Even";
        }
    }
}
