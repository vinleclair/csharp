using System;

public static class ResistorColor
{
    private enum Color
    {
        black,
        brown,
        red,
        orange,
        yellow,
        green,
        blue,
        violet,
        grey,
        white
    }
    
    public static int ColorCode(string color) 
        => (int)Enum.Parse(typeof(Color), color); 

    public static string[] Colors()
        => Enum.GetNames(typeof(Color)); 
}
