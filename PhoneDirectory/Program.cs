using Microsoft.EntityFrameworkCore;
using PhoneDirectory.Application;
using PhoneDirectory.Factory;
using PhoneDirectory.Repository;
using PhoneDirectory.Service;
using PhoneDirectory.Dto.Requests;
using PhoneDirectory.Mapping;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<PhoneDirectoryDbContext>(options => options.UseInMemoryDatabase("PhoneDirectoryDb"));
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<ContactService>();
builder.Services.AddScoped<ContactFactory>();
builder.Services.AddScoped<IContactGroupRepository, ContactGroupRepository>();
builder.Services.AddScoped<ContactGroupService>();
builder.Services.AddScoped<ContactGroupFactory>();
builder.Services.AddScoped<ContactApplication>();
builder.Services.AddAutoMapper(typeof(ContactMappingProfile), typeof(ContactGroupMappingProfile));


var app = builder.Build();

app.MapPost("/contacts", (AddContactRequest request, ContactApplication appLayer) =>
{
    var response = appLayer.AddContact(request);
    return Results.Ok(response);
});

app.MapDelete("/contacts/{id}", (int id, ContactApplication appLayer) =>
{
    return appLayer.DeleteContact(id) ? Results.NoContent() : Results.NotFound();
});

app.MapPut("/contacts/{id}", (int id,UpdateContactRequest request, ContactApplication appLayer) =>
{
    var response = appLayer.UpdateContact(id,request);
    return Results.Ok(response);
});

app.MapGet("/contacts", (ContactApplication appLayer) =>
{
    var response = appLayer.GetContact();
    return Results.Ok(response);
});

app.MapGet("/contacts/{id}", (int id, ContactApplication appLayer) =>
{
    var response = appLayer.GetContactId(id);
    return response is not null ? Results.Ok(response) : Results.NotFound();
});

app.MapPost("/groups", (AddGroupRequest request, ContactApplication appLayer) =>
{
    var response = appLayer.AddGroup(request);
    return Results.Ok(response);
});

app.MapDelete("/groups/{id}", (int id, ContactApplication appLayer) =>
{
    var result = appLayer.DeleteGroup(id);
    return result ? Results.Ok() : Results.NotFound();
});

app.MapGet("/groups", (ContactApplication appLayer) =>
{
    var response = appLayer.GetGroups();
    return Results.Ok(response);
});

app.Run("http://localhost:7227");
