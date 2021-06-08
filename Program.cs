using System;

namespace YOUR_APP_NAME.YOUR_MODULE_NAME
{
    class Program
    {
        static void Main(string[] args)
        {
            dotenv.net.DotEnv.Config(false);

            $FUNCTION_NAME.PreRun();

            var defaultFunctionInput = new LyFnInputParams { InputSample = "Hello" };
            var defaultFunctionOutput = $FUNCTION_NAME.Run(defaultFunctionInput);

            Console.WriteLine("Function Input: " + defaultFunctionInput.InputSample);
            Console.WriteLine("Function Output: " + defaultFunctionOutput.OutputSample);

            $FUNCTION_NAME.PostRun();
        }
    }
}
