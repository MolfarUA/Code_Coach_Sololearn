package main
import "fmt"

func main() {
    var age int
    fmt.Scanln(&age)

    mars := age * 365 / 687
    fmt.Println(mars)
}
