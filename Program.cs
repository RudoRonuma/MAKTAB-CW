//Question1();
//Question2();
//Question3();
//Question4();
//Question5();
//Question6();

using CW1;

QueraQuestion17675.Main(null);


static void Question1()
{
    var radius = Convert.ToSingle(Console.ReadLine());
    Console.WriteLine("Circumference: " + 2 * radius * Math.PI);
    Console.WriteLine("Side: " + radius * radius * Math.PI);
}


static void Question2()
{
    var hours = Convert.ToInt32(Console.ReadLine());
    var mins = Convert.ToInt32(Console.ReadLine());
    var secs = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine((hours * 60 * 60) + (mins * 60) + secs);
}

static void Question3()
{
    var salary = Convert.ToSingle(Console.ReadLine());
    salary -= salary * 0.1f;
    salary -= salary * 0.06f;
    Console.WriteLine(salary);
}

static void Question4()
{
    string totalStr = "";
    //foreach (var _ in Enumerable.Range(0, 7))
    for (int i = 0; i < 7; i++)
    {
        totalStr += Console.ReadKey().KeyChar.ToString();
    }

    var isNum = int.TryParse(totalStr, out var theNum);
    Console.WriteLine("\n" + isNum);
    Console.WriteLine(theNum);
}

static void Question5()
{
    var theNumber = Convert.ToInt32(Console.ReadLine());
    int firstNum = theNumber / 100;
    theNumber -= firstNum * 100;
    int secondNum = theNumber / 10;
    theNumber -= secondNum * 10;
    int thirdNum = theNumber;


    Console.WriteLine(firstNum + thirdNum == secondNum);
}

static void Question6()
{
    var theNumber = Convert.ToInt32(Console.ReadLine());
    int firstNum = theNumber / 10;
    int secondNum = theNumber - (firstNum * 10);

    Console.WriteLine(theNumber % firstNum == 0 && theNumber % secondNum == 0);
}
