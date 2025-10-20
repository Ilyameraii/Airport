using System.Linq.Expressions;

namespace Airport.Extensions
{
    internal static class BindingExtensions
    {
        /// <summary>
        /// Обобщенный статический метод для типобезопасной привязки через лямбда-выражения
        /// </summary>
        /// <typeparam name="TControl">Тип элемента управления (должен наследоваться от <see cref="Control"/>).</typeparam>
        /// <typeparam name="TSourceProperty">Тип свойства источника данных, значение которого будет отображаться в контроле.</typeparam>
        /// <param name="control">
        /// Экземпляр элемента управления Windows Forms, к которому применяется привязка.
        /// </param>
        /// <param name="controlProperty">
        /// Лямбда-выражение, указывающее, какое свойство контрола будет связано с данными.
        /// Используется только для извлечения имени свойства; значение не вычисляется.
        /// </param>
        /// <param name="dataSource">
        /// Объект-источник данных, содержащий информацию для отображения.
        /// Должен поддерживать привязку через механизм <see cref="Control.DataBindings"/>.
        /// </param>
        /// <param name="sourceProperty">
        /// Лямбда-выражение, указывающее, какое свойство источника данных использовать.
        /// Используется только для извлечения имени свойства; значение не вычисляется.
        /// </param>
        public static void AddBindings<TControl,TControlProperty,TSource,TSourceProperty>(
            this TControl control,
            Expression<Func<TControl,TControlProperty>> controlProperty,
            TSource dataSource,
            Expression<Func<TSource,TSourceProperty>> sourceProperty)
            where TControl : Control
        {
            var controlPropertyName = GetPropertyName(controlProperty);
            var sourcePropertyName = GetPropertyName(sourceProperty);
            control.DataBindings.Add(controlPropertyName, dataSource, sourcePropertyName);
        }   

        private static string GetPropertyName<T, TProperty>(Expression<Func<T, TProperty>> sourceProperty)
         
        {
            if (sourceProperty.Body is MemberExpression member)
            {
                return member.Member.Name;
            }
            throw new ArgumentException("Expression must be a member access.", nameof(sourceProperty));
        }
    }
}
