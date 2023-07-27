### Special Thanks

Since "IdentityServer4" (https://github.com/IdentityServer/IdentityServer4) project is not maintained anymore, To support my .net 7 project I have upgraded the project into .net 7 and published this repository to use anyone for free. Special thanks to the IdentitySever4 project and the team.

### About Dynami IdentityServer4

Dynami IdentityServer4 is a free, open source OpenID Connect and OAuth 2.0 framework for .NET 7 + which is primaraly based on .IdentityServer4" (https://github.com/IdentityServer/IdentityServer4) project. Dynami IdentityServer4 incorporates all the protocol implementations and extensibility points needed to integrate token-based authentication, single-sign-on and API access control in your applications. IdentityServer4 is officially certified by the OpenID Foundation and thus spec-compliant and interoperable. It is part of the .NET Foundation, and operates under their code of conduct. It is licensed under Apache 2 (an OSI approved license).

### Adding UI into your Project.

Use this link to add startup UI into your Dynamic IdentityServer4 project. : https://github.com/erandika1986/Dynami.IdentityServer4.UI

This repository contains the controllers, models, views, and CSS files needed for the UI. You can simply clone it and copy the folders into the web project.

Alternatively, you can run this Powershell script from your web project directory to download them automatically:

```
iex ((New-Object System.Net.WebClient).DownloadString('https://raw.githubusercontent.com/erandika1986/Dynami.IdentityServer4.UI/main/getmain.ps1'))

```
Or using bash one-liner on macOS or Linux:
```
curl -L https://raw.githubusercontent.com/erandika1986/Dynami.IdentityServer4.UI/main/getmain.sh | bashh

```

### Core Sample Applications

You can view all sample application in this URL: https://github.com/erandika1986/Dynami.IdentityServer4.Samples

### Advance Sample Application

Dynami IdentityServer4 Blazor WebAssembly  Complete Demo Application  - https://github.com/erandika1986/Blazor-WebAssembly-Indentity4-Demo
