using TangoRestApiClient.Common.Model;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// Llenar el summary con lo que hace
/// </summary>
/// <typeparam name="Q">Query</typeparam>
/// <typeparam name="D">Dataset</typeparam>
public interface IBaseServices<Q, D>
{
    Q GetData(int pageSize = 100, int pageIndex = 0); // devolver una colección del modelo de la query
    D GetDataById(int id); // devolver un objeto del modelo del ABM
    int GetIdByFilter(string filter); // ver
    TransactionResultModel Insert(D data); // devolver un INT con el ID
    TransactionResultModel Edit(D data); // no devolver nada, tira error si falla.
    TransactionResultModel Delete(int id); // no devolver nada, tira error si falla.
}
