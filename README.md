# Task7.Subtask7

Код:
```
abstract class Delivery 
{
  public string Address;
}

class HomeDelivery: Delivery 
{
  /* ... */
}

class PickPointDelivery: Delivery 
{
  /* ... */
}

class ShopDelivery: Delivery 
{
  /* ... */
}

class Order < TDelivery,
TStruct > where TDelivery: Delivery 
{
  public TDelivery Delivery;

  public int Number;

  public string Description;

  public void DisplayAddress() 
  {
    Console.WriteLine(Delivery.Address);
  }

  // ... Другие поля
}
```
### Вашей задачей будет развить и продолжить эту систему классов, чтобы она больше напоминала систему в реальном мире.
