// basic defination for folder and files 


/*
  diff between 
way for write program and store data 
sln :  used custom format for write program from microsoft , its difficlut to understand and cause confict when use merge on git 

slnx: used xml to write files its easy to understand and use samll size to store 
 */

using CSharpBasicsAssignment; 
 
/**
program.cs : entry point main file to run project 
/bin : build files for project 
/obj : files generted in runtime
csproj : file to identify which framework you used and style guide used in project
*/
 
using CSharpBasicsAssignment;
Console.WriteLine("=== PART B: Variables, Types & Casting ===");

RunTypesDemo();
void RunTypesDemo()
{
    //data type in c# 
    /// number data types 
    /// 
    #region part b 1
    int realNumber = 123;
    Console.WriteLine($" type of realNumber is{realNumber.GetType()}");
    long longNumber = 123456789012L;
    Console.WriteLine($" type of longNumber is{longNumber.GetType()}");
    double dooubleNumber = 12.8;
    Console.WriteLine($" type of dooubleNumber is{dooubleNumber.GetType()}");
    decimal decimalNumber = 12.3m;
    Console.WriteLine($" type of decimalNumber is{decimalNumber.GetType()}");
    float floatNumber = 12.43f;
    Console.WriteLine($" type of floatNumber is{floatNumber.GetType()}");
    bool isSuccess = false;
    Console.WriteLine($" type of isSuccess is{isSuccess.GetType()}");
    char choice = '+';
    Console.WriteLine($" type of choice is{choice.GetType()}");
    string name = "ahmed";
    Console.WriteLine($" type of name is{name.GetType()}");
    var myVarible = 123;
    Console.WriteLine($" type of myVarible is{myVarible.GetType()}");
    #endregion

    #region part b 2
    // convert without casting 
    long convetedValue = realNumber; // here convert from samll to large 
    Console.WriteLine($" converted value to long {convetedValue}");
    //convert from char 16 bit to int 32 bit is save and have no data loss
    int myValue = choice;
    Console.WriteLine($" converted value to int {myValue}");
    //  explict => convert from large to small 
    int dConverted = (int)(dooubleNumber);
    // not rounded number to last ex 12.3 => 12 ,12.6 => 12
    Console.WriteLine($" converted value to int by simple casting {dConverted}");
    int doubleConverted = Convert.ToInt32(dooubleNumber);
    //rounded number to last 12.5 => 13
    Console.WriteLine($" converted value to int by converted  casting {doubleConverted}");
    #endregion

    #region part b 3
    int result = 5 / 2;  // as int is for real number it deny , and left other tens يعني بتهمل الارقام العشرية عشان الرقم يبقي صحيح 
    Console.WriteLine($"result is by divi int  {result}"); // 2 

    double resultdouble = 5.0 / 2;
    Console.WriteLine($"result is by divi  double{resultdouble}"); //2.5 لانك مستخدم ان الناتج لازم يرجع dobule 
    #endregion

    #region B5 — Boxing / Unboxing
    object numberBeforeBoxing = 10;
    Console.WriteLine($"value before boxing {numberBeforeBoxing}");
    Console.WriteLine($"type before boxing {numberBeforeBoxing.GetType()}");
    int numberAfterBoxing = (int)numberBeforeBoxing;
    Console.WriteLine($"value after boxing {numberBeforeBoxing}");
    Console.WriteLine($"type after boxing {numberAfterBoxing.GetType()}");
    #endregion

    #region B6 — Parsing
    string word1 = "123";
    int wordAfterCast = int.Parse(word1);
    Console.WriteLine($"value after casting {word1}");

    string word2 = "abc";
    bool isConverted = int.TryParse(word2, out int resultValue);
    Console.WriteLine($"the value {word2} is {isConverted} AND value after casting {resultValue}");
    #endregion

    #region B7 — float to decimal
    float valueFloat = 12.3f;
    //decimal valueDecimal = valueFloat; // can't convert from float to decaiml by implict way
    decimal valueDecimal = (decimal)valueFloat;
    // float is binary system storage is larager than deciaml is base 10 
    Console.WriteLine($"value float is {valueFloat} and converted to deciaml is {valueDecimal}");
    #endregion

    #region Experiment 1 — Struct Copy Semantics
    CSharpBasicsAssignment.Point point1 = new CSharpBasicsAssignment.Point(12, 14);
    CSharpBasicsAssignment.Point point2 = point1;
    point2.X = 15;
    Console.WriteLine($"point1 value is {point1.X}");//12
    Console.WriteLine($"point2 value is {point2.X}");//15
                                                     // as struct is value typed point1 get copy of point2 and point2 change x of its own not in point1
    #endregion

    #region reference Semantics 
    CSharpBasicsAssignment.Order order1 = new CSharpBasicsAssignment.Order(1, "ahmed", 3, 100.3m, 0, false, 10, "cair", '1', 124532224, 3242323);
    Console.WriteLine($"order is paid before from order1 {order1.IsPaid}");
    CSharpBasicsAssignment.Order order2 = order1;
    order2.IsPaid = true;
    Console.WriteLine($"order is paid after assin from order1 {order1.IsPaid}");
    Console.WriteLine($"order is paid  after assin  from 2 {order2.IsPaid}");
    order1.PrintSummary();

    #endregion

    #region Object وReferenceEquals
    Object orderObject = new CSharpBasicsAssignment.Order(1, "ahmed", 3, 100.3m, 0, false, 10, "cair", '1', 124532224, 3242323);
    CSharpBasicsAssignment.Order order3 = (Order)orderObject;
    Console.WriteLine($"order status is {Order.ReferenceEquals(order3, orderObject)}");
    #endregion
    order3.PrintSummary();

    // summary of data type and stored 
    /**
     * value typed :stored in stack same name is struct => ex : int long char bool 
     * refrence type : stored in heap and refrence to stack as first string name store name in stack and value in heap
     * refrence type not create new  object : as refrence value is not store date it store refrence in memeory 
     * 
     */

    #region D3 — Bitwise Operators
    Console.WriteLine(" D3 — Bitwise Operators"); 
    int a = 5, b = 10;
    Console.WriteLine($"a & b = {a & b}"); // 0
    Console.WriteLine($"a | b = {a | b}"); // 0
    Console.WriteLine($"a ^ b = {a ^ b}"); // 0

    #endregion

}
#region scope
void printDetails(string name)
{
    Console.WriteLine(name);
}

//Console.WriteLine(name);  // you can;t access it outside function 
printDetails("ali"); // if you want only in function call 

for (int i = 0; i < 5; i++)
{
    int result = 0;
    Console.WriteLine(result + i);
}

//Console.WriteLine(i);// you can't access i as its outside loop block scope 
//Console.WriteLine(result);// you can;t access result as its inside loop block scope 
#endregion


#region Compound Assignment Operators 
int total = 100;

//operation 
Console.WriteLine($"operator =+ {total+=5}");
Console.WriteLine($"operator =- {total-=3}");
Console.WriteLine($"operator *= { total*3}");
Console.WriteLine($"operator =/ {total / 5}");
Console.WriteLine($"operator =% {total%2}"); 


#endregion