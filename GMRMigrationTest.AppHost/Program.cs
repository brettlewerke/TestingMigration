var builder = DistributedApplication.CreateBuilder(args);

var apiService = builder.AddProject<Projects.GMRMigrationTest_ApiService>("apiservice");

builder.AddProject<Projects.GMRMigrationTest_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);

builder.Build().Run();
