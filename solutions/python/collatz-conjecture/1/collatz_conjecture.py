def steps(number):
    n=0
    if number<1: raise ValueError("Only positive integers are allowed")
    while number!=1:
        number = 3 * number + 1 if number % 2 else number / 2
        n+=1
    return n
    
