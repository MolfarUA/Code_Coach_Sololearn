var operate = 20_000_000
var sellFor = 3_000_000
var insurance = 1_000_000
func monthly(customers: Int) {
	var income = sellFor * customers
	var monthCost = operate + insurance
	var total = income - monthCost
	if total < 0 {
		print("Loss")
	} else if total == 0 {
		print("Broke Even")
	} else {
		print("Profit")
	}
}
monthly(customers: Int(readLine()!)!)
