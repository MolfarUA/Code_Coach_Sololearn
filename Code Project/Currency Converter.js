function main() {
    var amount = parseFloat(readLine(), 10);
    var rate = parseFloat(readLine(), 10);
    
    console.log(convert(amount, rate));
}


 function convert(amount, rate)  {
    return amount * rate;      
    }
var x = convert(100, 1.1);
