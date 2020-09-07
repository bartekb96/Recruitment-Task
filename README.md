# Recruitment-Task\
Recruitment Task\

To build and launch the project follow the steps bellow:\
1) clone the repository into choosen directory, or download .zip file and extract it\

2) Install Nuget packages into proper projects. There are 3 projects in this solution:\
  -Hsf.ApplicatonProcess.August2020.Data \
  -Hsf.ApplicatonProcess.August2020.Domain\
  -Hsf.ApplicatonProcess.August2020.Blazor\
  To add Nuget package into the project, you need to mouse rightclick on the selected project in the "Solution Explorer" on your right hand side in Visual Studio. Then sellect "menage nuget packages" from context menue. Then click "browse" and type name of nuget package you want to install. Pick package from the list and click "Install".\
  In "Hsf.ApplicatonProcess.August2020.Blazor" project you need to install:\
  a) Blazored.FluentValidation\
  b) Blazored.Modal\
  c) Microsoft.AspNetCore.Blazor.HttpClient\
  d) Microsoft.EntityFrameworkCore.Tools\
  
  In "Hsf.ApplicatonProcess.August2020.Data" project you need to install:\
  a) Blazored.Modal\
  b) Microsoft.AspNetCore.StaticFiles\
  c) Microsoft.EntityFrameworkCore.Design\
  d) Microsoft.EntityFrameworkCore.SqlServer\
  e) Swashbuckle.AspNetCore\
  f) Swashbuckle.AspNetCore.Filters\
  
  In "Hsf.ApplicatonProcess.August2020.Domain" project you need to install:\
  a) NETStandard.Library\
  b) System.ComponentModel.Annotations\
  
3) Once NuGet packages are installed you need to set startup projects. To do that rightclick on the solution name in "solution explorer" on your right hand side in Visual Studio. Then pick "set startup projects" from context menue. After that dialogue window should appear. In this window select "multiple startup projects" and select "startup" option near to the "Hsf.ApplicatonProcess.August2020.Data" and "Hsf.ApplicatonProcess.August2020.Blazor" projects. It will provide that both API endpoint and user interface will appear in the browser after you run project. You also need to make "Hsf.ApplicatonProcess.August2020.Data" project be higher in the hierarchy than "Hsf.ApplicatonProcess.August2020.Blazor". To do that use up and down arrows on your right hand side. "Hsf.ApplicatonProcess.August2020.Blazor" uses "Hsf.ApplicatonProcess.August2020.Data" so "Hsf.ApplicatonProcess.August2020.Data" need to be run first.\

4) At the end you need to add EF migrations. To do that click on "Package Manager Console" tab in bottom left corner in VS. If you can't see this tab, select "view" -> "other windows" -> "Package Manager Console", in the main bar at the top of Visual Studio window. Console should appear. Then type "Add-Migration InitialCreate" in console. Then type "Update Database". \

I hope it's all you need to make project run succesfully.\
