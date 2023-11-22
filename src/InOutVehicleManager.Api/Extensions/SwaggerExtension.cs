using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace InOutVehicleManager.Api.Extensions;

public class SwaggerExtension
{
    public class HttpMethodDocumentFilter : IDocumentFilter
    {
        public void Apply(OpenApiDocument swaggerDoc, DocumentFilterContext context)
        {
            var groupedPaths = swaggerDoc.Paths
                       .GroupBy(pair => GetHttpMethod(pair.Value))
                       .ToDictionary(group => group.Key, group => group.ToDictionary(pair => pair.Key, pair => pair.Value));

            swaggerDoc.Paths.Clear();

            foreach (var (groupName, paths) in groupedPaths)
            {
                var newPaths = paths.ToDictionary(pair => pair.Key, pair => pair.Value);
                foreach (var (pathKey, pathItem) in newPaths)
                {
                    swaggerDoc.Paths.Add(pathKey, pathItem);
                }
            }
        }

        private static string GetHttpMethod(OpenApiPathItem pathItem)
        {
            if (pathItem.Operations != null && pathItem.Operations.Any())
                return pathItem.Operations.First().Key.ToString();

            return string.Empty;
        }
    }
}