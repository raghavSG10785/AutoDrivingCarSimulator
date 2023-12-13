using AutoCarDrivingLibrary;
using AutoCarDrivingLogic.Interface;
using AutoCarDrivingLogic.Service;
using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program 
{
    public static void Main()
    {
        //Assuming default implementations
        IAutoDrivingDirectionLogic autoCarDriving = new AutoDrivingDirectionLogic();
        var autoDriving = new Program(autoCarDriving);
        autoDriving.AutoCarDriving();
    }

    private IAutoDrivingDirectionLogic _AutoDrivingDirectionLogic { get; set; }
    public MoveCommand _MoveCommand { get; set; }
    public Program(IAutoDrivingDirectionLogic autoDrivingDirectionLogic)
    {
        _AutoDrivingDirectionLogic = autoDrivingDirectionLogic;
    }


    public void AutoCarDriving()
    {
        int x = 0;
        int y = 0;

        Console.WriteLine("Enter Move Command 'L', 'R' or 'F': ");
        string? value = Console.ReadLine();

        try
        {
            if (!string.IsNullOrEmpty(value))
            {

                if (value == MoveCommand.L.ToString() || value == MoveCommand.R.ToString())
                {
                    _AutoDrivingDirectionLogic.Move(value, 0, 0);
                }
                else if (value == MoveCommand.F.ToString())
                {
                    Console.WriteLine("Enter Width: ");
                    x = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter Length: ");
                    y = Convert.ToInt32(Console.ReadLine());
                    _AutoDrivingDirectionLogic.Move(value, x, y);
                }
            }
            else
            {
                Console.WriteLine("No Input was entered");
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }
}