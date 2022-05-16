#Сортировка подсчетом
import random as r
max = 5
data = [r.randint(0,max) for i in range(11)]

print(data)

# data = [2, 5, 2, 3, 4, 1, 4, 5, 0, 2, 1] # получившийся массив

#          0  1  2  3  4  5
counter = [0, 0, 0, 0, 0, 0] # массив с количеством различных символов в нашем массиве data
# далее нам нужно посчитать, сколько разных элементов встречается в массиве data

counter = [0 for i in range(max+1)]
#          0  1  2  3  4  5
# counter = [0, 0, 0, 0, 0, 0] # массив с количеством различных символов в нашем массиве data
# далее нам нужно посчитать, сколько разных элементов встречается в массиве data
print(counter)


for item in data:
    counter[item] +=1 # записываем в counter сколько каких элементов
print(counter)

k = 0
# # пробежимся по количеству элементов, которые хранятся в counter
for index in range(len(counter)): 
    for i in range(counter[index]): # берем индекс элемента из массива, пробегаемся по его количеству
        data[k] = index 
        k += 1

print(data)

# counter = [1, 2, 3, 1, 2, 2]
# # на нулевой позиции стоит 1, значит нужно поставить один нолик, и так далее
# data = [0, 1, 1, 2, 2, 2, 3, 4, 4, 5, 5] # массив отсортировался

# Написали алгоритм сортировки, теперь необходимо оценить сложность данного алгоритма
import random as r
max = 5
n = 11
data = [r.randint(0,max) for i in range(n)] # O(n)

print(data)
counter = [0 for i in range(max+1)] # O(n) - так как она не может быть больше чем количество элементов массива

print(counter)

for item in data: # O(n)
    counter[item] +=1 

print(counter)

k = 0
for index in range(len(counter)): 
    for i in range(counter[index]):
        data[k] = index # выполнится столько раз, сколько элементов было в изначальном массиве, значит сложность O(n)
        k += 1 

print(data)
# Итоговая оценка сложности - O(4n)
45:50