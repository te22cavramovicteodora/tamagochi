
Weapon invandrare = new("invandrare");

invandrare.Attack();
int damage = Random.Shared.Next(invandrare.MinDamage, invandrare.MaxDamage);

Console.WriteLine(damage);
Console.ReadLine();