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
string name = Console.ReadLine();
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
phrase.Substring(0, 3); //Returns Aca
```

**Conversion**
----------------
Convert strings to integer/double

```csharp
int num = Convert.ToInt32("45");
double num = Convert.ToDouble("45.12")
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
Example of a list. Make sure to include this at the top: using Systems.Collections.Generic;

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
food.Add(“pizza”);
food.Add(“ham”);
food.Add(“hotdog”);
food.Add(“fries”);
food.Remove(“fries”);
food.Insert(0, “sushi”);
food.Count;
food.indexOf(“pizza”);
food.LastIndexOf(“fries”);
food.Contains(“pizza”); //true
food.Sort(); //sorts alphabetically
food.Reverse();
food.Clear();
//Initialize
List<string> mylist = new List<string>(new string[] {"element1", "element2", "element3"});
//Vector to array
string[] foodArray = food.ToArray();
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
  using var form = new startIndex();
  var result = form.ShowDialog();
  if (result == DialogResult.OK)
  {
      //Our starting listing number
      int startingIndex = form.ReturnValue1;

      //Removes any existing numbers
      EditedTextBox.Text = Regex.Replace(EditedTextBox.Text, @"[0-9][.]", ""); //Removes #. (Ex: 1.)
      EditedTextBox.Text = Regex.Replace(EditedTextBox.Text, @"[0-9]", ""); //Removes #'s

      string[] lines = EditedTextBox.Lines;
      for (int i = 0; i < lines.Length; i++, startingIndex++)
      {
          lines[i] = (startingIndex) + ". " + lines[i].Trim();
      }
      EditedTextBox.Lines = lines;
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

**Async Methods**
-----------
Delaying the task
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
Run command prompt commands through a hidden console
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

**Projects**
------------
[Regex Patterns](https://github.com/Kttra/RegexPatterns) - Details on regex expressions and patterns.

[Random String/Num Generator](https://github.com/Kttra/RandomStringGenerator/blob/main/randomStringGenerator.cs) - Code to quickly generate random strings or numbers.

[Input Validation](https://github.com/Kttra/ValidInput/blob/main/validInput.cs) - Code to check for valid input.

[Json](https://github.com/Kttra/JsonGridLoader) - Project that reads and write to json files.
