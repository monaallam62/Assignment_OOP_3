namespace OOP_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //a) A University has Departments. If the university is closed, the departments no longer exist.
            //Answer
            //a)Composition relationship
            //=======================================================
            //b) A Driver uses a Car.The driver does not own the car.
            //b)Association relationship
            //=======================================================
            //c) A Dog is an Animal.
            //c)Inheritance
            //========================================================
            //d) A Team has Players. If the team is deleted, the players still exist.
            //d)Aggregation
            //========================================================
            //e) A method receives a Logger as a parameter and calls it inside the method only
            //e)Dependency
            #endregion

            #region Question 2
            //Q2 : Answer the following questions about access modifiers and sealed:

            //a) A parent class has a protected field. Can a child class in a different assembly access it? What about through an object instance from outside?
            //Yes can child access it in a diff assemply (protected access modifier with inheritance can acces internal and external), No,It can only be accessed within the derived class (through inheritance) not from outside the class hierarchy

            //b) What is the difference between protected internal and private protected?
            //without inheritance :protect internal: the member can accissibe within same assembly ,private protected:the member is accessible within the same class
            //with inheritance :protect internal:Accessible anywhere in the same assembly (internal) or in derived classes in other assemblies (protected),private protected:accessible in the containing class or derived classes in the same assembly only

            //c) What does the sealed keyword do when applied to a class? What about when applied to a method?
            // no one can inherit from this class,  the methosd can't be overridden 

            //d) Can you create an object from a sealed class using new? Why or why not?
            //Yes i can cuz sealed only prevents inheritance it doesn't prevent object creation
            #endregion


        }
    }
}
