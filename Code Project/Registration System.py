try:
    name = input()
    #your code goes here
    count=0
    for i in name:
      count+=1
      
    if count > 3:
      print("Account Created")
    else:
      raise Exception
except:
    print("Invalid Name")
