namespace Exile.Constants;

public enum ResponseCodes
{
    RetryAfter2000msWithFailCount = -1,
    ExchangeKeysAndCredentials = 0,
    RetryAfter2000ms = 1,
    SuccessfulLogin = 2,
    InvalidUsernameOrPassword = 3,
    AccountDisabled = 4,
    AlreadyLoggedIn = 5,
    RuneScapeUpdated = 6,
    WorldFull = 7,
    CannotConnectLoginServerOffline = 8,
    LoginLimitExceeded = 9,
    CannotConnectBadSessionId = 10,
    LoginServerRejectedSession = 11,
    NeedMembersAccount = 12,
    CannotCompleteLoginTryDifferentWorld = 13,
    ServerUpdating = 14,
    UnknownError15 = 15,
    LoginAttemptsExceeded = 16,
    InMembersOnlyArea = 17,
    InvalidLoginServerRequested = 20,
    JustLeftAnotherWorld = 21,
    UnexplainedError
}