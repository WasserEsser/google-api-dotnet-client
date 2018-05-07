// Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software distributed under the License is distributed on
// an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. See the License for the
// specific language governing permissions and limitations under the License.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by google-apis-code-generator 1.5.1
//     C# generator version: 1.33.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

/**
 * \brief
 *   Stackdriver Trace API Version v1
 *
 * \section ApiInfo API Version Information
 *    <table>
 *      <tr><th>API
 *          <td><a href='https://cloud.google.com/trace'>Stackdriver Trace API</a>
 *      <tr><th>API Version<td>v1
 *      <tr><th>API Rev<td>20180430 (1215)
 *      <tr><th>API Docs
 *          <td><a href='https://cloud.google.com/trace'>
 *              https://cloud.google.com/trace</a>
 *      <tr><th>Discovery Name<td>cloudtrace
 *    </table>
 *
 * \section ForMoreInfo For More Information
 *
 * The complete API documentation for using Stackdriver Trace API can be found at
 * <a href='https://cloud.google.com/trace'>https://cloud.google.com/trace</a>.
 *
 * For more information about the Google APIs Client Library for .NET, see
 * <a href='https://developers.google.com/api-client-library/dotnet/get_started'>
 * https://developers.google.com/api-client-library/dotnet/get_started</a>
 */

namespace Google.Apis.CloudTrace.v1
{
    /// <summary>The CloudTrace Service.</summary>
    public class CloudTraceService : Google.Apis.Services.BaseClientService
    {
        /// <summary>The API version.</summary>
        public const string Version = "v1";

        /// <summary>The discovery version used to generate this service.</summary>
        public static Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed =
            Google.Apis.Discovery.DiscoveryVersion.Version_1_0;

        /// <summary>Constructs a new service.</summary>
        public CloudTraceService() :
            this(new Google.Apis.Services.BaseClientService.Initializer()) {}

        /// <summary>Constructs a new service.</summary>
        /// <param name="initializer">The service initializer.</param>
        public CloudTraceService(Google.Apis.Services.BaseClientService.Initializer initializer)
            : base(initializer)
        {
            projects = new ProjectsResource(this);
        }

        /// <summary>Gets the service supported features.</summary>
        public override System.Collections.Generic.IList<string> Features
        {
            get { return new string[0]; }
        }

        /// <summary>Gets the service name.</summary>
        public override string Name
        {
            get { return "cloudtrace"; }
        }

        /// <summary>Gets the service base URI.</summary>
        public override string BaseUri
        {
            get { return "https://cloudtrace.googleapis.com/"; }
        }

        /// <summary>Gets the service base path.</summary>
        public override string BasePath
        {
            get { return ""; }
        }

        #if !NET40
        /// <summary>Gets the batch base URI; <c>null</c> if unspecified.</summary>
        public override string BatchUri
        {
            get { return "https://cloudtrace.googleapis.com/batch"; }
        }

        /// <summary>Gets the batch base path; <c>null</c> if unspecified.</summary>
        public override string BatchPath
        {
            get { return "batch"; }
        }
        #endif

        /// <summary>Available OAuth 2.0 scopes for use with the Stackdriver Trace API.</summary>
        public class Scope
        {
            /// <summary>View and manage your data across Google Cloud Platform services</summary>
            public static string CloudPlatform = "https://www.googleapis.com/auth/cloud-platform";

            /// <summary>Write Trace data for a project or application</summary>
            public static string TraceAppend = "https://www.googleapis.com/auth/trace.append";

            /// <summary>Read Trace data for a project or application</summary>
            public static string TraceReadonly = "https://www.googleapis.com/auth/trace.readonly";

        }



        private readonly ProjectsResource projects;

        /// <summary>Gets the Projects resource.</summary>
        public virtual ProjectsResource Projects
        {
            get { return projects; }
        }
    }

    ///<summary>A base abstract class for CloudTrace requests.</summary>
    public abstract class CloudTraceBaseServiceRequest<TResponse> : Google.Apis.Requests.ClientServiceRequest<TResponse>
    {
        ///<summary>Constructs a new CloudTraceBaseServiceRequest instance.</summary>
        protected CloudTraceBaseServiceRequest(Google.Apis.Services.IClientService service)
            : base(service)
        {
        }

        /// <summary>V1 error format.</summary>
        [Google.Apis.Util.RequestParameterAttribute("$.xgafv", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<XgafvEnum> Xgafv { get; set; }

        /// <summary>V1 error format.</summary>
        public enum XgafvEnum
        {
            /// <summary>v1 error format</summary>
            [Google.Apis.Util.StringValueAttribute("1")]
            Value1,
            /// <summary>v2 error format</summary>
            [Google.Apis.Util.StringValueAttribute("2")]
            Value2,
        }

        /// <summary>OAuth access token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("access_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string AccessToken { get; set; }

        /// <summary>Data format for response.</summary>
        /// [default: json]
        [Google.Apis.Util.RequestParameterAttribute("alt", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<AltEnum> Alt { get; set; }

        /// <summary>Data format for response.</summary>
        public enum AltEnum
        {
            /// <summary>Responses with Content-Type of application/json</summary>
            [Google.Apis.Util.StringValueAttribute("json")]
            Json,
            /// <summary>Media download with context-dependent Content-Type</summary>
            [Google.Apis.Util.StringValueAttribute("media")]
            Media,
            /// <summary>Responses with Content-Type of application/x-protobuf</summary>
            [Google.Apis.Util.StringValueAttribute("proto")]
            Proto,
        }

        /// <summary>OAuth bearer token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("bearer_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string BearerToken { get; set; }

        /// <summary>JSONP</summary>
        [Google.Apis.Util.RequestParameterAttribute("callback", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Callback { get; set; }

        /// <summary>Selector specifying which fields to include in a partial response.</summary>
        [Google.Apis.Util.RequestParameterAttribute("fields", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Fields { get; set; }

        /// <summary>API key. Your API key identifies your project and provides you with API access, quota, and reports.
        /// Required unless you provide an OAuth 2.0 token.</summary>
        [Google.Apis.Util.RequestParameterAttribute("key", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string Key { get; set; }

        /// <summary>OAuth 2.0 token for the current user.</summary>
        [Google.Apis.Util.RequestParameterAttribute("oauth_token", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string OauthToken { get; set; }

        /// <summary>Pretty-print response.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("pp", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> Pp { get; set; }

        /// <summary>Returns response with indentations and line breaks.</summary>
        /// [default: true]
        [Google.Apis.Util.RequestParameterAttribute("prettyPrint", Google.Apis.Util.RequestParameterType.Query)]
        public virtual System.Nullable<bool> PrettyPrint { get; set; }

        /// <summary>Available to use for quota purposes for server-side applications. Can be any arbitrary string
        /// assigned to a user, but should not exceed 40 characters.</summary>
        [Google.Apis.Util.RequestParameterAttribute("quotaUser", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string QuotaUser { get; set; }

        /// <summary>Legacy upload protocol for media (e.g. "media", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("uploadType", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadType { get; set; }

        /// <summary>Upload protocol for media (e.g. "raw", "multipart").</summary>
        [Google.Apis.Util.RequestParameterAttribute("upload_protocol", Google.Apis.Util.RequestParameterType.Query)]
        public virtual string UploadProtocol { get; set; }

        /// <summary>Initializes CloudTrace parameter list.</summary>
        protected override void InitParameters()
        {
            base.InitParameters();

            RequestParameters.Add(
                "$.xgafv", new Google.Apis.Discovery.Parameter
                {
                    Name = "$.xgafv",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "access_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "access_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "alt", new Google.Apis.Discovery.Parameter
                {
                    Name = "alt",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "json",
                    Pattern = null,
                });
            RequestParameters.Add(
                "bearer_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "bearer_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "callback", new Google.Apis.Discovery.Parameter
                {
                    Name = "callback",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "fields", new Google.Apis.Discovery.Parameter
                {
                    Name = "fields",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "key", new Google.Apis.Discovery.Parameter
                {
                    Name = "key",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "oauth_token", new Google.Apis.Discovery.Parameter
                {
                    Name = "oauth_token",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "pp", new Google.Apis.Discovery.Parameter
                {
                    Name = "pp",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "prettyPrint", new Google.Apis.Discovery.Parameter
                {
                    Name = "prettyPrint",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = "true",
                    Pattern = null,
                });
            RequestParameters.Add(
                "quotaUser", new Google.Apis.Discovery.Parameter
                {
                    Name = "quotaUser",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "uploadType", new Google.Apis.Discovery.Parameter
                {
                    Name = "uploadType",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
            RequestParameters.Add(
                "upload_protocol", new Google.Apis.Discovery.Parameter
                {
                    Name = "upload_protocol",
                    IsRequired = false,
                    ParameterType = "query",
                    DefaultValue = null,
                    Pattern = null,
                });
        }
    }

    /// <summary>The "projects" collection of methods.</summary>
    public class ProjectsResource
    {
        private const string Resource = "projects";

        /// <summary>The service which this resource belongs to.</summary>
        private readonly Google.Apis.Services.IClientService service;

        /// <summary>Constructs a new resource.</summary>
        public ProjectsResource(Google.Apis.Services.IClientService service)
        {
            this.service = service;
            traces = new TracesResource(service);

        }

        private readonly TracesResource traces;

        /// <summary>Gets the Traces resource.</summary>
        public virtual TracesResource Traces
        {
            get { return traces; }
        }

        /// <summary>The "traces" collection of methods.</summary>
        public class TracesResource
        {
            private const string Resource = "traces";

            /// <summary>The service which this resource belongs to.</summary>
            private readonly Google.Apis.Services.IClientService service;

            /// <summary>Constructs a new resource.</summary>
            public TracesResource(Google.Apis.Services.IClientService service)
            {
                this.service = service;

            }


            /// <summary>Gets a single trace by its ID.</summary>
            /// <param name="projectId">ID of the Cloud project where the trace data is stored.</param>
            /// <param
            /// name="traceId">ID of the trace to return.</param>
            public virtual GetRequest Get(string projectId, string traceId)
            {
                return new GetRequest(service, projectId, traceId);
            }

            /// <summary>Gets a single trace by its ID.</summary>
            public class GetRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.Trace>
            {
                /// <summary>Constructs a new Get request.</summary>
                public GetRequest(Google.Apis.Services.IClientService service, string projectId, string traceId)
                    : base(service)
                {
                    ProjectId = projectId;
                    TraceId = traceId;
                    InitParameters();
                }


                /// <summary>ID of the Cloud project where the trace data is stored.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>ID of the trace to return.</summary>
                [Google.Apis.Util.RequestParameterAttribute("traceId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string TraceId { get; private set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "get"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/projects/{projectId}/traces/{traceId}"; }
                }

                /// <summary>Initializes Get parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "traceId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "traceId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }

            /// <summary>Returns of a list of traces that match the specified filter conditions.</summary>
            /// <param name="projectId">ID of the Cloud project where the trace data is stored.</param>
            public virtual ListRequest List(string projectId)
            {
                return new ListRequest(service, projectId);
            }

            /// <summary>Returns of a list of traces that match the specified filter conditions.</summary>
            public class ListRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.ListTracesResponse>
            {
                /// <summary>Constructs a new List request.</summary>
                public ListRequest(Google.Apis.Services.IClientService service, string projectId)
                    : base(service)
                {
                    ProjectId = projectId;
                    InitParameters();
                }


                /// <summary>ID of the Cloud project where the trace data is stored.</summary>
                [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
                public virtual string ProjectId { get; private set; }

                /// <summary>Start of the time interval (inclusive) during which the trace data was collected from the
                /// application.</summary>
                [Google.Apis.Util.RequestParameterAttribute("startTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object StartTime { get; set; }

                /// <summary>Token identifying the page of results to return. If provided, use the value of the
                /// `next_page_token` field from a previous request. Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageToken", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string PageToken { get; set; }

                /// <summary>Maximum number of traces to return. If not specified or <= 0, the implementation selects a
                /// reasonable value.  The implementation may return fewer traces than the requested page size.
                /// Optional.</summary>
                [Google.Apis.Util.RequestParameterAttribute("pageSize", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<int> PageSize { get; set; }

                /// <summary>Type of data returned for traces in the list. Optional. Default is `MINIMAL`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("view", Google.Apis.Util.RequestParameterType.Query)]
                public virtual System.Nullable<ViewEnum> View { get; set; }

                /// <summary>Type of data returned for traces in the list. Optional. Default is `MINIMAL`.</summary>
                public enum ViewEnum
                {
                    [Google.Apis.Util.StringValueAttribute("VIEW_TYPE_UNSPECIFIED")]
                    VIEWTYPEUNSPECIFIED,
                    [Google.Apis.Util.StringValueAttribute("MINIMAL")]
                    MINIMAL,
                    [Google.Apis.Util.StringValueAttribute("ROOTSPAN")]
                    ROOTSPAN,
                    [Google.Apis.Util.StringValueAttribute("COMPLETE")]
                    COMPLETE,
                }

                /// <summary>Field used to sort the returned traces. Optional. Can be one of the following:
                ///
                /// *   `trace_id` *   `name` (`name` field of root span in the trace) *   `duration` (difference
                /// between `end_time` and `start_time` fields of the root span) *   `start` (`start_time` field of the
                /// root span)
                ///
                /// Descending order can be specified by appending `desc` to the sort field (for example, `name desc`).
                ///
                /// Only one sort field is permitted.</summary>
                [Google.Apis.Util.RequestParameterAttribute("orderBy", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string OrderBy { get; set; }

                /// <summary>An optional filter against labels for the request.
                ///
                /// By default, searches use prefix matching. To specify exact match, prepend a plus symbol (`+`) to the
                /// search term. Multiple terms are ANDed. Syntax:
                ///
                /// *   `root:NAME_PREFIX` or `NAME_PREFIX`: Return traces where any root span starts with
                /// `NAME_PREFIX`. *   `+root:NAME` or `+NAME`: Return traces where any root span's name is exactly
                /// `NAME`. *   `span:NAME_PREFIX`: Return traces where any span starts with `NAME_PREFIX`. *
                /// `+span:NAME`: Return traces where any span's name is exactly `NAME`. *   `latency:DURATION`: Return
                /// traces whose overall latency is greater or equal to than `DURATION`. Accepted units are nanoseconds
                /// (`ns`), milliseconds (`ms`), and seconds (`s`). Default is `ms`. For example, `latency:24ms` returns
                /// traces whose overall latency is greater than or equal to 24 milliseconds. *   `label:LABEL_KEY`:
                /// Return all traces containing the specified label key (exact match, case-sensitive) regardless of the
                /// key:value pair's value (including empty values). *   `LABEL_KEY:VALUE_PREFIX`: Return all traces
                /// containing the specified label key (exact match, case-sensitive) whose value starts with
                /// `VALUE_PREFIX`. Both a key and a value must be specified. *   `+LABEL_KEY:VALUE`: Return all traces
                /// containing a key:value pair exactly matching the specified text. Both a key and a value must be
                /// specified. *   `method:VALUE`: Equivalent to `/http/method:VALUE`. *   `url:VALUE`: Equivalent to
                /// `/http/url:VALUE`.</summary>
                [Google.Apis.Util.RequestParameterAttribute("filter", Google.Apis.Util.RequestParameterType.Query)]
                public virtual string Filter { get; set; }

                /// <summary>End of the time interval (inclusive) during which the trace data was collected from the
                /// application.</summary>
                [Google.Apis.Util.RequestParameterAttribute("endTime", Google.Apis.Util.RequestParameterType.Query)]
                public virtual object EndTime { get; set; }


                ///<summary>Gets the method name.</summary>
                public override string MethodName
                {
                    get { return "list"; }
                }

                ///<summary>Gets the HTTP method.</summary>
                public override string HttpMethod
                {
                    get { return "GET"; }
                }

                ///<summary>Gets the REST path.</summary>
                public override string RestPath
                {
                    get { return "v1/projects/{projectId}/traces"; }
                }

                /// <summary>Initializes List parameter list.</summary>
                protected override void InitParameters()
                {
                    base.InitParameters();

                    RequestParameters.Add(
                        "projectId", new Google.Apis.Discovery.Parameter
                        {
                            Name = "projectId",
                            IsRequired = true,
                            ParameterType = "path",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "startTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "startTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageToken", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageToken",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "pageSize", new Google.Apis.Discovery.Parameter
                        {
                            Name = "pageSize",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "view", new Google.Apis.Discovery.Parameter
                        {
                            Name = "view",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "orderBy", new Google.Apis.Discovery.Parameter
                        {
                            Name = "orderBy",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "filter", new Google.Apis.Discovery.Parameter
                        {
                            Name = "filter",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                    RequestParameters.Add(
                        "endTime", new Google.Apis.Discovery.Parameter
                        {
                            Name = "endTime",
                            IsRequired = false,
                            ParameterType = "query",
                            DefaultValue = null,
                            Pattern = null,
                        });
                }

            }
        }

        /// <summary>Sends new traces to Stackdriver Trace or updates existing traces. If the ID of a trace that you
        /// send matches that of an existing trace, any fields in the existing trace and its spans are overwritten by
        /// the provided values, and any new fields provided are merged with the existing trace data. If the ID does not
        /// match, a new trace is created.</summary>
        /// <param name="body">The body of the request.</param>
        /// <param name="projectId">ID of the Cloud project where the trace data is stored.</param>
        public virtual PatchTracesRequest PatchTraces(Google.Apis.CloudTrace.v1.Data.Traces body, string projectId)
        {
            return new PatchTracesRequest(service, body, projectId);
        }

        /// <summary>Sends new traces to Stackdriver Trace or updates existing traces. If the ID of a trace that you
        /// send matches that of an existing trace, any fields in the existing trace and its spans are overwritten by
        /// the provided values, and any new fields provided are merged with the existing trace data. If the ID does not
        /// match, a new trace is created.</summary>
        public class PatchTracesRequest : CloudTraceBaseServiceRequest<Google.Apis.CloudTrace.v1.Data.Empty>
        {
            /// <summary>Constructs a new PatchTraces request.</summary>
            public PatchTracesRequest(Google.Apis.Services.IClientService service, Google.Apis.CloudTrace.v1.Data.Traces body, string projectId)
                : base(service)
            {
                ProjectId = projectId;
                Body = body;
                InitParameters();
            }


            /// <summary>ID of the Cloud project where the trace data is stored.</summary>
            [Google.Apis.Util.RequestParameterAttribute("projectId", Google.Apis.Util.RequestParameterType.Path)]
            public virtual string ProjectId { get; private set; }


            /// <summary>Gets or sets the body of this request.</summary>
            Google.Apis.CloudTrace.v1.Data.Traces Body { get; set; }

            ///<summary>Returns the body of the request.</summary>
            protected override object GetBody() { return Body; }

            ///<summary>Gets the method name.</summary>
            public override string MethodName
            {
                get { return "patchTraces"; }
            }

            ///<summary>Gets the HTTP method.</summary>
            public override string HttpMethod
            {
                get { return "PATCH"; }
            }

            ///<summary>Gets the REST path.</summary>
            public override string RestPath
            {
                get { return "v1/projects/{projectId}/traces"; }
            }

            /// <summary>Initializes PatchTraces parameter list.</summary>
            protected override void InitParameters()
            {
                base.InitParameters();

                RequestParameters.Add(
                    "projectId", new Google.Apis.Discovery.Parameter
                    {
                        Name = "projectId",
                        IsRequired = true,
                        ParameterType = "path",
                        DefaultValue = null,
                        Pattern = null,
                    });
            }

        }
    }
}

namespace Google.Apis.CloudTrace.v1.Data
{    

    /// <summary>A generic empty message that you can re-use to avoid defining duplicated empty messages in your APIs. A
    /// typical example is to use it as the request or the response type of an API method. For instance:
    ///
    /// service Foo { rpc Bar(google.protobuf.Empty) returns (google.protobuf.Empty); }
    ///
    /// The JSON representation for `Empty` is empty JSON object `{}`.</summary>
    public class Empty : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>The response message for the `ListTraces` method.</summary>
    public class ListTracesResponse : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>If defined, indicates that there are more traces that match the request and that this value should
        /// be passed to the next request to continue retrieving additional traces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("nextPageToken")]
        public virtual string NextPageToken { get; set; } 

        /// <summary>List of trace records as specified by the view parameter.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> Traces { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A trace describes how long it takes for an application to perform an operation. It consists of a set of
    /// spans, each of which represent a single timed event within the operation.</summary>
    public class Trace : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>Project ID of the Cloud project where the trace data is stored.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("projectId")]
        public virtual string ProjectId { get; set; } 

        /// <summary>Collection of spans in the trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spans")]
        public virtual System.Collections.Generic.IList<TraceSpan> Spans { get; set; } 

        /// <summary>Globally unique identifier for the trace. This identifier is a 128-bit numeric value formatted as a
        /// 32-byte hex string.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traceId")]
        public virtual string TraceId { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>A span represents a single timed event within a trace. Spans can be nested and form a trace tree.
    /// Often, a trace contains a root span that describes the end-to-end latency of an operation and, optionally, one
    /// or more subspans for its suboperations. Spans do not need to be contiguous. There may be gaps between spans in a
    /// trace.</summary>
    public class TraceSpan : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>End time of the span in nanoseconds from the UNIX epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("endTime")]
        public virtual object EndTime { get; set; } 

        /// <summary>Distinguishes between spans generated in a particular context. For example, two spans with the same
        /// name may be distinguished using `RPC_CLIENT` and `RPC_SERVER` to identify queueing latency associated with
        /// the span.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind { get; set; } 

        /// <summary>Collection of labels associated with the span. Label keys must be less than 128 bytes. Label values
        /// must be less than 16 kilobytes (10MB for `/stacktrace` values).
        ///
        /// Some predefined label keys exist, or you may create your own. When creating your own, we recommend the
        /// following formats:
        ///
        /// * `/category/product/key` for agents of well-known products (e.g. `/db/mongodb/read_size`). *
        /// `short_host/path/key` for domain-specific keys (e.g. `foo.com/myproduct/bar`)
        ///
        /// Predefined labels include:
        ///
        /// *   `/agent` *   `/component` *   `/error/message` *   `/error/name` *   `/http/client_city` *
        /// `/http/client_country` *   `/http/client_protocol` *   `/http/client_region` *   `/http/host` *
        /// `/http/method` *   `/http/path` *   `/http/redirected_url` *   `/http/request/size` *
        /// `/http/response/size` *   `/http/route` *   `/http/status_code` *   `/http/url` *   `/http/user_agent` *
        /// `/pid` *   `/stacktrace` *   `/tid`</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("labels")]
        public virtual System.Collections.Generic.IDictionary<string,string> Labels { get; set; } 

        /// <summary>Name of the span. Must be less than 128 bytes. The span name is sanitized and displayed in the
        /// Stackdriver Trace tool in the {% dynamic print site_values.console_name %}. The name may be a method name or
        /// some other per-call site name. For the same executable and the same call point, a best practice is to use a
        /// consistent name, which makes it easier to correlate cross-trace spans.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("name")]
        public virtual string Name { get; set; } 

        /// <summary>ID of the parent span, if any. Optional.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("parentSpanId")]
        public virtual System.Nullable<ulong> ParentSpanId { get; set; } 

        /// <summary>Identifier for the span. Must be a 64-bit integer other than 0 and unique within a trace.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("spanId")]
        public virtual System.Nullable<ulong> SpanId { get; set; } 

        /// <summary>Start time of the span in nanoseconds from the UNIX epoch.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("startTime")]
        public virtual object StartTime { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }    

    /// <summary>List of new or updated traces.</summary>
    public class Traces : Google.Apis.Requests.IDirectResponseSchema
    {
        /// <summary>List of traces.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("traces")]
        public virtual System.Collections.Generic.IList<Trace> TracesValue { get; set; } 

        /// <summary>The ETag of the item.</summary>
        public virtual string ETag { get; set; }
    }
}
