//genereerib random number 0-10

//Random rnd = new Random(); //oskab meie süsteemist juhuslikku numbrit kätte saada

//int myRandomNum = rnd.Next(0, 11); // genereeritakse 0 - 10, viimane väärtus pole kaasa arvatud
//Console.WriteLine($"My random number is: {myRandomNum}");

//genereerib 3 korda random number

//Random rnd = new Random();

//int myRandomNum;//deklareerin selle väljas pool for blocki, et vajadusel saaks seda väärtust kätte saada

//for (int i = 0; i < 3; i++)
//{
//    myRandomNum = rnd.Next(0, 11);
//    Console.WriteLine($"My random number is: {myRandomNum}");
//}

//genereerib random numbrite summa
Random rnd = new Random();

int myRandomNum;

int randomSum = 0;

for (int i = 0; i < 3; i++)
{
    myRandomNum = rnd.Next(0, 11); // genereeritakse 0 - 10, viimane väärtus pole kaasa arvatud
    randomSum = randomSum + myRandomNum;
    Console.WriteLine($"My random number is: {myRandomNum}");
}

Console.WriteLine($"Random sum total: {randomSum}");