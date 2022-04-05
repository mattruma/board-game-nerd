# Introduction

## Azure Environment

Create a `main.parameters.json` file, like the below:

```json
{
    "$schema": "https://schema.management.azure.com/schemas/2019-04-01/deploymentParameters.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "value": "eastus"
        },
        "apimName": {
            "value": ""
        },
        "apimPublisherName": {
            "value": ""
        },
        "apimPublisherEmail": {
            "value": ""
        },
        "cosmosAccountName": {
            "value": ""
        },
        "cosmosLocations": {
            "value": [
                {
                    "locationName": "eastus",
                    "failoverPriority": 0,
                    "isZoneRedundant": false
                },
                {
                    "locationName": "westus",
                    "failoverPriority": 1,
                    "isZoneRedundant": false
                }
            ]
        },
        "storageAccountName": {
            "value": ""
        },
        "sqlServerName": {
            "value": ""
        },
        "sqlAdministratorLogin": {
            "value": ""
        },
        "sqlAdministratorLoginPassword": {
            "value": ""
        }
    }
}
```

## Links

### Azure DevOps

* https://josh-ops.com/posts/azure-devops-code-coverage
* https://docs.microsoft.com/en-us/dotnet/core/tools/dotnet-test#examples
* https://lassiautio.com/2020/03/31/code-coverage-with-azure-devops
* https://code-maze.com/dotnet-code-coverage