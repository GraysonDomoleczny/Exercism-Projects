def rotate(text, key):
    alphabet='abcdefghijklmnopqrstuvwxyz'
    rotate=(alphabet[key:] + alphabet[:key])
    shifted=str.maketrans(alphabet + alphabet.upper(), rotate + rotate.upper())
    return text.translate(shifted)
    
        
