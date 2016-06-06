using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;
using Kurs.Api.Services;

namespace Kurs.Api.Server.Services
{
    public interface ISubstitutionsService : IKursApiService
    {
        IEnumerable<ISubstitution> Substitutions { get; }

        /// <summary>
        /// ����� ����������� �� Id
        /// </summary>
        /// <param name="substitutionId"></param>
        /// <returns></returns>
        ISubstitution Find( int substitutionId );

        /// <summary>
        /// ������� ����������� �� Id
        /// </summary>
        void Delete( int substitutionId );

        /// <summary>
        /// ������� ����� �����������
        /// </summary>
        OperationResult<ISubstitution, SubstitutionValidationErrors> Create( Substitution substitution );

        /// <summary>
        /// �������� �����������
        /// </summary>
        OperationResult<ISubstitution, SubstitutionValidationErrors> Update( Substitution substitution );

        /// <summary>
        /// ��������������� ������� ��������
        /// </summary>
        ActionValidationErrors ValidateAction( int triggerDescriptorId, TriggerAction action );

        /// <summary>
        /// ����� ���� ���������� ��������� �������, ��������� ��� ������ � �������� �������/�������� ���������� ��� �����������
        /// </summary>
        /// <param name="isInput">true - ��������� �������, false - ��������</param>
        /// <param name="attributeDescriptorIds">����� ������������ ���������, ������� ��� �������</param>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetAllowAgrumentDescriptors( bool isInput, IEnumerable<int> attributeDescriptorIds );

//        /// <summary>
//        /// ����� ���� ���������� ��������� ������ ��������� ��� ������ � �������� �������� ���������� ��� �����������, ��������������� �� �������.
//        /// </summary>
//        /// <returns></returns>
//        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowOutputAgrumentDescriptors( IEnumerable<int> attributeDescriptorIds );

        /// <summary>
        /// ����� ��������, ���������� ��� ������ � �������� �������� ��������� ��������>
        /// </summary>
        /// <param name="argumentDescriptorId">Id-����������� ��������� �����������</param>
        /// <param name="parentArgumentKeyOfValue">�������� ����� ������������� ���������. ��������� ��� ����������� ����������� ���������� �������� ���������� ���������. 
        /// ��������, ���� ���� ������� "������ ������", �� ���� �������� �������� ��������� ��� ��������� "������"</param>
        /// <returns>����� ��������� (��������, ������������ ��������). ���� ����������� �� ����� �������� ��������� ���, �� null</returns>
        Dictionary<string, string> GetAllowArgumentValues( int argumentDescriptorId, string parentArgumentKeyOfValue );
    }
}