using System;

class Test
{

    static void Main()


    {

        string passWords = Console.ReadLine();

        bool b = ValidatePassword(passWords);
        if (b)
        {
            Console.WriteLine("Strong");
        }
        else
        {
            Console.WriteLine("Weak");
        }

        Console.ReadKey();

    }

    static bool ValidatePassword(string passWords)

    {

        int validSpecialCharacters = 0;
        //int validAlphabets = 0;
        int validNumbers = 0;

        //foreach (char c in passWord)

        //{

        //    if (c >= 'a' && c <= 'z')

        //    {

        //        validConditions++;

        //        break;

        //    }

        //}

        //foreach (char c in passWord)

        //{

        //    if (c >= 'A' && c <= 'Z')

        //    {

        //        validConditions++;

        //        break;

        //    }

        //}

        //if (validConditions == 0) return false;

        foreach (char c in passWords)
        {
            if (c >= '0' && c <= '9')
            {
                validNumbers++;
            }
        }
        if (validNumbers >= 2)
        {
            char[] special = { '!', '@', '#', '$', '%', '&', '*' }; // or whatever
            foreach (char c in passWords)
            {
                if (Array.Exists(special, element => element == c))
                {
                    validSpecialCharacters++;
                }
            }
        }
        return (passWords.Length >= 7 && validSpecialCharacters >= 2 && validNumbers >= 2);
    }

}
