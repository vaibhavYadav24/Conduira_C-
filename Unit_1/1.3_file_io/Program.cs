using System;
using System.IO;


class Program
{
    static void Main()
    {
		string fileName = @"file.txt"; 
		string[] Lines ;
		int n,i;
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }

        Console.Write(" Input number of lines to write in the file  :");
        n= Convert.ToInt32(Console.ReadLine()); 
        Lines=new string[n];      
        Console.Write(" Input {0} strings below :\n",n);
		for(i=0;i<n;i++)
		{
		Console.Write(" Input line {0} : ",i+1);
		Lines[i] = Console.ReadLine();	
		}	
        System.IO.File.WriteAllLines(fileName, Lines);
        
	using (StreamReader sr = File.OpenText(fileName)) 
        {
            string s = "";
            Console.Write("\n The content of the file is  :\n",n);
            while ((s = sr.ReadLine()) != null) 
            {
                Console.WriteLine(" {0} ",s);
            }
            Console.WriteLine();
        }        
    }
}
