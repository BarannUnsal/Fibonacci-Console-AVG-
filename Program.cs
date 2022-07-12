int n1 = 0, n2 = 1, n3, i, number, all = 0, ort = 0;
Console.Write("Kaç adet sayı olsun: ");
number = Convert.ToInt32(Console.ReadLine());
Console.Write(n1 + " " + n2 + " ");
for (i = 2; i < number; ++i)   
{
    n3 = n1 + n2;
    Console.Write(n3 + " ");
    n1 = n2;
    n2 = n3;
    all += number; 
}
ort = all / number;
Console.WriteLine($"Sayıların Ortalaması: {ort}");