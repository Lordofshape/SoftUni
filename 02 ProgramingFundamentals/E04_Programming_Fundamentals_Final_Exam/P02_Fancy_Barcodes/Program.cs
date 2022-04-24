namespace P02_Fancy_Barcodes
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string pattern = @"\@\#+(?<item>[A-Z][A-Za-z0-9]{4,}[A-Z])\@\#+";
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match collection = Regex.Match(barcode, pattern);
                if (collection.Success)
                {
                    string item = collection.Groups["item"].Value;
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < item.Length; j++)
                    {
                        if (char.IsDigit(item[j]))
                        {
                            sb.Append(item[j]);
                        }
                    }
                    if (sb.Length==0)
                    {
                        Console.WriteLine("Product group: 00");
                    }
                    else
                    {
                        Console.WriteLine($"Product group: {sb}");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
               
            }        
        }
    }
}
