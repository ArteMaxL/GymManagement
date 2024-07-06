using MediatR;

namespace GymManagement.Application.Subscriptions.Commands.CreateSubscription;

public record CreateSubscriptionCommand(
    string SubscriptionType, 
    Guid AdminGuid) : IRequest<Guid>;
