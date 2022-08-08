# C# Code
A compilation of C# code to quickly reference to while making C# applications.

**Printing & Getting Userinput**
--------------
Print to console and get userinput

```csharp
Console.WriteLine("Hello World");
//Print value
int num = 10;
Console.WriteLine($"{num}");

Console.Write(“Enter your name: ”); //Doesn’t create newline

name = Console.ReadLine();
Console.WriteLine(“Hello, ” + name);
```

**Variables**
--------------
Data types in C#

```csharp
string characterName = “John”;
int characterAge = 35;
Console.WriteLine("There was a man named " + characterName);
char grade = ‘A’;
//float, double, decimal
bool isMale = true;
```

**Strings**
--------------
Common string commands

```csharp
string phrase = “Academy”
phrase.Length; //Gives length
phrase.ToUpper(); //Converts to uppercase
phrase.Contains(“Academy”); //Returns True
phrase[0]; //Returns A
phrase.Indexof(“Academy”); //Returns 0
phrase.Substring(0, 3); //Returns Aca, index 0, length 3
```

**Conversion**
----------------
Convert strings to integer/double

```csharp
int num = Convert.ToInt32("45");
double num = Convert.ToDouble("45.12")
```

Try Parse example

```csharp
//Get an integer input, can rewrite for double, bool, float, char
public static int getInt()
{
    Console.Write("Input a number: ");
    string input = Console.ReadLine();

    int num;
    while (!int.TryParse(input, out num))
    {
	Console.Write("Invalid! Try again: ");
	input = Console.ReadLine();
    }

    return num;
}
```
**Char to int**
This works because each character is internally represented by a number. The characters '0' to '9' are represented by consecutive numbers, so finding the difference between the characters '0' and '2' results in the number 2.

```csharp
char foo = '2';
int bar = foo - '0';
//or natively
bar = char.GetNumericValue(foo);
```

**Arrays**
-------------
Example of different types of arrays (1D, 2D, 3D).

```csharp
int[] LuckyNumbers = {4, 8, 15, 16, 23, 42};
LuckyNumbers[0]; //4
LuckyNumbers[1] = 7;
LuckyNumbers.length();
string[] friends = new string[5];
friends[0] = “Jim”;

int[,] numberGrid = {
	{1, 2},
	{3, 4},
	{5, 6}
};
Console.WriteLine(numberGrid[1][1]); //4
int[,] myArray = new int[2,3]; //2 rows, 3 columns
int[,,] array1 = new int[4, 2, 3]; //D1=4, D2=2, D3=3

```

**More Examples on Arrays**
--------------------
Example of Jagged Arrays - arrays of which the member arrays can be of different lengths, producing rows of jagged edges when visualized as output

Method Extension - enable you to add methods to existing types without creating a new derived type, recompiling, or otherwise modifying the original type

```csharp
public class Program
{
	public static void Main()
	{
		int[] array = new int[] { 1, 2, 3 };
		array.PrintElements();
		array[1] = 10;
		array.PrintElements();

		//A Multi-Dimensional Array, 2D
		int[,] a = {
			{1, 2, 3},
			{4, 5, 6}
		};
		Console.WriteLine($"A multi-dimensional array length: {a.Length}");

		//A jagged array. It's an array of arrays, so you need to
		//initialize nested arrays afterwards
		int[][] b = {
			new int[] {1,2,3},
			new int[] {10,20,30,40,50},
			new int[] {5,6},
		};
		Console.WriteLine($"The jagged array length: {b.Length}");
		Console.WriteLine($"The nested array length: {b[1].Length}");

		//An element in the first row, first column
		a[0, 0] = 10;

		//The first element's first element
		b[0][0] = 10;

		//int[2][2][2] or int[2][2][] is not possible
		//You can initialize only the first rank
		//Nested arrays are not initialized
		//c[0].Length will give null reference exception
		int[][][] c = new int[2][][];
	}
	//Creating Arrays
	public static void MakeArray()
	{
		//Multi-dimensional arrays have more than one index
		int[] x = new int[10];
		int a = x[4];
		int[,] y = new int[2, 3]; //create 2 by 3 array
		int b = y[0, 2]; //Get a value from the index [0,2]
		int len = y.Length;
	}
	//Jagged Array
	public static void MakeJaggedArray()
	{
		//Jagged Array
		//An array of arrays
		int[][] jaggedArray = new int[2][]; //2 elements for the 1st array
		jaggedArray[0] = new int[3]; //new array with 3 elements
		int value = jaggedArray[0][2];
		int jLength = jaggedArray[0].Length; //length 3

		//null reference exception b/c there's nothing in there yet
		//jLength = y[1].Length;
	}
}

//Method Extension
public static class ArrayExtension
{
	//Print out the array (Ex of output: {1, 2, 3})
	public static void PrintElements(this int[] array)
	{
        Console.Write("{");
		foreach (var element in array)
		{
			Console.Write("" + element + ", ");
		}
		//Call backspace twice to get rid of the extra comma
		Console.WriteLine("\b\b}");
	}
}
```

**If Statements**
--------------
Example of an if statement

```csharp
bool isMale = true;
bool isTall = true;
if(isMale && isTall){
	Console.WriteLine(“You are a tall male”);
}
else if(isMale || isTall){
	Console.WriteLine(“You are either not male or not tall”);
}
else{
}
```

**Switch Statements**
----------------
Example of a switch statement

```csharp
string dayName;
int dayNum = 0;
switch(dayName){
	case 0:
		dayName = “Sunday”;
		break;
	case 1:
		dayName = “Monday”;
		break;
	default:
		dayName = “Invalid Day”;
		break;
}
```

**While Loops**
------------
Example of a while loop.

```csharp
int index = 1;
while(index <= 5){
	Console.WriteLine(index);
	index++;
}
do{
	Console.WriteLine(index);
	index++;
}while(index <= 5);
```

**For Loops**
---------------
Example of for loop.

```csharp
int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
for(int i = 0; i < luckyNumbers.length(); i++){
	Console.WriteLine(luckyNumbers[i]);
}
```

**Exception Handling**
-----------------
Try and catch block example.

```csharp
try{
	Console.WriteLine(“Enter a number: ”);
    	int num1 = Convert.ToInt32(Console.ReadLine());
   	 Console.WriteLine(“Enter another number: ”);
    	int num2 = Convert.ToInt32(Console.ReadLine());

   	 Console.WriteLine(num1/num2);
}
catch(DivideByZeroException e){
	Console.WriteLine(e.Message);
}
catch(FormatException){
	Console.WriteLine(e.Message);
}
catch(Exception e){
	Console.WriteLine(e.Message);
}
//Executed no matter what
finally{
    //Clean up
}
```

**List**
--------------
Example of a list. Make sure to include this at the top: using System.Collections.Generic;

```csharp
//Here's an array to compare
string[] food = new string[3];
food[0] = “pizza”;
food[1] = “ham”;
food[2] = “hotdog”;
foreach(String item in food){
	Console.WriteLine(item);
}

//List
List<String> food = new List<String>();
food.Add("pizza");
food.Add("ham");
food.Add("hotdog");
food.Add("fries");
food.Remove("fries");
food.Insert(0, "sushi");
int length = food.Count;
food.IndexOf("pizza");
food.LastIndexOf("fries");
food.Contains("pizza"); //true
food.Sort(); //sorts alphabetically
food.Reverse();
food.Clear();
//Initialize
List<string> mylist = new List<string>(new string[] {"element1", "element2", "element3"});
//Vector to array
string[] foodArray = food.ToArray();
//Checking if list is null
if (food?.Any() != true) //using System.Linq;
{
	//Handle null or empty list
}
```

**List of List**
-----------------
2D List Examples

```csharp
List<List<string>> myList = new List<List<string>>();
myList.Add(new List<string> { "a", "b" });
myList.Add(new List<string> { "c", "d", "e" });
myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
myList.Add(new List<string> { "a", "b" });
myList.AddRange(list2); //append another list
//To iterate over it.
foreach (List<string> subList in myList)
{
    foreach (string item in subList)
    {
        Console.WriteLine(item);
    }
}

List<List<String>> strList = new List<List<String>>{ 
    new List<String> {String.Empty, String.Empty},
    new List<String> {String.Empty, String.Empty},
    new List<String> {String.Empty, String.Empty},
    new List<String> {String.Empty, String.Empty},
};
```
**Class**
----------------
Example of a class.
Encapsulation - refers to an object's ability to hide data and behavior that are not necessary to its user
Abstraction - the method of exposing only the required features of the class and hiding unncessary information

```csharp
class Animal{
	//private - data can only be accessed inside the same class
	//public - data can be accessed from other classes if we choose to reference the class
	//static - not bound to an instance of the class, shared by all other instances
	//Class variables
	public static int Count = 0;
	public string name;
	public int age;
	public float happiness;
	//Class Constructors
	public Animal(){
		name = "Spot";
		age = 6;
		happiness = 0.5f;
		Count++;
	}
	//Parameterized constructor
	public Animal(string _name, int _age, float _happiness){
		name = _name;
		age = _age;
		happiness = _happiness;
		Count++;
	}
	static Animal(){
	}
	//Copy constructor
	public Animal(Animal animal){
		this.name = animal.name;
		this.age = animal.age;
		this.happiness = animal.happiness;
		Count++;
	}
	//Destructor
	~Animal(){
		//Code to release resources
	}
	public void Print(){
		Console.WriteLine("Name: " + name);
		Console.WriteLine("Age: " + age);
		Console.WriteLine("Happiness: " + happiness);
	}
}
public static void Main()
{	
	Animal dog = new Animal();
	dog.name = "Doggy";
	dog.Print();
	Animal cat = new Animal("Mr. Beans", 10, 0.8f);
	cat.Print();
}
```
Inheritance

Here, we are inheriting the derived class Dog from the base class Animal. The Dog class can now access the fields and methods of Animal class.

```charp
class Animal {  
  // fields and methods
} 

// Dog inherits from Animal
class Dog : Animal {
  // fields and methods of Animal 
  // fields and methods of Dog 
}
```

Polymorphism Compile Time

```charp
public class TestData  
{  
public int Add(int a, int b, int c)  
{  
    return a + b + c;  
}  
public int Add(int a, int b)  
{  
    return a + b;  
}  
}  
class Program  
{  
	static void Main(string[] args)  
	{  
	    TestData dataClass = new TestData();  
	    int add2 = dataClass.Add(45, 34, 67);  
	    int add1 = dataClass.Add(23, 34);  
	}  
}  
```

Dynamic/Runtime Polymorphism

```charp
public class Drawing  
{  
	public virtual double Area()  
	{  
	     return 0;  
	}  
}  

public class Circle : Drawing  
{  
	public double Radius { get; set; }  
	public Circle()  
	{  
	    Radius = 5;  
	}  
	public override double Area()  
	{  
	    return (3.14) * Math.Pow(Radius, 2);  
	}  
}  

public class Square : Drawing  
{  
	public double Length { get; set; }  
	public Square()  
	{  
	    Length = 6;  
	}  
	public override double Area()  
	{  
	    return Math.Pow(Length, 2);  
	}  
}  

public class Rectangle : Drawing  
{  
	public double Height { get; set; }  
	public double Width { get; set; }  
	public Rectangle()  
	{  
	    Height = 5.3;  
	    Width = 3.4;  
	}  
	public override double Area()  
	{  
	    return Height * Width;  
	}  
}  

class Program  
{  
	static void Main(string[] args)  
	{  

	    Drawing circle = new Circle();  
	    Console.WriteLine("Area :" + circle.Area());  

	    Drawing square = new Square();  
	    Console.WriteLine("Area :" + square.Area());  

	    Drawing rectangle = new Rectangle();  
	    Console.WriteLine("Area :" + rectangle.Area());  
	}  
}  

```

Overloading – method with same names and different signatures

Overriding – using a virtual keyword and overriding in child class

```csharp
public class Employee{
	public string name {get;set;}
	public string address {get;set;}
	public virtual void Validate(){
		CheckName();
		CheckAddress();
	}
	private void CheckName(){
	}
	private void CheckAdress(){
	}
public class Manager : Employee{
	public void Management(){
	}
	public override void Validate(){
	}
	public void Validate(bool strict)
	{

	}
	public void Validate(bool strict, int num1)
	{
	} 
}
```

**Struct**
------------------
A structure is a data type of a value type. A struct keyword is used when you are going to define a structure. Struct type is Private by default.

Although both class and structure are user-defined data types, they are different in several fundamental ways. A class is a reference type and stores on the heap. Struct, on the other hand, is a value type and is, therefore, stored on the stack. While the structure doesn’t support inheritance and polymorphism, the class provides support for both.

```csharp
struct MyStruct{
	public int Prop1 {get; set;}
	public int Prop2 {get; set;}
}
```

**Ref vs out**
-----------------------
The **ref** keyword passes arguments by reference. It means any changes made to this argument in the method will be reflected in that variable when control returns to the calling method.

```csharp
public static string GetNextName(ref int id)
{
    string returnText = "Next-" + id.ToString();
    id += 1;
    return returnText;
}
static void Main(string[] args)
{
    int i = 1;
    Console.WriteLine("Previous value of integer i:" + i.ToString());
    string test = GetNextName(ref i);
    Console.WriteLine("Current value of integer i:" + i.ToString());
}
/*	Output:
	Previous value of integer i:1
	Current value of integer i:2
*/
```

The **out** keyword passes arguments by reference. This is very similar to the ref keyword.
```csharp
public static string GetNextNameByOut(out int id)
{
    id = 1;
    string returnText = "Next-" + id.ToString();
    return returnText;
}
static void Main(string[] args)
{
    int i = 0;
    Console.WriteLine("Previous value of integer i:" + i.ToString());
    string test = GetNextNameByOut(out i);
    Console.WriteLine("Current value of integer i:" + i.ToString());
}
/*	Output:
	Previous value of integer i:0
	Current value of integer i:1
*/
```
The out and ref keywords are useful when we want to return a value in the same variables that are passed as an argument. Ref tells the compiler that the object is initialized before entering the function, while out tells the compiler that the object will be initialized inside the function.

So while ref is two-ways, out is out-only.

**Const vs Readonly**
-----------------
Const needs to be initialized while readonly can be assigned later on. However, both cannot be changed afterwards.

```csharp
public readonly int myVal;
public const int myVal2 = 1;
```

**Lambda expressions**
--------------------
You use a lambda expression to create an anonymous function.
```csharp
(input-parameters) => expression
(input-parameters) => { <sequence-of-statements> }
```

**Ternary Conditional Operator**
-----------------
The conditional operator "? :",known as the ternary conditional operator, evaluates a boolean expression and returns the result of one of the two expressions, depending on whether the Boolean expression evaluates to true or false. The format of the ternary operator can be seen below. On the left we have a boolean expression followed by two values. The resulting value will be the one on the left if the expression is true, otherwise the right side will be the resulting value.

```csharp
string name = "   ";
name = string.IsNullOrWhiteSpace(name) ? "Empty":"Not Empty"; //name will become "Empty"
bool condition = 0.1 > 0.5;
int? x = condition ? 12 : null; //Becomes null 
```

It is possible to combine the ternary operator with a lambda expression to form shorter functions/methods.
```csharp
string GetWeatherDisplay(double tempInCelsius) => tempInCelsius < 20.0 ? "Cold." : "Perfect!";
```

**String Builder**
-----------------
In C#, strings are immutable. To solve the problem, C# introduces the StringBuilder in the System.Text namespace. StringBuilder does not create a new object in memory, instead it dynamically expands memory to accomodate the modified string.

```csharp
StringBuilder sb = new StringBuilder(); //string will be appended later
//or
StringBuilder sb = new StringBuilder("Hello World!");
sb.Append(" Hi there");
sb.AppendLine("Hello C#")
//AppendFormat
StringBuilder sbAmout = new StringBuilder("Your total amount is ");
sbAmout.AppendFormat("{0} ", 25);
Console.WriteLine(sbAmout); //output: Your total amount is 25
//Insert
StringBuilder sb = new StringBuilder("Hello World!");
sb.Insert(5," C#"); 
Console.WriteLine(sb); //output: Hello C# World!
//Remove, start at index 5, then length 7
StringBuilder sb = new StringBuilder("Hello World!");
sb.Remove(5, 7);
Console.WriteLine(sb); //output: Hello
//Replace
StringBuilder sb = new StringBuilder("Hello World!");
sb.Replace("World", "C#");
Console.WriteLine(sb);//output: Hello C#!
```

**Boxing & Unboxing**
----------------
**Boxing** - is a process of converting a value type to an object type where value type is placed on the stack memory, and the object type is placed in the heap memory. This conversion is an implicit conversion and you can directly assign any value to an object, and C# will handle the rest of the conversion on its own.
```csharp
Int a=111;
Object b=a;
```
**Unboxing** - it is the reverse process of the boxing process. It is a conversion of the object type to the value type and the value of the boxed object type placed on the heap memory which will be transferred to the value type which is placed on the stack. This conversion of the unboxing process has to be done explicitly.
```csharp
Object b=111;
Int a=(int)b;
```
**Enum**
--------------
An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).'

```csharp
enum Day {Sat, Sun, Mon, Tue, Wed, Thu, Fri};
//Access Sun by Day.Sun, would give the value 1
```
**Delegates**
--------------
A delegate is an object which refers to a method or you can say it is a reference type variable that can hold a reference to the methods

```csharp
public delegate void Print(int value);
public static void Main()
{	
	Print printDel = PrintNum;
	printDel(50);
}
public static void PrintNum(int num){
	Console.WriteLine(num);
}
```

**Form Controls, Labels, Textboxes**
------------------------------------
We can assign and change the form controls on the go without needing to create a list.

```csharp
//Best method in our case
for (int i = 0; i < Form1.colNum; i++)
{
    this.Controls["label" + i].Text = Form1.colName[i];
}

//If you don't care about order
var labels = Controls.OfType<Label>().Where(label => label.Name.StartsWith("label"));

//If you want to use exact names
labels = new List<Label> { label0, label1, label2, label3, label4, label5, label6, label7, label8};
```
**Textbox & Checkbox**
-----------
Error Message Box
```csharp
MessageBox.Show("Invalid! Time cannot be 0.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
```
Textbox not empty
```csharp
if (!String.IsNullOrEmpty(textBox1.Text){
  //Do stuff
}
```
Checkbox checked
```csharp
if(checkBox1.Checked)
{
  //Do stuff
}
```
    
**Textbox Enter Event**
-----------------------------------
Instead of checking user input upon a button press we can check user input by a key event press. Below is a section of the code where we check the user's input for a valid file path.

```csharp
private void directoryTextbox_KeyDown(object sender, KeyEventArgs e)
{
  if (e.KeyCode == Keys.Enter)
  {
     //Do stuff
  }
  else if(e.KeyCode == Keys.Escape)
  {
      this.Close();
  }
}
```
**Textbox Key Press Event**
--------------
Only accept a digit.
```csharp
private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
{
    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
}
```
**Textbox Key Up Event**
-------
Do something after the user presses a key.
```csharp
//Update textbox 2 when textbox 1 is given input
private void textBox1_KeyUp(object sender, KeyEventArgs e)
{
    if (!String.IsNullOrEmpty(textBox1.Text) && !String.IsNullOrEmpty(textBox3.Text) &&
        !String.IsNullOrEmpty(textBox4.Text) && checkBox1.Checked)
    {
        double.TryParse(textBox1.Text, out double A);
        double.TryParse(textBox3.Text, out double C);
        double.TryParse(textBox4.Text, out double D);

        double B = D * (A / C);
        textBox2.Text = "" + Math.Round(B);
    }
}
```
**Combobox**
-----------------------
```csharp
//Set the default select state to the 1st index
comboBox1.SelectedIndex = 0;


//A way to add combobox items
comboBox1.Items.Add("bmp");
comboBox1.Items.Add("jpg");
comboBox1.Items.Add("png");

//Clear all
comboBox1.Items.Clear();
```

**App Settings**
-------------
Changing the app settings and using them.
```csharp
//Assigning them values
Properties.Settings.Default.info1 = 1;
Properties.Settings.Default.info2 = 2;
Properties.Settings.Default.info3 = 3;

//Save the settings
Properties.Settings.Default.Save();

//Assign other variables to them if we wish to
int info1 = Properties.Settings.Default.info1;
int info2 = Properties.Settings.Default.info2;
int info3 = Properties.Settings.Default.info3;
```
**Show Forms**
------------
```csharp
form2 f2 = new form2();
f2.Show(); //Show form2, immediately execute code under
//f2.ShowDialog(); //Show form2, wait for form2 to close

//To Close form2, have this somewhere in the form2.cs file
this.Close();
```

**Returning a Value from another Form**
------------
Form 1
```csharp
private void Btn_Click(object sender, EventArgs e)
{
  //Open the 2nd form
  using var form2 = new startIndex();
  var result = form2.ShowDialog();
  if (result == DialogResult.OK)
  {
      //Do stuff with the value received from form2
      int startingIndex = form2.ReturnValue1;
  }
}
```
Form 2
```csharp
private void foo()
{
  this.ReturnValue1 = 1;
  this.DialogResult = DialogResult.OK;
  this.Close();
}
public int ReturnValue1 { get; set; }
```

**Calling Function/Method from Another Form**
-----
```csharp

namespace F1
{
    // Method defined in this class
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //This method will be called from another form
        public void function()
        {
            MessageBox.Show("Hello");
        }
        //Opening the new form using button click
        private void OpenNewForm_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
    } 
    // This is second form
    public partial class Form2: Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        // on button click Form1 method will be called
        private void button1_Click(object sender, EventArgs e)
        {
            var mainForm = Application.OpenForms.OfType<Form1>().Single();
            mainForm.function();
        }
```

**Async Methods**
-----------
Delaying the task. An async method runs synchronously until it reaches its first await expression, at which point the method is suspended until the awaited task is complete.

```csharp
private async void method1()
{
  for (int i = 0; i < 5; i++)
  {
      //Do stuff
      //Then wait 5 seconds
      await Task.Delay(5000);
  }
}
```
Wait for another async method to finish before proceeding.
```csharp
private async void method2()
{
    for(int i = 0; i < 5; i++)
    {
        Task t = method2Cont("String");
        await t;
    }
}
private async Task method2Cont(string type)
{
  for(int i = 0; i < 5; i++)
  {
      //Do stuff with the string
      //Wait 3 seconds
      await Task.Delay(3000);
  }
}
```
**File Dialog**
------------------------------------
To open the file dialog and assign settings we can do the following:

```csharp
//Setting up the file explorer selector
OpenFileDialog openFileDialog1 = new OpenFileDialog();
openFileDialog1.CheckFileExists = true;
openFileDialog1.CheckPathExists = true;
openFileDialog1.RestoreDirectory = true;
openFileDialog1.InitialDirectory = @"C:\";
openFileDialog1.Title = "Choose a json file";
openFileDialog1.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";

//File path valid
if (openFileDialog1.ShowDialog() == DialogResult.OK)
{
  //Get the path of specified file
  directoryTextbox.Text = openFileDialog1.FileName;
  Properties.Settings.Default.FileName = openFileDialog1.FileName;
  Properties.Settings.Default.Save();
  MessageBox.Show("File path saved", "Success");
}
else
{
  MessageBox.Show("Invalid file path", "Error");
}
```

**Command Prompt**
-----------------
Run command prompt commands through a hidden console.

```csharp
using System.Diagnostics;
var proc1 = new ProcessStartInfo();
string aCommand = "shutdown -s -f -t " + time;
proc1.UseShellExecute = true;
proc1.WorkingDirectory = @"C:\Windows\System32";
proc1.FileName = @"C:\Windows\System32\cmd.exe";
proc1.Verb = "runas"; //behave as if the process has been started from Explorer with the "Run as Administrator" menu command
proc1.Arguments = "/c " + aCommand; //"/c" tells the prompt to run and terminate afterwards
proc1.WindowStyle = ProcessWindowStyle.Hidden;
Process.Start(proc1);
```

**Json Files in C#**
-----------------------------------
There are multiple ways to access and write information from and to a json file. The below code goes over two different ways.

```csharp
string fileName = @"d:\Users\Username\Desktop\sampleAB2.json";
if (File.Exists(fileName))
{
  var jsonObject = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(fileName));
  int rotation = jsonObject["Rotation"];
  
  //Writing a file
  var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
  var text = JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
  File.WriteAllText(@"d:\Users\Username\Desktop\sampleAB2.json", text);

  //If you want to assign the json to class instead, then you can call the value like this: jsonObject.Step1.classUsed[0]
  /*
  var jsonObjectEdit = JsonConvert.DeserializeObject<JsonValues>(File.ReadAllText(fileName));
  					    
  //System.Text.Json Serialize Method
  var options = new JsonSerializerOptions {WriteIndented = true};
  string jsonString = System.Text.Json.JsonSerializer.Serialize(jsonObjectEdit, options);
  Console.WriteLine(jsonString);
  File.WriteAllText(@"d:\Users\Username\Desktop\sampleAB2.json", jsonString);
  */
}
```

**Grid and Cell Values**
-----------------------------------
You can assign the cell values manually and also add in rows throughout the program.

```csharp
//Add a row
dataGridView1.Rows.Add("Row Name");

//Assigning row 8, cell 0 a value
dataGridView1.Rows[8].Cells[0].Value = "Row Name";
dataGridView1[8, 0].Value = "Row Name";

//Clear the grid
dataGridView1.Rows.Clear();
```

**Links to Other Helpful Projects**
------------
Here are some other C# projects that contain info on some more complicated concepts. As this project is more focused on showing the basics of C#, I felt that these other concepts warrant their own page.

[Data Structures](https://github.com/Kttra/DataStructuresCSharp) - Repo where I cover some data structures.

[Dictionary & Hashtables](https://github.com/Kttra/DictionaryHashNotes) - Some notes on Dictionaries and Hashtables.

[Git Overview](https://github.com/Kttra/GitOverview) - An overview on git commands and some details on using sourcetree.

[Input Validation](https://github.com/Kttra/ValidInput/blob/main/validInput.cs) - Code to check for valid input. Also includes examples of parsing and only allowing for specific input.

[Json](https://github.com/Kttra/JsonGridLoader) - Project that reads and write to json files.

[Random C# Programs](https://github.com/Kttra/RandomPrograms) - Random C# programs.

[Random String/Num Generator](https://github.com/Kttra/RandomStringGenerator/blob/main/randomStringGenerator.cs) - Code to quickly generate random strings or numbers.

[Regex Patterns](https://github.com/Kttra/RegexPatterns) - Details on regex expressions and patterns.

[Unit Testing](https://github.com/Kttra/xUnitExample) - A project that explains how to set up unit testing for visual studio projects (using both XUnit and MSTest).

[XML & IEnumerable](https://github.com/Kttra/IEnumerableXMLNotes) - Some quick notes on XElemenet and IEnumerable.
