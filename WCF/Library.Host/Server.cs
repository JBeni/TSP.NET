using Library.Services;
using System;
using System.ServiceModel;
using System.ServiceModel.Description;


namespace Library.Host
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Server
    {
        private static ServiceHost host;

        public static void Main(string[] args)
        {
            StartServer();

            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static private void StartServer()
        {
            LibraryServices serviceLibrary = new LibraryServices();
            host = new ServiceHost(serviceLibrary, new Uri("http://localhost:1000/services"));

            try
            {
                host.Open();

                ILibraryServices singletonInstance = (ILibraryServices)host.SingletonInstance;
                LibraryServices svp = (LibraryServices)singletonInstance;
                AfisareEndpoint();
                Console.WriteLine("Server lansat in executie cu succes! Asteptare cereri de la clienti...");
            }
            catch (Exception ex)
            {
                Console.WriteLine("[exception]: " + ex);
            }
        }

        static private void AfisareEndpoint()
        {
            foreach (ServiceEndpoint se in host.Description.Endpoints)
            {
                string temp = String.Format("@ A(address): {0}\n@ EP name: {1}\n@ B(binding): {2}\n@ (Contract): {3}\n@ Uri: {4}", se.Address, se.Name, se.Binding.Name, se.Contract.Name, se.ListenUri.AbsolutePath);
                Console.WriteLine(temp);

                foreach (var x in se.EndpointBehaviors)
                {
                    string t = x.ToString();
                    Console.WriteLine(t);
                }
            }
        }


    }
}
