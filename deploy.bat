@rd /s /q nugets
call dotnet pack Diagnostic.Extensions.sln --configuration Release
for %%f in (nugets/*.nupkg) do (
	call dotnet nuget push nugets/%%f -k %IH_API_KEY% -s https://api.nuget.org/v3/index.json
)

pause