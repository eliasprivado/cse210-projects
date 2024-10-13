//Entry Class; this class will display an entry to a user. It will display the date, promp text, and hold the entry text.
public class Entry
{
    //Attributes
    public string _date;
    public string _promptText;
    public string _entryText;

    //Methods
    public void Display()
    {
        Console.WriteLine("Welcome to the Journal Program!\nPlease select one of the following choices:");
        Console.WriteLine("1. Write\n2.Display\n3.Load\n4.Save\nQuit");
        Console.WriteLine("What would you like to do? ");
    }

}