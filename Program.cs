using System;

class Program{
    static void Main(string[]args){
        Console.Write("Money 1: ");
        float money1 = float.Parse(Console.ReadLine());
        Console.Write("Money 2: ");
        float money2 = float.Parse(Console.ReadLine());
        Console.Write("Money 3: ");
        float money3 = float.Parse(Console.ReadLine());
        float use;
        float left = 0;
        bool end = true;
        do{
            use = float.Parse(Console.ReadLine());
            if (use > 0){
                if (use < money1){
                    money1 = money1 - use;
                }else if (use < money2){
                    money2 = money2 - use;
                }else if (use < money3){
                    money3 = money3 - use;
                }else{
                    left = left + use;
                }
            }else{
                end = false;
            }
        }while(end);
        Console.WriteLine("Balance 1: {0}",money1);
        Console.WriteLine("Balance 2: {0}",money2);
        Console.WriteLine("Balance 3: {0}",money3);

        if (left > 0){
            Console.WriteLine("Left: {0}",left);
        }
    }
}