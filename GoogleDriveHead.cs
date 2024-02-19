using System;

public class GoogleDriveHead
{

    public class Rootobject
    {
        public string rootUrl { get; set; }
        public string kind { get; set; }
        public string mtlsRootUrl { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public Parameters parameters { get; set; }
        public string baseUrl { get; set; }
        public string title { get; set; }
        public Resources resources { get; set; }
        public Icons icons { get; set; }
        public Auth auth { get; set; }
        public string servicePath { get; set; }
        public string batchPath { get; set; }
        public string ownerName { get; set; }
        public Schemas schemas { get; set; }
        public string ownerDomain { get; set; }
        public string discoveryVersion { get; set; }
        public string protocol { get; set; }
        public string revision { get; set; }
        public string id { get; set; }
        public string version { get; set; }
        public string documentationLink { get; set; }
        public string basePath { get; set; }
    }

    public class Parameters
    {
        public Access_Token access_token { get; set; }
        public Alt alt { get; set; }
        public Callback callback { get; set; }
        public Fields fields { get; set; }
        public Key key { get; set; }
        public Oauth_Token oauth_token { get; set; }
        public Prettyprint prettyPrint { get; set; }
        public Quotauser quotaUser { get; set; }
        public Upload_Protocol upload_protocol { get; set; }
        public Uploadtype uploadType { get; set; }
        public Xgafv xgafv { get; set; }
    }

    public class Access_Token
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Alt
    {
        public string type { get; set; }
        public string description { get; set; }
        public string _default { get; set; }
        public string[] _enum { get; set; }
        public string[] enumDescriptions { get; set; }
        public string location { get; set; }
    }

    public class Callback
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Fields
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Oauth_Token
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Prettyprint
    {
        public string type { get; set; }
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
    }

    public class Quotauser
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Upload_Protocol
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Uploadtype
    {
        public string type { get; set; }
        public string description { get; set; }
        public string location { get; set; }
    }

    public class Xgafv
    {
        public string type { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string[] enumDescriptions { get; set; }
        public string location { get; set; }
    }

    public class Resources
    {
        public About about { get; set; }
        public Apps apps { get; set; }
        public Changes changes { get; set; }
        public Channels channels { get; set; }
        public Comments comments { get; set; }
        public Drives drives { get; set; }
        public Files files { get; set; }
        public Permissions permissions { get; set; }
        public Replies replies { get; set; }
        public Revisions revisions { get; set; }
        public Teamdrives teamdrives { get; set; }
    }

    public class About
    {
        public Methods methods { get; set; }
    }

    public class Methods
    {
        public Get get { get; set; }
    }

    public class Get
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters1 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters1
    {
    }

    public class Response
    {
        public string _ref { get; set; }
    }

    public class Apps
    {
        public Methods1 methods { get; set; }
    }

    public class Methods1
    {
        public Get1 get { get; set; }
        public List list { get; set; }
    }

    public class Get1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters2 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response1 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters2
    {
        public Appid appId { get; set; }
    }

    public class Appid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Response1
    {
        public string _ref { get; set; }
    }

    public class List
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters3 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response2 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters3
    {
        public Appfilterextensions appFilterExtensions { get; set; }
        public Appfiltermimetypes appFilterMimeTypes { get; set; }
        public Languagecode languageCode { get; set; }
    }

    public class Appfilterextensions
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Appfiltermimetypes
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Languagecode
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response2
    {
        public string _ref { get; set; }
    }

    public class Changes
    {
        public Methods2 methods { get; set; }
    }

    public class Methods2
    {
        public Getstartpagetoken getStartPageToken { get; set; }
        public List1 list { get; set; }
        public Watch watch { get; set; }
    }

    public class Getstartpagetoken
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters4 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response3 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters4
    {
        public Driveid driveId { get; set; }
        public Supportsalldrives supportsAllDrives { get; set; }
        public Supportsteamdrives supportsTeamDrives { get; set; }
        public Teamdriveid teamDriveId { get; set; }
    }

    public class Driveid
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Response3
    {
        public string _ref { get; set; }
    }

    public class List1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters5 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsSubscription { get; set; }
        public Response4 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters5
    {
        public Driveid1 driveId { get; set; }
        public Includecorpusremovals includeCorpusRemovals { get; set; }
        public Includeitemsfromalldrives includeItemsFromAllDrives { get; set; }
        public Includeremoved includeRemoved { get; set; }
        public Includeteamdriveitems includeTeamDriveItems { get; set; }
        public Pagesize pageSize { get; set; }
        public Pagetoken pageToken { get; set; }
        public Restricttomydrive restrictToMyDrive { get; set; }
        public Spaces spaces { get; set; }
        public Supportsalldrives1 supportsAllDrives { get; set; }
        public Supportsteamdrives1 supportsTeamDrives { get; set; }
        public Teamdriveid1 teamDriveId { get; set; }
        public Includepermissionsforview includePermissionsForView { get; set; }
        public Includelabels includeLabels { get; set; }
    }

    public class Driveid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includecorpusremovals
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeitemsfromalldrives
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeremoved
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeteamdriveitems
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Pagesize
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Restricttomydrive
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Spaces
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response4
    {
        public string _ref { get; set; }
    }

    public class Watch
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters6 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsSubscription { get; set; }
        public Request request { get; set; }
        public Response5 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters6
    {
        public Driveid2 driveId { get; set; }
        public Includecorpusremovals1 includeCorpusRemovals { get; set; }
        public Includeitemsfromalldrives1 includeItemsFromAllDrives { get; set; }
        public Includeremoved1 includeRemoved { get; set; }
        public Includeteamdriveitems1 includeTeamDriveItems { get; set; }
        public Pagesize1 pageSize { get; set; }
        public Pagetoken1 pageToken { get; set; }
        public Restricttomydrive1 restrictToMyDrive { get; set; }
        public Spaces1 spaces { get; set; }
        public Supportsalldrives2 supportsAllDrives { get; set; }
        public Supportsteamdrives2 supportsTeamDrives { get; set; }
        public Teamdriveid2 teamDriveId { get; set; }
        public Includepermissionsforview1 includePermissionsForView { get; set; }
        public Includelabels1 includeLabels { get; set; }
    }

    public class Driveid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includecorpusremovals1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeitemsfromalldrives1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeremoved1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeteamdriveitems1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Pagesize1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Restricttomydrive1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Spaces1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview1
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels1
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request
    {
        public string parameterName { get; set; }
        public string _ref { get; set; }
    }

    public class Response5
    {
        public string _ref { get; set; }
    }

    public class Channels
    {
        public Methods3 methods { get; set; }
    }

    public class Methods3
    {
        public Stop stop { get; set; }
    }

    public class Stop
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters7 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Request1 request { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters7
    {
    }

    public class Request1
    {
        public string parameterName { get; set; }
        public string _ref { get; set; }
    }

    public class Comments
    {
        public Methods4 methods { get; set; }
    }

    public class Methods4
    {
        public Create create { get; set; }
        public Delete delete { get; set; }
        public Get2 get { get; set; }
        public List2 list { get; set; }
        public Update update { get; set; }
    }

    public class Create
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters8 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request2 request { get; set; }
        public Response6 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters8
    {
        public Fileid fileId { get; set; }
    }

    public class Fileid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request2
    {
        public string _ref { get; set; }
    }

    public class Response6
    {
        public string _ref { get; set; }
    }

    public class Delete
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters9 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters9
    {
        public Fileid1 fileId { get; set; }
        public Commentid commentId { get; set; }
    }

    public class Fileid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Get2
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters10 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response7 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters10
    {
        public Fileid2 fileId { get; set; }
        public Commentid1 commentId { get; set; }
        public Includedeleted includeDeleted { get; set; }
    }

    public class Fileid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Includedeleted
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response7
    {
        public string _ref { get; set; }
    }

    public class List2
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters11 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response8 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters11
    {
        public Fileid3 fileId { get; set; }
        public Includedeleted1 includeDeleted { get; set; }
        public Pagesize2 pageSize { get; set; }
        public Pagetoken2 pageToken { get; set; }
        public Startmodifiedtime startModifiedTime { get; set; }
    }

    public class Fileid3
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Includedeleted1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Pagesize2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Startmodifiedtime
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response8
    {
        public string _ref { get; set; }
    }

    public class Update
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters12 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request3 request { get; set; }
        public Response9 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters12
    {
        public Fileid4 fileId { get; set; }
        public Commentid2 commentId { get; set; }
    }

    public class Fileid4
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request3
    {
        public string _ref { get; set; }
    }

    public class Response9
    {
        public string _ref { get; set; }
    }

    public class Drives
    {
        public Methods5 methods { get; set; }
    }

    public class Methods5
    {
        public Create1 create { get; set; }
        public Delete1 delete { get; set; }
        public Get3 get { get; set; }
        public Hide hide { get; set; }
        public List3 list { get; set; }
        public Unhide unhide { get; set; }
        public Update1 update { get; set; }
    }

    public class Create1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters13 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request4 request { get; set; }
        public Response10 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters13
    {
        public Requestid requestId { get; set; }
    }

    public class Requestid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request4
    {
        public string _ref { get; set; }
    }

    public class Response10
    {
        public string _ref { get; set; }
    }

    public class Delete1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters14 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters14
    {
        public Driveid3 driveId { get; set; }
        public Usedomainadminaccess useDomainAdminAccess { get; set; }
        public Allowitemdeletion allowItemDeletion { get; set; }
    }

    public class Driveid3
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Allowitemdeletion
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Get3
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters15 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response11 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters15
    {
        public Driveid4 driveId { get; set; }
        public Usedomainadminaccess1 useDomainAdminAccess { get; set; }
    }

    public class Driveid4
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response11
    {
        public string _ref { get; set; }
    }

    public class Hide
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters16 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response12 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters16
    {
        public Driveid5 driveId { get; set; }
    }

    public class Driveid5
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Response12
    {
        public string _ref { get; set; }
    }

    public class List3
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters17 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response13 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters17
    {
        public Pagesize3 pageSize { get; set; }
        public Pagetoken3 pageToken { get; set; }
        public Q q { get; set; }
        public Usedomainadminaccess2 useDomainAdminAccess { get; set; }
    }

    public class Pagesize3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken3
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Q
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response13
    {
        public string _ref { get; set; }
    }

    public class Unhide
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters18 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response14 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters18
    {
        public Driveid6 driveId { get; set; }
    }

    public class Driveid6
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Response14
    {
        public string _ref { get; set; }
    }

    public class Update1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters19 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request5 request { get; set; }
        public Response15 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters19
    {
        public Driveid7 driveId { get; set; }
        public Usedomainadminaccess3 useDomainAdminAccess { get; set; }
    }

    public class Driveid7
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request5
    {
        public string _ref { get; set; }
    }

    public class Response15
    {
        public string _ref { get; set; }
    }

    public class Files
    {
        public Methods6 methods { get; set; }
    }

    public class Methods6
    {
        public Copy copy { get; set; }
        public Create2 create { get; set; }
        public Delete2 delete { get; set; }
        public Emptytrash emptyTrash { get; set; }
        public Export export { get; set; }
        public Generateids generateIds { get; set; }
        public Get4 get { get; set; }
        public List4 list { get; set; }
        public Listlabels listLabels { get; set; }
        public Modifylabels modifyLabels { get; set; }
        public Update2 update { get; set; }
        public Watch1 watch { get; set; }
    }

    public class Copy
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters20 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request6 request { get; set; }
        public Response16 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters20
    {
        public Fileid5 fileId { get; set; }
        public Enforcesingleparent enforceSingleParent { get; set; }
        public Ignoredefaultvisibility ignoreDefaultVisibility { get; set; }
        public Keeprevisionforever keepRevisionForever { get; set; }
        public Ocrlanguage ocrLanguage { get; set; }
        public Supportsalldrives3 supportsAllDrives { get; set; }
        public Supportsteamdrives3 supportsTeamDrives { get; set; }
        public Includepermissionsforview2 includePermissionsForView { get; set; }
        public Includelabels2 includeLabels { get; set; }
    }

    public class Fileid5
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Enforcesingleparent
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Ignoredefaultvisibility
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Keeprevisionforever
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Ocrlanguage
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request6
    {
        public string _ref { get; set; }
    }

    public class Response16
    {
        public string _ref { get; set; }
    }

    public class Create2
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters21 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public bool supportsMediaUpload { get; set; }
        public Mediaupload mediaUpload { get; set; }
        public Request7 request { get; set; }
        public Response17 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters21
    {
        public Enforcesingleparent1 enforceSingleParent { get; set; }
        public Ignoredefaultvisibility1 ignoreDefaultVisibility { get; set; }
        public Keeprevisionforever1 keepRevisionForever { get; set; }
        public Ocrlanguage1 ocrLanguage { get; set; }
        public Supportsalldrives4 supportsAllDrives { get; set; }
        public Supportsteamdrives4 supportsTeamDrives { get; set; }
        public Usecontentasindexabletext useContentAsIndexableText { get; set; }
        public Includepermissionsforview3 includePermissionsForView { get; set; }
        public Includelabels3 includeLabels { get; set; }
    }

    public class Enforcesingleparent1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Ignoredefaultvisibility1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Keeprevisionforever1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Ocrlanguage1
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Usecontentasindexabletext
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview3
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels3
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Mediaupload
    {
        public string[] accept { get; set; }
        public string maxSize { get; set; }
        public Protocols protocols { get; set; }
    }

    public class Protocols
    {
        public Resumable resumable { get; set; }
        public Simple simple { get; set; }
    }

    public class Resumable
    {
        public bool multipart { get; set; }
        public string path { get; set; }
    }

    public class Simple
    {
        public bool multipart { get; set; }
        public string path { get; set; }
    }

    public class Request7
    {
        public string _ref { get; set; }
    }

    public class Response17
    {
        public string _ref { get; set; }
    }

    public class Delete2
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters22 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters22
    {
        public Fileid6 fileId { get; set; }
        public Supportsalldrives5 supportsAllDrives { get; set; }
        public Supportsteamdrives5 supportsTeamDrives { get; set; }
        public Enforcesingleparent2 enforceSingleParent { get; set; }
    }

    public class Fileid6
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives5
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives5
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Enforcesingleparent2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Emptytrash
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters23 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters23
    {
        public Enforcesingleparent3 enforceSingleParent { get; set; }
        public Driveid8 driveId { get; set; }
    }

    public class Enforcesingleparent3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Driveid8
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Export
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters24 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsMediaDownload { get; set; }
        public bool useMediaDownloadService { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters24
    {
        public Fileid7 fileId { get; set; }
        public Mimetype mimeType { get; set; }
    }

    public class Fileid7
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Mimetype
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Generateids
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters25 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response18 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters25
    {
        public Count count { get; set; }
        public Space space { get; set; }
        public Type type { get; set; }
    }

    public class Count
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Space
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Type
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response18
    {
        public string _ref { get; set; }
    }

    public class Get4
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters26 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsSubscription { get; set; }
        public bool supportsMediaDownload { get; set; }
        public bool useMediaDownloadService { get; set; }
        public Response19 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters26
    {
        public Fileid8 fileId { get; set; }
        public Acknowledgeabuse acknowledgeAbuse { get; set; }
        public Supportsalldrives6 supportsAllDrives { get; set; }
        public Supportsteamdrives6 supportsTeamDrives { get; set; }
        public Includepermissionsforview4 includePermissionsForView { get; set; }
        public Includelabels4 includeLabels { get; set; }
    }

    public class Fileid8
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Acknowledgeabuse
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives6
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives6
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview4
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels4
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response19
    {
        public string _ref { get; set; }
    }

    public class List4
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters27 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response20 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters27
    {
        public Corpora corpora { get; set; }
        public Corpus corpus { get; set; }
        public Driveid9 driveId { get; set; }
        public Includeitemsfromalldrives2 includeItemsFromAllDrives { get; set; }
        public Includeteamdriveitems2 includeTeamDriveItems { get; set; }
        public Orderby orderBy { get; set; }
        public Pagesize4 pageSize { get; set; }
        public Pagetoken4 pageToken { get; set; }
        public Q1 q { get; set; }
        public Spaces2 spaces { get; set; }
        public Supportsalldrives7 supportsAllDrives { get; set; }
        public Supportsteamdrives7 supportsTeamDrives { get; set; }
        public Teamdriveid3 teamDriveId { get; set; }
        public Includepermissionsforview5 includePermissionsForView { get; set; }
        public Includelabels5 includeLabels { get; set; }
    }

    public class Corpora
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Corpus
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
        public string[] enumDescriptions { get; set; }
        public string[] _enum { get; set; }
    }

    public class Driveid9
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeitemsfromalldrives2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includeteamdriveitems2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Orderby
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Pagesize4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken4
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Q1
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Spaces2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives7
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives7
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid3
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview5
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels5
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response20
    {
        public string _ref { get; set; }
    }

    public class Listlabels
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters28 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response21 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters28
    {
        public Fileid9 fileId { get; set; }
        public Maxresults maxResults { get; set; }
        public Pagetoken5 pageToken { get; set; }
    }

    public class Fileid9
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Maxresults
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken5
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response21
    {
        public string _ref { get; set; }
    }

    public class Modifylabels
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters29 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request8 request { get; set; }
        public Response22 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters29
    {
        public Fileid10 fileId { get; set; }
    }

    public class Fileid10
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request8
    {
        public string _ref { get; set; }
    }

    public class Response22
    {
        public string _ref { get; set; }
    }

    public class Update2
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters30 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsMediaUpload { get; set; }
        public Mediaupload1 mediaUpload { get; set; }
        public Request9 request { get; set; }
        public Response23 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters30
    {
        public Fileid11 fileId { get; set; }
        public Addparents addParents { get; set; }
        public Enforcesingleparent4 enforceSingleParent { get; set; }
        public Keeprevisionforever2 keepRevisionForever { get; set; }
        public Ocrlanguage2 ocrLanguage { get; set; }
        public Removeparents removeParents { get; set; }
        public Supportsalldrives8 supportsAllDrives { get; set; }
        public Supportsteamdrives8 supportsTeamDrives { get; set; }
        public Usecontentasindexabletext1 useContentAsIndexableText { get; set; }
        public Includepermissionsforview6 includePermissionsForView { get; set; }
        public Includelabels6 includeLabels { get; set; }
    }

    public class Fileid11
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Addparents
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Enforcesingleparent4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Keeprevisionforever2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Ocrlanguage2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Removeparents
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives8
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives8
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Usecontentasindexabletext1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview6
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels6
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Mediaupload1
    {
        public string[] accept { get; set; }
        public string maxSize { get; set; }
        public Protocols1 protocols { get; set; }
    }

    public class Protocols1
    {
        public Resumable1 resumable { get; set; }
        public Simple1 simple { get; set; }
    }

    public class Resumable1
    {
        public bool multipart { get; set; }
        public string path { get; set; }
    }

    public class Simple1
    {
        public bool multipart { get; set; }
        public string path { get; set; }
    }

    public class Request9
    {
        public string _ref { get; set; }
    }

    public class Response23
    {
        public string _ref { get; set; }
    }

    public class Watch1
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters31 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsSubscription { get; set; }
        public Request10 request { get; set; }
        public Response24 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters31
    {
        public Fileid12 fileId { get; set; }
        public Supportsalldrives9 supportsAllDrives { get; set; }
        public Supportsteamdrives9 supportsTeamDrives { get; set; }
        public Acknowledgeabuse1 acknowledgeAbuse { get; set; }
        public Includepermissionsforview7 includePermissionsForView { get; set; }
        public Includelabels7 includeLabels { get; set; }
    }

    public class Fileid12
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives9
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives9
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Acknowledgeabuse1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview7
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includelabels7
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request10
    {
        public string parameterName { get; set; }
        public string _ref { get; set; }
    }

    public class Response24
    {
        public string _ref { get; set; }
    }

    public class Permissions
    {
        public Methods7 methods { get; set; }
    }

    public class Methods7
    {
        public Create3 create { get; set; }
        public Delete3 delete { get; set; }
        public Get5 get { get; set; }
        public List5 list { get; set; }
        public Update3 update { get; set; }
    }

    public class Create3
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters32 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request11 request { get; set; }
        public Response25 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters32
    {
        public Fileid13 fileId { get; set; }
        public Emailmessage emailMessage { get; set; }
        public Enforcesingleparent5 enforceSingleParent { get; set; }
        public Movetonewownersroot moveToNewOwnersRoot { get; set; }
        public Sendnotificationemail sendNotificationEmail { get; set; }
        public Supportsalldrives10 supportsAllDrives { get; set; }
        public Supportsteamdrives10 supportsTeamDrives { get; set; }
        public Transferownership transferOwnership { get; set; }
        public Usedomainadminaccess4 useDomainAdminAccess { get; set; }
    }

    public class Fileid13
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Emailmessage
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Enforcesingleparent5
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Movetonewownersroot
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Sendnotificationemail
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives10
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives10
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Transferownership
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request11
    {
        public string _ref { get; set; }
    }

    public class Response25
    {
        public string _ref { get; set; }
    }

    public class Delete3
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters33 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters33
    {
        public Fileid14 fileId { get; set; }
        public Permissionid permissionId { get; set; }
        public Supportsalldrives11 supportsAllDrives { get; set; }
        public Supportsteamdrives11 supportsTeamDrives { get; set; }
        public Usedomainadminaccess5 useDomainAdminAccess { get; set; }
    }

    public class Fileid14
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Permissionid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives11
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives11
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess5
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Get5
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters34 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response26 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters34
    {
        public Fileid15 fileId { get; set; }
        public Permissionid1 permissionId { get; set; }
        public Supportsalldrives12 supportsAllDrives { get; set; }
        public Supportsteamdrives12 supportsTeamDrives { get; set; }
        public Usedomainadminaccess6 useDomainAdminAccess { get; set; }
    }

    public class Fileid15
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Permissionid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives12
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives12
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess6
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response26
    {
        public string _ref { get; set; }
    }

    public class List5
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters35 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response27 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters35
    {
        public Fileid16 fileId { get; set; }
        public Pagesize5 pageSize { get; set; }
        public Pagetoken6 pageToken { get; set; }
        public Supportsalldrives13 supportsAllDrives { get; set; }
        public Supportsteamdrives13 supportsTeamDrives { get; set; }
        public Usedomainadminaccess7 useDomainAdminAccess { get; set; }
        public Includepermissionsforview8 includePermissionsForView { get; set; }
    }

    public class Fileid16
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Pagesize5
    {
        public string description { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken6
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives13
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives13
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess7
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Includepermissionsforview8
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response27
    {
        public string _ref { get; set; }
    }

    public class Update3
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters36 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request12 request { get; set; }
        public Response28 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters36
    {
        public Fileid17 fileId { get; set; }
        public Permissionid2 permissionId { get; set; }
        public Removeexpiration removeExpiration { get; set; }
        public Supportsalldrives14 supportsAllDrives { get; set; }
        public Supportsteamdrives14 supportsTeamDrives { get; set; }
        public Transferownership1 transferOwnership { get; set; }
        public Usedomainadminaccess8 useDomainAdminAccess { get; set; }
    }

    public class Fileid17
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Permissionid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Removeexpiration
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsalldrives14
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Supportsteamdrives14
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Transferownership1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess8
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request12
    {
        public string _ref { get; set; }
    }

    public class Response28
    {
        public string _ref { get; set; }
    }

    public class Replies
    {
        public Methods8 methods { get; set; }
    }

    public class Methods8
    {
        public Create4 create { get; set; }
        public Delete4 delete { get; set; }
        public Get6 get { get; set; }
        public List6 list { get; set; }
        public Update4 update { get; set; }
    }

    public class Create4
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters37 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request13 request { get; set; }
        public Response29 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters37
    {
        public Fileid18 fileId { get; set; }
        public Commentid3 commentId { get; set; }
    }

    public class Fileid18
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid3
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request13
    {
        public string _ref { get; set; }
    }

    public class Response29
    {
        public string _ref { get; set; }
    }

    public class Delete4
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters38 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters38
    {
        public Fileid19 fileId { get; set; }
        public Commentid4 commentId { get; set; }
        public Replyid replyId { get; set; }
    }

    public class Fileid19
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid4
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Replyid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Get6
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters39 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response30 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters39
    {
        public Fileid20 fileId { get; set; }
        public Commentid5 commentId { get; set; }
        public Replyid1 replyId { get; set; }
        public Includedeleted2 includeDeleted { get; set; }
    }

    public class Fileid20
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid5
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Replyid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Includedeleted2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response30
    {
        public string _ref { get; set; }
    }

    public class List6
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters40 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response31 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters40
    {
        public Fileid21 fileId { get; set; }
        public Commentid6 commentId { get; set; }
        public Includedeleted3 includeDeleted { get; set; }
        public Pagesize6 pageSize { get; set; }
        public Pagetoken7 pageToken { get; set; }
    }

    public class Fileid21
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid6
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Includedeleted3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Pagesize6
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken7
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response31
    {
        public string _ref { get; set; }
    }

    public class Update4
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters41 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request14 request { get; set; }
        public Response32 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters41
    {
        public Fileid22 fileId { get; set; }
        public Commentid7 commentId { get; set; }
        public Replyid2 replyId { get; set; }
    }

    public class Fileid22
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Commentid7
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Replyid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request14
    {
        public string _ref { get; set; }
    }

    public class Response32
    {
        public string _ref { get; set; }
    }

    public class Revisions
    {
        public Methods9 methods { get; set; }
    }

    public class Methods9
    {
        public Delete5 delete { get; set; }
        public Get7 get { get; set; }
        public List7 list { get; set; }
        public Update5 update { get; set; }
    }

    public class Delete5
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters42 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters42
    {
        public Fileid23 fileId { get; set; }
        public Revisionid revisionId { get; set; }
    }

    public class Fileid23
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Revisionid
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Get7
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters43 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public bool supportsMediaDownload { get; set; }
        public bool useMediaDownloadService { get; set; }
        public Response33 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters43
    {
        public Fileid24 fileId { get; set; }
        public Revisionid1 revisionId { get; set; }
        public Acknowledgeabuse2 acknowledgeAbuse { get; set; }
    }

    public class Fileid24
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Revisionid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Acknowledgeabuse2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response33
    {
        public string _ref { get; set; }
    }

    public class List7
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters44 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response34 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters44
    {
        public Fileid25 fileId { get; set; }
        public Pagesize7 pageSize { get; set; }
        public Pagetoken8 pageToken { get; set; }
    }

    public class Fileid25
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Pagesize7
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken8
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response34
    {
        public string _ref { get; set; }
    }

    public class Update5
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters45 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request15 request { get; set; }
        public Response35 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters45
    {
        public Fileid26 fileId { get; set; }
        public Revisionid2 revisionId { get; set; }
    }

    public class Fileid26
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Revisionid2
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request15
    {
        public string _ref { get; set; }
    }

    public class Response35
    {
        public string _ref { get; set; }
    }

    public class Teamdrives
    {
        public Methods10 methods { get; set; }
    }

    public class Methods10
    {
        public Create5 create { get; set; }
        public Delete6 delete { get; set; }
        public Get8 get { get; set; }
        public List8 list { get; set; }
        public Update6 update { get; set; }
    }

    public class Create5
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters46 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request16 request { get; set; }
        public Response36 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters46
    {
        public Requestid1 requestId { get; set; }
    }

    public class Requestid1
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Request16
    {
        public string _ref { get; set; }
    }

    public class Response36
    {
        public string _ref { get; set; }
    }

    public class Delete6
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters47 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters47
    {
        public Teamdriveid4 teamDriveId { get; set; }
    }

    public class Teamdriveid4
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Get8
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters48 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Response37 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters48
    {
        public Teamdriveid5 teamDriveId { get; set; }
        public Usedomainadminaccess9 useDomainAdminAccess { get; set; }
    }

    public class Teamdriveid5
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess9
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response37
    {
        public string _ref { get; set; }
    }

    public class List8
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters49 parameters { get; set; }
        public object[] parameterOrder { get; set; }
        public Response38 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters49
    {
        public Pagesize8 pageSize { get; set; }
        public Pagetoken9 pageToken { get; set; }
        public Q2 q { get; set; }
        public Usedomainadminaccess10 useDomainAdminAccess { get; set; }
    }

    public class Pagesize8
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string minimum { get; set; }
        public string maximum { get; set; }
        public string location { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Pagetoken9
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Q2
    {
        public string description { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess10
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Response38
    {
        public string _ref { get; set; }
    }

    public class Update6
    {
        public string id { get; set; }
        public string path { get; set; }
        public string flatPath { get; set; }
        public string httpMethod { get; set; }
        public Parameters50 parameters { get; set; }
        public string[] parameterOrder { get; set; }
        public Request17 request { get; set; }
        public Response39 response { get; set; }
        public string[] scopes { get; set; }
        public string description { get; set; }
    }

    public class Parameters50
    {
        public Teamdriveid6 teamDriveId { get; set; }
        public Usedomainadminaccess11 useDomainAdminAccess { get; set; }
    }

    public class Teamdriveid6
    {
        public string description { get; set; }
        public string location { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
    }

    public class Usedomainadminaccess11
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string location { get; set; }
        public string type { get; set; }
    }

    public class Request17
    {
        public string _ref { get; set; }
    }

    public class Response39
    {
        public string _ref { get; set; }
    }

    public class Icons
    {
        public string x16 { get; set; }
        public string x32 { get; set; }
    }

    public class Auth
    {
        public Oauth2 oauth2 { get; set; }
    }

    public class Oauth2
    {
        public Scopes scopes { get; set; }
    }

    public class Scopes
    {
        public HttpsWwwGoogleapisComAuthDrive httpswwwgoogleapiscomauthdrive { get; set; }
        public HttpsWwwGoogleapisComAuthDriveAppdata httpswwwgoogleapiscomauthdriveappdata { get; set; }
        public HttpsWwwGoogleapisComAuthDriveAppsReadonly httpswwwgoogleapiscomauthdriveappsreadonly { get; set; }
        public HttpsWwwGoogleapisComAuthDriveFile httpswwwgoogleapiscomauthdrivefile { get; set; }
        public HttpsWwwGoogleapisComAuthDriveMetadata httpswwwgoogleapiscomauthdrivemetadata { get; set; }
        public HttpsWwwGoogleapisComAuthDriveMetadataReadonly httpswwwgoogleapiscomauthdrivemetadatareadonly { get; set; }
        public HttpsWwwGoogleapisComAuthDrivePhotosReadonly httpswwwgoogleapiscomauthdrivephotosreadonly { get; set; }
        public HttpsWwwGoogleapisComAuthDriveReadonly httpswwwgoogleapiscomauthdrivereadonly { get; set; }
        public HttpsWwwGoogleapisComAuthDriveScripts httpswwwgoogleapiscomauthdrivescripts { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDrive
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveAppdata
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveAppsReadonly
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveFile
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveMetadata
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveMetadataReadonly
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDrivePhotosReadonly
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveReadonly
    {
        public string description { get; set; }
    }

    public class HttpsWwwGoogleapisComAuthDriveScripts
    {
        public string description { get; set; }
    }

    public class Schemas
    {
        public About1 About { get; set; }
        public User1 User { get; set; }
        public App App { get; set; }
        public Appicons AppIcons { get; set; }
        public Applist AppList { get; set; }
        public Startpagetoken StartPageToken { get; set; }
        public Changelist ChangeList { get; set; }
        public Change Change { get; set; }
        public File1 File { get; set; }
        public Permission Permission { get; set; }
        public Contentrestriction ContentRestriction { get; set; }
        public Label Label { get; set; }
        public Labelfield LabelField { get; set; }
        public Teamdrive1 TeamDrive { get; set; }
        public Drive1 Drive { get; set; }
        public Channel Channel { get; set; }
        public Comment Comment { get; set; }
        public Reply Reply { get; set; }
        public Commentlist CommentList { get; set; }
        public Drivelist DriveList { get; set; }
        public Generatedids GeneratedIds { get; set; }
        public Filelist FileList { get; set; }
        public Labellist LabelList { get; set; }
        public Modifylabelsrequest ModifyLabelsRequest { get; set; }
        public Labelmodification LabelModification { get; set; }
        public Labelfieldmodification LabelFieldModification { get; set; }
        public Modifylabelsresponse ModifyLabelsResponse { get; set; }
        public Permissionlist PermissionList { get; set; }
        public Replylist ReplyList { get; set; }
        public Revision Revision { get; set; }
        public Revisionlist RevisionList { get; set; }
        public Teamdrivelist TeamDriveList { get; set; }
    }

    public class About1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public Kind kind { get; set; }
        public Storagequota storageQuota { get; set; }
        public Drivethemes driveThemes { get; set; }
        public Cancreatedrives canCreateDrives { get; set; }
        public Importformats importFormats { get; set; }
        public Exportformats exportFormats { get; set; }
        public Appinstalled appInstalled { get; set; }
        public User user { get; set; }
        public Foldercolorpalette folderColorPalette { get; set; }
        public Maximportsizes maxImportSizes { get; set; }
        public Maxuploadsize maxUploadSize { get; set; }
        public Teamdrivethemes teamDriveThemes { get; set; }
        public Cancreateteamdrives canCreateTeamDrives { get; set; }
    }

    public class Kind
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Storagequota
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties1 properties { get; set; }
    }

    public class Properties1
    {
        public Limit limit { get; set; }
        public Usageindrive usageInDrive { get; set; }
        public Usageindrivetrash usageInDriveTrash { get; set; }
        public Usage usage { get; set; }
    }

    public class Limit
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Usageindrive
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Usageindrivetrash
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Usage
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Drivethemes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public string type { get; set; }
        public Properties2 properties { get; set; }
    }

    public class Properties2
    {
        public Id id { get; set; }
        public Backgroundimagelink backgroundImageLink { get; set; }
        public Colorrgb colorRgb { get; set; }
    }

    public class Id
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagelink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Colorrgb
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancreatedrives
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Importformats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties additionalProperties { get; set; }
    }

    public class Additionalproperties
    {
        public string type { get; set; }
        public Items1 items { get; set; }
    }

    public class Items1
    {
        public string type { get; set; }
    }

    public class Exportformats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties1 additionalProperties { get; set; }
    }

    public class Additionalproperties1
    {
        public string type { get; set; }
        public Items2 items { get; set; }
    }

    public class Items2
    {
        public string type { get; set; }
    }

    public class Appinstalled
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class User
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Foldercolorpalette
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items3 items { get; set; }
    }

    public class Items3
    {
        public string type { get; set; }
    }

    public class Maximportsizes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties2 additionalProperties { get; set; }
    }

    public class Additionalproperties2
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Maxuploadsize
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Teamdrivethemes
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
        public Items4 items { get; set; }
    }

    public class Items4
    {
        public string type { get; set; }
        public Properties3 properties { get; set; }
    }

    public class Properties3
    {
        public Id1 id { get; set; }
        public Backgroundimagelink1 backgroundImageLink { get; set; }
        public Colorrgb1 colorRgb { get; set; }
    }

    public class Id1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagelink1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Colorrgb1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Cancreateteamdrives
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class User1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties4 properties { get; set; }
    }

    public class Properties4
    {
        public Displayname displayName { get; set; }
        public Kind1 kind { get; set; }
        public Me me { get; set; }
        public Permissionid3 permissionId { get; set; }
        public Emailaddress emailAddress { get; set; }
        public Photolink photoLink { get; set; }
    }

    public class Displayname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind1
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Me
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Permissionid3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Emailaddress
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Photolink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class App
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties5 properties { get; set; }
    }

    public class Properties5
    {
        public Name name { get; set; }
        public Objecttype objectType { get; set; }
        public Supportscreate supportsCreate { get; set; }
        public Producturl productUrl { get; set; }
        public Primarymimetypes primaryMimeTypes { get; set; }
        public Secondarymimetypes secondaryMimeTypes { get; set; }
        public Primaryfileextensions primaryFileExtensions { get; set; }
        public Secondaryfileextensions secondaryFileExtensions { get; set; }
        public Id2 id { get; set; }
        public Supportsimport supportsImport { get; set; }
        public Installed installed { get; set; }
        public Authorized authorized { get; set; }
        public Icons1 icons { get; set; }
        public Usebydefault useByDefault { get; set; }
        public Kind2 kind { get; set; }
        public Shortdescription shortDescription { get; set; }
        public Longdescription longDescription { get; set; }
        public Supportsmultiopen supportsMultiOpen { get; set; }
        public Productid productId { get; set; }
        public Openurltemplate openUrlTemplate { get; set; }
        public Createurl createUrl { get; set; }
        public Createinfoldertemplate createInFolderTemplate { get; set; }
        public Supportsofflinecreate supportsOfflineCreate { get; set; }
        public Hasdrivewidescope hasDriveWideScope { get; set; }
    }

    public class Name
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Objecttype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Supportscreate
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Producturl
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Primarymimetypes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items5 items { get; set; }
    }

    public class Items5
    {
        public string type { get; set; }
    }

    public class Secondarymimetypes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items6 items { get; set; }
    }

    public class Items6
    {
        public string type { get; set; }
    }

    public class Primaryfileextensions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items7 items { get; set; }
    }

    public class Items7
    {
        public string type { get; set; }
    }

    public class Secondaryfileextensions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items8 items { get; set; }
    }

    public class Items8
    {
        public string type { get; set; }
    }

    public class Id2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Supportsimport
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Installed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Authorized
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Icons1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items9 items { get; set; }
    }

    public class Items9
    {
        public string _ref { get; set; }
    }

    public class Usebydefault
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind2
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Shortdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Longdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Supportsmultiopen
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Productid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Openurltemplate
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Createurl
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Createinfoldertemplate
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Supportsofflinecreate
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hasdrivewidescope
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Appicons
    {
        public string id { get; set; }
        public string type { get; set; }
        public Properties6 properties { get; set; }
    }

    public class Properties6
    {
        public Size size { get; set; }
        public Category category { get; set; }
        public Iconurl iconUrl { get; set; }
    }

    public class Size
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Category
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iconurl
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Applist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties7 properties { get; set; }
    }

    public class Properties7
    {
        public Defaultappids defaultAppIds { get; set; }
        public Kind3 kind { get; set; }
        public Selflink selfLink { get; set; }
        public Items11 items { get; set; }
    }

    public class Defaultappids
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items10 items { get; set; }
    }

    public class Items10
    {
        public string type { get; set; }
    }

    public class Kind3
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Selflink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Items11
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items12 items { get; set; }
    }

    public class Items12
    {
        public string _ref { get; set; }
    }

    public class Startpagetoken
    {
        public string id { get; set; }
        public string type { get; set; }
        public Properties8 properties { get; set; }
    }

    public class Properties8
    {
        public Startpagetoken1 startPageToken { get; set; }
        public Kind4 kind { get; set; }
    }

    public class Startpagetoken1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind4
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Changelist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties9 properties { get; set; }
    }

    public class Properties9
    {
        public Kind5 kind { get; set; }
        public Nextpagetoken nextPageToken { get; set; }
        public Newstartpagetoken newStartPageToken { get; set; }
        public Changes1 changes { get; set; }
    }

    public class Kind5
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Nextpagetoken
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Newstartpagetoken
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Changes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items13 items { get; set; }
    }

    public class Items13
    {
        public string _ref { get; set; }
    }

    public class Change
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties10 properties { get; set; }
    }

    public class Properties10
    {
        public Kind6 kind { get; set; }
        public Removed removed { get; set; }
        public File file { get; set; }
        public Fileid27 fileId { get; set; }
        public Time time { get; set; }
        public Driveid10 driveId { get; set; }
        public Type1 type { get; set; }
        public Teamdriveid7 teamDriveId { get; set; }
        public Teamdrive teamDrive { get; set; }
        public Changetype changeType { get; set; }
        public Drive drive { get; set; }
    }

    public class Kind6
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Removed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class File
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Fileid27
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Time
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Driveid10
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Type1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid7
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Teamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string _ref { get; set; }
    }

    public class Changetype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Drive
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class File1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties11 properties { get; set; }
    }

    public class Properties11
    {
        public Kind7 kind { get; set; }
        public Driveid11 driveId { get; set; }
        public Fileextension fileExtension { get; set; }
        public Copyrequireswriterpermission copyRequiresWriterPermission { get; set; }
        public Md5checksum md5Checksum { get; set; }
        public Contenthints contentHints { get; set; }
        public Writerscanshare writersCanShare { get; set; }
        public Viewedbyme viewedByMe { get; set; }
        public Mimetype2 mimeType { get; set; }
        public Exportlinks exportLinks { get; set; }
        public Parents parents { get; set; }
        public Thumbnaillink thumbnailLink { get; set; }
        public Iconlink iconLink { get; set; }
        public Shared shared { get; set; }
        public Lastmodifyinguser lastModifyingUser { get; set; }
        public Owners owners { get; set; }
        public Headrevisionid headRevisionId { get; set; }
        public Sharinguser sharingUser { get; set; }
        public Webviewlink webViewLink { get; set; }
        public Webcontentlink webContentLink { get; set; }
        public Size1 size { get; set; }
        public Viewerscancopycontent viewersCanCopyContent { get; set; }
        public Permissions1 permissions { get; set; }
        public Hasthumbnail hasThumbnail { get; set; }
        public Spaces3 spaces { get; set; }
        public Foldercolorrgb folderColorRgb { get; set; }
        public Id3 id { get; set; }
        public Name1 name { get; set; }
        public Description description { get; set; }
        public Starred starred { get; set; }
        public Trashed trashed { get; set; }
        public Explicitlytrashed explicitlyTrashed { get; set; }
        public Createdtime createdTime { get; set; }
        public Modifiedtime modifiedTime { get; set; }
        public Modifiedbymetime modifiedByMeTime { get; set; }
        public Viewedbymetime viewedByMeTime { get; set; }
        public Sharedwithmetime sharedWithMeTime { get; set; }
        public Quotabytesused quotaBytesUsed { get; set; }
        public Version version { get; set; }
        public Originalfilename originalFilename { get; set; }
        public Ownedbyme ownedByMe { get; set; }
        public Fullfileextension fullFileExtension { get; set; }
        public Properties14 properties { get; set; }
        public Appproperties appProperties { get; set; }
        public Isappauthorized isAppAuthorized { get; set; }
        public Teamdriveid8 teamDriveId { get; set; }
        public Capabilities capabilities { get; set; }
        public Hasaugmentedpermissions hasAugmentedPermissions { get; set; }
        public Trashinguser trashingUser { get; set; }
        public Thumbnailversion thumbnailVersion { get; set; }
        public Trashedtime trashedTime { get; set; }
        public Modifiedbyme modifiedByMe { get; set; }
        public Permissionids permissionIds { get; set; }
        public Imagemediametadata imageMediaMetadata { get; set; }
        public Videomediametadata videoMediaMetadata { get; set; }
        public Shortcutdetails shortcutDetails { get; set; }
        public Contentrestrictions contentRestrictions { get; set; }
        public Resourcekey resourceKey { get; set; }
        public Linksharemetadata linkShareMetadata { get; set; }
        public Labelinfo labelInfo { get; set; }
        public Sha1checksum sha1Checksum { get; set; }
        public Sha256checksum sha256Checksum { get; set; }
    }

    public class Kind7
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Driveid11
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Fileextension
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Copyrequireswriterpermission
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Md5checksum
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Contenthints
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties12 properties { get; set; }
    }

    public class Properties12
    {
        public Indexabletext indexableText { get; set; }
        public Thumbnail thumbnail { get; set; }
    }

    public class Indexabletext
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Thumbnail
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties13 properties { get; set; }
    }

    public class Properties13
    {
        public Image image { get; set; }
        public Mimetype1 mimeType { get; set; }
    }

    public class Image
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Mimetype1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Writerscanshare
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Viewedbyme
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Mimetype2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Exportlinks
    {
        public string description { get; set; }
        public bool readOnly { get; set; }
        public string type { get; set; }
        public Additionalproperties3 additionalProperties { get; set; }
    }

    public class Additionalproperties3
    {
        public string type { get; set; }
    }

    public class Parents
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items14 items { get; set; }
    }

    public class Items14
    {
        public string type { get; set; }
    }

    public class Thumbnaillink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iconlink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Shared
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Lastmodifyinguser
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Owners
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items15 items { get; set; }
    }

    public class Items15
    {
        public string _ref { get; set; }
    }

    public class Headrevisionid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sharinguser
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Webviewlink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Webcontentlink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Size1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Viewerscancopycontent
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Permissions1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items16 items { get; set; }
    }

    public class Items16
    {
        public string _ref { get; set; }
    }

    public class Hasthumbnail
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Spaces3
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items17 items { get; set; }
    }

    public class Items17
    {
        public string type { get; set; }
    }

    public class Foldercolorrgb
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Id3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Name1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Description
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Starred
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Trashed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Explicitlytrashed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Createdtime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Modifiedtime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Modifiedbymetime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Viewedbymetime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Sharedwithmetime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Quotabytesused
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Version
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Originalfilename
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Ownedbyme
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Fullfileextension
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Properties14
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties4 additionalProperties { get; set; }
    }

    public class Additionalproperties4
    {
        public string type { get; set; }
    }

    public class Appproperties
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties5 additionalProperties { get; set; }
    }

    public class Additionalproperties5
    {
        public string type { get; set; }
    }

    public class Isappauthorized
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Teamdriveid8
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Capabilities
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties15 properties { get; set; }
    }

    public class Properties15
    {
        public Canchangeviewerscancopycontent canChangeViewersCanCopyContent { get; set; }
        public Canmovechildrenoutofdrive canMoveChildrenOutOfDrive { get; set; }
        public Canreaddrive canReadDrive { get; set; }
        public Canedit canEdit { get; set; }
        public Cancopy canCopy { get; set; }
        public Cancomment canComment { get; set; }
        public Canaddchildren canAddChildren { get; set; }
        public Candelete canDelete { get; set; }
        public Candownload canDownload { get; set; }
        public Canlistchildren canListChildren { get; set; }
        public Canremovechildren canRemoveChildren { get; set; }
        public Canrename canRename { get; set; }
        public Cantrash canTrash { get; set; }
        public Canreadrevisions canReadRevisions { get; set; }
        public Canreadteamdrive canReadTeamDrive { get; set; }
        public Canmoveteamdriveitem canMoveTeamDriveItem { get; set; }
        public Canchangecopyrequireswriterpermission canChangeCopyRequiresWriterPermission { get; set; }
        public Canmoveitemintoteamdrive canMoveItemIntoTeamDrive { get; set; }
        public Canuntrash canUntrash { get; set; }
        public Canmodifycontent canModifyContent { get; set; }
        public Canmoveitemwithinteamdrive canMoveItemWithinTeamDrive { get; set; }
        public Canmoveitemoutofteamdrive canMoveItemOutOfTeamDrive { get; set; }
        public Candeletechildren canDeleteChildren { get; set; }
        public Canmovechildrenoutofteamdrive canMoveChildrenOutOfTeamDrive { get; set; }
        public Canmovechildrenwithinteamdrive canMoveChildrenWithinTeamDrive { get; set; }
        public Cantrashchildren canTrashChildren { get; set; }
        public Canmoveitemoutofdrive canMoveItemOutOfDrive { get; set; }
        public Canaddmydriveparent canAddMyDriveParent { get; set; }
        public Canremovemydriveparent canRemoveMyDriveParent { get; set; }
        public Canmoveitemwithindrive canMoveItemWithinDrive { get; set; }
        public Canshare canShare { get; set; }
        public Canmovechildrenwithindrive canMoveChildrenWithinDrive { get; set; }
        public Canmodifycontentrestriction canModifyContentRestriction { get; set; }
        public Canaddfolderfromanotherdrive canAddFolderFromAnotherDrive { get; set; }
        public Canchangesecurityupdateenabled canChangeSecurityUpdateEnabled { get; set; }
        public Canacceptownership canAcceptOwnership { get; set; }
        public Canreadlabels canReadLabels { get; set; }
        public Canmodifylabels canModifyLabels { get; set; }
        public Canmodifyeditorcontentrestriction canModifyEditorContentRestriction { get; set; }
        public Canmodifyownercontentrestriction canModifyOwnerContentRestriction { get; set; }
        public Canremovecontentrestriction canRemoveContentRestriction { get; set; }
    }

    public class Canchangeviewerscancopycontent
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canmovechildrenoutofdrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreaddrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canedit
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancopy
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancomment
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canaddchildren
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candelete
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candownload
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canlistchildren
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canremovechildren
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canrename
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cantrash
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreadrevisions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreadteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canmoveteamdriveitem
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canchangecopyrequireswriterpermission
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmoveitemintoteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canuntrash
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmodifycontent
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmoveitemwithinteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canmoveitemoutofteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Candeletechildren
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmovechildrenoutofteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canmovechildrenwithinteamdrive
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Cantrashchildren
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmoveitemoutofdrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canaddmydriveparent
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canremovemydriveparent
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmoveitemwithindrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canshare
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmovechildrenwithindrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmodifycontentrestriction
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canaddfolderfromanotherdrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangesecurityupdateenabled
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canacceptownership
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreadlabels
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmodifylabels
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmodifyeditorcontentrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmodifyownercontentrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canremovecontentrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hasaugmentedpermissions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Trashinguser
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Thumbnailversion
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Trashedtime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Modifiedbyme
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Permissionids
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items18 items { get; set; }
    }

    public class Items18
    {
        public string type { get; set; }
    }

    public class Imagemediametadata
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties16 properties { get; set; }
    }

    public class Properties16
    {
        public Flashused flashUsed { get; set; }
        public Meteringmode meteringMode { get; set; }
        public Sensor sensor { get; set; }
        public Exposuremode exposureMode { get; set; }
        public Colorspace colorSpace { get; set; }
        public Whitebalance whiteBalance { get; set; }
        public Width width { get; set; }
        public Height height { get; set; }
        public Location location { get; set; }
        public Rotation rotation { get; set; }
        public Time1 time { get; set; }
        public Cameramake cameraMake { get; set; }
        public Cameramodel cameraModel { get; set; }
        public Exposuretime exposureTime { get; set; }
        public Aperture aperture { get; set; }
        public Focallength focalLength { get; set; }
        public Isospeed isoSpeed { get; set; }
        public Exposurebias exposureBias { get; set; }
        public Maxaperturevalue maxApertureValue { get; set; }
        public Subjectdistance subjectDistance { get; set; }
        public Lens lens { get; set; }
    }

    public class Flashused
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Meteringmode
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sensor
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Exposuremode
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Colorspace
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Whitebalance
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Width
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Height
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Location
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties17 properties { get; set; }
    }

    public class Properties17
    {
        public Latitude latitude { get; set; }
        public Longitude longitude { get; set; }
        public Altitude altitude { get; set; }
    }

    public class Latitude
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Longitude
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Altitude
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Rotation
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Time1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cameramake
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cameramodel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Exposuretime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Aperture
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Focallength
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Isospeed
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Exposurebias
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Maxaperturevalue
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Subjectdistance
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Lens
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Videomediametadata
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties18 properties { get; set; }
    }

    public class Properties18
    {
        public Width1 width { get; set; }
        public Height1 height { get; set; }
        public Durationmillis durationMillis { get; set; }
    }

    public class Width1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Height1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Durationmillis
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Shortcutdetails
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties19 properties { get; set; }
    }

    public class Properties19
    {
        public Targetid targetId { get; set; }
        public Targetmimetype targetMimeType { get; set; }
        public Targetresourcekey targetResourceKey { get; set; }
    }

    public class Targetid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Targetmimetype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Targetresourcekey
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Contentrestrictions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items19 items { get; set; }
    }

    public class Items19
    {
        public string _ref { get; set; }
    }

    public class Resourcekey
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Linksharemetadata
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties20 properties { get; set; }
    }

    public class Properties20
    {
        public Securityupdateeligible securityUpdateEligible { get; set; }
        public Securityupdateenabled securityUpdateEnabled { get; set; }
    }

    public class Securityupdateeligible
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Securityupdateenabled
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Labelinfo
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties21 properties { get; set; }
    }

    public class Properties21
    {
        public Labels labels { get; set; }
    }

    public class Labels
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items20 items { get; set; }
    }

    public class Items20
    {
        public string _ref { get; set; }
    }

    public class Sha1checksum
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sha256checksum
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Permission
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties22 properties { get; set; }
    }

    public class Properties22
    {
        public Id4 id { get; set; }
        public Displayname1 displayName { get; set; }
        public Type2 type { get; set; }
        public Kind8 kind { get; set; }
        public Permissiondetails permissionDetails { get; set; }
        public Photolink1 photoLink { get; set; }
        public Emailaddress1 emailAddress { get; set; }
        public Role1 role { get; set; }
        public Allowfilediscovery allowFileDiscovery { get; set; }
        public Domain domain { get; set; }
        public Expirationtime expirationTime { get; set; }
        public Teamdrivepermissiondetails teamDrivePermissionDetails { get; set; }
        public Deleted deleted { get; set; }
        public View view { get; set; }
        public Pendingowner pendingOwner { get; set; }
    }

    public class Id4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayname1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Type2
    {
        public string description { get; set; }
        public Annotations annotations { get; set; }
        public string type { get; set; }
    }

    public class Annotations
    {
        public string[] required { get; set; }
    }

    public class Kind8
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Permissiondetails
    {
        public string description { get; set; }
        public bool readOnly { get; set; }
        public string type { get; set; }
        public Items21 items { get; set; }
    }

    public class Items21
    {
        public string type { get; set; }
        public Properties23 properties { get; set; }
    }

    public class Properties23
    {
        public Permissiontype permissionType { get; set; }
        public Inheritedfrom inheritedFrom { get; set; }
        public Role role { get; set; }
        public Inherited inherited { get; set; }
    }

    public class Permissiontype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Inheritedfrom
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Role
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Inherited
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Photolink1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Emailaddress1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Role1
    {
        public string description { get; set; }
        public Annotations1 annotations { get; set; }
        public string type { get; set; }
    }

    public class Annotations1
    {
        public string[] required { get; set; }
    }

    public class Allowfilediscovery
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Domain
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Expirationtime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Teamdrivepermissiondetails
    {
        public string description { get; set; }
        public bool readOnly { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
        public Items22 items { get; set; }
    }

    public class Items22
    {
        public string type { get; set; }
        public Properties24 properties { get; set; }
    }

    public class Properties24
    {
        public Teamdrivepermissiontype teamDrivePermissionType { get; set; }
        public Inheritedfrom1 inheritedFrom { get; set; }
        public Role2 role { get; set; }
        public Inherited1 inherited { get; set; }
    }

    public class Teamdrivepermissiontype
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Inheritedfrom1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Role2
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Inherited1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Deleted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class View
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Pendingowner
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Contentrestriction
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties25 properties { get; set; }
    }

    public class Properties25
    {
        public Readonly readOnly { get; set; }
        public Reason reason { get; set; }
        public Type3 type { get; set; }
        public Restrictinguser restrictingUser { get; set; }
        public Restrictiontime restrictionTime { get; set; }
        public Ownerrestricted ownerRestricted { get; set; }
        public Systemrestricted systemRestricted { get; set; }
    }

    public class Readonly
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Reason
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Type3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Restrictinguser
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Restrictiontime
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Ownerrestricted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Systemrestricted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Label
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties26 properties { get; set; }
    }

    public class Properties26
    {
        public Id5 id { get; set; }
        public Revisionid3 revisionId { get; set; }
        public Kind9 kind { get; set; }
        public Fields1 fields { get; set; }
    }

    public class Id5
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Revisionid3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind9
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Fields1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties6 additionalProperties { get; set; }
    }

    public class Additionalproperties6
    {
        public string _ref { get; set; }
    }

    public class Labelfield
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties27 properties { get; set; }
    }

    public class Properties27
    {
        public Kind10 kind { get; set; }
        public Id6 id { get; set; }
        public Valuetype valueType { get; set; }
        public Datestring dateString { get; set; }
        public Integer integer { get; set; }
        public Selection selection { get; set; }
        public Text text { get; set; }
        public User2 user { get; set; }
    }

    public class Kind10
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Id6
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Valuetype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Datestring
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items23 items { get; set; }
    }

    public class Items23
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Integer
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items24 items { get; set; }
    }

    public class Items24
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Selection
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items25 items { get; set; }
    }

    public class Items25
    {
        public string type { get; set; }
    }

    public class Text
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items26 items { get; set; }
    }

    public class Items26
    {
        public string type { get; set; }
    }

    public class User2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items27 items { get; set; }
    }

    public class Items27
    {
        public string _ref { get; set; }
    }

    public class Teamdrive1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties28 properties { get; set; }
    }

    public class Properties28
    {
        public Id7 id { get; set; }
        public Name2 name { get; set; }
        public Colorrgb2 colorRgb { get; set; }
        public Kind11 kind { get; set; }
        public Backgroundimagelink2 backgroundImageLink { get; set; }
        public Capabilities1 capabilities { get; set; }
        public Themeid themeId { get; set; }
        public Backgroundimagefile backgroundImageFile { get; set; }
        public Createdtime1 createdTime { get; set; }
        public Restrictions restrictions { get; set; }
        public Orgunitid orgUnitId { get; set; }
    }

    public class Id7
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Name2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Colorrgb2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind11
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagelink2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Capabilities1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties29 properties { get; set; }
    }

    public class Properties29
    {
        public Canaddchildren1 canAddChildren { get; set; }
        public Cancomment1 canComment { get; set; }
        public Cancopy1 canCopy { get; set; }
        public Candeleteteamdrive canDeleteTeamDrive { get; set; }
        public Candownload1 canDownload { get; set; }
        public Canedit1 canEdit { get; set; }
        public Canlistchildren1 canListChildren { get; set; }
        public Canmanagemembers canManageMembers { get; set; }
        public Canreadrevisions1 canReadRevisions { get; set; }
        public Canremovechildren1 canRemoveChildren { get; set; }
        public Canrename1 canRename { get; set; }
        public Canrenameteamdrive canRenameTeamDrive { get; set; }
        public Canchangeteamdrivebackground canChangeTeamDriveBackground { get; set; }
        public Canshare1 canShare { get; set; }
        public Canchangecopyrequireswriterpermissionrestriction canChangeCopyRequiresWriterPermissionRestriction { get; set; }
        public Canchangedomainusersonlyrestriction canChangeDomainUsersOnlyRestriction { get; set; }
        public Canchangesharingfoldersrequiresorganizerpermissionrestriction canChangeSharingFoldersRequiresOrganizerPermissionRestriction { get; set; }
        public Canchangeteammembersonlyrestriction canChangeTeamMembersOnlyRestriction { get; set; }
        public Candeletechildren1 canDeleteChildren { get; set; }
        public Cantrashchildren1 canTrashChildren { get; set; }
        public Canresetteamdriverestrictions canResetTeamDriveRestrictions { get; set; }
    }

    public class Canaddchildren1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancomment1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancopy1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candeleteteamdrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candownload1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canedit1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canlistchildren1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmanagemembers
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreadrevisions1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canremovechildren1
    {
        public string description { get; set; }
        public bool deprecated { get; set; }
        public string type { get; set; }
    }

    public class Canrename1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canrenameteamdrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangeteamdrivebackground
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canshare1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangecopyrequireswriterpermissionrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangedomainusersonlyrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangesharingfoldersrequiresorganizerpermissionrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangeteammembersonlyrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candeletechildren1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cantrashchildren1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canresetteamdriverestrictions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Themeid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagefile
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties30 properties { get; set; }
    }

    public class Properties30
    {
        public Id8 id { get; set; }
        public Xcoordinate xCoordinate { get; set; }
        public Ycoordinate yCoordinate { get; set; }
        public Width2 width { get; set; }
    }

    public class Id8
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Xcoordinate
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Ycoordinate
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Width2
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdtime1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Restrictions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties31 properties { get; set; }
    }

    public class Properties31
    {
        public Copyrequireswriterpermission1 copyRequiresWriterPermission { get; set; }
        public Domainusersonly domainUsersOnly { get; set; }
        public Teammembersonly teamMembersOnly { get; set; }
        public Adminmanagedrestrictions adminManagedRestrictions { get; set; }
        public Sharingfoldersrequiresorganizerpermission sharingFoldersRequiresOrganizerPermission { get; set; }
    }

    public class Copyrequireswriterpermission1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Domainusersonly
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Teammembersonly
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Adminmanagedrestrictions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sharingfoldersrequiresorganizerpermission
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Orgunitid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Drive1
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties32 properties { get; set; }
    }

    public class Properties32
    {
        public Id9 id { get; set; }
        public Name3 name { get; set; }
        public Colorrgb3 colorRgb { get; set; }
        public Kind12 kind { get; set; }
        public Backgroundimagelink3 backgroundImageLink { get; set; }
        public Capabilities2 capabilities { get; set; }
        public Themeid1 themeId { get; set; }
        public Backgroundimagefile1 backgroundImageFile { get; set; }
        public Createdtime2 createdTime { get; set; }
        public Hidden hidden { get; set; }
        public Restrictions1 restrictions { get; set; }
        public Orgunitid1 orgUnitId { get; set; }
    }

    public class Id9
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Name3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Colorrgb3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind12
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagelink3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Capabilities2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties33 properties { get; set; }
    }

    public class Properties33
    {
        public Canaddchildren2 canAddChildren { get; set; }
        public Cancomment2 canComment { get; set; }
        public Cancopy2 canCopy { get; set; }
        public Candeletedrive canDeleteDrive { get; set; }
        public Candownload2 canDownload { get; set; }
        public Canedit2 canEdit { get; set; }
        public Canlistchildren2 canListChildren { get; set; }
        public Canmanagemembers1 canManageMembers { get; set; }
        public Canreadrevisions2 canReadRevisions { get; set; }
        public Canrename2 canRename { get; set; }
        public Canrenamedrive canRenameDrive { get; set; }
        public Canchangedrivebackground canChangeDriveBackground { get; set; }
        public Canshare2 canShare { get; set; }
        public Canchangecopyrequireswriterpermissionrestriction1 canChangeCopyRequiresWriterPermissionRestriction { get; set; }
        public Canchangedomainusersonlyrestriction1 canChangeDomainUsersOnlyRestriction { get; set; }
        public Canchangedrivemembersonlyrestriction canChangeDriveMembersOnlyRestriction { get; set; }
        public Canchangesharingfoldersrequiresorganizerpermissionrestriction1 canChangeSharingFoldersRequiresOrganizerPermissionRestriction { get; set; }
        public Canresetdriverestrictions canResetDriveRestrictions { get; set; }
        public Candeletechildren2 canDeleteChildren { get; set; }
        public Cantrashchildren2 canTrashChildren { get; set; }
    }

    public class Canaddchildren2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancomment2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cancopy2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candeletedrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candownload2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canedit2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canlistchildren2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canmanagemembers1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canreadrevisions2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canrename2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canrenamedrive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangedrivebackground
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canshare2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangecopyrequireswriterpermissionrestriction1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangedomainusersonlyrestriction1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangedrivemembersonlyrestriction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canchangesharingfoldersrequiresorganizerpermissionrestriction1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canresetdriverestrictions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Candeletechildren2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Cantrashchildren2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Themeid1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Backgroundimagefile1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties34 properties { get; set; }
    }

    public class Properties34
    {
        public Id10 id { get; set; }
        public Xcoordinate1 xCoordinate { get; set; }
        public Ycoordinate1 yCoordinate { get; set; }
        public Width3 width { get; set; }
    }

    public class Id10
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Xcoordinate1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Ycoordinate1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Width3
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Createdtime2
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Hidden
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Restrictions1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties35 properties { get; set; }
    }

    public class Properties35
    {
        public Copyrequireswriterpermission2 copyRequiresWriterPermission { get; set; }
        public Domainusersonly1 domainUsersOnly { get; set; }
        public Drivemembersonly driveMembersOnly { get; set; }
        public Adminmanagedrestrictions1 adminManagedRestrictions { get; set; }
        public Sharingfoldersrequiresorganizerpermission1 sharingFoldersRequiresOrganizerPermission { get; set; }
    }

    public class Copyrequireswriterpermission2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Domainusersonly1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Drivemembersonly
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Adminmanagedrestrictions1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sharingfoldersrequiresorganizerpermission1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Orgunitid1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Channel
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties36 properties { get; set; }
    }

    public class Properties36
    {
        public Payload payload { get; set; }
        public Id11 id { get; set; }
        public Resourceid resourceId { get; set; }
        public Resourceuri resourceUri { get; set; }
        public Token token { get; set; }
        public Expiration expiration { get; set; }
        public Type4 type { get; set; }
        public Address address { get; set; }
        public Params _params { get; set; }
        public Kind13 kind { get; set; }
    }

    public class Payload
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Id11
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Resourceid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Resourceuri
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Token
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Expiration
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Type4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Address
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Params
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties7 additionalProperties { get; set; }
    }

    public class Additionalproperties7
    {
        public string type { get; set; }
    }

    public class Kind13
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Comment
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties37 properties { get; set; }
    }

    public class Properties37
    {
        public Id12 id { get; set; }
        public Kind14 kind { get; set; }
        public Createdtime3 createdTime { get; set; }
        public Modifiedtime1 modifiedTime { get; set; }
        public Resolved resolved { get; set; }
        public Anchor anchor { get; set; }
        public Replies1 replies { get; set; }
        public Author author { get; set; }
        public Deleted1 deleted { get; set; }
        public Htmlcontent htmlContent { get; set; }
        public Content content { get; set; }
        public Quotedfilecontent quotedFileContent { get; set; }
    }

    public class Id12
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind14
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Createdtime3
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Modifiedtime1
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Resolved
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Anchor
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Replies1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items28 items { get; set; }
    }

    public class Items28
    {
        public string _ref { get; set; }
    }

    public class Author
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Deleted1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Htmlcontent
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Content
    {
        public string description { get; set; }
        public Annotations2 annotations { get; set; }
        public string type { get; set; }
    }

    public class Annotations2
    {
        public string[] required { get; set; }
    }

    public class Quotedfilecontent
    {
        public string description { get; set; }
        public string type { get; set; }
        public Properties38 properties { get; set; }
    }

    public class Properties38
    {
        public Mimetype3 mimeType { get; set; }
        public Value value { get; set; }
    }

    public class Mimetype3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Value
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Reply
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties39 properties { get; set; }
    }

    public class Properties39
    {
        public Id13 id { get; set; }
        public Kind15 kind { get; set; }
        public Createdtime4 createdTime { get; set; }
        public Modifiedtime2 modifiedTime { get; set; }
        public Action action { get; set; }
        public Author1 author { get; set; }
        public Deleted2 deleted { get; set; }
        public Htmlcontent1 htmlContent { get; set; }
        public Content1 content { get; set; }
    }

    public class Id13
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind15
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Createdtime4
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Modifiedtime2
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Action
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Author1
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Deleted2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Htmlcontent1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Content1
    {
        public string description { get; set; }
        public Annotations3 annotations { get; set; }
        public string type { get; set; }
    }

    public class Annotations3
    {
        public string[] required { get; set; }
    }

    public class Commentlist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties40 properties { get; set; }
    }

    public class Properties40
    {
        public Kind16 kind { get; set; }
        public Comments1 comments { get; set; }
        public Nextpagetoken1 nextPageToken { get; set; }
    }

    public class Kind16
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Comments1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items29 items { get; set; }
    }

    public class Items29
    {
        public string _ref { get; set; }
    }

    public class Nextpagetoken1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Drivelist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties41 properties { get; set; }
    }

    public class Properties41
    {
        public Nextpagetoken2 nextPageToken { get; set; }
        public Kind17 kind { get; set; }
        public Drives1 drives { get; set; }
    }

    public class Nextpagetoken2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind17
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Drives1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items30 items { get; set; }
    }

    public class Items30
    {
        public string _ref { get; set; }
    }

    public class Generatedids
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties42 properties { get; set; }
    }

    public class Properties42
    {
        public Ids ids { get; set; }
        public Space1 space { get; set; }
        public Kind18 kind { get; set; }
    }

    public class Ids
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items31 items { get; set; }
    }

    public class Items31
    {
        public string type { get; set; }
    }

    public class Space1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind18
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Filelist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties43 properties { get; set; }
    }

    public class Properties43
    {
        public Nextpagetoken3 nextPageToken { get; set; }
        public Kind19 kind { get; set; }
        public Incompletesearch incompleteSearch { get; set; }
        public Files1 files { get; set; }
    }

    public class Nextpagetoken3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind19
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Incompletesearch
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Files1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items32 items { get; set; }
    }

    public class Items32
    {
        public string _ref { get; set; }
    }

    public class Labellist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties44 properties { get; set; }
    }

    public class Properties44
    {
        public Labels1 labels { get; set; }
        public Nextpagetoken4 nextPageToken { get; set; }
        public Kind20 kind { get; set; }
    }

    public class Labels1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items33 items { get; set; }
    }

    public class Items33
    {
        public string _ref { get; set; }
    }

    public class Nextpagetoken4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind20
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Modifylabelsrequest
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties45 properties { get; set; }
    }

    public class Properties45
    {
        public Labelmodifications labelModifications { get; set; }
        public Kind21 kind { get; set; }
    }

    public class Labelmodifications
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items34 items { get; set; }
    }

    public class Items34
    {
        public string _ref { get; set; }
    }

    public class Kind21
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Labelmodification
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties46 properties { get; set; }
    }

    public class Properties46
    {
        public Labelid labelId { get; set; }
        public Fieldmodifications fieldModifications { get; set; }
        public Removelabel removeLabel { get; set; }
        public Kind22 kind { get; set; }
    }

    public class Labelid
    {
        public string description { get; set; }
        public Annotations4 annotations { get; set; }
        public string type { get; set; }
    }

    public class Annotations4
    {
        public string[] required { get; set; }
    }

    public class Fieldmodifications
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items35 items { get; set; }
    }

    public class Items35
    {
        public string _ref { get; set; }
    }

    public class Removelabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind22
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Labelfieldmodification
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties47 properties { get; set; }
    }

    public class Properties47
    {
        public Fieldid fieldId { get; set; }
        public Kind23 kind { get; set; }
        public Setdatevalues setDateValues { get; set; }
        public Settextvalues setTextValues { get; set; }
        public Setselectionvalues setSelectionValues { get; set; }
        public Setintegervalues setIntegerValues { get; set; }
        public Setuservalues setUserValues { get; set; }
        public Unsetvalues unsetValues { get; set; }
    }

    public class Fieldid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind23
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Setdatevalues
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items36 items { get; set; }
    }

    public class Items36
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Settextvalues
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items37 items { get; set; }
    }

    public class Items37
    {
        public string type { get; set; }
    }

    public class Setselectionvalues
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items38 items { get; set; }
    }

    public class Items38
    {
        public string type { get; set; }
    }

    public class Setintegervalues
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items39 items { get; set; }
    }

    public class Items39
    {
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Setuservalues
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items40 items { get; set; }
    }

    public class Items40
    {
        public string type { get; set; }
    }

    public class Unsetvalues
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Modifylabelsresponse
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties48 properties { get; set; }
    }

    public class Properties48
    {
        public Modifiedlabels modifiedLabels { get; set; }
        public Kind24 kind { get; set; }
    }

    public class Modifiedlabels
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items41 items { get; set; }
    }

    public class Items41
    {
        public string _ref { get; set; }
    }

    public class Kind24
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Permissionlist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties49 properties { get; set; }
    }

    public class Properties49
    {
        public Nextpagetoken5 nextPageToken { get; set; }
        public Kind25 kind { get; set; }
        public Permissions2 permissions { get; set; }
    }

    public class Nextpagetoken5
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind25
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Permissions2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items42 items { get; set; }
    }

    public class Items42
    {
        public string _ref { get; set; }
    }

    public class Replylist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties50 properties { get; set; }
    }

    public class Properties50
    {
        public Kind26 kind { get; set; }
        public Replies2 replies { get; set; }
        public Nextpagetoken6 nextPageToken { get; set; }
    }

    public class Kind26
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Replies2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items43 items { get; set; }
    }

    public class Items43
    {
        public string _ref { get; set; }
    }

    public class Nextpagetoken6
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Revision
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties51 properties { get; set; }
    }

    public class Properties51
    {
        public Id14 id { get; set; }
        public Mimetype4 mimeType { get; set; }
        public Kind27 kind { get; set; }
        public Published published { get; set; }
        public Exportlinks1 exportLinks { get; set; }
        public Keepforever keepForever { get; set; }
        public Md5checksum1 md5Checksum { get; set; }
        public Modifiedtime3 modifiedTime { get; set; }
        public Publishauto publishAuto { get; set; }
        public Publishedoutsidedomain publishedOutsideDomain { get; set; }
        public Publishedlink publishedLink { get; set; }
        public Size2 size { get; set; }
        public Originalfilename1 originalFilename { get; set; }
        public Lastmodifyinguser1 lastModifyingUser { get; set; }
    }

    public class Id14
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Mimetype4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind27
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Published
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Exportlinks1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties8 additionalProperties { get; set; }
    }

    public class Additionalproperties8
    {
        public string type { get; set; }
    }

    public class Keepforever
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Md5checksum1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Modifiedtime3
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Publishauto
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Publishedoutsidedomain
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Publishedlink
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Size2
    {
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Originalfilename1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Lastmodifyinguser1
    {
        public string description { get; set; }
        public string _ref { get; set; }
    }

    public class Revisionlist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties52 properties { get; set; }
    }

    public class Properties52
    {
        public Nextpagetoken7 nextPageToken { get; set; }
        public Kind28 kind { get; set; }
        public Revisions1 revisions { get; set; }
    }

    public class Nextpagetoken7
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind28
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Revisions1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items44 items { get; set; }
    }

    public class Items44
    {
        public string _ref { get; set; }
    }

    public class Teamdrivelist
    {
        public string id { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Properties53 properties { get; set; }
    }

    public class Properties53
    {
        public Nextpagetoken8 nextPageToken { get; set; }
        public Kind29 kind { get; set; }
        public Teamdrives1 teamDrives { get; set; }
    }

    public class Nextpagetoken8
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Kind29
    {
        public string description { get; set; }
        public string _default { get; set; }
        public string type { get; set; }
    }

    public class Teamdrives1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items45 items { get; set; }
    }

    public class Items45
    {
        public string _ref { get; set; }
    }
}
