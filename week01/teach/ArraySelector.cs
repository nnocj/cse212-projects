public static class ArraySelector
{
    public static void Run()
    {    
        Console.ReadLine();
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        var results = new int[select.Length]; // now i see my mistake. I needed to set it's capacity.
        var l1Idx = 0;
        var l2Idx = 0;

        for (var i = 0; i < select.Length; i++)// changing the name from integer to variable is very significant here.
        {   
            if (select[i] == 1){
                results[i] = list1[l1Idx++];
            }

            else if (select[i] == 2){
                results[i] = list2[l2Idx++];
            }
        }
        return results;
    }
}