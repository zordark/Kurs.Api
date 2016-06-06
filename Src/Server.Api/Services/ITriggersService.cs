using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface ITriggersService : IKursApiService
    {
        IEnumerable<ITrigger> Triggers { get; }

        /// <summary>
        /// ����� ������� �� Id
        /// </summary>
        /// <param name="triggerId"></param>
        /// <returns></returns>
        ITrigger Find( int triggerId );

        /// <summary>
        /// ������� �������
        /// </summary>
        void Delete( int triggerId );

        /// <summary>
        /// ������� ����� �������
        /// </summary>
        OperationResult<ITrigger, TriggerValidationErrors> Create( Trigger trigger );

        /// <summary>
        /// �������� �������
        /// </summary>
        OperationResult<ITrigger, TriggerValidationErrors> Update( Trigger trigger );

        /// <summary>
        /// ����� ���������� ������� ��������� ��������� ��� ������ � �������� EventDescriptor �������� <see cref="ITrigger"/>>
        /// </summary>
        /// <returns></returns>
        IEnumerable<ITypeDescriptor> GetAllowTriggerDescriptors();

        /// <summary>
        /// ����� �����������, ���������� ��� ���������� � <see cref="TriggerAction.SubstitutionIds"/> >
        /// </summary>
        /// <param name="triggerDescriptorId">Id-����������� ��������</param>
        /// <param name="actionDescriptorId">Id-����������� �������</param>
        /// <returns></returns>
        IEnumerable<ISubstitution> GetAllowActionSubstitutions( int triggerDescriptorId, int actionDescriptorId );

        /// <summary>
        /// ����� ���������� �������, ������� �������� ��������������� � ������� ��������� �����������>
        /// </summary>
        /// <param name="actionDescriptorId">Id-����������� �������</param>
        /// <param name="substitutionIds">����� Id ����������� �������</param>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetNotDefinedActionArguments( int actionDescriptorId, IEnumerable<int> substitutionIds );

        /// <summary>
        /// ����� ��������, ���������� ��� ������ � �������� �������� ��������� ��������>
        /// </summary>
        /// <param name="triggerArgumentDescriptorId">Id-����������� ��������� �������� <see cref="TriggerArgument.DescriptorId"/>> </param>
        /// <param name="parentArgumentKeyOfValue">�������� ����� ������������� ���������. ��������� ��� ����������� ����������� ���������� �������� ���������� ���������. 
        /// ��������, ���� ���� ������� "������ ������", �� ���� �������� �������� ��������� ��� ��������� "������"</param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        Dictionary<string, string> GetAllowTriggerArgumentValues( int triggerArgumentDescriptorId, string parentArgumentKeyOfValue );

        /// <summary>
        /// ����� ��������, ���������� ��� ������ � �������� �������� ��������� ������� ��������>
        /// </summary>
        /// <param name="triggerActionArgumentDescriptorId">Id-����������� ��������� ������� �������� <see cref="TriggerActionArgument.DescriptorId"/>> </param>
        /// <param name="parentArgumentKeyOfValue">�������� ����� ������������� ���������. ��������� ��� ����������� ����������� ���������� �������� ���������� ���������. 
        /// ��������, ���� ���� ������� "������ ������", �� ���� �������� �������� ��������� ��� ��������� "������"</param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        Dictionary<string, string> GetAllowTriggerActionArgumentValues( int triggerActionArgumentDescriptorId, string parentArgumentKeyOfValue );

        /// <summary>
        /// ����� ������, ������� ����� ��������� ��������
        /// </summary>
        /// <param name="adapterId">Id-��������</param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        IEnumerable<ITypeDescriptor> GetAdapterCommands( int adapterId );
    }
}