var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.WebApi_ApiService>("apiservice");

builder.AddProject<Projects.WebApi_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
