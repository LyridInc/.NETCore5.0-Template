using System;

namespace YOUR_APP_NAME.YOUR_MODULE_NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            dotenv.net.DotEnv.Config(false);

            YOUR_FUNCTION_NAME.PreRun();

            var defaultFunctionInput = new LyFnInputParams { InputSample = "Hello" };
            var defaultFunctionOutput = YOUR_FUNCTION_NAME.Run(defaultFunctionInput);

            Console.WriteLine("Function Input: " + defaultFunctionInput.InputSample);
            Console.WriteLine("Function Output: " + defaultFunctionOutput.OutputSample);

            YOUR_FUNCTION_NAME.PostRun();
        }
    }
}
