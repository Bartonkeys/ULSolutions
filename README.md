# ULSolutions

Coding challenge solution to allow users to calulate Factorials and FizzBuzz.

Leverages the following patterns and packages:
- MediatR
- Result
- Fluent Validation

Solution consist of 3 projects:
- ULSoutions.API: Web API project using swagger to expose the following Get methods on the ChallengeController:
  - GetFactorial: HttpGet method with input factorial integer, returns the factorial result as a string.
  - GetFizzBuzz: HttpGet method with no input and returns FizzBuzz output to 100, with each result on a sperate line.
