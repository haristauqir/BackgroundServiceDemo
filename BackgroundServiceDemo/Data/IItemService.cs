using BackgroundServiceDemo.Model;

namespace BackgroundServiceDemo.Data;

public interface IItemService
{
	List<Item> GetItems();
}