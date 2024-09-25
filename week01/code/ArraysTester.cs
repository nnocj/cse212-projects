public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} rotated to the right by 1 is <List>{{{string.Join(',', RotateListRight(numbers, 1))}}}");  // Expects <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} rotated to the right by 5 is <List>{{{string.Join(',', RotateListRight(numbers, 5))}}}"); // Expects <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} rotated to the right by 3 is <List>{{{string.Join(',', RotateListRight(numbers, 3))}}}"); // Expects <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}} rotated to the right by 9 is <List>{{{string.Join(',', RotateListRight(numbers, 9))}}}");  // Expects <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }

    private static double[] MultiplesOf(double number, int length)
        { /*'Multiples Set App' Functional Steps: 
            1. The function will accept the number and the number of multiples
            2. An algorithm will multiply the number which the user wants to find its multiples by each value starting with one to the length of the list entered by the user.
                For each result, the algorithm will also store each one in a list called multiples
                So lets say if the user wants to find 5 set of multiples of 3, the algorithm will 
                multiply 3 * 1, 3 * 2, 3 * 3, 3* 4, 3 * 5. Resulting to  3, 6, 9, 12, and 15 respectively.
                Each of these results will be added to the multiples list.
            3. The function will return the list of multiples.*/   

        List<double> multiples = new List<double>();

        for (int i= 1; i <length + 1; i++) {
            multiples.Add(number * i);
        }

        return multiples.ToArray(); 
    }
    
    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// <c>&lt;List&gt;{1, 2, 3, 4, 5, 6, 7, 8, 9}</c> and an amount is 3 then the list returned should be 
    /// <c>&lt;List&gt;{7, 8, 9, 1, 2, 3, 4, 5, 6}</c>.  The value of amount will be in the range of <c>1</c> and 
    /// <c>data.Count</c>.
    /// <br /><br />
    /// Because a list is dynamic, this function will modify the existing <c>data</c> list rather than returning a new list.
    /// </summary>
    /// 
  
    private static List<int> RotateListRight(List<int> data, int amount)
    {
      /*List Right Rotation App Functional Steps:
        1. The function will accept the list data to be rotated and the amount of rotation steps
        2. Using subtraction, an algorithm will start adding the values that when shifted by the said amount
           would appear at the start of the list, to a new list. So for instance if List {1, 2, 3, 4, 5}
           when shifted to the right by 3 steps will be {3, 4, 5, 1, 2}. 
           So we'll have 5 - 3 = 2, since the list size is 5. The value from index 2 to 5 will be added first
           following that those from 0 to three will be added. This will use two AddRange, GetRange functions.

        3. The function will return the new rotated list.*/  
        List<int> rotatedList = new  List<int>();

        int startPoint = data.Count - amount;
        
        rotatedList.AddRange(data.GetRange(startPoint, amount));

        rotatedList.AddRange(data.GetRange(0, startPoint));

        return rotatedList;

    }
}
