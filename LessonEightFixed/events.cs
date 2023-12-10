// using System;

// delegate void MyEventHandler(); // Declare the delegate type for the event.

// class MyEvent // Declare the class containing the event.
// {
//     private event MyEventHandler someEvent; // Declare the event using the delegate type.

//     public event MyEventHandler SomeEvent
//     {
//         add
//         {
//             someEvent -= value;
//             someEvent += value;
//         }
//         remove
//         {
//             someEvent -= value;
//         }
//     }

//     public void OnSomeEvent() 
//     {
//         someEvent?.Invoke();
//     }
// }


// class EventDemo
// {
//     static void Handler1() // Event handler.
//     {
//         Console.WriteLine("Event 1 occurred");
//     }

//     static void Handler2() // Event handler.
//     {
//         Console.WriteLine("Event 2 occurred");
//     }

//     static void Handler3() // Event handler.
//     {
//         Console.WriteLine("Event 3 occurred");
//     }

//     static void Main()
//     {
//         MyEvent evt = new MyEvent();
//         // Add event handlers to the event.
//         evt.SomeEvent += Handler1;
//         evt.SomeEvent += Handler2;
//         evt.SomeEvent += Handler3;

//         evt.OnSomeEvent(); // Trigger the event.
//     }
// }

