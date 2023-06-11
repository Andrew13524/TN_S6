using System;
using System.Collections.Generic;
using System.Text;

namespace S6
{
    public interface IHealAbility
    {
        void Heal();
    }
    public interface IRageAbility
    {
        int Rage();
    }

    public abstract class Enemy
    {
        public string Name;
        public int Health;
        public int Damage;

        public Enemy(int health, int damage)
        {
            Health = health;
            Damage = damage;
        }

        public abstract int Attack();
    }

    public class Goblin : Enemy, IRageAbility
    {
        public Goblin(int health, int damage) : base(health, damage)
        {
            Name = "Goblin";
        }

        public override int Attack()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 100);

            if(randomValue < 20)
            {
                return Rage();
            }

            return Damage;
        }

        public int Rage()
        {
            return Damage * 2;
        }
    }

    public class Slime : Enemy, IRageAbility, IHealAbility
    {
        public Slime(int health, int damage) : base(health, damage)
        {
            Name = "Slime";
        }

        public override int Attack()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 100);

            if (randomValue < 20)
            {
                return Rage();
            }
            else if (randomValue < 40)
            {
                Heal();
            }

            return Damage;
        }

        public void Heal()
        {
            Health += 15;
        }

        public int Rage()
        {
            return Damage * 2;
        }
    }

    public class Theif : Enemy
    {
        public Theif(int health, int damage) : base(health, damage)
        {
            Name = "Theif";
        }

        public override int Attack()
        {
            return Damage;
        }
    }
}
