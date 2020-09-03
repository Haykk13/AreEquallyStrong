using System;

namespace AreEquallyStrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your left's strength: ");
            int yourLeft = int.Parse(Console.ReadLine());
            Console.Write("Enter your rights's strength: ");
            int yourRight = int.Parse(Console.ReadLine());
            Console.Write("Enter friend's left's strength: ");
            int friendsLeft = int.Parse(Console.ReadLine());
            Console.Write("Enter friend's right's strength: ");
            int friendsRight = int.Parse(Console.ReadLine());
            if(areEquallyStrong(yourLeft, yourRight, friendsLeft, friendsRight))
            {
                Console.WriteLine("You are equally strong!");
            }
            else
            {
                Console.WriteLine("You are NOT equally strong!");
            }
            Console.ReadLine();
        }
        static bool areEquallyStrong(int yourLeft, int yourRight, int friendsLeft, int friendsRight)
        {
            bool isEqual = false;
            if(yourLeft + yourRight == friendsLeft + friendsRight && (yourLeft == friendsLeft || yourLeft == friendsRight))
            {
                isEqual = true;
            }
            return isEqual;
        }

    }
}
