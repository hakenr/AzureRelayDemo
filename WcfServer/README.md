# Azure Relay - WCF Relay - Server-side

## Implementation Components (server-side)
* `WindowsAzure.ServiceBus` NuGet package
* `web.config` - `system.serviceModel` configuration
  * incl. `multipleSiteBindingsEnabled="false"`
* optional `[ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]` - to bypass AddressFiltering

## Important
* warm-up of the service needed, sample warm-up for ASP.NET WCF host included in web.config `<applicationInitialization>` (has to be installed!)

