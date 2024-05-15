using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.vendedor.model;

namespace TangoRestApiClient.services.vendedor;

public interface IVendedorServices
{
    VendedorQuery GetData();
    VendedorDataset GetDataById(int id);
    TransactionResultModel Insert(VendedorDataset data);
    TransactionResultModel Edit(VendedorDataset data);
    TransactionResultModel Delete(int id);
    int GetIdByFilter(string filter);
}
