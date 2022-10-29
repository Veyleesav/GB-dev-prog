#Как бы я реально сделал
arr=[1,2,3,4,5,6]
revArr=[]
for i in range(len(arr),0,-1):
    revArr.append(i)
print(revArr)

#Как, наверное, ожидается
arr=[1,2,3,4,5,6]
arrLen=len(arr)
j=0
i=arrLen-1
while j<arrLen/2:
    temp=arr[j]
    arr[j]=arr[i]
    arr[i]=temp
    j+=1
    i-=1
print(arr)
