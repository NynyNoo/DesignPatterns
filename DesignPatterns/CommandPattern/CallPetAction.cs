namespace DesignPatterns.CommandPattern;

public class CallPetAction
{
    public void CallPetActions()
    {
        ClassInvoker invoker = new();
        Console.WriteLine("Pet know how to: ");
        Command dogAction1 = invoker.getCommand("Walk");
        dogAction1.Action();
        invoker.getCommand("Eat").Action();
        invoker.getCommand("Sleep").Action();
        
    }
    
}