# Implement Azure Security
- What is Azure AD?
- Quick look at Azure AD users
- Role Based Access Control
- Introduction to Application Object
  - Use Case: Read data from Storage account using application object
  - Create app object and give rights to it on storage account - Reader, Storage Blob Data Reader
  - Refer:
    - 224-azure-blob-storage-using-application-object
- What is the Azure Key Vault Service?
- Azure Key Vault - What is a service principal
- Azure Key vault - Secrets
- Azure Key vault - Encryption keys
- Azure VM Disk Encryption
- Azure Key Vault Secrets - Using Application Objects
  - Refer
    - 227-azure-key-vault-secrets-using-application-object
  - Create app object, give rights to app object on key vault, create secret in key vault, update app object values in source code and run it

- Managed Service Identity
  - 231-managed-identities-example-on-not-using-managed-identies
  - 232-managed-identities-using-identities
  - 233-azure-key-vault-secrets-using-managed-identity
  - 234-managed-identity-getting-the-access-token

- Primer to OAuth and OpenID Connect - History of Authentication
- Primer to OAuth and OpenID Connect - Identity Provider
- What is OAuth?
- OAuth 2.0 Authorization Code Flow
- OAuth 2.0 Implicit Flow
  - When both auth code and access token both comes from the broser
  - Useful when all code is client side - Angular JS, Java script etc
- OAuth 2.0 - Overview
- OAuth with Azure AD - Overview
- Quick Look into OAuth when logging into Azure
- OAuth 2.0 for ASP.Net Core
- The Access Tokens
- OAuth 2.0 - Accessing Blob storage
- Azure AD - Multi-Factor Authentication
- OpenID Connect
  - Built on the OAuth 2.0 protocol and uses an additional JSON Web Token (JWT)
  - An identity layer built on top of the OAuth 2.0 framework
  - It allows third-party applications to verify the identity of the end-user and to obtain basic user profile information.
  - It is not controlled by any one website or service provider
  You control how much personal information you choose to share with websites that accept OpenIDs