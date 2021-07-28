import Foundation

let dateS1 = readLine()!

let dateFormatterGet1 = DateFormatter()
dateFormatterGet1.dateFormat = "MMM dd,yyyy"
let dateFormatterGet2 = DateFormatter()
dateFormatterGet2.dateFormat = "MM/dd/yyyy"

let dateFormatterOut = DateFormatter()
dateFormatterOut.dateFormat = "d/M/yyyy"

var date = Date()
if let temp = dateFormatterGet1.date(from: dateS1) {
    date = temp
} else {
    date = dateFormatterGet2.date(from: dateS1)!
}

var result = dateFormatterOut.string(from: date)
print(result)
