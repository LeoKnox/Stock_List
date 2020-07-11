using System.Collections.Generic;

namespace Stock_App.Data
{
    public interface IStockService
    {
        List<Stock> GetAllStocks();
        Stock GetStockById(int stockId);
        void UpdateStock(int stockId, Stock stock);
        void DeleteStock(int stockId);
        void AddStock(Stock stock);
    }
}