using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string altSatir = "\r\n";

            Console.WriteLine("Para hesabı uygulamasına hoş geldiniz");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz..");
            Console.WriteLine("1- Güncel bakiyeni kaydet" + altSatir + "2- Güncel bakiyem ile neler yapabileceğini öğren." + altSatir +
            "3- Paranı biriktirmeye başla.");



            int chose = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lüfen güncel paranızı giriniz : ");
            int Money = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Güncel Paranız : " + Money);

            switch (chose)
            {
                case 1:
                    int newMoney = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Güncel Paranız : " + newMoney);
                    break;
                case 2:
                    int updatedMoney = Money;
                    Console.WriteLine("Şuan ki paranız ile yapabilecekleriniz : ");
                    if(updatedMoney <= 200)
                    {
                        Console.WriteLine("Şuan'da yapabileceğiniz şeyler : "
                        + altSatir
                        + "1. Güzel bir soslu Makarna yemek."
                        + altSatir
                        + "2. Paranızı harcamayıp biriktirmek." 
                        + altSatir
                        + "3. Bit pazarından güzel kıyafteler almak."
                        );
                        int lowerThan200 = Convert.ToInt32(Console.ReadLine());
                        if (lowerThan200 == 1)
                        {
                            Console.WriteLine("Şuan'da yapabileceğiniz soslu makarnalar"
                            +altSatir
                            + "Kremalı Mantarlı Makarna"
                            +altSatir
                            + "Domates Salçalı Makarna"
                            +altSatir
                            + "Tavuklu Körili Makarna"
                            +altSatir
                            + "Hepsini BİM'den uygun bir fiyata alabilirsiniz.");
                        } else if(lowerThan200 == 2)
                        {
                            Console.WriteLine("Lütfen biriktirmek istediğiniz miktarı giriniz : ");
                            int toCollect = Convert.ToInt32(Console.ReadLine());
                            int toCollectCalculator = toCollect - updatedMoney;
                            Console.WriteLine(" Bu miktarı biriktirmek için : " + toCollectCalculator + "TL'ye ihtiyacınız var.");
                        } else if(lowerThan200 == 3)
                        {
                            Console.WriteLine("Bit pazarından ne kadarlık bir alışveriş yapmak istiyorsunuz : ");
                            int bitPazari = Convert.ToInt32(Console.ReadLine());
                            int bitPazariCalculator = updatedMoney - bitPazari;
                            if(bitPazariCalculator >= updatedMoney)
                            {
                                Console.WriteLine("Bu alışverişi yapabilirsiniz...");
                            }else
                            {
                                Console.WriteLine("Bu alışverişi yapamazsınız...");

                            }
                        }
                    }
                    else if (updatedMoney > 200)
                    {
                        Console.WriteLine("Bu para ile neler yapmak istersiniz : " + updatedMoney 
                        + altSatir 
                        + "1- Yeni bir kıyafet almak."
                        + altSatir
                        + "2- Güzel bir yemek yapmak veya yemek."
                        + altSatir
                        + "3- Oda içerisine akseksuar almak");
                        int Highersecim = Convert.ToInt32(Console.ReadLine());
                        if(Highersecim == 1)
                        {
                            Console.WriteLine("Lütfen almak istediğiniz kıyfatin bütçesini giriniz.");
                            int clothes = Convert.ToInt32(Console.ReadLine());
                            int clothesCalculator = clothes - updatedMoney;
                            Console.WriteLine("Bu kıyafeti almanız için bu kadar para biriktirmeniz lazım : " + clothesCalculator);
                        } else if(Highersecim == 2)
                        {
                            Console.WriteLine("Yemek istediğiniz yemeği veya yapmak istediğiniz yemeğin bütçesini lütfen giriniz : ");
                            int food = Convert.ToInt32(Console.ReadLine());
                            int foodCalcular = food - updatedMoney;
                            if(foodCalcular < updatedMoney)
                            {
                                Console.WriteLine("Bu yemeniz için bu kadar lazım : " + foodCalcular);
                            }
                            else
                            {
                                
                                Console.WriteLine("Bence direkt olarak yemelisin..");
                            }
                            
                        } else if ((Highersecim == 3))
                        {
                            Console.WriteLine("Lütfen almak istediğiniz akseksuarın bütçesini giriniz : ");
                            int akseksuar = Convert.ToInt32(Console.ReadLine());
                            int akseksuarCalculator = akseksuar - updatedMoney;
                           if(akseksuarCalculator < updatedMoney)
                            {
                                Console.WriteLine("Bu alışverişi yapabilirsin :) ");

                                
                            }
                            else
                            {
                                
                                Console.WriteLine("Bu alışverişi yapmanız için bu kadar para biriktirmeniz lazım  : " + akseksuarCalculator);

                            }
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem yapınız");
                        }
                    }
                    break;
                case 3:
                    Console.WriteLine("Paranı biriktirmeye hazır mısın ? : ");
                    string saving = Console.ReadLine();
                    if(saving == "evet")
                    {
                        Console.WriteLine("Baya iyi şimdi biriktirmek istediğin miktarı gir ve hesaplama yapayım. : ");
                        int miktar = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Bu parayı biriktirmen için şuandan itibaren bu kadar para lazım : " + (miktar - Money)+"TL");
                    }else if(saving == "hayır")
                    {
                        Console.WriteLine("İradeni kuvetlendir ve öyle gel");
                    }
                    else
                    {
                        Console.WriteLine("Amacın ne dostum");
                    }

                    
                    break;
            }
        }
    }
}
