using Microsoft.EntityFrameworkCore;

// Grab the creator function form .NET
var builder = WebApplication.CreateBuilder(args);
// Adding a set of services (functionality) to our server
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
// Creating a server
var app = builder.Build();


// Defining the endpoints with the handlers (functions) we
// want to support, only mocks at the momement
app.MapGet("/todoitems", () =>
{
  return "Get all to-do items";
});

app.MapGet("/todoitems/complete", () =>
{
    return "A list of all todo items which are complete";
});

app.MapGet("/todoitems/{id}", (int id) =>
{
  return "Get an item by ID: " + id;
});

app.MapPost("/todoitems", () =>
{
  return "Add a new item";
});

app.MapPut("/todoitems/{id}", (int id) =>
{
  return "Update a todo with ID: " + id;
});

app.MapDelete("/todoitems/{id}", (int id) => 
{
  return "Deleting todo with ID: " + id;
});

// Exposing/starting the server
app.Run();