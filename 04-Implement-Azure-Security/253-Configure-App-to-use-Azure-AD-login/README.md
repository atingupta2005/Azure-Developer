# Configure-App-to-use-Azure-AD-login
- Create Azure Web App - ASP.Net 3.1
- Create new app registration in AAD
  - Redirect URI:
    - <app-url>/.auth/login/aad/callback
  - Open Authentication from left
  - Under Implicit grant, enable ID tokens
  - From left select Expose an API > Set
  - Paste in the URL of your App Service app
  - Select Add a scope
    - In Scope name, enter user_impersonation.
    -

## Enable Azure Active Directory in your App Service app
- Navigate to your app
- Select Authentication, Click Add identity provider\Microsoft
- App registration type: Existing

- Notice Configuration settings of the Web app
- Browse Web App
