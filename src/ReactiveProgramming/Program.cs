using System;
using System.Reactive.Linq;

namespace ReactiveProgramming
{
    static class Program
    {
        public static event EventHandler<string> Messenger;
        static void Main(string[] args)
        {
            var observable = Observable.FromEventPattern<string>(
                e => Messenger += e,
                e => Messenger -= e
            );

            var receiver1 = observable.Subscribe(message =>
            {
                Console.WriteLine($"The receiver one said: {message.EventArgs}");
            });

            var receiver2 = observable.Subscribe(message =>
            {
                Console.WriteLine($"The receiver two said: {message.EventArgs}");
            });

            Messenger(null, "Hello world");
            Messenger(null, "Hi there");
        }
    }
}
