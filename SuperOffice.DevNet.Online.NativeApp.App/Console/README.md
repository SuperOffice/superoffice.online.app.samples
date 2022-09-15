+-----------------------+
|  Sign in with OIDC    |
+-----------------------+

Press any key to sign in...
[08:59:03 Verbose] IdentityModel.OidcClient.OidcClient
LoginAsync

[08:59:03 Information] IdentityModel.OidcClient.OidcClient
Starting authentication request.

[08:59:03 Verbose] IdentityModel.OidcClient.OidcClient
EnsureProviderInformation

[08:59:04 Debug] IdentityModel.OidcClient.OidcClient
Successfully loaded discovery document

[08:59:04 Debug] IdentityModel.OidcClient.OidcClient
Loaded keyset from "https://sod.superoffice.com/login/.well-known/jwks"

[08:59:04 Debug] IdentityModel.OidcClient.OidcClient
Keyset contains the following kids: ["16B7FB8C3F9AB06885A800C64E64C97C4AB5E98C"]

[08:59:04 Verbose] IdentityModel.OidcClient.OidcClient
Effective options:

[08:59:04 Verbose] IdentityModel.OidcClient.OidcClient
{
  "Authority": "https://sod.superoffice.com/login/",
  "ProviderInformation": {
    "IssuerName": "https://sod.superoffice.com",
    "KeySet": {
      "Keys": [
        {
          "alg": "RS256",
          "e": "AQAB",
          "key_ops": [],
          "kid": "16B7FB8C3F9AB06885A800C64E64C97C4AB5E98C",
          "kty": "RSA",
          "n": "sY6PrEDYl7VuiTaFDCnTKYwcqq2y5J_vttZWf8QCV9oOXsI77lhCqO71SavHaoRQe3gkXsWIbgpv3hwmYyDiOiqf6XdJxVarmrvvjmXDQDl9mgUZ4visDhxNPFyWjsMiLQpVUlpO73ASy7-F_cuBCTQ4g9YDX7YBh94WL-EvA9ciB6ZtRsRS945ezrDMq8Q38RjpemXekc7ObwPXOX7PzFkGcdMWLHNm6Ktj2OFIqkuJYBRmOr85IlKcuek4x0LeVDj24Min_HG-4MqVpvDzF4m2Ib5AgFI3Akl9p7Z-dCSq6KTphu8hO_LmW-E93kz6weG7dZxt7otFps0j09py-Q",
          "use": "sig",
          "x5c": [
            "MIIDrTCCApUCAQowDQYJKoZIhvcNAQEFBQAwgZQxCzAJBgNVBAYTAk5PMQ0wCwYDVQQIDARPc2xvMQ0wCwYDVQQHDARPc2xvMRcwFQYDVQQKDA5TdXBlck9mZmljZSBBUzEqMCgGA1UEAwwhU3VwZXJPZmZpY2UgT25saW5lIERldmVsb3BtZW50IENBMSIwIAYJKoZIhvcNAQkBFhNzZGtAc3VwZXJvZmZpY2UuY29tMCAXDTEzMDkwMzExNDIyN1oYDzIxMTMwODEwMTE0MjI3WjCBoTELMAkGA1UEBhMCTk8xDTALBgNVBAgMBE9zbG8xDTALBgNVBAcMBE9zbG8xFzAVBgNVBAoMDlN1cGVyT2ZmaWNlIEFTMTcwNQYDVQQDDC5TdXBlck9mZmljZSBPbmxpbmUgRGV2ZWxvcG1lbnQgRmVkZXJhdGVkIExvZ2luMSIwIAYJKoZIhvcNAQkBFhNzZGtAc3VwZXJvZmZpY2UuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsY6PrEDYl7VuiTaFDCnTKYwcqq2y5J/vttZWf8QCV9oOXsI77lhCqO71SavHaoRQe3gkXsWIbgpv3hwmYyDiOiqf6XdJxVarmrvvjmXDQDl9mgUZ4visDhxNPFyWjsMiLQpVUlpO73ASy7+F/cuBCTQ4g9YDX7YBh94WL+EvA9ciB6ZtRsRS945ezrDMq8Q38RjpemXekc7ObwPXOX7PzFkGcdMWLHNm6Ktj2OFIqkuJYBRmOr85IlKcuek4x0LeVDj24Min/HG+4MqVpvDzF4m2Ib5AgFI3Akl9p7Z+dCSq6KTphu8hO/LmW+E93kz6weG7dZxt7otFps0j09py+QIDAQABMA0GCSqGSIb3DQEBBQUAA4IBAQCrx88qTpQlM27TPd3i/qHt182+Gy40klx2l9ho1PW8EZqKJTZQD4+guHGLrMzYLTl0rDWcqbjVbYjZKw6xoSGAFOlKjoBCZqkiVhFyiOeXYpg4F3rNCau944nNkLr+XJ+84B8ieruGDDcf0gCN33WXmIvG69I4PmLJB9RbdVaTvmPdwonPiIZ0+i60L9w8IW8pL4EM7upIiRkpBrHMhHJr/DhmDV+P+nO8GuyYKXmgbkeTtVvskwRbO6j/USEjTFdCcAj0WHpKYAKxvgqpdfZsdfo2JAnnuv83BbuAkYxZWPip7kEMcNEPGpLp7CBr58g5JlvWr1pSsm0NNXEER3E2"
          ],
          "x5t": "Frf7jD-asGiFqADGTmTJfEq16Yw",
          "KeySize": 2048,
          "HasPrivateKey": false
        }
      ]
    },
    "TokenEndpoint": "https://sod.superoffice.com/login/common/oauth/tokens",
    "AuthorizeEndpoint": "https://sod.superoffice.com/login/common/oauth/authorize",
    "EndSessionEndpoint": "https://sod.superoffice.com/login/logout",
    "TokenEndPointAuthenticationMethods": [
      "client_secret_post",
      "client_secret_basic"
    ],
    "SupportsUserInfo": false,
    "SupportsEndSession": true
  },
  "ClientId": "8cd4fc8710c121d8245c9d8ef59e1086",
  "ClientSecret": "a24bf7afdb4fca3ebdddab63f7e78a58",
  "Scope": "openid",
  "RedirectUri": "http://127.0.0.1:65499",
  "BrowserTimeout": "00:00:00",
  "ClockSkew": "00:05:00",
  "RefreshDiscoveryDocumentForLogin": true,
  "RefreshDiscoveryOnSignatureFailure": false,
  "ResponseMode": "Redirect",
  "LoadProfile": false,
  "FilterClaims": false,
  "Flow": "AuthorizationCode",
  "BackchannelTimeout": "00:00:30",
  "TokenClientCredentialStyle": "PostBody",
  "Policy": {
    "Discovery": {
      "LoopbackAddresses": [
        "localhost",
        "127.0.0.1"
      ],
      "Authority": "https://sod.superoffice.com/login",
      "AuthorityValidationStrategy": {},
      "RequireHttps": true,
      "AllowHttpOnLoopback": true,
      "ValidateIssuerName": false,
      "ValidateEndpoints": true,
      "EndpointValidationExcludeList": [],
      "AdditionalEndpointBaseAddresses": [],
      "RequireKeySet": true
    },
    "RequireAuthorizationCodeHash": true,
    "RequireAccessTokenHash": false,
    "RequireIdentityTokenOnRefreshTokenResponse": false,
    "RequireIdentityTokenSignature": true,
    "ValidateTokenIssuerName": false,
    "ValidSignatureAlgorithms": [
      "RS256",
      "RS384",
      "RS512",
      "PS256",
      "PS384",
      "PS512",
      "ES256"
    ]
  },
  "FilteredClaims": [
    "iss",
    "exp",
    "nbf",
    "aud",
    "nonce",
    "iat",
    "auth_time",
    "c_hash",
    "at_hash"
  ]
}

[08:59:04 Verbose] IdentityModel.OidcClient.AuthorizeClient
AuthorizeAsync

[08:59:04 Verbose] IdentityModel.OidcClient.AuthorizeClient
CreateAuthorizeStateAsync

[08:59:04 Verbose] IdentityModel.OidcClient.CryptoHelper
CreatePkceData

[08:59:04 Verbose] IdentityModel.OidcClient.CryptoHelper
CreateNonce

[08:59:04 Verbose] IdentityModel.OidcClient.CryptoHelper
CreateState

[08:59:04 Verbose] IdentityModel.OidcClient.AuthorizeClient
CreateAuthorizeUrl

[08:59:04 Verbose] IdentityModel.OidcClient.AuthorizeClient
CreateAuthorizeParameters

[08:59:04 Debug] IdentityModel.OidcClient.AuthorizeClient
{
  "StartUrl": "https://sod.superoffice.com/login/common/oauth/authorize?response_type=code&nonce=smTo3BqVY0GyDAxm2Xe5iA&state=EH9TWd_DVV1VCUR_zzvtSQ&code_challenge=0ALTTAOZIoFMw66X_1S0BLKl_eUQfAXeQDJvbuhssss&code_challenge_method=S256&client_id=8cd4fc8710c121d8245c9d8ef59e1086&scope=openid&redirect_uri=http%3A%2F%2F127.0.0.1%3A65499",
  "Nonce": "smTo3BqVY0GyDAxm2Xe5iA",
  "State": "EH9TWd_DVV1VCUR_zzvtSQ",
  "CodeVerifier": "BXPZAbWfflWtO4Y2jTR_s9N06S5pQ-xmGLCakJ1ikEI",
  "RedirectUri": "http://127.0.0.1:65499"
}

[08:59:15 Verbose] IdentityModel.OidcClient.OidcClient
ProcessResponseAsync

[08:59:15 Information] IdentityModel.OidcClient.OidcClient
Processing response.

[08:59:15 Verbose] IdentityModel.OidcClient.OidcClient
EnsureProviderInformation

[08:59:15 Debug] IdentityModel.OidcClient.OidcClient
Successfully loaded discovery document

[08:59:15 Debug] IdentityModel.OidcClient.OidcClient
Loaded keyset from "https://sod.superoffice.com/login/.well-known/jwks"

[08:59:15 Debug] IdentityModel.OidcClient.OidcClient
Keyset contains the following kids: ["16B7FB8C3F9AB06885A800C64E64C97C4AB5E98C"]

[08:59:15 Verbose] IdentityModel.OidcClient.OidcClient
Effective options:

[08:59:15 Verbose] IdentityModel.OidcClient.OidcClient
{
  "Authority": "https://sod.superoffice.com/login/",
  "ProviderInformation": {
    "IssuerName": "https://sod.superoffice.com",
    "KeySet": {
      "Keys": [
        {
          "alg": "RS256",
          "e": "AQAB",
          "key_ops": [],
          "kid": "16B7FB8C3F9AB06885A800C64E64C97C4AB5E98C",
          "kty": "RSA",
          "n": "sY6PrEDYl7VuiTaFDCnTKYwcqq2y5J_vttZWf8QCV9oOXsI77lhCqO71SavHaoRQe3gkXsWIbgpv3hwmYyDiOiqf6XdJxVarmrvvjmXDQDl9mgUZ4visDhxNPFyWjsMiLQpVUlpO73ASy7-F_cuBCTQ4g9YDX7YBh94WL-EvA9ciB6ZtRsRS945ezrDMq8Q38RjpemXekc7ObwPXOX7PzFkGcdMWLHNm6Ktj2OFIqkuJYBRmOr85IlKcuek4x0LeVDj24Min_HG-4MqVpvDzF4m2Ib5AgFI3Akl9p7Z-dCSq6KTphu8hO_LmW-E93kz6weG7dZxt7otFps0j09py-Q",
          "use": "sig",
          "x5c": [
            "MIIDrTCCApUCAQowDQYJKoZIhvcNAQEFBQAwgZQxCzAJBgNVBAYTAk5PMQ0wCwYDVQQIDARPc2xvMQ0wCwYDVQQHDARPc2xvMRcwFQYDVQQKDA5TdXBlck9mZmljZSBBUzEqMCgGA1UEAwwhU3VwZXJPZmZpY2UgT25saW5lIERldmVsb3BtZW50IENBMSIwIAYJKoZIhvcNAQkBFhNzZGtAc3VwZXJvZmZpY2UuY29tMCAXDTEzMDkwMzExNDIyN1oYDzIxMTMwODEwMTE0MjI3WjCBoTELMAkGA1UEBhMCTk8xDTALBgNVBAgMBE9zbG8xDTALBgNVBAcMBE9zbG8xFzAVBgNVBAoMDlN1cGVyT2ZmaWNlIEFTMTcwNQYDVQQDDC5TdXBlck9mZmljZSBPbmxpbmUgRGV2ZWxvcG1lbnQgRmVkZXJhdGVkIExvZ2luMSIwIAYJKoZIhvcNAQkBFhNzZGtAc3VwZXJvZmZpY2UuY29tMIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAsY6PrEDYl7VuiTaFDCnTKYwcqq2y5J/vttZWf8QCV9oOXsI77lhCqO71SavHaoRQe3gkXsWIbgpv3hwmYyDiOiqf6XdJxVarmrvvjmXDQDl9mgUZ4visDhxNPFyWjsMiLQpVUlpO73ASy7+F/cuBCTQ4g9YDX7YBh94WL+EvA9ciB6ZtRsRS945ezrDMq8Q38RjpemXekc7ObwPXOX7PzFkGcdMWLHNm6Ktj2OFIqkuJYBRmOr85IlKcuek4x0LeVDj24Min/HG+4MqVpvDzF4m2Ib5AgFI3Akl9p7Z+dCSq6KTphu8hO/LmW+E93kz6weG7dZxt7otFps0j09py+QIDAQABMA0GCSqGSIb3DQEBBQUAA4IBAQCrx88qTpQlM27TPd3i/qHt182+Gy40klx2l9ho1PW8EZqKJTZQD4+guHGLrMzYLTl0rDWcqbjVbYjZKw6xoSGAFOlKjoBCZqkiVhFyiOeXYpg4F3rNCau944nNkLr+XJ+84B8ieruGDDcf0gCN33WXmIvG69I4PmLJB9RbdVaTvmPdwonPiIZ0+i60L9w8IW8pL4EM7upIiRkpBrHMhHJr/DhmDV+P+nO8GuyYKXmgbkeTtVvskwRbO6j/USEjTFdCcAj0WHpKYAKxvgqpdfZsdfo2JAnnuv83BbuAkYxZWPip7kEMcNEPGpLp7CBr58g5JlvWr1pSsm0NNXEER3E2"
          ],
          "x5t": "Frf7jD-asGiFqADGTmTJfEq16Yw",
          "KeySize": 2048,
          "HasPrivateKey": false
        }
      ]
    },
    "TokenEndpoint": "https://sod.superoffice.com/login/common/oauth/tokens",
    "AuthorizeEndpoint": "https://sod.superoffice.com/login/common/oauth/authorize",
    "EndSessionEndpoint": "https://sod.superoffice.com/login/logout",
    "TokenEndPointAuthenticationMethods": [
      "client_secret_post",
      "client_secret_basic"
    ],
    "SupportsUserInfo": false,
    "SupportsEndSession": true
  },
  "ClientId": "8cd4fc8710c121d8245c9d8ef59e1086",
  "ClientSecret": "a24bf7afdb4fca3ebdddab63f7e78a58",
  "Scope": "openid",
  "RedirectUri": "http://127.0.0.1:65499",
  "BrowserTimeout": "00:00:00",
  "ClockSkew": "00:05:00",
  "RefreshDiscoveryDocumentForLogin": true,
  "RefreshDiscoveryOnSignatureFailure": false,
  "ResponseMode": "Redirect",
  "LoadProfile": false,
  "FilterClaims": false,
  "Flow": "AuthorizationCode",
  "BackchannelTimeout": "00:00:30",
  "TokenClientCredentialStyle": "PostBody",
  "Policy": {
    "Discovery": {
      "LoopbackAddresses": [
        "localhost",
        "127.0.0.1"
      ],
      "Authority": "https://sod.superoffice.com/login",
      "AuthorityValidationStrategy": {},
      "RequireHttps": true,
      "AllowHttpOnLoopback": true,
      "ValidateIssuerName": false,
      "ValidateEndpoints": true,
      "EndpointValidationExcludeList": [],
      "AdditionalEndpointBaseAddresses": [],
      "RequireKeySet": true
    },
    "RequireAuthorizationCodeHash": true,
    "RequireAccessTokenHash": false,
    "RequireIdentityTokenOnRefreshTokenResponse": false,
    "RequireIdentityTokenSignature": true,
    "ValidateTokenIssuerName": false,
    "ValidSignatureAlgorithms": [
      "RS256",
      "RS384",
      "RS512",
      "PS256",
      "PS384",
      "PS512",
      "ES256"
    ]
  },
  "FilteredClaims": [
    "iss",
    "exp",
    "nbf",
    "aud",
    "nonce",
    "iat",
    "auth_time",
    "c_hash",
    "at_hash"
  ]
}

[08:59:15 Debug] IdentityModel.OidcClient.OidcClient
Authorize response: "?state=EH9TWd_DVV1VCUR_zzvtSQ&code=gZsGDdePRqKEXEMhpFWwQeOR0z9MOwHmaInhDN2psHYSGdJFHyuz91N0E18JLi87"

[08:59:15 Verbose] IdentityModel.OidcClient.ResponseProcessor
ProcessResponseAsync

[08:59:15 Verbose] IdentityModel.OidcClient.ResponseProcessor
ProcessCodeFlowResponseAsync

[08:59:15 Verbose] IdentityModel.OidcClient.ResponseProcessor
RedeemCodeAsync

[08:59:15 Verbose] IdentityModel.OidcClient.ResponseProcessor
ValidateTokenResponse

[08:59:15 Verbose] IdentityModel.OidcClient.IdentityTokenValidator
Validate

[08:59:15 Debug] IdentityModel.OidcClient.IdentityTokenValidator
Added signing key with kid: "16B7FB8C3F9AB06885A800C64E64C97C4AB5E98C"

[08:59:15 Verbose] IdentityModel.OidcClient.ResponseProcessor
ValidateNonce

[08:59:15 Verbose] IdentityModel.OidcClient.OidcClient
ProcessClaims

[08:59:15 Information] IdentityModel.OidcClient.OidcClient
Authentication request success.



Claims:
sub: tony@superoffice.com
iat: 1649314756
http://schemes.superoffice.net/identity/associateid: 5
http://schemes.superoffice.net/identity/identityprovider: central-superid
http://schemes.superoffice.net/identity/email: tony@superoffice.com
http://schemes.superoffice.net/identity/upn: tony@superoffice.com
http://schemes.superoffice.net/identity/is_administrator: True
http://schemes.superoffice.net/identity/ctx: Cust26759
http://schemes.superoffice.net/identity/company_name: Tonys Developer Network
http://schemes.superoffice.net/identity/serial: 1801550193
http://schemes.superoffice.net/identity/netserver_url: https://sod.superoffice.com/Cust26759/Remote/Services88/
http://schemes.superoffice.net/identity/initials: TY
http://schemes.superoffice.net/identity/so_primary_email_address: tony@superoffice.com
nonce: smTo3BqVY0GyDAxm2Xe5iA
nbf: 1649314696
exp: 1649315056
iss: https://sod.superoffice.com
aud: 8cd4fc8710c121d8245c9d8ef59e1086

identity token: eyJhbGciOiJSUzI1NiIsImtpZCI6IjE2QjdGQjhDM0Y5QUIwNjg4NUE4MDBDNjRFNjRDOTdDNEFCNUU5OEMiLCJ4NXQiOiJGcmY3akQtYXNHaUZxQURHVG1USmZFcTE2WXciLCJ0eXAiOiJKV1QifQ.eyJzdWIiOiJ0b255QHN1cGVyb2ZmaWNlLmNvbSIsImlhdCI6MTY0OTMxNDc1NiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L2Fzc29jaWF0ZWlkIjoiNSIsImh0dHA6Ly9zY2hlbWVzLnN1cGVyb2ZmaWNlLm5ldC9pZGVudGl0eS9pZGVudGl0eXByb3ZpZGVyIjoiY2VudHJhbC1zdXBlcmlkIiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L2VtYWlsIjoidG9ueUBzdXBlcm9mZmljZS5jb20iLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvdXBuIjoidG9ueUBzdXBlcm9mZmljZS5jb20iLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvaXNfYWRtaW5pc3RyYXRvciI6IlRydWUiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvY3R4IjoiQ3VzdDI2NzU5IiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L2NvbXBhbnlfbmFtZSI6IlRvbnlzIERldmVsb3BlciBOZXR3b3JrIiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L3NlcmlhbCI6IjE4MDE1NTAxOTMiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvbmV0c2VydmVyX3VybCI6Imh0dHBzOi8vc29kLnN1cGVyb2ZmaWNlLmNvbS9DdXN0MjY3NTkvUmVtb3RlL1NlcnZpY2VzODgvIiwiaHR0cDovL3NjaGVtZXMuc3VwZXJvZmZpY2UubmV0L2lkZW50aXR5L2luaXRpYWxzIjoiVFkiLCJodHRwOi8vc2NoZW1lcy5zdXBlcm9mZmljZS5uZXQvaWRlbnRpdHkvc29fcHJpbWFyeV9lbWFpbF9hZGRyZXNzIjoidG9ueUBzdXBlcm9mZmljZS5jb20iLCJub25jZSI6InNtVG8zQnFWWTBHeURBeG0yWGU1aUEiLCJuYmYiOjE2NDkzMTQ2OTYsImV4cCI6MTY0OTMxNTA1NiwiaXNzIjoiaHR0cHM6Ly9zb2Quc3VwZXJvZmZpY2UuY29tIiwiYXVkIjoiOGNkNGZjODcxMGMxMjFkODI0NWM5ZDhlZjU5ZTEwODYifQ.Rv8VBu_lXjYNCoy9wS47pUKewfXyMiYZBV83aMV3C94ri00ZKjFBJD-uCgSlp6lehIBzWT3w315N6Tozv8EE63YBT1ySakrNyhIyEAMb3GQTD-mpcSsI-1-rWiW0tjm2sL0HJBqwaZDR-GWOONVZrm2hC7T2_O6Ff_WZ0tJ8N4JjJf4rAb-lWYLX1hCBNmGXoRXgtFl4YvtIJPNUr5ZkwGCTQIplKvwvZoo67-GyTZdMfyK5jM3_ArQop6WV5xJ-fh5EBjoeIzozsMeYl-PNaOdcFVxR-jP-69Fck8jaKbYJJhVRa4CtJjw8i-HvmqXwMpE89O87ShhHSLXlUszOGA
access token:   8A:Cust26759.AeOBSDqv83zW0BjN0vbi3vIgAgAA4f04Vnh0USHqHUpLPCDMSmWnSxP3oT0RCynTERedCKS/xTY509Zi/CvNl36eCq9kZq5ZiLbpkBbhULTS2Hf1x1fP9uIogdB5VD7cgiTm6P+nUB02RJbllalmgrSuAlyLWd0BEfhgXylY76DL0VNErfY1CWICN/8ZUjU/2h6c0hQjeO5tHKVyxKpZB26xc1RBjl2amaZuUl/T8Ey8oqRNOGmx1AnLqe2FufzLpAeeC2ZCr9HLi4yU1/nEqp3y3fCylYvHpidA0pVX2FMicN2PR5gpG3lvebXm3o7r8Tv6d4bqciwKMmCu/htlZZunv4d0ipqTisqgf/EauZ32j+i/EaDlBcmPDpaEUFtY2jb3kSaqOhA32nGRpSYaKW2s/VLmI8+Z3Hx25KXu3h40GCvf6xaLL9qeOvOqgQtR/Cq/AyLPEWHVXivrbeMcVVbdAem7RbdJI7G2FH6jiAgTPVcxH/wgo9e/WGs67xBuEwIMwPzc75EdNW+kl73u1juWbZqVjBUlC4CEKEDvEdoeIjbtjTuSYCl6oy4YCBSoEyZ9aoBgjS1AxAQjK3Iqj12952SGxDMazAlo3dopRt/rwOjfO/tbxfgVxh96xaC2BhgjiglVz+3OM40pPyqDKg+B3OiwruiS+9X9RHtBDpEu2sOMOkQ8hhf4XnyV3EKwqOY+1eeM8WeIYWEHPXSnx7oft825gJ/zJRkI4xHdtPeLGoCwnQ7h3u2+wgtQfSPC0J/szdI7yDrqPFxbR+Ywlh+HeIuQ
refresh token:  ru37JOnv2FOLkHl9RGze29M64yJef4JuZUYSI6lNKCXzffUsgs820SV0idbQgA2k



  x...exit  c...call api   r...refresh token