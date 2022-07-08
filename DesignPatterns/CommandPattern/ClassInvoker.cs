using System.Collections;

namespace DesignPatterns.CommandPattern;

public class ClassInvoker
{
    private ArrayList commandList = new ArrayList();

    public ClassInvoker()
    {
        commandList.Add(new Eat());
        commandList.Add(new Sleep());
        commandList.Add(new Walk());
    }

    public Command getCommand(string strCommand)
    {
        foreach (Object obj in commandList)
        {
            Command objExecute = (Command)obj;
            if (objExecute.strCommand == strCommand)
            {
                return objExecute;
            }
        }
        Console.WriteLine("Cannot find that command! ");
        return null!;
    }
}