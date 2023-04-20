using System.Text;

public class OTP
{
    static void Main()
    {
        int getotp = generateOTP_withFixedNumberofDigits();
        Console.WriteLine("Generate OTP within Range Using Randon class logic: " + getotp);

        string getcustomotp = generate_Custom_OTP_withFixedNumberofDigits(4);
        Console.WriteLine("Generate Custom OTP with FixedNumberofDigits(n): " + getcustomotp);

        Random rand = new Random();
        Console.WriteLine("OTP with just Random.Next() Method: "+rand.Next());
    }

    static int generateOTP_withFixedNumberofDigits()
    {
        int otp = 0;
        Random rand = new Random();
        for (int i = 0; i < 10; i++)
        {
            otp = rand.Next(10000000, 99999999);
            Console.WriteLine("{0} -> {1}", i, otp);
        }
        return otp;
    }

    static string generate_Custom_OTP_withFixedNumberofDigits(int iOTPLength)
    {
        string[] saAllowedCharacters = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
        string sOTP = String.Empty;
        string sTempChars = String.Empty;
        Random rand = new Random();
        for (int i = 0; i < iOTPLength; i++)
        {
            int p = rand.Next(0, saAllowedCharacters.Length);
            sTempChars = saAllowedCharacters[rand.Next(0, saAllowedCharacters.Length)];
            sOTP += sTempChars;
        }
        return sOTP;
    }
}