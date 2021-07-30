file = open("/usercode/files/books.txt", "r")

letters=[]

for line in file.readlines():

    words=line.split()

    for w in words:
        
        letters.append(w[0])
    
    print("".join(letters),end="")
    letters=[]

file.close()
