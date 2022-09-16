// Заполнить массив четной длины таким образом,
// чтобы значение элемента массива повторялось ровно 2 раза.


int[] arr = GenArray();
PrintArray(arr);


int[] GenArray()
{
    int size;
    while (true)
    {
        size = new Random().Next(2, 9);
        if (size % 2 == 0) break;
    }

    int[] arr = new int[size];

    int[] arrIndex = new int[size];
    for (int i = 0; i < size; i++)
        arrIndex[i] = -1;

    for (int i = 0; i < size; i += 2)
    {
        int tempItem = AbsenceArrayItem(arr);
        for (int j = 0; j < 2; j++)
        {
            int ind = AbsenceIndexArray(arrIndex);
            arr[ind] = tempItem;
            arrIndex[i + j] = ind;
        }
    }
    return arr;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i]);
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}

bool IsContain(int[] array, int num) // Проверка, содержится ли элемент в массиве
{
    foreach (var item in array)
    {
        if (num == item) return true;
    }
    return false;
}

int AbsenceArrayItem(int[] array) // Генерация отсутствующего в массиве элемента
{
    while (true)
    {
        int item = new Random().Next(1, 10);
        if (!IsContain(array, item))
            return item;
    }
}

bool IsEmptyIndexArray(int[] indexArray, int index) // Проверка занятости позиции в массиве
{
    foreach (var item in indexArray)
    {
        if (item == index)
            return false;
    }
    return true;
}

int AbsenceIndexArray(int[] indexArray)
{
    while (true)
    {
        int item = new Random().Next(0, indexArray.Length);
        if (IsEmptyIndexArray(indexArray, item))
            return item;
    }
}