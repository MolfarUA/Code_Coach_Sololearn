string = input()
situation = string.replace("x", "")
if "T$" in situation or "$T" in situation:
 print("ALARM")
else:
 print("quiet")
