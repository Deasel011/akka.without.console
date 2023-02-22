//-----------------------------------------------------------------------
// <copyright file="GreetingActor.cs" company="Akka.NET Project">
//     Copyright (C) 2009-2022 Lightbend Inc. <http://www.lightbend.com>
//     Copyright (C) 2013-2022 .NET Foundation <https://github.com/akkadotnet/akka.net>
// </copyright>
//-----------------------------------------------------------------------

#region akka-hello-world-greeting
using System;
using Akka.Actor;

namespace HelloWorld
{
    /// <summary>
    /// The actor class
    /// </summary>
    public class GreetingActor : ReceiveActor
    {
        public GreetingActor()
        {
            // Tell the actor to respond to the Greet message
            Receive<Greet>(greet => System.Diagnostics.Debug.WriteLine($"Hello {greet.Who}", ConsoleColor.Green));
        }
        protected override void PreStart() => System.Diagnostics.Debug.WriteLine("Good Morning, we are awake!", ConsoleColor.Green);

        protected override void PostStop() => System.Diagnostics.Debug.WriteLine("Good Night, going to bed!", ConsoleColor.Red);
    }
}
#endregion

