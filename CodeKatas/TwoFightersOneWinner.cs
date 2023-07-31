namespace CodeKatas;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class TwoFightersOneWinner
{
    public class Fighter
    {
        public string Name;
        public int Health, DamagePerAttack;
        public Fighter(string name, int health, int damagePerAttack)
        {
            this.Name = name;
            this.Health = health;
            this.DamagePerAttack = damagePerAttack;
        }
    }
    public static string DeclareWinner(Fighter fighter1, Fighter fighter2, string firstAttacker)
    {
        if (firstAttacker != fighter1.Name && firstAttacker != fighter2.Name)
        {
            return "invalid first attacker";
        }
        while (fighter1.Health > 0 && fighter2.Health > 0)
        {
            if (firstAttacker == fighter1.Name)
            {
                fighter2.Health -= fighter1.DamagePerAttack;
                Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}: {fighter2.Name} now has {fighter2.Health} health.");
                if (fighter2.Health <= 0) return $"{fighter1.Name}";
                fighter1.Health -= fighter2.DamagePerAttack;
                Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}: {fighter1.Name} now has {fighter1.Health} health.");
                if (fighter1.Health <= 0) return $"{fighter2.Name}";
            }
            else if (firstAttacker == fighter2.Name)
            {
                fighter1.Health -= fighter2.DamagePerAttack;
                Console.WriteLine($"{fighter2.Name} attacks {fighter1.Name}: {fighter1.Name} now has {fighter1.Health} health.");
                if (fighter1.Health <= 0) return $"{fighter2.Name}";
                fighter2.Health -= fighter1.DamagePerAttack;
                Console.WriteLine($"{fighter1.Name} attacks {fighter2.Name}: {fighter2.Name} now has {fighter2.Health} health.");
                if (fighter2.Health <= 0) return $"{fighter1.Name}";
            }
        }
        return "its a draw!";
    }
}
