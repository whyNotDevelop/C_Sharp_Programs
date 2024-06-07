namespace ManageEmployees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Mage();
            character.performSpecialAbility();
            //character.childMethod();

        }
    }
    /*
 You are developing a game engine for a role-playing game (RPG) where players can control 
 different types of characters, such as warriors, mages, and archers. Each character type 
 has common attributes like health points (HP), attack points (AP), and defense points (DP), 
 but they also possess unique abilities and characteristics.

 Design a class hierarchy that represents the different character types in the game using inheritance. 
 Ensure that common attributes and behaviors are captured in a base class, while specific attributes and
 behaviors are implemented in derived classes.

 Additionally, implement abstraction by defining an abstract method called performSpecialAbility()
 in the base class. This method should represent a character's unique special ability, such as a 
 warrior's "shield bash" or a mage's "fireball spell". Each derived class should provide its implementation
 for the performSpecialAbility() method to define its unique ability.

 Consider how inheritance allows you to reuse code and structure your classes efficiently, while abstraction
 enables you to define a common interface for different character types
 while allowing for variations in their special abilities.
*/
    internal abstract class Character
    {
        protected double HP;
        protected double AP;
        protected double DP;
        protected string name;
        protected int ranking;

        public abstract void performSpecialAbility();
    }
    internal class Warrior:Character
    {
        public override void performSpecialAbility()
        {
            Console.WriteLine("shield bash");
        }
    }
    internal class Mage: Character
    {
        public override void performSpecialAbility()
        {
            Console.WriteLine("fireball spell");
        }

        public void childMethod()
        {
            Console.WriteLine("I am a method found on this class only");
        }
    }

}