using Microsoft.Extensions.Localization;
using System.Reflection;

namespace   InvoiceGenerator.Resources
{
     /// <summary>
     /// Provides localized resources for Views
     /// </summary>
    public class ViewLocalizer
    {
        private readonly IStringLocalizer _localizer;

        public ViewLocalizer(IStringLocalizerFactory factory)
        {
            var type = typeof(Resource);

            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create(nameof(Resource), assemblyName.Name);
        }

        public LocalizedString this[string key, params object[] args] => _localizer[key, args];

    }
}
