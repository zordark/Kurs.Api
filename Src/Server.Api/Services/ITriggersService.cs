using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;

namespace Kurs.Api.Server.Services
{
    public interface ITriggersService
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
        ITrigger Create( Trigger trigger );

        /// <summary>
        /// �������� �������
        /// </summary>
        ITrigger Update( Trigger trigger );

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
        IEnumerable<ISubstitution> GetAllowActionSubstitutions( int triggerDescriptorId, int actionDescriptorId);

        /// <summary>
        /// ����� ��������, ���������� ��� ������ � �������� �������� ��������� ��������>
        /// </summary>
        /// <param name="triggerArgumentDescriptorId">Id-����������� ��������� �������� <see cref="TriggerArgument.DescriptorId"/>> </param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        IEnumerable<KeyValuePair<string, string>> GetAllowTriggerArgumentValues( int triggerArgumentDescriptorId );

        /// <summary>
        /// ����� ��������, ���������� ��� ������ � �������� �������� ��������� ������� ��������>
        /// </summary>
        /// <param name="triggerActionArgumentDescriptorId">Id-����������� ��������� ������� �������� <see cref="TriggerActionArgument.DescriptorId"/>> </param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        IEnumerable<KeyValuePair<string, string>> GetAllowTriggerActionArgumentValues( int triggerActionArgumentDescriptorId );

        /// <summary>
        /// ����� ������, ������� ����� ��������� ��������
        /// </summary>
        /// <param name="adapterId">Id-��������</param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        IEnumerable<ITypeDescriptor> GetAdapterCommands( int adapterId );
    }
}