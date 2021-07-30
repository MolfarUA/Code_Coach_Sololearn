package main
import "fmt"

      type Timer struct{
      id string
      value int
      
    }
func (ptr *Timer) tick() {
  ptr.value += 1
  fmt.Println(ptr.value)
}

func main() {
    var x int
    fmt.Scanln(&x)

    t := Timer{"timer1", 0}
    
    for i:=0;i<x;i++ {
        t.tick()
    }
}
