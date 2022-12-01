namespace enums;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Days.Friday);
        Console.WriteLine((int)Days.Friday);

        int warmCondition=32;

        if(warmCondition<=(int)AirCondition.Normal)
            Console.WriteLine("Hava yeterince sıcak değil.");
        else if(warmCondition>=(int)AirCondition.Hot)
            Console.WriteLine("Hava çok sıcak.");
        else if(warmCondition>=(int)AirCondition.Normal && warmCondition<(int)AirCondition.Hot)
            Console.WriteLine("Hava dışarı çıkmak için ideal!");
    }
}
enum Days
{
    Monday=1,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
enum AirCondition
{
    Cold=5,
    Normal=20,
    Hot=25,
    tooHot=30
}