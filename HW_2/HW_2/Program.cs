using System;

namespace HW_2
{
    class Program
    {
        static void Main(string[] args)
        {


            //========================================================
            //  1.Uzdevums - Sasveicināšanās konsoles aplikācija
            //  Izveidot konsoles aplikāciju, kas pavaicā un iegūst lietotāja vārdu, un sasveicinās ar konkrēto lietotāju


            Console.WriteLine("Kā tevi sauc?");

            string userName = Console.ReadLine();

            Console.WriteLine("Sveiks, " + userName);


            //========================================================
            //  2. uzdevums - int.Parse
            //  Iegūst lietotāja vecumu un izvada lietotājam cik gadi viņam paliks nākamgad int.Parse


            Console.WriteLine("Kāds ir tavs vecums?");

            int userAge = int.Parse(Console.ReadLine());

            int userAge2 = userAge + 1;

            Console.WriteLine("Tavs vecums, " + userAge + " Nakamgad tev būs, " + userAge2);


            //========================================================
            //  3. uzdevums - Math.Max
            //  Iegūt no lietotāja skaitļus un atrādīt lietotājam lielāko skaitli


            Console.WriteLine("Ieraksti pirmo skaitli");

            int myNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ieraksti otro skaitli");

            int myNumber2 = int.Parse(Console.ReadLine());

            int maxResult = Math.Max(myNumber1, myNumber2);

            Console.WriteLine("Lielākais skaitlis ir: " + maxResult);


            //========================================================
            //  4.uzdevums - Math.Min
            //  Iegūt no lietotāja skaitļus un atrādīt lietotājam mazāko skaitli


            Console.WriteLine("Ieraksti pirmo skaitli");

            int myNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ieraksti otro skaitli");

            int myNumber2 = int.Parse(Console.ReadLine());

            int minResult = Math.Min(myNumber1, myNumber2);

            Console.WriteLine("Mazākais skaitlis ir: " + minResult);


            //========================================================
            //  5.uzdevums - %
            //  Iegūt no lietotāja skaitļus un atrādīt dalījuma atlikumu


            Console.WriteLine("Lai izdalītu īeraksti pirmo skaitli");

            int myNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ieraksti otro skaitli");

            int myNumber2 = int.Parse(Console.ReadLine());

            int divResult = myNumber1 % myNumber2;

            Console.WriteLine("Dalijuma atlikums ir: " + divResult);


            //========================================================
            //  6.uzdevums - Odd or Even
            //  Iegūt no lietotāja skaitli un parādīt vai lietotājs ievadījis pāra vai nepāra skaitli


            Console.WriteLine("Ieraksti skaitli, lai noteiktu vai tas ir pāra skaitlis: ");

            int myNumber = int.Parse(Console.ReadLine());

            int resultOne = myNumber % 2;

            bool resultEnd1 = resultOne == 0;

            Console.WriteLine(resultEnd1);



            //========================================================
            //  7.uzdevums - Taisnstūra laukuma aprēķināšana
            //  Iegūt no lietotāja taisnstūra malu vērtības un aprēķināt taisnstūra laukumu. Precīzi jāaprēķina laukums arī ja tas sanāk decimāldaļās jānoapaļo ar 2 cipariem aiz komata


            Console.WriteLine("Lai apreiķinātu taisnistūra laukumu ievadi malu vērtības ");
            Console.WriteLine("Malas A vērtība: ");

            double sideA = double.Parse(Console.ReadLine());

            Console.WriteLine("Malas B vērtība: ");

            double sideB = double.Parse(Console.ReadLine());

            double squareSize = sideA * sideB;

            double squareSizeRounded = Math.Round(squareSize, 2);

            Console.WriteLine("Taisnistūra laukums ir: " + squareSizeRounded);



            //========================================================
            //  8.uzdevums - Trijstūra laukuma aprēķināšana
            //  Iegūt no lietotāja skaitli, lai aprēķinātu vienādsānu trijstūra laukumu


            Console.WriteLine("Lai aprēķinātu vienādsānu trijstūra laukumu ievadi malas garumu: ");

            double triangleSide = double.Parse(Console.ReadLine());

            double triangleArea = (triangleSide * triangleSide * (Math.Sqrt(3))) / 4;

            double triangleAreaRounded = Math.Round(triangleArea, 2);

            Console.WriteLine("Vienādsānu trijstūra laukums ir: " + triangleAreaRounded);



            //========================================================
            //  9.uzdevums - Interpolācija
            //  Iegūst lietotāja vecumu un izvada lietotājam vārdu un vecumu izmantojot interpolāciju


            Console.WriteLine("Kāds ir tavs vecums?");

            string myName = Console.ReadLine();

            Console.WriteLine("Kāds ir tavs vecums?");

            int myAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Sveiks " + myName + ", tavs vecums ir " + myAge);


        }
    }
}
