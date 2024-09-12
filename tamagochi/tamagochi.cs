public class Weapon
{
public string Name;
public int MinDamage;
public int MaxDamage;

//ange parametrar altsp string name för ett A
public Weapon(string name)
{
    Name = name;
    MinDamage = Random.Shared.Next(8,12);
    MaxDamage = Random.Shared.Next(18,25);
}

public void Attack()
{
    Console.WriteLine($"Attacking with {Name}");
}
}
