public static class WordRemover
{
    public static string RemoveRepeatWords(string str) // Функция удаления повторяющихся слов
    {
        string[] words = str.ToLower().Split('.', ',', ' ', ';', ':', '!', '?');
        string result = null;
        
        foreach(var word in words)
        {
            int count = 0;
            foreach (string item in words)
            {
                if (item == word)
                {
                    count++;
                }
            }
            if (count == 1)
            {
                result += word + " ";
            }   
        }

        return result;
    }
}
