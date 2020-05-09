FROM mcr.microsoft.com/dotnet/core/sdk as base
WORKDIR /app
COPY . .
RUN dotnet build
RUN dotnet publish -c Release -o out **/P3Project.WebAPI.csproj

FROM mcr.microsoft.com/dotnet/core/aspnet
WORKDIR /app
COPY --from=base /app/out .
CMD [ "dotnet", "P3Project.WebAPI.csproj" ]