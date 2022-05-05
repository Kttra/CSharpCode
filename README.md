# C# Code
A compilation of C# code to quickly reference to while making .NET applications.

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

**Projects**
------------
[Regex Patterns](https://github.com/Kttra/RegexPatterns) - Details on regex expressions and patterns.

[Random String/Num Generator](https://github.com/Kttra/RandomStringGenerator/blob/main/randomStringGenerator.cs) - Code to quickly generate random strings or numbers.

[Input Validation](https://github.com/Kttra/ValidInput/blob/main/validInput.cs) - Code to check for valid input.
