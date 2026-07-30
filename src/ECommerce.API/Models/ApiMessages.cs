namespace ECommerce.API.Models;

public static class ApiMessages
{

    public const string Registered = "Registered successfully.";
    public const string LoggedIn = "Logged in successfully.";
    public const string TokenRefreshed = "Tokens refreshed successfully.";
    public const string LoggedOut = "Logged out successfully.";
    public const string VerificationCodeSent =
        "Registration successful. A verification code was sent to your email. Confirm your email before logging in.";
    public const string VerificationCodeResent =
        "This email is registered but not confirmed. A new verification code was sent to your email.";
    public const string EmailConfirmed = "Email confirmed successfully.";
    public const string CurrentUserRetrieved = "Current user retrieved successfully.";
    public const string UserProfileUpdated = "Profile updated successfully.";
    public const string UserAddressesRetrieved = "Addresses retrieved successfully.";
    public const string UserAddressAdded = "Address added successfully.";

    public const string OrderCreated = "Order created successfully.";
    public const string OrdersRetrieved = "Orders retrieved successfully.";
    public const string OrderRetrieved = "Order retrieved successfully.";
    public const string OrderCancelled = "Order cancelled successfully.";
    public const string PaymentIntentCreated = "Payment intent created successfully.";

}
