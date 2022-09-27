class Menu
{
    public Menu()
    {

    }
    Data variable = new Data();
    Operation matriz = new Operation();
    public void start()
    {
        int answer = 0;
        Console.Clear();
        Console.WriteLine("How many numbers will you write?");
        variable.Number = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        answer = matriz.matriz(variable.Number);
        
        Console.WriteLine("The average is: "+ answer);
    }
    public void text(int i)
    {
        Console.WriteLine("Write the number {0}: ", i+1);
    }
    public void deviation(int exp)
    {
        Console.WriteLine("The deviation is: "+ exp);
    }
}