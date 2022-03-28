using System;

class Program {
  public static void Main (string[] args) {
    while(true){
   Console.WriteLine("1 - Convert decimal Number to bin Number ");
   Console.WriteLine("2 - Convert decimal Number to Hexadeciaml Number");
   Console.WriteLine("3 - Convert decimal IP Address to bin IP Address");
   Console.WriteLine("4 - Convert decimal MAC Address to Hexadeciaml MAC Address");
   Console.WriteLine("5 - Exit");
   Console.WriteLine("Enter Choice:");
   int choice= Convert.ToInt16(Console.ReadLine());
   switch(choice){
   case 1:{
   Console.WriteLine("Enter dec Number:");
   int dec = Convert.ToInt32(Console.ReadLine());
   string bin = decTObin(dec);
   Console.WriteLine("dec Number:"+ dec);
   Console.WriteLine("bin Number:"+ bin);
   break;
   }
   case 2:{
   Console.WriteLine("Enter dec Number:");
   int dec = Convert.ToInt16(Console.ReadLine());
   string hexa = decTOhexa(dec);
   Console.WriteLine("dec Number: "+dec);
   Console.WriteLine("Hexadeciaml Number: "+hexa);
   break;
   }
   case 3:{
   Console.WriteLine("Enter dec IP Address (i.e. 192.168.35.10):");
   string ip = Console.ReadLine();
   string [] ar = ip.Split(".");
   string bin="";
   for (int i = 0; i < ar.Length; i++){
   bin = bin + decTObin(Int32.Parse(ar[i]))+".";
   }
   bin = bin.Substring(0,bin.Length-1);
   Console.WriteLine("dec IP Address:"+ip);
   Console.WriteLine("bin IP Address:"+bin);
   break;
   }
   case 4:{
   Console.WriteLine("Enter dec MAC Address (i.e. 203:65:157:93:13:7):");
   string mac = Console.ReadLine();
   string [] ar = mac.Split(":");
   string hexa="";
   for(int i = 0; i < ar.Length; i++){
   hexa= hexa+ decTOhexa(Int32.Parse(ar[i]))+":"; 
   }
   hexa = hexa.Substring(0, hexa.Length -1);
   Console.WriteLine("decimal MAC Address:"+mac);
   Console.WriteLine("hexadeciaml MAC Address:"+hexa);
   break;
   }
   case 5:{
   System.Environment.Exit(0);
    break;
   }
   default : Console.WriteLine("Error: Please enter valid input");
   break;
   }
 
    //methods
  string decTObin(int dec){
      string bin = "";
      while (dec > 0){
        bin = dec%2 + bin;
        dec /= 2;
      }
        return bin;
    }
  string decTOhexa(int dec){
    string hexa="";   
    char [] hex =      {'0','1','2','3','4','5','6','7','8','9','A','B','C','D','E','F'};
    while(dec > 0)
    {
    int rem=dec%16;   
    hexa=hex[rem]+hexa;   
    dec=dec/16;
    }
    return hexa;
      }
    }
  }
}