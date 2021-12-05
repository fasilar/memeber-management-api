# Member Management API

This project was generated with `.Net Core Web API` & `.Net Core xUnit Test`

## Instructions

1. Run this project and update the API URL in the client application `(Git Repo - https://github.com/fasilar/member-management-client.git)`

## Submissions

1. Sample mock data stored as JSON under `App_Data` folder
2. An API end point accepting parameters (policy number and/or member card number) and return results matching the filter condition from the JSON records
3. Unit tests scenarios: 
    * Both parameters are null and it should not return results
    * Search by policy number
        
## Considerations & Decisions

1. Used `.Net Core Web API` with dependency injection
1. Separation of concerns
2. Unit tests using `xUnit`

## Limitations

1. Time Constraint

## Improvements Needed

1. Exception handling need to be done
2. More unit tests can be included