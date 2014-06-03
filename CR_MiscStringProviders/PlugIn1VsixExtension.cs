using System.ComponentModel.Composition;
using DevExpress.CodeRush.Common;

namespace CR_MiscStringProviders
{
    [Export(typeof(IVsixPluginExtension))]
    public class CR_MiscStringProvidersExtension : IVsixPluginExtension { }
}