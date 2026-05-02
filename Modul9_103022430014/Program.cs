using Modul9_103022430014;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Numerics;
using System.Text.Json;
using static Program;

internal class Program
{
   public static void Main (string[] args)
    {
        BankTransferConfig config = new BankTransferConfig();
        if (config.config.lang == "en")
        {
            Console.WriteLine("Please insert the amount of money to transfer:");
        } else
        {
            Console.WriteLine("Masukkan jumlah uang yang akan ditransfer:");
        }

        double input2 = Convert.ToInt32(Console.ReadLine());
        double total2 = Convert.ToInt32(Console.ReadLine());
    }
}
