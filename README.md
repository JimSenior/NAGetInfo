# NAGetInfo

NAGetInfo is a small app to call an api with an ID from The National Archive.  At the moment the only valid api call is http://discovery.nationalarchives.gov.uk/API/records/v1/details/. 

## Installation

Use Visual Studio to download the solution.  Once the solution has been downloaded you will need to install the NewtonSoft addin.
From the top menu goto tools -> Nuget Package Manager -> Manage Nuget Packages for solution.  Select NewtonSoft.Jason (ver 12.0.3).

Once installed, build the solution by right clicking in the top node in soltion explorer window and select 'Build Solution'.

## Using NAGetInfo

To run NAGetInfo bring up a command window and navigate to <solution location(e.g. C:\Visual Studio Community\NAGetInfo)>\NAGetInfo\bin\Debug\netcoreapp3.1
then type: NAGetInfo http://discovery.nationalarchives.gov.uk/API/records/v1/details/<id of item to search for>.

## Results

If the Id is valid the then the title is displayed (if there is one), If there is not title then the ScopeClient.description is displayed otherwise a reference is displayed
(The citableReference field) and finally id all those fields are blank then 'Not Sufficient Info' is displayed.

