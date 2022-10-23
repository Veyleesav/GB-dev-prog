#Прямой вариант
n=6
i=1
f=1
while i<=n:
    f*=i
    i+=1
print(f)

#Обратный вариант
n=6
i=n
f=1
while i>=1:
    f*=i
    i-=1
print(f)