var builder = DistributedApplication.CreateBuilder(args);

if (builder.ExecutionContext.IsPublishMode) {
    // Add a Dockerfile app, named "frontend", at "../frontend"
    builder.AddDockerfile("frontend", "../frontend")
        // allow Aspire to control the port via env variable PORT and target port 3000
        .WithHttpEndpoint(env: "PORT", targetPort: 3000)
        // give the app an extenral endpoint
        .WithExternalHttpEndpoints();
} else {
    // Add a NPM app, named "frontend", at "../frontend", with "npm run dev"
    builder.AddNpmApp("frontend", "../frontend", "dev")
        // allow Aspire to control the port via env variable PORT
        .WithHttpEndpoint(env: "PORT")
        // give the app an extenral endpoint
        .WithExternalHttpEndpoints();
}

builder.Build().Run();