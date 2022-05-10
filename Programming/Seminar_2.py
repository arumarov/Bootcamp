## Задача с Codewars
## Задача 1
## На вход подается площадь квадрата, который закрашен синим
## На вход подается площадь квадрата, который закрашен синим
# from cmath import pi
# import math

# def square_area_to_circle(size):
#     s = float(pi*(((math.sqrt(size))/2)**2))
#     equal =(round(s, 8))
#     return equal

## Задача 2
## Создайте функцию, которая возвращает n-й элемент последовательности Фибоначчи
def fibonacci(n):
    if n==1 or n==2:
        result=1
    elif n==0:
        result=0      
    else:
        result = (fibonacci(n-1))+(fibonacci(n-2))
    return result
print(fibonacci(15))
## Такое решение работает, но не проходит тесты из-за большого времени выполнения для больших n