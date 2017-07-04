using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.NetherRealms
{
    public class Demon
    {
        public string Name { get; set; }

        public int Health { get; set; }

        public double Damage { get; set; }
    }

    public class NetherRealms
    {
        public static void Main()
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, Demon> demonsResult = new SortedDictionary<string, Demon>();

            foreach (var demon in demons)
            {
                var healtSymbols = demon
                    .Where(s => !char.IsDigit(s) && s != '+' && s != '-' && s != '*' && s != '/' && s != '.').ToArray();
                var healtOfDemon = 0;
                var damageOfDemon = 0.0;

                foreach (var healtSymbol in healtSymbols)
                {
                    healtOfDemon += healtSymbol;
                }

                var damageRegex = new Regex(@"\-?\d+\.?\d*");
                var damageNumbers = damageRegex.Matches(demon);

                foreach (Match damageNumber in damageNumbers)
                {
                    damageOfDemon += double.Parse(damageNumber.ToString());
                }

                foreach (var demonSymbols in demon)
                {
                    if (demonSymbols == '*')
                    {
                        damageOfDemon *= 2;
                    }
                    else if (demonSymbols == '/')
                    {
                        damageOfDemon /= 2;
                    }
                }

                Demon currentDemon = new Demon
                {
                    Name = demon,
                    Health = healtOfDemon,
                    Damage = damageOfDemon
                };

                demonsResult[demon] = currentDemon;
            }

            foreach (var demon in demonsResult.Values)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:F2} damage");
            }
        }
    }
}