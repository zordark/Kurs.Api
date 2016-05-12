using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kurs.Api.Data;

namespace Kurs.Api
{
    public interface ISubstitutionService
    {
        /// <summary>
        /// Получить все подстановки
        /// </summary>
        /// <returns></returns>
        IEnumerable<SubstitutionInfo> ReadAll();

        /// <summary>
        /// Получить подстановку по идентификатору
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Substitution Read(int id);

        /// <summary>
        /// Создание новой подстановки
        /// </summary>
        /// <param name="substitution"></param>
        /// <returns></returns>
        Substitution Create(Substitution substitution);

        /// <summary>
        /// Удаление подстановки
        /// </summary>
        /// <param name="id"></param>
        void Delete(int id);

        /// <summary>
        /// Обновление подстановки
        /// </summary>
        /// <param name="substitution"></param>
        void Update(Substitution substitution);


    }
}
