//class program
//{
//    static void Main() {
//        int[] digits = { 1, 2, 3 }; // Большое целое число: 123
//        int N = 1;
//        int[] result = Plusn(digits, N);
//        foreach (var k in result)
//        {
//            Console.Write(k);
//        }
//    }
//    static int[] Plusn(int[] digits, int N)
//    {
//        int carry = N;
//        for (int i = digits.Length - 1; i >= 0; i--)
//        {
//            int sum = digits[i] + carry;
//            digits[i] = sum % 10;
//            carry = sum / 10;
//        }

//        if (carry > 0)
//        {
//            int[] result = new int[digits.Length + 1];
//            result[0] = carry;
//            Array.Copy(digits, 0, result, 1, digits.Length);
//            return result;
//        }
//        else
//        {
//            return digits;
//        }
//    }
//}

//class program
//{
//    static void Main() {
//        List<int> list = new List<int>() { 5, 90, 30, 1, -3 };
//        int newPosition = Convert.ToInt32(Console.ReadLine());
//        Move(list, newPosition)  ;
//        Console.WriteLine(string.Join(", ", list));
//    }
//    public static void Move(List<int> list, int choose)
//    {
//        if (choose >= list.Count)
//        {
//            throw new ArgumentOutOfRangeException("Выбор", "Вышел за рамки");
//        }

//        int EndEl = list[list.Count - 1];
//        list.RemoveAt(list.Count - 1);
//        list.Insert(choose, EndEl);
//    }
//}
//class program
//{
//    static void Main()
//    {
//        int Choose = Convert.ToInt32(Console.ReadLine());
//        string columnTitle = Columnnumber(Choose);
//        Console.WriteLine(columnTitle); // Output: A
//    }
//    static string Columnnumber(int Choose)
//    {
//        string columnTitle = "";

//        while (Choose > 0)
//        {
//            int remainder = (Choose - 1) % 26;
//            columnTitle = (char)(65 + remainder) + columnTitle;
//            Choose = (Choose - 1) / 26;
//        }

//        return columnTitle;
//    }
//}


