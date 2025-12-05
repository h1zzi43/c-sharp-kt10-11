using System;
using System.Collections.Generic;

namespace App.Tasks.Task1_CharacterFactory;

public interface ICharacter
{
    string Name { get; set; }
    void Attack();
}

public class Warrior : ICharacter
{
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Воин наносит удар мечом!");
    }
}

public class Mage : ICharacter
{
    public string Name { get; set; }

    public void Attack()
    {
        Console.WriteLine("Маг кастует огненный шар!");
    }
}

public class CharacterFactory<T> where T : ICharacter, new()
{
    public T Create(string name)
    {
        T character = new T();
        character.Name = name;
        return character;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var warriorFactory = new CharacterFactory<Warrior>();
        var mageFactory = new CharacterFactory<Mage>();

        var warrior = warriorFactory.Create("Артур");
        var mage = mageFactory.Create("Мерлин");

        warrior.Attack();
        mage.Attack();
    }
}
