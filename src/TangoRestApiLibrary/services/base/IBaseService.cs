using TangoRestApiClient.Common.Model;
using TangoRestApiLibrary.services.DTO;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// llename
/// </summary>
/// <typeparam name="Q"></typeparam>
/// <typeparam name="D"></typeparam>
public interface IBaseService<Q, D>
{
    Q GetData();
    D GetDataById(int id);
    int GetIdByFilter(string filter);
    TransactionResultModel Insert(D data);
    TransactionResultModel Edit(D data);
    TransactionResultModel Delete(int id); //eliminar x anular ...
}
