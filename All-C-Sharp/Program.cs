namespace All_C_Sharp
{
    internal class Program
    {
        static void printData(string name)
        {

            Console.WriteLine($"Hii, Its me \"{name}\"");
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");  // WriteLine - moving cursor on next line
            //Console.Write("Hello, World!");      // write - cursor on same line
            //Console.ReadLine();                  // readline - when you get input someting

            /*  D A T A    T Y P E S    I N    C    S H A R P  */

            //int age = 20;               // 4 byte
            //float price = 100.99F;      // 4 byte
            //char firstLatter = 'S';     // 2 byte
            //bool male = true;           // 1 bit
            //string name = "Sandesh";    // 2 bytes per character
            //long mob = 9112432477;      // 8 byte
            //double weight = 49.57676D;   // 8 byte (16 digits)




            /*  T Y P E S   C A S T I N G    I N   C   S H A R P  */

            // There are two types of casting 

            /* 1] Implicit Casting
               char to int to long to float to double

             Ex : 
                   int n='S';
                   double no = 28;
                   double no1 = 67.78;
             */

            /* 2] Explicit Casting

             Ex : 
                    int a = (int)39.8;
                    float no = (float)935.93;
            */


            /*  C O N V E R T    M E T O D S   I N   C   S H A R P */

            //int varr=Convert.ToInt32(3.55);
            //double  varr1= Convert.ToDouble(3);
            //long varr2 = Convert.ToInt32(33.89);
            //string name=Convert.ToString(Console.ReadLine());

            /*  M A T H    C L A S S   I N   C   S H A R P */

            //int larg = Math.Max(33, 17);
            //int small = Math.Min(33, 17);
            //double sRoot=Math.Sqrt(small);
            //int absuluteValue= Math.Abs(-19);
            //Console.WriteLine(larg);
            //Console.WriteLine(small);
            //Console.WriteLine(sRoot);
            //Console.WriteLine(absuluteValue);


            /* S T R I N G   M E T O D S   I N    C    S H A R P */

            //string line = "hii, everyone what \" are you doing";
            //Console.WriteLine(line.Length);
            //Console.WriteLine(line.ToUpper());
            //Console.WriteLine(line.ToLower());
            //Console.WriteLine(string.Concat("Hello,Its me" , " SANDESH"));

            //string name = "sandesh";
            //int age = 20;
            //Console.WriteLine($"My name is {name}. And age is {age}");  // string interpolition

            //Console.WriteLine(line[0]);
            //Console.WriteLine(line.IndexOf("are"));
            //Console.WriteLine(line.Substring(1));   //start from given number print hole string


            /*  M E T H O D S   I N   C    S H A R P */

            //Console.Write("Enter Your name : ");
            //string name = Console.ReadLine();
            //printData(name);


            /* C L A S S E S    A N D   O B J E C T  */

            Player sandesh = new Player();

            //Console.WriteLine(sandesh.name);            // when access public data types
            //Console.WriteLine(sandesh.health);

            //Console.WriteLine(sandesh.getName());         // when access private data types
            //Console.WriteLine(sandesh.getHealth());


            //sandesh.setHelth(57);                        // using method access the values
            //Console.WriteLine(sandesh.health);



        }
    }
}
