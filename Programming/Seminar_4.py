
# import random as r
# li = [r.randint(0,5) for i in range(11)]

# print(li)

data = [2, 5, 2, 3, 4, 1, 4, 5, 0, 2, 1] # получившийся массив

#          0  1  2  3  4  5
counter = [0, 0, 0, 0, 0, 0] # массив с количеством различных символов в нашем массиве data
# далее нам нужно посчитать, сколько разных элементов встречается в массиве data

for item in data:
    counter[item] +=1 # записываем в counter сколько каких элементов
# counter = [1, 2, 3, 1, 2, 2]

i = 0
for count in counter:
    for i in count:
        data[i] = count# пробежимся по количеству элементов, которые хранятся в counter
        i += i

