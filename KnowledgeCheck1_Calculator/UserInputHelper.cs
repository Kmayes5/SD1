using System;
namespace KnowledgeCheck1_Calculator
{
	internal static class UserInputHelper
	{
		internal static void PromptForTwoNumbers(ref int num1, ref int num2) {

           var num1string = Console.ReadLine();
           var num2string = Console.ReadLine();
			
			if(int.TryParse(num1string, out num2)&&int.TryParse(num2string, out num1))
			{
				return;
			}
			else {
				throw new Exception("input not a number");
			}
        }

			
	}
}

