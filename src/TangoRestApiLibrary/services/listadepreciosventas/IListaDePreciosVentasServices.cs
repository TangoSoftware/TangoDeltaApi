using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.listadepreciosventas.model;

namespace TangoRestApiClient.services.listadepreciosventas;

public interface IListaDePreciosVentasServices
{
    ListaDePreciosVentasQuery GetData();
    ListaDePreciosVentasDataset GetDataById(int id);
    TransactionResultModel Insert(ListaDePreciosVentasDataset data);
    TransactionResultModel Edit(ListaDePreciosVentasDataset data);
    TransactionResultModel Delete(int id);
    int GetIdByFilter(string filter);
}
