using P1;

class Insha
{
    static int a = 10;//static variable


    //    void getNum()

    //    {
    //        //In  order to get input from user we can 
    //        //assist with this method 
    //        Console.WriteLine("Enter The 1st Number:");
    //        //Console.ReadLine String accept krta hai or humein 
    //        //isko int ki form mein accept krwana hai. That's why 
    ////We're using Convert.ToInt32 

    //        a = Convert.ToInt32 (Console.ReadLine());
    //        Console.WriteLine("Enter The 2nd Number:");
    //        b = Convert.ToInt32 (Console.ReadLine());
    //    }

    static void Main()
    {
        //its the syntax to create an object in C#
        Operation obj = new Operation();
        //obj.getNum();
        //obj.Add();
        obj.Sub();
        obj.Multi();
        obj.Div();
        SI obj4 = new SI();
        obj4.CalSI();
        //Operation obj= new Operation();
        ////obj.getNum();
        ////obj.Add();
        //obj.Sub();
        //obj.Multi();
        //obj.Div();
        //SI obj = new SI();
        //obj.CalSI();
        //calling instance variable from another class
        Variables obj1 = new Variables();
        Console.WriteLine(obj1.b);
        //calling static variable from same class as of it's static variable it 
        //doesn't need an object to be created and can be called directly by using the class name
        Console.WriteLine(Insha.a);
        //calling instance variable from another class
        //Variables obj1 = new Variables();

        //Console.WriteLine(obj1.b);
        //calling static variable from same class as of it's static variable it 
        //doesn't need an object to be created and can be called directly by using the class name

        Console.WriteLine(Insha.a);


        Concat obj2 = new Concat();
        obj2.ConcatNumbers();
        Concat obj3 = new Concat();
        obj3.ConcatStrNumbers();

    }


}

