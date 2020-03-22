public static class Sort
{
    private static void Swap(ref int x, ref int y) // Метод для обмена элементов массива
    {
        var t = x;
        x = y;
        y = t;
    }

    // Метод Partition возвращает индекс опорного елемента, который делит массив на элементы меньше опорного слева, и элементы больше опорного справа. 
    // В самом методе в качестве опорного выбирается последний элемент, а обход осуществляется от начала массива.
    private static int Partition(int[] array, int minIndex, int maxIndex) // Метод возвращающий индекс опорного элемента
    {
        var pivot = minIndex - 1; // Индекс опорного элемента
        for (var i = minIndex; i < maxIndex; i++)
        {
            if (array[i] < array[maxIndex])
            {
                ++pivot;
                Swap(ref array[pivot], ref array[i]);
            }
        }
        ++pivot;
        Swap(ref array[pivot], ref array[maxIndex]); // Меняем значение элемента с опорным индексом на значение элемента с максимальным индексом
        return pivot;
    }

    private static int[] QuickSort(int[] array, int minIndex, int maxIndex) // Метод "быстрой сортировки", принимает массив, минимальный индекс, максимальный индекс 
    {
        if (minIndex >= maxIndex)
        {
            return array;
        }
        var pivotIndex = Partition(array, minIndex, maxIndex); // Вызываем метод Partition, где находим опорный индекс
        QuickSort(array, minIndex, pivotIndex - 1); // Рекурсия слева
        QuickSort(array, pivotIndex + 1, maxIndex); // Рекурсия справа
        return array;
    }

    public static int[] SortAscending(int[] array) // Функция сортировки, принимает в качестве аргумента массив целых чисел
    {
        return QuickSort(array, 0, array.Length - 1);
    }
}
