code = input()[::-1]

spell = ""
        
        
letters = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', ' ' ]

for i in range(len(letters)-1):
	letters.append(letters[i].upper())
	
for i in code:
	if i in letters:
		spell += i
		
	
print(spell)
