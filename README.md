[![Build status](https://ci.appveyor.com/api/projects/status/v2ti3t1l6d2q3key?svg=true)](https://ci.appveyor.com/project/jacobduijzerRHM/cleanarchitectureworkshop)


# Clean Architecture, workshop

The aim of this workshop: getting started with clean architecture. Not by reading all the theory but starting handson with a sample application.

# The problem
We have a Golf application with multiple UI's: a website and an app. Both UI's are used to keep track of your game, scores, handicap, etc. This project screams for a clean architecture because we can re-use almost everything. Business logic, data storage, notifications.

# The Solution
Clean Architecture :)

# The Workshop

## Theory
Just a littlebit. Sorry.

![Clean Architecture](./artwork/CleanArchitecture.jpg)

### Different names, (almost) same solution

- Hexagonal Architecture
- Onion Architecture
- Screaming Architecture
- Lean Architecture
- A Use-Case Driven Approach

Each of these architectures produce systems that are:

- Independent of Frameworks. The architecture does not depend on the existence of some library of feature laden software. This allows you to use such frameworks as tools, rather than having to cram your system into their limited constraints.

- Testable. The business rules can be tested without the UI, Database, Web Server, or any other external element.

- Independent of UI. The UI can change easily, without changing the rest of the system. A Web UI could be replaced with a console UI, for example, without changing the business rules.

- Independent of Database. You can swap out Oracle or SQL Server, for Mongo, BigTable, CouchDB, or something else. Your business rules are not bound to the database.

- Independent of any external agency. In fact your business rules simply don’t know anything at all about the outside world.

## Create an interactor (use case) to retrieve all Courses

Create a use case to retrieve all golf courses to be able to select the course and loop you are playing on. 

## Create an interactor (use case) to store a new ScoreCard

Create a use case to store a score card in a repository. This should be some kind of persistant storage but for this workshop we just use an in-mem repository.

## Add a simple UI

Just create a simple UI with the following functionality:

- Show a list with courses and loops
- Select a loop and fill in a score card
- Store the score card

## Recap

- Differences for me as a programmer

- Differences for my projects 

- Discussion about the workshop. 

# Links
- [The Clean Architecture (Uncle Bob)](https://8thlight.com/blog/uncle-bob/2012/08/13/the-clean-architecture.html)

- [A starting point for Clean Architecture with .NET (Steve Smith)](https://github.com/ardalis/CleanArchitecture)

- [a Clean Architecture in .Net (Stephan Hoekstra, Funda)](https://medium.com/@stephanhoekstra/clean-architecture-in-net-8eed6c224c50
)

- [Simple mediator implementation in .NET](https://github.com/jbogard/MediatR)

- [A CODE REVIEW CHECKLIST](http://www.jondjones.com/c-sharp-bootcamp/clean-code/code-reviews/a-code-review-checklist)	

# Books
- [Clean Architecture: A Craftsman's Guide to Software Structure and Design (Robert C. Martin Series)](https://www.amazon.com/Clean-Architecture-Craftsmans-Software-Structure/dp/0134494164)
