using TangoRestApiClient.Common.Model;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// llename
/// </summary>
/// <typeparam name="Q">Query</typeparam>
/// <typeparam name="D">Dataset</typeparam>
public interface IBaseServices<Q, D>
{
    Q GetData();
    D GetDataById(int id);
    int GetIdByFilter(string filter);
    TransactionResultModel Insert(D data);
    TransactionResultModel Edit(D data);
    TransactionResultModel Delete(int id);
}
