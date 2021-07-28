noise = str(input())
noise_list = noise.split()
animal = {"Grr":"Lion", "Ssss":"Snake", "Rawr":"Tiger", "Chirp":"Bird"}

answer = " "
for x in noise_list:
     answer += animal[x] + " "

print(answer)
