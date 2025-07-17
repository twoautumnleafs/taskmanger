Console Task Tracker with OOP Design in C#
This is a simple console-based task tracker application implemented in C# using Object-Oriented Programming principles. The project demonstrates core OOP concepts such as encapsulation, inheritance, polymorphism, and adherence to SOLID principles.

What This Project Does
Allows managing users, categories, and tasks.

Supports different types of tasks via polymorphism:

One-time tasks with a due date.

Recurring tasks with a repeat interval.

Provides basic operations such as adding, removing, and searching tasks.

Organizes tasks by user and category.

Displays tasks in a clear, console-friendly format.

Technologies and Concepts Used
C# 10+ language features.

.NET 7.0 console application.

OOP principles:

Encapsulation: Task and user data are encapsulated within classes.

Inheritance & Polymorphism: Base TaskBase class with derived OneTimeTask and RecurringTask.

SOLID principles for maintainable and extensible code.

Use of generic collections (List<T>), LINQ for searching/filtering.

Unique identifiers for tasks using Guid.

Separation of concerns with folders and classes organized by responsibility:

Models for domain entities.

Services for business logic (e.g., TaskManager).

How to Run
Ensure .NET 7 SDK is installed.

Clone or download the project.

Build and run from the command line:

dotnet build
dotnet run