using System;
using System.Data.SqlTypes;
using System.Security.Policy;
using static CSharpEssentials.Program;

namespace CSharpEssentials
{

    class 
    {
        public class User
        {

        }

        static void Main()
        {
            Character character = new Character();
            character.equipment.items[0].ShowItem();//Меч:10()
            character.equipment.items[1].ShowItem();//Лук:5()
            Console.WriteLine($"Общий вес: {character.equipment.GetWeightOfEquipment()}");//Общий вес: 15
        }
    }
}
