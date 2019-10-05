using System;
using System.IO;

namespace localhook_client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Initiating");

        }

        static void EnsureConfigFileCreated() {
            FileInfo f = new FileInfo(constants.StorageFileName);
        }
    }
}
