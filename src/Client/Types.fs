namespace rec GitLab.Data.GraphQLClient

/// Access level to a resource
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccessLevelEnum =
    /// No access.
    | [<CompiledName "NO_ACCESS">] NoAccess
    /// Minimal access.
    | [<CompiledName "MINIMAL_ACCESS">] MinimalAccess
    /// Guest access.
    | [<CompiledName "GUEST">] Guest
    /// Planner access.
    | [<CompiledName "PLANNER">] Planner
    /// Reporter access.
    | [<CompiledName "REPORTER">] Reporter
    /// Developer access.
    | [<CompiledName "DEVELOPER">] Developer
    /// Maintainer access.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner access.
    | [<CompiledName "OWNER">] Owner
    /// Admin access.
    | [<CompiledName "ADMIN">] Admin

/// Access configured on a granular scope.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccessTokenGranularScopeAccess =
    /// Grants access to resources belonging to all personal projects of a user.
    | [<CompiledName "PERSONAL_PROJECTS">] PersonalProjects
    /// Grants access to resources belonging to all groups and projects the user is a member of.
    | [<CompiledName "ALL_MEMBERSHIPS">] AllMemberships
    /// Grants access to resources belonging to selected groups and projects the user is a member of.
    | [<CompiledName "SELECTED_MEMBERSHIPS">] SelectedMemberships
    /// Grants access to standalone user-level resources.
    | [<CompiledName "USER">] User
    /// Grants access to standalone instance-level resources.
    | [<CompiledName "INSTANCE">] Instance

/// Values for sorting access tokens.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccessTokenSort =
    /// Sort by created_at in descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Sort by created_at in ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Sort by updated_at in descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Sort by updated_at in ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Sort by expires_at in descending order.
    | [<CompiledName "EXPIRES_DESC">] ExpiresDesc
    /// Sort by expires_at in ascending order.
    | [<CompiledName "EXPIRES_ASC">] ExpiresAsc
    /// Sort by last_used_at in descending order.
    | [<CompiledName "LAST_USED_DESC">] LastUsedDesc
    /// Sort by last_used_at in ascending order.
    | [<CompiledName "LAST_USED_ASC">] LastUsedAsc
    /// Sort by ID in descending order.
    | [<CompiledName "ID_DESC">] IdDesc
    /// Sort by ID in ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// Sort by name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Sort by name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc

/// State of an access token.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AccessTokenState =
    /// Token is active.
    | [<CompiledName "ACTIVE">] Active
    /// Token is inactive.
    | [<CompiledName "INACTIVE">] Inactive

/// Agent token statuses
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AgentTokenStatus =
    /// Active agent token.
    | [<CompiledName "ACTIVE">] Active
    /// Revoked agent token.
    | [<CompiledName "REVOKED">] Revoked

/// LLMs supported by the self-hosted model features.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiAcceptedSelfHostedModels =
    /// CodeGemma Code: Suitable for code suggestions.
    | [<CompiledName "CODEGEMMA">] Codegemma
    /// Code-Llama Instruct: Suitable for code suggestions.
    | [<CompiledName "CODELLAMA">] Codellama
    /// Codestral: Suitable for code suggestions.
    | [<CompiledName "CODESTRAL">] Codestral
    /// Mistral: Suitable for code suggestions and duo chat.
    | [<CompiledName "MISTRAL">] Mistral
    /// Mixtral: Suitable for code suggestions and duo chat.
    | [<CompiledName "MIXTRAL">] Mixtral
    /// Deepseek Coder base or instruct.
    | [<CompiledName "DEEPSEEKCODER">] Deepseekcoder
    /// LLaMA 3: Suitable for code suggestions and duo chat.
    | [<CompiledName "LLAMA3">] Llama3
    /// Claude 3 model family, suitable for code generation and duo chat.
    | [<CompiledName "CLAUDE_3">] Claude3
    /// GPT: Suitable for code suggestions.
    | [<CompiledName "GPT">] Gpt
    /// General: Any model suitable for code suggestions and duo chat.
    | [<CompiledName "GENERAL">] General

/// Action to subscribe to.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiAction =
    /// Chat action.
    | [<CompiledName "CHAT">] Chat

/// The category of the additional context
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiAdditionalContextCategory =
    /// File content category.
    | [<CompiledName "FILE">] File
    /// Snippet content category.
    | [<CompiledName "SNIPPET">] Snippet
    /// Merge_request content category.
    | [<CompiledName "MERGE_REQUEST">] MergeRequest
    /// Issue content category.
    | [<CompiledName "ISSUE">] Issue
    /// Dependency content category.
    | [<CompiledName "DEPENDENCY">] Dependency
    /// Local_git content category.
    | [<CompiledName "LOCAL_GIT">] LocalGit
    /// Terminal content category.
    | [<CompiledName "TERMINAL">] Terminal
    /// User_rule content category.
    | [<CompiledName "USER_RULE">] UserRule
    /// Repository content category.
    | [<CompiledName "REPOSITORY">] Repository
    /// Directory content category.
    | [<CompiledName "DIRECTORY">] Directory
    /// Agent_user_environment content category.
    | [<CompiledName "AGENT_USER_ENVIRONMENT">] AgentUserEnvironment

/// Possible flow configuration types for AI Catalog agents.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiCatalogFlowConfigType =
    /// Chat flow configuration.
    | [<CompiledName "CHAT">] Chat

/// Possible reasons for reporting an AI catalog item.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiCatalogItemReportReason =
    /// Contains dangerous code, exploits, or harmful actions.
    | [<CompiledName "IMMEDIATE_SECURITY_THREAT">] ImmediateSecurityThreat
    /// Hypothetical or low risk security flaws that could be exploited.
    | [<CompiledName "POTENTIAL_SECURITY_THREAT">] PotentialSecurityThreat
    /// Wasting compute or causing performance issues.
    | [<CompiledName "EXCESSIVE_RESOURCE_USAGE">] ExcessiveResourceUsage
    /// Frequently failing or nuisance activity.
    | [<CompiledName "SPAM_OR_LOW_QUALITY">] SpamOrLowQuality
    /// Please describe below.
    | [<CompiledName "OTHER">] Other

/// Possible item types for AI items.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiCatalogItemType =
    /// Agent.
    | [<CompiledName "AGENT">] Agent
    /// Flow.
    | [<CompiledName "FLOW">] Flow
    /// Third party flow.
    | [<CompiledName "THIRD_PARTY_FLOW">] ThirdPartyFlow

/// Possible version bumps for AI catalog items.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiCatalogVersionBump =
    /// Major version bump.
    | [<CompiledName "MAJOR">] Major
    /// Minor version bump.
    | [<CompiledName "MINOR">] Minor
    /// Patch version bump.
    | [<CompiledName "PATCH">] Patch

/// Conversation type of the thread.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiConversationsThreadsConversationType =
    /// duo_chat_legacy thread.
    | [<CompiledName "DUO_CHAT_LEGACY">] DuoChatLegacy
    /// duo_code_review thread.
    | [<CompiledName "DUO_CODE_REVIEW">] DuoCodeReview
    /// duo_quick_chat thread.
    | [<CompiledName "DUO_QUICK_CHAT">] DuoQuickChat
    /// duo_chat thread.
    | [<CompiledName "DUO_CHAT">] DuoChat

/// Providers for AI features that can be configured.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiFeatureProviders =
    /// Disabled option
    | [<CompiledName "DISABLED">] Disabled
    /// Vendored option
    | [<CompiledName "VENDORED">] Vendored
    /// Self hosted option
    | [<CompiledName "SELF_HOSTED">] SelfHosted
    /// Unassigned option
    | [<CompiledName "UNASSIGNED">] Unassigned

/// AI features that can be configured through the Duo self-hosted feature settings.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiFeatures =
    /// Code generation feature setting
    | [<CompiledName "CODE_GENERATIONS">] CodeGenerations
    /// Code completion feature setting
    | [<CompiledName "CODE_COMPLETIONS">] CodeCompletions
    /// Duo Chat feature setting
    | [<CompiledName "DUO_CHAT">] DuoChat
    /// Duo chat explain code feature setting
    | [<CompiledName "DUO_CHAT_EXPLAIN_CODE">] DuoChatExplainCode
    /// Duo chat write test feature setting
    | [<CompiledName "DUO_CHAT_WRITE_TESTS">] DuoChatWriteTests
    /// Duo chat refactor code feature setting
    | [<CompiledName "DUO_CHAT_REFACTOR_CODE">] DuoChatRefactorCode
    /// Duo chat fix code feature setting
    | [<CompiledName "DUO_CHAT_FIX_CODE">] DuoChatFixCode
    /// Review merge request feature setting
    | [<CompiledName "REVIEW_MERGE_REQUEST">] ReviewMergeRequest
    /// Duo agent platform feature setting
    | [<CompiledName "DUO_AGENT_PLATFORM">] DuoAgentPlatform
    /// Duo chat troubleshoot job feature setting
    | [<CompiledName "DUO_CHAT_TROUBLESHOOT_JOB">] DuoChatTroubleshootJob
    /// Generate commit message feature setting
    | [<CompiledName "GENERATE_COMMIT_MESSAGE">] GenerateCommitMessage
    /// Summarize new merge request feature setting
    | [<CompiledName "SUMMARIZE_NEW_MERGE_REQUEST">] SummarizeNewMergeRequest
    /// Duo chat explain vulnerability feature setting
    | [<CompiledName "DUO_CHAT_EXPLAIN_VULNERABILITY">] DuoChatExplainVulnerability
    /// Resolve vulnerability feature setting
    | [<CompiledName "RESOLVE_VULNERABILITY">] ResolveVulnerability
    /// Summarize review feature setting
    | [<CompiledName "SUMMARIZE_REVIEW">] SummarizeReview
    /// Glab ask git command feature setting
    | [<CompiledName "GLAB_ASK_GIT_COMMAND">] GlabAskGitCommand
    /// Duo chat summarize comment feature setting
    | [<CompiledName "DUO_CHAT_SUMMARIZE_COMMENTS">] DuoChatSummarizeComments

/// Possible message roles for AI features.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiMessageRole =
    /// user message.
    | [<CompiledName "USER">] User
    /// assistant message.
    | [<CompiledName "ASSISTANT">] Assistant
    /// system message.
    | [<CompiledName "SYSTEM">] System

/// Types of messages returned from AI features.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiMessageType =
    /// Tool selection message.
    | [<CompiledName "TOOL">] Tool

/// AI features that can be configured through the Model Selection feature settings.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiModelSelectionFeatures =
    /// Code generation feature setting
    | [<CompiledName "CODE_GENERATIONS">] CodeGenerations
    /// Code completion feature setting
    | [<CompiledName "CODE_COMPLETIONS">] CodeCompletions
    /// Duo Chat feature setting
    | [<CompiledName "DUO_CHAT">] DuoChat
    /// Duo chat explain code feature setting
    | [<CompiledName "DUO_CHAT_EXPLAIN_CODE">] DuoChatExplainCode
    /// Duo chat write test feature setting
    | [<CompiledName "DUO_CHAT_WRITE_TESTS">] DuoChatWriteTests
    /// Duo chat refactor code feature setting
    | [<CompiledName "DUO_CHAT_REFACTOR_CODE">] DuoChatRefactorCode
    /// Duo chat fix code feature setting
    | [<CompiledName "DUO_CHAT_FIX_CODE">] DuoChatFixCode
    /// Duo chat troubleshoot job feature setting
    | [<CompiledName "DUO_CHAT_TROUBLESHOOT_JOB">] DuoChatTroubleshootJob
    /// Generate commit message feature setting
    | [<CompiledName "GENERATE_COMMIT_MESSAGE">] GenerateCommitMessage
    /// Summarize new merge request feature setting
    | [<CompiledName "SUMMARIZE_NEW_MERGE_REQUEST">] SummarizeNewMergeRequest
    /// Duo chat explain vulnerability feature setting
    | [<CompiledName "DUO_CHAT_EXPLAIN_VULNERABILITY">] DuoChatExplainVulnerability
    /// Resolve vulnerability feature setting
    | [<CompiledName "RESOLVE_VULNERABILITY">] ResolveVulnerability
    /// Summarize review feature setting
    | [<CompiledName "SUMMARIZE_REVIEW">] SummarizeReview
    /// Duo chat summarize comment feature setting
    | [<CompiledName "DUO_CHAT_SUMMARIZE_COMMENTS">] DuoChatSummarizeComments
    /// Review merge request feature setting
    | [<CompiledName "REVIEW_MERGE_REQUEST">] ReviewMergeRequest
    /// Duo agent platform feature setting
    | [<CompiledName "DUO_AGENT_PLATFORM">] DuoAgentPlatform

/// GitLab release state of the model
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiSelfHostedModelReleaseState =
    /// Experimental status.
    | [<CompiledName "EXPERIMENTAL">] Experimental
    /// Beta status.
    | [<CompiledName "BETA">] Beta
    /// GA status.
    | [<CompiledName "GA">] Ga

/// Type of AI usage event
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AiUsageEventType =
    /// Code Suggestion was requested. Old data only.
    | [<CompiledName "CODE_SUGGESTIONS_REQUESTED">] CodeSuggestionsRequested
    /// Code Suggestion was shown in IDE.
    | [<CompiledName "CODE_SUGGESTION_SHOWN_IN_IDE">] CodeSuggestionShownInIde
    /// Code Suggestion was accepted in IDE.
    | [<CompiledName "CODE_SUGGESTION_ACCEPTED_IN_IDE">] CodeSuggestionAcceptedInIde
    /// Code Suggestion was rejected in IDE.
    | [<CompiledName "CODE_SUGGESTION_REJECTED_IN_IDE">] CodeSuggestionRejectedInIde
    /// Code Suggestion token was refreshed. Old data only.
    | [<CompiledName "CODE_SUGGESTION_DIRECT_ACCESS_TOKEN_REFRESH">] CodeSuggestionDirectAccessTokenRefresh
    /// Duo Chat response was requested.
    | [<CompiledName "REQUEST_DUO_CHAT_RESPONSE">] RequestDuoChatResponse
    /// Troubleshoot job feature was used.
    | [<CompiledName "TROUBLESHOOT_JOB">] TroubleshootJob
    /// Agent platform session was created.
    | [<CompiledName "AGENT_PLATFORM_SESSION_CREATED">] AgentPlatformSessionCreated
    /// Agent platform session was started.
    | [<CompiledName "AGENT_PLATFORM_SESSION_STARTED">] AgentPlatformSessionStarted
    /// Agent platform session was finished.
    | [<CompiledName "AGENT_PLATFORM_SESSION_FINISHED">] AgentPlatformSessionFinished
    /// Agent platform session was dropped.
    | [<CompiledName "AGENT_PLATFORM_SESSION_DROPPED">] AgentPlatformSessionDropped
    /// Agent platform session was stopped.
    | [<CompiledName "AGENT_PLATFORM_SESSION_STOPPED">] AgentPlatformSessionStopped
    /// Agent platform session was resumed.
    | [<CompiledName "AGENT_PLATFORM_SESSION_RESUMED">] AgentPlatformSessionResumed
    /// Duo Code Review encountered an error.
    | [<CompiledName "ENCOUNTER_DUO_CODE_REVIEW_ERROR_DURING_REVIEW">] EncounterDuoCodeReviewErrorDuringReview
    /// Duo Code Review found no issues after review.
    | [<CompiledName "FIND_NO_ISSUES_DUO_CODE_REVIEW_AFTER_REVIEW">] FindNoIssuesDuoCodeReviewAfterReview
    /// Duo Code Review found nothing to review on MR.
    | [<CompiledName "FIND_NOTHING_TO_REVIEW_DUO_CODE_REVIEW_ON_MR">] FindNothingToReviewDuoCodeReviewOnMr
    /// Duo Code Review posted a diff comment.
    | [<CompiledName "POST_COMMENT_DUO_CODE_REVIEW_ON_DIFF">] PostCommentDuoCodeReviewOnDiff
    /// User gave thumbs-up reaction to Duo Code Review comment.
    | [<CompiledName "REACT_THUMBS_UP_ON_DUO_CODE_REVIEW_COMMENT">] ReactThumbsUpOnDuoCodeReviewComment
    /// User gave thumbs-down reaction to Duo Code Review comment.
    | [<CompiledName "REACT_THUMBS_DOWN_ON_DUO_CODE_REVIEW_COMMENT">] ReactThumbsDownOnDuoCodeReviewComment
    /// MR author requested Duo Code Review.
    | [<CompiledName "REQUEST_REVIEW_DUO_CODE_REVIEW_ON_MR_BY_AUTHOR">] RequestReviewDuoCodeReviewOnMrByAuthor
    /// Non-author requested Duo Code Review on MR.
    | [<CompiledName "REQUEST_REVIEW_DUO_CODE_REVIEW_ON_MR_BY_NON_AUTHOR">] RequestReviewDuoCodeReviewOnMrByNonAuthor
    /// Files were excluded from Duo Code Review.
    | [<CompiledName "EXCLUDED_FILES_FROM_DUO_CODE_REVIEW">] ExcludedFilesFromDuoCodeReview
    /// MCP tool call was started.
    | [<CompiledName "START_MCP_TOOL_CALL">] StartMcpToolCall
    /// MCP tool call was finished.
    | [<CompiledName "FINISH_MCP_TOOL_CALL">] FinishMcpToolCall

/// Values for sorting alerts
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementAlertSort =
    /// Start time by ascending order.
    | [<CompiledName "STARTED_AT_ASC">] StartedAtAsc
    /// Start time by descending order.
    | [<CompiledName "STARTED_AT_DESC">] StartedAtDesc
    /// End time by ascending order.
    | [<CompiledName "ENDED_AT_ASC">] EndedAtAsc
    /// End time by descending order.
    | [<CompiledName "ENDED_AT_DESC">] EndedAtDesc
    /// Created time by ascending order.
    | [<CompiledName "CREATED_TIME_ASC">] CreatedTimeAsc
    /// Created time by descending order.
    | [<CompiledName "CREATED_TIME_DESC">] CreatedTimeDesc
    /// Created time by ascending order.
    | [<CompiledName "UPDATED_TIME_ASC">] UpdatedTimeAsc
    /// Created time by descending order.
    | [<CompiledName "UPDATED_TIME_DESC">] UpdatedTimeDesc
    /// Events count by ascending order.
    | [<CompiledName "EVENT_COUNT_ASC">] EventCountAsc
    /// Events count by descending order.
    | [<CompiledName "EVENT_COUNT_DESC">] EventCountDesc
    /// Severity from less critical to more critical.
    | [<CompiledName "SEVERITY_ASC">] SeverityAsc
    /// Severity from more critical to less critical.
    | [<CompiledName "SEVERITY_DESC">] SeverityDesc
    /// Status by order: `Ignored > Resolved > Acknowledged > Triggered`.
    | [<CompiledName "STATUS_ASC">] StatusAsc
    /// Status by order: `Triggered > Acknowledged > Resolved > Ignored`.
    | [<CompiledName "STATUS_DESC">] StatusDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Filters the alerts based on given domain
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementDomainFilter =
    /// Alerts for operations domain.
    | [<CompiledName "operations">] Operations

/// Values of types of integrations
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementIntegrationType =
    /// Prometheus integration.
    | [<CompiledName "PROMETHEUS">] Prometheus
    /// Integration with any monitoring tool.
    | [<CompiledName "HTTP">] Http

/// Values for alert field names used in the custom mapping
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementPayloadAlertFieldName =
    /// The title of the incident.
    | [<CompiledName "TITLE">] Title
    /// A high-level summary of the problem.
    | [<CompiledName "DESCRIPTION">] Description
    /// The time of the incident.
    | [<CompiledName "START_TIME">] StartTime
    /// The resolved time of the incident.
    | [<CompiledName "END_TIME">] EndTime
    /// The affected service.
    | [<CompiledName "SERVICE">] Service
    /// The name of the associated monitoring tool.
    | [<CompiledName "MONITORING_TOOL">] MonitoringTool
    /// One or more hosts, as to where this incident occurred.
    | [<CompiledName "HOSTS">] Hosts
    /// The severity of the alert.
    | [<CompiledName "SEVERITY">] Severity
    /// The unique identifier of the alert. This can be used to group occurrences of the same alert.
    | [<CompiledName "FINGERPRINT">] Fingerprint
    /// The name of the associated GitLab environment.
    | [<CompiledName "GITLAB_ENVIRONMENT_NAME">] GitlabEnvironmentName

/// Values for alert field types used in the custom mapping
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementPayloadAlertFieldType =
    /// Array field type.
    | [<CompiledName "ARRAY">] Array
    /// DateTime field type.
    | [<CompiledName "DATETIME">] Datetime
    /// String field type.
    | [<CompiledName "STRING">] String
    /// Number field type.
    | [<CompiledName "NUMBER">] Number

/// Alert severity values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementSeverity =
    /// Critical severity
    | [<CompiledName "CRITICAL">] Critical
    /// High severity
    | [<CompiledName "HIGH">] High
    /// Medium severity
    | [<CompiledName "MEDIUM">] Medium
    /// Low severity
    | [<CompiledName "LOW">] Low
    /// Info severity
    | [<CompiledName "INFO">] Info
    /// Unknown severity
    | [<CompiledName "UNKNOWN">] Unknown

/// Alert status values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AlertManagementStatus =
    /// Investigation has not started.
    | [<CompiledName "TRIGGERED">] Triggered
    /// Someone is actively investigating the problem.
    | [<CompiledName "ACKNOWLEDGED">] Acknowledged
    /// The problem has been addressed.
    | [<CompiledName "RESOLVED">] Resolved
    /// No action will be taken.
    | [<CompiledName "IGNORED">] Ignored

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AnalyticsAggregationPeriod =
    /// Daily aggregation.
    | [<CompiledName "DAY">] Day
    /// Weekly aggregation.
    | [<CompiledName "WEEK">] Week
    /// Monthly aggregation.
    | [<CompiledName "MONTH">] Month

/// Enum for types of analyzers
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AnalyzerStatusEnum =
    /// Last analyzer execution finished successfully.
    | [<CompiledName "SUCCESS">] Success
    /// Last analyzer execution failed.
    | [<CompiledName "FAILED">] Failed
    /// Analyzer is not configured.
    | [<CompiledName "NOT_CONFIGURED">] NotConfigured

/// Enum for types of analyzers
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AnalyzerTypeEnum =
    /// Sast analyzer.
    | [<CompiledName "SAST">] Sast
    /// Sast advanced analyzer.
    | [<CompiledName "SAST_ADVANCED">] SastAdvanced
    /// Sast iac analyzer.
    | [<CompiledName "SAST_IAC">] SastIac
    /// Dast analyzer.
    | [<CompiledName "DAST">] Dast
    /// Dependency scanning analyzer.
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// Coverage fuzzing analyzer.
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// Api fuzzing analyzer.
    | [<CompiledName "API_FUZZING">] ApiFuzzing
    /// Cluster image scanning analyzer.
    | [<CompiledName "CLUSTER_IMAGE_SCANNING">] ClusterImageScanning
    /// Secret detection analyzer.
    | [<CompiledName "SECRET_DETECTION_PIPELINE_BASED">] SecretDetectionPipelineBased
    /// Container scanning analyzer.
    | [<CompiledName "CONTAINER_SCANNING_PIPELINE_BASED">] ContainerScanningPipelineBased
    /// Secret push protection. Managed via project security settings.
    | [<CompiledName "SECRET_DETECTION_SECRET_PUSH_PROTECTION">] SecretDetectionSecretPushProtection
    /// Container scanning for registry. Managed via project security settings.
    | [<CompiledName "CONTAINER_SCANNING_FOR_REGISTRY">] ContainerScanningForRegistry
    /// Any kind of container scanning.
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// Any kind of secret detection.
    | [<CompiledName "SECRET_DETECTION">] SecretDetection

/// All possible ways to specify the API surface for an API fuzzing scan.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ApiFuzzingScanMode =
    /// The API surface is specified by a HAR file.
    | [<CompiledName "HAR">] Har
    /// The API surface is specified by a OPENAPI file.
    | [<CompiledName "OPENAPI">] Openapi
    /// The API surface is specified by a POSTMAN file.
    | [<CompiledName "POSTMAN">] Postman

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ApprovalReportType =
    /// Represents report_type for vulnerability check related approval rules.
    | [<CompiledName "SCAN_FINDING">] ScanFinding
    /// Represents report_type for license scanning related approval rules.
    | [<CompiledName "LICENSE_SCANNING">] LicenseScanning
    /// Represents report_type for any_merge_request related approval rules.
    | [<CompiledName "ANY_MERGE_REQUEST">] AnyMergeRequest

/// The kind of an approval rule.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ApprovalRuleType =
    /// A `regular` approval rule.
    | [<CompiledName "REGULAR">] Regular
    /// A `code_owner` approval rule.
    | [<CompiledName "CODE_OWNER">] CodeOwner
    /// A `report_approver` approval rule.
    | [<CompiledName "REPORT_APPROVER">] ReportApprover
    /// A `any_approver` approval rule.
    | [<CompiledName "ANY_APPROVER">] AnyApprover

/// Assignee ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AssigneeWildcardId =
    /// No assignee is assigned.
    | [<CompiledName "NONE">] None
    /// An assignee is assigned.
    | [<CompiledName "ANY">] Any

/// Operators for filtering by security attributes
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AttributeFilterOperator =
    /// Project has one or more of the specified attributes.
    | [<CompiledName "IS_ONE_OF">] IsOneOf
    /// Project does not have any of the specified attributes.
    | [<CompiledName "IS_NOT_ONE_OF">] IsNotOneOf

/// Auto stop setting.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AutoStopSetting =
    /// Always
    | [<CompiledName "ALWAYS">] Always
    /// With Action
    | [<CompiledName "WITH_ACTION">] WithAction

/// User availability status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AvailabilityEnum =
    /// Not Set
    | [<CompiledName "NOT_SET">] NotSet
    /// Busy
    | [<CompiledName "BUSY">] Busy

/// Available fields to be exported as CSV
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type AvailableExportFields =
    /// Assignee(s) name of the work item.
    | [<CompiledName "ASSIGNEE">] Assignee
    /// Assignee(s) username of the work item.
    | [<CompiledName "ASSIGNEE_USERNAME">] AssigneeUsername
    /// Author name of the work item.
    | [<CompiledName "AUTHOR">] Author
    /// Author username of the work item.
    | [<CompiledName "AUTHOR_USERNAME">] AuthorUsername
    /// Confidentiality flag of the work item.
    | [<CompiledName "CONFIDENTIAL">] Confidential
    /// Description of the work item.
    | [<CompiledName "DESCRIPTION">] Description
    /// Unique identifier of the work item.
    | [<CompiledName "ID">] Id
    /// IID identifier of the work item.
    | [<CompiledName "IID">] Iid
    /// Locked discussions flag of the work item.
    | [<CompiledName "LOCKED">] Locked
    /// Start date (UTC) of the work item.
    | [<CompiledName "START_DATE">] StartDate
    /// Due date (UTC) of the work item.
    | [<CompiledName "DUE_DATE">] DueDate
    /// Closed at (UTC) date of the work item.
    | [<CompiledName "CLOSED_AT">] ClosedAt
    /// Crated at (UTC) date of the work item.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Updated at (UTC) date of the work item.
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Milestone of the work item.
    | [<CompiledName "MILESTONE">] Milestone
    /// Parent ID of the work item.
    | [<CompiledName "PARENT_ID">] ParentId
    /// Parent IID of the work item.
    | [<CompiledName "PARENT_IID">] ParentIid
    /// Parent title of the work item.
    | [<CompiledName "PARENT_TITLE">] ParentTitle
    /// State of the work item.
    | [<CompiledName "STATE">] State
    /// Title of the work item.
    | [<CompiledName "TITLE">] Title
    /// Time estimate of the work item.
    | [<CompiledName "TIME_ESTIMATE">] TimeEstimate
    /// Time spent of the work item.
    | [<CompiledName "TIME_SPENT">] TimeSpent
    /// Type of the work item.
    | [<CompiledName "TYPE">] Type
    /// Web URL to the work item.
    | [<CompiledName "URL">] Url
    /// Weight of the work item.
    | [<CompiledName "WEIGHT">] Weight

/// Types of blob viewers
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type BlobViewersType =
    /// Rich blob viewers type.
    | [<CompiledName "rich">] Rich
    /// Simple blob viewers type.
    | [<CompiledName "simple">] Simple
    /// Auxiliary blob viewers type.
    | [<CompiledName "auxiliary">] Auxiliary

/// Status of a merge train's car
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CarStatus =
    /// Car's status: idle
    | [<CompiledName "IDLE">] Idle
    /// Car's status: stale
    | [<CompiledName "STALE">] Stale
    /// Car's status: fresh
    | [<CompiledName "FRESH">] Fresh
    /// Car's status: merging
    | [<CompiledName "MERGING">] Merging
    /// Car's status: merged
    | [<CompiledName "MERGED">] Merged
    /// Car's status: skip_merged
    | [<CompiledName "SKIP_MERGED">] SkipMerged

/// Values for scoping catalog resources
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiCatalogResourceScope =
    /// All catalog resources visible to the current user.
    | [<CompiledName "ALL">] All
    /// Catalog resources belonging to authorized namespaces of the user.
    | [<CompiledName "NAMESPACES">] Namespaces

/// Values for sorting catalog resources
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiCatalogResourceSort =
    /// Name by ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Name by descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Latest release date by ascending order.
    | [<CompiledName "LATEST_RELEASED_AT_ASC">] LatestReleasedAtAsc
    /// Latest release date by descending order.
    | [<CompiledName "LATEST_RELEASED_AT_DESC">] LatestReleasedAtDesc
    /// Created date by ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Created date by descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Star count by ascending order.
    | [<CompiledName "STAR_COUNT_ASC">] StarCountAsc
    /// Star count by descending order.
    | [<CompiledName "STAR_COUNT_DESC">] StarCountDesc
    /// Last 30-day usage count by ascending order.
    | [<CompiledName "USAGE_COUNT_ASC">] UsageCountAsc
    /// Last 30-day usage count by descending order.
    | [<CompiledName "USAGE_COUNT_DESC">] UsageCountDesc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiCatalogResourceVerificationLevel =
    /// The resource is Gitlab Maintained
    | [<CompiledName "GITLAB_MAINTAINED">] GitlabMaintained
    /// The resource is Gitlab Partner Maintained
    | [<CompiledName "GITLAB_PARTNER_MAINTAINED">] GitlabPartnerMaintained
    /// The resource is Verified Creator Maintained
    | [<CompiledName "VERIFIED_CREATOR_MAINTAINED">] VerifiedCreatorMaintained
    /// The resource is Verified Creator Self Managed
    | [<CompiledName "VERIFIED_CREATOR_SELF_MANAGED">] VerifiedCreatorSelfManaged
    /// The resource is Unverified
    | [<CompiledName "UNVERIFIED">] Unverified

/// Include type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiConfigIncludeType =
    /// Remote include.
    | [<CompiledName "remote">] Remote
    /// Local include.
    | [<CompiledName "local">] Local
    /// Project file include.
    | [<CompiledName "file">] File
    /// Template include.
    | [<CompiledName "template">] Template
    /// Component include.
    | [<CompiledName "component">] Component

/// Values for YAML processor result
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiConfigStatus =
    /// Configuration file is valid.
    | [<CompiledName "VALID">] Valid
    /// Configuration file is not valid.
    | [<CompiledName "INVALID">] Invalid

/// Deploy freeze period status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiFreezePeriodStatus =
    /// Freeze period is active.
    | [<CompiledName "ACTIVE">] Active
    /// Freeze period is inactive.
    | [<CompiledName "INACTIVE">] Inactive

/// Values for sorting inherited variables
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiGroupVariablesSort =
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Key by descending order.
    | [<CompiledName "KEY_DESC">] KeyDesc
    /// Key by ascending order.
    | [<CompiledName "KEY_ASC">] KeyAsc

/// Available input types
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiInputsType =
    /// Array input
    | [<CompiledName "ARRAY">] Array
    /// Boolean input
    | [<CompiledName "BOOLEAN">] Boolean
    /// Number input
    | [<CompiledName "NUMBER">] Number
    /// String input
    | [<CompiledName "STRING">] String

/// Aggregation functions available for CI/CD job analytics
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobAnalyticsAggregation =
    /// Average duration of jobs in seconds.
    | [<CompiledName "MEAN_DURATION_IN_SECONDS">] MeanDurationInSeconds
    /// 95th percentile duration of jobs in seconds.
    | [<CompiledName "P95_DURATION_IN_SECONDS">] P95DurationInSeconds
    /// Percentage of successful jobs.
    | [<CompiledName "RATE_OF_SUCCESS">] RateOfSuccess
    /// Percentage of failed jobs.
    | [<CompiledName "RATE_OF_FAILED">] RateOfFailed
    /// Percentage of canceled jobs.
    | [<CompiledName "RATE_OF_CANCELED">] RateOfCanceled

/// Fields available for selection in CI/CD job analytics
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobAnalyticsField =
    /// Job name.
    | [<CompiledName "NAME">] Name
    /// Stage.
    | [<CompiledName "STAGE">] Stage

/// Values for sorting CI/CD job analytics
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobAnalyticsSort =
    /// Sort by name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Sort by name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Sort by mean duration in ascending order.
    | [<CompiledName "MEAN_DURATION_ASC">] MeanDurationAsc
    /// Sort by mean duration in descending order.
    | [<CompiledName "MEAN_DURATION_DESC">] MeanDurationDesc
    /// Sort by 95th percentile duration in ascending order.
    | [<CompiledName "P95_DURATION_ASC">] P95DurationAsc
    /// Sort by 95th percentile duration in descending order.
    | [<CompiledName "P95_DURATION_DESC">] P95DurationDesc
    /// Sort by success rate in ascending order.
    | [<CompiledName "SUCCESS_RATE_ASC">] SuccessRateAsc
    /// Sort by success rate in descending order.
    | [<CompiledName "SUCCESS_RATE_DESC">] SuccessRateDesc
    /// Sort by failed rate in ascending order.
    | [<CompiledName "FAILED_RATE_ASC">] FailedRateAsc
    /// Sort by failed rate in descending order.
    | [<CompiledName "FAILED_RATE_DESC">] FailedRateDesc
    /// Sort by canceled rate in ascending order.
    | [<CompiledName "CANCELED_RATE_ASC">] CanceledRateAsc
    /// Sort by canceled rate in descending order.
    | [<CompiledName "CANCELED_RATE_DESC">] CanceledRateDesc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobFailureReason =
    /// A job that failed due to unknown failure.
    | [<CompiledName "UNKNOWN_FAILURE">] UnknownFailure
    /// A job that failed due to script failure.
    | [<CompiledName "SCRIPT_FAILURE">] ScriptFailure
    /// A job that failed due to api failure.
    | [<CompiledName "API_FAILURE">] ApiFailure
    /// A job that failed due to stuck or timeout failure.
    | [<CompiledName "STUCK_OR_TIMEOUT_FAILURE">] StuckOrTimeoutFailure
    /// A job that failed due to runner system failure.
    | [<CompiledName "RUNNER_SYSTEM_FAILURE">] RunnerSystemFailure
    /// A job that failed due to missing dependency failure.
    | [<CompiledName "MISSING_DEPENDENCY_FAILURE">] MissingDependencyFailure
    /// A job that failed due to runner unsupported.
    | [<CompiledName "RUNNER_UNSUPPORTED">] RunnerUnsupported
    /// A job that failed due to stale schedule.
    | [<CompiledName "STALE_SCHEDULE">] StaleSchedule
    /// A job that failed due to job execution timeout.
    | [<CompiledName "JOB_EXECUTION_TIMEOUT">] JobExecutionTimeout
    /// A job that failed due to archived failure.
    | [<CompiledName "ARCHIVED_FAILURE">] ArchivedFailure
    /// A job that failed due to unmet prerequisites.
    | [<CompiledName "UNMET_PREREQUISITES">] UnmetPrerequisites
    /// A job that failed due to scheduler failure.
    | [<CompiledName "SCHEDULER_FAILURE">] SchedulerFailure
    /// A job that failed due to data integrity failure.
    | [<CompiledName "DATA_INTEGRITY_FAILURE">] DataIntegrityFailure
    /// A job that failed due to forward deployment failure.
    | [<CompiledName "FORWARD_DEPLOYMENT_FAILURE">] ForwardDeploymentFailure
    /// A job that failed due to user blocked.
    | [<CompiledName "USER_BLOCKED">] UserBlocked
    /// A job that failed due to project deleted.
    | [<CompiledName "PROJECT_DELETED">] ProjectDeleted
    /// A job that failed due to ci quota exceeded.
    | [<CompiledName "CI_QUOTA_EXCEEDED">] CiQuotaExceeded
    /// A job that failed due to pipeline loop detected.
    | [<CompiledName "PIPELINE_LOOP_DETECTED">] PipelineLoopDetected
    /// A job that failed due to no matching runner.
    | [<CompiledName "NO_MATCHING_RUNNER">] NoMatchingRunner
    /// A job that failed due to trace size exceeded.
    | [<CompiledName "TRACE_SIZE_EXCEEDED">] TraceSizeExceeded
    /// A job that failed due to builds disabled.
    | [<CompiledName "BUILDS_DISABLED">] BuildsDisabled
    /// A job that failed due to environment creation failure.
    | [<CompiledName "ENVIRONMENT_CREATION_FAILURE">] EnvironmentCreationFailure
    /// A job that failed due to deployment rejected.
    | [<CompiledName "DEPLOYMENT_REJECTED">] DeploymentRejected
    /// A job that failed due to failed outdated deployment job.
    | [<CompiledName "FAILED_OUTDATED_DEPLOYMENT_JOB">] FailedOutdatedDeploymentJob
    /// A job that failed due to runner provisioning timeout.
    | [<CompiledName "RUNNER_PROVISIONING_TIMEOUT">] RunnerProvisioningTimeout
    /// A job that failed due to protected environment failure.
    | [<CompiledName "PROTECTED_ENVIRONMENT_FAILURE">] ProtectedEnvironmentFailure
    /// A job that failed due to insufficient bridge permissions.
    | [<CompiledName "INSUFFICIENT_BRIDGE_PERMISSIONS">] InsufficientBridgePermissions
    /// A job that failed due to downstream bridge project not found.
    | [<CompiledName "DOWNSTREAM_BRIDGE_PROJECT_NOT_FOUND">] DownstreamBridgeProjectNotFound
    /// A job that failed due to invalid bridge trigger.
    | [<CompiledName "INVALID_BRIDGE_TRIGGER">] InvalidBridgeTrigger
    /// A job that failed due to upstream bridge project not found.
    | [<CompiledName "UPSTREAM_BRIDGE_PROJECT_NOT_FOUND">] UpstreamBridgeProjectNotFound
    /// A job that failed due to insufficient upstream permissions.
    | [<CompiledName "INSUFFICIENT_UPSTREAM_PERMISSIONS">] InsufficientUpstreamPermissions
    /// A job that failed due to bridge pipeline is child pipeline.
    | [<CompiledName "BRIDGE_PIPELINE_IS_CHILD_PIPELINE">] BridgePipelineIsChildPipeline
    /// A job that failed due to downstream pipeline creation failed.
    | [<CompiledName "DOWNSTREAM_PIPELINE_CREATION_FAILED">] DownstreamPipelineCreationFailed
    /// A job that failed due to secrets provider not found.
    | [<CompiledName "SECRETS_PROVIDER_NOT_FOUND">] SecretsProviderNotFound
    /// A job that failed due to reached max descendant pipelines depth.
    | [<CompiledName "REACHED_MAX_DESCENDANT_PIPELINES_DEPTH">] ReachedMaxDescendantPipelinesDepth
    /// A job that failed due to ip restriction failure.
    | [<CompiledName "IP_RESTRICTION_FAILURE">] IpRestrictionFailure
    /// A job that failed due to reached max pipeline hierarchy size.
    | [<CompiledName "REACHED_MAX_PIPELINE_HIERARCHY_SIZE">] ReachedMaxPipelineHierarchySize
    /// A job that failed due to reached downstream pipeline trigger rate limit.
    | [<CompiledName "REACHED_DOWNSTREAM_PIPELINE_TRIGGER_RATE_LIMIT">] ReachedDownstreamPipelineTriggerRateLimit

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobKind =
    /// Standard CI job.
    | [<CompiledName "BUILD">] Build
    /// Bridge CI job connecting a parent and child pipeline.
    | [<CompiledName "BRIDGE">] Bridge

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobSource =
    /// A job initiated by scan execution policy.
    | [<CompiledName "SCAN_EXECUTION_POLICY">] ScanExecutionPolicy
    /// A job initiated by pipeline execution policy.
    | [<CompiledName "PIPELINE_EXECUTION_POLICY">] PipelineExecutionPolicy
    /// A job initiated by unknown.
    | [<CompiledName "UNKNOWN">] Unknown
    /// A job initiated by push.
    | [<CompiledName "PUSH">] Push
    /// A job initiated by web.
    | [<CompiledName "WEB">] Web
    /// A job initiated by trigger.
    | [<CompiledName "TRIGGER">] Trigger
    /// A job initiated by schedule.
    | [<CompiledName "SCHEDULE">] Schedule
    /// A job initiated by api.
    | [<CompiledName "API">] Api
    /// A job initiated by external.
    | [<CompiledName "EXTERNAL">] External
    /// A job initiated by pipeline.
    | [<CompiledName "PIPELINE">] Pipeline
    /// A job initiated by chat.
    | [<CompiledName "CHAT">] Chat
    /// A job initiated by webide.
    | [<CompiledName "WEBIDE">] Webide
    /// A job initiated by merge request event.
    | [<CompiledName "MERGE_REQUEST_EVENT">] MergeRequestEvent
    /// A job initiated by external pull request event.
    | [<CompiledName "EXTERNAL_PULL_REQUEST_EVENT">] ExternalPullRequestEvent
    /// A job initiated by parent pipeline.
    | [<CompiledName "PARENT_PIPELINE">] ParentPipeline
    /// A job initiated by ondemand dast scan.
    | [<CompiledName "ONDEMAND_DAST_SCAN">] OndemandDastScan
    /// A job initiated by ondemand dast validation.
    | [<CompiledName "ONDEMAND_DAST_VALIDATION">] OndemandDastValidation
    /// A job initiated by security orchestration policy.
    | [<CompiledName "SECURITY_ORCHESTRATION_POLICY">] SecurityOrchestrationPolicy
    /// A job initiated by container registry push.
    | [<CompiledName "CONTAINER_REGISTRY_PUSH">] ContainerRegistryPush
    /// A job initiated by duo workflow.
    | [<CompiledName "DUO_WORKFLOW">] DuoWorkflow
    /// A job initiated by pipeline execution policy schedule.
    | [<CompiledName "PIPELINE_EXECUTION_POLICY_SCHEDULE">] PipelineExecutionPolicySchedule

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobStatus =
    /// A job that is created.
    | [<CompiledName "CREATED">] Created
    /// A job that is waiting for resource.
    | [<CompiledName "WAITING_FOR_RESOURCE">] WaitingForResource
    /// A job that is preparing.
    | [<CompiledName "PREPARING">] Preparing
    /// A job that is waiting for callback.
    | [<CompiledName "WAITING_FOR_CALLBACK">] WaitingForCallback
    /// A job that is pending.
    | [<CompiledName "PENDING">] Pending
    /// A job that is running.
    | [<CompiledName "RUNNING">] Running
    /// A job that is success.
    | [<CompiledName "SUCCESS">] Success
    /// A job that is failed.
    | [<CompiledName "FAILED">] Failed
    /// A job that is canceling.
    | [<CompiledName "CANCELING">] Canceling
    /// A job that is canceled.
    | [<CompiledName "CANCELED">] Canceled
    /// A job that is skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// A job that is manual.
    | [<CompiledName "MANUAL">] Manual
    /// A job that is scheduled.
    | [<CompiledName "SCHEDULED">] Scheduled

/// Direction of access.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobTokenScopeDirection =
    /// Job token scope project can access target project in the outbound allowlist.
    | [<CompiledName "OUTBOUND">] Outbound
    /// Target projects in the inbound allowlist can access the scope project through their job tokens.
    | [<CompiledName "INBOUND">] Inbound

/// CI_JOB_TOKEN policy
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiJobTokenScopePolicies =
    /// Read Deployments
    | [<CompiledName "READ_DEPLOYMENTS">] ReadDeployments
    /// Admin Deployments
    | [<CompiledName "ADMIN_DEPLOYMENTS">] AdminDeployments
    /// Read Environments
    | [<CompiledName "READ_ENVIRONMENTS">] ReadEnvironments
    /// Admin Environments
    | [<CompiledName "ADMIN_ENVIRONMENTS">] AdminEnvironments
    /// Read Jobs
    | [<CompiledName "READ_JOBS">] ReadJobs
    /// Admin Jobs
    | [<CompiledName "ADMIN_JOBS">] AdminJobs
    /// Read Merge Requests
    | [<CompiledName "READ_MERGE_REQUESTS">] ReadMergeRequests
    /// Read Packages
    | [<CompiledName "READ_PACKAGES">] ReadPackages
    /// Admin Packages
    | [<CompiledName "ADMIN_PACKAGES">] AdminPackages
    /// Read Pipelines
    | [<CompiledName "READ_PIPELINES">] ReadPipelines
    /// Admin Pipelines
    | [<CompiledName "ADMIN_PIPELINES">] AdminPipelines
    /// Read Releases
    | [<CompiledName "READ_RELEASES">] ReadReleases
    /// Admin Releases
    | [<CompiledName "ADMIN_RELEASES">] AdminReleases
    /// Read Repositories
    | [<CompiledName "READ_REPOSITORIES">] ReadRepositories
    /// Read Secure Files
    | [<CompiledName "READ_SECURE_FILES">] ReadSecureFiles
    /// Admin Secure Files
    | [<CompiledName "ADMIN_SECURE_FILES">] AdminSecureFiles
    /// Read Terraform State
    | [<CompiledName "READ_TERRAFORM_STATE">] ReadTerraformState
    /// Admin Terraform State
    | [<CompiledName "ADMIN_TERRAFORM_STATE">] AdminTerraformState
    /// Read Work Items
    | [<CompiledName "READ_WORK_ITEMS">] ReadWorkItems

/// The status of a pipeline creation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiPipelineCreationStatus =
    /// The pipeline creation is failed
    | [<CompiledName "FAILED">] Failed
    /// The pipeline creation is in progress
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The pipeline creation is succeeded
    | [<CompiledName "SUCCEEDED">] Succeeded

/// Ci Pipeline sources enum
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiPipelineSources =
    /// Pipeline created by an unknown event
    | [<CompiledName "UNKNOWN">] Unknown
    /// Pipeline created by a push event
    | [<CompiledName "PUSH">] Push
    /// Pipeline created by a web event
    | [<CompiledName "WEB">] Web
    /// Pipeline created by a trigger event
    | [<CompiledName "TRIGGER">] Trigger
    /// Pipeline created by a schedule event
    | [<CompiledName "SCHEDULE">] Schedule
    /// Pipeline created by an API event
    | [<CompiledName "API">] Api
    /// Pipeline created by an external event
    | [<CompiledName "EXTERNAL">] External
    /// Pipeline created by a pipeline event
    | [<CompiledName "PIPELINE">] Pipeline
    /// Pipeline created by a chat event
    | [<CompiledName "CHAT">] Chat
    /// Pipeline created by a webide event
    | [<CompiledName "WEBIDE">] Webide
    /// Pipeline created by a merge request event
    | [<CompiledName "MERGE_REQUEST_EVENT">] MergeRequestEvent
    /// Pipeline created by an external pull request event
    | [<CompiledName "EXTERNAL_PULL_REQUEST_EVENT">] ExternalPullRequestEvent
    /// Pipeline created by a parent pipeline event
    | [<CompiledName "PARENT_PIPELINE">] ParentPipeline
    /// Pipeline created by an ondemand dast scan event
    | [<CompiledName "ONDEMAND_DAST_SCAN">] OndemandDastScan
    /// Pipeline created by an ondemand dast validation event
    | [<CompiledName "ONDEMAND_DAST_VALIDATION">] OndemandDastValidation
    /// Pipeline created by a security orchestration policy event
    | [<CompiledName "SECURITY_ORCHESTRATION_POLICY">] SecurityOrchestrationPolicy
    /// Pipeline created by a container registry push event
    | [<CompiledName "CONTAINER_REGISTRY_PUSH">] ContainerRegistryPush
    /// Pipeline created by a duo workflow event
    | [<CompiledName "DUO_WORKFLOW">] DuoWorkflow
    /// Pipeline created by a pipeline execution policy schedule event
    | [<CompiledName "PIPELINE_EXECUTION_POLICY_SCHEDULE">] PipelineExecutionPolicySchedule

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerAccessLevel =
    /// A runner that is not protected.
    | [<CompiledName "NOT_PROTECTED">] NotProtected
    /// A runner that is ref protected.
    | [<CompiledName "REF_PROTECTED">] RefProtected

/// Runner cloud provider.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerCloudProvider =
    /// Google Cloud.
    | [<CompiledName "GOOGLE_CLOUD">] GoogleCloud
    /// Google Kubernetes Engine.
    | [<CompiledName "GKE">] Gke

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerCreationMethod =
    /// Applies to a runner that was created by a runner registration token.
    | [<CompiledName "REGISTRATION_TOKEN">] RegistrationToken
    /// Applies to a runner that was created by an authenticated user.
    | [<CompiledName "AUTHENTICATED_USER">] AuthenticatedUser

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerCreationState =
    /// Applies to a runner that has been created, but is not yet registered and running.
    | [<CompiledName "STARTED">] Started
    /// Applies to a runner that has been registered and has polled for CI/CD jobs at least once.
    | [<CompiledName "FINISHED">] Finished

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerJobExecutionStatus =
    /// Runner is idle.
    | [<CompiledName "IDLE">] Idle
    /// Runner is busy.
    | [<CompiledName "ACTIVE">] Active

/// Values for filtering runners in namespaces.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerMembershipFilter =
    /// Include runners that have a direct relationship.
    | [<CompiledName "DIRECT">] Direct
    /// Include runners that have either a direct or inherited relationship. These runners can be specific to a project or a group.
    | [<CompiledName "DESCENDANTS">] Descendants

/// Values for sorting runners
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerSort =
    /// Ordered by contacted_at in ascending order.
    | [<CompiledName "CONTACTED_ASC">] ContactedAsc
    /// Ordered by contacted_at in descending order.
    | [<CompiledName "CONTACTED_DESC">] ContactedDesc
    /// Ordered by created_at in ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Ordered by created_at in descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Ordered by token_expires_at in ascending order.
    | [<CompiledName "TOKEN_EXPIRES_AT_ASC">] TokenExpiresAtAsc
    /// Ordered by token_expires_at in descending order.
    | [<CompiledName "TOKEN_EXPIRES_AT_DESC">] TokenExpiresAtDesc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerStatus =
    /// Runner that contacted this instance within the last 2 hours.
    | [<CompiledName "ONLINE">] Online
    /// Runner that has not contacted this instance within the last 2 hours. Will be considered `STALE` if offline for more than 7 days.
    | [<CompiledName "OFFLINE">] Offline
    /// Runner that has not contacted this instance within the last 7 days.
    | [<CompiledName "STALE">] Stale
    /// Runner that has never contacted the instance.
    | [<CompiledName "NEVER_CONTACTED">] NeverContacted

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerType =
    /// A runner that is instance type.
    | [<CompiledName "INSTANCE_TYPE">] InstanceType
    /// A runner that is group type.
    | [<CompiledName "GROUP_TYPE">] GroupType
    /// A runner that is project type.
    | [<CompiledName "PROJECT_TYPE">] ProjectType

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiRunnerUpgradeStatus =
    /// Runner version is not valid.
    | [<CompiledName "INVALID">] Invalid
    /// Upgrade is not available for the runner.
    | [<CompiledName "NOT_AVAILABLE">] NotAvailable
    /// Upgrade is available for the runner.
    | [<CompiledName "AVAILABLE">] Available
    /// Upgrade is available and recommended for the runner.
    | [<CompiledName "RECOMMENDED">] Recommended

/// Values for sorting variables
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiVariableSort =
    /// Sorted by key in ascending order.
    | [<CompiledName "KEY_ASC">] KeyAsc
    /// Sorted by key in descending order.
    | [<CompiledName "KEY_DESC">] KeyDesc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CiVariableType =
    /// Env var type.
    | [<CompiledName "ENV_VAR">] EnvVar
    /// File type.
    | [<CompiledName "FILE">] File

/// The code flow node type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CodeFlowNodeType =
    /// Source node.
    | [<CompiledName "SOURCE">] Source
    /// Propagation node.
    | [<CompiledName "PROPAGATION">] Propagation
    /// Sink node.
    | [<CompiledName "SINK">] Sink

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CodeQualityDegradationSeverity =
    /// Code Quality degradation has a status of blocker.
    | [<CompiledName "BLOCKER">] Blocker
    /// Code Quality degradation has a status of critical.
    | [<CompiledName "CRITICAL">] Critical
    /// Code Quality degradation has a status of major.
    | [<CompiledName "MAJOR">] Major
    /// Code Quality degradation has a status of minor.
    | [<CompiledName "MINOR">] Minor
    /// Code Quality degradation has a status of info.
    | [<CompiledName "INFO">] Info
    /// Code Quality degradation has a status of unknown.
    | [<CompiledName "UNKNOWN">] Unknown

/// Represents the generation status of the compared codequality report.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CodequalityReportsComparerReportGenerationStatus =
    /// Report was generated.
    | [<CompiledName "PARSED">] Parsed
    /// Report is being generated.
    | [<CompiledName "PARSING">] Parsing
    /// An error happened while generating the report.
    | [<CompiledName "ERROR">] Error

/// Represents the state of the code quality report.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CodequalityReportsComparerStatus =
    /// No degradations found in the head pipeline report.
    | [<CompiledName "SUCCESS">] Success
    /// Report generated and there are new code quality degradations.
    | [<CompiledName "FAILED">] Failed
    /// Head report or base report not found.
    | [<CompiledName "NOT_FOUND">] NotFound

/// Mode of a commit action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommitActionMode =
    /// Create command.
    | [<CompiledName "CREATE">] Create
    /// Delete command.
    | [<CompiledName "DELETE">] Delete
    /// Move command.
    | [<CompiledName "MOVE">] Move
    /// Update command.
    | [<CompiledName "UPDATE">] Update
    /// Chmod command.
    | [<CompiledName "CHMOD">] Chmod

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CommitEncoding =
    /// Text encoding.
    | [<CompiledName "TEXT">] Text
    /// Base64 encoding.
    | [<CompiledName "BASE64">] Base64

/// Comparable security report type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComparableSecurityReportType =
    /// SAST report
    | [<CompiledName "SAST">] Sast
    /// Secret detection report
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// Container scanning report
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// Dependency scanning report
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// DAST report
    | [<CompiledName "DAST">] Dast
    /// Coverage fuzzing report
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// API fuzzing report
    | [<CompiledName "API_FUZZING">] ApiFuzzing

/// Comparison operators for filtering
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComparisonOperator =
    /// Less than or equal to (<=).
    | [<CompiledName "LESS_THAN_OR_EQUAL_TO">] LessThanOrEqualTo
    /// Equal to (=).
    | [<CompiledName "EQUAL_TO">] EqualTo
    /// Greater than or equal to (>=).
    | [<CompiledName "GREATER_THAN_OR_EQUAL_TO">] GreaterThanOrEqualTo

/// ComplianceFramework of a project for filtering
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceFrameworkPresenceFilter =
    /// No compliance framework is assigned.
    | [<CompiledName "NONE">] None
    /// Any compliance framework is assigned.
    | [<CompiledName "ANY">] Any

/// Values for sorting compliance frameworks.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceFrameworkSort =
    /// Sort by compliance framework name, ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Sort by compliance framework name, descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Sort by compliance framework updated date, ascending order.
    | [<CompiledName "UPDATED_AT_ASC">] UpdatedAtAsc
    /// Sort by compliance framework updated date, descending order.
    | [<CompiledName "UPDATED_AT_DESC">] UpdatedAtDesc

/// Name of the check for the compliance standard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceStandardsAdherenceCheckName =
    /// Prevent approval by merge request creator (author)
    | [<CompiledName "PREVENT_APPROVAL_BY_MERGE_REQUEST_AUTHOR">] PreventApprovalByMergeRequestAuthor
    /// Prevent approval by merge request committers
    | [<CompiledName "PREVENT_APPROVAL_BY_MERGE_REQUEST_COMMITTERS">] PreventApprovalByMergeRequestCommitters
    /// At least two approvals
    | [<CompiledName "AT_LEAST_TWO_APPROVALS">] AtLeastTwoApprovals
    /// At least one non author approval
    | [<CompiledName "AT_LEAST_ONE_NON_AUTHOR_APPROVAL">] AtLeastOneNonAuthorApproval
    /// Sast
    | [<CompiledName "SAST">] Sast
    /// Dast
    | [<CompiledName "DAST">] Dast

/// Name of the compliance standard.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceStandardsAdherenceStandard =
    /// Gitlab
    | [<CompiledName "GITLAB">] Gitlab
    /// Soc2
    | [<CompiledName "SOC2">] Soc2

/// Status of the compliance standards adherence.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceStandardsAdherenceStatus =
    /// Success
    | [<CompiledName "SUCCESS">] Success
    /// Fail
    | [<CompiledName "FAIL">] Fail

/// Reason for the compliance violation.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceViolationReason =
    /// Approved by merge request author
    | [<CompiledName "APPROVED_BY_MERGE_REQUEST_AUTHOR">] ApprovedByMergeRequestAuthor
    /// Approved by committer
    | [<CompiledName "APPROVED_BY_COMMITTER">] ApprovedByCommitter
    /// Approved by insufficient users
    | [<CompiledName "APPROVED_BY_INSUFFICIENT_USERS">] ApprovedByInsufficientUsers

/// Severity of the compliance violation.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceViolationSeverity =
    /// Info severity
    | [<CompiledName "INFO">] Info
    /// Low severity
    | [<CompiledName "LOW">] Low
    /// Medium severity
    | [<CompiledName "MEDIUM">] Medium
    /// High severity
    | [<CompiledName "HIGH">] High
    /// Critical severity
    | [<CompiledName "CRITICAL">] Critical

/// Compliance violation sort values.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceViolationSort =
    /// Severity in descending order, further sorted by ID in descending order.
    | [<CompiledName "SEVERITY_LEVEL_DESC">] SeverityLevelDesc
    /// Severity in ascending order, further sorted by ID in ascending order.
    | [<CompiledName "SEVERITY_LEVEL_ASC">] SeverityLevelAsc
    /// Violation reason in descending order, further sorted by ID in descending order.
    | [<CompiledName "VIOLATION_REASON_DESC">] ViolationReasonDesc
    /// Violation reason in ascending order, further sorted by ID in ascending order.
    | [<CompiledName "VIOLATION_REASON_ASC">] ViolationReasonAsc
    /// Merge request title in descending order, further sorted by ID in descending order.
    | [<CompiledName "MERGE_REQUEST_TITLE_DESC">] MergeRequestTitleDesc
    /// Merge request title in ascending order, further sorted by ID in ascending order.
    | [<CompiledName "MERGE_REQUEST_TITLE_ASC">] MergeRequestTitleAsc
    /// Date merged in descending order, further sorted by ID in descending order.
    | [<CompiledName "MERGED_AT_DESC">] MergedAtDesc
    /// Date merged in ascending order, further sorted by ID in ascending order.
    | [<CompiledName "MERGED_AT_ASC">] MergedAtAsc

/// Compliance violation status of the project.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ComplianceViolationStatus =
    /// Detected
    | [<CompiledName "DETECTED">] Detected
    /// In review
    | [<CompiledName "IN_REVIEW">] InReview
    /// Resolved
    | [<CompiledName "RESOLVED">] Resolved
    /// Dismissed
    | [<CompiledName "DISMISSED">] Dismissed

/// Conan file types
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ConanMetadatumFileTypeEnum =
    /// A recipe file type.
    | [<CompiledName "RECIPE_FILE">] RecipeFile
    /// A package file type.
    | [<CompiledName "PACKAGE_FILE">] PackageFile

/// Values for sorting contacts
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContactSort =
    /// First name in ascending order.
    | [<CompiledName "FIRST_NAME_ASC">] FirstNameAsc
    /// First name in descending order.
    | [<CompiledName "FIRST_NAME_DESC">] FirstNameDesc
    /// Last name in ascending order.
    | [<CompiledName "LAST_NAME_ASC">] LastNameAsc
    /// Last name in descending order.
    | [<CompiledName "LAST_NAME_DESC">] LastNameDesc
    /// Email in ascending order.
    | [<CompiledName "EMAIL_ASC">] EmailAsc
    /// Email in descending order.
    | [<CompiledName "EMAIL_DESC">] EmailDesc
    /// Phone in ascending order.
    | [<CompiledName "PHONE_ASC">] PhoneAsc
    /// Phone in descending order.
    | [<CompiledName "PHONE_DESC">] PhoneDesc
    /// Description in ascending order.
    | [<CompiledName "DESCRIPTION_ASC">] DescriptionAsc
    /// Description in descending order.
    | [<CompiledName "DESCRIPTION_DESC">] DescriptionDesc
    /// Organization in ascending order.
    | [<CompiledName "ORGANIZATION_ASC">] OrganizationAsc
    /// Organization in descending order.
    | [<CompiledName "ORGANIZATION_DESC">] OrganizationDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerExpirationPolicyCadenceEnum =
    /// Every day
    | [<CompiledName "EVERY_DAY">] EveryDay
    /// Every week
    | [<CompiledName "EVERY_WEEK">] EveryWeek
    /// Every two weeks
    | [<CompiledName "EVERY_TWO_WEEKS">] EveryTwoWeeks
    /// Every month
    | [<CompiledName "EVERY_MONTH">] EveryMonth
    /// Every three months
    | [<CompiledName "EVERY_THREE_MONTHS">] EveryThreeMonths

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerExpirationPolicyKeepEnum =
    /// 1 tag per image name
    | [<CompiledName "ONE_TAG">] OneTag
    /// 5 tags per image name
    | [<CompiledName "FIVE_TAGS">] FiveTags
    /// 10 tags per image name
    | [<CompiledName "TEN_TAGS">] TenTags
    /// 25 tags per image name
    | [<CompiledName "TWENTY_FIVE_TAGS">] TwentyFiveTags
    /// 50 tags per image name
    | [<CompiledName "FIFTY_TAGS">] FiftyTags
    /// 100 tags per image name
    | [<CompiledName "ONE_HUNDRED_TAGS">] OneHundredTags

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerExpirationPolicyOlderThanEnum =
    /// 7 days until tags are automatically removed
    | [<CompiledName "SEVEN_DAYS">] SevenDays
    /// 14 days until tags are automatically removed
    | [<CompiledName "FOURTEEN_DAYS">] FourteenDays
    /// 30 days until tags are automatically removed
    | [<CompiledName "THIRTY_DAYS">] ThirtyDays
    /// 60 days until tags are automatically removed
    | [<CompiledName "SIXTY_DAYS">] SixtyDays
    /// 90 days until tags are automatically removed
    | [<CompiledName "NINETY_DAYS">] NinetyDays

/// Access level for a container repository protection rule resource
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerProtectionRepositoryRuleAccessLevel =
    /// Maintainer access.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner access.
    | [<CompiledName "OWNER">] Owner
    /// Admin access.
    | [<CompiledName "ADMIN">] Admin

/// Status of the tags cleanup of a container repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerRepositoryCleanupStatus =
    /// Tags cleanup is not scheduled. This is the default state.
    | [<CompiledName "UNSCHEDULED">] Unscheduled
    /// Tags cleanup is scheduled and is going to be executed shortly.
    | [<CompiledName "SCHEDULED">] Scheduled
    /// Tags cleanup has been partially executed. There are still remaining tags to delete.
    | [<CompiledName "UNFINISHED">] Unfinished
    /// Tags cleanup is ongoing.
    | [<CompiledName "ONGOING">] Ongoing

/// Values for sorting container repositories
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerRepositorySort =
    /// Name by ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Name by descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Status of a container repository
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerRepositoryStatus =
    /// Delete Scheduled status.
    | [<CompiledName "DELETE_SCHEDULED">] DeleteScheduled
    /// Delete Failed status.
    | [<CompiledName "DELETE_FAILED">] DeleteFailed
    /// Delete Ongoing status.
    | [<CompiledName "DELETE_ONGOING">] DeleteOngoing

/// Values for sorting tags
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ContainerRepositoryTagSort =
    /// Ordered by name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Ordered by name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Ordered by published_at in ascending order. Only available for GitLab.com.
    | [<CompiledName "PUBLISHED_AT_ASC">] PublishedAtAsc
    /// Ordered by published_at in descending order. Only available for GitLab.com.
    | [<CompiledName "PUBLISHED_AT_DESC">] PublishedAtDesc

/// Type of custom field
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CustomFieldType =
    /// Single select field type.
    | [<CompiledName "SINGLE_SELECT">] SingleSelect
    /// Multi select field type.
    | [<CompiledName "MULTI_SELECT">] MultiSelect
    /// Number field type.
    | [<CompiledName "NUMBER">] Number
    /// Text field type.
    | [<CompiledName "TEXT">] Text
    /// Date field type.
    | [<CompiledName "DATE">] Date

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CustomerRelationsContactState =
    /// All available contacts.
    | [<CompiledName "all">] All
    /// Active contacts.
    | [<CompiledName "active">] Active
    /// Inactive contacts.
    | [<CompiledName "inactive">] Inactive

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CustomerRelationsOrganizationState =
    /// All available organizations.
    | [<CompiledName "all">] All
    /// Active organizations.
    | [<CompiledName "active">] Active
    /// Inactive organizations.
    | [<CompiledName "inactive">] Inactive

/// Categories for customizable dashboards.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CustomizableDashboardCategory =
    /// Analytics category for customizable dashboards.
    | [<CompiledName "ANALYTICS">] Analytics

/// Values for a CVSS severity
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type CvssSeverity =
    /// Not a vulnerability.
    | [<CompiledName "NONE">] None
    /// Low severity.
    | [<CompiledName "LOW">] Low
    /// Medium severity.
    | [<CompiledName "MEDIUM">] Medium
    /// High severity.
    | [<CompiledName "HIGH">] High
    /// Critical severity.
    | [<CompiledName "CRITICAL">] Critical

/// Check type of the pre scan verification step.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastPreScanVerificationCheckType =
    /// Connection check
    | [<CompiledName "CONNECTION">] Connection
    /// Authentication check
    | [<CompiledName "AUTHENTICATION">] Authentication
    /// Crawling check
    | [<CompiledName "CRAWLING">] Crawling

/// Status of DAST pre scan verification.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastPreScanVerificationStatus =
    /// Pre Scan Verification in execution.
    | [<CompiledName "RUNNING">] Running
    /// Pre Scan Verification complete without errors.
    | [<CompiledName "COMPLETE">] Complete
    /// Pre Scan Verification finished with one or more errors.
    | [<CompiledName "COMPLETE_WITH_ERRORS">] CompleteWithErrors
    /// Pre Scan Validation unable to finish.
    | [<CompiledName "FAILED">] Failed

/// Unit for the duration of Dast Profile Cadence.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastProfileCadenceUnit =
    /// DAST Profile Cadence duration in days.
    | [<CompiledName "DAY">] Day
    /// DAST Profile Cadence duration in weeks.
    | [<CompiledName "WEEK">] Week
    /// DAST Profile Cadence duration in months.
    | [<CompiledName "MONTH">] Month
    /// DAST Profile Cadence duration in years.
    | [<CompiledName "YEAR">] Year

/// Scan method to be used by the scanner.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastScanMethodType =
    /// Website scan method.
    | [<CompiledName "WEBSITE">] Website
    /// OpenAPI scan method.
    | [<CompiledName "OPENAPI">] Openapi
    /// HAR scan method.
    | [<CompiledName "HAR">] Har
    /// Postman scan method.
    | [<CompiledName "POSTMAN_COLLECTION">] PostmanCollection
    /// GraphQL scan method.
    | [<CompiledName "GRAPHQL">] Graphql

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastScanTypeEnum =
    /// Passive DAST scan. This scan will not make active attacks against the target site.
    | [<CompiledName "PASSIVE">] Passive
    /// Active DAST scan. This scan will make active attacks against the target site.
    | [<CompiledName "ACTIVE">] Active

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastSiteProfileValidationStatusEnum =
    /// No site validation exists.
    | [<CompiledName "NONE">] None
    /// Site validation process has not started.
    | [<CompiledName "PENDING_VALIDATION">] PendingValidation
    /// Site validation process is in progress.
    | [<CompiledName "INPROGRESS_VALIDATION">] InprogressValidation
    /// Site validation process finished successfully.
    | [<CompiledName "PASSED_VALIDATION">] PassedValidation
    /// Site validation process finished but failed.
    | [<CompiledName "FAILED_VALIDATION">] FailedValidation

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastSiteValidationStatusEnum =
    /// Site validation process has not started.
    | [<CompiledName "PENDING_VALIDATION">] PendingValidation
    /// Site validation process is in progress.
    | [<CompiledName "INPROGRESS_VALIDATION">] InprogressValidation
    /// Site validation process finished successfully.
    | [<CompiledName "PASSED_VALIDATION">] PassedValidation
    /// Site validation process finished but failed.
    | [<CompiledName "FAILED_VALIDATION">] FailedValidation

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastSiteValidationStrategyEnum =
    /// Text file validation.
    | [<CompiledName "TEXT_FILE">] TextFile
    /// Header validation.
    | [<CompiledName "HEADER">] Header
    /// Meta tag validation.
    | [<CompiledName "META_TAG">] MetaTag

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DastTargetTypeEnum =
    /// Website target.
    | [<CompiledName "WEBSITE">] Website
    /// API target.
    | [<CompiledName "API">] Api

/// Color of the data visualization palette
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DataVisualizationColorEnum =
    /// Blue color
    | [<CompiledName "BLUE">] Blue
    /// Orange color
    | [<CompiledName "ORANGE">] Orange
    /// Aqua color
    | [<CompiledName "AQUA">] Aqua
    /// Green color
    | [<CompiledName "GREEN">] Green
    /// Magenta color
    | [<CompiledName "MAGENTA">] Magenta

/// Weight of the data visualization palette
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DataVisualizationWeightEnum =
    /// 50 weight
    | [<CompiledName "WEIGHT_50">] Weight50
    /// 100 weight
    | [<CompiledName "WEIGHT_100">] Weight100
    /// 200 weight
    | [<CompiledName "WEIGHT_200">] Weight200
    /// 300 weight
    | [<CompiledName "WEIGHT_300">] Weight300
    /// 400 weight
    | [<CompiledName "WEIGHT_400">] Weight400
    /// 500 weight
    | [<CompiledName "WEIGHT_500">] Weight500
    /// 600 weight
    | [<CompiledName "WEIGHT_600">] Weight600
    /// 700 weight
    | [<CompiledName "WEIGHT_700">] Weight700
    /// 800 weight
    | [<CompiledName "WEIGHT_800">] Weight800
    /// 900 weight
    | [<CompiledName "WEIGHT_900">] Weight900
    /// 950 weight
    | [<CompiledName "WEIGHT_950">] Weight950

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DependencyProxyManifestStatus =
    /// Dependency proxy manifest has a status of default.
    | [<CompiledName "DEFAULT">] Default
    /// Dependency proxy manifest has a status of pending_destruction.
    | [<CompiledName "PENDING_DESTRUCTION">] PendingDestruction
    /// Dependency proxy manifest has a status of processing.
    | [<CompiledName "PROCESSING">] Processing
    /// Dependency proxy manifest has a status of error.
    | [<CompiledName "ERROR">] Error

/// Values for sorting dependencies
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DependencySort =
    /// Name by descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Name by ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Packager by descending order.
    | [<CompiledName "PACKAGER_DESC">] PackagerDesc
    /// Packager by ascending order.
    | [<CompiledName "PACKAGER_ASC">] PackagerAsc
    /// Severity by descending order.
    | [<CompiledName "SEVERITY_DESC">] SeverityDesc
    /// Severity by ascending order.
    | [<CompiledName "SEVERITY_ASC">] SeverityAsc
    /// License by ascending order.
    | [<CompiledName "LICENSE_ASC">] LicenseAsc
    /// License by descending order.
    | [<CompiledName "LICENSE_DESC">] LicenseDesc

/// Status of the deployment approval summary.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentApprovalSummaryStatus =
    /// Summarized deployment approval status that is approved.
    | [<CompiledName "APPROVED">] Approved
    /// Summarized deployment approval status that is rejected.
    | [<CompiledName "REJECTED">] Rejected
    /// Summarized deployment approval status that is pending approval.
    | [<CompiledName "PENDING_APPROVAL">] PendingApproval

/// All deployment statuses.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentStatus =
    /// A deployment that is created.
    | [<CompiledName "CREATED">] Created
    /// A deployment that is running.
    | [<CompiledName "RUNNING">] Running
    /// A deployment that is success.
    | [<CompiledName "SUCCESS">] Success
    /// A deployment that is failed.
    | [<CompiledName "FAILED">] Failed
    /// A deployment that is canceled.
    | [<CompiledName "CANCELED">] Canceled
    /// A deployment that is skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// A deployment that is blocked.
    | [<CompiledName "BLOCKED">] Blocked

/// All environment deployment tiers.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentTier =
    /// Production.
    | [<CompiledName "PRODUCTION">] Production
    /// Staging.
    | [<CompiledName "STAGING">] Staging
    /// Testing.
    | [<CompiledName "TESTING">] Testing
    /// Development.
    | [<CompiledName "DEVELOPMENT">] Development
    /// Other.
    | [<CompiledName "OTHER">] Other

/// Status of the deployment approval.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DeploymentsApprovalStatus =
    /// A deployment approval that is approved.
    | [<CompiledName "APPROVED">] Approved
    /// A deployment approval that is rejected.
    | [<CompiledName "REJECTED">] Rejected

/// Copy state of a DesignCollection
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DesignCollectionCopyState =
    /// The DesignCollection has no copy in progress
    | [<CompiledName "READY">] Ready
    /// The DesignCollection is being copied
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// The DesignCollection encountered an error during a copy
    | [<CompiledName "ERROR">] Error

/// Mutation event of a design within a version
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DesignVersionEvent =
    /// No change.
    | [<CompiledName "NONE">] None
    /// A creation event
    | [<CompiledName "CREATION">] Creation
    /// A modification event
    | [<CompiledName "MODIFICATION">] Modification
    /// A deletion event
    | [<CompiledName "DELETION">] Deletion

/// Detailed representation of whether a GitLab merge request can be merged.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DetailedMergeStatus =
    /// Merge status has not been checked.
    | [<CompiledName "UNCHECKED">] Unchecked
    /// Currently checking for mergeability.
    | [<CompiledName "CHECKING">] Checking
    /// Branch can be merged.
    | [<CompiledName "MERGEABLE">] Mergeable
    /// Source branch exists and contains commits.
    | [<CompiledName "COMMITS_STATUS">] CommitsStatus
    /// Pipeline must succeed before merging.
    | [<CompiledName "CI_MUST_PASS">] CiMustPass
    /// Pipeline is still running.
    | [<CompiledName "CI_STILL_RUNNING">] CiStillRunning
    /// Discussions must be resolved before merging.
    | [<CompiledName "DISCUSSIONS_NOT_RESOLVED">] DiscussionsNotResolved
    /// Merge request must not be draft before merging.
    | [<CompiledName "DRAFT_STATUS">] DraftStatus
    /// Merge request must be open before merging.
    | [<CompiledName "NOT_OPEN">] NotOpen
    /// Merge request must be approved before merging.
    | [<CompiledName "NOT_APPROVED">] NotApproved
    /// Merge request dependencies must be merged.
    | [<CompiledName "BLOCKED_STATUS">] BlockedStatus
    /// Status checks must pass.
    | [<CompiledName "EXTERNAL_STATUS_CHECKS">] ExternalStatusChecks
    /// Merge request diff is being created.
    | [<CompiledName "PREPARING">] Preparing
    /// Either the title or description must reference a Jira issue.
    | [<CompiledName "JIRA_ASSOCIATION">] JiraAssociation
    /// There are conflicts between the source and target branches.
    | [<CompiledName "CONFLICT">] Conflict
    /// Merge request needs to be rebased.
    | [<CompiledName "NEED_REBASE">] NeedRebase
    /// Merge request approvals currently syncing.
    | [<CompiledName "APPROVALS_SYNCING">] ApprovalsSyncing
    /// Merge request includes locked paths.
    | [<CompiledName "LOCKED_PATHS">] LockedPaths
    /// Merge request includes locked LFS files.
    | [<CompiledName "LOCKED_LFS_FILES">] LockedLfsFiles
    /// Merge request may not be merged until after the specified time.
    | [<CompiledName "MERGE_TIME">] MergeTime
    /// All policy rules must be satisfied.
    | [<CompiledName "SECURITY_POLICIES_VIOLATIONS">] SecurityPoliciesViolations
    /// Merge request title does not match required regex.
    | [<CompiledName "TITLE_NOT_MATCHING">] TitleNotMatching
    /// Indicates a reviewer has requested changes.
    | [<CompiledName "REQUESTED_CHANGES">] RequestedChanges

/// Type of file the position refers to
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DiffPositionType =
    /// Text file.
    | [<CompiledName "text">] Text
    /// An image.
    | [<CompiledName "image">] Image
    /// Unknown file type.
    | [<CompiledName "file">] File

/// Represents the different dismissal types for security policy violations.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DismissalType =
    /// Dismissal due to policy false positive.
    | [<CompiledName "POLICY_FALSE_POSITIVE">] PolicyFalsePositive
    /// Dismissal due to scanner false positive.
    | [<CompiledName "SCANNER_FALSE_POSITIVE">] ScannerFalsePositive
    /// Dismissal due to emergency hot fix.
    | [<CompiledName "EMERGENCY_HOT_FIX">] EmergencyHotFix
    /// Dismissal due to other reasons.
    | [<CompiledName "OTHER">] Other

/// All possible ways that DORA metrics can be aggregated.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DoraMetricBucketingInterval =
    /// All data points are combined into a single value.
    | [<CompiledName "ALL">] All
    /// Data points are combined into chunks by month.
    | [<CompiledName "MONTHLY">] Monthly
    /// Data points are combined into chunks by day.
    | [<CompiledName "DAILY">] Daily

/// The status of the workflow.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DuoWorkflowStatus =
    /// The workflow is created.
    | [<CompiledName "CREATED">] Created
    /// The workflow is running.
    | [<CompiledName "RUNNING">] Running
    /// The workflow is paused.
    | [<CompiledName "PAUSED">] Paused
    /// The workflow is input_required.
    | [<CompiledName "INPUT_REQUIRED">] InputRequired
    /// The workflow is plan_approval_required.
    | [<CompiledName "PLAN_APPROVAL_REQUIRED">] PlanApprovalRequired
    /// The workflow is tool_call_approval_required.
    | [<CompiledName "TOOL_CALL_APPROVAL_REQUIRED">] ToolCallApprovalRequired
    /// The workflow is stopped.
    | [<CompiledName "STOPPED">] Stopped
    /// The workflow is failed.
    | [<CompiledName "FAILED">] Failed
    /// The workflow is finished.
    | [<CompiledName "FINISHED">] Finished

/// The status group of the flow session.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DuoWorkflowStatusGroup =
    /// Flow sessions with a status group of active.
    | [<CompiledName "ACTIVE">] Active
    /// Flow sessions with a status group of paused.
    | [<CompiledName "PAUSED">] Paused
    /// Flow sessions with a status group of awaiting_input.
    | [<CompiledName "AWAITING_INPUT">] AwaitingInput
    /// Flow sessions with a status group of completed.
    | [<CompiledName "COMPLETED">] Completed
    /// Flow sessions with a status group of failed.
    | [<CompiledName "FAILED">] Failed
    /// Flow sessions with a status group of canceled.
    | [<CompiledName "CANCELED">] Canceled

/// Values for sorting Duo Workflows.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type DuoWorkflowsWorkflowSort =
    /// By status ascending order.
    | [<CompiledName "STATUS_ASC">] StatusAsc
    /// By status descending order.
    | [<CompiledName "STATUS_DESC">] StatusDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Type of a tree entry
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EntryType =
    /// Directory tree type.
    | [<CompiledName "tree">] Tree
    /// File tree type.
    | [<CompiledName "blob">] Blob
    /// Commit tree type.
    | [<CompiledName "commit">] Commit

/// Roadmap sort values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EpicSort =
    /// Sort by start date in descending order.
    | [<CompiledName "START_DATE_DESC">] StartDateDesc
    /// Sort by start date in ascending order.
    | [<CompiledName "START_DATE_ASC">] StartDateAsc
    /// Sort by end date in descending order.
    | [<CompiledName "END_DATE_DESC">] EndDateDesc
    /// Sort by end date in ascending order.
    | [<CompiledName "END_DATE_ASC">] EndDateAsc
    /// Sort by title in descending order.
    | [<CompiledName "TITLE_DESC">] TitleDesc
    /// Sort by title in ascending order.
    | [<CompiledName "TITLE_ASC">] TitleAsc
    /// Sort by created_at by ascending order.
    | [<CompiledName "CREATED_AT_ASC">] CreatedAtAsc
    /// Sort by created_at by descending order.
    | [<CompiledName "CREATED_AT_DESC">] CreatedAtDesc
    /// Sort by updated_at by ascending order.
    | [<CompiledName "UPDATED_AT_ASC">] UpdatedAtAsc
    /// Sort by updated_at by descending order.
    | [<CompiledName "UPDATED_AT_DESC">] UpdatedAtDesc

/// State of an epic
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EpicState =
    /// All epics.
    | [<CompiledName "all">] All
    /// Open epics.
    | [<CompiledName "opened">] Opened
    /// Closed epics.
    | [<CompiledName "closed">] Closed

/// State event of an epic
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EpicStateEvent =
    /// Reopen the epic.
    | [<CompiledName "REOPEN">] Reopen
    /// Close the epic.
    | [<CompiledName "CLOSE">] Close

/// Epic ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EpicWildcardId =
    /// No epic is assigned.
    | [<CompiledName "NONE">] None
    /// Any epic is assigned.
    | [<CompiledName "ANY">] Any

/// Status of the error tracking service
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ErrorTrackingStatus =
    /// Successfuly fetch the stack trace.
    | [<CompiledName "SUCCESS">] Success
    /// Error tracking service respond with an error.
    | [<CompiledName "ERROR">] Error
    /// Sentry issue not found.
    | [<CompiledName "NOT_FOUND">] NotFound
    /// Error tracking service is not ready.
    | [<CompiledName "RETRY">] Retry

/// Escalation rule statuses
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EscalationRuleStatus =
    /// .
    | [<CompiledName "ACKNOWLEDGED">] Acknowledged
    /// .
    | [<CompiledName "RESOLVED">] Resolved

/// Event action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type EventAction =
    /// Created action
    | [<CompiledName "CREATED">] Created
    /// Updated action
    | [<CompiledName "UPDATED">] Updated
    /// Closed action
    | [<CompiledName "CLOSED">] Closed
    /// Reopened action
    | [<CompiledName "REOPENED">] Reopened
    /// Pushed action
    | [<CompiledName "PUSHED">] Pushed
    /// Commented action
    | [<CompiledName "COMMENTED">] Commented
    /// Merged action
    | [<CompiledName "MERGED">] Merged
    /// Joined action
    | [<CompiledName "JOINED">] Joined
    /// Left action
    | [<CompiledName "LEFT">] Left
    /// Destroyed action
    | [<CompiledName "DESTROYED">] Destroyed
    /// Expired action
    | [<CompiledName "EXPIRED">] Expired
    /// Approved action
    | [<CompiledName "APPROVED">] Approved

/// Enum for the security scanners used with exclusions
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ExclusionScannerEnum =
    /// Secret Push Protection.
    | [<CompiledName "SECRET_PUSH_PROTECTION">] SecretPushProtection

/// Enum for types of exclusion for a security scanner
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ExclusionTypeEnum =
    /// File or directory location.
    | [<CompiledName "PATH">] Path
    /// Regex pattern matching rules.
    | [<CompiledName "REGEX_PATTERN">] RegexPattern
    /// Raw value to ignore.
    | [<CompiledName "RAW_VALUE">] RawValue
    /// Scanner rule identifier.
    | [<CompiledName "RULE">] Rule

/// Values for status of the Web IDE Extension Marketplace opt-in for the user
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ExtensionsMarketplaceOptInStatus =
    /// Web IDE Extension Marketplace opt-in status: UNSET.
    | [<CompiledName "UNSET">] Unset
    /// Web IDE Extension Marketplace opt-in status: ENABLED.
    | [<CompiledName "ENABLED">] Enabled
    /// Web IDE Extension Marketplace opt-in status: DISABLED.
    | [<CompiledName "DISABLED">] Disabled

/// Report comparison status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type FindingReportsComparerStatus =
    /// Report was generated.
    | [<CompiledName "PARSED">] Parsed
    /// Report is being generated.
    | [<CompiledName "PARSING">] Parsing
    /// An error happened while generating the report.
    | [<CompiledName "ERROR">] Error

/// Action to trigger on multiple Geo registries
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GeoRegistriesBulkAction =
    /// Reverify multiple registries.
    | [<CompiledName "REVERIFY_ALL">] ReverifyAll
    /// Resync multiple registries.
    | [<CompiledName "RESYNC_ALL">] ResyncAll

/// Action to trigger on an individual Geo registry
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GeoRegistryAction =
    /// Reverify a registry.
    | [<CompiledName "REVERIFY">] Reverify
    /// Resync a registry.
    | [<CompiledName "RESYNC">] Resync

/// Geo registry class
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GeoRegistryClass =
    /// Geo::ContainerRepositoryRegistry registry class
    | [<CompiledName "CONTAINER_REPOSITORY_REGISTRY">] ContainerRepositoryRegistry
    /// Geo::DesignManagementRepositoryRegistry registry class
    | [<CompiledName "DESIGN_MANAGEMENT_REPOSITORY_REGISTRY">] DesignManagementRepositoryRegistry
    /// Geo::JobArtifactRegistry registry class
    | [<CompiledName "JOB_ARTIFACT_REGISTRY">] JobArtifactRegistry
    /// Geo::LfsObjectRegistry registry class
    | [<CompiledName "LFS_OBJECT_REGISTRY">] LfsObjectRegistry
    /// Geo::MergeRequestDiffRegistry registry class
    | [<CompiledName "MERGE_REQUEST_DIFF_REGISTRY">] MergeRequestDiffRegistry
    /// Geo::PackageFileRegistry registry class
    | [<CompiledName "PACKAGE_FILE_REGISTRY">] PackageFileRegistry
    /// Geo::PipelineArtifactRegistry registry class
    | [<CompiledName "PIPELINE_ARTIFACT_REGISTRY">] PipelineArtifactRegistry
    /// Geo::TerraformStateVersionRegistry registry class
    | [<CompiledName "TERRAFORM_STATE_VERSION_REGISTRY">] TerraformStateVersionRegistry
    /// Geo::UploadRegistry registry class
    | [<CompiledName "UPLOAD_REGISTRY">] UploadRegistry
    /// Geo::SnippetRepositoryRegistry registry class
    | [<CompiledName "SNIPPET_REPOSITORY_REGISTRY">] SnippetRepositoryRegistry
    /// Geo::GroupWikiRepositoryRegistry registry class
    | [<CompiledName "GROUP_WIKI_REPOSITORY_REGISTRY">] GroupWikiRepositoryRegistry
    /// Geo::PagesDeploymentRegistry registry class
    | [<CompiledName "PAGES_DEPLOYMENT_REGISTRY">] PagesDeploymentRegistry
    /// Geo::CiSecureFileRegistry registry class
    | [<CompiledName "CI_SECURE_FILE_REGISTRY">] CiSecureFileRegistry
    /// Geo::DependencyProxyBlobRegistry registry class
    | [<CompiledName "DEPENDENCY_PROXY_BLOB_REGISTRY">] DependencyProxyBlobRegistry
    /// Geo::DependencyProxyManifestRegistry registry class
    | [<CompiledName "DEPENDENCY_PROXY_MANIFEST_REGISTRY">] DependencyProxyManifestRegistry
    /// Geo::ProjectWikiRepositoryRegistry registry class
    | [<CompiledName "PROJECT_WIKI_REPOSITORY_REGISTRY">] ProjectWikiRepositoryRegistry
    /// Geo::ProjectRepositoryRegistry registry class
    | [<CompiledName "PROJECT_REPOSITORY_REGISTRY">] ProjectRepositoryRegistry
    /// Geo::PackagesNugetSymbolRegistry registry class
    | [<CompiledName "PACKAGES_NUGET_SYMBOL_REGISTRY">] PackagesNugetSymbolRegistry

/// Values for sorting Geo registries
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GeoRegistrySort =
    /// ID by ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// ID by descending order.
    | [<CompiledName "ID_DESC">] IdDesc
    /// Latest verification date by ascending order.
    | [<CompiledName "VERIFIED_AT_ASC">] VerifiedAtAsc
    /// Latest verification date by descending order.
    | [<CompiledName "VERIFIED_AT_DESC">] VerifiedAtDesc
    /// Latest sync date by ascending order.
    | [<CompiledName "LAST_SYNCED_AT_ASC">] LastSyncedAtAsc
    /// Latest sync date by descending order.
    | [<CompiledName "LAST_SYNCED_AT_DESC">] LastSyncedAtDesc

/// Types of add-ons
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GitlabSubscriptionsAddOnType =
    /// GitLab Duo Pro add-on.
    | [<CompiledName "CODE_SUGGESTIONS">] CodeSuggestions
    /// GitLab Duo Enterprise add-on.
    | [<CompiledName "DUO_ENTERPRISE">] DuoEnterprise
    /// GitLab Duo with Amazon Q add-on.
    | [<CompiledName "DUO_AMAZON_Q">] DuoAmazonQ

/// Role of User
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GitlabSubscriptionsUserRole =
    /// Guest.
    | [<CompiledName "GUEST">] Guest
    /// Planner.
    | [<CompiledName "PLANNER">] Planner
    /// Reporter.
    | [<CompiledName "REPORTER">] Reporter
    /// Developer.
    | [<CompiledName "DEVELOPER">] Developer
    /// Maintainer.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner.
    | [<CompiledName "OWNER">] Owner

/// Values for sorting users
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GitlabSubscriptionsUserSort =
    /// Id by ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// Id by descending order.
    | [<CompiledName "ID_DESC">] IdDesc
    /// Name by ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Name by descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Last activity by ascending order.
    | [<CompiledName "LAST_ACTIVITY_ON_ASC">] LastActivityOnAsc
    /// Last activity by descending order.
    | [<CompiledName "LAST_ACTIVITY_ON_DESC">] LastActivityOnDesc

/// Values for sorting artifacts
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GoogleCloudArtifactRegistryArtifactsSort =
    /// Ordered by `name` in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Ordered by `name` in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Ordered by `image_size_bytes` in ascending order.
    | [<CompiledName "IMAGE_SIZE_BYTES_ASC">] ImageSizeBytesAsc
    /// Ordered by `image_size_bytes` in descending order.
    | [<CompiledName "IMAGE_SIZE_BYTES_DESC">] ImageSizeBytesDesc
    /// Ordered by `upload_time` in ascending order.
    | [<CompiledName "UPLOAD_TIME_ASC">] UploadTimeAsc
    /// Ordered by `upload_time` in descending order.
    | [<CompiledName "UPLOAD_TIME_DESC">] UploadTimeDesc
    /// Ordered by `build_time` in ascending order.
    | [<CompiledName "BUILD_TIME_ASC">] BuildTimeAsc
    /// Ordered by `build_time` in descending order.
    | [<CompiledName "BUILD_TIME_DESC">] BuildTimeDesc
    /// Ordered by `update_time` in ascending order.
    | [<CompiledName "UPDATE_TIME_ASC">] UpdateTimeAsc
    /// Ordered by `update_time` in descending order.
    | [<CompiledName "UPDATE_TIME_DESC">] UpdateTimeDesc
    /// Ordered by `media_type` in ascending order.
    | [<CompiledName "MEDIA_TYPE_ASC">] MediaTypeAsc
    /// Ordered by `media_type` in descending order.
    | [<CompiledName "MEDIA_TYPE_DESC">] MediaTypeDesc

/// Group member relation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupMemberRelation =
    /// Members in the group itself.
    | [<CompiledName "DIRECT">] Direct
    /// Members in the group's ancestor groups.
    | [<CompiledName "INHERITED">] Inherited
    /// Members in the group's subgroups.
    | [<CompiledName "DESCENDANTS">] Descendants
    /// Invited group's members.
    | [<CompiledName "SHARED_FROM_GROUPS">] SharedFromGroups

/// User permission on groups
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupPermission =
    /// Groups where the user can create projects.
    | [<CompiledName "CREATE_PROJECTS">] CreateProjects
    /// Groups where the user can transfer projects to.
    | [<CompiledName "TRANSFER_PROJECTS">] TransferProjects
    /// Groups where the user can import projects to.
    | [<CompiledName "IMPORT_PROJECTS">] ImportProjects

/// Values for sorting releases belonging to a group
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupReleaseSort =
    /// Released at by descending order.
    | [<CompiledName "RELEASED_AT_DESC">] ReleasedAtDesc
    /// Released at by ascending order.
    | [<CompiledName "RELEASED_AT_ASC">] ReleasedAtAsc

/// Values for the group secrets manager status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupSecretsManagerStatus =
    /// Secrets manager is being provisioned.
    | [<CompiledName "PROVISIONING">] Provisioning
    /// Secrets manager has been provisioned and enabled.
    | [<CompiledName "ACTIVE">] Active
    /// Secrets manager is being deprovisioned.
    | [<CompiledName "DEPROVISIONING">] Deprovisioning

/// Values for sorting groups
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupSort =
    /// Most similar to the search query.
    | [<CompiledName "SIMILARITY">] Similarity
    /// Sort by created at, ascending order.
    | [<CompiledName "CREATED_AT_ASC">] CreatedAtAsc
    /// Sort by created at, descending order.
    | [<CompiledName "CREATED_AT_DESC">] CreatedAtDesc
    /// Sort by updated at, ascending order.
    | [<CompiledName "UPDATED_AT_ASC">] UpdatedAtAsc
    /// Sort by updated at, descending order.
    | [<CompiledName "UPDATED_AT_DESC">] UpdatedAtDesc
    /// Sort by name, ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Sort by name, descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Sort by path, ascending order.
    | [<CompiledName "PATH_ASC">] PathAsc
    /// Sort by path, descending order.
    | [<CompiledName "PATH_DESC">] PathDesc
    /// Sort by ID, ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// Sort by ID, descending order.
    | [<CompiledName "ID_DESC">] IdDesc

/// Values for grouping compute usage data.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type GroupingEnum =
    /// Aggregate usage data across all namespaces in the instance.
    | [<CompiledName "INSTANCE_AGGREGATE">] InstanceAggregate
    /// Group data by individual root namespace.
    | [<CompiledName "PER_ROOT_NAMESPACE">] PerRootNamespace

/// Health status of an issue or epic
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type HealthStatus =
    /// On track
    | [<CompiledName "onTrack">] OnTrack
    /// Needs attention
    | [<CompiledName "needsAttention">] NeedsAttention
    /// At risk
    | [<CompiledName "atRisk">] AtRisk

/// Health status of an issue or epic for filtering
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type HealthStatusFilter =
    /// No health status is assigned.
    | [<CompiledName "NONE">] None
    /// Any health status is assigned.
    | [<CompiledName "ANY">] Any
    /// On track
    | [<CompiledName "onTrack">] OnTrack
    /// Needs attention
    | [<CompiledName "needsAttention">] NeedsAttention
    /// At risk
    | [<CompiledName "atRisk">] AtRisk

/// Import source
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ImportSource =
    /// Not imported
    | [<CompiledName "NONE">] None
    /// Gitlab Migration
    | [<CompiledName "GITLAB_MIGRATION">] GitlabMigration
    /// Gitlab Project
    | [<CompiledName "GITLAB_PROJECT">] GitlabProject
    /// Gitlab Group
    | [<CompiledName "GITLAB_GROUP">] GitlabGroup
    /// Github
    | [<CompiledName "GITHUB">] Github
    /// Bitbucket
    | [<CompiledName "BITBUCKET">] Bitbucket
    /// Bitbucket Server
    | [<CompiledName "BITBUCKET_SERVER">] BitbucketServer
    /// Fogbugz
    | [<CompiledName "FOGBUGZ">] Fogbugz
    /// Gitea
    | [<CompiledName "GITEA">] Gitea
    /// Git
    | [<CompiledName "GIT">] Git
    /// Manifest
    | [<CompiledName "MANIFEST">] Manifest
    /// Custom Template
    | [<CompiledName "CUSTOM_TEMPLATE">] CustomTemplate
    /// Jira
    | [<CompiledName "JIRA">] Jira

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ImportSourceUserStatus =
    /// An import source user mapping that is pending reassignment.
    | [<CompiledName "PENDING_REASSIGNMENT">] PendingReassignment
    /// An import source user mapping that is awaiting approval.
    | [<CompiledName "AWAITING_APPROVAL">] AwaitingApproval
    /// An import source user mapping that is reassignment in progress.
    | [<CompiledName "REASSIGNMENT_IN_PROGRESS">] ReassignmentInProgress
    /// An import source user mapping that is rejected.
    | [<CompiledName "REJECTED">] Rejected
    /// An import source user mapping that is failed.
    | [<CompiledName "FAILED">] Failed
    /// An import source user mapping that is completed.
    | [<CompiledName "COMPLETED">] Completed
    /// An import source user mapping that is keep as placeholder.
    | [<CompiledName "KEEP_AS_PLACEHOLDER">] KeepAsPlaceholder

/// Integration Names
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IntegrationType =
    /// Beyond Identity.
    | [<CompiledName "BEYOND_IDENTITY">] BeyondIdentity

/// Issuable resource link type enum
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssuableResourceLinkType =
    /// General link type
    | [<CompiledName "general">] General
    /// Zoom link type
    | [<CompiledName "zoom">] Zoom
    /// Slack link type
    | [<CompiledName "slack">] Slack
    /// Pagerduty link type
    | [<CompiledName "pagerduty">] Pagerduty

/// Fields to perform the search in
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssuableSearchableField =
    /// Search in title field.
    | [<CompiledName "TITLE">] Title
    /// Search in description field.
    | [<CompiledName "DESCRIPTION">] Description

/// Incident severity
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssuableSeverity =
    /// Unknown severity
    | [<CompiledName "UNKNOWN">] Unknown
    /// Low severity
    | [<CompiledName "LOW">] Low
    /// Medium severity
    | [<CompiledName "MEDIUM">] Medium
    /// High severity
    | [<CompiledName "HIGH">] High
    /// Critical severity
    | [<CompiledName "CRITICAL">] Critical

/// State of a GitLab issue or merge request
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssuableState =
    /// In open state.
    | [<CompiledName "opened">] Opened
    /// In closed state.
    | [<CompiledName "closed">] Closed
    /// Discussion has been locked.
    | [<CompiledName "locked">] Locked
    /// All available.
    | [<CompiledName "all">] All

/// Iteration ID wildcard values for issue creation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueCreationIterationWildcardId =
    /// Current iteration.
    | [<CompiledName "CURRENT">] Current

/// Issue escalation status values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueEscalationStatus =
    /// Investigation has not started.
    | [<CompiledName "TRIGGERED">] Triggered
    /// Someone is actively investigating the problem.
    | [<CompiledName "ACKNOWLEDGED">] Acknowledged
    /// The problem has been addressed.
    | [<CompiledName "RESOLVED">] Resolved
    /// No action will be taken.
    | [<CompiledName "IGNORED">] Ignored

/// Values for sorting issues
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueSort =
    /// Due date by ascending order.
    | [<CompiledName "DUE_DATE_ASC">] DueDateAsc
    /// Due date by descending order.
    | [<CompiledName "DUE_DATE_DESC">] DueDateDesc
    /// Relative position by ascending order.
    | [<CompiledName "RELATIVE_POSITION_ASC">] RelativePositionAsc
    /// Severity from less critical to more critical.
    | [<CompiledName "SEVERITY_ASC">] SeverityAsc
    /// Severity from more critical to less critical.
    | [<CompiledName "SEVERITY_DESC">] SeverityDesc
    /// Title by ascending order.
    | [<CompiledName "TITLE_ASC">] TitleAsc
    /// Title by descending order.
    | [<CompiledName "TITLE_DESC">] TitleDesc
    /// Number of upvotes (awarded "thumbs up" emoji) by ascending order.
    | [<CompiledName "POPULARITY_ASC">] PopularityAsc
    /// Number of upvotes (awarded "thumbs up" emoji) by descending order.
    | [<CompiledName "POPULARITY_DESC">] PopularityDesc
    /// Status from triggered to resolved.
    | [<CompiledName "ESCALATION_STATUS_ASC">] EscalationStatusAsc
    /// Status from resolved to triggered.
    | [<CompiledName "ESCALATION_STATUS_DESC">] EscalationStatusDesc
    /// Closed time by ascending order.
    | [<CompiledName "CLOSED_AT_ASC">] ClosedAtAsc
    /// Closed time by descending order.
    | [<CompiledName "CLOSED_AT_DESC">] ClosedAtDesc
    /// Weight by ascending order.
    | [<CompiledName "WEIGHT_ASC">] WeightAsc
    /// Weight by descending order.
    | [<CompiledName "WEIGHT_DESC">] WeightDesc
    /// Published issues shown last.
    | [<CompiledName "PUBLISHED_ASC">] PublishedAsc
    /// Published issues shown first.
    | [<CompiledName "PUBLISHED_DESC">] PublishedDesc
    /// Issues with earliest SLA due time shown first.
    | [<CompiledName "SLA_DUE_AT_ASC">] SlaDueAtAsc
    /// Issues with latest SLA due time shown first.
    | [<CompiledName "SLA_DUE_AT_DESC">] SlaDueAtDesc
    /// Blocking issues count by ascending order.
    | [<CompiledName "BLOCKING_ISSUES_ASC">] BlockingIssuesAsc
    /// Blocking issues count by descending order.
    | [<CompiledName "BLOCKING_ISSUES_DESC">] BlockingIssuesDesc
    /// Issues with healthy issues first.
    | [<CompiledName "HEALTH_STATUS_ASC">] HealthStatusAsc
    /// Issues with unhealthy issues first.
    | [<CompiledName "HEALTH_STATUS_DESC">] HealthStatusDesc
    /// Priority by ascending order.
    | [<CompiledName "PRIORITY_ASC">] PriorityAsc
    /// Priority by descending order.
    | [<CompiledName "PRIORITY_DESC">] PriorityDesc
    /// Label priority by ascending order.
    | [<CompiledName "LABEL_PRIORITY_ASC">] LabelPriorityAsc
    /// Label priority by descending order.
    | [<CompiledName "LABEL_PRIORITY_DESC">] LabelPriorityDesc
    /// Milestone due date by ascending order.
    | [<CompiledName "MILESTONE_DUE_ASC">] MilestoneDueAsc
    /// Milestone due date by descending order.
    | [<CompiledName "MILESTONE_DUE_DESC">] MilestoneDueDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// State of a GitLab issue
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueState =
    /// In open state.
    | [<CompiledName "opened">] Opened
    /// In closed state.
    | [<CompiledName "closed">] Closed
    /// Discussion has been locked.
    | [<CompiledName "locked">] Locked
    /// All available.
    | [<CompiledName "all">] All

/// Values for issue state events
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueStateEvent =
    /// Reopens the issue.
    | [<CompiledName "REOPEN">] Reopen
    /// Closes the issue.
    | [<CompiledName "CLOSE">] Close

/// Issue type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IssueType =
    /// Issue issue type
    | [<CompiledName "ISSUE">] Issue
    /// Incident issue type
    | [<CompiledName "INCIDENT">] Incident
    /// Test Case issue type
    | [<CompiledName "TEST_CASE">] TestCase
    /// Requirement issue type
    | [<CompiledName "REQUIREMENT">] Requirement
    /// Task issue type
    | [<CompiledName "TASK">] Task
    /// Ticket issue type
    | [<CompiledName "TICKET">] Ticket

/// Fields to perform the search in
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IterationSearchableField =
    /// Search in title field.
    | [<CompiledName "TITLE">] Title
    /// Search in cadence_title field.
    | [<CompiledName "CADENCE_TITLE">] CadenceTitle

/// Iteration sort values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IterationSort =
    /// Sort by cadence id in ascending and due date in ascending order.
    | [<CompiledName "CADENCE_AND_DUE_DATE_ASC">] CadenceAndDueDateAsc
    /// Sort by cadence id in ascending and due date in descending order.
    | [<CompiledName "CADENCE_AND_DUE_DATE_DESC">] CadenceAndDueDateDesc

/// State of a GitLab iteration
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IterationState =
    /// Upcoming iteration.
    | [<CompiledName "upcoming">] Upcoming
    /// Current iteration.
    | [<CompiledName "current">] Current
    /// Open iteration.
    | [<CompiledName "opened">] Opened
    /// Closed iteration.
    | [<CompiledName "closed">] Closed
    /// Any iteration.
    | [<CompiledName "all">] All

/// Iteration ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type IterationWildcardId =
    /// No iteration is assigned.
    | [<CompiledName "NONE">] None
    /// An iteration is assigned.
    | [<CompiledName "ANY">] Any
    /// Current iteration.
    | [<CompiledName "CURRENT">] Current

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type JobArtifactFileType =
    /// ARCHIVE job artifact file type.
    | [<CompiledName "ARCHIVE">] Archive
    /// METADATA job artifact file type.
    | [<CompiledName "METADATA">] Metadata
    /// TRACE job artifact file type.
    | [<CompiledName "TRACE">] Trace
    /// JUNIT job artifact file type.
    | [<CompiledName "JUNIT">] Junit
    /// METRICS job artifact file type.
    | [<CompiledName "METRICS">] Metrics
    /// METRICS REFEREE job artifact file type.
    | [<CompiledName "METRICS_REFEREE">] MetricsReferee
    /// NETWORK REFEREE job artifact file type.
    | [<CompiledName "NETWORK_REFEREE">] NetworkReferee
    /// DOTENV job artifact file type.
    | [<CompiledName "DOTENV">] Dotenv
    /// COBERTURA job artifact file type.
    | [<CompiledName "COBERTURA">] Cobertura
    /// JACOCO job artifact file type.
    | [<CompiledName "JACOCO">] Jacoco
    /// CLUSTER APPLICATIONS job artifact file type.
    | [<CompiledName "CLUSTER_APPLICATIONS">] ClusterApplications
    /// LSIF job artifact file type.
    | [<CompiledName "LSIF">] Lsif
    /// SCIP job artifact file type.
    | [<CompiledName "SCIP">] Scip
    /// CYCLONEDX job artifact file type.
    | [<CompiledName "CYCLONEDX">] Cyclonedx
    /// ANNOTATIONS job artifact file type.
    | [<CompiledName "ANNOTATIONS">] Annotations
    /// REPOSITORY XRAY job artifact file type.
    | [<CompiledName "REPOSITORY_XRAY">] RepositoryXray
    /// SAST job artifact file type.
    | [<CompiledName "SAST">] Sast
    /// SECRET DETECTION job artifact file type.
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// DEPENDENCY SCANNING job artifact file type.
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// CONTAINER SCANNING job artifact file type.
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// CLUSTER IMAGE SCANNING job artifact file type.
    | [<CompiledName "CLUSTER_IMAGE_SCANNING">] ClusterImageScanning
    /// DAST job artifact file type.
    | [<CompiledName "DAST">] Dast
    /// LICENSE SCANNING job artifact file type.
    | [<CompiledName "LICENSE_SCANNING">] LicenseScanning
    /// ACCESSIBILITY job artifact file type.
    | [<CompiledName "ACCESSIBILITY">] Accessibility
    /// CODE QUALITY job artifact file type.
    | [<CompiledName "CODEQUALITY">] Codequality
    /// PERFORMANCE job artifact file type.
    | [<CompiledName "PERFORMANCE">] Performance
    /// BROWSER PERFORMANCE job artifact file type.
    | [<CompiledName "BROWSER_PERFORMANCE">] BrowserPerformance
    /// LOAD PERFORMANCE job artifact file type.
    | [<CompiledName "LOAD_PERFORMANCE">] LoadPerformance
    /// TERRAFORM job artifact file type.
    | [<CompiledName "TERRAFORM">] Terraform
    /// REQUIREMENTS job artifact file type.
    | [<CompiledName "REQUIREMENTS">] Requirements
    /// REQUIREMENTS V2 job artifact file type.
    | [<CompiledName "REQUIREMENTS_V2">] RequirementsV2
    /// COVERAGE FUZZING job artifact file type.
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// API FUZZING job artifact file type.
    | [<CompiledName "API_FUZZING">] ApiFuzzing

/// List of fields where the provided searchTerm should be looked up
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LabelSearchFieldList =
    /// Search in the label title.
    | [<CompiledName "TITLE">] Title
    /// Search in the label description.
    | [<CompiledName "DESCRIPTION">] Description

/// All LDAP admin role sync statuses.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type LdapAdminRoleSyncStatus =
    /// A sync that is never synced.
    | [<CompiledName "NEVER_SYNCED">] NeverSynced
    /// A sync that is queued.
    | [<CompiledName "QUEUED">] Queued
    /// A sync that is running.
    | [<CompiledName "RUNNING">] Running
    /// A sync that is failed.
    | [<CompiledName "FAILED">] Failed
    /// A sync that is successful.
    | [<CompiledName "SUCCESSFUL">] Successful

/// List limit metric setting
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ListLimitMetric =
    /// Limit list by number and total weight of issues.
    | [<CompiledName "all_metrics">] AllMetrics
    /// Limit list by number of issues.
    | [<CompiledName "issue_count">] IssueCount
    /// Limit list by total weight of issues.
    | [<CompiledName "issue_weights">] IssueWeights

/// Possible identifier types for a measurement
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MeasurementIdentifier =
    /// Project count.
    | [<CompiledName "PROJECTS">] Projects
    /// User count.
    | [<CompiledName "USERS">] Users
    /// Issue count.
    | [<CompiledName "ISSUES">] Issues
    /// Merge request count.
    | [<CompiledName "MERGE_REQUESTS">] MergeRequests
    /// Group count.
    | [<CompiledName "GROUPS">] Groups
    /// Pipeline count.
    | [<CompiledName "PIPELINES">] Pipelines
    /// Pipeline count with success status.
    | [<CompiledName "PIPELINES_SUCCEEDED">] PipelinesSucceeded
    /// Pipeline count with failed status.
    | [<CompiledName "PIPELINES_FAILED">] PipelinesFailed
    /// Pipeline count with canceled status.
    | [<CompiledName "PIPELINES_CANCELED">] PipelinesCanceled
    /// Pipeline count with skipped status.
    | [<CompiledName "PIPELINES_SKIPPED">] PipelinesSkipped

/// Access level of a group or project member
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberAccessLevel =
    /// The Guest role is for users who need visibility into a project or group but should not have the ability to make changes, such as external stakeholders.
    | [<CompiledName "GUEST">] Guest
    /// The Planner role is suitable for team members who need to manage projects and track work items but do not need to contribute code.
    | [<CompiledName "PLANNER">] Planner
    /// The Reporter role is suitable for team members who need to stay informed about a project or group but do not actively contribute code.
    | [<CompiledName "REPORTER">] Reporter
    /// The Developer role gives users access to contribute code while restricting sensitive administrative actions.
    | [<CompiledName "DEVELOPER">] Developer
    /// The Maintainer role is primarily used for managing code reviews, approvals, and administrative settings for projects. This role can also manage project memberships.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// The Owner role is typically assigned to the individual or team responsible for managing and maintaining the group or creating the project. This role has the highest level of administrative control, and can manage all aspects of the group or project, including managing other Owners.
    | [<CompiledName "OWNER">] Owner
    /// The Minimal Access role is for users who need the least amount of access into groups and projects. You can assign this role as a default, before giving a user another role with more permissions.
    | [<CompiledName "MINIMAL_ACCESS">] MinimalAccess

/// Name of access levels of a group or project member
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberAccessLevelName =
    /// Guest access.
    | [<CompiledName "GUEST">] Guest
    /// Planner access.
    | [<CompiledName "PLANNER">] Planner
    /// Reporter access.
    | [<CompiledName "REPORTER">] Reporter
    /// Developer access.
    | [<CompiledName "DEVELOPER">] Developer
    /// Maintainer access.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner access.
    | [<CompiledName "OWNER">] Owner

/// Types of member approval status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberApprovalStatusType =
    /// Approved promotion request.
    | [<CompiledName "APPROVED">] Approved
    /// Denied promotion request.
    | [<CompiledName "DENIED">] Denied
    /// Pending promotion request.
    | [<CompiledName "PENDING">] Pending

/// Member role permission
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberRolePermission =
    /// Allows approval of merge requests.
    | [<CompiledName "ADMIN_MERGE_REQUEST">] AdminMergeRequest
    /// Allows archiving of projects.
    | [<CompiledName "ARCHIVE_PROJECT">] ArchiveProject
    /// Ability to delete or restore a group. This ability does not allow deleting top-level groups. Review the Retention period settings to prevent accidental deletion.
    | [<CompiledName "REMOVE_GROUP">] RemoveGroup
    /// Allows deletion of projects.
    | [<CompiledName "REMOVE_PROJECT">] RemoveProject
    /// Allows linking security policy projects.
    | [<CompiledName "MANAGE_SECURITY_POLICY_LINK">] ManageSecurityPolicyLink
    /// Create, read, update, and delete compliance frameworks. Users with this permission can also assign a compliance framework label to a project, and set the default framework of a group.
    | [<CompiledName "ADMIN_COMPLIANCE_FRAMEWORK">] AdminComplianceFramework
    /// Create, read, update, and delete CI/CD variables.
    | [<CompiledName "ADMIN_CICD_VARIABLES">] AdminCicdVariables
    /// Manage deploy tokens at the group or project level.
    | [<CompiledName "MANAGE_DEPLOY_TOKENS">] ManageDeployTokens
    /// Create, read, update, and delete group access tokens. When creating a token, users with this custom permission must select a role for that token that has the same or fewer permissions as the default role used as the base for the custom role.
    | [<CompiledName "MANAGE_GROUP_ACCESS_TOKENS">] ManageGroupAccessTokens
    /// Add or remove users in a group, and assign roles to users. When assigning a role, users with this custom permission must select a role that has the same or fewer permissions as the default role used as the base for their custom role.
    | [<CompiledName "ADMIN_GROUP_MEMBER">] AdminGroupMember
    /// Create, read, update, and delete integrations with external applications.
    | [<CompiledName "ADMIN_INTEGRATIONS">] AdminIntegrations
    /// Configure merge request settings at the group or project level. Group actions include managing merge checks and approval settings. Project actions include managing MR configurations, approval rules and settings, and branch targets. In order to enable Suggested reviewers, the "Manage project access tokens" custom permission needs to be enabled.
    | [<CompiledName "MANAGE_MERGE_REQUEST_SETTINGS">] ManageMergeRequestSettings
    /// Create, read, update, and delete project access tokens. When creating a token, users with this custom permission must select a role for that token that has the same or fewer permissions as the default role used as the base for the custom role.
    | [<CompiledName "MANAGE_PROJECT_ACCESS_TOKENS">] ManageProjectAccessTokens
    /// Create, read, update, and delete protected branches for a project.
    | [<CompiledName "ADMIN_PROTECTED_BRANCH">] AdminProtectedBranch
    /// Create, read, update, and delete protected environments
    | [<CompiledName "ADMIN_PROTECTED_ENVIRONMENTS">] AdminProtectedEnvironments
    /// Create, read, update, and delete protected tags.
    | [<CompiledName "MANAGE_PROTECTED_TAGS">] ManageProtectedTags
    /// Configure push rules for repositories at the group or project level.
    | [<CompiledName "ADMIN_PUSH_RULES">] AdminPushRules
    /// Create, view, edit, and delete group or project Runners. Includes configuring Runner settings.
    | [<CompiledName "ADMIN_RUNNERS">] AdminRunners
    /// Manage the security categories and attributes belonging to a top-level group. Also requires the `read_security_attribute` permission.
    | [<CompiledName "ADMIN_SECURITY_ATTRIBUTES">] AdminSecurityAttributes
    /// Edit and manage security testing configurations and settings.
    | [<CompiledName "ADMIN_SECURITY_TESTING">] AdminSecurityTesting
    /// Execute terraform commands, lock/unlock terraform state files, and remove file versions.
    | [<CompiledName "ADMIN_TERRAFORM_STATE">] AdminTerraformState
    /// Edit the status, linked issue, and severity of a vulnerability object. Also requires the `read_vulnerability` permission.
    | [<CompiledName "ADMIN_VULNERABILITY">] AdminVulnerability
    /// Manage webhooks
    | [<CompiledName "ADMIN_WEB_HOOK">] AdminWebHook
    /// Read compliance capabilities including adherence, violations, and frameworks for groups and projects.
    | [<CompiledName "READ_COMPLIANCE_DASHBOARD">] ReadComplianceDashboard
    /// Read security scan profiles.
    | [<CompiledName "READ_SECURITY_SCAN_PROFILES">] ReadSecurityScanProfiles
    /// Read CI/CD details for runners and jobs in the Admin Area.
    | [<CompiledName "READ_ADMIN_CICD">] ReadAdminCicd
    /// Read CRM contact.
    | [<CompiledName "READ_CRM_CONTACT">] ReadCrmContact
    /// Allows read-only access to the dependencies and licenses.
    | [<CompiledName "READ_DEPENDENCY">] ReadDependency
    /// Read group details in the Admin Area.
    | [<CompiledName "READ_ADMIN_GROUPS">] ReadAdminGroups
    /// Read project details in the Admin Area.
    | [<CompiledName "READ_ADMIN_PROJECTS">] ReadAdminProjects
    /// Allows read-only access to the source code in the user interface. Does not allow users to edit or download repository archives, clone or pull repositories, view source code in an IDE, or view merge requests for private projects. You can download individual files because read-only access inherently grants the ability to make a local copy of the file.
    | [<CompiledName "READ_CODE">] ReadCode
    /// Allows read-only access to group or project runners, including the runner fleet dashboard.
    | [<CompiledName "READ_RUNNERS">] ReadRunners
    /// Allows read-only access to the security categories and attributes belonging to a top-level group.
    | [<CompiledName "READ_SECURITY_ATTRIBUTE">] ReadSecurityAttribute
    /// Read subscription details in the Admin area.
    | [<CompiledName "READ_ADMIN_SUBSCRIPTION">] ReadAdminSubscription
    /// Read system information such as background migrations, health checks, and Gitaly in the Admin Area.
    | [<CompiledName "READ_ADMIN_MONITORING">] ReadAdminMonitoring
    /// Read the user list and user details in the Admin area.
    | [<CompiledName "READ_ADMIN_USERS">] ReadAdminUsers
    /// Read vulnerability reports and security dashboards.
    | [<CompiledName "READ_VULNERABILITY">] ReadVulnerability

/// Member role standard permission
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberRoleStandardPermission =
    /// Allows approval of merge requests.
    | [<CompiledName "ADMIN_MERGE_REQUEST">] AdminMergeRequest
    /// Allows archiving of projects.
    | [<CompiledName "ARCHIVE_PROJECT">] ArchiveProject
    /// Ability to delete or restore a group. This ability does not allow deleting top-level groups. Review the Retention period settings to prevent accidental deletion.
    | [<CompiledName "REMOVE_GROUP">] RemoveGroup
    /// Allows deletion of projects.
    | [<CompiledName "REMOVE_PROJECT">] RemoveProject
    /// Allows linking security policy projects.
    | [<CompiledName "MANAGE_SECURITY_POLICY_LINK">] ManageSecurityPolicyLink
    /// Create, read, update, and delete compliance frameworks. Users with this permission can also assign a compliance framework label to a project, and set the default framework of a group.
    | [<CompiledName "ADMIN_COMPLIANCE_FRAMEWORK">] AdminComplianceFramework
    /// Create, read, update, and delete CI/CD variables.
    | [<CompiledName "ADMIN_CICD_VARIABLES">] AdminCicdVariables
    /// Manage deploy tokens at the group or project level.
    | [<CompiledName "MANAGE_DEPLOY_TOKENS">] ManageDeployTokens
    /// Create, read, update, and delete group access tokens. When creating a token, users with this custom permission must select a role for that token that has the same or fewer permissions as the default role used as the base for the custom role.
    | [<CompiledName "MANAGE_GROUP_ACCESS_TOKENS">] ManageGroupAccessTokens
    /// Add or remove users in a group, and assign roles to users. When assigning a role, users with this custom permission must select a role that has the same or fewer permissions as the default role used as the base for their custom role.
    | [<CompiledName "ADMIN_GROUP_MEMBER">] AdminGroupMember
    /// Create, read, update, and delete integrations with external applications.
    | [<CompiledName "ADMIN_INTEGRATIONS">] AdminIntegrations
    /// Configure merge request settings at the group or project level. Group actions include managing merge checks and approval settings. Project actions include managing MR configurations, approval rules and settings, and branch targets. In order to enable Suggested reviewers, the "Manage project access tokens" custom permission needs to be enabled.
    | [<CompiledName "MANAGE_MERGE_REQUEST_SETTINGS">] ManageMergeRequestSettings
    /// Create, read, update, and delete project access tokens. When creating a token, users with this custom permission must select a role for that token that has the same or fewer permissions as the default role used as the base for the custom role.
    | [<CompiledName "MANAGE_PROJECT_ACCESS_TOKENS">] ManageProjectAccessTokens
    /// Create, read, update, and delete protected branches for a project.
    | [<CompiledName "ADMIN_PROTECTED_BRANCH">] AdminProtectedBranch
    /// Create, read, update, and delete protected environments
    | [<CompiledName "ADMIN_PROTECTED_ENVIRONMENTS">] AdminProtectedEnvironments
    /// Configure push rules for repositories at the group or project level.
    | [<CompiledName "ADMIN_PUSH_RULES">] AdminPushRules
    /// Create, view, edit, and delete group or project Runners. Includes configuring Runner settings.
    | [<CompiledName "ADMIN_RUNNERS">] AdminRunners
    /// Execute terraform commands, lock/unlock terraform state files, and remove file versions.
    | [<CompiledName "ADMIN_TERRAFORM_STATE">] AdminTerraformState
    /// Edit the status, linked issue, and severity of a vulnerability object. Also requires the `read_vulnerability` permission.
    | [<CompiledName "ADMIN_VULNERABILITY">] AdminVulnerability
    /// Manage webhooks
    | [<CompiledName "ADMIN_WEB_HOOK">] AdminWebHook
    /// Read compliance capabilities including adherence, violations, and frameworks for groups and projects.
    | [<CompiledName "READ_COMPLIANCE_DASHBOARD">] ReadComplianceDashboard
    /// Read security scan profiles.
    | [<CompiledName "READ_SECURITY_SCAN_PROFILES">] ReadSecurityScanProfiles
    /// Read CRM contact.
    | [<CompiledName "READ_CRM_CONTACT">] ReadCrmContact
    /// Allows read-only access to the dependencies and licenses.
    | [<CompiledName "READ_DEPENDENCY">] ReadDependency
    /// Allows read-only access to the source code in the user interface. Does not allow users to edit or download repository archives, clone or pull repositories, view source code in an IDE, or view merge requests for private projects. You can download individual files because read-only access inherently grants the ability to make a local copy of the file.
    | [<CompiledName "READ_CODE">] ReadCode
    /// Allows read-only access to group or project runners, including the runner fleet dashboard.
    | [<CompiledName "READ_RUNNERS">] ReadRunners
    /// Read vulnerability reports and security dashboards.
    | [<CompiledName "READ_VULNERABILITY">] ReadVulnerability

/// Access level of a group or project member
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberRolesAccessLevel =
    /// The Minimal Access role is for users who need the least amount of access into groups and projects. You can assign this role as a default, before giving a user another role with more permissions.
    | [<CompiledName "MINIMAL_ACCESS">] MinimalAccess
    /// The Guest role is for users who need visibility into a project or group but should not have the ability to make changes, such as external stakeholders.
    | [<CompiledName "GUEST">] Guest
    /// The Planner role is suitable for team members who need to manage projects and track work items but do not need to contribute code.
    | [<CompiledName "PLANNER">] Planner
    /// The Reporter role is suitable for team members who need to stay informed about a project or group but do not actively contribute code.
    | [<CompiledName "REPORTER">] Reporter
    /// The Developer role gives users access to contribute code while restricting sensitive administrative actions.
    | [<CompiledName "DEVELOPER">] Developer
    /// The Maintainer role is primarily used for managing code reviews, approvals, and administrative settings for projects. This role can also manage project memberships.
    | [<CompiledName "MAINTAINER">] Maintainer

/// Values for ordering member roles by a specific field
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberRolesOrderBy =
    /// Ordered by name.
    | [<CompiledName "NAME">] Name
    /// Ordered by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Ordered by id.
    | [<CompiledName "ID">] Id

/// Values for sorting members
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MemberSort =
    /// Access level ascending order.
    | [<CompiledName "ACCESS_LEVEL_ASC">] AccessLevelAsc
    /// Access level descending order.
    | [<CompiledName "ACCESS_LEVEL_DESC">] AccessLevelDesc
    /// User's full name ascending order.
    | [<CompiledName "USER_FULL_NAME_ASC">] UserFullNameAsc
    /// User's full name descending order.
    | [<CompiledName "USER_FULL_NAME_DESC">] UserFullNameDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// New state to apply to a merge request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeRequestNewState =
    /// Open the merge request if it is closed.
    | [<CompiledName "OPEN">] Open
    /// Close the merge request if it is open.
    | [<CompiledName "CLOSED">] Closed

/// State of a review of a GitLab merge request.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeRequestReviewState =
    /// Awaiting review from merge request reviewer.
    | [<CompiledName "UNREVIEWED">] Unreviewed
    /// Merge request reviewer has reviewed.
    | [<CompiledName "REVIEWED">] Reviewed
    /// Merge request reviewer has requested changes.
    | [<CompiledName "REQUESTED_CHANGES">] RequestedChanges
    /// Merge request reviewer has approved the changes.
    | [<CompiledName "APPROVED">] Approved
    /// Merge request reviewer removed their approval of the changes.
    | [<CompiledName "UNAPPROVED">] Unapproved
    /// Merge request reviewer has started a review.
    | [<CompiledName "REVIEW_STARTED">] ReviewStarted

/// Values for sorting merge requests
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeRequestSort =
    /// Merge time by ascending order.
    | [<CompiledName "MERGED_AT_ASC">] MergedAtAsc
    /// Merge time by descending order.
    | [<CompiledName "MERGED_AT_DESC">] MergedAtDesc
    /// Closed time by ascending order.
    | [<CompiledName "CLOSED_AT_ASC">] ClosedAtAsc
    /// Closed time by descending order.
    | [<CompiledName "CLOSED_AT_DESC">] ClosedAtDesc
    /// Title by ascending order.
    | [<CompiledName "TITLE_ASC">] TitleAsc
    /// Title by descending order.
    | [<CompiledName "TITLE_DESC">] TitleDesc
    /// Number of upvotes (awarded "thumbs up" emoji) by ascending order.
    | [<CompiledName "POPULARITY_ASC">] PopularityAsc
    /// Number of upvotes (awarded "thumbs up" emoji) by descending order.
    | [<CompiledName "POPULARITY_DESC">] PopularityDesc
    /// Priority by ascending order.
    | [<CompiledName "PRIORITY_ASC">] PriorityAsc
    /// Priority by descending order.
    | [<CompiledName "PRIORITY_DESC">] PriorityDesc
    /// Label priority by ascending order.
    | [<CompiledName "LABEL_PRIORITY_ASC">] LabelPriorityAsc
    /// Label priority by descending order.
    | [<CompiledName "LABEL_PRIORITY_DESC">] LabelPriorityDesc
    /// Milestone due date by ascending order.
    | [<CompiledName "MILESTONE_DUE_ASC">] MilestoneDueAsc
    /// Milestone due date by descending order.
    | [<CompiledName "MILESTONE_DUE_DESC">] MilestoneDueDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// State of a GitLab merge request
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeRequestState =
    /// Merge request has been merged.
    | [<CompiledName "merged">] Merged
    /// Opened merge request.
    | [<CompiledName "opened">] Opened
    /// In closed state.
    | [<CompiledName "closed">] Closed
    /// Discussion has been locked.
    | [<CompiledName "locked">] Locked
    /// All available.
    | [<CompiledName "all">] All

/// Values for merge request dashboard list type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeRequestsDashboardListType =
    /// Action based list rendering.
    | [<CompiledName "ACTION_BASED">] ActionBased
    /// Role based list rendering.
    | [<CompiledName "ROLE_BASED">] RoleBased

/// Representation of whether a GitLab merge request can be merged.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeStatus =
    /// Merge status has not been checked.
    | [<CompiledName "UNCHECKED">] Unchecked
    /// Currently checking for mergeability.
    | [<CompiledName "CHECKING">] Checking
    /// There are no conflicts between the source and target branches.
    | [<CompiledName "CAN_BE_MERGED">] CanBeMerged
    /// There are conflicts between the source and target branches.
    | [<CompiledName "CANNOT_BE_MERGED">] CannotBeMerged
    /// Currently unchecked. The previous state was `CANNOT_BE_MERGED`.
    | [<CompiledName "CANNOT_BE_MERGED_RECHECK">] CannotBeMergedRecheck

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeStrategyEnum =
    /// Use the merge_train merge strategy.
    | [<CompiledName "MERGE_TRAIN">] MergeTrain
    /// Use the add_to_merge_train_when_checks_pass merge strategy.
    | [<CompiledName "ADD_TO_MERGE_TRAIN_WHEN_CHECKS_PASS">] AddToMergeTrainWhenChecksPass
    /// Use the merge_when_checks_pass merge strategy.
    | [<CompiledName "MERGE_WHEN_CHECKS_PASS">] MergeWhenChecksPass

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeTrainStatus =
    /// Active merge train.
    | [<CompiledName "ACTIVE">] Active
    /// Completed merge train.
    | [<CompiledName "COMPLETED">] Completed

/// Representation of mergeability check identifier.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeabilityCheckIdentifier =
    /// Checks whether the merge request has changes requested
    | [<CompiledName "REQUESTED_CHANGES">] RequestedChanges
    /// Checks whether the merge request is approved
    | [<CompiledName "NOT_APPROVED">] NotApproved
    /// Checks whether the merge request is blocked
    | [<CompiledName "MERGE_REQUEST_BLOCKED">] MergeRequestBlocked
    /// Checks whether the title or description references a Jira issue.
    | [<CompiledName "JIRA_ASSOCIATION_MISSING">] JiraAssociationMissing
    /// Checks whether the security policies are satisfied
    | [<CompiledName "SECURITY_POLICY_VIOLATIONS">] SecurityPolicyViolations
    /// Checks whether the external status checks pass
    | [<CompiledName "STATUS_CHECKS_MUST_PASS">] StatusChecksMustPass
    /// Checks whether the merge request contains locked paths
    | [<CompiledName "LOCKED_PATHS">] LockedPaths
    /// Checks whether the merge request is open
    | [<CompiledName "NOT_OPEN">] NotOpen
    /// Checks whether the merge is blocked due to a scheduled merge time
    | [<CompiledName "MERGE_TIME">] MergeTime
    /// Checks whether the merge request is draft
    | [<CompiledName "DRAFT_STATUS">] DraftStatus
    /// Checks source branch exists and contains commits.
    | [<CompiledName "COMMITS_STATUS">] CommitsStatus
    /// Checks whether the merge request has open discussions
    | [<CompiledName "DISCUSSIONS_NOT_RESOLVED">] DiscussionsNotResolved
    /// Checks whether the title matches the expected regex
    | [<CompiledName "TITLE_REGEX">] TitleRegex
    /// Checks whether CI has passed
    | [<CompiledName "CI_MUST_PASS">] CiMustPass
    /// Checks whether the merge request contains locked LFS files that are locked by users other than the merge request author
    | [<CompiledName "LOCKED_LFS_FILES">] LockedLfsFiles
    /// Checks whether the merge request has a conflict
    | [<CompiledName "CONFLICT">] Conflict
    /// Checks whether the merge request needs to be rebased
    | [<CompiledName "NEED_REBASE">] NeedRebase

/// Representation of whether a mergeability check passed, checking, failed or is inactive.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MergeabilityCheckStatus =
    /// Mergeability check has passed.
    | [<CompiledName "SUCCESS">] Success
    /// Mergeability check is being checked.
    | [<CompiledName "CHECKING">] Checking
    /// Mergeability check has failed. The merge request cannot be merged.
    | [<CompiledName "FAILED">] Failed
    /// Mergeability check is disabled via settings.
    | [<CompiledName "INACTIVE">] Inactive
    /// Mergeability check has passed with a warning.
    | [<CompiledName "WARNING">] Warning

/// Values for sorting milestones
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneSort =
    /// Milestone due date by ascending order.
    | [<CompiledName "DUE_DATE_ASC">] DueDateAsc
    /// Milestone due date by descending order.
    | [<CompiledName "DUE_DATE_DESC">] DueDateDesc
    /// Group milestones in the order: non-expired milestones with due dates, non-expired milestones without due dates and expired milestones then sort by due date in ascending order.
    | [<CompiledName "EXPIRED_LAST_DUE_DATE_ASC">] ExpiredLastDueDateAsc
    /// Group milestones in the order: non-expired milestones with due dates, non-expired milestones without due dates and expired milestones then sort by due date in descending order.
    | [<CompiledName "EXPIRED_LAST_DUE_DATE_DESC">] ExpiredLastDueDateDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Current state of milestone
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneStateEnum =
    /// Milestone is currently active.
    | [<CompiledName "active">] Active
    /// Milestone is closed.
    | [<CompiledName "closed">] Closed

/// Milestone ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MilestoneWildcardId =
    /// No milestone is assigned.
    | [<CompiledName "NONE">] None
    /// Milestone is assigned.
    | [<CompiledName "ANY">] Any
    /// Milestone assigned is open and started (overlaps current date). This differs from the behavior in the [REST API implementation](https://docs.gitlab.com/api/issues/#list-issues).
    | [<CompiledName "STARTED">] Started
    /// Milestone assigned starts in the future (start date > today). This differs from the behavior in the [REST API implementation](https://docs.gitlab.com/api/issues/#list-issues).
    | [<CompiledName "UPCOMING">] Upcoming

/// Field names for ordering machine learning model versions
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MlModelVersionsOrderBy =
    /// Ordered by name.
    | [<CompiledName "VERSION">] Version
    /// Ordered by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Ordered by id.
    | [<CompiledName "ID">] Id

/// Values for ordering machine learning models by a specific field
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MlModelsOrderBy =
    /// Ordered by name.
    | [<CompiledName "NAME">] Name
    /// Ordered by creation time.
    | [<CompiledName "CREATED_AT">] CreatedAt
    /// Ordered by update time.
    | [<CompiledName "UPDATED_AT">] UpdatedAt
    /// Ordered by id.
    | [<CompiledName "ID">] Id

/// The position to which the adjacent object should be moved
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MoveType =
    /// Adjacent object is moved before the object that is being moved.
    | [<CompiledName "before">] Before
    /// Adjacent object is moved after the object that is being moved.
    | [<CompiledName "after">] After

/// Different toggles for changing mutator behavior
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type MutationOperationMode =
    /// Performs a replace operation.
    | [<CompiledName "REPLACE">] Replace
    /// Performs an append operation.
    | [<CompiledName "APPEND">] Append
    /// Performs a removal operation.
    | [<CompiledName "REMOVE">] Remove

/// Possible filter types for remote development cluster agents in a namespace
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NamespaceClusterAgentFilter =
    /// Cluster agents in the namespace that can be used for hosting workspaces.
    | [<CompiledName "AVAILABLE">] Available
    /// Cluster agents that are directly mapped to the given namespace.
    | [<CompiledName "DIRECTLY_MAPPED">] DirectlyMapped
    /// Cluster agents within a namespace that are not directly mapped to it.
    | [<CompiledName "UNMAPPED">] Unmapped
    /// All cluster agents in the namespace that can be used for hosting worksapces.
    | [<CompiledName "ALL">] All

/// Values for sorting projects
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NamespaceProjectSort =
    /// Most similar to the search query.
    | [<CompiledName "SIMILARITY">] Similarity
    /// Sort by latest activity, descending order.
    | [<CompiledName "ACTIVITY_DESC">] ActivityDesc
    /// Sort by total storage size, ascending order.
    | [<CompiledName "STORAGE_SIZE_ASC">] StorageSizeAsc
    /// Sort by total storage size, descending order.
    | [<CompiledName "STORAGE_SIZE_DESC">] StorageSizeDesc
    /// Sort by path, ascending order.
    | [<CompiledName "PATH_ASC">] PathAsc
    /// Sort by path, descending order.
    | [<CompiledName "PATH_DESC">] PathDesc
    /// Sort by full path, ascending order.
    | [<CompiledName "FULL_PATH_ASC">] FullPathAsc
    /// Sort by full path, descending order.
    | [<CompiledName "FULL_PATH_DESC">] FullPathDesc
    /// Sort by total repository size, ascending order.
    | [<CompiledName "REPOSITORY_SIZE_ASC">] RepositorySizeAsc
    /// Sort by total repository size, descending order.
    | [<CompiledName "REPOSITORY_SIZE_DESC">] RepositorySizeDesc
    /// Sort by total snippet size, ascending order.
    | [<CompiledName "SNIPPETS_SIZE_ASC">] SnippetsSizeAsc
    /// Sort by total snippet size, descending order.
    | [<CompiledName "SNIPPETS_SIZE_DESC">] SnippetsSizeDesc
    /// Sort by total build artifact size, ascending order.
    | [<CompiledName "BUILD_ARTIFACTS_SIZE_ASC">] BuildArtifactsSizeAsc
    /// Sort by total build artifact size, descending order.
    | [<CompiledName "BUILD_ARTIFACTS_SIZE_DESC">] BuildArtifactsSizeDesc
    /// Sort by total LFS object size, ascending order.
    | [<CompiledName "LFS_OBJECTS_SIZE_ASC">] LfsObjectsSizeAsc
    /// Sort by total LFS object size, descending order.
    | [<CompiledName "LFS_OBJECTS_SIZE_DESC">] LfsObjectsSizeDesc
    /// Sort by total package size, ascending order.
    | [<CompiledName "PACKAGES_SIZE_ASC">] PackagesSizeAsc
    /// Sort by total package size, descending order.
    | [<CompiledName "PACKAGES_SIZE_DESC">] PackagesSizeDesc
    /// Sort by total wiki size, ascending order.
    | [<CompiledName "WIKI_SIZE_ASC">] WikiSizeAsc
    /// Sort by total wiki size, descending order.
    | [<CompiledName "WIKI_SIZE_DESC">] WikiSizeDesc
    /// Sort by total container registry size, ascending order.
    | [<CompiledName "CONTAINER_REGISTRY_SIZE_ASC">] ContainerRegistrySizeAsc
    /// Sort by total container registry size, descending order.
    | [<CompiledName "CONTAINER_REGISTRY_SIZE_DESC">] ContainerRegistrySizeDesc
    /// Sort by excess repository storage size, descending order.
    | [<CompiledName "EXCESS_REPO_STORAGE_SIZE_DESC">] ExcessRepoStorageSizeDesc

/// Negated Iteration ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NegatedIterationWildcardId =
    /// Current iteration.
    | [<CompiledName "CURRENT">] Current

/// Negated Milestone ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NegatedMilestoneWildcardId =
    /// Milestone assigned is open and yet to be started (start date > today).
    | [<CompiledName "STARTED">] Started
    /// Milestone assigned is open but starts in the past (start date <= today). This differs from the behavior in the [REST API implementation](https://docs.gitlab.com/api/issues/#list-issues).
    | [<CompiledName "UPCOMING">] Upcoming

/// Work item notes collection type.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type NotesFilterType =
    /// Show all activity
    | [<CompiledName "ALL_NOTES">] AllNotes
    /// Show comments only
    | [<CompiledName "ONLY_COMMENTS">] OnlyComments
    /// Show history only
    | [<CompiledName "ONLY_ACTIVITY">] OnlyActivity

/// Rotation length unit of an on-call rotation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OncallRotationUnitEnum =
    /// Hours
    | [<CompiledName "HOURS">] Hours
    /// Days
    | [<CompiledName "DAYS">] Days
    /// Weeks
    | [<CompiledName "WEEKS">] Weeks

/// Enum defining the type of OpenTelemetry metric
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OpenTelemetryMetricType =
    /// Gauge Type type.
    | [<CompiledName "GAUGE_TYPE">] GaugeType
    /// Sum Type type.
    | [<CompiledName "SUM_TYPE">] SumType
    /// Histogram Type type.
    | [<CompiledName "HISTOGRAM_TYPE">] HistogramType
    /// Exponential Histogram Type type.
    | [<CompiledName "EXPONENTIAL_HISTOGRAM_TYPE">] ExponentialHistogramType

/// Possible filter types for remote development cluster agents in an organization
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationClusterAgentFilter =
    /// Cluster agents that are directly mapped to the given organization.
    | [<CompiledName "DIRECTLY_MAPPED">] DirectlyMapped
    /// All cluster agents in the organization that can be used for hosting workspaces.
    | [<CompiledName "ALL">] All

/// Values for sorting organization groups and projects.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationGroupProjectSort =
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Values for sorting organizations
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type OrganizationSort =
    /// Name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Description in ascending order.
    | [<CompiledName "DESCRIPTION_ASC">] DescriptionAsc
    /// Description in descending order.
    | [<CompiledName "DESCRIPTION_DESC">] DescriptionDesc
    /// Default Rate in ascending order.
    | [<CompiledName "DEFAULT_RATE_ASC">] DefaultRateAsc
    /// Default Rate in descending order.
    | [<CompiledName "DEFAULT_RATE_DESC">] DefaultRateDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageDependencyType =
    /// dependencies dependency type
    | [<CompiledName "DEPENDENCIES">] Dependencies
    /// devDependencies dependency type
    | [<CompiledName "DEV_DEPENDENCIES">] DevDependencies
    /// bundleDependencies dependency type
    | [<CompiledName "BUNDLE_DEPENDENCIES">] BundleDependencies
    /// peerDependencies dependency type
    | [<CompiledName "PEER_DEPENDENCIES">] PeerDependencies

/// Values for sorting group packages
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageGroupSort =
    /// Ordered by project path in descending order.
    | [<CompiledName "PROJECT_PATH_DESC">] ProjectPathDesc
    /// Ordered by project path in ascending order.
    | [<CompiledName "PROJECT_PATH_ASC">] ProjectPathAsc
    /// Ordered by created_at in descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Ordered by created_at in ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Ordered by name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Ordered by name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Ordered by version in descending order.
    | [<CompiledName "VERSION_DESC">] VersionDesc
    /// Ordered by version in ascending order.
    | [<CompiledName "VERSION_ASC">] VersionAsc
    /// Ordered by type in descending order.
    | [<CompiledName "TYPE_DESC">] TypeDesc
    /// Ordered by type in ascending order.
    | [<CompiledName "TYPE_ASC">] TypeAsc

/// Values for package manager
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageManager =
    /// Package manager: bundler.
    | [<CompiledName "BUNDLER">] Bundler
    /// Package manager: yarn.
    | [<CompiledName "YARN">] Yarn
    /// Package manager: npm.
    | [<CompiledName "NPM">] Npm
    /// Package manager: pnpm.
    | [<CompiledName "PNPM">] Pnpm
    /// Package manager: maven.
    | [<CompiledName "MAVEN">] Maven
    /// Package manager: composer.
    | [<CompiledName "COMPOSER">] Composer
    /// Package manager: pip.
    | [<CompiledName "PIP">] Pip
    /// Package manager: conan.
    | [<CompiledName "CONAN">] Conan
    /// Package manager: go.
    | [<CompiledName "GO">] Go
    /// Package manager: nuget.
    | [<CompiledName "NUGET">] Nuget
    /// Package manager: sbt.
    | [<CompiledName "SBT">] Sbt
    /// Package manager: gradle.
    | [<CompiledName "GRADLE">] Gradle
    /// Package manager: pipenv.
    | [<CompiledName "PIPENV">] Pipenv
    /// Package manager: poetry.
    | [<CompiledName "POETRY">] Poetry
    /// Package manager: setuptools.
    | [<CompiledName "SETUPTOOLS">] Setuptools
    /// Package manager: apk.
    | [<CompiledName "APK">] Apk
    /// Package manager: conda.
    | [<CompiledName "CONDA">] Conda
    /// Package manager: pub.
    | [<CompiledName "PUB">] Pub
    /// Package manager: cargo.
    | [<CompiledName "CARGO">] Cargo

/// Values for sorting package
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageSort =
    /// Ordered by created_at in descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Ordered by created_at in ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Ordered by name in descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Ordered by name in ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Ordered by version in descending order.
    | [<CompiledName "VERSION_DESC">] VersionDesc
    /// Ordered by version in ascending order.
    | [<CompiledName "VERSION_ASC">] VersionAsc
    /// Ordered by type in descending order.
    | [<CompiledName "TYPE_DESC">] TypeDesc
    /// Ordered by type in ascending order.
    | [<CompiledName "TYPE_ASC">] TypeAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageStatus =
    /// Packages with a default status
    | [<CompiledName "DEFAULT">] Default
    /// Packages with a hidden status
    | [<CompiledName "HIDDEN">] Hidden
    /// Packages with a processing status
    | [<CompiledName "PROCESSING">] Processing
    /// Packages with a error status
    | [<CompiledName "ERROR">] Error
    /// Packages with a pending_destruction status
    | [<CompiledName "PENDING_DESTRUCTION">] PendingDestruction
    /// Packages with a deprecated status
    | [<CompiledName "DEPRECATED">] Deprecated

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackageTypeEnum =
    /// Packages from the Maven package manager
    | [<CompiledName "MAVEN">] Maven
    /// Packages from the npm package manager
    | [<CompiledName "NPM">] Npm
    /// Packages from the Conan package manager
    | [<CompiledName "CONAN">] Conan
    /// Packages from the Nuget package manager
    | [<CompiledName "NUGET">] Nuget
    /// Packages from the PyPI package manager
    | [<CompiledName "PYPI">] Pypi
    /// Packages from the Composer package manager
    | [<CompiledName "COMPOSER">] Composer
    /// Packages from the Generic package manager
    | [<CompiledName "GENERIC">] Generic
    /// Packages from the Golang package manager
    | [<CompiledName "GOLANG">] Golang
    /// Packages from the Debian package manager
    | [<CompiledName "DEBIAN">] Debian
    /// Packages from the Rubygems package manager
    | [<CompiledName "RUBYGEMS">] Rubygems
    /// Packages from the Helm package manager
    | [<CompiledName "HELM">] Helm
    /// Packages from the Terraform Module package manager
    | [<CompiledName "TERRAFORM_MODULE">] TerraformModule
    /// Packages from the Rpm package manager
    | [<CompiledName "RPM">] Rpm
    /// Packages from the Ml_model package manager
    | [<CompiledName "ML_MODEL">] MlModel
    /// Packages from the Cargo package manager
    | [<CompiledName "CARGO">] Cargo

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackagesCleanupKeepDuplicatedPackageFilesEnum =
    /// Value to keep all package files
    | [<CompiledName "ALL_PACKAGE_FILES">] AllPackageFiles
    /// Value to keep 1 package files
    | [<CompiledName "ONE_PACKAGE_FILE">] OnePackageFile
    /// Value to keep 10 package files
    | [<CompiledName "TEN_PACKAGE_FILES">] TenPackageFiles
    /// Value to keep 20 package files
    | [<CompiledName "TWENTY_PACKAGE_FILES">] TwentyPackageFiles
    /// Value to keep 30 package files
    | [<CompiledName "THIRTY_PACKAGE_FILES">] ThirtyPackageFiles
    /// Value to keep 40 package files
    | [<CompiledName "FORTY_PACKAGE_FILES">] FortyPackageFiles
    /// Value to keep 50 package files
    | [<CompiledName "FIFTY_PACKAGE_FILES">] FiftyPackageFiles

/// Access level of a package protection rule resource
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackagesProtectionRuleAccessLevel =
    /// Maintainer access.
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner access.
    | [<CompiledName "OWNER">] Owner
    /// Admin access.
    | [<CompiledName "ADMIN">] Admin

/// Access level for the deletion of a package protection rule resource.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackagesProtectionRuleAccessLevelForDelete =
    /// Owner access. Available only when feature flag `packages_protected_packages_delete` is enabled.
    | [<CompiledName "OWNER">] Owner
    /// Admin access. Available only when feature flag `packages_protected_packages_delete` is enabled.
    | [<CompiledName "ADMIN">] Admin

/// Package type of a package protection rule resource
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PackagesProtectionRulePackageType =
    /// Packages of the Conan format.
    | [<CompiledName "CONAN">] Conan
    /// Packages of the Helm format.
    | [<CompiledName "HELM">] Helm
    /// Packages of the Generic format.
    | [<CompiledName "GENERIC">] Generic
    /// Packages of the Maven format.
    | [<CompiledName "MAVEN">] Maven
    /// Packages of the npm format.
    | [<CompiledName "NPM">] Npm
    /// Packages of the NuGet format.
    | [<CompiledName "NUGET">] Nuget
    /// Packages of the PyPI format.
    | [<CompiledName "PYPI">] Pypi

/// Type of resource that the permission can be applied to.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PermissionBoundary =
    /// Group.
    | [<CompiledName "GROUP">] Group
    /// Project.
    | [<CompiledName "PROJECT">] Project
    /// User.
    | [<CompiledName "USER">] User
    /// Instance.
    | [<CompiledName "INSTANCE">] Instance

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineAnalyticsJobStatus =
    /// Jobs with any status.
    | [<CompiledName "ANY">] Any
    /// Job that failed.
    | [<CompiledName "FAILED">] Failed
    /// Job that succeeded.
    | [<CompiledName "SUCCESS">] Success
    /// Job that was canceled or skipped.
    | [<CompiledName "OTHER">] Other

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineConfigSourceEnum =
    /// Unknown source.
    | [<CompiledName "UNKNOWN_SOURCE">] UnknownSource
    /// Repository source.
    | [<CompiledName "REPOSITORY_SOURCE">] RepositorySource
    /// Auto DevOps source.
    | [<CompiledName "AUTO_DEVOPS_SOURCE">] AutoDevopsSource
    /// Webide source.
    | [<CompiledName "WEBIDE_SOURCE">] WebideSource
    /// Remote source.
    | [<CompiledName "REMOTE_SOURCE">] RemoteSource
    /// External project source.
    | [<CompiledName "EXTERNAL_PROJECT_SOURCE">] ExternalProjectSource
    /// Bridge source.
    | [<CompiledName "BRIDGE_SOURCE">] BridgeSource
    /// Parameter source.
    | [<CompiledName "PARAMETER_SOURCE">] ParameterSource
    /// Compliance source.
    | [<CompiledName "COMPLIANCE_SOURCE">] ComplianceSource
    /// Security policies default source.
    | [<CompiledName "SECURITY_POLICIES_DEFAULT_SOURCE">] SecurityPoliciesDefaultSource
    /// Pipeline execution policy forced.
    | [<CompiledName "PIPELINE_EXECUTION_POLICY_FORCED">] PipelineExecutionPolicyForced

/// Event type of the pipeline associated with a merge request
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineMergeRequestEventType =
    /// Pipeline run on the changes from the source branch combined with the target branch.
    | [<CompiledName "MERGED_RESULT">] MergedResult
    /// Pipeline run on the changes in the merge request source branch.
    | [<CompiledName "DETACHED">] Detached
    /// Pipeline ran as part of a merge train.
    | [<CompiledName "MERGE_TRAIN">] MergeTrain

/// Values for sorting pipeline schedules.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineScheduleSort =
    /// Sort pipeline schedules by ID in descending order.
    | [<CompiledName "ID_DESC">] IdDesc
    /// Sort pipeline schedules by ID in ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// Sort pipeline schedules by description in descending order.
    | [<CompiledName "DESCRIPTION_DESC">] DescriptionDesc
    /// Sort pipeline schedules by description in ascending order.
    | [<CompiledName "DESCRIPTION_ASC">] DescriptionAsc
    /// Sort pipeline schedules by target in descending order.
    | [<CompiledName "REF_DESC">] RefDesc
    /// Sort pipeline schedules by target in ascending order.
    | [<CompiledName "REF_ASC">] RefAsc
    /// Sort pipeline schedules by next run in descending order.
    | [<CompiledName "NEXT_RUN_AT_DESC">] NextRunAtDesc
    /// Sort pipeline schedules by next run in ascending order.
    | [<CompiledName "NEXT_RUN_AT_ASC">] NextRunAtAsc
    /// Sort pipeline schedules by created date in descending order.
    | [<CompiledName "CREATED_AT_DESC">] CreatedAtDesc
    /// Sort pipeline schedules by created date in ascending order.
    | [<CompiledName "CREATED_AT_ASC">] CreatedAtAsc
    /// Sort pipeline schedules by updated date in descending order.
    | [<CompiledName "UPDATED_AT_DESC">] UpdatedAtDesc
    /// Sort pipeline schedules by updated date in ascending order.
    | [<CompiledName "UPDATED_AT_ASC">] UpdatedAtAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineScheduleStatus =
    /// Active pipeline schedules.
    | [<CompiledName "ACTIVE">] Active
    /// Inactive pipeline schedules.
    | [<CompiledName "INACTIVE">] Inactive

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineScopeEnum =
    /// Pipeline is running.
    | [<CompiledName "RUNNING">] Running
    /// Pipeline has not started running yet.
    | [<CompiledName "PENDING">] Pending
    /// Pipeline has completed.
    | [<CompiledName "FINISHED">] Finished
    /// Branches.
    | [<CompiledName "BRANCHES">] Branches
    /// Tags.
    | [<CompiledName "TAGS">] TAGS

/// Pipeline security report finding sort values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineSecurityReportFindingSort =
    /// Severity in descending order.
    | [<CompiledName "severity_desc">] SeverityDesc
    /// Severity in ascending order.
    | [<CompiledName "severity_asc">] SeverityAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineStatusEnum =
    /// Pipeline has been created.
    | [<CompiledName "CREATED">] Created
    /// A resource (for example, a runner) that the pipeline requires to run is unavailable.
    | [<CompiledName "WAITING_FOR_RESOURCE">] WaitingForResource
    /// Pipeline is preparing to run.
    | [<CompiledName "PREPARING">] Preparing
    /// Pipeline is waiting for an external action.
    | [<CompiledName "WAITING_FOR_CALLBACK">] WaitingForCallback
    /// Pipeline has not started running yet.
    | [<CompiledName "PENDING">] Pending
    /// Pipeline is running.
    | [<CompiledName "RUNNING">] Running
    /// At least one stage of the pipeline failed.
    | [<CompiledName "FAILED">] Failed
    /// Pipeline completed successfully.
    | [<CompiledName "SUCCESS">] Success
    /// Pipeline is in the process of canceling.
    | [<CompiledName "CANCELING">] Canceling
    /// Pipeline was canceled before completion.
    | [<CompiledName "CANCELED">] Canceled
    /// Pipeline was skipped.
    | [<CompiledName "SKIPPED">] Skipped
    /// Pipeline needs to be manually started.
    | [<CompiledName "MANUAL">] Manual
    /// Pipeline is scheduled to run.
    | [<CompiledName "SCHEDULED">] Scheduled

/// Pipeline variables minimum override roles.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PipelineVariablesDefaultRoleType =
    /// No one allowed
    | [<CompiledName "NO_ONE_ALLOWED">] NoOneAllowed
    /// Developer
    | [<CompiledName "DEVELOPER">] Developer
    /// Maintainer
    | [<CompiledName "MAINTAINER">] Maintainer
    /// Owner
    | [<CompiledName "OWNER">] Owner

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyEnforcementType =
    /// Represents an enforced policy type.
    | [<CompiledName "ENFORCE">] Enforce
    /// Represents a warn mode policy type.
    | [<CompiledName "WARN">] Warn

/// Types of security policy project created status.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyProjectCreatedStatus =
    /// Creating the security policy project was successful.
    | [<CompiledName "SUCCESS">] Success
    /// Creating the security policy project faild.
    | [<CompiledName "ERROR">] Error

/// Lists the status of a virtual registry cleanup policy
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyStatus =
    /// Cleanup policy status scheduled.
    | [<CompiledName "SCHEDULED">] Scheduled
    /// Cleanup policy status running.
    | [<CompiledName "RUNNING">] Running
    /// Cleanup policy status failed.
    | [<CompiledName "FAILED">] Failed

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyType =
    /// Approval policy.
    | [<CompiledName "APPROVAL_POLICY">] ApprovalPolicy
    /// Scan execution policy.
    | [<CompiledName "SCAN_EXECUTION_POLICY">] ScanExecutionPolicy
    /// Pipeline execution policy.
    | [<CompiledName "PIPELINE_EXECUTION_POLICY">] PipelineExecutionPolicy
    /// Pipeline execution schedule policy.
    | [<CompiledName "PIPELINE_EXECUTION_SCHEDULE_POLICY">] PipelineExecutionSchedulePolicy
    /// Vulnerability management policy.
    | [<CompiledName "VULNERABILITY_MANAGEMENT_POLICY">] VulnerabilityManagementPolicy

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyViolationErrorType =
    /// Represents mismatch between the scans of the source and target pipelines.
    | [<CompiledName "SCAN_REMOVED">] ScanRemoved
    /// Represents error which occurs when pipeline is misconfigured and does not include necessary artifacts to evaluate a policy.
    | [<CompiledName "ARTIFACTS_MISSING">] ArtifactsMissing
    /// Represents unknown error.
    | [<CompiledName "UNKNOWN">] Unknown

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyViolationStatus =
    /// Represents a failed policy violation.
    | [<CompiledName "FAILED">] Failed
    /// Represents a running policy violation.
    | [<CompiledName "RUNNING">] Running
    /// Represents a policy violation warning.
    | [<CompiledName "WARNING">] Warning

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PolicyViolations =
    /// Dismissed in Merge request bypass reason.
    | [<CompiledName "DISMISSED_IN_MR">] DismissedInMr

/// Types of principal that can have secret permissions
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type PrincipalType =
    /// user.
    | [<CompiledName "USER">] User
    /// group.
    | [<CompiledName "GROUP">] Group
    /// member role.
    | [<CompiledName "MEMBER_ROLE">] MemberRole
    /// predefined role.
    | [<CompiledName "ROLE">] Role

/// Current state of the product analytics stack.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProductAnalyticsState =
    /// Stack has not been created yet.
    | [<CompiledName "CREATE_INSTANCE">] CreateInstance
    /// Stack is currently initializing.
    | [<CompiledName "LOADING_INSTANCE">] LoadingInstance
    /// Stack is waiting for events from users.
    | [<CompiledName "WAITING_FOR_EVENTS">] WaitingForEvents
    /// Stack has been initialized and has data.
    | [<CompiledName "COMPLETE">] Complete

/// Values for the archived argument
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectArchived =
    /// Only archived projects.
    | [<CompiledName "ONLY">] Only
    /// Include archived projects.
    | [<CompiledName "INCLUDE">] Include
    /// Exclude archived projects.
    | [<CompiledName "EXCLUDE">] Exclude

/// Compliance status of the project control.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectComplianceControlStatus =
    /// Pass
    | [<CompiledName "PASS">] Pass
    /// Fail
    | [<CompiledName "FAIL">] Fail
    /// Pending
    | [<CompiledName "PENDING">] Pending

/// Values for order_by field for project requirement statuses.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectComplianceRequirementStatusOrderBy =
    /// Order by projects.
    | [<CompiledName "PROJECT">] Project
    /// Order by requirements.
    | [<CompiledName "REQUIREMENT">] Requirement
    /// Order by frameworks.
    | [<CompiledName "FRAMEWORK">] Framework

/// Access level of a project feature
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectFeatureAccessLevel =
    /// Not enabled for anyone.
    | [<CompiledName "DISABLED">] Disabled
    /// Enabled only for team members.
    | [<CompiledName "PRIVATE">] Private
    /// Enabled for everyone able to access the project.
    | [<CompiledName "ENABLED">] Enabled

/// Project member relation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectMemberRelation =
    /// Direct members
    | [<CompiledName "DIRECT">] Direct
    /// Inherited members
    | [<CompiledName "INHERITED">] Inherited
    /// Descendants members
    | [<CompiledName "DESCENDANTS">] Descendants
    /// Invited Groups members
    | [<CompiledName "INVITED_GROUPS">] InvitedGroups
    /// Shared Into Ancestors members
    | [<CompiledName "SHARED_INTO_ANCESTORS">] SharedIntoAncestors

/// Status of project secret
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectSecretStatus =
    /// Secret is complete.
    | [<CompiledName "COMPLETED">] Completed
    /// Secret creation appears stale (started long ago or missing completion timestamp).
    | [<CompiledName "CREATE_STALE">] CreateStale
    /// Secret update appears stale (started long ago or missing completion timestamp).
    | [<CompiledName "UPDATE_STALE">] UpdateStale
    /// Secret creation is in progress.
    | [<CompiledName "CREATE_IN_PROGRESS">] CreateInProgress
    /// Secret update is in progress.
    | [<CompiledName "UPDATE_IN_PROGRESS">] UpdateInProgress

/// Values for the project secrets manager status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectSecretsManagerStatus =
    /// Secrets manager is being provisioned.
    | [<CompiledName "PROVISIONING">] Provisioning
    /// Secrets manager has been provisioned and enabled.
    | [<CompiledName "ACTIVE">] Active
    /// Secrets manager is being deprovisioned.
    | [<CompiledName "DEPROVISIONING">] Deprovisioning

/// Values for sorting projects
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ProjectSort =
    /// ID by ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// ID by descending order.
    | [<CompiledName "ID_DESC">] IdDesc
    /// Latest activity by ascending order.
    | [<CompiledName "LATEST_ACTIVITY_ASC">] LatestActivityAsc
    /// Latest activity by descending order.
    | [<CompiledName "LATEST_ACTIVITY_DESC">] LatestActivityDesc
    /// Name by ascending order.
    | [<CompiledName "NAME_ASC">] NameAsc
    /// Name by descending order.
    | [<CompiledName "NAME_DESC">] NameDesc
    /// Path by ascending order.
    | [<CompiledName "PATH_ASC">] PathAsc
    /// Path by descending order.
    | [<CompiledName "PATH_DESC">] PathDesc
    /// Stars by ascending order.
    | [<CompiledName "STARS_ASC">] StarsAsc
    /// Stars by descending order.
    | [<CompiledName "STARS_DESC">] StarsDesc
    /// Storage size by ascending order.
    | [<CompiledName "STORAGE_SIZE_ASC">] StorageSizeAsc
    /// Storage size by descending order.
    | [<CompiledName "STORAGE_SIZE_DESC">] StorageSizeDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Dependency reachability status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReachabilityType =
    /// Dependency reachability status is not available.
    | [<CompiledName "UNKNOWN">] Unknown
    /// Dependency is imported and in use.
    | [<CompiledName "IN_USE">] InUse
    /// Dependency is not in use.
    | [<CompiledName "NOT_FOUND">] NotFound

/// Type of ref
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RefType =
    /// Ref type for branches.
    | [<CompiledName "HEADS">] Heads
    /// Ref type for tags.
    | [<CompiledName "TAGS">] TAGS

/// State of a Geo registry
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RegistryState =
    /// Registry waiting to be synced.
    | [<CompiledName "PENDING">] Pending
    /// Registry currently syncing.
    | [<CompiledName "STARTED">] Started
    /// Registry that is synced.
    | [<CompiledName "SYNCED">] Synced
    /// Registry that failed to sync.
    | [<CompiledName "FAILED">] Failed

/// Relationship of the policies to resync.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RelationshipType =
    /// Policies defined for the project/group only.
    | [<CompiledName "DIRECT">] Direct
    /// Policies defined for the project/group and ancestor groups.
    | [<CompiledName "INHERITED">] Inherited

/// The position to which the object should be moved
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RelativePositionType =
    /// Object is moved before an adjacent object.
    | [<CompiledName "BEFORE">] Before
    /// Object is moved after an adjacent object.
    | [<CompiledName "AFTER">] After

/// Type of the link: `other`, `runbook`, `image`, `package`
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReleaseAssetLinkType =
    /// Other link type
    | [<CompiledName "OTHER">] Other
    /// Runbook link type
    | [<CompiledName "RUNBOOK">] Runbook
    /// Package link type
    | [<CompiledName "PACKAGE">] Package
    /// Image link type
    | [<CompiledName "IMAGE">] Image

/// Values for sorting releases
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReleaseSort =
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Released at by descending order.
    | [<CompiledName "RELEASED_AT_DESC">] ReleasedAtDesc
    /// Released at by ascending order.
    | [<CompiledName "RELEASED_AT_ASC">] ReleasedAtAsc

/// Release tag ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReleaseTagWildcardId =
    /// No release tag is assigned.
    | [<CompiledName "NONE">] None
    /// Release tag is assigned.
    | [<CompiledName "ANY">] Any

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReplicationStateEnum =
    /// Replication process has not started.
    | [<CompiledName "PENDING">] Pending
    /// Replication process is in progress.
    | [<CompiledName "STARTED">] Started
    /// Replication process finished successfully.
    | [<CompiledName "SYNCED">] Synced
    /// Replication process finished but failed.
    | [<CompiledName "FAILED">] Failed

/// State of a requirement
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RequirementState =
    /// Open requirement.
    | [<CompiledName "OPENED">] Opened
    /// Archived requirement.
    | [<CompiledName "ARCHIVED">] Archived

/// Status of a requirement based on last test report
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RequirementStatusFilter =
    /// Requirements without any test report.
    | [<CompiledName "MISSING">] Missing
    /// Passed test report.
    | [<CompiledName "PASSED">] Passed
    /// Failed test report.
    | [<CompiledName "FAILED">] Failed

/// Process mode for resource groups
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ResourceGroupsProcessMode =
    /// Unordered.
    | [<CompiledName "UNORDERED">] Unordered
    /// Oldest first.
    | [<CompiledName "OLDEST_FIRST">] OldestFirst
    /// Newest first.
    | [<CompiledName "NEWEST_FIRST">] NewestFirst
    /// Newest ready first.
    | [<CompiledName "NEWEST_READY_FIRST">] NewestReadyFirst

/// Reviewer ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ReviewerWildcardId =
    /// No reviewer is assigned.
    | [<CompiledName "NONE">] None
    /// Any reviewer is assigned.
    | [<CompiledName "ANY">] Any

/// Risk rating levels based on score ranges
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type RiskRating =
    /// Low risk (0–25).
    | [<CompiledName "LOW">] Low
    /// Medium risk (26–50).
    | [<CompiledName "MEDIUM">] Medium
    /// High risk (51–75).
    | [<CompiledName "HIGH">] High
    /// Critical risk (76–100).
    | [<CompiledName "CRITICAL">] Critical
    /// Unknown risk level.
    | [<CompiledName "UNKNOWN">] Unknown

/// Size of UI component in SAST configuration page
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SastUiComponentSize =
    /// Size of UI component in SAST configuration page is small.
    | [<CompiledName "SMALL">] Small
    /// Size of UI component in SAST configuration page is medium.
    | [<CompiledName "MEDIUM">] Medium
    /// Size of UI component in SAST configuration page is large.
    | [<CompiledName "LARGE">] Large

/// Values for sbom source types
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SbomSourceType =
    /// Source Type: container_scanning_for_registry.
    | [<CompiledName "CONTAINER_SCANNING_FOR_REGISTRY">] ContainerScanningForRegistry
    /// Source Type: dependency_scanning.
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// Source Type: container_scanning.
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// Enum source nil.
    | [<CompiledName "NIL_SOURCE">] NilSource

/// Options for filtering by scan mode.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ScanModeEnum =
    /// Return results from all scans.
    | [<CompiledName "ALL">] All
    /// Return results from full scans.
    | [<CompiledName "FULL">] Full
    /// Return results from partial scans.
    | [<CompiledName "PARTIAL">] Partial

/// The status of the security scan
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ScanStatus =
    /// The scan has been created.
    | [<CompiledName "CREATED">] Created
    /// The report has been successfully prepared.
    | [<CompiledName "SUCCEEDED">] Succeeded
    /// The related CI build failed.
    | [<CompiledName "JOB_FAILED">] JobFailed
    /// The report artifact provided by the CI build couldn't be parsed.
    | [<CompiledName "REPORT_ERROR">] ReportError
    /// Preparing the report for the scan.
    | [<CompiledName "PREPARING">] Preparing
    /// Report couldn't be prepared.
    | [<CompiledName "PREPARATION_FAILED">] PreparationFailed
    /// Report for the scan has been removed from the database.
    | [<CompiledName "PURGED">] Purged

/// Level of search
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SearchLevel =
    /// Project search.
    | [<CompiledName "PROJECT">] Project
    /// Group search.
    | [<CompiledName "GROUP">] Group
    /// Global search including all groups and projects.
    | [<CompiledName "GLOBAL">] Global

/// Type of search
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SearchType =
    /// Basic search.
    | [<CompiledName "BASIC">] Basic
    /// Advanced search.
    | [<CompiledName "ADVANCED">] Advanced
    /// Exact code search.
    | [<CompiledName "ZOEKT">] Zoekt

/// Status of secret rotation
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecretRotationStatus =
    /// Rotation is not due soon.
    | [<CompiledName "OK">] Ok
    /// Rotation is due within 7 days.
    | [<CompiledName "APPROACHING">] Approaching
    /// Rotation is overdue (reminder was sent).
    | [<CompiledName "OVERDUE">] Overdue

/// Mode for bulk updating security attributes
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityAttributeBulkUpdateMode =
    /// Add attributes to projects (keeps existing attributes).
    | [<CompiledName "ADD">] Add
    /// Remove attributes from projects.
    | [<CompiledName "REMOVE">] Remove
    /// Replace all existing attributes with the specified attributes.
    | [<CompiledName "REPLACE">] Replace

/// Editable state for security categories and attributes
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityCategoryEditableState =
    /// Locked state.
    | [<CompiledName "LOCKED">] Locked
    /// Editable attributes state.
    | [<CompiledName "EDITABLE_ATTRIBUTES">] EditableAttributes
    /// Editable state.
    | [<CompiledName "EDITABLE">] Editable

/// Template type for predefined security categories
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityCategoryTemplateType =
    /// Business impact category.
    | [<CompiledName "BUSINESS_IMPACT">] BusinessImpact
    /// Business unit category.
    | [<CompiledName "BUSINESS_UNIT">] BusinessUnit
    /// Application category.
    | [<CompiledName "APPLICATION">] Application
    /// Exposure category.
    | [<CompiledName "EXPOSURE">] Exposure

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityPolicyRelationType =
    /// Policies defined for the project/group only.
    | [<CompiledName "DIRECT">] Direct
    /// Policies defined for the project/group and ancestor groups.
    | [<CompiledName "INHERITED">] Inherited
    /// Policies defined for the project/group's ancestor groups only.
    | [<CompiledName "INHERITED_ONLY">] InheritedOnly
    /// Policies defined for the group's descendant projects/groups only. Only valid for group-level policies.
    | [<CompiledName "DESCENDANT">] Descendant

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityPreferredLicenseSourceConfiguration =
    /// Use the SBOM as a source of license information for dependencies.
    | [<CompiledName "SBOM">] Sbom
    /// Use internal instance license database as a source of license information for dependencies.
    | [<CompiledName "PMDB">] Pmdb

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityReportTypeEnum =
    /// SAST scan report
    | [<CompiledName "SAST">] Sast
    /// SAST ADVANCED scan report
    | [<CompiledName "SAST_ADVANCED">] SastAdvanced
    /// SAST IAC scan report
    | [<CompiledName "SAST_IAC">] SastIac
    /// DAST scan report
    | [<CompiledName "DAST">] Dast
    /// DEPENDENCY SCANNING scan report
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// CONTAINER SCANNING scan report
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// SECRET DETECTION scan report
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// COVERAGE FUZZING scan report
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// API FUZZING scan report
    | [<CompiledName "API_FUZZING">] ApiFuzzing
    /// CLUSTER IMAGE SCANNING scan report
    | [<CompiledName "CLUSTER_IMAGE_SCANNING">] ClusterImageScanning

/// Scan profile type
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityScanProfileType =
    /// Sast
    | [<CompiledName "SAST">] Sast
    /// Secret detection
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// Container scanning
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// Dependency scanning
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning

/// The type of the security scanner
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SecurityScannerType =
    /// SAST scanner
    | [<CompiledName "SAST">] Sast
    /// SAST advanced scanner
    | [<CompiledName "SAST_ADVANCED">] SastAdvanced
    /// SAST IaC scanner
    | [<CompiledName "SAST_IAC">] SastIac
    /// DAST scanner
    | [<CompiledName "DAST">] Dast
    /// Dependency scanning scanner
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// Container scanning scanner
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// Secret detection scanner
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// Coverage fuzzing scanner
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// API fuzzing scanner
    | [<CompiledName "API_FUZZING">] ApiFuzzing
    /// Cluster image scanning scanner
    | [<CompiledName "CLUSTER_IMAGE_SCANNING">] ClusterImageScanning

/// State of a Sentry error
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SentryErrorStatus =
    /// Error has been resolved.
    | [<CompiledName "RESOLVED">] Resolved
    /// Error has been ignored until next release.
    | [<CompiledName "RESOLVED_IN_NEXT_RELEASE">] ResolvedInNextRelease
    /// Error is unresolved.
    | [<CompiledName "UNRESOLVED">] Unresolved
    /// Error has been ignored.
    | [<CompiledName "IGNORED">] Ignored

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ServiceType =
    /// Apple App Store Connect integration
    | [<CompiledName "APPLE_APP_STORE_SERVICE">] AppleAppStoreService
    /// Asana integration
    | [<CompiledName "ASANA_SERVICE">] AsanaService
    /// Assembla integration
    | [<CompiledName "ASSEMBLA_SERVICE">] AssemblaService
    /// Atlassian Bamboo integration
    | [<CompiledName "BAMBOO_SERVICE">] BambooService
    /// Bugzilla integration
    | [<CompiledName "BUGZILLA_SERVICE">] BugzillaService
    /// Buildkite integration
    | [<CompiledName "BUILDKITE_SERVICE">] BuildkiteService
    /// Campfire integration
    | [<CompiledName "CAMPFIRE_SERVICE">] CampfireService
    /// ClickUp integration
    | [<CompiledName "CLICKUP_SERVICE">] ClickupService
    /// Confluence Workspace integration
    | [<CompiledName "CONFLUENCE_SERVICE">] ConfluenceService
    /// Custom issue tracker integration
    | [<CompiledName "CUSTOM_ISSUE_TRACKER_SERVICE">] CustomIssueTrackerService
    /// Datadog integration
    | [<CompiledName "DATADOG_SERVICE">] DatadogService
    /// Diffblue Cover integration
    | [<CompiledName "DIFFBLUE_COVER_SERVICE">] DiffblueCoverService
    /// Discord Notifications integration
    | [<CompiledName "DISCORD_SERVICE">] DiscordService
    /// Drone integration
    | [<CompiledName "DRONE_CI_SERVICE">] DroneCiService
    /// Emails on push integration
    | [<CompiledName "EMAILS_ON_PUSH_SERVICE">] EmailsOnPushService
    /// EWM integration
    | [<CompiledName "EWM_SERVICE">] EwmService
    /// External wiki integration
    | [<CompiledName "EXTERNAL_WIKI_SERVICE">] ExternalWikiService
    /// GitGuardian integration
    | [<CompiledName "GIT_GUARDIAN_SERVICE">] GitGuardianService
    /// GitHub integration
    | [<CompiledName "GITHUB_SERVICE">] GithubService
    /// GitLab for Slack app integration
    | [<CompiledName "GITLAB_SLACK_APPLICATION_SERVICE">] GitlabSlackApplicationService
    /// Google Artifact Management integration (SaaS only)
    | [<CompiledName "GOOGLE_CLOUD_PLATFORM_ARTIFACT_REGISTRY_SERVICE">] GoogleCloudPlatformArtifactRegistryService
    /// Google Cloud IAM integration (SaaS only)
    | [<CompiledName "GOOGLE_CLOUD_PLATFORM_WORKLOAD_IDENTITY_FEDERATION_SERVICE">] GoogleCloudPlatformWorkloadIdentityFederationService
    /// Google Play integration
    | [<CompiledName "GOOGLE_PLAY_SERVICE">] GooglePlayService
    /// Google Chat integration
    | [<CompiledName "HANGOUTS_CHAT_SERVICE">] HangoutsChatService
    /// Harbor integration
    | [<CompiledName "HARBOR_SERVICE">] HarborService
    /// irker (IRC gateway) integration
    | [<CompiledName "IRKER_SERVICE">] IrkerService
    /// Jenkins integration
    | [<CompiledName "JENKINS_SERVICE">] JenkinsService
    /// Jira issues integration
    | [<CompiledName "JIRA_SERVICE">] JiraService
    /// GitLab for Jira Cloud app integration
    | [<CompiledName "JIRA_CLOUD_APP_SERVICE">] JiraCloudAppService
    /// Linear integration
    | [<CompiledName "LINEAR_SERVICE">] LinearService
    /// Matrix notifications integration
    | [<CompiledName "MATRIX_SERVICE">] MatrixService
    /// Mattermost notifications integration
    | [<CompiledName "MATTERMOST_SERVICE">] MattermostService
    /// Mattermost slash commands integration
    | [<CompiledName "MATTERMOST_SLASH_COMMANDS_SERVICE">] MattermostSlashCommandsService
    /// Microsoft Teams notifications integration
    | [<CompiledName "MICROSOFT_TEAMS_SERVICE">] MicrosoftTeamsService
    /// Packagist integration
    | [<CompiledName "PACKAGIST_SERVICE">] PackagistService
    /// Phorge integration
    | [<CompiledName "PHORGE_SERVICE">] PhorgeService
    /// Pipeline status emails integration
    | [<CompiledName "PIPELINES_EMAIL_SERVICE">] PipelinesEmailService
    /// Pivotal Tracker integration
    | [<CompiledName "PIVOTALTRACKER_SERVICE">] PivotaltrackerService
    /// Pumble integration
    | [<CompiledName "PUMBLE_SERVICE">] PumbleService
    /// Pushover integration
    | [<CompiledName "PUSHOVER_SERVICE">] PushoverService
    /// Redmine integration
    | [<CompiledName "REDMINE_SERVICE">] RedmineService
    /// Slack notifications integration
    | [<CompiledName "SLACK_SERVICE">] SlackService
    /// Slack slash commands integration
    | [<CompiledName "SLACK_SLASH_COMMANDS_SERVICE">] SlackSlashCommandsService
    /// Squash TM integration
    | [<CompiledName "SQUASH_TM_SERVICE">] SquashTmService
    /// JetBrains TeamCity integration
    | [<CompiledName "TEAMCITY_SERVICE">] TeamcityService
    /// Telegram integration
    | [<CompiledName "TELEGRAM_SERVICE">] TelegramService
    /// Unify Circuit integration
    | [<CompiledName "UNIFY_CIRCUIT_SERVICE">] UnifyCircuitService
    /// Webex Teams integration
    | [<CompiledName "WEBEX_TEAMS_SERVICE">] WebexTeamsService
    /// JetBrains YouTrack integration
    | [<CompiledName "YOUTRACK_SERVICE">] YoutrackService
    /// ZenTao integration
    | [<CompiledName "ZENTAO_SERVICE">] ZentaoService

/// How to format SHA strings.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ShaFormat =
    /// Abbreviated format. Short SHAs are typically eight characters long.
    | [<CompiledName "SHORT">] Short
    /// Unabbreviated format.
    | [<CompiledName "LONG">] Long

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SharedRunnersSetting =
    /// Sharing of runners is disabled and unoverridable.
    | [<CompiledName "DISABLED_AND_UNOVERRIDABLE">] DisabledAndUnoverridable
    /// Sharing of runners is disabled and overridable.
    | [<CompiledName "DISABLED_AND_OVERRIDABLE">] DisabledAndOverridable
    /// Sharing of runners is enabled.
    | [<CompiledName "ENABLED">] Enabled

/// Type of a snippet blob input action
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SnippetBlobActionEnum =
    /// Create a snippet blob.
    | [<CompiledName "create">] Create
    /// Update a snippet blob.
    | [<CompiledName "update">] Update
    /// Delete a snippet blob.
    | [<CompiledName "delete">] Delete
    /// Move a snippet blob.
    | [<CompiledName "move">] Move

/// Common sort values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type Sort =
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Values for sort direction
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SortDirectionEnum =
    /// Ascending order.
    | [<CompiledName "ASC">] Asc
    /// Descending order.
    | [<CompiledName "DESC">] Desc

/// Values for sorting the mapping of users on source instance to users on destination instance.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SourceUserSort =
    /// Status of the mapping by ascending order.
    | [<CompiledName "STATUS_ASC">] StatusAsc
    /// Status of the mapping by descending order.
    | [<CompiledName "STATUS_DESC">] StatusDesc
    /// Instance source name by ascending order.
    | [<CompiledName "SOURCE_NAME_ASC">] SourceNameAsc
    /// Instance source name by descending order.
    | [<CompiledName "SOURCE_NAME_DESC">] SourceNameDesc
    /// ID of the source user by ascending order.
    | [<CompiledName "ID_ASC">] IdAsc
    /// ID of the source user by descending order.
    | [<CompiledName "ID_DESC">] IdDesc

/// Options for default squash behaviour for merge requests
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SquashOptionSetting =
    /// Do not allow.
    | [<CompiledName "NEVER">] Never
    /// Allow.
    | [<CompiledName "ALLOWED">] Allowed
    /// Encourage.
    | [<CompiledName "ENCOURAGED">] Encouraged
    /// Require.
    | [<CompiledName "ALWAYS">] Always

/// Types of change for a subscription history record
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SubscriptionHistoryChangeType =
    /// This was the previous state before the subscription was updated.
    | [<CompiledName "GITLAB_SUBSCRIPTION_UPDATED">] GitlabSubscriptionUpdated
    /// This was the previous state before the subscription was destroyed.
    | [<CompiledName "GITLAB_SUBSCRIPTION_DESTROYED">] GitlabSubscriptionDestroyed

/// Status of the subscription to an issuable.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type SubscriptionStatus =
    /// User is explicitly subscribed to the issuable.
    | [<CompiledName "EXPLICITLY_SUBSCRIBED">] ExplicitlySubscribed
    /// User is explicitly unsubscribed from the issuable.
    | [<CompiledName "EXPLICITLY_UNSUBSCRIBED">] ExplicitlyUnsubscribed

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TestCaseStatus =
    /// Test case that has a status of error.
    | [<CompiledName "error">] Error
    /// Test case that has a status of failed.
    | [<CompiledName "failed">] Failed
    /// Test case that has a status of success.
    | [<CompiledName "success">] Success
    /// Test case that has a status of skipped.
    | [<CompiledName "skipped">] Skipped

/// State of a test report
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TestReportState =
    /// Passed test report.
    | [<CompiledName "PASSED">] Passed
    /// Failed test report.
    | [<CompiledName "FAILED">] Failed

/// Category of error.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TimeboxReportErrorReason =
    /// This type does not support timebox reports.
    | [<CompiledName "UNSUPPORTED">] Unsupported
    /// One or both of start_date and due_date is missing.
    | [<CompiledName "MISSING_DATES">] MissingDates
    /// There are too many events.
    | [<CompiledName "TOO_MANY_EVENTS">] TooManyEvents
    /// Priority by ascending order.
    | [<CompiledName "PRIORITY_ASC">] PriorityAsc
    /// Priority by descending order.
    | [<CompiledName "PRIORITY_DESC">] PriorityDesc
    /// Label priority by ascending order.
    | [<CompiledName "LABEL_PRIORITY_ASC">] LabelPriorityAsc
    /// Label priority by descending order.
    | [<CompiledName "LABEL_PRIORITY_DESC">] LabelPriorityDesc
    /// Milestone due date by ascending order.
    | [<CompiledName "MILESTONE_DUE_ASC">] MilestoneDueAsc
    /// Milestone due date by descending order.
    | [<CompiledName "MILESTONE_DUE_DESC">] MilestoneDueDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

/// Values for sorting timelogs
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TimelogSort =
    /// Spent at ascending order.
    | [<CompiledName "SPENT_AT_ASC">] SpentAtAsc
    /// Spent at descending order.
    | [<CompiledName "SPENT_AT_DESC">] SpentAtDesc
    /// Time spent ascending order.
    | [<CompiledName "TIME_SPENT_ASC">] TimeSpentAsc
    /// Time spent descending order.
    | [<CompiledName "TIME_SPENT_DESC">] TimeSpentDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TodoActionEnum =
    /// Todo action name for assigned.
    | [<CompiledName "assigned">] Assigned
    /// Todo action name for review_requested.
    | [<CompiledName "review_requested">] ReviewRequested
    /// Todo action name for mentioned.
    | [<CompiledName "mentioned">] Mentioned
    /// Todo action name for build_failed.
    | [<CompiledName "build_failed">] BuildFailed
    /// Todo action name for marked.
    | [<CompiledName "marked">] Marked
    /// Todo action name for approval_required.
    | [<CompiledName "approval_required">] ApprovalRequired
    /// Todo action name for unmergeable.
    | [<CompiledName "unmergeable">] Unmergeable
    /// Todo action name for directly_addressed.
    | [<CompiledName "directly_addressed">] DirectlyAddressed
    /// Todo action name for member_access_requested.
    | [<CompiledName "member_access_requested">] MemberAccessRequested
    /// Todo action name for review_submitted.
    | [<CompiledName "review_submitted">] ReviewSubmitted
    /// Todo action name for ssh_key_expired.
    | [<CompiledName "ssh_key_expired">] SshKeyExpired
    /// Todo action name for ssh_key_expiring_soon.
    | [<CompiledName "ssh_key_expiring_soon">] SshKeyExpiringSoon
    /// Todo action name for merge_train_removed.
    | [<CompiledName "merge_train_removed">] MergeTrainRemoved
    /// Todo action name for okr_checkin_requested.
    | [<CompiledName "okr_checkin_requested">] OkrCheckinRequested
    /// Todo action name for added_approver.
    | [<CompiledName "added_approver">] AddedApprover
    /// Todo action name for duo_pro_access_granted.
    | [<CompiledName "duo_pro_access_granted">] DuoProAccessGranted
    /// Todo action name for duo_enterprise_access_granted.
    | [<CompiledName "duo_enterprise_access_granted">] DuoEnterpriseAccessGranted
    /// Todo action name for duo_core_access_granted.
    | [<CompiledName "duo_core_access_granted">] DuoCoreAccessGranted

/// Sort options for todos.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TodoSort =
    /// By label priority in ascending order.
    | [<CompiledName "LABEL_PRIORITY_ASC">] LabelPriorityAsc
    /// By label priority in descending order.
    | [<CompiledName "LABEL_PRIORITY_DESC">] LabelPriorityDesc
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TodoStateEnum =
    /// State of the todo is pending.
    | [<CompiledName "pending">] Pending
    /// State of the todo is done.
    | [<CompiledName "done">] Done

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TodoTargetEnum =
    /// Commit.
    | [<CompiledName "COMMIT">] Commit
    /// Issue.
    | [<CompiledName "ISSUE">] Issue
    /// Work item.
    | [<CompiledName "WORKITEM">] Workitem
    /// Merge request.
    | [<CompiledName "MERGEREQUEST">] Mergerequest
    /// Design.
    | [<CompiledName "DESIGN">] Design
    /// Alert.
    | [<CompiledName "ALERT">] Alert
    /// Project.
    | [<CompiledName "PROJECT">] Project
    /// Namespace.
    | [<CompiledName "NAMESPACE">] Namespace
    /// SSH key.
    | [<CompiledName "KEY">] Key
    /// Wiki page.
    | [<CompiledName "WIKIPAGEMETA">] Wikipagemeta
    /// An Epic.
    | [<CompiledName "EPIC">] Epic
    /// User.
    | [<CompiledName "USER">] User
    /// Vulnerability.
    | [<CompiledName "VULNERABILITY">] Vulnerability
    /// Project Compliance Violation.
    | [<CompiledName "COMPLIANCE_VIOLATION">] ComplianceViolation

/// Status of the request to the training provider. The URL of a TrainingUrl is calculated asynchronously. When PENDING, the URL of the TrainingUrl will be null. When COMPLETED, the URL of the TrainingUrl will be available.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TrainingUrlRequestStatus =
    /// Pending request.
    | [<CompiledName "PENDING">] Pending
    /// Completed request.
    | [<CompiledName "COMPLETED">] Completed

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type TypeEnum =
    /// Snippet created independent of any project.
    | [<CompiledName "personal">] Personal
    /// Snippet related to a specific project.
    | [<CompiledName "project">] Project

/// Name of the feature that the callout is for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserCalloutFeatureNameEnum =
    /// Callout feature name for gke_cluster_integration.
    | [<CompiledName "GKE_CLUSTER_INTEGRATION">] GkeClusterIntegration
    /// Callout feature name for gcp_signup_offer.
    | [<CompiledName "GCP_SIGNUP_OFFER">] GcpSignupOffer
    /// Callout feature name for cluster_security_warning.
    | [<CompiledName "CLUSTER_SECURITY_WARNING">] ClusterSecurityWarning
    /// Callout feature name for ultimate_trial.
    | [<CompiledName "ULTIMATE_TRIAL">] UltimateTrial
    /// Callout feature name for geo_enable_hashed_storage.
    | [<CompiledName "GEO_ENABLE_HASHED_STORAGE">] GeoEnableHashedStorage
    /// Callout feature name for geo_migrate_hashed_storage.
    | [<CompiledName "GEO_MIGRATE_HASHED_STORAGE">] GeoMigrateHashedStorage
    /// Callout feature name for canary_deployment.
    | [<CompiledName "CANARY_DEPLOYMENT">] CanaryDeployment
    /// Callout feature name for gold_trial_billings.
    | [<CompiledName "GOLD_TRIAL_BILLINGS">] GoldTrialBillings
    /// Callout feature name for suggest_popover_dismissed.
    | [<CompiledName "SUGGEST_POPOVER_DISMISSED">] SuggestPopoverDismissed
    /// Callout feature name for tabs_position_highlight.
    | [<CompiledName "TABS_POSITION_HIGHLIGHT">] TabsPositionHighlight
    /// Callout feature name for threat_monitoring_info.
    | [<CompiledName "THREAT_MONITORING_INFO">] ThreatMonitoringInfo
    /// Callout feature name for two_factor_auth_recovery_settings_check.
    | [<CompiledName "TWO_FACTOR_AUTH_RECOVERY_SETTINGS_CHECK">] TwoFactorAuthRecoverySettingsCheck
    /// Callout feature name for web_ide_alert_dismissed.
    | [<CompiledName "WEB_IDE_ALERT_DISMISSED">] WebIdeAlertDismissed
    /// Callout feature name for active_user_count_threshold.
    | [<CompiledName "ACTIVE_USER_COUNT_THRESHOLD">] ActiveUserCountThreshold
    /// Callout feature name for buy_pipeline_minutes_notification_dot.
    | [<CompiledName "BUY_PIPELINE_MINUTES_NOTIFICATION_DOT">] BuyPipelineMinutesNotificationDot
    /// Callout feature name for personal_access_token_expiry.
    | [<CompiledName "PERSONAL_ACCESS_TOKEN_EXPIRY">] PersonalAccessTokenExpiry
    /// Callout feature name for suggest_pipeline.
    | [<CompiledName "SUGGEST_PIPELINE">] SuggestPipeline
    /// Callout feature name for feature_flags_new_version.
    | [<CompiledName "FEATURE_FLAGS_NEW_VERSION">] FeatureFlagsNewVersion
    /// Callout feature name for registration_enabled_callout.
    | [<CompiledName "REGISTRATION_ENABLED_CALLOUT">] RegistrationEnabledCallout
    /// Callout feature name for new_user_signups_cap_reached.
    | [<CompiledName "NEW_USER_SIGNUPS_CAP_REACHED">] NewUserSignupsCapReached
    /// Callout feature name for unfinished_tag_cleanup_callout.
    | [<CompiledName "UNFINISHED_TAG_CLEANUP_CALLOUT">] UnfinishedTagCleanupCallout
    /// Callout feature name for pipeline_needs_banner.
    | [<CompiledName "PIPELINE_NEEDS_BANNER">] PipelineNeedsBanner
    /// Callout feature name for pipeline_needs_hover_tip.
    | [<CompiledName "PIPELINE_NEEDS_HOVER_TIP">] PipelineNeedsHoverTip
    /// Callout feature name for web_ide_ci_environments_guidance.
    | [<CompiledName "WEB_IDE_CI_ENVIRONMENTS_GUIDANCE">] WebIdeCiEnvironmentsGuidance
    /// Callout feature name for security_configuration_upgrade_banner.
    | [<CompiledName "SECURITY_CONFIGURATION_UPGRADE_BANNER">] SecurityConfigurationUpgradeBanner
    /// Callout feature name for trial_status_reminder_d14.
    | [<CompiledName "TRIAL_STATUS_REMINDER_D14">] TrialStatusReminderD14
    /// Callout feature name for trial_status_reminder_d3.
    | [<CompiledName "TRIAL_STATUS_REMINDER_D3">] TrialStatusReminderD3
    /// Callout feature name for security_configuration_devops_alert.
    | [<CompiledName "SECURITY_CONFIGURATION_DEVOPS_ALERT">] SecurityConfigurationDevopsAlert
    /// Callout feature name for profile_personal_access_token_expiry.
    | [<CompiledName "PROFILE_PERSONAL_ACCESS_TOKEN_EXPIRY">] ProfilePersonalAccessTokenExpiry
    /// Callout feature name for terraform_notification_dismissed.
    | [<CompiledName "TERRAFORM_NOTIFICATION_DISMISSED">] TerraformNotificationDismissed
    /// Callout feature name for security_newsletter_callout.
    | [<CompiledName "SECURITY_NEWSLETTER_CALLOUT">] SecurityNewsletterCallout
    /// Callout feature name for verification_reminder.
    | [<CompiledName "VERIFICATION_REMINDER">] VerificationReminder
    /// Callout feature name for ci_deprecation_warning_for_types_keyword.
    | [<CompiledName "CI_DEPRECATION_WARNING_FOR_TYPES_KEYWORD">] CiDeprecationWarningForTypesKeyword
    /// Callout feature name for security_training_feature_promotion.
    | [<CompiledName "SECURITY_TRAINING_FEATURE_PROMOTION">] SecurityTrainingFeaturePromotion
    /// Callout feature name for namespace_storage_pre_enforcement_banner.
    | [<CompiledName "NAMESPACE_STORAGE_PRE_ENFORCEMENT_BANNER">] NamespaceStoragePreEnforcementBanner
    /// Callout feature name for ci_minutes_limit_alert_warning_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_WARNING_STAGE">] CiMinutesLimitAlertWarningStage
    /// Callout feature name for ci_minutes_limit_alert_danger_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_DANGER_STAGE">] CiMinutesLimitAlertDangerStage
    /// Callout feature name for ci_minutes_limit_alert_exceeded_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_EXCEEDED_STAGE">] CiMinutesLimitAlertExceededStage
    /// Callout feature name for preview_user_over_limit_free_plan_alert.
    | [<CompiledName "PREVIEW_USER_OVER_LIMIT_FREE_PLAN_ALERT">] PreviewUserOverLimitFreePlanAlert
    /// Callout feature name for user_reached_limit_free_plan_alert.
    | [<CompiledName "USER_REACHED_LIMIT_FREE_PLAN_ALERT">] UserReachedLimitFreePlanAlert
    /// Callout feature name for submit_license_usage_data_banner.
    | [<CompiledName "SUBMIT_LICENSE_USAGE_DATA_BANNER">] SubmitLicenseUsageDataBanner
    /// Callout feature name for personal_project_limitations_banner.
    | [<CompiledName "PERSONAL_PROJECT_LIMITATIONS_BANNER">] PersonalProjectLimitationsBanner
    /// Callout feature name for namespace_storage_limit_alert_warning_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_WARNING_THRESHOLD">] NamespaceStorageLimitAlertWarningThreshold
    /// Callout feature name for namespace_storage_limit_alert_alert_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_ALERT_THRESHOLD">] NamespaceStorageLimitAlertAlertThreshold
    /// Callout feature name for namespace_storage_limit_alert_error_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_ERROR_THRESHOLD">] NamespaceStorageLimitAlertErrorThreshold
    /// Callout feature name for new_top_level_group_alert.
    | [<CompiledName "NEW_TOP_LEVEL_GROUP_ALERT">] NewTopLevelGroupAlert
    /// Callout feature name for branch_rules_info_callout.
    | [<CompiledName "BRANCH_RULES_INFO_CALLOUT">] BranchRulesInfoCallout
    /// Callout feature name for project_repository_limit_alert_warning_threshold.
    | [<CompiledName "PROJECT_REPOSITORY_LIMIT_ALERT_WARNING_THRESHOLD">] ProjectRepositoryLimitAlertWarningThreshold
    /// Callout feature name for namespace_over_storage_users_combined_alert.
    | [<CompiledName "NAMESPACE_OVER_STORAGE_USERS_COMBINED_ALERT">] NamespaceOverStorageUsersCombinedAlert
    /// Callout feature name for vsd_feedback_banner.
    | [<CompiledName "VSD_FEEDBACK_BANNER">] VsdFeedbackBanner
    /// Callout feature name for security_policy_protected_branch_modification.
    | [<CompiledName "SECURITY_POLICY_PROTECTED_BRANCH_MODIFICATION">] SecurityPolicyProtectedBranchModification
    /// Callout feature name for vulnerability_report_grouping.
    | [<CompiledName "VULNERABILITY_REPORT_GROUPING">] VulnerabilityReportGrouping
    /// Callout feature name for duo_chat_callout.
    | [<CompiledName "DUO_CHAT_CALLOUT">] DuoChatCallout
    /// Callout feature name for joining_a_project_alert.
    | [<CompiledName "JOINING_A_PROJECT_ALERT">] JoiningAProjectAlert
    /// Callout feature name for transition_to_jihu_callout.
    | [<CompiledName "TRANSITION_TO_JIHU_CALLOUT">] TransitionToJihuCallout
    /// Callout feature name for deployment_details_feedback.
    | [<CompiledName "DEPLOYMENT_DETAILS_FEEDBACK">] DeploymentDetailsFeedback
    /// Callout feature name for deployment_approvals_empty_state.
    | [<CompiledName "DEPLOYMENT_APPROVALS_EMPTY_STATE">] DeploymentApprovalsEmptyState
    /// Callout feature name for period_in_terraform_state_name_alert.
    | [<CompiledName "PERIOD_IN_TERRAFORM_STATE_NAME_ALERT">] PeriodInTerraformStateNameAlert
    /// Callout feature name for work_item_epic_feedback.
    | [<CompiledName "WORK_ITEM_EPIC_FEEDBACK">] WorkItemEpicFeedback
    /// Callout feature name for branch_rules_tip_callout.
    | [<CompiledName "BRANCH_RULES_TIP_CALLOUT">] BranchRulesTipCallout
    /// Callout feature name for openssl_callout.
    | [<CompiledName "OPENSSL_CALLOUT">] OpensslCallout
    /// Callout feature name for new_mr_dashboard_banner.
    | [<CompiledName "NEW_MR_DASHBOARD_BANNER">] NewMrDashboardBanner
    /// Callout feature name for pipl_compliance_alert.
    | [<CompiledName "PIPL_COMPLIANCE_ALERT">] PiplComplianceAlert
    /// Callout feature name for new_merge_request_dashboard_welcome.
    | [<CompiledName "NEW_MERGE_REQUEST_DASHBOARD_WELCOME">] NewMergeRequestDashboardWelcome
    /// Callout feature name for pipeline_inputs_announcement_banner.
    | [<CompiledName "PIPELINE_INPUTS_ANNOUNCEMENT_BANNER">] PipelineInputsAnnouncementBanner
    /// Callout feature name for pipeline_new_inputs_adoption_banner.
    | [<CompiledName "PIPELINE_NEW_INPUTS_ADOPTION_BANNER">] PipelineNewInputsAdoptionBanner
    /// Callout feature name for pipeline_schedules_inputs_adoption_banner.
    | [<CompiledName "PIPELINE_SCHEDULES_INPUTS_ADOPTION_BANNER">] PipelineSchedulesInputsAdoptionBanner
    /// Callout feature name for product_usage_data_collection_changes.
    | [<CompiledName "PRODUCT_USAGE_DATA_COLLECTION_CHANGES">] ProductUsageDataCollectionChanges
    /// Callout feature name for dora_dashboard_migration_group.
    | [<CompiledName "DORA_DASHBOARD_MIGRATION_GROUP">] DoraDashboardMigrationGroup
    /// Callout feature name for dora_dashboard_migration_project.
    | [<CompiledName "DORA_DASHBOARD_MIGRATION_PROJECT">] DoraDashboardMigrationProject
    /// Callout feature name for explore_duo_core_banner.
    | [<CompiledName "EXPLORE_DUO_CORE_BANNER">] ExploreDuoCoreBanner
    /// Callout feature name for merge_request_dashboard_display_preferences_popover.
    | [<CompiledName "MERGE_REQUEST_DASHBOARD_DISPLAY_PREFERENCES_POPOVER">] MergeRequestDashboardDisplayPreferencesPopover
    /// Callout feature name for vulnerability_archival.
    | [<CompiledName "VULNERABILITY_ARCHIVAL">] VulnerabilityArchival
    /// Callout feature name for duo_amazon_q_alert.
    | [<CompiledName "DUO_AMAZON_Q_ALERT">] DuoAmazonQAlert
    /// Callout feature name for personal_homepage_preferences_banner.
    | [<CompiledName "PERSONAL_HOMEPAGE_PREFERENCES_BANNER">] PersonalHomepagePreferencesBanner
    /// Callout feature name for email_otp_enrollment_callout.
    | [<CompiledName "EMAIL_OTP_ENROLLMENT_CALLOUT">] EmailOtpEnrollmentCallout
    /// Callout feature name for merge_request_dashboard_show_drafts.
    | [<CompiledName "MERGE_REQUEST_DASHBOARD_SHOW_DRAFTS">] MergeRequestDashboardShowDrafts
    /// Callout feature name for focused_vulnerability_reporting.
    | [<CompiledName "FOCUSED_VULNERABILITY_REPORTING">] FocusedVulnerabilityReporting
    /// Callout feature name for expired_trial_status_widget.
    | [<CompiledName "EXPIRED_TRIAL_STATUS_WIDGET">] ExpiredTrialStatusWidget
    /// Callout feature name for work_item_consolidated_list_feedback.
    | [<CompiledName "WORK_ITEM_CONSOLIDATED_LIST_FEEDBACK">] WorkItemConsolidatedListFeedback

/// Name of the feature that the callout is for.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserGroupCalloutFeatureName =
    /// Callout feature name for invite_members_banner.
    | [<CompiledName "INVITE_MEMBERS_BANNER">] InviteMembersBanner
    /// Callout feature name for approaching_seat_count_threshold.
    | [<CompiledName "APPROACHING_SEAT_COUNT_THRESHOLD">] ApproachingSeatCountThreshold
    /// Callout feature name for namespace_storage_pre_enforcement_banner.
    | [<CompiledName "NAMESPACE_STORAGE_PRE_ENFORCEMENT_BANNER">] NamespaceStoragePreEnforcementBanner
    /// Callout feature name for ci_minutes_limit_alert_warning_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_WARNING_STAGE">] CiMinutesLimitAlertWarningStage
    /// Callout feature name for ci_minutes_limit_alert_danger_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_DANGER_STAGE">] CiMinutesLimitAlertDangerStage
    /// Callout feature name for ci_minutes_limit_alert_exceeded_stage.
    | [<CompiledName "CI_MINUTES_LIMIT_ALERT_EXCEEDED_STAGE">] CiMinutesLimitAlertExceededStage
    /// Callout feature name for preview_user_over_limit_free_plan_alert.
    | [<CompiledName "PREVIEW_USER_OVER_LIMIT_FREE_PLAN_ALERT">] PreviewUserOverLimitFreePlanAlert
    /// Callout feature name for user_reached_limit_free_plan_alert.
    | [<CompiledName "USER_REACHED_LIMIT_FREE_PLAN_ALERT">] UserReachedLimitFreePlanAlert
    /// Callout feature name for free_group_limited_alert.
    | [<CompiledName "FREE_GROUP_LIMITED_ALERT">] FreeGroupLimitedAlert
    /// Callout feature name for namespace_storage_limit_alert_warning_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_WARNING_THRESHOLD">] NamespaceStorageLimitAlertWarningThreshold
    /// Callout feature name for namespace_storage_limit_alert_alert_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_ALERT_THRESHOLD">] NamespaceStorageLimitAlertAlertThreshold
    /// Callout feature name for namespace_storage_limit_alert_error_threshold.
    | [<CompiledName "NAMESPACE_STORAGE_LIMIT_ALERT_ERROR_THRESHOLD">] NamespaceStorageLimitAlertErrorThreshold
    /// Callout feature name for usage_quota_trial_alert.
    | [<CompiledName "USAGE_QUOTA_TRIAL_ALERT">] UsageQuotaTrialAlert
    /// Callout feature name for preview_usage_quota_free_plan_alert.
    | [<CompiledName "PREVIEW_USAGE_QUOTA_FREE_PLAN_ALERT">] PreviewUsageQuotaFreePlanAlert
    /// Callout feature name for enforcement_at_limit_alert.
    | [<CompiledName "ENFORCEMENT_AT_LIMIT_ALERT">] EnforcementAtLimitAlert
    /// Callout feature name for web_hook_disabled.
    | [<CompiledName "WEB_HOOK_DISABLED">] WebHookDisabled
    /// Callout feature name for unlimited_members_during_trial_alert.
    | [<CompiledName "UNLIMITED_MEMBERS_DURING_TRIAL_ALERT">] UnlimitedMembersDuringTrialAlert
    /// Callout feature name for project_repository_limit_alert_warning_threshold.
    | [<CompiledName "PROJECT_REPOSITORY_LIMIT_ALERT_WARNING_THRESHOLD">] ProjectRepositoryLimitAlertWarningThreshold
    /// Callout feature name for namespace_over_storage_users_combined_alert.
    | [<CompiledName "NAMESPACE_OVER_STORAGE_USERS_COMBINED_ALERT">] NamespaceOverStorageUsersCombinedAlert
    /// Callout feature name for all_seats_used_alert.
    | [<CompiledName "ALL_SEATS_USED_ALERT">] AllSeatsUsedAlert
    /// Callout feature name for compliance_framework_settings_moved_callout.
    | [<CompiledName "COMPLIANCE_FRAMEWORK_SETTINGS_MOVED_CALLOUT">] ComplianceFrameworkSettingsMovedCallout
    /// Callout feature name for expired_duo_pro_trial_widget.
    | [<CompiledName "EXPIRED_DUO_PRO_TRIAL_WIDGET">] ExpiredDuoProTrialWidget
    /// Callout feature name for expired_duo_enterprise_trial_widget.
    | [<CompiledName "EXPIRED_DUO_ENTERPRISE_TRIAL_WIDGET">] ExpiredDuoEnterpriseTrialWidget
    /// Callout feature name for expired_trial_status_widget.
    | [<CompiledName "EXPIRED_TRIAL_STATUS_WIDGET">] ExpiredTrialStatusWidget
    /// Callout feature name for namespace_user_cap_reached_alert.
    | [<CompiledName "NAMESPACE_USER_CAP_REACHED_ALERT">] NamespaceUserCapReachedAlert
    /// Callout feature name for duo_agent_platform_requested.
    | [<CompiledName "DUO_AGENT_PLATFORM_REQUESTED">] DuoAgentPlatformRequested
    /// Callout feature name for project_premium_message_callout.
    | [<CompiledName "PROJECT_PREMIUM_MESSAGE_CALLOUT">] ProjectPremiumMessageCallout
    /// Callout feature name for repository_premium_message_callout.
    | [<CompiledName "REPOSITORY_PREMIUM_MESSAGE_CALLOUT">] RepositoryPremiumMessageCallout
    /// Callout feature name for mrs_premium_message_callout.
    | [<CompiledName "MRS_PREMIUM_MESSAGE_CALLOUT">] MrsPremiumMessageCallout

/// Types of User Promotion States.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserPromotionStatusType =
    /// Successfully applied all promotion requests for user.
    | [<CompiledName "SUCCESS">] Success
    /// User promotion was successful, but all promotion requests were not successfully applied.
    | [<CompiledName "PARTIAL_SUCCESS">] PartialSuccess
    /// Failed to apply promotion requests for user.
    | [<CompiledName "FAILED">] Failed

/// Possible states of a user
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserState =
    /// User is active and can use the system.
    | [<CompiledName "active">] Active
    /// User has been blocked by an administrator and cannot use the system.
    | [<CompiledName "blocked">] Blocked
    /// User is no longer active and cannot use the system.
    | [<CompiledName "deactivated">] Deactivated
    /// User is blocked, and their contributions are hidden.
    | [<CompiledName "banned">] Banned
    /// User has been blocked by the system.
    | [<CompiledName "ldap_blocked">] LdapBlocked
    /// User is blocked and pending approval.
    | [<CompiledName "blocked_pending_approval">] BlockedPendingApproval

/// Possible types of user
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type UserType =
    /// Human
    | [<CompiledName "HUMAN">] Human
    /// Support bot
    | [<CompiledName "SUPPORT_BOT">] SupportBot
    /// Alert bot
    | [<CompiledName "ALERT_BOT">] AlertBot
    /// Visual review bot
    | [<CompiledName "VISUAL_REVIEW_BOT">] VisualReviewBot
    /// Service user
    | [<CompiledName "SERVICE_USER">] ServiceUser
    /// Ghost
    | [<CompiledName "GHOST">] Ghost
    /// Project bot
    | [<CompiledName "PROJECT_BOT">] ProjectBot
    /// Migration bot
    | [<CompiledName "MIGRATION_BOT">] MigrationBot
    /// Security bot
    | [<CompiledName "SECURITY_BOT">] SecurityBot
    /// Automation bot
    | [<CompiledName "AUTOMATION_BOT">] AutomationBot
    /// Security policy bot
    | [<CompiledName "SECURITY_POLICY_BOT">] SecurityPolicyBot
    /// Admin bot
    | [<CompiledName "ADMIN_BOT">] AdminBot
    /// Service account
    | [<CompiledName "SERVICE_ACCOUNT">] ServiceAccount
    /// Placeholder
    | [<CompiledName "PLACEHOLDER">] Placeholder
    /// Duo code review bot
    | [<CompiledName "DUO_CODE_REVIEW_BOT">] DuoCodeReviewBot
    /// Import user
    | [<CompiledName "IMPORT_USER">] ImportUser

/// Possible identifier types for a measurement
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ValueStreamDashboardMetric =
    /// Project count.
    | [<CompiledName "PROJECTS">] Projects
    /// Issue count.
    | [<CompiledName "ISSUES">] Issues
    /// Group count.
    | [<CompiledName "GROUPS">] Groups
    /// Merge request count.
    | [<CompiledName "MERGE_REQUESTS">] MergeRequests
    /// Pipeline count.
    | [<CompiledName "PIPELINES">] Pipelines
    /// User count.
    | [<CompiledName "USERS">] Users
    /// Contributor count. EXPERIMENTAL: Only available on the SaaS version of GitLab when the ClickHouse database backend is enabled.
    | [<CompiledName "CONTRIBUTORS">] Contributors

/// Possible identifier types for project-level measurement
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ValueStreamDashboardProjectLevelMetric =
    /// Issue count.
    | [<CompiledName "ISSUES">] Issues
    /// Merge request count.
    | [<CompiledName "MERGE_REQUESTS">] MergeRequests
    /// Pipeline count.
    | [<CompiledName "PIPELINES">] Pipelines
    /// Contributor count. EXPERIMENTAL: Only available on the SaaS version of GitLab when the ClickHouse database backend is enabled.
    | [<CompiledName "CONTRIBUTORS">] Contributors

/// Stage event identifiers
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ValueStreamStageEvent =
    /// Issue created event.
    | [<CompiledName "ISSUE_CREATED">] IssueCreated
    /// Issue first mentioned in commit event.
    | [<CompiledName "ISSUE_FIRST_MENTIONED_IN_COMMIT">] IssueFirstMentionedInCommit
    /// Issue deployed to production event.
    | [<CompiledName "ISSUE_DEPLOYED_TO_PRODUCTION">] IssueDeployedToProduction
    /// Merge request created event.
    | [<CompiledName "MERGE_REQUEST_CREATED">] MergeRequestCreated
    /// Merge request first deployed to production event.
    | [<CompiledName "MERGE_REQUEST_FIRST_DEPLOYED_TO_PRODUCTION">] MergeRequestFirstDeployedToProduction
    /// Merge request last build finished event.
    | [<CompiledName "MERGE_REQUEST_LAST_BUILD_FINISHED">] MergeRequestLastBuildFinished
    /// Merge request last build started event.
    | [<CompiledName "MERGE_REQUEST_LAST_BUILD_STARTED">] MergeRequestLastBuildStarted
    /// Merge request merged event.
    | [<CompiledName "MERGE_REQUEST_MERGED">] MergeRequestMerged
    /// Code stage start event.
    | [<CompiledName "CODE_STAGE_START">] CodeStageStart
    /// Issue stage end event.
    | [<CompiledName "ISSUE_STAGE_END">] IssueStageEnd
    /// Plan stage start event.
    | [<CompiledName "PLAN_STAGE_START">] PlanStageStart
    /// Issue closed event.
    | [<CompiledName "ISSUE_CLOSED">] IssueClosed
    /// Issue first added to board event.
    | [<CompiledName "ISSUE_FIRST_ADDED_TO_BOARD">] IssueFirstAddedToBoard
    /// Issue first associated with milestone event.
    | [<CompiledName "ISSUE_FIRST_ASSOCIATED_WITH_MILESTONE">] IssueFirstAssociatedWithMilestone
    /// Issue last edited event.
    | [<CompiledName "ISSUE_LAST_EDITED">] IssueLastEdited
    /// Issue label added event.
    | [<CompiledName "ISSUE_LABEL_ADDED">] IssueLabelAdded
    /// Issue label removed event.
    | [<CompiledName "ISSUE_LABEL_REMOVED">] IssueLabelRemoved
    /// Issue first assigned at event.
    | [<CompiledName "ISSUE_FIRST_ASSIGNED_AT">] IssueFirstAssignedAt
    /// Issue first added to iteration event.
    | [<CompiledName "ISSUE_FIRST_ADDED_TO_ITERATION">] IssueFirstAddedToIteration
    /// Merge request closed event.
    | [<CompiledName "MERGE_REQUEST_CLOSED">] MergeRequestClosed
    /// Merge request last edited event.
    | [<CompiledName "MERGE_REQUEST_LAST_EDITED">] MergeRequestLastEdited
    /// Merge request label added event.
    | [<CompiledName "MERGE_REQUEST_LABEL_ADDED">] MergeRequestLabelAdded
    /// Merge request label removed event.
    | [<CompiledName "MERGE_REQUEST_LABEL_REMOVED">] MergeRequestLabelRemoved
    /// Merge request first commit at event.
    | [<CompiledName "MERGE_REQUEST_FIRST_COMMIT_AT">] MergeRequestFirstCommitAt
    /// Merge request first assigned at event.
    | [<CompiledName "MERGE_REQUEST_FIRST_ASSIGNED_AT">] MergeRequestFirstAssignedAt
    /// Merge request reviewer first assigned event.
    | [<CompiledName "MERGE_REQUEST_REVIEWER_FIRST_ASSIGNED">] MergeRequestReviewerFirstAssigned
    /// Merge request last approved at event.
    | [<CompiledName "MERGE_REQUEST_LAST_APPROVED_AT">] MergeRequestLastApprovedAt

/// Sorting values available to value stream stage items
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type ValueStreamStageItemSort =
    /// Duration by ascending order.
    | [<CompiledName "DURATION_ASC">] DurationAsc
    /// Duration by ascending order.
    | [<CompiledName "DURATION_DESC">] DurationDesc
    /// Stage end event time by ascending order.
    | [<CompiledName "END_EVENT_ASC">] EndEventAsc
    /// Stage end event time by descending order.
    | [<CompiledName "END_EVENT_DESC">] EndEventDesc

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VerificationStateEnum =
    /// Verification process has not started.
    | [<CompiledName "PENDING">] Pending
    /// Verification process is in progress.
    | [<CompiledName "STARTED">] Started
    /// Verification process finished successfully.
    | [<CompiledName "SUCCEEDED">] Succeeded
    /// Verification process finished but failed.
    | [<CompiledName "FAILED">] Failed
    /// Verification process is disabled.
    | [<CompiledName "DISABLED">] Disabled

/// Verification status of a GPG, X.509 or SSH signature for a commit.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VerificationStatus =
    /// unverified verification status.
    | [<CompiledName "UNVERIFIED">] Unverified
    /// verified verification status.
    | [<CompiledName "VERIFIED">] Verified
    /// same_user_different_email verification status.
    | [<CompiledName "SAME_USER_DIFFERENT_EMAIL">] SameUserDifferentEmail
    /// other_user verification status.
    | [<CompiledName "OTHER_USER">] OtherUser
    /// unverified_key verification status.
    | [<CompiledName "UNVERIFIED_KEY">] UnverifiedKey
    /// unknown_key verification status.
    | [<CompiledName "UNKNOWN_KEY">] UnknownKey
    /// multiple_signatures verification status.
    | [<CompiledName "MULTIPLE_SIGNATURES">] MultipleSignatures
    /// revoked_key verification status.
    | [<CompiledName "REVOKED_KEY">] RevokedKey
    /// verified_system verification status.
    | [<CompiledName "VERIFIED_SYSTEM">] VerifiedSystem
    /// unverified_author_email verification status.
    | [<CompiledName "UNVERIFIED_AUTHOR_EMAIL">] UnverifiedAuthorEmail
    /// verified_ca verification status.
    | [<CompiledName "VERIFIED_CA">] VerifiedCa

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VisibilityLevelsEnum =
    /// Private visibility level.
    | [<CompiledName "private">] Private
    /// Internal visibility level.
    | [<CompiledName "internal">] Internal
    /// Public visibility level.
    | [<CompiledName "public">] Public

/// Determines whether the pipeline list shows ID or IID
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VisibilityPipelineIdType =
    /// Display pipeline ID.
    | [<CompiledName "ID">] Id
    /// Display pipeline IID.
    | [<CompiledName "IID">] Iid

[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VisibilityScopesEnum =
    /// Snippet is visible only to the snippet creator.
    | [<CompiledName "private">] Private
    /// Snippet is visible for any logged in user except external users.
    | [<CompiledName "internal">] Internal
    /// Snippet can be accessed without any authentication.
    | [<CompiledName "public">] Public

/// The dismissal reason of the Vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityDismissalReason =
    /// The vulnerability is known, and has not been remediated or mitigated, but is considered to be an acceptable business risk.
    | [<CompiledName "ACCEPTABLE_RISK">] AcceptableRisk
    /// An error in reporting in which a test result incorrectly indicates the presence of a vulnerability in a system when the vulnerability is not present.
    | [<CompiledName "FALSE_POSITIVE">] FalsePositive
    /// A management, operational, or technical control (that is, safeguard or countermeasure) employed by an organization that provides equivalent or comparable protection for an information system.
    | [<CompiledName "MITIGATING_CONTROL">] MitigatingControl
    /// The finding is not a vulnerability because it is part of a test or is test data.
    | [<CompiledName "USED_IN_TESTS">] UsedInTests
    /// The vulnerability is known, and has not been remediated or mitigated, but is considered to be in a part of the application that will not be updated.
    | [<CompiledName "NOT_APPLICABLE">] NotApplicable

/// The external tracker of the external issue link related to a vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityExternalIssueLinkExternalTracker =
    /// Jira external tracker
    | [<CompiledName "JIRA">] Jira

/// The type of the external issue link related to a vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityExternalIssueLinkType =
    /// Created link type.
    | [<CompiledName "CREATED">] Created

/// Status of vulnerability flag false positive detection
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityFalsePositiveDetectionStatus =
    /// Detection is not started
    | [<CompiledName "NOT_STARTED">] NotStarted
    /// Detection is in progress
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// Detection is detected as fp
    | [<CompiledName "DETECTED_AS_FP">] DetectedAsFp
    /// Detection is detected as not fp
    | [<CompiledName "DETECTED_AS_NOT_FP">] DetectedAsNotFp
    /// Detection is failed
    | [<CompiledName "FAILED">] Failed

/// Status of a secret token found in a vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityFindingTokenStatusState =
    /// Token status is unknown.
    | [<CompiledName "UNKNOWN">] Unknown
    /// Token is active and can be exploited.
    | [<CompiledName "ACTIVE">] Active
    /// Token is inactive and cannot be exploited.
    | [<CompiledName "INACTIVE">] Inactive

/// The grade of the vulnerable project
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityGrade =
    /// A grade
    | [<CompiledName "A">] A
    /// B grade
    | [<CompiledName "B">] B
    /// C grade
    | [<CompiledName "C">] C
    /// D grade
    | [<CompiledName "D">] D
    /// F grade
    | [<CompiledName "F">] F

/// The type of the issue link related to a vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityIssueLinkType =
    /// Has a related issue
    | [<CompiledName "RELATED">] Related
    /// Issue is created for the vulnerability
    | [<CompiledName "CREATED">] Created

/// `OwaspTop10` vulnerability categories for OWASP 2021
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityOwasp2021Top10 =
    /// No OWASP top 10 category.
    | [<CompiledName "NONE">] None

/// OwaspTop10 category of the vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityOwaspTop10 =
    /// A1:2017-Injection, OWASP top 10 2017 category.
    | [<CompiledName "A1_2017">] A12017
    /// A2:2017-Broken Authentication, OWASP top 10 2017 category.
    | [<CompiledName "A2_2017">] A22017
    /// A3:2017-Sensitive Data Exposure, OWASP top 10 2017 category.
    | [<CompiledName "A3_2017">] A32017
    /// A4:2017-XML External Entities (XXE), OWASP top 10 2017 category.
    | [<CompiledName "A4_2017">] A42017
    /// A5:2017-Broken Access Control, OWASP top 10 2017 category.
    | [<CompiledName "A5_2017">] A52017
    /// A6:2017-Security Misconfiguration, OWASP top 10 2017 category.
    | [<CompiledName "A6_2017">] A62017
    /// A7:2017-Cross-Site Scripting (XSS), OWASP top 10 2017 category.
    | [<CompiledName "A7_2017">] A72017
    /// A8:2017-Insecure Deserialization, OWASP top 10 2017 category.
    | [<CompiledName "A8_2017">] A82017
    /// A9:2017-Using Components with Known Vulnerabilities, OWASP top 10 2017 category.
    | [<CompiledName "A9_2017">] A92017
    /// A10:2017-Insufficient Logging & Monitoring, OWASP top 10 2017 category.
    | [<CompiledName "A10_2017">] A102017
    /// No OWASP top 10 2017 category.
    | [<CompiledName "NONE">] None

/// The type of the security scan that found the vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityReportType =
    /// SAST report
    | [<CompiledName "SAST">] Sast
    /// Dependency scanning report
    | [<CompiledName "DEPENDENCY_SCANNING">] DependencyScanning
    /// Container scanning report
    | [<CompiledName "CONTAINER_SCANNING">] ContainerScanning
    /// DAST report
    | [<CompiledName "DAST">] Dast
    /// Secret detection report
    | [<CompiledName "SECRET_DETECTION">] SecretDetection
    /// Coverage fuzzing report
    | [<CompiledName "COVERAGE_FUZZING">] CoverageFuzzing
    /// API fuzzing report
    | [<CompiledName "API_FUZZING">] ApiFuzzing
    /// Cluster image scanning report
    | [<CompiledName "CLUSTER_IMAGE_SCANNING">] ClusterImageScanning
    /// Container scanning for registry report
    | [<CompiledName "CONTAINER_SCANNING_FOR_REGISTRY">] ContainerScanningForRegistry
    /// Generic report
    | [<CompiledName "GENERIC">] Generic

/// The severity of the vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilitySeverity =
    /// Info severity
    | [<CompiledName "INFO">] Info
    /// Unknown severity
    | [<CompiledName "UNKNOWN">] Unknown
    /// Low severity
    | [<CompiledName "LOW">] Low
    /// Medium severity
    | [<CompiledName "MEDIUM">] Medium
    /// High severity
    | [<CompiledName "HIGH">] High
    /// Critical severity
    | [<CompiledName "CRITICAL">] Critical

/// Vulnerability sort values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilitySort =
    /// Severity in descending order.
    | [<CompiledName "severity_desc">] SeverityDesc
    /// Severity in ascending order.
    | [<CompiledName "severity_asc">] SeverityAsc
    /// Detection timestamp in descending order.
    | [<CompiledName "detected_desc">] DetectedDesc
    /// Detection timestamp in ascending order.
    | [<CompiledName "detected_asc">] DetectedAsc

/// The state of the vulnerability
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityState =
    /// For details, see [vulnerability status values](https://docs.gitlab.com/user/application_security/vulnerabilities/#vulnerability-status-values).
    | [<CompiledName "CONFIRMED">] Confirmed
    /// For details, see [vulnerability status values](https://docs.gitlab.com/user/application_security/vulnerabilities/#vulnerability-status-values).
    | [<CompiledName "DETECTED">] Detected
    /// For details, see [vulnerability status values](https://docs.gitlab.com/user/application_security/vulnerabilities/#vulnerability-status-values).
    | [<CompiledName "DISMISSED">] Dismissed
    /// For details, see [vulnerability status values](https://docs.gitlab.com/user/application_security/vulnerabilities/#vulnerability-status-values).
    | [<CompiledName "RESOLVED">] Resolved

/// Workflow name for vulnerability triggered workflows
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type VulnerabilityWorkflowName =
    /// Workflow name is sast fp detection
    | [<CompiledName "SAST_FP_DETECTION">] SastFpDetection
    /// Workflow name is resolve sast vulnerability
    | [<CompiledName "RESOLVE_SAST_VULNERABILITY">] ResolveSastVulnerability

/// Webhook auto-disabling alert status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WebhookAlertStatus =
    /// Webhook is executable.
    | [<CompiledName "EXECUTABLE">] Executable
    /// Webhook has been temporarily disabled and will be automatically re-enabled.
    | [<CompiledName "TEMPORARILY_DISABLED">] TemporarilyDisabled
    /// Webhook has been permanently disabled and will not be automatically re-enabled.
    | [<CompiledName "DISABLED">] Disabled

/// Strategy for filtering push events by branch name
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WebhookBranchFilterStrategy =
    /// Receive push events from branches that match a wildcard pattern.
    | [<CompiledName "WILDCARD">] Wildcard
    /// Receive push events from branches that match a regular expression (regex).
    | [<CompiledName "REGEX">] Regex
    /// Receive push events from all branches.
    | [<CompiledName "ALL_BRANCHES">] AllBranches

/// Weight ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WeightWildcardId =
    /// No weight is assigned.
    | [<CompiledName "NONE">] None
    /// Weight is assigned.
    | [<CompiledName "ANY">] Any

/// Values for work item award emoji update enum
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemAwardEmojiUpdateAction =
    /// Adds the emoji.
    | [<CompiledName "ADD">] Add
    /// Removes the emoji.
    | [<CompiledName "REMOVE">] Remove
    /// Toggles the status of the emoji.
    | [<CompiledName "TOGGLE">] Toggle

/// Values for sorting work item discussions
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemDiscussionsSort =
    /// Created at in ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Created at in descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc

/// Parent ID wildcard values
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemParentWildcardId =
    /// No parent is assigned.
    | [<CompiledName "NONE">] None
    /// Any parent is assigned.
    | [<CompiledName "ANY">] Any

/// Values for work item link types
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemRelatedLinkType =
    /// Related type.
    | [<CompiledName "RELATED">] Related
    /// Blocked by type.
    | [<CompiledName "BLOCKED_BY">] BlockedBy
    /// Blocks type.
    | [<CompiledName "BLOCKS">] Blocks

/// Values for sorting work items
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemSort =
    /// Updated at descending order.
    | [<CompiledName "UPDATED_DESC">] UpdatedDesc
    /// Updated at ascending order.
    | [<CompiledName "UPDATED_ASC">] UpdatedAsc
    /// Created at descending order.
    | [<CompiledName "CREATED_DESC">] CreatedDesc
    /// Created at ascending order.
    | [<CompiledName "CREATED_ASC">] CreatedAsc
    /// Title by ascending order.
    | [<CompiledName "TITLE_ASC">] TitleAsc
    /// Title by descending order.
    | [<CompiledName "TITLE_DESC">] TitleDesc
    /// Label priority by ascending order.
    | [<CompiledName "LABEL_PRIORITY_ASC">] LabelPriorityAsc
    /// Label priority by descending order.
    | [<CompiledName "LABEL_PRIORITY_DESC">] LabelPriorityDesc
    /// Milestone due date by ascending order.
    | [<CompiledName "MILESTONE_DUE_ASC">] MilestoneDueAsc
    /// Milestone due date by descending order.
    | [<CompiledName "MILESTONE_DUE_DESC">] MilestoneDueDesc
    /// Blocking items count by ascending order.
    | [<CompiledName "BLOCKING_ISSUES_ASC">] BlockingIssuesAsc
    /// Blocking items count by descending order.
    | [<CompiledName "BLOCKING_ISSUES_DESC">] BlockingIssuesDesc

/// State of a GitLab work item
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemState =
    /// In open state.
    | [<CompiledName "OPEN">] Open
    /// In closed state.
    | [<CompiledName "CLOSED">] Closed

/// Values for work item state events
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemStateEvent =
    /// Reopens the work item.
    | [<CompiledName "REOPEN">] Reopen
    /// Closes the work item.
    | [<CompiledName "CLOSE">] Close

/// Category of the work item status
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemStatusCategoryEnum =
    /// Triage status category
    | [<CompiledName "TRIAGE">] Triage
    /// To do status category
    | [<CompiledName "TO_DO">] ToDo
    /// In progress status category
    | [<CompiledName "IN_PROGRESS">] InProgress
    /// Done status category
    | [<CompiledName "DONE">] Done
    /// Canceled status category
    | [<CompiledName "CANCELED">] Canceled

/// Values for work item subscription events
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemSubscriptionEvent =
    /// Subscribe to a work item.
    | [<CompiledName "SUBSCRIBE">] Subscribe
    /// Unsubscribe from a work item.
    | [<CompiledName "UNSUBSCRIBE">] Unsubscribe

/// Values for work item to-do update enum
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemTodoUpdateAction =
    /// Marks the to-do as done.
    | [<CompiledName "MARK_AS_DONE">] MarkAsDone
    /// Adds the to-do.
    | [<CompiledName "ADD">] Add

/// Type of a work item widget
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkItemWidgetType =
    /// Assignees widget.
    | [<CompiledName "ASSIGNEES">] Assignees
    /// Description widget.
    | [<CompiledName "DESCRIPTION">] Description
    /// Hierarchy widget.
    | [<CompiledName "HIERARCHY">] Hierarchy
    /// Labels widget.
    | [<CompiledName "LABELS">] Labels
    /// Milestone widget.
    | [<CompiledName "MILESTONE">] Milestone
    /// Notes widget.
    | [<CompiledName "NOTES">] Notes
    /// Start And Due Date widget.
    | [<CompiledName "START_AND_DUE_DATE">] StartAndDueDate
    /// Health Status widget.
    | [<CompiledName "HEALTH_STATUS">] HealthStatus
    /// Weight widget.
    | [<CompiledName "WEIGHT">] Weight
    /// Iteration widget.
    | [<CompiledName "ITERATION">] Iteration
    /// Progress widget.
    | [<CompiledName "PROGRESS">] Progress
    /// Verification Status widget.
    | [<CompiledName "VERIFICATION_STATUS">] VerificationStatus
    /// Requirement Legacy widget.
    | [<CompiledName "REQUIREMENT_LEGACY">] RequirementLegacy
    /// Test Reports widget.
    | [<CompiledName "TEST_REPORTS">] TestReports
    /// Notifications widget.
    | [<CompiledName "NOTIFICATIONS">] Notifications
    /// Current User Todos widget.
    | [<CompiledName "CURRENT_USER_TODOS">] CurrentUserTodos
    /// Award Emoji widget.
    | [<CompiledName "AWARD_EMOJI">] AwardEmoji
    /// Linked Items widget.
    | [<CompiledName "LINKED_ITEMS">] LinkedItems
    /// Color widget.
    | [<CompiledName "COLOR">] Color
    /// Participants widget.
    | [<CompiledName "PARTICIPANTS">] Participants
    /// Time Tracking widget.
    | [<CompiledName "TIME_TRACKING">] TimeTracking
    /// Designs widget.
    | [<CompiledName "DESIGNS">] Designs
    /// Development widget.
    | [<CompiledName "DEVELOPMENT">] Development
    /// Crm Contacts widget.
    | [<CompiledName "CRM_CONTACTS">] CrmContacts
    /// Email Participants widget.
    | [<CompiledName "EMAIL_PARTICIPANTS">] EmailParticipants
    /// Status widget.
    | [<CompiledName "STATUS">] Status
    /// Linked Resources widget.
    | [<CompiledName "LINKED_RESOURCES">] LinkedResources
    /// Custom Fields widget.
    | [<CompiledName "CUSTOM_FIELDS">] CustomFields
    /// Error Tracking widget.
    | [<CompiledName "ERROR_TRACKING">] ErrorTracking
    /// Vulnerabilities widget.
    | [<CompiledName "VULNERABILITIES">] Vulnerabilities

/// The environment of a workflow.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkflowEnvironment =
    /// Chat Partial environment
    | [<CompiledName "CHAT_PARTIAL">] ChatPartial
    /// Chat environment
    | [<CompiledName "CHAT">] Chat
    /// Ambient environment
    | [<CompiledName "AMBIENT">] Ambient

/// Enum for the type of the variable to be injected in a workspace.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkspaceVariableInputType =
    /// Name type.
    | [<CompiledName "ENVIRONMENT">] Environment

/// Enum for the type of the variable injected in a workspace.
[<Fable.Core.StringEnum; RequireQualifiedAccess>]
type WorkspaceVariableType =
    /// Environment type.
    | [<CompiledName "ENVIRONMENT">] Environment

/// Autogenerated input type of AchievementsAward
type AchievementsAwardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the achievement being awarded.
        achievementId: string
        /// Global ID of the user being awarded the achievement.
        userId: string
    }

/// Autogenerated input type of AchievementsCreate
type AchievementsCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace for the achievement.
        namespaceId: string
        /// Name for the achievement.
        name: string
        /// Avatar for the achievement.
        avatar: Option<string>
        /// Description of or notes for the achievement.
        description: Option<string>
    }

/// Autogenerated input type of AchievementsDelete
type AchievementsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the achievement being deleted.
        achievementId: string
    }

/// Autogenerated input type of AchievementsRevoke
type AchievementsRevokeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the user achievement being revoked.
        userAchievementId: string
    }

/// Autogenerated input type of AchievementsUpdate
type AchievementsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the achievement being updated.
        achievementId: string
        /// Name for the achievement.
        name: Option<string>
        /// Avatar for the achievement.
        avatar: Option<string>
        /// Description of or notes for the achievement.
        description: Option<string>
    }

/// Autogenerated input type of AddProjectToSecurityDashboard
type AddProjectToSecurityDashboardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to be added to Instance Security Dashboard.
        id: string
    }

/// Autogenerated input type of AdminRolesLdapSync
type AdminRolesLdapSyncInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
    }

/// Autogenerated input type of AdminSidekiqQueuesDeleteJobs
type AdminSidekiqQueuesDeleteJobsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Delete jobs matching organization_id in the context metadata.
        organizationId: Option<string>
        /// Delete jobs matching user in the context metadata.
        user: Option<string>
        /// Delete jobs matching user_id in the context metadata.
        userId: Option<string>
        /// Delete jobs matching gl_user_id in the context metadata.
        glUserId: Option<string>
        /// Delete jobs matching scoped_user in the context metadata.
        scopedUser: Option<string>
        /// Delete jobs matching scoped_user_id in the context metadata.
        scopedUserId: Option<string>
        /// Delete jobs matching project in the context metadata.
        project: Option<string>
        /// Delete jobs matching root_namespace in the context metadata.
        rootNamespace: Option<string>
        /// Delete jobs matching client_id in the context metadata.
        clientId: Option<string>
        /// Delete jobs matching caller_id in the context metadata.
        callerId: Option<string>
        /// Delete jobs matching remote_ip in the context metadata.
        remoteIp: Option<string>
        /// Delete jobs matching job_id in the context metadata.
        jobId: Option<string>
        /// Delete jobs matching pipeline_id in the context metadata.
        pipelineId: Option<string>
        /// Delete jobs matching related_class in the context metadata.
        relatedClass: Option<string>
        /// Delete jobs matching feature_category in the context metadata.
        featureCategory: Option<string>
        /// Delete jobs matching artifact_size in the context metadata.
        artifactSize: Option<string>
        /// Delete jobs matching artifact_used_cdn in the context metadata.
        artifactUsedCdn: Option<string>
        /// Delete jobs matching artifacts_dependencies_size in the context metadata.
        artifactsDependenciesSize: Option<string>
        /// Delete jobs matching artifacts_dependencies_count in the context metadata.
        artifactsDependenciesCount: Option<string>
        /// Delete jobs matching root_caller_id in the context metadata.
        rootCallerId: Option<string>
        /// Delete jobs matching merge_action_status in the context metadata.
        mergeActionStatus: Option<string>
        /// Delete jobs matching bulk_import_entity_id in the context metadata.
        bulkImportEntityId: Option<string>
        /// Delete jobs matching sidekiq_destination_shard_redis in the context metadata.
        sidekiqDestinationShardRedis: Option<string>
        /// Delete jobs matching kubernetes_agent_id in the context metadata.
        kubernetesAgentId: Option<string>
        /// Delete jobs matching subscription_plan in the context metadata.
        subscriptionPlan: Option<string>
        /// Delete jobs matching ai_resource in the context metadata.
        aiResource: Option<string>
        /// Delete jobs matching policy_sync_config_id in the context metadata.
        policySyncConfigId: Option<string>
        /// Delete jobs with the given worker class.
        workerClass: Option<string>
        /// Name of the queue to delete jobs from.
        queueName: string
    }

/// Autogenerated input type of AiAction
type AiActionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Input for explain_vulnerability AI action.
        explainVulnerability: Option<AiExplainVulnerabilityInput>
        /// Input for resolve_vulnerability AI action.
        resolveVulnerability: Option<AiResolveVulnerabilityInput>
        /// Input for summarize_review AI action.
        summarizeReview: Option<AiSummarizeReviewInput>
        /// Input for measure_comment_temperature AI action.
        measureCommentTemperature: Option<AiMeasureCommentTemperatureInput>
        /// Input for generate_description AI action.
        generateDescription: Option<AiGenerateDescriptionInput>
        /// Input for generate_commit_message AI action.
        generateCommitMessage: Option<AiGenerateCommitMessageInput>
        /// Input for description_composer AI action.
        descriptionComposer: Option<AiDescriptionComposerInput>
        /// Input for chat AI action.
        chat: Option<AiChatInput>
        /// Input for summarize_new_merge_request AI action.
        summarizeNewMergeRequest: Option<AiSummarizeNewMergeRequestInput>
        /// Input for agentic_chat AI action.
        agenticChat: Option<AiAgenticChatInput>
        /// Client generated ID that can be subscribed to, to receive a response for the mutation.
        clientSubscriptionId: Option<string>
        /// Specifies the origin platform of the request.
        platformOrigin: Option<string>
        /// Global ID of the project the user is acting on.
        projectId: Option<string>
        /// Global ID of the top-level namespace the user is acting on.
        rootNamespaceId: Option<string>
        /// Conversation type of the thread.
        conversationType: Option<AiConversationsThreadsConversationType>
        /// Global Id of the existing thread to continue the conversation. If it is not specified, a new thread will be created for the specified conversation_type.
        threadId: Option<string>
    }

type AiAdditionalContextInput =
    {
        /// ID of the additional context.
        id: string
        /// Category of the additional context.
        category: AiAdditionalContextCategory
        /// Content of the additional context.
        content: string
        /// Metadata of the additional context.
        metadata: Option<string>
    }

/// Autogenerated input type of AiAgentCreate
type AiAgentCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to which the agent belongs.
        projectPath: string
        /// Name of the agent.
        name: string
        /// Prompt for the agent.
        prompt: string
    }

/// Autogenerated input type of AiAgentDestroy
type AiAgentDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to which the agent belongs.
        projectPath: string
        /// Global ID of the AI Agent to be deleted.
        agentId: string
    }

/// Autogenerated input type of AiAgentUpdate
type AiAgentUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to which the agent belongs.
        projectPath: string
        /// ID of the agent.
        agentId: string
        /// Name of the agent.
        name: Option<string>
        /// Prompt for the agent.
        prompt: Option<string>
    }

type AiAgenticChatInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// Content of the message.
        content: string
        /// Global ID of the namespace the user is acting on.
        namespaceId: Option<string>
        /// Information about currently selected text which can be passed for additional context.
        currentFile: Option<AiCurrentFileInput>
        /// Additional context to be passed for the chat.
        additionalContext: Option<list<AiAdditionalContextInput>>
    }

/// Autogenerated input type of AiCatalogAgentCreate
type AiCatalogAgentCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description for the agent.
        description: string
        /// Name for the agent.
        name: string
        /// Project for the agent.
        projectId: string
        /// Whether the agent is publicly visible in the catalog.
        ``public``: bool
        /// Whether to release the latest version of the agent.
        release: Option<bool>
        /// System prompt for the agent.
        systemPrompt: string
        /// List of GitLab tools enabled for the agent.
        tools: Option<list<string>>
        /// User prompt for the agent.
        userPrompt: Option<string>
        /// Whether to add to the project upon creation.
        addToProjectWhenCreated: Option<bool>
    }

/// Autogenerated input type of AiCatalogAgentDelete
type AiCatalogAgentDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog Agent to delete.
        id: string
        /// When true, the flow will always be hard deleted and never soft deleted. Can only be used by instance admins
        forceHardDelete: Option<bool>
    }

/// Autogenerated input type of AiCatalogAgentUpdate
type AiCatalogAgentUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog Agent to update.
        id: string
        /// Description for the agent.
        description: Option<string>
        /// Name for the agent.
        name: Option<string>
        /// Whether the agent is publicly visible in the catalog.
        ``public``: Option<bool>
        /// Whether to release the latest version of the agent.
        release: Option<bool>
        /// System prompt for the agent.
        systemPrompt: Option<string>
        /// List of GitLab tools enabled for the agent.
        tools: Option<list<string>>
        /// User prompt for the agent.
        userPrompt: Option<string>
        /// Bump version, calculated from the last released version name.
        versionBump: Option<AiCatalogVersionBump>
    }

/// Autogenerated input type of AiCatalogFlowCreate
type AiCatalogFlowCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description for the flow.
        description: string
        /// Name for the flow.
        name: string
        /// Project for the flow.
        projectId: string
        /// Whether the flow is publicly visible in the catalog.
        ``public``: bool
        /// Whether to release the latest version of the flow.
        release: Option<bool>
        /// Steps for the flow.
        steps: Option<list<AiCatalogFlowStepsInput>>
        /// YAML definition for the flow.
        definition: Option<string>
        /// Whether to add to the project upon creation.
        addToProjectWhenCreated: Option<bool>
    }

/// Autogenerated input type of AiCatalogFlowDelete
type AiCatalogFlowDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog flow to delete.
        id: string
        /// When true, the flow will always be hard deleted and never soft deleted. Can only be used by instance admins
        forceHardDelete: Option<bool>
    }

type AiCatalogFlowStepsInput =
    {
        /// Agent to use.
        agentId: string
        /// Major version, minor version, or patch to pin the agent to.
        pinnedVersionPrefix: Option<string>
    }

/// Autogenerated input type of AiCatalogFlowUpdate
type AiCatalogFlowUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog flow to update.
        id: string
        /// Description for the flow.
        description: Option<string>
        /// Name for the flow.
        name: Option<string>
        /// Whether the flow is publicly visible in the catalog.
        ``public``: Option<bool>
        /// Whether to release the latest version of the flow.
        release: Option<bool>
        /// Steps for the flow.
        steps: Option<list<AiCatalogFlowStepsInput>>
        /// YAML definition for the Flow.
        definition: Option<string>
        /// Bump version, calculated from the last released version name.
        versionBump: Option<AiCatalogVersionBump>
    }

/// Autogenerated input type of AiCatalogItemConsumerCreate
type AiCatalogItemConsumerCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Item to configure.
        itemId: string
        /// Target project or top-level group in which the catalog item is configured.
        target: ItemConsumerTargetInput
        /// List of event types to create flow triggers for (values can be mention, assign or assign_reviewer).
        triggerTypes: Option<list<string>>
        /// Parent item consumer belonging to the top-level group.
        parentItemConsumerId: Option<string>
    }

/// Autogenerated input type of AiCatalogItemConsumerDelete
type AiCatalogItemConsumerDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog item consumer to delete.
        id: string
    }

/// Autogenerated input type of AiCatalogItemConsumerUpdate
type AiCatalogItemConsumerUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog item consumer to update.
        id: string
        /// Version to pin the item to.
        pinnedVersionPrefix: string
        /// Service account to associate with the item consumer.
        serviceAccountId: Option<string>
        /// List of event types to create flow triggers for (values can be mention, assign or assign_reviewer).
        triggerTypes: Option<list<string>>
    }

/// Autogenerated input type of AiCatalogItemReport
type AiCatalogItemReportInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog item to report.
        id: string
        /// Reason for reporting the catalog item.
        reason: AiCatalogItemReportReason
        /// Additional details about the report. Limited to 1000 characters.
        body: Option<string>
    }

/// Autogenerated input type of AiCatalogThirdPartyFlowCreate
type AiCatalogThirdPartyFlowCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description for the Flow.
        description: string
        /// Name for the Flow.
        name: string
        /// Project for the Flow.
        projectId: string
        /// Whether the Flow is publicly visible in the catalog.
        ``public``: bool
        /// Whether to release the latest version of the Flow.
        release: Option<bool>
        /// Whether to add to the project upon creation.
        addToProjectWhenCreated: Option<bool>
        /// YAML definition for the Flow.
        definition: string
    }

/// Autogenerated input type of AiCatalogThirdPartyFlowDelete
type AiCatalogThirdPartyFlowDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog Third Party Flow to delete.
        id: string
        /// When true, the Third Party Flow will always be hard deleted and never soft deleted. Can only be used by instance admins
        forceHardDelete: Option<bool>
    }

/// Autogenerated input type of AiCatalogThirdPartyFlowUpdate
type AiCatalogThirdPartyFlowUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the catalog Flow to update.
        id: string
        /// Description for the Flow.
        description: Option<string>
        /// Name for the Flow.
        name: Option<string>
        /// Whether the Flow is publicly visible in the catalog.
        ``public``: Option<bool>
        /// Whether to release the latest version of the Flow.
        release: Option<bool>
        /// YAML definition for the Flow.
        definition: Option<string>
        /// Bump version, calculated from the last released version name.
        versionBump: Option<AiCatalogVersionBump>
    }

type AiChatInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: Option<string>
        /// Global ID of the namespace the user is acting on.
        namespaceId: Option<string>
        /// Global ID of the agent version to answer the chat.
        agentVersionId: Option<string>
        /// Content of the message.
        content: string
        /// Information about currently selected text which can be passed for additional context.
        currentFile: Option<AiCurrentFileInput>
        /// Additional context to be passed for the chat.
        additionalContext: Option<list<AiAdditionalContextInput>>
    }

type AiCurrentFileInput =
    {
        /// File name.
        fileName: string
        /// Selected text.
        selectedText: string
        /// Content above cursor.
        contentAboveCursor: Option<string>
        /// Content below cursor.
        contentBelowCursor: Option<string>
    }

type AiDescriptionComposerInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// ID of the project where the changes are from.
        sourceProjectId: Option<string>
        /// Source branch of the changes.
        sourceBranch: Option<string>
        /// Target branch of where the changes will be merged into.
        targetBranch: Option<string>
        /// Current description.
        description: string
        /// Current merge request title.
        title: string
        /// Prompt from user.
        userPrompt: string
        /// Previously AI-generated description content used for context in iterative refinements or follow-up prompts.
        previousResponse: Option<string>
    }

/// Autogenerated input type of AiDuoWorkflowCreate
type AiDuoWorkflowCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project the user is acting on.
        projectId: Option<string>
        /// Global ID of the namespace the user is acting on.
        namespaceId: Option<string>
        /// Goal of the workflow.
        goal: Option<string>
        /// Actions the agent is allowed to perform.
        agentPrivileges: Option<list<int>>
        /// Actions the agent can perform without asking for approval.
        preApprovedAgentPrivileges: Option<list<int>>
        /// Workflow type based on its capability.
        workflowDefinition: Option<string>
        /// When enabled, Duo Agent Platform may stop to ask the user questions before proceeding.
        allowAgentToRequestUser: Option<bool>
        /// Environment for the workflow.
        environment: Option<WorkflowEnvironment>
        /// ID of the catalog item the workflow is triggered from.
        aiCatalogItemVersionId: Option<string>
        /// IID of the noteable (Issue) that the workflow is associated with.
        issueId: Option<string>
        /// IID of the noteable (MergeRequest) that the workflow is associated with.
        mergeRequestId: Option<string>
    }

type AiExplainVulnerabilityInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// Include vulnerablility source code in the AI prompt.
        includeSourceCode: Option<bool>
    }

/// Autogenerated input type of AiFeatureSettingUpdate
type AiFeatureSettingUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Array of AI features being configured (for single or batch update).
        features: list<AiFeatures>
        /// Provider for AI setting.
        provider: AiFeatureProviders
        /// Global ID of the self-hosted model providing the AI setting.
        aiSelfHostedModelId: Option<string>
        /// Identifier of the selected model for the feature.
        offeredModelRef: Option<string>
    }

/// Autogenerated input type of AiFlowTriggerCreate
type AiFlowTriggerCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the AI flow trigger is associated with.
        projectPath: string
        /// Owner of the AI flow trigger.
        userId: string
        /// Description of the AI flow trigger.
        description: string
        /// Event types that triggers the AI flow.
        eventTypes: Option<list<int>>
        /// Path to the configuration file for the AI flow trigger.
        configPath: Option<string>
        /// AI catalog item consumer to use instead of config_path.
        aiCatalogItemConsumerId: Option<string>
    }

/// Autogenerated input type of AiFlowTriggerDelete
type AiFlowTriggerDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the flow trigger to delete.
        id: string
    }

/// Autogenerated input type of AiFlowTriggerUpdate
type AiFlowTriggerUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the flow trigger to update.
        id: string
        /// Owner of the AI flow trigger.
        userId: Option<string>
        /// Description of the AI flow trigger.
        description: Option<string>
        /// Event types that triggers the AI flow.
        eventTypes: Option<list<int>>
        /// Path to the configuration file for the AI flow trigger.
        configPath: Option<string>
        /// AI catalog item consumer to use instead of config_path.
        aiCatalogItemConsumerId: Option<string>
    }

type AiGenerateCommitMessageInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
    }

type AiGenerateDescriptionInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// Content of the message.
        content: string
        /// Name of the description template to use to generate message off of.
        descriptionTemplateName: Option<string>
    }

type AiMeasureCommentTemperatureInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// Content of the message.
        content: string
    }

/// Autogenerated input type of AiModelSelectionNamespaceUpdate
type AiModelSelectionNamespaceUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group for the model selection.
        groupId: string
        /// Array of AI features being configured (for single or batch update).
        features: list<AiModelSelectionFeatures>
        /// Identifier of the selected model for the feature.
        offeredModelRef: string
    }

type AiResolveVulnerabilityInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// Global ID of the merge request which the merge request containing the vulnerability resolution will target.
        vulnerableMergeRequestId: Option<string>
    }

/// Autogenerated input type of AiSelfHostedModelConnectionCheck
type AiSelfHostedModelConnectionCheckInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Deployment name of the self-hosted model.
        name: string
        /// AI model deployed.
        model: AiAcceptedSelfHostedModels
        /// Endpoint of the self-hosted model.
        endpoint: string
        /// API token to access the self-hosted model, if any.
        apiToken: Option<string>
        /// Identifier for 3rd party model provider.
        identifier: Option<string>
    }

/// Autogenerated input type of AiSelfHostedModelCreate
type AiSelfHostedModelCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Deployment name of the self-hosted model.
        name: string
        /// AI model deployed.
        model: AiAcceptedSelfHostedModels
        /// Endpoint of the self-hosted model.
        endpoint: string
        /// API token to access the self-hosted model, if any.
        apiToken: Option<string>
        /// Identifier for 3rd party model provider.
        identifier: Option<string>
    }

/// Autogenerated input type of AiSelfHostedModelDelete
type AiSelfHostedModelDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the self-hosted model to delete.
        id: string
    }

/// Autogenerated input type of AiSelfHostedModelUpdate
type AiSelfHostedModelUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the self-hosted model to update.
        id: string
        /// Deployment name of the self-hosted model.
        name: string
        /// AI model deployed.
        model: AiAcceptedSelfHostedModels
        /// Endpoint of the self-hosted model.
        endpoint: string
        /// API token to access the self-hosted model, if any.
        apiToken: Option<string>
        /// Identifier for 3rd party model provider.
        identifier: Option<string>
    }

/// Summarize a new merge request based on two branches. Returns `null` if the `add_ai_summary_for_new_mr` feature flag is disabled.
type AiSummarizeNewMergeRequestInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
        /// ID of the project where the changes are from.
        sourceProjectId: Option<string>
        /// Source branch of the changes.
        sourceBranch: string
        /// Target branch of where the changes will be merged into.
        targetBranch: string
    }

type AiSummarizeReviewInput =
    {
        /// Global ID of the resource to mutate.
        resourceId: string
    }

/// Field that are available while modifying the custom mapping attributes for an HTTP integration
type AlertManagementPayloadAlertFieldInput =
    {
        /// GitLab alert field name.
        fieldName: AlertManagementPayloadAlertFieldName
        /// Path to value inside payload JSON.
        path: list<string>
        /// Human-readable label of the payload path.
        label: Option<string>
        /// Type of the parsed value.
        ``type``: AlertManagementPayloadAlertFieldType
    }

/// Autogenerated input type of AlertSetAssignees
type AlertSetAssigneesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the alert to mutate is in.
        projectPath: string
        /// IID of the alert to mutate.
        iid: string
        /// Usernames to assign to the alert. Replaces existing assignees by default.
        assigneeUsernames: list<string>
        /// Operation to perform. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of AlertTodoCreate
type AlertTodoCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the alert to mutate is in.
        projectPath: string
        /// IID of the alert to mutate.
        iid: string
    }

/// Input type for filtering projects by analyzer type and status
type AnalyzerFilterInput =
    {
        /// Type of analyzer to filter by.
        analyzerType: AnalyzerTypeEnum
        /// Status of the analyzer to filter by.
        status: AnalyzerStatusEnum
    }

/// Autogenerated input type of ApproveDeployment
type ApproveDeploymentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the deployment.
        id: string
        /// Status of the approval (either `APPROVED` or `REJECTED`).
        status: DeploymentsApprovalStatus
        /// Comment to go with the approval.
        comment: Option<string>
        /// Name of the User/Group/Role to use for the approval, when the user belongs to multiple approval rules.
        representedAs: Option<string>
    }

/// Autogenerated input type of ArtifactDestroy
type ArtifactDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the artifact to delete.
        id: string
    }

/// Input type for filtering projects by security attributes
type AttributeFilterInput =
    {
        /// Operator to apply for the attribute filter.
        operator: AttributeFilterOperator
        /// Global IDs of the security attributes to filter by. Up to 20 values.
        attributes: list<string>
    }

/// Autogenerated input type of AuditEventsAmazonS3ConfigurationCreate
type AuditEventsAmazonS3ConfigurationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Group path.
        groupPath: string
        /// Access key ID of the Amazon S3 account.
        accessKeyXid: string
        /// Secret access key of the Amazon S3 account.
        secretAccessKey: string
        /// Name of the bucket where the audit events would be logged.
        bucketName: string
        /// AWS region where the bucket is created.
        awsRegion: string
    }

/// Autogenerated input type of AuditEventsAmazonS3ConfigurationDelete
type AuditEventsAmazonS3ConfigurationDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Amazon S3 configuration to destroy.
        id: string
    }

/// Autogenerated input type of AuditEventsAmazonS3ConfigurationUpdate
type AuditEventsAmazonS3ConfigurationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Amazon S3 configuration to update.
        id: string
        /// Destination name.
        name: Option<string>
        /// Access key ID of the Amazon S3 account.
        accessKeyXid: Option<string>
        /// Secret access key of the Amazon S3 account.
        secretAccessKey: Option<string>
        /// Name of the bucket where the audit events would be logged.
        bucketName: Option<string>
        /// Active status of the destination.
        active: Option<bool>
        /// AWS region where the bucket is created.
        awsRegion: Option<string>
    }

/// Autogenerated input type of AuditEventsGroupDestinationEventsAdd
type AuditEventsGroupDestinationEventsAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to add for streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsGroupDestinationEventsDelete
type AuditEventsGroupDestinationEventsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to remove from streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsGroupDestinationNamespaceFilterCreate
type AuditEventsGroupDestinationNamespaceFilterCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination ID.
        destinationId: string
        /// Full path of the namespace(only project or group).
        namespacePath: Option<string>
    }

/// Autogenerated input type of AuditEventsGroupDestinationNamespaceFilterDelete
type AuditEventsGroupDestinationNamespaceFilterDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace filter ID.
        namespaceFilterId: string
    }

/// Autogenerated input type of AuditEventsInstanceAmazonS3ConfigurationCreate
type AuditEventsInstanceAmazonS3ConfigurationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Access key ID of the Amazon S3 account.
        accessKeyXid: string
        /// Secret access key of the Amazon S3 account.
        secretAccessKey: string
        /// Name of the bucket where the audit events would be logged.
        bucketName: string
        /// AWS region where the bucket is created.
        awsRegion: string
    }

/// Autogenerated input type of AuditEventsInstanceAmazonS3ConfigurationDelete
type AuditEventsInstanceAmazonS3ConfigurationDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the instance-level Amazon S3 configuration to delete.
        id: string
    }

/// Autogenerated input type of AuditEventsInstanceAmazonS3ConfigurationUpdate
type AuditEventsInstanceAmazonS3ConfigurationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the instance-level Amazon S3 configuration to update.
        id: string
        /// Destination name.
        name: Option<string>
        /// Access key ID of the Amazon S3 account.
        accessKeyXid: Option<string>
        /// Secret access key of the Amazon S3 account.
        secretAccessKey: Option<string>
        /// Name of the bucket where the audit events would be logged.
        bucketName: Option<string>
        /// AWS region where the bucket is created.
        awsRegion: Option<string>
        /// Active status of the destination.
        active: Option<bool>
    }

/// Autogenerated input type of AuditEventsInstanceDestinationEventsAdd
type AuditEventsInstanceDestinationEventsAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to add for streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsInstanceDestinationEventsDelete
type AuditEventsInstanceDestinationEventsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to remove from streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsInstanceDestinationNamespaceFilterCreate
type AuditEventsInstanceDestinationNamespaceFilterCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination ID.
        destinationId: string
        /// Full path of the namespace. Project or group namespaces only.
        namespacePath: Option<string>
    }

/// Autogenerated input type of AuditEventsInstanceDestinationNamespaceFilterDelete
type AuditEventsInstanceDestinationNamespaceFilterDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace filter ID.
        namespaceFilterId: string
    }

/// Autogenerated input type of AuditEventsStreamingDestinationEventsAdd
type AuditEventsStreamingDestinationEventsAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to add for streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsStreamingDestinationEventsRemove
type AuditEventsStreamingDestinationEventsRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to remove from streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsStreamingDestinationInstanceEventsAdd
type AuditEventsStreamingDestinationInstanceEventsAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to add for streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsStreamingDestinationInstanceEventsRemove
type AuditEventsStreamingDestinationInstanceEventsRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of event type filters to remove from streaming.
        eventTypeFilters: list<string>
        /// Destination id.
        destinationId: string
    }

/// Autogenerated input type of AuditEventsStreamingHTTPNamespaceFiltersAdd
type AuditEventsStreamingHTTPNamespaceFiltersAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination ID.
        destinationId: string
        /// Full path of the group.
        groupPath: Option<string>
        /// Full path of the project.
        projectPath: Option<string>
    }

/// Autogenerated input type of AuditEventsStreamingHTTPNamespaceFiltersDelete
type AuditEventsStreamingHTTPNamespaceFiltersDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace filter ID.
        namespaceFilterId: string
    }

/// Autogenerated input type of AuditEventsStreamingHeadersCreate
type AuditEventsStreamingHeadersCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header key.
        key: string
        /// Header value.
        value: string
        /// Destination to associate header with.
        destinationId: string
        /// Boolean option determining whether header is active or not.
        active: Option<bool>
    }

/// Autogenerated input type of AuditEventsStreamingHeadersDestroy
type AuditEventsStreamingHeadersDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header to delete.
        headerId: string
    }

/// Autogenerated input type of AuditEventsStreamingHeadersUpdate
type AuditEventsStreamingHeadersUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header to update.
        headerId: string
        /// Header key.
        key: Option<string>
        /// Header value.
        value: Option<string>
        /// Boolean option determining whether header is active or not.
        active: Option<bool>
    }

/// Autogenerated input type of AuditEventsStreamingInstanceHeadersCreate
type AuditEventsStreamingInstanceHeadersCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header key.
        key: string
        /// Header value.
        value: string
        /// Instance level external destination to associate header with.
        destinationId: string
        /// Boolean option determining whether header is active or not.
        active: Option<bool>
    }

/// Autogenerated input type of AuditEventsStreamingInstanceHeadersDestroy
type AuditEventsStreamingInstanceHeadersDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header to delete.
        headerId: string
    }

/// Autogenerated input type of AuditEventsStreamingInstanceHeadersUpdate
type AuditEventsStreamingInstanceHeadersUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Header to update.
        headerId: string
        /// Header key.
        key: Option<string>
        /// Header value.
        value: Option<string>
        /// Boolean option determining whether header is active or not.
        active: Option<bool>
    }

/// Autogenerated input type of AwardEmojiAdd
type AwardEmojiAddInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the awardable resource.
        awardableId: string
        /// Emoji name.
        name: string
    }

/// Autogenerated input type of AwardEmojiRemove
type AwardEmojiRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the awardable resource.
        awardableId: string
        /// Emoji name.
        name: string
    }

/// Autogenerated input type of AwardEmojiToggle
type AwardEmojiToggleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the awardable resource.
        awardableId: string
        /// Emoji name.
        name: string
    }

/// Autogenerated input type of BoardEpicCreate
type BoardEpicCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group the epic to create is in.
        groupPath: string
        /// Global ID of the board that the epic is in.
        boardId: string
        /// Global ID of the epic board list in which epic will be created.
        listId: string
        /// Title of the epic.
        title: string
    }

type BoardIssueInput =
    {
        /// Filter by label name.
        labelName: Option<list<Option<string>>>
        /// Filter by author username.
        authorUsername: Option<string>
        /// Filter by reaction emoji applied by the current user. Wildcard values "NONE" and "ANY" are supported.
        myReactionEmoji: Option<string>
        /// List of IIDs of issues. For example `["1", "2"]`.
        iids: Option<list<string>>
        /// Filter by milestone title.
        milestoneTitle: Option<string>
        /// Filter by assignee username.
        assigneeUsername: Option<list<Option<string>>>
        /// Filter by release tag.
        releaseTag: Option<string>
        /// Filter by the given issue types.
        types: Option<list<IssueType>>
        /// Filter by milestone ID wildcard.
        milestoneWildcardId: Option<MilestoneWildcardId>
        /// Filter by iteration title.
        iterationTitle: Option<string>
        /// Filter by weight.
        weight: Option<string>
        /// Filter by a list of iteration IDs. Incompatible with iterationWildcardId.
        iterationId: Option<list<string>>
        /// List of negated arguments.
        ``not``: Option<NegatedBoardIssueInput>
        /// List of arguments with inclusive OR.
        ``or``: Option<UnionedIssueFilterInput>
        /// Search query for issue title or description.
        search: Option<string>
        /// Filter by assignee wildcard. Incompatible with assigneeUsername and assigneeUsernames.
        assigneeWildcardId: Option<AssigneeWildcardId>
        /// Filter by confidentiality.
        confidential: Option<bool>
        /// Filter by epic ID wildcard. Incompatible with epicId.
        epicWildcardId: Option<EpicWildcardId>
        /// Whether to include subepics when filtering issues by epicId.
        includeSubepics: Option<bool>
        /// Filter by iteration ID wildcard.
        iterationWildcardId: Option<IterationWildcardId>
        /// Filter by a list of iteration cadence IDs.
        iterationCadenceId: Option<list<string>>
        /// Filter by weight ID wildcard. Incompatible with weight.
        weightWildcardId: Option<WeightWildcardId>
        /// Health status of the issue, "none" and "any" values are supported.
        healthStatusFilter: Option<HealthStatusFilter>
    }

/// Autogenerated input type of BoardListCreate
type BoardListCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Create the backlog list.
        backlog: Option<bool>
        /// Global ID of an existing label.
        labelId: Option<string>
        /// Global ID of the issue board to mutate.
        boardId: string
        /// Position of the list.
        position: Option<int>
        /// Global ID of an existing milestone.
        milestoneId: Option<string>
        /// Global ID of an existing iteration.
        iterationId: Option<string>
        /// Global ID of an existing user.
        assigneeId: Option<string>
    }

/// Autogenerated input type of BoardListUpdateLimitMetrics
type BoardListUpdateLimitMetricsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the list.
        listId: string
        /// New limit metric type for the list.
        limitMetric: Option<ListLimitMetric>
        /// New maximum issue count limit.
        maxIssueCount: Option<int>
        /// New maximum issue weight limit.
        maxIssueWeight: Option<int>
    }

/// Autogenerated input type of BranchDelete
type BranchDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the branch is associated with.
        projectPath: string
        /// Name of the branch.
        name: string
    }

type BranchProtectionInput =
    {
        /// Details about who can merge into the branch rule target.
        mergeAccessLevels: Option<list<MergeAccessLevelInput>>
        /// Details about who can push to the branch rule target.
        pushAccessLevels: Option<list<PushAccessLevelInput>>
        /// Allows users with write access to the branch rule target to force push changes.
        allowForcePush: Option<bool>
        /// Enforce code owner approvals before allowing a merge.
        codeOwnerApprovalRequired: Option<bool>
    }

/// Autogenerated input type of BranchRuleCreate
type BranchRuleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path to the project that the branch is associated with.
        projectPath: string
        /// Branch name, with wildcards, for the branch rules.
        name: string
    }

/// Autogenerated input type of BranchRuleDelete
type BranchRuleDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule to destroy.
        id: string
    }

/// Autogenerated input type of BranchRuleExternalStatusCheckCreate
type BranchRuleExternalStatusCheckCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule to update.
        branchRuleId: string
        /// Name of the external status check.
        name: string
        /// URL of external status check resource.
        externalUrl: string
    }

/// Autogenerated input type of BranchRuleExternalStatusCheckDestroy
type BranchRuleExternalStatusCheckDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the external status check to destroy.
        id: string
        /// Global ID of the branch rule.
        branchRuleId: string
    }

/// Autogenerated input type of BranchRuleExternalStatusCheckUpdate
type BranchRuleExternalStatusCheckUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the external status check to update.
        id: string
        /// Global ID of the branch rule.
        branchRuleId: string
        /// Name of the external status check.
        name: string
        /// External URL of the external status check.
        externalUrl: string
    }

/// Autogenerated input type of BranchRuleSquashOptionDelete
type BranchRuleSquashOptionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule.
        branchRuleId: string
    }

/// Autogenerated input type of BranchRuleSquashOptionUpdate
type BranchRuleSquashOptionUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule.
        branchRuleId: string
        /// Squash option after mutation.
        squashOption: SquashOptionSetting
    }

/// Autogenerated input type of BranchRuleUpdate
type BranchRuleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule to update.
        id: string
        /// Branch name, with wildcards, for the branch rules.
        name: string
        /// Branch protections configured for the branch rule.
        branchProtection: Option<BranchProtectionInput>
    }

/// Autogenerated input type of BulkDestroyJobArtifacts
type BulkDestroyJobArtifactsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the job artifacts to destroy.
        ids: list<string>
        /// Global Project ID of the job artifacts to destroy. Incompatible with projectPath.
        projectId: string
    }

/// Autogenerated input type of BulkEnableDevopsAdoptionNamespaces
type BulkEnableDevopsAdoptionNamespacesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List of Namespace IDs.
        namespaceIds: list<string>
        /// Display namespace ID.
        displayNamespaceId: Option<string>
    }

/// Autogenerated input type of BulkRunnerDelete
type BulkRunnerDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IDs of the runners to delete.
        ids: Option<list<string>>
    }

/// Autogenerated input type of BulkUpdateSecurityAttributes
type BulkUpdateSecurityAttributesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of groups and projects to update.
        items: list<string>
        /// Global IDs of security attributes to apply.
        attributes: list<string>
        /// Update mode: add, remove, or replace attributes.
        mode: SecurityAttributeBulkUpdateMode
    }

/// Autogenerated input type of CatalogResourcesCreate
type CatalogResourcesCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path belonging to the catalog resource.
        projectPath: string
    }

/// Autogenerated input type of CatalogResourcesDestroy
type CatalogResourcesDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path belonging to the catalog resource.
        projectPath: string
    }

/// Attributes for defining an input.
type CiInputsInput =
    {
        /// Name of the input.
        name: string
        /// Value of the input.
        value: string
        /// Set to `true` to delete the input.
        destroy: Option<bool>
    }

/// Autogenerated input type of CiJobTokenScopeAddGroupOrProject
type CiJobTokenScopeAddGroupOrProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project that the CI job token scope belongs to.
        projectPath: string
        /// Group or project to be added to the CI job token scope.
        targetPath: string
    }

/// Autogenerated input type of CiJobTokenScopeAddProject
type CiJobTokenScopeAddProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project that the CI job token scope belongs to.
        projectPath: string
        /// Project to be added to the CI job token scope.
        targetProjectPath: string
    }

/// Autogenerated input type of CiJobTokenScopeAutopopulateAllowlist
type CiJobTokenScopeAutopopulateAllowlistInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project in which to autopopulate the allowlist.
        projectPath: string
    }

/// Autogenerated input type of CiJobTokenScopeClearAllowlistAutopopulations
type CiJobTokenScopeClearAllowlistAutopopulationsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project in which to autopopulate the allowlist.
        projectPath: string
    }

/// Autogenerated input type of CiJobTokenScopeRemoveGroup
type CiJobTokenScopeRemoveGroupInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project that the CI job token scope belongs to.
        projectPath: string
        /// Group to be removed from the CI job token scope.
        targetGroupPath: string
    }

/// Autogenerated input type of CiJobTokenScopeRemoveProject
type CiJobTokenScopeRemoveProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project that the CI job token scope belongs to.
        projectPath: string
        /// Project to be removed from the CI job token scope.
        targetProjectPath: string
    }

/// Autogenerated input type of CiJobTokenScopeUpdatePolicies
type CiJobTokenScopeUpdatePoliciesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project that the CI job token scope belongs to.
        projectPath: string
        /// Group or project that the CI job token targets.
        targetPath: string
        /// Indicates whether default permissions are enabled (true) or fine-grained permissions are enabled (false).
        defaultPermissions: bool
        /// List of policies added to the CI job token scope.
        jobTokenPolicies: list<CiJobTokenScopePolicies>
    }

/// Autogenerated input type of CiLint
type CiLintInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the CI config.
        projectPath: string
        /// Contents of `.gitlab-ci.yml`.
        content: string
        /// Ref to use when linting. Default is the project default branch.
        ref: Option<string>
        /// Run pipeline creation simulation, or only do static check.
        dryRun: Option<bool>
    }

/// Attributes for defining a CI/CD variable.
type CiVariableInput =
    {
        /// Name of the variable.
        key: string
        /// Value of the variable.
        value: string
        /// Type of variable.
        variableType: Option<CiVariableType>
    }

/// Autogenerated input type of ClusterAgentDelete
type ClusterAgentDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the cluster agent that will be deleted.
        id: string
    }

/// Autogenerated input type of ClusterAgentTokenCreate
type ClusterAgentTokenCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the cluster agent that will be associated with the new token.
        clusterAgentId: string
        /// Description of the token.
        description: Option<string>
        /// Name of the token.
        name: string
    }

/// Autogenerated input type of ClusterAgentTokenRevoke
type ClusterAgentTokenRevokeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the agent token that will be revoked.
        id: string
    }

/// Autogenerated input type of ClusterAgentUrlConfigurationCreate
type ClusterAgentUrlConfigurationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the cluster agent that will be associated with the new URL configuration.
        clusterAgentId: string
        /// URL for the new URL configuration.
        url: string
        /// Base64-encoded client certificate in PEM format if mTLS authentication should be used. Must be provided with `client_key`.
        clientCert: Option<string>
        /// Base64-encoded client key in PEM format if mTLS authentication should be used. Must be provided with `client_cert`.
        clientKey: Option<string>
        /// Base64-encoded CA certificate in PEM format to verify the agent endpoint.
        caCert: Option<string>
        /// TLS host name to verify the server name in agent endpoint certificate.
        tlsHost: Option<string>
    }

/// Autogenerated input type of ClusterAgentUrlConfigurationDelete
type ClusterAgentUrlConfigurationDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the agent URL configuration that will be deleted.
        id: string
    }

type CommitAction =
    {
        /// Action to perform: create, delete, move, update, or chmod.
        action: CommitActionMode
        /// Content of the file.
        content: Option<string>
        /// Encoding of the file. Default is text.
        encoding: Option<CommitEncoding>
        /// Enables/disables the execute flag on the file.
        executeFilemode: Option<bool>
        /// Full path to the file.
        filePath: string
        /// Last known file commit ID.
        lastCommitId: Option<string>
        /// Original full path to the file being moved.
        previousPath: Option<string>
    }

/// Autogenerated input type of CommitCreate
type CommitCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the branch is associated with.
        projectPath: string
        /// Name of the branch to commit into, it can be a new branch.
        branch: string
        /// If on a new branch, name of the original branch.
        startBranch: Option<string>
        /// Raw commit message.
        message: string
        /// Array of action hashes to commit as a batch.
        actions: list<CommitAction>
    }

type ComplianceFrameworkFilters =
    {
        /// ID of the compliance framework.
        id: Option<string>
        /// IDs of the compliance framework.
        ids: Option<list<string>>
        /// Negated compliance framework filter input.
        ``not``: Option<NegatedComplianceFrameworkFilters>
        /// Checks presence of compliance framework of the project, "none" and "any" values are supported.
        presenceFilter: Option<ComplianceFrameworkPresenceFilter>
    }

type ComplianceFrameworkInput =
    {
        /// New name for the compliance framework.
        name: Option<string>
        /// New description for the compliance framework.
        description: Option<string>
        /// New color representation of the compliance framework in hex format. e.g. #FCA121.
        color: Option<string>
        /// Set the compliance framework as the default framework for the group.
        ``default``: Option<bool>
        /// Projects to add or remove from the compliance framework.
        projects: Option<ComplianceFrameworkProjectInput>
    }

type ComplianceFrameworkProjectInput =
    {
        /// IDs of the projects to add to the compliance framework.
        addProjects: list<int>
        /// IDs of the projects to remove from the compliance framework.
        removeProjects: list<int>
    }

type ComplianceRequirementInput =
    {
        /// New name for the compliance requirement.
        name: Option<string>
        /// New description for the compliance requirement.
        description: Option<string>
        /// Compliance controls of the compliance requirement.
        complianceRequirementsControls: Option<list<ComplianceRequirementsControlInput>>
    }

type ComplianceRequirementsControlInput =
    {
        /// New name for the compliance requirement control.
        name: string
        /// Expression of the compliance control.
        expression: Option<string>
        /// Type of the compliance control.
        controlType: Option<string>
        /// Name of the external control.
        externalControlName: Option<string>
        /// URL of the external control.
        externalUrl: Option<string>
        /// Secret token for an external control.
        secretToken: Option<string>
        /// Whether ping is enabled for external controls.
        pingEnabled: Option<bool>
    }

type ComplianceStandardsAdherenceInput =
    {
        /// Name of the check for the compliance standard.
        checkName: Option<ComplianceStandardsAdherenceCheckName>
        /// Name of the compliance standard.
        standard: Option<ComplianceStandardsAdherenceStandard>
        /// Filter compliance standards adherence by project.
        projectIds: Option<list<string>>
    }

type ComplianceStandardsProjectAdherenceInput =
    {
        /// Name of the check for the compliance standard.
        checkName: Option<ComplianceStandardsAdherenceCheckName>
        /// Name of the compliance standard.
        standard: Option<ComplianceStandardsAdherenceStandard>
    }

type ComplianceViolationInput =
    {
        /// Merge requests merged before the date (inclusive).
        mergedBefore: Option<string>
        /// Merge requests merged after the date (inclusive).
        mergedAfter: Option<string>
        /// Filter compliance violations by target branch.
        targetBranch: Option<string>
        /// Filter compliance violations by project.
        projectIds: Option<list<string>>
    }

type ComplianceViolationProjectInput =
    {
        /// Merge requests merged before the date (inclusive).
        mergedBefore: Option<string>
        /// Merge requests merged after the date (inclusive).
        mergedAfter: Option<string>
        /// Filter compliance violations by target branch.
        targetBranch: Option<string>
    }

/// Autogenerated input type of ConfigureContainerScanning
type ConfigureContainerScanningInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
    }

/// Autogenerated input type of ConfigureDependencyScanning
type ConfigureDependencyScanningInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
    }

/// Autogenerated input type of ConfigureSastIac
type ConfigureSastIacInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
    }

/// Autogenerated input type of ConfigureSast
type ConfigureSastInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
        /// SAST CI configuration for the project.
        configuration: SastCiConfigurationInput
    }

/// Autogenerated input type of ConfigureSecretDetection
type ConfigureSecretDetectionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
    }

/// Autogenerated input type of CorpusCreate
type CorpusCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the corpus package.
        packageId: string
        /// Project the corpus belongs to.
        fullPath: string
    }

/// Autogenerated input type of CreateAlertIssue
type CreateAlertIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the alert to mutate is in.
        projectPath: string
        /// IID of the alert to mutate.
        iid: string
    }

/// Autogenerated input type of CreateAnnotation
type CreateAnnotationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the environment to add an annotation to.
        environmentId: Option<string>
        /// Global ID of the cluster to add an annotation to.
        clusterId: Option<string>
        /// Timestamp indicating starting moment to which the annotation relates.
        startingAt: string
        /// Timestamp indicating ending moment to which the annotation relates.
        endingAt: Option<string>
        /// Path to a file defining the dashboard on which the annotation should be added.
        dashboardPath: string
        /// Description of the annotation.
        description: string
    }

/// Autogenerated input type of CreateBoard
type CreateBoardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project with which the resource is associated.
        projectPath: Option<string>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
        /// Board name.
        name: Option<string>
        /// Whether or not backlog list is hidden.
        hideBacklogList: Option<bool>
        /// Whether or not closed list is hidden.
        hideClosedList: Option<bool>
        /// ID of user to be assigned to the board.
        assigneeId: Option<string>
        /// ID of milestone to be assigned to the board.
        milestoneId: Option<string>
        /// ID of iteration to be assigned to the board.
        iterationId: Option<string>
        /// ID of iteration cadence to be assigned to the board.
        iterationCadenceId: Option<string>
        /// Weight value to be assigned to the board.
        weight: Option<int>
        /// Labels of the issue.
        labels: Option<list<string>>
        /// IDs of labels to be added to the board.
        labelIds: Option<list<string>>
    }

/// Autogenerated input type of CreateBranch
type CreateBranchInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the branch is associated with.
        projectPath: string
        /// Name of the branch.
        name: string
        /// Branch name or commit SHA to create branch from.
        ref: string
    }

/// Autogenerated input type of CreateClusterAgent
type CreateClusterAgentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the associated project for the cluster agent.
        projectPath: string
        /// Name of the cluster agent.
        name: string
    }

/// Autogenerated input type of CreateComplianceFramework
type CreateComplianceFrameworkInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace to add the compliance framework to.
        namespacePath: string
        /// Parameters to update the compliance framework with.
        ``params``: ComplianceFrameworkInput
    }

/// Autogenerated input type of CreateComplianceRequirement
type CreateComplianceRequirementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance framework of the new requirement.
        complianceFrameworkId: string
        /// Parameters to update the compliance requirement with.
        ``params``: ComplianceRequirementInput
        /// Controls to add to the compliance requirement.
        controls: Option<list<ComplianceRequirementsControlInput>>
    }

/// Autogenerated input type of CreateComplianceRequirementsControl
type CreateComplianceRequirementsControlInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance requirement of the new control.
        complianceRequirementId: string
        /// Parameters to create the compliance requirement control.
        ``params``: ComplianceRequirementsControlInput
    }

/// Autogenerated input type of CreateContainerProtectionRepositoryRule
type CreateContainerProtectionRepositoryRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project where a protection rule is located.
        projectPath: string
        /// Container repository path pattern protected by the protection rule. Must start with the project’s full path. For example: `my-project/*-prod-*`. Wildcard character `*` is allowed anywhere after the project’s full path.
        repositoryPathPattern: string
        /// Minimum GitLab access level required to delete container images from the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForDelete: Option<ContainerProtectionRepositoryRuleAccessLevel>
        /// Minimum GitLab access level required to push container images to the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForPush: Option<ContainerProtectionRepositoryRuleAccessLevel>
    }

/// Autogenerated input type of CreateCustomEmoji
type CreateCustomEmojiInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace full path the emoji is associated with.
        groupPath: string
        /// Name of the emoji.
        name: string
        /// Location of the emoji file.
        url: string
    }

/// Autogenerated input type of CreateDiffNote
type CreateDiffNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the resource to add a note to.
        noteableId: string
        /// Content of the note.
        body: string
        /// Internal flag for a note. Default is false.
        ``internal``: Option<bool>
        /// Position of the note on a diff.
        position: DiffPositionInput
    }

/// Autogenerated input type of CreateDiscussion
type CreateDiscussionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the resource to add a note to.
        noteableId: string
        /// Content of the note.
        body: string
        /// Internal flag for a note. Default is false.
        ``internal``: Option<bool>
    }

/// Autogenerated input type of CreateEpic
type CreateEpicInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group the epic to mutate is in.
        groupPath: string
        /// Title of the epic.
        title: Option<string>
        /// Description of the epic.
        description: Option<string>
        /// Indicates if the epic is confidential.
        confidential: Option<bool>
        /// Start date of the epic.
        startDateFixed: Option<string>
        /// End date of the epic.
        dueDateFixed: Option<string>
        /// Indicates start date should be sourced from start_date_fixed field not the issue milestones.
        startDateIsFixed: Option<bool>
        /// Indicates end date should be sourced from due_date_fixed field not the issue milestones.
        dueDateIsFixed: Option<bool>
        /// IDs of labels to be added to the epic.
        addLabelIds: Option<list<string>>
        /// IDs of labels to be removed from the epic.
        removeLabelIds: Option<list<string>>
        /// Array of labels to be added to the epic.
        addLabels: Option<list<string>>
        /// Color of the epic.
        color: Option<string>
    }

/// Autogenerated input type of CreateImageDiffNote
type CreateImageDiffNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the resource to add a note to.
        noteableId: string
        /// Content of the note.
        body: string
        /// Internal flag for a note. Default is false.
        ``internal``: Option<bool>
        /// Position of the note on a diff.
        position: DiffImagePositionInput
    }

/// Autogenerated input type of CreateIssue
type CreateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the issue.
        description: Option<string>
        /// Due date of the issue.
        dueDate: Option<string>
        /// Indicates the issue is confidential.
        confidential: Option<bool>
        /// Indicates discussion is locked on the issue.
        locked: Option<bool>
        /// Type of the issue.
        ``type``: Option<IssueType>
        /// Project full path the issue is associated with.
        projectPath: string
        /// IID (internal ID) of a project issue. Only admins and project owners can modify.
        iid: Option<int>
        /// Title of the issue.
        title: string
        /// ID of the milestone to assign to the issue. On update milestone will be removed if set to null.
        milestoneId: Option<string>
        /// Labels of the issue.
        labels: Option<list<string>>
        /// IDs of labels to be added to the issue.
        labelIds: Option<list<string>>
        /// Timestamp when the issue was created. Available only for admins and project owners.
        createdAt: Option<string>
        /// IID of a merge request for which to resolve discussions.
        mergeRequestToResolveDiscussionsOf: Option<string>
        /// ID of a discussion to resolve. Also pass `merge_request_to_resolve_discussions_of`.
        discussionToResolve: Option<string>
        /// Array of user IDs to assign to the issue.
        assigneeIds: Option<list<string>>
        /// Global ID of issue that should be placed before the current issue.
        moveBeforeId: Option<string>
        /// Global ID of issue that should be placed after the current issue.
        moveAfterId: Option<string>
        /// Desired health status.
        healthStatus: Option<HealthStatus>
        /// Weight of the issue.
        weight: Option<int>
        /// Global iteration ID. Mutually exlusive argument with `iterationWildcardId`.
        iterationId: Option<string>
        /// Iteration wildcard ID. Supported values are: `CURRENT`. Mutually exclusive argument with `iterationId`. iterationCadenceId also required when this argument is provided.
        iterationWildcardId: Option<IssueCreationIterationWildcardId>
        /// Global iteration cadence ID. Required when `iterationWildcardId` is provided.
        iterationCadenceId: Option<string>
        /// Global ID of the status.
        statusId: Option<string>
    }

/// Autogenerated input type of CreateIteration
type CreateIterationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project with which the resource is associated.
        projectPath: Option<string>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
        /// Global ID of the iteration cadence to be assigned to the new iteration.
        iterationsCadenceId: Option<string>
        /// Title of the iteration.
        title: Option<string>
        /// Description of the iteration.
        description: Option<string>
        /// Start date of the iteration.
        startDate: Option<string>
        /// End date of the iteration.
        dueDate: Option<string>
    }

/// Autogenerated input type of CreateNote
type CreateNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the resource to add a note to.
        noteableId: string
        /// Content of the note.
        body: string
        /// Internal flag for a note. Default is false.
        ``internal``: Option<bool>
        /// Global ID of the discussion the note is in reply to.
        discussionId: Option<string>
        /// SHA of the head commit which is used to ensure that the merge request has not been updated since the request was sent.
        mergeRequestDiffHeadSha: Option<string>
    }

/// Autogenerated input type of CreatePackagesProtectionRule
type CreatePackagesProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project where a protection rule is located.
        projectPath: string
        /// Package name protected by the protection rule. For example, `@my-scope/my-package-*`. Wildcard character `*` allowed.
        packageNamePattern: string
        /// Package type protected by the protection rule. For example, `NPM`, `PYPI`.
        packageType: PackagesProtectionRulePackageType
        /// Minimum GitLab access required to push packages to the package registry. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForPush: Option<PackagesProtectionRuleAccessLevel>
    }

/// Autogenerated input type of CreateRequirement
type CreateRequirementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Title of the requirement.
        title: Option<string>
        /// Description of the requirement.
        description: Option<string>
        /// Full project path the requirement is associated with.
        projectPath: string
    }

/// Autogenerated input type of CreateSnippet
type CreateSnippetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Title of the snippet.
        title: string
        /// Description of the snippet.
        description: Option<string>
        /// Visibility level of the snippet.
        visibilityLevel: VisibilityLevelsEnum
        /// Full path of the project the snippet is associated with.
        projectPath: Option<string>
        /// Paths to files uploaded in the snippet description.
        uploadedFiles: Option<list<string>>
        /// Actions to perform over the snippet repository and blobs.
        blobActions: Option<list<SnippetBlobActionInputType>>
    }

/// Autogenerated input type of CreateTestCase
type CreateTestCaseInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Test case title.
        title: string
        /// Test case description.
        description: Option<string>
        /// IDs of labels to be added to the test case.
        labelIds: Option<list<string>>
        /// Project full path to create the test case in.
        projectPath: string
        /// Sets the test case confidentiality.
        confidential: Option<bool>
    }

/// Attributes to create value stream stage.
type CreateValueStreamStageInput =
    {
        /// Name of the stage.
        name: string
        /// Whether the stage is customized. If false, it assigns a built-in default stage by name.
        custom: Option<bool>
        /// End event identifier.
        endEventIdentifier: Option<ValueStreamStageEvent>
        /// Label ID associated with the end event identifier.
        endEventLabelId: Option<string>
        /// Whether the stage is hidden.
        hidden: Option<bool>
        /// Start event identifier.
        startEventIdentifier: Option<ValueStreamStageEvent>
        /// Label ID associated with the start event identifier.
        startEventLabelId: Option<string>
    }

/// Autogenerated input type of CustomFieldArchive
type CustomFieldArchiveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the custom field.
        id: string
    }

/// Autogenerated input type of CustomFieldCreate
type CustomFieldCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group path where the custom field is created.
        groupPath: string
        /// Type of custom field.
        fieldType: CustomFieldType
        /// Name of the custom field.
        name: string
        /// Available options for a select field.
        selectOptions: Option<list<CustomFieldSelectOptionInput>>
        /// Work item type global IDs associated to the custom field.
        workItemTypeIds: Option<list<string>>
    }

/// Attributes for the custom field select option
type CustomFieldSelectOptionInput =
    {
        /// Global ID of the custom field select option to update. Creates a new record if not provided.
        id: Option<string>
        /// Value of the custom field select option.
        value: string
    }

/// Autogenerated input type of CustomFieldUnarchive
type CustomFieldUnarchiveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the custom field.
        id: string
    }

/// Autogenerated input type of CustomFieldUpdate
type CustomFieldUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the custom field.
        id: string
        /// Name of the custom field.
        name: Option<string>
        /// Available options for a select field.
        selectOptions: Option<list<CustomFieldSelectOptionInput>>
        /// Work item type global IDs associated to the custom field.
        workItemTypeIds: Option<list<string>>
    }

/// Autogenerated input type of CustomerRelationsContactCreate
type CustomerRelationsContactCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group for the contact.
        groupId: string
        /// Organization for the contact.
        organizationId: Option<string>
        /// First name of the contact.
        firstName: string
        /// Last name of the contact.
        lastName: string
        /// Phone number of the contact.
        phone: Option<string>
        /// Email address of the contact.
        email: Option<string>
        /// Description of or notes for the contact.
        description: Option<string>
    }

/// Autogenerated input type of CustomerRelationsContactUpdate
type CustomerRelationsContactUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the contact.
        id: string
        /// Organization of the contact.
        organizationId: Option<string>
        /// First name of the contact.
        firstName: Option<string>
        /// Last name of the contact.
        lastName: Option<string>
        /// Phone number of the contact.
        phone: Option<string>
        /// Email address of the contact.
        email: Option<string>
        /// Description of or notes for the contact.
        description: Option<string>
        /// State of the contact.
        active: Option<bool>
    }

/// Autogenerated input type of CustomerRelationsOrganizationCreate
type CustomerRelationsOrganizationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group for the organization.
        groupId: string
        /// Name of the organization.
        name: string
        /// Standard billing rate for the organization.
        defaultRate: Option<float>
        /// Description of or notes for the organization.
        description: Option<string>
    }

/// Autogenerated input type of CustomerRelationsOrganizationUpdate
type CustomerRelationsOrganizationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the organization.
        id: string
        /// Name of the organization.
        name: Option<string>
        /// Standard billing rate for the organization.
        defaultRate: Option<float>
        /// Description of or notes for the organization.
        description: Option<string>
        /// State of the organization.
        active: Option<bool>
    }

/// Autogenerated input type of DastOnDemandScanCreate
type DastOnDemandScanCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the site profile belongs to.
        fullPath: string
        /// ID of the site profile to be used for the scan.
        dastSiteProfileId: string
        /// ID of the scanner profile to be used for the scan.
        dastScannerProfileId: Option<string>
    }

/// Represents DAST Profile Cadence.
type DastProfileCadenceInput =
    {
        /// Unit for the duration of DAST Profile Cadence.
        unit: Option<DastProfileCadenceUnit>
        /// Duration of the DAST Profile Cadence.
        duration: Option<int>
    }

/// Autogenerated input type of DastProfileCreate
type DastProfileCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the profile belongs to.
        fullPath: string
        /// Represents a DAST Profile Schedule.
        dastProfileSchedule: Option<DastProfileScheduleInput>
        /// Name of the profile.
        name: string
        /// Description of the profile. Defaults to an empty string.
        description: Option<string>
        /// Associated branch.
        branchName: Option<string>
        /// ID of the site profile to be associated.
        dastSiteProfileId: string
        /// ID of the scanner profile to be associated.
        dastScannerProfileId: string
        /// Run scan using profile after creation. Defaults to false.
        runAfterCreate: Option<bool>
        /// Indicates the runner tags associated with the profile.
        tagList: Option<list<string>>
    }

/// Autogenerated input type of DastProfileDelete
type DastProfileDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the profile to be deleted.
        id: string
    }

/// Autogenerated input type of DastProfileRun
type DastProfileRunInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the profile to be used for the scan.
        id: string
    }

/// Input type for DAST Profile Schedules
type DastProfileScheduleInput =
    {
        /// Status of a Dast Profile Schedule.
        active: Option<bool>
        /// Start time of a Dast Profile Schedule.
        startsAt: Option<string>
        /// Time Zone for the Start time of a Dast Profile Schedule.
        timezone: Option<string>
        /// Cadence of a Dast Profile Schedule.
        cadence: Option<DastProfileCadenceInput>
    }

/// Autogenerated input type of DastProfileUpdate
type DastProfileUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the profile to be deleted.
        id: string
        /// Represents a DAST profile schedule.
        dastProfileSchedule: Option<DastProfileScheduleInput>
        /// Name of the profile.
        name: Option<string>
        /// Description of the profile. Defaults to an empty string.
        description: Option<string>
        /// Associated branch.
        branchName: Option<string>
        /// ID of the site profile to be associated.
        dastSiteProfileId: Option<string>
        /// ID of the scanner profile to be associated.
        dastScannerProfileId: Option<string>
        /// Run scan using profile after update. Defaults to false.
        runAfterUpdate: Option<bool>
        /// Indicates the runner tags associated with the profile.
        tagList: Option<list<string>>
    }

/// Autogenerated input type of DastScannerProfileCreate
type DastScannerProfileCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the scanner profile belongs to.
        fullPath: string
        /// Name of the scanner profile.
        profileName: string
        /// Maximum number of minutes allowed for the spider to traverse the site.
        spiderTimeout: Option<int>
        /// Maximum number of seconds allowed for the site under test to respond to a request.
        targetTimeout: Option<int>
        /// Indicates the type of DAST scan that will run. Either a Passive Scan or an Active Scan.
        scanType: Option<DastScanTypeEnum>
        /// Indicates if the AJAX spider should be used to crawl the target site. True to run the AJAX spider in addition to the traditional spider, and false to run only the traditional spider.
        useAjaxSpider: Option<bool>
        /// Indicates if debug messages should be included in DAST console output. True to include the debug messages.
        showDebugMessages: Option<bool>
    }

/// Autogenerated input type of DastScannerProfileDelete
type DastScannerProfileDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the scanner profile to be deleted.
        id: string
    }

/// Autogenerated input type of DastScannerProfileUpdate
type DastScannerProfileUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the scanner profile to be updated.
        id: string
        /// Name of the scanner profile.
        profileName: string
        /// Maximum number of minutes allowed for the spider to traverse the site.
        spiderTimeout: int
        /// Maximum number of seconds allowed for the site under test to respond to a request.
        targetTimeout: int
        /// Indicates the type of DAST scan that will run. Either a Passive Scan or an Active Scan.
        scanType: Option<DastScanTypeEnum>
        /// Indicates if the AJAX spider should be used to crawl the target site. True to run the AJAX spider in addition to the traditional spider, and false to run only the traditional spider.
        useAjaxSpider: Option<bool>
        /// Indicates if debug messages should be included in DAST console output. True to include the debug messages.
        showDebugMessages: Option<bool>
    }

/// Input type for DastSiteProfile authentication
type DastSiteProfileAuthInput =
    {
        /// Indicates whether authentication is enabled.
        enabled: Option<bool>
        /// The URL of the page containing the sign-in HTML form on the target website.
        url: Option<string>
        /// Name of username field at the sign-in HTML form.
        usernameField: Option<string>
        /// Name of password field at the sign-in HTML form.
        passwordField: Option<string>
        /// Username to authenticate with on the target.
        username: Option<string>
        /// Password to authenticate with on the target.
        password: Option<string>
        /// Name or ID of sign-in submit button at the sign-in HTML form.
        submitField: Option<string>
    }

/// Autogenerated input type of DastSiteProfileCreate
type DastSiteProfileCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the site profile.
        profileName: string
        /// URL of the target to be scanned.
        targetUrl: Option<string>
        /// Type of target to be scanned.
        targetType: Option<DastTargetTypeEnum>
        /// Scan method by the scanner.
        scanMethod: Option<DastScanMethodType>
        /// File Path or URL used as input for the scan method.
        scanFilePath: Option<string>
        /// Comma-separated list of request header names and values to be added to every request made by DAST.
        requestHeaders: Option<string>
        /// Parameters for authentication.
        auth: Option<DastSiteProfileAuthInput>
        /// Project the site profile belongs to.
        fullPath: string
        /// URLs to skip during an authenticated scan. Defaults to `[]`.
        excludedUrls: Option<list<string>>
        /// Optional variables that can be configured for DAST scans.
        optionalVariables: Option<list<string>>
    }

/// Autogenerated input type of DastSiteProfileDelete
type DastSiteProfileDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the site profile to be deleted.
        id: string
    }

/// Autogenerated input type of DastSiteProfileUpdate
type DastSiteProfileUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the site profile.
        profileName: string
        /// URL of the target to be scanned.
        targetUrl: Option<string>
        /// Type of target to be scanned.
        targetType: Option<DastTargetTypeEnum>
        /// Scan method by the scanner.
        scanMethod: Option<DastScanMethodType>
        /// File Path or URL used as input for the scan method.
        scanFilePath: Option<string>
        /// Comma-separated list of request header names and values to be added to every request made by DAST.
        requestHeaders: Option<string>
        /// Parameters for authentication.
        auth: Option<DastSiteProfileAuthInput>
        /// ID of the site profile to be updated.
        id: string
        /// URLs to skip during an authenticated scan.
        excludedUrls: Option<list<string>>
        /// Optional variables that can be configured for DAST scans.
        optionalVariables: Option<list<string>>
    }

/// Autogenerated input type of DastSiteTokenCreate
type DastSiteTokenCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the site token belongs to.
        fullPath: string
        /// URL of the target to be validated.
        targetUrl: Option<string>
    }

/// Autogenerated input type of DastSiteValidationCreate
type DastSiteValidationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the site profile belongs to.
        fullPath: string
        /// ID of the site token.
        dastSiteTokenId: string
        /// Path to be requested during validation.
        validationPath: string
        /// Validation strategy to be used.
        strategy: Option<DastSiteValidationStrategyEnum>
    }

/// Autogenerated input type of DastSiteValidationRevoke
type DastSiteValidationRevokeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the site validation belongs to.
        fullPath: string
        /// Normalized URL of the target to be revoked.
        normalizedTargetUrl: string
    }

/// Autogenerated input type of DeleteAnnotation
type DeleteAnnotationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the annotation to delete.
        id: string
    }

/// Autogenerated input type of DeleteContainerProtectionRepositoryRule
type DeleteContainerProtectionRepositoryRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the container repository protection rule to delete.
        id: string
    }

/// Autogenerated input type of DeleteContainerProtectionTagRule
type DeleteContainerProtectionTagRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the tag protection rule to delete.
        id: string
    }

/// Autogenerated input type of DeleteConversationThread
type DeleteConversationThreadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the thread to delete.
        threadId: string
    }

/// Autogenerated input type of DeleteDuoWorkflowsWorkflow
type DeleteDuoWorkflowsWorkflowInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the workflow to delete.
        workflowId: string
    }

/// Autogenerated input type of DeletePackagesProtectionRule
type DeletePackagesProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the package protection rule to delete.
        id: string
    }

/// Autogenerated input type of DeletePagesDeployment
type DeletePagesDeploymentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Pages Deployment.
        id: string
    }

/// Values for ordering deployments by a specific field
type DeploymentsOrderByInput =
    {
        /// Order by Created time.
        createdAt: Option<SortDirectionEnum>
        /// Order by Finished time.
        finishedAt: Option<SortDirectionEnum>
    }

/// Autogenerated input type of DesignManagementDelete
type DesignManagementDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project where the issue is to upload designs for.
        projectPath: string
        /// IID of the issue to modify designs for.
        iid: string
        /// Filenames of the designs to delete.
        filenames: list<string>
    }

/// Autogenerated input type of DesignManagementMove
type DesignManagementMoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the design to move.
        id: string
        /// ID of the immediately preceding design.
        previous: Option<string>
        /// ID of the immediately following design.
        next: Option<string>
    }

/// Autogenerated input type of DesignManagementUpdate
type DesignManagementUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the design to update.
        id: string
        /// Description of the design.
        description: Option<string>
    }

/// Autogenerated input type of DesignManagementUpload
type DesignManagementUploadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project where the issue is to upload designs for.
        projectPath: string
        /// IID of the issue to modify designs for.
        iid: string
        /// Files to upload.
        files: list<string>
    }

/// Autogenerated input type of DestroyBoard
type DestroyBoardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the board to destroy.
        id: string
    }

/// Autogenerated input type of DestroyBoardList
type DestroyBoardListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the list to destroy. Only label lists are accepted.
        listId: string
    }

/// Autogenerated input type of DestroyComplianceFramework
type DestroyComplianceFrameworkInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance framework to destroy.
        id: string
    }

/// Autogenerated input type of DestroyComplianceRequirement
type DestroyComplianceRequirementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance requirement to destroy.
        id: string
    }

/// Autogenerated input type of DestroyComplianceRequirementsControl
type DestroyComplianceRequirementsControlInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance requirement control to destroy.
        id: string
    }

/// Autogenerated input type of DestroyContainerRepository
type DestroyContainerRepositoryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the container repository.
        id: string
    }

/// Autogenerated input type of DestroyContainerRepositoryTags
type DestroyContainerRepositoryTagsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the container repository.
        id: string
        /// Container repository tag(s) to delete. Total number can't be greater than 20
        tagNames: list<string>
    }

/// Autogenerated input type of DestroyCustomEmoji
type DestroyCustomEmojiInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the custom emoji to destroy.
        id: string
    }

/// Autogenerated input type of DestroyEpicBoard
type DestroyEpicBoardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the board to destroy.
        id: string
    }

/// Autogenerated input type of DestroyNote
type DestroyNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the note to destroy.
        id: string
    }

/// Autogenerated input type of DestroyPackageFile
type DestroyPackageFileInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Package file.
        id: string
    }

/// Autogenerated input type of DestroyPackageFiles
type DestroyPackageFilesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path where the packages cleanup policy is located.
        projectPath: string
        /// IDs of the Package file.
        ids: list<string>
    }

/// Autogenerated input type of DestroyPackage
type DestroyPackageInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Package.
        id: string
    }

/// Autogenerated input type of DestroyPackages
type DestroyPackagesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the Packages. Max 100
        ids: list<string>
    }

/// Autogenerated input type of DestroySnippet
type DestroySnippetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the snippet to destroy.
        id: string
    }

/// Autogenerated input type of DevfileValidate
type DevfileValidateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Input devfile.
        devfileYaml: string
    }

type DiffImagePositionInput =
    {
        /// Merge base of the branch the comment was made on.
        baseSha: Option<string>
        /// SHA of the HEAD at the time the comment was made.
        headSha: string
        /// SHA of the branch being compared against.
        startSha: string
        /// The paths of the file that was changed. Both of the properties of this input are optional, but at least one of them is required
        paths: DiffPathsInput
        /// Total height of the image.
        height: int
        /// Total width of the image.
        width: int
        /// X position of the note.
        x: int
        /// Y position of the note.
        y: int
    }

type DiffPathsInput =
    {
        /// Path of the file on the HEAD SHA.
        newPath: Option<string>
        /// Path of the file on the start SHA.
        oldPath: Option<string>
    }

type DiffPositionInput =
    {
        /// Merge base of the branch the comment was made on.
        baseSha: Option<string>
        /// SHA of the HEAD at the time the comment was made.
        headSha: string
        /// SHA of the branch being compared against.
        startSha: string
        /// The paths of the file that was changed. Both of the properties of this input are optional, but at least one of them is required
        paths: DiffPathsInput
        /// Line on HEAD SHA that was changed. Please see the [REST API Documentation](https://docs.gitlab.com/api/discussions/#create-a-new-thread-in-the-merge-request-diff) for more information on how to use this field.
        newLine: Option<int>
        /// Line on start SHA that was changed. Please see the [REST API Documentation](https://docs.gitlab.com/api/discussions/#create-a-new-thread-in-the-merge-request-diff) for more information on how to use this field.
        oldLine: Option<int>
    }

/// Autogenerated input type of DisableDevopsAdoptionNamespace
type DisableDevopsAdoptionNamespaceInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// One or many IDs of the enabled namespaces to disable.
        id: list<string>
    }

/// Autogenerated input type of DiscussionToggleResolve
type DiscussionToggleResolveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the discussion.
        id: string
        /// Will resolve the discussion when true, and unresolve the discussion when false.
        resolve: bool
    }

/// Autogenerated input type of DismissPolicyViolations
type DismissPolicyViolationsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// IDs of warn mode policies with violations to dismiss.
        securityPolicyIds: list<string>
        /// Type of dismissal for the policy violations.
        dismissalTypes: list<DismissalType>
        /// Comment explaining the dismissal of the policy violations.
        comment: string
    }

/// Filter parameters for projects to be aggregated for DORA metrics.
type DoraProjectFilterInput =
    {
        /// Filter projects by topic.
        topic: Option<list<string>>
    }

/// Input for Duo context exclusion settings
type DuoContextExclusionSettingsInput =
    {
        /// List of rules for excluding files from Duo context.
        exclusionRules: list<string>
    }

/// Autogenerated input type of DuoSettingsUpdate
type DuoSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// URL for local AI gateway server.
        aiGatewayUrl: Option<string>
        /// Timeout for AI gateway request.
        aiGatewayTimeoutSeconds: Option<int>
        /// URL for the local Duo Agent Platform service.
        duoAgentPlatformServiceUrl: Option<string>
        /// Indicates whether GitLab Duo Core features are enabled.
        duoCoreFeaturesEnabled: Option<bool>
    }

/// Autogenerated input type of DuoUserFeedback
type DuoUserFeedbackInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the agent to answer the chat.
        agentVersionId: Option<string>
        /// ID of the AI Message.
        aiMessageId: string
        /// Tracking event data.
        trackingEvent: Option<TrackingEventInput>
    }

/// Autogenerated input type of EchoCreate
type EchoCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Errors to return to the user.
        errors: Option<list<string>>
        /// Messages to return to the user.
        messages: Option<list<string>>
    }

/// Autogenerated input type of EnableDevopsAdoptionNamespace
type EnableDevopsAdoptionNamespaceInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace ID.
        namespaceId: string
        /// Display namespace ID.
        displayNamespaceId: Option<string>
    }

/// Autogenerated input type of EnvironmentCreate
type EnvironmentCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
        /// Name of the environment.
        name: string
        /// Description of the environment.
        description: Option<string>
        /// External URL of the environment.
        externalUrl: Option<string>
        /// Tier of the environment.
        tier: Option<DeploymentTier>
        /// Cluster agent of the environment.
        clusterAgentId: Option<string>
        /// Kubernetes namespace of the environment.
        kubernetesNamespace: Option<string>
        /// Flux resource path of the environment.
        fluxResourcePath: Option<string>
        /// Auto stop setting of the environment.
        autoStopSetting: Option<AutoStopSetting>
    }

/// Autogenerated input type of EnvironmentDelete
type EnvironmentDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the environment to Delete.
        id: string
    }

/// Autogenerated input type of EnvironmentStop
type EnvironmentStopInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the environment to stop.
        id: string
        /// Force environment to stop without executing on_stop actions.
        force: Option<bool>
    }

/// Autogenerated input type of EnvironmentUpdate
type EnvironmentUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the environment to update.
        id: string
        /// Description of the environment.
        description: Option<string>
        /// External URL of the environment.
        externalUrl: Option<string>
        /// Tier of the environment.
        tier: Option<DeploymentTier>
        /// Cluster agent of the environment.
        clusterAgentId: Option<string>
        /// Kubernetes namespace of the environment.
        kubernetesNamespace: Option<string>
        /// Flux resource path of the environment.
        fluxResourcePath: Option<string>
        /// Auto stop setting of the environment.
        autoStopSetting: Option<AutoStopSetting>
    }

/// Autogenerated input type of EnvironmentsCanaryIngressUpdate
type EnvironmentsCanaryIngressUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the environment to update.
        id: string
        /// Weight of the Canary Ingress.
        weight: int
    }

/// Autogenerated input type of EpicAddIssue
type EpicAddIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IID of the epic to mutate.
        iid: string
        /// Group the epic to mutate belongs to.
        groupPath: string
        /// Full path of the project the issue belongs to.
        projectPath: string
        /// IID of the issue to be added.
        issueIid: string
    }

/// Autogenerated input type of EpicBoardCreate
type EpicBoardCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Whether or not display epic colors.
        displayColors: Option<bool>
        /// Board name.
        name: Option<string>
        /// Whether or not backlog list is hidden.
        hideBacklogList: Option<bool>
        /// Whether or not closed list is hidden.
        hideClosedList: Option<bool>
        /// Labels of the issue.
        labels: Option<list<string>>
        /// IDs of labels to be added to the board.
        labelIds: Option<list<string>>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
    }

/// Autogenerated input type of EpicBoardListCreate
type EpicBoardListCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Create the backlog list.
        backlog: Option<bool>
        /// Global ID of an existing label.
        labelId: Option<string>
        /// Global ID of the issue board to mutate.
        boardId: string
    }

/// Autogenerated input type of EpicBoardListDestroy
type EpicBoardListDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the epic board list to destroy.
        listId: string
    }

/// Autogenerated input type of EpicBoardUpdate
type EpicBoardUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Whether or not display epic colors.
        displayColors: Option<bool>
        /// Board name.
        name: Option<string>
        /// Whether or not backlog list is hidden.
        hideBacklogList: Option<bool>
        /// Whether or not closed list is hidden.
        hideClosedList: Option<bool>
        /// Labels of the issue.
        labels: Option<list<string>>
        /// IDs of labels to be added to the board.
        labelIds: Option<list<string>>
        /// Epic board global ID.
        id: string
    }

type EpicFilters =
    {
        /// Filter by label name.
        labelName: Option<list<Option<string>>>
        /// Filter by author username.
        authorUsername: Option<string>
        /// Filter by reaction emoji applied by the current user. Wildcard values "NONE" and "ANY" are supported.
        myReactionEmoji: Option<string>
        /// Negated epic arguments.
        ``not``: Option<NegatedEpicBoardIssueInput>
        /// List of arguments with inclusive OR.
        ``or``: Option<UnionedEpicFilterInput>
        /// Search query for epic title or description.
        search: Option<string>
        /// Filter by confidentiality.
        confidential: Option<bool>
    }

/// Autogenerated input type of EpicMoveList
type EpicMoveListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the board that the epic is in.
        boardId: string
        /// ID of the epic to mutate.
        epicId: string
        /// ID of the board list that the epic will be moved from. Required if moving between lists.
        fromListId: Option<string>
        /// ID of the list the epic will be in after mutation.
        toListId: string
        /// ID of epic that should be placed before the current epic.
        moveBeforeId: Option<string>
        /// ID of epic that should be placed after the current epic.
        moveAfterId: Option<string>
        /// Position of epics within the board list. Positions start at 0. Use -1 to move to the end of the list.
        positionInList: Option<int>
    }

/// Autogenerated input type of EpicSetSubscription
type EpicSetSubscriptionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IID of the epic to mutate.
        iid: string
        /// Group the epic to mutate belongs to.
        groupPath: string
        /// Desired state of the subscription.
        subscribedState: bool
    }

/// A node of an epic tree.
type EpicTreeNodeFieldsInputType =
    {
        /// ID of the epic issue or epic that is being moved.
        id: string
        /// ID of the epic issue or issue the epic or issue is switched with.
        adjacentReferenceId: Option<string>
        /// Type of switch. Valid values are `after` or `before`.
        relativePosition: Option<MoveType>
        /// ID of the new parent epic.
        newParentId: Option<string>
    }

/// Autogenerated input type of EpicTreeReorder
type EpicTreeReorderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the base epic of the tree.
        baseEpicId: string
        /// Parameters for updating the tree positions.
        moved: EpicTreeNodeFieldsInputType
    }

/// Autogenerated input type of EscalationPolicyCreate
type EscalationPolicyCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the escalation policy for.
        projectPath: string
        /// Name of the escalation policy.
        name: string
        /// Description of the escalation policy.
        description: Option<string>
        /// Steps of the escalation policy.
        rules: list<EscalationRuleInput>
    }

/// Autogenerated input type of EscalationPolicyDestroy
type EscalationPolicyDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Escalation policy internal ID to remove.
        id: string
    }

/// Autogenerated input type of EscalationPolicyUpdate
type EscalationPolicyUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the on-call schedule to create the on-call rotation in.
        id: string
        /// Name of the escalation policy.
        name: Option<string>
        /// Description of the escalation policy.
        description: Option<string>
        /// Steps of the escalation policy.
        rules: Option<list<EscalationRuleInput>>
    }

/// Represents an escalation rule
type EscalationRuleInput =
    {
        /// On-call schedule to notify.
        oncallScheduleIid: Option<string>
        /// Username of the user to notify.
        username: Option<string>
        /// Time in seconds before the rule is activated.
        elapsedTimeSeconds: int
        /// Status required to prevent the rule from activating.
        status: EscalationRuleStatus
    }

/// Autogenerated input type of ExportRequirements
type ExportRequirementsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// List requirements by sort order.
        sort: Option<Sort>
        /// Filter requirements by state.
        state: Option<RequirementState>
        /// Search query for requirement title.
        search: Option<string>
        /// Filter requirements by author username.
        authorUsername: Option<list<string>>
        /// Full project path the requirements are associated with.
        projectPath: string
        /// List of selected requirements fields to be exported.
        selectedFields: Option<list<string>>
    }

/// Autogenerated input type of ExternalAuditEventDestinationCreate
type ExternalAuditEventDestinationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination URL.
        destinationUrl: string
        /// Destination name.
        name: Option<string>
        /// Group path.
        groupPath: string
        /// Verification token.
        verificationToken: Option<string>
    }

/// Autogenerated input type of ExternalAuditEventDestinationDestroy
type ExternalAuditEventDestinationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of external audit event destination to destroy.
        id: string
    }

/// Autogenerated input type of ExternalAuditEventDestinationUpdate
type ExternalAuditEventDestinationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of external audit event destination to update.
        id: string
        /// Destination URL to change.
        destinationUrl: Option<string>
        /// Destination name.
        name: Option<string>
        /// Active status of the destination.
        active: Option<bool>
    }

/// Autogenerated input type of GeoRegistriesBulkUpdate
type GeoRegistriesBulkUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Class of the Geo registries to be updated.
        registryClass: GeoRegistryClass
        /// Action to be executed on Geo registries.
        action: GeoRegistriesBulkAction
        /// Execute the action on registries selected by their ID.
        ids: Option<list<string>>
        /// Execute the action on registries selected by their replication state.
        replicationState: Option<ReplicationStateEnum>
        /// Execute the action on registries selected by their verification state.
        verificationState: Option<VerificationStateEnum>
    }

/// Autogenerated input type of GeoRegistriesUpdate
type GeoRegistriesUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Geo registry entry to be updated.
        registryId: string
        /// Action to be executed on a Geo registry.
        action: GeoRegistryAction
    }

/// Autogenerated input type of GitlabSubscriptionActivate
type GitlabSubscriptionActivateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Activation code received after purchasing a GitLab subscription.
        activationCode: string
    }

/// Autogenerated input type of GoogleCloudLoggingConfigurationCreate
type GoogleCloudLoggingConfigurationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Group path.
        groupPath: string
        /// Unique identifier of the Google Cloud project to which the logging configuration belongs.
        googleProjectIdName: string
        /// Email address associated with the service account that will be used to authenticate and interact with the Google Cloud Logging service. This is part of the IAM credentials.
        clientEmail: string
        /// Unique identifier used to distinguish and manage different logs within the same Google Cloud project.(defaults to `audit_events`).
        logIdName: Option<string>
        /// Private Key associated with the service account. This key is used to authenticate the service account and authorize it to interact with the Google Cloud Logging service.
        privateKey: string
    }

/// Autogenerated input type of GoogleCloudLoggingConfigurationDestroy
type GoogleCloudLoggingConfigurationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Google Cloud logging configuration to destroy.
        id: string
    }

/// Autogenerated input type of GoogleCloudLoggingConfigurationUpdate
type GoogleCloudLoggingConfigurationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Unique identifier of the Google Cloud project to which the logging configuration belongs.
        googleProjectIdName: Option<string>
        /// Email address associated with the service account that will be used to authenticate and interact with the Google Cloud Logging service. This is part of the IAM credentials.
        clientEmail: Option<string>
        /// Unique identifier used to distinguish and manage different logs within the same Google Cloud project.
        logIdName: Option<string>
        /// Private Key associated with the service account. This key is used to authenticate the service account and authorize it to interact with the Google Cloud Logging service.
        privateKey: Option<string>
        /// Active status of the destination.
        active: Option<bool>
        /// ID of the google Cloud configuration to update.
        id: string
    }

/// Attributes for defining Node Pool in GKE
type GoogleCloudNodePool =
    {
        /// Image to use on the pool.
        imageType: string
        /// Labels for the node pool of the runner.
        labels: Option<list<GoogleCloudNodePoolLabel>>
        /// Machine type to use.
        machineType: string
        /// Name of the node pool.
        name: string
        /// Node count of the pool.
        nodeCount: int
    }

/// Labels for the Node Pool of a GKE cluster.
type GoogleCloudNodePoolLabel =
    {
        /// Key of the label.
        key: string
        /// Value of the label.
        value: string
    }

/// Autogenerated input type of GroupAuditEventStreamingDestinationsCreate
type GroupAuditEventStreamingDestinationsCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination config.
        config: string
        /// Destination name.
        name: Option<string>
        /// Destination category.
        category: string
        /// Group path.
        groupPath: string
        /// Secret token.
        secretToken: Option<string>
    }

/// Autogenerated input type of GroupAuditEventStreamingDestinationsDelete
type GroupAuditEventStreamingDestinationsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the audit events external streaming destination to delete.
        id: string
    }

/// Autogenerated input type of GroupAuditEventStreamingDestinationsUpdate
type GroupAuditEventStreamingDestinationsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of external audit event destination to update.
        id: string
        /// Destination config.
        config: Option<string>
        /// Destination name.
        name: Option<string>
        /// Destination category.
        category: Option<string>
        /// Secret token.
        secretToken: Option<string>
        /// Active status of the destination.
        active: Option<bool>
    }

/// Autogenerated input type of GroupMemberBulkUpdate
type GroupMemberBulkUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the members.
        userIds: list<string>
        /// Access level to update the members to.
        accessLevel: MemberAccessLevel
        /// Date and time the membership expires.
        expiresAt: Option<string>
        /// Global ID of the group.
        groupId: string
    }

/// Autogenerated input type of GroupMembersExport
type GroupMembersExportInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the group.
        groupId: string
    }

type GroupProjectRequirementComplianceStatusInput =
    {
        /// Filter compliance requirement statuses by compliance requirement.
        requirementId: Option<string>
        /// Filter compliance requirement statuses by compliance framework.
        frameworkId: Option<string>
        /// Filter compliance requirement statuses by project.
        projectId: Option<string>
    }

/// Autogenerated input type of GroupSavedReplyCreate
type GroupSavedReplyCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
        /// Group for the save reply.
        groupId: string
    }

/// Autogenerated input type of GroupSavedReplyDestroy
type GroupSavedReplyDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the group-level saved reply.
        id: string
    }

/// Autogenerated input type of GroupSavedReplyUpdate
type GroupSavedReplyUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
        /// Global ID of the group-level saved reply.
        id: string
    }

/// Autogenerated input type of GroupSecretsManagerDeprovision
type GroupSecretsManagerDeprovisionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group of the secrets manager.
        groupPath: string
    }

/// Autogenerated input type of GroupSecretsManagerInitialize
type GroupSecretsManagerInitializeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group of the secrets manager.
        groupPath: string
    }

/// Autogenerated input type of GroupUpdate
type GroupUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the group that will be updated.
        fullPath: string
        /// Indicates if math rendering limits are locked for all descendant groups.
        lockMathRenderingLimitsEnabled: Option<bool>
        /// Indicates if math rendering limits are used for the group.
        mathRenderingLimitsEnabled: Option<bool>
        /// Name of the group.
        name: Option<string>
        /// Path of the namespace.
        path: Option<string>
        /// Shared runners availability for the namespace and its descendants.
        sharedRunnersSetting: Option<SharedRunnersSetting>
        /// OAuth provider required for step-up authentication.
        stepUpAuthRequiredOauthProvider: Option<string>
        /// Visibility of the namespace.
        visibility: Option<VisibilityLevelsEnum>
        /// Indicates whether GitLab Duo features are enabled for the group. Introduced in GitLab 16.10: **Status**: Experiment.
        duoFeaturesEnabled: Option<bool>
        /// Indicates if the GitLab Duo features enabled setting is enforced for all subgroups. Introduced in GitLab 16.10: **Status**: Experiment.
        lockDuoFeaturesEnabled: Option<bool>
    }

type HierarchyFilterInput =
    {
        /// Filter work items by global IDs of their parent items (maximum is 100 items).
        parentIds: Option<list<string>>
        /// Whether to include work items of descendant parents when filtering by parent_ids.
        includeDescendantWorkItems: Option<bool>
    }

/// Autogenerated input type of HttpIntegrationCreate
type HttpIntegrationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the integration in.
        projectPath: string
        /// Name of the integration.
        name: string
        /// Type of integration to create. Cannot be changed after creation.
        ``type``: Option<AlertManagementIntegrationType>
        /// Whether the integration is receiving alerts.
        active: bool
        /// Example of an alert payload.
        payloadExample: Option<string>
        /// Custom mapping of GitLab alert attributes to fields from the payload example.
        payloadAttributeMappings: Option<list<AlertManagementPayloadAlertFieldInput>>
    }

/// Autogenerated input type of HttpIntegrationDestroy
type HttpIntegrationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the integration to remove.
        id: string
    }

/// Autogenerated input type of HttpIntegrationResetToken
type HttpIntegrationResetTokenInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the integration to mutate.
        id: string
    }

/// Autogenerated input type of HttpIntegrationUpdate
type HttpIntegrationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the integration to mutate.
        id: string
        /// Name of the integration.
        name: Option<string>
        /// Whether the integration is receiving alerts.
        active: Option<bool>
        /// Example of an alert payload.
        payloadExample: Option<string>
        /// Custom mapping of GitLab alert attributes to fields from the payload example.
        payloadAttributeMappings: Option<list<AlertManagementPayloadAlertFieldInput>>
    }

/// Autogenerated input type of ImportSourceUserCancelReassignment
type ImportSourceUserCancelReassignmentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the mapping of a user on source instance to a user on destination instance.
        id: string
    }

/// Autogenerated input type of ImportSourceUserKeepAllAsPlaceholder
type ImportSourceUserKeepAllAsPlaceholderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the namespace.
        namespaceId: string
    }

/// Autogenerated input type of ImportSourceUserKeepAsPlaceholder
type ImportSourceUserKeepAsPlaceholderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the mapping of a user on source instance to a user on destination instance.
        id: string
    }

/// Autogenerated input type of ImportSourceUserReassign
type ImportSourceUserReassignInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the mapping of a user on source instance to a user on destination instance.
        id: string
        /// Global ID of the assignee user.
        assigneeUserId: string
    }

/// Autogenerated input type of ImportSourceUserResendNotification
type ImportSourceUserResendNotificationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the mapping of a user on source instance to a user on destination instance.
        id: string
    }

/// Autogenerated input type of ImportSourceUserUndoKeepAsPlaceholder
type ImportSourceUserUndoKeepAsPlaceholderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the mapping of a user on source instance to a user on destination instance.
        id: string
    }

/// Autogenerated input type of InstanceAuditEventStreamingDestinationsCreate
type InstanceAuditEventStreamingDestinationsCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination config.
        config: string
        /// Destination name.
        name: Option<string>
        /// Destination category.
        category: string
        /// Secret token.
        secretToken: Option<string>
    }

/// Autogenerated input type of InstanceAuditEventStreamingDestinationsDelete
type InstanceAuditEventStreamingDestinationsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the audit events external streaming destination to delete.
        id: string
    }

/// Autogenerated input type of InstanceAuditEventStreamingDestinationsUpdate
type InstanceAuditEventStreamingDestinationsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of external audit event destination to update.
        id: string
        /// Destination config.
        config: Option<string>
        /// Destination name.
        name: Option<string>
        /// Destination category.
        category: Option<string>
        /// Secret token.
        secretToken: Option<string>
        /// Active status of the destination.
        active: Option<bool>
    }

/// Autogenerated input type of InstanceExternalAuditEventDestinationCreate
type InstanceExternalAuditEventDestinationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination URL.
        destinationUrl: string
        /// Destination name.
        name: Option<string>
    }

/// Autogenerated input type of InstanceExternalAuditEventDestinationDestroy
type InstanceExternalAuditEventDestinationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the external instance audit event destination to destroy.
        id: string
    }

/// Autogenerated input type of InstanceExternalAuditEventDestinationUpdate
type InstanceExternalAuditEventDestinationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the external instance audit event destination to update.
        id: string
        /// Destination URL to change.
        destinationUrl: Option<string>
        /// Destination name.
        name: Option<string>
        /// Active status of the destination.
        active: Option<bool>
    }

/// Autogenerated input type of InstanceGoogleCloudLoggingConfigurationCreate
type InstanceGoogleCloudLoggingConfigurationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Unique identifier of the Google Cloud project to which the logging configuration belongs.
        googleProjectIdName: string
        /// Email address associated with the service account that will be used to authenticate and interact with the Google Cloud Logging service. This is part of the IAM credentials.
        clientEmail: string
        /// Unique identifier used to distinguish and manage different logs within the same Google Cloud project.(defaults to `audit_events`).
        logIdName: Option<string>
        /// Private Key associated with the service account. This key is used to authenticate the service account and authorize it to interact with the Google Cloud Logging service.
        privateKey: string
    }

/// Autogenerated input type of InstanceGoogleCloudLoggingConfigurationDestroy
type InstanceGoogleCloudLoggingConfigurationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Google Cloud logging configuration to destroy.
        id: string
    }

/// Autogenerated input type of InstanceGoogleCloudLoggingConfigurationUpdate
type InstanceGoogleCloudLoggingConfigurationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Destination name.
        name: Option<string>
        /// Unique identifier of the Google Cloud project to which the logging configuration belongs.
        googleProjectIdName: Option<string>
        /// Email address associated with the service account that will be used to authenticate and interact with the Google Cloud Logging service. This is part of the IAM credentials.
        clientEmail: Option<string>
        /// Unique identifier used to distinguish and manage different logs within the same Google Cloud project.
        logIdName: Option<string>
        /// Private Key associated with the service account. This key is used to authenticate the service account and authorize it to interact with the Google Cloud Logging service.
        privateKey: Option<string>
        /// Active status of the destination.
        active: Option<bool>
        /// ID of the instance google Cloud configuration to update.
        id: string
    }

/// Autogenerated input type of IntegrationExclusionCreate
type IntegrationExclusionCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Type of integration to exclude.
        integrationName: IntegrationType
        /// IDs of projects to exclude up to a maximum of 100.
        projectIds: Option<list<string>>
        /// IDs of groups to exclude up to a maximum of 100.
        groupIds: Option<list<string>>
    }

/// Autogenerated input type of IntegrationExclusionDelete
type IntegrationExclusionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Type of integration.
        integrationName: IntegrationType
        /// IDs of excluded projects.
        projectIds: Option<list<string>>
        /// IDs of excluded groups.
        groupIds: Option<list<string>>
    }

/// Autogenerated input type of IssuableResourceLinkCreate
type IssuableResourceLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Incident id to associate the resource link with.
        id: string
        /// Link of the resource.
        link: string
        /// Link text of the resource.
        linkText: Option<string>
        /// Link type of the resource.
        linkType: Option<IssuableResourceLinkType>
    }

/// Autogenerated input type of IssuableResourceLinkDestroy
type IssuableResourceLinkDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Issuable resource link ID to remove.
        id: string
    }

/// Autogenerated input type of IssueLinkAlerts
type IssueLinkAlertsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Alerts references to be linked to the incident.
        alertReferences: list<string>
    }

/// Autogenerated input type of IssueMove
type IssueMoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Project to move the issue to.
        targetProjectPath: string
    }

/// Autogenerated input type of IssueMoveList
type IssueMoveListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the board that the issue is in.
        boardId: string
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// ID of the board list that the issue will be moved from.
        fromListId: Option<string>
        /// ID of the board list that the issue will be moved to.
        toListId: Option<string>
        /// ID of issue that should be placed before the current issue.
        moveBeforeId: Option<string>
        /// ID of issue that should be placed after the current issue.
        moveAfterId: Option<string>
        /// Position of issue within the board list. Positions start at 0. Use -1 to move to the end of the list.
        positionInList: Option<int>
    }

/// Autogenerated input type of IssueSetAssignees
type IssueSetAssigneesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Usernames to assign to the resource. Replaces existing assignees by default.
        assigneeUsernames: list<string>
        /// Operation to perform. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of IssueSetConfidential
type IssueSetConfidentialInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Whether or not to set the issue as a confidential.
        confidential: bool
    }

/// Autogenerated input type of IssueSetCrmContacts
type IssueSetCrmContactsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Customer relations contact IDs to set. Replaces existing contacts by default.
        contactIds: list<string>
        /// Changes the operation mode. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of IssueSetDueDate
type IssueSetDueDateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Desired due date for the issue. Due date is removed if null.
        dueDate: Option<string>
    }

/// Autogenerated input type of IssueSetEpic
type IssueSetEpicInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
    }

/// Autogenerated input type of IssueSetEscalationPolicy
type IssueSetEscalationPolicyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Global ID of the escalation policy to assign to the issue. Policy will be removed if absent or set to null.
        escalationPolicyId: Option<string>
    }

/// Autogenerated input type of IssueSetEscalationStatus
type IssueSetEscalationStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Set the escalation status.
        status: IssueEscalationStatus
    }

/// Autogenerated input type of IssueSetIteration
type IssueSetIterationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Iteration to assign to the issue.
        iterationId: Option<string>
    }

/// Autogenerated input type of IssueSetLocked
type IssueSetLockedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Whether or not to lock discussion on the issue.
        locked: bool
    }

/// Autogenerated input type of IssueSetSeverity
type IssueSetSeverityInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Set the incident severity level.
        severity: IssuableSeverity
    }

/// Autogenerated input type of IssueSetSubscription
type IssueSetSubscriptionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Desired state of the subscription.
        subscribedState: bool
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
    }

/// Autogenerated input type of IssueSetWeight
type IssueSetWeightInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// The desired weight for the issue. If set to null, weight is removed.
        weight: Option<int>
    }

/// Autogenerated input type of IssueUnlinkAlert
type IssueUnlinkAlertInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Global ID of the alert to unlink from the incident.
        alertId: string
    }

type ItemConsumerTargetInput =
    {
        /// Group in which to configure the item.
        groupId: Option<string>
        /// Project in which to configure the item.
        projectId: Option<string>
    }

/// Autogenerated input type of IterationCadenceCreate
type IterationCadenceCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group where the iteration cadence is created.
        groupPath: string
        /// Title of the iteration cadence.
        title: Option<string>
        /// Duration in weeks of the iterations within the cadence.
        durationInWeeks: Option<int>
        /// Upcoming iterations to be created when iteration cadence is set to automatic.
        iterationsInAdvance: Option<int>
        /// Timestamp of the automation start date.
        startDate: Option<string>
        /// Whether the iteration cadence should automatically generate upcoming iterations.
        automatic: bool
        /// Whether the iteration cadence is active.
        active: bool
        /// Whether the iteration cadence should roll over issues to the next iteration or not.
        rollOver: Option<bool>
        /// Description of the iteration cadence. Maximum length is 5000 characters.
        description: Option<string>
    }

/// Autogenerated input type of IterationCadenceDestroy
type IterationCadenceDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the iteration cadence.
        id: string
    }

/// Autogenerated input type of IterationCadenceUpdate
type IterationCadenceUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the iteration cadence.
        id: string
        /// Title of the iteration cadence.
        title: Option<string>
        /// Duration in weeks of the iterations within the cadence.
        durationInWeeks: Option<int>
        /// Upcoming iterations to be created when iteration cadence is set to automatic.
        iterationsInAdvance: Option<int>
        /// Timestamp of the automation start date.
        startDate: Option<string>
        /// Whether the iteration cadence should automatically generate upcoming iterations.
        automatic: Option<bool>
        /// Whether the iteration cadence is active.
        active: Option<bool>
        /// Whether the iteration cadence should roll over issues to the next iteration or not.
        rollOver: Option<bool>
        /// Description of the iteration cadence. Maximum length is 5000 characters.
        description: Option<string>
    }

/// Autogenerated input type of IterationDelete
type IterationDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the iteration.
        id: string
    }

/// Autogenerated input type of JiraImportStart
type JiraImportStartInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project key of the importer Jira project.
        jiraProjectKey: string
        /// Project to import the Jira project into.
        projectPath: string
        /// Mapping of Jira to GitLab users.
        usersMapping: Option<list<JiraUsersMappingInputType>>
    }

/// Autogenerated input type of JiraImportUsers
type JiraImportUsersInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to import the Jira users into.
        projectPath: string
        /// Index of the record the import should started at, default 0 (50 records returned).
        startAt: Option<int>
    }

type JiraUsersMappingInputType =
    {
        /// ID of the GitLab user.
        gitlabId: Option<int>
        /// Jira account ID of the user.
        jiraAccountId: string
    }

/// Autogenerated input type of JobArtifactsDestroy
type JobArtifactsDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the job to mutate.
        id: string
    }

/// Autogenerated input type of JobCancel
type JobCancelInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the job to mutate.
        id: string
    }

/// Autogenerated input type of JobPlay
type JobPlayInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the job to mutate.
        id: string
        /// Variables to use when playing a manual job.
        variables: Option<list<CiVariableInput>>
    }

/// Autogenerated input type of JobRetry
type JobRetryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the job to mutate.
        id: string
        /// Variables to use when retrying a manual job.
        variables: Option<list<CiVariableInput>>
        /// Inputs to use when retrying the job.
        inputs: Option<list<CiInputsInput>>
    }

/// Autogenerated input type of JobUnschedule
type JobUnscheduleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the job to mutate.
        id: string
    }

/// Autogenerated input type of LabelCreate
type LabelCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project with which the resource is associated.
        projectPath: Option<string>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
        /// Title of the label.
        title: string
        /// Description of the label.
        description: Option<string>
        /// The color of the label given in 6-digit hex notation with leading '#' sign(for example, `#FFAABB`) or one of the CSS color names.
        color: Option<string>
    }

/// Autogenerated input type of LabelUpdate
type LabelUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the label to update.
        id: string
    }

/// Autogenerated input type of LdapAdminRoleLinkCreate
type LdapAdminRoleLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the custom admin role to be assigned to a user.
        adminMemberRoleId: string
        /// LDAP provider for the LDAP link.
        provider: string
        /// Common Name (CN) of the LDAP group.
        cn: Option<string>
        /// Search filter for the LDAP group.
        filter: Option<string>
    }

/// Autogenerated input type of LdapAdminRoleLinkDestroy
type LdapAdminRoleLinkDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the instance-level LDAP link to delete.
        id: string
    }

/// Autogenerated input type of LifecycleAttachWorkItemType
type LifecycleAttachWorkItemTypeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace path where the lifecycle exists.
        namespacePath: string
        /// Global ID of the work item type to attach to the lifecycle.
        workItemTypeId: string
        /// Global ID of the lifecycle to attach the work item type to.
        lifecycleId: string
        /// Status mappings from the old lifecycle to the new lifecycle.
        statusMappings: Option<list<StatusMappingInput>>
    }

/// Autogenerated input type of LifecycleCreate
type LifecycleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace path where the lifecycle will be created.
        namespacePath: string
        /// Name of the lifecycle.
        name: string
        /// Statuses of the lifecycle. Can be existing (with id) or new (without id).
        statuses: list<WorkItemStatusInput>
        /// Index of the default open status in the statuses array.
        defaultOpenStatusIndex: int
        /// Index of the default closed status in the statuses array.
        defaultClosedStatusIndex: int
        /// Index of the default duplicated status in the statuses array.
        defaultDuplicateStatusIndex: int
    }

/// Autogenerated input type of LifecycleDelete
type LifecycleDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace path where the lifecycle exists.
        namespacePath: string
        /// Global ID of the lifecycle to delete.
        id: string
    }

/// Autogenerated input type of LifecycleUpdate
type LifecycleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace path where the lifecycle exists.
        namespacePath: string
        /// Global ID of the lifecycle to be updated.
        id: string
        /// Name of the lifecycle.
        name: Option<string>
        /// Statuses of the lifecycle. Can be existing (with id) or new (without id).
        statuses: Option<list<WorkItemStatusInput>>
        /// Index of the default open status in the statuses array.
        defaultOpenStatusIndex: Option<int>
        /// Index of the default closed status in the statuses array.
        defaultClosedStatusIndex: Option<int>
        /// Index of the default duplicated status in the statuses array.
        defaultDuplicateStatusIndex: Option<int>
        /// Mappings for statuses being removed from the lifecycle. Maps old status to replacement status.
        statusMappings: Option<list<StatusMappingInput>>
    }

/// Autogenerated input type of LinkProjectComplianceViolationIssue
type LinkProjectComplianceViolationIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project compliance violation.
        violationId: string
        /// Full path of the project the issue belongs to.
        projectPath: string
        /// IID of the issue to be linked.
        issueIid: string
    }

/// Autogenerated input type of MarkAsSpamSnippet
type MarkAsSpamSnippetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the snippet to update.
        id: string
    }

/// Autogenerated input type of MavenUpstreamCreate
type MavenUpstreamCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the upstream registry.
        id: string
        /// Name of upstream registry.
        name: string
        /// Description of the upstream registry.
        description: Option<string>
        /// URL of the upstream registry.
        url: string
        /// Cache validity period. Defaults to 24 hours.
        cacheValidityHours: Option<int>
        /// Username of the upstream registry.
        username: Option<string>
        /// Password of the upstream registry.
        password: Option<string>
    }

/// Autogenerated input type of MemberRoleAdminCreate
type MemberRoleAdminCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the member role.
        description: Option<string>
        /// Name of the member role.
        name: Option<string>
        /// List of all customizable admin permissions.
        permissions: Option<list<MemberRoleAdminPermission>>
    }

/// Autogenerated input type of MemberRoleAdminDelete
type MemberRoleAdminDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the admin member role to delete.
        id: string
    }

/// Autogenerated input type of MemberRoleAdminUpdate
type MemberRoleAdminUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the member role.
        description: Option<string>
        /// Name of the member role.
        name: Option<string>
        /// List of all customizable admin permissions.
        permissions: Option<list<MemberRoleAdminPermission>>
        /// ID of the member role to mutate.
        id: string
    }

/// Autogenerated input type of MemberRoleCreate
type MemberRoleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the member role.
        description: Option<string>
        /// Name of the member role.
        name: Option<string>
        /// List of all customizable permissions.
        permissions: Option<list<MemberRolePermission>>
        /// Base access level for the custom role.
        baseAccessLevel: MemberRolesAccessLevel
        /// Group the member role to mutate is in. Required for SaaS.
        groupPath: Option<string>
    }

/// Autogenerated input type of MemberRoleDelete
type MemberRoleDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the member role to delete.
        id: string
    }

/// Autogenerated input type of MemberRoleToUserAssign
type MemberRoleToUserAssignInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the user to be assigned to a custom role.
        userId: string
        /// Global ID of the custom role to be assigned to a user.            Admin roles will be unassigned from the user if omitted or set as NULL.
        memberRoleId: Option<string>
    }

/// Autogenerated input type of MemberRoleUpdate
type MemberRoleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the member role.
        description: Option<string>
        /// Name of the member role.
        name: Option<string>
        /// List of all customizable permissions.
        permissions: Option<list<MemberRolePermission>>
        /// ID of the member role to mutate.
        id: string
    }

/// Defines which user roles, users, or groups can merge into a protected branch.
type MergeAccessLevelInput =
    {
        /// Access level allowed to perform action.
        accessLevel: Option<int>
        /// User associated with the access level.
        userId: Option<string>
        /// Group associated with the access level.
        groupId: Option<string>
    }

/// Autogenerated input type of MergeRequestAccept
type MergeRequestAcceptInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// How to merge the merge request.
        strategy: Option<MergeStrategyEnum>
        /// Custom merge commit message.
        commitMessage: Option<string>
        /// HEAD SHA at the time when the merge was requested.
        sha: string
        /// Custom squash commit message (if squash is true).
        squashCommitMessage: Option<string>
        /// Should the source branch be removed.
        shouldRemoveSourceBranch: Option<bool>
        /// Squash commits on the source branch before merge.
        squash: Option<bool>
    }

/// Autogenerated input type of MergeRequestBypassSecurityPolicy
type MergeRequestBypassSecurityPolicyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// ID of the security policy to bypass.
        securityPolicyIds: list<string>
        /// Reason for bypassing the security policy.
        reason: string
    }

/// Autogenerated input type of MergeRequestCreate
type MergeRequestCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the merge request is associated with.
        projectPath: string
        /// Title of the merge request.
        title: string
        /// Source branch of the merge request.
        sourceBranch: string
        /// Target branch of the merge request.
        targetBranch: string
        /// Description of the merge request (Markdown rendered as HTML for caching).
        description: Option<string>
        /// Labels of the merge request.
        labels: Option<list<string>>
        /// Date after which the merge request can be merged.
        mergeAfter: Option<string>
        /// Indicates if the source branch of the merge request will be deleted after merge.
        removeSourceBranch: Option<bool>
    }

/// Autogenerated input type of MergeRequestDestroyRequestedChanges
type MergeRequestDestroyRequestedChangesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
    }

/// Autogenerated input type of MergeRequestReviewerRereview
type MergeRequestReviewerRereviewInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// User ID for the user that has been requested for a new review.
        userId: string
    }

/// Autogenerated input type of MergeRequestSetAssignees
type MergeRequestSetAssigneesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Usernames to assign to the resource. Replaces existing assignees by default.
        assigneeUsernames: list<string>
        /// Operation to perform. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of MergeRequestSetDraft
type MergeRequestSetDraftInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Whether or not to set the merge request as a draft.
        draft: bool
    }

/// Autogenerated input type of MergeRequestSetLabels
type MergeRequestSetLabelsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Label IDs to set. Replaces existing labels by default.
        labelIds: list<string>
        /// Changes the operation mode. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of MergeRequestSetLocked
type MergeRequestSetLockedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Whether or not to lock the merge request.
        locked: bool
    }

/// Autogenerated input type of MergeRequestSetMilestone
type MergeRequestSetMilestoneInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Milestone to assign to the merge request.
        milestoneId: Option<string>
    }

/// Autogenerated input type of MergeRequestSetReviewers
type MergeRequestSetReviewersInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Usernames of reviewers to assign. Replaces existing reviewers by default.
        reviewerUsernames: list<string>
        /// Operation to perform. Defaults to REPLACE.
        operationMode: Option<MutationOperationMode>
    }

/// Autogenerated input type of MergeRequestSetSubscription
type MergeRequestSetSubscriptionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Desired state of the subscription.
        subscribedState: bool
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
    }

/// Autogenerated input type of MergeRequestUpdateApprovalRule
type MergeRequestUpdateApprovalRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Number of required approvals for a given rule.
        approvalsRequired: int
        /// ID of an approval rule.
        approvalRuleId: int
        /// Name of the approval rule.
        name: string
        /// IDs of groups as approvers.
        groupIds: Option<list<string>>
        /// IDs of users as approvers.
        userIds: Option<list<string>>
        /// Whether hidden groups should be removed.
        removeHiddenGroups: Option<bool>
    }

/// Autogenerated input type of MergeRequestUpdate
type MergeRequestUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the merge request to mutate is in.
        projectPath: string
        /// IID of the merge request to mutate.
        iid: string
        /// Title of the merge request.
        title: Option<string>
        /// Target branch of the merge request.
        targetBranch: Option<string>
        /// Description of the merge request (Markdown rendered as HTML for caching).
        description: Option<string>
        /// Action to perform to change the state.
        state: Option<MergeRequestNewState>
        /// Estimated time to complete the merge request. Use `null` or `0` to remove the current estimate.
        timeEstimate: Option<string>
        /// Date after which the merge request can be merged.
        mergeAfter: Option<string>
        /// Indicates if the source branch of the merge request will be deleted after merge.
        removeSourceBranch: Option<bool>
        /// Override all requested changes. Can only be set by users who have permissionto merge this merge request.
        overrideRequestedChanges: Option<bool>
    }

type MergeRequestsResolverNegatedParams =
    {
        /// Filters merge requests to exclude any that are approved by usernames in the given array.
        approvedBy: Option<list<string>>
        /// Filters merge requests to exclude any that are assigned to the usernames in the given array.
        assigneeUsernames: Option<list<string>>
        /// Filters merge requests to exclude any that are authored by the given user.
        authorUsername: Option<string>
        /// Filters merge requests to exclude any that have the labels provided in the given array.
        labelName: Option<list<string>>
        /// Filters merge requests to those not in the given milestone.
        milestoneTitle: Option<string>
        /// Filters merge requests to those without the given reaction from the authenticated user.
        myReactionEmoji: Option<string>
        /// Filters merge requests to those without the given release tag.
        releaseTag: Option<string>
        /// Filters merge requests to those not reviewed by the given user.
        reviewerUsername: Option<string>
        /// Filters merge requests to exclude the source branch names provided in the given array.
        sourceBranches: Option<list<string>>
        /// Filters merge requests to exclude the target branch names provided in the given array.
        targetBranches: Option<list<string>>
    }

/// Autogenerated input type of MergeTrainsDeleteCar
type MergeTrainsDeleteCarInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the car.
        carId: string
    }

/// Autogenerated input type of MlModelCreate
type MlModelCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Name of the model.
        name: string
        /// Description of the model.
        description: Option<string>
    }

/// Autogenerated input type of MlModelDelete
type MlModelDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Global ID of the model to be deleted.
        id: string
    }

/// Autogenerated input type of MlModelDestroy
type MlModelDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Global ID of the model to be deleted.
        id: string
    }

/// Autogenerated input type of MlModelEdit
type MlModelEditInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Id of the model.
        modelId: Option<int>
        /// Name of the model.
        name: string
        /// Description of the model.
        description: Option<string>
    }

/// Autogenerated input type of MlModelVersionCreate
type MlModelVersionCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Global ID of the model the version belongs to.
        modelId: string
        /// Model version.
        version: Option<string>
        /// Description of the model version.
        description: Option<string>
        /// Global ID of a candidate to promote optionally.
        candidateId: Option<string>
    }

/// Autogenerated input type of MlModelVersionDelete
type MlModelVersionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the model version to be deleted.
        id: string
    }

/// Autogenerated input type of MlModelVersionEdit
type MlModelVersionEditInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the model to mutate is in.
        projectPath: string
        /// Global ID of the model the version belongs to.
        modelId: string
        /// Model version.
        version: string
        /// Description of the model version.
        description: string
    }

/// Autogenerated input type of NamespaceBanDestroy
type NamespaceBanDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the namespace ban to remove.
        id: string
    }

/// Autogenerated input type of NamespaceCiCdSettingsUpdate
type NamespaceCiCdSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Indicates if stale runners directly belonging to the namespace should be periodically pruned.
        allowStaleRunnerPruning: Option<bool>
        /// Full path of the namespace the settings belong to.
        fullPath: string
    }

/// Autogenerated input type of NamespaceCreateRemoteDevelopmentClusterAgentMapping
type NamespaceCreateRemoteDevelopmentClusterAgentMappingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// GlobalID of the cluster agent to be associated with the namespace.
        clusterAgentId: string
        /// GlobalID of the namespace to be associated with the cluster agent.
        namespaceId: string
    }

/// Autogenerated input type of NamespaceDeleteRemoteDevelopmentClusterAgentMapping
type NamespaceDeleteRemoteDevelopmentClusterAgentMappingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// GlobalID of the cluster agent to be un-associated from the namespace.
        clusterAgentId: string
        /// GlobalID of the namespace to be un-associated from the cluster agent.
        namespaceId: string
    }

/// Autogenerated input type of NamespaceSettingsUpdate
type NamespaceSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace the settings belong to.
        fullPath: string
        /// Indicates the default minimum role required to override pipeline variables in the namespace.
        pipelineVariablesDefaultRole: Option<PipelineVariablesDefaultRoleType>
    }

/// Autogenerated input type of NamespacesRegenerateNewWorkItemEmailAddress
type NamespacesRegenerateNewWorkItemEmailAddressInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace to regenerate the new work item email address for.
        fullPath: string
    }

type NegatedBoardIssueInput =
    {
        /// Filter by label name.
        labelName: Option<list<Option<string>>>
        /// Filter by author username.
        authorUsername: Option<string>
        /// Filter by reaction emoji applied by the current user. Wildcard values "NONE" and "ANY" are supported.
        myReactionEmoji: Option<string>
        /// List of IIDs of issues. For example `["1", "2"]`.
        iids: Option<list<string>>
        /// Filter by milestone title.
        milestoneTitle: Option<string>
        /// Filter by assignee username.
        assigneeUsername: Option<list<Option<string>>>
        /// Filter by release tag.
        releaseTag: Option<string>
        /// Filter by the given issue types.
        types: Option<list<IssueType>>
        /// Filter by milestone ID wildcard.
        milestoneWildcardId: Option<MilestoneWildcardId>
        /// Filter by iteration title.
        iterationTitle: Option<string>
        /// Filter by weight.
        weight: Option<string>
        /// Filter by a list of iteration IDs. Incompatible with iterationWildcardId.
        iterationId: Option<list<string>>
        /// Filter by iteration ID wildcard.
        iterationWildcardId: Option<NegatedIterationWildcardId>
        /// Health status not applied to the issue.                    Includes issues where health status is not set.
        healthStatusFilter: Option<HealthStatus>
    }

type NegatedComplianceFrameworkFilters =
    {
        /// ID of the compliance framework.
        id: Option<string>
        /// IDs of the compliance framework.
        ids: Option<list<string>>
    }

type NegatedEpicBoardIssueInput =
    {
        /// Filter by label name.
        labelName: Option<list<Option<string>>>
        /// Filter by author username.
        authorUsername: Option<string>
        /// Filter by reaction emoji applied by the current user. Wildcard values "NONE" and "ANY" are supported.
        myReactionEmoji: Option<string>
    }

type NegatedEpicFilterInput =
    {
        /// Filter by label name.
        labelName: Option<list<Option<string>>>
        /// Filter by author username.
        authorUsername: Option<string>
        /// Filter by reaction emoji applied by the current user.
        myReactionEmoji: Option<string>
    }

type NegatedIssueFilterInput =
    {
        /// ID of a user not assigned to the issues.
        assigneeId: Option<string>
        /// Usernames of users not assigned to the issue.
        assigneeUsernames: Option<list<string>>
        /// Username of a user who didn't author the issue.
        authorUsername: Option<list<string>>
        /// List of IIDs of issues to exclude. For example, `[1, 2]`.
        iids: Option<list<string>>
        /// Labels not applied to the issue.
        labelName: Option<list<string>>
        /// Milestone not applied to the issue.
        milestoneTitle: Option<list<string>>
        /// Filter by negated milestone wildcard values.
        milestoneWildcardId: Option<NegatedMilestoneWildcardId>
        /// Filter by reaction emoji applied by the current user.
        myReactionEmoji: Option<string>
        /// Release tag not associated with the issue's milestone. Ignored when parent is a group.
        releaseTag: Option<list<string>>
        /// Filters out issues by the given issue types.
        types: Option<list<IssueType>>
        /// ID of an epic not associated with the issues.
        epicId: Option<string>
        /// Weight not applied to the issue.
        weight: Option<string>
        /// List of iteration Global IDs not applied to the issue.
        iterationId: Option<list<string>>
        /// Filter by negated iteration ID wildcard.
        iterationWildcardId: Option<IterationWildcardId>
        /// Health status not applied to the issue.                    Includes issues where health status is not set.
        healthStatusFilter: Option<list<HealthStatus>>
    }

type NegatedValueStreamAnalyticsIssuableFilterInput =
    {
        /// Usernames of users not assigned to the issue or merge request.
        assigneeUsernames: Option<list<string>>
        /// Username of a user who didn't author the issue or merge request.
        authorUsername: Option<string>
        /// Milestone not applied to the issue or merge request.
        milestoneTitle: Option<string>
        /// Labels not applied to the issue or merge request.
        labelNames: Option<list<string>>
        /// ID of an epic not associated with the issues.         Using the filter is not supported for stages based on merge requests.
        epicId: Option<string>
        /// List of iteration Global IDs not applied to the issue.         Using the filter is not supported for stages based on merge requests.
        iterationId: Option<string>
        /// Weight not applied to the issue.         Using the filter is not supported for stages based on merge requests.
        weight: Option<int>
        /// Filter by reaction emoji applied by the current user.
        myReactionEmoji: Option<string>
    }

type NegatedWorkItemFilterInput =
    {
        /// Usernames of users not assigned to the work item (maximum is 100 usernames).
        assigneeUsernames: Option<list<string>>
        /// Username of a user who didn't author the work item (maximum is 100 usernames).
        authorUsername: Option<list<string>>
        /// Labels not applied to the work item (maximum is 100 labels).
        labelName: Option<list<string>>
        /// Milestone not applied to the work item (maximum is 100 milestones).
        milestoneTitle: Option<list<string>>
        /// Filter by negated milestone wildcard values.
        milestoneWildcardId: Option<NegatedMilestoneWildcardId>
        /// Filter by reaction emoji not applied by the current user.
        myReactionEmoji: Option<string>
        /// Release tag not associated with the work items's milestone (maximum is 100 tags). Ignored when parent is a group .
        releaseTag: Option<list<string>>
        /// Filter out work items by the given types.
        types: Option<list<IssueType>>
        /// Health status not applied to the work items.                    Includes work items where health status is not set.
        healthStatusFilter: Option<list<HealthStatus>>
        /// Weight not applied to the work items.
        weight: Option<string>
        /// List of iteration Global IDs not applied to the work items (maximum is 100 IDs).
        iterationId: Option<list<string>>
        /// Filter by negated iteration ID wildcard.
        iterationWildcardId: Option<IterationWildcardId>
    }

/// Autogenerated input type of NoteConvertToThread
type NoteConvertToThreadInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Note to convert.
        id: string
    }

/// Active period time range for on-call rotation
type OncallRotationActivePeriodInputType =
    {
        /// Start of the rotation active period in 24 hour format. For example, "18:30".
        startTime: string
        /// End of the rotation active period in 24 hour format. For example, "18:30".
        endTime: string
    }

/// Autogenerated input type of OncallRotationCreate
type OncallRotationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the on-call schedule in.
        projectPath: string
        /// IID of the on-call schedule to create the on-call rotation in.
        scheduleIid: string
        /// Name of the on-call rotation.
        name: string
        /// Start date and time of the on-call rotation, in the timezone of the on-call schedule.
        startsAt: OncallRotationDateInputType
        /// End date and time of the on-call rotation, in the timezone of the on-call schedule.
        endsAt: Option<OncallRotationDateInputType>
        /// Rotation length of the on-call rotation.
        rotationLength: OncallRotationLengthInputType
        /// Active period of time that the on-call rotation should take place.
        activePeriod: Option<OncallRotationActivePeriodInputType>
        /// Usernames of users participating in the on-call rotation. A maximum limit of 100 participants applies.
        participants: list<OncallUserInputType>
    }

/// Date input type for on-call rotation
type OncallRotationDateInputType =
    {
        /// Date component of the date in YYYY-MM-DD format.
        date: string
        /// Time component of the date in 24hr HH:MM format.
        time: string
    }

/// Autogenerated input type of OncallRotationDestroy
type OncallRotationDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to remove the on-call schedule from.
        projectPath: string
        /// IID of the on-call schedule to the on-call rotation belongs to.
        scheduleIid: string
        /// ID of the on-call rotation to remove.
        id: string
    }

/// The rotation length of the on-call rotation
type OncallRotationLengthInputType =
    {
        /// Rotation length of the on-call rotation.
        length: int
        /// Unit of the rotation length of the on-call rotation.
        unit: OncallRotationUnitEnum
    }

/// Autogenerated input type of OncallRotationUpdate
type OncallRotationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the on-call schedule to create the on-call rotation in.
        id: string
        /// Name of the on-call rotation.
        name: Option<string>
        /// Start date and time of the on-call rotation, in the timezone of the on-call schedule.
        startsAt: Option<OncallRotationDateInputType>
        /// End date and time of the on-call rotation, in the timezone of the on-call schedule.
        endsAt: Option<OncallRotationDateInputType>
        /// Rotation length of the on-call rotation.
        rotationLength: Option<OncallRotationLengthInputType>
        /// Active period of time that the on-call rotation should take place.
        activePeriod: Option<OncallRotationActivePeriodInputType>
        /// Usernames of users participating in the on-call rotation. A maximum limit of 100 participants applies.
        participants: Option<list<OncallUserInputType>>
    }

/// Autogenerated input type of OncallScheduleCreate
type OncallScheduleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the on-call schedule in.
        projectPath: string
        /// Name of the on-call schedule.
        name: string
        /// Description of the on-call schedule.
        description: Option<string>
        /// Timezone of the on-call schedule.
        timezone: string
    }

/// Autogenerated input type of OncallScheduleDestroy
type OncallScheduleDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to remove the on-call schedule from.
        projectPath: string
        /// On-call schedule internal ID to remove.
        iid: string
    }

/// Autogenerated input type of OncallScheduleUpdate
type OncallScheduleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to update the on-call schedule in.
        projectPath: string
        /// On-call schedule internal ID to update.
        iid: string
        /// Name of the on-call schedule.
        name: Option<string>
        /// Description of the on-call schedule.
        description: Option<string>
        /// Timezone of the on-call schedule.
        timezone: Option<string>
    }

/// The rotation user and color palette
type OncallUserInputType =
    {
        /// Username of the user to participate in the on-call rotation. For example, `"user_one"`.
        username: string
        /// Value of DataVisualizationColorEnum. The color from the palette to assign to the on-call user.
        colorPalette: Option<DataVisualizationColorEnum>
        /// Color weight to assign to for the on-call user. To view on-call schedules in GitLab, do not provide a value below 500. A value between 500 and 950 ensures sufficient contrast.
        colorWeight: Option<DataVisualizationWeightEnum>
    }

/// Autogenerated input type of OrganizationCreateClusterAgentMapping
type OrganizationCreateClusterAgentMappingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// GlobalID of the cluster agent to be associated with the organization.
        clusterAgentId: string
        /// GlobalID of the organization to be associated with the cluster agent.
        organizationId: string
    }

/// Autogenerated input type of OrganizationCreate
type OrganizationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the organization.
        description: Option<string>
        /// Avatar for the organization.
        avatar: Option<string>
        /// Name for the organization.
        name: string
        /// Path for the organization.
        path: string
    }

/// Autogenerated input type of OrganizationDeleteClusterAgentMapping
type OrganizationDeleteClusterAgentMappingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// GlobalID of the cluster agent to be dissociated with the organization.
        clusterAgentId: string
        /// GlobalID of the organization to be dissociated with the cluster agent.
        organizationId: string
    }

/// Autogenerated input type of OrganizationUpdate
type OrganizationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the organization.
        description: Option<string>
        /// Avatar for the organization.
        avatar: Option<string>
        /// ID of the organization to mutate.
        id: string
        /// Name for the organization.
        name: Option<string>
        /// Path for the organization.
        path: Option<string>
    }

/// Autogenerated input type of OrganizationUserUpdate
type OrganizationUserUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Access level to update the organization user to.
        accessLevel: OrganizationUserAccessLevel
        /// ID of the organization user to mutate.
        id: string
    }

/// Autogenerated input type of PagesMarkOnboardingComplete
type PagesMarkOnboardingCompleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
    }

/// Autogenerated input type of PipelineCancel
type PipelineCancelInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline to mutate.
        id: string
    }

/// Autogenerated input type of PipelineCreate
type PipelineCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project that is triggering the pipeline.
        projectPath: string
        /// Ref on which to run the pipeline.
        ref: string
        /// Variables for the pipeline.
        variables: Option<list<CiVariableInput>>
    }

/// Autogenerated input type of PipelineDestroy
type PipelineDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline to mutate.
        id: string
    }

/// Autogenerated input type of PipelineRetry
type PipelineRetryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline to mutate.
        id: string
    }

/// Autogenerated input type of PipelineScheduleCreate
type PipelineScheduleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the pipeline schedule is associated with.
        projectPath: string
        /// Description of the pipeline schedule.
        description: string
        /// Cron expression of the pipeline schedule.
        cron: string
        ///                     Cron time zone supported by `ActiveSupport::TimeZone`.                    For example: `Pacific Time (US & Canada)` (default: `UTC`).
        cronTimezone: Option<string>
        /// Ref of the pipeline schedule.
        ref: string
        /// Indicates if the pipeline schedule should be active or not.
        active: Option<bool>
        /// Variables for the pipeline schedule.
        variables: Option<list<PipelineScheduleVariableInput>>
    }

/// Autogenerated input type of PipelineScheduleDelete
type PipelineScheduleDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline schedule to mutate.
        id: string
    }

/// Autogenerated input type of PipelineSchedulePlay
type PipelineSchedulePlayInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline schedule to mutate.
        id: string
    }

/// Autogenerated input type of PipelineScheduleTakeOwnership
type PipelineScheduleTakeOwnershipInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline schedule to mutate.
        id: string
    }

/// Autogenerated input type of PipelineScheduleUpdate
type PipelineScheduleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline schedule to mutate.
        id: string
        /// Description of the pipeline schedule.
        description: Option<string>
        /// Cron expression of the pipeline schedule.
        cron: Option<string>
        ///                     Cron time zone supported by `ActiveSupport::TimeZone`.                    For example: `Pacific Time (US & Canada)` (default: `UTC`).
        cronTimezone: Option<string>
        /// Ref of the pipeline schedule.
        ref: Option<string>
        /// Indicates if the pipeline schedule should be active or not.
        active: Option<bool>
        /// Variables for the pipeline schedule.
        variables: Option<list<PipelineScheduleVariableInput>>
    }

/// Attributes for the pipeline schedule variable.
type PipelineScheduleVariableInput =
    {
        /// ID of the variable to mutate.
        id: Option<string>
        /// Name of the variable.
        key: string
        /// Value of the variable.
        value: string
        /// Type of the variable.
        variableType: CiVariableType
        /// Boolean option to destroy the variable.
        destroy: Option<bool>
    }

/// Autogenerated input type of PipelineTriggerCreate
type PipelineTriggerCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project that the pipeline trigger token to mutate is in.
        projectPath: string
        /// Description of the pipeline trigger token.
        description: string
        /// Timestamp of when the pipeline trigger token expires.
        expiresAt: Option<string>
    }

/// Autogenerated input type of PipelineTriggerDelete
type PipelineTriggerDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline trigger token to delete.
        id: string
    }

/// Autogenerated input type of PipelineTriggerUpdate
type PipelineTriggerUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the pipeline trigger token to update.
        id: string
        /// Description of the pipeline trigger token.
        description: string
    }

/// Representation of who is provided access to. For eg: User/Role/MemberRole/Group.
type PrincipalInput =
    {
        /// ID of the principal.
        id: int
        /// Type of the principal.
        ``type``: PrincipalType
    }

/// Autogenerated input type of ProcessUserBillablePromotionRequest
type ProcessUserBillablePromotionRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of user to be promoted.
        userId: string
        /// Status for the member approval request (approved, denied, pending).
        status: MemberApprovalStatusType
    }

/// Autogenerated input type of ProductAnalyticsProjectSettingsUpdate
type ProductAnalyticsProjectSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the settings belong to.
        fullPath: string
        /// Connection string for the product analytics configurator.
        productAnalyticsConfiguratorConnectionString: Option<string>
        /// Host for the product analytics data collector.
        productAnalyticsDataCollectorHost: Option<string>
        /// Base URL for the Cube API.
        cubeApiBaseUrl: Option<string>
        /// API key for the Cube API.
        cubeApiKey: Option<string>
    }

/// Autogenerated input type of ProjectCiCdSettingsUpdate
type ProjectCiCdSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full Path of the project the settings belong to.
        fullPath: string
        /// Indicates whether group runners are enabled for the project.
        groupRunnersEnabled: Option<bool>
        /// Indicates whether the latest artifact should be kept for the project.
        keepLatestArtifact: Option<bool>
        /// Indicates whether CI/CD job tokens generated in other projects have restricted access to this project.
        inboundJobTokenScopeEnabled: Option<bool>
        /// Indicates the ability to push to the original project repository using a job token
        pushRepositoryForJobTokenAllowed: Option<bool>
        /// Indicates whether pipeline variables can be displayed in the UI.
        displayPipelineVariables: Option<bool>
        /// Minimum role required to set variables when creating a pipeline or running a job.
        pipelineVariablesMinimumOverrideRole: Option<string>
        /// Default process mode for resource groups in the project.
        resourceGroupDefaultProcessMode: Option<ResourceGroupsProcessMode>
        /// Indicates if merged results pipelines are enabled for the project.
        mergePipelinesEnabled: Option<bool>
        /// Indicates if merge trains are enabled for the project.
        mergeTrainsEnabled: Option<bool>
        /// Indicates whether an option is allowed to merge without refreshing the merge train. Ignored unless the `merge_trains_skip_train` feature flag is also enabled.
        mergeTrainsSkipTrainAllowed: Option<bool>
    }

type ProjectComplianceControlStatusInput =
    {
        /// Compliance requirement id of the statuses.
        complianceRequirementId: Option<string>
    }

/// Filters for project compliance violations.
type ProjectComplianceViolationFilterInput =
    {
        /// Project ID for which to filter compliance violations.
        projectId: Option<string>
        /// Control ID for which to filter compliance violations.
        controlId: Option<string>
        /// Status of the project compliance violation.
        status: Option<list<ComplianceViolationStatus>>
        /// Compliance violations created on or before the date (inclusive).
        createdBefore: Option<string>
        /// Compliance violations created on or after the date (inclusive).
        createdAfter: Option<string>
    }

/// Autogenerated input type of ProjectInitializeProductAnalytics
type ProjectInitializeProductAnalyticsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to initialize.
        projectPath: string
    }

/// Autogenerated input type of ProjectMemberBulkUpdate
type ProjectMemberBulkUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the members.
        userIds: list<string>
        /// Access level to update the members to.
        accessLevel: MemberAccessLevel
        /// Date and time the membership expires.
        expiresAt: Option<string>
        /// Global ID of the project.
        projectId: string
    }

type ProjectRequirementComplianceStatusInput =
    {
        /// Filter compliance requirement statuses by compliance requirement.
        requirementId: Option<string>
        /// Filter compliance requirement statuses by compliance framework.
        frameworkId: Option<string>
    }

/// Autogenerated input type of ProjectSavedReplyCreate
type ProjectSavedReplyCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
        /// Project for the saved reply.
        projectId: string
    }

/// Autogenerated input type of ProjectSavedReplyDestroy
type ProjectSavedReplyDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project-level saved reply.
        id: string
    }

/// Autogenerated input type of ProjectSavedReplyUpdate
type ProjectSavedReplyUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
        /// Global ID of the project-level saved reply.
        id: string
    }

/// Autogenerated input type of ProjectSecretCreate
type ProjectSecretCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the secret.
        projectPath: string
        /// Name of the project secret.
        name: string
        /// Description of the project secret.
        description: Option<string>
        /// Value of the project secret.
        secret: string
        /// Environments that can access the secret.
        environment: string
        /// Branches that can access the secret.
        branch: string
        /// Number of days between rotation reminders for the secret.
        rotationIntervalDays: Option<int>
    }

/// Autogenerated input type of ProjectSecretDelete
type ProjectSecretDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the secret.
        projectPath: string
        /// Name of the project secret.
        name: string
    }

/// Autogenerated input type of ProjectSecretUpdate
type ProjectSecretUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the secret.
        projectPath: string
        /// Name of the project secret to update.
        name: string
        /// New description of the project secret.
        description: Option<string>
        /// New value of the project secret.
        secret: Option<string>
        /// New environments that can access the secret.
        environment: Option<string>
        /// New branches that can access the secret.
        branch: Option<string>
        /// Number of days between rotation reminders for the secret.
        rotationIntervalDays: Option<int>
        /// This should match the current metadata version of the project secret being updated.
        metadataCas: int
    }

/// Autogenerated input type of ProjectSecretsManagerDeprovision
type ProjectSecretsManagerDeprovisionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the secrets manager.
        projectPath: string
    }

/// Autogenerated input type of ProjectSecretsManagerInitialize
type ProjectSecretsManagerInitializeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project of the secrets manager.
        projectPath: string
    }

/// Autogenerated input type of ProjectSecurityExclusionCreate
type ProjectSecurityExclusionCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the exclusion will be associated with.
        projectPath: string
        /// Type of the exclusion.
        ``type``: ExclusionTypeEnum
        /// Scanner to ignore values for based on the exclusion.
        scanner: ExclusionScannerEnum
        /// Value of the exclusion.
        value: string
        /// Whether the exclusion is active.
        active: bool
        /// Optional description for the exclusion.
        description: Option<string>
    }

/// Autogenerated input type of ProjectSecurityExclusionDelete
type ProjectSecurityExclusionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the exclusion to be deleted.
        id: string
    }

/// Autogenerated input type of ProjectSecurityExclusionUpdate
type ProjectSecurityExclusionUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the exclusion to be updated.
        id: string
        /// Type of the exclusion.
        ``type``: Option<ExclusionTypeEnum>
        /// Scanner to ignore values for based on the exclusion.
        scanner: Option<ExclusionScannerEnum>
        /// Value of the exclusion.
        value: Option<string>
        /// Whether the exclusion is active.
        active: Option<bool>
        /// Optional description for the exclusion.
        description: Option<string>
    }

/// Autogenerated input type of ProjectSetComplianceFramework
type ProjectSetComplianceFrameworkInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to change the compliance framework of.
        projectId: string
        /// ID of the compliance framework to assign to the project. Set to `null` to unset.
        complianceFrameworkId: Option<string>
    }

/// Autogenerated input type of ProjectSetContinuousVulnerabilityScanning
type ProjectSetContinuousVulnerabilityScanningInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
        /// Desired status for continuous vulnerability scanning feature.
        enable: bool
    }

/// Autogenerated input type of ProjectSetLocked
type ProjectSetLockedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to mutate.
        projectPath: string
        /// Full path to the file.
        filePath: string
        /// Whether or not to lock the file path.
        lock: bool
    }

/// Autogenerated input type of ProjectSettingsUpdate
type ProjectSettingsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full Path of the project the settings belong to.
        fullPath: string
        /// Indicates whether GitLab Duo features are enabled for the project.
        duoFeaturesEnabled: Option<bool>
        /// Settings for excluding files from Duo context.
        duoContextExclusionSettings: Option<DuoContextExclusionSettingsInput>
    }

/// Autogenerated input type of ProjectSubscriptionCreate
type ProjectSubscriptionCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the downstream project of the Project Subscription.
        projectPath: string
        /// Full path of the upstream project of the Project Subscription.
        upstreamPath: string
    }

/// Autogenerated input type of ProjectSubscriptionDelete
type ProjectSubscriptionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the subscription to delete.
        subscriptionId: string
    }

/// Autogenerated input type of ProjectSyncFork
type ProjectSyncForkInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to initialize.
        projectPath: string
        /// Ref of the fork to fetch into.
        targetBranch: string
    }

/// Autogenerated input type of ProjectTargetBranchRuleCreate
type ProjectTargetBranchRuleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project ID for the target branch rule.
        projectId: string
        /// Name for the target branch rule.
        name: string
        /// Target branch for the target branch rule.
        targetBranch: string
    }

/// Autogenerated input type of ProjectTargetBranchRuleDestroy
type ProjectTargetBranchRuleDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID for the target branch rule.
        id: string
    }

/// Autogenerated input type of ProjectUpdateComplianceFrameworks
type ProjectUpdateComplianceFrameworksInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to change the compliance framework of.
        projectId: string
        /// IDs of the compliance framework to update for the project.
        complianceFrameworkIds: list<string>
    }

/// Autogenerated input type of PrometheusIntegrationCreate
type PrometheusIntegrationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the integration in.
        projectPath: string
        /// Type of integration to create. Cannot be changed after creation.
        ``type``: Option<AlertManagementIntegrationType>
        /// Whether the integration is receiving alerts.
        active: bool
        /// Example of an alert payload.
        payloadExample: Option<string>
        /// Custom mapping of GitLab alert attributes to fields from the payload example.
        payloadAttributeMappings: Option<list<AlertManagementPayloadAlertFieldInput>>
        /// Name of the integration.
        name: Option<string>
    }

/// Autogenerated input type of PrometheusIntegrationResetToken
type PrometheusIntegrationResetTokenInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the integration to mutate.
        id: string
    }

/// Autogenerated input type of PrometheusIntegrationUpdate
type PrometheusIntegrationUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the integration.
        name: Option<string>
        /// Whether the integration is receiving alerts.
        active: Option<bool>
        /// Example of an alert payload.
        payloadExample: Option<string>
        /// Custom mapping of GitLab alert attributes to fields from the payload example.
        payloadAttributeMappings: Option<list<AlertManagementPayloadAlertFieldInput>>
        /// ID of the integration to mutate.
        id: string
    }

/// Autogenerated input type of PromoteToEpic
type PromoteToEpicInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Group the promoted epic will belong to.
        groupPath: Option<string>
    }

/// Defines which user roles, users, deploy keys, or groups can push to a protected branch.
type PushAccessLevelInput =
    {
        /// Access level allowed to perform action.
        accessLevel: Option<int>
        /// User associated with the access level.
        userId: Option<string>
        /// Group associated with the access level.
        groupId: Option<string>
        /// Deploy key assigned to the access level.
        deployKeyId: Option<string>
    }

/// Autogenerated input type of RefreshFindingTokenStatus
type RefreshFindingTokenStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Vulnerability whose token status should be refreshed.
        vulnerabilityId: string
    }

/// Autogenerated input type of RefreshSecurityFindingTokenStatus
type RefreshSecurityFindingTokenStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the Security::Finding whose token status should be refreshed (MR context).
        securityFindingUuid: string
    }

/// Autogenerated input type of RefreshStandardsAdherenceChecks
type RefreshStandardsAdherenceChecksInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group path.
        groupPath: string
    }

/// Autogenerated input type of RefreshVulnerabilityFindingTokenStatus
type RefreshVulnerabilityFindingTokenStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Vulnerability whose token status should be refreshed.
        vulnerabilityId: string
    }

/// Autogenerated input type of ReleaseAssetLinkCreate
type ReleaseAssetLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the asset link.
        name: string
        /// URL of the asset link.
        url: string
        /// Relative path for a direct asset link.
        directAssetPath: Option<string>
        /// Type of the asset link.
        linkType: Option<ReleaseAssetLinkType>
        /// Full path of the project the asset link is associated with.
        projectPath: string
        /// Name of the associated release's tag.
        tagName: string
    }

/// Autogenerated input type of ReleaseAssetLinkDelete
type ReleaseAssetLinkDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the release asset link to delete.
        id: string
    }

/// Fields that are available when modifying a release asset link
type ReleaseAssetLinkInput =
    {
        /// Name of the asset link.
        name: string
        /// URL of the asset link.
        url: string
        /// Relative path for a direct asset link.
        directAssetPath: Option<string>
        /// Type of the asset link.
        linkType: Option<ReleaseAssetLinkType>
    }

/// Autogenerated input type of ReleaseAssetLinkUpdate
type ReleaseAssetLinkUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the release asset link to update.
        id: string
        /// Name of the asset link.
        name: Option<string>
        /// URL of the asset link.
        url: Option<string>
        /// Relative path for a direct asset link.
        directAssetPath: Option<string>
        /// Type of the asset link.
        linkType: Option<ReleaseAssetLinkType>
    }

/// Fields that are available when modifying release assets
type ReleaseAssetsInput =
    {
        /// List of asset links to associate to the release.
        links: Option<list<ReleaseAssetLinkInput>>
    }

/// Autogenerated input type of ReleaseCreate
type ReleaseCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the release is associated with.
        projectPath: string
        /// Name of the tag to associate with the release.
        tagName: string
        /// Message to use if creating a new annotated tag.
        tagMessage: Option<string>
        /// Commit SHA or branch name to use if creating a new tag.
        ref: Option<string>
        /// Name of the release.
        name: Option<string>
        /// Description (also known as "release notes") of the release.
        description: Option<string>
        /// Date and time for the release. Defaults to the current time. Expected in ISO 8601 format (`2019-03-15T08:00:00Z`). Only provide this field if creating an upcoming or historical release.
        releasedAt: Option<string>
        /// Title of each milestone the release is associated with. GitLab Premium customers can specify group milestones.
        milestones: Option<list<string>>
        /// Assets associated to the release.
        assets: Option<ReleaseAssetsInput>
    }

/// Autogenerated input type of ReleaseDelete
type ReleaseDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the release is associated with.
        projectPath: string
        /// Name of the tag associated with the release to delete.
        tagName: string
    }

/// Autogenerated input type of ReleaseUpdate
type ReleaseUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project the release is associated with.
        projectPath: string
        /// Name of the tag associated with the release.
        tagName: string
        /// Name of the release.
        name: Option<string>
        /// Description (release notes) of the release.
        description: Option<string>
        /// Release date.
        releasedAt: Option<string>
        /// Title of each milestone the release is associated with. GitLab Premium customers can specify group milestones.
        milestones: Option<list<string>>
    }

/// Autogenerated input type of RemoveProjectFromSecurityDashboard
type RemoveProjectFromSecurityDashboardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to remove from the Instance Security Dashboard.
        id: string
    }

/// Autogenerated input type of RepositionImageDiffNote
type RepositionImageDiffNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the DiffNote to update.
        id: string
        /// Position of the note on a diff.
        position: UpdateDiffImagePositionInput
    }

type RequirementLegacyFilterInput =
    {
        /// List of legacy requirement IIDs of work items. or example `["1", "2"]`.
        legacyIids: list<string>
    }

/// Autogenerated input type of RestorePagesDeployment
type RestorePagesDeploymentInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the Pages Deployment.
        id: string
    }

/// Autogenerated input type of ResyncSecurityPolicies
type ResyncSecurityPoliciesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project or group.
        fullPath: string
        /// Relationship of the policies to resync.
        relationship: Option<RelationshipType>
    }

/// Autogenerated input type of RunnerAssignToProject
type RunnerAssignToProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the runner to assign to the project .
        runnerId: string
        /// Full path of the project to which the runner will be assigned.
        projectPath: string
    }

/// Autogenerated input type of RunnerBulkPause
type RunnerBulkPauseInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IDs of the runners to pause or unpause.
        ids: list<string>
        /// Indicates the runner is not allowed to receive jobs.
        paused: bool
    }

/// Autogenerated input type of RunnerCacheClear
type RunnerCacheClearInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project that will have its runner cache cleared.
        projectId: string
    }

/// Autogenerated input type of RunnerCreate
type RunnerCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the runner.
        description: Option<string>
        /// Runner's maintenance notes.
        maintenanceNote: Option<string>
        /// Maximum timeout (in seconds) for jobs processed by the runner.
        maximumTimeout: Option<int>
        /// Access level of the runner.
        accessLevel: Option<CiRunnerAccessLevel>
        /// Indicates the runner is not allowed to receive jobs.
        paused: Option<bool>
        /// Indicates the runner is locked.
        locked: Option<bool>
        /// Indicates the runner is able to run untagged jobs.
        runUntagged: Option<bool>
        /// Tags associated with the runner.
        tagList: Option<list<string>>
        /// Type of the runner to create.
        runnerType: CiRunnerType
        /// Global ID of the group that the runner is created in (valid only for group runner).
        groupId: Option<string>
        /// Global ID of the project that the runner is created in (valid only for project runner).
        projectId: Option<string>
    }

/// Autogenerated input type of RunnerDelete
type RunnerDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the runner to delete.
        id: string
    }

/// Autogenerated input type of RunnerUnassignFromProject
type RunnerUnassignFromProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the runner to unassign from the project.
        runnerId: string
        /// Full path of the project from which the runner will be unassigned.
        projectPath: string
    }

/// Autogenerated input type of RunnerUpdate
type RunnerUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the runner.
        description: Option<string>
        /// Runner's maintenance notes.
        maintenanceNote: Option<string>
        /// Maximum timeout (in seconds) for jobs processed by the runner.
        maximumTimeout: Option<int>
        /// Access level of the runner.
        accessLevel: Option<CiRunnerAccessLevel>
        /// Indicates the runner is not allowed to receive jobs.
        paused: Option<bool>
        /// Indicates the runner is locked.
        locked: Option<bool>
        /// Indicates the runner is able to run untagged jobs.
        runUntagged: Option<bool>
        /// Tags associated with the runner.
        tagList: Option<list<string>>
        /// ID of the runner to update.
        id: string
        /// Projects associated with the runner. Available only for project runners.
        associatedProjects: Option<list<string>>
    }

/// Autogenerated input type of RunnersExportUsage
type RunnersExportUsageInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Filter jobs by the full path of the group or project they belong to. For example, `gitlab-org` or `gitlab-org/gitlab`. Available only to administrators and users with the Maintainer role for the group (when a group is specified), or project (when a project is specified). Limited to runners from 5000 child projects.
        fullPath: Option<string>
        /// Scope of the runners to include in the report.
        runnerType: Option<CiRunnerType>
        /// UTC start date of the period to report on. Defaults to the start of last full month.
        fromDate: Option<string>
        /// UTC end date of the period to report on. " \            "Defaults to the end of the month specified by `fromDate`.
        toDate: Option<string>
        /// Maximum number of projects to return. All other runner usage will be attributed to an `<Other projects>` entry. Defaults to 1000 projects.
        maxProjectCount: Option<int>
    }

/// Autogenerated input type of RunnersRegistrationTokenReset
type RunnersRegistrationTokenResetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Scope of the object to reset the token for.
        ``type``: CiRunnerType
        /// ID of the project or group to reset the token for. Omit if resetting instance runner token.
        id: Option<string>
    }

/// Autogenerated input type of SafeDisablePipelineVariables
type SafeDisablePipelineVariablesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the group to disable pipeline variables for.
        fullPath: string
    }

/// Represents the analyzers entity in SAST CI configuration
type SastCiConfigurationAnalyzersEntityInput =
    {
        /// Name of analyzer.
        name: string
        /// State of the analyzer.
        enabled: bool
        /// List of variables for the analyzer.
        variables: Option<list<SastCiConfigurationEntityInput>>
    }

/// Represents an entity in SAST CI configuration
type SastCiConfigurationEntityInput =
    {
        /// CI keyword of entity.
        field: string
        /// Default value that is used if value is empty.
        defaultValue: string
        /// Current value of the entity.
        value: string
    }

/// Represents a CI configuration of SAST
type SastCiConfigurationInput =
    {
        /// List of global entities related to SAST configuration.
        ``global``: Option<list<SastCiConfigurationEntityInput>>
        /// List of pipeline entities related to SAST configuration.
        pipeline: Option<list<SastCiConfigurationEntityInput>>
        /// List of analyzers and related variables for the SAST configuration.
        analyzers: Option<list<SastCiConfigurationAnalyzersEntityInput>>
    }

/// Autogenerated input type of SavedReplyCreate
type SavedReplyCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
    }

/// Autogenerated input type of SavedReplyDestroy
type SavedReplyDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the user saved reply.
        id: string
    }

/// Autogenerated input type of SavedReplyUpdate
type SavedReplyUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Name of the saved reply.
        name: string
        /// Content of the saved reply.
        content: string
        /// Global ID of the user saved reply.
        id: string
    }

/// Autogenerated input type of ScanExecutionPolicyCommit
type ScanExecutionPolicyCommitInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        fullPath: Option<string>
        /// YAML snippet of the policy.
        policyYaml: string
        /// Changes the operation mode.
        operationMode: MutationOperationMode
        /// Name of the policy. If the name is null, the `name` field from `policy_yaml` is used.
        name: string
    }

/// Autogenerated input type of SecretPermissionDelete
type SecretPermissionDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project permissions for the secret.
        projectPath: string
        /// Whose permission to be deleted.
        principal: PrincipalInput
    }

/// Autogenerated input type of SecretPermissionUpdate
type SecretPermissionUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to which the permissions are added.
        projectPath: string
        /// User/MemberRole/Role/Group that is provided access.
        principal: PrincipalInput
        /// Permissions to be provided. ['create', 'update', 'read', 'delete'].
        permissions: list<string>
        /// Expiration date for Secret Permission (optional).
        expiredAt: Option<string>
    }

/// Autogenerated input type of SecurityAttributeCreate
type SecurityAttributeCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Attributes to create.
        attributes: list<SecurityAttributeInput>
        /// Global ID of the security category.
        categoryId: string
        /// Global ID of the namespace.
        namespaceId: string
    }

/// Autogenerated input type of SecurityAttributeDestroy
type SecurityAttributeDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the security attribute to destroy.
        id: string
    }

/// Input type for security attribute
type SecurityAttributeInput =
    {
        /// Name of the security attribute.
        name: string
        /// Description of the security attribute.
        description: string
        /// Color of the security attribute.
        color: string
    }

/// Autogenerated input type of SecurityAttributeProjectUpdate
type SecurityAttributeProjectUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project.
        projectId: string
        /// Global IDs of the security attributes to add to the project.
        addAttributeIds: Option<list<string>>
        /// Global IDs of the security attributes to remove from the project.
        removeAttributeIds: Option<list<string>>
    }

/// Autogenerated input type of SecurityAttributeUpdate
type SecurityAttributeUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Color of the security attribute.
        color: Option<string>
        /// Description of the security attribute.
        description: Option<string>
        /// Global ID of the security attribute.
        id: string
        /// Name of the security attribute.
        name: Option<string>
    }

/// Autogenerated input type of SecurityCategoryCreate
type SecurityCategoryCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the security category.
        description: Option<string>
        /// Whether multiple attributes can be selected.
        multipleSelection: Option<bool>
        /// Name of the security category.
        name: string
        /// Global ID of the category namespace.
        namespaceId: string
    }

/// Autogenerated input type of SecurityCategoryDestroy
type SecurityCategoryDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the security category to destroy.
        id: string
    }

/// Autogenerated input type of SecurityCategoryUpdate
type SecurityCategoryUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Description of the security category.
        description: Option<string>
        /// Global ID of the security category.
        id: string
        /// Name of the security category.
        name: Option<string>
        /// Global ID of the category namespace.
        namespaceId: string
    }

/// Autogenerated input type of SecurityFindingCreateIssue
type SecurityFindingCreateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the security finding to be used to create an issue.
        uuid: string
        /// ID of the project to attach the issue to.
        project: string
    }

/// Autogenerated input type of SecurityFindingCreateMergeRequest
type SecurityFindingCreateMergeRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the security finding to be used to create a merge request.
        uuid: string
    }

/// Autogenerated input type of SecurityFindingCreateVulnerability
type SecurityFindingCreateVulnerabilityInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the security finding to be used to create a vulnerability.
        uuid: string
    }

/// Autogenerated input type of SecurityFindingDismiss
type SecurityFindingDismissInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the finding to be dismissed.
        uuid: string
        /// Comment why finding should be dismissed.
        comment: Option<string>
        /// Reason why finding should be dismissed.
        dismissalReason: Option<VulnerabilityDismissalReason>
    }

/// Autogenerated input type of SecurityFindingExternalIssueLinkCreate
type SecurityFindingExternalIssueLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the security finding to be used to create an issue.
        uuid: string
        /// Type of the external issue link.
        linkType: VulnerabilityExternalIssueLinkType
        /// ID of the project to attach the issue to.
        project: string
        /// External tracker type of the external issue link.
        externalTracker: VulnerabilityExternalIssueLinkExternalTracker
    }

/// Autogenerated input type of SecurityFindingRevertToDetected
type SecurityFindingRevertToDetectedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the finding to be dismissed.
        uuid: string
        /// Comment that explains why finding was reverted to detected status.
        comment: Option<string>
    }

/// Autogenerated input type of SecurityFindingSeverityOverride
type SecurityFindingSeverityOverrideInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// UUID of the finding to modify.
        uuid: string
        /// New severity value for the finding.
        severity: VulnerabilitySeverity
    }

/// Autogenerated input type of SecurityPolicyProjectAssign
type SecurityPolicyProjectAssignInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project or group.
        fullPath: Option<string>
        /// ID of the security policy project.
        securityPolicyProjectId: string
    }

/// Autogenerated input type of SecurityPolicyProjectCreateAsync
type SecurityPolicyProjectCreateAsyncInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project or group.
        fullPath: string
    }

/// Autogenerated input type of SecurityPolicyProjectCreate
type SecurityPolicyProjectCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project or group.
        fullPath: Option<string>
    }

/// Autogenerated input type of SecurityPolicyProjectUnassign
type SecurityPolicyProjectUnassignInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project or group.
        fullPath: Option<string>
    }

/// Autogenerated input type of SecurityTrainingUpdate
type SecurityTrainingUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
        /// ID of the provider.
        providerId: string
        /// Sets the training provider as enabled for the project.
        isEnabled: bool
        /// Sets the training provider as primary for the project.
        isPrimary: Option<bool>
    }

/// Autogenerated input type of SetContainerScanningForRegistry
type SetContainerScanningForRegistryInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace (project).
        namespacePath: string
        /// Desired status for Container Scanning for Registry feature.
        enable: bool
    }

/// Autogenerated input type of SetGroupSecretPushProtection
type SetGroupSecretPushProtectionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Whether to enable the feature.
        secretPushProtectionEnabled: bool
        /// Full path of the group.
        namespacePath: string
        /// IDs of projects to exclude from the feature.
        projectsToExclude: Option<list<int>>
    }

/// Autogenerated input type of SetGroupValidityChecks
type SetGroupValidityChecksInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Whether to enable validity checks for all projects in the group.
        validityChecksEnabled: bool
        /// Full path of the group.
        namespacePath: string
        /// IDs of projects to exclude from validity checks configuration.
        projectsToExclude: Option<list<int>>
    }

/// Autogenerated input type of SetLicenseConfigurationSource
type SetLicenseConfigurationSourceInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project.
        projectPath: string
        /// Preferred source of license information for dependencies.
        source: SecurityPreferredLicenseSourceConfiguration
    }

/// Autogenerated input type of SetPagesForceHttps
type SetPagesForceHttpsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Indicates user wants to enforce HTTPS on their pages.
        value: bool
        /// Path of the project to set the pages force HTTPS.
        projectPath: string
    }

/// Autogenerated input type of SetPagesUseUniqueDomain
type SetPagesUseUniqueDomainInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Indicates user wants to use unique subdomains for their pages.
        value: bool
        /// Path of the project to set the pages to use unique domains.
        projectPath: string
    }

/// Autogenerated input type of SetPreReceiveSecretDetection
type SetPreReceiveSecretDetectionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace (project).
        namespacePath: string
        /// Desired status for secret push protection feature.
        enable: bool
    }

/// Autogenerated input type of SetSecretPushProtection
type SetSecretPushProtectionInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace (project).
        namespacePath: string
        /// Desired status for secret push protection feature.
        enable: bool
    }

/// Autogenerated input type of SetValidityChecks
type SetValidityChecksInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace (project).
        namespacePath: string
        /// Desired status for validity checks feature.
        enable: bool
    }

/// Represents an action to perform over a snippet file
type SnippetBlobActionInputType =
    {
        /// Type of input action.
        action: SnippetBlobActionEnum
        /// Previous path of the snippet file.
        previousPath: Option<string>
        /// Path of the snippet file.
        filePath: string
        /// Snippet file content.
        content: Option<string>
    }

/// Autogenerated input type of StarProject
type StarProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to star or unstar.
        projectId: string
        /// Indicates whether to star or unstar the project.
        starred: bool
    }

/// Input for mapping a removed status to a replacement status
type StatusMappingInput =
    {
        /// Global ID of the status being removed/replaced.
        oldStatusId: string
        /// Global ID of the replacement status.
        newStatusId: string
    }

/// Autogenerated input type of TagCreate
type TagCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the branch is associated with.
        projectPath: string
        /// Name of the tag.
        name: string
        /// Tag name or commit SHA to create tag from.
        ref: string
        /// Tagging message.
        message: Option<string>
    }

/// Autogenerated input type of TagDelete
type TagDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project full path the branch is associated with.
        projectPath: string
        /// Name of the tag.
        name: string
    }

/// Autogenerated input type of TerraformStateDelete
type TerraformStateDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Terraform state.
        id: string
    }

/// Autogenerated input type of TerraformStateLock
type TerraformStateLockInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Terraform state.
        id: string
    }

/// Autogenerated input type of TerraformStateUnlock
type TerraformStateUnlockInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the Terraform state.
        id: string
    }

/// A time-frame defined as a closed inclusive range of two dates
type Timeframe =
    {
        /// Start of the range.
        start: System.DateTime
        /// End of the range.
        ``end``: System.DateTime
    }

/// Autogenerated input type of TimelineEventCreate
type TimelineEventCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Incident ID of the timeline event.
        incidentId: string
        /// Text note of the timeline event.
        note: string
        /// Timestamp of when the event occurred.
        occurredAt: string
        /// Tags for the incident timeline event.
        timelineEventTagNames: Option<list<string>>
    }

/// Autogenerated input type of TimelineEventDestroy
type TimelineEventDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Timeline event ID to remove.
        id: string
    }

/// Autogenerated input type of TimelineEventPromoteFromNote
type TimelineEventPromoteFromNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Note ID from which the timeline event promoted.
        noteId: string
    }

/// Autogenerated input type of TimelineEventTagCreate
type TimelineEventTagCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project to create the timeline event tag in.
        projectPath: string
        /// Name of the tag.
        name: string
    }

/// Autogenerated input type of TimelineEventUpdate
type TimelineEventUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the timeline event to update.
        id: string
        /// Text note of the timeline event.
        note: Option<string>
        /// Timestamp when the event occurred.
        occurredAt: Option<string>
        /// Tags for the incident timeline event.
        timelineEventTagNames: Option<list<string>>
    }

/// Autogenerated input type of TimelogCreate
type TimelogCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Amount of time spent.
        timeSpent: string
        /// Timestamp of when the time was spent. If empty, defaults to current time.
        spentAt: Option<string>
        /// Summary of time spent.
        summary: string
        /// Global ID of the issuable (Issue, WorkItem or MergeRequest).
        issuableId: string
    }

/// Autogenerated input type of TimelogDelete
type TimelogDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the timelog.
        id: string
    }

/// A closed, inclusive range of two timestamps
type TimestampRange =
    {
        /// Start of the range.
        start: string
        /// End of the range.
        ``end``: string
    }

/// Autogenerated input type of TodoCreate
type TodoCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item's parent. Issues, merge requests, designs, and epics are supported.
        targetId: string
    }

/// Autogenerated input type of TodoDeleteAllDone
type TodoDeleteAllDoneInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// To-do items marked as done before the timestamp will be deleted.
        updatedBefore: Option<string>
    }

/// Autogenerated input type of TodoDeleteMany
type TodoDeleteManyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the to-do items to process (a maximum of 100 is supported at once).
        ids: list<string>
    }

/// Autogenerated input type of TodoMarkDone
type TodoMarkDoneInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item to mark as done.
        id: string
    }

/// Autogenerated input type of TodoResolveMany
type TodoResolveManyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the to-do items to process (a maximum of 100 is supported at once).
        ids: list<string>
    }

/// Autogenerated input type of TodoRestore
type TodoRestoreInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item to restore.
        id: string
    }

/// Autogenerated input type of TodoRestoreMany
type TodoRestoreManyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the to-do items to process (a maximum of 100 is supported at once).
        ids: list<string>
    }

/// Autogenerated input type of TodoSnooze
type TodoSnoozeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item to be snoozed.
        id: string
        /// Time until which the todo should be snoozed.
        snoozeUntil: string
    }

/// Autogenerated input type of TodoSnoozeMany
type TodoSnoozeManyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the to-do items to process (a maximum of 100 is supported at once).
        ids: list<string>
        /// Time until which the todos should be snoozed.
        snoozeUntil: string
    }

/// Autogenerated input type of TodoUnSnooze
type TodoUnSnoozeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item to be snoozed.
        id: string
    }

/// Autogenerated input type of TodoUnsnoozeMany
type TodoUnsnoozeManyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the to-do items to process (a maximum of 100 is supported at once).
        ids: list<string>
    }

/// Autogenerated input type of TodosMarkAllDone
type TodosMarkAllDoneInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the to-do item's parent. Issues, merge requests, designs, and epics are supported. If argument is omitted, all pending to-do items of the current user are marked as done.
        targetId: Option<string>
        /// ID of an author.
        authorId: Option<list<string>>
        /// ID of a project.
        projectId: Option<list<string>>
        /// ID of a group.
        groupId: Option<list<string>>
        /// Action to be filtered.
        action: Option<list<TodoActionEnum>>
        /// Type of the todo.
        ``type``: Option<list<TodoTargetEnum>>
    }

/// Attributes for defining a tracking event.
type TrackingEventInput =
    {
        /// Event action.
        action: string
        /// Event category.
        category: string
        /// Extra metadata for the event.
        extra: Option<string>
        /// Event label.
        label: Option<string>
        /// Event property.
        property: Option<string>
        /// Event value.
        value: Option<string>
    }

type UnionedEpicFilterInput =
    {
        /// Filters epics that have at least one of the given labels.
        labelNames: Option<list<string>>
        /// Filters epics that are authored by one of the given users.
        authorUsernames: Option<list<string>>
    }

type UnionedIssueFilterInput =
    {
        /// Filters issues that are assigned to at least one of the given users.
        assigneeUsernames: Option<list<string>>
        /// Filters issues that are authored by one of the given users.
        authorUsernames: Option<list<string>>
        /// Filters issues that have at least one of the given labels.
        labelNames: Option<list<string>>
    }

type UnionedMergeRequestFilterInput =
    {
        /// Filters MRs that are assigned to at least one of the given users.
        assigneeUsernames: Option<list<string>>
    }

type UnionedWorkItemFilterInput =
    {
        /// Filters work items that are assigned to at least one of the given users (maximum is 100 usernames).
        assigneeUsernames: Option<list<string>>
        /// Filters work items that are authored by one of the given users (maximum is 100 usernames).
        authorUsernames: Option<list<string>>
        /// Filters work items that have at least one of the given labels (maximum is 100 labels).
        labelNames: Option<list<string>>
    }

/// Autogenerated input type of UnlinkProjectComplianceViolationIssue
type UnlinkProjectComplianceViolationIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project compliance violation.
        violationId: string
        /// Full path of the project the issue belongs to.
        projectPath: string
        /// IID of the issue to be unlinked.
        issueIid: string
    }

/// Autogenerated input type of UpdateAlertStatus
type UpdateAlertStatusInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the alert to mutate is in.
        projectPath: string
        /// IID of the alert to mutate.
        iid: string
        /// Status to set the alert.
        status: AlertManagementStatus
    }

/// Autogenerated input type of UpdateBoardEpicUserPreferences
type UpdateBoardEpicUserPreferencesInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Board global ID.
        boardId: string
        /// ID of an epic to set preferences for.
        epicId: string
        /// Whether the epic should be collapsed in the board.
        collapsed: bool
    }

/// Autogenerated input type of UpdateBoard
type UpdateBoardInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Board name.
        name: Option<string>
        /// Whether or not backlog list is hidden.
        hideBacklogList: Option<bool>
        /// Whether or not closed list is hidden.
        hideClosedList: Option<bool>
        /// Board global ID.
        id: string
        /// ID of user to be assigned to the board.
        assigneeId: Option<string>
        /// ID of milestone to be assigned to the board.
        milestoneId: Option<string>
        /// ID of iteration to be assigned to the board.
        iterationId: Option<string>
        /// ID of iteration cadence to be assigned to the board.
        iterationCadenceId: Option<string>
        /// Weight value to be assigned to the board.
        weight: Option<int>
        /// Labels of the issue.
        labels: Option<list<string>>
        /// IDs of labels to be added to the board.
        labelIds: Option<list<string>>
    }

/// Autogenerated input type of UpdateBoardList
type UpdateBoardListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Position of list within the board.
        position: Option<int>
        /// Indicates if the list is collapsed for the user.
        collapsed: Option<bool>
        /// Global ID of the list.
        listId: string
    }

/// Autogenerated input type of UpdateComplianceFramework
type UpdateComplianceFrameworkInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance framework to update.
        id: string
        /// Parameters to update the compliance framework with.
        ``params``: ComplianceFrameworkInput
    }

/// Autogenerated input type of UpdateComplianceRequirement
type UpdateComplianceRequirementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance requirement to update.
        id: string
        /// Parameters to update the compliance requirement with.
        ``params``: ComplianceRequirementInput
        /// Controls to add or update to the compliance requirement.
        controls: Option<list<ComplianceRequirementsControlInput>>
    }

/// Autogenerated input type of UpdateComplianceRequirementsControl
type UpdateComplianceRequirementsControlInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the compliance requirement control to update.
        id: string
        /// Parameters to update the compliance requirement control with.
        ``params``: ComplianceRequirementsControlInput
    }

/// Autogenerated input type of UpdateContainerExpirationPolicy
type UpdateContainerExpirationPolicyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path where the container expiration policy is located.
        projectPath: string
        /// Indicates whether the container expiration policy is enabled.
        enabled: Option<bool>
        /// Schedule of the container expiration policy.
        cadence: Option<ContainerExpirationPolicyCadenceEnum>
        /// Tags older than the given age will expire.
        olderThan: Option<ContainerExpirationPolicyOlderThanEnum>
        /// Number of tags to retain.
        keepN: Option<ContainerExpirationPolicyKeepEnum>
        /// Tags with names matching the regex pattern will expire.
        nameRegex: Option<string>
        /// Tags with names matching the regex pattern will be preserved.
        nameRegexKeep: Option<string>
    }

/// Autogenerated input type of UpdateContainerProtectionRepositoryRule
type UpdateContainerProtectionRepositoryRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the container repository protection rule to be updated.
        id: string
        /// Container repository path pattern protected by the protection rule. Must start with the project’s full path. For example: `my-project/*-prod-*`. Wildcard character `*` is allowed anywhere after the project’s full path.
        repositoryPathPattern: Option<string>
        /// Minimum GitLab access level required to delete container images from the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForDelete: Option<ContainerProtectionRepositoryRuleAccessLevel>
        /// Minimum GitLab access level required to push container images to the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForPush: Option<ContainerProtectionRepositoryRuleAccessLevel>
    }

/// Autogenerated input type of UpdateContainerProtectionTagRule
type UpdateContainerProtectionTagRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the tag protection rule to update.
        id: string
    }

/// Autogenerated input type of UpdateDependencyProxyImageTtlGroupPolicy
type UpdateDependencyProxyImageTtlGroupPolicyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group path for the group dependency proxy image TTL policy.
        groupPath: string
        /// Indicates whether the policy is enabled or disabled.
        enabled: Option<bool>
        /// Number of days to retain a cached image file.
        ttl: Option<int>
    }

/// Autogenerated input type of UpdateDependencyProxyPackagesSettings
type UpdateDependencyProxyPackagesSettingsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path for the dependency proxy for packages settings.
        projectPath: string
        /// Indicates whether the dependency proxy for packages is enabled for the project.
        enabled: Option<bool>
        /// URL for the external Maven packages registry.
        mavenExternalRegistryUrl: Option<string>
        /// Username for the external Maven packages registry.
        mavenExternalRegistryUsername: Option<string>
        /// Password for the external Maven packages registry. Introduced in 16.5: This feature is an Experiment. It can be changed or removed at any time.
        mavenExternalRegistryPassword: Option<string>
    }

/// Autogenerated input type of UpdateDependencyProxySettings
type UpdateDependencyProxySettingsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group path for the group dependency proxy.
        groupPath: string
        /// Indicates whether the policy is enabled or disabled.
        enabled: Option<bool>
        /// Identity credential used to authenticate with Docker Hub when pulling images. Can be a username (for password or personal access token (PAT)) or organization name (for organization access token (OAT)).
        identity: Option<string>
        /// Secret credential used to authenticate with Docker Hub when pulling images. Can be a password, personal access token (PAT), or organization access token (OAT).
        secret: Option<string>
    }

type UpdateDiffImagePositionInput =
    {
        /// X position of the note.
        x: Option<int>
        /// Y position of the note.
        y: Option<int>
        /// Total width of the image.
        width: Option<int>
        /// Total height of the image.
        height: Option<int>
    }

/// Autogenerated input type of UpdateEpicBoardList
type UpdateEpicBoardListInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Position of list within the board.
        position: Option<int>
        /// Indicates if the list is collapsed for the user.
        collapsed: Option<bool>
        /// Global ID of the epic list.
        listId: string
    }

/// Autogenerated input type of UpdateEpic
type UpdateEpicInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IID of the epic to mutate.
        iid: string
        /// Group the epic to mutate is in.
        groupPath: string
        /// Title of the epic.
        title: Option<string>
        /// Description of the epic.
        description: Option<string>
        /// Indicates if the epic is confidential.
        confidential: Option<bool>
        /// Start date of the epic.
        startDateFixed: Option<string>
        /// End date of the epic.
        dueDateFixed: Option<string>
        /// Indicates start date should be sourced from start_date_fixed field not the issue milestones.
        startDateIsFixed: Option<bool>
        /// Indicates end date should be sourced from due_date_fixed field not the issue milestones.
        dueDateIsFixed: Option<bool>
        /// IDs of labels to be added to the epic.
        addLabelIds: Option<list<string>>
        /// IDs of labels to be removed from the epic.
        removeLabelIds: Option<list<string>>
        /// Array of labels to be added to the epic.
        addLabels: Option<list<string>>
        /// Color of the epic.
        color: Option<string>
        /// State event for the epic.
        stateEvent: Option<EpicStateEvent>
        /// Array of labels to be removed from the epic.
        removeLabels: Option<list<string>>
    }

/// Autogenerated input type of UpdateImageDiffNote
type UpdateImageDiffNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the note to update.
        id: string
        /// Content of the note.
        body: Option<string>
        /// Position of the note on a diff.
        position: Option<UpdateDiffImagePositionInput>
    }

/// Autogenerated input type of UpdateIssue
type UpdateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project the issue to mutate is in.
        projectPath: string
        /// IID of the issue to mutate.
        iid: string
        /// Description of the issue.
        description: Option<string>
        /// Due date of the issue.
        dueDate: Option<string>
        /// Indicates the issue is confidential.
        confidential: Option<bool>
        /// Indicates discussion is locked on the issue.
        locked: Option<bool>
        /// Type of the issue.
        ``type``: Option<IssueType>
        /// Title of the issue.
        title: Option<string>
        /// ID of the milestone to assign to the issue. On update milestone will be removed if set to null.
        milestoneId: Option<string>
        /// IDs of labels to be added to the issue.
        addLabelIds: Option<list<string>>
        /// IDs of labels to be removed from the issue.
        removeLabelIds: Option<list<string>>
        /// IDs of labels to be set. Replaces existing issue labels.
        labelIds: Option<list<string>>
        /// Close or reopen an issue.
        stateEvent: Option<IssueStateEvent>
        /// Estimated time to complete the issue. Use `null` or `0` to remove the current estimate.
        timeEstimate: Option<string>
        /// Desired health status.
        healthStatus: Option<HealthStatus>
        /// Weight of the issue.
        weight: Option<int>
    }

/// Autogenerated input type of UpdateIteration
type UpdateIterationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group of the iteration.
        groupPath: string
        /// Global ID of the iteration.
        id: string
        /// Title of the iteration.
        title: Option<string>
        /// Description of the iteration.
        description: Option<string>
        /// Start date of the iteration.
        startDate: Option<string>
        /// End date of the iteration.
        dueDate: Option<string>
    }

/// Autogenerated input type of UpdateNamespacePackageSettings
type UpdateNamespacePackageSettingsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Namespace path where the namespace package setting is located.
        namespacePath: string
        /// Indicates whether duplicate Maven packages are allowed for the namespace.
        mavenDuplicatesAllowed: Option<bool>
        /// When maven_duplicates_allowed is false, you can publish duplicate packages with names that match this regex. Otherwise, this setting has no effect.
        mavenDuplicateExceptionRegex: Option<string>
        /// Indicates whether duplicate generic packages are allowed for the namespace.
        genericDuplicatesAllowed: Option<bool>
        /// When generic_duplicates_allowed is false, you can publish duplicate packages with names that match this regex. Otherwise, this setting has no effect.
        genericDuplicateExceptionRegex: Option<string>
        /// Indicates whether duplicate NuGet packages are allowed for the namespace.
        nugetDuplicatesAllowed: Option<bool>
        /// When nuget_duplicates_allowed is false, you can publish duplicate packages with names that match this regex. Otherwise, this setting has no effect.
        nugetDuplicateExceptionRegex: Option<string>
        /// Indicates whether duplicate Terraform packages are allowed for the namespace.
        terraformModuleDuplicatesAllowed: Option<bool>
        /// When terraform_module_duplicates_allowed is false, you can publish duplicate packages with names that match this regex. Otherwise, this setting has no effect.
        terraformModuleDuplicateExceptionRegex: Option<string>
        /// Indicates whether Maven package forwarding is allowed for the namespace.
        mavenPackageRequestsForwarding: Option<bool>
        /// Indicates whether npm package forwarding is allowed for the namespace.
        npmPackageRequestsForwarding: Option<bool>
        /// Indicates whether PyPI package forwarding is allowed for the namespace.
        pypiPackageRequestsForwarding: Option<bool>
        /// Indicates whether Maven package forwarding is locked for all descendent namespaces.
        lockMavenPackageRequestsForwarding: Option<bool>
        /// Indicates whether npm package forwarding is locked for all descendent namespaces.
        lockNpmPackageRequestsForwarding: Option<bool>
        /// Indicates whether PyPI package forwarding is locked for all descendent namespaces.
        lockPypiPackageRequestsForwarding: Option<bool>
        /// Indicates whether the NuGet symbol server is enabled for the namespace.
        nugetSymbolServerEnabled: Option<bool>
        /// Indicates whether audit events are created when publishing or deleting a package in the namespace (Premium and Ultimate only).
        auditEventsEnabled: Option<bool>
    }

/// Autogenerated input type of UpdateNote
type UpdateNoteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the note to update.
        id: string
        /// Content of the note.
        body: Option<string>
    }

/// Autogenerated input type of UpdatePackagesCleanupPolicy
type UpdatePackagesCleanupPolicyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Project path where the packages cleanup policy is located.
        projectPath: string
        /// Number of duplicated package files to retain.
        keepNDuplicatedPackageFiles: Option<PackagesCleanupKeepDuplicatedPackageFilesEnum>
    }

/// Autogenerated input type of UpdatePackagesProtectionRule
type UpdatePackagesProtectionRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the package protection rule to be updated.
        id: string
        /// Package name protected by the protection rule. For example, `@my-scope/my-package-*`. Wildcard character `*` allowed.
        packageNamePattern: Option<string>
        /// Package type protected by the protection rule. For example, `NPM`, `PYPI`.
        packageType: Option<PackagesProtectionRulePackageType>
        /// Minimum GitLab access required to push packages to the package registry. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. If the value is `nil`, the default minimum access level is `DEVELOPER`.
        minimumAccessLevelForPush: Option<PackagesProtectionRuleAccessLevel>
    }

/// Autogenerated input type of UpdateProjectComplianceViolation
type UpdateProjectComplianceViolationInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the project compliance violation to update.
        id: string
        /// New status for the project compliance violation.
        status: ComplianceViolationStatus
    }

/// Autogenerated input type of UpdateRequirement
type UpdateRequirementInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Title of the requirement.
        title: Option<string>
        /// Description of the requirement.
        description: Option<string>
        /// Full project path the requirement is associated with.
        projectPath: string
        /// State of the requirement.
        state: Option<RequirementState>
        /// IID of the requirement work item to update.
        workItemIid: Option<string>
        /// Creates a test report for the requirement with the given state.
        lastTestReportState: Option<TestReportState>
    }

/// Autogenerated input type of UpdateSnippet
type UpdateSnippetInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the snippet to update.
        id: string
        /// Title of the snippet.
        title: Option<string>
        /// Description of the snippet.
        description: Option<string>
        /// Visibility level of the snippet.
        visibilityLevel: Option<VisibilityLevelsEnum>
        /// Actions to perform over the snippet repository and blobs.
        blobActions: Option<list<SnippetBlobActionInputType>>
    }

/// Attributes to update value stream stage.
type UpdateValueStreamStageInput =
    {
        /// Name of the stage.
        name: Option<string>
        /// Whether the stage is customized. If false, it assigns a built-in default stage by name.
        custom: Option<bool>
        /// End event identifier.
        endEventIdentifier: Option<ValueStreamStageEvent>
        /// Label ID associated with the end event identifier.
        endEventLabelId: Option<string>
        /// Whether the stage is hidden.
        hidden: Option<bool>
        /// Start event identifier.
        startEventIdentifier: Option<ValueStreamStageEvent>
        /// Label ID associated with the start event identifier.
        startEventLabelId: Option<string>
        /// ID of the stage to be updated.
        id: Option<string>
    }

/// Autogenerated input type of UpdateVirtualRegistriesSetting
type UpdateVirtualRegistriesSettingInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Group path for the group virtual registries.
        fullPath: string
        /// Enable or disable the virtual registries.
        enabled: Option<bool>
    }

/// Autogenerated input type of UploadDelete
type UploadDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project with which the resource is associated.
        projectPath: Option<string>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
        /// Secret part of upload path.
        secret: string
        /// Upload filename.
        filename: string
    }

/// Autogenerated input type of UserAchievementPrioritiesUpdate
type UserAchievementPrioritiesUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of the user achievements being prioritized, ordered from highest to lowest priority.
        userAchievementIds: list<string>
    }

/// Autogenerated input type of UserAchievementsDelete
type UserAchievementsDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the user achievement being deleted.
        userAchievementId: string
    }

/// Autogenerated input type of UserAchievementsUpdate
type UserAchievementsUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the user achievement being updated.
        userAchievementId: string
        /// Indicates whether or not the user achievement is visible on the profile.
        showOnProfile: bool
    }

/// Autogenerated input type of UserAddOnAssignmentBulkCreate
type UserAddOnAssignmentBulkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of AddOnPurchase to be assigned to.
        addOnPurchaseId: string
        /// Global IDs of user to be assigned.
        userIds: list<string>
    }

/// Autogenerated input type of UserAddOnAssignmentBulkRemove
type UserAddOnAssignmentBulkRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of AddOnPurchase to be unassigned from.
        addOnPurchaseId: string
        /// Global IDs of user to be unassigned.
        userIds: list<string>
    }

/// Autogenerated input type of UserAddOnAssignmentCreate
type UserAddOnAssignmentCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of AddOnPurchase to be assigned to.
        addOnPurchaseId: string
        /// Global ID of user to be assigned.
        userId: string
    }

/// Autogenerated input type of UserAddOnAssignmentRemove
type UserAddOnAssignmentRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of AddOnPurchase assignment belongs to.
        addOnPurchaseId: string
        /// Global ID of user whose assignment will be removed.
        userId: string
    }

/// Autogenerated input type of UserCalloutCreate
type UserCalloutCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Feature name you want to dismiss the callout for.
        featureName: string
    }

/// Autogenerated input type of UserGroupCalloutCreate
type UserGroupCalloutCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Feature name you want to dismiss the callout for.
        featureName: string
        /// Group for the callout.
        groupId: string
    }

/// Autogenerated input type of UserPreferencesUpdate
type UserPreferencesUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Status of the Web IDE Extension Marketplace opt-in for the user.
        extensionsMarketplaceOptInStatus: Option<ExtensionsMarketplaceOptInStatus>
        /// Sort order for issue lists.
        issuesSort: Option<IssueSort>
        /// Merge request dashboard list rendering type.
        mergeRequestDashboardListType: Option<MergeRequestsDashboardListType>
        /// Show draft merge requests on the merge request dashboard.
        mergeRequestDashboardShowDrafts: Option<bool>
        /// Sort order for issue lists.
        mergeRequestsSort: Option<MergeRequestSort>
        /// Use work item view instead of legacy issue view.
        useWorkItemsView: Option<bool>
        /// Determines whether the pipeline list shows ID or IID.
        visibilityPipelineIdType: Option<VisibilityPipelineIdType>
        /// Sort order for projects.
        projectsSort: Option<ProjectSort>
    }

/// Autogenerated input type of UserSetNamespaceCommitEmail
type UserSetNamespaceCommitEmailInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the namespace to set the namespace commit email for.
        namespaceId: string
        /// ID of the email to set.
        emailId: Option<string>
    }

/// Autogenerated input type of ValueStreamCreate
type ValueStreamCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Value stream configuration.
        setting: Option<ValueStreamSettingInput>
        /// Value stream name.
        name: string
        /// Value stream stages.
        stages: Option<list<CreateValueStreamStageInput>>
        /// Full path of the namespace(project or group) the value stream is created in.
        namespacePath: string
    }

/// Autogenerated input type of ValueStreamDestroy
type ValueStreamDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the value stream to destroy.
        id: string
    }

/// Attributes for value stream setting.
type ValueStreamSettingInput =
    {
        /// Projects' global IDs used to filter value stream data.
        projectIdsFilter: Option<list<string>>
    }

/// Autogenerated input type of ValueStreamUpdate
type ValueStreamUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Value stream configuration.
        setting: Option<ValueStreamSettingInput>
        /// Global ID of the value stream to update.
        id: string
        /// Value stream name.
        name: Option<string>
        /// Value stream stages.
        stages: Option<list<UpdateValueStreamStageInput>>
    }

type VerificationStatusFilterInput =
    {
        /// Verification status of the work item.
        verificationStatus: RequirementStatusFilter
    }

type VerificationStatusInput =
    {
        /// Verification status of the work item.
        verificationStatus: TestReportState
    }

/// Autogenerated input type of VerifiedNamespaceCreate
type VerifiedNamespaceCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Root namespace path.
        namespacePath: string
        /// Verification level for a root namespace.
        verificationLevel: CiCatalogResourceVerificationLevel
    }

/// Autogenerated input type of VulnerabilitiesArchive
type VulnerabilitiesArchiveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to attach the vulnerability to.
        projectId: string
        /// Last update date of vulnerabilities being archived.
        date: System.DateTime
    }

/// Autogenerated input type of VulnerabilitiesCreateIssue
type VulnerabilitiesCreateIssueInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to attach the issue to.
        project: string
        /// IDs of vulnerabilities to link to the given issue.  Up to 100 can be provided.
        vulnerabilityIds: list<string>
    }

/// Autogenerated input type of VulnerabilitiesDismiss
type VulnerabilitiesDismissInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IDs of the vulnerabilities to be dismissed (maximum 100 entries).
        vulnerabilityIds: list<string>
        /// Comment why vulnerability was dismissed (maximum 50,000 characters).
        comment: Option<string>
        /// Reason why vulnerability should be dismissed.
        dismissalReason: Option<VulnerabilityDismissalReason>
    }

/// Autogenerated input type of VulnerabilitiesRemoveAllFromProject
type VulnerabilitiesRemoveAllFromProjectInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IDs of project for which all Vulnerabilities should be removed. The deletion will happen in the background so the changes will not be visible immediately.
        projectIds: list<string>
        /// When set as `true`, deletes only the vulnerabilities no longer detected. When set as `false`, deletes only the vulnerabilities still detected.
        resolvedOnDefaultBranch: Option<bool>
    }

/// Autogenerated input type of VulnerabilityConfirm
type VulnerabilityConfirmInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Comment why vulnerability was confirmed (maximum 50,000 characters).
        comment: Option<string>
        /// ID of the vulnerability to be confirmed.
        id: string
    }

/// Input type for filtering projects by vulnerability count and severity
type VulnerabilityCountFilterInput =
    {
        /// Severity level of vulnerabilities to filter by.
        severity: VulnerabilitySeverity
        /// Number of vulnerabilities to filter by.
        count: int
        /// Comparison operator for the vulnerability count.
        operator: ComparisonOperator
    }

/// Autogenerated input type of VulnerabilityCreate
type VulnerabilityCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the project to attach the vulnerability to.
        project: string
        /// Name of the vulnerability.
        name: string
        /// Long text section that describes the vulnerability in more detail.
        description: string
        /// Information about the scanner used to discover the vulnerability.
        scanner: VulnerabilityScannerInput
        /// Array of CVE or CWE identifiers for the vulnerability.
        identifiers: list<VulnerabilityIdentifierInput>
        /// State of the vulnerability (defaults to `detected`).
        state: Option<VulnerabilityState>
        /// Severity of the vulnerability (defaults to `unknown`).
        severity: Option<VulnerabilitySeverity>
        /// Instructions for how to fix the vulnerability.
        solution: Option<string>
        /// Timestamp of when the vulnerability was first detected (defaults to creation time).
        detectedAt: Option<string>
        /// Timestamp of when the vulnerability state changed to confirmed (defaults to creation time if status is `confirmed`).
        confirmedAt: Option<string>
        /// Timestamp of when the vulnerability state changed to resolved (defaults to creation time if status is `resolved`).
        resolvedAt: Option<string>
        /// Timestamp of when the vulnerability state changed to dismissed (defaults to creation time if status is `dismissed`).
        dismissedAt: Option<string>
    }

/// Autogenerated input type of VulnerabilityDismissFalsePositiveFlag
type VulnerabilityDismissFalsePositiveFlagInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the vulnerability to dismiss false positive flag for.
        id: string
    }

/// Autogenerated input type of VulnerabilityDismiss
type VulnerabilityDismissInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Comment why vulnerability was dismissed (maximum 50,000 characters).
        comment: Option<string>
        /// ID of the vulnerability to be dismissed.
        id: string
        /// Reason why vulnerability should be dismissed.
        dismissalReason: Option<VulnerabilityDismissalReason>
    }

/// Autogenerated input type of VulnerabilityExternalIssueLinkCreate
type VulnerabilityExternalIssueLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the vulnerability.
        id: string
        /// Type of the external issue link.
        linkType: VulnerabilityExternalIssueLinkType
        /// External tracker type of the external issue link.
        externalTracker: VulnerabilityExternalIssueLinkExternalTracker
    }

/// Autogenerated input type of VulnerabilityExternalIssueLinkDestroy
type VulnerabilityExternalIssueLinkDestroyInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the vulnerability external issue link.
        id: string
    }

type VulnerabilityIdentifierInput =
    {
        /// Name of the vulnerability identifier.
        name: string
        /// URL of the vulnerability identifier.
        url: string
        /// External type of the vulnerability identifier.
        externalType: Option<string>
        /// External ID of the vulnerability identifier.
        externalId: Option<string>
    }

/// Autogenerated input type of VulnerabilityIssueLinkCreate
type VulnerabilityIssueLinkCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the issue to link to.
        issueId: string
        /// IDs of vulnerabilities to link to the given issue.  Up to 100 can be provided.
        vulnerabilityIds: list<string>
    }

/// Autogenerated input type of VulnerabilityLinkMergeRequest
type VulnerabilityLinkMergeRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the vulnerability.
        vulnerabilityId: string
        /// ID of the merge request.
        mergeRequestId: string
        /// Confidence rating representing the estimated accuracy of the fix in the AI generated merge request. Decimal value between 0 and 1, with 1 being the highest.
        readinessScore: Option<float>
    }

/// Autogenerated input type of VulnerabilityResolve
type VulnerabilityResolveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Comment why vulnerability was resolved (maximum 50,000 characters).
        comment: Option<string>
        /// ID of the vulnerability to be resolved.
        id: string
    }

/// Autogenerated input type of VulnerabilityRevertToDetected
type VulnerabilityRevertToDetectedInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Comment why vulnerability was reverted to detected (maximum 50,000 characters).
        comment: Option<string>
        /// ID of the vulnerability to be reverted to detected.
        id: string
    }

type VulnerabilityScannerInput =
    {
        /// Unique ID that identifies the scanner.
        id: string
        /// Human readable value that identifies the analyzer, not required to be unique.
        name: string
        /// Link to more information about the analyzer.
        url: string
        /// Information about vendor/maintainer of the scanner.
        vendor: Option<VulnerabilityScannerVendorInput>
        /// Version of the scanner.
        version: string
    }

type VulnerabilityScannerVendorInput =
    {
        /// Name of the vendor/maintainer.
        name: string
    }

/// Autogenerated input type of VulnerabilityUnlinkMergeRequest
type VulnerabilityUnlinkMergeRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// ID of the vulnerability.
        vulnerabilityId: string
        /// ID of the merge request.
        mergeRequestId: string
    }

/// Autogenerated input type of WikiPageSubscribe
type WikiPageSubscribeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the wiki page meta record.
        id: string
        /// Desired state of the subscription.
        subscribed: bool
    }

/// Autogenerated input type of WorkItemAddClosingMergeRequest
type WorkItemAddClosingMergeRequestInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the context namespace (project or group). Only project full paths are used to find a merge request using a short reference syntax like `!1`. Ignored for full references and URLs. Defaults to the namespace of the work item if not provided.
        contextNamespacePath: Option<string>
        /// Global ID of the work item.
        id: string
        /// Merge request reference (short, full or URL). Example: `!1`, `project_full_path!1` or `https://gitlab.com/gitlab-org/gitlab/-/merge_requests/1`.
        mergeRequestReference: string
    }

/// Autogenerated input type of WorkItemAddLinkedItems
type WorkItemAddLinkedItemsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
        /// Type of link. Defaults to `RELATED`.
        linkType: Option<WorkItemRelatedLinkType>
        /// Global IDs of the items to link. Maximum number of IDs you can provide: 10.
        workItemsIds: list<string>
    }

/// Autogenerated input type of WorkItemBulkMove
type WorkItemBulkMoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID array of the work items that will be moved. IDs that the user can't move will be ignored. A max of 100 can be provided.
        ids: list<string>
        /// Full path of the source namespace. For example, `gitlab-org/gitlab-foss`.
        sourceFullPath: string
        /// Full path of the target namespace. For example, `gitlab-org/gitlab-foss`. User paths are not supported.
        targetFullPath: string
    }

/// Autogenerated input type of WorkItemBulkUpdate
type WorkItemBulkUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID array of the work items that will be updated. IDs that the user can't update will be ignored. A max of 100 can be provided.
        ids: list<string>
        /// Full path of the project or group (Premium and Ultimate only) containing the work items that will be updated. User paths are not supported.
        fullPath: string
        /// Input for labels widget.
        labelsWidget: Option<WorkItemWidgetLabelsUpdateInput>
    }

/// Autogenerated input type of WorkItemConvert
type WorkItemConvertInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
        /// Global ID of the new work item type.
        workItemTypeId: string
    }

type WorkItemConvertTaskInput =
    {
        /// Last line in the Markdown source that defines the list item task.
        lineNumberEnd: int
        /// First line in the Markdown source that defines the list item task.
        lineNumberStart: int
        /// Current lock version of the work item containing the task in the description.
        lockVersion: int
        /// Full string of the task to be replaced. New title for the created work item.
        title: string
        /// Global ID of the work item type used to create the new work item.
        workItemTypeId: string
    }

/// Autogenerated input type of WorkItemCreateFromTask
type WorkItemCreateFromTaskInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
        /// Arguments necessary to convert a task into a work item.
        workItemData: WorkItemConvertTaskInput
    }

/// Autogenerated input type of WorkItemCreate
type WorkItemCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Input for assignees widget.
        assigneesWidget: Option<WorkItemWidgetAssigneesInput>
        /// Sets the work item confidentiality.
        confidential: Option<bool>
        /// Input for description widget.
        descriptionWidget: Option<WorkItemWidgetDescriptionInput>
        /// Input for milestone widget.
        milestoneWidget: Option<WorkItemWidgetMilestoneInput>
        /// Source which triggered the creation of the work item. Used only for tracking purposes.
        createSource: Option<string>
        /// Timestamp when the work item was created. Available only for admins and project owners.
        createdAt: Option<string>
        /// Input for CRM contacts widget.
        crmContactsWidget: Option<WorkItemWidgetCrmContactsCreateInput>
        /// Information required to resolve discussions in a noteable, when the work item is created.
        discussionsToResolve: Option<WorkItemResolveDiscussionsInput>
        /// Input for hierarchy widget.
        hierarchyWidget: Option<WorkItemWidgetHierarchyCreateInput>
        /// Input for labels widget.
        labelsWidget: Option<WorkItemWidgetLabelsCreateInput>
        /// Input for linked items widget.
        linkedItemsWidget: Option<WorkItemWidgetLinkedItemsCreateInput>
        /// Full path of the namespace(project or group) the work item is created in.
        namespacePath: Option<string>
        /// Input for start and due date widget.
        startAndDueDateWidget: Option<WorkItemWidgetStartAndDueDateUpdateInput>
        /// Title of the work item.
        title: string
        /// Global ID of a work item type.
        workItemTypeId: string
        /// Input for weight widget.
        weightWidget: Option<WorkItemWidgetWeightInput>
        /// Input for health status widget.
        healthStatusWidget: Option<WorkItemWidgetHealthStatusInput>
        /// Iteration widget of the work item.
        iterationWidget: Option<WorkItemWidgetIterationInput>
        /// Input for color widget.
        colorWidget: Option<WorkItemWidgetColorInput>
    }

/// Autogenerated input type of WorkItemDelete
type WorkItemDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
    }

type WorkItemDescriptionTemplateContentInput =
    {
        /// Full path of the group or project using the template.
        fromNamespace: Option<string>
        /// Name of the description template.
        name: string
        /// ID of the project the template belongs to.
        projectId: int
    }

/// Autogenerated input type of WorkItemExport
type WorkItemExportInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Search query for title or description.
        search: Option<string>
        /// Specify the fields to perform the search in.Defaults to `[TITLE, DESCRIPTION]`. Requires the `search` argument.'
        ``in``: Option<list<IssuableSearchableField>>
        /// Filter by global IDs of work items (maximum is 100 IDs).
        ids: Option<list<string>>
        /// Filter work items by author username.
        authorUsername: Option<string>
        /// Filter for confidential work items. If `false`, excludes confidential work items. If `true`, returns only confidential work items.
        confidential: Option<bool>
        /// Usernames of users assigned to the work item (maximum is 100 usernames).
        assigneeUsernames: Option<list<string>>
        /// Filter by assignee wildcard. Incompatible with `assigneeUsernames`.
        assigneeWildcardId: Option<AssigneeWildcardId>
        /// Labels applied to the work item (maximum is 100 labels).
        labelName: Option<list<string>>
        /// Milestone applied to the work item (maximum is 100 milestones).
        milestoneTitle: Option<list<string>>
        /// Filter by milestone ID wildcard. Incompatible with `milestoneTitle`.
        milestoneWildcardId: Option<MilestoneWildcardId>
        /// Filter by reaction emoji applied by the current user. Wildcard values `NONE` and `ANY` are supported.
        myReactionEmoji: Option<string>
        /// List of IIDs of work items. For example, `["1", "2"]` (maximum is 100 IIDs).
        iids: Option<list<string>>
        /// Current state of the work item.
        state: Option<IssuableState>
        /// Filter work items by the given work item types.
        types: Option<list<IssueType>>
        /// Work items created before the timestamp.
        createdBefore: Option<string>
        /// Work items created after the timestamp.
        createdAfter: Option<string>
        /// Work items updated before the timestamp.
        updatedBefore: Option<string>
        /// Work items updated after the timestamp.
        updatedAfter: Option<string>
        /// Work items due before the timestamp.
        dueBefore: Option<string>
        /// Work items due after the timestamp.
        dueAfter: Option<string>
        /// Work items closed before the date.
        closedBefore: Option<string>
        /// Work items closed after the date.
        closedAfter: Option<string>
        /// Work items the current user is subscribed to.
        subscribed: Option<SubscriptionStatus>
        /// Negated work item arguments.
        ``not``: Option<NegatedWorkItemFilterInput>
        /// List of arguments with inclusive `OR`.
        ``or``: Option<UnionedWorkItemFilterInput>
        /// Filter work items by global IDs of their parent items (maximum is 100 IDs).
        parentIds: Option<list<string>>
        /// Release tag associated with the work item's milestone (maximum is 100 tags). Ignored when parent is a group.
        releaseTag: Option<list<string>>
        /// Filter by release tag wildcard.
        releaseTagWildcardId: Option<ReleaseTagWildcardId>
        /// Filter by ID of CRM contact.
        crmContactId: Option<string>
        /// Filter by ID of CRM contact organization.
        crmOrganizationId: Option<string>
        /// Full project path.
        projectPath: string
        /// List of selected fields to be exported. Omit to export all available fields.
        selectedFields: Option<list<AvailableExportFields>>
    }

/// Autogenerated input type of WorkItemHierarchyAddChildrenItems
type WorkItemHierarchyAddChildrenItemsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global IDs of children work items.
        childrenIds: list<string>
        /// Global ID of the work item.
        id: string
    }

/// Autogenerated input type of WorkItemRemoveLinkedItems
type WorkItemRemoveLinkedItemsInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
        /// Global IDs of the items to unlink. Maximum number of IDs you can provide: 10.
        workItemsIds: list<string>
    }

type WorkItemResolveDiscussionsInput =
    {
        /// ID of a discussion to resolve.
        discussionId: Option<string>
        /// Global ID of the noteable where discussions will be resolved when the work item is created. Only `MergeRequestID` is supported at the moment.
        noteableId: string
    }

type WorkItemStatusInput =
    {
        /// ID of the status. If not provided, a new status will be created.
        id: Option<string>
        /// Name of the status.
        name: Option<string>
        /// Color of the status.
        color: Option<string>
        /// Description of the status.
        description: Option<string>
        /// Category of the status.
        category: Option<WorkItemStatusCategoryEnum>
    }

/// Autogenerated input type of WorkItemSubscribe
type WorkItemSubscribeInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item.
        id: string
        /// Desired state of the subscription.
        subscribed: bool
    }

/// Autogenerated input type of WorkItemUpdate
type WorkItemUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Input for assignees widget.
        assigneesWidget: Option<WorkItemWidgetAssigneesInput>
        /// Sets the work item confidentiality.
        confidential: Option<bool>
        /// Input for description widget.
        descriptionWidget: Option<WorkItemWidgetDescriptionInput>
        /// Input for milestone widget.
        milestoneWidget: Option<WorkItemWidgetMilestoneInput>
        /// Input for emoji reactions widget.
        awardEmojiWidget: Option<WorkItemWidgetAwardEmojiUpdateInput>
        /// Input for CRM contacts widget.
        crmContactsWidget: Option<WorkItemWidgetCrmContactsUpdateInput>
        /// Input for to-dos widget.
        currentUserTodosWidget: Option<WorkItemWidgetCurrentUserTodosInput>
        /// Input for hierarchy widget.
        hierarchyWidget: Option<WorkItemWidgetHierarchyUpdateInput>
        /// Global ID of the work item.
        id: string
        /// Input for labels widget.
        labelsWidget: Option<WorkItemWidgetLabelsUpdateInput>
        /// Input for notes widget.
        notesWidget: Option<WorkItemWidgetNotesInput>
        /// Input for notifications widget.
        notificationsWidget: Option<WorkItemWidgetNotificationsUpdateInput>
        /// Input for start and due date widget.
        startAndDueDateWidget: Option<WorkItemWidgetStartAndDueDateUpdateInput>
        /// Close or reopen a work item.
        stateEvent: Option<WorkItemStateEvent>
        /// Input for time tracking widget.
        timeTrackingWidget: Option<WorkItemWidgetTimeTrackingInput>
        /// Title of the work item.
        title: Option<string>
        /// Input for iteration widget.
        iterationWidget: Option<WorkItemWidgetIterationInput>
        /// Input for weight widget.
        weightWidget: Option<WorkItemWidgetWeightInput>
        /// Input for progress widget.
        progressWidget: Option<WorkItemWidgetProgressInput>
        /// Input for verification status widget.
        verificationStatusWidget: Option<VerificationStatusInput>
        /// Input for health status widget.
        healthStatusWidget: Option<WorkItemWidgetHealthStatusInput>
        /// Input for color widget.
        colorWidget: Option<WorkItemWidgetColorInput>
    }

/// Autogenerated input type of WorkItemUserPreferenceUpdate
type WorkItemUserPreferenceUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the namespace on which the preference is set.
        namespacePath: string
        /// Global ID of a work item type.
        workItemTypeId: Option<string>
        /// Sort order for work item lists.
        sort: Option<WorkItemSort>
        /// Display settings for the work item lists.
        displaySettings: Option<string>
    }

type WorkItemWidgetAssigneesInput =
    {
        /// Global IDs of assignees.
        assigneeIds: list<string>
    }

type WorkItemWidgetAwardEmojiUpdateInput =
    {
        /// Action for the update.
        action: WorkItemAwardEmojiUpdateAction
        /// Emoji name.
        name: string
    }

type WorkItemWidgetColorInput =
    {
        /// Color of the work item.
        color: string
    }

type WorkItemWidgetCrmContactsCreateInput =
    {
        /// CRM contact IDs to set.
        contactIds: list<string>
    }

type WorkItemWidgetCrmContactsUpdateInput =
    {
        /// CRM contact IDs to set. Replaces existing contacts by default.
        contactIds: list<string>
        /// Set the operation mode.
        operationMode: Option<MutationOperationMode>
    }

type WorkItemWidgetCurrentUserTodosInput =
    {
        /// Action for the update.
        action: WorkItemTodoUpdateAction
        /// Global ID of the to-do. If not present, all to-dos of the work item will be updated.
        todoId: Option<string>
    }

type WorkItemWidgetCustomFieldFilterInputType =
    {
        /// Global ID of the custom field.
        customFieldId: Option<string>
        /// Name of the custom field.
        customFieldName: Option<string>
        /// Global IDs of the selected options for custom fields with select type (maximum is 100 IDs).
        selectedOptionIds: Option<list<string>>
        /// Values of the selected options for custom fields with select type (maximum is 100 values).
        selectedOptionValues: Option<list<string>>
    }

type WorkItemWidgetCustomFieldValueInputType =
    {
        /// Global ID of the custom field.
        customFieldId: string
        /// Global IDs of the selected options for custom fields with select type.
        selectedOptionIds: Option<list<string>>
        /// Value for custom fields with number type.
        numberValue: Option<float>
        /// Value for custom fields with text type.
        textValue: Option<string>
        /// Value for custom fields with date type.
        dateValue: Option<string>
    }

type WorkItemWidgetDescriptionInput =
    {
        /// Description of the work item.
        description: string
    }

type WorkItemWidgetHealthStatusInput =
    {
        /// Health status to be assigned to the work item.
        healthStatus: Option<HealthStatus>
    }

type WorkItemWidgetHierarchyCreateInput =
    {
        /// Global ID of the parent work item.
        parentId: Option<string>
    }

type WorkItemWidgetHierarchyUpdateInput =
    {
        /// ID of the work item to be switched with.
        adjacentWorkItemId: Option<string>
        /// Global IDs of children work items.
        childrenIds: Option<list<string>>
        /// Global ID of the parent work item. Use `null` to remove the association.
        parentId: Option<string>
        /// Type of switch. Valid values are `BEFORE` or `AFTER`.
        relativePosition: Option<RelativePositionType>
    }

type WorkItemWidgetIterationInput =
    {
        /// Iteration to assign to the work item.
        iterationId: Option<string>
    }

type WorkItemWidgetLabelsCreateInput =
    {
        /// IDs of labels to be added to the work item.
        labelIds: list<string>
    }

type WorkItemWidgetLabelsUpdateInput =
    {
        /// Global IDs of labels to be added to the work item.
        addLabelIds: Option<list<string>>
        /// Global IDs of labels to be removed from the work item.
        removeLabelIds: Option<list<string>>
    }

type WorkItemWidgetLinkedItemsCreateInput =
    {
        /// Type of link. Defaults to `RELATED`.
        linkType: Option<WorkItemRelatedLinkType>
        /// Global IDs of the items to link. Maximum number of IDs you can provide: 10.
        workItemsIds: list<string>
    }

type WorkItemWidgetMilestoneInput =
    {
        /// Milestone to assign to the work item.
        milestoneId: Option<string>
    }

type WorkItemWidgetNotesInput =
    {
        /// Discussion lock attribute for notes widget of the work item.
        discussionLocked: bool
    }

type WorkItemWidgetNotificationsUpdateInput =
    {
        /// Desired state of the subscription.
        subscribed: bool
    }

type WorkItemWidgetProgressInput =
    {
        /// Current progress value of the work item.
        currentValue: int
        /// Start value of the work item.
        startValue: Option<int>
        /// End value of the work item.
        endValue: Option<int>
    }

type WorkItemWidgetStartAndDueDateUpdateInput =
    {
        /// Due date for the work item.
        dueDate: Option<string>
        /// Start date for the work item.
        startDate: Option<string>
        /// Indicates if the work item is using fixed dates.
        isFixed: Option<bool>
    }

type WorkItemWidgetStatusFilterInput =
    {
        /// Global ID of the status.
        id: Option<string>
        /// Name of the status.
        name: Option<string>
    }

type WorkItemWidgetStatusInput =
    {
        /// Global ID of the status.
        status: Option<string>
    }

type WorkItemWidgetTimeTrackingInput =
    {
        /// Time estimate for the work item in human readable format. For example: 1h 30m.
        timeEstimate: Option<string>
        /// Timelog data for time spent on the work item.
        timelog: Option<WorkItemWidgetTimeTrackingTimelogInput>
    }

type WorkItemWidgetTimeTrackingTimelogInput =
    {
        /// Amount of time spent in human readable format. For example: 1h 30m.
        timeSpent: string
        /// Timestamp of when the time tracked was spent at, if not provided would be set to current timestamp.
        spentAt: Option<string>
        /// Summary of how the time was spent.
        summary: Option<string>
    }

type WorkItemWidgetWeightInput =
    {
        /// Weight of the work item.
        weight: Option<int>
    }

/// Autogenerated input type of WorkItemsCsvExport
type WorkItemsCsvExportInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Search query for title or description.
        search: Option<string>
        /// Specify the fields to perform the search in.Defaults to `[TITLE, DESCRIPTION]`. Requires the `search` argument.'
        ``in``: Option<list<IssuableSearchableField>>
        /// Filter by global IDs of work items (maximum is 100 IDs).
        ids: Option<list<string>>
        /// Filter work items by author username.
        authorUsername: Option<string>
        /// Filter for confidential work items. If `false`, excludes confidential work items. If `true`, returns only confidential work items.
        confidential: Option<bool>
        /// Usernames of users assigned to the work item (maximum is 100 usernames).
        assigneeUsernames: Option<list<string>>
        /// Filter by assignee wildcard. Incompatible with `assigneeUsernames`.
        assigneeWildcardId: Option<AssigneeWildcardId>
        /// Labels applied to the work item (maximum is 100 labels).
        labelName: Option<list<string>>
        /// Milestone applied to the work item (maximum is 100 milestones).
        milestoneTitle: Option<list<string>>
        /// Filter by milestone ID wildcard. Incompatible with `milestoneTitle`.
        milestoneWildcardId: Option<MilestoneWildcardId>
        /// Filter by reaction emoji applied by the current user. Wildcard values `NONE` and `ANY` are supported.
        myReactionEmoji: Option<string>
        /// List of IIDs of work items. For example, `["1", "2"]` (maximum is 100 IIDs).
        iids: Option<list<string>>
        /// Current state of the work item.
        state: Option<IssuableState>
        /// Filter work items by the given work item types.
        types: Option<list<IssueType>>
        /// Work items created before the timestamp.
        createdBefore: Option<string>
        /// Work items created after the timestamp.
        createdAfter: Option<string>
        /// Work items updated before the timestamp.
        updatedBefore: Option<string>
        /// Work items updated after the timestamp.
        updatedAfter: Option<string>
        /// Work items due before the timestamp.
        dueBefore: Option<string>
        /// Work items due after the timestamp.
        dueAfter: Option<string>
        /// Work items closed before the date.
        closedBefore: Option<string>
        /// Work items closed after the date.
        closedAfter: Option<string>
        /// Work items the current user is subscribed to.
        subscribed: Option<SubscriptionStatus>
        /// Negated work item arguments.
        ``not``: Option<NegatedWorkItemFilterInput>
        /// List of arguments with inclusive `OR`.
        ``or``: Option<UnionedWorkItemFilterInput>
        /// Filter work items by global IDs of their parent items (maximum is 100 IDs).
        parentIds: Option<list<string>>
        /// Release tag associated with the work item's milestone (maximum is 100 tags). Ignored when parent is a group.
        releaseTag: Option<list<string>>
        /// Filter by release tag wildcard.
        releaseTagWildcardId: Option<ReleaseTagWildcardId>
        /// Filter by ID of CRM contact.
        crmContactId: Option<string>
        /// Filter by ID of CRM contact organization.
        crmOrganizationId: Option<string>
        /// Full project path.
        projectPath: string
        /// List of selected fields to be exported. Omit to export all available fields.
        selectedFields: Option<list<AvailableExportFields>>
    }

/// Autogenerated input type of WorkItemsCsvImport
type WorkItemsCsvImportInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full project path.
        projectPath: string
        /// CSV file to import work items from.
        file: string
    }

/// Autogenerated input type of WorkspaceCreate
type WorkspaceCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// GlobalID of the cluster agent the created workspace will be associated with.
        clusterAgentId: string
        /// Desired state of the created workspace.
        desiredState: string
        /// ID of the project that will provide the Devfile for the created workspace.
        projectId: string
        /// Project repo git ref.
        projectRef: Option<string>
        /// Project path containing the devfile used to configure the workspace. If not provided, the GitLab default devfile is used.
        devfilePath: Option<string>
    }

/// Autogenerated input type of WorkspaceUpdate
type WorkspaceUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the workspace.
        id: string
        /// Desired state of the created workspace.
        desiredState: string
    }

/// Attributes for defining a variable to be injected in a workspace.
type WorkspaceVariableInput =
    {
        /// Name of the workspace variable.
        key: string
        /// Value of the variable.
        value: string
        /// Type of the variable to be injected in a workspace.
        variableType: Option<WorkspaceVariableType>
    }

/// Autogenerated input type of approvalProjectRuleDelete
type approvalProjectRuleDeleteInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the approval project rule to delete.
        id: string
    }

/// Autogenerated input type of approvalProjectRuleUpdate
type approvalProjectRuleUpdateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the approval rule to destroy.
        id: string
        /// Name of the approval rule.
        name: string
        /// How many approvals are required to satify rule.
        approvalsRequired: int
        /// List of IDs of Users that can approval rule.
        userIds: Option<list<string>>
        /// List of IDs of Groups that can approval rule.
        groupIds: Option<list<string>>
    }

/// Autogenerated input type of branchRuleApprovalProjectRuleCreate
type branchRuleApprovalProjectRuleCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the branch rule to destroy.
        branchRuleId: string
        /// Name of the approval rule.
        name: string
        /// How many approvals are required to satify rule.
        approvalsRequired: int
        /// List of IDs of Users that can approval rule.
        userIds: Option<list<string>>
        /// List of IDs of Groups that can approval rule.
        groupIds: Option<list<string>>
    }

/// Autogenerated input type of createContainerProtectionTagRule
type createContainerProtectionTagRuleInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project containing the container image tags.
        projectPath: string
        /// The pattern that matches container image tags to protect. For example, `v1.*`. Wildcard character `*` allowed. Introduced in GitLab 17.8: **Status**: Experiment.
        tagNamePattern: string
        /// Minimum GitLab access level required to delete container image tags from the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. Introduced in GitLab 17.8: **Status**: Experiment. If the value is `nil`, no access level can delete tags.
        minimumAccessLevelForDelete: Option<ContainerProtectionTagRuleAccessLevel>
        /// Minimum GitLab access level required to push container image tags to the container repository. Valid values include `MAINTAINER`, `OWNER`, or `ADMIN`. Introduced in GitLab 17.8: **Status**: Experiment. If the value is `nil`, no access level can push tags.
        minimumAccessLevelForPush: Option<ContainerProtectionTagRuleAccessLevel>
    }

/// Autogenerated input type of iterationCreate
type iterationCreateInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project with which the resource is associated.
        projectPath: Option<string>
        /// Full path of the group with which the resource is associated.
        groupPath: Option<string>
        /// Global ID of the iteration cadence to be assigned to the new iteration.
        iterationsCadenceId: Option<string>
        /// Title of the iteration.
        title: Option<string>
        /// Description of the iteration.
        description: Option<string>
        /// Start date of the iteration.
        startDate: Option<string>
        /// End date of the iteration.
        dueDate: Option<string>
    }

/// Autogenerated input type of projectBlobsRemove
type projectBlobsRemoveInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to replace.
        projectPath: string
        /// List of blob oids.
        blobOids: list<string>
    }

/// Autogenerated input type of projectTextReplace
type projectTextReplaceInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Full path of the project to replace.
        projectPath: string
        /// List of text patterns to replace project-wide.
        replacements: list<string>
    }

/// Autogenerated input type of vulnerabilitiesSeverityOverride
type vulnerabilitiesSeverityOverrideInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// IDs of the vulnerabilities for which severity needs to be changed (maximum 100 entries).
        vulnerabilityIds: list<string>
        /// New severity value for the severities.
        severity: VulnerabilitySeverity
        /// Comment why vulnerability severity was changed (maximum 50,000 characters).
        comment: string
    }

/// Autogenerated input type of workItemsHierarchyReorder
type workItemsHierarchyReorderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item to be reordered.
        id: string
        /// ID of the work item to move next to. For example, the item above or below.
        adjacentWorkItemId: Option<string>
        /// Global ID of the new parent work item.
        parentId: Option<string>
        /// Position relative to the adjacent work item. Valid values are `BEFORE` or `AFTER`.
        relativePosition: Option<RelativePositionType>
    }

/// Autogenerated input type of workItemsReorder
type workItemsReorderInput =
    {
        /// A unique identifier for the client performing the mutation.
        clientMutationId: Option<string>
        /// Global ID of the work item to be reordered.
        id: string
        /// Global ID of a work item that should be placed before the work item.
        moveBeforeId: Option<string>
        /// Global ID of a work item that should be placed after the work item.
        moveAfterId: Option<string>
    }

/// The error returned by the GraphQL backend
type ErrorType = { message: string }
