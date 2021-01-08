using System;
using System.Reflection;

namespace Framework.Main.Core.Advices
{
    public class Advice<T> : DispatchProxy
    {
        private T _decorated;

        public static T Create(T decorated)
        {
            object proxy = Create<T, Advice<T>>();
            ((Advice<T>)proxy).SetDecorator(decorated);

            return (T)proxy;
        }

        public void SetDecorator(T decorated)
        {
            _decorated = decorated;
        }

        protected override object Invoke(MethodInfo targetMethod, object[] args)
        {
            if (targetMethod != null)
            {
                Before(targetMethod, args);
                var result = targetMethod.Invoke(_decorated, args);

                return result;
            }
            throw new ArgumentException(nameof(targetMethod));
        }

        private void Before(MethodInfo methodInfo, object[] args)
        {
            Attribute[] attr = (Attribute[])methodInfo.GetCustomAttributes(typeof(Attributes.Step));
            foreach (var a in attr)
            {
                if (a is Attributes.Step)
                    StepAdvice.StepLog((Attributes.Step)a);
            }
        }
    }
}
