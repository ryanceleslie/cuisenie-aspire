var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var apiService = builder.AddProject<Projects.Cuisenie_ApiService>("apiservice");

builder.AddProject<Projects.Cuisenie_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(cache)
    .WaitFor(cache)
    .WithReference(apiService)
    .WaitFor(apiService);

builder.AddProject<Projects.Cuisenie_RecipeService>("recipeservice");

builder.AddProject<Projects.NoTopLevelStatementExample>("notoplevelstatementexample");

builder.Build().Run();
