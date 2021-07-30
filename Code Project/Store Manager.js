function main() {
    var increase = parseInt(readLine(), 10);
    var prices = [98.99, 15.2, 20, 1026];
    //your code goes here
    
    var incPrice = prices.map(cur => cur + increase);
        console.log(incPrice);  
}
