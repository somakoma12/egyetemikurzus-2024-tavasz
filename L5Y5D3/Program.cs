﻿// See https://aka.ms/new-console-template for more information
using L5Y5D3;

Console.WriteLine("Szia, ebben az appban egyszerű matek feladatokat kell majd megoldanod, minden jó megoldásért 1 pont jár.\nMegoldásnak egész számokat írj be, osztásnál lefelé kerekíts, pl: 5/2=2  ");
Random rand = new Random();

List<Kerdes> kerdesek = new List<Kerdes>();
List<Valasz> valaszok = new List<Valasz>();



for (int i = 0; i < 10; i++)
{
    kerdesek.Add(new Kerdes(rand));


}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(kerdesek[i].ToString());
    Console.WriteLine("Mennyivel egyenlő az alábbi egyenlet?");
    Console.Write($"({kerdesek[i].A}) {kerdesek[i].Muvelet} ({kerdesek[i].B}) = ");

    try
    {
        int valasz = Convert.ToInt32(Console.ReadLine());
        valaszok.Add(new Valasz(kerdesek[i], valasz));
        Console.WriteLine(valaszok[i].Helyesseg);
    }
    catch (OverflowException)
    {
        Console.Error.WriteLine("Túl nagy szám, írd újra!");
        i--;
    }
    catch (FormatException)
    {
        Console.Error.WriteLine("Nem számot írtál be! Számot írj te troll!!");
        i--;
    }catch(Exception e) { 
        Console.Error.WriteLine("Te mi a bánatot csinálsz????");
    }
}

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(valaszok[i].Valaszod);
}
