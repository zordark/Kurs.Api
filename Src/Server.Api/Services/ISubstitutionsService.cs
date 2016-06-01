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
        ISubstitution Create( Substitution substitution );

        /// <summary>
        /// �������� �����������
        /// </summary>
        ISubstitution Update( Substitution substitution );

        /// <summary>
        /// ����� ���� ���������� ��������� ������� ��������� ��� ������ � �������� ������� ���������� ��� �����������, ��������������� �� �������.
        /// </summary>
        /// <returns></returns>
        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowInputAgrumentDescriptors();

        /// <summary>
        /// ����� ���� ���������� ��������� ������ ��������� ��� ������ � �������� �������� ���������� ��� �����������, ��������������� �� �������.
        /// </summary>
        /// <returns></returns>
        Dictionary<ITypeDescriptor, IEnumerable<IAttributeDescriptor>> GetAllowOutputAgrumentDescriptors();

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