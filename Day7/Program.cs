

// string name = "Zain Henny";

// int charPos = name.IndexOf("Z");

// string firstName = name.Substring(charPos);

// Console.WriteLine(firstName);

// int myAge = 25;
// int votingAge = 18;
// Console.WriteLine(myAge >= votingAge);


// string name = "Henny";
// bool isProgrammer = true;
// Console.WriteLine(name + " is learning C#: " + isProgrammer);


string name = "Henny";
int age = 12;
bool isLearning = true;

Console.WriteLine($"My name is {name}, I am {age} years old, And am learning C#: {isLearning}");

string username = "Henny";
string password = "1234";  
bool isLoggedIn = false;

if (password == "1234")
{
    isLoggedIn = true;
}

Console.WriteLine($"Username: {username}");
Console.WriteLine($"Password: {password}");
Console.WriteLine($"Login successful: {isLoggedIn}");

string studentNmae = "Zain";
int examScore = 60;
bool isPass = false;

if (examScore >= 40)
{
    isPass = true;
}


Console.WriteLine($"studentName: {studentNmae}");
Console.WriteLine($"examScore: {examScore}");
Console.WriteLine($"You Passed: {isPass}");
