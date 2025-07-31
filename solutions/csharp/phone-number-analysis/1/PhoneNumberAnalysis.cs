public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool IsNewYork = false;
        bool IsFake = false;
        string LocalNumber = "";

        string[] phoneTab = phoneNumber.Split('-'); // Split the phone number

        if (phoneTab[0] == "212")
        {
            IsNewYork = true;

        }
        if (phoneTab[1] == "555")
        {
            IsFake = true;
        }

        LocalNumber = phoneTab[2];

        return (IsNewYork, IsFake, LocalNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) => 
        phoneNumberInfo.IsFake;
}