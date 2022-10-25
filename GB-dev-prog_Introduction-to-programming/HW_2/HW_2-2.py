#Как бы я реально сделал
arr=[1,2,3,4,5,6]
revArr=[]
for i in range(len(arr),-1,-1):
    revArr.append(i)
print(revArr)

#Как, наверное, ожидается
arr=[1,2,3,4,5,6]
arrLen=len(arr)
i=0
while i<arrLen-1:
    j=0
    while j<arrLen-i-1:
        temp=arr[j]
        arr[j]=arr[j+1]
        arr[j+1]=temp
        j+=1
    i+=1
print(arr)
