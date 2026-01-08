def is_pangram(sentence):
    return all(i in sentence.lower() for i in 'qwertyuiopasdfghjklzxcvbnm')
  
