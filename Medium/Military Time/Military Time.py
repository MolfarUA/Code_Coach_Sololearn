a=input()
b=a.replace("AM","").replace ("PM","")
ans=""
if a[-2:]=="AM":
    if b[1]==":":
        print("0"+b[0:])
    elif b[:2] == "12":
        print("00" + b[2:])
    else:
        print(b[0:])
else:
    if b[1]==":":
        ans=str(int(b[0])+12)+b[1:]
    elif b[2]==":" and b[0:2]!="12":
        ans=str(int(b[0:2])+12)+b[2:]   
    else:
        ans= b
    print(ans)
