namespace Stopwatch
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Menu();
    }
    static void Menu()
    {
      Console.Clear();

      Console.WriteLine($"S- Segundos | Ex: 3s");
      Console.WriteLine($"M- Minutos  | Ex: 3m");
      Console.WriteLine($"0- Sair");

      Console.Write($"Informe o tempo com a unidade: ");

      string data = Console.ReadLine().ToLower();
      char type = char.Parse(data.Substring(data.Length - 1, 1));
      int time = int.Parse(data.Substring(0, data.Length - 1));
      int multiplier = 0;

      if (type == 'm')
        multiplier = 60;
      else if (type == 's')
        multiplier = 1;
      else
      {
        Console.WriteLine($"Tipo Inválido...");
        Thread.Sleep(1000);
        Menu();
      }

      if (time == 0)
        System.Environment.Exit(0);

      Start(time * multiplier);
    }
    static void Start(int time)
    {
      int currentTime = 0;
      int seg = 0;
      int min = 0;

      while (currentTime != time)
      {
        Console.Clear();
        currentTime++;
        seg++;

        if (currentTime % 60 == 0 && seg == 60)
        {
          min++;
          seg = 0;
        }

        if (seg < 10 && min < 10)
          Console.WriteLine($"0{min}:0{seg}");

        else if (min < 10)
          Console.WriteLine($"0{min}:{seg}");

        else if (seg < 10)
          Console.WriteLine($"{min}:0{seg}");
        else
          Console.WriteLine($"{min}:{seg}");


        Thread.Sleep(1000);

      }
      Console.WriteLine($"Stopwatch finalizado\nRetornando ao menu...");
      Thread.Sleep(2500);
      Menu();
    }
  }
}