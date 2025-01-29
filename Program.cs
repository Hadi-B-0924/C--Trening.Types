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
        double myDouble = 12.9; //Standard måten å reprensentere et desimaltall i c#. Double er ganske nøyaktig i de fleste tilfeller.
        //For finanssektoren er double ikke nøyaktig, men da kan man bruke det såkalte decimal.
        //Man kan også legge til bokstaven "d" etter siste siffe for å spesifisere en double, men er ikke et krav.
        decimal myDecimal = 31.3m; // en veldig nøyakitg måte å reprensentere et desimaltall på, men krever mye av datamaskinen. 

        long myLong = 935750104590856913; //Long er en datatype som får tildelt dobbelt så stor plass enn en int.  

     }
}
