
cls
echo "deploying..."

nuget pack .\Core\Data\Logging\Logging.csproj -Verbosity detailed -Properties Configuration=Release -Prop Platform=x64
nuget pack .\Data\Core\Logging\Logging.csproj -Verbosity detailed -Properties Configuration=Release -Prop Platform=x64
nuget pack .\WwW\Edge\Corn\Corn.csproj -Verbosity detailed -Properties Configuration=Release -Prop Platform=x64
nuget pack .\WWW\Implementation\Compatability\Compatability.csproj -Verbosity detailed -Properties Configuration=Release -Prop Platform=x64

move .\moniüs.Logging.*.nupkg F:\NuGet\0.3.2 -Force

echo "deploy completed,"

ls F:\NuGet\0.3.2\moniüs.Logging.*.nupkg