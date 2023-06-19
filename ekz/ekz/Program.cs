using System;
// Написати код задачі, розмістити його у репозитарії на GitHub. Посилання на нього розмістити в якості відповіді на дану задачу
// Створити інтерфейс Lamp.Він має містити дані про освітлювальний прилад: тип, виробник, потужність у люменах, вид та кількість освітлювальних елементів.Інтерфейс має включати методи для друку на екрані значень цих даних та зміну потужності.
// Створити інтерфейс Camera. Він має містити дані про фото прилад: тип, виробник, світлочутливість оптичного об'єктиву. Також інтерфейс має включати методи для друку на екрані значень цих даних та зміну світлочутливості. 
// Створити клас PhotoStudio, який буде наслідувати описані вище інтерфейси. 
// Створити мінімум два екземпляри даного класу.
// Вивести на екран усі характеристики фото та світлового обладнання.
// Змінити значення світлочутливості для одного об'єкту і вивести його на екран.



interface Lamp
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    int Power { get; set; }
    string LightType { get; set; }
    int LightCount { get; set; }

    void Print();
    void ChangePower(int newPower);
}

interface Camera
{
    string Type { get; set; }
    string Manufacturer { get; set; }
    double Sensitivity { get; set; }

    void Print();
    void ChangeSensitivity(double newSensitivity);
}

class PhotoStudio : Lamp, Camera
{
  
    public string Type { get; set; }
    public string Manufacturer { get; set; }
    public int Power { get; set; }
    public string LightType { get; set; }
    public int LightCount { get; set; }

    // Camera properties
    public double Sensitivity { get; set; }

    public void Print()
    {
        Console.WriteLine("Lamp Info:");
        Console.WriteLine($"Type: {Type}, Manufacturer: {Manufacturer}, Power: {Power}, LightType: {LightType}, LightCount: {LightCount}");

        Console.WriteLine("Camera Info:");
        Console.WriteLine($"Type: {Type}, Manufacturer: {Manufacturer}, Sensitivity: {Sensitivity}");
    }

    public void ChangePower(int newPower)
    {
        Power = newPower;
    }

    public void ChangeSensitivity(double newSensitivity)
    {
        Sensitivity = newSensitivity;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PhotoStudio studio1 = new PhotoStudio
        {
            Type = "Studio1",
            Manufacturer = "Manufacturer1",
            Power = 100,
            LightType = "LED",
            LightCount = 4,
            Sensitivity = 3.4
        };
        PhotoStudio studio2 = new PhotoStudio
        {
            Type = "Studio2",
            Manufacturer = "Manufacturer2",
            Power = 200,
            LightType = "Incandescent",
            LightCount = 6,
            Sensitivity = 4.2
        };

        studio1.Print();
        studio2.Print();

        studio1.ChangeSensitivity(4.0);
        Console.WriteLine("Updated Camera Sensitivity for Studio1:");
        studio1.Print();
    }
}
