using Kolekcija_Rjecnik;

Dictionary<Student, List<int>> bodovi = new()
{
    {new("123","Ann","Diaz"), new(){ 23,12} },
    {new("321","John","Ab"), new(){ 54,2,3} }
};

bodovi.Add(new("122", "Jane", "Doe"), new() { 1, 44 });
//bodovi.Add(new("122", "John", "Doe"), new() { 1, 44 });

Student A = new("123", "Ann", "Diaz"),
    B = new("135", "Ivo", "Wagner");
bodovi[A] = new() { 1, 2, 3 };
try
{
    Console.WriteLine(bodovi[B].Sum());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
bodovi[B] = new() { 35 };
Ispis(bodovi);

List<int> rez;
Student C = new("111", "A", "B");
//if (!bodovi.TryGetValue(C, out rez!))
if (!bodovi.TryGetValue(B, out rez!))
    Console.WriteLine("Nema podataka za " + C);
else
    Console.WriteLine(rez.Sum());

Console.WriteLine("-----Ispis svih kljuceva:-----");
foreach(Student student in bodovi.Keys)
    Console.WriteLine(student);
Console.WriteLine("-----Ispis svih vrijednosti:-----");
foreach (List<int> rezultat in bodovi.Values)
{
    foreach(int b in rezultat) 
        Console.Write(b + " ");
    Console.WriteLine();
}

if (bodovi.Remove(A))
    Console.WriteLine("Uklonio element s kljucem " + A);
Ispis(bodovi);
void Ispis(Dictionary<Student, List<int>> bodovi)
{
    Console.WriteLine("Ispis sadržaja rječnika:");
    for (int i = 0; i < bodovi.Count; i++)
        Console.WriteLine(bodovi.ElementAt(i).Key
            + " " + bodovi.ElementAt(i).Value.Sum());
}
/* foreach(KeyValuePair<Student, List<int>> rezultat in bodovi)
{
    Console.WriteLine(rezultat.Key);
    Console.WriteLine("\t rezultat: " + rezultat.Value.Sum());
} */