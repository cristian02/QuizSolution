# QuizSolution
Exercises

dotnet new sln 
dotnet new classlib -o Model
dotnet sln add Model/Model.csproj 

dotnet new console -o ShowOOP
dotnet sln add ShowOOP/ShowOOP.csproj
dotnet add ShowOOP/ShowOOP.csproj reference  Model/Model.csproj 

dotnet run --project ShowOOP/ShowOOP.csproj

dotnet new -l 

dotnet new webapp -o ShowJS
dotnet sln add ShowJS/ShowJS.csproj 
dotnet run --project ShowJS/ShowJS.csproj
