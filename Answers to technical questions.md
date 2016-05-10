## How long did you spend on the coding test?

Including these questions, I spent just over 4 hours.

If I were to spend more time on the solution, I would:

- Allow the user to input a full postcode, instead of just a outcode. The service could strip out the unnecessary part of the postcode. This appears to be the behaviour on the live JustEat site.
- Add more functionality to the front end UI. Angular would make it easy to add sorting and filtering of the results table.
- Add more unit tests to cover the additonal functionality.
- Add additional 

## What was the most useful feature that was added to the latest version of your chosen language? 

C# 6 added a lot of useful features. It's tricky to pick a favourite!

The feature I've found most useful is the **null-conditional operator**. It's less a new language feature (such as generics or async); more syntatical sugar that can be used make your code tidier and more readable. It can also help avoid the infamous NullReferenceException by making null checks easier.

I've used it here:

```c#
outcode = outcode?.Trim() ?? string.Empty;
```

In this snippet, I'm checking to see whether the outcode string variable is null before executing the Trim() method. If it is null, the expression evaluates to null, rather than throwing an exception. This could also be achived by wrapping the line in an if statement. The feature really comes into its own when traversing deeply nested objects. For example:

```c#
townName = restaurant?.Details?.Location?.Town?.FriendlyName;
```

## How would you track down a performance issue in production?

I've never had to track down a performance issue in production. In my previous role, we experiencing performance issues when the system was under high load. I worked with a senior developer and used profiling tools locally (both the Visual Studio profiler and Redgate ANTS Profiler) to identify bottlenecks within the system.

If I were asked to find performance issues within a production environment, I would look at tools such as New Relic.


## How would you improve the JUST EAT APIs that you just used?

I found the APIs easy to understand and use. The documentation for the individual methods was comprehensive - having the schema to refer to was useful. The 

## Please describe yourself using JSON.

