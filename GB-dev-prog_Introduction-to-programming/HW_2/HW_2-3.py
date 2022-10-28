#Как сразу приходит в голову
arr=[6,4,3,2,5,1]
arr.sort()
print(sum(arr[1:-1]))

#Как, наверное, ожидается
arr=[6,4,3,2,5,1]
arrLen=len(arr)
i=0
k=1
res=0
while i<arrLen-1:
    j=0
    while j<arrLen-i-1:
        if arr[j]>arr[j+1]:
            temp=arr[j]
            arr[j]=arr[j+1]
            arr[j+1]=temp
        j+=1
    i+=1
while k<arrLen-1:
    res+=arr[k]
    k+=1
print(res)