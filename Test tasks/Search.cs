public static class Search
{
    public static int BinarySearch(int[] array, int searchedValue) // Функция поиска индекса заданного значения
    {
        var left = 0; // Первый элемент
        var right = array.Length - 1; // Последний элемент
        while (left <= right)
        {
            var middle = (left + right) / 2; // Средний элемент
            if (searchedValue == array[middle])
            {
                return middle;
            }
            else if (searchedValue < array[middle]) // Сужаем рабочую зону массива с правой стороны
            {
                right = middle - 1;
            }
            else // Сужаем рабочую зону массива с левой стороны
            {
                left = middle + 1;
            }
        }
        return -1;
    }
}
