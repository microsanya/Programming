/// <summary>
/// Перечисление состояния заказа
/// </summary>
public enum OrderStatus
{
    New,
    Processing,
    Assembly,
    Sent,
    Delivered,
    Returned,
    Abandoned
}