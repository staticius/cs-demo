namespace CS_ONE;

public class Hello
{
    public static void Main(string[] args)
    {
        int ayNumber;
        
        Console.WriteLine("1 - 12 arası bir sayı giriniz: ");

        ayNumber = Convert.ToInt32(Console.ReadLine());

            switch (ayNumber)
            {
                case 1:
                    Console.WriteLine("{0} Ocak Ayı", ayNumber);
                    break;
                case 2:
                    Console.WriteLine("{0} Şubat Ayı", ayNumber);
                    break;
                case 3:
                    Console.WriteLine("{0} Mart Ayı", ayNumber);
                    break;
                case 4:
                    Console.WriteLine("{0} Nisan Ayı", ayNumber);
                    break;
                case 5:
                    Console.WriteLine("{0} Mayıs Ayı", ayNumber);
                    break;
                case 6:
                    Console.WriteLine("{0} Haziran Ayı", ayNumber);
                    break;
                case 7:
                    Console.WriteLine("{0} Temmuz Ayı", ayNumber);
                    break;
                case 8:
                    Console.WriteLine("{0} Ağustos Ayı", ayNumber);
                    break;
                case 9:
                    Console.WriteLine("{0} Eylül Ayı", ayNumber);
                    break;
                case 10:
                    Console.WriteLine("{0} Ekim Ayı", ayNumber);
                    break;
                case 11:
                    Console.WriteLine("{0} Kasım Ayı", ayNumber);
                    break;
                case 12:
                    Console.WriteLine("{0} Aralık Ayı", ayNumber);
                    break;
                default:
                    Console.WriteLine("1 ve 12 arasında bir sayı girdiğinden emin ol, senin girdiğin sayı: {0}", ayNumber);
                    break;
            }
        }

        
    }