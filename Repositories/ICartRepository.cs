using be_flutter_nhom2.Models;

namespace be_flutter_nhom2.Repositories;

public interface ICartRepository
{
    Task<List<Cart>> GetCartByIdUserAsync(string idUser);

    Task<Cart> AddProductToCartAsync(string idUser, int idProduct, int quantity);
    
    Task<Cart> RemoveProductFromCartAsync(string idUser, int idProduct);
    
    Task<Cart> UpdateProductQuantityAsync(string idUser, int idProduct, int newQuantity);

    Task ClearCartAsync(string idUser);
    
    Task<decimal> GetCartTotalAsync(string idUser);
}
