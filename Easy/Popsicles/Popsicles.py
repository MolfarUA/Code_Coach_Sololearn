siblings = int(input())
popsicles = int(input())
k = popsicles % siblings
#your code goes here
if popsicles > 0 and k == 0:
    print("give away")
else:
    print("eat them yourself")
