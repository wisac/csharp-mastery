class Person {
   protected string Name { get; set; }
   private string _email;


}

class Employee : Person {
   private string _accountName;

   public void makeAccountName(){
      _accountName = this.Name;
   }
}