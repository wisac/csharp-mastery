using MyDelegate;

myEventClass myEventTest = new();

// register event handler or subscriber to event
myEventTest.myEvent += PrintChange;

// event handler or subscriber
static void PrintChange(string message)
{
   Console.WriteLine("changed:" + message);
}


string input;
do
{
   input = Console.ReadLine();

   if (!input.Equals("no"))
   {
      // trigger event
      myEventTest.MyProperty = input;
   }
} while (!input.Equals("exit"));




namespace MyDelegate
{
   public delegate void myDelegate(string text);


   public class myEventClass
   {
      private string text;
      public event myDelegate myEvent; // event with whose delegate or callback accepts a string argument


      public string MyProperty
      {
         set
         {
            this.text = value; // the event or change we want to notify subscribers about
            myEvent(this.text); // trigger event
         }
      }
   }
}

