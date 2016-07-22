using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Bileti
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YAZLIK SİNEMA");
            int tambilet = 0, ogrenci = 0, toplam = 0 ;
            double geneltoplam = 0;
            ConsoleKeyInfo  yiyecek, biletsecim;
            int film = 0, sinema = 0, seans = 0;
            int paket1 = 0, paket2 = 0, paket3 = 0, paket4 = 0, paket5 = 0, paket6 = 0, paket7 = 0, paket8 = 0, paket9 = 0, paket10 = 0, paket11 = 0, paket12 = 0, paket13 = 0, paket14 = 0, paket15 = 0, paket16 = 0;

            string[] filmler = { "1.Film ", "2.Film ", "3.Film ", "4.Film ", "5.Film ", "6.Film " };

            string[] paket = new string[16];
            string[][] SinemaSalonu = new string[6][];
            SinemaSalonu[0] = new string[5] {"11.30","14.00","16.30","19.00","21.30" };
            SinemaSalonu[1] = new string[6] {"11.00", "13.15", "15.30", "17.45", "20.00", "22.15" };
            SinemaSalonu[2] = new string[4] { "12.00", "14.30", "17.00", "19.30"};
            SinemaSalonu[3] = new string[5] { "11.30", "14.00", "16.30", "19.00", "21.30" };
            SinemaSalonu[4] = new string[4] { "11.45", "14.15", "16.45", "19.15" };
            SinemaSalonu[5] = new string[4] { "11.30", "14.30", "17.30", "20.30" };

            filmsecimi:
            for (int i = 0; i < SinemaSalonu.GetLongLength(0); i++)
            {
                Console.Write(i + 1 + ". Salon\t" + filmler[i] + "\t");
                foreach (var salon in SinemaSalonu[i])
                {
                    Console.Write(salon + "\t");
                }
                Console.WriteLine();
            }

            Console.Write("Film Seçiniz. (1-6)");
            int secilenfilm = int.Parse(Console.ReadLine());
            seanssecimi:
            Console.Clear();
            Console.WriteLine("YAZLIK SİNEMA");
            switch (secilenfilm)
            {
                case 1:
                    film = 0;
                    Console.WriteLine(filmler[0]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[0])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string seçilenseans1 = Console.ReadLine();
                    switch (seçilenseans1)
                    {
                        case "11.30":
                            sinema = 0;
                            seans = 0;
                            bastansec:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if(biletsecim.Key==ConsoleKey.Backspace)
                            {
                                goto bastansec;
                            }

                            break;
                        case "14.00":
                            sinema = 0;
                            seans = 1;
                        bastansec01:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec01;
                            }

                            break;
                        case "16.30":
                            sinema = 0;
                            seans = 2;
                        bastansec02:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec02;
                            }

                            break;
                        case "19.00":
                            sinema = 0;
                            seans = 3;
                        bastansec03:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec03;
                            }

                            break;
                        case "21.30":
                            sinema = 0;
                            seans = 4;
                        bastansec04:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec04;
                            }

                            break;
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;
                            
                    }
                    break;
                case 2:
                    film = 1;
                    Console.WriteLine(filmler[1]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[1])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string seçilenseans = Console.ReadLine();
                    switch (seçilenseans)
                    {
                        case "11.00":
                            sinema = 1;
                            seans = 0;
                        bastansec10:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec10;
                            }

                            break;
                        case "13.15":
                            sinema = 1;
                            seans = 1;
                        bastansec11:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec11;
                            }

                            break;
                        case "15.30":
                            sinema = 1;
                            seans = 2;
                        bastansec12:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec12;
                            }

                            break;
                        case "17.45":
                            sinema = 1;
                            seans = 3;
                        bastansec13:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec13;
                            }

                            break;
                        case "20.00":
                            sinema = 1;
                            seans = 4;
                        bastansec14:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec14;
                            }

                            break;
                        case "22.15":
                            sinema = 1;
                            seans = 5;
                        bastansec15:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec15;
                            }
                            break;
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;

                    }
                    break;
                case 3:
                    film = 2;
                    Console.WriteLine(filmler[2]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[2])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string secilenseans = Console.ReadLine();
                    switch (secilenseans)
                    {
                        case "12.00":
                            sinema = 2;
                            seans = 0;
                        bastansec20:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec20;
                            }

                            break;
                        case "14.30":
                            sinema = 2;
                            seans = 1;
                        bastansec21:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec21;
                            }

                            break;
                        case "17.00":
                            sinema = 2;
                            seans = 2;
                        bastansec22:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec22;
                            }
                            break;
                        case "19.30":
                            sinema = 2;
                            seans = 3;
                        bastansec23:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec23;
                            }

                            break;
                        
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;

                    }
                    break;
                case 4:
                    film = 3;
                    Console.WriteLine(filmler[3]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[3])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string secilenseans1 = Console.ReadLine();
                    switch (secilenseans1)
                    {
                        case "11.30":
                            sinema = 3;
                            seans = 0;
                        bastansec30:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec30;
                            }

                            break;
                        case "14.00":
                            sinema = 3;
                            seans = 1;
                        bastansec31:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec31;
                            }

                            break;
                        case "16.30":
                            sinema = 3;
                            seans = 2;
                        bastansec32:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec32;
                            }

                            break;
                        case "19.00":
                            sinema = 3;
                            seans = 3;
                        bastansec33:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec33;
                            }

                            break;
                        case "21.30":
                            sinema = 3;
                            seans = 4;
                        bastansec34:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec34;
                            }

                            break;
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;

                    }
                    break;
                case 5:
                    film = 4;
                    Console.WriteLine(filmler[4]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[4])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string seçilenseans3 = Console.ReadLine();
                    switch (seçilenseans3)
                    {
                        case "11.45":
                            sinema = 4;
                            seans = 0;
                        bastansec40:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec40;
                            }

                            break;
                        case "14.15":
                            sinema = 4;
                            seans = 1;
                        bastansec41:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec41;
                            }

                            break;
                        case "16.45":
                            sinema = 4;
                            seans = 2;
                        bastansec42:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec42;
                            }

                            break;
                        case "19.15":
                            sinema = 4;
                            seans = 3;
                        bastansec43:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec43;
                            }

                            break;
                        
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;

                    }
                    break;
                case 6:
                    film = 5;
                    Console.WriteLine(filmler[5]);
                    Console.WriteLine("Seans Seçiniz.");
                    foreach (var salon in SinemaSalonu[5])
                    {
                        Console.Write(salon + "\t");
                    }
                    Console.WriteLine(": ");
                    string seçilenseans4 = Console.ReadLine();
                    switch (seçilenseans4)
                    {
                        case "11.30":
                            sinema = 5;
                            seans = 0;
                        bastansec50:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec50;
                            }

                            break;
                        case "14.30":
                            sinema = 5;
                            seans = 1;
                        bastansec51:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec51;
                            }

                            break;
                        case "17.30":
                            sinema = 5;
                            seans = 2;
                        bastansec52:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec52;
                            }

                            break;
                        case "20.30":
                            sinema = 5;
                            seans = 3;
                        bastansec53:
                            tambilet = bilettam(film, sinema, seans);
                            ogrenci = biletogrenci(film, sinema, seans, tambilet);
                            Console.WriteLine("Bilet tipi seçimine geri dönmek için 'BackSpace' e basınız");
                            Console.WriteLine("Devam etmek için herhangi bir tuşa basınız");
                            biletsecim = Console.ReadKey();
                            if (biletsecim.Key == ConsoleKey.Backspace)
                            {
                                goto bastansec53;
                            }

                            break;
                        
                        default:
                            Console.WriteLine("Hatalı Seçim Yaptınız.");
                            Console.ReadLine();
                            goto seanssecimi;

                    }
                    break;

                default:
                    Console.WriteLine("Hatalı Seçim Yaptınız.");
                    Console.ReadLine();
                    goto filmsecimi;
                    
            }
            Console.Clear();
            Console.WriteLine("YAZLIK SİNEMA");
            Console.WriteLine(secilenfilm + ". Salon : " + filmler[film]);
            Console.WriteLine("Saat : " + SinemaSalonu[sinema][seans]);
            Console.WriteLine("Tam Bilet :" + tambilet + "\tÖğrenci :" + ogrenci);
            toplam = (tambilet * 15) + (ogrenci * 10);
        evethayir:
            Console.Write("Yiyecek ve içecek seçmek ister misiniz?(e/h)");
            yiyecek = Console.ReadKey();
            Console.Clear();
            Console.WriteLine("YAZLIK SİNEMA");
            Console.WriteLine(secilenfilm + ". Salon : " + filmler[film]);
            Console.WriteLine("Saat : " + SinemaSalonu[sinema][seans]);
            Console.WriteLine("Tam Bilet :" + tambilet + "\tÖğrenci :" + ogrenci);
            if (yiyecek.Key==ConsoleKey.E)
            {
                int secilenpaket = 0;
                do
                {
                yemeksec:
                    Console.Clear();
                
                    Console.WriteLine("Ürün alımı tamamlandığında 0'a basın");
                    if (tambilet >= 2)
                    {
                        Console.WriteLine("Paket1 -> Küçük boy Patlamış Mısır ve Kola : 10.00 Tl");
                        Console.WriteLine("Paket2 -> Orta boy Patlamış Mısır ve Kola : 15.00 Tl");
                        Console.WriteLine("Paket3 -> Orta boy Patlamış Mısır ve 2 Kola : 17.50 Tl");
                        Console.WriteLine("Paket4 -> Büyük boy Patlamış Mısır ve 2 Kola : 20.00 Tl");
                    }
                    if (ogrenci >= 2)
                    {
                        Console.WriteLine("Paket5 -> Küçük boy Patlamış Mısır ve Kola : 8.00 Tl");
                        Console.WriteLine("Paket6 -> Orta boy Patlamış Mısır ve Kola : 12.50 Tl");
                        Console.WriteLine("Paket7 -> Orta boy Patlamış Mısır ve 2 Kola : 15.00 Tl");
                        Console.WriteLine("Paket8 -> Büyük boy Patlamış Mısır ve 2 Kola : 17.50 Tl");
                    }
                    if (ogrenci < 2 && tambilet < 2)
                    {
                        Console.WriteLine("Paket9 -> Küçük boy Patlamış Mısır ve Kola : 12.00 Tl");
                        Console.WriteLine("Paket10 -> Orta boy Patlamış Mısır ve Kola : 17.50 Tl");
                        Console.WriteLine("Paket11 -> Orta boy Patlamış Mısır ve 2 Kola : 20.00 Tl");
                        Console.WriteLine("Paket12 -> Büyük boy Patlamış Mısır ve 2 Kola : 22.50 Tl");
                    }

                    Console.WriteLine("Kola(13) : 4.00 Tl");
                    Console.WriteLine("Küçük Boy Mısır(14) : 10.00 Tl");
                    Console.WriteLine("Orta Boy Mısır(15) : 15.00 Tl");
                    Console.WriteLine("Büyük Boy Mısır(16) : 17.50 Tl");


                    secilenpaket = int.Parse(Console.ReadLine());
                    switch (secilenpaket)
                    {
                        case 0: break;
                        case 1: paket1++; geneltoplam += 10.00; break;
                        case 2: paket2++; geneltoplam += 15.00; break;
                        case 3: paket3++; geneltoplam += 17.50; break;
                        case 4: paket4++; geneltoplam += 20.00; break;
                        case 5: paket5++; geneltoplam += 8.00; break;
                        case 6: paket6++; geneltoplam += 12.50; break;
                        case 7: paket7++; geneltoplam += 15.00; break;
                        case 8: paket8++; geneltoplam += 17.50; break;
                        case 9: paket9++; geneltoplam += 12.00; break;
                        case 10: paket10++; geneltoplam += 17.50; break;
                        case 11: paket11++; geneltoplam += 20.00; break;
                        case 12: paket12++; geneltoplam += 22.50; break;
                        case 13: paket13++; geneltoplam += 4.00; break;
                        case 14: paket14++; geneltoplam += 10.00; break;
                        case 15: paket15++; geneltoplam += 15.00; break;
                        case 16: paket16++; geneltoplam += 17.50; break;
                        default:
                            Console.WriteLine("Hatalı seçim yaptınız.");
                            goto yemeksec;
                            
                    }

                } while (secilenpaket != 0);
                Console.Clear();
                Console.WriteLine("YAZLIK SİNEMA");
                Console.WriteLine(secilenfilm+". Salon : "+filmler[film]);
                Console.WriteLine("Saat : " + SinemaSalonu[sinema][seans]);
                Console.WriteLine("Tam Bilet :" + tambilet + "\tÖğrenci :" + ogrenci);
                Console.WriteLine("Seçilen paketler");

                if(paket1 !=0)
                {
                    Console.WriteLine(paket1 + " adet küçük boy mısır ve kola seçtiniz.");
                }
                if (paket2 != 0)
                {
                    Console.WriteLine(paket2 + " adet Orta boy Patlamış Mısır ve Kola seçtiniz.");
                }
                if (paket3 != 0)
                {
                    Console.WriteLine(paket3 + " adet Orta boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket4 != 0)
                {
                    Console.WriteLine(paket4 + " adet Büyük boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket5 != 0)
                {
                    Console.WriteLine(paket5 + " adet küçük boy mısır ve kola seçtiniz.");
                }
                if (paket6 != 0)
                {
                    Console.WriteLine(paket6 + " adet Orta boy Patlamış Mısır ve Kola seçtiniz.");
                }
                if (paket7 != 0)
                {
                    Console.WriteLine(paket7 + " adet Orta boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket8 != 0)
                {
                    Console.WriteLine(paket8 + " adet Büyük boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket9 != 0)
                {
                    Console.WriteLine(paket9 + " adet küçük boy mısır ve kola seçtiniz.");
                }
                if (paket10 != 0)
                {
                    Console.WriteLine(paket10 + " adet Orta boy Patlamış Mısır ve Kola seçtiniz.");
                }
                if (paket11 != 0)
                {
                    Console.WriteLine(paket11 + " adet Orta boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket12 != 0)
                {
                    Console.WriteLine(paket12 + " adet Büyük boy Patlamış Mısır ve 2 Kola seçtiniz.");
                }
                if (paket13 != 0)
                {
                    Console.WriteLine(paket13 + " adet Kola seçtiniz.");
                }
                if (paket14 != 0)
                {
                    Console.WriteLine(paket14 + " adet küçük boy mısır seçtiniz.");
                }
                if (paket15 != 0)
                {
                    Console.WriteLine(paket15 + " adet orta boy mısır seçtiniz.");
                }
                if (paket16 != 0)
                {
                    Console.WriteLine(paket16 + " adet büyük boy mısır seçtiniz.");
                }

                Console.Write("Toplam borcunuz ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(geneltoplam+toplam + ".00");
                Console.ResetColor();
                Console.WriteLine(" Tl'dir");



            }
            else if(yiyecek.Key==ConsoleKey.H)
            {
                
                Console.Write("Toplam borcunuz ");
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(toplam + ".00");
                Console.ResetColor();
                Console.WriteLine(" Tl'dir");
            }
            else
            {
                Console.WriteLine("Hatalı Seçim Yaptınız.");
                Console.ReadLine();
                goto evethayir;
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("İyi Seyirler...");

            Console.ReadLine();

        }

        static int bilettam(int film, int sine, int sean)
        {
            Console.WriteLine("YAZLIK SİNEMA");
            int tambilet = 0;
            
            ConsoleKeyInfo bilettipi;
            string[] filmler = { "1.Film ", "2.Film ", "3.Film ", "4.Film ", "5.Film ", "6.Film " };

            string[][] SinemaSalonu = new string[6][];
            SinemaSalonu[0] = new string[5] { "11.30", "14.00", "16.30", "19.00", "21.30" };
            SinemaSalonu[1] = new string[6] { "11.00", "13.15", "15.30", "17.45", "20.00", "22.15" };
            SinemaSalonu[2] = new string[4] { "12.00", "14.30", "17.00", "19.30" };
            SinemaSalonu[3] = new string[5] { "11.30", "14.00", "16.30", "19.00", "21.30" };
            SinemaSalonu[4] = new string[4] { "11.45", "14.15", "16.45", "19.15" };
            SinemaSalonu[5] = new string[4] { "11.30", "14.30", "17.30", "20.30" };
            do
            {
            bilettipisecimi:
                Console.Clear();
                Console.ResetColor();

                Console.WriteLine("YAZLIK SİNEMA");
                Console.WriteLine(filmler[film]);
                Console.WriteLine(SinemaSalonu[sine][sean]);

                Console.WriteLine("Tambilet adedi seçiniz ; \t(tamamladığınız 'Enter' a tıklayınız.)");


                Console.WriteLine("Tam Bilet(t)\t" + tambilet);
                bilettipi = Console.ReadKey();

                if (bilettipi.Key == ConsoleKey.T)
                {
                    tambilet++;
                }
                else if (bilettipi.Key != ConsoleKey.T && bilettipi.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız.");
                    Console.ReadLine();
                    goto bilettipisecimi;
                }

            } while (bilettipi.Key != ConsoleKey.Enter);

            
            return tambilet;

        }

        static int biletogrenci(int film, int sine, int sean,int tam)
        {
            Console.WriteLine("YAZLIK SİNEMA");
            int tambilet = tam, ogrenci = 0;
            DateTime simdikizaman = new DateTime();
            simdikizaman = DateTime.Now;
            TimeSpan ogrenciyas;
            ConsoleKeyInfo bilettipi;
            string[] filmler = { "1.Film ", "2.Film ", "3.Film ", "4.Film ", "5.Film ", "6.Film " };

            string[][] SinemaSalonu = new string[6][];
            SinemaSalonu[0] = new string[5] { "11.30", "14.00", "16.30", "19.00", "21.30" };
            SinemaSalonu[1] = new string[6] { "11.00", "13.15", "15.30", "17.45", "20.00", "22.15" };
            SinemaSalonu[2] = new string[4] { "12.00", "14.30", "17.00", "19.30" };
            SinemaSalonu[3] = new string[5] { "11.30", "14.00", "16.30", "19.00", "21.30" };
            SinemaSalonu[4] = new string[4] { "11.45", "14.15", "16.45", "19.15" };
            SinemaSalonu[5] = new string[4] { "11.30", "14.30", "17.30", "20.30" };
            do
            {
            bilettipisecimi:
                Console.Clear();                

                Console.WriteLine("YAZLIK SİNEMA");
                Console.WriteLine(filmler[film]);
                Console.WriteLine(SinemaSalonu[sine][sean]);

                Console.WriteLine("Öğrenci bileti adedi seçiniz ; \t(tamamladığınız 'Enter' a tıklayınız.)");

                Console.WriteLine("Tam Bilet\t" + tambilet);
                Console.WriteLine("Öğrenci(o)\t" + ogrenci);
                bilettipi = Console.ReadKey();

                
                if (bilettipi.Key == ConsoleKey.O)
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Doğum tarihinizi giriniz(GG/AA/YYYY) : ");
                    DateTime dogumgunu = Convert.ToDateTime(Console.ReadLine());
                    Console.ResetColor();
                    ogrenciyas = simdikizaman - dogumgunu;
                    if (ogrenciyas.TotalDays / 365 < 26)
                    {
                        ogrenci++;
                    }
                    else
                    {
                        Console.Write("Yaşınız 26'nın üzerinde olduğu için öğrenci olarak kabul görmüyorsunuz. lütfen baştan seçim yapınız.");
                        Console.ReadLine();
                        goto bilettipisecimi;
                    }
                }
                else if (bilettipi.Key != ConsoleKey.O && bilettipi.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("Hatalı Seçim Yaptınız.");
                    Console.ReadLine();
                    goto bilettipisecimi;
                }

            } while (bilettipi.Key != ConsoleKey.Enter);

            Console.Clear();
            Console.WriteLine("YAZLIK SİNEMA");
            Console.WriteLine(filmler[film]);
            Console.WriteLine(SinemaSalonu[sine][sean]);
            Console.WriteLine("Tam Bilet :" + tambilet + "\tÖğrenci :" + ogrenci);

            return ogrenci;

        }
    }
}
