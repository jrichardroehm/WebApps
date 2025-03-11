# Microsoft Web Applications - Web Forms, Model-View-Controller (MVC), and Blazer Web Applications
The purpose of this repository is to incorporate database connections using the Bogus NuGet package to randomly generate data.

The data is outputted to a 10x10 grid utilizing buttons and forms.

The Web Forms utilizes the Session object to store data generated from Bogus - A memory expensive operation common to Web Form sites.

The MVC does not use session metadata to prevent generation of new randomized data, however it does redirect to a separate view making continuous generation difficult.

The Blazer Application generates all data in the client-side application, making it memory inexpensive for the network.

These programs succeed in all of the aforementioned goals.

# Running the Applications
Both the MVC and Blazer Applications will show in the "Startup Items" drop down in Visual Studio.

However the Web Forms will require the user to select the "Set as Startup Prject" on the WebApplication-WebForms tab.

<meta name="google-site-verification" content="tZgbB2s-hTI0IePQQRCjHqL_Vf0j_XJmehXAHJerrn4" />

# ![BlazerIcon] ![PowershellIcon] Microsoft Azure PowerShell

This repository contains PowerShell cmdlets for developers and administrators to develop, deploy,
administer, and manage Microsoft Azure resources.

The Az PowerShell module is preinstalled in [Azure Cloud Shell][AzureCloudShell].

## Modules

The following table contains a list of the Azure PowerShell rollup modules.

Description       | Module Name  | PowerShell Gallery Link
----------------- | ------------ | -----------------------
Azure PowerShell  | `Az`         | [![Az]][AzGallery]
Azure PowerShell with preview modules | `AzPreview`                             | [![AzPreview]][AzPreviewGallery]

For a complete list of the modules found in this repository, see
[Azure PowerShell Modules][AzurePowerShellModules].

## Installation

### PowerShell Gallery

Run the following command in a PowerShell session to install the Az PowerShell module:

```powershell
Install-Module -Name Az -Scope CurrentUser -Repository PSGallery -Force
```

[The latest version of PowerShell 7][PowerShellCore] is the recommended version of PowerShell for
use with the Az PowerShell module on all platforms including Windows, Linux, and macOS. This module
also runs on Windows PowerShell 5.1 with [.NET Framework 4.7.2][DotNetFramework] or higher.

The `Az` module replaces `AzureRM`. You should not install `Az` side-by-side with `AzureRM`.

If you have an earlier version of the Azure PowerShell module installed from the PowerShell Gallery
and would like to update to the latest version, run the following command in a PowerShell session:

```powershell
Update-Module -Name Az -Scope CurrentUser -Force
```

`Update-Module` installs the new version side-by-side with previous versions. It does not uninstall
the previous versions.

For more information on installing Azure PowerShell, see the
[installation guide][InstallationGuide].

## Usage

### Log into Azure

To connect to Azure, use the [`Connect-AzAccount`][ConnectAzAccount] cmdlet:

```powershell
# Opens a new browser window to log into your Azure account.
Connect-AzAccount

# Log in with a previously created service principal. Use the application ID as the username, and the secret as password.
$Credential = Get-Credential
Connect-AzAccount -ServicePrincipal -Credential $Credential -TenantId $TenantId
```

To log into a specific cloud (_AzureChinaCloud_, _AzureCloud_, _AzureUSGovernment_), use the
`Environment` parameter:

```powershell
# Log into a specific cloud, for example the Azure China cloud.
Connect-AzAccount -Environment AzureChinaCloud
```

### Session context

A session context persists login information across Azure PowerShell modules and PowerShell
instances. Use the [`Get-AzContext`][GetAzContext] cmdlet to view the context you are using in the
current session. The results contain the Azure tenant and subscription.

```powershell
# Get the Azure PowerShell context for the current PowerShell session
Get-AzContext

# Lists all available Azure PowerShell contexts in the current PowerShell session
Get-AzContext -ListAvailable
```

To get the subscriptions in a tenant, use the [`Get-AzSubscription`][GetAzSubscription] cmdlet:

```powershell
# Get all of the Azure subscriptions in your current Azure tenant
Get-AzSubscription

# Get all of the Azure subscriptions in a specific Azure tenant
Get-AzSubscription -TenantId $TenantId
```

To change the subscription that you are using for your current context, use the
[`Set-AzContext`][SetAzContext] cmdlet:

```powershell
# Set the Azure PowerShell context to a specific Azure subscription
Set-AzContext -Subscription $SubscriptionName -Name 'MyContext'

# Set the Azure PowerShell context using piping
Get-AzSubscription -SubscriptionName $SubscriptionName | Set-AzContext -Name 'MyContext'
```

For details on Azure PowerShell contexts, see [Azure PowerShell context objects][PersistedCredentialsGuide].

### Discovering cmdlets

Use `Get-Command` to discover cmdlets within a specific module, or cmdlets that follow a specific
search pattern:

```powershell
# List all cmdlets in the Az.Accounts module
Get-Command -Module Az.Accounts

# List all cmdlets that contain VirtualNetwork in their name
Get-Command -Name '*VirtualNetwork*'

# List all cmdlets that contain VM in their name in the Az.Compute module
Get-Command -Module Az.Compute -Name '*VM*'
```

### Cmdlet help and examples

To view the help content for a cmdlet, use the `Get-Help` cmdlet:

```powershell
# View basic help information for Get-AzSubscription
Get-Help -Name Get-AzSubscription

# View the examples for Get-AzSubscription
Get-Help -Name Get-AzSubscription -Examples

# View the full help for Get-AzSubscription
Get-Help -Name Get-AzSubscription -Full

# View the online version of the help from https://learn.microsoft.com for Get-AzSubscription
Get-Help -Name Get-AzSubscription -Online
```

For detailed instructions on using Azure PowerShell, see the [getting started guide][GettingStartedGuide].

## Reporting Issues and Feedback

### Issues

For issues you can reach out to me individually if you would like.


### Feedback

You can reach out to me individually if you would like to submit feedback.

## Contributing
For details on contributing to this repository, see the [DeveloperGuide].


## Telemetry

This program does not collect any additional Telemetry data.

## Learn More

* [MicrosoftAzureDocs]


---

<!-- References -->

<!-- Local -->
[GitHubRepo]: https://github.com/Azure/azure-powershell/issues

[Contributing]: CONTRIBUTING.md

[AzurePowerShellModules]: documentation/azure-powershell-modules.md
[DeveloperGuide]: documentation/development-docs/azure-powershell-developer-guide.md

<!-- External -->
[BlazerIcon]: https://en.wikipedia.org/wiki/Blazor#/media/File:Blazor.png


<!-- Docs -->
[MicrosoftAzureDocs]: https://learn.microsoft.com/azure/