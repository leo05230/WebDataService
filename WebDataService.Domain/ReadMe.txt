安裝
Install-Package Microsoft.EntityFrameworkCore.SqlServer -Version 3.1.0
Install-Package Microsoft.EntityFrameworkCore.SqlServer.Design -Version 1.1.6
Install-Package Microsoft.EntityFrameworkCore.Tools -Version 3.1.0

如果有刪除時可能就要重新新增一個方案再加入舊專案

//第一次乾淨時
Scaffold-DbContext "Data Source=192.168.80.23;Database=DataSet;user id=sa;password=86125275;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities
//有更新時
Scaffold-DbContext "Data Source=192.168.80.23;Database=DataSet;user id=sa;password=86125275;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -Project WebDataService.Domain -Force
