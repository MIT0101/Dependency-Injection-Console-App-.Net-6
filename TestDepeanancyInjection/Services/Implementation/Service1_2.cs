using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDepeanancyInjection.Services.Infrastructure;

namespace TestDepeanancyInjection.Services.Implementation;

public class Service1_2 : IService1
{
    public async Task Action1()
    {
        Console.WriteLine($"Welcome from {nameof(Action1)} inside {nameof(Service1_2)}");
    }
}
