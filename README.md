# myportfolio backend part
Template for Net 7 framework with PostgreSQL database
## Установка необходимого программного обеспечения
### Пакет NuGet необходимо добавить для поддержки базы данных, используемой в этом руководстве.
```
NET Core SDK version 7.0
```
```
Microsoft.AspNetCore.OpenApi 7.0
```
```
Microsoft.EntityFrameworkCore.InMemory 7.0
```
```
Microsoft.EntityFrameworkCore.SqlServer 7.0
```
```
Microsoft.EntityFrameworkCore.Tools 7.0
```
```
Microsoft.VisualStudio.Web.CodeGeneration.Design 7.0
```
```
Swashbuckle.AspNetCore 7.0
```
```
Npgsql
```
```
Npgsql.EntityFrameworkCore.PostgreSQL 7.0
``````
## Предварительная настройка

1. Установите `dotnet-ef`, для этого откройте консоль диспетчера пакетов, вставьте и выполните следующую команду:

```
  dotnet tool install --global dotnet-ef
```

## Создание БД с помощью CLI

1. Запустите сборку проекта:

```
  dotnet build
```

2. Запустите команду на создание миграции

```
  dotnet ef migrations add InitialCreate
```

3. Обновите БД

```
  dotnet ef database update
```

