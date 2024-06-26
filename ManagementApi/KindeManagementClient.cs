using Clinically.Kinde.Authentication.ManagementApi.Api;
using Clinically.Kinde.Authentication.ManagementApi.Client;

namespace Clinically.Kinde.Authentication.ManagementApi;

public class KindeManagementClient : IDisposable
{
    private Configuration? _clientConfiguration;
    private string? _authToken;
    private HttpClient? _client;
    private HttpClientHandler? _clientHandler;
    private readonly IHttpClientFactory _httpClientFactory;
    private readonly KindeManagementApiAuthenticationHelper _authenticationHelper;
    private readonly KindeAuthenticationOptions _options;

    public KindeManagementClient(IHttpClientFactory httpClientFactory,
        KindeManagementApiAuthenticationHelper authenticationHelper,
        KindeAuthenticationOptions options)
    {
        _httpClientFactory = httpClientFactory;
        _authenticationHelper = authenticationHelper;
        _options = options;
        _ = authenticationHelper.GetAuthTokenAsync().Result; // Load when created so it is available
    }

    private async Task<Configuration> GetConfiguration()
    {
        if (_clientConfiguration is not null) return _clientConfiguration;
        ArgumentException.ThrowIfNullOrEmpty(_options.Domain, nameof(_options.Domain));
        
        if (string.IsNullOrEmpty(_authToken)) _authToken = await _authenticationHelper.GetAuthTokenAsync().ConfigureAwait(false);
        ArgumentException.ThrowIfNullOrEmpty(_authToken, nameof(_authToken));
        
        _clientConfiguration = new Configuration
        {
            BasePath = _options.Domain,
            AccessToken = _authToken
        };
        
        return _clientConfiguration;
    }

    private HttpClient GetClient()
    {
        if (_client is not null) return _client;

        _client = _httpClientFactory.CreateClient();

        return _client;
    }
    
    private HttpClientHandler GetClientHandler()
    {
        if (_clientHandler is not null) return _clientHandler;

        _clientHandler = new HttpClientHandler();
        return _clientHandler;
    }

    private OrganizationsApi? _organizationsApi;
    public OrganizationsApi Organizations
    {
        get
        {
            if (_organizationsApi is not null) return _organizationsApi;
            _organizationsApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _organizationsApi;
        }
    }

    private UsersApi? _usersApi;
    public UsersApi Users
    {
        get
        {
            if (_usersApi is not null) return _usersApi;
            _usersApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _usersApi;
        }
    }

    private RolesApi? _rolesApi;
    public RolesApi Roles
    {
        get
        {
            if (_rolesApi is not null) return _rolesApi;
            _rolesApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _rolesApi;
        }
    }
    
    private PermissionsApi? _permissionsApi;
    public PermissionsApi Permissions
    {
        get
        {
            if (_permissionsApi is not null) return _permissionsApi;
            _permissionsApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _permissionsApi;
        }
    }
    
    private FeatureFlagsApi? _featureFlagsApi;
    public FeatureFlagsApi FeatureFlags
    {
        get
        {
            if (_featureFlagsApi is not null) return _featureFlagsApi;
            _featureFlagsApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _featureFlagsApi;
        }
    }
    
    private PropertiesApi? _propertiesApi;
    public PropertiesApi Properties
    {
        get
        {
            if (_propertiesApi is not null) return _propertiesApi;
            _propertiesApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _propertiesApi;
        }
    }

    private PropertyCategoriesApi? _propertyCategoriesApi;
    public PropertyCategoriesApi PropertyCategories
    {
        get
        {
            if (_propertyCategoriesApi is not null) return _propertyCategoriesApi;
            _propertyCategoriesApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _propertyCategoriesApi;
        }
    }
    
    private IndustriesApi? _industriesApi;
    public IndustriesApi Industries
    {
        get
        {
            if (_industriesApi is not null) return _industriesApi;
            _industriesApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _industriesApi;
        }
    }


    private SubscribersApi? _subscribersApi;

    public SubscribersApi Subscribers
    {
        get
        {
            if (_subscribersApi is not null) return _subscribersApi;
            _subscribersApi = new(GetClient(), GetConfiguration().Result, GetClientHandler());
            return _subscribersApi;
        }
    }
    
    public void Dispose()
    {
        _client?.Dispose();
        _clientHandler?.Dispose();
    }
}

