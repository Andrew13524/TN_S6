using System;

namespace S6
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(health: 100, damage: 15);

            Goblin goblin = new Goblin(health: 100, damage: 10);
            Slime slime = new Slime(health: 25, damage: 2);
            Theif theif = new Theif(health: 50, damage: 5);

            StartBattle(player, goblin);

            Console.ReadLine();
        }

        public static void StartBattle(Player player, Enemy enemy)
        {
            while (true)
            {
                Console.WriteLine($"Player Health: {player.Health} {enemy.Name} Health: {enemy.Health}");
                Console.ReadKey();

                enemy.Health -= player.Damage;

                if(enemy.Health <= 0)
                {
                    Console.WriteLine("Enemy Died");
                    return;
                }

                Console.WriteLine($"Player Health: {player.Health} {enemy.Name} Health: {enemy.Health}");
                Console.ReadKey();

                player.Health -= enemy.Attack();

                if (enemy.Health <= 0)
                {
                    Console.WriteLine("You Died");
                    return;
                }
            }
        }
    }
}
