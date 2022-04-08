using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace WebApiAutores.Utilidades
{
    public class SwaggerAgrupaPorVersion : IControllerModelConvention
    {
        public void Apply(ControllerModel controller)
        {
            var namespaceControlador = controller.ControllerType.Namespace; //Controllers.V1
            var versionAPI = namespaceControlador.Split('.').Last().ToLower(); //V11
            controller.ApiExplorer.GroupName = versionAPI;
        }
    }
}
