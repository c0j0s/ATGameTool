# ATPay 
ATPay项目包含了尝试过的充值自动化方案系统。

## ATPayBot 机器人
酷Q机器人，通过对机器人发达命令，实现便捷充值功能。
此方案属于半自动方案，由于无法得到支付状态，实现不了全自动方案。

__使用流程__   
用户支付 -> 管理员收到支付信息 -> 发送充值命令给机器人 -> 完成充值

__使用手册__  

| 功能 | 语句 | 备注 |
| ---------- | --- | --- |
| 充值 | 充值 金/银 <账号> <金额> | 支持多行批量充值 |
| 换区 | 选择服务区/换区 <区名> | 需配置服务区配置文件 |

__服务区配置文件__  
文件位置： com.cojos.atpaybot/config.txt

配置参数：  
```txt
<区名>,<服务器IP地址>,<数据库账号>,<数据库密码>,<库名>,<端口>
```

## ATPayBot 机器人 V2

### 功能
- 批量充值
- 配置数据库
- 定时任务
- 问答系统
- 撤回消息（待定）

### 程序栈
```
QQ <-> 酷Q <-> 机器人 <-> Sqlite数据库 （问答/定时任务/充值配置） 
                     <-> MySql数据库 （充值）
```

### 使用手册
#### 初始设置
![initialisation](https://github.com/c0j0s/ATPay/blob/v2/src/1.png)  

|设置|详情|
|-----|-----|
|数据库配置|一般数据库连接配置|
|管理员QQ|能使用管理员功能的QQ号|
|开启群|开启机器人的群号|
|图灵密钥|连接图灵机器人后台的密钥|

#### 管理员功能

|功能|帮助|样式|
|-----|-----|----|
|充值|![initialisation](https://github.com/c0j0s/ATPay/blob/v2/src/2_1.png)|![initialisation](https://github.com/c0j0s/ATPay/blob/v2/src/2_2.png)|
|更换设置|![initialisation](https://github.com/c0j0s/ATPay/blob/v2/src/3_1.png)|![initialisation](https://github.com/c0j0s/ATPay/blob/v2/src/3_2.png)|

---
后续添加更多功能

#### 聊天功能
该机器人已连接图灵机器人后台，实现简单聊天功能。管理员可在图灵机器人后台训练/添加新技能。
