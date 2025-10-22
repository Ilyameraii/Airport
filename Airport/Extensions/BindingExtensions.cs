using System.ComponentModel.DataAnnotations;
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
        /// <param name="errorProvider">
        /// элемент ErrorProvider формы, по умолчанию null
        /// </param>
        public static void AddBindings<TControl, TControlProperty, TSource, TSourceProperty>(
            this TControl control,
            Expression<Func<TControl, TControlProperty>> controlProperty,
            TSource dataSource,
            Expression<Func<TSource, TSourceProperty>> sourceProperty,
            ErrorProvider? errorProvider = null)
            where TControl : Control
            where TSource : class
        {
            var controlPropertyName = GetPropertyName(controlProperty);
            var sourcePropertyName = GetPropertyName(sourceProperty);

            if (controlPropertyName == null || sourcePropertyName == null)
            {
                return;
            }

            control.DataBindings.Add(controlPropertyName, dataSource, sourcePropertyName);

            if (errorProvider != null)
            {
                // Инициализация: проверить ошибку сейчас
                UpdateErrorForProperty(control, dataSource, sourcePropertyName, errorProvider);

                // Подписка: обновлять ошибку при валидации контрола
                control.Validating += (s, e) =>
                {
                    UpdateErrorForProperty(control, dataSource, sourcePropertyName, errorProvider);
                    e.Cancel = false;
                };
            }
        }

        private static void UpdateErrorForProperty<TSource>(
            Control control,
            TSource dataSource,
            string propertyName,
            ErrorProvider errorProvider)
            where TSource : class
        {
            var context = new ValidationContext(dataSource);
            var results = new List<ValidationResult>();
            Validator.TryValidateObject(dataSource, context, results, true);

            var error = results.FirstOrDefault(r => r.MemberNames.Contains(propertyName));
            errorProvider.SetError(control, error?.ErrorMessage ?? "");
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
