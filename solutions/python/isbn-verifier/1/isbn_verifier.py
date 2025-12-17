def is_valid(isbn):
    sum=0
    isbn=isbn.replace('-','')

    if len(isbn)!=10: return False
        
    if isbn[-1] in 'QWERTYUIOPASDFGHJKLZXCVBNM': 
        if isbn[-1]=='X': sum+=10
        else: return False
        isbn=isbn[:-1]
    elif int(isbn[-1]) in range (0,9): 
        sum+=int(isbn[-1])
        isbn=isbn[:-1]

    for i in 'qwertyuiopasdfghjklzxcvbnm':
        if i in isbn.lower(): return False

    for i in range(2,11):
        sum+=(i*int(isbn[-(i-1)]))
        
    return sum%11==0