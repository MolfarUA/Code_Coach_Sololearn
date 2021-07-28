if let pesos = readLine(), let dollars = readLine(), let val1 = Int(pesos), let val2 = Int(dollars) {
    print(((val1*2)/100 < val2) ? "Pesos": "Dollars")
}
