
namespace SmartTicketing.ModelSkeleton;

public enum OrderStatus { Pending, Paid, Declined, ReconciliationRequired }
public enum PaymentMethod { Card, QrWallet }

public sealed class Destination {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public long FareVnd { get; set; }
    public bool Active { get; set; }
}

public sealed class TicketOrder {
    public Guid Id { get; set; }
    public Guid DestinationId { get; set; }
    public int Quantity { get; set; }
    public long TotalVnd { get; set; }
    public OrderStatus Status { get; set; }
    public string IdempotencyKey { get; set; } = string.Empty;
    public DateTime CreatedAt { get; set; }
    public void ConfirmPaid() => Status = OrderStatus.Paid;
    public void Cancel() { }
}

public sealed class Payment {
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public PaymentMethod Method { get; set; }
    public string ProviderReference { get; set; } = string.Empty;
    public long AmountVnd { get; set; }
    public OrderStatus Status { get; set; }
    public DateTime ExpiresAt { get; set; }
    public void MarkPaid() => Status = OrderStatus.Paid;
    public void MarkFailed() => Status = OrderStatus.Declined;
}

public sealed class Ticket {
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string Barcode { get; set; } = string.Empty;
    public DateTime IssuedAt { get; set; }
}

public interface IPaymentGateway { Task InitiateAsync(); Task QueryStatusAsync(); Task VerifyCallbackAsync(); }
public interface IPrinter { Task PrintAsync(Ticket ticket); }
public interface IOrderRepository { Task SaveAsync(TicketOrder order); Task<TicketOrder?> GetByIdAsync(Guid id); }

public sealed class TicketService {
    private readonly IPaymentGateway _gateway;
    private readonly IPrinter _printer;
    private readonly IOrderRepository _orders;
    public TicketService(IPaymentGateway gateway, IPrinter printer, IOrderRepository orders)
        => (_gateway, _printer, _orders) = (gateway, printer, orders);
    public Task<TicketOrder> CreateOrderAsync() => throw new NotImplementedException();
    public Task ConfirmPaymentAsync() => throw new NotImplementedException();
    public Task IssueTicketsAsync() => throw new NotImplementedException();
}
