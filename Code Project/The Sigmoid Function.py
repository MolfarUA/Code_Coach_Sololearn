w1, w2, b, x1, x2 = [float(x) for x in input().split()]
import math
output = w1*x1 + w2*x2 + b
output = round(1/(1 + math.exp(output*-1)), 4)
print(output)
