let a:String! = readLine()
let b:String! = readLine()
var siblings:Int! = Int(a)
var popsicles:Int! = Int(b)

if popsicles % siblings == 0 {
    print("give away")
} else {
    print("eat them yourself")
}
