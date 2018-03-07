using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var register = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string username = input[1];
                if (input[0] == "register")
                {
                    string licensePlateNumber = input[2];
                    if (!register.ContainsKey(username))
                    {
                        bool isValidePlate = ValidationPlate(licensePlateNumber);
                        if(isValidePlate==false)
                        {
                            Console.WriteLine($"ERROR: invalid license plate {licensePlateNumber}");
                            continue;
                        }
                        else if (register.ContainsValue(licensePlateNumber))
                        {
                            Console.WriteLine($"ERROR: license plate {licensePlateNumber} is busy");
                            continue;
                        }
                        register.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else 
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {register[username]}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    username = input[1];
                    if (register.ContainsKey(username))
                    {
                        Console.WriteLine($"user {username} unregistered successfully");
                        register.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }
            foreach (var user in register)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
        static bool ValidationPlate(string licensePlateNumber)
        {
            bool isValid = false;
            char[] arr = licensePlateNumber.ToCharArray();
            bool letters = (arr[0] >= 'A') && (arr[0] <= 'Z') && (arr[1] >= 'A') && (arr[1] <= 'Z') && (arr[arr.Length - 1] >= 'A') && (arr[arr.Length - 1] <= 'Z') && (arr[arr.Length - 2] >= 'A') && (arr[arr.Length - 2] <= 'Z');
            bool digits = ((arr[2] >= '0') && (arr[2] <= '9')) && ((arr[3] >= '0') && (arr[3] <= '9')) && ((arr[4] >= '0') && (arr[4] <= '9')) && ((arr[5] >= '0') && (arr[5] <= '9'));
            if ((letters==true)&&(digits==true))
            {
                isValid = true;
            }
            return isValid;
        }
    }
}
