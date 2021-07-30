import re
a = input()
pattern = r"[189]"
if re.match(pattern,a):
    if len(a) == 8:
        print("Valid")
    else:
        print("Invalid")
else:
    print("Invalid")
