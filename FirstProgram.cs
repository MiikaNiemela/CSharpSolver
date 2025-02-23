// File: FirstProgram.cs
//
namespace Matematiikan
{
    class Tehtävä
    {
        static void Tulosta(string tuloste)
        {
            Console.WriteLine(tuloste);
        }
        // Keskinopeus on matka jaettuna ajalla.
        static int LaskeKeskinopeus(int matka, int aika)
        {
            return matka / aika;
        }
        // Calculate average speed, print out the 
        /// <summary>
        /// Laskee keskinopeuden annetun matkan ja ajan perusteella.
        /// </summary>
        /// <param name="matka">Kuljettu matka.</param>
        /// <param name="aika">Aika, joka kului matkan kulkemiseen.</param>
        /// <param name="matkaYksikkö">Matkan yksikkö (oletus on "km").</param>
        /// <param name="ajanYksikkö">Ajan yksikkö (oletus on "h").</param>
        /// <returns>Keskinopeus, joka lasketaan jakamalla matka ajalla.</returns>
        int Keskinopeus(int matka, int aika, string? matkaYksikkö = "km", string? ajanYksikkö = "h")
        {
            int keskinopeus = LaskeKeskinopeus(matka, aika);
            Tulosta($"{matka}{matkaYksikkö}/{aika}{ajanYksikkö} = {keskinopeus} {matkaYksikkö}/{ajanYksikkö}");
            return keskinopeus;
        }
        static void Main(string[] args)
        {
            // 1
            Console.WriteLine("Taituri tehtävä 10 sivulta 29/n");
            // tehtävä a.
            int a = 5;
            int b = a;
            int c = a + b;
            int d = a + b + c;
            Console.WriteLine("Tehtävä a vastaus on: " + d);

            // tehtävä b.
            a = 6;
            b = 2;
            c = 8;
            d = a + b + c;
            Console.WriteLine("tehtävä b vastaus on: " + d);
        }
    }
}

/*
// 1
Console.WriteLine("Taituri tehtävä 10 sivulta 29/n");
// tehtävä a.
int a = 5;
int b = a;
int c = a + b;
int d = a + b + c;
Console.WriteLine("Tehtävä a vastaus on: " + d);

// tehtävä b.
a = 6;
b = 2;
c = 8;
d = a + b + c;
Console.WriteLine("tehtävä b vastaus on: " + d);


// 2
Console.WriteLine("Kotitehtävä 2 Sivulta 29");
// matkalla 15.7. - 26.7.
int matkallaPäiviä = 26 - 15;
Console.WriteLine("Kasperi matkalla " + matkallaPäiviä + " päivää");
int kaksiViikkoa = 14;
int perilläKahdenViikonJälkeen = 15 + kaksiViikkoa;
Console.WriteLine("KAhden viikon matka loppuu " + perilläKahdenViikonJälkeen + ".7. ");
*/

/*
// 3
Console.WriteLine("Kotitehtävä 1(a,b,c ja d) Sivulta 33");
// Nopeus ja aika
// Keskinopeus on matka jaettuna ajalla.
// Huomioi matkan ja ajan yksikkö

//1.a.
Tulosta("1.a. vastaus:" + laskeKeskinopeus(240, 4));

//1.b.
Tulosta("1.b. vastaus:" + laskeKeskinopeus(27, 3));

//1.c.
Tulosta("1.c vastaus:" + laskeKeskinopeus(200, 40));
*/