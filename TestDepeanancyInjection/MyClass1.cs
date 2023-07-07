using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestDepeanancyInjection.Services.Infrastructure;

namespace TestDepeanancyInjection;

public class MyClass1
{
    private readonly IService1 _service1;
    public MyClass1()
    {
        _service1 = MyServiceManager.GetService<IService1>();
    }

    public async Task UserService1() {
       await _service1.Action1();
    }
}
