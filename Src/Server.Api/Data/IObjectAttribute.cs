namespace Kurs.Api.Server.Data
{
    public interface IObjectAttribute
    {
        int Id { get; }

        string Uid { get; }

        string DisplayName { get; }

        /// <summary>
        /// Какому AdapterObject принадлежит этот атрибут
        /// </summary>
        IObject Owner { get; }

        /// <summary>
        /// Описатель этого атрибута
        /// </summary>
        ITypeDescriptor Descriptor { get; }

        /// <summary>
        /// Значение атрибута
        /// </summary>
        string Value { get; }

        /// <summary>
        /// Отображаемое пользователю значение атрибута
        /// </summary>
        string DisplayValue { get; }
    }
}