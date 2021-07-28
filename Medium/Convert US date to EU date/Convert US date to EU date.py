import re

def month_convert(month):
    months = {
        "January" : "1",
        "February" : "2",
        "March" : "3",
        "April" : "4",
        "May" : "5",
        "June" : "6",
        "July" : "7",
        "August" : "8",
        "September" : "9",
        "October" : "10",
        "November" : "11",
        "December" : "12",
    }
    return months[month]

def first_format(date):
    date = re.split("/", date)
    return date[1]+"/"+date[0]+"/"+date[2]

def second_format(date):
    date = re.split(" |, ", date)
    return date[1]+"/"+month_convert(date[0])+"/"+date[2]

def europise_date(date):
    if re.search('\d+?/\d+?/\d+', date):
        return first_format(date)
    else:
        return second_format(date)

date = input()

print(europise_date(date))
