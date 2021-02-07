using System;
using System.Collections.Generic;

namespace Lab.ConsoleApp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Weapon StartSword = new Weapon("My first Sword", 1);
            Globals<Weapon>.PlayerInventory.Add(StartSword);
            Console.WriteLine(StartSword.weaponName); // This works
            Console.WriteLine(Globals<Weapon>.PlayerInventory[0]); // This prints "CSharp_Shell.Weapon", but I expected "StartSword"
            Console.WriteLine(Globals<Weapon>.PlayerInventory[0].weaponName); // This results in an Error
        }
    }

    internal static class Globals<T> where T: class
    {
        public static string Playername;
        public static IList<T> PlayerInventory = new List<T>();
    }

    public class Weapon
    {
        public string weaponName;
        public int weaponBaseDamage;

        public Weapon(string name, int baseDamage)
        {
            weaponName = name;
            weaponBaseDamage = baseDamage;
        }
    }
}