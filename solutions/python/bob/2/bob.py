def response(hey_bob):
    hey_bob=hey_bob.strip()
    if not hey_bob: return "Fine. Be that way!"
    elif hey_bob.isupper(): 
        return "Calm down, I know what I'm doing!" if hey_bob[-1]=='?' else "Whoa, chill out!"
    return "Sure." if hey_bob[-1]=='?' else "Whatever."
    
    
