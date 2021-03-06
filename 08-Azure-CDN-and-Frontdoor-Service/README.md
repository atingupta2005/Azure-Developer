## Azure CDN
- Azure Content Delivery Network - Introduction
- Azure Content Delivery Network Cache
- Azure Content Delivery Network caching - Query strings
- What is a content delivery network on Azure?
- Create an Azure CDN profile and endpoint
  - Create resource - CDN Profile
  - Add Endpoint
  - Wait for 30 min so that cache can be replicated
  - Take endpoint host name and open in browser
  - Use Endpoint URL in Postman and notice that it takes less time from 2nd request onwards
  - Use Webapp URL in Postman and notice that it takes same time for each request
- Add Azure CDN to an Azure App Service web app
- Add a custom domain to your endpoint
- Set Azure CDN caching rules
  - Cache Response directives
    - Used to specify browser caching policies
    - Policies include how a resource is cached, where it’s cached and its maximum age before expiring
    - Used in Response Header of the webpage with the key - cache-control
    - Max-Age: Defines, in seconds, the amount of time it takes for a cached copy of a resource to expire.
    - No-Cache: Means that a browser may cache a response, but must first submit a validation request to an origin server.
    - No-Store: Means browsers aren’t allowed to cache a response and must pull it from the server each time it’s requested. This setting is usually used for sensitive data, such as personal banking details.
    - Public: Indicates that a resource can be cached by any
    - Private: Indicates that a resource is user specific—it can still be cached, but only on a client device. For example, a web page response marked as private can be cached by a desktop browser, but not a content delivery network (CDN).

  - Setting in CDN profile
    - Bypass Cache
      - Do not cache even if cache-control exists
    - Override
      - Set the cache time even if the server sets the cache-control settings
    - Set if missing
      - If the cache-control setting is present, respect the setting. Set if not present


## Front Door Service
- Azure Front Door Service
  - A routing service that accelerates application performance based on the endpoint performance
  - Will route traffic to the fastest and most available application backend
  - Can route traffic to backend servers based on the URL paths of the servers
  - Can configure more than one website on the same front door configuration
  - Session affinity: keep a user session attached to the same application backend
  -
- Create Front Door Service
  - In Visual Studio Create 2 web apps and change home page content. Deploy in East US region and West US region each
  - Create resource - Front Door
  - Weight - 100: Send all traffic to this endpoint
- Wait to 2 min and open URL of front door service on browser
- Notice its directing to traffic to priority one
- Stop that web app
- Wait to 2 min and open URL of front door service on browser
- Notice its directing to traffic to priority two


- Transient faults
  - Transient faults can occur while working with Azure Services
  - Reasons:
    - Shared environment
    - The underlying hardware at Azure
  - Our application should be able to handle these Transient Faults
  - Our application should be able to retry an operation.
  - .Net SDK for some services has the facility to handle Transient faults. Example - CosmosDB
  - Example:
    - The DocumentClient class will automatically retry failed attempts
      - You can set the maximum wait time for each retry and number of retries
