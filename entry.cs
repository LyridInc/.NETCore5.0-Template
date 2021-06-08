using System;

namespace YOUR_APP_NAME.YOUR_MODULE_NAME
{
    // LyFnInputParams user fills up these parameters
    // The struct name need to be static, but the internal composition of the struct can be changed to fit your usage
    public struct LyFnInputParams
    {
        public string InputSample { get; set; }
    }

    // LyFnOutputParams a struct that will be returned
    // The struct name need to be static, but the internal composition of the struct can be changed to fit your usage
    public struct LyFnOutputParams
    {
        public string OutputSample { get; set; }
    }

    class YOUR_FUNCTION_NAME
    {
        // PreRun (optional) will be executed prior to Run()
        public static void PreRun()
        {

        }

        // Main Run
        public static LyFnOutputParams Run(LyFnInputParams input)
        {
            var value = Environment.GetEnvironmentVariable("ENV1") ?? "";

            return new LyFnOutputParams { OutputSample = input.InputSample + " " + value };
        }

        //PostRun (optional) will be executed after Run() is executed
        public static void PostRun()
        {

        }
    }
}
