var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.HomeControl1_ApiService>("apiservice");

builder.AddProject<Projects.HomeControl1_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService)
    .WaitFor(apiService);

builder.Build().Run();
