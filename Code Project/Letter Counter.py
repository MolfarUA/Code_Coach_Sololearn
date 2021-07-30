text = input()
dict = {}

for i in text.lower():
    dict[i] = text.count(i)
print(dict)
