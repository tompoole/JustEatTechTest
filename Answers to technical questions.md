# Just Eat Tech Test Questions

## How long did you spend on the coding test?

Including these questions, I spent just over 4 hours.

If I were to spend more time on the solution, I would:

- Allow the user to input a full postcode, instead of just a outcode. The service could strip out the unnecessary part of the postcode. This appears to be the behaviour on the live Just Eat site.
- Add more functionality to the front end UI. Angular would make it easy to add sorting and filtering of the results table.
- Add more unit tests to cover the additonal functionality.
- Add more comprehensive integration tests, possibly testing the web project.
- Add tests to the Angular application.
- Load changeable details (such as the web service API key)  from configuration, rather than having it hard-coded

## What was the most useful feature that was added to the latest version of your chosen language? 

The feature I've found most useful is the null-conditional operator. It's less a new language feature (such as generics or async); more syntatical sugar that can be used make your code tidier and more readable. It can also help avoid the infamous NullReferenceException by making null checks easier.

I've used it here:

```c#
outcode = outcode?.Trim() ?? string.Empty;
```

In this snippet, I'm checking to see whether the outcode string variable is null before executing the Trim() method. If it is null, the expression evaluates to null, rather than throwing an exception. This could also be achived by wrapping the line in an if statement, however the operator looks neater and avoids additional nesting. The feature really comes into its own when traversing deeply nested objects. For example:

```c#
townName = restaurant?.Details?.Location?.Town?.FriendlyName;
```

## How would you track down a performance issue in production?

I've never had to track down a performance issue in production. In my previous role, we experiencing performance issues when the system was under high load. I worked with a senior developer and used profiling tools locally (both the Visual Studio profiler and Redgate ANTS Profiler) to identify bottlenecks within the system.

If I were asked to find performance issues within a production environment, I would look into tools such as New Relic. This is an area I would be interested in finding out more.


## How would you improve the JUST EAT APIs that you just used?

Overall I found the APIs easy to understand and use. The documentation for the individual methods was comprehensive - having the schema to refer to was useful. There could be more documentation explaining general API details such as authentication, API keys etc. If the API was indented for external use, a web-based UI for generating/revoking API keys could be useful. 

## Please describe yourself using JSON.

```json
{
  "firstName": "Tom",
  "middleName": null,
  "surname": "Poole",
  "age": 27,
  "favouriteTakeaway": "Chinese",
  "interests":
  [
  	"Technology",
    "Music",
  	"Films",
    "Running",
    "Coffee"
  ]
}
```

