# Foundational C# & .NET Certification

## Table of Contents
1. [About](#about)
2. [Installation](#installation)
3. [Usage](#usage)
4. [Technologies](#technologies)
5. [Contributing](#contributing)
6. [Credits](#credits)

## About:
This repo contains study notes, exercises, and challenges that I completed while studying the Foundation C# Certification course available on Microsoft Learn x freeCodeCamp. 

There are console applications that I developed throughout the series of this coursework; you can follow along my process by reviewing commit history and seeing the branches for each part of the program (there are six parts in total, the first part was completed in browser so does not appear as a branch in this repo).

## Installation
This entire repo uses .NET 8.0 runtime so you will need to change the .csproj files to match your local machines version of .NET if it is different:
    `<TargetFramework>net8.0</TargetFramework>`

NOTE: Most of the code you see on this `main` branch of the repo is actually commented out. As I progressed in the coursework, I would comment out the old code to make space for new work. If you would like to run anything that is in this repo, you will have to uncomment the relevant sections and can follow along with branch histories to see what should be uncommented in order to execute the code without any errors. 

Alternatively, most of the code exercises in the history of each branch shows the expected output in the console with a comment after the written line of code. Simply viewing the code files here on GitHub is a quick way to preview the expected output, thanks to the comments.

## Usage
To check out the console applications developed as part of code challenges in this certification process, it is recommended to run these specific files as they are more robust than the notes and smaller exercises: 

- **Student Grading Console Application** 
  - Part2 > ChallengeProject > Starter
  - Open this folder in terminal
  - `dotnet run`
- **Pet Shelter Console Application**
  - Part3 > GuidedProject > Starter 
  - Open this folder in terminal
  - `dotnet run`

## Features
- There are five branches for parts 2-6 of this guided course, organized by lesson and projects
- Mirroring the flow of the five branches is five folders which have relevant content per each module in the course
  - Part2 
    - *title*: Create and run simple C# console applications
  - Part3
    - *title*: Add logic to C# console applications
  - Part4
    - *title*: Work with variable data in C# console applications
  - Part5
    - *title*: Create methods in C# console applications
  - Part6
    - *title*: Debug C# console applications
  - *MyApp* 
    - NOTE: this is a "bonus" folder which has additional notes or projects or tests which was used alongside the studies of this guided course. It is not officially part of the coursework in any organized capacity; it contains "overflow" information and ideas for practice etc. 

Each folder contains **ExercisePractice**, **GuidedProject**, and **ChallengeProject** folders respectively. If you are interested in running some of the console applications featured in this repo on your own local machine, it is recommended to open the GuidedProject > Starter or ChallengeProject > Starter folders in your terminal and run those with the following command: `dotnet run`

## Technologies
Some of the technologies and concepts practiced in this repo are:
- C# language, looping, logic
- .NET runtime and framework for C# classes & methods
- practice with git branching, pull requests, and organizing the flow of repo 

## Contributing
If you would like to contribute to this repo, feel free to fork or follow along for your own study experience! The main benefit to documenting my coursework in this way is the learning along the way; it is organized in a way that mirrors the iterative approach to software development and solving logic problems.

## Credits
All credit and thanks for the course material goes to [Microsoft Learn](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-1/) and [freeCodeCamp](https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/) for making this available to all for studying. I do not own any of the promps nor exercies featured in this repo; the solutions are a combination of following along with the lesson plans and my own solutions. They are here for all to see for collaborative learning processes and to share my certification journey with others.

Special thanks to Andrew Harasymiw and Matthew Black of @PrimeAcademy for teaching me how to learn code and giving me the building blocks to: *Read, Write, Speak, Teach*

## Get Started with C#, Part Four
This branch has exercises and challenges from Part Three of the Microsoft Learn "Get Started with C#" [learning path](https://learn.microsoft.com/en-us/training/paths/get-started-c-sharp-part-4/).

# NOTE TO SELF:
- Delete sensitive files on this GitHub repository (see commit "cleaning up files" on 1/20/23 specifically) 
- Make GH repo public when this is done!!