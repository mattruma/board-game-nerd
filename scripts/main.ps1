param(
    [Parameter(Mandatory = $false)]
    [String] $ResourceGroupName,
    [Parameter(Mandatory = $false)]
    [String] $Location = "eastus",
    [Parameter(Mandatory = $false)]
    [String] $TemplateFile = './main.bicep',
    [Parameter(Mandatory = $false)]
    [String] $ParametersFile = './main.parameters.json'
)

az group create `
    -n $ResourceGroupName `
    -l $Location

az deployment group create `
    -g $ResourceGroupName `
    -f $TemplateFile `
    -p $ParametersFile