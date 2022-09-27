class Operation
{
    public Operation()
    {

    }

    public int matriz(int number)
    {    
        Menu obj = new Menu();
        int average = 0,  answer = 0, exp= 0;
        
        int[] numbers = new int[number];

        for (int i = 0; i < numbers.Length; i++)
        {
            //Console.WriteLine("Escrine el numero");
            obj.text(i);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
            average += numbers[i];
        }
        average = average/number;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            answer = numbers[i]-average;
            exp += answer * answer;
        }
        exp = (exp / number);

        obj.deviation(exp);
        return average;
    }
}