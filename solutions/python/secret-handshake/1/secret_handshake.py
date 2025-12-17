def commands(binary_str):
    handshake=[]
    secrets=('', 'jump', 'close your eyes', 'double blink', 'wink')
    for i in range(1,5):
        if binary_str[i]=='1':
            handshake.insert(0,secrets[i])
    if binary_str[0]=='1':
        handshake.reverse()
    return handshake