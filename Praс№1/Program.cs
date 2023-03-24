class car
{
    public double maxSpeed;
    public string name;

    
    public car( double maxSpeed, string name)
    {
        this.maxSpeed = maxSpeed;
        this.name = name; 
    }

  static void Main()
    {
        car a = new car (490.5, "Buggati_shiron_super_sport_300"); // Создал 1 тачку
        Console.WriteLine(" Название тачки: " + a.name + " \n Макс.скорость: " + a.maxSpeed);

        car b = new car(460, "Koenigsegg_Jesko_Absolut"); // Создал 2 тачку
        Console.WriteLine("\n Название тачки: " + b.name + " \n Макс.скорость: " + b.maxSpeed);

        car c = new car(531, "CCS_Tuatara"); // Создал 3 тачку
        Console.WriteLine("\n Название тачки: " + c.name + " \n Макс.скорость: " + c.maxSpeed) ;

        car d = new car(410, "Aston_Martin_Valkyrie "); // Создал 4 тачку
        Console.WriteLine("\n Название тачки: " + d.name + "\n Макс.скорость: " + d.maxSpeed);

        double aspeed,bspeed,cspeed, dspeed, max;
        aspeed = a.maxSpeed;
        bspeed = b.maxSpeed;
        cspeed = c.maxSpeed;
        dspeed = d.maxSpeed;

        max = new[] { aspeed, bspeed, cspeed, dspeed}.Max();

        if (max == aspeed)
        {
            Console.WriteLine("\n Победитель " + a.name + ". Его скорость равна " + max );
        }
        if (max == bspeed)
        {
            Console.WriteLine("\n Победитель " + b.name + ". Его скорость равна " + max);
        }
        if (max == cspeed)
        {
            Console.WriteLine("\n Победитель " + c.name + ". Его скорость равна " + max);
        }
        if (max == dspeed)
        {
            Console.WriteLine("\n Победитель " + d.name + ". Его скорость равна " + max);
        }
    } 
    }



