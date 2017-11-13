using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using TypeExtensions = DevExpress.Mvvm.Native.TypeExtensions;

namespace HybridApp.Common {
    public class DesignTimeEntityGenerator {
        const int MaxLevel = 3;
        public static ObservableCollection<T> CreateCollection<T>() where T : class, new() {
            var collection = new ObservableCollection<T>();
            for(int i = 1; i < 16; i++) {
                var entity = CreateEntity<T>(i);
                collection.Add(entity);
            }
            return collection;
        }
        public static T CreateEntity<T>() where T : class, new() {
            return CreateEntity<T>(0);
        }
        static T CreateEntity<T>(int index) where T : class, new() {
            var entity = new T();
            InitializeProperties(index, entity);
            return entity;
        }
        static void InitializeProperties(int index, object entity, int level = 0) {
            if(level >= MaxLevel)
                return;
            foreach(var propertyInfo in entity.GetType().GetProperties().Where(p => p.CanWrite && p.GetIndexParameters().Length == 0)) {
                var propType = propertyInfo.PropertyType;
                var newValue = TryGetValueForSimpleProperty(propType, index);
                if(newValue != null) {
                    propertyInfo.SetValue(entity, newValue);
                }
                if(TypeExtensions.IsGenericType(propType) && propType.GetGenericTypeDefinition() == typeof(Nullable<>)) {
                    var nullebleType = propType.GetGenericArguments().FirstOrDefault();
                    var value = TryGetValueForSimpleProperty(nullebleType, index);
                    if(value != nullebleType)
                        propertyInfo.SetValue(entity, value);
                } else if(propType == typeof(string)) {
                    propertyInfo.SetValue(entity, propertyInfo.Name + index);
                } else if(!propType.GetTypeInfo().IsAbstract && propType.GetConstructors().FirstOrDefault(c => c.GetParameters().Count() == 0 && c.IsPublic) != null) {
                    var child = Activator.CreateInstance(propType);
                    InitializeProperties(index, child, level++);
                    propertyInfo.SetValue(entity, child);
                }
            }
        }
        static object TryGetValueForSimpleProperty(Type type, int index) {
            if(IsNumber(type)) {
                return Convert.ChangeType(index, type);
            } else if(type == typeof(DateTime)) {
                return DateTime.Now + TimeSpan.FromDays(index);
            } else if(type.GetTypeInfo().IsEnum) {
                var values = Enum.GetValues(type);
                return values.Cast<object>().ElementAt(index % values.Length);
            } else if(type == typeof(bool))
                return index % 2 == 0;
            return null;
        }
        static bool IsNumber(Type value) {
            return value == typeof(sbyte)
                    || value == typeof(byte)
                    || value == typeof(short)
                    || value == typeof(ushort)
                    || value == typeof(int)
                    || value == typeof(uint)
                    || value == typeof(long)
                    || value == typeof(ulong)
                    || value == typeof(float)
                    || value == typeof(double)
                    || value == typeof(decimal);
        }
    }
}
