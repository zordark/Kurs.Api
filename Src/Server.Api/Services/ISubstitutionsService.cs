using System.Collections.Generic;
using Kurs.Api.Server.Data;
using Kurs.Api.Server.Dto;

namespace Kurs.Api.Server.Services
{
    public interface ISubstitutionsService
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
        /// ������ ���� ���������� ��������� ������� ��������� ��� ������ � �������� ������� ���������� ��� �����������.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetAllowInputAgrumentDescriptors();

        /// <summary>
        /// ������ ���� ���������� ��������� ������ ��������� ��� ������ � �������� �������� ���������� ��� �����������.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IAttributeDescriptor> GetAllowOutputAgrumentDescriptors();
    }
}