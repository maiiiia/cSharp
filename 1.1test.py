n = 10
d = 1000
p1=1.1
p2=1.05
x=100
for i in range(n):
    d=p1*d
    print("money left on account after getting '%' from deposit by the end of the year: ", d)
    d = d - x
    print("money left on account after donating to statmod by the end of the year: ", d)
    x = x*p2