using System;

namespace ImportConfiguration
{
    internal class Client
    {
        public void Main()
        {
            DataDirectory.ReadFormat("xml");
            DataDirectory.ReadFormat("csv");

            Console.ReadLine();
        }
    }
}