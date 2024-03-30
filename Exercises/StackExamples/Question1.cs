using System.Collections;

namespace StackExamples;

public class Question1
{
    // Write program that implement a stack with push and pop operations.Fidn the top element of the stack and check if it is empty.
    public void Question()
    {
        Stack stack = new Stack();

        Console.WriteLine("Which operation : 1-push 2-pop 3-top 4-empty or anything you want to exit");
        
        
        
            int input = int.Parse(Console.ReadLine()!);// Not implementing any try catch for different inputs but it works fine for now.
            switch (input)
            {
                case 1:
                    Console.WriteLine("Value:");
                    stack.Push(int.Parse(Console.ReadLine()!)); // Add a new element to stack 
                    break;
                case 2:
                    stack.Pop(); // Remove the top element
                    break;
                case 3:
                    stack.Peek(); // Find the top element
                    break;
                case 4:
                    if (stack.Count == 0) // Checking if stack is empty
                    {
                        Console.WriteLine("Stack is empty");
                    }
                    break;
                default:
                    Console.WriteLine("Bye");
                    break;
            }
        
       
            /*  +---+        
                | A |
                +---+  //Stack values
                | B |
                +---+
                | C |
                +---+
                
                +---+
                | B |
                +---+
                | A | // Adding the B again
                +---+
                | C |
                +---+

                +---+
                | A |
                +---+ // Pop the value
                | C |
                +---+

                */

        
        
        
    }
}