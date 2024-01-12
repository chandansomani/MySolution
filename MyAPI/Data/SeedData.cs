namespace Users.DatabaseEntity
{
    public static class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HashingAlgorithm>().HasData(
                new HashingAlgorithm
                {
                    HashingAlgorithmId = new Guid(),
                    AlgorithmName = "RSA",
                    AlgorithmDescription = "RSA",
                    Status = true,
                    CreatedByID = Guid.NewGuid(),
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByID = Guid.NewGuid(),
                    ModifiedDate = DateTime.UtcNow,
                },                
            );
            modelBuilder.Entity<EmailValidationStatus>().HasData(
                new EmailValidationStatus { 
                    EmailValidationStatusId = new Guid(),
                    StatusDescription = "",
                    CreatedByID = Guid.NewGuid(),
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByID= Guid.NewGuid(),
                    ModifiedDate = DateTime.UtcNow,
                }
                );
            modelBuilder.Entity<ExternalProvider>().HasData(
                new ExternalProvider {
                    ExternalProviderId = new Guid(),
                    Status = true,
                    ProviderName = "",
                    WSEndPoint = "",
                    CreatedByID= Guid.NewGuid(),
                    CreatedDate = DateTime.UtcNow,
                    ModifiedByID = new Guid(),
                    ModifiedDate = DateTime.UtcNow,                    
                }
                );
            modelBuilder.Entity<User>().HasData(
                   new User
                   {
                       UserId = Guid.NewGuid(),
                       UserFriendlyId = "SampleUser001",
                       FirstName = "John",
                       LastName = "Doe",
                       PreferredName = "Johnny",
                       FullName = "John Doe",
                       MobileNumber = "+1234567890",
                       UserName = "john.doe",
                       PasswordHash = "hashed_password_1",
                       PasswordSalt = "password_salt_1",
                       HashingAlgorithmId = Guid.NewGuid(),
                       Email = "john.doe@example.com",
                       ConfirmationToken = "confirmation_token_1",
                       TokenGenerationTime = DateTime.UtcNow,
                       EmailValidationStatusId = Guid.NewGuid(),
                       PasswordRecoveryToken = "recovery_token_1",
                       RecoveryTokenTime = DateTime.UtcNow,
                       IsFirstLogin = true,
                       ExternalProviderId = Guid.NewGuid(),
                   },
                   new User
                   {
                       UserId = Guid.NewGuid(),
                       UserFriendlyId = "SampleUser002",
                       FirstName = "Jane",
                       LastName = "Smith",
                       PreferredName = "Janie",
                       FullName = "Jane Smith",
                       MobileNumber = "+9876543210",
                       UserName = "jane.smith",
                       PasswordHash = "hashed_password_2",
                       PasswordSalt = "password_salt_2",
                       HashingAlgorithmId = Guid.NewGuid(),
                       Email = "jane.smith@example.com",
                       ConfirmationToken = "confirmation_token_2",
                       TokenGenerationTime = DateTime.UtcNow,
                       EmailValidationStatusId = Guid.NewGuid(),
                       PasswordRecoveryToken = "recovery_token_2",
                       RecoveryTokenTime = DateTime.UtcNow,
                       IsFirstLogin = false,
                       ExternalProviderId = null,
                   }
            );
        }
    }
}