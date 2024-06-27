# WindowsServiceByTopshelf

## 在开发阶段，你可能希望直接从命令行运行服务，而不是安装为系统服务，以便于调试。
使用console命令代替安装：
WindowsServiceByTopshelf run

## 安装和管理服务
WindowsServiceByTopshelf install
WindowsServiceByTopshelf start
WindowsServiceByTopshelf stop
WindowsServiceByTopshelf uninstall

## 服务管理器（Services.msc）
- 打开“运行”对话框：按Win + R键。
- 输入命令：在“运行”对话框中输入services.msc，然后按回车键。
- 管理服务：服务管理界面将会打开，列出了所有系统服务。
在这里，你可以双击一个服务来查看其属性，
包括启动类型、登录身份、恢复选项等，并可以进行启动、停止、暂停、恢复等操作。