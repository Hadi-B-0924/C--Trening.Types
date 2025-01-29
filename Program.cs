namespace C__Trening.Types;

class Program
{
    static void Main(string[] args)
    {
        //For å definere en variabel, må vi først fortelle maskinen hvilken type denne skal være.
        //Så gir vi variabelen et navn slik vi kan referere til den senere.
        //Så gir vi variabelen en verdi, etter likhetstegnet. 
        string myString  = "Hello World!"; //en string reprensenterer en tekst 
        Console.WriteLine(myString);
        //hele tall reprensenteres via en type som heter int.
        int myWholeNumber = 20; // en int, har en minimumsverdi på -2^31 og en maksverdi på 2^31
        /*int toLargeNumber = 49860214407294534071025435;  */ //vi må passe på at vi ikke assigner en for stor verdi for datatypen vi har valg.
        Console.WriteLine(myWholeNumber);
        float myFloat = 14.6f; //en gammel måte å reprensentere et desimaltall på. Generelt unøyaktig og lite brukt. 
        Console.WriteLine(myFloat);
    }
}
