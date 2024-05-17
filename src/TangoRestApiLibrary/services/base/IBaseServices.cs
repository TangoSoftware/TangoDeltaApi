using TangoRestApiLibrary.services.basemodel;

namespace TangoRestApiClient.services.baseServices;

/// <summary>
/// 
/// </summary>
/// <typeparam name="QR"></typeparam>
/// <typeparam name="D"></typeparam>
public interface IBaseServices<QR, D>
    where QR : BaseQueryRecord
    where D : BaseData
{
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    List<QR> GetData();
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    D GetDataById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    int GetIdByFilter(string filter);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    int Insert(D data);
    /// <summary>
    ///
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    void Edit(D data);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    void Delete(int id);
}
