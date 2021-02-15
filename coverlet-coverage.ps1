Clear-Host

Write-Host "Removing any old test and coverage.cobertura.xml files from all folders"
get-childitem ./Tests -include coverage.cobertura.xml -recurse | foreach ($_) {remove-item $_.fullname}
remove-item -Path ./TestResults -recurse -ErrorAction Ignore

# /p:Exclude="^((?!IdentityService).)*$|UnitTests" /p:ExcludeByAttribute="Obsolete" /p:ExcludeByAttribute="GeneratedCode"
Write-Host "Running Tests and collecting coverage stats"
dotnet test CoverageSample.sln -c Debug --results-directory "./TestResults" --logger "trx" /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:SkipAutoProps=true

Write-Host "Install ReportGenerator global tool"
dotnet tool install --global dotnet-reportgenerator-globaltool

Write-Host "Generating code coverage report"
reportgenerator -reportTypes:HTML "-reports:./**/coverage.cobertura.xml" -targetdir:./TestResults/CodeCoverage/Html
