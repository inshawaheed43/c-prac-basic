using System;
using System.Collections.Generic;
using System.Text;

namespace P1
{
    internal class Variables
    {

        //types of variables
        //main types: static, instance, local, global, constant, readonly
        static int a = 10;//static variable

        //so basically Internal is the protection keyword 
        //which is used to access member, methods, function, var etc
        //from one file to another file in the same project.
        //So basically it is used for accessing internal members of a class
        //from another class in the same project.
        internal int b = 20; //instance variable

        //ok so now we'll call these vars in Program.cs but we 
        //need to remember the difference i.e. static variables can be called without
        //creating an object of the class but instance variables need an object to be
        //created first before they can be called


        const int c = 30; //constant variable
                          //if we don't want anyone to overwrite 
                          //the value of a variable then we can use const keyword

 
    }
}
