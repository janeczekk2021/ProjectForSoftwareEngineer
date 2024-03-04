using System.Runtime.CompilerServices;


namespace CountryList.Application
{
    public interface ICheckDoc
    {
        string[] checkDocuments(string countryCode);
    }
    public class CheckDoc: ICheckDoc 

    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter one of the three-letter code for a North American\n" +
                "Country from below countries list");
            Console.WriteLine();

            Console.WriteLine(
                "CAN – Canada\n" +
                "USA – The United States\n" +
                "BLZ – Belize\n" +
                "GTM – Guatemala\n" +
                "SLV – El Salvador\n" +
                "HND – Honduras\n" +
                "NIC – Nicaragua\n" +
                "CRI – Costa Rica\n" +
                "PAN – Panama");
            Console.WriteLine();

            checkDocuments();
        }

        public string[] checkDocuments(string countryCode)
        {

            string[] can = ["USA", "CAN"];
            string[] usa = ["USA"];
            string[] mex = ["USA", "MEX"];
            string[] blz = ["USA", "MEX", "BLZ"];
            string[] gtm = ["USA", "MEX", "GTM"];
            string[] slv = ["USA", "MEX", "GTM", "SLV"];
            string[] hnd = ["USA", "MEX", "GTM", "HND"];
            string[] nic = ["USA", "MEX", "GTM", "HND", "NIC"];
            string[] cri = ["USA", "MEX", "GTM", "HND", "NIC", "CRI"];
            string[] pan = ["USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"];
            
            string[] countryCodes = [
                "CAN – Canada",
                "USA – The United States",
                "BLZ – Belize",
                "GTM – Guatemala",
                "SLV – El Salvador",
                "HND – Honduras",
                "NIC – Nicaragua",
                "CRI – Costa Rica",
                "PAN – Panama",
                "MEX – Mexico"
            ];


            string destCountry = countryCode.ToUpper();
            string[] result = ["Wrong country code provided"];


            switch (destCountry)
            {
                case "CAN":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[0]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in can)
                    {
                        Console.WriteLine(country);
                    }
                    result = can;
                    break;
                case "USA":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[1]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in usa)
                    {
                        Console.WriteLine(country);
                    }
                    result = usa;
                    break;
                case "BLZ":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[2]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in blz)
                    {
                        Console.WriteLine(country);
                    }
                    result = blz;
                    break;
                case "GTM":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[3]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in gtm)
                    {
                        Console.WriteLine(country);
                    }
                    result = gtm;
                    break;
                case "SLV":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[4]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in slv)
                    {
                        Console.WriteLine(country);
                    }
                    result = slv;
                    break;
                case "HND":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[5]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in hnd)
                    {
                        Console.WriteLine(country);
                    }
                    result = hnd;
                    break;
                case "NIC":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[6]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in nic)
                    {
                        Console.WriteLine(country);
                    }
                    result = nic;
                    break;
                case "CRI":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[7]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in cri)
                    {
                        Console.WriteLine(country);
                    }
                    result = cri;
                    break;
                case "PAN":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[8]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in pan)
                    {
                        Console.WriteLine(country);
                    }
                    result = pan;
                    break;
                case "MEX":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[9]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in mex)
                    {
                        Console.WriteLine(country);
                    }
                    result = mex;
                    break;
            }
            
            return result;
            
        }


        public static void checkDocuments()
        {

            string[] can = ["USA", "CAN"];
            string[] usa = ["USA"];
            string[] mex = ["USA", "MEX"];
            string[] blz = ["USA", "MEX", "BLZ"];
            string[] gtm = ["USA", "MEX", "GTM"];
            string[] slv = ["USA", "MEX", "GTM", "SLV"];
            string[] hnd = ["USA", "MEX", "GTM", "HND"];
            string[] nic = ["USA", "MEX", "GTM", "HND", "NIC"];
            string[] cri = ["USA", "MEX", "GTM", "HND", "NIC", "CRI"];
            string[] pan = ["USA", "MEX", "GTM", "HND", "NIC", "CRI", "PAN"];

            string[] countryCodes = [
                "CAN – Canada",
                "USA – The United States",
                "BLZ – Belize",
                "GTM – Guatemala",
                "SLV – El Salvador",
                "HND – Honduras",
                "NIC – Nicaragua",
                "CRI – Costa Rica",
                "PAN – Panama",
                "MEX – Mexico"
            ];

            Console.Write("Please enter three-letter code destination country: ");

            string destCountry = Console.ReadLine().ToUpper();
            Console.WriteLine();
            //string destCountry = countryCode.ToUpper();
            string[] result = new string[1];



            switch (destCountry)
            {
                case "CAN":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[0]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in can)
                    {
                        Console.WriteLine(country);
                    }
                    result = can;
                    break;
                case "USA":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[1]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in usa)
                    {
                        Console.WriteLine(country);
                    }
                    result = usa;
                    break;
                case "BLZ":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[2]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in blz)
                    {
                        Console.WriteLine(country);
                    }
                    result = blz;
                    break;
                case "GTM":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[3]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in gtm)
                    {
                        Console.WriteLine(country);
                    }
                    result = gtm;
                    break;
                case "SLV":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[4]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in slv)
                    {
                        Console.WriteLine(country);
                    }
                    result = slv;
                    break;
                case "HND":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[5]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in hnd)
                    {
                        Console.WriteLine(country);
                    }
                    result = hnd;
                    break;
                case "NIC":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[6]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in nic)
                    {
                        Console.WriteLine(country);
                    }
                    result = nic;
                    break;
                case "CRI":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[7]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in cri)
                    {
                        Console.WriteLine(country);
                    }
                    result = cri;
                    break;
                case "PAN":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[8]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in pan)
                    {
                        Console.WriteLine(country);
                    }
                    result = pan;
                    break;
                case "MEX":
                    Console.WriteLine("You chose destination:\n" +
                        countryCodes[9]);
                    Console.WriteLine("Please take documents applicable for below countries:");
                    foreach (string country in mex)
                    {
                        Console.WriteLine(country);
                    }
                    result = mex;
                    break;
            }

            if (result[0] == null)
            {
                Console.WriteLine("Wrong country code provided\n" +
                "Please enter one of the three-letter code for a North American\n" +
               "Country from below countries list\n" +
               "CAN – Canad\n" +
               "USA – The United States\n" +
               "BLZ – Belize\n" +
               "GTM – Guatemala\n" +
               "SLV – El Salvador\n" +
               "HND – Honduras\n" +
               "NIC – Nicaragua\n" +
               "CRI – Costa Rica\n" +
               "PAN – Panama\n" +
               "MEX – Mexico");
            }
        }

    }
}


