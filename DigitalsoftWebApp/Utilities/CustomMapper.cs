using System.Reflection;

namespace DigitalsoftWebApp.Utilities
{
    public class CustomMapper
    {
        public static void CopyProperties<T, U>(T source, U dest)
        {
            var sourceProps = typeof(T).GetProperties().Where(x => x.CanRead).ToList();
            var destProps = typeof(U).GetProperties().Where(x => x.CanWrite).ToList();

            foreach (var sourceProp in sourceProps)
            {
                PropertyInfo targetProperty = FindClosestMatchProperty(sourceProp.Name, destProps);

                if (targetProperty != null)
                {
                    object value = sourceProp.GetValue(source, null);
                    if (value != null && targetProperty.PropertyType.IsAssignableFrom(sourceProp.PropertyType))
                    {
                        targetProperty.SetValue(dest, value);
                    }
                }
            }
        }

        private static PropertyInfo FindClosestMatchProperty(string propName, List<PropertyInfo> properties)
        {
            propName = propName.Replace("_", "");

            return properties.FirstOrDefault(p =>
            {
                var targetPropName = p.Name.Replace("_", "");
                return targetPropName.Contains(propName) || propName.Contains(targetPropName);
            });
        }
    }
}
