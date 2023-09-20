# ULSolutions

Coding challenge solution to allow users to calculate Factorials and FizzBuzz.

Leverages the following patterns and packages:
- MediatR - allow request/responses for command and queries with clean separation.
- Result pattern - Lightweight object to indicate success / failure
- Fluent Validation - Allow defination of strongly typed rules.

Solution consist of 3 projects:
## ULSoutions.API
**Set as start project and use as input** 
Web API project using swagger to expose the following Get methods on the ChallengeController:
  - GetFactorial: HttpGet method with input factorial integer, returns the factorial result as a string.
  - GetFizzBuzz: HttpGet method with no input and returns FizzBuzz output to 100, with each result on a seperate line.
## ULSolutions.InfraStructure
Class library to handle the following commands:
  - CalculateFactorialCommand:
    - Input: integer up to 10000
    - Validation: Validate that input is greater than zero and less than or equal to 10K
    - Calculate factorial using .NET BigInteger. Naive implementation using async/await approach with a simple loop. Possible to extend implementation to a more complicated algorithm, e.g prime swing. Max input capped to 10K for performance reasons.
  - CalculateFizzBuzzCommand: Calculate FizzBuzz to 100
## ULSolutions.Test
Simple unit tests to cover basic scenarios and validation.
## To Do
Create UI application that leverages the API project to give user a better experience.
