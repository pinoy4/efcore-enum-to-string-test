This repo has the purpose of reproducing this issue: https://stackoverflow.com/questions/55182602/efcore-enum-to-string-value-conversion-not-used-in-where-clause


There is a [docker-compose.yaml](docker-compose.yaml) file that can be used to start a postgres database.
Just run `docker-compose up postgres` and then you can run the app.


Migrations are set to run automatically when the app starts and no seeds are needed to reproduce the issue.

Once the app is running make a GET call to `http://localhost:5000/test` and the issue will present itself.
