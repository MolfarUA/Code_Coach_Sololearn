class stack: # defining the stack class
    def __init__(self):
        self.items = []
    def is_empty(self): # returns true if self.items is empty
        return self.items == []
    def push(self, item): # adds item to the stack
        self.items.insert(0, item)
    def pop(self): # removes item from the stack
        return self.items.pop(0) 
    def __str__(self): # makes stack printable
        return "|%s|" %(' | '.join([f'"{item}"' for item in self.items]))
    def __call__(self): # makes stack callable as a function like a list
        return self.items
# keep in mind that you can still implement all of the stack functionality without creating a class.

def balanced(expression): # balanced function
    paren = stack() # initialize
    for char in expression: # iterate through expression to filter out parentheses
        if char == '(': 
            paren.push(char) # push opening parenthesis to stack
        if char == ')': 
            if '(' in paren(): 
                paren.pop() # pop from stack if stack is not empty
            else: 
                return False # return false if pop attempted on empty stack
    if not paren():
        return True # return true if stack is empty
    return False # return false if an opening parenthesis is found
    
if __name__ == "__main__": # the main function
    print(balanced(input()))
