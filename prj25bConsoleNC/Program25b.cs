// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello,1003 World!");

using System.Data.SqlClient;
using ca.i5i.c.person;
using ca.i5i.c.animal.pet;
using ca.i5i.c.animal;
using ca.i5i.c.animal2;
using System.Text.RegularExpressions;
using System.Collections;
using System.Data.SQLite;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Reflection.Metadata;

namespace ca.i5i.c
{
    class Program25b
    {
        enum Months
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        enum Level
        {
            Low,
            Medium,
            High
        }

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello21World!");
            //MyMethod2511();
            //Input2512();
            //DefaultParameter2513("Sweden");
            //DefaultParameter2513();
            //DefaultParameter2513("USA");
            //Pet2514();
            //Person2515();
            //PersonShortHand2516();
            //Car2517();
            //Animal2518();
            //AbstractAnimal2519();
            //IAnimal2520();
            //EnumValu/521();
            //SqlConnection2522();
            //intSwap2523();
            //stringSwap2523();
            //regex2524dot();
            //regex2524d();
            //regex2524Replace();
            //regex2524repeat();           
            //regex2524phone();
            //regex2524email();
            //regex2524other();
            //fileStream2525a();
            //streamReader2525c();
            //streamWriter2525e();
            //binaryWriter2525g();            
            //directoryInfo2525i();     
            //collection2526ArrayList();
            //collection2526Hashtable();
            //collection2526SortedList();
            //collection2526Stack();
            //collection2526Queue();
            //collection2526BitArray();
            //sqlite2527();
            //lambda2528Expression();
            lambda2528StatementA();
            //lambda2528StatementB();
            //lambda2528delegateTypeFuncA();
            //lambda2528delegateTypeFuncB();
            //lambda2528ExpressionAsParameter();

            Console.ReadKey();  //this way better than Sleep/ReadLine.
            //Thread.Sleep(9000);  //sleep for 9 seconds.
            //Console.ReadLine();
        }

        static void lambda2528ExpressionAsParameter() {
            // array containing integer values 
            int[] numbers = { 2, 13, 1, 4, 13, 5 };

            // lambda expression as method parameter
            // returns the total count of 13 in the numbers array
            int totalCount = numbers.Count(x => x == 13);          

            Console.WriteLine("Total number of 13: " + totalCount);
        }
        static void lambda2528delegateTypeFuncB()
        {
            // using lambda expression with delegate type Func: take an int input, multiply it with 3 and return the result. 
            Func<int, int> multiply = num => num * 3;            
            Console.WriteLine(multiply(5));  // calls multiply() by passing 5 as an input.
        }

        static void lambda2528delegateTypeFuncA()
        {
            Func<int, int> square = x => x * x;  //we can assign lambda expressions to the delegate types like Func. 
            Console.WriteLine(square(5));  // square is a new instance of the delegate.
        }

        static void lambda2528StatementB()
        {
            // statement lambda that takes two int inputs and returns the sum. 
            var resultingSum = (int a, int b) =>
            {
                int calculatedSum = a + b;
                return calculatedSum;
            };
            Console.WriteLine("Total sum: " + resultingSum(5, 6));
        }


        static void lambda2528StatementA()
        {
            var sum2 = (int a, int b) =>
            {
                var sum = a + b;
                return sum;
            };
            Console.WriteLine("sum of 2 number2: " + sum2(5, 4));
        } 


        static void lambda2528Expression()
        {
            var square = (int num) => num * num;   // expression lambda that returns the square of a number.           
            Console.WriteLine("Square of number: " + square(5));   // passing input to the expression lambda. 
        }

        static void sqlite2527()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = CreateConnection();
            CreateTable(sqlite_conn);
            InsertData(sqlite_conn);
            ReadData(sqlite_conn); ;
        }
        
        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            // Create a new database connection:
            //sqlite_conn = new SQLiteConnection("Data Source= sqlite3db.db; Version = 3; New = True; Compress = True; ");
            sqlite_conn = new SQLiteConnection("Data Source= sqlite3dbB.db");         
            try
            {
                sqlite_conn.Open();     // Open the connection:
            }
            catch (Exception ex)
            {
                ;
            }
            return sqlite_conn;
        }

        static void CreateTable(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            string Createsql = "CREATE TABLE SampleTable (Col1 VARCHAR(20), Col2 INT)";
            string Createsql1 = "CREATE TABLE SampleTable1 (Col1 VARCHAR(20), Col2 INT)";
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = Createsql;
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = Createsql1;
            sqlite_cmd.ExecuteNonQuery();
        }

        static void InsertData(SQLiteConnection conn)
        {
            SQLiteCommand sqlite_cmd;
            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test Text ', 1); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test1 Text1 ', 2); ";
            sqlite_cmd.ExecuteNonQuery();
            sqlite_cmd.CommandText = "INSERT INTO SampleTable (Col1, Col2) VALUES('Test2 Text2 ', 3); ";
            sqlite_cmd.ExecuteNonQuery();
        }

        static void ReadData(SQLiteConnection conn)
        {
            SQLiteDataReader sqlite_datareader;
            SQLiteCommand sqlite_cmd;

            Console.WriteLine("in ReadData");

            sqlite_cmd = conn.CreateCommand();
            sqlite_cmd.CommandText = "SELECT * FROM SampleTable";

            sqlite_datareader = sqlite_cmd.ExecuteReader();
            while (sqlite_datareader.Read())  //  The Read() method of the reader moves the reader to the next row.
            {
                string myreader = sqlite_datareader.GetString(0);
                Console.WriteLine(myreader);
            }
            conn.Close();
        }
        
        static void collection2526BitArray() {
            //creating two bit arrays of size 8
            BitArray ba1 = new BitArray(8);
            BitArray ba2 = new BitArray(8);
            byte[] a = { 60 };
            byte[] b = { 13 };
            //storing the values 60, and 13 into the bit arrays
            ba1 = new BitArray(a);
            ba2 = new BitArray(b);
            //content of ba1
            Console.WriteLine("Bit array ba1: 60");
            for (int i = 0; i < ba1.Count; i++)
            {
                Console.Write("{0, -6} ", ba1[i]);
            }
            Console.WriteLine();

            //content of ba2
            Console.WriteLine("Bit array ba2: 13");
            for (int i = 0; i < ba2.Count; i++)
            {
                Console.Write("{0, -6} ", ba2[i]);
            }
            Console.WriteLine();

            BitArray ba3 = new BitArray(8);
            ba3 = ba1.And(ba2);
            //content of ba3
            Console.WriteLine("Bit array ba3 after AND operation: 12");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();

            ba3 = ba1.Or(ba2);
            //content of ba3
            Console.WriteLine("Bit array ba3 after OR operation: 61");
            for (int i = 0; i < ba3.Count; i++)
            {
                Console.Write("{0, -6} ", ba3[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    
        static void collection2526Queue()
        {
            Queue q = new Queue();
            q.Enqueue('A');
            q.Enqueue('M');
            q.Enqueue('G');
            q.Enqueue('W');
            Console.WriteLine("Current queue: ");
            foreach (char c in q)
                Console.Write(c + " ");
            Console.WriteLine();

            q.Enqueue('V');
            q.Enqueue('H');
            Console.WriteLine("Current queue2: ");
            foreach (char c in q)
                Console.Write(c + " ");

            Console.WriteLine();

            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue();
            Console.WriteLine("The removed value: {0}", ch);
            Console.ReadKey();
        }    

            static void collection2526Stack() {
            Stack st = new Stack();
            st.Push('A');
            st.Push('M');
            st.Push('G');
            st.Push('W');
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V');
            st.Push('H');
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop();
            st.Pop();
            st.Pop();
            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            {
                Console.Write(c + " ");
            }
        }

        static void collection2526SortedList()
        {
            SortedList sl = new SortedList();
            sl.Add("001", "Canada");
            sl.Add("002", "China");
            sl.Add("003", "USA");
            sl.Add("004", "FR");
            sl.Add("005", "ES");
            sl.Add("006", "CO");
            sl.Add("007", "ME");

            if (sl.ContainsValue("COM"))
            {
                Console.WriteLine("This name is already in the list");
}
            else
            {
                sl.Add("008", "COM");
            }
            // get a collection of the keys.
            ICollection key = sl.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + sl[k]);
            }
        }    

        static void collection2526Hashtable()
        {
            Hashtable ht = new Hashtable();
            ht.Add("001", "Canada");
            ht.Add("002", "China");
            ht.Add("003", "USA");
            ht.Add("004", "FR");
            ht.Add("005", "ES");
            ht.Add("006", "CO");
            ht.Add("007", "ME");
            if (ht.ContainsValue("COM"))
            {
                Console.WriteLine("This name is already in the list");}
            else
            {
                ht.Add("008", "COM");
            }
            // Get a collection of the keys.
            ICollection key = ht.Keys;
            foreach (string k in key)
            {
                Console.WriteLine(k + ": " + ht[k]);
            }
            Console.ReadKey();
        }    

        static void collection2526ArrayList() {
            ArrayList al = new ArrayList();
            Console.WriteLine("Adding some numbers:");
            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);
            Console.Write("Content: ");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Sorted Content: ");
            al.Sort();
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        static void directoryInfo2525i()
        {
            //creating a DirectoryInfo object
            //DirectoryInfo mydir = new DirectoryInfo(@"c:\Windows");
            //DirectoryInfo mydir = new DirectoryInfo(@"C:\tools");
            DirectoryInfo mydir = new DirectoryInfo(@"C:\tools\backupDOS");

        // getting the files in the directory, their names and size
        FileInfo[] f = mydir.GetFiles();
            foreach (FileInfo file in f)
            {
                Console.WriteLine("File Name: {0} Size: {1} LastWriteTime: {2}",
                file.Name, file.Length, file.LastWriteTime);
            }
            Console.ReadKey();
        }    

        static void binaryWriter2525g()
        {
            BinaryWriter bw;
            BinaryReader br;
            int i = 25;
            double d = 3.14157;
            bool b = true;
            string s = "I am happy55";
            //create the file
            try
            {
                bw = new BinaryWriter(new FileStream("mydata2525", FileMode.Create));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot create file.");
                return;
            }
            //writing into the file
            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot write to file.");
                return;
            }
            bw.Close();
            //reading from the file
            try
            {
                br = new BinaryReader(new FileStream("mydata2525", FileMode.Open));
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message + "\n Cannot open file.");
                return;
            }
            try
            {
                i = br.ReadInt32();
                Console.WriteLine("Integer data: {0}", i);
                d = br.ReadDouble();
                Console.WriteLine("Double data: {0}", d);
                b = br.ReadBoolean();
                Console.WriteLine("Boolean data: {0}", b);
                s = br.ReadString();
                Console.WriteLine("String data: {0}", s);
            }
            catch (IOException e)
            {

                Console.WriteLine(e.Message + "\n Cannot read from file.");
                return;
            }
            br.Close();
            Console.ReadKey();
        }


        static void streamWriter2525e()
        {
            string[] names = new string[] { "Jen Smith, 12399.55, ON", "Alan Zhang, '88', QC", "Joe Li, 77, ON" };
            //using (StreamWriter sw = new StreamWriter("names2525.txt"))
            using (StreamWriter sw = new StreamWriter("names2525.csv"))
            {
                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }
            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names2525.csv"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            Console.ReadKey();
        }
    
        static void streamReader2525c()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                //using (StreamReader sr = new StreamReader("c:/jamaica.txt"))
                using (StreamReader sr = new StreamReader("jamaica2525.txt"))
                {
                    string line;
                    // Read and display lines from the file until
                    // the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        static void fileStream2525a()
        {
            FileStream F = new FileStream("test2525.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int i = 1; i <= 20; i++)
            {
                F.WriteByte((byte)i);  //so file content is binary.
            }

            F.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(F.ReadByte() + " ");
            }

            F.Close();  
        }

        static void regex2524other() {
            // this will either d or e, whichever comes first.
            Regex regex = new Regex(@"d|e");
            Match match = regex.Match("edge");

            regex = new Regex(@"[^x-z]");
            match = regex.Match("xmax");

            // this will return any character between x and z inclusive
            regex = new Regex(@"[x-z]");
            match = regex.Match("xmax");

            // this will the return the one digit character
            regex = new Regex(@"\d");
            match = regex.Match("I am 39 years old");

            // this will return like ab, aab, aaab
            regex = new Regex(@"a+b");
            match = regex.Match("aaabcd");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }

        static void regex2524email()
        {
            string[] str = {"jen@gmail.com", "jengmail.com", "@gmail.com"};
            foreach (string s in str)
            {
                Console.WriteLine("{0} {1} a valid E-mail address.", s,
                                    validEmail2524(s) ? "is" : "is not");
            }
        }

        public static bool validEmail2524(string inputEmail)
        {
            //string strRegex = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";
            string strRegex = @"(\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,6})";
            Regex re = new Regex(strRegex, RegexOptions.IgnoreCase);
            if (re.IsMatch(inputEmail))
                return (true);
            else
                return (false);
        }

        static void regex2524phone()
        {
            //mobile numbers as an array of strings
            string[] nos = {"9902147368", "9611967273", "63661820954"};
            foreach (string s in nos)
            {
                Console.WriteLine("The mobile {0} {1} a valid number.", s,
                valid2524(s) ? "is" : "is not");
            }
        }
        public static bool valid2524(string mobile)
        {
            string cRegex = @"(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9] {2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)";
            Regex res = new Regex(cRegex);
            if (res.IsMatch(mobile))
                return (true);
            else
                return (false);
        }    

        static void regex2524repeat()
        {
            // Define a regular expression for repeated words.
            //Reference to undefined group name 'word2'.
            Regex rx = new Regex(@"\b(?<word1>\w+)\s+(\k<word1>)\b", RegexOptions.Compiled); // Compiled maximize run-time performance at the expense of initialization time. 
            //Regex rx = new Regex(@"\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);   //  bitwise inclusive OR
            // logical operators || && 
            string text = "The the quick brown fox  fox jumps over the lazy dog dog.";
            MatchCollection matches = rx.Matches(text);
                       
            Console.WriteLine("{0} matches found in:\n   {1}",
                              matches.Count,       // the number of matches found.
                              text);
          
            foreach (Match match in matches)     // Report on each match.
            {
                GroupCollection groups = match.Groups;
                Console.WriteLine("'{0}' repeated at positions {1} and {2}",
                                  groups["word1"].Value,
                                  groups[0].Index,
                                  groups[1].Index);
            }
        }

        static void regex2524Replace()
        {
            string pattern = "(Mr\\.? |Mrs\\.? |Miss |Ms\\.? )";
            string[] names = { "Mr. Henry Hunt", "Ms. Sara Samuels", "Abraham Adams", "Ms. Nicole Norris" };
            foreach (string name in names)
                //Console.WriteLine(Regex.Replace(name, pattern, String.Empty));
                Console.WriteLine(Regex.Replace(name, pattern, "ceo"));  // public static string Replace (string input, string pattern, string replacement);
        }

        static void regex2524d()
        {
            Regex regex = new Regex(@"\d");
            Match match = regex.Match("I 5am 3 219 years old");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
        static void regex2524dot()
        {
            Regex regex = new Regex(@"s..t");
            Match match = regex.Match("This is my seat");

            if (match.Success)
            {
                Console.WriteLine("Match Value: " + match.Value);
            }
        }
        static void stringSwap2523()
        {
            /* local variable definition */
            string a = "zzzz";
            string b = "yyyy";

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            /* calling a function to swap the values */
            stringSwap(ref a, ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
        }

        static void intSwap2523()
        {
            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);
            /* calling a function to swap the values */
            intSwap(ref a, ref b);
            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);
        }

        static public void stringSwap(ref string x, ref string y)
        {
            string temp;
            temp = x; /* save the value of x */
            x = y; /* put y into x */
            y = temp; /* put temp into y */
        }

        static public void intSwap(ref int x, ref int y)
        {
            int temp;
            temp = x; /* save the value of x */
            x = y; /* put y into x */
            y = temp; /* put temp into y */
        }

        static void SqlConnection2522()
        {
            string connetionString;
            SqlConnection cnn;
            connetionString = "Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;";
            // Server=myServerName\myInstanceName;Database=myDataBase;User Id=myUsername;Password=myPassword;

            //Trusted Connection:
            //Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;

            cnn = new SqlConnection(connetionString);
            cnn.Open();
            //MessageBox.Show("Connection Open  !");
            Console.WriteLine("Connection open!");
            cnn.Close();
        }

        static void EnumValues2521()
        {
            int myNum = (int)Months.April;
            Console.WriteLine(myNum);

            Level myVar = Level.Medium;
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }
        }

        static void IAnimal2520()
        {
            SilverPig myPig = new SilverPig();  // Create a SilverPig object
            myPig.animalSound();
        }

        static void AbstractAnimal2519()
        {
            GoldPig myPig = new GoldPig(); // Create a Pig object
            myPig.animalSound();  // Call the abstract method
            myPig.sleep();  // Call the regular method
        }

        static void Animal2518()
        {
            Animal myAnimal = new Animal();  // Create a Animal object
            Animal myPig = new Pig();  // Create a Pig object
            Animal myGull = new Gull();  // Create a Gull object

            myAnimal.animalSound();
            myPig.animalSound();
            myGull.animalSound();
        }

        static void Car2517()
        {
            Car myCar = new Car();
            // Call the honk() method (From the Vehicle class) on the myCar object
            myCar.honk();
            // Display the value of the brand field (from the Vehicle class) and the value of the modelName from the Car class
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
        }

        static void PersonShortHand2516()
        {
            PersonShortHand myObj = new PersonShortHand();
            myObj.Name = "Liam2516";
            Console.WriteLine(myObj.Name);
        }

        static void Person2515()
        {
            Person myObj = new Person();
            myObj.Name = "Liam2515";
            Console.WriteLine(myObj.Name);
        }


        static void Pet2514()
        {
            List<IPet> pets = new List<IPet>
            {
                new Dog(),
                new Cat()
            };

            foreach (var pet in pets)
            {
                Console.WriteLine(pet.TalkToOwner());
            }
        }


        static void DefaultParameter2513(string country = "Norway")
        //country is an optional parameter and "Norway" is the default value.
        {
            Console.WriteLine(country);
        }

        static void Input2512()
        {
            Console.WriteLine("Enter username:");
            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();
            // Print the value of the variable (userName), which will display the input value
            Console.WriteLine("Username28 is: " + userName);

            Console.WriteLine("Enter 29your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age29 is: " + age);
        }

        static void MyMethod2511()
        {
            Console.WriteLine("Hello23 World!");
            Console.WriteLine("I am Learning C#");
            Console.WriteLine("It is awesome!");
            Console.WriteLine(3 + 3);

            // This is a comment
            string name = "John24";
            Console.WriteLine(name);

            //Console.Write("Hello World! ");
            //Console.Write("I will print on the same line.");
            /* The code below will print the words Hello World
                to the screen, and it is amazing */

            const int myNum = 25;
            //myNum = 20;
            Console.WriteLine(myNum);

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);   // Outputs True
            Console.WriteLine(isFishTasty);   // Outputs False  

            int myInt = 27;
            double myDouble = 5.25;
            bool myBool = true;
            Console.WriteLine(Convert.ToString(myInt));    // Convert int to string
            Console.WriteLine(Convert.ToDouble(myInt));    // Convert int to double
            Console.WriteLine(Convert.ToInt32(myDouble));  // Convert double to int
            Console.WriteLine(Convert.ToString(myBool));   // Convert bool to string

            string firstName30 = "John";
            string lastName30 = "Doe30";
            string name30 = $"My full name is: {firstName30} {lastName30}";  //  String interpolation was introduced in C# version 6.
            Console.WriteLine(name30);

            string name31 = "John Doe 31";
            int charPos = name31.IndexOf("D");  // Location of the letter D.
            string lastName = name31.Substring(charPos);  // Get last name.
            Console.WriteLine(lastName);

            int time = 20;
            string result = time < 18 ? "Good day." : "Good evening.";
            Console.WriteLine(result);

            int day = 4;
            string st = "czz";
            switch (st)
            {
                case "zz":
                    Console.WriteLine("Today is Saturday.");
                    break;
                case "yy":
                    Console.WriteLine("Today is Sunday.");
                    break;
                default:
                    Console.WriteLine("Looking forward to the Weekend.");
                    break;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 1; i <= 2; ++i)
            {
                Console.WriteLine("Outer: " + i);  // Executes 2 times

                // Inner loop
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine(" Inner: " + j);  // Executes 6 times (2 * 3)
                }
            }

            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int l = 0;
            while (l < 10)
            {
                if (l == 4)
                {
                    l++;
                    //continue;
                    break;
                }
                Console.WriteLine(l);
                l++;
            }
        }
    }
}
