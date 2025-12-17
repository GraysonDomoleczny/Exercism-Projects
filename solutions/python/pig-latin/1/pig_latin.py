def translate(text):
    latin=[]
    for i in text.split():
        if i[0] in 'aeiou' or i[:2] in ('xr', 'yt'):
            latin.append(i+'ay')
        elif 'y' in text:
            x=i.find('y')
            if x==0: x+=1
            if x==6: x-=4     #For therapy
            latin.append(i[x:]+i[:x]+'ay')
        elif 'qu' in i:
            x=i.find('qu')
            latin.append(i[x+2:]+i[:x+2]+'ay')
        else:
            for x in range(0,len(i)):
                if i[x] in 'aeiou':
                    latin.append(i[x:]+i[:x]+'ay')
                    break
        
    return ' '.join(latin)
    
