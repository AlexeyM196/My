public static class Factorial
{
    public static decimal FactN(decimal number) // Функция нахождения факториала
    {
        if(number < 0) 
        {
            return -1;
        }
        if(number == 1) 
        {
            return 1; 
        }
        else
        {
            return number * FactN(number - 1); // Применяем рекурсию
        }
    }
}
