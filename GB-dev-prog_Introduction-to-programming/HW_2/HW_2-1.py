#Как бы я реально делал
arr=[7,5,3,2,1,7]
maxElementIndex = [i for i, x in enumerate(arr) if x == max(arr)]
minElementIndex = [i for i, x in enumerate(arr) if x == min(arr)]
print('Индексы максимального элемента:', maxElementIndex,'Индексы минимального элемента:', minElementIndex)

#Как, наверное, ожидается
arr=[7,5,3,2,1,7]
maxElementIndex = []
minElementIndex = []
maxEl=arr[0]
minEl=arr[0]
i = 0
j=0

while i<len(arr):
    if arr[i]>maxEl:
        maxEl=arr[i]
    elif arr[i]<minEl:
        minEl=arr[i]
    i+=1
    print()
while j<len(arr):
    if arr[j]==maxEl:
        maxElementIndex.append(j)
    elif arr[j]==minEl:
        minElementIndex.append(j)
    j+=1

print('Индексы максимального элемента:', maxElementIndex,'Индексы минимального элемента:', minElementIndex)
