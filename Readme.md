## Задача

Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


Ссылка на блок-схему алгоритма: [блок-схема](Kontrolwork/Block.jpg)


## Решение задачи

1. Cоздаем массив, запрашиваем у пользователя число элементов и сами значения 
2. Перебираем каждый элемент используя цикл for, проверяем на условие, если длина строки элемента меньше или равна 3. При выполнении условия прибавляем +1 к переменной size. Так мы узнаем длину у нового массива 
3. Создаем новый массив для вывода результата, длина массива = size
4. Заполняем новый массив элементами из исходного массива, если выполняется условие: длина строки элемента меньше или равна 3
5. Выводим на печать исходный и новый массивы
