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
    List<QR> Get(int pageSize, int pageIndex);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    D GetById(int id);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="filter"></param>
    /// <returns></returns>
    IQueryable<QR> GetByFilter(string filter);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    int Create(D data);
    /// <summary>
    ///
    /// </summary>
    /// <param name="data"></param>
    /// <returns></returns>
    void Update(D data);
    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    void Delete(int id);
}
