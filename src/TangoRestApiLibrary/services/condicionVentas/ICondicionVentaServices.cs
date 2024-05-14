using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.condicionVentas.model;

namespace TangoRestApiClient.services.condicionVentas;
public interface ICondicionVentaServices
{
    CondicionVentaQuery GetData();
    CondicionVentaDataset GetDataById(int id);
    TransactionResultModel Insert(CondicionVentaDataset data);
    TransactionResultModel Edit(CondicionVentaDataset data);
    TransactionResultModel Delete(int id);
    int GetIdByFilter(string filter);
}
