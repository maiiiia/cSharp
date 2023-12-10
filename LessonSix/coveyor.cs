using System;


// Упражнение 6.7
// Сымитировать управление лентой конвейера. Для этой цели можно
// создать метод Conveyor(), принимающий в качестве параметров
// следующие команды: "старт","стоп","вперед"и "назад".


public enum ConveyorCommand
{
    Start,
    Stop,
    Forward,
    Backward
}

public class ConveyorSimulation
{
    private bool isRunning = false;
    private int currentPosition = 0;

    public void Conveyor(ConveyorCommand command)
    {
        switch (command)
        {
            case ConveyorCommand.Start:
                StartConveyor();
                break;
            case ConveyorCommand.Stop:
                StopConveyor();
                break;
            case ConveyorCommand.Forward:
                MoveForward();
                break;
            case ConveyorCommand.Backward:
                MoveBackward();
                break;
            default:
                Console.WriteLine("Unknown command");
                break;
        }

        Console.WriteLine($"Current Position: {currentPosition}");
    }

    private void StartConveyor()
    {
        if (!isRunning)
        {
            Console.WriteLine("Conveyor started.");
            isRunning = true;
        }
        else
        {
            Console.WriteLine("Conveyor is already running.");
        }
    }

    private void StopConveyor()
    {
        if (isRunning)
        {
            Console.WriteLine("Conveyor stopped.");
            isRunning = false;
        }
        else
        {
            Console.WriteLine("Conveyor is already stopped.");
        }
    }

    private void MoveForward()
    {
        if (isRunning)
        {
            Console.WriteLine("Moving conveyor forward.");
            currentPosition++;
        }
        else
        {
            Console.WriteLine("Cannot move forward. Conveyor is not running.");
        }
    }

    private void MoveBackward()
    {
        if (isRunning)
        {
            Console.WriteLine("Moving conveyor backward.");
            currentPosition--;
        }
        else
        {
            Console.WriteLine("Cannot move backward. Conveyor is not running.");
        }
    }
}

// class Program
// {
//     static void Main()
//     {
//         ConveyorSimulation simulation = new ConveyorSimulation();

//         simulation.Conveyor(ConveyorCommand.Start);
//         simulation.Conveyor(ConveyorCommand.Forward);
//         simulation.Conveyor(ConveyorCommand.Stop);
//         simulation.Conveyor(ConveyorCommand.Backward);
//         simulation.Conveyor((ConveyorCommand)100); // Unknown command

//         // Output:
//         // Conveyor started.
//         // Moving conveyor forward.
//         // Conveyor stopped.
//         // Moving conveyor backward.
//         // Unknown command
//     }
// }
