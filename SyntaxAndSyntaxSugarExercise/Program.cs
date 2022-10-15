namespace SyntaxAndSyntaxSugarExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // int answer = 4; //***explicit typing ***
            // string response;//***explicit typing ***

            // if (answer < 9)
            // {
            // response = answer + " is less than nine";
            //}
            //else
            //{
            ///  response = answer + “greater than or equal to nine”;
            // }


            //****** Explicit typing, Inferred Typing,Ternary Operator & String Interpolation*****

            var answer  = 4; //Inferred Typing     
            int number = 9; //Explicit typing
            var response = (answer < number) ? $"{answer} is less than nine" : $"{answer} greater than or equal to nine";

                
            Console.WriteLine(response);






        }
    }
}