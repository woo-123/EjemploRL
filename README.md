# EjemploRL
dotnet new mvc --auth Individual -o EjemploRL

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

dotnet aspnet-codegenerator identity -dc EjemploRL.Data.ApplicationDbContext --files "Account.Register;Account.Login"