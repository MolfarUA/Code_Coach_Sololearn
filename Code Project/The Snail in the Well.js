function main() {
    var depth = parseInt(readLine(), 10);
    //your code goes here
    
    i = 0;
    
    for (; depth > 0;) {
        i++;
        
        depth -= 7
        if (depth > 0) {
            depth += 2
        }
    }
    console.log(i);
}
