def find(list, value):
    original=list[:]
    if value not in list: raise ValueError("value not in array")
    while len(list)>2:
        middle=len(list)//2
        if value>list[middle]:
            list=list[len(list)//2+1:]
        elif value<list[middle]:
            list=list[:len(list)//2]
        else:
            return len(list)//2
    if len(list)==2:
        return original.index(list[1])
    return original.index(list[0])