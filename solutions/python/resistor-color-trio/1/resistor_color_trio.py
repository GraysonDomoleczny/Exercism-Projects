def label(colors):
    color=['black','brown','red','orange','yellow','green','blue','violet','grey','white']
    ohms=(10*color.index(colors[0])+color.index(colors[1]))*(10**color.index(colors[2]))
    
    if ohms > 1_000_000_000:
        prefix = "giga"
        ohms //= 1_000_000_000
    elif ohms > 1_000_000:
        prefix = "mega"
        ohms //= 1_000_000
    elif ohms > 1_000:
        prefix = "kilo"
        ohms //= 1_000
    else:
        prefix = ""
    
    return f"{ohms} {prefix}ohms"
