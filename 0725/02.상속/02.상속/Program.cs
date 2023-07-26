using System;

namespace Sample
{
    class Player
    {
        public int id;
        public int hp;
        public int attack;
        //public Player()
        //{
        //    Console.WriteLine("Player 생성자 호출");
        //}
        public void Move()
        {
            Console.WriteLine("Player Move");
        }
        public void Attack()
        {
            Console.WriteLine("Player Attack");
        }
    }
    class Knight: Player
    {
        public Knight()
        {
            //Console.WriteLine("Knight 생성자 호출");
            base.hp = 100;
        }
    }
    class MAge : Player
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight();
            Console.WriteLine($"HP: {knight.hp}");
            knight.Move();
            knight.Attack();

            Thread.Sleep(3000);
        }
    }
}