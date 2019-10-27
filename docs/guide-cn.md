## 项目结构说明

```
project/src
│
└───Application(输出项目的一些公告依赖)
│   │
│   └───DtCoco.Core(项目中一些通用代码的封装)
│   └───DtCoco.Data(实体，ORM的扩展等代码)
│   └───DtCoco.Framework(前台验权限，输出项目的通用代码提取，对第三方组件的二次封装)
│   └───DtCoco.Services(项目业务模块代码)
│   
└───Core(一些第三方库的封装，独立组件，可以发布nuget包的库)
│   │
│   └───DtCoco.Interface
│   └───DtCoco.Orm.EntityFramework
│   └───DtCoco.Orm.SqlSugar
│   └───DtCoco.Oss.Aliyun
│   └───DtCoco.Oss.Minio
│   └───... Other components
│
└───Main(应用程序输出库，如前端和后端接口)
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
