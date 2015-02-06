def Fiblist(n):
    a = 0
    b = 1
    mylist = []
    mylist.append(a)
    for i in range(0, n):
        temp = a
        a = b
        b = temp + b
        mylist.append(a)
    # print mylist

    if n not in mylist:
        return "isNotFib"
    else:
        return "isFib"

def isFib(seq):
    list = seq.split(",")
    # print len(list)
    mystr = ""
    for i in range(0, len(list)):
        if i > 0 and i != len(list):
            mystr = mystr + ","
        mystr = mystr + Fiblist(int(list.__getitem__(i)))
    print mystr


isFib("5,7,8,13")


