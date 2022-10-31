using CapstoneAPI.Models;

namespace CapstoneAPI.Controllers
{
    public interface ISeller
    {
        bool AddProduct(Product p);

        bool DeleteProduct(int ProductId);

        bool UpdateProduct(int ProductId, Product p);

        bool AddPinCode(DeliveryPincode pin);

        List<Product> ShowAllProductsOfSeller(string EmailId);

        List<Order> ShowAllOrdersOfSeller(string SellerEmailId);

        bool UpdateDeliveryStatus(int OrderId, string delstatus);

        bool UpdateReturnStatus(int OrderId, bool retstatus);

    }
}
