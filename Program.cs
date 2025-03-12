using System;
using System.IO.Ports;
using KlusterG.AutoGui;
using KlusterG.AutoGui.InternalKeys;

namespace MeuProjeto
{
    internal class Program
    {
        
        private static SerialPort serialPort;

        static void Main(string[] args)
        {
            
            serialPort = new SerialPort("COM3", 9600); 
            serialPort.DataReceived += SerialPort_DataReceived;
            serialPort.Open();

            Console.WriteLine("Waiting for Arduino commands...");
            Console.ReadLine(); 
        }

        private static void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            
            string data = serialPort.ReadLine().Trim();

            switch (data)
            {
                case "7":
                    Exec.KeyPress(KKeys.A);
                    Console.WriteLine("Button 7 → Key A");
                    break;
                case "6":
                    Exec.KeyPress(KKeys.B);
                    Console.WriteLine("Button 6 → Key B");
                    break;
                case "5":
                    Exec.KeyPress(KKeys.C);
                    Console.WriteLine("Button 5 → Key C");
                    break;
                case "4":
                    Exec.KeyPress(KKeys.D);
                    Console.WriteLine("Button 4 → Key D");
                    break;
                default:
                    Console.WriteLine("Unknown command: " + data);
                    break;
            }
        }
    }
}
