import math
players = [180, 172, 178, 185, 190, 195, 192, 200, 210, 190]
sum = 0
for nums in players:
    sum+=nums

mean = sum / len(players)
new_list = []
for i in players:
    new_list.append(mean-i)

new_sum = 0
for k in new_list:
    new_sum+=k**2

variance = new_sum/len(players)
deviation = math.sqrt(variance)
#print(variance)
#print(deviation)
#print(round(variance))
#print(round(deviation))
range1 = mean - deviation
range2 = mean + deviation
num_players = []
for j in players:
    if j in range(round(range1),round(range2)):
        num_players.append(j)
    else:
        pass

print(len(num_players))
