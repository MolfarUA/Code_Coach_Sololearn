class Juice:
    def __init__(self, name, capacity):
        self.name = name
        self.capacity = capacity

    def __str__(self):
        return (self.name + ' ('+str(self.capacity)+'L)')
    
    def __add__(self,newJuice):
        
        self.name += "&" + str(newJuice.name)
        self.capacity += newJuice.capacity 
        return self.__str__


a = Juice('Orange', 1.5)
b = Juice('Apple', 2.0)


print(a.__add__(b)())
