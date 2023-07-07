using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDepeanancyInjection;

public class MyServiceManager
{
    private static MyServiceManager _instance;

    private IServiceProvider _serviceProvider;
    public static void Build(ServiceCollection serviceCollection)
    {
        _instance = new MyServiceManager(serviceCollection);
    }

    private MyServiceManager(ServiceCollection serviceCollection) {
        _serviceProvider=serviceCollection.BuildServiceProvider();
    }
    private TR GetServiceInstance<TR>() {

        if (_instance == null)
        {
            throw new MissingMemberException("You Must Build {MyServiceManager} Before Use It", nameof(MyServiceManager));

        }
        return _serviceProvider.GetRequiredService<TR>();
    }

    public static TR GetService<TR>()
    {

        return _instance.GetServiceInstance<TR>();
    }
}
