namespace VanakIndustry.Core.Constants
{
    public static class ApiMessages
    {
        public const string ResourceNotFound = "Api.Resource.Not.Found";
        public const string InvalidRequest = "Api.Invalid.Request";
        public const string GenericError = "Api.Generic.Error";
        public const string Forbidden = "Api.Forbidden";
        public const string PageSize = "Api.PageSize";
        public const string PageIndex = "Api.PageIndex";
        public const string DuplicateUserName = "Api.Username.Duplicate";
        public const string DuplicateEmail = "Api.Email.Duplicate";
        public const string NotEnoughBalance = "Api.NotEnoughBalance";
        public const string MinPasswordLengthError = "Api.MinPasswordLengthError";
        public const string IdRequired = "Api.Validate.IdRequired";

        public static class Auth
        {
            public const string EmailRequired = "Api.Auth.Email.Required";
            public const string UsernameRequired = "Api.Auth.Username.Required";
            public const string PasswordRequired = "Api.Auth.Password.Required";
            public const string RoleTypeRequired = "Api.Auth.RoleType.Required";
            public const string TokenRequired = "Api.Auth.Token.Required";
            public const string CurrentPasswordRequired = "Api.Auth.CurrentPassword.Required";
            public const string InvalidCredentials = "Api.Auth.Invalid.Credentials";
            public const string ResetPasswordResponse = "Api.Auth.ResetPassword.Response";
            
            public const string ValidateResetPasswordTokenInvalidToken = "Api.Auth.ValidateResetPasswordToken.InvalidToken";
            public const string ValidateResetPasswordTokenValidToken = "Api.Auth.ValidateResetPasswordToken.ValidToken";
            
            public const string ChangePasswordNotEqualsPasswords = "Api.Auth.ChangePassword.NotEqualPasswords";
            public const string ChangePasswordCurrentPasswordIsNotCorrect = "Api.Auth.ChangePassword.CurrentIsNotCorrect";
            public const string ChangePasswordSuccessful = "Api.Auth.ChangePassword.Successful";

            public const string MinPasswordLengthError = "Api.Auth.MinPasswordLengthError";
        }
        public static class User
        {
            public const string UserIdRequired = "Api.User.UserId.Required";
            public const string CompanyIdRequired = "Api.User.CompanyId.Required";
            public const string FirstNameRequired = "Api.User.FirstName.Required";    
            public const string LastNameRequired = "Api.User.LastName.Required";    
            public const string EmailRequired = "Api.User.Email.Required";    
            public const string FaxRequired = "Api.User.Fax.Required";    
            public const string PhoneRequired = "Api.User.Phone.Required";    
            public const string FunctionRequired = "Api.User.Function.Required";    
            public const string PasswordRequired = "Api.User.Password.Required";
            public const string EmailIsDuplicate = "Api.User.Email.Duplicate";
            public const string MinPasswordLengthError = "Api.User.Password.MinPasswordLengthError";
        }
    }
}
