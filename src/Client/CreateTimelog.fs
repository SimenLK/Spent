[<RequireQualifiedAccess>]
module rec GitLab.Data.GraphQLClient.CreateTimelog

type InputVariables =
    { issuableId: string
      timeSpent: string
      spentAt: string
      summary: string }

/// User that logged the time.
type UserCore =
    {
        /// Username of the user. Unique within the instance of GitLab.
        username: string
    }

/// Timelog.
type Timelog =
    {
        /// Internal ID of the timelog.
        id: string
        /// Time spent displayed in seconds.
        timeSpent: int
        /// Timestamp of when the time tracked was spent at.
        spentAt: Option<string>
        /// Summary of how the time was spent.
        summary: Option<string>
        /// User that logged the time.
        user: UserCore
    }

type TimelogCreatePayload =
    {
        /// Timelog.
        timelog: Option<Timelog>
        /// Errors encountered during the mutation.
        errors: list<string>
    }

type Query =
    { timelogCreate: Option<TimelogCreatePayload> }
