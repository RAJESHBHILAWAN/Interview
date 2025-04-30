using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.SOLID
{
    internal class DependencyInjection
    {
        public DependencyInjection() { }

        private void ConstructorInjection()
        {
            ClientConstructorInjection client = new ClientConstructorInjection(new Service());
            client.Start();
            Console.ReadKey();
        }

        private void PropertyInjection()
        {

            ClientPropertyInjection client = new ClientPropertyInjection();
            client.Service = new MailService();
            client.Start();
            Console.ReadKey();

        }
        private void MethodInjection()
        {
            ClientMethodInjection client = new ClientMethodInjection();
            client.Start(new Service());
            Console.ReadKey();

        }
    }
}
#region MethodInjection
public class ClientMethodInjection
{
    private IService _service;
    public void Start(IService service)
    {
        this._service = service;
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }
}

#endregion
#region PropertyInjection
public class ClientPropertyInjection
{
    private IService _service;
    public IService Service
    {
        set
        {
            this._service = value;
        }
    }
    public void Start()
    {
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }

}

#endregion

#region ConstructorInjection
public class ClientConstructorInjection
{
    private IService _service;
    public ClientConstructorInjection(IService service)
    {
        this._service = service;
    }
    public void Start()
    {
        Console.WriteLine("Service Started");
        this._service.Serve();
        //To Do: Some Stuff
    }
}
#endregion


public interface IService
{
    void Serve();
}
public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}

public class MailService : IService
{
    public void Serve()
    {
        Console.WriteLine("Service Called");
        //To Do: Some Stuff
    }
}
