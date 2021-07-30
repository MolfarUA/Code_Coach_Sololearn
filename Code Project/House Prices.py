import numpy as np

data = np.array([150000, 125000, 320000, 540000, 200000, 120000, 160000, 230000, 280000, 290000, 300000, 500000, 420000, 100000, 150000, 280000])

mean = sum(data) / len(data)

stdvar = (sum((v-mean)**2 for v in data)/ len(data))**0.5

low, high = mean - stdvar, mean + stdvar

val = len([v for v in data if low < v < high])

home = (val / len(data)) * 100

print(home)
