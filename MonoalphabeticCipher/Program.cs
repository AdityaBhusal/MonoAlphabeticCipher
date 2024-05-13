using System;

public class Program{

    public static void Main (string[] args){
        Console.WriteLine("Enter the Plain Text to be encrypted: ");
        string userInput  = Console.ReadLine()??"text not entered, ";
        string CipherKey="WXZYLKJHGUFTBSQPENOMCRDIAV";
        string CipherText="";
        foreach (char i in userInput)
        {
            int a = (int)i -97;
            CipherText += CipherKey[a];
        }
        Console.WriteLine("The Encrypted Text is: "+CipherText);

}
}