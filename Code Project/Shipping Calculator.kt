fun shippingCost(amount: Double, international: Boolean): Double {
    var cost = 0.0
    
    if (international) {
        cost = if (amount * 0.15 > 50) 50.0 else amount * 0.15
    }
    else if (amount < 75) {
        cost = amount * 0.1
    }    
    return cost
}

fun main(args: Array<String>) {
    val total = readLine()!!.toDouble()
    val international = readLine()!!.toBoolean()    
    println(shippingCost(total, international))
}
