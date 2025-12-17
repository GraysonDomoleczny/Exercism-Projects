public static class RomanNumeralExtension
{
    public static string ToRoman(this int value)
    {
        string romanNum = "";
        
        while (value >= 1000) 
        {
            romanNum += "M";
            value -= 1000;
        }
        
        while (value >= 900)
        {
            romanNum += "CM";
            value -= 900;   
        }
        
        while (value >= 500)
        {
            romanNum += "D";
            value -= 500;
        }
        
        while (value >= 400)
        {
            romanNum += "CD";
            value -= 400;
        }
        
        while (value >= 100)
        {
            romanNum += "C";
            value -= 100;
        }
        
        while (value >= 90)
        {
            romanNum += "XC";
            value -= 90;
        }

        while (value >= 50)
        {
            romanNum += "L";
            value -= 50;
        }

        while (value >= 40)
        {
            romanNum += "XL";
            value -= 40;
        }

        while (value >= 10)
        {
            romanNum += "X";
            value -= 10;
        }

        while (value >= 9)
        {
            romanNum += "IX";
            value -= 9;
        }

        while (value >= 5)
        {
            romanNum += "V";
            value -= 5;
        }

        while (value >= 4)
        {
            romanNum += "IV";
            value -= 4;
        }

        while (value >= 1)
        {
            romanNum += "I";
            value -= 1;
        }
        return romanNum;
    }
}