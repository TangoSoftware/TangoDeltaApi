using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.transporte.model;

namespace TangoRestApiClient.services.transporte;
public interface ITransporteServices
{
    TransporteQuery GetData();
    TransporteDataset GetDataById(int id);
    TransactionResultModel Insert(TransporteDataset data);
    TransactionResultModel Edit(TransporteDataset data);
    TransactionResultModel Delete(int id);
    int GetIdByFilter(string filter);
}
