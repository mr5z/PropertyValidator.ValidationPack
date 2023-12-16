using System.Reflection;
using System.Resources;

namespace PropertyValidator.ValidationPack;

public static class ErrorMessageHelper
{
    public static void UpdateResource<T>()
    {
        var type = typeof(T);
        var resourceMan = new ResourceManager(type.UnderlyingSystemType.FullName, type.Assembly);
        var errType = typeof(ErrorMessages);
        var field = errType.GetField("resourceMan", BindingFlags.NonPublic | BindingFlags.Static);
        field.SetValue(null, resourceMan);
    }
}
