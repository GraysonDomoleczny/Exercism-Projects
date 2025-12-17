public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string romanNum = "";
        
        while (value >= 1000) { romanNum += "M";  value -= 1000; }
        if    (value >= 900)  { romanNum += "CM"; value -= 900; }
        if    (value >= 500)  { romanNum += "D";  value -= 500; }
        if    (value >= 400)  { romanNum += "CD"; value -= 400; }
        while (value >= 100)  { romanNum += "C";  value -= 100; }
        if    (value >= 90)   { romanNum += "XC"; value -= 90; }
        if    (value >= 50)   { romanNum += "L";  value -= 50; }
        if    (value >= 40)   { romanNum += "XL"; value -= 40; }
        while (value >= 10)   { romanNum += "X";  value -= 10; }
        if    (value >= 9)    { romanNum += "IX"; value -= 9; }
        if    (value >= 5)    { romanNum += "V";  value -= 5; }
        if    (value >= 4)    { romanNum += "IV"; value -= 4; }
        while (value >= 1)    { romanNum += "I";  value -= 1; }
        
        return romanNum;
    }
}