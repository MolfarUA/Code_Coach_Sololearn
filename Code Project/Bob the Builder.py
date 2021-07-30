import numpy as np
n = int(input())
X = []
for i in range(n):
    X.append([float(x) for x in input().split()])
y = [int(x) for x in input().split()]
datapoint = [float(x) for x in input().split()]
from sklearn.linear_model import LogisticRegression
model = LogisticRegression()
model.fit(X,y)
datapoint = np.array(datapoint).reshape(1,-1)
print(model.predict(datapoint[[0]])[0])
