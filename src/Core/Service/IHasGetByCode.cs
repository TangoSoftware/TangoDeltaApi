using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TangoDeltaApi.Core.Service;

namespace TangoDeltaApiCore.Service
{
    /// <summary>
    /// Representa una servicios con capacidad de
    /// obtener la Instancia o el Id de un registro, 
    /// a partir de su código de Identificador Alternativo UniqueKey.
    /// </summary>
    /// <typeparam name="C">
    /// Tipo de dato del código de Identificador Alternativo UniqueKey.
    /// </typeparam>
    /// <typeparam name="QR">
    /// Tipo de dato del QueryRecord a obtener.
    /// </typeparam>
    public interface IHasGetByCode<in C, out QR>
        where C : IConvertible
        where QR : BaseQueryRecord
    {

        /// <summary>
        /// Permite obtener un registro a partir de su código
        /// de Identificador Alternativo UniqueKey.
        /// </summary>
        /// <param name="code">
        /// código de la entidad a utilizar como filtro.
        /// </param>
        /// <returns>
        /// Instancia de la entidad.
        /// </returns>
        QR GetByCode(C code);

        /// <summary>
        /// Permite obtener el Id de un registro a partir de su código
        /// de Identificador Alternativo UniqueKey.
        /// </summary>
        /// <param name="code">
        /// Código de la entidad a utilizar como filtro.
        /// </param>
        /// <returns>
        /// Id de la entidad.
        /// </returns>
        int GetIdByCode(C code);

    }
}
