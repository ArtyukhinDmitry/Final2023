# Итоговая проверочная работа

Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

План выполнения:
1. Создать репозиторий на GitHub
2. Написать программу решения задачи на языке программирования C#
3. Нарисовать блок схему алгоритма решения задачи
4. Добавить файл README.md
5. Репозиторий должен содержать не менее 3 коммитов

Описание алгоритма решения задачи:
1. На старте имеем строчный массив с заданными значениями - ishodni
2. Сначала выполняем перебор элементов массива ishodni и находим количество элементов удовлетворяющим требованию (skoka=3), для формирования нового массива с необходимым количеством элементов х.
3. Далее выполняем перебор элементов массива ishodni и находим элементы, которые удовлетворяют требованию (skoka=3), и записываем их в новый массив - poluchilos.
4. Выводим в консоль получившийся массив.

Дополнительно:
Для запуска программы, небходимо запустить файл Program.cs и в терминале написать команду: dotnet run.
Блок схема: blockShema.jpg
