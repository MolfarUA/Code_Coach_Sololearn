import re

pswd = input()
special = re.sub ("[!@#$%&*]", "", pswd)
nums = re.sub ("[\d]", "", pswd)
if len(pswd) < 7 or len(special) == len(pswd) or len(nums) == len(pswd):
    print ("Weak")
else :
    print ("Strong")
