using TestDepeanancyInjection.Services.Infrastructure;

namespace TestDepeanancyInjection.Services.Implementation;

public class Service1 : IService1
{
    public int count = 0;
    public async Task Action1()
    {
        Console.WriteLine($"Welcome from {nameof(Action1)} inside {nameof(Service1)}");
        Console.WriteLine($"Count is {count}");
        count++;
    }
}
