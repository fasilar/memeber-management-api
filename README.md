# MemberManagement

This project was generated with .Net Core Web API & .Net Core xUnit Test

## Instructions

1. Run this project and update the API URL in the client application

## Submissions

1. Sample data stored as JSON under 'App_Data'
2. An API end point accepting parameters (policy number and/or member card number) and returns result according to the filer
3. Unit tests scenarios: 
        1. Both parameters are null and it should not return results
        2. Search by policy number
        
## Considerations & Decisions

1. Used .Net Core Web API with dependency injection
1. Separation of concerns
2. Unit tests using xUnit

## Limitations & Improvements Needed

1. Time Constraint
2. Exception handling need to be done
3. More unit tests can be included