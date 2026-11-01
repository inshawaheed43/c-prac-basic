Variables are the data they can be changed dynamically during the execution of a program. 
They are used to store information that can be referenced and manipulated throughout the code. 
In programming, variables are essential for creating flexible and dynamic applications, allowing developers to 
work with different data types and values as needed.

variable represented by data types and identifiers 
 
types of variables according to scopes

1. Global vars: Always declared under class and in case of static it will be called by classname and
in case of instance it will be called by object name 

class A{
int a; // non-static/ global instance variable
static int b; // static global variable
}

2. Local Variables: 
This type of variable is declared under function 
and it will be called by function();


class b{
static void fun(){


}

void fun2(){
int a=100; // instance variable
}
}


