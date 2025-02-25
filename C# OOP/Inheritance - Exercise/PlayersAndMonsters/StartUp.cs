using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            MuseElf museElf = new MuseElf("Peter", 2);
            Console.WriteLine(museElf.ToString());
            SoulMaster soulMaster = new SoulMaster("Ivan", 3);
            Console.WriteLine(soulMaster.ToString());
            BladeKnight bladeKnight = new BladeKnight("Maria", 3);
            Console.WriteLine(bladeKnight.ToString());
            Elf elf = new Elf("Rudolph", 1);
            Console.WriteLine(elf.ToString());
        }
    }
}