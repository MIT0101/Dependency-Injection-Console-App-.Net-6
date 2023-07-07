using Microsoft.Extensions.DependencyInjection;
using TestDepeanancyInjection;
using TestDepeanancyInjection.Services.Implementation;
using TestDepeanancyInjection.Services.Infrastructure;


var serviceCollection = new ServiceCollection();
serviceCollection.AddScoped<IService1, Service1>();
MyServiceManager.Build(serviceCollection);

var s1= MyServiceManager.GetService<IService1>();
await s1.Action1();

var myClass1 = new MyClass1();

await myClass1.UserService1();
