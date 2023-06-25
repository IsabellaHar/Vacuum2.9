namespace Vacuum2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, I am a vacuum cleaner.");
            Console.WriteLine("I exist in a two square environment.  If I am in the left square and it is dirty, I clean it.  If it is clean, I move to the right square.");
            Console.WriteLine("If I am in the right square and it is dirty, I clean it.  If it is clean, I move to the left square.");


            int performance = 0;  //performance measure
            string location = "left";
            string stateLeft = "dirty";
            string stateRight = "dirty";

            int totalSteps = 5;

            for (int i = 0; i < totalSteps; i++)
            {

                //Award points for clean squares
                if (stateLeft == "clean") {
                    performance++;
                }
                if (stateRight == "clean") {
                    performance++;
                }

                //Check if on left square
                if (location == "left") {
                    //Check if the left square is dirty or clean and take appropriate action
                    if (stateLeft == "dirty") {
                        Console.WriteLine("I am cleaning the left square");
                        stateLeft = "clean";
                        Console.WriteLine("I am moving to the right square");
                        location = "right";
                    } else
                    {
                        Console.WriteLine("The left square is clean");
                        Console.WriteLine("I am moving to the right square");
                        location = "right";
                    } //end if-else -left square actions
                }
                else //location is the right square
                {
                    //Check if the right square is dirty or clean and take appropriate action
                    if (stateRight == "dirty") {
                        Console.WriteLine("I am cleaning the right square");
                        stateRight = "clean";
                        Console.WriteLine("I am moving to the left square");
                        location = "left";
                    }
                    else
                    {
                        Console.WriteLine("The right square is clean");
                        Console.WriteLine("I am moving to the left square");
                        location = "left";
                    } //end if-else
                }  //end else - right square actions
            }  //end for loop - steps

            Console.WriteLine("I was awarded " +  performance + " points over " + totalSteps + " steps.");


        } //end function Main






    } //end class Program
} //end namespace