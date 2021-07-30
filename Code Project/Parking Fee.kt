fun main(args: Array<String>) {
    var hours = readLine()!!.toInt()
    var total: Double = 0.0
    
    
if(hours <= 5){
        var result: Double = hours * 1.0
        total = result 
    } else if (hours > 5 && hours < 24){
        var result: Double = (hours - 5.0) * 0.5
        total = 5.0 + result 
    } else {
        var result: Double = (15.0 * Math.floor(hours /24.0)) + ((hours% 24.0)*0.5)
        total = result 
    }
    
    println(total)
}
