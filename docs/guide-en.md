## Project structure description

```
project/src
│
└───Application(Some announcement dependencies of output project)
│   │
│   └───DtCoco.Core(Encapsulation of some common code in the project)
│   └───DtCoco.Data(Data entity, ORM extension and other codes)
│   └───DtCoco.Framework(Foreground check authority, general code extraction of output project, secondary encapsulation of third-party components)
│   └───DtCoco.Services(Project business module code)
│   
└───Core(Encapsulation of some third-party libraries,Independent component, which can publish the library of nuget package)
│   │
│   └───DtCoco.Interface
│   └───DtCoco.Orm.EntityFramework
│   └───DtCoco.Orm.SqlSugar
│   └───DtCoco.Oss.Aliyun
│   └───DtCoco.Oss.Minio
│   └───... Other components
│
└───Main(Store application output library such as front and rear interface)
│   │
│   └───DtCoco.Api.Backend
│   └───DtCoco.Api.Web
│   └───... Other project api
│
└───Tasks
│   │
│   └───DtCoco.Task.InitData
│   └───... Other task
│
└───Tests
│   │
│   └───DtCoco.UnitTest
│   └───... Other test
│
```
