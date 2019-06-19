## Overview
1. Starting blank template.
```
{
    "$schema": "http://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "",
    "parameters": {  },
    "variables": {  },
    "functions": [  ],
    "resources": [  ],
    "outputs": {  }
}
```

<details><summary>Solution (don't click unless you get stuck!)</summary>
<p>

```
{
  "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.0",
  "resources": [
    {
      "apiVersion": "2016-09-01",
      "name": "ftdemo-myasp-cat",
      "type": "Microsoft.Web/serverfarms",
      "location": "eastus",
      "properties": {
        "name": "ftdemo-myasp-cat",
        "workerSize": 0,
        "workerSizeId": 0,
        "numberOfWorkers": "1",
        "hostingEnvironment": "",
        "location": "eastus"
      },
      "sku": {
          "Tier": "Free",
          "Name": "F1"
      }
    }
  ]
}
```

</p>
</details>

## References and Dependencies
<details><summary>Solution (don't click unless you get stuck!)</summary>
<p>

```
{
  "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.0",
  "resources": [
    {
      "apiVersion": "2016-09-01",
      "name": "ftdemo-myasp-cat",
      "type": "Microsoft.Web/serverfarms",
      "location": "eastus",
      "properties": {
        "name": "ftdemo-myasp-cat",
        "workerSize": 0,
        "workerSizeId": 0,
        "numberOfWorkers": "1",
        "hostingEnvironment": "",
        "location": "eastus"
      },
      "sku": {
          "Tier": "Free",
          "Name": "F1"
      }
    },
    {
      "apiVersion": "2016-08-01",
      "type": "Microsoft.Web/sites",
      "kind": "app",
      "name": "ftdemo-web-cat",
      "location": "eastus",
      "comments": "This is the web app, also the default 'nameless' slot.",
      "properties": {
        "serverFarmId": "[resourceId('Microsoft.Web/serverfarms', 'ftdemo-myasp-cat')]"
      },
      "dependsOn": [
        "[resourceId('Microsoft.Web/serverfarms', 'ftdemo-myasp-cat')]"
      ]
    }
  ]
}
```

</p>
</details>

## Output
<details><summary>Solution (don't click unless you get stuck!)</summary>
<p>

```
{
  "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
  "contentVersion": "1.0.0.0",
  "resources": [
    {
      "apiVersion": "2016-09-01",
      "name": "ftdemo-myasp-cat",
      "type": "Microsoft.Web/serverfarms",
      "location": "eastus",
      "properties": {
        "name": "ftdemo-myasp-cat",
        "workerSize": 0,
        "workerSizeId": 0,
        "numberOfWorkers": "1",
        "hostingEnvironment": "",
        "location": "eastus"
      },
      "sku": {
          "Tier": "Free",
          "Name": "F1"
      }
    },
    {
      "apiVersion": "2016-08-01",
      "type": "Microsoft.Web/sites",
      "kind": "app",
      "name": "ftdemo-web-cat",
      "location": "eastus",
      "comments": "This is the web app, also the default 'nameless' slot.",
      "properties": {
        "serverFarmId": "[resourceId('Microsoft.Web/serverfarms', 'ftdemo-myasp-cat')]"
      },
      "dependsOn": [
        "[resourceId('Microsoft.Web/serverfarms', 'ftdemo-myasp-cat')]"
      ]
    }
  ],
  "outputs": {
  "resourceID": {
    "type": "string",
    "value": "[resourceId('Microsoft.Web/sites', 'ftdemo-web-cat')]"
    }
  }
}
```

</p>
</details>

## Parameteres 
<details><summary>Solution - Parameters</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "appServiceName": {
            "type": "string",
            "defaultValue": "ftdemo-myasp-cat",
            "metadata": {
                "description": "Base name of the resource for the app service plan."
            },
            "minLength": 2
        },
        "webAppName": {
            "type": "string",
            "defaultValue": "ftdemo-web-cat",
            "metadata": {
                "description": "Base name of the resource for the web app."
            },
            "minLength": 2
        },
        "sku": {
            "type": "string",
            "defaultValue": "F1",
            "metadata": {
                "description": "The SKU of App Service Plan, by default is standard F1"
            }
        },
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2016-09-01",
            "name": "[parameters('appServiceName')]",
            "type": "Microsoft.Web/serverfarms",
            "location": "[parameters('location')]",
            "properties": {
                "name": "[parameters('appServiceName')]",
                "workerSize": 0,
                "workerSizeId": 0,
                "numberOfWorkers": "1",
                "hostingEnvironment": "",
                "location": "[parameters('location')]"
            },
            "sku": {
                "Tier": "Free",
                "Name": "[parameters('sku')]"
            }
        },
        {
            "apiVersion": "2016-08-01",
            "type": "Microsoft.Web/sites",
            "kind": "app",
            "name": "[parameters('webAppName')]",
            "location": "[parameters('location')]",
            "comments": "This is the web app, also the default 'nameless' slot.",
            "properties": {
                "serverFarmId": "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            },
            "dependsOn": [
                "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            ]
        }
    ],
    "outputs": {
        "resourceID": {
            "type": "string",
            "value": "[resourceId('Microsoft.Web/sites', parameters('appServiceName'))]"
        }
    }
}
```

</p>
</details>

<details><summary>Solution - Add Another Resource (VNet)</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "appServiceName": {
            "type": "string",
            "defaultValue": "ftdemo-myasp-cat",
            "metadata": {
                "description": "Base name of the resource for the app service plan."
            },
            "minLength": 2
        },
        "webAppName": {
            "type": "string",
            "defaultValue": "ftdemo-web-cat",
            "metadata": {
                "description": "Base name of the resource for the web app."
            },
            "minLength": 2
        },
        "sku": {
            "type": "string",
            "defaultValue": "F1",
            "metadata": {
                "description": "The SKU of App Service Plan, by default is standard F1"
            }
        },
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2016-09-01",
            "name": "[parameters('appServiceName')]",
            "type": "Microsoft.Web/serverfarms",
            "location": "[parameters('location')]",
            "properties": {
                "name": "[parameters('appServiceName')]",
                "workerSize": 0,
                "workerSizeId": 0,
                "numberOfWorkers": "1",
                "hostingEnvironment": "",
                "location": "[parameters('location')]"
            },
            "sku": {
                "Tier": "Free",
                "Name": "[parameters('sku')]"
            }
        },
        {
            "apiVersion": "2016-08-01",
            "type": "Microsoft.Web/sites",
            "kind": "app",
            "name": "[parameters('webAppName')]",
            "location": "[parameters('location')]",
            "comments": "This is the web app, also the default 'nameless' slot.",
            "properties": {
                "serverFarmId": "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            },
            "dependsOn": [
                "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            ]
        },
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[parameters('vnetName')]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            }
        }
    ],
    "outputs": {
        "resourceID": {
            "type": "string",
            "value": "[resourceId('Microsoft.Web/sites', parameters('appServiceName'))]"
        }
    }
}
```

</p>
</details>

<details><summary>Solution - Parameter File Dev</summary>
<p>
```
{
  "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentParameters.json#",
  "contentVersion": "1.0.0.0",
  "parameters": {
    "appServiceName": {
      "value": "ftdemo-myasp-cat-prod"
    },
    "webAppName": {
      "value": "ftdemo-web-cat-prod"
    },
    "sku": {
      "value": "F1"
    },
    "location": {
      "value": "eastus"
    },
    "vnetName": {
      "value": "myVnet-prod"
    },
    "vnetAddressPrefix": {
      "value": "10.0.0.0/16"
    }
  }
}
```
</p>
</details>

## Incremental/Complete, Linked/Nested
<details><summary>Solution - App Service Plan (azuredeploy-asp-and-site.json)</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "appServiceName": {
            "type": "string",
            "defaultValue": "ftdemo-myasp-cat",
            "metadata": {
                "description": "Base name of the resource for the app service plan."
            },
            "minLength": 2
        },
        "webAppName": {
            "type": "string",
            "defaultValue": "ftdemo-web-cat",
            "metadata": {
                "description": "Base name of the resource for the web app."
            },
            "minLength": 2
        },
        "sku": {
            "type": "string",
            "defaultValue": "F1",
            "metadata": {
                "description": "The SKU of App Service Plan, by default is standard F1"
            }
        },
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2016-09-01",
            "name": "[parameters('appServiceName')]",
            "type": "Microsoft.Web/serverfarms",
            "location": "[parameters('location')]",
            "properties": {
                "name": "[parameters('appServiceName')]",
                "workerSize": 0,
                "workerSizeId": 0,
                "numberOfWorkers": "1",
                "hostingEnvironment": "",
                "location": "[parameters('location')]"
            },
            "sku": {
                "Tier": "Free",
                "Name": "[parameters('sku')]"
            }
        },
        {
            "apiVersion": "2016-08-01",
            "type": "Microsoft.Web/sites",
            "kind": "app",
            "name": "[parameters('webAppName')]",
            "location": "[parameters('location')]",
            "comments": "This is the web app, also the default 'nameless' slot.",
            "properties": {
                "serverFarmId": "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            },
            "dependsOn": [
                "[resourceId('Microsoft.Web/serverfarms', parameters('appServiceName'))]"
            ]
        }
    ],
    "outputs": {
        "resourceID": {
            "type": "string",
            "value": "[resourceId('Microsoft.Web/sites', parameters('appServiceName'))]"
        }
    }
}
```

</p>
</details>

<details><summary>Solution - VNet (azuredeploy-vnet.json)</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[parameters('vnetName')]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            }
        }
    ]
}
```

</p>
</details>

Starting Template for Parent
```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
      "appServiceName": {
        "defaultValue": "ftdemo-myasp-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the app service plan."
        }
      },
      "webAppName": {
        "defaultValue": "ftdemo-web-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the web app."
        }
      },
      "sku": {
        "defaultValue": "F1",
        "type": "string",
        "metadata": {
          "description": "The SKU of App Service Plan, by default is standard F1"
        }
      },
      "vnetName": {
        "defaultValue": "myVnet",
        "type": "string",
        "metadata": {
          "description": "The VNet name"
        }
      },
      "vnetAddressPrefix": {
        "defaultValue": "10.0.0.0/16",
        "type": "string",
        "metadata": {
          "description": "The address prefix for the VNet"
        }
      },
      "location": {
        "defaultValue": "eastus",
        "type": "string",
        "metadata": {
          "description": "Location for all resources."
        }
      }
    },
    "variables": {},
    "resources": [
      {
        "type": "Microsoft.Resources/deployments",
        "name": "linkedTemplate-asp",
        "apiVersion": "2017-05-10",
        "properties": {
          "mode": "Incremental",
          "templateLink": {
            "uri": "https://armtemplatescat.blob.core.windows.net/demo/azuredeploy-asp-and-site.json",
            "contentVersion": "1.0.0.0"
          },
          "parameters": {
            "appServiceName": {
              "value": "[parameters('appServiceName')]"
            },
            "webAppName": {
              "value": "[parameters('webAppName')]"
            },
            "sku": {
              "value": "[parameters('sku')]"
            },
            "location": {
              "value": "[parameters('location')]"
            }
          }
        }
      }
    ]
  }
```

<details><summary>Solution - Parent Template</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
      "appServiceName": {
        "defaultValue": "ftdemo-myasp-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the app service plan."
        }
      },
      "webAppName": {
        "defaultValue": "ftdemo-web-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the web app."
        }
      },
      "sku": {
        "defaultValue": "F1",
        "type": "string",
        "metadata": {
          "description": "The SKU of App Service Plan, by default is standard F1"
        }
      },
      "vnetName": {
        "defaultValue": "myVnet",
        "type": "string",
        "metadata": {
          "description": "The VNet name"
        }
      },
      "vnetAddressPrefix": {
        "defaultValue": "10.0.0.0/16",
        "type": "string",
        "metadata": {
          "description": "The address prefix for the VNet"
        }
      },
      "location": {
        "defaultValue": "eastus",
        "type": "string",
        "metadata": {
          "description": "Location for all resources."
        }
      }
    },
    "variables": {},
    "resources": [
      {
        "type": "Microsoft.Resources/deployments",
        "name": "linkedTemplate-asp",
        "apiVersion": "2017-05-10",
        "properties": {
          "mode": "Incremental",
          "templateLink": {
            "uri": "https://armtemplatescat.blob.core.windows.net/demo/azuredeploy-asp-and-site.json",
            "contentVersion": "1.0.0.0"
          },
          "parameters": {
            "appServiceName": {
              "value": "[parameters('appServiceName')]"
            },
            "webAppName": {
              "value": "[parameters('webAppName')]"
            },
            "sku": {
              "value": "[parameters('sku')]"
            },
            "location": {
              "value": "[parameters('location')]"
            }
          }
        }
      },
      {
        "type": "Microsoft.Resources/deployments",
        "name": "linkedTemplate-vnet",
        "apiVersion": "2017-05-10",
        "properties": {
          "mode": "Incremental",
          "templateLink": {
            "uri": "https://armtemplatescat.blob.core.windows.net/demo/azuredeploy-vnet.json",
            "contentVersion": "1.0.0.0"
          },
          "parameters": {
            "vnetName": {
              "value": "[parameters('vnetName')]"
            },
            "vnetAddressPrefix": {
              "value": "[parameters('vnetAddressPrefix')]"
            },
            "location": {
              "value": "[parameters('location')]"
            }
          }
        }
      }
    ]
  }
```

</p>
</details>

## Variables and Functions

<details><summary>Solution - Variables and Functions</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
      "appServiceName": {
        "defaultValue": "ftdemo-myasp-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the app service plan."
        }
      },
      "webAppName": {
        "defaultValue": "ftdemo-web-cat",
        "minLength": 2,
        "type": "string",
        "metadata": {
          "description": "Base name of the resource for the web app."
        }
      },
      "sku": {
        "defaultValue": "F1",
        "type": "string",
        "metadata": {
          "description": "The SKU of App Service Plan, by default is standard F1"
        }
      },
      "vnetName": {
        "defaultValue": "myVnet",
        "type": "string",
        "metadata": {
          "description": "The VNet name"
        }
      },
      "vnetAddressPrefix": {
        "defaultValue": "10.0.0.0/16",
        "type": "string",
        "metadata": {
          "description": "The address prefix for the VNet"
        }
      },
      "location": {
        "defaultValue": "eastus",
        "type": "string",
        "metadata": {
          "description": "Location for all resources."
        }
      }
    },
    "variables": {
        "appServiceName":"[concat('ftdemo-myasp-cat-', parameters('location'))]",
        "webAppName":"[concat('ftdemo-site-cat-', parameters('location'))]",
        "vnetName":"[concat('ftdemo-vnet-cat-', parameters('location'))]"
    },
    "resources": [
      {
        "type": "Microsoft.Resources/deployments",
        "name": "linkedTemplate-asp",
        "apiVersion": "2017-05-10",
        "properties": {
          "mode": "Incremental",
          "templateLink": {
            "uri": "https://armtemplatescat.blob.core.windows.net/demo/azuredeploy-asp-and-site.json",
            "contentVersion": "1.0.0.0"
          },
          "parameters": {
            "appServiceName": {
              "value": "[variables('appServiceName')]"
            },
            "webAppName": {
              "value": "[variables('webAppName')]"
            },
            "sku": {
              "value": "[parameters('sku')]"
            },
            "location": {
              "value": "[parameters('location')]"
            }
          }
        }
      },
      {
        "type": "Microsoft.Resources/deployments",
        "name": "linkedTemplate-vnet",
        "apiVersion": "2017-05-10",
        "properties": {
          "mode": "Incremental",
          "templateLink": {
            "uri": "https://armtemplatescat.blob.core.windows.net/demo/azuredeploy-vnet.json",
            "contentVersion": "1.0.0.0"
          },
          "parameters": {
            "vnetName": {
              "value": "[variables('vnetName')]"
            },
            "vnetAddressPrefix": {
              "value": "[parameters('vnetAddressPrefix')]"
            },
            "location": {
              "value": "[parameters('location')]"
            }
          }
        }
      }
    ]
  }
```

</p>
</details>


## Copy, Conditional, Tags, and Cross Resource/Sub
Start with the VNet template:
```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[parameters('vnetName')]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            }
        }
    ],
}
```

<details><summary>Solution - Copy</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[concat(parameters('vnetName'), copyIndex())]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            },
            "copy": {
                "name": "vnetcopy",
                "count": 3
            }
        }
    ]
}
```

</p>
</details>

<details><summary>Solution - Copy with Dependency</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[parameters('vnetName')]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            }
        },
        {
            "apiVersion": "2018-04-01",
            "type": "Microsoft.Network/virtualNetworks/subnets",
            "name": "[concat(parameters('vnetName'), '/defaultsubnet-', copyIndex())]",
            "location": "[parameters('location')]",
            "dependsOn": [
                "[parameters('vnetName')]"
            ],
            "properties": {
                "addressPrefix": "[concat('10.0.', copyIndex(), '.0/24')]"
            },
            "copy": {
                "name": "subnetcopy",
                "count": 3
            }
        }
    ]
}
```

</p>
</details>

<details><summary>Solution - If/Else</summary>
<p>

```
{
    "$schema": "https://schema.management.azure.com/schemas/2015-01-01/deploymentTemplate.json#",
    "contentVersion": "1.0.0.0",
    "parameters": {
        "location": {
            "type": "string",
            "defaultValue": "[resourceGroup().location]",
            "metadata": {
                "description": "Location for all resources."
            }
        },
        "vnetName": {
            "defaultValue": "myVnet",
            "type": "string",
            "metadata": {
                "description": "The VNet name"
            }
        },
        "vnetAddressPrefix": {
            "defaultValue": "10.0.0.0/16",
            "type": "string",
            "metadata": {
                "description": "The address prefix for the VNet"
            }
        },
        "has3DefaultSubnets": {
            "defaultValue": "yes",
            "type": "string",
            "metadata": {
                "description": "yes/no (all lowercase) for if you want 3 default subnets setup"
            }
        }
    },
    "resources": [
        {
            "apiVersion": "2018-06-01",
            "type": "Microsoft.Network/virtualNetworks",
            "name": "[parameters('vnetName')]",
            "location": "[parameters('location')]",
            "properties": {
                "addressSpace": {
                    "addressPrefixes": [
                        "[parameters('vnetAddressPrefix')]"
                    ]
                }
            }
        },
        {
            "condition": "[equals(parameters('has3DefaultSubnets'), 'yes')]",
            "apiVersion": "2018-04-01",
            "type": "Microsoft.Network/virtualNetworks/subnets",
            "name": "[concat(parameters('vnetName'), '/defaultsubnet-', copyIndex())]",
            "location": "[parameters('location')]",
            "dependsOn": [
                "[parameters('vnetName')]"
            ],
            "properties": {
              "addressPrefix": "[concat('10.0.', copyIndex(), '.0/24')]"
            },
            "copy": {
                "name": "subnetcopy",
                "count": 3
            }
          }
    ]
}
```

</p>
</details>
