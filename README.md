# EjemploRL
dotnet new mvc --auth Individual -o EjemploRL

# 
    <PackageReference Include="Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore" Version="5.0.9" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.EntityFrameworkCore" Version="5.0.9" />
    <PackageReference Include="Microsoft.AspNetCore.Identity.UI" Version="5.0.9" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="5.0.9" />
    <PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="5.0.7" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="5.0.9" />
    <PackageReference Include="Microsoft.VisualStudio.Web.CodeGeneration.Design" Version="5.0.2" />

dotnet tool install --global dotnet-aspnet-codegenerator --version 5.0.2

dotnet aspnet-codegenerator identity -dc EjemploRL.Data.ApplicationDbContext --files "Account.Register;Account.Login"

dotnet tool update --global dotnet-ef --version 5.0.9

dotnet ef migrations add InitialMigration --context frutosecoapp.Data.ApplicationDbContext -o "C:\Users\Inteligo\Code\netcore\usmp\programacionI\demomvc\frutosecoapp\Data\Migrations"

dotnet ef database update





