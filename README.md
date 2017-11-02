---
services: active-directory
platforms: dotnet, javascript
author: iwilliams (but also, dstrockis & jmprieur)
---

# Combine two Azure AD Scenarios: Browser to Web and JavaScript-based Auhhentication

This sample shows how to build a .Net MVC web application that uses OpenID Connect to sign-in users from a single Azure Active Directory tenant, using the ASP.Net OpenID Connect OWIN middleware. It also shows how to include an SPA section that authenticates with the same Azure AD tenant. ADAL for JavaScript is used for securing an single page app written independently of any frameworks, implemented with an ASP.NET Web API backend.


For more information about how the protocols work in this scenario and other scenarios, see [Authentication Scenarios for Azure AD](http://go.microsoft.com/fwlink/?LinkId=394414).


> [AZURE.TIP] Try the preview of our new [developer portal](https://identity.microsoft.com/Docs/Web) that will help you get up and running with Azure Active Directory in just a few minutes!  The developer portal will walk you through the process of registering an app and integrating Azure AD into your code.  When you’re finished, you will have a simple application that can authenticate users in your tenant and a backend that can accept tokens and perform validation.  

Integrating Azure AD into a single page app
====================

ADAL for Javascript is an open source library.  For distribution options, source code, and contributions, check out the ADAL JS repo at https://github.com/AzureAD/azure-activedirectory-library-for-js.

For more information about how the protocols work in this scenario and other scenarios, see [Authentication Scenarios for Azure AD](http://go.microsoft.com/fwlink/?LinkId=394414).

## How To Run This Sample

Getting started is simple!  To run this sample you will need:
- Visual Studio 2013 (or higher)
- An Internet connection
- An Azure Active Directory (Azure AD) tenant. For more information on how to get an Azure AD tenant, please see [How to get an Azure AD tenant](https://azure.microsoft.com/en-us/documentation/articles/active-directory-howto-tenant/) 
- A user account in your Azure AD tenant. This sample will not work with a Microsoft account, so if you signed in to the Azure portal with a Microsoft account and have never created a user account in your directory before, you need to do that now.

### Step 1:  Clone or download this repository

`git clone https://github.com/irwinwilliams/ATaleOfTwoAzureAD_Scenarios.git
### Step 2:  Register the sample with your Azure Active Directory tenant

1. Sign in to the [Azure portal](https://portal.azure.com).
2. On the top bar, click on your account and under the **Directory** list, choose the Active Directory tenant where you wish to register your application.
3. Click on **More Services** in the left hand nav, and choose **Azure Active Directory**.
4. Click on **App registrations** and choose **Add**.
<<<<<<< HEAD
5. Enter a friendly name for the application, for example 'WebApp-OpenIDConnect-DotNet' and select 'Web Application and/or Web API' as the Application Type. For the sign-on URL, enter the base URL for the sample, which is by default `https://localhost:44320/`. Click on **Create** to create the application.
6. While still in the Azure portal, choose your application, click on **Settings** and choose **Properties**.
7. Find the Application ID value and copy it to the clipboard.
8. In the same page, change the `logoutUrl` property to `https://localhost:44320/Account/EndSession`.  This is the default single sign out URL for this sample.
9. For the App ID URI, enter `https://<your_tenant_name>/WebApp-OpenIDConnect-DotNet`, replacing `<your_tenant_name>` with the name of your Azure AD tenant. 

=======
### Step 3:  Enable the OAuth2 implicit grant for your application

By default, applications provisioned in Azure AD are not enabled to use the OAuth2 implicit grant. In order to run this sample, you need to explicitly opt in.

1. From the former steps, your browser should still be on the Azure portal.
2. From the application page, click on **Manifest** to open the inline manifest editor.
3. Search for the `oauth2AllowImplicitFlow` property. You will find that it is set to `false`; change it to `true` and save the file.
