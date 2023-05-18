//loetelu 1 kuni 10
//for(int i = 0; i < 10; i++)
//{
//    Console.WriteLine($"i = {i + 1}"); //see +1 ei muuda i väärtust, vaid muudab, mida kuvatakse; ilma +1 algaks loetelu 0'st
//}

//loetelu 10 kuni 1
//for (int i = 10; i > 0; i--) //i-- = i - 1
//{
//    Console.WriteLine($"i = {i}");
//}

//mis on kõigi i'de summa
int sum = 0;
for (int i = 1; i < 11; i++)
{
    Console.WriteLine($"i = {i}");
    Console.WriteLine($"Current total: {sum}");
    sum = sum + i; //sum += i;
}

Console.WriteLine($"Final total {sum}");//vahe viimase Current totali ja Final totali vahel tuleb, kuna programm for blockis ei arvesta real 15 oleva i++'iga 