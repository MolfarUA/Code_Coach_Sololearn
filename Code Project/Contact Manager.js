function contact(name, number) 
{
    this.name = name;
    this.number = number;
    this.print = print;
}

function print()
{
    console.log(this.name + ": " + this.number);
}

var a = new contact("David", 12345);
var b = new contact("Amy", 987654321)
a.print();
b.print();
