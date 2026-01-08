def resistor_label(colors):
    color=['black','brown','red','orange','yellow','green','blue','violet','grey','white']
    tolerances={'grey':'±0.05%', 'violet':'±0.1%', 'blue':'±0.25%', 'green':'±0.5%', 'brown':'±1%', 'red':'±2%', 'gold':'±5%', 'silver':'10'}
    tolerance=''

    if len(colors)==5:
        ohms=((100*color.index(colors[0]))+(10*color.index(colors[1]))+(color.index(colors[2])))*(10**color.index(colors[3]))
        tolerance=tolerances[colors[-1]]
    elif len(colors)==4:
        ohms=(10*color.index(colors[0])+color.index(colors[1]))*(10**color.index(colors[2]))
        tolerance=tolerances[colors[-1]]
    elif len(colors)==3:
        ohms=(10*color.index(colors[0])+color.index(colors[1]))*(10**color.index(colors[2]))
    elif len(colors)==2:
        return str((10*color.index(colors[0])+color.index(colors[1])))+' ohms'
    else: 
        return str(10*color.index(colors[0]))+' ohms'
    
    if ohms >= 1_000_000_000:
        prefix = "giga"
        ohms /= 1_000_000_000
    elif ohms >= 1_000_000:
        prefix = "mega"
        ohms /= 1_000_000
    elif ohms >= 1_000:
        prefix = "kilo"
        ohms /= 1_000
    else:
        prefix = ""

    if ohms%1==0:
        ohms=int(ohms)

    return f"{ohms} {prefix}ohms {tolerance}"