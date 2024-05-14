using TangoRestApiClient.Common.Model;
using TangoRestApiClient.services.pedidos.model;

namespace TangoRestApiClient.services.pedidos;


public interface IPedidosServices
{
    PedidoQuery GetData();
    PedidoDataset GetDataById(int id);
    TransactionResultModel Insert(PedidoDataset data);
    TransactionResultModel Edit(PedidoDataset data);
    TransactionResultModel Delete(int id); //eliminar x anular ...
}
