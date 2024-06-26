using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApiCore.Service
{
    public interface IHasGetByCode<in T, out QR>
        where T : IConvertible
        where QR : BaseQueryRecord
    {

        /// <summary>
        /// Permite obtener un registro a partir de su código
        /// de Identificador alternativo UniqueKey.
        /// </summary>
        /// <param name="code">
        /// código de la entidad a utilizar como filtro.
        /// </param>
        /// <returns>
        /// Instancia de la entidad.
        /// </returns>
        QR GetByCode(T code);

        /// <summary>
        /// Permite obtener el Id de un registro a partir de su código
        /// de Identificador alternativo UniqueKey.
        /// </summary>
        /// <param name="code">
        /// Código de la entidad a utilizar como filtro.
        /// </param>
        /// <returns>
        /// Id de la entidad.
        /// </returns>
        int GetIdByCode(T code);

    }
}
