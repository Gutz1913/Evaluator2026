using Evaluator.Backend;

Console.WriteLine("Expression Evaluator");
var expression1 = "4*5/(4+6)";
var expression2 = "4*(5+6-(8/2^3)-7)-1";
var expression3 = ("9^(1/2)");

Console.WriteLine($"{expression1} = {MyEvaluator.Evaluate(expression1)}");
Console.WriteLine($"{expression2} = {MyEvaluator.Evaluate(expression2)}");
Console.WriteLine($"{expression3} = {MyEvaluator.Evaluate(expression3)}");