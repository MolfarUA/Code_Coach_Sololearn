class Add {
  constructor(...words) {
      this.words = words;
  }
  //your code goes here
  print(){
      let y=""
      for(x of this.words){
           y=y+"$"+x;
      }
      console.log(y);
      
  }
}

var x = new Add("hehe", "hoho", "haha", "hihi", "huhu","");
var y = new Add("this", "is", "awesome","");
var z = new Add("lorem", "ipsum", "dolor", "sit", "amet", "consectetur", "adipiscing", "elit","");
x.print();
y.print();
z.print();
