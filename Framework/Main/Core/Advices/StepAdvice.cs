using Framework.Main.Core.Attributes;
using System;

namespace Framework.Main.Core.Advices
{
    public static class StepAdvice
    {
        internal static void StepLog(Step step) => Console.WriteLine(" -- Navigate to " + step.dest);
    }
}
