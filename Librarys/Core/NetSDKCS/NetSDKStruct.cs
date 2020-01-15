﻿
//if the OS is linux 64bit open this define when compile the library.﻿ and open define LINUX in the OriginalSDK.cs file.
//如果系统是Linux 64位编译的时候请打下下面的宏,以及OriginalSDK.cs文件中的宏
//#define LINUX_X64   

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace NetSDKCS
{
  /// <summary>
  /// initialization parameter structure
  /// 初始化接口参数结构体
  /// </summary>
  public struct NETSDK_INIT_PARAM
  {
    /// <summary>
    /// specify netsdk's normal network process thread number, zero means using default value
    /// 指定NetSDK常规网络处理线程数, 当值为0时, 使用内部默认值
    /// </summary>
    public int nThreadNum;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>                      
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  }

  /// <summary>
  /// SDK error code number enumeration
  /// SDK错误码枚举
  /// </summary>
  public enum EM_ErrorCode : uint
  {
    /// <summary>
    /// No error
    /// 没有错误
    /// </summary>
    NET_NOERROR = 0,
    /// <summary>
    /// Unknown error
    /// 未知错误
    /// </summary>
    NET_ERROR = 0xFFFFFFFF,
    /// <summary>
    /// Windows system error
    /// Windows系统错误
    /// </summary>
    NET_SYSTEM_ERROR = 0x80000000 | 1,
    /// <summary>
    /// Protocol error it may result from network timeout
    /// 网络错误,可能是因为网络超时
    /// </summary>
    NET_NETWORK_ERROR = 0x80000000 | 2,
    /// <summary>
    /// Device protocol does not match
    /// 设备协议不匹配
    /// </summary>
    NET_DEV_VER_NOMATCH = 0x80000000 | 3,
    /// <summary>
    /// Handle is invalid
    /// 句柄无效
    /// </summary>
    NET_INVALID_HANDLE = 0x80000000 | 4,
    /// <summary>
    /// Failed to open channel
    /// 打开通道失败
    /// </summary>
    NET_OPEN_CHANNEL_ERROR = 0x80000000 | 5,
    /// <summary>
    /// Failed to close channel
    /// 关闭通道失败
    /// </summary>
    NET_CLOSE_CHANNEL_ERROR = 0x80000000 | 6,
    /// <summary>
    /// User parameter is illegal
    /// 用户参数不合法
    /// </summary>
    NET_ILLEGAL_PARAM = 0x80000000 | 7,
    /// <summary>
    /// SDK initialization error
    /// SDK初始化出错
    /// </summary>
    NET_SDK_INIT_ERROR = 0x80000000 | 8,
    /// <summary>
    /// SDK clear error 
    /// SDK清理出错
    /// </summary>
    NET_SDK_UNINIT_ERROR = 0x80000000 | 9,
    /// <summary>
    /// Error occurs when apply for render resources
    /// 申请render资源出错
    /// </summary>
    NET_RENDER_OPEN_ERROR = 0x80000000 | 10,
    /// <summary>
    /// Error occurs when opening the decoder library
    /// 打开解码库出错
    /// </summary>
    NET_DEC_OPEN_ERROR = 0x80000000 | 11,
    /// <summary>
    /// Error occurs when closing the decoder library
    /// 关闭解码库出错
    /// </summary>
    NET_DEC_CLOSE_ERROR = 0x80000000 | 12,
    /// <summary>
    /// The detected channel number is 0 in multiple-channel preview
    /// 多画面预览中检测到通道数为0
    /// </summary>
    NET_MULTIPLAY_NOCHANNEL = 0x80000000 | 13,
    /// <summary>
    /// Failed to initialize record library
    /// 录音库初始化失败
    /// </summary>
    NET_TALK_INIT_ERROR = 0x80000000 | 14,
    /// <summary>
    /// The record library has not been initialized
    /// 录音库未经初始化
    /// </summary>
    NET_TALK_NOT_INIT = 0x80000000 | 15,
    /// <summary>
    /// Error occurs when sending out audio data
    /// 发送音频数据出错
    /// </summary>
    NET_TALK_SENDDATA_ERROR = 0x80000000 | 16,
    /// <summary>
    /// The real-time has been protected
    /// 实时数据已经处于保存状态
    /// </summary>
    NET_REAL_ALREADY_SAVING = 0x80000000 | 17,
    /// <summary>
    /// The real-time data has not been save
    /// 未保存实时数据
    /// </summary>
    NET_NOT_SAVING = 0x80000000 | 18,
    /// <summary>
    /// Error occurs when opening the file
    /// 打开文件出错
    /// </summary>
    NET_OPEN_FILE_ERROR = 0x80000000 | 19,
    /// <summary>
    /// Failed to enable PTZ to control timer
    /// 启动云台控制定时器失败
    /// </summary>
    NET_PTZ_SET_TIMER_ERROR = 0x80000000 | 20,
    /// <summary>
    /// Error occurs when verify returned data
    /// 对返回数据的校验出错
    /// </summary>
    NET_RETURN_DATA_ERROR = 0x80000000 | 21,
    /// <summary>
    /// There is no sufficient buffer
    /// 没有足够的缓存
    /// </summary>
    NET_INSUFFICIENT_BUFFER = 0x80000000 | 22,
    /// <summary>
    /// The current SDK does not support this fucntion
    /// 当前SDK未支持该功能
    /// </summary>
    NET_NOT_SUPPORTED = 0x80000000 | 23,
    /// <summary>
    /// There is no searched result
    /// 查询不到录象
    /// </summary>
    NET_NO_RECORD_FOUND = 0x80000000 | 24,
    /// <summary>
    /// You have no operation right
    /// 无操作权限
    /// </summary>
    NET_NOT_AUTHORIZED = 0x80000000 | 25,
    /// <summary>
    /// Can not operate right now
    /// 暂时无法执行
    /// </summary>
    NET_NOT_NOW = 0x80000000 | 26,
    /// <summary>
    /// There is no audio talk channel
    /// 未发现对讲通道
    /// </summary>
    NET_NO_TALK_CHANNEL = 0x80000000 | 27,
    /// <summary>
    /// There is no audio
    /// 未发现音频
    /// </summary>
    NET_NO_AUDIO = 0x80000000 | 28,
    /// <summary>
    /// The network SDK has not been initialized
    /// 网络SDK未经初始化
    /// </summary>
    NET_NO_INIT = 0x80000000 | 29,
    /// <summary>
    /// The download completed
    /// 下载已结束
    /// </summary>
    NET_DOWNLOAD_END = 0x80000000 | 30,
    /// <summary>
    /// There is no searched result
    /// 查询结果为空
    /// </summary>
    NET_EMPTY_LIST = 0x80000000 | 31,
    /// <summary>
    /// Failed to get system property setup
    /// 获取系统属性配置失败
    /// </summary>
    NET_ERROR_GETCFG_SYSATTR = 0x80000000 | 32,
    /// <summary>
    /// Failed to get SN
    /// 获取序列号失败
    /// </summary>
    NET_ERROR_GETCFG_SERIAL = 0x80000000 | 33,
    /// <summary>
    /// Failed to get general property
    /// 获取常规属性失败
    /// </summary>
    NET_ERROR_GETCFG_GENERAL = 0x80000000 | 34,
    /// <summary>
    /// Failed to get DSP capacity description
    /// 获取DSP能力描述失败
    /// </summary>
    NET_ERROR_GETCFG_DSPCAP = 0x80000000 | 35,
    /// <summary>
    /// Failed to get network channel setup
    /// 获取网络配置失败
    /// </summary>
    NET_ERROR_GETCFG_NETCFG = 0x80000000 | 36,
    /// <summary>
    /// Failed to get channel name
    /// 获取通道名称失败
    /// </summary>
    NET_ERROR_GETCFG_CHANNAME = 0x80000000 | 37,
    /// <summary>
    /// Failed to get video property
    /// 获取视频属性失败
    /// </summary>
    NET_ERROR_GETCFG_VIDEO = 0x80000000 | 38,
    /// <summary>
    /// Failed to get record setup
    /// 获取录象配置失败
    /// </summary>
    NET_ERROR_GETCFG_RECORD = 0x80000000 | 39,
    /// <summary>
    /// Failed to get decoder protocol name
    /// 获取解码器协议名称失败
    /// </summary>
    NET_ERROR_GETCFG_PRONAME = 0x80000000 | 40,
    /// <summary>
    /// Failed to get 232 COM function name
    /// 获取232串口功能名称失败
    /// </summary>
    NET_ERROR_GETCFG_FUNCNAME = 0x80000000 | 41,
    /// <summary>
    /// Failed to get decoder property
    /// 获取解码器属性失败
    /// </summary>
    NET_ERROR_GETCFG_485DECODER = 0x80000000 | 42,
    /// <summary>
    /// Failed to get 232 COM setup
    /// 获取232串口配置失败
    /// </summary>
    NET_ERROR_GETCFG_232COM = 0x80000000 | 43,
    /// <summary>
    /// Failed to get external alarm input setup
    /// 获取外部报警输入配置失败
    /// </summary>
    NET_ERROR_GETCFG_ALARMIN = 0x80000000 | 44,
    /// <summary>
    /// Failed to get motion detection alarm
    /// 获取动态检测报警失败
    /// </summary>
    NET_ERROR_GETCFG_ALARMDET = 0x80000000 | 45,
    /// <summary>
    /// Failed to get device time
    /// 获取设备时间失败
    /// </summary>
    NET_ERROR_GETCFG_SYSTIME = 0x80000000 | 46,
    /// <summary>
    /// Failed to get preview parameter
    /// 获取预览参数失败
    /// </summary>
    NET_ERROR_GETCFG_PREVIEW = 0x80000000 | 47,
    /// <summary>
    /// Failed to get audio maintenance setup
    /// 获取自动维护配置失败
    /// </summary>
    NET_ERROR_GETCFG_AUTOMT = 0x80000000 | 48,
    /// <summary>
    /// Failed to get video matrix setup
    /// 获取视频矩阵配置失败
    /// </summary>
    NET_ERROR_GETCFG_VIDEOMTRX = 0x80000000 | 49,
    /// <summary>
    /// Failed to get privacy mask zone setup
    /// 获取区域遮挡配置失败
    /// </summary>
    NET_ERROR_GETCFG_COVER = 0x80000000 | 50,
    /// <summary>
    /// Failed to get video watermark setup
    /// 获取图象水印配置失败
    /// </summary>
    NET_ERROR_GETCFG_WATERMAKE = 0x80000000 | 51,
    /// <summary>
    /// Failed to get config￡omulticast port by channel
    /// 获取配置失败位置：组播端口按通道配置
    /// </summary>
    NET_ERROR_GETCFG_MULTICAST = 0x80000000 | 52,
    /// <summary>
    /// Failed to modify general property
    /// 修改常规属性失败
    /// </summary>
    NET_ERROR_SETCFG_GENERAL = 0x80000000 | 55,
    /// <summary>
    /// Failed to modify channel setup
    /// 修改网络配置失败
    /// </summary>
    NET_ERROR_SETCFG_NETCFG = 0x80000000 | 56,
    /// <summary>
    /// Failed to modify channel name
    /// 修改通道名称失败
    /// </summary>
    NET_ERROR_SETCFG_CHANNAME = 0x80000000 | 57,
    /// <summary>
    /// Failed to modify video channel
    /// 修改视频属性失败
    /// </summary>
    NET_ERROR_SETCFG_VIDEO = 0x80000000 | 58,
    /// <summary>
    /// Failed to modify record setup
    /// 修改录象配置失败
    /// </summary>
    NET_ERROR_SETCFG_RECORD = 0x80000000 | 59,
    /// <summary>
    /// Failed to modify decoder property 
    /// 修改解码器属性失败
    /// </summary>
    NET_ERROR_SETCFG_485DECODER = 0x80000000 | 60,
    /// <summary>
    /// Failed to modify 232 COM setup
    /// 修改232串口配置失败
    /// </summary>
    NET_ERROR_SETCFG_232COM = 0x80000000 | 61,
    /// <summary>
    /// Failed to modify external input alarm setup
    /// 修改外部输入报警配置失败
    /// </summary>
    NET_ERROR_SETCFG_ALARMIN = 0x80000000 | 62,
    /// <summary>
    /// Failed to modify motion detection alarm setup
    /// 修改动态检测报警配置失败
    /// </summary>
    NET_ERROR_SETCFG_ALARMDET = 0x80000000 | 63,
    /// <summary>
    /// Failed to modify device time
    /// 修改设备时间失败
    /// </summary>
    NET_ERROR_SETCFG_SYSTIME = 0x80000000 | 64,
    /// <summary>
    /// Failed to modify preview parameter
    /// 修改预览参数失败
    /// </summary>
    NET_ERROR_SETCFG_PREVIEW = 0x80000000 | 65,
    /// <summary>
    /// Failed to modify auto maintenance setup
    /// 修改自动维护配置失败
    /// </summary>
    NET_ERROR_SETCFG_AUTOMT = 0x80000000 | 66,
    /// <summary>
    /// Failed to modify video matrix setup
    /// 修改视频矩阵配置失败
    /// </summary>
    NET_ERROR_SETCFG_VIDEOMTRX = 0x80000000 | 67,
    /// <summary>
    /// Failed to modify privacy mask zone
    /// 修改区域遮挡配置失败
    /// </summary>
    NET_ERROR_SETCFG_COVER = 0x80000000 | 68,
    /// <summary>
    /// Failed to modify video watermark setup
    /// 修改图象水印配置失败
    /// </summary>
    NET_ERROR_SETCFG_WATERMAKE = 0x80000000 | 69,
    /// <summary>
    /// Failed to modify wireless network information
    /// 修改无线网络信息失败
    /// </summary>
    NET_ERROR_SETCFG_WLAN = 0x80000000 | 70,
    /// <summary>
    /// Failed to select wireless network device
    /// 选择无线网络设备失败
    /// </summary>
    NET_ERROR_SETCFG_WLANDEV = 0x80000000 | 71,
    /// <summary>
    /// Failed to modify the actively registration parameter setup
    /// 修改主动注册参数配置失败
    /// </summary>
    NET_ERROR_SETCFG_REGISTER = 0x80000000 | 72,
    /// <summary>
    /// Failed to modify camera property
    /// 修改摄像头属性配置失败
    /// </summary>
    NET_ERROR_SETCFG_CAMERA = 0x80000000 | 73,
    /// <summary>
    /// Failed to modify IR alarm setup
    /// 修改红外报警配置失败
    /// </summary>
    NET_ERROR_SETCFG_INFRARED = 0x80000000 | 74,
    /// <summary>
    /// Failed to modify audio alarm setup
    /// 修改音频报警配置失败
    /// </summary>
    NET_ERROR_SETCFG_SOUNDALARM = 0x80000000 | 75,
    /// <summary>
    /// Failed to modify storage position setup
    /// 修改存储位置配置失败
    /// </summary>
    NET_ERROR_SETCFG_STORAGE = 0x80000000 | 76,
    /// <summary>
    /// The audio encode port has not been successfully initialized
    /// 音频编码接口没有成功初始化
    /// </summary>
    NET_AUDIOENCODE_NOTINIT = 0x80000000 | 77,
    /// <summary>
    /// The data are too long
    /// 数据过长
    /// </summary>
    NET_DATA_TOOLONGH = 0x80000000 | 78,
    /// <summary>
    /// The device does not support current operation
    /// 设备不支持该操作
    /// </summary>
    NET_UNSUPPORTED = 0x80000000 | 79,
    /// <summary>
    /// Device resources is not sufficient
    /// 设备资源不足
    /// </summary>
    NET_DEVICE_BUSY = 0x80000000 | 80,
    /// <summary>
    /// The server has boot up
    /// 服务器已经启动
    /// </summary>
    NET_SERVER_STARTED = 0x80000000 | 81,
    /// <summary>
    /// The server has not fully boot up
    /// 服务器尚未成功启动
    /// </summary>
    NET_SERVER_STOPPED = 0x80000000 | 82,
    /// <summary>
    /// Input serial number is not correct
    /// 输入序列号有误
    /// </summary>
    NET_LISTER_INCORRECT_SERIAL = 0x80000000 | 83,
    /// <summary>
    /// Failed to get HDD information
    /// 获取硬盘信息失败
    /// </summary>
    NET_QUERY_DISKINFO_FAILED = 0x80000000 | 84,
    /// <summary>
    /// Failed to get connect session information
    /// 获取连接Session信息
    /// </summary>
    NET_ERROR_GETCFG_SESSION = 0x80000000 | 85,
    /// <summary>
    /// The password you typed is incorrect. You have exceeded the maximum number of retries
    /// 输入密码错误超过限制次数
    /// </summary>
    NET_USER_FLASEPWD_TRYTIME = 0x80000000 | 86,
    /// <summary>
    /// Password is not correct
    /// 密码不正确
    /// </summary>
    NET_LOGIN_ERROR_PASSWORD = 0x80000000 | 100,
    /// <summary>
    /// The account does not exist
    /// 帐户不存在
    /// </summary>
    NET_LOGIN_ERROR_USER = 0x80000000 | 101,
    /// <summary>
    /// Time out for log in returned value
    /// 等待登录返回超时
    /// </summary>
    NET_LOGIN_ERROR_TIMEOUT = 0x80000000 | 102,
    /// <summary>
    /// The account has logged in
    /// 帐号已登录
    /// </summary>
    NET_LOGIN_ERROR_RELOGGIN = 0x80000000 | 103,
    /// <summary>
    /// The account has been locked
    /// 帐号已被锁定
    /// </summary>
    NET_LOGIN_ERROR_LOCKED = 0x80000000 | 104,
    /// <summary>
    /// The account bas been in the black list
    /// 帐号已被列为黑名单
    /// </summary>
    NET_LOGIN_ERROR_BLACKLIST = 0x80000000 | 105,
    /// <summary>
    /// Resources are not sufficient. System is busy now
    /// 资源不足,系统忙
    /// </summary>
    NET_LOGIN_ERROR_BUSY = 0x80000000 | 106,
    /// <summary>
    /// Time out. Please check network and try again
    /// 登录设备超时,请检查网络并重试
    /// </summary>
    NET_LOGIN_ERROR_CONNECT = 0x80000000 | 107,
    /// <summary>
    /// Network connection failed
    /// 网络连接失败
    /// </summary>
    NET_LOGIN_ERROR_NETWORK = 0x80000000 | 108,
    /// <summary>
    /// Successfully logged in the device but can not create video channel. Please check network connection
    /// 登录设备成功,但无法创建视频通道,请检查网络状况
    /// </summary>
    NET_LOGIN_ERROR_SUBCONNECT = 0x80000000 | 109,
    /// <summary>
    /// exceed the max connect number
    /// 超过最大连接数
    /// </summary>
    NET_LOGIN_ERROR_MAXCONNECT = 0x80000000 | 110,
    /// <summary>
    /// protocol 3 support
    /// 只支持3代协议
    /// </summary>
    NET_LOGIN_ERROR_PROTOCOL3_ONLY = 0x80000000 | 111,
    /// <summary>
    /// There is no USB or USB info error
    /// 未插入U盾或U盾信息错误
    /// </summary>
    NET_LOGIN_ERROR_UKEY_LOST = 0x80000000 | 112,
    /// <summary>
    /// Client-end IP address has no right to login
    /// 客户端IP地址没有登录权限
    /// </summary>
    NET_LOGIN_ERROR_NO_AUTHORIZED = 0x80000000 | 113,
    /// <summary>
    /// user or password error
    /// 账号或密码错误 
    /// </summary>
    NET_LOGIN_ERROR_USER_OR_PASSOWRD = 0X80000000 | 117,
    /// <summary>
    /// Error occurs when Render library open audio
    /// Render库打开音频出错
    /// </summary>
    NET_RENDER_SOUND_ON_ERROR = 0x80000000 | 120,
    /// <summary>
    /// Error occurs when Render library close audio
    /// Render库关闭音频出错
    /// </summary>
    NET_RENDER_SOUND_OFF_ERROR = 0x80000000 | 121,
    /// <summary>
    /// Error occurs when Render library control volume
    /// Render库控制音量出错
    /// </summary>
    NET_RENDER_SET_VOLUME_ERROR = 0x80000000 | 122,
    /// <summary>
    /// Error occurs when Render library set video parameter
    /// Render库设置画面参数出错
    /// </summary>
    NET_RENDER_ADJUST_ERROR = 0x80000000 | 123,
    /// <summary>
    /// Error occurs when Render library pause play
    /// Render库暂停播放出错
    /// </summary>
    NET_RENDER_PAUSE_ERROR = 0x80000000 | 124,
    /// <summary>
    /// Render library snapshot error
    /// Render库抓图出错
    /// </summary>
    NET_RENDER_SNAP_ERROR = 0x80000000 | 125,
    /// <summary>
    /// Render library stepper error
    /// Render库步进出错
    /// </summary>
    NET_RENDER_STEP_ERROR = 0x80000000 | 126,
    /// <summary>
    /// Error occurs when Render library set frame rate
    /// Render库设置帧率出错
    /// </summary>
    NET_RENDER_FRAMERATE_ERROR = 0x80000000 | 127,
    /// <summary>
    /// Error occurs when Render lib setting show region
    /// Render库设置显示区域出错
    /// </summary>
    NET_RENDER_DISPLAYREGION_ERROR = 0x80000000 | 128,
    /// <summary>
    /// An error occurred when Render library getting current play time
    /// Render库获取当前播放时间出错
    /// </summary>
    NET_RENDER_GETOSDTIME_ERROR = 0x80000000 | 129,
    /// <summary>
    /// Group name has been existed
    /// 组名已存在
    /// </summary>
    NET_GROUP_EXIST = 0x80000000 | 140,
    /// <summary>
    /// The group name does not exist
    /// 组名不存在
    /// </summary>
    NET_GROUP_NOEXIST = 0x80000000 | 141,
    /// <summary>
    /// The group right exceeds the right list
    /// 组的权限超出权限列表范围
    /// </summary>
    NET_GROUP_RIGHTOVER = 0x80000000 | 142,
    /// <summary>
    /// The group can not be removed since there is user in it
    /// 组下有用户,不能删除
    /// </summary>
    NET_GROUP_HAVEUSER = 0x80000000 | 143,
    /// <summary>
    /// The user has used one of the group right. It can not be removed
    /// 组的某个权限被用户使用,不能出除
    /// </summary>
    NET_GROUP_RIGHTUSE = 0x80000000 | 144,
    /// <summary>
    /// New group name has been existed
    /// 新组名同已有组名重复
    /// </summary>
    NET_GROUP_SAMENAME = 0x80000000 | 145,
    /// <summary>
    /// The user name has been existed
    /// 用户已存在
    /// </summary>
    NET_USER_EXIST = 0x80000000 | 146,
    /// <summary>
    /// The account does not exist
    /// 用户不存在
    /// </summary>
    NET_USER_NOEXIST = 0x80000000 | 147,
    /// <summary>
    /// User right exceeds the group right
    /// 用户权限超出组权限
    /// </summary>
    NET_USER_RIGHTOVER = 0x80000000 | 148,
    /// <summary>
    /// Reserved account. It does not allow to be modified
    /// 保留帐号,不容许修改密码
    /// </summary>
    NET_USER_PWD = 0x80000000 | 149,
    /// <summary>
    /// password is not correct
    /// 密码不正确
    /// </summary>
    NET_USER_FLASEPWD = 0x80000000 | 150,
    /// <summary>
    /// Password is invalid
    /// 密码不匹配
    /// </summary>
    NET_USER_NOMATCHING = 0x80000000 | 151,
    /// <summary>
    /// account in use
    /// 账号正在使用中
    /// </summary>
    NET_USER_INUSE = 0x80000000 | 152,
    /// <summary>
    /// Failed to get network card setup
    /// 获取网卡配置失败
    /// </summary>
    NET_ERROR_GETCFG_ETHERNET = 0x80000000 | 300,
    /// <summary>
    /// Failed to get wireless network information
    /// 获取无线网络信息失败
    /// </summary>
    NET_ERROR_GETCFG_WLAN = 0x80000000 | 301,
    /// <summary>
    /// Failed to get wireless network device
    /// 获取无线网络设备失败
    /// </summary>
    NET_ERROR_GETCFG_WLANDEV = 0x80000000 | 302,
    /// <summary>
    /// Failed to get actively registration parameter
    /// 获取主动注册参数失败
    /// </summary>
    NET_ERROR_GETCFG_REGISTER = 0x80000000 | 303,
    /// <summary>
    /// Failed to get camera property
    /// 获取摄像头属性失败
    /// </summary>
    NET_ERROR_GETCFG_CAMERA = 0x80000000 | 304,
    /// <summary>
    /// Failed to get IR alarm setup
    /// 获取红外报警配置失败
    /// </summary>
    NET_ERROR_GETCFG_INFRARED = 0x80000000 | 305,
    /// <summary>
    /// Failed to get audio alarm setup
    /// 获取音频报警配置失败
    /// </summary>
    NET_ERROR_GETCFG_SOUNDALARM = 0x80000000 | 306,
    /// <summary>
    /// Failed to get storage position
    /// 获取存储位置配置失败
    /// </summary>
    NET_ERROR_GETCFG_STORAGE = 0x80000000 | 307,
    /// <summary>
    /// Failed to get mail setup.
    /// 获取邮件配置失败
    /// </summary>
    NET_ERROR_GETCFG_MAIL = 0x80000000 | 308,
    /// <summary>
    /// Can not set right now.
    /// 暂时无法设置
    /// </summary>
    NET_CONFIG_DEVBUSY = 0x80000000 | 309,
    /// <summary>
    /// The configuration setup data are illegal.
    /// 配置数据不合法
    /// </summary>
    NET_CONFIG_DATAILLEGAL = 0x80000000 | 310,
    /// <summary>
    /// Failed to get DST setup
    /// 获取夏令时配置失败
    /// </summary>
    NET_ERROR_GETCFG_DST = 0x80000000 | 311,
    /// <summary>
    /// Failed to set DST 
    /// 设置夏令时配置失败
    /// </summary>
    NET_ERROR_SETCFG_DST = 0x80000000 | 312,
    /// <summary>
    /// Failed to get video osd setup.
    /// 获取视频OSD叠加配置失败
    /// </summary>
    NET_ERROR_GETCFG_VIDEO_OSD = 0x80000000 | 313,
    /// <summary>
    /// Failed to set video osd 
    /// 设置视频OSD叠加配置失败
    /// </summary>
    NET_ERROR_SETCFG_VIDEO_OSD = 0x80000000 | 314,
    /// <summary>
    /// Failed to get CDMA\GPRS configuration
    /// 获取CDMA\GPRS网络配置失败
    /// </summary>
    NET_ERROR_GETCFG_GPRSCDMA = 0x80000000 | 315,
    /// <summary>
    /// Failed to set CDMA\GPRS configuration
    /// 设置CDMA\GPRS网络配置失败
    /// </summary>
    NET_ERROR_SETCFG_GPRSCDMA = 0x80000000 | 316,
    /// <summary>
    /// Failed to get IP Filter configuration
    /// 获取IP过滤配置失败
    /// </summary>
    NET_ERROR_GETCFG_IPFILTER = 0x80000000 | 317,
    /// <summary>
    /// Failed to set IP Filter configuration
    /// 设置IP过滤配置失败
    /// </summary>
    NET_ERROR_SETCFG_IPFILTER = 0x80000000 | 318,
    /// <summary>
    /// Failed to get Talk Encode configuration
    /// 获取语音对讲编码配置失败
    /// </summary>
    NET_ERROR_GETCFG_TALKENCODE = 0x80000000 | 319,
    /// <summary>
    /// Failed to set Talk Encode configuration
    /// 设置语音对讲编码配置失败
    /// </summary>
    NET_ERROR_SETCFG_TALKENCODE = 0x80000000 | 320,
    /// <summary>
    /// Failed to get The length of the video package configuration
    /// 获取录像打包长度配置失败
    /// </summary>
    NET_ERROR_GETCFG_RECORDLEN = 0x80000000 | 321,
    /// <summary>
    /// Failed to set The length of the video package configuration
    /// 设置录像打包长度配置失败
    /// </summary>
    NET_ERROR_SETCFG_RECORDLEN = 0x80000000 | 322,
    /// <summary>
    /// Not support Network hard disk partition
    /// 不支持网络硬盘分区
    /// </summary>
    NET_DONT_SUPPORT_SUBAREA = 0x80000000 | 323,
    /// <summary>
    /// Failed to get the register server information
    /// 获取设备上主动注册服务器信息失败
    /// </summary>
    NET_ERROR_GET_AUTOREGSERVER = 0x80000000 | 324,
    /// <summary>
    /// Failed to control actively registration
    /// 主动注册重定向注册错误
    /// </summary>
    NET_ERROR_CONTROL_AUTOREGISTER = 0x80000000 | 325,
    /// <summary>
    /// Failed to disconnect actively registration
    /// 断开主动注册服务器错误
    /// </summary>
    NET_ERROR_DISCONNECT_AUTOREGISTER = 0x80000000 | 326,
    /// <summary>
    /// Failed to get mms configuration
    /// 获取mms配置失败
    /// </summary>
    NET_ERROR_GETCFG_MMS = 0x80000000 | 327,
    /// <summary>
    /// Failed to set mms configuration
    /// 设置mms配置失败
    /// </summary>
    NET_ERROR_SETCFG_MMS = 0x80000000 | 328,
    /// <summary>
    /// Failed to get SMS configuration
    /// 获取短信激活无线连接配置失败
    /// </summary>
    NET_ERROR_GETCFG_SMSACTIVATION = 0x80000000 | 329,
    /// <summary>
    /// Failed to set SMS configuration
    /// 设置短信激活无线连接配置失败
    /// </summary>
    NET_ERROR_SETCFG_SMSACTIVATION = 0x80000000 | 330,
    /// <summary>
    /// Failed to get activation of a wireless connection
    /// 获取拨号激活无线连接配置失败
    /// </summary>
    NET_ERROR_GETCFG_DIALINACTIVATION = 0x80000000 | 331,
    /// <summary>
    /// Failed to set activation of a wireless connection
    /// 设置拨号激活无线连接配置失败
    /// </summary>
    NET_ERROR_SETCFG_DIALINACTIVATION = 0x80000000 | 332,
    /// <summary>
    /// Failed to get the parameter of video output
    /// 查询视频输出参数配置失败
    /// </summary>
    NET_ERROR_GETCFG_VIDEOOUT = 0x80000000 | 333,
    /// <summary>
    /// Failed to set the configuration of video output
    /// 设置视频输出参数配置失败
    /// </summary>
    NET_ERROR_SETCFG_VIDEOOUT = 0x80000000 | 334,
    /// <summary>
    /// Failed to get osd overlay enabling
    /// 获取osd叠加使能配置失败
    /// </summary>
    NET_ERROR_GETCFG_OSDENABLE = 0x80000000 | 335,
    /// <summary>
    /// Failed to set OSD overlay enabling
    /// 设置osd叠加使能配置失败
    /// </summary>
    NET_ERROR_SETCFG_OSDENABLE = 0x80000000 | 336,
    /// <summary>
    /// Failed to set digital input configuration of front encoders
    /// 设置数字通道前端编码接入配置失败
    /// </summary>
    NET_ERROR_SETCFG_ENCODERINFO = 0x80000000 | 337,
    /// <summary>
    /// Failed to get TV adjust configuration
    /// 获取TV调节配置失败
    /// </summary>
    NET_ERROR_GETCFG_TVADJUST = 0x80000000 | 338,
    /// <summary>
    /// Failed to set TV adjust configuration
    /// 设置TV调节配置失败
    /// </summary>
    NET_ERROR_SETCFG_TVADJUST = 0x80000000 | 339,
    /// <summary>
    /// Failed to request to establish a connection
    /// 请求建立连接失败
    /// </summary>
    NET_ERROR_CONNECT_FAILED = 0x80000000 | 340,
    /// <summary>
    /// Failed to request to upload burn files
    /// 请求刻录文件上传失败
    /// </summary>
    NET_ERROR_SETCFG_BURNFILE = 0x80000000 | 341,
    /// <summary>
    /// Failed to get capture configuration information
    /// 获取抓包配置信息失败
    /// </summary>
    NET_ERROR_SNIFFER_GETCFG = 0x80000000 | 342,
    /// <summary>
    /// Failed to set capture configuration information
    /// 设置抓包配置信息失败
    /// </summary>
    NET_ERROR_SNIFFER_SETCFG = 0x80000000 | 343,
    /// <summary>
    /// Failed to get download restrictions information
    /// 查询下载限制信息失败
    /// </summary>
    NET_ERROR_DOWNLOADRATE_GETCFG = 0x80000000 | 344,
    /// <summary>
    /// Failed to set download restrictions information
    /// 设置下载限制信息失败
    /// </summary>
    NET_ERROR_DOWNLOADRATE_SETCFG = 0x80000000 | 345,
    /// <summary>
    /// Failed to query serial port parameters
    /// 查询串口参数失败
    /// </summary>
    NET_ERROR_SEARCH_TRANSCOM = 0x80000000 | 346,
    /// <summary>
    /// Failed to get the preset info
    /// 获取预制点信息错误
    /// </summary>
    NET_ERROR_GETCFG_POINT = 0x80000000 | 347,
    /// <summary>
    /// Failed to set the preset info
    /// 设置预制点信息错误
    /// </summary>
    NET_ERROR_SETCFG_POINT = 0x80000000 | 348,
    /// <summary>
    /// SDK log out the device abnormally
    /// SDK没有正常登出设备
    /// </summary>
    NET_SDK_LOGOUT_ERROR = 0x80000000 | 349,
    /// <summary>
    /// Failed to get vehicle configuration
    /// 获取车载配置失败
    /// </summary>
    NET_ERROR_GET_VEHICLE_CFG = 0x80000000 | 350,
    /// <summary>
    /// Failed to set vehicle configuration
    /// 设置车载配置失败
    /// </summary>
    NET_ERROR_SET_VEHICLE_CFG = 0x80000000 | 351,
    /// <summary>
    /// Failed to get ATM overlay configuration
    /// 获取atm叠加配置失败
    /// </summary>
    NET_ERROR_GET_ATM_OVERLAY_CFG = 0x80000000 | 352,
    /// <summary>
    /// Failed to set ATM overlay configuration
    /// 设置atm叠加配置失败
    /// </summary>
    NET_ERROR_SET_ATM_OVERLAY_CFG = 0x80000000 | 353,
    /// <summary>
    /// Failed to get ATM overlay ability
    /// 获取atm叠加能力失败
    /// </summary>
    NET_ERROR_GET_ATM_OVERLAY_ABILITY = 0x80000000 | 354,
    /// <summary>
    /// Failed to get decoder tour configuration
    /// 获取解码器解码轮巡配置失败
    /// </summary>
    NET_ERROR_GET_DECODER_TOUR_CFG = 0x80000000 | 355,
    /// <summary>
    /// Failed to set decoder tour configuration
    /// 设置解码器解码轮巡配置失败
    /// </summary>
    NET_ERROR_SET_DECODER_TOUR_CFG = 0x80000000 | 356,
    /// <summary>
    /// Failed to control decoder tour
    /// 控制解码器解码轮巡失败
    /// </summary>
    NET_ERROR_CTRL_DECODER_TOUR = 0x80000000 | 357,
    /// <summary>
    /// Beyond the device supports for the largest number of user groups
    /// 超出设备支持最大用户组数目
    /// </summary>
    NET_GROUP_OVERSUPPORTNUM = 0x80000000 | 358,
    /// <summary>
    /// Beyond the device supports for the largest number of users
    /// 超出设备支持最大用户数目
    /// </summary>
    NET_USER_OVERSUPPORTNUM = 0x80000000 | 359,
    /// <summary>
    /// Failed to get SIP configuration
    /// 获取SIP配置失败
    /// </summary>
    NET_ERROR_GET_SIP_CFG = 0x80000000 | 368,
    /// <summary>
    /// Failed to set SIP configuration
    /// 设置SIP配置失败
    /// </summary>
    NET_ERROR_SET_SIP_CFG = 0x80000000 | 369,
    /// <summary>
    /// Failed to get SIP capability
    /// 获取SIP能力失败
    /// </summary>
    NET_ERROR_GET_SIP_ABILITY = 0x80000000 | 370,
    /// <summary>
    /// Failed to get "WIFI ap' configuration
    /// 获取WIFI ap配置失败
    /// </summary>
    NET_ERROR_GET_WIFI_AP_CFG = 0x80000000 | 371,
    /// <summary>
    /// Failed to set "WIFI ap" configuration
    /// 设置WIFI ap配置失败
    /// </summary>
    NET_ERROR_SET_WIFI_AP_CFG = 0x80000000 | 372,
    /// <summary>
    /// Failed to get decode policy
    /// 获取解码策略配置失败
    /// </summary>
    NET_ERROR_GET_DECODE_POLICY = 0x80000000 | 373,
    /// <summary>
    /// Failed to set decode policy
    /// 设置解码策略配置失败
    /// </summary>
    NET_ERROR_SET_DECODE_POLICY = 0x80000000 | 374,
    /// <summary>
    /// refuse talk
    /// 拒绝对讲
    /// </summary>
    NET_ERROR_TALK_REJECT = 0x80000000 | 375,
    /// <summary>
    /// talk has opened by other client
    /// 对讲被其他客户端打开
    /// </summary>
    NET_ERROR_TALK_OPENED = 0x80000000 | 376,
    /// <summary>
    /// resource conflict
    /// 资源冲突
    /// </summary>
    NET_ERROR_TALK_RESOURCE_CONFLICIT = 0x80000000 | 377,
    /// <summary>
    /// unsupported encode type
    /// 不支持的语音编码格式
    /// </summary>
    NET_ERROR_TALK_UNSUPPORTED_ENCODE = 0x80000000 | 378,
    /// <summary>
    /// no right
    /// 无权限
    /// </summary>
    NET_ERROR_TALK_RIGHTLESS = 0x80000000 | 379,
    /// <summary>
    /// request failed
    /// 请求对讲失败
    /// </summary>
    NET_ERROR_TALK_FAILED = 0x80000000 | 380,
    /// <summary>
    /// Failed to get device relative config
    /// 获取机器相关配置失败
    /// </summary>
    NET_ERROR_GET_MACHINE_CFG = 0x80000000 | 381,
    /// <summary>
    /// Failed to set device relative config
    /// 设置机器相关配置失败
    /// </summary>
    NET_ERROR_SET_MACHINE_CFG = 0x80000000 | 382,
    /// <summary>
    /// get data failed
    /// 设备无法获取当前请求数据
    /// </summary>
    NET_ERROR_GET_DATA_FAILED = 0x80000000 | 383,
    /// <summary>
    /// MAC validate failed
    /// MAC地址验证失败 
    /// </summary>
    NET_ERROR_MAC_VALIDATE_FAILED = 0x80000000 | 384,
    /// <summary>
    /// Failed to get server instance 
    /// 获取服务器实例失败
    /// </summary>
    NET_ERROR_GET_INSTANCE = 0x80000000 | 385,
    /// <summary>
    /// Generated json string is error
    /// 生成的jason字符串错误
    /// </summary>
    NET_ERROR_JSON_REQUEST = 0x80000000 | 386,
    /// <summary>
    /// The responding json string is error
    /// 响应的jason字符串错误
    /// </summary>
    NET_ERROR_JSON_RESPONSE = 0x80000000 | 387,
    /// <summary>
    /// The protocol version is lower than current version
    /// 协议版本低于当前使用的版本
    /// </summary>
    NET_ERROR_VERSION_HIGHER = 0x80000000 | 388,
    /// <summary>
    /// Hotspare disk operation failed. The capacity is low
    /// 热备操作失败, 容量不足
    /// </summary>
    NET_SPARE_NO_CAPACITY = 0x80000000 | 389,
    /// <summary>
    /// Display source is used by other output
    /// 显示源被其他输出占用
    /// </summary>
    NET_ERROR_SOURCE_IN_USE = 0x80000000 | 390,
    /// <summary>
    /// advanced users grab low-level user resource
    /// 高级用户抢占低级用户资源
    /// </summary>
    NET_ERROR_REAVE = 0x80000000 | 391,
    /// <summary>
    /// net forbid
    /// 禁止入网
    /// </summary>
    NET_ERROR_NETFORBID = 0x80000000 | 392,
    /// <summary>
    /// get MAC filter configuration error
    /// 获取MAC过滤配置失败
    /// </summary>
    NET_ERROR_GETCFG_MACFILTER = 0x80000000 | 393,
    /// <summary>
    /// set MAC filter configuration error
    /// 设置MAC过滤配置失败
    /// </summary>
    NET_ERROR_SETCFG_MACFILTER = 0x80000000 | 394,
    /// <summary>
    /// get IP/MAC filter configuration error
    /// 获取IP/MAC过滤配置失败
    /// </summary>
    NET_ERROR_GETCFG_IPMACFILTER = 0x80000000 | 395,
    /// <summary>
    /// set IP/MAC filter configuration error
    /// 设置IP/MAC过滤配置失败
    /// </summary>
    NET_ERROR_SETCFG_IPMACFILTER = 0x80000000 | 396,
    /// <summary>
    /// operation over time 
    /// 当前操作超时
    /// </summary>
    NET_ERROR_OPERATION_OVERTIME = 0x80000000 | 397,
    /// <summary>
    /// senior validation failure
    /// 高级校验失败
    /// </summary>
    NET_ERROR_SENIOR_VALIDATE_FAILED = 0x80000000 | 398,
    /// <summary>
    /// device ID is not exist
    /// 设备ID不存在
    /// </summary>
    NET_ERROR_DEVICE_ID_NOT_EXIST = 0x80000000 | 399,
    /// <summary>
    /// unsupport operation
    /// 不支持当前操作
    /// </summary>
    NET_ERROR_UNSUPPORTED = 0x80000000 | 400,
    /// <summary>
    /// proxy dll load error
    /// 代理库加载失败
    /// </summary>
    NET_ERROR_PROXY_DLLLOAD = 0x80000000 | 401,
    /// <summary>
    /// proxy user parameter is not legal
    /// 代理用户参数不合法
    /// </summary>
    NET_ERROR_PROXY_ILLEGAL_PARAM = 0x80000000 | 402,
    /// <summary>
    /// handle invalid
    /// 代理句柄无效
    /// </summary>
    NET_ERROR_PROXY_INVALID_HANDLE = 0x80000000 | 403,
    /// <summary>
    /// login device error
    /// 代理登入前端设备失败
    /// </summary>
    NET_ERROR_PROXY_LOGIN_DEVICE_ERROR = 0x80000000 | 404,
    /// <summary>
    /// start proxy server error
    /// 启动代理服务失败
    /// </summary>
    NET_ERROR_PROXY_START_SERVER_ERROR = 0x80000000 | 405,
    /// <summary>
    /// request speak failed
    /// 请求喊话失败
    /// </summary>
    NET_ERROR_SPEAK_FAILED = 0x80000000 | 406,
    /// <summary>
    /// unsupport F6
    /// 设备不支持此F6接口调用
    /// </summary>
    NET_ERROR_NOT_SUPPORT_F6 = 0x80000000 | 407,
    /// <summary>
    /// CD is not ready
    /// 光盘未就绪
    /// </summary>
    NET_ERROR_CD_UNREADY = 0x80000000 | 408,
    /// <summary>
    /// Directory does not exist
    /// 目录不存在
    /// </summary>
    NET_ERROR_DIR_NOT_EXIST = 0x80000000 | 409,
    /// <summary>
    /// The device does not support the segmentation model
    /// 设备不支持的分割模式
    /// </summary>
    NET_ERROR_UNSUPPORTED_SPLIT_MODE = 0x80000000 | 410,
    /// <summary>
    /// Open the window parameter is illegal
    /// 开窗参数不合法
    /// </summary>
    NET_ERROR_OPEN_WND_PARAM = 0x80000000 | 411,
    /// <summary>
    /// Open the window more than limit
    /// 开窗数量超过限制
    /// </summary>
    NET_ERROR_LIMITED_WND_COUNT = 0x80000000 | 412,
    /// <summary>
    /// Request command with the current pattern don't match
    /// 请求命令与当前模式不匹配
    /// </summary>
    NET_ERROR_UNMATCHED_REQUEST = 0x80000000 | 413,
    /// <summary>
    /// Render Library to enable high-definition image internal adjustment strategy error
    /// Render库启用高清图像内部调整策略出错
    /// </summary>
    NET_RENDER_ENABLELARGEPICADJUSTMENT_ERROR = 0x80000000 | 414,
    /// <summary>
    /// Upgrade equipment failure
    /// 设备升级失败
    /// </summary>
    NET_ERROR_UPGRADE_FAILED = 0x80000000 | 415,
    /// <summary>
    /// Can't find the target device
    /// 找不到目标设备
    /// </summary>
    NET_ERROR_NO_TARGET_DEVICE = 0x80000000 | 416,
    /// <summary>
    /// Can't find the verify device
    /// 找不到验证设备
    /// </summary>
    NET_ERROR_NO_VERIFY_DEVICE = 0x80000000 | 417,
    /// <summary>
    /// No cascade permissions
    /// 无级联权限
    /// </summary>
    NET_ERROR_CASCADE_RIGHTLESS = 0x80000000 | 418,
    /// <summary>
    /// low priority
    /// 低优先级
    /// </summary>
    NET_ERROR_LOW_PRIORITY = 0x80000000 | 419,
    /// <summary>
    /// The remote device request timeout
    /// 远程设备请求超时
    /// </summary>
    NET_ERROR_REMOTE_REQUEST_TIMEOUT = 0x80000000 | 420,
    /// <summary>
    /// Input source beyond maximum route restrictions
    /// 输入源超出最大路数限制
    /// </summary>
    NET_ERROR_LIMITED_INPUT_SOURCE = 0x80000000 | 421,
    /// <summary>
    /// Failed to set log print
    /// 设置日志打印失败
    /// </summary>
    NET_ERROR_SET_LOG_PRINT_INFO = 0x80000000 | 422,
    /// <summary>
    /// "dwSize" is not initialized in input param
    /// 入参的dwsize字段出错
    /// </summary>
    NET_ERROR_PARAM_DWSIZE_ERROR = 0x80000000 | 423,
    /// <summary>
    /// TV wall exceed limit
    /// 电视墙数量超过上限
    /// </summary>
    NET_ERROR_LIMITED_MONITORWALL_COUNT = 0x80000000 | 424,
    /// <summary>
    /// Fail to execute part of the process
    /// 部分过程执行失败
    /// </summary>
    NET_ERROR_PART_PROCESS_FAILED = 0x80000000 | 425,
    /// <summary>
    /// Fail to transmit due to not supported by target
    /// 该功能不支持转发
    /// </summary>
    NET_ERROR_TARGET_NOT_SUPPORT = 0x80000000 | 426,
    /// <summary>
    /// Access to the file failed
    /// 访问文件失败
    /// </summary>
    NET_ERROR_VISITE_FILE = 0x80000000 | 510,
    /// <summary>
    /// Device busy
    /// 设备忙
    /// </summary>
    NET_ERROR_DEVICE_STATUS_BUSY = 0x80000000 | 511,
    /// <summary>
    /// Fail to change the password
    /// 修改密码无权限
    /// </summary>
    NET_USER_PWD_NOT_AUTHORIZED = 0x80000000 | 512,
    /// <summary>
    /// Password strength is not enough
    /// 密码强度不够
    /// </summary>
    NET_USER_PWD_NOT_STRONG = 0x80000000 | 513,
    /// <summary>
    /// No corresponding setup
    /// 没有对应的配置
    /// </summary>
    NET_ERROR_NO_SUCH_CONFIG = 0x80000000 | 514,
    /// <summary>
    /// Failed to record audio
    /// 录音失败
    /// </summary>
    NET_ERROR_AUDIO_RECORD_FAILED = 0x80000000 | 515,
    /// <summary>
    /// Failed to send out data 
    /// 数据发送失败
    /// </summary>
    NET_ERROR_SEND_DATA_FAILED = 0x80000000 | 516,
    /// <summary>
    /// Abandoned port 
    /// 废弃接口
    /// </summary>
    NET_ERROR_OBSOLESCENT_INTERFACE = 0x80000000 | 517,
    /// <summary>
    /// Internal buffer is not sufficient 
    /// 内部缓冲不足
    /// </summary>
    NET_ERROR_INSUFFICIENT_INTERAL_BUF = 0x80000000 | 518,
    /// <summary>
    /// verify password when changing device IP
    /// 修改设备ip时,需要校验密码
    /// </summary>
    NET_ERROR_NEED_ENCRYPTION_PASSWORD = 0x80000000 | 519,
    /// <summary>
    /// Failed to serialize data
    /// 设备不支持此记录集
    /// </summary>
    NET_ERROR_SERIALIZE_ERROR = 0x80000000 | 1010,
    /// <summary>
    /// Failed to deserialize data
    /// 数据序列化错误
    /// </summary>
    NET_ERROR_DESERIALIZE_ERROR = 0x80000000 | 1011,
    /// <summary>
    /// the wireless id is already existed
    /// 数据反序列化错误
    /// </summary>
    NET_ERROR_LOWRATEWPAN_ID_EXISTED = 0x80000000 | 1012,
    /// <summary>
    /// the wireless id limited
    /// 该无线ID已存在
    /// </summary>
    NET_ERROR_LOWRATEWPAN_ID_LIMIT = 0x80000000 | 1013,
    /// <summary>
    /// add the wireless id abnormaly
    /// 无线ID数量已超限
    /// </summary>
    NET_ERROR_LOWRATEWPAN_ID_ABNORMAL = 0x80000000 | 1014,
    /// <summary>
    /// encrypt data fail
    /// 加密数据失败
    /// </summary>
    NET_ERROR_ENCRYPT = 0x80000000 | 1015,
    /// <summary>
    /// new password illegal
    /// 新密码不合规范
    /// </summary>
    NET_ERROR_PWD_ILLEGAL = 0x80000000 | 1016,
    /// <summary>
    /// device is already init
    /// 设备已经初始化
    /// </summary>
    NET_ERROR_DEVICE_ALREADY_INIT = 0x80000000 | 1017,
    /// <summary>
    /// security code check out fail
    /// 安全码错误
    /// </summary>
    NET_ERROR_SECURITY_CODE = 0x80000000 | 1018,
    /// <summary>
    /// security code out of time
    /// 安全码超出有效期
    /// </summary>
    NET_ERROR_SECURITY_CODE_TIMEOUT = 0x80000000 | 1019,
    /// <summary>
    /// get passwd specification fail
    /// 获取密码规范失败
    /// </summary>
    NET_ERROR_GET_PWD_SPECI = 0x80000000 | 1020,
    /// <summary>
    /// no authority of operation 
    /// 无权限进行该操作
    /// </summary>
    NET_ERROR_NO_AUTHORITY_OF_OPERATION = 0x80000000 | 1021,
    /// <summary>
    /// decrypt data fail
    /// 解密数据失败
    /// </summary>
    NET_ERROR_DECRYPT = 0x80000000 | 1022,
    /// <summary>
    /// 2D code check out fail
    /// 2D code校验失败
    /// </summary>
    NET_ERROR_2D_CODE = 0x80000000 | 1023,
    /// <summary>
    /// invalid request
    /// 非法的RPC请求
    /// </summary>
    NET_ERROR_INVALID_REQUEST = 0x80000000 | 1024,
    /// <summary>
    /// pwd reset disabled
    /// 密码重置功能已关闭
    /// </summary>
    NET_ERROR_PWD_RESET_DISABLE = 0x80000000 | 1025,
    /// <summary>
    /// failed to display private data,such as rule box
    /// 显示私有数据，比如规则框等失败
    /// </summary>
    NET_ERROR_PLAY_PRIVATE_DATA = 0x80000000 | 1026,
    /// <summary>
    /// robot operate failed
    /// 机器人操作失败
    /// </summary>
    NET_ERROR_ROBOT_OPERATE_FAILED = 0x80000000 | 1027,
    /// <summary>
    /// 组ID超过最大值
    /// </summary>
    NET_ERROR_FACE_RECOGNITION_SERVER_GROUP_ID_EXCEED = 0x80000000 | 1051,
    /// <summary>
    /// invaild channel
    /// 无效的通道
    /// </summary>
    ERR_INTERNAL_INVALID_CHANNEL = 0x90001002,
    /// <summary>
    /// reopen channel failed
    /// 重新打开通道失败
    /// </summary>
    ERR_INTERNAL_REOPEN_CHANNEL = 0x90001003,
    /// <summary>
    /// send data failed
    /// 发送数据失败
    /// </summary>
    ERR_INTERNAL_SEND_DATA = 0x90002008,
    /// <summary>
    /// creat socket failed
    /// 创建套接字失败
    /// </summary>
    ERR_INTERNAL_CREATE_SOCKET = 0x90002003,
    ERR_INTERNAL_LISTEN_FAILED = 0x90010010,
  }

  /// <summary>
  /// device information structure
  /// 设备信息结构体
  /// </summary>
  public struct NET_DEVICEINFO_Ex
  {
    /// <summary>
    /// serial number
    /// 序列号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string sSerialNumber;
    /// <summary>
    /// count of alarm input
    /// 报警输入个数
    /// </summary>
    public int nAlarmInPortNum;
    /// <summary>
    /// count of alarm output
    /// 报警输出个数
    /// </summary>
    public int nAlarmOutPortNum;
    /// <summary>
    /// number of disk
    /// 硬盘个数
    /// </summary>
    public int nDiskNum;
    /// <summary>
    /// device type, refer to EM_NET_DEVICE_TYPE
    /// 设备类型,见枚举NET_DEVICE_TYPE
    /// </summary>
    public EM_NET_DEVICE_TYPE nDVRType;
    /// <summary>
    /// number of channel
    /// 通道个数
    /// </summary>
    public int nChanNum;
    /// <summary>
    /// Online Timeout, Not Limited Access to 0, not 0 Minutes Limit Said
    /// 在线超时时间,为0表示不限制登陆,非0表示限制的分钟数
    /// </summary>
    public byte byLimitLoginTime;
    /// <summary>
    /// When login failed due to password error, notice user by this parameter.This parameter is invalid when remaining login times is zero
    /// 当登陆失败原因为密码错误时,通过此参数通知用户,剩余登陆次数,为0时表示此参数无效
    /// </summary>
    public byte byLeftLogTimes;
    /// <summary>
    /// keep bytes for aligned
    /// 保留字节,字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// when log in failed,the left time for users to unlock (seconds), -1 indicate the device haven't set the parameter
    /// 当登陆失败,用户解锁剩余时间（秒数）, -1表示设备未设置该参数
    /// </summary>
    public int nLockLeftTime;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
    public byte[] Reserved;
  }

  /// <summary>
  /// device type enumeration
  /// 设备类型枚举
  /// </summary>
  public enum EM_NET_DEVICE_TYPE
  {
    /// <summary>
    /// Unknow
    //  未知
    /// </summary>
    NET_PRODUCT_NONE = 0,
    /// <summary>
    /// Non real-time MACE
    /// 非实时MACE
    /// </summary>
    NET_DVR_NONREALTIME_MACE,
    /// <summary>
    /// Non real-time
    /// 非实时
    /// </summary>
    NET_DVR_NONREALTIME,
    /// <summary>
    /// Network video server
    /// 网络视频服务器
    /// </summary>
    NET_NVS_MPEG1,
    /// <summary>
    /// MPEG1 2-ch DVR
    /// MPEG1二路录像机
    /// </summary>
    NET_DVR_MPEG1_2,
    /// <summary>
    /// MPEG1 8-ch DVR
    /// MPEG1八路录像机
    /// </summary>
    NET_DVR_MPEG1_8,
    /// <summary>
    /// MPEG4 8-ch DVR
    /// MPEG4八路录像机
    /// </summary>
    NET_DVR_MPEG4_8,
    /// <summary>
    /// MPEG4 16-ch DVR
    /// MPEG4 十六路录像机
    /// </summary>
    NET_DVR_MPEG4_16,
    /// <summary>
    /// LB series DVR
    /// LB系列录像机
    /// </summary>
    NET_DVR_MPEG4_SX2,
    /// <summary>
    /// GB  series DVR
    /// GB系列录像机
    /// </summary>
    NET_DVR_MEPG4_ST2,
    /// <summary>
    /// HB  series DVR
    /// HB系列录像机
    /// </summary>
    NET_DVR_MEPG4_SH2,
    /// <summary>
    /// GBE  series DVR
    /// GBE系列录像机
    /// </summary>
    NET_DVR_MPEG4_GBE,
    /// <summary>
    /// II network video server
    /// II代网络视频服务器
    /// </summary>
    NET_DVR_MPEG4_NVSII,
    /// <summary>
    /// New standard configuration protocol
    /// 新标准配置协议
    /// </summary>
    NET_DVR_STD_NEW,
    /// <summary>
    /// DDNS server
    /// DDNS服务器
    /// </summary>
    NET_DVR_DDNS,
    /// <summary>
    /// ATM series
    /// ATM机
    /// </summary>
    NET_DVR_ATM,
    /// <summary>
    /// 2nd non real-time NB series DVR
    /// 二代非实时NB系列机器
    /// </summary>
    NET_NB_SERIAL,
    /// <summary>
    /// LN  series
    /// LN系列产品
    /// </summary>
    NET_LN_SERIAL,
    /// <summary>
    /// BAV series
    /// BAV系列产品
    /// </summary>
    NET_BAV_SERIAL,
    /// <summary>
    /// SDIP series
    /// SDIP系列产品
    /// </summary>
    NET_SDIP_SERIAL,
    /// <summary>
    /// IPC series
    /// IPC系列产品
    /// </summary>
    NET_IPC_SERIAL,
    /// <summary>
    /// NVS B series
    /// NVS B系列
    /// </summary>
    NET_NVS_B,
    /// <summary>
    /// NVS H series
    /// NVS H系列
    /// </summary>
    NET_NVS_C,
    /// <summary>
    /// NVS S series
    /// NVS S系列
    /// </summary>
    NET_NVS_S,
    /// <summary>
    /// NVS E series
    /// NVS E系列
    /// </summary>
    NET_NVS_E,
    /// <summary>
    /// Search device type from QueryDevState. it is in string format
    /// 从QueryDevState中查询设备类型,以字符串格式
    /// </summary>
    NET_DVR_NEW_PROTOCOL,
    /// <summary>
    /// NVD
    /// 解码器
    /// </summary>
    NET_NVD_SERIAL,
    /// <summary>
    /// N5
    /// N5
    /// </summary>
    NET_DVR_N5,
    /// <summary>
    /// HDVR
    /// 混合DVR
    /// </summary>
    NET_DVR_MIX_DVR,
    /// <summary>
    /// SVR series
    /// SVR系列
    /// </summary>
    NET_SVR_SERIAL,
    /// <summary>
    /// SVR-BS
    /// SVR-BS
    /// </summary>
    NET_SVR_BS,
    /// <summary>
    /// NVR series
    /// NVR系列
    /// </summary>
    NET_NVR_SERIAL,
    /// <summary>
    /// N51
    /// N51
    /// </summary>
    NET_DVR_N51,
    /// <summary>
    /// ITSE Intelligent Analysis Box
    /// ITSE 智能分析盒
    /// </summary>
    NET_ITSE_SERIAL,
    /// <summary>
    /// Intelligent traffic camera equipment
    /// 智能交通像机设备
    /// </summary>
    NET_ITC_SERIAL,
    /// <summary>
    /// radar speedometer HWS
    /// 雷达测速仪HWS
    /// </summary>
    NET_HWS_SERIAL,
    /// <summary>
    /// portable video record
    /// 便携式音视频录像机
    /// </summary>
    NET_PVR_SERIAL,
    /// <summary>
    /// IVS(intelligent video server series)
    /// IVS（智能视频服务器系列）
    /// </summary>
    NET_IVS_SERIAL,
    /// <summary>
    /// universal intelligent detect video server series 
    /// 通用智能视频侦测服务器
    /// </summary>
    NET_IVS_B,
    /// <summary>
    /// face recognisation server
    /// 人脸识别服务器
    /// </summary>
    NET_IVS_F,
    /// <summary>
    /// video quality diagnosis server
    /// 视频质量诊断服务器
    /// </summary>
    NET_IVS_V,
    /// <summary>
    /// matrix
    /// 矩阵
    /// </summary>
    NET_MATRIX_SERIAL,
    /// <summary>
    /// N52
    /// N52
    /// </summary>
    NET_DVR_N52,
    /// <summary>
    /// N56
    /// N56
    /// </summary>
    NET_DVR_N56,
    /// <summary>
    /// ESS
    /// ESS
    /// </summary>
    NET_ESS_SERIAL,
    /// <summary>
    /// 人数统计服务器
    /// </summary>
    NET_IVS_PC,
    /// <summary>
    /// pc-nvr
    /// pc-nvr
    /// </summary>
    NET_PC_NVR,
    /// <summary>
    /// screen controller
    /// 大屏控制器
    /// </summary>
    NET_DSCON,
    /// <summary>
    /// network video storage server
    /// 网络视频存储服务器
    /// </summary>
    NET_EVS,
    /// <summary>
    /// an embedded intelligent video analysis system
    /// 嵌入式智能分析视频系统
    /// </summary>
    NET_EIVS,
    /// <summary>
    /// DVR-N6
    /// DVR-N6
    /// </summary>
    NET_DVR_N6,
    /// <summary>
    /// K-Lite Codec Pack
    /// 万能解码器
    /// </summary>
    NET_UDS,
    /// <summary>
    /// Bank alarm host
    /// 银行报警主机
    /// </summary>
    NET_AF6016,
    /// <summary>
    /// Video network alarm host
    /// 视频网络报警主机
    /// </summary>
    NET_AS5008,
    /// <summary>
    /// Network alarm host
    /// 网络报警主机
    /// </summary>
    NET_AH2008,
    /// <summary>
    /// Alarm host series
    /// 报警主机系列
    /// </summary>
    NET_A_SERIAL,
    /// <summary>
    /// Access control series of products
    /// 门禁系列产品
    /// </summary>
    NET_BSC_SERIAL,
    /// <summary>
    /// NVS series product
    /// NVS系列产品
    /// </summary>
    NET_NVS_SERIAL,
    /// <summary>
    /// VTO series product
    /// VTO系列产品
    /// </summary>                           
    NET_VTO_SERIAL,
    /// <summary>
    /// VTNC series product
    /// VTNC系列产品
    /// </summary>
    NET_VTNC_SERIAL,
    /// <summary>
    /// TPC series product, it is the thermal device 
    /// TPC系列产品, 即热成像设备
    /// </summary>
    NET_TPC_SERIAL,
    /// <summary>
    /// ASM series product
    /// 无线中继设备
    /// </summary>
    NET_ASM_SERIAL,
    /// <summary>
    /// VTS series product
    /// 管理机
    /// </summary>
    NET_VTS_SERIAL,
    /// <summary>
    /// Alarm host-ARC2016C
    /// 报警主机ARC2016C
    /// </summary>
    NET_ARC2016C,
    /// <summary>
    /// ASA Attendance machine
    /// 考勤机
    /// </summary>
    NET_ASA,
    /// <summary>
    /// Industry terminal walkie-talkie
    /// 行业对讲终端
    /// </summary>
    NET_VTT_SERIAL,
    /// <summary>
    /// Alarm column
    /// 报警柱
    /// </summary>
    NET_VTA_SERIAL,
    /// <summary>
    /// SIP Server
    /// SIP服务器
    /// </summary>
    NET_VTNS_SERIAL,
    /// <summary>
    /// Indoor unit
    /// 室内机
    /// </summary>
    NET_VTH_SERIAL,
  }

  /// <summary>
  /// login device mode enumeration
  /// 登陆设备方式枚举
  /// </summary>
  public enum EM_LOGIN_SPAC_CAP_TYPE
  {
    /// <summary>
    /// TCP login, default
    /// TCP登陆, 默认方式
    /// </summary>
    TCP = 0,
    /// <summary>
    /// No criteria login
    /// 无条件登陆
    /// </summary>
    ANY = 1,
    /// <summary>
    /// auto sign up login
    /// 主动注册的登入
    /// </summary>
    SERVER_CONN = 2,
    /// <summary>
    /// multicast login, default
    /// 组播登陆
    /// </summary>
    MULTICAST = 3,
    /// <summary>
    /// UDP method login
    /// UDP方式下的登入
    /// </summary>
    UDP = 4,
    /// <summary>
    /// only main connection login
    /// 只建主连接下的登入
    /// </summary>
    MAIN_CONN_ONLY = 6,
    /// <summary>
    /// SSL encryption login
    /// SSL加密方式登陆
    /// </summary>
    SSL = 7,
    /// <summary>
    /// login IVS box remote device
    /// 登录智能盒远程设备
    /// </summary>
    INTELLIGENT_BOX = 9,
    /// <summary>
    /// login device do not config
    /// 登录设备后不做取配置操作
    /// </summary>
    NO_CONFIG = 10,
    /// <summary>
    /// USB key device login
    /// 用U盾设备的登入
    /// </summary>
    U_LOGIN = 11,
    /// <summary>
    /// LDAP login
    /// LDAP方式登录
    /// </summary>
    LDAP = 12,
    /// <summary>
    /// AD login
    /// AD（ActiveDirectory）登录方式
    /// </summary>
    AD = 13,
    /// <summary>
    /// Radius  login 
    /// Radius 登录方式
    /// </summary>
    RADIUS = 14,
    /// <summary>
    /// Socks5 login
    /// Socks5登陆方式
    /// </summary>
    SOCKET_5 = 15,
    /// <summary>
    /// cloud login
    /// 云登陆方式
    /// </summary>
    CLOUD = 16,
    /// <summary>
    /// dual authentication loin
    /// 二次鉴权登陆方式
    /// </summary>
    AUTH_TWICE = 17,
    /// <summary>
    /// TS stream client login
    /// TS码流客户端登陆方式
    /// </summary>
    TS = 18,
    /// <summary>
    /// web private login
    /// 为P2P登陆方式
    /// </summary>
    P2P = 19,
    /// <summary>
    /// mobile client login
    /// 手机客户端登陆
    /// </summary>
    MOBILE = 20,
    /// <summary>
    /// invalid login
    /// 无效的登陆方式
    /// </summary>          
    INVALID = 21,
  }

  /// <summary>
  /// the corresponding parameter when setting log in structure
  /// 设置登入时的相关参数
  /// </summary>
  public struct NET_PARAM
  {
    /// <summary>
    /// Waiting time(unit is ms), 0:default 5000ms.
    /// 等待超时时间(毫秒为单位),为0默认5000ms
    /// </summary>
    public int nWaittime;
    /// <summary>
    /// Connection timeout value(Unit is ms), 0:default 1500ms.
    /// 连接超时时间(毫秒为单位),为0默认1500ms
    /// </summary>
    public int nConnectTime;
    /// <summary>
    /// Connection trial times, 0:default 1.
    /// 连接尝试次数,为0默认1次
    /// </summary>
    public int nConnectTryNum;
    /// <summary>
    /// Sub-connection waiting time(Unit is ms), 0:default 10ms.
    /// 子连接之间的等待时间(毫秒为单位),为0默认10ms
    /// </summary>
    public int nSubConnectSpaceTime;
    /// <summary>
    /// Access to device information timeout, 0:default 1000ms.
    /// 获取设备信息超时时间,为0默认1000ms
    /// </summary>
    public int nGetDevInfoTime;
    /// <summary>
    /// Each connected to receive data buffer size(Bytes), 0:default 250*1024
    /// 每个连接接收数据缓冲大小(字节为单位),为0默认250*1024
    /// </summary>
    public int nConnectBufSize;
    /// <summary>
    /// Access to sub-connect information timeout(Unit is ms), 0:default 1000ms.
    /// 获取子连接信息超时时间(毫秒为单位),为0默认1000ms
    /// </summary>
    public int nGetConnInfoTime;
    /// <summary>
    /// Timeout value of search video (unit ms), default 3000ms
    /// 按时间查询录像文件的超时时间(毫秒为单位),为0默认为3000ms
    /// </summary>
    public int nSearchRecordTime;
    /// <summary>
    /// dislink disconnect time,0:default 60000ms
    /// 检测子链接断线等待时间(毫秒为单位),为0默认为60000ms
    /// </summary>
    public int nsubDisconnetTime;
    /// <summary>
    /// net type, 0-LAN, 1-WAN
    /// 网络类型, 0-LAN, 1-WAN
    /// </summary>
    public byte byNetType;
    /// <summary>
    /// playback data from the receive buffer size(m),when value = 0,default 4M
    /// 回放数据接收缓冲大小（M为单位）,为0默认为4M
    /// </summary>
    public byte byPlaybackBufSize;
    /// <summary>
    /// Pulse detect offline time(second) .When it is 0, the default setup is 60s, and the min time is 2s 
    /// 心跳检测断线时间(单位为秒),为0默认为60s,最小时间为2s
    /// </summary>
    public byte bDetectDisconnTime;
    /// <summary>
    /// Pulse send out interval(second). When it is 0, the default setup is 10s, the min internal is 2s.
    /// 心跳包发送间隔(单位为秒),为0默认为10s,最小间隔为2s
    /// </summary>
    public byte bKeepLifeInterval;
    /// <summary>
    /// actual pictures of the receive buffer size(byte)when value = 0,default 2*1024*1024
    /// 实时图片接收缓冲大小（字节为单位）,为0默认为2*1024*1024
    /// </summary>
    public int nPicBufSize;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>    
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved;
  }

  /// <summary>
  /// snapshot parameter structure
  /// 抓图参数结构体
  /// </summary>
  public struct NET_SNAP_PARAMS
  {
    /// <summary>
    /// Snapshot channel
    /// 抓图的通道
    /// </summary>
    public uint Channel;
    /// <summary>
    /// Image quality:level 1 to level 6
    /// 画质；1~6
    /// </summary>
    public uint Quality;
    /// <summary>
    /// Video size;0:QCIF,1:CIF,2:D1
    /// 画面大小；0：QCIF,1：CIF,2：D1
    /// </summary>
    public uint ImageSize;
    /// <summary>
    /// Snapshot mode;0:request one frame,1:send out requestion regularly,2: Request consecutively
    /// 抓图模式；0xFFFFFFFF:表示停止抓图, 0：表示请求一帧, 1：表示定时发送请求, 2：表示连续请求
    /// </summary>
    public uint mode;
    /// <summary>
    /// Time unit is second.If mode=1, it means send out requestion regularly. The time is valid.
    /// 时间单位秒；若mode=1表示定时发送请求时只有部分特殊设备(如：车载设备)支持通过该字段实现定时抓图时间间隔的配置建议通过 CFG_CMD_ENCODE 配置的stuSnapFormat[nSnapMode].stuVideoFormat.nFrameRate字段实现相关功能
    /// </summary>
    public uint InterSnap;
    /// <summary>
    /// Request serial number
    /// 请求序列号，有效值范围 0~65535，超过范围会被截断为 unsigned short
    /// </summary>
    public uint CmdSerial;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public uint[] Reserved;
  }

  /// <summary>
  /// real data flag, corresponding param dwFlag in SetRealDataCallBack.supports '|' operator, like dwFlag = EM_REALDATA_FLAG.RAW_DATA | EM_REALDATA_FLAG.YUV_DATA
  /// 实时监视的实时数据标志, 对应 SetRealDataCallBack 中的 dwFlag 参数,支持 '|' 运算符, 如 dwFlag = EM_REALDATA_FLAG.RAW_DATA | EM_REALDATA_FLAG.YUV_DATA
  /// </summary>
  [Flags]
  public enum EM_REALDATA_FLAG
  {
    /// <summary>
    /// raw data flag,		corresponding param dwDataType in fRealDataCallBackEx / fRealDataCallBackEx2 is 0, 0x01 = 0x01 << 0
    /// 原始数据标志,			对应fRealDataCallBack(Ex/Ex2)回调函数中 dwDataType 为0, 0x01 = 0x01 << 0
    /// </summary>
    RAW_DATA = 0x01,
    /// <summary>
    /// data with frame info flag,	corresponding param dwDataType in fRealDataCallBackEx / fRealDataCallBackEx2 is 1, 0x02 = 0x01 << 1
    /// 带有帧信息的数据标志,	对应fRealDataCallBack(Ex/Ex2)回调函数中 dwDataType 为1, 0x02 = 0x01 << 1
    /// </summary>
    DATA_WITH_FRAME_INFO = 0x02,
    /// <summary>
    /// YUV data flag,		corresponding param dwDataType in fRealDataCallBackEx / fRealDataCallBackEx2 is 2, 0x04 = 0x01 << 2
    /// YUV 数据标志,			对应fRealDataCallBack(Ex/Ex2)回调函数中 dwDataType 为2, 0x04 = 0x01 << 2
    /// </summary>
    YUV_DATA = 0x04,
    /// <summary>
    /// PCM audio data flag,	corresponding param dwDataType in fRealDataCallBackEx / fRealDataCallBackEx2 is 3, 0x08 = 0x01 << 3
    /// PCM 音频数据标志,		对应fRealDataCallBack(Ex/Ex2)回调函数中 dwDataType 为3, 0x08 = 0x01 << 3
    /// </summary>
    PCM_AUDIO_DATA = 0x08,
  }

  /// <summary>
  /// SnapPictureToFile function input parameter
  /// SnapPictureToFile函数输入参数
  /// </summary>
  public struct NET_IN_SNAP_PIC_TO_FILE_PARAM
  {
    /// <summary>
    /// structure size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// snapshot parameter, mode field is only snapshot for once, fail to support timed or continuous snapshot; except mobile DVR, other devices only support snapshot frequency of one snapshot per second
    /// 抓图参数, 其中mode字段仅一次性抓图, 不支持定时或持续抓图; 除了车载DVR, 其他设备仅支持每秒一张的抓图频率
    /// </summary>
    public NET_SNAP_PARAMS stuParam;
    /// <summary>
    /// write in file address
    /// 写入文件的地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szFilePath;
  }

  /// <summary>
  /// SnapPictureToFile function output parameter 
  /// SnapPictureToFile函数输出参数
  /// </summary>
  public struct NET_OUT_SNAP_PIC_TO_FILE_PARAM
  {
    /// <summary>
    /// structure size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// picture content, user memory allocation, memory size is dwPicBufLen
    /// 图片内容,用户分配内存,大小为dwPicBufLen
    /// </summary>
    public IntPtr szPicBuf;
    /// <summary>
    /// picture content memory size, unit: byte
    /// 图片内容内存大小, 单位:字节
    /// </summary>
    public uint dwPicBufLen;
    /// <summary>
    /// returned picture size, unit:byte
    /// 返回的图片大小, 单位:字节
    /// </summary>
    public uint dwPicBufRetLen;
  }

  /// <summary>
  /// realplay type
  /// 监视类型
  /// </summary>
  public enum EM_RealPlayType
  {
    /// <summary>
    /// Real-time preview
    /// 实时预览
    /// </summary>
    Realplay = 0,
    /// <summary>
    /// Multiple-channel preview 
    /// 多画面预览
    /// </summary>
    Multiplay,
    /// <summary>
    /// Real-time monitor-main stream. It is the same as EM_RealPlayType.Realplay
    /// 实时监视-主码流,等同于EM_RealPlayType.Realplay
    /// </summary>
    Realplay_0,
    /// <summary>
    /// Real-time monitor -- extra stream 1
    /// 实时监视-从码流1
    /// </summary>
    Realplay_1,
    /// <summary>
    /// Real-time monitor -- extra stream 2
    /// 实时监视-从码流2
    /// </summary>
    Realplay_2,
    /// <summary>
    /// Real-time monitor -- extra stream 3
    /// 实时监视-从码流3
    /// </summary>
    Realplay_3,
    /// <summary>
    /// Multiple-channel preview--1-window 
    /// 多画面预览－1画面
    /// </summary>
    Multiplay_1,
    /// <summary>
    /// Multiple-channel preview--4-window
    /// 多画面预览－4画面
    /// </summary>
    Multiplay_4,
    /// <summary>
    /// Multiple-channel preview--8-window
    /// 多画面预览－8画面
    /// </summary>
    Multiplay_8,
    /// <summary>
    /// Multiple-channel preview--9-window
    /// 多画面预览－9画面
    /// </summary>
    Multiplay_9,
    /// <summary>
    /// Multiple-channel preview--16-window
    /// 多画面预览－16画面
    /// </summary>
    Multiplay_16,
    /// <summary>
    /// Multiple-channel preview--6-window
    /// 多画面预览－6画面
    /// </summary>
    Multiplay_6,
    /// <summary>
    /// Multiple-channel preview--12-window
    /// 多画面预览－12画面
    /// </summary>
    Multiplay_12,
    /// <summary>
    /// Multiple-channel preview--25-window
    /// 多画面预览－25画面
    /// </summary>
    Multiplay_25,
    /// <summary>
    /// Multiple-channel preview--36-window
    /// 多画面预览－36画面
    /// </summary>
    Multiplay_36,
    /// <summary>
    /// test stream
    /// 带宽测试码流 
    /// </summary>
    Realplay_Test = 255,
  }

  /// <summary>
  /// realplay disconnnect event
  /// 监视断线类型
  /// </summary>
  public enum EM_REALPLAY_DISCONNECT_EVENT_TYPE
  {
    /// <summary>
    /// resources is taked by advanced user
    /// 表示高级用户抢占低级用户资源
    /// </summary>
    REAVE,
    /// <summary>
    /// forbidden
    /// 禁止入网
    /// </summary>
    NETFORBID,
    /// <summary>
    /// sublink disconnect
    /// 子链接断线
    /// </summary>
    SUBCONNECT,
  }

  /// <summary>
  /// absolute control PTZ corresponding structure
  /// 绝对控制云台对应结构
  /// </summary>
  public struct NET_PTZ_CONTROL_ABSOLUTELY
  {
    /// <summary>
    /// PTZ Absolute Speed
    /// 云台绝对移动位置
    /// </summary>
    public NET_PTZ_SPACE_UNIT stuPosition;
    /// <summary>
    /// PTZ Operation Speed
    /// 云台运行速度
    /// </summary>
    public NET_PTZ_SPEED_UNIT stuSpeed;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szReserve;
  }

  /// <summary>
  /// continuous control PTZ corresponding structure
  /// 云台控制坐标单元
  /// </summary>
  public struct NET_PTZ_SPEED_UNIT
  {
    /// <summary>
    /// PTZ horizontal speed, normalized to -1~1
    /// 云台水平方向速率,归一化到-1~1
    /// </summary>
    public float fPositionX;
    /// <summary>
    /// PTZ vertical speed, normalized to -1~1 
    /// 云台垂直方向速率,归一化到-1~1
    /// </summary>
    public float fPositionY;
    /// <summary>
    /// PTZ aperture magnification, normalized to 0~1 
    /// 云台光圈放大倍率,归一化到 0~1
    /// </summary>
    public float fZoom;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szReserve;
  }

  /// <summary>
  /// PTZ control coordinate unit structure
  /// 云台控制坐标单元
  /// </summary>
  public struct NET_PTZ_SPACE_UNIT
  {
    /// <summary>
    /// PTZ horizontal motion position, effective range[0,3600]
    /// 云台水平运动位置,有效范围：[0,3600]
    /// </summary>
    public int nPositionX;
    /// <summary>
    /// PTZ vertical motion position, effective range[-1800,1800]
    /// 云台垂直运动位置,有效范围：[-1800,1800]
    /// </summary>
    public int nPositionY;
    /// <summary>
    /// PTZ aperture change position, the effective range[0,128]
    /// 云台光圈变动位置,有效范围：[0,128]
    /// </summary>
    public int nZoom;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szReserve;
  }

  /// <summary>
  /// continuous control PTZ corresponding structure
  /// 持续控制云台对应结构
  /// </summary>
  public struct NET_PTZ_CONTROL_CONTINUOUSLY
  {
    /// <summary>
    /// PTZ speed
    /// 云台运行速度
    /// </summary>
    public NET_PTZ_SPEED_UNIT stuSpeed;
    /// <summary>
    /// Continuous motion timeout, the unit is in seconds 
    /// 连续移动超时时间,单位为秒
    /// </summary>
    public int nTimeOut;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szReserve;
  }

  /// <summary>
  /// with speed rotation site PTZ control corresponding to the preset structure
  /// 带速度转动到预置位点云台控制对应结构
  /// </summary>
  public struct NET_PTZ_CONTROL_GOTOPRESET
  {
    /// <summary>
    /// Preset BIT Index 
    /// 预置位索引
    /// </summary>
    public int nPresetIndex;
    /// <summary>
    /// PTZ Operation Speed
    /// 云台运行速度
    /// </summary>
    public NET_PTZ_SPEED_UNIT stuSpeed;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szReserve;
  }

  /// <summary>
  /// set the PTZ vision information structure
  /// 设置云台可视域信息
  /// </summary>
  public struct NET_PTZ_VIEW_RANGE_INFO
  {
    /// <summary>
    /// current struct size
    /// 结构体大小
    /// </summary>
    public int nStructSize;
    /// <summary>
    /// Horizontal azimuth Angle, 0~3600, unit: degrees 
    /// 水平方位角度, 0~3600, 单位:度
    /// </summary>
    public int nAzimuthH;
  }

  /// <summary>
  /// PTZ absolute focus corresponding structure
  /// 云台绝对聚焦对应结构体
  /// </summary>
  public struct NET_PTZ_FOCUS_ABSOLUTELY
  {
    /// <summary>
    /// PTZ Focused On Location, range (0~8191)
    /// 云台聚焦位置,取值范围(0~8191)
    /// </summary>
    public uint dwValue;
    /// <summary>
    /// PTZ Focused On Speed, the scope (0~7)
    /// 云台聚焦速度,取值范围(0~7)
    /// </summary>
    public uint dwSpeed;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szReserve;
  }

  /// <summary>
  /// PTZ control - fan and corresponding structure
  /// 云台控制-扇扫对应结构
  /// </summary>
  public struct NET_PTZ_CONTROL_SECTORSCAN
  {
    /// <summary>
    /// Staring Angle,Range:[-180,180]
    /// 起始角度,范围:[-180,180]
    /// </summary>
    public int nBeginAngle;
    /// <summary>
    /// Ending Angle,Range:[-180,180]
    /// 结束角度,范围:[-180,180]
    /// </summary>
    public int nEndAngle;
    /// <summary>
    /// Speed,Range:[0,255]
    /// 速度,范围:[0,255]
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szReserve;
  }

  /// <summary>
  /// control Fish eye E-PTZ information structure 
  /// 控制鱼眼电子云台信息
  /// </summary>
  public struct NET_PTZ_CONTROL_SET_FISHEYE_EPTZ
  {
    /// <summary>
    /// structure size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// EPtz control window no
    /// 进行EPtz控制的窗口编号
    /// </summary>
    public uint dwWindowID;
    /// <summary>
    /// E-PTZ command
    /// 电子云台命令
    /// </summary>
    public uint dwCommand;
    /// <summary>
    /// command corresponding to parameter 1
    /// 命令对应参数1
    /// </summary>
    public uint dwParam1;
    /// <summary>
    /// command corresponding to  parameter 2
    /// 命令对应参数2
    /// </summary>
    public uint dwParam2;
    /// <summary>
    /// command corresponding to  parameter 3
    /// 命令对应参数3
    /// </summary>
    public uint dwParam3;
    /// <summary>
    /// command corresponding to  parameter 4
    /// 命令对应参数4
    /// </summary>
    public uint dwParam4;
  }

  /// <summary>
  /// track control command enumeration
  /// 轨道机控制命令
  /// </summary>
  public enum EM_NET_TRACK_CONTROL_CMD
  {
    /// <summary>
    /// Move up, dwParam1 means step length range 1-8
    /// 向上移动,dwParam1表示步长,范围1～8
    /// </summary>
    UP,
    /// <summary>
    /// Move down, dwParam1 means step length  range 1-8
    /// 向下移动,dwParam1表示步长,范围1～8
    /// </summary>
    DOWN,
    /// <summary>
    /// Move left, dwParam1 means step length  range 1-8
    /// 向左移动,dwParam1表示步长,范围1～8
    /// </summary>
    LEFT,
    /// <summary>
    /// Move right, dwParam1 means step length  range 1-8
    /// 向右移动,dwParam1表示步长,范围1～8
    /// </summary>
    RIGHT,
    /// <summary>
    /// Set preset，dwParam1 means preset value
    /// 设置预置点,dwParam1表示预置点值
    /// </summary>
    SETPRESET,
    /// <summary>
    /// Clear preset，dwParam1 means preset value
    /// 清除预置点,dwParam1表示预置点值
    /// </summary>
    CLEARPRESET,
    /// <summary>
    /// Goto preset，dwParam1 means preset value
    /// 转至预置点,dwParam1表示预置点值
    /// </summary>
    GOTOPRESET,
  }

  /// <summary>
  /// track control information structure
  /// 轨道机控制信息
  /// </summary>
  public struct NET_PTZ_CONTROL_SET_TRACK_CONTROL
  {
    /// <summary>
    /// dwSize need to be assigned sizeof(NET_PTZ_CONTROL_SET_TRACK_CONTROL)
    /// 用户使用该结构体时,dwSize 需赋值为 sizeof(NET_PTZ_CONTROL_SET_TRACK_CONTROL)
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel number
    /// 通道号
    /// </summary>
    public uint dwChannelID;
    /// <summary>
    /// Control command，corresponding to enum EM_NET_TRACK_CONTROL_CMD
    /// 电子云台命令,对应枚举EM_NET_TRACK_CONTROL_CMD
    /// </summary>
    public uint dwCommand;
    /// <summary>
    /// command corresponding to parameter 1
    /// 命令对应参数1
    /// </summary>
    public uint dwParam1;
    /// <summary>
    /// command corresponding to parameter 2
    /// 命令对应参数2
    /// </summary>
    public uint dwParam2;
    /// <summary>
    /// command corresponding to parameter 3
    /// 命令对应参数3
    /// </summary>
    public uint dwParam3;
  }

  /// <summary>
  /// PTZ control command enumeration
  /// 云台控制命令
  /// </summary>
  public enum EM_EXTPTZ_ControlType : uint
  {
    /// <summary>
    /// Up
    /// 上
    /// </summary>
    UP_CONTROL = 0,
    /// <summary>
    /// Down
    /// 下
    /// </summary>
    DOWN_CONTROL,
    /// <summary>
    /// Left
    /// 左
    /// </summary>
    LEFT_CONTROL,
    /// <summary>
    /// Right
    /// 右
    /// </summary>
    RIGHT_CONTROL,
    /// <summary>
    /// +Zoom in 
    /// 变倍+
    /// </summary>
    ZOOM_ADD_CONTROL,
    /// <summary>
    /// -Zoom out
    /// 变倍-
    /// </summary>
    ZOOM_DEC_CONTROL,
    /// <summary>
    /// +Focus 
    /// 调焦+
    /// </summary>
    FOCUS_ADD_CONTROL,
    /// <summary>
    /// -Focus
    /// 调焦-
    /// </summary>
    FOCUS_DEC_CONTROL,
    /// <summary>
    /// + Aperture 
    /// 光圈+
    /// </summary>
    APERTURE_ADD_CONTROL,
    /// <summary>
    /// -Aperture
    /// 光圈-
    /// </summary>
    APERTURE_DEC_CONTROL,
    /// <summary>
    /// Go to preset 
    /// 转至预置点
    /// </summary>
    POINT_MOVE_CONTROL,
    /// <summary>
    /// Set
    /// 设置
    /// </summary>
    POINT_SET_CONTROL,
    /// <summary>
    /// Delete
    /// 删除
    /// </summary>
    POINT_DEL_CONTROL,
    /// <summary>
    /// Tour
    /// 点间巡航
    /// </summary>
    POINT_LOOP_CONTROL,
    /// <summary>
    /// Light and wiper 
    /// 灯光雨刷
    /// </summary>
    LAMP_CONTROL,
    /// <summary>
    /// Upper left
    /// 左上
    /// </summary>
    LEFTTOP = 0x20,
    /// <summary>
    /// Upper right
    /// 右上
    /// </summary>
    RIGHTTOP,
    /// <summary>
    /// Down left
    /// 左下
    /// </summary>
    LEFTDOWN,
    /// <summary>
    /// Down right 
    /// 右下
    /// </summary>
    RIGHTDOWN,
    /// <summary>
    ///  Add preset to tour	tour preset value
    /// 加入预置点到巡航 巡航线路 预置点值
    /// </summary>
    ADDTOLOOP,
    /// <summary>
    /// Delete preset in tour tour preset value
    /// 删除巡航中预置点 巡航线路 预置点值
    /// </summary>
    DELFROMLOOP,
    /// <summary>
    /// Delete tour tour
    /// 清除巡航 巡航线路
    /// </summary>
    CLOSELOOP,
    /// <summary>
    /// Begin pan rotation
    /// 开始水平旋转
    /// </summary>
    STARTPANCRUISE,
    /// <summary>
    /// Stop pan rotation
    /// 停止水平旋转
    /// </summary>
    STOPPANCRUISE,
    /// <summary>
    /// Set left limit
    /// 设置左边界
    /// </summary>
    SETLEFTBORDER,
    /// <summary>
    /// Set right limit
    /// 设置右边界
    /// </summary>
    SETRIGHTBORDER,
    /// <summary>
    /// Begin scanning	
    /// 开始线扫
    /// </summary>
    STARTLINESCAN,
    /// <summary>
    /// Stop scanning
    /// 停止线扫
    /// </summary>
    CLOSELINESCAN,
    /// <summary>
    /// Start mode	mode line	
    /// 设置模式开始    模式线路
    /// </summary>
    SETMODESTART,
    /// <summary>
    /// Stop mode	mode line	
    /// 设置模式结束    模式线路
    /// </summary>
    SETMODESTOP,
    /// <summary>
    /// Enable mode	Mode line
    /// 运行模式    模式线路
    /// </summary>
    RUNMODE,
    /// <summary>
    /// Disable mode	Mode line
    /// 停止模式    模式线路
    /// </summary>
    STOPMODE,
    /// <summary>
    /// Delete mode	Mode line
    /// 清除模式    模式线路
    /// </summary>
    DELETEMODE,
    /// <summary>
    /// Flip
    /// 翻转命令
    /// </summary>
    REVERSECOMM,
    /// <summary>
    /// 3D position	X address(8192)	Y address(8192)	zoom(4)
    /// 快速定位 水平坐标(8192) 垂直坐标(8192) 变倍(4)
    /// </summary>
    FASTGOTO,
    /// <summary>
    /// auxiliary open	Auxiliary point(param4 corresponding struct PTZ_CONTROL_AUXILIARY,param1、param2、param3 is invalid,dwStop set to FALSE)
    /// 辅助开关开 辅助点(param4对应 PTZ_CONTROL_AUXILIARY,param1、param2、param3无效,dwStop设置为FALSE)
    /// </summary>
    AUXIOPEN,
    /// <summary>
    /// Auxiliary close	Auxiliary point(param4 corresponding struct PTZ_CONTROL_AUXILIARY,param1、param2、param3 is invalid,dwStop set to FALSE)
    /// 辅助开关关 辅助点(param4对应 PTZ_CONTROL_AUXILIARY,param1、param2、param3无效,dwStop设置为FALSE)
    /// </summary>
    AUXICLOSE,
    /// <summary>
    /// Open dome menu 
    /// 打开球机菜单
    /// </summary>
    OPENMENU = 0x36,
    /// <summary>
    /// Close menu 
    /// 关闭菜单
    /// </summary>
    CLOSEMENU,
    /// <summary>
    /// Confirm menu 
    /// 菜单确定
    /// </summary>
    MENUOK,
    /// <summary>
    /// Cancel menu 
    /// 菜单取消
    /// </summary>
    MENUCANCEL,
    /// <summary>
    /// menu up 
    /// 菜单上
    /// </summary>
    MENUUP,
    /// <summary>
    /// menu down
    /// 菜单下
    /// </summary>
    MENUDOWN,
    /// <summary>
    /// menu left
    /// 菜单左
    /// </summary>
    MENULEFT,
    /// <summary>
    /// Menu right
    /// 菜单右
    /// </summary>
    MENURIGHT,
    /// <summary>
    /// Alarm activate PTZ parm1:Alarm input channel;parm2:Alarm activation type  1-preset 2-scan 3-tour;parm 3:activation value,such as preset value.
    /// 报警联动云台 parm1：报警输入通道；parm2：报警联动类型1-预置点2-线扫3-巡航；parm3：联动值,如预置点号
    /// </summary>
    ALARMHANDLE = 0x40,
    /// <summary>
    /// Matrix switch parm1:monitor number(video output number);parm2:video input number;parm3:matrix number 
    /// 矩阵切换 parm1：监视器号(视频输出号)；parm2：视频输入号；parm3：矩阵号
    /// </summary>
    MATRIXSWITCH = 0x41,
    /// <summary>
    /// Light controller
    /// 灯光控制器
    /// </summary>
    LIGHTCONTROL,
    /// <summary>
    /// 3D accurately positioning parm1:Pan degree(0~3600); parm2: tilt coordinates(0~900); parm3:zoom(1~128)
    /// 三维精确定位 parm1：水平角度(0~3600)；parm2：垂直坐标(0~900)；parm3：变倍(1~128)
    /// </summary>
    EXACTGOTO,
    /// <summary>
    /// Reset  3D positioning as zero 
    /// 三维定位重设零位
    /// </summary>
    RESETZERO,
    /// <summary>
    /// Absolute motion control command,param4 corresponding struct NET_PTZ_CONTROL_ABSOLUTELY
    /// 绝对移动控制命令,param4对应结构 NET_PTZ_CONTROL_ABSOLUTELY
    /// </summary>
    MOVE_ABSOLUTELY,
    /// <summary>
    /// Continuous motion control command,param4 corresponding struct NET_PTZ_CONTROL_CONTINUOUSLY
    /// 持续移动控制命令,param4对应结构 NET_PTZ_CONTROL_CONTINUOUSLY
    /// </summary>
    MOVE_CONTINUOUSLY,
    /// <summary>
    /// PTZ control command, at a certain speed to preset locu,parm4 corresponding struct NET_PTZ_CONTROL_GOTOPRESET
    /// 云台控制命令,以一定速度转到预置位点,parm4对应结构NET_PTZ_CONTROL_GOTOPRESET
    /// </summary>
    GOTOPRESET,
    /// <summary>
    /// Set to horizon(param4 corresponding struct NET_PTZ_VIEW_RANGE_INFO)
    /// 设置可视域(param4对应结构 NET_PTZ_VIEW_RANGE_INFO)
    /// </summary>
    SET_VIEW_RANGE = 0x49,
    /// <summary>
    /// Absolute focus(param4 corresponding struct NET_PTZ_FOCUS_ABSOLUTELY)
    /// 绝对聚焦(param4对应结构NET_PTZ_FOCUS_ABSOLUTELY)
    /// </summary>
    FOCUS_ABSOLUTELY = 0x4A,
    /// <summary>
    /// Level fan sweep(param4 corresponding NET_PTZ_CONTROL_SECTORSCAN,param1,param2,param3 is invalid)
    /// 水平扇扫(param4对应PTZ_CONTROL_SECTORSCAN,param1、param2、param3无效)
    /// </summary>
    HORSECTORSCAN = 0x4B,
    /// <summary>
    /// Vertical sweep fan(param4 corresponding NET_PTZ_CONTROL_SECTORSCAN,param1,param2,param3 is invalid)
    /// 垂直扇扫(param4对应PTZ_CONTROL_SECTORSCAN,param1、param2、param3无效)
    /// </summary>
    VERSECTORSCAN = 0x4C,
    /// <summary>
    /// Set absolute focus, focus on value, param1 for focal length, range: [0255], param2 as the focus, scope: [0255], param3, param4 is invalid
    /// 设定绝对焦距、聚焦值,param1为焦距,范围:[0,255],param2为聚焦,范围:[0,255],param3、param4无效
    /// </summary>
    SET_ABS_ZOOMFOCUS = 0x4D,
    /// <summary>
    /// Control fish eye PTZ,param4corresponding to structure NET_PTZ_CONTROL_SET_FISHEYE_EPTZ  
    /// 控制鱼眼电子云台,param4对应结构 PTZ_CONTROL_SET_FISHEYE_EPTZ
    /// </summary>
    SET_FISHEYE_EPTZ = 0x4E,
    /// <summary>
    /// Track start control(param4 corresponding to structure  NET_PTZ_CONTROL_SET_TRACK_CONTROL,dwStop set as FALSE， param1、param2、param3 is invalid)
    /// 轨道机开始控制(param4对应结构体为 PTZ_CONTROL_SET_TRACK_CONTROL,dwStop传FALSE, param1、param2、param3无效)
    /// </summary>
    SET_TRACK_START = 0x4F,
    /// <summary>
    /// Track stop control (param4 corresponding to structure NET_PTZ_CONTROL_SET_TRACK_CONTROL,dwStop set as FALSE，param1、param2、param3  is invalid)
    /// 轨道机停止控制(param4对应结构体为 PTZ_CONTROL_SET_TRACK_CONTROL,dwStop传FALSE,param1、param2、param3无效)
    /// </summary>
    SET_TRACK_STOP = 0x50,
    /// <summary>
    /// Up + TELE param1=speed (1-8) 
    /// 上 + TELE param1=速度(1-8),下同
    /// </summary>                                                     
    UP_TELE = 0x70,
    /// <summary>
    /// Down + TELE
    /// 下 + TELE
    /// </summary>
    DOWN_TELE,
    /// <summary>
    /// Left + TELE
    /// 左 + TELE
    /// </summary>
    LEFT_TELE,
    /// <summary>
    /// Right + TELE
    /// 右 + TELE
    /// </summary>
    RIGHT_TELE,
    /// <summary>
    /// Upper left + TELE
    /// 左上 + TELE
    /// </summary>
    LEFTUP_TELE,
    /// <summary>
    /// Down left + TELE
    /// 左下 + TELE
    /// </summary>
    LEFTDOWN_TELE,
    /// <summary>
    /// Upper right + TELE
    /// 右上 + TELE
    /// </summary>
    TIGHTUP_TELE,
    /// <summary>
    /// Down right + TELE
    /// 右下 + TELE
    /// </summary>
    RIGHTDOWN_TELE,
    /// <summary>
    /// Up + WIDE param1=speed (1-8) 
    /// 上 + WIDE param1=速度(1-8),下同
    /// </summary>
    UP_WIDE,
    /// <summary>
    /// Down + WIDE
    /// 下 + WIDE
    /// </summary>
    DOWN_WIDE,
    /// <summary>
    /// Left + WIDE
    /// 左 + WIDE
    /// </summary>
    LEFT_WIDE,
    /// <summary>
    /// Right + WIDE
    /// 右 + WIDE
    /// </summary>
    RIGHT_WIDE,
    /// <summary>
    /// Upper left + WIDE
    /// 左上 + WIDE
    /// </summary>
    LEFTUP_WIDE,
    /// <summary>
    /// Down left+ WIDE
    /// 左下 + WIDE
    /// </summary>
    LEFTDOWN_WIDE,
    /// <summary>
    /// Upper right + WIDE
    /// 右上 + WIDE
    /// </summary>
    TIGHTUP_WIDE,
    /// <summary>
    /// Down right + WIDE
    /// 右下 + WIDE
    /// </summary>
    RIGHTDOWN_WIDE,
    /// <summary>
    /// max command value
    /// 最大命令值
    /// </summary>
    TOTAL,
  }

  /// <summary>
  /// frame parameter structure of Callback video data frame
  /// 回调视频数据帧的帧参数结构体
  /// </summary>
  public struct NET_VideoFrameParam
  {
    /// <summary>
    /// Encode type 
    /// 编码类型
    /// </summary>
    public byte encode;
    /// <summary>
    /// I = 0, P = 1, B = 2...
    /// I = 0, P = 1, B = 2...
    /// </summary>
    public byte frametype;
    /// <summary>
    /// PAL - 0, NTSC - 1
    /// PAL - 0, NTSC - 1
    /// </summary>
    public byte format;
    /// <summary>
    /// CIF - 0, HD1 - 1, 2CIF - 2, D1 - 3, VGA - 4, QCIF - 5, QVGA - 6 ,SVCD - 7,QQVGA - 8, SVGA - 9, XVGA - 10,WXGA - 11,SXGA - 12,WSXGA - 13,UXGA - 14,WUXGA - 15,LFT - 16, 720 - 17, 1080 - 18,1_3M-19, 2M-20, 5M-21;when size equal to 255, width and height valid
    /// CIF - 0, HD1 - 1, 2CIF - 2, D1 - 3, VGA - 4, QCIF - 5, QVGA - 6 ,SVCD - 7,QQVGA - 8, SVGA - 9, XVGA - 10,WXGA - 11,SXGA - 12,WSXGA - 13,UXGA - 14,WUXGA - 15,LFT - 16, 720 - 17, 1080 - 18 ,1_3M-19,2M-20, 5M-21;当size=255时，成员变量width,height 有效
    /// </summary>
    public byte size;
    /// <summary>
    /// If it is H264 encode it is always 0,Fill in FOURCC('X','V','I','D') in MPEG 4
    /// 如果是H264编码则总为0，否则值为*( DWORD*)"DIVX"，即0x58564944
    /// </summary>
    public uint fourcc;
    /// <summary>
    /// width pixel, valid when struct member "size"  equal to 255
    /// 宽，单位是像素，当size=255时有效
    /// </summary>
    public ushort width;
    /// <summary>
    /// height pixel, valid when struct member "size"  equal to 255
    /// 高，单位是像素，当size=255时有效
    /// </summary>
    public ushort height;
    /// <summary>
    /// Time information
    /// 时间信息
    /// </summary>
    public NET_TIME struTime;
  }

  /// <summary>
  /// frame parameter structure of audio data callback 
  /// 回调音频数据帧的帧参数结构体
  /// </summary>
  public struct NET_CBPCMDataParam
  {
    /// <summary>
    /// Track amount
    /// 声道数
    /// </summary>
    public byte channels;
    /// <summary>
    /// sample 0 - 8000, 1 - 11025, 2 - 16000, 3 - 22050, 4 - 32000, 5 - 44100, 6 - 48000
    /// 采样 0 - 8000, 1 - 11025, 2 - 16000, 3 - 22050, 4 - 32000, 5 - 44100, 6 - 48000
    /// </summary>
    public byte samples;
    /// <summary>
    /// Sampling depth. Value:8/16 show directly
    /// 采样深度 取值8或者16等。直接表示
    /// </summary>
    public byte depth;
    /// <summary>
    /// 0 - indication no symbol,1-indication with symbol
    /// 0 - 指示无符号,1-指示有符号
    /// </summary>
    public byte param1;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    public uint reserved;
  }

  /// <summary>
  /// Time structure
  /// 时间结构体
  /// </summary>
  public struct NET_TIME
  {
    /// <summary>
    /// Year
    /// 年
    /// </summary>
    public uint dwYear;
    /// <summary>
    /// Month
    /// 月
    /// </summary>
    public uint dwMonth;
    /// <summary>
    /// Day
    /// 天
    /// </summary>
    public uint dwDay;
    /// <summary>
    /// Hour
    /// 小时
    /// </summary>
    public uint dwHour;
    /// <summary>
    /// Minute
    /// 分
    /// </summary>
    public uint dwMinute;
    /// <summary>
    /// Second
    /// 秒
    /// </summary>
    public uint dwSecond;
    /// <summary>
    /// DateTime change to NET_TIME static funtion.
    /// DateTime转为NET_TIME静态函数
    /// </summary>
    /// <param name="dateTime">datetime</param>
    /// <returns>NET_TIME</returns>
    public static NET_TIME FromDateTime(DateTime dateTime)
    {
      try
      {
        NET_TIME net_time = new NET_TIME();
        net_time.dwYear = (uint)dateTime.Year;
        net_time.dwMonth = (uint)dateTime.Month;
        net_time.dwDay = (uint)dateTime.Day;
        net_time.dwHour = (uint)dateTime.Hour;
        net_time.dwMinute = (uint)dateTime.Minute;
        net_time.dwSecond = (uint)dateTime.Second;
        return net_time;
      }
      catch
      {
        return new NET_TIME();
      }
    }
    /// <summary>
    /// change NET_TIME to DateTime
    /// NET_TIME 转为 DateTime
    /// </summary>
    /// <returns>DateTime</returns>
    public DateTime ToDateTime()
    {
      try
      {
        return new DateTime((int)dwYear, (int)dwMonth, (int)dwDay, (int)dwHour, (int)dwMinute, (int)dwSecond);
      }
      catch
      {
        return DateTime.Now;
      }
    }
    /// <summary>
    /// oveeride toString function
    /// 重写toString函数
    /// </summary>
    /// <returns>return time string</returns>
    public override string ToString()
    {
      return string.Format("{0}-{1}-{2} {3}:{4}:{5}", dwYear.ToString("D4"), dwMonth.ToString("D2"), dwDay.ToString("D2"), dwHour.ToString("D2"), dwMinute.ToString("D2"), dwSecond.ToString("D2"));
    }
  }

  /// <summary>
  /// control playback type
  /// 回放控制类型
  /// </summary>
  public enum PlayBackType
  {
    /// <summary>
    /// play
    /// 播发
    /// </summary>
    Play,
    /// <summary>
    /// pause
    /// 暂停
    /// </summary>
    Pause,
    /// <summary>
    /// stop
    /// 停止
    /// </summary>
    Stop,
    /// <summary>
    /// fast
    /// 快放
    /// </summary>
    Fast,
    /// <summary>
    /// slow
    /// 慢放
    /// </summary>
    Slow,
    /// <summary>
    /// normal
    /// 正常播放
    /// </summary>
    Normal,
  }

  /// <summary>
  /// user work mode enumeration
  /// 用户设置工作模式枚举
  /// </summary>
  public enum EM_USEDEV_MODE
  {
    /// <summary>
    /// Set client-end mode to begin audio talk 
    /// 设置客户端方式进行语音对讲
    /// </summary>
    TALK_CLIENT_MODE,
    /// <summary>
    /// Set server mode to begin audio talk 
    /// 设置服务器方式进行语音对讲
    /// </summary>
    TALK_SERVER_MODE,
    /// <summary>
    /// Set encode format for audio talk,corresponding structure NET_DEV_TALKDECODE_INFO
    /// 设置语音对讲编码格式(对应NET_DEV_TALKDECODE_INFO)
    /// </summary>
    TALK_ENCODE_TYPE,
    /// <summary>
    /// Set alarm subscribe way
    /// 设置报警订阅方式
    /// </summary>
    ALARM_LISTEN_MODE,
    /// <summary>
    /// Set user right to realize configuration management
    /// 设置通过权限进行配置管理
    /// </summary>
    CONFIG_AUTHORITY_MODE,
    /// <summary>
    /// set talking channel(0~MaxChannel-1)
    /// 设置对讲通道(0~MaxChannel-1)
    /// </summary>
    TALK_TALK_CHANNEL,
    /// <summary>
    /// set the stream type of the record for query(0-both main and extra stream,1-only main stream,2-only extra stream)
    /// 设置待查询及按时间回放的录像码流类型(0-主辅码流,1-主码流,2-辅码流)
    /// </summary>
    RECORD_STREAM_TYPE,
    /// <summary>
    /// set speaking parameter,corresponding structure NET_SPEAK_PARAM
    /// 设置语音对讲喊话参数,对应结构体 NET_SPEAK_PARAM
    /// </summary>
    TALK_SPEAK_PARAM,
    /// <summary>
    /// Set by time video playback and download the video file TYPE,see to EM_RECORD_TYPE
    /// 设置按时间录像回放及下载的录像文件类型(详见EM_RECORD_TYPE)
    /// </summary>
    RECORD_TYPE,
    /// <summary>
    /// Set voice intercom parameters of three generations of equipment and the corresponding structure NET_TALK_EX
    /// 设置三代设备的语音对讲参数, 对应结构体 NET_TALK_EX
    /// </summary>
    TALK_MODE3,
    /// <summary>
    /// set real time playback function(0-off,1-on)
    /// 设置实时回放功能(0-关闭,1开启)
    /// </summary>
    PLAYBACK_REALTIME_MODE,
    /// <summary>
    /// judge the voice intercom if it was a forwarding mode, (corresponding to  NET_TALK_TRANSFER_PARAM)
    /// 设置语音对讲是否为转发模式, 对应结构体 NET_TALK_TRANSFER_PARAM
    /// </summary>
    TALK_TRANSFER_MODE,
    /// <summary>
    /// set VT parameters,corresponding structure NET_VT_TALK_PARAM
    /// 设置VT对讲参数, 对应结构体 NET_VT_TALK_PARAM
    /// </summary>
    TALK_VT_PARAM,
    /// <summary>
    /// set target device identifier for searching system capacity information, (not zero - locate device forwards the information)
    /// 设置目标设备标示符, 用以查询新系统能力(非0-转发系统能力消息)
    /// </summary>
    TARGET_DEV_ID,
  }

  /// <summary>
  /// audio encode information structure
  /// 语音编码信息
  /// </summary>
  public struct NET_DEV_TALKDECODE_INFO
  {
    /// <summary>
    /// Encode type
    /// 编码类型
    /// </summary>
    public EM_TALK_CODING_TYPE encodeType;
    /// <summary>
    /// Bit:8/16
    /// 位数,如8或16, 目前只能是16
    /// </summary>
    public int nAudioBit;
    /// <summary>
    /// Sampling rate such as 8000 or 16000
    /// 采样率,如8000或16000
    /// </summary>
    public uint dwSampleRate;
    /// <summary>
    /// Pack Period,Unit ms
    /// 打包周期, 单位ms
    /// </summary>
    public int nPacketPeriod;
    /// <summary>
    /// resrved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
    public byte[] reserved;
  }

  /// <summary>
  /// audio encode type enumeration
  /// 语音编码类型
  /// </summary>
  public enum EM_TALK_CODING_TYPE
  {
    /// <summary>
    /// No-head PCM
    /// 无头PCM
    /// </summary>
    DEFAULT = 0,
    /// <summary>
    /// With head PCM
    /// 带头PCM
    /// </summary>
    PCM = 1,
    /// <summary>
    /// G711a
    /// G711a
    /// </summary>
    G711a,
    /// <summary>
    /// AMR
    /// AMR
    /// </summary>
    AMR,
    /// <summary>
    /// G711u
    /// G711u
    /// </summary>
    G711u,
    /// <summary>
    /// G726
    /// G726
    /// </summary>
    G726,
    /// <summary>
    /// G723_53
    /// G723_53
    /// </summary>
    G723_53,
    /// <summary>
    /// G723_63
    /// G723_63
    /// </summary>
    G723_63,
    /// <summary>
    /// AAC
    /// AAC
    /// </summary>
    AAC,
    /// <summary>
    /// OGG
    /// OGG
    /// </summary>
    OGG,
    /// <summary>
    /// G729
    /// G729
    /// </summary>
    G729 = 10,
    /// <summary>
    /// MPEG2
    /// MPEG2
    /// </summary>
    MPEG2,
    /// <summary>
    /// MPEG2-Layer2
    /// MPEG2-Layer2
    /// </summary>
    MPEG2_Layer2,
    /// <summary>
    /// G.722.1
    /// G.722.1
    /// </summary>
    G722_1,
    /// <summary>
    /// ADPCM
    /// ADPCM
    /// </summary>
    ADPCM = 21,
    /// <summary>
    /// MP3
    /// MP3
    /// </summary>
    MP3 = 22,
  }

  /// <summary>
  /// speak information structure
  /// 对讲信息结构体
  /// </summary>
  public struct NET_SPEAK_PARAM
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// 0:talk back(default), 1: propaganda,from propaganda ro talk back,need afresh to configure
    /// 0：对讲（默认模式）,1：喊话；从喊话切换到对讲要重新设置
    /// </summary>
    public int nMode;
    /// <summary>
    /// reproducer channel
    /// 扬声器通道号,喊话时有效
    /// </summary>
    public int nSpeakerChannel;
    /// <summary>
    /// Wait for device to responding or not when enable bidirectional talk. Default setup is no.TRUE:wait ;FALSE:no
    /// 开启对讲时是否等待设备的响应,默认不等待.TRUE:等待;FALSE:不等待，超时时间由CLIENT_SetNetworkParam设置,对应NET_PARAM的nWaittime字段
    /// </summary>
    public bool bEnableWait;
  }

  /// <summary>
  /// record file type
  /// 录像文件类型
  /// </summary>
  public enum EM_RECORD_TYPE
  {
    /// <summary>
    /// All the video
    /// 所有录像
    /// </summary>
    ALL,
    /// <summary>
    /// normal  video
    /// 普通录像
    /// </summary>
    NORMAL,
    /// <summary>
    /// External alarm video
    /// 外部报警录像
    /// </summary>
    ALARM,
    /// <summary>
    /// motion alarm video
    /// 动检报警录像
    /// </summary>
    MOTION,
  }

  /// <summary>
  /// extend talk information for EM_USEDEV_MODE.TALK_MODE3
  /// 对讲扩展结构体
  /// </summary>
  public struct NET_TALK_EX
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel number
    /// 通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// Audio transmission listener ports
    /// 音频传输侦听端口
    /// </summary>
    public int nAudioPort;
    /// <summary>
    /// Ms wait time, unit, use the default value is 0
    /// 等待时间, 单位ms,为0则使用默认值
    /// </summary>
    public int nWaitTime;
    /// <summary>
    /// Visual talk video window
    /// 可视对讲视频显示窗口
    /// </summary>
    public IntPtr hVideoWnd;
    /// <summary>
    /// Video encode format
    /// 视频编码格式
    /// </summary>
    public NET_TALK_VIDEO_FORMAT stuVideoFmt;
    /// <summary>
    /// Multicast address
    /// 组播地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
    public byte[] szMulticastAddr;
    /// <summary>
    /// Multicast local port
    /// 组播本地端口
    /// </summary>
    public ushort wMulticastLocalPort;
    /// <summary>
    /// Multicast remote port
    /// 组播远程端口
    /// </summary>
    public ushort wMulticastRemotePort;
  }

  /// <summary>
  /// video format information
  /// 视频格式信息结构体
  /// </summary>
  public struct NET_TALK_VIDEO_FORMAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Video compression format
    /// 视频压缩格式
    /// </summary>
    public uint dwCompression;
    /// <summary>
    /// Video sampling frequency
    /// 视频采样频率
    /// </summary>
    public int nFrequency;
  }

  /// <summary>
  /// open the forwarding mode of intercom or not 
  /// 是否开启语音对讲的转发模式
  /// </summary>
  public struct NET_TALK_TRANSFER_PARAM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Open the forwarding mode of intercom or not, TRUE: yes, FALSE: no
    /// 是否开启语音对讲转发模式, TRUE: 开启转发, FALSE: 关闭转发
    /// </summary>
    public bool bTransfer;
  }

  /// <summary>
  /// talk about VT information
  /// VT对讲参数
  /// </summary>
  public struct NET_VT_TALK_PARAM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// identity filed is valid by bitwise.see EM_VT_PARAM_VALID
    /// 按位标识后面的字段是否有效, EM_VT_PARAM_VALID的组合
    /// </summary>
    public int nValidFlag;
    /// <summary>
    /// event call back, EM_VT_PARAM_VALID.EVENT_CB is valid
    /// 事件回调函数, EM_VT_PARAM_VALID.EVENT_CB
    /// </summary>
    public fVtEventCallBack pfEventCb;
    /// <summary>
    /// call back user data, EM_VT_PARAM_VALID.USER_DATA is valid
    /// 事件回调函数自定义数据, EM_VT_PARAM_VALID.USER_DATA
    /// </summary>
    public IntPtr dwUser;
    /// <summary>
    /// Mid-number(the called number), 8byte, EM_VT_PARAM_VALID.MID_NUM is valid
    /// 被叫中号, 8位, EM_VT_PARAM_VALID.MID_NUM
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szPeerMidNum;
    /// <summary>
    /// call operation, 0:no-operation, 1:repulse, 2:accept, EM_VT_PARAM_VALID.ACTION is valid
    /// 对呼叫的操作, 0:无操作, 1:拒接, 2:接入, EM_VT_PARAM_VALID_ACTION
    /// </summary>
    public EM_NEWCALL_ACTION emAction;
    /// <summary>
    /// waitting time(ms), EM_VT_PARAM_VALID.WAITTIME is valid
    /// 超时时间, 单位ms, EM_VT_PARAM_VALID.WAITTIME
    /// </summary>
    public int nWaitTime;
    /// <summary>
    /// handle for show video, EM_VT_PARAM_VALID.VIDEOWND is valid
    /// 可视对讲视频显示窗口, EM_VT_PARAM_VALID.VIDEOWND
    /// </summary>
    public IntPtr hVideoWnd;
    /// <summary>
    /// talk mode, true:client, false:server, EM_VT_PARAM_VALID.CSMODE is valid
    /// 客户端/服务器模式, TRUE:客户端, FALSE:服务器, EM_VT_PARAM_VALID.CSMODE
    /// </summary>
    public bool bClient;
    /// <summary>
    /// talk decode information.
    /// 语音编码信息, EM_VT_PARAM_VALID.AUDIO_ENCODE
    /// </summary>
    public NET_DEV_TALKDECODE_INFO stAudioEncode;
  }

  /// <summary>
  /// call operation  for VT 
  /// 呼叫事件处理动作
  /// </summary>
  public enum EM_NEWCALL_ACTION
  {
    /// <summary>
    /// no-operation
    /// 无操作
    /// </summary>                                                     
    UNKNOWN,
    /// <summary>                                                      
    /// repulse                                                        
    /// 拒接                                                               
    /// </summary>                                                     
    REFUSE,
    /// <summary>                                                      
    /// accept                                                         
    /// 接入                                                               
    /// </summary>                                                     
    ACCEPT,
  }

  /// <summary>
  /// valid paramter for VT
  /// VT有效参数类型
  /// </summary>
  public enum EM_VT_PARAM_VALID
  {
    /// <summary>
    /// event call back
    /// 事件回调
    /// </summary>
    EVENT_CB = 0x0001,
    /// <summary>
    /// user data
    /// 用户数据
    /// </summary>
    USER_DATA = 0x0002,
    /// <summary>
    /// Mid-number
    /// 中号
    /// </summary>
    MID_NUM = 0x0004,
    /// <summary>
    /// call operation
    /// 呼叫操作
    /// </summary>
    ACTION = 0x0008,
    /// <summary>
    /// waitting time
    /// 等待
    /// </summary>
    WAITTIME = 0x0010,
    /// <summary>
    /// handle for show video
    /// 显示视频
    /// </summary>
    VIDEOWND = 0x0020,
    /// <summary>
    /// talk mode
    /// 对讲模式
    /// </summary>
    CSMODE = 0x0040,
    /// <summary>
    /// audio encode
    /// 音频编码
    /// </summary>
    AUDIO_ENCODE = 0x0080,
    /// <summary>
    /// local ip
    /// 本地IP
    /// </summary>
    LOCAL_IP = 0x0100,
  }

  /// <summary>
  /// event type
  /// 事件类型
  /// </summary>
  public enum EM_AUDIO_CB_FLAG
  {
    /// <summary>
    /// unknow
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// new call
    /// 有呼叫进来
    /// </summary>
    NEWCALL,
    /// <summary>
    /// hangup
    /// 对方挂断
    /// </summary>
    REMOTE_HANGUP,
    /// <summary>
    /// disconncet
    /// 断线
    /// </summary>
    DISCONNECT,
    /// <summary>
    /// ring
    /// 对端响铃
    /// </summary>
    RING,
  }

  /// <summary>
  /// record play back parameter information
  /// 录像回放入参信息
  /// </summary>
  public struct NET_IN_PLAY_BACK_BY_TIME_INFO
  {
    /// <summary>
    /// Begin time
    /// 开始时间
    /// </summary>
    public NET_TIME stStartTime;
    /// <summary>
    /// End time
    /// 结束时间
    /// </summary>
    public NET_TIME stStopTime;
    /// <summary>
    /// Play window
    /// 播放窗格, 可为NULL
    /// </summary>
    public IntPtr hWnd;
    /// <summary>
    /// Download pos callback
    /// 进度回调
    /// </summary>
    public fDownLoadPosCallBack cbDownLoadPos;
    /// <summary>
    /// Pos user
    /// 进度回调用户信息
    /// </summary>
    public IntPtr dwPosUser;
    /// <summary>
    /// Download data callback
    /// 数据回调
    /// </summary>
    public fDataCallBack fDownLoadDataCallBack;
    /// <summary>
    /// Data user
    /// 数据回调用户信息
    /// </summary>
    public IntPtr dwDataUser;
    /// <summary>
    /// Playback direction 
    /// 播放方向, 0:正放; 1:倒放(需要设备支持）
    /// </summary>
    public int nPlayDirection;
    /// <summary>
    /// Watiting time
    /// 接口超时时间, 目前倒放使用
    /// </summary>
    public int nWaittime;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  }

  /// <summary>
  /// record play back parameter out
  /// 录像回放出参信息
  /// </summary>
  public struct NET_OUT_PLAY_BACK_BY_TIME_INFO
  {
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  }

  /// <summary>
  /// record file information
  /// 录像文件信息
  /// </summary>
  public struct NET_RECORDFILE_INFO
  {
    /// <summary>
    /// Channel number
    /// 通道号
    /// </summary>
    public uint ch;
    /// <summary>
    /// File name
    /// 文件名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 124)]
    public string filename;
    /// <summary>
    /// the total number of file frames
    /// 文件总帧数
    /// </summary>
    public uint framenum;
    /// <summary>
    /// File length 
    /// 文件长度, 单位为Kbyte
    /// </summary>
    public uint size;
    /// <summary>
    /// Start time 
    /// 开始时间
    /// </summary>
    public NET_TIME starttime;
    /// <summary>
    /// End time 
    /// 结束时间
    /// </summary>
    public NET_TIME endtime;
    /// <summary>
    /// HDD number, 0－127 is the local record. 128-network record
    /// 磁盘号(区分网络录像和本地录像的类型,0－127表示本地录像,其中64表示光盘1,128表示网络录像)
    /// </summary>
    public uint driveno;
    /// <summary>
    /// Start cluster number 
    /// 起始簇号
    /// </summary>
    public uint startcluster;
    /// <summary>
    /// Recorded file type  0:general record;1:alarm record ;2:motion detection;3:card number record ;4:image ;255:all
    /// 录象文件类型  0：普通录象；1：报警录象；2：移动检测；3：卡号录象；4：图片, 5: 智能录像, 19: POS录像, 255:所有录像
    /// </summary>
    public byte nRecordFileType;
    /// <summary>
    /// 0:general record 1:Important record
    /// 0:普通录像 1:重要录像
    /// </summary>
    public byte bImportantRecID;
    /// <summary>
    /// Document Indexing
    /// 文件定位索引(nRecordFileType==4<图片>时,bImportantRecID<<8 +bHint ,组成图片定位索引 )
    /// </summary>
    public byte bHint;
    /// <summary>
    /// 0-main stream record 1-sub1 stream record 2-sub2 stream record 3-sub3 stream record
    /// 0-主码流录像 1-辅码流1录像 2-辅码流2 3-辅码流3录像
    /// </summary>
    public byte bRecType;
  }

  /// <summary>
  /// type of video search
  /// 录像查询类型
  /// </summary>
  public enum EM_QUERY_RECORD_TYPE
  {
    /// <summary>
    /// All the recorded video  
    /// 所有录像
    /// </summary>
    ALL = 0,
    /// <summary>
    /// The video of external alarm
    /// 外部报警录像
    /// </summary>
    ALARM = 1,
    /// <summary>
    /// The video of dynamic detection alarm
    /// 动态检测报警录像
    /// </summary>
    MOTION_DETECT = 2,
    /// <summary>
    /// All the alarmed video
    /// 所有报警录像
    /// </summary>
    ALARM_ALL = 3,
    /// <summary>
    /// query by the card number
    /// 卡号查询
    /// </summary>
    CARD = 4,
    /// <summary>
    /// query by condition
    /// 按条件查询
    /// </summary>
    CONDITION = 5,
    /// <summary>
    /// combination query 
    /// 组合查询
    /// </summary>
    JOIN = 6,
    /// <summary>
    /// query pictures by the card number, used by HB-U and NVS
    /// 按卡号查询图片,HB-U、NVS等使用
    /// </summary>
    CARD_PICTURE = 8,
    /// <summary>
    /// query pictures, used by HB-U and NVS
    /// 查询图片,HB-U、NVS等使用
    /// </summary>
    PICTURE = 9,
    /// <summary>
    /// query by field
    /// 按字段查询
    /// </summary>
    FIELD = 10,
    /// <summary>
    /// Smart record search 
    /// 智能录像查询
    /// </summary>
    INTELLI_VIDEO = 11,
    /// <summary>
    /// query network data, used by Jinqiao Internet Bar
    /// 查询网络数据,金桥网吧等使用
    /// </summary>
    NET_DATA = 15,
    /// <summary>
    /// query the video of serial data
    /// 查询透明串口数据录像
    /// </summary>
    TRANS_DATA = 16,
    /// <summary>
    /// query the important video
    /// 查询重要录像
    /// </summary>
    IMPORTANT = 17,
    /// <summary>
    /// query the talk file
    /// 查询录音文件
    /// </summary>
    TALK_DATA = 18,
    /// <summary>
    /// invalid query type
    /// POS录像
    /// </summary>
    INVALID = 256,
  }

  /// <summary>
  /// alarm type,used in fMessCallBackEx
  /// 报警类型
  /// </summary>
  public enum EM_ALARM_TYPE
  {
    /// <summary>
    /// External alarm ,data's length(byte) is same to device's alarm channels' count, 1 means alarm, 0 means Non alarm.
    /// 外部报警，数据字节数与设备报警通道个数相同，每个字节表示一个报警通道的报警状态，1为有报警，0为无报警
    /// </summary>
    ALARM_ALARM_EX = 0x2101,
    /// <summary>
    /// Motion detection alarm 
    /// 动态检测报警，数据字节数与设备视频通道个数相同，每个字节表示一个视频通道的动态检测报警状态，1为有报警，0为无报警
    /// </summary>
    MOTION_ALARM_EX = 0x2102,
    /// <summary>
    /// Video loss alarm 
    /// 视频丢失报警，数据字节数与设备视频通道个数相同，每个字节表示一个视频通道的视频丢失报警状态，1为有报警，0为无报警
    /// </summary>
    VIDEOLOST_ALARM_EX = 0x2103,
    /// <summary>
    /// Camera masking alarm 
    /// 视频遮挡报警，数据字节数与设备视频通道个数相同，每个字节表示一个视频通道的遮挡(黑屏)报警状态，1为有报警，0为无报警
    /// </summary>
    SHELTER_ALARM_EX = 0x2104,
    /// <summary>
    /// Audio detection alarm 
    /// 音频检测报警，数据为16个字节，每个字节表示一个视频通道的音频检测报警状态，1为有报警，0为无报警
    /// </summary>
    SOUND_DETECT_ALARM_EX = 0x2105,
    /// <summary>
    /// HDD full alarm 
    /// 硬盘满报警，数据为1个字节，1为有硬盘满报警，0为无报警
    /// </summary>
    DISKFULL_ALARM_EX = 0x2106,
    /// <summary>
    /// HDD error alarm
    /// 坏硬盘报警，数据为32个字节，每个字节表示一个硬盘的故障报警状态，1为有报警，0为无报警
    /// </summary>
    DISKERROR_ALARM_EX = 0x2107,
    /// <summary>
    /// Encoder alarm
    /// 编码器报警，数据为16个字节，每个字节表示一个通道编码器状态，1为有报警，0为无报警
    /// </summary>
    ENCODER_ALARM_EX = 0x210A,
    /// <summary>
    /// Emergency alarm 
    /// 紧急报警，数据为16个字节，每个字节表示一个通道编码器状态，1为有报警，0为无报警
    /// </summary>
    URGENCY_ALARM_EX = 0x210B,
    /// <summary>
    /// Wireless alarm
    /// 无线报警，数据为16个字节，每个字节表示一个通道编码器状态，1为有报警，0为无报警
    /// </summary>
    WIRELESS_ALARM_EX = 0x210C,
    /// <summary>
    /// New auido detection alarm. Please refer to NET_NEW_SOUND_ALARM_STATE for alarm information structure
    /// 新音频检测报警,报警信息的结构体见NET_NEW_SOUND_ALARM_STATE
    /// </summary>
    NEW_SOUND_DETECT_ALARM_EX = 0x210D,
    /// <summary>
    /// Alarm decoder alarm
    /// 报警解码器报警，报警信息的结构体见 NET_ALARM_DECODER_ALARM
    /// </summary>
    ALARM_DECODER_ALARM_EX = 0x210E,
    /// <summary>
    /// NVD:Decoding capacity
    /// 解码器：解码能力报警，数据为一个字节，0：能正常解码 1：表示超出解码能力
    /// </summary>
    DECODER_DECODE_ABILITY = 0x210F,
    /// <summary>
    /// Fiber encoder alarm
    /// 光纤编码器状态报警，报警信息的结构体见 NET_ALARM_FDDI_ALARM
    /// </summary>
    FDDI_DECODER_ABILITY = 0x2110,
    /// <summary>
    /// Panorama switch alarm
    /// 切换场景报警，数据为16个字节，每个字节表示一个通道编码器状态，1为有报警，0为无报警
    /// </summary>
    PANORAMA_SWITCH_ALARM_EX = 0x2111,
    /// <summary>
    /// Lost focus alarm
    /// 失去焦点报警，数据为16个字节，每个字节表示一个通道编码器状态，1为有报警，0为无报警
    /// </summary>
    LOSTFOCUS_ALARM_EX = 0x2112,
    /// <summary>
    /// oem state
    /// oem报停状态，数据为 1 BYTE
    /// </summary>
    OEMSTATE_EX = 0x2113,
    /// <summary>
    /// DSP alarm
    /// DSP报警，报警信息的结构体见 NET_DSP_ALARM
    /// </summary>
    DSP_ALARM_EX = 0x2114,
    /// <summary>
    /// atm and pos disconnection alarm, 0:disconnection 1:connection
    /// atm和pos机断开报警, 数据为 1 BYTE，0：连接断开 1：连接正常
    /// </summary>
    ATMPOS_BROKEN_EX = 0x2115,
    /// <summary>
    /// Record state changed alarm
    /// 录像状态变化报警，报警信息为 NET_ALARM_RECORDING_CHANGED 数组
    /// </summary>
    RECORD_CHANGED_EX = 0x2116,
    /// <summary>
    /// Device config changed alarm
    /// 配置发生变化报警，数据 无
    /// </summary>
    CONFIG_CHANGED_EX = 0x2117,
    /// <summary>
    /// Device rebooting alarm
    /// 设备重启报警，数据 无
    /// </summary>
    DEVICE_REBOOT_EX = 0x2118,
    /// <summary>
    /// CoilFault alarm
    /// 线圈/车检器故障报警(对应结构体 NET_ALARM_WINGDING_INFO)
    /// </summary>
    WINGDING_ALARM_EX = 0x2119,
    /// <summary>
    /// traffic congestion alarm
    /// 交通阻塞报警(车辆出现异常停止或者排队)(对应结构体 NET_ALARM_TRAF_CONGESTION_INFO)
    /// </summary>
    TRAF_CONGESTION_ALARM_EX = 0x211A,
    /// <summary>
    /// traffic exception alarm
    /// 交通异常报警(交通流量趋于0或异常空闲)(对应结构体 NET_ALARM_TRAF_EXCEPTION_INFO)
    /// </summary>
    TRAF_EXCEPTION_ALARM_EX = 0x211B,
    /// <summary>
    /// FlashFault alarm
    /// 补光设备故障报警(对应结构体 NET_ALARM_EQUIPMENT_FILL_INFO)
    /// </summary>
    EQUIPMENT_FILL_ALARM_EX = 0x211C,
    /// <summary>
    /// alarm arm disarm 
    /// 报警布撤防状态(对应结构体 NET_ALARM_EQUIPMENT_FILL_INFO)
    /// </summary>
    ALARM_ARM_DISARM_STATE = 0x211D,
    /// <summary>
    /// ACC power off alarm
    /// ACC断电报警，数据为 DWORD 0：ACC通电 1：ACC断电
    /// </summary>
    ALARM_ACC_POWEROFF = 0x211E,
    /// <summary>
    /// Alarm of 3G flow exceed(see struct NET_DEV_3GFLOW_EXCEED_STATE_INFO)
    /// 3G流量超出阈值报警(对应结构体 NET_DEV_3GFLOW_EXCEED_STATE_INFO)
    /// </summary>
    ALARM_3GFLOW_EXCEED = 0x211F,
    /// <summary>
    /// Speed limit alarm 
    /// 限速报警(对应结构体 NET_ALARM_SPEED_LIMIT)
    /// </summary>
    ALARM_SPEED_LIMIT = 0x2120,
    /// <summary>
    /// Vehicle information uploading
    /// 车载自定义信息上传 (对应结构体 NET_ALARM_VEHICLE_INFO_UPLOAD)
    /// </summary>
    ALARM_VEHICLE_INFO_UPLOAD = 0x2121,
    /// <summary>
    /// Static detection alarm
    /// 静态检测报警，数据字节数与设备视频通道个数相同，每个字节表示一个视频通道的静态检测报警状态，1为有报警，0为无报警
    /// </summary>
    STATIC_ALARM_EX = 0x2122,
    /// <summary>
    /// ptz location info
    /// 云台定位信息(对应结构体 NET_PTZ_LOCATION_INFO)
    /// </summary>
    PTZ_LOCATION_EX = 0x2123,
    /// <summary>
    /// card record info(struct NET_ALARM_CARD_RECORD_INFO_UPLOAD)
    /// 卡号录像信息上传(对应结构体 NET_ALARM_CARD_RECORD_INFO_UPLOAD)
    /// </summary>
    ALARM_CARD_RECORD_UPLOAD = 0x2124,
    /// <summary>
    /// ATM trade info(struct NET_ALARM_ATM_INFO_UPLOAD)
    /// ATM交易信息上传(对应结构体 ALARM_ATM_INFO_UPLOAD)
    /// </summary>
    ALARM_ATM_INFO_UPLOAD = 0x2125,
    /// <summary>
    /// enclosure alarm(struct NET_ALARM_ENCLOSURE_INFO)
    /// 电子围栏报警(对应结构体NET_ALARM_ENCLOSURE_INFO)
    /// </summary>
    ALARM_ENCLOSURE = 0x2126,
    /// <summary>
    /// SIP state alarm(struct NET_ALARM_SIP_STATE)
    /// SIP状态报警(对应结构体 NET_ALARM_SIP_STATE)
    /// </summary>
    ALARM_SIP_STATE = 0x2127,
    /// <summary>
    /// RAID state alarm(struct NET_ALARM_RAID_INFO)
    /// RAID异常报警(对应结构体 NET_ALARM_RAID_INFO)
    /// </summary>
    ALARM_RAID_STATE = 0x2128,
    /// <summary>
    /// crossing speed limit alarm(struct NET_ALARM_SPEED_LIMIT)
    /// 路口限速报警(对应结构体 NET_ALARM_SPEED_LIMIT)
    /// </summary>
    ALARM_CROSSING_SPEED_LIMIT = 0x2129,
    /// <summary>
    /// over loading alarm(struct NET_ALARM_OVER_LOADING)
    /// 超载报警(对应结构体NET_ALARM_OVER_LOADING)
    /// </summary>
    ALARM_OVER_LOADING = 0x212A,
    /// <summary>
    /// hard brake alarm(struct NET_ALARM_HARD_BRAKING)
    /// 急刹车报警(对应机构体NET_ALARM_HARD_BRAKING)
    /// </summary>
    ALARM_HARD_BRAKING = 0x212B,
    /// <summary>
    /// smoke sensor alarm(struct NET_ALARM_SMOKE_SENSOR)
    /// 烟感报警(对应结构体NET_ALARM_SMOKE_SENSOR)
    /// </summary>
    ALARM_SMOKE_SENSOR = 0x212C,
    /// <summary>
    /// traffic light fault alarm(struct NET_ALARM_TRAFFIC_LIGHT_FAULT) 
    /// 交通灯故障报警(对应结构体NET_ALARM_TRAFFIC_LIGHT_FAULT)
    /// </summary>
    ALARM_TRAFFIC_LIGHT_FAULT = 0x212D,
    /// <summary>
    /// traffic flux alarm(struct NET_ALARM_TRAFFIC_FLUX_LANE_INFO)
    /// 交通流量统计报警(对应结构体NET_ALARM_TRAFFIC_FLUX_LANE_INFO)
    /// </summary>
    ALARM_TRAFFIC_FLUX_STAT = 0x212E,
    /// <summary>
    /// camera move alarm(struct NET_ALARM_CAMERA_MOVE_INFO)
    /// 摄像机移位报警事件(对应结构体NET_ALARM_CAMERA_MOVE_INFO)
    /// </summary>
    ALARM_CAMERA_MOVE = 0x212F,
    /// <summary>
    /// detailed motion alarm(struct NET_ALARM_DETAILEDMOTION_CHNL_INFO)
    /// 详细动检报警上报信息(对应结构体NET_ALARM_DETAILEDMOTION_CHNL_INFO)
    /// </summary>
    ALARM_DETAILEDMOTION = 0x2130,
    /// <summary>
    /// storage failure alarm(struct NET_ALARM_STORAGE_FAILURE)
    /// 存储异常报警(对应结构体 NET_ALARM_STORAGE_FAILURE 数组)
    /// </summary>
    ALARM_STORAGE_FAILURE = 0x2131,
    /// <summary>
    /// front IPC disconnect alarm(struct NET_ALARM_FRONTDISCONNET_INFO)
    /// 前端IPC断网报警(对应结构体NET_ALARM_FRONTDISCONNET_INFO)
    /// </summary>
    ALARM_FRONTDISCONNECT = 0x2132,
    /// <summary>
    /// remote external alarm
    /// 远程外部报警(对应结构体 NET_ALARM_REMOTE_ALARM_INFO)
    /// </summary>
    ALARM_ALARM_EX_REMOTE = 0x2133,
    /// <summary>
    /// battery low power alarm(struct NET_ALARM_BATTERYLOWPOWER_INFO)
    /// 电池电量低报警(对应结构体NET_ALARM_BATTERYLOWPOWER_INFO)
    /// </summary>
    ALARM_BATTERYLOWPOWER = 0x2134,
    /// <summary>
    /// temperature alarm(struct NET_ALARM_TEMPERATURE_INFO)
    /// 温度过高报警(对应结构体 NET_ALARM_TEMPERATURE_INFO)
    /// </summary>
    ALARM_TEMPERATURE = 0x2135,
    /// <summary>
    /// tired drive alarm(struct NET_ALARM_TIREDDRIVE_INFO)
    /// 疲劳驾驶报警(对应结构体NET_ALARM_TIREDDRIVE_INFO)
    /// </summary>
    ALARM_TIREDDRIVE = 0x2136,
    /// <summary>
    /// Alarm of record loss (corresponding structure NET_ALARM_LOST_RECORD)
    /// 丢录像事件报警(对应结构体NET_ALARM_LOST_RECORD)
    /// </summary>
    ALARM_LOST_RECORD = 0x2137,
    /// <summary>
    /// Alarm of High CPU Occupancy rate (corresponding structure NET_ALARM_HIGH_CPU) 
    /// CPU占用率过高事件报警(对应结构体 NET_ALARM_HIGH_CPU)
    /// </summary>
    ALARM_HIGH_CPU = 0x2138,
    /// <summary>
    /// Alarm of net package loss (corresponding structure NET_ALARM_LOST_NETPACKET)
    /// 网络发送数据丢包事件报警(对应结构体 NET_ALARM_LOST_NETPACKET)
    /// </summary>
    ALARM_LOST_NETPACKET = 0x2139,
    /// <summary>
    /// Alarm of high memory occupancy rate(corresponding structure NET_ALARM_HIGH_MEMORY)
    /// 内存占用率过高事件报警(对应结构体NET_ALARM_HIGH_MEMORY)
    /// </summary>
    ALARM_HIGH_MEMORY = 0x213A,
    /// <summary>
    /// WEB user have no operation for long time (no extended info)
    /// WEB用户长时间无操作事件（无扩展信息）
    /// </summary>
    LONG_TIME_NO_OPERATION = 0x213B,
    /// <summary>
    /// blacklist snap(corresponding to NET_BLACKLIST_SNAP_INFO)  
    /// 黑名单车辆抓拍事件(对应结构体NET_BLACKLIST_SNAP_INFO)  
    /// </summary>
    BLACKLIST_SNAP = 0x213C,
    /// <summary>
    /// alarm of disk(corresponding to NET_ALARM_DISK_INFO)
    /// 硬盘报警(对应 NET_ALARM_DISK_INFO 数组)
    /// </summary>
    ALARM_DISK = 0x213E,
    /// <summary>
    /// alarm of file systemcorresponding to NET_ALARM_FILE_SYSTEM_INFO)
    /// 文件系统报警(对应NET_ALARM_FILE_SYSTEM_INFO数组)
    /// </summary>
    ALARM_FILE_SYSTEM = 0x213F,
    /// <summary>
    /// alarm of ivs(corresponding to NET_ALARM_IVS_INFO)
    /// 智能报警事件(对应结构体NET_ALARM_IVS_INFO)
    /// </summary>
    ALARM_IVS = 0x2140,
    /// <summary>
    /// goods weight (corresponding to NET_ALARM_GOODS_WEIGHT_UPLOAD_INFO)
    /// 货重信息上报(对应NET_ALARM_GOODS_WEIGHT_UPLOAD_INFO)
    /// </summary>
    ALARM_GOODS_WEIGHT_UPLOAD = 0x2141,
    /// <summary>
    /// alarm of goods weight(corresponding to NET_ALARM_GOODS_WEIGHT_INFO)
    /// 货重信息报警(对应NET_ALARM_GOODS_WEIGHT_INFO)
    /// </summary>
    ALARM_GOODS_WEIGHT = 0x2142,
    /// <summary>
    /// GPS orientation info(corresponding to NET_GPS_STATUS_INFO)
    /// GPS定位信息(对应 NET_GPS_STATUS_INFO)
    /// </summary>
    GPS_STATUS = 0x2143,
    /// <summary>
    /// alarm disk burned full(corresponding to NET_ALARM_DISKBURNED_FULL_INFO)
    /// 硬盘刻录满报警(对应 NET_ALARM_DISKBURNED_FULL_INFO)
    /// </summary>
    ALARM_DISKBURNED_FULL = 0x2144,
    /// <summary>
    /// storage low space(corresponding to NET_ALARM_STORAGE_LOW_SPACE_INFO)
    /// 存储容量不足事件(对应NET_ALARM_STORAGE_LOW_SPACE_INFO)
    /// </summary>
    ALARM_STORAGE_LOW_SPACE = 0x2145,
    /// <summary>
    /// disk flux abnormal(corresponding to NET_ALARM_DISK_FLUX)
    /// 硬盘数据异常事件(对应 NET_ALARM_DISK_FLUX)
    /// </summary>
    ALARM_DISK_FLUX = 0x2160,
    /// <summary>
    /// net flux abnormal(corresponding to NET_ALARM_NET_FLUX)
    /// 网络数据异常事件(对应 NET_ALARM_NET_FLUX)
    /// </summary>
    ALARM_NET_FLUX = 0x2161,
    /// <summary>
    /// fan speed abnormal(corresponding to NET_ALARM_FAN_SPEED)
    /// 风扇转速异常事件(对应 NET_ALARM_FAN_SPEED)
    /// </summary>
    ALARM_FAN_SPEED = 0x2162,
    /// <summary>
    /// storage mistake(corresponding to NET_ALARM_STORAGE_FAILURE_EX)
    /// 存储错误报警(对应结构体NET_ALARM_STORAGE_FAILURE_EX)
    /// </summary>
    ALARM_STORAGE_FAILURE_EX = 0x2163,
    /// <summary>
    /// record abnormal(corresponding to NET_ALARM_RECORD_FAILED_INFO)
    /// 录像异常报警(对应结构体NET_ALARM_RECORD_FAILED_INFO)
    /// </summary>
    ALARM_RECORD_FAILED = 0x2164,
    /// <summary>
    /// storage break down(corresponding to NET_ALARM_STORAGE_BREAK_DOWN_INFO)
    /// 存储崩溃事件(对应结构体 NET_ALARM_STORAGE_BREAK_DOWN_INFO)
    /// </summary>
    ALARM_STORAGE_BREAK_DOWN = 0x2165,
    /// <summary>
    /// NET_ALARM_VIDEO_ININVALID_INFO
    /// 视频输入通道失效事件（例：配置的视频输入通道码流,超出设备处理能力）NET_ALARM_VIDEO_ININVALID_INFO
    /// </summary>
    ALARM_VIDEO_ININVALID = 0x2166,
    /// <summary>
    /// vehicle turnover arm event(struct NET_ALARM_VEHICEL_TURNOVER_EVENT_INFO)
    /// 车辆侧翻报警事件(对应结构体NET_ALARM_VEHICEL_TURNOVER_EVENT_INFO)
    /// </summary>
    ALARM_VEHICLE_TURNOVER = 0x2167,
    /// <summary>
    /// vehicle collision event(struct NET_ALARM_VEHICEL_COLLISION_EVENT_INFO)
    /// 车辆撞车报警事件(对应结构体NET_ALARM_VEHICEL_COLLISION_EVENT_INFO)
    /// </summary>
    ALARM_VEHICLE_COLLISION = 0x2168,
    /// <summary>
    /// vehicle confirm information event(struct NET_ALARM_VEHICEL_CONFIRM_INFO)
    /// 车辆上传信息事件(对应结构体NET_ALARM_VEHICEL_CONFIRM_INFO)
    /// </summary>
    ALARM_VEHICLE_CONFIRM = 0x2169,
    /// <summary>
    /// vehicle camero large angle event(struct NET_ALARM_VEHICEL_LARGE_ANGLE)
    /// 车载摄像头大角度扭转事件(对应结构体NET_ALARM_VEHICEL_LARGE_ANGLE)
    /// </summary>
    ALARM_VEHICLE_LARGE_ANGLE = 0x2170,
    /// <summary>
    /// device talking invite event (struct NET_ALARM_TALKING_INVITE_INFO)
    /// 设备请求对方发起对讲事件(对应结构体NET_ALARM_TALKING_INVITE_INFO)
    /// </summary>
    ALARM_TALKING_INVITE = 0x2171,
    /// <summary>
    /// local alarm event (struct NET_ALARM_ALARM_INFO_EX2)
    /// 本地报警事件(对应结构体 NET_ALARM_ALARM_INFO_EX2)
    /// </summary>
    ALARM_ALARM_EX2 = 0x2175,
    /// <summary>
    /// video timing detecting event(struct NET_ALARM_VIDEO_TIMING)
    /// 视频定时检测事件(对应结构体NET_ALARM_VIDEO_TIMING)
    /// </summary>
    ALARM_VIDEO_TIMING = 0x2176,
    /// <summary>
    /// COM event(struct NET_ALARM_COMM_PORT_EVENT_INFO)
    /// 串口事件(对应结构体NET_ALARM_COMM_PORT_EVENT_INFO)
    /// </summary>
    ALARM_COMM_PORT = 0x2177,
    /// <summary>
    /// audio anomaly event(struct NET_ALARM_AUDIO_ANOMALY)
    /// 音频异常事件(对应结构体NET_ALARM_AUDIO_ANOMALY)
    /// </summary>
    ALARM_AUDIO_ANOMALY = 0x2178,
    /// <summary>
    /// audio mutation event(struct NET_ALARM_AUDIO_MUTATION)
    /// 声强突变事件(对应结构体NET_ALARM_AUDIO_MUTATION)
    /// </summary>
    ALARM_AUDIO_MUTATION = 0x2179,
    /// <summary>
    /// Tyre information report event (struct NET_EVENT_TYRE_INFO)
    /// 轮胎信息上报事件(对应结构体NET_EVENT_TYRE_INFO)
    /// </summary>
    EVENT_TYREINFO = 0x2180,
    /// <summary>
    /// Redundant power supplies abnormal alarm(struct NET_ALARM_POWER_ABNORMAL_INFO)
    /// 冗余电源异常报警(对应结构体NET_ALARM_POWER_ABNORMAL_INFO)
    /// </summary>
    ALARM_POWER_ABNORMAL = 0X2181,
    /// <summary>
    /// On-board equipment active offline events(struct  NET_EVENT_REGISTER_OFF_INFO)
    /// 车载设备主动下线事件(对应结构体 NET_EVENT_REGISTER_OFF_INFO)
    /// </summary>
    EVENT_REGISTER_OFF = 0x2182,
    /// <summary>
    /// No hard disk alarm(struct NET_ALARM_NO_DISK_INFO)
    /// 无硬盘报警(对应结构体NET_ALARM_NO_DISK_INFO)
    /// </summary>
    ALARM_NO_DISK = 0x2183,
    /// <summary>
    /// The fall alarm(struct NET_ALARM_FALLING_INFO)
    /// 跌落事件报警(对应结构体NET_ALARM_FALLING_INFO)
    /// </summary>
    ALARM_FALLING = 0x2184,
    /// <summary>
    /// Protective capsule event(corresponding structure NET_ALARM_PROTECTIVE_CAPSULE_INFO)
    /// 防护舱事件(对应结构体NET_ALARM_PROTECTIVE_CAPSULE_INFO)
    /// </summary>
    ALARM_PROTECTIVE_CAPSULE = 0x2185,
    /// <summary>
    /// Call Non-response alarm(corresponding to NET_ALARM_NO_RESPONSE_INFO)
    /// 呼叫未应答警报(对应结构体NET_ALARM_NO_RESPONSE_INFO)
    /// </summary>
    ALARM_NO_RESPONSE = 0x2186,
    /// <summary>
    /// Config enable to change reported event(corresponding to structure  NET_ALARM_CONFIG_ENABLE_CHANGE_INFO)
    /// 配置使能改变上报事件(对应结构体 NET_ALARM_CONFIG_ENABLE_CHANGE_INFO)
    /// </summary>
    ALARM_CONFIG_ENABLE_CHANGE = 0x2187,
    /// <summary>
    /// Cross warning line event( Corresponding to structure NET_ALARM_EVENT_CROSSLINE_INFO )
    /// 警戒线事件( 对应结构体 NET_ALARM_EVENT_CROSSLINE_INFO )
    /// </summary>
    EVENT_CROSSLINE_DETECTION = 0x2188,
    /// <summary>
    /// Warning zone event(Corresponding to structure NET_ALARM_EVENT_CROSSREGION_INFO )
    /// 警戒区事件( 对应结构体 NET_ALARM_EVENT_CROSSREGION_INFO )
    /// </summary>
    EVENT_CROSSREGION_DETECTION = 0x2189,
    /// <summary>
    /// Abandoned object event(Corresponding to structure NET_ALARM_EVENT_LEFT_INFO )
    /// 物品遗留事件( 对应结构体 NET_ALARM_EVENT_LEFT_INFO )
    /// </summary>
    EVENT_LEFT_DETECTION = 0x218a,
    /// <summary>
    /// Human face detect event(Corresponding to structure NET_ALARM_EVENT_FACE_INFO ) 
    /// 人脸检测事件( 对应结构体 NET_ALARM_EVENT_FACE_INFO )
    /// </summary>
    EVENT_FACE_DETECTION = 0x218b,
    /// <summary>
    /// IPC alarm,IPC upload local alarm via DVR or NVR(Corresponding to structure NET_ALARM_IPC_INFO)
    /// IPC报警,IPC通过DVR或NVR上报的本地报警(对应结构体 NET_ALARM_IPC_INFO)
    /// </summary>
    ALARM_IPC = 0x218c,
    /// <summary>
    /// Missing object event(Corresponding to structure NET_ALARM_TAKENAWAY_DETECTION_INFO)
    /// 物品搬移事件(对应结构体 NET_ALARM_TAKENAWAY_DETECTION_INFO)
    /// </summary>
    EVENT_TAKENAWAYDETECTION = 0x218d,
    /// <summary>
    /// Video abnormal event(Corresponding to structure NET_ALARM_VIDEOABNORMAL_DETECTION_INFO)
    /// 视频异常事件(对应结构体 NET_ALARM_VIDEOABNORMAL_DETECTION_INFO)
    /// </summary>
    EVENT_VIDEOABNORMALDETECTION = 0x218e,
    /// <summary>
    /// Video motion detect event  (Corresponding to structure NET_ALARM_MOTIONDETECT_INFO)
    /// 视频移动侦测事件(对应结构体 NET_ALARM_MOTIONDETECT_INFO)
    /// </summary>
    EVENT_MOTIONDETECT = 0x218f,
    /// <summary>
    /// PIR alarm (Corresponding to BYTE*, pBuf length dwBufLen)
    /// PIR警报(对应BYTE*, pBuf长度dwBufLen)
    /// </summary>
    ALARM_PIR = 0x2190,
    /// <summary>
    /// Storage hot swap event(Corresponding to structure NET_ALARM_STORAGE_HOT_PLUG_INFO)
    /// 存储热插拔事件(对应结构体 NET_ALARM_STORAGE_HOT_PLUG_INFO)
    /// </summary>
    ALARM_STORAGE_HOT_PLUG = 0x2191,
    /// <summary>
    /// the event of rate of flow(Corresponding to structure NET_ALARM_FLOW_RATE_INFO)
    /// 流量使用情况事件(对应结构体 NET_ALARM_FLOW_RATE_INFO)
    /// </summary>
    ALARM_FLOW_RATE = 0x2192,
    /// <summary>
    /// Move detection event(Corresponding to structure NET_ALARM_MOVE_DETECTION_INFO)
    /// 移动事件(对应NET_ALARM_MOVE_DETECTION_INFO)
    /// </summary>
    ALARM_MOVEDETECTION = 0x2193,
    /// <summary>
    /// WanderDetection event(Corresponding to structure NET_ALARM_WANDERDETECTION_INFO)
    /// 徘徊事件(对应NET_ALARM_WANDERDETECTION_INFO)
    /// </summary>
    ALARM_WANDERDETECTION = 0x2194,
    /// <summary>
    /// cross fence(Corresponding to NET_ALARM_CROSSFENCEDETECTION_INFO)
    /// 翻越围栏事件(对应NET_ALARM_CROSSFENCEDETECTION_INFO)
    /// </summary>
    ALARM_CROSSFENCEDETECTION = 0x2195,
    /// <summary>
    /// parking detection event(Corresponding to NET_ALARM_PARKINGDETECTION_INFO)
    /// 非法停车事件(对应NET_ALARM_PARKINGDETECTION_INFO)
    /// </summary>
    ALARM_PARKINGDETECTION = 0x2196,
    /// <summary>
    /// Rioter detection event(Corresponding to NET_ALARM_RIOTERDETECTION_INFO)
    /// 人员聚集事件(对应NET_ALARM_RIOTERDETECTION_INFO)
    /// </summary>
    ALARM_RIOTERDETECTION = 0x2197,
    /// <summary>
    /// A storage group does not exist(struct NET_ALARM_STORAGE_NOT_EXIST_INFO)
    /// 存储组不存在事件(对应结构体 NET_ALARM_STORAGE_NOT_EXIST_INFO)
    /// </summary>
    ALARM_STORAGE_NOT_EXIST = 0x3167,
    /// <summary>
    /// Network fault event(struct NET_ALARM_NETABORT_INFO)
    /// 网络故障事件(对应结构体 NET_ALARM_NETABORT_INFO)
    /// </summary>
    ALARM_NET_ABORT = 0x3169,
    /// <summary>
    /// IP conflict event(struct NET_ALARM_IP_CONFLICT_INFO)
    /// IP冲突事件(对应结构体 NET_ALARM_IP_CONFLICT_INFO)
    /// </summary>
    ALARM_IP_CONFLICT = 0x3170,
    /// <summary>
    /// MAC conflict event(struct NET_ALARM_MAC_CONFLICT_INFO)
    /// MAC冲突事件(对应结构体 NET_ALARM_MAC_CONFLICT_INFO)
    /// </summary>
    ALARM_MAC_CONFLICT = 0x3171,
    /// <summary>
    /// power fault event(struct NET_ALARM_POWERFAULT_INFO)
    /// 电源故障事件(对应结构体NET_ALARM_POWERFAULT_INFO)
    /// </summary>
    ALARM_POWERFAULT = 0x3172,
    /// <summary>
    /// Chassis intrusion, tamper alarm events(struct NET_ALARM_CHASSISINTRUDED_INFO)
    /// 机箱入侵(防拆)报警事件(对应结构体NET_ALARM_CHASSISINTRUDED_INFO)
    /// </summary>
    ALARM_CHASSISINTRUDED = 0x3173,
    /// <summary>
    /// Native extension alarm events(struct NET_ALARM_ALARMEXTENDED_INFO)
    /// 本地扩展报警事件(对应结构体 NET_ALARM_ALARMEXTENDED_INFO)
    /// </summary>
    ALARM_ALARMEXTENDED = 0x3174,
    /// <summary>
    /// Cloth removal state change events(struct NET_ALARM_ARMMODE_CHANGE_INFO)
    /// 布撤防状态变化事件(对应结构体NET_ALARM_ARMMODE_CHANGE_INFO)
    /// </summary>
    ALARM_ARMMODE_CHANGE_EVENT = 0x3175,
    /// <summary>
    /// The bypass state change events(struct NET_ALARM_BYPASSMODE_CHANGE_INFO)
    /// 旁路状态变化事件(对应结构体NET_ALARM_BYPASSMODE_CHANGE_INFO)
    /// </summary>
    ALARM_BYPASSMODE_CHANGE_EVENT = 0x3176,
    /// <summary>
    /// Entrance guard did not close events(struct NET_ALARM_ACCESS_CTL_NOT_CLOSE_INFO)
    /// 门禁未关事件(对应结构体NET_ALARM_ACCESS_CTL_NOT_CLOSE_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_NOT_CLOSE = 0x3177,
    /// <summary>
    /// break-in event(struct NET_ALARM_ACCESS_CTL_BREAK_IN_INFO)
    /// 闯入事件(对应结构体NET_ALARM_ACCESS_CTL_BREAK_IN_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_BREAK_IN = 0x3178,
    /// <summary>
    /// access Again and again event(struct NET_ALARM_ACCESS_CTL_REPEAT_ENTER_INFO)
    /// 反复进入事件(对应结构体NET_ALARM_ACCESS_CTL_REPEAT_ENTER_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_REPEAT_ENTER = 0x3179,
    /// <summary>
    /// Stress CARDS event(struct NET_ALARM_ACCESS_CTL_DURESS_INFO)
    /// 胁迫卡刷卡事件(对应结构体NET_ALARM_ACCESS_CTL_DURESS_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_DURESS = 0x3180,
    /// <summary>
    /// Access event(struct NET_ALARM_ACCESS_CTL_EVENT_INFO)
    /// 门禁事件(对应结构体 NET_ALARM_ACCESS_CTL_EVENT_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_EVENT = 0x3181,
    /// <summary>
    /// Emergency ALARM EX2(struct NET_ALARM_URGENCY_ALARM_EX2), Artificially triggered emergency, general processing is linked external communication function requests for help
    /// 紧急报警EX2(对应结构体NET_ALARM_URGENCY_ALARM_EX2), 人为触发的紧急事件, 一般处理是联动外部通讯功能请求帮助
    /// </summary>
    URGENCY_ALARM_EX2 = 0x3182,
    /// <summary>
    /// Alarm input source signal events (as long as there is input will generate the event, whether to play the current mode, unable to block, struct NET_ALARM_INPUT_SOURCE_SIGNAL_INFO)
    /// 报警输入源信号事件(只要有输入就会产生该事件, 不论防区当前的模式,无法屏蔽, 对应 NET_ALARM_INPUT_SOURCE_SIGNAL_INFO )
    /// </summary>
    ALARM_INPUT_SOURCE_SIGNAL = 0x3183,
    /// <summary>
    /// analog alarm(struct NET_ALARM_ANALOGALARM_EVENT_INFO)
    /// 模拟量报警输入通道事件(对应结构体NET_ALARM_ANALOGALARM_EVENT_INFO)
    /// </summary>
    ALARM_ANALOGALARM_EVENT = 0x3184,
    /// <summary>
    /// Access control status event(corresponding structure NET_ALARM_ACCESS_CTL_STATUS_INFO)
    /// 门禁状态事件(对应结构体NET_ALARM_ACCESS_CTL_STATUS_INFO)
    /// </summary>
    ALARM_ACCESS_CTL_STATUS = 0x3185,
    /// <summary>
    /// Access control snapshot event(corresponding to NET_ALARM_ACCESS_SNAP_INFO)
    /// 门禁抓图事件(对应结构体NET_ALARM_ACCESS_SNAP_INFO)
    /// </summary>
    ALARM_ACCESS_SNAP = 0x3186,
    /// <summary>
    /// Cancel alarm(corresponding to structure NET_ALARM_ALARMCLEAR_INFO)
    /// 消警事件(对应结构体NET_ALARM_ALARMCLEAR_INFO)
    /// </summary>
    ALARM_ALARMCLEAR = 0x3187,
    /// <summary>
    /// CID event(corresponding to structure NET_ALARM_CIDEVENT_INFO)
    /// CID事件(对应结构体 NET_ALARM_CIDEVENT_INFO)
    /// </summary>
    ALARM_CIDEVENT = 0x3188,
    /// <summary>
    /// Device hand up evnt(corresponding to structure NET_ALARM_TALKING_HANGUP_INFO)
    /// 设备主动挂断对讲事件(对应结构体NET_ALARM_TALKING_HANGUP_INFO)
    /// </summary>
    ALARM_TALKING_HANGUP = 0x3189,
    /// <summary>
    /// Bank card evnt(corresponding to structure NET_ALARM_BANKCARDINSERT_INFO)
    /// 银行卡插卡事件(对应结构体NET_ALARM_BANKCARDINSERT_INFO)
    /// </summary>
    ALARM_BANKCARDINSERT = 0x318a,
    /// <summary>
    /// Emergency call alarm event(corresponding to structure NET_ALARM_RCEMERGENCY_CALL_INFO)
    /// 紧急呼叫报警事件(对应结构体 NET_ALARM_RCEMERGENCY_CALL_INFO)
    /// </summary>
    ALARM_RCEMERGENCY_CALL = 0x318b,
    /// <summary>
    /// Multi-people group unlock event(corresponding to  structure NET_ALARM_OPEN_DOOR_GROUP_INFO)
    /// 多人组合开门事件(对应结构体NET_ALARM_OPEN_DOOR_GROUP_INFO)
    /// </summary>
    ALARM_OPENDOORGROUP = 0x318c,
    /// <summary>
    /// get fingerprint event(corresponding to  structure NET_ALARM_CAPTURE_FINGER_PRINT_INFO)
    /// 获取指纹事件(对应结构体NET_ALARM_CAPTURE_FINGER_PRINT_INFO)
    /// </summary>
    ALARM_FINGER_PRINT = 0x318d,
    /// <summary>
    /// card no. record event(corresponding to  structure  NET_ALARM_CARD_RECORD_INFO)
    /// 卡号录像事件(对应结构体 NET_ALARM_CARD_RECORD_INFO)
    /// </summary>
    ALARM_CARD_RECORD = 0x318e,
    /// <summary>
    /// sub system status change event(corresponding to  structure NET_ALARM_SUBSYSTEM_STATE_CHANGE_INFO)
    /// 子系统状态改变事件(对应结构体NET_ALARM_SUBSYSTEM_STATE_CHANGE_INFO)
    /// </summary>
    ALARM_SUBSYSTEM_STATE_CHANGE = 0x318f,
    /// <summary>
    /// battery scheduled warning event(corresponding to  structure NET_ALARM_BATTERYPOWER_INFO)
    /// 电池电量定时通知事件(对应结构体NET_ALARM_BATTERYPOWER_INFO)
    /// </summary>
    ALARM_BATTERYPOWER_EVENT = 0x3190,
    /// <summary>
    /// bell status event(corresponding to  structure NET_ALARM_BELLSTATUS_INFO)
    /// 警号状态事件(对应结构体NET_ALARM_BELLSTATUS_INFO)
    /// </summary>
    ALARM_BELLSTATUS_EVENT = 0x3191,
    /// <summary>
    /// zone status change event(corresponding to  structure NET_ALARM_DEFENCE_STATUS_CHANGE_INFO),customized need￡?and arm/disarm change event, bypass event status have different definitions,The status CLIENT_QueryDevState function NET_DEVSTATE_DEFENCE_STATE command get
    /// 防区状态变化事件(对应结构体ALARM_DEFENCE_STATUS_CHANGE_INFO),定制需求,和布防撤防变化事件、旁路状态变化事件中的状态定义不同,该状态通过CLIENT_QueryDevState()接口的NET_DEVSTATE_DEFENCE_STATE命令获取
    /// </summary>
    ALARM_DEFENCE_STATE_CHANGE_EVENT = 0x3192,
    /// <summary>
    /// ticket statistics info event(corresponding to  structure  NET_ALARM_TICKET_STATISTIC)
    /// 车票统计信息事件(对应结构体 NET_ALARM_TICKET_STATISTIC)
    /// </summary>
    ALARM_TICKET_STATISTIC = 0x3193,
    /// <summary>
    /// login failed event(corresponding to  structure NET_ALARM_LOGIN_FAILIUR_INFO)
    /// 登陆失败事件(对应结构体NET_ALARM_LOGIN_FAILIUR_INFO)
    /// </summary>
    ALARM_LOGIN_FAILIUR = 0x3194,
    /// <summary>
    /// expansion module offline event(corresponding to  structure  NET_ALARM_MODULE_LOST_INFO)
    /// 扩展模块掉线事件(对应结构体 NET_ALARM_MODULE_LOST_INFO)
    /// </summary>
    ALARM_MODULE_LOST = 0x3195,
    /// <summary>
    /// PSTN offline event(corresponding to  structure NET_ALARM_PSTN_BREAK_LINE_INFO)
    /// PSTN掉线事件(对应结构体NET_ALARM_PSTN_BREAK_LINE_INFO)
    /// </summary>
    ALARM_PSTN_BREAK_LINE = 0x3196,
    /// <summary>
    /// analog alarm evnet(instant event), specific sensor  trigger(corresponding to  structure NET_ALARM_ANALOGPULSE_INFO)
    /// 模拟量报警事件(瞬时型事件), 特定传感器类型时才触发(对应结构体NET_ALARM_ANALOGPULSE_INFO)
    /// </summary>
    ALARM_ANALOG_PULSE = 0x3197,
    /// <summary>
    /// task confirmation event(corresponding to  structure  NET_ALARM_MISSION_CONFIRM_INFO)
    /// 任务确认事件(对应结构体 任务确认事件(对应结构体 NET_ALARM_MISSION_CONFIRM_INFO))
    /// </summary>
    ALARM_MISSION_CONFIRM = 0x3198,
    /// <summary>
    /// device to platform notice event?t(corresponding to  structure  NET_ALARM_DEVICE_MSG_NOTIFY_INFO)
    /// 设备向平台发通知的事件(对应结构体 NET_ALARM_DEVICE_MSG_NOTIFY_INFO)
    /// </summary>
    ALARM_DEVICE_MSG_NOTIFY = 0x3199,
    /// <summary>
    /// parking timeout event(corresponding to  structure  NET_ALARM_VEHICLE_STANDING_OVER_TIME_INFO)
    /// 停车超时报警(对应结构体 NET_ALARM_VEHICLE_STANDING_OVER_TIME_INFO)
    /// </summary>
    ALARM_VEHICLE_STANDING_OVER_TIME = 0x319A,
    /// <summary>
    /// e-fence event(corresponding to  structure  NET_ALARM_ENCLOSURE_ALARM_INFO)
    /// 电子围栏事件(对应结构体 NET_ALARM_ENCLOSURE_ALARM_INFO)
    /// </summary>
    ALARM_ENCLOSURE_ALARM = 0x319B,
    /// <summary>
    /// station detection event, one in station first report the start event and last on in station report stop event before leave (corresponding to  structure NET_ALARM_GUARD_DETECT_INFO)
    /// 岗亭检测事件,此事件岗亭有第一个人时上报start事件,岗亭最后一个人离开时上报stop 事件(对应结构体NET_ALARM_GUARD_DETECT_INFO)
    /// </summary>
    ALARM_GUARD_DETECT = 0x319C,
    /// <summary>
    /// station info update event￡?report if people in station(corresponding to  structure NET_ALARM_GUARD_UPDATE_INFO)
    /// 岗亭信息更新事件,只要岗亭有人员出入就上报(对应结构体NET_ALARM_GUARD_UPDATE_INFO)  
    /// </summary>
    ALARM_GUARD_INFO_UPDATE = 0x319D,
    /// <summary>
    /// Node activation event (corresponding to structure NET_ALARM_NODE_ACTIVE_INFO)
    /// 节点激活事件(对应结构体NET_ALARM_NODE_ACTIVE_INFO)
    /// </summary>
    ALARM_NODE_ACTIVE = 0x319E,
    /// <summary>
    /// Video static detection event (corresponding to structure NET_ALARM_VIDEO_STATIC_INFO)
    /// 视频静态检测事件(对应结构体 NET_ALARM_VIDEO_STATIC_INFO)
    /// </summary>
    ALARM_VIDEO_STATIC = 0x319F,
    /// <summary>
    /// Active registration device re-login event (corresponding to structure NET_ALARM_REGISTER_REONLINE_INFO)
    /// 主动注册设备重新登陆事件(对应结构体NET_ALARM_REGISTER_REONLINE_INFO)
    /// </summary>
    ALARM_REGISTER_REONLINE = 0x31a0,
    /// <summary>
    /// ISCSI alarm event (corresponding to structure NET_ALARM_ISCSI_STATUS_INFO)
    /// ISCSI告警事件(对应结构体 NET_ALARM_ISCSI_STATUS_INFO)
    /// </summary>
    ALARM_ISCSI_STATUS = 0x31a1,
    /// <summary>
    /// detection collection device alarm event (corresponding to structure NET_ALARM_SCADA_DEV_INFO)
    /// 检测采集设备报警事件(对应结构体 NET_ALARM_SCADA_DEV_INFO)
    /// </summary>
    ALARM_SCADA_DEV_ALARM = 0x31a2,
    /// <summary>
    /// Sub device status(corresponding structure NET_ALARM_AUXILIARY_DEV_STATE)
    /// 辅助设备状态(对应结构体NET_ALARM_AUXILIARY_DEV_STATE)
    /// </summary>
    ALARM_AUXILIARY_DEV_STATE = 0x31a3,
    /// <summary>
    /// Parking swipe card event(corresponding structure NET_ALARM_PARKING_CARD)
    /// 停车刷卡事件(对应结构体NET_ALARM_PARKING_CARD)
    /// </summary>
    ALARM_PARKING_CARD = 0x31a4,
    /// <summary>
    /// Alarm transmit event(corresponding structure NET_ALARM_PROFILE_ALARM_TRANSMIT_INFO)
    /// 报警传输事件(对应结构体NET_ALARM_PROFILE_ALARM_TRANSMIT_INFO)
    /// </summary>
    ALARM_PROFILE_ALARM_TRANSMIT = 0x31a5,
    /// <summary>
    /// Vehicle acc event(corresponding structure NET_ALARM_VEHICLE_ACC_INFO)
    /// 车辆ACC报警事件(对应结构体 NET_ALARM_VEHICLE_ACC_INFO)
    /// </summary>
    ALARM_VEHICLE_ACC = 0x31a6,
    /// <summary>
    /// suspiciouscar event(corresponding structure NET_ALARM_TRAFFIC_SUSPICIOUSCAR_INFO)
    /// 嫌疑车辆上报事件(对应结构体 NET_ALARM_TRAFFIC_SUSPICIOUSCAR_INFO)
    /// </summary>
    ALARM_TRAFFIC_SUSPICIOUSCAR = 0x31a7,
    /// <summary>
    /// the event of latch state (corresponding structure  NET_ALARM_ACCESS_LOCK_STATUS_INFO)
    /// 门锁状态事件(对应结构体 NET_ALARM_ACCESS_LOCK_STATUS_INFO)
    /// </summary>
    ALARM_ACCESS_LOCK_STATUS = 0x31a8,
    /// <summary>
    /// Finace scheme event(corresponding structure NET_ALARM_FINACE_SCHEME_INFO)
    /// 理财经办事件(对应结构体 NET_ALARM_FINACE_SCHEME_INFO)
    /// </summary>
    ALARM_FINACE_SCHEME = 0x31a9,
    /// <summary>
    /// Thermal temperature abnormal event alarm(Corresponding to structure NET_ALARM_HEATIMG_TEMPER_INFO)
    /// 热成像测温点温度异常报警事件(对应结构体 NET_ALARM_HEATIMG_TEMPER_INFO)
    /// </summary>
    ALARM_HEATIMG_TEMPER = 0x31aa,
    /// <summary>
    /// Device cancel bidirectional talk query event(Corresponding to structure NET_ALARM_TALKING_IGNORE_INVITE_INFO)
    /// 设备取消对讲请求事件(对应结构体NET_ALARM_TALKING_IGNORE_INVITE_INFO)
    /// </summary>
    ALARM_TALKING_IGNORE_INVITE = 0x31ab,
    /// <summary>
    /// Vehicle Abrupt-turn event(Corresponding to structure NET_ALARM_BUS_SHARP_TURN_INFO)
    /// 车辆急转事件(对应结构体NET_ALARM_BUS_SHARP_TURN_INFO)
    /// </summary>
    ALARM_BUS_SHARP_TURN = 0x31ac,
    /// <summary>
    /// vehicle abrupt stop event(Corresponding to structure NET_ALARM_BUS_SCRAM_INFO)
    /// 车辆急停事件(对应结构体NET_ALARM_BUS_SCRAM_INFO)
    /// </summary>
    ALARM_BUS_SCRAM = 0x31ad,
    /// <summary>
    /// Vehicle abrupt speed up event(Corresponding to structure NET_ALARM_BUS_SHARP_ACCELERATE_INFO)
    /// 车辆急加速事件(对应结构体NET_ALARM_BUS_SHARP_ACCELERATE_INFO)
    /// </summary>
    ALARM_BUS_SHARP_ACCELERATE = 0x31ae,
    /// <summary>
    /// Vehicle abrupt slow down event (Corresponding to structure NET_ALARM_BUS_SHARP_DECELERATE_INFO)
    /// 车辆急减速事件(对应结构体NET_ALARM_BUS_SHARP_DECELERATE_INFO)
    /// </summary>
    ALARM_BUS_SHARP_DECELERATE = 0x31af,
    /// <summary>
    /// A&C data operation event (Corresponding to structure NET_ALARM_ACCESS_CARD_OPERATE_INFO)
    /// 门禁卡数据操作事件(对应结构体NET_ALARM_ACCESS_CARD_OPERATE_INFO)
    /// </summary>
    ALARM_ACCESS_CARD_OPERATE = 0x31b0,
    /// <summary>
    /// Policeman check in event(Corresponding to structure NET_ALARM_POLICE_CHECK_INFO)
    /// 警员签到事件(对应结构体NET_ALARM_POLICE_CHECK_INFO)
    /// </summary>
    ALARM_POLICE_CHECK = 0x31b1,
    /// <summary>
    /// Network alarm event(Corresponding to structure NET_ALARM_NET_INFO)
    /// 网络报警事件(对应结构体 NET_ALARM_NET_INFO)
    /// </summary>
    ALARM_NET = 0x31b2,
    /// <summary>
    /// New file event(Corresponding to structure NET_ALARM_NEW_FILE_INFO)
    /// 新文件事件(对应结构体NET_ALARM_NEW_FILE_INFO)
    /// </summary>
    ALARM_NEW_FILE = 0x31b3,
    /// <summary>
    /// Thermal fire position (Corresponding to structure NET_ALARM_FIREWARNING_INFO)
    /// 热成像着火点事件 (对应结构体 NET_ALARM_FIREWARNING_INFO)
    /// </summary>
    ALARM_FIREWARNING = 0x31b5,
    /// <summary>
    /// Record loss event: the HDD is OK, delete results from misoperation.  (Corresponding to structure NET_ALARM_RECORD_LOSS_INFO)
    /// 录像丢失事件,指硬盘完好的情况下,发生误删等原因引起(对应结构体NET_ALARM_RECORD_LOSS_INFO)
    /// </summary>
    ALARM_RECORD_LOSS = 0x31b6,
    /// <summary>
    /// Frame loss event，it results from poor network environment or insufficient encode capability (Corresponding to structure NET_ALARM_VIDEO_FRAME_LOSS_INFO)
    /// 视频丢帧事件,比如网络不好或编码能力不足引起的丢帧(对应结构体NET_ALARM_VIDEO_FRAME_LOSS_INFO)
    /// </summary>
    ALARM_VIDEO_FRAME_LOSS = 0x31b7,
    /// <summary>
    /// Abnormal record results from HDD volume(Corresponding to structure NET_ALARM_RECORD_VOLUME_FAILURE_INFO)
    /// 由保存录像的磁盘卷发生异常,引起的录像异常(对应结构体 NET_ALARM_RECORD_VOLUME_FAILURE_INFO)
    /// </summary>
    ALARM_RECORD_VOLUME_FAILURE = 0x31b8,
    /// <summary>
    /// Image upload completion event(Corresponding to structure NET_EVENT_SNAP_UPLOAD_INFO)
    /// 图上传完成事件(对应结构体NET_EVENT_SNAP_UPLOAD_INFO)
    /// </summary>
    EVENT_SNAP_UPLOAD = 0X31b9,
    /// <summary>
    /// Audio detect event(Corresponding to structure NET_ALARM_AUDIO_DETECT )
    /// 音频检测事件(对应结构体 NET_ALARM_AUDIO_DETECT )
    /// </summary>
    ALARM_AUDIO_DETECT = 0x31ba,
    /// <summary>
    /// Failure data amount during the image upload process （Corresponding to structure NET_ALARM_UPLOADPIC_FAILCOUNT_INFO）
    /// 上传中盟失败数据个数（对应结构体NET_ALARM_UPLOADPIC_FAILCOUNT_INFO）
    /// </summary>
    ALARM_UPLOADPIC_FAILCOUNT = 0x31bb,
    /// <summary>
    /// POS management event(Corresponding to NET_ALARM_POS_MANAGE_INFO )
    /// POS管理事件事件(对应结构体 NET_ALARM_POS_MANAGE_INFO )
    /// </summary>
    ALARM_POS_MANAGE = 0x31bc,
    /// <summary>
    /// remote control status(Corresponding to NET_ALARM_REMOTE_CTRL_STATUS )
    /// 无线遥控器状态事件(对应结构体 NET_ALARM_REMOTE_CTRL_STATUS )
    /// </summary>
    ALARM_REMOTE_CTRL_STATUS = 0x31bd,
    /// <summary>
    /// desuetude, passenger card check(Corresponding to structure NET_ALARM_PASSENGER_CARD_CHECK )
    /// 废弃, 乘客刷卡事件(对应结构体 NET_ALARM_PASSENGER_CARD_CHECK )
    /// </summary>
    ALARM_PASSENGER_CARD_CHECK = 0x31be,
    /// <summary>
    /// Sound event(Corresponding to NET_ALARM_SOUND )
    /// 声音事件(对应结构体 NET_ALARM_SOUND )
    /// </summary>
    ALARM_SOUND = 0x31bf,
    /// <summary>
    /// Lock break event(Corresponding to NET_ALARM_LOCK_BREAK_INFO )
    /// 撬锁事件(对应结构体 NET_ALARM_LOCK_BREAK_INFO )
    /// </summary>
    ALARM_LOCK_BREAK = 0x31c0,
    /// <summary>
    /// Human Inside event((Corresponding to structure NET_ALARM_HUMAN_INSIDE_INFO)
    /// 舱内有人事件(对应结构体NET_ALARM_HUMAN_INSIDE_INFO)
    /// </summary>
    ALARM_HUMAN_INSIDE = 0x31c1,
    /// <summary>
    /// Human tumble Inside(Corresponding to structure NET_ALARM_HUMAN_TUMBLE_INSIDE_INFO)
    /// 舱内有人摔倒事件(对应结构体NET_ALARM_HUMAN_TUMBLE_INSIDE_INFO)
    /// </summary>
    ALARM_HUMAN_TUMBLE_INSIDE = 0x31c2,
    /// <summary>
    /// Lock entry trigger event(Corresponding to structure NET_ALARM_DISABLE_LOCKIN_INFO)
    /// 闭锁进门按钮触发事件(对应NET_ALARM_DISABLE_LOCKIN_INFO)
    /// </summary>
    ALARM_DISABLE_LOCKIN = 0x31c3,
    /// <summary>
    /// Lock go out trigger(Corresponding to structure NET_ALARM_DISABLE_LOCKOUT_INFO)
    /// 闭锁出门按钮触发事件(对应结构体NET_ALARM_DISABLE_LOCKOUT_INFO)
    /// </summary>
    ALARM_DISABLE_LOCKOUT = 0x31c4,
    /// <summary>
    /// break rules data upload failed (Corresponding to NET_ALARM_UPLOAD_PIC_FAILED_INFO )
    /// 违章数据上传失败事件(对应结构体 NET_ALARM_UPLOAD_PIC_FAILED_INFO )
    /// </summary>
    ALARM_UPLOAD_PIC_FAILED = 0x31c5,
    /// <summary>
    /// flow meter info event (NET_ALARM_FLOW_METER_INFO)
    /// 水流量统计信息上报事件(对应结构体 NET_ALARM_FLOW_METER_INFO)
    /// </summary>
    ALARM_FLOW_METER = 0x31c6,
    /// <summary>
    /// search around wifi device(Corresponding to NET_ALARM_WIFI_SEARCH_INFO)
    /// 获取到周围环境中WIFI设备上报事件(对应结构体 NET_ALARM_WIFI_SEARCH_INFO)
    /// </summary>
    ALARM_WIFI_SEARCH = 0x31c7,
    /// <summary>
    /// lowpower of wirelessdevice(NET_ALARM_WIRELESSDEV_LOWPOWER_INFO)
    /// 获取无线设备低电量上报事件(对应结构体NET_ALARM_WIRELESSDEV_LOWPOWER_INFO)
    /// </summary>
    ALARM_WIRELESSDEV_LOWPOWER = 0X31C8,
    /// <summary>
    /// Ptz Diagnoses event(Corresponding to NET_ALARM_PTZ_DIAGNOSES_INFO)
    /// 云台诊断事件(对应结构体NET_ALARM_PTZ_DIAGNOSES_INFO)
    /// </summary>
    ALARM_PTZ_DIAGNOSES = 0x31c9,
    /// <summary>
    /// flash light fault event (Corresponding to NET_ALARM_FLASH_LIGHT_FAULT_INFO)
    /// 爆闪灯(闪光灯)报警事件 (对应结构体 NET_ALARM_FLASH_LIGHT_FAULT_INFO)
    /// </summary>
    ALARM_FLASH_LIGHT_FAULT = 0x31ca,
    /// <summary>
    /// stroboscopic light fault event (Corresponding to NET_ALARM_STROBOSCOPIC_LIGTHT_FAULT_INFO)
    /// 频闪灯报警事件 (对应结构体 NET_ALARM_STROBOSCOPIC_LIGTHT_FAULT_INFO)
    /// </summary>
    ALARM_STROBOSCOPIC_LIGTHT_FAULT = 0x31cb,
    /// <summary>
    /// NumberStat event (Corresponding to NET_ALARM_HUMAN_NUMBER_STATISTIC_INFO)
    /// 人数量/客流量统计事件 (对应结构体 NET_ALARM_HUMAN_NUMBER_STATISTIC_INFO)
    /// </summary>
    ALARM_HUMAM_NUMBER_STATISTIC = 0x31cc,
    /// <summary>
    /// Video unfocus (Corresponding NET_ALARM_VIDEOUNFOCUS_INFO)
    /// 视频虚焦报警(对应结构体 NET_ALARM_VIDEOUNFOCUS_INFO)
    /// </summary>
    ALARM_VIDEOUNFOCUS = 0x31ce,
    /// <summary>
    /// Video recond buffer drop frame event(Corresponding to NET_ALARM_BUF_DROP_FRAME_INFO)
    /// 录像缓冲区丢帧事件(对应结构体 NET_ALARM_BUF_DROP_FRAME_INFO)
    /// </summary>
    ALARM_BUF_DROP_FRAME = 0x31cd,
    /// <summary>
    /// Abnormal event when master broad'version and slave broad'version different  (Corresponding to NET_ALARM_DOUBLE_DEV_VERSION_ABNORMAL_INFO)
    /// 双控设备主板与备板之间版本信息不一致异常事件 (对应结构体 NET_ALARM_DOUBLE_DEV_VERSION_ABNORMAL_INFO)
    /// </summary>
    ALARM_DOUBLE_DEV_VERSION_ABNORMAL = 0x31cf,
    /// <summary>
    /// Switch with master and slave(Corresponding to NET_ALARM_DCSSWITCH_INFO)
    /// 主备切换事件 集群切换报警 (对应结构体 NET_ALARM_DCSSWITCH_INFO)
    /// </summary>
    ALARM_DCSSWITCH = 0x31d0,
    /// <summary>
    /// Radar connect state(Corresponding to NET_ALARM_RADAR_CONNECT_STATE_INFO)
    /// 雷达状态事件(对应结构体 NET_ALARM_RADAR_CONNECT_STATE_INFO)
    /// </summary>
    ALARM_RADAR_CONNECT_STATE = 0x31d1,
    /// <summary>
    /// Defence arming status change(Corresponding to NET_ALARM_DEFENCE_ARMMODECHANGE_INFO)
    /// 防区布撤防状态改变事件(对应结构体 NET_ALARM_DEFENCE_ARMMODECHANGE_INFO)
    /// </summary>
    ALARM_DEFENCE_ARMMODE_CHANGE = 0x31d2,
    /// <summary>
    /// Subsystem arming status change(Corresponding to NET_ALARM_SUBSYSTEM_ARMMODECHANGE_INFO)
    /// 子系统布撤防状态改变事件(对应结构体 NET_ALARM_SUBSYSTEM_ARMMODECHANGE_INFO)
    /// </summary>
    ALARM_SUBSYSTEM_ARMMODE_CHANGE = 0x31d3,
    /// <summary>
    /// infrared detection information event (Corresponding NET_ALARM_RFID_INFO)
    /// 红外线检测信息事件(对应结构体 NET_ALARM_RFID_INFO)
    /// </summary>
    ALARM_RFID_INFO = 0x31d4,
    /// <summary>
    /// smoke detection(Corresponding NET_ALARM_SMOKE_DETECTION_INFO)
    /// 烟雾报警事件(对应结构体 NET_ALARM_SMOKE_DETECTION_INFO)
    /// </summary>
    ALARM_SMOKE_DETECTION = 0x31d5,
    /// <summary>
    /// TemperatureDifference Between Rule (Corresponding NET_ALARM_BETWEENRULE_DIFFTEMPER_INFO)
    /// 热成像规则间温差异常报警(对应结构体 NET_ALARM_BETWEENRULE_DIFFTEMPER_INFO)
    /// </summary>
    ALARM_BETWEENRULE_TEMP_DIFF = 0x31d6,
    /// <summary>
    /// Traffic picture analyse(Corresponding NET_ALARM_PIC_ANALYSE_INFO)
    /// 图片二次分析事件(对应 NET_ALARM_PIC_ANALYSE_INFO)
    /// </summary>
    ALARM_TRAFFIC_PIC_ANALYSE = 0x31d7,
    /// <summary>
    /// Hotspot warning(Corresponding NET_ALARM_HOTSPOT_WARNING_INFO)
    /// 热成像热点异常报警(对应结构体 NET_ALARM_HOTSPOT_WARNING_INFO)
    /// </summary>
    ALARM_HOTSPOT_WARNING = 0x31d8,
    /// <summary>
    /// coldspot warning(Corresponding NET_ALARM_COLDSPOT_WARNING_INFO)
    /// 热成像冷点异常报警(对应结构体 NET_ALARM_COLDSPOT_WARNING_INFO)
    /// </summary>
    ALARM_COLDSPOT_WARNING = 0x31d9,
    /// <summary>
    /// firewarning (Corresponding NET_ALARM_FIREWARNING_INFO_DETAIL)
    /// 热成像火情报警信息上报(对应结构体 NET_ALARM_FIREWARNING_INFO_DETAIL)
    /// </summary>
    ALARM_FIREWARNING_INFO = 0x31da,
    /// <summary>
    /// face overheating(Corresponding NET_ALARM_FACE_OVERHEATING_INFO)
    /// 热成像人体发烧预警(对应结构体 NET_ALARM_FACE_OVERHEATING_INFO)
    /// </summary>
    ALARM_FACE_OVERHEATING = 0x31db,
    /// <summary>
    /// Sensor abnormal(Corresponding NET_ALARM_SENSOR_ABNORMAL_INFO)
    /// 探测器异常报警(对应结构体 NET_ALARM_SENSOR_ABNORMAL_INFO)
    /// </summary>
    ALARM_SENSOR_ABNORMAL = 0X31dc,
    /// <summary>
    /// patient detection(Corresponding NET_ALARM_PATIENTDETECTION_INFO)
    /// 监控病人活动状态报警事件(对应结构体 NET_ALARM_PATIENTDETECTION_INFO)
    /// </summary>
    ALARM_PATIENTDETECTION = 0x31de,
    /// <summary>
    /// radar high speed detection(Corresponding to NET_ALARM_RADAR_HIGH_SPEED_INFO)
    /// 雷达监测超速报警事件 智能楼宇专用 (对应结构体 NET_ALARM_RADAR_HIGH_SPEED_INFO)
    /// </summary>
    ALARM_RADAR_HIGH_SPEED = 0x31df,
    /// <summary>
    /// Polling Alarm (Corresponding to NET_ALARM_POLLING_ALARM_INFO)
    /// 设备巡检报警事件 智能楼宇专用 (对应结构体 NET_ALARM_POLLING_ALARM_INFO)
    /// </summary>
    ALARM_POLLING_ALARM = 0x31e0,
    /// <summary>
    /// the alarm event for ITC_HWS000 (Corresponding NET_ALARM_ITC_HWS000)
    /// 虚点测速仪设备事件与报警(对应结构体 NET_ALARM_ITC_HWS000)
    /// </summary>
    ALARM_ITC_HWS000 = 0x31e1,
    /// <summary>
    /// Traffic Strobe State(Corresponding to NET_ALARM_TRAFFICSTROBESTATE_INFO)
    /// 道闸栏状态事件(对应结构体 NET_ALARM_TRAFFICSTROBESTATE_INFO)
    /// </summary>
    ALARM_TRAFFICSTROBESTATE = 0x31e2,
    /// <summary>
    /// telephone number check event(Corresponding to NET_ALARM_TELEPHONE_CHECK_INFO)
    /// 手机号码上报事件(对应结构体 NET_ALARM_TELEPHONE_CHECK_INFO)
    /// </summary>
    ALARM_TELEPHONE_CHECK = 0x31e3,
    /// <summary>
    /// Paste Detection(Corresponding to NET_ALARM_PASTE_DETECTION_INFO )
    /// 贴条事件(对应结构体 NET_ALARM_PASTE_DETECTION_INFO )
    /// </summary>
    ALARM_PASTE_DETECTION = 0x31e4,
    /// <summary>
    /// the alarm event for Shooting (Corresponding to NET_ALARM_PIC_SHOOTINGSCORERECOGNITION_INFO)
    /// 打靶像机事件(对应结构体 NET_ALARM_PIC_SHOOTINGSCORERECOGNITION_INFO)
    /// </summary>
    ALARM_SHOOTINGSCORERECOGNITION = 0x31e5,
    /// <summary>
    /// the alarm event for swipe overtime(Corresponding to NET_ALARM_SWIPE_OVERTIME_INFO)
    /// 超时未刷卡事件(对应结构体 NET_ALARM_SWIPE_OVERTIME_INFO)
    /// </summary>
    ALARM_SWIPEOVERTIME = 0x31e6,
    /// <summary>
    /// the alarm event for driving without card(Corresponding to NET_ALARM_DRIVING_WITHOUTCARD_INFO)
    /// 无卡驾驶事件(对应结构体 NET_ALARM_DRIVING_WITHOUTCARD_INFO)
    /// </summary>
    ALARM_DRIVING_WITHOUTCARD = 0x31e7,
    /// <summary>
    /// red light event (Corresponding to NET_ALARM_TRAFFIC_PEDESTRIAN_RUN_REDLIGHT_DETECTION_INFO)
    /// 闯红灯事件(对应结构体 NET_ALARM_TRAFFIC_PEDESTRIAN_RUN_REDLIGHT_DETECTION_INFO ) 
    /// </summary>
    ALARM_TRAFFIC_PEDESTRIAN_RUN_REDLIGHT_DETECTION = 0x31e8,
    /// <summary>
    /// the alarm event for fight detection(Corresponding to NET_ALARM_FIGHTDETECTION)
    /// 斗殴事件(对应结构体 NET_ALARM_FIGHTDETECTION)
    /// </summary>
    ALARM_FIGHTDETECTION = 0x31e9,
    ALARM_OIL_4G_OVERFLOW = 0x31ea,      //the alarm event for fushan oil 4G over flow threshold(Corresponding to NET_ALARM_OIL_4G_OVERFLOW_INFO)
    ALARM_ACCESSIDENTIFY = 0x31eb,      //VTO access identify(Corresponding to NET_ALARM_ACCESSIDENTIFY_INFO)
    ALARM_POWER_SWITCHER_ALARM = 0x31ec,      // the alarm event for Abnormal power switcher (Corresponding to DEV_ALRAM_POWERSWITCHER_INFO)
    ALARM_SCENNE_CHANGE_ALARM = 0x31ed,      // the alarm event for scene change (Corresponding to ALARM_PIC_SCENECHANGE_INFO)
    ALARM_WIFI_VIRTUALINFO_SEARCH = 0x31ef,      // the alarm event for WIFI virtual information(Corresponding to ALARM_WIFI_VIRTUALINFO_SEARCH_INFO)
    ALARM_TRAFFIC_OVERSPEED = 0x31f0,      // traffic overspeed event(Corresponding to event  ALARM_TRAFFIC_OVERSPEED_INFO)
    ALARM_TRAFFIC_UNDERSPEED = 0x31f1,      // traffic underspeed event(Corresponding to event  ALARM_TRAFFIC_NDERSPEED_INFO)
    ALARM_TRAFFIC_PEDESTRAIN = 0x31f2,      // traffic pedestrain event(Corresponding to event  ALARM_TRAFFIC_PEDESTRAIN_INFO)
    ALARM_TRAFFIC_JAM = 0x31f3,      // traffic jam event(Corresponding to event  ALARM_TRAFFIC_JAM_INFO)
    ALARM_TRAFFIC_PARKING = 0x31f4,      // traffic parking event(Corresponding to event  ALARM_TRAFFIC_PARKING_INFO)
    ALARM_TRAFFIC_THROW = 0x31f5,      // traffic throw event(Corresponding to event  ALARM_TRAFFIC_THROW_INFO)
    ALARM_TRAFFIC_RETROGRADE = 0x31f6,      // traffic retrograde event(Corresponding to event  ALARM_TRAFFIC_RETROGRADE_INFO)
    ALARM_VTSTATE_UPDATE = 0x31f7,      // VTS state update(Corresponding to ALARM_VTSTATE_UPDATE_INFO)
    ALARM_CALL_NO_ANSWERED = 0x31f8,      // the alarm event for call no answer, under directly connected(Corresponding to NET_ALARM_CALL_NO_ANSWERED_INFO)
    ALARM_USER_LOCK_EVENT = 0x31f9,      // User Lock Alarm Event
    ALARM_RETROGRADE_DETECTION = 0x31fa,      // retrogade dection event(Corresponding to ALARM_RETROGRADE_DETECTION_INFO)
    ALARM_AIO_APP_CONFIG_EVENT = 0x31fb,      // AIO App config event(Corresponding to NET_ALARM_AIO_APP_CONFIG_EVENT)
    ALARM_RAID_STATE_EX = 0x31fc,      // RAID state alarm(Corresponding to struct ALARM_RAID_INFO_EX)
    ALARM_STORAGE_IPC_FAILURE = 0x31fd,      // IPC storage failure alarm(IPC SD Card Abnormal Alarm)(Corresponding to struct ALARM_STORAGE_IPC_FAILURE_INFO)
    ALARM_DEVICE_STAY = 0x31fe,      // Still amarm, if the device coordinates are not changed in the specified time, the still alarm information is triggered(Corresponding to struct ALARM_DEVICE_STAY_INFO)    
    ALARM_SUB_WAY_DOOR_STATE = 0x31ff,      // the door state of subway(Corresponding to ALARM_SUB_WAY_DOOR_STATE_INFO)
    ALARM_SUB_WAY_PECE_SWITCH = 0x3200,      // the PECE switch state of subway(Corresponding to ALARM_SUB_WAY_PECE_SWITCH_INFO)
    ALARM_SUB_WAY_FIRE_ALARM = 0x3201,      // the fire alarm of subway(Corresponding to ALARM_SUB_WAY_FIRE_ALARM_INFO)
    ALARM_SUB_WAY_EMER_HANDLE = 0x3202,      // the emer handle state(Corresponding to ALARM_SUB_WAY_EMER_HANDLE_INFO)
    ALARM_SUB_WAY_CAB_COVER = 0x3203,      // the cab cover state(Corresponding to ALARM_SUB_WAY_CAB_COVER_INFO)
    ALARM_SUB_WAY_DERA_OBST = 0x3204,      // the dera or obst of subway(Corresponding to ALARM_SUB_WAY_DERA_OBST_INFO)
    ALARM_SUB_WAY_PECU_CALL = 0x3205,      // the PECU call state(Corresponding to ALARM_SUB_WAY_PECU_CALL_INFO)
    ALARM_BOX = 0x3206,      // the Alarm Box(Corresponding to ALARM_BOX_INFO)
    ALARM_DOOR_CLOSEDMANUALLY = 0x3207,      // door closed manually(Corresponding to  ALARM_DOOR_CLOSEDMANUALLY_INFO)
    ALARM_DOOR_NOTCLOSED_LONGTIME = 0x3208,      // door not closed long time(Corresponding to ALARM_DOOR_NOTCLOSED_LONGTIME_INFO)
    ALARM_UNDER_VOLTAGE = 0x3209,      // the under voltage alarm ( Corresponding to ALARM_UNDER_VOLTAGE_INFO )
    ALARM_OVER_VOLTAGE = 0x320a,      // the over voltage alarm  ( Corresponding to ALARM_OVER_VOLTAGE_INFO )
    ALARM_CUT_LINE = 0x320b,      // the cut line alarm(Corresponding to ALARM_CUT_LINE_INFO)
    ALARM_VIDEOMOTION_EVENT = 0x320c,      // video motion event(Corresponding to ALARM_VIDEOMOTION_EVENT_INFO)
    ALARM_WIDE_VIEW_REGION_EVENT = 0x320d,      // WideViewRegions event(Corresponding to ALARM_WIDE_VIEW_REGION_EVENT_INFO)
    ALARM_FIBRE_OPTIC_ABORT = 0x320e,      // the fibre optic abort alarm(Corresponding to ALARM_FIBRE_OPTIC_ABORT)
    ALARM_TAIL_DETECTION = 0x320f,      // tail detection(Corresponding ALARM_TAIL_DETECTION_INFO)
    ALARM_BITRATES_OVERLIMIT = 0x3210,      // alarm when camera bitrate is over channel decoding specification(Corresponding to ALARM_BITRATES_OVERLIMIT_INFO)
    ALARM_RECORD_CHANGED_EX = 0x3211,      // Record state changed alarm(Corresponding to NET_ALARM_RECORD_CHANGED_INFO_EX)
    ALARM_HIGH_DECIBEL = 0x3212,      // High decibel alarm(Corresponding to NET_ALARM_HIGH_DECIBEL_INFO)
    ALARM_SHAKE_DETECTION = 0x3213,      // Shake detection alarm(Corresponding to ALARM_SHAKE_DETECTION_INFO)
    ALARM_TUMBLE_DETECTION = 0x3214,      // tumble detection alarm(Corresponding to ALARM_TUMBLE_DETECTION_INFO)
    ALARM_ACCESS_CTL_MALICIOUS = 0x3215,      // Open door with malice(Corresponding to ALARM_ACCESS_CTL_MALICIOUS)
    ALARM_ACCESS_CTL_USERID_REGISTER = 0x3216,      // UserID Register(Corresponding to ALARM_ACCESS_CTL_USERID_REGISTER)
    ALARM_ACCESS_CTL_REVERSELOCK = 0x3217,      // ReverseLock alarm(Corresponding to ALARM_ACCESS_CTL_REVERSELOCK)
    ALARM_ACCESS_CTL_USERID_DELETE = 0x3218,      // UserID delete(Corresponding to ALARM_ACCESS_CTL_USERID_DELETE)
    ALARM_ACCESS_DOOR_BELL = 0x3219,      // Door bell (Corresponding to ALARM_ACCESS_DOOR_BELL_INFO)
    ALARM_ACCESS_FACTORY_RESET = 0x321a,      // Wireless Dev Facroty Reset (Corresponding to ALARM_ACCESS_FACTORY_RESET_INFO)
    ALARM_POLICE_RECORD_PROGRESS = 0x321b,        // MPT record file transfer progress(Corresponding to ALARM_POLICE_RECORD_PROGRESS_INFO)
    ALARM_POLICE_PLUGIN = 0x321c,        // MPT plugin in or out event(Corresponding to ALARM_POLICE_PLUGIN_INFO)
    ALARM_GPS_NOT_ALIGNED = 0x321d,        // GPS not aligned alarm (Corresponding to ALARM_GPS_NOT_ALIGNED_INFO)
    ALARM_WIRELESS_NOT_CONNECTED = 0x321e,        // WireLess(include wifi, 3G/4G) not connected alarm (Corresponding to ALARM_WIRELESS_NOT_CONNECTED_INFO)
    ALARM_CABINET = 0x321f,        // Cloud Cabinet event(Corresponding to ALARM_CABINET_INFO)
    SWITCH_SCREEN = 0x3220,        // Switch screen event.
    ALARM_NEAR_DISTANCE_DETECTION = 0x3221,        // alarm of near distance detection (Corresponding to ALARM_NEAR_DISTANCE_INFO)
    ALARM_MAN_STAND_DETECTION = 0x3222,        // alarm of stereo standing (Corresponding to ALARM_MAN_STAND_INFO)
    ALARM_MAN_NUM_DETECTION = 0x3223,        // alarm of regional population statistics  (Corresponding to ALARM_MAN_NUM_INFO)
    MCS_GENERAL_CAPACITY_LOW = 0x3224,        // MCS general capacity low event(Corresponding to ALARM_MCS_GENERAL_CAPACITY_LOW_INFO)
    MCS_DATA_NODE_OFFLINE = 0x3225,        // MCS data node offline event(Corresponding to ALARM_MCS_DATA_NODE_OFFLINE_INFO)
    MCS_DISK_OFFLINE = 0x3226,        // MCS disk offline event(Corresponding to ALARM_MCS_DISK_OFFLINE_INFO)
    MCS_DISK_SLOW = 0x3227,        // MCS disk slow event(Corresponding to ALARM_MCS_DISK_SLOW_INFO)
    MCS_DISK_BROKEN = 0x3228,        // MCS disk broken event(Corresponding to ALARM_MCS_DISK_BROKEN_INFO)
    MCS_DISK_UNKNOW_ERROR = 0x3229,        // MCS disk unknown error event(Corresponding to ALARM_MCS_DISK_UNKNOW_ERROR_INFO)
    MCS_METADATA_SERVER_ABNORMAL = 0x322a,        // MCS metadata server abnormal event(Corresponding to ALARM_MCS_METADATA_SERVER_ABNORMAL_INFO)
    MCS_CATALOG_SERVER_ABNORMAL = 0x322b,        // MCS catalog server abnormal event(Corresponding to ALARM_MCS_CATALOG_SERVER_ABNORMAL_INFO)
    MCS_GENERAL_CAPACITY_RESUME = 0x322c,        // MCS general capacity resume event(Corresponding to ALARM_MCS_GENERAL_CAPACITY_RESUME_INFO)
    MCS_DATA_NODE_ONLINE = 0x322d,        // MCS data node online event(Corresponding to ALARM_MCS_DATA_NODE_ONLINE_INFO)
    MCS_DISK_ONLINE = 0x322e,        // MCS disk online event(Corresponding to ALARM_MCS_DISK_ONLINE_INFO)
    MCS_METADATA_SLAVE_ONLINE = 0x322f,        // MCS metadata slave online event(Corresponding to ALARM_MCS_METADATA_SLAVE_ONLINE_INFO)
    MCS_CATALOG_SERVER_ONLINE = 0x3230,        // MCS catalog server online event(Corresponding to ALARM_MCS_CATALOG_SERVER_ONLINE_INFO)
    ALARM_OFFLINE_LOGSYNC = 0x3231,        // alarm of off Line logsync(Corresponding to ALARM_OFFLINE_LOGSYNC_INFO)
    ALARM_UPGRADE_STATE = 0x3232,        // event of device upgrade(Corresponding to ALARM_UPGRADE_STATE)
    ALARM_LABELINFO = 0x3233,        // IPC added new(2017.4),RFID tag information acquisition event (Corresponding to DH_ALARM_LABELINFO)
    ALARM_TIRED_PHYSIOLOGICAL = 0x3234,        // alarm of Tired Physiological(Corresponding to ALARM_TIRED_PHYSIOLOGICAL)
    ALARM_CALLING_WHEN_DRIVING = 0x3235,        // alarm of Calling When Driving(Corresponding to ALARM_CALLING_WHEN_DRIVING)
    ALARM_TRAFFIC_DRIVER_SMOKING = 0x3236,        // alarm of Traffic Driver Smoking(Corresponding to ALARM_TRAFFIC_DRIVER_SMOKING)
    ALARM_TRAFFIC_DRIVER_LOWER_HEAD = 0x3237,        // alarm of Traffic Driver Lower Head(Corresponding to ALARM_TRAFFIC_DRIVER_LOWER_HEAD)
    ALARM_TRAFFIC_DRIVER_LOOK_AROUND = 0x3238,        // alarm of Traffic Driver Look Around(Corresponding to ALARM_TRAFFIC_DRIVER_LOOK_AROUND)
    ALARM_TRAFFIC_DRIVER_LEAVE_POST = 0x3239,        // alarm of Traffic Driver Leave Post(Corresponding to ALARM_TRAFFIC_DRIVER_LEAVE_POST)
    ALARM_TRAFFIC_DRIVER_YAWN = 0x323a,        // alarm of Traffic Driver Yawn(Corresponding to ALARM_TRAFFIC_DRIVER_YAWN)
    ALARM_AUTO_INSPECTION = 0x323b,        // Device auto inspection(Corresponding to ALARM_AUTO_INSPECTION) 
    ALARM_TRAFFIC_VEHICLE_POSITION = 0x323c,        // Vehicle Position Event(Corresponding to ALARM_TRAFFIC_VEHICLE_POSITION)
    ALARM_FACE_VERIFICATION_ACCESS_SNAP = 0x323d, // alarm of face verification access snap(Corresponding to ALARM_FACE_VERIFICATION_ACCESS_SNAP_INFO)
    ALARM_VIDEOBLIND = 0x323e,        // alarm of video blind(Corresponding to ALARM_VIDEO_BLIND_INFO)
    ALARM_DRIVER_NOTCONFIRM = 0x323f,        // alarm of driver not confirm(Corresponding to ALARM_DRIVER_NOTCONFIRM_INFO)
    /// <summary>
    /// 
    /// 人脸信息录入事件(对应NET_ALARM_FACEINFO_COLLECT_INFO)
    /// </summary>
    FACEINFO_COLLECT = 0x3240,
    ALARM_HIGH_SPEED = 0x3241,      // alarm of high speed(Corresponding to ALARM_HIGH_SPEED_INFO)
    ALARM_VIDEO_LOSS = 0x3242,      // alarm of video loss(Corresponding to ALARM_VIDEO_LOSS_INFO)
    ALARM_MPTBASE_CONNECT = 0x3243,          // alarm of the connection status between device ant base(Corresponding to ALARM_MPTBASE_CONNECT) 
    ALARM_LATEST_SHUTDOWN = 0x3244,          // alarm of the latest status of shut down (Corresponding to ALARM_LATEST_SHUTDOWN)    
    ALARM_ROBOT_COLLISION = 0x3245,     // alarm of robot collision(Corresponding to ALARM_ROBOT_COLLISION)
    ALARM_ROBOT_FALLENDOWN = 0x3246,      // alarm of robot fallendown(Corresponding to ALARM_ROBOT_FALLENDOWN)
    ALARM_ROBOT_UNRECOGNIZED2DCODE = 0x3247,      // alarm of robot unrecognized 2DCODE(Corresponding to ALARM_ROBOT_UNRECOGNIZED2DCODE) 
    ALARM_ROBOT_WRONG2DCODE = 0x3248,     // alarm of wrong 2DCODE(Corresponding to ALARM_ROBOT_WRONG2DCODE)
    ALARM_ROBOT_ROADBLOCKED = 0x3249,       // alarm of robot roadblocked(Corresponding to ALARM_ROBOT_ROADBLOCKED) 
    ALARM_ROBOT_FAULT = 0x324a,     // alarm of robot fault(Corresponding to ALARM_ROBOT_FAULT)
    ALARM_ROBOT_OVERLOAD = 0x324b,      // alarm of robot overload(Corresponding to ALARM_ROBOT_OVERLOAD)
    ALARM_ROBOT_YAWEXCEPTION = 0x324c,      // alarm of robot yawexception(Corresponding to ALARM_ROBOT_YAWEXCEPTION)
    ALARM_ROBOT_LOADTIMEOUT = 0x324e,     // alarm of robot LoadTimeout(Corresponding to ALARM_ROBOT_LOADTIMEOUT)
    ALARM_ROBOT_UNLOADTIMEOUT = 0x324f,     // alarm of robot UnLoadTimeout(Corresponding to ALARM_ROBOT_UNLOADTIMEOUT)
    ALARM_ROBOT_MAPUPDATE = 0x3250,     // alarm of robot MapUpdate(Corresponding to ALARM_ROBOT_MAPUPDATE)
    ALARM_ROBOT_BRAKE = 0x3252,     // alarm of robot brake(Corresponding to ALARM_ROBOT_BRAKE)
    ALARM_ROBOT_MANUAL_INTERVENTION = 0x3253,     // alarm of robot manual intervention(Corresponding to ALARM_ROBOT_MANUAL_INTERVENTION)
    ALARM_VIDEO_TALK_PATH = 0x324d,     // alarm of the video talk path(Corresponding to ALARM_VIDEO_TALK_PATH_INFO)
    ALARM_CGIRECORD = 0x3251,          // cgi triggered manual video recording(Corresponding to ALARM_CGIRECORD)
    ALARM_BATTERY_TEMPERATURE = 0x3254,     // alarm of battery temperature(corresponding to ALARM_BATTERY_TEMPERATURE_INFO)
    ALARM_TIRE_PRESSURE = 0x3255,     // alarm of tire pressure(corresponding to ALARM_TIRE_PRESSURE_INFO )
    ALARM_VTH_CONFLICT = 0x3256,      // alarm of VTH Conflict(corresponding to ALARM_VTH_CONFLICT_INFO)
    ALARM_ACCESS_CTL_BLACKLIST = 0x3257,          // alarm of access event form blacklist(corresponding to ALARM_ACCESS_CTL_BLACKLIST)
    ALARM_ROBOT_EMERGENCY_STOP = 0x3258,      // alarm of robot emergency stop(corresponding to ALARM_ROBOT_EMERFEBCY_STOP)
    ALARM_ROBOT_PATH_PLAN_FAILED = 0x3259,      // alarm of robot path plan failed(corresponding to ALARM_ROBOT_PATH_PLAN_FAILED)
    ALARM_ROBOT_LOCAL_MAP_UPLOAD = 0x325a,      // alarm of robot local map upload(corresponding to ALARM_ROBOT_LOCAL_MAP_UPLOAD)
    ALARM_ROBOT_SHELF_ERROR = 0x325b,     // alarm of robot shelf error(corresponding to ALARM_ROBOT_SHELF_ERROR)
    ALARM_ROBOT_SENSOR_ERROR = 0x325c,      // alarm of robot sensor error(corresponding to ALARM_ROBOT_SENSOR_ERROR)
    ALARM_ROBOT_DERAILMENT = 0x325d,          // alarm of robot derailment(corresponding to ALARM_ROBOT_DERAILMENT)
    ALARM_ROBOT_MOTOR_UNINIT = 0x325e,          // alarm of robot motor lock the gate(corresponding to ALARM_ROBOT_MOTOR_UNINIT)
    ALARM_ROBOT_PREVENT_FALLING = 0x325f,          // alarm of Robot prevent falling(corresponding to ALARM_ROBOT_PREVENT_FALLING)
    ALARM_ROBOT_LOCATION_EXCEPTION = 0x3260,      // alarm of robot location exception(Corresponding to ALARM_ROBOT_LOCATION_EXCEPTION )
    ALARM_ROBOT_UPGRADER_FAIL = 0x3261,          // alarm of Robot upgrader fail(corresponding to ALARM_ROBOT_UPGRADER_FAIL)
    ALARM_ROBOT_CHARGING_ERROR = 0x3262,          // alarm of robot charging error(Corresponding to ALARM_ROBOT_CHARGING_ERROR)
    ALARM_ROBOT_STATIONCHARGING_ERROR = 0x3263,   // alarm of robot station charging error(Corresponding ALARM_ROBOT_STATIONCHARGING_ERROR)
    ALARM_USERLOCK = 0x3300,    // alarm of user lock(corresponding to ALARM_USERLOCK_INFO)
    ALARM_DOWNLOAD_REMOTE_FILE = 0x3301,    // alarm of download remote file(corresponding to ALARM_DOWNLOAD_REMOTE_FILE_INFO)
    ALARM_NASFILE_STATUS = 0x3302,         // alarm of NAS file status (Corresponding to ALARM_NASFILE_STATUS_INFO)
    ALARM_TALKING_CANCELCALL = 0x3303,         // alarm of Cancel talking call(Corresponding to ALARM_TALKING_CANCELCALL_INFO)
    ALARM_ACCESS_CTL_UNAUTHORIZED_MALICIOUSWIP = 0x3304, // alarm of unauthorized maliciouswip(Corresponding to ALARM_ACCESS_CTL_UNAUTHORIZED_MALICIOUSWIP) 
    ALARM_CROWD_DETECTION = 0x3305,     // alarm of crowd detection(Corresponding to ALARM_CROWD_DETECTION_INFO)
    ALARM_FACE_FEATURE_ABSTRACT = 0x3306,     // alarm of face feature abstract(Corresponding to ALARM_FACE_FEATURE_ABSTRACT_INFO)
    ALARM_RECORD_SCHEDULE_CHANGE = 0x3307,      // alarm of record schedule change (Corresponding to NET_ALARM_RECORD_SCHEDULE_CHANGE_INFO)
    ALARM_NTP_CHANGE = 0x3308,      // alarm of NTP change (Corresponding to NET_ALARM_NTP_CHANGE_INFO) 
  }

  /// <summary>
  /// intelligent event type,used in RealLoadPicture or fAnalyzerDataCallBack
  /// 智能事件类型
  /// </summary>
  public enum EM_EVENT_IVS_TYPE
  {
    /// <summary>
    /// subscription all event
    /// 订阅所有事件
    /// </summary>
    ALL = 0x00000001,
    /// <summary>
    /// cross line event(Corresponding to NET_DEV_EVENT_CROSSLINE_INFO)
    /// 警戒线事件(对应 NET_DEV_EVENT_CROSSLINE_INFO)
    /// </summary>
    CROSSLINEDETECTION = 0x00000002,
    /// <summary>
    /// cross region event(Corresponding to NET_DEV_EVENT_CROSSREGION_INFO)
    /// 警戒区事件(对应 NET_DEV_EVENT_CROSSREGION_INFO)
    /// </summary>
    CROSSREGIONDETECTION = 0x00000003,
    /// <summary>
    /// past event(Corresponding to NET_DEV_EVENT_PASTE_INFO)
    /// 贴条事件(对应 NET_DEV_EVENT_PASTE_INFO)
    /// </summary>
    PASTEDETECTION = 0x00000004,
    /// <summary>
    /// left event(Corresponding to NET_DEV_EVENT_LEFT_INFO)
    /// 物品遗留事件(对应 NET_DEV_EVENT_LEFT_INFO)
    /// </summary>
    LEFTDETECTION = 0x00000005,
    /// <summary>
    /// stay event(Corresponding to NET_DEV_EVENT_STAY_INFO)
    /// 停留事件(对应 NET_DEV_EVENT_STAY_INFO)
    /// </summary>
    STAYDETECTION = 0x00000006,
    /// <summary>
    /// wander event(Corresponding to NET_DEV_EVENT_WANDER_INFO)
    /// 徘徊事件(对应 NET_DEV_EVENT_WANDER_INFO)
    /// </summary>
    WANDERDETECTION = 0x00000007,
    /// <summary>
    /// reservation event(Corresponding to NET_DEV_EVENT_PRESERVATION_INFO) 
    /// 物品保全事件(对应 NET_DEV_EVENT_PRESERVATION_INFO)
    /// </summary>
    PRESERVATION = 0x00000008,
    /// <summary>
    /// move event(Corresponding to NET_DEV_EVENT_MOVE_INFO)
    /// 移动事件(对应 NET_DEV_EVENT_MOVE_INFO)
    /// </summary>
    MOVEDETECTION = 0x00000009,
    /// <summary>
    /// tail event(Corresponding to NET_DEV_EVENT_TAIL_INFO)
    /// 尾随事件(对应 NET_DEV_EVENT_TAIL_INFO)
    /// </summary>
    TAILDETECTION = 0x0000000A,
    /// <summary>
    /// rioter event(Corresponding to NET_DEV_EVENT_RIOTERL_INFO)
    /// 聚众事件(对应 NET_DEV_EVENT_RIOTERL_INFO)
    /// </summary>
    RIOTERDETECTION = 0x0000000B,
    /// <summary>
    /// fire event(Corresponding to NET_DEV_EVENT_FIRE_INFO)
    /// 火警事件(对应 NET_DEV_EVENT_FIRE_INFO)
    /// </summary>
    FIREDETECTION = 0x0000000C,
    /// <summary>
    /// smoke event(Corresponding to NET_DEV_EVENT_SMOKE_INFO)
    /// 烟雾报警事件(对应 NET_DEV_EVENT_SMOKE_INFO)
    /// </summary>
    SMOKEDETECTION = 0x0000000D,
    /// <summary>
    /// fight event(Corresponding to NET_DEV_EVENT_FLOWSTAT_INFO)
    /// 斗殴事件(对应 NET_DEV_EVENT_FLOWSTAT_INFO)
    /// </summary>
    FIGHTDETECTION = 0x0000000E,
    /// <summary>
    /// flow stat event(Corresponding to NET_DEV_EVENT_FLOWSTAT_INFO)
    /// 流量统计事件(对应 NET_DEV_EVENT_FLOWSTAT_INFO)
    /// </summary>
    FLOWSTAT = 0x0000000F,
    /// <summary>
    /// number stat event(Corresponding to NET_DEV_EVENT_NUMBERSTAT_INFO)
    /// 数量统计事件(对应 NET_DEV_EVENT_NUMBERSTAT_INFO)
    /// </summary>
    NUMBERSTAT = 0x00000010,
    /// <summary>
    /// camera cover event
    /// 摄像头覆盖事件(保留)
    /// </summary>
    CAMERACOVERDDETECTION = 0x00000011,
    /// <summary>
    /// camera move event
    /// 摄像头移动事件(保留)
    /// </summary>
    CAMERAMOVEDDETECTION = 0x00000012,
    /// <summary>
    /// video abnormal event(Corresponding to NET_DEV_EVENT_VIDEOABNORMALDETECTION_INFO)
    /// 视频异常事件(对应 NET_DEV_EVENT_VIDEOABNORMALDETECTION_INFO)
    /// </summary>
    VIDEOABNORMALDETECTION = 0x00000013,
    /// <summary>
    /// video bad event
    /// 视频损坏事件(保留)
    /// </summary>
    VIDEOBADDETECTION = 0x00000014,
    /// <summary>
    /// traffic control event(Corresponding to NET_DEV_EVENT_TRAFFICCONTROL_INFO)
    /// 交通管制事件(对应 NET_DEV_EVENT_TRAFFICCONTROL_INFO)
    /// </summary>
    TRAFFICCONTROL = 0x00000015,
    /// <summary>
    /// traffic accident event(Corresponding to NET_DEV_EVENT_TRAFFICACCIDENT_INFO)
    /// 交通事故事件(对应 NET_DEV_EVENT_TRAFFICACCIDENT_INFO)
    /// </summary>
    TRAFFICACCIDENT = 0x00000016,
    /// <summary>
    /// traffic junction event(Corresponding to NET_DEV_EVENT_TRAFFICJUNCTION_INFO)
    /// 交通路口事件----老规则(对应 NET_DEV_EVENT_TRAFFICJUNCTION_INFO)
    /// </summary>
    TRAFFICJUNCTION = 0x00000017,
    /// <summary>
    /// traffic gate event(Corresponding to NET_DEV_EVENT_TRAFFICGATE_INFO)
    /// 交通卡口事件----老规则(对应 NET_DEV_EVENT_TRAFFICGATE_INFO)
    /// </summary>
    TRAFFICGATE = 0x00000018,
    /// <summary>
    /// traffic snapshot(Corresponding to NET_DEV_EVENT_TRAFFICSNAPSHOT_INFO)
    /// 交通抓拍事件(对应 NET_DEV_EVENT_TRAFFICSNAPSHOT_INFO)
    /// </summary>
    TRAFFICSNAPSHOT = 0x00000019,
    /// <summary>
    /// face detection(Corresponding to NET_DEV_EVENT_FACEDETECT_INFO)
    /// 人脸检测事件 (对应 NET_DEV_EVENT_FACEDETECT_INFO)
    /// </summary>
    FACEDETECT = 0x0000001A,
    /// <summary>
    /// traffic-Jam(Corresponding to NET_DEV_EVENT_TRAFFICJAM_INFO)
    /// 交通拥堵事件(对应 NET_DEV_EVENT_TRAFFICJAM_INFO)
    /// </summary>
    TRAFFICJAM = 0x0000001B,
    /// <summary>
    /// traffic-RunRedLight(Corresponding to NET_DEV_EVENT_TRAFFIC_RUNREDLIGHT_INFO)
    /// 交通违章-闯红灯事件(对应 NET_DEV_EVENT_TRAFFIC_RUNREDLIGHT_INFO)
    /// </summary>
    TRAFFIC_RUNREDLIGHT = 0x00000100,
    /// <summary>
    /// traffic-Overline(Corresponding to NET_DEV_EVENT_TRAFFIC_OVERLINE_INFO)
    /// 交通违章-压车道线事件(对应 NET_DEV_EVENT_TRAFFIC_OVERLINE_INFO)
    /// </summary>
    TRAFFIC_OVERLINE = 0x00000101,
    /// <summary>
    /// traffic-Retrograde(Corresponding to NET_DEV_EVENT_TRAFFIC_RETROGRADE_INFO)
    /// 交通违章-逆行事件(对应 NET_DEV_EVENT_TRAFFIC_RETROGRADE_INFO)
    /// </summary>
    TRAFFIC_RETROGRADE = 0x00000102,
    /// <summary>
    /// traffic-TurnLeft(Corresponding to NET_DEV_EVENT_TRAFFIC_TURNLEFT_INFO)
    /// 交通违章-违章左转(对应 NET_DEV_EVENT_TRAFFIC_TURNLEFT_INFO)
    /// </summary>
    TRAFFIC_TURNLEFT = 0x00000103,
    /// <summary>
    /// traffic-TurnRight(Corresponding to NET_DEV_EVENT_TRAFFIC_TURNRIGHT_INFO)	
    /// 交通违章-违章右转(对应 NET_DEV_EVENT_TRAFFIC_TURNRIGHT_INFO)
    /// </summary>
    TRAFFIC_TURNRIGHT = 0x00000104,
    /// <summary>
    /// traffic-Uturn(Corresponding to NET_DEV_EVENT_TRAFFIC_UTURN_INFO)
    /// 交通违章-违章掉头(对应 NET_DEV_EVENT_TRAFFIC_UTURN_INFO)
    /// </summary>
    TRAFFIC_UTURN = 0x00000105,
    /// <summary>
    /// traffic-Overspeed(Corresponding to NET_DEV_EVENT_TRAFFIC_OVERSPEED_INFO)
    /// 交通违章-超速(对应 NET_DEV_EVENT_TRAFFIC_OVERSPEED_INFO)
    /// </summary>
    TRAFFIC_OVERSPEED = 0x00000106,
    /// <summary>
    /// traffic-Underspeed(Corresponding to NET_DEV_EVENT_TRAFFIC_UNDERSPEED_INFO)
    /// 交通违章-低速(对应 NET_DEV_EVENT_TRAFFIC_UNDERSPEED_INFO)
    /// </summary>
    TRAFFIC_UNDERSPEED = 0x00000107,
    /// <summary>
    /// traffic-Parking(Corresponding to NET_DEV_EVENT_TRAFFIC_PARKING_INFO)
    /// 交通违章-违章停车(对应 NET_DEV_EVENT_TRAFFIC_PARKING_INFO)
    /// </summary>
    TRAFFIC_PARKING = 0x00000108,
    /// <summary>
    /// traffic-WrongRoute(Corresponding to NET_DEV_EVENT_TRAFFIC_WRONGROUTE_INFO)
    /// 交通违章-不按车道行驶(对应 NET_DEV_EVENT_TRAFFIC_WRONGROUTE_INFO)
    /// </summary>
    TRAFFIC_WRONGROUTE = 0x00000109,
    /// <summary>
    /// traffic-CrossLane(Corresponding to NET_DEV_EVENT_TRAFFIC_CROSSLANE_INFO)
    /// 交通违章-违章变道(对应 NET_DEV_EVENT_TRAFFIC_CROSSLANE_INFO)
    /// </summary>
    TRAFFIC_CROSSLANE = 0x0000010A,
    /// <summary>
    /// traffic-OverYellowLine(Corresponding to NET_DEV_EVENT_TRAFFIC_OVERYELLOWLINE_INFO)
    /// 交通违章-压黄线 (对应 NET_DEV_EVENT_TRAFFIC_OVERYELLOWLINE_INFO)
    /// </summary>
    TRAFFIC_OVERYELLOWLINE = 0x0000010B,
    /// <summary>
    /// traffic-DrivingOnShoulder(Corresponding to NET_DEV_EVENT_TRAFFIC_DRIVINGONSHOULDER_INFO)
    /// 交通违章-路肩行驶事件(对应 NET_DEV_EVENT_TRAFFIC_DRIVINGONSHOULDER_INFO)  
    /// </summary>
    TRAFFIC_DRIVINGONSHOULDER = 0x0000010C,
    /// <summary>
    /// traffic-YellowPlateInLane(Corresponding to NET_DEV_EVENT_TRAFFIC_YELLOWPLATEINLANE_INFO)
    /// 交通违章-黄牌车占道事件(对应 NET_DEV_EVENT_TRAFFIC_YELLOWPLATEINLANE_INFO)
    /// </summary>
    TRAFFIC_YELLOWPLATEINLANE = 0x0000010E,
    /// <summary>
    /// Traffic offense-Pedestral has higher priority at the  crosswalk(Corresponding to NET_DEV_EVENT_TRAFFIC_PEDESTRAINPRIORITY_INFO)
    /// 交通违章-斑马线行人优先事件(对应 NET_DEV_EVENT_TRAFFIC_PEDESTRAINPRIORITY_INFO)
    /// </summary>
    TRAFFIC_PEDESTRAINPRIORITY = 0x0000010F,
    /// <summary>
    /// cross fence(Corresponding to NET_DEV_EVENT_CROSSFENCEDETECTION_INFO)
    /// 翻越围栏事件(对应 NET_DEV_EVENT_CROSSFENCEDETECTION_INFO)
    /// </summary>
    CROSSFENCEDETECTION = 0x0000011F,
    /// <summary>
    /// ElectroSpark event(Corresponding to NET_DEV_EVENT_ELECTROSPARK_INFO) 
    /// 电火花事件(对应 NET_DEV_EVENT_ELECTROSPARK_INFO)
    /// </summary>
    ELECTROSPARKDETECTION = 0X00000110,
    /// <summary>
    /// no passing(Corresponding to NET_DEV_EVENT_TRAFFIC_NOPASSING_INFO)
    /// 交通违章-禁止通行事件(对应 NET_DEV_EVENT_TRAFFIC_NOPASSING_INFO)
    /// </summary>
    TRAFFIC_NOPASSING = 0x00000111,
    /// <summary>
    /// abnormal run(Corresponding to NET_DEV_EVENT_ABNORMALRUNDETECTION_INFO)
    /// 异常奔跑事件(对应 NET_DEV_EVENT_ABNORMALRUNDETECTION_INFO)
    /// </summary>
    ABNORMALRUNDETECTION = 0x00000112,
    /// <summary>
    /// retrograde(Corresponding to NET_DEV_EVENT_RETROGRADEDETECTION_INFO)
    /// 人员逆行事件(对应 NET_DEV_EVENT_RETROGRADEDETECTION_INFO)
    /// </summary>
    RETROGRADEDETECTION = 0x00000113,
    /// <summary>
    /// in region detection(Corresponding to NET_DEV_EVENT_INREGIONDETECTION_INFO)
    /// 区域内检测事件(对应 NET_DEV_EVENT_INREGIONDETECTION_INFO)
    /// </summary>
    INREGIONDETECTION = 0x00000114,
    /// <summary>
    /// taking away things(Corresponding to NET_DEV_EVENT_TAKENAWAYDETECTION_INFO)
    /// 物品搬移事件(对应 NET_DEV_EVENT_TAKENAWAYDETECTION_INFO)
    /// </summary>
    TAKENAWAYDETECTION = 0x00000115,
    /// <summary>
    /// parking(Corresponding to NET_DEV_EVENT_PARKINGDETECTION_INFO)
    /// 非法停车事件(对应 NET_DEV_EVENT_PARKINGDETECTION_INFO)
    /// </summary>
    PARKINGDETECTION = 0x00000116,
    /// <summary>
    /// face recognition(Corresponding to NET_DEV_EVENT_FACERECOGNITION_INFO)
    /// 人脸识别事件(对应 NET_DEV_EVENT_FACERECOGNITION_INFO)
    /// </summary>
    FACERECOGNITION = 0x00000117,
    /// <summary>
    /// manual snap(Corresponding to NET_DEV_EVENT_TRAFFIC_MANUALSNAP_INFO)
    /// 交通手动抓拍事件(对应 NET_DEV_EVENT_TRAFFIC_MANUALSNAP_INFO)
    /// </summary>
    TRAFFIC_MANUALSNAP = 0x00000118,
    /// <summary>
    /// traffic flow state(Corresponding to NET_DEV_EVENT_TRAFFIC_FLOW_STATE)
    /// 交通流量统计事件(对应 NET_DEV_EVENT_TRAFFIC_FLOW_STATE)
    /// </summary>
    TRAFFIC_FLOWSTATE = 0x00000119,
    /// <summary>
    /// traffic stay(Corresponding to NET_DEV_EVENT_TRAFFIC_STAY_INFO)
    /// 交通滞留事件(对应 NET_DEV_EVENT_TRAFFIC_STAY_INFO)
    /// </summary>
    TRAFFIC_STAY = 0x0000011A,
    /// <summary>
    /// traffic vehicle route(Corresponding to NET_DEV_EVENT_TRAFFIC_VEHICLEINROUTE_INFO)
    /// 有车占道事件(对应 NET_DEV_EVENT_TRAFFIC_VEHICLEINROUTE_INFO)
    /// </summary>
    TRAFFIC_VEHICLEINROUTE = 0x0000011B,
    /// <summary>
    /// motion detect(Corresponding to NET_DEV_EVENT_ALARM_INFO)
    /// 视频移动侦测事件(对应 NET_DEV_EVENT_ALARM_INFO)
    /// </summary>
    ALARM_MOTIONDETECT = 0x0000011C,
    /// <summary>
    /// local alarm(Corresponding to NET_DEV_EVENT_ALARM_INFO)
    /// 外部报警事件(对应 NET_DEV_EVENT_ALARM_INFO)
    /// </summary>
    ALARM_LOCALALARM = 0x0000011D,
    /// <summary>
    /// prisoner rise detect(Corresponding to NET_DEV_EVENT_PRISONERRISEDETECTION_INFO)
    /// 看守所囚犯起身事件(对应 NET_DEV_EVENT_PRISONERRISEDETECTION_INFO)
    /// </summary>
    PRISONERRISEDETECTION = 0x0000011E,
    /// <summary>
    /// traffic tollgate(Corresponding to NET_DEV_EVENT_TRAFFICJUNCTION_INFO)
    /// 交通违章-卡口事件----新规则(对应 NET_DEV_EVENT_TRAFFICJUNCTION_INFO)
    /// </summary>
    TRAFFIC_TOLLGATE = 0x00000120,
    /// <summary>
    /// density detection of persons(Corresponding to NET_DEV_EVENT_DENSITYDETECTION_INFO)
    /// 人员密集度检测(对应 NET_DEV_EVENT_DENSITYDETECTION_INFO)
    /// </summary>
    DENSITYDETECTION = 0x00000121,
    /// <summary>
    /// video diagnosis result(Corresponding to NET_VIDEODIAGNOSIS_COMMON_INFO and NET_REAL_DIAGNOSIS_RESULT)
    /// 视频诊断结果事件(对应 NET_VIDEODIAGNOSIS_COMMON_INFO 和 NET_REAL_DIAGNOSIS_RESULT)
    /// </summary>
    VIDEODIAGNOSIS = 0x00000122,
    /// <summary>
    /// queue detection(Corresponding to NET_DEV_EVENT_QUEUEDETECTION_INFO)
    /// 排队检测报警事件(对应 NET_DEV_EVENT_QUEUEDETECTION_INFO)
    /// </summary>
    QUEUEDETECTION = 0x00000123,
    /// <summary>
    /// take up in bus route(Corresponding to NET_DEV_EVENT_TRAFFIC_VEHICLEINBUSROUTE_INFO)
    /// 占用公交车道事件(对应 NET_DEV_EVENT_TRAFFIC_VEHICLEINBUSROUTE_INFO)
    /// </summary>
    TRAFFIC_VEHICLEINBUSROUTE = 0x00000124,
    /// <summary>
    /// illegal astern(Corresponding to NET_DEV_EVENT_IVS_TRAFFIC_BACKING_INFO) 
    /// 违章倒车事件(对应 NET_DEV_EVENT_IVS_TRAFFIC_BACKING_INFO)
    /// </summary>
    TRAFFIC_BACKING = 0x00000125,
    /// <summary>
    /// audio abnormity(Corresponding to NET_DEV_EVENT_IVS_AUDIO_ABNORMALDETECTION_INFO)
    /// 声音异常检测(对应 NET_DEV_EVENT_IVS_AUDIO_ABNORMALDETECTION_INFO)
    /// </summary>
    AUDIO_ABNORMALDETECTION = 0x00000126,
    /// <summary>
    /// run yellow light(Corresponding to NET_DEV_EVENT_TRAFFIC_RUNYELLOWLIGHT_INFO)
    /// 交通违章-闯黄灯事件(对应 NET_DEV_EVENT_TRAFFIC_RUNYELLOWLIGHT_INFO)
    /// </summary>
    TRAFFIC_RUNYELLOWLIGHT = 0x00000127,
    /// <summary>
    /// climb detection(Corresponding to NET_DEV_EVENT_IVS_CLIMB_INFO) 
    /// 攀高检测事件(对应 NET_DEV_EVENT_IVS_CLIMB_INFO)
    /// </summary>
    CLIMBDETECTION = 0x00000128,
    /// <summary>
    /// leave detection(Corresponding to NET_DEV_EVENT_IVS_LEAVE_INFO)
    /// 离岗检测事件(对应 NET_DEV_EVENT_IVS_LEAVE_INFO)
    /// </summary>
    LEAVEDETECTION = 0x00000129,
    /// <summary>
    /// parking on yellow box(Corresponding to NET_DEV_EVENT_TRAFFIC_PARKINGONYELLOWBOX_INFO)
    /// 黄网格线抓拍事件(对应 NET_DEV_EVENT_TRAFFIC_PARKINGONYELLOWBOX_INFO)
    /// </summary>
    TRAFFIC_PARKINGONYELLOWBOX = 0x0000012A,
    /// <summary>
    /// parking space parking(Corresponding to NET_DEV_EVENT_TRAFFIC_PARKINGSPACEPARKING_INFO)
    /// 车位有车事件(对应 NET_DEV_EVENT_TRAFFIC_PARKINGSPACEPARKING_INFO)
    /// </summary>
    TRAFFIC_PARKINGSPACEPARKING = 0x0000012B,
    /// <summary>
    /// parking space no parking(Corresponding to NET_DEV_EVENT_TRAFFIC_PARKINGSPACENOPARKING_INFO)
    /// 车位无车事件(对应 NET_DEV_EVENT_TRAFFIC_PARKINGSPACENOPARKING_INFO)   
    /// </summary>
    TRAFFIC_PARKINGSPACENOPARKING = 0x0000012C,
    /// <summary>
    /// passerby(Corresponding to NET_DEV_EVENT_TRAFFIC_PEDESTRAIN_INFO)
    /// 交通行人事件(对应 NET_DEV_EVENT_TRAFFIC_PEDESTRAIN_INFO)
    /// </summary>
    TRAFFIC_PEDESTRAIN = 0x0000012D,
    /// <summary>
    /// throw(Corresponding to NET_DEV_EVENT_TRAFFIC_THROW_INFO)
    /// 交通抛洒物品事件(对应 NET_DEV_EVENT_TRAFFIC_THROW_INFO)
    /// </summary>
    TRAFFIC_THROW = 0x0000012E,
    /// <summary>
    /// idle(Corresponding to NET_DEV_EVENT_TRAFFIC_IDLE_INFO)
    /// 交通空闲事件(对应 NET_DEV_EVENT_TRAFFIC_IDLE_INFO)
    /// </summary>
    TRAFFIC_IDLE = 0x0000012F,
    /// <summary>
    /// Vehicle ACC power outage alarm events(Corresponding to NET_DEV_EVENT_ALARM_VEHICLEACC_INFO)
    /// 车载ACC断电报警事件(对应 NET_DEV_EVENT_ALARM_VEHICLEACC_INFO)
    /// </summary>
    ALARM_VEHICLEACC = 0x00000130,
    /// <summary>
    /// Vehicle rollover alarm events(Corresponding to NET_DEV_EVENT_VEHICEL_ALARM_INFO)
    /// 车辆侧翻报警事件(对应 NET_DEV_EVENT_VEHICEL_ALARM_INFO)
    /// </summary>
    ALARM_VEHICLE_TURNOVER = 0x00000131,
    /// <summary>
    /// Vehicle crash alarm events(Corresponding to NET_DEV_EVENT_VEHICEL_ALARM_INFO)
    /// 车辆撞车报警事件(对应 NET_DEV_EVENT_VEHICEL_ALARM_INFO)
    /// </summary>
    ALARM_VEHICLE_COLLISION = 0x00000132,
    /// <summary>
    /// On-board camera large Angle turn events
    /// 车载摄像头大角度扭转事件
    /// </summary>
    ALARM_VEHICLE_LARGE_ANGLE = 0x00000133,
    /// <summary>
    /// Parking line pressing events(Corresponding to NET_DEV_EVENT_TRAFFIC_PARKINGSPACEOVERLINE_INFO)
    /// 车位压线事件(对应 NET_DEV_EVENT_TRAFFIC_PARKINGSPACEOVERLINE_INFO)
    /// </summary>
    TRAFFIC_PARKINGSPACEOVERLINE = 0x00000134,
    /// <summary>
    /// Many scenes switching events(Corresponding to NET_DEV_EVENT_IVS_MULTI_SCENE_SWICH_INFO)
    /// 多场景切换事件(对应 NET_DEV_EVENT_IVS_MULTI_SCENE_SWICH_INFO)
    /// </summary>
    MULTISCENESWITCH = 0x00000135,
    /// <summary>
    /// Limited license plate event(Corresponding to NET_DEV_EVENT_TRAFFIC_RESTRICTED_PLATE)
    /// 受限车牌事件(对应 NET_DEV_EVENT_TRAFFIC_RESTRICTED_PLATE)
    /// </summary>
    TRAFFIC_RESTRICTED_PLATE = 0X00000136,
    /// <summary>
    /// Cross stop line event(Corresponding to NET_DEV_EVENT_TRAFFIC_OVERSTOPLINE)
    /// 压停止线事件(对应 NET_DEV_EVENT_TRAFFIC_OVERSTOPLINE)
    /// </summary>
    TRAFFIC_OVERSTOPLINE = 0X00000137,
    /// <summary>
    /// Traffic unfasten seat belt event(Corresponding to NET_DEV_EVENT_TRAFFIC_WITHOUT_SAFEBELT) 
    /// 交通未系安全带事件(对应 NET_DEV_EVENT_TRAFFIC_WITHOUT_SAFEBELT)
    /// </summary>
    TRAFFIC_WITHOUT_SAFEBELT = 0x00000138,
    /// <summary>
    /// Driver smoking event(Corresponding to NET_DEV_EVENT_TRAFFIC_DRIVER_SMOKING) 
    /// 驾驶员抽烟事件(对应 NET_DEV_EVENT_TRAFFIC_DRIVER_SMOKING)
    /// </summary>
    TRAFFIC_DRIVER_SMOKING = 0x00000139,
    /// <summary>
    /// Driver call event(Corresponding to NET_DEV_EVENT_TRAFFIC_DRIVER_CALLING) 
    /// 驾驶员打电话事件(对应 NET_DEV_EVENT_TRAFFIC_DRIVER_CALLING)
    /// </summary>
    TRAFFIC_DRIVER_CALLING = 0x0000013A,
    /// <summary>
    /// Pedestrain red light(Corresponding to NET_DEV_EVENT_TRAFFIC_PEDESTRAINRUNREDLIGHT_INFO)
    /// 行人闯红灯事件(对应 NET_DEV_EVENT_TRAFFIC_PEDESTRAINRUNREDLIGHT_INFO)
    /// </summary>
    TRAFFIC_PEDESTRAINRUNREDLIGHT = 0x0000013B,
    /// <summary>
    /// Pass not in order(corresponding NET_DEV_EVENT_TRAFFIC_PASSNOTINORDER_INFO)
    /// 未按规定依次通行(对应 NET_DEV_EVENT_TRAFFIC_PASSNOTINORDER_INFO)
    /// </summary>
    TRAFFIC_PASSNOTINORDER = 0x0000013C,
    /// <summary>
    /// Object feature detection event(Corresponding to NET_DEV_EVENT_TRAFFIC_OBJECT_DETECTION) 
    /// 物体特征检测事件 NET_DEV_EVENT_TRAFFIC_OBJECT_DETECTION
    /// </summary>
    OBJECT_DETECTION = 0x00000141,
    /// <summary>
    /// Analog alarm channel?ˉs alarm event(corresponding NET_DEV_EVENT_ALARM_ANALOGALRM_INFO)
    /// 模拟量报警通道的报警事件(对应NET_DEV_EVENT_ALARM_ANALOGALRM_INFO)
    /// </summary>
    ALARM_ANALOGALARM = 0x00000150,
    /// <summary>
    /// Warning lineexpansion event(Corresponding to NET_DEV_EVENT_CROSSLINE_INFO_EX) 
    /// 警戒线扩展事件 NET_DEV_EVENT_CROSSLINE_INFO_EX
    /// </summary>
    CROSSLINEDETECTION_EX = 0x00000151,
    /// <summary>
    /// Normal Record
    /// 普通录像
    /// </summary>
    ALARM_COMMON = 0x00000152,
    /// <summary>
    /// Video tampering event(Corresponding to NET_DEV_EVENT_ALARM_VIDEOBLIND)
    /// 视频遮挡事件(对应 NET_DEV_EVENT_ALARM_VIDEOBLIND)
    /// </summary>
    ALARM_VIDEOBLIND = 0x00000153,
    /// <summary>
    /// Video loss event
    /// 视频丢失事件
    /// </summary>
    ALARM_VIDEOLOSS = 0x00000154,
    /// <summary>
    /// Event of getting out bed detection(Corresponding to NET_DEV_EVENT_GETOUTBED_INFO)
    /// 看守所下床事件(对应 NET_DEV_EVENT_GETOUTBED_INFO)
    /// </summary>
    GETOUTBEDDETECTION = 0x00000155,
    /// <summary>
    /// Event of patrol detection(Corresponding to NET_DEV_EVENT_PATROL_INFO)
    /// 巡逻检测事件(对应 NET_DEV_EVENT_PATROL_INFO)
    /// </summary>
    PATROLDETECTION = 0x00000156,
    /// <summary>
    /// Event of on duty detection(Corresponding to NET_DEV_EVENT_ONDUTY_INFO)
    /// 站岗检测事件(对应 NET_DEV_EVENT_ONDUTY_INFO)
    /// </summary>
    ONDUTYDETECTION = 0x00000157,
    /// <summary>
    /// Event of VTO do not answer calling request
    /// 门口机呼叫未响应事件
    /// </summary>
    NOANSWERCALL = 0x00000158,
    /// <summary>
    /// Event of storage do not exist
    /// 存储组不存在事件
    /// </summary>
    STORAGENOTEXIST = 0x00000159,
    /// <summary>
    /// Event of storage space low
    /// 硬盘空间低报警事件
    /// </summary>
    STORAGELOWSPACE = 0x0000015A,
    /// <summary>
    /// Event of storage failure
    /// 存储错误事件
    /// </summary>
    STORAGEFAILURE = 0x0000015B,
    /// <summary>
    /// Event of profile alarm transmit
    /// 报警传输事件
    /// </summary>
    PROFILEALARMTRANSMIT = 0x0000015C,
    /// <summary>
    /// Event of static video detect(corresponding NET_DEV_EVENT_ALARM_VIDEOSTATIC_INFO)
    /// 视频静态检测事件(对应 NET_DEV_EVENT_ALARM_VIDEOSTATIC_INFO)
    /// </summary>
    VIDEOSTATIC = 0x0000015D,
    /// <summary>
    /// Event of video timing detect(corresponding NET_DEV_EVENT_ALARM_VIDEOTIMING_INFO)
    /// 视频定时检测事件(对应 NET_DEV_EVENT_ALARM_VIDEOTIMING_INFO)
    /// </summary>
    VIDEOTIMING = 0x0000015E,
    /// <summary>
    /// Heat map 
    /// 热度图
    /// </summary>
    HEATMAP = 0x0000015F,
    /// <summary>
    /// ID info reading event (Corresponding to NET_DEV_EVENT_ALARM_CITIZENIDCARD_INFO)
    /// 身份证信息读取事件(对应 NET_DEV_EVENT_ALARM_CITIZENIDCARD_INFO)
    /// </summary>
    CITIZENIDCARD = 0x00000160,
    /// <summary>
    /// Image info event(Corresponding to NET_DEV_EVENT_ALARM_PIC_INFO)
    /// 图片信息事件(对应 NET_DEV_EVENT_ALARM_PIC_INFO)
    /// </summary>
    PICINFO = 0x00000161,
    /// <summary>
    /// NetPlayCheck event(corresponding NET_DEV_EVENT_ALARM_NETPLAYCHECK_INFO)
    /// 上网登记事件(对应 NET_DEV_EVENT_ALARM_NETPLAYCHECK_INFO)
    /// </summary>
    NETPLAYCHECK = 0x00000162,
    /// <summary>
    /// Jam Forbid into  event(corresponding NET_DEV_EVENT_ALARM_JAMFORBIDINTO_INFO)
    /// 车辆拥堵禁入事件(对应 NET_DEV_EVENT_ALARM_JAMFORBIDINTO_INFO)
    /// </summary>
    TRAFFIC_JAM_FORBID_INTO = 0x00000163,
    /// <summary>
    /// Snap by time event(corresponding NET_DEV_EVENT_SNAPBYTIME)
    /// 定时抓图事件(对应NET_DEV_EVENT_SNAPBYTIME)
    /// </summary>
    SNAPBYTIME = 0x00000164,
    /// <summary>
    /// PTZ turn to preset event(corresponding to NET_DEV_EVENT_ALARM_PTZ_PRESET_INFO)
    /// 云台转动到预置点事件(对应 NET_DEV_EVENT_ALARM_PTZ_PRESET_INFO)
    /// </summary>
    PTZ_PRESET = 0x00000165,
    /// <summary>
    /// Event of infrared detect info(corresponding to NET_DEV_EVENT_ALARM_RFID_INFO)
    /// 红外线检测信息事件(对应 NET_DEV_EVENT_ALARM_RFID_INFO)
    /// </summary>
    RFID_INFO = 0x00000166,
    /// <summary>
    /// Event of standing up detection
    /// 人起立检测事件
    /// </summary>
    STANDUPDETECTION = 0X00000167,
    /// <summary>
    /// Event of QSYTrafficCarWeight (corresponding to NET_DEV_EVENT_QSYTRAFFICCARWEIGHT_INFO)
    /// 交通卡口称重事件(对应 NET_DEV_EVENT_QSYTRAFFICCARWEIGHT_INFO)
    /// </summary>
    QSYTRAFFICCARWEIGHT = 0x00000168,
    /// <summary>
    /// Event of compare plate(corresponding to NET_DEV_EVENT_TRAFFIC_COMPAREPLATE_INFO)
    /// 卡口前后车牌合成事件(对应NET_DEV_EVENT_TRAFFIC_COMPAREPLATE_INFO)
    /// </summary>
    TRAFFIC_COMPAREPLATE = 0x00000169,
    /// <summary>
    /// Event of shooting score recognition(corresponding to NET_CFG_IVS_SHOOTINGSCORERECOGNITION_INFO)
    /// 打靶像机事件(对应 NET_CFG_IVS_SHOOTINGSCORERECOGNITION_INFO)
    /// </summary>
    SHOOTINGSCORERECOGNITION = 0x0000016A,
    /// <summary>
    /// 场景变更事件(对应 NET_DEV_ALRAM_SCENECHANGE_INFO,CFG_VIDEOABNORMALDETECTION_INFO)
    /// </summary>
    SCENE_CHANGE = 0x0000016D,
    /// <summary>
    /// Event of presnap analyse(corresponding to NET_DEV_EVENT_TRAFFIC_ANALYSE_PRESNAP_INFO)
    /// 预分析抓拍图片事件(对应 NET_DEV_EVENT_TRAFFIC_ANALYSE_PRESNAP_INFO)
    /// </summary>
    TRAFFIC_ANALYSE_PRESNAP = 0x00000170,
    /// <summary>
    /// All event start with [TRAFFIC](EVENT_IVS_TRAFFICCONTROL to EVENT_TRAFFICSNAPSHOT,EVENT_IVS_TRAFFIC_RUNREDLIGHT to EVENT_IVS_TRAFFIC_UNDERSPEED)
    /// 所有以traffic开头的事件目前指的是EVENT_IVS_TRAFFICCONTROL 到 EVENT_TRAFFICSNAPSHOT,EVENT_IVS_TRAFFIC_RUNREDLIGHT 到 EVENT_IVS_TRAFFIC_UNDERSPEED
    /// </summary>                    
    TRAFFIC_ALL = 0x000001FF,
    /// <summary>
    /// All IVS events 
    /// 所有智能分析事件
    /// </summary>
    VIDEOANALYSE = 0x00000200,
    /// <summary>
    /// LinkSD events(Corresponding to NET_DEV_EVENT_LINK_SD)
    /// LinkSD事件(对应 NET_DEV_EVENT_LINK_SD)
    /// </summary>
    LINKSD = 0x00000201,
    /// <summary>
    /// Vehicle Analyse (Corresponding to NET_DEV_EVENT_VEHICLEANALYSE)
    /// 车辆特征检测分析(对应NET_DEV_EVENT_VEHICLEANALYSE)
    /// </summary>
    VEHICLEANALYSE = 0x00000202,
    /// <summary>
    /// Flow rate events(Corresponding to NET_DEV_EVENT_FLOWRATE_INFO)
    /// 流量使用情况事件(对应 NET_DEV_EVENT_FLOWRATE_INFO)
    /// </summary>
    FLOWRATE = 0x00000203,
    /// <summary>
    /// 门禁事件 (对应 NET_DEV_EVENT_ACCESS_CTL_INFO)
    /// </summary>
    ACCESS_CTL = 0x00000204,
    /// <summary>
    /// SnapManual事件(对应 NET_DEV_EVENT_SNAPMANUAL)
    /// </summary>
    SNAPMANUAL = 0x00000205,
    /// <summary>
    /// RFID电子车牌标签事件(对应 NET_DEV_EVENT_TRAFFIC_ELETAGINFO_INFO)
    /// </summary>
    TRAFFIC_ELETAGINFO = 0x00000206,
    /// <summary>
    /// 生理疲劳驾驶事件(对应 NET_DEV_EVENT_TIREDPHYSIOLOGICAL_INFO)
    /// </summary>
    TRAFFIC_TIREDPHYSIOLOGICAL = 0x00000207,
    /// <summary>
    /// 车辆急转报警事件(对应 NET_DEV_EVENT_BUSSHARPTURN_INFO)
    /// </summary>
    TRAFFIC_BUSSHARPTURN = 0x00000208,
    /// <summary>
    /// 人证比对事件(对应 NET_DEV_EVENT_CITIZEN_PICTURE_COMPARE_INFO)
    /// </summary>
    CITIZEN_PICTURE_COMPARE = 0x00000209,
    /// <summary>
    /// 人体特征事件(对应 NET_DEV_EVENT_HUMANTRAIT_INFO)
    /// </summary>
    HUMANTRAIT = 0x00000215,
    /// <summary>
    /// 左转不礼让直行事件
    /// </summary>
    TRAFFIC_TURNLEFTAFTERSTRAIGHT = 0x00000218,
    /// <summary>
    /// 大弯小转事件
    /// </summary>
    TRAFFIC_BIGBENDSMALLTURN = 0x00000219,
    /// <summary>
    /// 车辆加塞事件
    /// </summary>
    TRAFFIC_QUEUEJUMP = 0x0000021C,
    /// <summary>
    /// 右转不礼让直行事件
    /// </summary>
    TRAFFIC_TURNRIGHTAFTERSTRAIGHT = 0x0000021E,
    /// <summary>
    /// 右转不礼让直行行人
    /// </summary>
    TRAFFIC_TURNRIGHTAFTERPEOPLE = 0x0000021F,
    /// <summary>
    /// 远光灯违章事件
    /// </summary>
    TRAFFIC_HIGH_BEAM = 0x00000228,
    /// <summary>
    /// 违章进入待行区
    /// </summary>
    TRAFFIC_WAITINGAREA = 0x00000234,
    /// <summary>
    /// 火警事件(对应 NET_DEV_EVENT_FIREWARNING_INFO)
    /// </summary>
    FIREWARNING = 0x00000243,
  }

  public struct NET_DEV_EVENT_FIRE_INFO
  {
    /// <summary>
    /// 通道号
    /// Channel Id
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件名称
    /// event name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 字节对齐
    /// byte alignment
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// PTS(ms)
    /// </summary>
    public double PTS;
    /// <summary>
    /// 事件发生的时间
    /// the event happen time
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// 事件ID
    /// event ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// 检测到的物体
    /// have being detected object
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// 事件对应文件信息
    /// event file info
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// 保留字节
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte byReserved;
    /// <summary>
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// 规则检测区域顶点数
    /// 
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// 规则检测区域
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT DetectRegion;
    /// <summary>
    /// 抓图标志(按位),具体见 NET_RESERVED_COMMON
    /// 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// 事件源设备上的index,-1表示数据无效
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// 智能事件公共信息
    /// 
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// 保留字节,留待扩展.
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 488)]
    public byte bReserved;
  }

  /// <summary>
  /// (烟雾报警事件)对应的数据块描述信息
  /// 
  /// </summary>
  public struct NET_DEV_EVENT_SMOKE_INFO
  {
    /// <summary>
    /// 通道号
    /// 
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件名称
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 字节对齐
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// 
    /// </summary>
    public double PTS;
    /// <summary>
    /// 事件发生的时间
    /// 
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// 事件ID
    /// 
    /// </summary>
    public int nEventID;
    /// <summary>
    /// 检测到的物体
    /// 
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// 事件对应文件信息
    /// 
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    /// 
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// 保留
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// 
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON   
    /// 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// 事件触发累计次数
    /// 
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// 智能事件公共信息
    /// 
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// 云台的坐标和放大倍数
    /// 
    /// </summary>
    public NET_PTZ_SPACE_UNIT stuPtzPosition;
    /// <summary>
    /// 保留字节,留待扩展.
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 792)]
    public byte[] bReserved;
  }
  // 事件扩展信息
  public struct NET_EXTENSION_INFO
  {
    /// <summary>
    /// 国标事件ID
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 52)]
    public string szEventID;
    /// <summary>
    /// 保留字节
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
    public byte[] byReserved;
  }
  public struct NET_DEV_EVENT_CITIZEN_PICTURE_COMPARE_INFO
  {
    /// 公共字段
    /// <summary>
    /// 通道号,从0开始
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件动作, 0表示脉冲, -1表示未知
    /// </summary>
    public int nEventAction;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double dbPTS;
    /// <summary>
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX stuUTC;
    /// <summary>
    /// 事件ID
    /// </summary>
    public int nEventID;

    //事件对应字段
    /// <summary>
    /// 人证比对结果,相似度大于等于阈值认为比对成功,true表示成功,false表示失败
    /// </summary>
    [MarshalAs(UnmanagedType.I1)]
    public bool bCompareResult;
    /// <summary>
    /// 两张图片的相似度,单位百分比,范围[1,100]
    /// </summary>
    public byte nSimilarity;
    /// <summary>
    /// 检测阈值,范围[1,100]
    /// </summary>
    public byte nThreshold;
    /// <summary>
    /// 性别
    /// </summary>
    public EM_CITIZENIDCARD_SEX_TYPE emSex;
    /// <summary>
    /// 民族
    /// 0 无效数据
    /// 1 汉族
    /// 2 蒙古族
    /// 3 回族
    /// 4 藏族
    /// 5 维吾尔族
    /// 6 苗族
    /// 7 彝族
    /// 8 壮族
    /// 9 布依族
    /// 10 朝鲜族
    /// 11 满族
    /// 12 侗族
    /// 13 瑶族
    /// 14 白族
    /// 15 土家族
    /// 16 哈尼族
    /// 17 哈萨克族
    /// 18 傣族
    /// 19 黎族
    /// 20 傈僳族
    /// 21 佤族
    /// 22 畲族
    /// 23 高山族
    /// 24 拉祜族
    /// 25 水族
    /// 26 东乡族
    /// 27 纳西族
    /// 28 景颇族
    /// 29 柯尔克孜族
    /// 30 土族
    /// 31 达斡尔族
    /// 32 仫佬族
    /// 33 羌族
    /// 34 布朗族
    /// 35 撒拉族
    /// 36 毛南族
    /// 37 仡佬族
    /// 38 锡伯族
    /// 39 阿昌族
    /// 40 普米族
    /// 41 塔吉克族
    /// 42 怒族
    /// 43 乌孜别克族
    /// 44 俄罗斯族
    /// 45 鄂温克族
    /// 46 德昂族
    /// 47 保安族
    /// 48 裕固族
    /// 49 京族
    /// 50 塔塔尔族
    /// 51 独龙族
    /// 52 鄂伦春族
    /// 53 赫哲族
    /// 54 门巴族
    /// 55 珞巴族
    /// 56 基诺族
    /// </summary>
    public int nEthnicity;

    /// <summary>
    /// 居民姓名    
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCitizen;
    /// <summary>
    /// 住址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szAddress;
    /// <summary>
    /// 身份证号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szNumber;
    /// <summary>
    /// 签发机关
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szAuthority;
    /// <summary>
    /// 出生日期(年月日)
    /// </summary>
    public NET_TIME stuBirth;
    /// <summary>
    /// 有效期限起始日期(年月日)
    /// </summary>
    public NET_TIME stuValidityStart;
    /// <summary>
    /// 该值为 TRUE, 截止日期 表示长期有效,此时 stuValidityEnd 值无意义;该值为 FALSE, 此时 截止日期 查看 stuValidityEnd 值
    /// </summary>
    public bool bLongTimeValidFlag;
    /// <summary>
    /// 有效期限结束日期(年月日)
    /// </summary>
    public NET_TIME stuValidityEnd;
    /// <summary>
    /// 图片信息，第一张为拍摄照片，第二张为身份证照片
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public CITIZEN_PICTURE_COMPARE_IMAGE_INFO[] stuImageInfo;
    /// <summary>
    /// IC卡号
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// 手机号（比对时先输入手机号）
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
    public string szCellPhone;
    /// <summary>
    /// 扩展信息
    /// 
    /// </summary>
    public NET_EXTENSION_INFO stuExtensionInfo;
    /// <summary>
    /// 扩展图片信息
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public CITIZEN_PICTURE_COMPARE_IMAGE_INFO_EX[] stuImageInfoEx;
    /// <summary>
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 360)]
    public byte[] byReserved;
  }

  /// <summary>
  /// 人证对比图片信息
  /// </summary>
  public struct CITIZEN_PICTURE_COMPARE_IMAGE_INFO
  {
    /// <summary>
    /// 文件在二进制数据块中的偏移位置, 单位:字节
    /// </summary>
    public uint dwOffSet;
    /// <summary>
    /// 文件大小, 单位:字节
    /// </summary>
    public uint dwFileLenth;
    /// <summary>
    /// 图片宽度, 单位:像素
    /// </summary>
    public ushort wWidth;
    /// <summary>
    /// 图片高度, 单位:像素
    /// </summary>
    public ushort wHeight;
    /// <summary>
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] byReserved;
  }

  /// <summary>
  /// 人脸图类型
  /// 
  /// </summary>
  public enum NET_EM_CITIZEN_PICTURE_COMPARE_TYPE
  {
    /// <summary>
    /// 未知
    /// 
    /// </summary>
    UNKNOWN = -1,
    /// <summary>
    /// 本地人脸库图
    /// 
    /// </summary>
    LOCAL,
    /// <summary>
    /// 人脸抠图
    /// 
    /// </summary>
    FACEMAP,
  }
  /// <summary>
  /// 人证对比扩展图片信息
  /// 
  /// </summary>
  public struct CITIZEN_PICTURE_COMPARE_IMAGE_INFO_EX
  {
    /// <summary>
    /// 人脸图类型
    /// 
    /// </summary>
    public NET_EM_CITIZEN_PICTURE_COMPARE_TYPE emType;
    /// <summary>
    /// 文件在二进制数据块中的偏移位置, 单位:字节
    /// 
    /// </summary>
    public uint dwOffSet;
    /// <summary>
    /// 文件大小, 单位:字节
    /// 
    /// </summary>
    public uint dwFileLenth;
    /// <summary>
    /// 图片宽度, 单位:像素
    /// 
    /// </summary>
    public ushort wWidth;
    /// <summary>
    /// 图片高度, 单位:像素
    /// 
    /// </summary>
    public ushort wHeight;
    /// <summary>
    /// 保留字节
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] byReserved;
  }

  public enum EM_CITIZENIDCARD_SEX_TYPE
  {
    UNKNOWN,          // 未知
    MALE,             // 男
    FEMALE,           // 女
    UNTOLD,           // 未说明   
  }

  // 人体图片信息
  public struct NET_HUMAN_IMAGE_INFO
  {
    public uint nOffSet;                   // 偏移 		
    public uint nLength;                   // 图片大小,单位字节
    public uint nWidth;                    // 图片宽度
    public uint nHeight;                   // 图片高度
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public byte[] byReserved;            // 预留字节
  }

  // 人脸图片信息
  public struct NET_FACE_IMAGE_INFO
  {
    public uint nOffSet;                   // 偏移 		
    public uint nLength;                   // 图片大小,单位字节
    public uint nWidth;                    // 图片宽度
    public uint nHeight;                   // 图片高度
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public byte[] byReserved;            // 预留字节
  }

  // 全景广角图
  public struct NET_SCENE_IMAGE_INFO
  {
    public uint nOffSet;                   // 偏移 		
    public uint nLength;                   // 图片大小,单位字节
    public uint nWidth;                    // 图片宽度
    public uint nHeight;                   // 图片高度
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public byte[] byReserved;            // 预留字节
  }

  // 人脸全景图
  public struct NET_FACE_SCENE_IMAGE
  {
    public uint nOffSet;                   // 偏移 		
    public uint nLength;                   // 图片大小,单位字节
    public uint nWidth;                    // 图片宽度
    public uint nHeight;                   // 图片高度
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 56)]
    public byte[] byReserved;            // 预留字节
  }

  // 检测到的人的信息
  public enum EM_DETECT_OBJECT
  {
    UNKNOWN,                   // 未知信息
    HUMAN_BODY_AND_FACE,       // 人体和人脸都有
    HUMAN_BODY,                // 仅有人体
    HUMAN_FACE,             // 仅有人脸
  }

  // 衣服颜色
  public enum EM_CLOTHES_COLOR
  {
    UNKNOWN,       // 未知
    WHITE,         // 白色
    ORANGE,        // 橙色
    PINK,          // 粉色
    BLACK,         // 黑色
    RED,           // 红色
    YELLOW,        // 黄色
    GRAY,          // 灰色
    BLUE,          // 蓝色
    GREEN,         // 绿色 
    PURPLE,        // 紫色
    BROWN,         // 棕色
  }

  //上衣类型
  public enum EM_COAT_TYPE
  {
    UNKNOWN,           // 未知
    LONG_SLEEVE,       // 长袖
    COTTA,             // 短袖
  }

  // 裤子类型
  public enum EM_TROUSERS_TYPE
  {
    UNKNOWN,       // 未知
    TROUSERS,      // 长裤
    SHORTS,        // 短裤
    SKIRT,         // 裙子
  }

  // 是否戴帽子
  public enum EM_HAS_HAT
  {
    UNKNOWN,             // 未知
    NO,                  // 不戴帽子
    YES,                 // 戴帽子
  }

  // 是否戴包(包括背包或拎包)
  public enum EM_HAS_BAG
  {
    UNKNOWN,             // 未知
    NO,                  // 不带包
    YES,                 // 带包
  }

  // 人体属性信息
  public struct NET_HUMAN_ATTRIBUTES_INFO
  {
    public EM_CLOTHES_COLOR emCoatColor;                                   // 上衣颜色
    public EM_COAT_TYPE emCoatType;                                        // 上衣类型
    public EM_CLOTHES_COLOR emTrousersColor;                               // 裤子颜色
    public EM_TROUSERS_TYPE emTrousersType;                                    // 裤子类型
    public EM_HAS_HAT emHasHat;                                        // 是否戴帽子
    public EM_HAS_BAG emHasBag;                                        // 是否带包
    public NET_RECT stuBoundingBox;                                    // 包围盒(8192坐标系)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
    public byte[] byReserved;                               // 预留字节
  }

  // 肤色
  public enum EM_COMPLEXION_TYPE
  {
    NODISTI,              // 未识别
    YELLOW,               // 黄
    BLACK,                // 黑
    WHITE,                // 白
  }
  // 人脸属性
  public struct NET_FACE_ATTRIBUTE
  {
    public EM_DEV_EVENT_FACEDETECT_SEX_TYPE emSex;                     // 性别
    public int nAge;                       // 年龄,-1表示该字段数据无效
    public uint nFeatureValidNum;           // 人脸特征数组有效个数,与 emFeature 结合使用
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE[] emFeatures;   // 人脸特征数组,与 nFeatureValidNum 结合使用
    public EM_COMPLEXION_TYPE emComplexion;                // 肤色
    public EM_EYE_STATE_TYPE emEye;                        // 眼睛状态
    public EM_MOUTH_STATE_TYPE emMouth;                    // 嘴巴状态
    public EM_MASK_STATE_TYPE emMask;                      // 口罩状态
    public EM_BEARD_STATE_TYPE emBeard;                    // 胡子状态
    public int nAttractive;                // 魅力值, 0未识别，识别时范围1-100,得分高魅力高
    public NET_RECT stuBoundingBox;                // 包围盒(8192坐标系)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 112)]
    public byte[] bReserved;             // 保留字节,留待扩展.
  }

  // 当前人体特征是由什么事件产生的
  public struct NET_HUMANTRAIT_EXTENSION_INFO
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public string szAdditionalCode;                           // 当前人体特征是由什么事件产生的,设备刚好返回32个字节数据，多加4个字节用于字节对齐和添加字符结束符
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] byReserved;                                 // 保留字节
  }

  /// <summary>
  /// 事件类型 EVENT_IVS_HUMANTRAIT(人体特征事件)对应的数据块描述信息 
  /// </summary>
  public struct NET_DEV_EVENT_HUMANTRAIT_INFO
  {
    public int nChannelID;                                   // 通道号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;                   // 事件名称
    public int nEventID;                                     // 事件ID
    public double PTS;                                          // 时间戳(单位是毫秒)
    public NET_TIME_EX UTC;                                          // 事件发生的时间
    public int nAction;                                      // 1:开始 2:停止
    public EM_CLASS_TYPE emClassType;                                // 智能事件所属大类
    public int nGroupID;                                     // 事件组ID，一次检测的多个人体特征nGroupID相同
    public int nCountInGroup;                                // 一个事件组内的抓拍张数(人体个数),一次检测的多个人体特征nCountInGroup相同
    public int nIndexInGroup;                                // 一个事件组内的抓拍序号，从1开始
    public NET_HUMAN_IMAGE_INFO stuHumanImage;                               // 人体图片信息
    public NET_FACE_IMAGE_INFO stuFaceImage;                                 // 人脸图片信息
    public EM_DETECT_OBJECT emDetectObject;                                  // 检测到的人的信息
    public NET_HUMAN_ATTRIBUTES_INFO stuHumanAttributes;                         // 人体属性
    public NET_SCENE_IMAGE_INFO stuSceneImage;                                // 全景大图信息
    public NET_FACE_ATTRIBUTE stuFaceAttributes;                             // 人脸属性
    public NET_FACE_SCENE_IMAGE stuFaceSceneImage;                           // 人脸全景图
    public NET_EXTENSION_INFO stuExtensionInfo;                             // 扩展信息
    public NET_HUMANTRAIT_EXTENSION_INFO stuHumanTrait;                    // 补充事件，表示当前人体特征是由该事件产生的
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 88)]
    public byte[] byReserved;                                  // 保留字节,留待扩展.
  }

  /// <summary>
  /// catch a figure type CLIENT_CapturePictureEx interface using
  /// 抓图类型
  /// </summary>
  public enum EM_NET_CAPTURE_FORMATS
  {
    /// <summary>
    /// BMP
    /// BMP
    /// </summary>
    BMP,
    /// <summary>
    /// 100% quality JPEG
    /// 100%质量的JPEG
    /// </summary>
    JPEG,
    /// <summary>
    /// 70% quality JPEG
    /// 70%质量的JPEG
    /// </summary>
    JPEG_70,
    /// <summary>
    /// 50% quality JPEG
    /// 50%质量的JPEG
    /// </summary>                       
    JPEG_50,
    /// <summary>
    /// 30% quality JPEG
    /// 30%质量的JPEG
    /// </summary>
    JPEG_30,
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_RUNREDLIGHT's data
  /// 交通-闯红灯事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_RUNREDLIGHT_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 对像信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// state of traffic light 0:unknown 1:green 2:red 3:yellow
    /// 红绿灯状态 0:未知 1：绿灯 2:红灯 3:黄灯
    /// </summary>
    public int nLightState;
    /// <summary>
    /// speed,km/h
    /// 车速,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// snap index,such as 3,2,1,1 means the last one,0 means there has eption and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end;
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留，字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位)
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// time of red light starting
    /// 红灯开始时间
    /// </summary>
    public NET_TIME_EX stRedLightUTC;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// red light margin
    /// 红灯容许间隔时间,单位：秒
    /// </summary>
    public byte byRedLightMargin;
    /// <summary>
    /// Align string
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byAlignment;
    /// <summary>
    /// Red light period. The unit is ms. 
    /// 表示红灯周期时间,单位毫秒
    /// </summary>
    public int nRedLightPeriod;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 928)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }
  /// <summary>
  /// 火警事件
  /// </summary>
  public struct NET_DEV_EVENT_FIREWARNING_INFO
  {
    /// <summary>
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 1:开始 2:停止
    /// </summary>
    public int nAction;
    /// <summary>
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byReserved;
  }
  /// <summary>
  /// time struct
  /// 时间信息结构体
  /// </summary>
  public struct NET_TIME_EX
  {
    /// <summary>
    /// Year
    /// 年
    /// </summary>
    public uint dwYear;
    /// <summary>
    /// Month
    /// 月
    /// </summary>
    public uint dwMonth;
    /// <summary>
    /// Day
    /// 日
    /// </summary>
    public uint dwDay;
    /// <summary>
    /// Hour
    /// 时
    /// </summary>
    public uint dwHour;
    /// <summary>
    /// Minute
    /// 分
    /// </summary>
    public uint dwMinute;
    /// <summary>
    /// Second
    /// 秒
    /// </summary>
    public uint dwSecond;
    /// <summary>
    /// Millisecond
    /// 毫秒
    /// </summary>
    public uint dwMillisecond;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public uint[] dwReserved;

    /// <summary>
    /// override tostring function
    /// 重写tostring函数
    /// </summary>
    /// <returns>timer string</returns>
    public override string ToString()
    {
      return string.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}", dwYear.ToString("D4"), dwMonth.ToString("D2"), dwDay.ToString("D2"), dwHour.ToString("D2"), dwMinute.ToString("D2"), dwSecond.ToString("D2"), dwMillisecond.ToString("D3"));
    }

    public string ToShortString()
    {
      return string.Format("{0}-{1}-{2} {3}:{4}:{5}", dwYear.ToString("D4"), dwMonth.ToString("D2"), dwDay.ToString("D2"), dwHour.ToString("D2"), dwMinute.ToString("D2"), dwSecond.ToString("D2"));
    }

    public DateTime ToDateTime()
    {
      try
      {
        return new DateTime((int)dwYear, (int)dwMonth, (int)dwDay, (int)dwHour, (int)dwMinute, (int)dwSecond, (int)dwMillisecond);
      }
      catch
      {
        return DateTime.Now;
      }
    }
  }

  /// <summary>
  /// Struct of object info for video analysis,4-byte alignment
  /// 物体信息结构体,强制4字节对齐
  /// </summary>
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
  public struct NET_MSG_OBJECT
  {
    /// <summary>
    /// Object ID,each ID represent a unique object
    /// 物体ID,每个ID表示一个唯一的物体
    /// </summary>
    public int nObjectID;
    /// <summary>
    /// Object type
    /// 物体类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szObjectType;
    /// <summary>
    /// Confidence(0~255),a high value indicate a high confidence
    /// 置信度(0~255),值越大表示置信度越高
    /// </summary>
    public int nConfidence;
    /// <summary>
    /// Object action:1:Appear 2:Move 3:Stay 4:Remove 5:Disappear 6:Split 7:Merge 8:Rename
    /// 物体动作:1:Appear 2:Move 3:Stay 4:Remove 5:Disappear 6:Split 7:Merge 8:Rename
    /// </summary>
    public int nAction;
    /// <summary>
    /// BoundingBox
    /// 包围盒
    /// </summary>
#if (LINUX_X64)
		public NET_RECT_LONG_TYPE                   BoundingBox;		     
#else
    public NET_RECT BoundingBox;
#endif
    /// <summary>
    /// The shape center of the object
    /// 物体型心
    /// </summary>
    public NET_POINT Center;
    /// <summary>
    /// the number of culminations for the polygon
    /// 多边形顶点个数
    /// </summary>
    public int nPolygonNum;
    /// <summary>
    /// a polygon that have a exactitude figure
    /// 较精确的轮廓多边形
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_POINT[] Contour;
    /// <summary>
    /// The main color of the object;the first byte indicate red value, as byte order as green, blue, transparence, for example:RGB(0,255,0),transparence = 0, rgbaMainColor = 0x00ff0000.
    /// 表示车牌、车身等物体主要颜色；按字节表示,分别为红、绿、蓝和透明度,例如:RGB值为(0,255,0),透明度为0时, 其值为0x00ff0000.
    /// </summary>
    public uint rgbaMainColor;
    /// <summary>
    /// the interrelated text of object,such as number plate,container number
    /// 物体上相关的带0结束符文本,比如车牌,集装箱号等等
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szText;
    /// <summary>
    /// object sub type,different object type has different sub type:Vehicle Category:"Unknown","Motor","Non-Motor","Bus","Bicycle","Motorcycle";Plate Category:"Unknown","mal","Yellow","DoubleYellow","Police","Armed"
    /// 物体子类别,根据不同的物体类型,可以取以下子类型:Vehicle Category:"Unknown"  未知,"Motor" 机动车,"Non-Motor":非机动车,"Bus": 公交车;Plate Category："Unknown" 未知,"Normal" 蓝牌黑牌,"Yellow" 黄牌,"DoubleYellow" 双层黄尾牌,"Police" 警牌"Armed" 武警牌
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szObjectSubType;
    /// <summary>
    /// Specifies the sub-brand of vehicle,the real value can be found in a mapping table from the development manual
    /// 车辆子品牌 需要通过映射表得到真正的子品牌 映射表详见开发手册
    /// </summary>
    public ushort wSubBrand;
    /// <summary>
    /// reserved
    /// 保留，字节对齐
    /// </summary>
    public byte byReserved1;
    /// <summary>
    /// picture info enable
    /// 是否有物体对应图片文件信息
    /// </summary>
    public byte bPicEnble;
    /// <summary>
    /// picture info
    /// 物体对应图片信息
    /// </summary>
    public NET_PIC_INFO stPicInfo;
    /// <summary>
    /// is shot frame
    /// 是否是抓拍张的识别结果
    /// </summary>
    public byte bShotFrame;
    /// <summary>
    /// rgbaMainColor is enable
    /// 物体颜色(rgbaMainColor)是否可用
    /// </summary>
    public byte bColor;
    /// <summary>
    /// Reserved
    /// 保留，字节对齐
    /// </summary>
    public byte byReserved2;
    /// <summary>
    /// Time indicates the type of detailed instructions,EM_TIME_TYP
    /// 时间表示类型,详见EM_TIME_TYPE说明
    /// </summary>
    public byte byTimeType;
    /// <summary>
    /// in view of the video compression,current time(when object snap or reconfnition, the frame will be attached to the frame in a video or pictures,means the frame in the original video of the time)
    /// 针对视频浓缩,当前时间戳（物体抓拍或识别时,会将此识别智能帧附在一个视频帧或jpeg图片中,此帧所在原始视频中的出现时间）
    /// </summary>
    public NET_TIME_EX stuCurrentTime;
    /// <summary>
    /// strart time(object appearing for the first time)
    /// 开始时间戳（物体开始出现时）
    /// </summary>
    public NET_TIME_EX stuStartTime;
    /// <summary>
    /// end time(object appearing for the last time) 
    /// 结束时间戳（物体最后出现时）
    /// </summary>
    public NET_TIME_EX stuEndTime;
#if (LINUX_X64)
		public NET_RECT_LONG_TYPE                   stuOriginalBoundingBox;	
        public NET_RECT_LONG_TYPE                   stuSignBoundingBox;	    
#else
    /// <summary>
    /// original bounding box(absolute coordinates)
    /// 包围盒(绝对坐标)
    /// </summary>
    public NET_RECT stuOriginalBoundingBox;
    /// <summary>
    /// sign bounding box coordinate
    /// 车标坐标包围盒
    /// </summary>
    public NET_RECT stuSignBoundingBox;
#endif
    /// <summary>
    /// The current frame number (frames when grabbing the object)
    /// 当前帧序号（抓下这个物体时的帧）
    /// </summary>
    public uint dwCurrentSequence;
    /// <summary>
    /// Start frame number (object appeared When the frame number
    /// 开始帧序号（物体开始出现时的帧序号）
    /// </summary>
    public uint dwBeginSequence;
    /// <summary>
    /// The end of the frame number (when the object disappearing Frame number)
    /// 结束帧序号（物体消逝时的帧序号）
    /// </summary>
    public uint dwEndSequence;
    /// <summary>
    /// At the beginning of the file offset, Unit: Word Section (when objects began to appear, the video frames in the original video file offset relative to the beginning of the file
    /// 开始时文件偏移, 单位: 字节（物体开始出现时,视频帧在原始视频文件中相对于文件起始处的偏移）
    /// </summary>
    public Int64 nBeginFileOffset;
    /// <summary>
    /// At the end of the file offset, Unit: Word Section (when the object disappeared, video frames in the original video file offset relative to the beginning of the file)
    /// 结束时文件偏移, 单位: 字节（物体消逝时,视频帧在原始视频文件中相对于文件起始处的偏移）
    /// </summary>
    public Int64 nEndFileOffset;
    /// <summary>
    /// Object color similarity, the range :0-100, represents an array subscript Colors, see EM_COLOR_TYPE
    /// 物体颜色相似度,取值范围：0-100,数组下标值代表某种颜色,详见EM_COLOR_TYPE
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byColorSimilar;
    /// <summary>
    /// When upper body color similarity (valid object type man )
    /// 上半身物体颜色相似度(物体类型为人时有效)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byUpperBodyColorSimilar;
    /// <summary>
    /// Lower body color similarity when objects (object type human valid )
    /// 下半身物体颜色相似度(物体类型为人时有效)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byLowerBodyColorSimilar;
    /// <summary>
    /// ID of relative object
    /// 相关物体ID
    /// </summary>
    public int nRelativeID;
    /// <summary>
    /// "ObjectType"is "Vehicle" or "Logo" means a certain brand under LOGO such as Audi A6L since there are so many brands SDK sends this field in real-time ,device filled as real.
    /// "ObjectType"为"Vehicle"或者"Logo"时,表示车标下的某一车系,比如奥迪A6L,由于车系较多,SDK实现时透传此字段,设备如实填写
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public byte[] szSubText;
    /// <summary>
    /// Specifies the model years of vehicle. the real value can be found in a mapping table from the development manual 
    /// 车辆品牌年款 需要通过映射表得到真正的年款 映射表详见开发手册
    /// </summary>
    public ushort wBrandYear;
  }

  /// <summary>
  /// enum time type
  /// 时间类型
  /// </summary>
  public enum EM_TIME_TYPE
  {
    /// <summary>
    /// absolute time 
    /// 绝对时间
    /// </summary>
    ABSLUTE,
    /// <summary>
    /// Relative time, relative to the video file header frame as the time basis points, the first frame corresponding to the UTC (0000-00-00 00:00:00)
    /// 相对时间,相对于视频文件头帧为时间基点,头帧对应于UTC(0000-00-00 00:00:00)
    /// </summary>
    RELATIVE,
  }

  /// <summary>
  /// enum color type
  /// 颜色类型
  /// </summary>
  public enum EM_COLOR_TYPE
  {
    /// <summary>
    /// red
    /// 红色
    /// </summary>
    RED,
    /// <summary>
    /// yellow
    /// 黄色
    /// </summary>
    YELLOW,
    /// <summary>
    /// green
    /// 绿色
    /// </summary>
    GREEN,
    /// <summary>
    /// cyan
    /// 青色
    /// </summary>
    CYAN,
    /// <summary>
    /// glue
    /// 蓝色
    /// </summary>
    BLUE,
    /// <summary>
    /// purple
    /// 紫色
    /// </summary>
    PURPLE,
    /// <summary>
    /// black
    /// 黑色
    /// </summary>
    BLACK,
    /// <summary>
    /// white
    /// 白色
    /// </summary>
    WHITE,
    /// <summary>
    /// max
    /// 最大值
    /// </summary>
    MAX,
  }

  /// <summary>
  /// rect size struct
  /// 矩形大小
  /// </summary>
  public struct NET_RECT
  {
    /// <summary>
    /// left
    /// 左
    /// </summary>
    public int nLeft;
    /// <summary>
    /// top
    /// 上
    /// </summary>
    public int nTop;
    /// <summary>
    /// right
    /// 右
    /// </summary>
    public int nRight;
    /// <summary>
    /// bottom
    /// 下
    /// </summary>
    public int nBottom;
  }

  /// <summary>
  /// rect size struct for linux x64
  /// Linux64平台下矩形大小
  /// </summary>
  public struct NET_RECT_LONG_TYPE
  {
    /// <summary>
    /// left
    /// 左
    /// </summary>
    public long nLeft;
    /// <summary>
    /// top
    /// 上
    /// </summary>
    public long nTop;
    /// <summary>
    /// right
    /// 右
    /// </summary>
    public long nRight;
    /// <summary>
    /// bottom
    /// 下
    /// </summary>
    public long nBottom;
  }

  /// <summary>
  /// dimension point struct
  /// 坐标点
  /// </summary>
  public struct NET_POINT
  {
    /// <summary>
    /// x
    /// 坐标x
    /// </summary>
    public short nx;
    /// <summary>
    /// y
    /// 坐标y
    /// </summary>
    public short ny;
  }

  /// <summary>
  /// picture information struct
  /// 图片信息
  /// </summary>
  public struct NET_PIC_INFO
  {
    /// <summary>
    /// current picture file's offset in the binary file, byte
    /// 文件在二进制数据块中的偏移位置, 单位:字节
    /// </summary>
    public uint dwOffSet;
    /// <summary>
    /// current picture file's size, byte
    /// 文件大小, 单位:字节
    /// </summary>
    public uint dwFileLenth;
    /// <summary>
    /// picture width, pixel
    /// 图片宽度, 单位:像素
    /// </summary>
    public ushort wWidth;
    /// <summary>
    /// picture high, pixel
    /// 图片高度, 单位:像素
    /// </summary>
    public ushort wHeight;
    /// <summary>
    /// File path,User use this field need to apply for space for copy and storage
    /// 文件路径，用户使用该字段时需要自行申请空间进行拷贝保存
    /// </summary>
    public IntPtr pszFilePath;
    /// <summary>
    /// When submit to the server, the algorithm has checked the image or not 
    /// 图片是否算法检测出来的检测过的提交识别服务器时
    /// </summary>
    public byte bIsDetected;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved;
    /// <summary>
    /// pszFilePath length
    /// </summary>
    public int nFilePathLen;
    /// <summary>
    /// The upper left corner of the figure is in the big picture. Absolute coordinates are used
    /// 小图左上角在大图的位置，使用绝对坐标系
    /// </summary>
    public NET_POINT stuPoint;
  }

  /// <summary>
  /// event file information struct
  /// 事件对应文件信息
  /// </summary>
  public struct NET_EVENT_FILE_INFO
  {
    /// <summary>
    /// the file count in the current file's group
    /// 当前文件所在文件组中的文件总数
    /// </summary>
    public byte bCount;
    /// <summary>
    /// the index of the file in the group
    /// 当前文件在文件组中的文件编号(编号1开始)
    /// </summary>
    public byte bIndex;
    /// <summary>
    /// file tag, see the enum EM_EVENT_FILETAG
    /// 文件标签, EM_EVENT_FILETAG
    /// </summary>
    public byte bFileTag;
    /// <summary>
    /// file type,0-normal 1-compose 2-cut picture
    /// 文件类型,0-普通 1-合成 2-抠图
    /// </summary>
    public byte bFileType;
    /// <summary>
    /// file time
    /// 文件时间
    /// </summary>
    public NET_TIME_EX stuFileTime;
    /// <summary>
    /// the only id of one group file
    /// 同一组抓拍文件的唯一标识
    /// </summary>
    public uint nGroupId;
  }

  /// <summary>
  /// event file's tag type
  /// 事件文件的文件标签类型
  /// </summary>
  public enum EM_EVENT_FILETAG
  {
    /// <summary>
    /// Before ATM Paste
    /// ATM贴条前
    /// </summary>
    NET_ATMBEFOREPASTE = 1,
    /// <summary>
    /// After ATM Paste
    /// ATM贴条后
    /// </summary>
    NET_ATMAFTERPASTE,
  }

  /// <summary>
  /// picture resolution struct
  /// 图片分辨率
  /// </summary>
  public struct NET_RESOLUTION_INFO
  {
    /// <summary>
    /// width
    /// 宽
    /// </summary>
    public ushort snWidth;
    /// <summary>
    /// hight
    /// 高
    /// </summary>
    public ushort snHight;
  }

  /// <summary>
  /// trafficCar event information struct
  /// 交通车辆信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO
  {
    /// <summary>
    /// plate number
    /// 车牌号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumber;
    /// <summary>
    /// plate type
    /// 号牌类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateType;
    /// <summary>
    /// plate color, "Blue","Yellow", "White","Black"
    /// 车牌颜色
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateColor;
    /// <summary>
    /// vehicle color, "White", "Black", "Red", "Yellow", "Gray", "Blue","Green"
    /// 车身颜色
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szVehicleColor;
    /// <summary>
    /// speed, Km/H
    /// 速度    单位Km/H
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// trigger event type
    /// 触发的相关事件
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szEvent;
    /// <summary>
    /// violation code, see TrafficGlobal.ViolationCode
    /// 违章代码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szViolationCode;
    /// <summary>
    /// violation describe
    /// 违章描述
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szViolationDesc;
    /// <summary>
    /// lower speed limit
    /// 速度下限
    /// </summary>
    public int nLowerSpeedLimit;
    /// <summary>
    /// upper speed limit
    /// 速度上限
    /// </summary>
    public int nUpperSpeedLimit;
    /// <summary>
    /// over speed margin, km/h 
    /// 限高速宽限值    单位：km/h 
    /// </summary>
    public int nOverSpeedMargin;
    /// <summary>
    /// under speed margin, km/h 
    /// 限低速宽限值    单位：km/h
    /// </summary>
    public int nUnderSpeedMargin;
    /// <summary>
    /// lane
    /// 车道
    /// </summary>
    public int nLane;
    /// <summary>
    /// vehicle size type
    /// 车辆大小类型
    /// </summary>
    public EM_VehicleSizeType nVehicleSize;
    /// <summary>
    /// vehicle length, m
    /// 车辆长度    单位米
    /// </summary>
    public float fVehicleLength;
    /// <summary>
    /// snap mode 0-normal,1-globle,2-near,4-snap on the same side,8-snap on the reverse side,16-plant picture
    /// 抓拍方式    0-未分类,1-全景,2-近景,4-同向抓拍,8-反向抓拍,16-号牌图像
    /// </summary>
    public int nSnapshotMode;
    /// <summary>
    /// channel name
    /// 本地或远程的通道名称,可以是地点信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szChannelName;
    /// <summary>
    /// Machine name
    /// 本地或远程设备名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szMachineName;
    /// <summary>
    /// machine group
    /// 机器分组或叫设备所属单位
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szMachineGroup;
    /// <summary>
    /// road way number
    /// 道路编号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szRoadwayNo;
    /// <summary>
    /// DrivingDirection: for example ["Approach", "Shanghai", "Hangzhou"]
    /// 行驶方向 , "DrivingDirection" : ["Approach", "上海", "杭州"]
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 * 256)]
    public byte[] szDrivingDirection;
    /// <summary>
    /// device address,OSD superimposed onto the image,from TrafficSnapshot.DeviceAddress,'\0'means end.
    /// 设备地址,OSD叠加到图片上的,来源于配置TrafficSnapshot.DeviceAddress,'\0'结束
    /// </summary>
    public IntPtr szDeviceAddress;
    /// <summary>
    /// Vehicle identification, such as "Unknown" - unknown "Audi" - Audi, "Honda" - Honda
    /// 车辆标识, 例如 "Unknown"-未知, "Audi"-奥迪, "Honda"-本田
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szVehicleSign;
    /// <summary>
    /// Generated by the vehicle inspection device to capture the signal redundancy
    /// 由车检器产生抓拍信号冗余信息
    /// </summary>
    public NET_SIG_CARWAY_INFO_EX stuSigInfo;
    /// <summary>
    /// Equipment deployment locations
    /// 设备部署地点
    /// </summary>
    public IntPtr szMachineAddr;
    /// <summary>
    /// Current picture exposure time, in milliseconds
    /// 当前图片曝光时间,单位为毫秒
    /// </summary>
    public float fActualShutter;
    /// <summary>
    /// Current picture gain, ranging from 0 to 100
    /// 当前图片增益,范围为0~100
    /// </summary>
    public byte byActualGain;
    /// <summary>
    /// Lane Direction,0 - south to north 1- Southwest to northeast 2 - West to east, 3 - Northwest to southeast 4 - north to south 5 - northeast to southwest 6 - East to West 7 - Southeast to northwest 8 - Unknown 9-customized
    /// 车道方向,0-南向北 1-西南向东北 2-西向东 3-西北向东南 4-北向南 5-东北向西南 6-东向西 7-东南向西北 8-未知 9-自定义
    /// </summary>
    public byte byDirection;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Address, as szDeviceAddress supplement
    /// 详细地址, 作为szDeviceAddress的补充
    /// </summary>
    public IntPtr szDetailedAddress;
    /// <summary>
    /// waterproof
    /// 图片防伪码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szDefendCode;
    /// <summary>
    /// Link black list data recorddefualt main keyID, 0 invalid,>0 black list data record
    /// 关联黑名单数据库记录默认主键ID, 0,无效；> 0,黑名单数据记录
    /// </summary>
    public int nTrafficBlackListID;
    /// <summary>
    /// bofy color RGBA
    /// 车身颜色RGBA
    /// </summary>
    public NET_COLOR_RGBA stuRGBA;
    /// <summary>
    /// snap time
    /// 抓拍时间
    /// </summary>
    public NET_TIME stSnapTime;
    /// <summary>
    /// Rec No
    /// 记录编号
    /// </summary>
    public int nRecNo;
    /// <summary>
    /// self defined parking space number for parking
    /// 自定义车位号（停车场用）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
    public byte[] szCustomParkNo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved1;
    /// <summary>
    /// Metal plate No. 
    /// 车板位号
    /// </summary>
    public int nDeckNo;
    /// <summary>
    /// Free metal plate No.
    /// 空闲车板数量
    /// </summary>
    public int nFreeDeckCount;
    /// <summary>
    /// Occupized metal plate No. 
    /// 占用车板数量
    /// </summary>
    public int nFullDeckCount;
    /// <summary>
    /// Total metal plate No. 
    /// 总共车板数量
    /// </summary>
    public int nTotalDeckCount;
    /// <summary>
    /// violation name
    /// 违章名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szViolationName;
    /// <summary>
    /// Weight of car(kg)
    /// 车重(单位 Kg)
    /// </summary>
    public uint nWeight;
    /// <summary>
    /// custom road way, valid when byDirection is 9
    /// 自定义车道方向,byDirection为9时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szCustomRoadwayDirection;
    /// <summary>
    /// the physical lane number,value form 0 to 5
    /// 物理车道号,取值0到5
    /// </summary>
    public byte byPhysicalLane;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved2;
    /// <summary>
    /// moving direction
    /// 车辆行驶方向
    /// </summary>
    public EM_TRAFFICCAR_MOVE_DIRECTION emMovingDirection;
    /// <summary>
    /// corresponding to throughTime
    /// 对应电子车牌标签信息中的过车时间(ThroughTime)
    /// </summary>
    public NET_TIME stuEleTagInfoUTC;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 552)]
    public byte[] bReserved;
  }

  /// <summary>
  /// traffic car move direction type
  /// 交通车辆行驶方向类型
  /// </summary>
  public enum EM_TRAFFICCAR_MOVE_DIRECTION
  {
    /// <summary>
    /// unknown
    /// 未知的
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// straight
    /// 直行
    /// </summary>
    STRAIGHT,
    /// <summary>
    /// turn left
    /// 左转
    /// </summary>
    TURN_LEFT,
    /// <summary>
    /// turn right
    /// 右转
    /// </summary>
    TURN_RIGHT,
    /// <summary>
    /// turn around
    /// 掉头
    /// </summary>
    TURN_AROUND,
  }

  /// <summary>
  /// VehicleSize
  /// 车身大小
  /// </summary>
  public enum EM_VehicleSizeType
  {
    /// <summary>
    /// UnKnow
    /// 未知
    /// </summary>
    UnKnow = -1,
    /// <summary>
    /// Light-duty
    /// 小型车
    /// </summary>
    Light_Duty = 1,
    /// <summary>
    /// Medium
    /// 中型车
    /// </summary>
    Medium = 1 << 1,
    /// <summary>
    /// Oversize
    /// 大型车
    /// </summary>
    Oversize = 1 << 2,
    /// <summary>
    /// Minisize
    /// 微型车
    /// </summary>
    Minisize = 1 << 3,
    /// <summary>
    /// Largesize
    /// 长车
    /// </summary>
    Largesize = 1 << 4,
  }

  /// <summary>
  /// Vehicle detector redundancy information
  /// 车检器冗余信息
  /// </summary>
  public struct NET_SIG_CARWAY_INFO_EX
  {
    /// <summary>
    /// The vehicle detector generates the snap signal redundancy info
    /// 由车检器产生抓拍信号冗余信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byRedundance;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 120)]
    public byte[] bReserved;
  }

  /// <summary>
  /// color RGBA
  /// 颜色RGBA
  /// </summary>
  public struct NET_COLOR_RGBA
  {
    /// <summary>
    /// red
    /// 红
    /// </summary>
    public int nRed;
    /// <summary>
    /// green
    /// 绿
    /// </summary>
    public int nGreen;
    /// <summary>
    /// blue
    /// 蓝
    /// </summary>
    public int nBlue;
    /// <summary>
    /// transparent
    /// 透明
    /// </summary>
    public int nAlpha;
  }

  /// <summary>
  /// common event information
  /// 事件通用信息
  /// </summary>
  public struct NET_EVENT_COMM_INFO
  {
    /// <summary>
    /// NTP time sync status
    /// NTP校时状态
    /// </summary>
    public EM_NTP_STATUS emNTPStatus;
    /// <summary>
    /// driver info number
    /// 驾驶员信息数
    /// </summary>
    public int nDriversNum;
    /// <summary>
    /// driver info data (NET_MSG_OBJECT_EX)
    /// 驾驶员信息数据(NET_MSG_OBJECT_EX)
    /// </summary>
    public IntPtr pstDriversInfo;
    /// <summary>
    /// writing path for loacl disk or sd card, or write to default path if NULL
    /// 本地硬盘或者sd卡成功写入路径,为NULL时,路径不存在
    /// </summary>
    public IntPtr pszFilePath;
    /// <summary>
    /// ftp path
    /// 设备成功写到ftp服务器的路径
    /// </summary>
    public IntPtr pszFTPPath;
    /// <summary>
    /// ftp path for assocated video
    /// 当前接入需要获取当前违章的关联视频的FTP上传路径
    /// </summary>
    public IntPtr pszVideoPath;
    /// <summary>
    /// Seat info
    /// 驾驶位信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public NET_EVENT_COMM_SEAT[] stCommSeat;
    /// <summary>
    /// Car Attachment number
    /// 车辆物件个数
    /// </summary>
    public int nAttachmentNum;
    /// <summary>
    /// Car Attachment
    /// 车辆物件信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public NET_EVENT_COMM_ATTACHMENT[] stuAttachment;
    /// <summary>
    /// Annual Inspection number
    /// 年检标志个数
    /// </summary>
    public int nAnnualInspectionNum;
    /// <summary>
    /// Annual Inspection
    /// 年检标志
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public NET_RECT[] stuAnnualInspection;
    /// <summary>
    /// The ratio of HC,unit,%/1000000
    /// HC所占比例，单位：%/1000000 
    /// </summary>
    public float fHCRatio;
    /// <summary>
    /// The ratio of NO,unit,%/1000000
    /// NO所占比例，单位：%/1000000 
    /// </summary>
    public float fNORatio;
    /// <summary>
    /// The percent of CO,unit,% ,range from 0 to 100
    /// CO所占百分比，单位：% 取值0~100
    /// </summary>
    public float fCOPercent;
    /// <summary>
    /// The percent of CO2,unit: % ,range from 0 to 100  
    /// CO2所占百分比，单位：% 取值0~100 
    /// </summary>
    public float fCO2Percent;
    /// <summary>
    /// The obscuration of light,unit,% ,range from 0 to 100
    /// 不透光度，单位：% 取值0~100
    /// </summary>
    public float fLightObscuration;
    /// <summary>
    /// Original pictures info number
    /// 原始图片张数
    /// </summary>
    public int nPictureNum;
    /// <summary>
    /// Original pictures info data
    /// 原始图片信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
    public NET_EVENT_PIC_INFO[] stuPicInfos;
    /// <summary>
    /// Temperature,unit: centigrade
    /// 温度值,单位摄氏度
    /// </summary>
    public float fTemperature;
    /// <summary>
    /// Humidity,unit: %
    /// 相对湿度百分比值
    /// </summary>
    public int nHumidity;
    /// <summary>
    /// Pressure,unit: Kpa
    /// 气压值,单位Kpa
    /// </summary>
    public float fPressure;
    /// <summary>
    /// Wind force,unit: m/s
    /// 风力值,单位m/s
    /// </summary>
    public float fWindForce;
    /// <summary>
    /// Wind direction,unit: degree,range:[0,360]
    /// 风向,单位度,范围:[0,360]
    /// </summary>
    public uint nWindDirection;
    /// <summary>
    /// Road gradient,unit: degree
    /// 道路坡度值,单位度
    /// </summary>
    public float fRoadGradient;
    /// <summary>
    /// Acceleration,unit: m/s2
    /// 加速度值,单位:m/s2
    /// </summary>
    public float fAcceleration;
    /// <summary>
    /// RFID electronics tag info
    /// RFID 电子车牌标签信息
    /// </summary>
    public NET_RFIDELETAG_INFO stuRFIDEleTagInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 704)]
    public byte[] bReserved;
    /// <summary>
    /// Country
    /// 国家
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 20)]
    public string szCountry;
  }

  /// <summary>
  /// traffic event snap picture info
  /// 交通抓图图片信息
  /// </summary>
  public struct NET_EVENT_PIC_INFO
  {
    /// <summary>
    /// offset
    /// 原始图片偏移，单位字节
    /// </summary>
    public uint nOffset;
    /// <summary>
    /// length of picture
    /// 原始图片长度，单位字节
    /// </summary>
    public uint nLength;
  }

  /// <summary>
  /// the info of RFID electronic tag 
  /// RFID 电子车牌标签信息
  /// </summary>
  public struct NET_RFIDELETAG_INFO
  {
    /// <summary>
    /// card ID
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szCardID;
    /// <summary>
    /// card type, 0:issued by transport administration offices, 1:new factory preloaded card
    /// 卡号类型, 0:交通管理机关发行卡, 1:新车出厂预装卡
    /// </summary>
    public int nCardType;
    /// <summary>
    /// card privince
    /// 卡号省份
    /// </summary>
    public EM_CARD_PROVINCE emCardPrivince;
    /// <summary>
    /// plate number
    /// 车牌号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szPlateNumber;
    /// <summary>
    /// production data
    /// 出厂日期
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szProductionDate;
    /// <summary>
    /// car type
    /// 车辆类型
    /// </summary>
    public EM_CAR_TYPE emCarType;
    /// <summary>
    /// power, unit:kilowatt-hour, range:0~254, 255 means larger than maximum power value can be stored
    /// 功率,单位：千瓦时，功率值范围0~254；255表示该车功率大于可存储的最大功率值
    /// </summary>
    public int nPower;
    /// <summary>
    /// displacement, unit:100ml, range:0~254, 255 means larger than maximum displacement value can be stored
    /// 排量,单位：百毫升，排量值范围0~254；255表示该车排量大于可存储的最大排量值
    /// </summary>
    public int nDisplacement;
    /// <summary>
    /// antenna ID, range:1~4
    /// 天线ID，取值范围:1~4
    /// </summary>
    public int nAntennaID;
    /// <summary>
    /// plate type
    /// 号牌种类
    /// </summary>
    public EM_PLATE_TYPE emPlateType;
    /// <summary>
    /// validity of inspection, year-month
    /// 检验有效期，年-月
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szInspectionValidity;
    /// <summary>
    /// the flag of inspetion, 0:already inspection, 1:not inspection
    /// 逾期未年检标志, 0:已年检, 1:逾期未年检
    /// </summary>
    public int nInspectionFlag;
    /// <summary>
    /// the years form effective inspection preiod to compulsory discarding preiod
    /// 强制报废期，从检验有效期开始，距离强制报废期的年数
    /// </summary>
    public int nMandatoryRetirement;
    /// <summary>
    /// car color
    /// 车身颜色
    /// </summary>
    public EM_CAR_COLOR_TYPE emCarColor;
    /// <summary>
    /// authorized capacity, unit:people, less than 0:incalid
    /// 核定载客量，该值 小于0 时：无效；此值表示核定载客，单位为人
    /// </summary>
    public int nApprovedCapacity;
    /// <summary>
    /// total weight, unit:100kg, range:0~0x3FF,  0x3FF1023:larger than maximum value can be stored, less than 0:invalid
    /// 此值表示总质量，单位为百千克；该值小于0时：无效；该值的有效范围为0~0x3FF，0x3FF（1023）表示数据值超过了可存储的最大值
    /// </summary>
    public int nApprovedTotalQuality;
    /// <summary>
    /// the time when the car is pass
    /// 过车时间
    /// </summary>
    public NET_TIME_EX stuThroughTime;
    /// <summary>
    /// use property
    /// 使用性质
    /// </summary>
    public EM_USE_PROPERTY_TYPE emUseProperty;
    /// <summary>
    /// Licensing code, UTF-8 encoding
    /// 发牌代号，UTF-8编码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] szPlateCode;
    /// <summary>
    /// Plate number, serial number, UTF-8 code
    /// 号牌号码序号，UTF-8编码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szPlateSN;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 104)]
    public byte[] bReserved;
  }

  /// <summary>
  /// card province
  /// 卡号省份
  /// </summary>
  public enum EM_CARD_PROVINCE
  {
    /// <summary>
    /// UNKNOWN
    /// 解析出错，未知省份
    /// </summary>
    UNKNOWN = 10,
    /// <summary>
    /// BeiJing
    /// 北京
    /// </summary>
    BEIJING = 11,
    /// <summary>
    /// TianJin
    /// 天津
    /// </summary>
    TIANJIN = 12,
    /// <summary>
    /// HeBei
    /// 河北
    /// </summary>
    HEBEI = 13,
    /// <summary>
    /// ShanXi, the provincial capital is TaiYuan
    /// 山西
    /// </summary>
    SHANXI_TAIYUAN = 14,
    /// <summary>
    /// NeiMengGu
    /// 内蒙古
    /// </summary>
    NEIMENGGU = 15,
    /// <summary>
    /// LiaoNing
    /// 辽宁
    /// </summary>
    LIAONING = 21,
    /// <summary>
    /// JiKin
    /// 吉林
    /// </summary>
    JILIN = 22,
    /// <summary>
    /// HeiLongJiang
    /// 黑龙江
    /// </summary>
    HEILONGJIANG = 23,
    /// <summary>
    /// ShangHai
    /// 上海
    /// </summary>
    SHANGHAI = 31,
    /// <summary>
    /// JiangSu
    /// 江苏
    /// </summary>
    JIANGSU = 32,
    /// <summary>
    /// ZheJiang
    /// 浙江
    /// </summary>
    ZHEJIANG = 33,
    /// <summary>
    /// AnHui
    /// 安徽
    /// </summary>
    ANHUI = 34,
    /// <summary>
    /// FuJian
    /// 福建
    /// </summary>
    FUJIAN = 35,
    /// <summary>
    /// JiangXi
    /// 江西
    /// </summary>
    JIANGXI = 36,
    /// <summary>
    /// ShanDong
    /// 山东
    /// </summary>
    SHANDONG = 37,
    /// <summary>
    /// HeNan
    /// 河南
    /// </summary>
    HENAN = 41,
    /// <summary>
    /// HuBei
    /// 湖北
    /// </summary>
    HUBEI = 42,
    /// <summary>
    /// HuNan
    /// 湖南
    /// </summary>
    HUNAN = 43,
    /// <summary>
    /// GuangDong
    /// 广东
    /// </summary>
    GUANGDONG = 44,
    /// <summary>
    /// GuangXi
    /// 广西
    /// </summary>
    GUANGXI = 45,
    /// <summary>
    /// HaiNan
    /// 海南
    /// </summary>
    HAINAN = 46,
    /// <summary>
    /// ChongQing
    /// 重庆
    /// </summary>
    CHONGQING = 50,
    /// <summary>
    /// SiChuan
    /// 四川
    /// </summary>
    SICHUAN = 51,
    /// <summary>
    /// GuiZhou
    /// 贵州
    /// </summary>
    GUIZHOU = 52,
    /// <summary>
    /// YunNan
    /// 云南
    /// </summary>
    YUNNAN = 53,
    /// <summary>
    /// XiZang
    /// 西藏
    /// </summary>
    XIZANG = 54,
    /// <summary>
    /// ShanXi , the provincial capital is XiAn
    /// 陕西
    /// </summary>
    SHANXI_XIAN = 61,
    /// <summary>
    /// GanSu
    /// 甘肃
    /// </summary>
    GANSU = 62,
    /// <summary>
    /// QingHai
    /// 青海
    /// </summary>
    QINGHAI = 63,
    /// <summary>
    /// NingXia
    /// 宁夏
    /// </summary>
    NINGXIA = 64,
    /// <summary>
    /// XinJiang
    /// 新疆
    /// </summary>
    XINJIANG = 65,
    /// <summary>
    /// XiangGang
    /// 香港
    /// </summary>
    XIANGGANG = 71,
    /// <summary>
    /// AoMen
    /// 澳门
    /// </summary>
    AOMEN = 82,
  }

  /// <summary>
  /// the type of the car
  /// 车辆类型
  /// </summary>
  public enum EM_CAR_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// bus
    /// 客车
    /// </summary>
    BUS,
    /// <summary>
    /// big truck
    /// 大货车
    /// </summary>
    BIG_TRUCK,
    /// <summary>
    /// medium truck
    /// 中货车
    /// </summary>
    MEDIUM_TRUCK,
    /// <summary>
    /// car
    /// 轿车
    /// </summary>
    CAR,
    /// <summary>
    /// van
    /// 面包车
    /// </summary>
    VAN,
    /// <summary>
    /// small truck
    /// 小货车
    /// </summary>
    SMALL_TRUCK,
    /// <summary>
    /// tricycle
    /// 三轮车
    /// </summary>
    TRICYCLE,
    /// <summary>
    /// motocycle
    /// 摩托车
    /// </summary>
    MOTORCYCLE,
    /// <summary>
    /// pedestrian
    /// 行人
    /// </summary>
    PEDESTRIAN,
    /// <summary>
    /// SUV-MPV
    /// SUV-MPV
    /// </summary>
    SUVMPV,
    /// <summary>
    /// medium bus
    /// 中客车
    /// </summary>
    MEDIUM_BUS,
    /// <summary>
    /// hazardous chemical vehicles
    /// 危化品车辆
    /// </summary>
    DANGE_VEHICLE,
  }

  /// <summary>
  /// the tpye of the plate
  /// 号牌类型
  /// </summary>
  public enum EM_PLATE_TYPE
  {
    /// <summary>
    /// unkonwn
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// big car (black words on yellow background)
    /// 大型汽车（黄底黑字）
    /// </summary>
    BIGCAR,
    /// <summary>
    /// small car (white words on blue background)
    /// 小型汽车（蓝底白字）
    /// </summary>
    SMALLCAR,
    /// <summary>
    /// embassy car (white words on black background, and the word '使' is red)
    /// 使馆汽车（黑底白字、红'使'字）
    /// </summary>
    EMBASSYCAR,
    /// <summary>
    /// consulate car (white words on black background, and the word '领' is red)
    /// 领馆汽车（黑底白字，红'领'字）
    /// </summary>
    CONSULATECAR,
    /// <summary>
    /// abroad car (white/red words on black background)
    /// 境外汽车（黑底白/红字）
    /// </summary>
    ABROADCAR,
    /// <summary>
    /// foreign car (white words on black background)
    /// 外籍汽车（黑底白字）
    /// </summary>
    FOREIGNCAR,
    /// <summary>
    /// police plate
    /// 警牌
    /// </summary>
    POLICE,
    /// <summary>
    /// armed police plate
    /// 武警牌
    /// </summary>
    ARMEDPOLICE,
    /// <summary>
    /// troops plate
    /// 部队号牌
    /// </summary>
    TROOPS,
    /// <summary>
    /// troops plate which is double layer
    /// 部队双层
    /// </summary>
    TROOPSDOUBLE,
    /// <summary>
    /// yellow tail plate which double layer
    /// 双层黄尾牌
    /// </summary>
    YELLOWTAILDOUBLE,
    /// <summary>
    /// coach car plate
    /// 教练车号牌
    /// </summary>
    COACHCAR,
    /// <summary>
    /// personality plate
    /// 个性号牌
    /// </summary>
    PERSONALITY,
    /// <summary>
    /// agricultural plate
    /// 农用牌
    /// </summary>
    AGRICULTURAL,
    /// <summary>
    /// motorcycle plate
    /// 摩托车号牌
    /// </summary>
    MOTORCYCLE,
    /// <summary>
    /// tractor plate
    /// 拖拉机号牌
    /// </summary>
    TRACTOR,
    /// <summary>
    /// small car (white words on black background)
    /// 小型汽车(黑底白字)
    /// </summary>
    SMALLCAR_BLACK,
    /// <summary>
    /// red plate
    /// 红牌车
    /// </summary>
    RED,
    /// <summary>
    /// blue plate
    /// 青牌车
    /// </summary>
    BLUE,
    /// <summary>
    /// white plate
    /// 白牌车
    /// </summary>
    WHITE,
    /// <summary>
    /// pure electric and new enegry car
    /// 纯电动新能源小车
    /// </summary>
    PURE_NEW_SMALLCAR,
    /// <summary>
    /// hybrid and new enegry car
    /// 混合新能源小车
    /// </summary>
    BLEND_NEW_SMALLCAR,
    /// <summary>
    /// pure electric and new enegry cart
    /// 纯电动新能源大车
    /// </summary>
    PURE_NEW_BIGCAR,
    /// <summary>
    /// hybrid and new enegry cart
    /// 混合新能源大车
    /// </summary>
    BLEND_NEW_BIGCAR,
  }

  /// <summary>
  /// car color
  /// 车身颜色
  /// </summary>
  public enum EM_CAR_COLOR_TYPE
  {
    /// <summary>
    /// white
    /// 白色
    /// </summary>
    WHITE,
    /// <summary>
    /// black
    /// 黑色
    /// </summary>
    BLACK,
    /// <summary>
    /// red
    /// 红色
    /// </summary>
    RED,
    /// <summary>
    /// yellow
    /// 黄色
    /// </summary>
    YELLOW,
    /// <summary>
    /// gray
    /// 灰色
    /// </summary>
    GRAY,
    /// <summary>
    /// blue
    /// 蓝色
    /// </summary>
    BLUE,
    /// <summary>
    /// green
    /// 绿色
    /// </summary>
    GREEN,
    /// <summary>
    /// pink
    /// 粉色
    /// </summary>
    PINK,
    /// <summary>
    /// purple
    /// 紫色
    /// </summary>
    PURPLE,
    /// <summary>
    /// dark purple
    /// 暗紫色
    /// </summary>
    DARK_PURPLE,
    /// <summary>
    /// brown
    /// 棕色
    /// </summary>
    BROWN,
    /// <summary>
    /// marron
    /// 粟色
    /// </summary>
    MAROON,
    /// <summary>
    /// silver gray
    /// 银灰色
    /// </summary>
    SILVER_GRAY,
    /// <summary>
    /// dark gray
    /// 暗灰色
    /// </summary>
    DARK_GRAY,
    /// <summary>
    /// white smoke
    /// 白烟色
    /// </summary>
    WHITE_SMOKE,
    /// <summary>
    /// deep orange
    /// 深橙色
    /// </summary>
    DEEP_ORANGE,
    /// <summary>
    /// light rose
    /// 浅玫瑰色
    /// </summary>
    LIGHT_ROSE,
    /// <summary>
    /// tomato red
    /// 番茄红色
    /// </summary>
    TOMATO_RED,
    /// <summary>
    /// olive
    /// 橄榄色
    /// </summary>
    OLIVE,
    /// <summary>
    /// golden
    /// 金色
    /// </summary>
    GOLDEN,
    /// <summary>
    /// dark olive
    /// 暗橄榄色
    /// </summary>
    DARK_OLIVE,
    /// <summary>
    /// yellow green
    /// 黄绿色
    /// </summary>
    YELLOW_GREEN,
    /// <summary>
    /// green yellow
    /// 绿黄色
    /// </summary>
    GREEN_YELLOW,
    /// <summary>
    /// forest green
    /// 森林绿
    /// </summary>
    FOREST_GREEN,
    /// <summary>
    /// ocean blue
    /// 海洋绿
    /// </summary>
    OCEAN_BLUE,
    /// <summary>
    /// deep sky blue
    /// 深天蓝
    /// </summary>
    DEEP_SKYBLUE,
    /// <summary>
    /// cyan
    /// 青色
    /// </summary>
    CYAN,
    /// <summary>
    /// deep blue
    /// 深蓝色
    /// </summary>
    DEEP_BLUE,
    /// <summary>
    /// deep red
    /// 深红色
    /// </summary>
    DEEP_RED,
    /// <summary>
    /// deep green
    /// 深绿色
    /// </summary>
    DEEP_GREEN,
    /// <summary>
    /// deep yellow
    /// 深黄色
    /// </summary>
    DEEP_YELLOW,
    /// <summary>
    /// deep pink
    /// 深粉色
    /// </summary>
    DEEP_PINK,
    /// <summary>
    /// deep purple
    /// 深紫色
    /// </summary>
    DEEP_PURPLE,
    /// <summary>
    /// deep brown
    /// 深棕色
    /// </summary>
    DEEP_BROWN,
    /// <summary>
    /// deep cyan
    /// 深青色
    /// </summary>
    DEEP_CYAN,
    /// <summary>
    /// orange
    /// 橙色
    /// </summary>
    ORANGE,
    /// <summary>
    /// deep golden
    /// 深金色
    /// </summary>
    DEEP_GOLDEN,
    /// <summary>
    /// other
    /// 未识别、其他
    /// </summary>
    OTHER = 255,
  }

  /// <summary>
  /// use property
  /// 使用性质
  /// </summary>
  public enum EM_USE_PROPERTY_TYPE
  {
    /// <summary>
    /// other
    /// 其他
    /// </summary>
    OTHER,
    /// <summary>
    /// not operating
    /// 非营运
    /// </summary>
    NOTOPERATING,
    /// <summary>
    /// higway
    /// 公路客运
    /// </summary>
    HIGWAY,
    /// <summary>
    /// bus
    /// 公交客运
    /// </summary>
    BUS,
    /// <summary>
    /// taxi
    /// 出租客运
    /// </summary>
    TAXI,
    /// <summary>
    /// tourism
    /// 旅游客运
    /// </summary>
    TOURISM,
    /// <summary>
    /// freight
    /// 货运
    /// </summary>
    FREIGHT,
    /// <summary>
    /// lease
    /// 租赁
    /// </summary>
    LEASE,
    /// <summary>
    /// for police
    /// 警用
    /// </summary>
    POLICE,
    /// <summary>
    /// for fire police
    /// 消防
    /// </summary>
    FIRE,
    /// <summary>
    /// for rescue
    /// 救护
    /// </summary>
    RESCUE,
    /// <summary>
    /// engineering emergency
    /// 工程救险
    /// </summary>
    ENGINEERING,
    /// <summary>
    /// form operating to not operating
    /// 营转非
    /// </summary>
    OPERATION_TO_NOT,
    /// <summary>
    /// form taxi to not taxi
    /// 出租转非
    /// </summary>
    TAXI_TO_NOT,
    /// <summary>
    /// for coach
    /// 教练
    /// </summary>
    COACH,
    /// <summary>
    /// kindergarten school bus
    /// 幼儿校车
    /// </summary>
    KINDER_SCHOOLBUS,
    /// <summary>
    /// pupil school bus
    /// 小学生校车
    /// </summary>
    PUPIL_SCHOOLBUS,
    /// <summary>
    /// other school bus
    /// 其他校车
    /// </summary>
    OTHER_SCHOOLBUS,
    /// <summary>
    /// for dangerous goods transportation
    /// 危化品运输
    /// </summary>
    FOR_DANGE_VEHICLE,
  }

  /// <summary>
  /// NTP status
  /// NTP状态
  /// </summary>
  public enum EM_NTP_STATUS
  {
    /// <summary>
    /// unknow
    /// 未知
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// disable
    /// 禁用
    /// </summary>
    DISABLE,
    /// <summary>
    /// successful
    /// 成功
    /// </summary>
    SUCCESSFUL,
    /// <summary>
    /// failed
    /// 失败
    /// </summary>
    FAILED,
  }

  /// <summary>
  /// Video analysis object info expansion structure,4-byte alignment
  /// 物体信息扩展结构体，强制4字节对齐
  /// </summary>
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
  public struct NET_MSG_OBJECT_EX
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// object ID, each ID means a exclusive object
    /// 物体ID,每个ID表示一个唯一的物体
    /// </summary>
    public int nObjectID;
    /// <summary>
    /// object  type
    /// 物体类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szObjectType;
    /// <summary>
    /// confidence coefficient (0~255) value the bigger means  confidence coefficient the higher
    /// 置信度(0~255),值越大表示置信度越高
    /// </summary>
    public int nConfidence;
    /// <summary>
    /// object  motion :1:Appear 2:Move 3:Stay 4:Remove 5:Disappear 6:Split 7:Merge 8:Rename
    /// 物体动作:1:Appear 2:Move 3:Stay 4:Remove 5:Disappear 6:Split 7:Merge 8:Rename
    /// </summary>
    public int nAction;
#if (LINUX_X64)
		public NET_RECT_LONG_TYPE           BoundingBox;		           
#else
    /// <summary>
    /// BoundingBox
    /// 包围盒
    /// </summary>
    public NET_RECT BoundingBox;
#endif
    /// <summary>
    /// object model center
    /// 物体型心
    /// </summary>
    public NET_POINT Center;
    /// <summary>
    /// polygon vertex number 
    /// 多边形顶点个数
    /// </summary>
    public int nPolygonNum;
    /// <summary>
    /// relatively accurate outline the polygon 
    /// 较精确的轮廓多边形
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_POINT[] Contour;
    /// <summary>
    /// means plate, vehicle body and etc. object major color by byte means are red, green, blue and transparency , such as:RGB value is (0,255,0), transparency is 0, its value is 0x00ff0000.
    /// 表示车牌、车身等物体主要颜色；按字节表示,分别为红、绿、蓝和透明度,例如:RGB值为(0,255,0),透明度为0时, 其值为0x00ff0000
    /// </summary>
    public uint rgbaMainColor;
    /// <summary>
    /// same as NET_MSG_OBJECT corresponding field
    /// 同NET_MSG_OBJECT相应字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szText;
    /// <summary>
    /// object sub type according to different object  types may use the following sub type,same as NET_MSG_OBJECT field
    /// 物体子类别,根据不同的物体类型,可以取以下子类型，同NET_MSG_OBJECT相应字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szObjectSubType;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved1;
    /// <summary>
    /// object corresponding to picture file info or not
    /// 是否有物体对应图片文件信息
    /// </summary>
    public byte bPicEnble;
    /// <summary>
    /// object corresponding to picture info 
    /// 物体对应图片信息
    /// </summary>
    public NET_PIC_INFO stPicInfo;
    /// <summary>
    /// snapshot recognition result or not 
    /// 是否是抓拍张的识别结果
    /// </summary>
    public byte bShotFrame;
    /// <summary>
    /// object  color (rgbaMainColor) usable or not
    /// 物体颜色(rgbaMainColor)是否可用
    /// </summary>
    public byte bColor;
    /// <summary>
    /// lower color (rgbaLowerBodyColor) usable or not
    /// 下半身颜色(rgbaLowerBodyColor)是否可用
    /// </summary>
    public byte bLowerBodyColor;
    /// <summary>
    /// time means type, see EM_TIME_TYPE note
    /// 时间表示类型,详见EM_TIME_TYPE说明
    /// </summary>
    public byte byTimeType;
    /// <summary>
    /// for video compression current time stamp, object snapshot or recognition, attach this recognition frame in one vire frame or jpegpicture,this frame's appearance time in original video
    /// 针对视频浓缩,当前时间戳（物体抓拍或识别时,会将此识别智能帧附在一个视频帧或jpeg图片中,此帧所在原始视频中的出现时间）
    /// </summary>
    public NET_TIME_EX stuCurrentTime;
    /// <summary>
    /// start time stamp,object start appearance
    /// 开始时间戳（物体开始出现时）
    /// </summary>
    public NET_TIME_EX stuStartTime;
    /// <summary>
    /// end time stamp,object last aapearance
    /// 结束时间戳（物体最后出现时）
    /// </summary>
    public NET_TIME_EX stuEndTime;
#if (LINUX_X64)
		public NET_RECT_LONG_TYPE           stuOriginalBoundingBox;	        // original bounding box(absolute coordinates)
        public NET_RECT_LONG_TYPE           stuSignBoundingBox;	            // sign bounding box coordinate
#else
    /// <summary>
    /// original bounding box(absolute coordinates)
    /// 包围盒(绝对坐标)
    /// </summary>
    public NET_RECT stuOriginalBoundingBox;
    /// <summary>
    /// sign bounding box coordinate
    /// 车标坐标包围盒
    /// </summary>
    public NET_RECT stuSignBoundingBox;
#endif
    /// <summary>
    /// current frame no. snapshot this object frame
    /// 当前帧序号（抓下这个物体时的帧）
    /// </summary>
    public uint dwCurrentSequence;
    /// <summary>
    /// start frame no. object start appearance frame no.
    /// 开始帧序号（物体开始出现时的帧序号）
    /// </summary>
    public uint dwBeginSequence;
    /// <summary>
    /// end frame no. object disappearance frame no.
    /// 结束帧序号（物体消逝时的帧序号）
    /// </summary>
    public uint dwEndSequence;
    /// <summary>
    /// start file shift, unit: byte object start appearance video in original video file moves toward file origin
    /// 开始时文件偏移, 单位: 字节（物体开始出现时,视频帧在原始视频文件中相对于文件起始处的偏移）
    /// </summary>
    public Int64 nBeginFileOffset;
    /// <summary>
    /// End file shift, unit: byte object disappearance video in original video file moves toward file origin
    /// 结束时文件偏移, 单位: 字节（物体消逝时,视频帧在原始视频文件中相对于文件起始处的偏移）
    /// </summary>
    public Int64 nEndFileOffset;
    /// <summary>
    /// object  color similarity take  value range 0-100 group subscript value represents certain color, see EM_COLOR_TYPE
    /// 物体颜色相似度,取值范围：0-100,数组下标值代表某种颜色,详见EM_COLOR_TYPE
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byColorSimilar;
    /// <summary>
    /// upper object  color  similarity (object  type as human is valid )
    /// 上半身物体颜色相似度(物体类型为人时有效)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byUpperBodyColorSimilar;
    /// <summary>
    /// lower object  color  similarity (object  type as human is valid )
    /// 下半身物体颜色相似度(物体类型为人时有效)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byLowerBodyColorSimilar;
    /// <summary>
    /// related object ID
    /// 相关物体ID
    /// </summary>
    public int nRelativeID;
    /// <summary>
    /// "ObjectType"is "Vehicle"or "Logo" means LOGO lower brand such as Audi A6L since there are many brands SDK shows this field in real-time,device filled as real.
    /// "ObjectType"为"Vehicle"或者"Logo"时,表示车标下的某一车系,比如奥迪A6L,由于车系较多,SDK实现时透传此字段,设备如实填写
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public byte[] szSubText;
    /// <summary>
    /// Intrusion staff height unit cm
    /// 入侵人员身高,单位cm
    /// </summary>
    public int nPersonStature;
    /// <summary>
    /// Staff intrusion direction
    /// 人员入侵方向
    /// </summary>
    public EM_MSG_OBJ_PERSON_DIRECTION emPersonDirection;
    /// <summary>
    /// Use direction same as rgbaMainColor,object  type as human is valid 
    /// 使用方法同rgbaMainColor,物体类型为人时有效
    /// </summary>
    public uint rgbaLowerBodyColor;
  }

  /// <summary>
  /// intrusion direction
  /// 入侵方向
  /// </summary>
  public enum EM_MSG_OBJ_PERSON_DIRECTION
  {
    /// <summary>
    /// unknown direction
    /// 未知方向
    /// </summary>
    UNKOWN,
    /// <summary>
    /// from left to right
    /// 从左向右
    /// </summary>
    LEFT_TO_RIGHT,
    /// <summary>
    /// from right ro left
    /// 从右向左
    /// </summary>
    RIGHT_TO_LEFT
  }

  /// <summary>
  /// driver's illegal info
  /// 驾驶位违规信息
  /// </summary>
  public struct NET_EVENT_COMM_SEAT
  {
    /// <summary>
    /// whether seat info detected
    /// 是否检测到座驾信息
    /// </summary>
    public bool bEnable;
    /// <summary>
    /// seat type
    /// 座驾类型, 0:未识别; 1:主驾驶; 2:副驾驶
    /// </summary>
    public EM_COMMON_SEAT_TYPE emSeatType;
    /// <summary>
    /// illegal state
    /// 违规状态
    /// </summary>
    public NET_EVENT_COMM_STATUS stStatus;
    /// <summary>
    /// safe belt state
    /// 安全带状态
    /// </summary>
    public EM_SAFEBELT_STATE emSafeBeltStatus;
    /// <summary>
    /// sun shade state
    /// 遮阳板状态
    /// </summary>
    public EM_SUNSHADE_STATE emSunShadeStatus;
    /// <summary>
    /// reversed
    /// 预留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 24)]
    public byte[] szReserved;
  }

  /// <summary>
  /// seat type
  /// 座位类型
  /// </summary>
  public enum EM_COMMON_SEAT_TYPE
  {
    /// <summary>
    /// unknown
    /// 未识别
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// main seat
    /// 主驾驶
    /// </summary>
    MAIN = 1,
    /// <summary>
    /// slave seat
    /// 副驾驶
    /// </summary>
    SLAVE = 2,
  }

  /// <summary>
  /// illegal state type of driver
  /// 违规状态
  /// </summary>
  public struct NET_EVENT_COMM_STATUS
  {
    /// <summary>
    /// smoking
    /// 是否抽烟
    /// </summary>
    public byte bySmoking;
    /// <summary>
    /// calling
    /// 是否打电话
    /// </summary>
    public byte byCalling;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 14)]
    public byte[] szReserved;
  }

  /// <summary>
  /// safebelt state
  /// 安全带状态
  /// </summary>
  public enum EM_SAFEBELT_STATE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOW,
    /// <summary>
    /// WithSafeBelt
    /// 已系安全带
    /// </summary>
    WITH_SAFE_BELT,
    /// <summary>
    /// WithoutSafeBelt
    /// 未系安全带
    /// </summary>
    WITHOUT_SAFE_BELT,
  }

  /// <summary>
  /// sunshade state
  /// 遮阳板状态
  /// </summary>
  public enum EM_SUNSHADE_STATE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOW_SUN_SHADE,
    /// <summary>
    /// WithSunShade
    /// 有遮阳板
    /// </summary>
    WITH_SUN_SHADE,
    /// <summary>
    /// WithoutSunShade
    /// 无遮阳板
    /// </summary>
    WITHOUT_SUN_SHADE,
  }

  /// <summary>
  /// event attachment struct
  /// 车辆物件
  /// </summary>
  public struct NET_EVENT_COMM_ATTACHMENT
  {
    /// <summary>
    /// type
    /// 物件类型
    /// </summary>
    public EM_COMM_ATTACHMENT_TYPE emAttachmentType;
    /// <summary>
    /// coordinate
    /// 坐标
    /// </summary>
    public NET_RECT stuRect;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public byte[] bReserved;
  }

  /// <summary>
  /// attachment type
  /// 车辆物件类型
  /// </summary>
  public enum EM_COMM_ATTACHMENT_TYPE
  {
    /// <summary>
    /// Unknown type
    /// 未知类型
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// Furniture
    /// 摆件
    /// </summary>
    FURNITURE = 1,
    /// <summary>
    /// Pendant
    /// 挂件
    /// </summary>
    PENDANT = 2,
    /// <summary>
    /// TissueBox
    /// 纸巾盒
    /// </summary>
    TISSUEBOX = 3,
    /// <summary>
    /// Danger
    /// 危险品
    /// </summary>
    DANGER = 4,
    /// <summary>
    /// perfumebox
    /// 香水
    /// </summary>
    PERFUMEBOX = 5,
  }

  /// <summary>
  /// Event Type EVENT_IVS_TRAFFICJUNCTION (transportation card traffic junctions old rule event / video port on the old electric alarm event rules) corresponding to the description of the data block
  /// Due to historical reasons, if you want to deal with bayonet event, NET_DEV_EVENT_TRAFFICJUNCTION_INFO and NET_EVENT_IVS_TRAFFICGATE be processed together to prevent police and video electrical coil electric alarm occurred while the case access platform
  /// Also NET_EVENT_IVS_TRAFFIC_TOLLGATE only support the new bayonet events
  /// 事件类型EVENT_IVS_TRAFFICJUNCTION(交通路口老规则事件/视频电警上的交通卡口老规则事件)对应的数据块描述信息
  /// 由于历史原因,如果要处理卡口事件,NET_DEV_EVENT_TRAFFICJUNCTION_INFO和NET_EVENT_IVS_TRAFFICGATE要一起处理,以防止有视频电警和线圈电警同时接入平台的情况发生
  /// 另外NET_EVENT_IVS_TRAFFIC_TOLLGATE只支持新卡口事件的配置
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFICJUNCTION_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// main driver's seat safety belt,1-fastened,2-unfastened
    /// 主驾驶座,系安全带状态,1-系安全带,2-未系安全带
    /// </summary>
    public byte byMainSeatBelt;
    /// <summary>
    /// co-drvier's seat safety belt,1-fastened,2-unfastened
    /// 副驾驶座,系安全带状态,1-系安全带,2-未系安全带
    /// </summary>
    public byte bySlaveSeatBelt;
    /// <summary>
    /// Current snapshot is head or rear see  EM_VEHICLE_DIRECTION
    /// 当前被抓拍到的车辆是车头还是车尾,具体请见 EM_VEHICLE_DIRECTION
    /// </summary>
    public byte byVehicleDirection;
    /// <summary>
    /// Open status see EM_OPEN_STROBE_STATE 
    /// 开闸状态,具体请见 EM_OPEN_STROBE_STATE
    /// </summary>
    public byte byOpenStrobeState;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// road number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// BreakingRule's mask,first byte: crash red light;secend byte:break the rule of driving road number; the third byte:converse; the forth byte:break rule to turn around;the five byte:traffic jam; the six byte:traffic vacancy; the seven byte: Overline; defalt:trafficJunction
    /// 违反规则掩码,第一位:闯红灯;第二位:不按规定车道行驶;第三位:逆行; 第四位：违章掉头;第五位:交通堵塞; 第六位:交通异常空闲;第七位:压线行驶; 否则默认为:交通路口事件
    /// </summary>
    public uint dwBreakingRule;
    /// <summary>
    /// the begin time of red light
    /// 红灯开始UTC时间
    /// </summary>                                         
    public NET_TIME_EX RedLightUTC;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index,such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// car's speed (km/h)
    /// 车辆实际速度Km/h 
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Intersection direction 1 - denotes the forward 2 - indicates the opposite
    /// 路口方向,1-表示正向,2-表示反向
    /// </summary>
    public byte byDirection;
    /// <summary>
    /// LightState means red light status:0 unknown,1 green,2 red,3 yellow
    /// LightState表示红绿灯状态:0 未知,1 绿灯,2 红灯,3 黄灯
    /// </summary>
    public byte byLightState;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    public byte byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// Alarm corresponding original video file information
    /// 报警对应的原始录像文件信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szRecordFile;
    /// <summary>
    /// custom info
    /// 自定义信息
    /// </summary>
    public NET_EVENT_JUNCTION_CUSTOM_INFO stuCustomInfo;
    /// <summary>
    /// the source of plate text, 0:Local,1:Server
    /// 车牌识别来源, 0:本地算法识别,1:后端服务器算法识别
    /// </summary>
    public byte byPlateTextSource;
    /// <summary>
    /// Reserved bytes
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved1;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 196)]
    public byte[] bReserved;
    /// <summary>
    /// Trigger Type:0 vehicle inspection device,1 radar,2 video
    /// TriggerType:触发类型,0车检器,1雷达,2视频
    /// </summary>
    public int nTriggerType;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// Card Number
    /// 卡片个数
    /// </summary>
    public uint dwRetCardNumber;
    /// <summary>
    /// Card information
    /// 卡片信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_EVENT_CARD_INFO[] stuCardInfo;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// custom info
  /// 卡口事件专用定制上报内容，定制需求增加到Custom下
  /// </summary>
  public struct NET_EVENT_JUNCTION_CUSTOM_INFO
  {
    /// <summary>
    /// custom weight info
    /// 原始图片信息
    /// </summary>
    public NET_EVENT_CUSTOM_WEIGHT_INFO stuWeightInfo;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
    public byte[] bReserved;
  }

  /// <summary>
  /// custom weight info
  /// 建委地磅定制称重信息
  /// </summary>
  public struct NET_EVENT_CUSTOM_WEIGHT_INFO
  {
    /// <summary>
    /// Rough Weight,unit:KG
    /// 毛重,车辆满载货物重量。单位KG
    /// </summary>
    public uint dwRoughWeight;
    /// <summary>
    /// Tare Weight,unit:KG
    /// 皮重,空车重量。单位KG
    /// </summary>
    public uint dwTareWeight;
    /// <summary>
    /// Net Weight,unit:KG
    /// 净重,载货重量。单位KG
    /// </summary>
    public uint dwNetWeight;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public byte[] bReserved;
  }

  /// <summary>
  /// vehicle direction
  /// 车辆方向
  /// </summary>
  public enum EM_VEHICLE_DIRECTION
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKOWN,
    /// <summary>
    /// head
    /// 车头
    /// </summary>
    HEAD,
    /// <summary>
    /// rear
    /// 车尾
    /// </summary>
    TAIL,
  }

  /// <summary>
  /// incidents reported to carry the card information
  /// 事件上报携带卡片信息
  /// </summary>
  public struct NET_EVENT_CARD_INFO
  {
    /// <summary>
    /// Card number string
    /// 卡片序号字符串
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
    public byte[] szCardNumber;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] bReserved;
  }

  /// <summary>
  /// the describe of EVENT_TRAFFIC_TURNLEFT's data
  /// 交通-违章左转对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_TURNLEFT_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end;
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 968)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_TURNRIGHT's data
  /// 交通-违章右转对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_TURNRIGHT_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 968)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_OVERSPEED's data
  /// 交通超速事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_OVERSPEED_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Speed Up limit Unit:km/h
    /// 速度上限 单位：km/h
    /// </summary>
    public int nSpeedUpperLimit;
    /// <summary>
    /// Speed Low limit Unit:km/h 
    /// 速度下限 单位：km/h 
    /// </summary>
    public int nSpeedLowerLimit;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// Faile path
    /// 文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
    public byte[] szFilePath;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 576)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// intelli event comm info
  /// 智能报警事件公共信息
  /// </summary>
  public struct NET_EVENT_INTELLI_COMM_INFO
  {
    /// <summary>
    /// class type
    /// 智能事件所属大类
    /// </summary>
    public EM_CLASS_TYPE emClassType;
    /// <summary>
    /// Preset ID
    /// 该事件触发的预置点，对应该设置规则的预置点
    /// </summary>
    public int nPresetID;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 124)]
    public byte[] bReserved;
  }

  /// <summary>
  /// class type
  /// 类类型
  /// </summary>
  public enum EM_CLASS_TYPE
  {
    /// <summary>
    /// unknow
    /// 未知业务
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// video-synopsis
    /// 视频浓缩
    /// </summary>
    VIDEO_SYNOPSIS = 1,
    /// <summary>
    /// traffiv-gate
    /// 卡口
    /// </summary>
    TRAFFIV_GATE = 2,
    /// <summary>
    /// electronic-police
    /// 电警
    /// </summary>
    ELECTRONIC_POLICE = 3,
    /// <summary>
    /// single-PTZ-parking
    /// 单球违停
    /// </summary>
    SINGLE_PTZ_PARKING = 4,
    /// <summary>
    /// PTZ-parking
    /// 主从违停
    /// </summary>
    PTZ_PARKINBG = 5,
    /// <summary>
    /// Traffic
    /// 交通事件
    /// </summary>
    TRAFFIC = 6,
    /// <summary>
    /// Normal
    /// 通用行为分析
    /// </summary>
    NORMAL = 7,
    /// <summary>
    /// Prison
    /// 监所行为分析
    /// </summary>
    PRISON = 8,
    /// <summary>
    /// ATM
    /// 金融行为分析
    /// </summary>
    ATM = 9,
    /// <summary>
    /// metro
    /// 地铁行为分析
    /// </summary>
    METRO = 10,
    /// <summary>
    /// FaceDetection
    /// 人脸检测
    /// </summary>
    FACE_DETECTION = 11,
    /// <summary>
    /// FaceRecognition
    /// 人脸识别
    /// </summary>
    FACE_RECOGNITION = 12,
    /// <summary>
    /// NumberStat
    /// 人数统计
    /// </summary>
    NUMBER_STAT = 13,
    /// <summary>
    /// HeatMap
    /// 热度图
    /// </summary>
    HEAT_MAP = 14,
    /// <summary>
    /// VideoDiagnosis
    /// 视频诊断
    /// </summary>
    VIDEO_DIAGNOSIS = 15,
    /// <summary>
    /// VideoEnhance
    /// 视频增强
    /// </summary>
    VIDEO_ENHANCE = 16,
    /// <summary>
    /// Smokefire detect 
    /// 烟火检测
    /// </summary>
    SMOKEFIRE_DETECT = 17,
    /// <summary>
    /// VehicleAnalyse
    /// 车辆特征识别
    /// </summary>
    VEHICLE_ANALYSE = 18,
    /// <summary>
    /// Person feature
    /// 人员特征识别
    /// </summary>
    PERSON_FEATURE = 19,
    /// <summary>
    /// SDFaceDetect
    /// 多预置点人脸检测"SDFaceDetect",配置一条规则但可以在不同预置点下生效
    /// </summary>
    SDFACEDETECTION = 20,
    /// <summary>
    /// HeatMapPlan
    /// 球机热度图计划"HeatMapPlan" 
    /// </summary>
    HEAT_MAP_PLAN = 21,
    /// <summary>
    /// NumberStatPlan
    /// 球机客流量统计计划 "NumberStatPlan"
    /// </summary>
    NUMBERSTAT_PLAN = 22,
    /// <summary>
    /// ATMFD
    /// 金融人脸检测，包括正常人脸、异常人脸、相邻人脸、头盔人脸等针对ATM场景特殊优化
    /// </summary>
    ATMFD = 23,
    /// <summary>
    /// Highway
    /// 高速交通事件检测"Highway"
    /// </summary>
    HIGHWAY = 24,
    /// <summary>
    /// City
    /// 城市交通事件检测 "City"
    /// </summary>
    CITY = 25,
    /// <summary>
    /// LeTrack
    /// 民用简易跟踪"LeTrack"
    /// </summary>
    LETRACK = 26,
    /// <summary>
    /// SCR
    /// 打靶相机"SCR"
    /// </summary>
    SCR = 27,
    /// <summary>
    /// StereoVision
    /// 立体视觉(双目)"StereoVision"
    /// </summary>
    STEREO_VISION = 28,
    /// <summary>
    /// HumanDetect
    /// 人体检测"HumanDetect"
    /// </summary>
    HUMANDETECT = 29,
    /// <summary>
    /// FaceAnalysis
    /// 人脸分析 "FaceAnalysis"
    /// </summary>
    FACE_ANALYSIS = 30,
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_UNDERSPEED's data
  /// 交通欠速事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_UNDERSPEED_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    // <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved2;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Speed Up limit Unit:km/h
    /// 速度上限 单位：km/h
    /// </summary>
    public int nSpeedUpperLimit;
    /// <summary>
    /// Speed Low limit Unit:km/h 
    /// 速度下限 单位：km/h 
    /// </summary>
    public int nSpeedLowerLimit;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved1;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// under speed percentage
    /// 欠速百分比
    /// </summary>
    public int nUnderSpeedingPercentage;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 832)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFICGATE's data
  /// owing to history, if you want to deal with TRAFFICGATE,NET_DEV_EVENT_TRAFFICJUNCTION_INFO and NET_EVENT_IVS_TRAFFICGATE must be handle together;
  /// in addition: EVENT_IVS_TRAFFIC_TOLLGATE only support new tollgate event configuration
  /// 事件类型EVENT_IVS_TRAFFICGATE(交通卡口老规则事件/线圈电警上的交通卡口老规则事件)对应的数据块描述信息
  /// 由于历史原因,如果要处理卡口事件,NET_DEV_EVENT_TRAFFICJUNCTION_INFO和NET_EVENT_IVS_TRAFFICGATE要一起处理,以防止有视频电警和线圈电警同时接入平台的情况发生
  /// 另外NET_EVENT_IVS_TRAFFIC_TOLLGATE只支持新卡口事件的配置
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFICGATE_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// Open gateway status see EM_OPEN_STROBE_STATE
    /// 开闸状态,具体请见EM_OPEN_STROBE_STATE
    /// </summary>
    public byte byOpenStrobeState;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体，车标
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// road number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// the car's actual rate(Km/h)
    /// 车辆实际速度Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// rate upper limit(km/h)
    /// 速度上限 单位：km/h
    /// </summary>
    public int nSpeedUpperLimit;
    /// <summary>
    /// rate lower limit(km/h)
    /// 速度下限 单位：km/h 
    /// </summary>
    public int nSpeedLowerLimit;
    /// <summary>
    /// BreakingRule's mask,first byte: Retrograde;second byte:Overline; the third byte:Overspeed;the forth byte:UnderSpeed;the five byte: crash red light;the six byte:passing(trafficgate),the seven byte: OverYellowLine; the eight byte: WrongRunningRoute; the nine byte: YellowVehicleInRoute; default: trafficgate
    /// 违反规则掩码,第一位:逆行;第二位:压线行驶; 第三位:超速行驶;第四位：欠速行驶; 第五位:闯红灯;第六位:穿过路口(卡口事件);第七位: 压黄线; 第八位: 有车占道; 第九位: 黄牌占道;否则默认为:交通卡口事件
    /// </summary>
    public uint dwBreakingRule;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// vehicle info
    /// 车身信息，有存放车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// manual snap sequence string 
    /// 手动抓拍序号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szManualSnapNo;
    /// <summary>
    /// snap index,such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved;
    /// <summary>
    /// snap flag from device
    /// 设备产生的抓拍标识
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szSnapFlag;
    /// <summary>
    /// snap mode,0-normal 1-globle 2-near 4-snap on the same side 8-snap on the reverse side 16-plant picture
    /// 抓拍方式,0-未分类 1-全景 2-近景 4-同向抓拍 8-反向抓拍 16-号牌图像
    /// </summary>
    public byte bySnapMode;
    /// <summary>
    /// over speed percentage
    /// 超速百分比
    /// </summary>
    public byte byOverSpeedPercentage;
    /// <summary>
    /// under speed percentage
    /// 欠速百分比
    /// </summary>
    public byte byUnderSpeedingPercentage;
    /// <summary>
    /// red light margin, s
    /// 红灯容许间隔时间,单位：秒
    /// </summary>
    public byte byRedLightMargin;
    /// <summary>
    /// drive direction,0-"Approach",where the car is more near,1-"Leave",means where if mor far to the car
    /// 行驶方向,0-上行(即车辆离设备部署点越来越近),1-下行(即车辆离设备部署点越来越远)
    /// </summary>
    public byte byDriveDirection;
    /// <summary>
    /// road way number
    /// 道路编号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szRoadwayNo;
    /// <summary>
    /// violation code
    /// 违章代码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szViolationCode;
    /// <summary>
    /// violation desc
    /// 违章描述
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szViolationDesc;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// car type,"Motor", "Light-duty", "Medium", "Oversize", "Huge", "Other"
    /// 车辆大小类型 Minisize"微型车,"Light-duty"小型车,"Medium"中型车
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szVehicleType;
    /// <summary>
    /// car length, m
    /// 车辆长度, 单位米
    /// </summary>
    public byte byVehicleLenth;
    /// <summary>
    /// LightState means red light status:0 unknown,1 green,2 red,3 yellow
    /// LightState表示红绿灯状态:0 未知,1 绿灯,2 红灯,3 黄灯
    /// </summary>
    public byte byLightState;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    public byte byReserved1;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// over speed margin, km/h
    /// 限高速宽限值    单位：km/h 
    /// </summary>
    public int nOverSpeedMargin;
    /// <summary>
    /// under speed margin, km/h
    /// 限低速宽限值    单位：km/h 
    /// </summary>
    public int nUnderSpeedMargin;
    /// <summary>
    /// DrivingDirection : ["Approach", "Shanghai", "Hangzhou"]
    /// DrivingDirection : ["Approach", "上海", "杭州"]
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3 * 256)]
    public byte[] szDrivingDirection;
    /// <summary>
    /// machine name
    /// 本地或远程设备名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szMachineName;
    /// <summary>
    /// machine address
    /// 机器部署地点、道路编码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szMachineAddress;
    /// <summary>
    /// machine group
    /// 机器分组、设备所属单位
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szMachineGroup;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// The vehicle detector generates the snap signal redundancy info
    /// 由车检器产生抓拍信号冗余信息
    /// </summary>
    public NET_SIG_CARWAY_INFO_EX stuSigInfo;
    /// <summary>
    /// File path
    /// 文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
    public byte[] szFilePath;
    /// <summary>
    /// the begin time of red light
    /// 红灯开始UTC时间
    /// </summary>
    public NET_TIME_EX RedLightUTC;
    /// <summary>
    /// device address,OSD superimposed onto the image,from TrafficSnapshot.DeviceAddress,'\0'means end
    /// 设备地址,OSD叠加到图片上的,来源于配置TrafficSnapshot.DeviceAddress,'\0'结束
    /// </summary>
    public IntPtr szDeviceAddress;
    /// <summary>
    /// Current picture exposure time, in milliseconds
    /// 当前图片曝光时间,单位为毫秒
    /// </summary>
    public float fActualShutter;
    /// <summary>
    /// Current picture gain, ranging from 0 to 1000
    /// 当前图片增益,范围为0~100
    /// </summary>
    public byte byActualGain;
    /// <summary>
    /// 0-S to N  1-SW to NE 2-W to E 3-NW to SE 4-N to S 5-NE to SW 6-E to W 7-SE to NW 8-Unknown
    /// 0-南向北 1-西南向东北 2-西向东 3-西北向东南 4-北向南 5-东北向西南 6-东向西 7-东南向西北 8-未知
    /// </summary>
    public byte byDirection;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    public byte bReserve;
    /// <summary>
    /// Card Number
    /// 卡片个数
    /// </summary>
    public byte bRetCardNumber;
    /// <summary>
    /// Card information
    /// 卡片信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_EVENT_CARD_INFO[] stuCardInfo;
    /// <summary>
    /// Waterproof
    /// 图片防伪码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szDefendCode;
    /// <summary>
    /// Link to balcklist main keyID, 0 invalid >0 blacklist data record
    /// 关联黑名单数据库记录默认主键ID, 0,无效；> 0,黑名单数据记录
    /// </summary>
    public int nTrafficBlackListID;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 452)]
    public byte[] bReserved;
  }

  /// <summary>
  /// strobe state
  /// 道闸状态
  /// </summary>
  public enum EM_OPEN_STROBE_STATE
  {
    /// <summary>
    /// unknown
    /// 未知状态
    /// </summary>
    UNKOWN,
    /// <summary>
    /// close
    /// 关闸
    /// </summary>
    CLOSE,
    /// <summary>
    /// auto open
    /// 自动开闸
    /// </summary>
    AUTO,
    /// <summary>
    /// manual open
    /// 手动开闸
    /// </summary>
    MANUAL,
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_MANUALSNAP's data
  /// 交通手动抓拍事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_MANUALSNAP_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;      // channel ID
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;         // event name
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;         // byte alignment
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;        // PTS(ms)
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;       // the event happen time
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;      // event ID
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;       // lane number
    /// <summary>
    /// manual snap number
    /// 手动抓拍序号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szManualSnapNo;     // manual snap number 
    /// <summary>
    /// have being detected object
    /// 对像信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;      // have being detected object
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;         // have being detected vehicle
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;       // TrafficCar info
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;        // event file info
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;       // Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;       // Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;     // snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;      // picture resolution
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1016)]
    public byte[] bReserved;      // reserved
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;         // public info 
  }

  /// <summary>
  /// event type  EVENT_IVS_TRAFFIC_PARKINGSPACEPARKING(parking space parking)corresponding data block description info
  /// 车位有车事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_PARKINGSPACEPARKING_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public uint PTS;
    /// <summary>
    /// Event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding lane No.
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// Vehicle body info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束 
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// parking space status 0-free 1-not free 2-on line
    /// 车位综合的状态,0-占用,1-空闲,2-压线
    /// </summary>
    public int nParkingSpaceStatus;
    /// <summary>
    /// traffic paring information
    /// 停车场信息
    /// </summary>
    public NET_DEV_TRAFFIC_PARKING_INFO stTrafficParingInfo;
    /// <summary>
    /// The source of plate text, 0:Local,1:Server
    /// 车牌识别来源, 0:本地算法识别,1:后端服务器算法识别
    /// </summary>
    public byte byPlateTextSource;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 379)]
    public byte[] bReserved;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// Parking lot info
  /// 停车场信息
  /// </summary>
  public struct NET_DEV_TRAFFIC_PARKING_INFO
  {
    /// <summary>
    /// Feature image point number
    /// 特征图片区点个数
    /// </summary>
    public int nFeaturePicAreaPointNum;
    /// <summary>
    /// Feature image info
    /// 特征图片区信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_POINT[] stFeaturePicArea;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 572)]
    public byte[] bReserved;
  }

  /// <summary>
  /// event type  EVENT_IVS_TRAFFIC_PARKINGSPACENOPARKING(parking space no parking)corresponding data block description info
  /// 车位无车事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_PARKINGSPACENOPARKING_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public uint PTS;
    /// <summary>
    /// Event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding lane No.
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// Vehicle body info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// traffic paring information
    /// 停车场信息
    /// </summary>
    public NET_DEV_TRAFFIC_PARKING_INFO stTrafficParingInfo;
    /// <summary>
    /// The source of plate text, 0:Local,1:Server
    /// 车牌识别来源, 0:本地算法识别,1:后端服务器算法识别
    /// </summary>
    public byte byPlateTextSource;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 383)]
    public byte[] bReserved;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// event type EVENT_IVS_PARKINGDETECTION corresponding data block description info 
  /// 非法停车事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_PARKINGDETECTION_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// detect region's point number
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// detect region info
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// snap flags(by bit),0bit:"*",1bit:"Timing",2bit:"Manual",3bit:"Marked",4bit:"Event",5bit:"Mosaic",6bit:"Cutout"
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// the source device's index,-1 means data in invalid
    /// 事件源设备上的index,-1表示数据无效
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// the source device's sign(exclusive),field said local device does not exist or is empty
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// event trigger accumilated times
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 616)]
    public byte[] bReserved;
  }

  /// <summary>
  /// event type  EVENT_IVS_TRAFFIC_OVERLINE(traffic-Overline)corresponding data block description info
  /// 交通-压线事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_OVERLINE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index,such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 968)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// event type  EVENT_IVS_TRAFFIC_OVERYELLOWLINE(traffic-OverYellowLine)corresponding data block description info
  /// 交通违章-压黄线对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_OVERYELLOWLINE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// true:corresponding alarm recording; false: no corresponding alarm recording
    /// True:有对应的报警录像; false:无对应的报警录像
    /// </summary>
    public int bIsExistAlarmRecord;
    /// <summary>
    /// Video size
    /// 录像大小
    /// </summary>
    public uint dwAlarmRecordSize;
    /// <summary>
    /// Video Path
    /// 录像路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szAlarmRecordPath;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 532)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// Acme amount of the rule detect zone 
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectNum;
    /// <summary>
    /// Rule detect zone
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// event type EVENT_IVS_TRAFFIC_RETROGRADE corresponding data block description info
  /// 交通-逆行事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_RETROGRADE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 车牌信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index,such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// true:corresponding alarm recording; false: no corresponding alarm recording
    /// True:有对应的报警录像; false:无对应的报警录像
    /// </summary>
    public int bIsExistAlarmRecord;
    /// <summary>
    /// Video size
    /// 录像大小
    /// </summary>
    public uint dwAlarmRecordSize;
    /// <summary>
    /// Video Path
    /// 录像路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szAlarmRecordPath;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved 
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 484)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// Acme amount of the rule detect zone 
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectNum;
    /// <summary>
    /// Rule detect zone
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// event type EVENT_IVS_TRAFFIC_WRONGROUTE corresponding data block description info
  /// 交通违章-不按车道行驶对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_WRONGROUTE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// event file info  
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON  
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved 
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 972)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// New audio detection alarm information 
  /// 新音频检测报警信息
  /// </summary>
  public struct NET_NEW_SOUND_ALARM_STATE
  {
    /// <summary>
    /// alarm channel count
    /// 报警的通道个数
    /// </summary>
    public int channelcount;
    /// <summary>
    /// sound alarm information
    /// 音频报警信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_NEW_SOUND_ALARM_STATE1[] SoundAlarmInfo;
  }

  /// <summary>
  /// New audio detection alarm information
  /// 新音频检测报警信息
  /// </summary>
  public struct NET_NEW_SOUND_ALARM_STATE1
  {
    /// <summary>
    /// alarm channel number
    /// 报警通道号
    /// </summary>
    public int channel;
    /// <summary>
    /// Alarm type;0:Volume value is too low ,1:Volume value is too high
    /// 报警类型；0：音频值过低,1：音频值过高
    /// </summary>
    public int alarmType;
    /// <summary>
    /// Volume
    /// 音量值
    /// </summary>
    public uint volume;
    /// <summary>
    /// volume alarm state, 0: alarm appear, 1: alarm disappear
    /// 音频报警状态, 0: 音频报警出现, 1: 音频报警消失
    /// </summary>
    public byte byState;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 255)]
    public byte[] reserved;
  }

  /// <summary>
  /// struct about audio anomaly alarm information
  /// 音频异常事件对应的数据描述信息
  /// </summary>
  public struct NET_ALARM_AUDIO_ANOMALY
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwStructSize;
    /// <summary>
    /// Event Action,0:Start, 1:Stop
    /// 事件动作, 0:Start, 1:Stop
    /// </summary>
    public uint dwAction;
    /// <summary>
    /// Audio Channel ID 
    /// 音频通道号
    /// </summary>
    public uint dwChannelID;
    /// <summary>
    /// Audio sensitivity
    /// 声音强度
    /// </summary>
    public int nDecibel;
    /// <summary>
    /// Audio frequency
    /// 声音频率
    /// </summary>
    public int nFrequency;
  }

  /// <summary>
  /// struct about audio mutation alarm information
  /// 声强突变事件对应的数据描述信息
  /// </summary>
  public struct NET_ALARM_AUDIO_MUTATION
  {
    /// <summary>
    /// StructSize
    /// 结构体大小
    /// </summary>
    public uint dwStructSize;
    /// <summary>
    /// Event Action,0:Start, 1:Stop
    /// 事件动作, 0:Start, 1:Stop
    /// </summary>
    public uint dwAction;
    /// <summary>
    /// Audio Channel ID
    /// 音频通道号
    /// </summary>
    public uint dwChannelID;
  }

  // 无硬盘报警
  public struct NET_ALARM_NO_DISK_INFO
  {
    public uint dwSize;
    /// <summary>
    /// 时间
    /// time
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// 事件动作, 0:Start, 1:Stop
    /// event action, 0:Start, 1:Stop
    /// </summary>
    public uint dwAction;
  }

  /// <summary>
  /// system ability
  /// 系统能力类型
  /// </summary>
  public enum EM_SYS_ABILITY
  {
    /// <summary>
    /// dynamic connect capacity
    /// 查询动态多连接能力
    /// </summary>
    DYNAMIC_CONNECT = 1,
    /// <summary>
    /// Watermark configuration capacity
    /// 水印配置能力
    /// </summary>
    WATERMARK_CFG = 17,
    /// <summary>
    /// wireless  configuration capacity
    /// wireless配置能力
    /// </summary>
    WIRELESS_CFG = 18,
    /// <summary>
    /// Device capacity list 
    /// 设备的能力列表
    /// </summary>
    DEVALL_INFO = 26,
    /// <summary>
    /// Card number search capacity 
    /// 卡号查询能力
    /// </summary>
    CARD_QUERY = 0x0100,
    /// <summary>
    /// Multiple-window preview capacity 
    /// 多画面预览能力
    /// </summary>
    MULTIPLAY = 0x0101,
    /// <summary>
    /// Fast query configuration Capabilities
    /// 快速查询配置能力
    /// </summary>
    QUICK_QUERY_CFG = 0x0102,
    /// <summary>
    /// Wireless alarm capacity 
    /// 无线报警能力
    /// </summary>
    INFRARED = 0x0121,
    /// <summary>
    /// Alarm activation mode function 
    /// 报警输出触发方式能力
    /// </summary>
    TRIGGER_MODE = 0x0131,
    /// <summary>
    /// Network hard disk partition
    /// 网络硬盘分区能力
    /// </summary>
    DISK_SUBAREA = 0x0141,
    /// <summary>
    /// Query DSP Capabilities
    /// 查询DSP能力
    /// </summary>
    DSP_CFG = 0x0151,
    /// <summary>
    /// Query SIP,RTSP Capabilities
    /// 查询SIP,RTSP能力
    /// </summary>
    STREAM_MEDIA = 0x0161,
    /// <summary>
    /// Search intelligent track capability
    /// 查询智能跟踪能力
    /// </summary>
    INTELLI_TRACKER = 0x0171,
  }

  /// <summary>
  /// device enable information
  /// 设备使能信息
  /// </summary>
  public struct NET_DEV_ENABLE_INFO
  {
    /// <summary>
    /// Function list capacity set. Corresponding to the above mentioned enumeration. Use bit to represent sub-function
    /// 功能列表能力集,下标对应上述的枚举值,按位表示子功能
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public uint[] IsFucEnable;
  }

  /// <summary>
  /// query log type
  /// 查询日志类型
  /// </summary>
  public enum EM_LOG_QUERY_TYPE
  {
    /// <summary>
    /// All logs
    /// 所有日志
    /// </summary>
    ALL = 0,
    /// <summary>
    /// System logs 
    /// 系统日志
    /// </summary>
    SYSTEM,
    /// <summary>
    /// Configuration logs 
    /// 配置日志
    /// </summary>
    CONFIG,
    /// <summary>
    /// Storage logs
    /// 存储相关
    /// </summary>
    STORAGE,
    /// <summary>
    /// Alarm logs 
    /// 报警日志
    /// </summary>
    ALARM,
    /// <summary>
    /// Record related
    /// 录象相关
    /// </summary>
    RECORD,
    /// <summary>
    /// Account related
    /// 帐号相关
    /// </summary>
    ACCOUNT,
    /// <summary>
    /// Clear log 
    /// 清除日志
    /// </summary>
    CLEAR,
    /// <summary>
    /// Playback related 
    /// 回放相关
    /// </summary>
    PLAYBACK,
    /// <summary>
    /// Concerning the front-end management and running
    /// 前端管理运行相关
    /// </summary>
    MANAGER
  }

  /// <summary>
  /// query device log prarm
  /// 查询设备日志参数
  /// </summary>
  public struct NET_QUERY_DEVICE_LOG_PARAM
  {
    /// <summary>
    /// Searched log type
    /// 查询日志类型
    /// </summary>
    public EM_LOG_QUERY_TYPE emLogType;
    /// <summary>
    /// The searched log start time
    /// 查询日志的开始时间
    /// </summary>
    public NET_TIME stuStartTime;
    /// <summary>
    /// The searched log end time
    /// 查询日志的结束时间
    /// </summary>
    public NET_TIME stuEndTime;
    /// <summary>
    /// The search begins from which log in one period. It shall begin with 0 if it is the first time search
    /// 在时间段中从第几条日志开始查询,开始第一次查询可设为0
    /// </summary>
    public int nStartNum;
    /// <summary>
    /// The ended log serial number in one search,the max returning number is 1024
    /// 一次查询中到第几条日志结束,日志返回条数的最大值为1024
    /// </summary>
    public int nEndNum;
    /// <summary>
    /// log struct type,0:NET_DEVICE_LOG_ITEM;1:NET_DEVICE_LOG_ITEM_EX
    /// 日志数据结构体类型,0:表示DH_DEVICE_LOG_ITEM；1:表示NET_DEVICE_LOG_ITEM_EX
    /// </summary>
    public byte nLogStuType;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] reserved;
    /// <summary>
    /// Channel no. 0:Compatible with previous all channel numbers. The channel No. begins with 1.1: The first channel
    /// 通道号,0:兼容之前表示所有通道号,所以通道号从1开始; 1:第一个通道
    /// </summary>
    public uint nChannelID;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
    public byte[] bReserved;
  }

  /// <summary>
  /// device log content
  /// 日志信息
  /// </summary>
  public struct NET_DEVICE_LOG_ITEM
  {
    /// <summary>
    /// Log type 
    /// 日志类型
    /// </summary>
    public int nLogType;
    /// <summary>
    /// Date
    /// 日期
    /// </summary>
    public NETDEVTIME stuOperateTime;
    /// <summary>
    /// Operator
    /// 操作者
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szOperator;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved;
    /// <summary>
    /// union structure type,0:szLogContext;1:stuOldLog
    /// union结构类型,0:szLogContext;1:stuOldLog
    /// </summary>
    public byte bUnionType;
    /// <summary>
    /// 0:Log content,1:Old log structure NET_OLDLOG
    /// 0:日志内容，1：老日志 结构体NET_OLDLOG
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szLogContext;
    /// <summary>
    /// Detail operation
    /// 具体的操作内容
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] reserved;
  }

  /// <summary>
  /// device log content
  /// 设备日志内容
  /// </summary>
  public struct NET_DEVICE_LOG_ITEM_EX
  {
    /// <summary>
    /// Log type 
    /// 日志类型
    /// </summary>
    public int nLogType;
    /// <summary>
    /// Date
    /// 日期
    /// </summary>
    public NETDEVTIME stuOperateTime;
    /// <summary>
    /// Operator
    /// 操作者
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szOperator;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved;
    /// <summary>
    /// union structure type,0:szLogContext;1:stuOldLog
    /// union结构类型,0:szLogContext;1:stuOldLog
    /// </summary>
    public byte bUnionType;
    /// <summary>
    /// 0:Log content,1:Old log structure NET_OLDLOG
    /// 0:日志内容，1：老日志 结构体NET_OLDLOG
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szLogContext;
    /// <summary>
    /// Detail operation
    /// 具体的操作内容
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szOperation;
    /// <summary>
    /// DetailContext
    /// 详细日志信息描述
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4 * 1024)]
    public byte[] szDetailContext;
  }

  /// <summary>
  /// old log content
  /// 老日志内容
  /// </summary>
  public struct NET_OLDLOG
  {
    /// <summary>
    /// Old log
    /// 老日志
    /// </summary>
    public NET_LOG_ITEM stuLog;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>         
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] bReserved;
  }

  /// <summary>
  /// old log content
  /// 老日志内容
  /// </summary>
  public struct NET_LOG_ITEM
  {
    /// <summary>
    /// Date
    /// 日期
    /// </summary>
    public NETDEVTIME time;
    /// <summary>
    /// Type
    /// 日志类型
    /// </summary>
    public ushort type;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    public byte reserved;
    /// <summary>
    /// Data
    /// 数据
    /// </summary>
    public byte data;
    /// <summary>
    /// Content
    /// 内容
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] context;
  }

  /// <summary>
  /// The time definition in the log information
  /// 时间结构体
  /// </summary>
  [StructLayout(LayoutKind.Explicit, Size = 4)]
  public struct NETDEVTIME
  {
    [FieldOffset(0)]
    private uint _value;

    /// <summary>
    /// Second 6bit
    /// 秒 6位
    /// </summary>
    public uint Second
    {
      set
      {
        _value = (value & 0x003f) | (_value & 0xffffffc0);
      }
      get
      {
        return _value & 0x003f;
      }
    }

    /// <summary>
    /// Minute 6bit
    /// 分 6位
    /// </summary>
    public uint Minute
    {
      set
      {
        _value = ((value & 0x003f) << 6) | (_value & 0xfffff03f);
      }
      get
      {
        return (_value >> 6) & 0x003f;
      }
    }

    /// <summary>
    /// Hour 5bit
    /// 小时 5位
    /// </summary>
    public uint Hour
    {
      set
      {
        _value = ((value & 0x001f) << 12) | (_value & 0xfffe0fff);
      }
      get
      {
        return (_value >> 12) & 0x001f;
      }
    }

    /// <summary>
    /// Day 5bit
    /// 天 5位
    /// </summary>
    public uint Day
    {
      set
      {
        _value = ((value & 0x001f) << 17) | (_value & 0xffc3ffff);
      }
      get
      {
        return (_value >> 17) & 0x001f;
      }
    }

    /// <summary>
    /// Month 4bit
    /// 月 4位
    /// </summary>
    public uint Month
    {
      set
      {
        _value = ((value & 0x000f) << 22) | (_value & 0xfc3fffff);
      }
      get
      {
        return (_value >> 22) & 0x000f;
      }
    }

    /// <summary>
    /// Year 6bit 2000-2063
    /// 年 6位 2000-2063
    /// </summary>
    public uint Year
    {
      set
      {
        _value = (((value - 2000) & 0x003f) << 26) | (_value & 0x3ffffff);
      }
      get
      {
        return ((_value >> 26) & 0x003f) + 2000;
      }
    }

    public override string ToString()
    {
      return string.Format("{0}-{1}-{2} {3}:{4}:{5}", Year.ToString("D4"), Month.ToString("D2"), Day.ToString("D2"), Hour.ToString("D2"), Minute.ToString("D2"), Second.ToString("D2"));
    }
  }

  /// <summary>
  /// device enable type
  /// 设备支持功能列表
  /// </summary>
  public enum EM_DEV_ENABLE_TYPE
  {
    /// <summary>
    /// FTP bitwise, 1: send out record file;  2: Send out snapshot file
    /// FTP 按位,1：传送录像文件 2：传送抓图文件
    /// </summary>
    FTP = 0,
    /// <summary>
    /// SMTP bitwise,1: alarm send out text mail 2: Alarm send out image3:support HealthMail
    /// SMTP 按位,1：报警传送文本邮件 2：报警传送图片 3:支持健康邮件功能
    /// </summary>
    SMTP,
    /// <summary>
    /// NTP	 Bitwise:1:Adjust system time 
    /// NTP  按位：1：调整系统时间
    /// </summary>
    NTP,
    /// <summary>
    /// Auto maintenance  Bitwise:1:reboot 2:close  3:delete file
    /// 自动维护 按位：1：重启 2：关闭 3:删除文件
    /// </summary>
    AUTO_MAINTAIN,
    /// <summary>
    /// Privacy mask Bitwise  :1:multiple-window privacy mask
    /// 区域遮挡 按位：1：多区域遮挡
    /// </summary>
    VIDEO_COVER,
    /// <summary>
    /// Auto registration	Bitwise:1:SDK auto log in after registration 
    /// 主动注册 按位：1：注册后sdk主动登陆
    /// </summary>
    AUTO_REGISTER,
    /// <summary>
    /// DHCP	Bitwise 1:DHCP
    /// DHCP 按位：1：DHCP
    /// </summary>
    DHCP,
    /// <summary>
    /// UPNP	Bitwise 1:UPNP
    /// UPNP 按位：1：UPNP
    /// </summary>
    UPNP,
    /// <summary>
    /// COM sniffer  Bitwise :1:CommATM
    /// 串口抓包 按位：1:CommATM
    /// </summary>
    COMM_SNIFFER,
    /// <summary>
    /// Network sniffer Bitwise : 1:NetSniffer
    /// 网络抓包 按位： 1：NetSniffer
    /// </summary>
    NET_SNIFFER,
    /// <summary>
    /// Burn function Bitwise 1:Search burn status 
    /// 刻录功能 按位：1：查询刻录状态
    /// </summary>
    BURN,
    /// <summary>
    /// Video matrix Bitwise  1:Support video matrix or not 2:Support SPOT video matrix or not
    /// 视频矩阵 按位：1：是否支持视频矩阵 2:是否支持SPOT视频矩阵 3:是否支持HDMI视频矩阵
    /// </summary>
    VIDEO_MATRIX,
    /// <summary>
    /// Video detection Bitwise :1:Support video detection or not 
    /// 音频检测 按位：1：是否支持音频检测
    /// </summary>
    AUDIO_DETECT,
    /// <summary>
    /// Storage position Bitwise:1:Ftp server (Ips) 2:SBM 3:NFS 16:DISK 17:Flash disk
    /// 存储位置 按位：1：Ftp服务器(Ips) 2：SMB 3：NFS 4：ISCSI 16：DISK 17：U盘
    /// </summary>
    STORAGE_STATION,
    /// <summary>
    /// IPS storage search  Bitwise  1:IPS storage search
    /// IPS存储查询 按位：1：IPS存储查询
    /// </summary>
    IPSSEARCH,
    /// <summary>
    /// Snapshot Bitwise  1:Resoluiton 2:Frame rate 3:Snapshoot  4:Snapshoot file image; 5:Image quality 
    /// 抓图  按位：1：分辨率2：帧率3：抓图方式4：抓图文件格式5：图画质量
    /// </summary>
    SNAP,
    /// <summary>
    /// Search default network card search  Bitwise  1:Support
    /// 支持默认网卡查询 按位 1：支持
    /// </summary>
    DEFAULTNIC,
    /// <summary>
    /// Image quality configuration time in CBR mode 1:support 
    /// CBR模式下显示画质配置项 按位 1:支持
    /// </summary>
    SHOWQUALITY,
    /// <summary>
    /// Configuration import& emport function capacity.  Bitwise   1:support
    /// 配置导入导出功能能力 按位 1:支持
    /// </summary>
    CONFIG_IMEXPORT,
    /// <summary>
    /// Support search log page by page or not. Bitwise 1:support 
    /// 是否支持分页方式的日志查询 按位 1：支持
    /// </summary>
    LOG,
    /// <summary>
    /// Record setup capacity. Bitwise  1:Redandunce  2:Pre-record 3:Record period
    /// 录像设置的一些能力 按位 1:冗余 2:预录 3:录像时间段
    /// </summary>
    SCHEDULE,
    /// <summary>
    /// Network type. Bitwise 1:Wire Network 2:Wireless Network 3:CDMA/GPRS,4:CDMA/GPRS multi network card
    /// 网络类型按位表示 1:以态网 2:无线局域 3:CDMA/GPRS 4:CDMA/GPRS多网卡配置
    /// </summary>
    NETWORK_TYPE,
    /// <summary>
    /// Important record. Bitwise 1:Important record mark
    /// 标识重要录像 按位:1：设置重要录像标识
    /// </summary>
    MARK_IMPORTANTRECORD,
    /// <summary>
    /// Frame rate control activities. Bitwise 1:support frame rate control activities;2:support timing alarm type activate frame rate control(it does not support dynamic detection), this ability mutually exclusive with ACF ability
    /// 活动帧率控制 按位：1：支持活动帧率控制, 2:支持定时报警类型活动帧率控制(不支持动检),该能力与ACF能力互斥
    /// </summary>
    ACFCONTROL,
    /// <summary>
    /// Multiple-channel extra stream. Bitwise:1:support three channel extra stream
    /// 多路辅码流 按位：1：支持三路辅码流, 2:支持辅码流编码压缩格式独立设置
    /// </summary>
    MULTIASSIOPTION,
    /// <summary>
    /// Component modules bitwise: 1.Separate processing the schedule 2.Standard I franme Interval setting
    /// 组件化模块 按位：1,时间表分开处理 2:标准I帧间隔设置
    /// </summary>
    DAVINCIMODULE,
    /// <summary>
    /// GPS function bitwise:1:Gps locate function
    /// GPS功能 按位：1：Gps定位功能
    /// </summary>
    GPS,
    /// <summary>
    /// Support multi net card query   bitwise: 1: support
    /// 支持多网卡查询 按位 1：支持
    /// </summary>
    MULTIETHERNET,
    /// <summary>
    /// Login properties   bitwise: 1: support query login properties 
    /// Login属性 按位：1：支持Login属性查询
    /// </summary>
    LOGIN_ATTRIBUTE,
    /// <summary>
    /// Recording associated  bitwise: 1:Normal recording; 2:Alarm recording;3:Motion detection recording;  4:Local storage; 5: Network storage ;6:Redundancy storage;  7:Local emergency storage
    /// 录像相关 按位：1,普通录像；2：报警录像；3：动态检测录像；4：本地存储；5：远程存储；6：冗余存储；7：本地紧急存储；8：支持区分主辅码流的远程存储
    /// </summary>
    RECORD_GENERAL,
    /// <summary>
    /// Whether support Json configuration, bitwise: 1: support Json
    /// Json格式配置:按位：1支持Json格式, 2: 使用F6的NAS配置, 3: 使用F6的Raid配置, 4：使用F6的MotionDetect配置, 5：完整支持三代配置(V3),通过F6命令访问
    /// </summary>
    JSON_CONFIG,
    /// <summary>
    /// Hide function:bitwise::1,hide PTZ function
    /// 屏蔽功能：按位：1,屏蔽PTZ云台功能, 2: 屏蔽3G的保活时段功能
    /// </summary>
    HIDE_FUNCTION,
    /// <summary>
    /// Harddisk damage information support ability: bitwise:1,harddisk damage information
    /// 硬盘坏道信息支持能力: 按位：1,硬盘坏道信息查询支持能力
    /// </summary>
    DISK_DAMAGE,
    /// <summary>
    /// Support playback network transmission speed control, bitwise::1 support playback acceleration
    /// 支持回放网传速度控制:按位:1,支持回放加速
    /// </summary>
    PLAYBACK_SPEED_CTRL,
    /// <summary>
    /// Support holiday period setup : bitwise:1,Support holiday period setup
    /// 支持假期时间段配置:按位:1,支持假期时间段配置
    /// </summary>
    HOLIDAYSCHEDULE,
    /// <summary>
    /// ATM fetch money overtime
    /// ATM取钱超时
    /// </summary>
    FETCH_MONEY_TIMEOUT,
    /// <summary>
    /// Device backup support format. DAV, ASF
    /// 备份支持的格式,按位：1:DAV, 2:ASF
    /// </summary>
    BACKUP_VIDEO_FORMAT,
    /// <summary>
    /// backup disk type query
    /// 支持硬盘类型查询
    /// </summary>
    QUERY_DISK_TYPE,
    /// <summary>
    /// backup device output of display (such as VGA) configuration, by bit: 1: configuration on tour of frame segmentation 
    /// 支持设备显示输出（VGA等）配置,按位: 1:画面分割轮巡配置
    /// </summary>
    CONFIG_DISPLAY_OUTPUT,
    /// <summary>
    /// backup extra stream control configuration, by bit: 1-extra stream control configuration
    /// 支持扩展码流录像控制设置, 按位：1-辅码流录像控制设置
    /// </summary>
    SUBBITRATE_RECORD_CTRL,
    /// <summary>
    /// backup IPV6 configuration, by bit:1-IPV6 configuration
    /// 支持IPV6设置, 按位：1-IPV6配置
    /// </summary>
    IPV6,
    /// <summary>
    /// SNMP
    /// SNMP（简单网络管理协议）
    /// </summary>
    SNMP,
    /// <summary>
    /// back up query device's URL info, by bit: 1-query device's config URL info
    /// 支持获取设备URL地址, 按位: 1-查询配置URL地址
    /// </summary>
    QUERY_URL,
    /// <summary>
    /// ISCSI
    /// ISCSI（Internet小型计算机系统接口配置）
    /// </summary>
    ISCSI,
    /// <summary>
    /// Raid
    /// 支持Raid功能
    /// </summary>
    RAID,
    /// <summary>
    /// Support disk info query
    /// 支持磁盘信息查询
    /// </summary>
    HARDDISK_INFO,
    /// <summary>
    /// support picture in pictu,by bit:1,set; 2,preview , record , query record , download record
    /// 支持画中画功能 按位:1,画中画设置; 2,画中画预览、录像存储、查询、下载;3,支持画中画编码配置,同时支持画中画通道查询
    /// </summary>
    PICINPIC,
    /// <summary>
    /// same to EN_PLAYBACK_SPEED_CTRL
    /// 同 EN_PLAYBACK_SPEED_CTRL ,只为了兼容协议
    /// </summary>
    PLAYBACK_SPEED_CTRL_SUPPORT,
    /// <summary>
    /// support LF-X series of 24, 32, 64 channels, label their encode ability with sepcial calculation, by bit 1: able
    /// 支持24、32、64路LF-X系列,标注这类设备特殊的编码能力计算方式
    /// </summary>
    LF_XDEV,
    /// <summary>
    /// support DSP encode
    /// DSP编码能力查询
    /// </summary>
    DSP_ENCODE_CAP,
    /// <summary>
    /// support different multicast config for different channel
    /// 组播能力查询
    /// </summary>
    MULTICAST,
    /// <summary>
    /// query the limit ability of net, bitwise,1-limit size of net send code stream
    /// 网络限制能力查询,按位,1-网络发送码流大小限制,2-支持用户操作数据加密,4-支持配置数据加密
    /// </summary>
    NET_LIMIT,
    /// <summary>
    /// serial port 422
    /// 串口422
    /// </summary>
    COM422,
    /// <summary>
    /// support three generations of framework agrement or not(need actualize listMethod(),listService()),by F6 to visit
    /// 是否支持三代协议框架（需要实现listMethod(),listService()）,通过F6命令访问
    /// </summary>
    PROTOCAL_FRAMEWORK,
    /// <summary>
    /// write disk OSD overlying ,bitwise, 1-write disk OSD overlying configuration
    /// 刻录OSD叠加, 按位, 1-刻录OSD叠加配置
    /// </summary>
    WRITE_DISK_OSD,
    /// <summary>
    /// dynamic multi-connect,bitise,1-request reply video data
    /// 动态多连接, 按位, 1-请求视频数据应答
    /// </summary>
    DYNAMIC_MULTI_CONNECT,
    /// <summary>
    /// cloud service,bitwise,1- support private cloud service
    /// 云服务,按位,1-支持私有云服务
    /// </summary>
    CLOUDSERVICE,
    /// <summary>
    /// Video Information Report, by bit. 1-Active video information report, 2-Frame numbers inquiry support
    /// 录像信息上报, 按位, 1-录像信息主动上报, 2-支持录像帧数查询
    /// </summary>
    RECORD_INFO,
    /// <summary>
    /// Active Register Support, by bit. 1- Dynamic active register support
    /// 主动注册能力,按位,1-支持动态主动注册, 2-主动注册动态多链接支持SDK发起IP,port填0的请求
    /// </summary>
    DYNAMIC_REG,
    /// <summary>
    /// Multi-channel Preview and Playback, by bit. 1-Multi-channel preview and playback support
    /// 多通道预览回放,按为,1-支持多通道预览回放
    /// </summary>
    MULTI_PLAYBACK,
    /// <summary>
    /// Encoding Channel, by bit. 1- Audio-only channel support
    /// 编码通道, 按位, 1-支持纯音频通道, 2-监视支持音视频分开获取
    /// </summary>
    ENCODE_CHN,
    /// <summary>
    /// Record search, by bit, 1-support sync search record, 2-support 3rd generation protocol search record
    /// 录像查询, 按位, 1-支持异步查询录像, 2-支持三代协议查询录像
    /// </summary>
    SEARCH_RECORD,
    /// <summary>
    /// Support MD5 check after update file send finish，1- support MD5
    /// 支持升级文件传输完成后做MD5验证,1-支持MD5验证2-支持三代升级
    /// </summary>
    UPDATE_MD5,
    /// <summary>
    /// protocol3 to F6, 1-support log 2.restore config by configManager.deleteFile protocol
    /// 三代切F6,按位，1-Log日志功能2.DeleteFile 恢复默认配置支持使用configManager.deleteFile协议 
    /// </summary>
    PROTOCOL3ToF6,
  }

  /// <summary>
  /// log type
  /// 日志类型
  /// </summary>
  public enum EM_LOG_TYPE
  {
    /// <summary>
    /// Device reboot
    /// 设备重启
    /// </summary>
    REBOOT = 0x0000,
    /// <summary>
    /// Shut down device
    /// 设备关机
    /// </summary>
    SHUT,
    /// <summary>
    /// Report stop
    /// 报告停止
    /// </summary>
    REPORTSTOP,
    /// <summary>
    /// Rreport start
    /// 报告开始
    /// </summary>
    REPORTSTART,
    /// <summary>
    /// Device Upgrade
    /// 设备升级
    /// </summary>
    UPGRADE = 0x0004,
    /// <summary>
    /// system time update
    /// 系统时间更新
    /// </summary>
    SYSTIME_UPDATE = 0x0005,
    /// <summary>
    /// GPS time update
    /// GPS时间更新
    /// </summary>
    GPS_TIME_UPDATE = 0x0006,
    /// <summary>
    /// Voice intercom, true representative open, false on behalf of the closed
    /// 语音对讲, true代表开启,false代表关闭
    /// </summary>
    AUDIO_TALKBACK,
    /// <summary>
    /// Transparent transmission, true representative open, false on behalf of the closed
    /// 透明传输, true代表开启,false代表关闭
    /// </summary>
    COMM_ADAPTER,
    /// <summary>
    /// Net sync
    /// 网络校时
    /// </summary>
    NET_TIMING,
    /// <summary>
    /// NR
    /// NR
    /// </summary>
    TYPE_NR,
    /// <summary>
    /// Save configuration
    /// 保存配置
    /// </summary>
    CONFSAVE = 0x0100,
    /// <summary>
    /// Read configuration 
    /// 读取配置
    /// </summary>
    CONFLOAD,
    /// <summary>
    /// File system error
    /// 文件系统错误
    /// </summary>
    FSERROR = 0x0200,
    /// <summary>
    /// HDD write error 
    /// 硬盘写错误
    /// </summary>
    HDD_WERR,
    /// <summary>
    /// HDD read error
    /// 硬盘读错误
    /// </summary>
    HDD_RERR,
    /// <summary>
    /// Set HDD type 
    /// 设置硬盘类型
    /// </summary>
    HDD_TYPE,
    /// <summary>
    /// Format HDD
    /// 格式化硬盘
    /// </summary>
    HDD_FORMAT,
    /// <summary>
    /// Current working HDD space is not sufficient
    /// 当前工作盘空间不足
    /// </summary>
    HDD_NOSPACE,
    /// <summary>
    /// Set HDD type as read-write 
    /// 设置硬盘类型为读写盘
    /// </summary>
    HDD_TYPE_RW,
    /// <summary>
    /// Set HDD type as read-only
    /// 设置硬盘类型为只读盘
    /// </summary>
    HDD_TYPE_RO,
    /// <summary>
    /// Set HDD type as redundant 
    /// 设置硬盘类型为冗余盘
    /// </summary>
    HDD_TYPE_RE,
    /// <summary>
    /// Set HDD type as snapshot
    /// 设置硬盘类型为快照盘
    /// </summary>
    HDD_TYPE_SS,
    /// <summary>
    /// No HDD
    /// 无硬盘记录
    /// </summary>
    HDD_NONE,
    /// <summary>
    /// No work HDD
    /// 无工作盘
    /// </summary>
    HDD_NOWORKHDD,
    /// <summary>
    /// Set HDD type to backup HDD
    /// 设置硬盘类型为备份盘
    /// </summary>
    HDD_TYPE_BK,
    /// <summary>
    /// Set HDD type to reserve subarea
    /// 设置硬盘类型为保留分区
    /// </summary>
    HDD_TYPE_REVERSE,
    /// <summary>
    /// note the boot-strap's hard disk info
    /// 记录开机时的硬盘信息
    /// </summary>
    HDD_START_INFO = 0x20e,
    /// <summary>
    /// note the disk number after the disk change
    /// 记录换盘后的工作盘号
    /// </summary>
    HDD_WORKING_DISK,
    /// <summary>
    /// note other errors of disk
    /// 记录硬盘其它错误
    /// </summary>
    HDD_OTHER_ERROR,
    /// <summary>
    /// there has some little errors on disk
    /// 硬盘存在轻微问题
    /// </summary>
    HDD_SLIGHT_ERR,
    /// <summary>
    /// there has some serious errors on disk
    /// 硬盘存在严重问题
    /// </summary>
    HDD_SERIOUS_ERR,
    /// <summary>
    /// the end of the alarm that current disk has no space left
    /// 当前工作盘空间不足报警结束
    /// </summary>
    HDD_NOSPACE_END,
    /// <summary>
    /// Raid control
    /// Raid操作
    /// </summary>
    HDD_TYPE_RAID_CONTROL,
    /// <summary>
    /// excess temperature
    /// 温度过高
    /// </summary>
    HDD_TEMPERATURE_HIGH,
    /// <summary>
    /// lower die temperature
    /// 温度过低
    /// </summary>
    HDD_TEMPERATURE_LOW,
    /// <summary>
    /// remove eSATA
    /// 移除eSATA
    /// </summary>
    HDD_ESATA_REMOVE,
    /// <summary>
    /// External alarm begin 
    /// 外部输入报警开始
    /// </summary>
    ALM_IN = 0x0300,
    /// <summary>
    /// Network alarm input 
    /// 网络报警输入
    /// </summary>
    NETALM_IN,
    /// <summary>
    /// External input alarm stop 
    /// 外部输入报警停止
    /// </summary>
    ALM_END = 0x0302,
    /// <summary>
    /// Video loss alarm begin
    /// 视频丢失报警开始
    /// </summary>
    LOSS_IN,
    /// <summary>
    /// Video loss alarm stop
    /// 视频丢失报警结束
    /// </summary>
    LOSS_END,
    /// <summary>
    /// Motion detection alarm begin
    /// 动态检测报警开始
    /// </summary>
    MOTION_IN,
    /// <summary>
    /// Motion detection alarm stop
    /// 动态检测报警结束
    /// </summary>
    MOTION_END,
    /// <summary>
    /// Annunciator alarm input
    /// 报警器报警输入
    /// </summary>
    ALM_BOSHI,
    /// <summary>
    /// Network disconnected
    /// 网络断开
    /// </summary>
    NET_ABORT = 0x0308,
    /// <summary>
    /// Network connection restore 
    /// 网络恢复
    /// </summary>
    NET_ABORT_RESUME,
    /// <summary>
    /// Encoder error
    /// 编码器故障
    /// </summary>
    CODER_BREAKDOWN,
    /// <summary>
    /// Encoder error restore 
    /// 编码器故障恢复
    /// </summary>
    CODER_BREAKDOWN_RESUME,
    /// <summary>
    /// Camera masking
    /// 视频遮挡
    /// </summary>
    BLIND_IN,
    /// <summary>
    /// Restore camera masking 
    /// 视频遮挡恢复
    /// </summary>
    BLIND_END,
    /// <summary>
    /// High temperature 
    /// 温度过高
    /// </summary>
    ALM_TEMP_HIGH,
    /// <summary>
    /// Low voltage
    /// 电压过低
    /// </summary>
    ALM_VOLTAGE_LOW,
    /// <summary>
    /// Battery capacity is not sufficient 
    /// 电池容量不足
    /// </summary>
    ALM_BATTERY_LOW,
    /// <summary>
    /// ACC power off 
    /// ACC断电
    /// </summary>
    ALM_ACC_BREAK,
    /// <summary>
    /// ACC res
    /// ACC重置
    /// </summary>
    ALM_ACC_RES,
    /// <summary>
    /// GPS signal lost
    /// GPS无信号
    /// </summary>
    GPS_SIGNAL_LOST,
    /// <summary>
    /// GPS signal resume
    /// GPS信号恢复
    /// </summary>
    GPS_SIGNAL_RESUME,
    /// <summary>
    /// 3G signal lost
    /// 3G无信号
    /// </summary>
    LOG_3G_SIGNAL_LOST,
    /// <summary>
    /// 3G signal resume
    /// 3G信号恢复
    /// </summary>
    LOG_3G_SIGNAL_RESUME,
    /// <summary>
    /// IPC external alarms
    /// IPC外部报警
    /// </summary>
    ALM_IPC_IN,
    /// <summary>
    /// IPC external alarms recovery
    /// IPC外部报警恢复
    /// </summary>
    ALM_IPC_END,
    /// <summary>
    /// Broken network alarm
    /// 断网报警
    /// </summary>
    ALM_DIS_IN,
    /// <summary>
    /// Broken network alarm recovery
    /// 断网报警恢复
    /// </summary>
    ALM_DIS_END,
    /// <summary>
    /// UPS alarm 
    /// UPS告警
    /// </summary>
    ALM_UPS_IN,
    /// <summary>
    /// UPS alarm resume 
    /// UPS告警恢复
    /// </summary>
    ALM_UPS_END,
    /// <summary>
    /// NAS server abnormal alarm 
    /// NAS服务器异常报警
    /// </summary>
    ALM_NAS_IN,
    /// <summary>
    /// NAS server abnormal alarm resume 
    /// NAS服务器异常报警恢复
    /// </summary>
    ALM_NAS_END,
    /// <summary>
    /// Redundant power alarm 
    /// 冗余电源告警
    /// </summary>
    ALM_REDUNDANT_POWER_IN,
    /// <summary>
    /// Redundant alarm resume 
    /// 冗余电源告警恢复
    /// </summary>
    ALM_REDUNDANT_POWER_END,
    /// <summary>
    /// Record failure alarm 
    /// 录像失败告警
    /// </summary>
    ALM_RECORD_FAILED_IN,
    /// <summary>
    /// Record failure alarm resume 
    /// 录像失败告警恢复
    /// </summary>
    ALM_RECORD_FAILED_END,
    /// <summary>
    /// Storage pool abnormal alarm
    /// 存储池异常报警
    /// </summary>
    ALM_VGEXCEPT_IN,
    /// <summary>
    /// Storage abnormal alarm resume 
    /// 存储池异常报警恢复
    /// </summary>
    ALM_VGEXCEPT_END,
    /// <summary>
    /// Fan alarm starts
    /// 风扇报警开始
    /// </summary>
    ALM_FANSPEED_IN,
    /// <summary>
    /// Fan alarm stops 
    /// 风扇报警结束
    /// </summary>
    ALM_FANSPEED_END,
    /// <summary>
    /// Frame loss alarm starts 
    /// 丢帧报警开始
    /// </summary>
    ALM_DROP_FRAME_IN,
    /// <summary>
    /// Frame loss alarm stops
    /// 丢帧报警结束
    /// </summary>
    ALM_DROP_FRAME_END,
    /// <summary>
    /// HDD pre-check tour alarm event log type 
    /// 磁盘预检巡检报警事件日志类型
    /// </summary>
    ALM_DISK_STATE_CHECK,
    /// <summary>
    /// HDCVI smoke alarm event
    /// 同轴烟感报警事件
    /// </summary>
    ALARM_COAXIAL_SMOKE,
    /// <summary>
    /// HDCVI temperature alarm event
    /// 同轴温度报警事件
    /// </summary>
    ALARM_COAXIAL_TEMP_HIGH,
    /// <summary>
    /// HDCVI external alarm event 
    /// 同轴外部报警事件
    /// </summary>
    ALARM_COAXIAL_ALM_IN,
    /// <summary>
    /// Wireless alarm begin 
    /// 无线报警开始
    /// </summary>
    INFRAREDALM_IN = 0x03a0,
    /// <summary>
    /// Wireless alarm end 
    /// 无线报警结束
    /// </summary>
    INFRAREDALM_END,
    /// <summary>
    /// IP conflict 
    /// IP冲突
    /// </summary>
    IPCONFLICT,
    /// <summary>
    /// IP restore
    /// IP恢复
    /// </summary>
    IPCONFLICT_RESUME,
    /// <summary>
    /// SD Card insert
    /// SD卡插入
    /// </summary>
    SDPLUG_IN,
    /// <summary>
    /// SD Card Pull-out
    /// SD卡拔出
    /// </summary>
    SDPLUG_OUT,
    /// <summary>
    /// Failed to bind port
    /// 网络端口绑定失败
    /// </summary>
    NET_PORT_BIND_FAILED,
    /// <summary>
    /// Hard disk error beep reset 
    /// 硬盘错误报警蜂鸣结束
    /// </summary>
    HDD_BEEP_RESET,
    /// <summary>
    /// MAC conflict
    /// MAC冲突
    /// </summary>
    MAC_CONFLICT,
    /// <summary>
    /// MAC conflict resume
    /// MAC冲突恢复
    /// </summary>
    MAC_CONFLICT_RESUME,
    /// <summary>
    /// alarm out
    /// 报警输出状态
    /// </summary>
    ALARM_OUT,
    /// <summary>
    /// RAID state event  
    /// RAID状态变化事件
    /// </summary>
    ALM_RAID_STAT_EVENT,
    /// <summary>
    /// Fire alarm, smoker or high temperature
    /// 火警报警,烟感或温度
    /// </summary>
    ABLAZE_ON,
    /// <summary>
    /// Fire alarm reset 
    /// 火警报警恢复
    /// </summary>
    ABLAZE_OFF,
    /// <summary>
    /// Intelligence pulse alarm
    /// 智能脉冲型报警
    /// </summary>
    INTELLI_ALARM_PLUSE,
    /// <summary>
    /// Intelligence alarm start
    /// 智能报警开始
    /// </summary>
    INTELLI_ALARM_IN,
    /// <summary>
    /// Intelligence alarm end
    /// 智能报警结束
    /// </summary>
    INTELLI_ALARM_END,
    /// <summary>
    /// 3G signal scan
    /// 3G信号检测
    /// </summary>
    LOG_3G_SIGNAL_SCAN,
    /// <summary>
    /// GPS signal scan
    /// GPS信号检测
    /// </summary>
    GPS_SIGNAL_SCAN,
    /// <summary>
    /// Auto record
    /// 自动录像
    /// </summary>
    AUTOMATIC_RECORD = 0x0400,
    /// <summary>
    /// Manual record 
    /// 手动录象
    /// </summary>
    MANUAL_RECORD = 0x0401,
    /// <summary>
    /// Stop record
    /// 停止录象
    /// </summary>
    CLOSED_RECORD,
    /// <summary>
    /// Log in
    /// 登录
    /// </summary>
    LOGIN = 0x0500,
    /// <summary>
    /// Log off 
    /// 注销
    /// </summary>
    LOGOUT,
    /// <summary>
    /// Add user
    /// 添加用户
    /// </summary>
    ADD_USER,
    /// <summary>
    /// Delete user
    /// 删除用户
    /// </summary>
    DELETE_USER,
    /// <summary>
    /// Modify user 
    /// 修改用户
    /// </summary>
    MODIFY_USER,
    /// <summary>
    /// Add user group 
    /// 添加用户组
    /// </summary>
    ADD_GROUP,
    /// <summary>
    /// Delete user group 
    /// 删除用户组
    /// </summary>
    DELETE_GROUP,
    /// <summary>
    /// Modify user group 
    /// 修改用户组
    /// </summary>
    MODIFY_GROUP,
    /// <summary>
    /// Network Login
    /// 网络用户登录
    /// </summary>
    NET_LOGIN = 0x0508,
    /// <summary>
    /// Modify password
    /// 修改密码
    /// </summary>
    MODIFY_PASSWORD,
    /// <summary>
    /// Clear log 
    /// 清除日志
    /// </summary>
    CLEAR = 0x0600,
    /// <summary>
    /// Search log 
    /// 查询日志
    /// </summary>
    SEARCHLOG,
    /// <summary>
    /// Search record
    /// 录像查询
    /// </summary>
    SEARCH = 0x0700,
    /// <summary>
    /// Record download
    /// 录像下载
    /// </summary>
    DOWNLOAD,
    /// <summary>
    /// Record playback
    /// 录像回放
    /// </summary>
    PLAYBACK,
    /// <summary>
    /// Backup recorded file 
    /// 备份录像文件
    /// </summary>
    BACKUP,
    /// <summary>
    /// Failed to backup recorded file
    /// 备份录像文件失败
    /// </summary>
    BACKUPERROR,
    /// <summary>
    /// Real-time backup, that is, copy CD
    /// 实时备份,即光盘刻录
    /// </summary>
    BACK_UPRT,
    /// <summary>
    /// CD copy
    /// 光盘复制
    /// </summary>
    BACKUPCLONE,
    /// <summary>
    /// Manual changed
    /// 手动换盘
    /// </summary>
    DISK_CHANGED,
    /// <summary>
    /// Image playback
    /// 图片回放
    /// </summary>
    IMAGEPLAYBACK,
    /// <summary>
    /// Lock the video
    /// 锁定录像
    /// </summary>
    LOCKFILE,
    /// <summary>
    /// Unlock the video
    /// 解锁录像
    /// </summary>
    UNLOCKFILE,
    /// <summary>
    /// Add log superposition of ATM card number
    /// ATM卡号叠加添加日志
    /// </summary>
    ATMPOS,
    /// <summary>
    /// Pause
    /// 暂停回放
    /// </summary>
    PLAY_PAUSE,
    /// <summary>
    /// Start
    /// 正放
    /// </summary>
    PLAY_START,
    /// <summary>
    /// Stop
    /// 停止回放
    /// </summary>
    PLAY_STOP,
    /// <summary>
    /// Back
    /// 倒放
    /// </summary>
    PLAY_BACK,
    /// <summary>
    /// Fast
    /// 快放
    /// </summary>
    PLAY_FAST,
    /// <summary>
    /// Slow
    /// 慢放
    /// </summary>
    PLAY_SLOW,
    /// <summary>
    /// Search
    /// 智能检索
    /// </summary>
    SMART_SEARCH,
    /// <summary>
    /// Snap
    /// 录像抓图
    /// </summary>
    RECORD_SNAP,
    /// <summary>
    /// Add tag
    /// 添加标签
    /// </summary>
    ADD_TAG,
    /// <summary>
    /// Delete tag
    /// 删除标签
    /// </summary>
    DEL_TAG,
    /// <summary>
    /// USB connected
    /// 发现USB设备
    /// </summary>
    USB_IN,
    /// <summary>
    /// USB disconnected
    /// USB设备断开连接
    /// </summary>
    USB_OUT,
    /// <summary>
    /// Backup file
    /// 文件备份
    /// </summary>
    BACKUP_FILE,
    /// <summary>
    /// Backup log
    /// 日志备份
    /// </summary>
    BACKUP_LOG,
    /// <summary>
    /// Backup config
    /// 配置备份
    /// </summary>
    BACKUP_CONFIG,
    /// <summary>
    /// Time update
    /// 时间同步
    /// </summary>
    TIME_UPDATE = 0x0800,
    /// <summary>
    /// remote diary 
    /// 远程日志
    /// </summary>
    REMOTE_STATE = 0x0850,
    /// <summary>
    /// User define
    /// 用户定义
    /// </summary>
    USER_DEFINE = 0x0900,
  }

  /// <summary>
  /// event type EVENT_IVS_CROSSLINEDETECTION corresponding data block description info
  /// 警戒线事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_CROSSLINE_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// rule detect line
    /// 规则检测线
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectLine;
    /// <summary>
    /// rule detect line's point number
    /// 规则检测线顶点数
    /// </summary>
    public int nDetectLineNum;
    /// <summary>
    /// object moveing track
    /// 物体运动轨迹
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] TrackLine;
    /// <summary>
    /// object moveing track's point number
    /// 物体运动轨迹顶点数
    /// </summary>
    public int nTrackLineNum;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// direction, 0-left to right, 1-right to left
    /// 表示入侵方向, 0-由左至右, 1-由右至左
    /// </summary>
    public byte bDirection;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// the source device's index,-1 means data in invalid
    /// 事件源设备上的index,-1表示数据无效,-1表示数据无效
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// the source device's sign(exclusive),field said local device does not exist or is empty
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// event trigger accumulated times
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 476)]
    public byte[] bReserved;
  }

  /// <summary>
  /// event type EVENT_IVS_CROSSREGIONDETECTION corresponding data block description info
  /// 警戒区事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_CROSSREGION_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved2;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// rule detect region
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// rule detect region's point number
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// object moving track
    /// 物体运动轨迹
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] TrackLine;
    /// <summary>
    /// object moving track's point number
    /// 物体运动轨迹顶点数
    /// </summary>
    public int nTrackLineNum;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// direction, 0-in, 1-out,2-apaer,3-leave
    /// 表示入侵方向, 0-进入, 1-离开,2-出现,3-消失
    /// </summary>
    public byte bDirection;
    /// <summary>
    /// action type,0-appear 1-disappear 2-in area 3-cross area
    /// 表示检测动作类型,0-出现 1-消失 2-在区域内 3-穿越区域
    /// </summary>
    public byte bActionType;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON  
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// the source device's index,-1 means data in invalid
    /// 事件源设备上的index,-1表示数据无效
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// the source device's sign(exclusive),field said local device does not exist or is empty
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// event trigger times
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 536)]
    public byte[] bReserved;
    /// <summary>
    /// Detect object amount
    /// 检测到的物体个数
    /// </summary>
    public int nObjectNum;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_MSG_OBJECT[] stuObjectIDs;
    /// <summary>
    /// Locus amount(Corresponding to the detected object amount.)
    /// 轨迹数(与检测到的物体个数对应)
    /// </summary>
    public int nTrackNum;
    /// <summary>
    /// Locus info(Corresponding to the detected object)
    /// 轨迹信息(与检测到的物体对应)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_POLY_POINTS[] stuTrackInfo;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
  }

  /// <summary>
  /// 事件类型EVENT_IVS_LEFTDETECTION(物品遗留事件)对应的数据块描述信息
  /// the describe of EVENT_IVS_LEFTDETECTION's data
  /// </summary>
  public struct NET_DEV_EVENT_LEFT_INFO
  {
    /// <summary>
    /// 通道号
    /// ChannelId
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件名称
    /// event name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 字节对齐
    /// byte alignment
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// PTS(ms)
    /// </summary>
    public double PTS;
    /// <summary>
    /// 事件发生的时间
    /// the event happen time
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// 事件ID
    /// event ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// 检测到的物体
    /// have being detected object
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// 事件对应文件信息
    /// event file info
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end;
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// byte alignment
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// 规则检测区域顶点数
    /// detect region point number
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// 规则检测区域
    /// detect region
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// flag(by bit),see NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// 事件源设备上的index,-1表示数据无效
    /// the source device's index,-1 means data in invalid
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// the source device's sign(exclusive),field said local device does not exist or is empty
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// 事件触发累计次数
    /// event trigger accumilated times
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// 智能事件公共信息
    /// intelli comm info
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// 事件触发的预置点号，从1开始（没有表示未知）
    /// Event triggered preset period, starting from 1 (no unknown)
    /// </summary>
    public short nPreserID;
    /// <summary>
    /// 事件触发的预置名称
    /// Preset name for event triggered
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPresetName;
    /// <summary>
    /// 扩展信息
    /// Extension info
    /// </summary>
    public NET_EXTENSION_INFO stuExtensionInfo;
    /// <summary>
    /// 保留字节,留待扩展.
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 290)]
    public byte[] bReserved;
  };

  // 事件类型EVENT_IVS_WANDERDETECTION(徘徊事件)对应的数据块描述信息
  public struct NET_DEV_EVENT_WANDER_INFO
  {
    public int nChannelID;                         // 通道号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;                        // 事件名称
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;                      // 字节对齐
    public double PTS;                                // 时间戳(单位是毫秒)
    public NET_TIME_EX UTC;                                // 事件发生的时间
    public int nEventID;                           // 事件ID
    public NET_EVENT_FILE_INFO stuFileInfo;                        // 事件对应文件信息
    public byte bEventAction;                       // 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;                      // 保留字节
    public byte byImageIndex;                       // 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    public int nObjectNum;                         // 检测到的物体个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_MSG_OBJECT[] stuObjectIDs;   // 检测到的物体
    public int nTrackNum;                          // 轨迹数(与检测到的物体个数对应)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_POLY_POINTS[] stuTrackInfo;   // 轨迹信息(与检测到的物体对应)
    public int nDetectRegionNum;                   // 规则检测区域顶点数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;    // 规则检测区域
    public uint dwSnapFlagMask;                     // 抓图标志(按位),具体见NET_RESERVED_COMMON    
    public int nSourceIndex;                       // 事件源设备上的index,-1表示数据无效
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;           // 事件源设备唯一标识,字段不存在或者为空表示本地设备
    public uint nOccurrenceCount;                   // 事件触发累计次数
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;         // 智能事件公共信息
    public short nPreserID;                            // 事件触发的预置点号，从1开始（没有表示未知）
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPresetName;                  // 事件触发的预置名称
    public NET_EXTENSION_INFO stuExtensionInfo;                   // 扩展信息
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 426)]
    public byte[] bReserved;                     // 保留字节,留待扩展.
  };

  // 事件类型EVENT_IVS_CROSSFENCEDETECTION(翻越围栏事件)对应的数据块描述信息
  public struct NET_DEV_EVENT_CROSSFENCEDETECTION_INFO
  {
    public int nChannelID;                                 // 通道号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;                                // 事件名称
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;                              // 字节对齐
    public double PTS;                                        // 时间戳(单位是毫秒)
    public NET_TIME_EX UTC;                                        // 事件发生的时间
    public int nEventID;                                   // 事件ID
    public NET_MSG_OBJECT stuObject;                                  // 检测到的物体
    public int nUpstairsLinePointNumber;                   // 围栏上边线顶点数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] stuUpstairsLine;    // 围栏上边线信息
    public int nDownstairsLinePointNumber;                 // 围栏下边线顶点数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] stuDownstairsLine;  // 围栏下边线信息  
    public int nTrackLineNum;                              // 物体运动轨迹顶点数     
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] TrackLine;           // 物体运动轨迹
    public NET_EVENT_FILE_INFO stuFileInfo;                                // 事件对应文件信息
    public byte bEventAction;                               // 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    public byte bDirection;                                 // 表示入侵方向, 0-由左至右, 1-由右至左
    public byte byReserved;
    public byte byImageIndex;                               // 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    public uint dwSnapFlagMask;                             // 抓图标志(按位),具体见NET_RESERVED_COMMON    
    public int nSourceIndex;                               // 事件源设备上的index,-1表示数据无效
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;                   // 事件源设备唯一标识,字段不存在或者为空表示本地设备
    public uint nOccurrenceCount;                           // 事件触发累计次数
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;                 // 智能事件公共信息
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 616)]
    public byte[] bReserved;                             // 保留字节,留待扩展.    
  };

  //事件类型 EVENT_IVS_CLIMBDETECTION(攀高检测事件)对应数据块描述信息
  public struct NET_DEV_EVENT_IVS_CLIMB_INFO
  {
    public int nChannelID;                                 // 通道号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;                                // 事件名称
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;                              // 字节对齐
    public double PTS;                                        // 时间戳(单位是毫秒)
    public NET_TIME_EX UTC;                                        // 事件发生的时间
    public int nEventID;                                   // 事件ID
    public NET_MSG_OBJECT stuObject;                                  // 检测到的物体
    public NET_EVENT_FILE_INFO stuFileInfo;                                // 事件对应文件信息
    public NET_RESOLUTION_INFO stuResolution;                              // 对应图片的分辨率
    public int nDetectLineNum;                             // 规则检测线顶点数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectLine;         // 规则检测线
    public byte bEventAction;                               // 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    public byte byImageIndex;                               // 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    public uint nOccurrenceCount;                           // 事件触发累计次数
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;                 // 智能事件公共信息
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 890)]
    public byte bReserved;                            // 保留字节
  }
  /// <summary>
  /// 事件类型EVENT_IVS_TAKENAWAYDETECTION(物品搬移事件)对应的数据块描述信息
  /// the describe of EVENT_IVS_TAKENAWAYDETECTION's data
  /// </summary>
  public struct NET_DEV_EVENT_TAKENAWAYDETECTION_INFO
  {
    /// <summary>
    /// 通道号
    /// ChannelId
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 事件名称
    /// event name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 字节对齐
    /// byte alignment
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// PTS(ms)
    /// </summary>
    public double PTS;
    /// <summary>
    /// 事件发生的时间
    /// the event happen time
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// 事件ID
    /// event ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// 检测到的物体
    /// have being detected object
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// 规则检测区域顶点数
    /// detect region's point number
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// 规则检测区域
    /// detect region info
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// 事件对应文件信息
    /// event file info
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end;
    /// </summary>
    public byte bEventAction;
    /// <summary>
    ///  byte alignment
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON    
    /// flag(by bit),see NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// 事件源设备上的index,-1表示数据无效
    /// the source device's index,-1 means data in invalid
    /// </summary>
    public int nSourceIndex;
    /// <summary>
    /// 事件源设备唯一标识,字段不存在或者为空表示本地设备
    /// the source device's sign(exclusive),field said local device does not exist or is empty
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSourceDevice;
    /// <summary>
    /// 事件触发累计次数
    /// event trigger accumilated times 
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// 智能事件公共信息
    /// intelli comm info
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// 事件触发的预置点号，从1开始（没有表示未知）
    /// Event triggered preset period, starting from 1 (no unknown)
    /// </summary>
    public short nPreserID;
    /// <summary>
    /// 事件触发的预置名称
    /// Preset name for event triggered
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPresetName;
    /// <summary>
    /// 扩展信息
    /// Extension info
    /// </summary>
    public NET_EXTENSION_INFO stuExtensionInfo;
    /// <summary>
    /// 保留字节,留待扩展.
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 418)]
    public byte[] bReserved;
  };

  /// <summary>
  /// 场景变更事件，ReloadPicture(对应事件 EVENT_IVS_SCENE_CHANGE)
  /// </summary>
  public struct NET_DEV_ALRAM_SCENECHANGE_INFO
  {
    /// <summary>
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 持续型事件动作, 1表示开始, 2表示停止
    /// </summary>
    public int nEventAction;
    /// <summary>
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double dbPTS;
    /// <summary>
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX stuUTC;
    /// <summary>
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// 抓图标志(按位),具体见 NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// 保留字节,留待扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  };

  /// <summary>
  /// poly point information
  /// 区域或曲线顶点信息
  /// </summary>
  public struct NET_POLY_POINTS
  {
    /// <summary>
    /// point number
    /// 顶点数
    /// </summary>
    public int nPointNum;
    /// <summary>
    /// point info
    /// 顶点信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] stuPoints;
  }

  #region HARD DISK
  /// <summary>
  /// hard disk's basic information
  /// 硬盘的基本信息
  /// </summary>
  public struct NET_DEV_DEVICE_INFO
  {
    /// <summary>
    /// model
    /// 型号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string byModle;
    /// <summary>
    /// serial number
    /// 序列号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string bySerialNumber;
    /// <summary>
    /// firmware no
    /// 固件号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string byFirmWare;
    /// <summary>
    /// ATA protocol version no.
    /// ATA协议版本号
    /// </summary>
    public int nAtaVersion;
    /// <summary>
    /// smart information no.
    /// smart 信息数
    /// </summary>
    public int nSmartNum;
    /// <summary>
    /// sectors
    /// 扇区
    /// </summary>
    public long Sectors;
    /// <summary>
    /// disk state 0-normal 1-abnormal
    /// 磁盘状态 0-正常 1-异常
    /// </summary>
    public int nStatus;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 33)]
    public int[] nReserved;
  }

  /// <summary>
  /// smart information of harddisk, there may be many items up to more than 30
  /// 硬盘的smart信息,可能会有很多条,最多不超过30个
  /// </summary>
  public struct NET_DEV_SMART_VALUE
  {
    /// <summary>
    /// ID
    /// ID
    /// </summary>
    public byte byId;
    /// <summary>
    /// attribute values
    /// 属性值
    /// </summary>
    public byte byCurrent;
    /// <summary>
    /// maximum error value 
    /// 最大出错值
    /// </summary>
    public byte byWorst;
    /// <summary>
    /// threshold value 
    /// 阈值
    /// </summary>
    public byte byThreshold;
    /// <summary>
    /// property name
    /// 属性名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName;
    /// <summary>
    /// actual value
    /// 实际值
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string szRaw;
    /// <summary>
    /// state
    /// 状态
    /// </summary>
    public int nPredict;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] reserved;
  }

  /// <summary>
  /// search hard disk smart information
  /// 硬盘smart信息查询
  /// </summary>
  public struct NET_DEV_SMART_HARDDISK
  {
    /// <summary>
    /// disk number
    /// 硬盘号
    /// </summary>
    public byte nDiskNum;
    /// <summary>
    /// Raid sub disk, 0:single disk
    /// Raid子盘,0表示单盘
    /// </summary>
    public byte byRaidNO;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// device information
    /// 设备信息
    /// </summary>
    public NET_DEV_DEVICE_INFO deviceInfo;
    /// <summary>
    /// smart information
    /// 硬盘smart信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 30)]
    public NET_DEV_SMART_VALUE[] smartValue;
  }
  #endregion
  #region <<Access Control>>

  /// <summary>
  /// Entrance Card Record Query Conditions
  /// 门禁卡记录查询条件
  /// </summary>
  public struct NET_FIND_RECORD_ACCESSCTLCARD_CONDITION
  {
    public uint dwSize;
    /// <summary>
    /// Card Number
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// User ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// Whether effective, TRUE: effective, FALSE: invalid 
    /// 是否有效, TRUE:有效,FALSE:无效
    /// </summary>
    public bool bIsValid;
    /// <summary>
    /// Card inquire condition effects or not, for member szCardNo
    /// 卡号查询条件是否有效,针对成员 szCardNo
    /// </summary>
    public bool abCardNo;
    /// <summary>
    /// User ID inquire condition effects or not, for member  szUserID
    /// 用户ID查询条件是否有效,针对成员 szUserID
    /// </summary>
    public bool abUserID;
    /// <summary>
    /// IsValid inquire condition effects or not, for member  bIsValid
    /// IsValid查询条件是否有效,针对成员 bIsValid
    /// </summary>
    public bool abIsValid;
  }

  /// <summary>
  /// Entrance Guard Record Information
  /// 门禁卡记录集信息
  /// </summary>
  public struct NET_RECORDSET_ACCESS_CTL_CARD
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Record Number,Read-Only
    /// 记录集编号,只读
    /// </summary>
    public Int32 nRecNo;
    /// <summary>
    /// Creat Time
    /// 创建时间
    /// </summary>
    public NET_TIME stuCreateTime;
    /// <summary>
    /// Card number
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// User's ID
    /// 用户ID, 设备暂不支持
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// Card Stetue
    /// 卡状态
    /// </summary>
    public EM_ACCESSCTLCARD_STATE emStatus;
    /// <summary>
    /// Card Type
    /// 卡类型
    /// </summary>
    public EM_ACCESSCTLCARD_TYPE emType;
    /// <summary>
    /// Card Password
    /// 卡密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPsw;
    /// <summary>
    /// Valid Door Number
    /// 有效的门数目
    /// </summary>
    public int nDoorNum;
    /// <summary>
    /// Privileged Door Number,That is CFG_CMD_ACCESS_EVENT Configure Array Subscript
    /// 有权限的门序号,即CFG_CMD_ACCESS_EVENT配置的数组下标
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] sznDoors;
    /// <summary>
    /// the Number of Effective Open Time
    /// 有效的的开门时间段数目
    /// </summary>
    public int nTimeSectionNum;
    /// <summary>
    /// Open Time Segment Index,That is CFG_ACCESS_TIMESCHEDULE_INFO Array subscript
    /// 开门时间段索引,即CFG_ACCESS_TIMESCHEDULE_INFO的数组下标
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] sznTimeSectionNo;
    /// <summary>
    /// Frequency of Use
    /// 使用次数,仅当来宾卡时有效
    /// </summary>
    public int nUseTime;
    /// <summary>
    /// Valid Start Time 
    /// 开始有效期, 设备暂不支持时分秒
    /// </summary>
    public NET_TIME stuValidStartTime;
    /// <summary>
    /// Valid End Time
    /// 结束有效期, 设备暂不支持时分秒
    /// </summary>
    public NET_TIME stuValidEndTime;
    /// <summary>
    /// Wether Valid,True =Valid,False=Invalid
    /// 是否有效,TRUE有效;FALSE无效
    /// </summary>
    public bool bIsValid;
    /// <summary>
    /// fingerprint data info (send only), DEPRECATED! use stuFingerPrintInfoEx instead
    /// 下发指纹数据信息，仅为兼容性保留，请使用 stuFingerPrintInfoEx
    /// </summary>
    public NET_ACCESSCTLCARD_FINGERPRINT_PACKET stuFingerPrintInfo;
    /// <summary>
    /// has first card or not
    /// 是否拥有首卡权限
    /// </summary>
    public bool bFirstEnter;
    /// <summary>
    /// card naming
    /// 卡命名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCardName;
    /// <summary>
    /// VTO link position
    /// 门口机关联位置
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szVTOPosition;
    /// <summary>
    /// Card for handicap, TRUE:yes, FALSE:no
    /// 是否为残疾人卡
    /// </summary>
    public bool bHandicap;
    /// <summary>
    /// Enabled member stuFingerPrintInfoEx
    /// 启用成员 stuFingerPrintInfoEx
    /// </summary>
    public bool bEnableExtended;
    /// <summary>
    /// fingerprint data info structure
    /// 指纹数据信息
    /// </summary>
    public NET_ACCESSCTLCARD_FINGERPRINT_PACKET_EX stuFingerPrintInfoEx;
    /// <summary>
    /// face detection data number,can not > 20
    /// 人脸数据个数不超过20
    /// </summary>
    public int nFaceDataNum;
    /// <summary>
    /// face detection data
    /// 人脸模版数据
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 * 2048)]
    public byte[] szFaceData;
    /// <summary>
    /// dynamic check code
    /// 动态校验码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szDynamicCheckCode;
    /// <summary>
    /// repeat enter route num 
    /// 反潜路径个数
    /// </summary>
    public int nRepeatEnterRouteNum;
    /// <summary>
    /// repeat enter route
    /// 反潜路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public int[] arRepeatEnterRoute;
    /// <summary>
    /// repeat enter route timeout
    /// 反潜超时时间
    /// </summary>
    public int nRepeatEnterRouteTimeout;
    /// <summary>
    /// enable to new field, TRUE: user nNewDoorNum,nNewDoors
    /// 是否启动新开门授权字段，TRUE表示使用nNewDoorNum和nNewDoors字段下发开门权限
    /// </summary>
    public bool bNewDoor;
    /// <summary>
    /// Valid Door Number;
    /// 有效的门数目;
    /// </summary>
    public int nNewDoorNum;
    /// <summary>
    /// Privileged Door Number, That is CFG_CMD_ACCESS_EVENT Configure Array Subscript
    /// 有权限的门序号,即CFG_CMD_ACCESS_EVENT配置的数组下标
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public int[] nNewDoors;
    /// <summary>
    /// the Number of Effective Open Time
    /// 有效的的开门时间段数目
    /// </summary>
    public int nNewTimeSectionNum;
    /// <summary>
    /// Open Time Segment Index,That is CFG_ACCESS_TIMESCHEDULE_INFO Array subscript
    /// 开门时间段索引,即CFG_ACCESS_TIMESCHEDULE_INFO的数组下标
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public int[] nNewTimeSectionNo;
    /// <summary>
    /// ID card no
    /// 身份证号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCitizenIDNo;
    /// <summary>
    /// SpecialDaysSchedule Number
    /// 假日计划表示数量
    /// </summary>
    public int nSpecialDaysScheduleNum;
    /// <summary>
    /// SpecialDaysSchedule Identification
    /// 假日计划标识
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public int[] arSpecialDaysSchedule;
    /// <summary>
    /// user type, 0:common, 1:blacklist
    /// 用户类型, 0 普通用户, 1 黑名单用户
    /// </summary>
    public uint nUserType;
  }

  /// <summary>
  /// fingerprint data, for sending only
  /// 指纹数据，只用于下发信息
  /// </summary>
  public struct NET_ACCESSCTLCARD_FINGERPRINT_PACKET
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// length of a finger print packet, unit: byte
    /// 单个数据包长度,单位字节
    /// </summary>
    public Int32 nLength;
    /// <summary>
    /// packet count 
    /// 包个数
    /// </summary>
    public Int32 nCount;
    /// <summary>
    /// all fingerprint packet in a single buffer, allocated and filled by user, nLength*nCount bytes
    /// 所有指纹数据包，用户申请内存并填充，长度为 nLength*nCount
    /// </summary>
    public IntPtr pPacketData;

  }

  /// <summary>
  /// fingerprint data, for sending and receiving
  /// 指纹数据扩展，可用于下发和获取信息
  /// </summary>
  public struct NET_ACCESSCTLCARD_FINGERPRINT_PACKET_EX
  {
    /// <summary>
    /// length of a finger print packet, unit: byte
    /// 单个数据包长度,单位字节
    /// </summary>
    public int nLength;
    /// <summary>
    /// packet count 
    /// 包个数
    /// </summary>
    public int nCount;
    /// <summary>
    /// all fingerprint packet in a single buffer, allocated by user
    /// 所有指纹数据包, 用户申请内存,大小至少为nLength * nCount
    /// </summary>
    public IntPtr pPacketData;
    /// <summary>
    /// pPacketData buffer length, set by user
    /// 指向内存区的大小，用户填写
    /// </summary>
    public int nPacketLen;
    /// <summary>
    /// The actual fingerprint size returned to the user, equal to nLength*nCount
    /// 返回给用户实际指纹总大小
    /// </summary>
    public int nRealPacketLen;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byReverseed;
  }

  /// <summary>
  /// Entrance Guard Event
  /// 门禁事件
  /// </summary>
  public struct NET_ALARM_ACCESS_CTL_EVENT_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Door Channel Number  
    /// 门通道号
    /// </summary>
    public Int32 nDoor;
    /// <summary>
    /// Entrance Guard Name
    /// 门禁名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szDoorName;
    /// <summary>
    /// Alarm Event Triggered Time
    /// 报警事件发生的时间
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// Entrance Guard Event Type
    /// 门禁事件类型
    /// </summary>
    public EM_ACCESS_CTL_EVENT_TYPE emEventType;
    /// <summary>
    /// Swing Card Result,True is Success,False is Fail
    /// 刷卡结果,TRUE表示成功,FALSE表示失败
    /// </summary>
    public bool bStatus;
    /// <summary>
    /// Card Type
    /// 卡类型
    /// </summary>
    public EM_ACCESSCTLCARD_TYPE emCardType;
    /// <summary>
    /// Open The Door Method
    /// 开门方式
    /// </summary>
    public EM_ACCESS_DOOROPEN_METHOD emOpenMethod;
    /// <summary>
    /// Card Number
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// Password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szPwd;
    /// <summary>
    /// Reader ID
    /// 门读卡器ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szReaderID;
    /// <summary>
    /// unlock user
    /// 开门用户
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szUserID;
    /// <summary>
    /// snapshot picture storage address
    /// 抓拍照片存储地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szSnapURL;
    /// <summary>
    /// Reason of unlock failure, only because it is valid when bStatus is FALSE:0x00 no error,0x10 unauthorized,0x11 card lost or cancelled,0x12 no door right,0x13 unlock mode error,0x14 valid period error,0x15 anti sneak into mode
    /// 0x16 forced alarm not unlocked,0x17 door NC status,0x18 AB lock status,0x19 patrol card,0x1A device is under intrusion alarm status,0x20 period error,0x21 unlock period error in holiday period,0x30 first card right check required,0x40 card correct, input password error
    /// 0x41 card correct, input password timed out,0x42 card correct, input fingerprint error,0x43 card correct, input fingerprint timed out,0x44 fingerprint correct, input password error,0x45 fingerprint correct, input password timed out,0x50 group unlock sequence error,0x51 test required for group unlock,0x60 test passed, control unauthorized
    /// 开门失败的原因,仅在bStatus为FALSE时有效：0x00 没有错误，0x10 未授权，0x11 卡挂失或注销，0x12 没有该门权限，0x13 开门模式错误，0x14 有效期错误，0x15 防反潜模式，0x16 胁迫报警未打开，0x17 门常闭状态，0x18 AB互锁状态，0x19 巡逻卡，0x1A 设备处于闯入报警状态，0x20 时间段错误
    /// 0x21 假期内开门时间段错误，0x30 需要先验证有首卡权限的卡片，0x40 卡片正确,输入密码错误，0x41 卡片正确,输入密码超时，0x42 卡片正确,输入指纹错误，0x43 卡片正确,输入指纹超时，0x44 指纹正确,输入密码错误，0x45 指纹正确,输入密码超时，0x50 组合开门顺序错误，0x51 组合开门需要继续验证，0x60 验证通过,控制台未授权
    /// </summary>
    public Int32 nErrorCode;
    /// <summary>
    /// punching record number
    /// 刷卡记录集中的记录编号
    /// </summary>
    public Int32 nPunchingRecNo;
    public int nNumbers;                           // 抓图张数
    public EM_ACCESSCTLCARD_STATE emStatus;                           // 卡状态
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szSN;                           // 智能锁序列号
    public EM_ATTENDANCESTATE emAttendanceState;                  // 考勤状态
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
    public string szQRCode;                      // 二维码
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szCallLiftFloor;        // 呼梯楼层号
  }

  /// <summary>
  /// Access control status event
  /// 门禁状态事件
  /// </summary>
  public struct NET_ALARM_ACCESS_CTL_STATUS_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Door channel no.
    /// 门通道号
    /// </summary>
    public int nDoor;
    /// <summary>
    /// Event time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// Access control status
    /// 门禁状态
    /// </summary>
    public EM_ACCESS_CTL_STATUS_TYPE emStatus;
  };

  /// <summary>
  /// Record New Operation (Insert)Parameter
  /// 记录集新增操作(插入)参数
  /// </summary>
  public struct NET_CTRL_RECORDSET_INSERT_PARAM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Record Information(User Write)
    /// 记录集信息(用户填写)
    /// </summary>
    public NET_CTRL_RECORDSET_INSERT_IN stuCtrlRecordSetInfo;
    /// <summary>
    /// Record Information(the Device Come Back)
    /// 记录集信息(设备返回)
    /// </summary>
    public NET_CTRL_RECORDSET_INSERT_OUT stuCtrlRecordSetResult;
  }

  /// <summary>
  /// New Record Set Operation(Insert)Parameter
  /// 记录集新增操作(插入)输入参数
  /// </summary>
  public struct NET_CTRL_RECORDSET_INSERT_IN
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Record Information Type
    /// 记录集信息类型
    /// </summary>
    public EM_NET_RECORD_TYPE emType;
    /// <summary>
    /// Record Information Cache,The EM_NET_RECORD_TYPE Note is Details
    /// 记录集信息缓存,详见EM_NET_RECORD_TYPE注释，由用户申请内存
    /// </summary>
    public IntPtr pBuf;
    /// <summary>
    /// Record Information Cache Size
    /// 记录集信息缓存大小,大小参照记录集信息类型对应的结构体
    /// </summary>
    public Int32 nBufLen;
  }

  /// <summary>
  /// Record New Operation(Insert) Parameter
  /// 记录集新增操作(插入)输出参数
  /// </summary>
  public struct NET_CTRL_RECORDSET_INSERT_OUT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Record Number(The Device Come Back When New Insert )
    /// 记录编号(新增插入时设备返回)
    /// </summary>
    public Int32 nRecNo;
  }

  /// <summary>
  /// Entrance Guard Control Ability
  /// 门禁控制能力
  /// </summary>
  public struct CFG_CAP_ACCESSCONTROL
  {
    /// <summary>
    /// Class Number of Entrance Guard
    /// 门禁组数
    /// </summary>
    public Int32 nAccessControlGroups;
  }

  /// <summary>
  /// Record Operation Parameter
  /// 记录集操作参数
  /// </summary>
  public struct NET_CTRL_RECORDSET_PARAM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record Information Type
    /// 记录集信息类型
    /// </summary>
    public EM_NET_RECORD_TYPE emType;
    /// <summary>
    /// New/Renew/Inquire,It is Record Information Cache,the EM_NET_RECORD_TYPE Note is Details),Delete,It is Record Number(Int type)
    /// 新增\更新\查询\导入时,为记录集信息缓存,详见EM_NET_RECORD_TYPE注释,由用户申请内存，长度为nBufLen,删除时,为记录编号(int型),清除时为NULL
    /// </summary>
    public IntPtr pBuf;
    /// <summary>
    /// Record Information Cache Size
    /// 记录集信息缓存大小,大小参照记录集信息类型对应的结构体
    /// </summary>
    public int nBufLen;
  }

  /// <summary>
  /// Card Status
  /// 卡状态
  /// </summary>
  public enum EM_ACCESSCTLCARD_STATE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN = -1,
    /// <summary>
    /// Normal
    /// 正常
    /// </summary>
    NORMAL = 0,
    /// <summary>
    /// Lose
    /// 挂失
    /// </summary>
    LOSE = 0x01,
    /// <summary>
    /// Logoff
    /// 注销
    /// </summary>
    LOGOFF = 0x02,
    /// <summary>
    /// Freeze
    /// 冻结
    /// </summary>
    FREEZE = 0x04,
    /// <summary>
    /// Arrears
    /// 欠费
    /// </summary>
    ARREARAGE = 0x08,
    /// <summary>
    /// Overdue
    /// 逾期
    /// </summary>
    OVERDUE = 0x10,
    /// <summary>
    /// Pre-Arrears(still can open the door)
    /// 预欠费(还是可以开门,但有语音提示)
    /// </summary>
    PREARREARAGE = 0x20,
  }

  /// <summary>
  /// Card Type
  /// 卡类型
  /// </summary>
  public enum EM_ACCESSCTLCARD_TYPE
  {
    /// <summary>
    /// unknow
    /// 未知
    /// </summary>
    UNKNOWN = -1,
    /// <summary>
    /// General Card
    /// 一般卡
    /// </summary>
    GENERAL,
    /// <summary>
    /// VIP Card
    /// VIP卡
    /// </summary>
    VIP,
    /// <summary>
    /// Guest Card
    /// 来宾卡
    /// </summary>
    GUEST,
    /// <summary>
    /// Patrol Card
    /// 巡逻卡
    /// </summary>
    PATROL,
    /// <summary>
    /// Blacklist Card
    /// 黑名单卡
    /// </summary>
    BLACKLIST,
    /// <summary>
    /// Corce Card
    /// 胁迫卡
    /// </summary>
    CORCE,
    /// <summary>
    /// Polling Card
    /// 巡检卡
    /// </summary>
    POLLING,
    /// <summary>
    /// Mother Card
    /// 母卡
    /// </summary>
    MOTHERCARD = 0xff,
  }

  /// <summary>
  /// Entrance Guard Event Type
  /// 门禁事件类型
  /// </summary>
  public enum EM_ACCESS_CTL_EVENT_TYPE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// Get In
    /// 进门
    /// </summary>
    ENTRY,
    /// <summary>
    /// Get Out
    /// 出门
    /// </summary>
    EXIT,
  }

  /// <summary>
  /// Door Open Method(Entrance Guard Event,Entrance Guard get In/Out Record，Actual Open Door Method)
  /// 开门方式(门禁事件,门禁出入记录,实际的开门方式)
  /// </summary>
  public enum EM_ACCESS_DOOROPEN_METHOD
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// Password
    /// 密码开锁
    /// </summary>
    PWD_ONLY,
    /// <summary>
    /// Card
    /// 刷卡开锁
    /// </summary>
    CARD,
    /// <summary>
    /// First Card Then Password
    /// 先刷卡后密码开锁
    /// </summary>
    CARD_FIRST,
    /// <summary>
    /// First Password Then Card 
    /// 先密码后刷卡开锁
    /// </summary>
    PWD_FIRST,
    /// <summary>
    /// Long-Range Open,Such as Through theIndoor Unit or Unlock the Door Machine Platform
    /// 远程开锁,如通过室内机或者平台对门口机开锁
    /// </summary>
    REMOTE,
    /// <summary>
    /// Open Door Button
    /// 开锁按钮进行开锁
    /// </summary>
    BUTTON,
    /// <summary>
    /// fingerprint lock
    /// 指纹开锁
    /// </summary>
    FINGERPRINT,
    /// <summary>
    /// password+swipe card+fingerprint combination unlock
    /// 密码+刷卡+指纹组合开锁
    /// </summary>
    PWD_CARD_FINGERPRINT,
    /// <summary>
    /// password+fingerprint combination unlock
    /// 密码+指纹组合开锁
    /// </summary>
    PWD_FINGERPRINT = 10,
    /// <summary>
    /// swipe card+fingerprint combination unlock
    /// 刷卡+指纹组合开锁
    /// </summary>
    CARD_FINGERPRINT = 11,
    /// <summary>
    /// multi-people unlock
    /// 多人开锁
    /// </summary>
    PERSONS = 12,
    /// <summary>
    /// Key
    /// 钥匙开门
    /// </summary>
    KEY = 13,
    /// <summary>
    /// Use force password to open the door 
    /// 胁迫密码开门
    /// </summary>
    COERCE_PWD = 14,
    /// <summary>
    /// face recogniton to open the door
    /// 人脸识别开门
    /// </summary>
    FACE_RECOGNITION = 16,
  }

  /// <summary>
  /// record type
  /// 记录类型
  /// </summary>
  public enum EM_NET_RECORD_TYPE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// Traffic white list account record.search criteria corresponding to FIND_RECORD_TRAFFICREDLIST_CONDITION structure,record info corresponding to NET_TRAFFIC_LIST_RECORD structure
    /// 交通白名单账户记录.查询条件对应 FIND_RECORD_TRAFFICREDLIST_CONDITION 结构体,记录信息对应 NET_TRAFFIC_LIST_RECORD 结构体
    /// </summary>
    TRAFFICWHITELIST,
    /// <summary>
    /// Traffic black list account record.search criteria corresponding to FIND_RECORD_TRAFFICREDLIST_CONDITION structure,record info corresponding to NET_TRAFFIC_LIST_RECORD structure
    /// 交通白名单账户记录.查询条件对应 FIND_RECORD_TRAFFICREDLIST_CONDITION 结构体,记录信息对应 NET_TRAFFIC_LIST_RECORD 结构体
    /// </summary>
    TRAFFICBLACKLIST,
    /// <summary>
    /// burning case record.search criteria corresponding to FIND_RECORD_BURN_CASE_CONDITION structure,record info corresponding to NET_BURN_CASE_INFO structure 
    /// 刻录案件记录.查询条件对应 FIND_RECORD_BURN_CASE_CONDITION 结构体,记录信息对应 NET_BURN_CASE_INFO 结构体
    /// </summary>                                         
    BURN_CASE,
    /// <summary>
    /// access control card,search criteria corresponding to FIND_RECORD_ACCESSCTLCARD_CONDITION structure,record info corresponding to NET_RECORDSET_ACCESS_CTL_CARD structure
    /// 门禁卡.查询条件对应 FIND_RECORD_ACCESSCTLCARD_CONDITION 结构体,记录信息对应 NET_RECORDSET_ACCESS_CTL_CARD 结构体
    /// </summary>
    ACCESSCTLCARD,
    /// <summary>
    /// access control password.search criteria corresponding to FIND_RECORD_ACCESSCTLPWD_CONDITION structure,record info corresponding to NET_RECORDSET_ACCESS_CTL_PWD
    /// 门禁密码.查询条件对应 FIND_RECORD_ACCESSCTLPWD_CONDITION 结构体,记录信息对应 NET_RECORDSET_ACCESS_CTL_PWD
    /// </summary>          
    ACCESSCTLPWD,
    /// <summary>
    /// access control in/out record.search criteria corresponding to FIND_RECORD_ACCESSCTLCARDREC_CONDITION structure,record info corresponding to
    /// 门禁出入记录（必须同时按卡号和时间段查询,建议用NET_RECORD_ACCESSCTLCARDREC_EX查询.查询条件对应 FIND_RECORD_ACCESSCTLCARDREC_CONDITION 结构体,记录信息对应 NET_RECORDSET_ACCESS_CTL_CARDREC 结构体
    /// </summary>                                                               
    ACCESSCTLCARDREC,
    /// <summary>
    /// holiday record set.search criteria corresponding to FIND_RECORD_ACCESSCTLHOLIDAY_CONDITION structure,record info corresponding to NET_RECORDSET_HOLIDAY
    /// 假日记录集.查询条件对应 FIND_RECORD_ACCESSCTLHOLIDAY_CONDITION 结构体,记录信息对应 NET_RECORDSET_HOLIDAY 结构体
    /// </summary>
    ACCESSCTLHOLIDAY,
    /// <summary>
    /// search Traffic flow record.search criteria corresponding to FIND_RECORD_TRAFFICFLOW_CONDITION structure,record info corresponding to NET_RECORD_TRAFFIC_FLOW_STATE structure
    /// 查询交通流量记录.查询条件对应 FIND_RECORD_TRAFFICFLOW_CONDITION 结构体,记录信息对应 NET_RECORD_TRAFFIC_FLOW_STATE 结构体
    /// </summary>
    TRAFFICFLOW_STATE,
    /// <summary>
    /// call record.search criteria corresponding to FIND_RECORD_VIDEO_TALK_LOG_CONDITION structure,record info corresponding to NET_RECORD_VIDEO_TALK_LOG structure 
    /// 通话记录.查询条件对应 FIND_RECORD_VIDEO_TALK_LOG_CONDITION 结构体,记录信息对应 NET_RECORD_VIDEO_TALK_LOG 结构体
    /// </summary>                                       
    VIDEOTALKLOG,
    /// <summary>
    /// status record.search criteria corresponding to FIND_RECORD_REGISTER_USER_STATE_CONDITION structure,record info corresponding to NET_RECORD_REGISTER_USER_STATE structure
    /// 状态记录.查询条件对应 FIND_RECORD_REGISTER_USER_STATE_CONDITION 结构体,记录信息对应 NET_RECORD_REGISTER_USER_STATE 结构体
    /// </summary>
    REGISTERUSERSTATE,
    /// <summary>
    /// contact record.search criteria corresponding to FIND_RECORD_VIDEO_TALK_CONTACT_CONDITION structure,record info corresponding to NET_RECORD_VIDEO_TALK_CONTACT structure
    /// 联系人记录.查询条件对应 FIND_RECORD_VIDEO_TALK_CONTACT_CONDITION 结构体,记录信息对应 NET_RECORD_VIDEO_TALK_CONTACT 结构体
    /// </summary>                                 
    VIDEOTALKCONTACT,
    /// <summary>
    /// annoinncement record.search criteria corresponding to FIND_RECORD_ANNOUNCEMENT_CONDITION structure,record info corresponding to NET_RECORD_ANNOUNCEMENT_INFO structure
    /// 公告记录.查询条件对应 FIND_RECORD_ANNOUNCEMENT_CONDITION 结构体,记录信息对应 NET_RECORD_ANNOUNCEMENT_INFO 结构体
    /// </summary>
    ANNOUNCEMENT,
    /// <summary>
    /// alarm record.search criteria corresponding to FIND_RECORD_ALARMRECORD_CONDITION structure,record info corresponding to NET_RECORD_ALARMRECORD_INFO structure
    /// 报警记录.查询条件对应 FIND_RECORD_ALARMRECORD_CONDITION 结构体,记录信息对应 NET_RECORD_ALARMRECORD_INFO 结构体
    /// </summary>
    ALARMRECORD,
    /// <summary>
    /// commodity notice record.search criteria corresponding to FIND_RECORD_COMMODITY_NOTICE_CONDITION structure,record info corresponding to NET_RECORD_COMMODITY_NOTICE structure
    /// 下发商品记录.查询条件对应 FIND_RECORD_COMMODITY_NOTICE_CONDITION 结构体,记录信息对应 NET_RECORD_COMMODITY_NOTICE 结构体
    /// </summary>
    COMMODITYNOTICE,
    /// <summary>
    /// healthcare notice.search criteria corresponding to FIND_RECORD_HEALTH_CARE_NOTICE_CONDITION structure,record info corresponding to NET_RECORD_HEALTH_CARE_NOTICE structure
    /// 就诊信息记录.查询条件对应 FIND_RECORD_HEALTH_CARE_NOTICE_CONDITION 结构体,记录信息对应 NET_RECORD_HEALTH_CARE_NOTICE 结构体
    /// </summary>
    HEALTHCARENOTICE,
    /// <summary>
    /// A&C entry-exit record(can select some critera to search. Please replace NET_RECORD_ACCESSCTLCARDREC).Search criteria corresponding to strcture FIND_RECORD_ACCESSCTLCARDREC_CONDITION_EX,Record info corresponding to structre NET_RECORDSET_ACCESS_CTL_CARDREC
    /// 门禁出入记录(可选择部分条件查询,建议替代NET_RECORD_ACCESSCTLCARDREC).查询条件对应 NET_FIND_RECORD_ACCESSCTLCARDREC_CONDITION_EX 结构体,记录信息对应 NET_RECORDSET_ACCESS_CTL_CARDREC 结构体
    /// </summary>
    ACCESSCTLCARDREC_EX,
    /// <summary>
    /// GPS position information reocrd, support import and clear only.Record info corresponding to structure NET_RECORD_GPS_LOCATION_INFO
    /// GPS位置信息记录, 只实现import和clear.记录信息对应 NET_RECORD_GPS_LOCATION_INFO 结构体
    /// </summary>
    GPS_LOCATION,
    /// <summary>
    /// public rental tenants record. search criteria corresponding to FIND_RECORD_RESIDENT_CONDTION structure,record info corresponding to NET_RECORD_RESIDENT_INFO structure
    /// 公租房租户信息.查询条件对应 FIND_RECORD_RESIDENT_CONDTION结构体,记录信息对应 NET_RECORD_RESIDENT_INFO 结构体
    /// </summary>
    RESIDENT,
    /// <summary>
    /// sensor record. search criteria corresponding to FIND_RECORD_SENSORRECORD_CONDITION structure,record info corresponding to NET_RECORD_SENSOR_RECORD structure
    /// 监测量数据记录.查询条件对应 FIND_RECORD_SENSORRECORD_CONDITION 结构体,记录信息对应 NET_RECORD_SENSOR_RECORD 结构体
    /// </summary>
    SENSORRECORD,
    /// <summary>
    /// AccessQRCode record. record info corresponding to NET_RECORD_ACCESSQRCODE_INFO structure
    /// 开门二维码记录集.记录信息对应 NET_RECORD_ACCESSQRCODE_INFO结构体
    /// </summary>
    ACCESSQRCODE,
    /// <summary>
    /// electronic tag info record.Search criteria corresponding to structure FIND_RECORD_ELECTRONICSTAG_CONDITION,Record info corresponding to NET_RECORD_ELECTRONICSTAG_INFO
    /// 电子车牌查询.查询条件对应FIND_RECORD_ELECTRONICSTAG_CONDITION 结构体,记录信息对应NET_RECORD_ELECTRONICSTAG_INFO 结构体
    /// </summary>
    ELECTRONICSTAG,
    /// <summary>
    /// Access blue tooth record.Search blue tooth access record corresponding to structure FIND_RECORD_ACCESS_BLUETOOTH_INFO_CONDITION,Record info corresponding to structure NET_RECORD_ACCESS_BLUETOOTH_INF
    /// 蓝牙开门记录集.查询条件对应 FIND_RECORD_ACCESS_BLUETOOTH_INFO_CONDITION 结构体,记录信息对应 NET_RECORD_ACCESS_BLUETOOTH_INFO 结构体
    /// </summary>
    ACCESS_BLUETOOTH,
  }

  /// <summary>
  /// Access Control Status Type
  /// 门禁状态类型
  /// </summary>
  public enum EM_ACCESS_CTL_STATUS_TYPE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// Open
    /// 开门
    /// </summary>
    OPEN,
    /// <summary>
    /// Close
    /// 关门
    /// </summary>
    CLOSE,
    /// <summary>
    /// Abnormal
    /// 异常
    /// </summary>
    ABNORMAL,
  }

  /// <summary>
  /// Entrance Guard Record  Information
  /// 门禁密码记录集信息
  /// </summary>
  public struct NET_RECORDSET_ACCESS_CTL_PWD
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record Number,Read-Only
    /// 记录集编号,只读
    /// </summary>
    public int nRecNo;
    /// <summary>
    /// Create Time
    /// 创建时间
    /// </summary>
    public NET_TIME stuCreateTime;
    /// <summary>
    /// User's ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szUserID;
    /// <summary>
    /// Open Password
    /// 开门密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szDoorOpenPwd;
    /// <summary>
    /// Alarm Password
    /// 报警密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szAlarmPwd;
    /// <summary>
    /// Valid Door Number
    /// 有效的的门数目
    /// </summary>
    public int nDoorNum;
    /// <summary>
    /// Privileged Door Number,That is CFG_CMD_ACCESS_EVENT Configure Array Subscript
    /// 有权限的门序号，即CFG_CMD_ACCESS_EVENT配置CFG_ACCESS_EVENT_INFO的数组下标
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] sznDoors;
    /// <summary>
    /// VTO link position
    /// 门口机关联位置
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szVTOPosition;
  }

  /// <summary>
  /// FindRecord    Interface Input Parameters 
  /// FindRecord接口输入参数
  /// </summary>
  public struct NET_IN_FIND_RECORD_PARAM
  {
    /// <summary>
    ///  Structure Size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// The record type to query
    /// 待查询记录类型
    /// </summary>
    public EM_NET_RECORD_TYPE emType;
    /// <summary>
    /// Query types corresponding to the query conditions,the space application by the user,according to query condition type,find corresponding structure,then ensure memory size
    /// 查询类型对应的查询条件,由用户申请内存，根据查询记录类型，找到查询条件对应的结构体，进而确定内存大小
    /// </summary>
    public IntPtr pQueryCondition;
  }

  /// <summary>
  /// FindRecord  Interface Output Parameters 
  /// FindRecord接口输出参数
  /// </summary>
  public struct NET_OUT_FIND_RECORD_PARAM
  {
    /// <summary>
    /// Structure Size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Query Log Handle,Uniquely identifies a certain query
    /// 查询记录句柄,唯一标识某次查询
    /// </summary>
    public IntPtr lFindeHandle;
  }

  /// <summary>
  /// FindNextRecord  Interface Input Parameters 
  /// FindNextRecord接口输入参数
  /// </summary>
  public struct NET_IN_FIND_NEXT_RECORD_PARAM
  {
    /// <summary>
    /// Structure Size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Query Log Handle
    /// 查询句柄
    /// </summary>
    public IntPtr lFindeHandle;
    /// <summary>
    /// The current number of records  need query 
    /// 当前想查询的记录条数
    /// </summary>
    public int nFileCount;
  }

  /// <summary>
  /// FindNextRecord  Interface Output Parameters
  /// FindNextRecord接口输出参数
  /// </summary>
  public struct NET_OUT_FIND_NEXT_RECORD_PARAM
  {
    /// <summary>
    /// Structure Size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record List, the user allocates memory, ensure structure by query record type(EM_NET_RECORD_TYPE) of NET_IN_FIND_RECORD_PARAM,then ensure memory size
    /// 记录列表,用户分配内存,根据NET_IN_FIND_RECORD_PARAM中的查询类型EM_NET_RECORD_TYPE，确定对应结构体，进入确定内存大小
    /// </summary>
    public IntPtr pRecordList;
    /// <summary>
    /// Max list Record Number 
    /// 最大查询列表记录数
    /// </summary>
    public int nMaxRecordNum;
    /// <summary>
    /// Query to the number of records, when the query to the article number less than want to query the number, end
    /// 查询到的记录条数,当查询到的条数小于想查询的条数时,查询结束
    /// </summary>
    public int nRetRecordNum;
  }

  /// <summary>
  /// QueryRecordCount port input parameter
  /// QueryRecordCount接口输入参数
  /// </summary>
  public struct NET_IN_QUEYT_RECORD_COUNT_PARAM
  {
    /// <summary>
    /// structure size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// search handle
    /// 查询句柄
    /// </summary>
    public IntPtr lFindeHandle;
  }

  /// <summary>
  /// QueryRecordCount port output parameter
  /// QueryRecordCount接口输出参数
  /// </summary>
  public struct NET_OUT_QUEYT_RECORD_COUNT_PARAM
  {
    /// <summary>
    /// structure size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// device return record item
    /// 设备返回的记录条数
    /// </summary>
    public int nRecordCount;
  }

  /// <summary>
  /// extry/exit search criteria
  /// 门禁出入记录查询条件
  /// </summary>
  public struct NET_FIND_RECORD_ACCESSCTLCARDREC_CONDITION_EX
  {
    public uint dwSize;
    /// <summary>
    /// Enable card search
    /// 启用卡号查询
    /// </summary>
    public bool bCardNoEnable;
    /// <summary>
    /// Card No.
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// Enable search by period
    /// 启用时间段查询
    /// </summary>
    public bool bTimeEnable;
    /// <summary>
    /// Start time 
    /// 起始时间
    /// </summary>
    public NET_TIME stStartTime;
    /// <summary>
    /// End time 
    /// 结束时间
    /// </summary>
    public NET_TIME stEndTime;
  }

  // 开门方向
  public enum EM_DIRECTION_ACCESS_CTL
  {
    UNKNOWN,
    ENTRY,                              // 进门             
    EXIT,                               // 出门
  }

  /// <summary>
  /// Access Control card Record Information
  /// 门禁刷卡记录记录集信息
  /// </summary>
  public struct NET_RECORDSET_ACCESS_CTL_CARDREC
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record Number,Read-Only
    /// 记录集编号,只读
    /// </summary>
    public int nRecNo;
    /// <summary>
    /// Card Number
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// Password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPwd;
    /// <summary>
    /// Swing Card Time
    /// 刷卡时间
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// Swing Card Result,True is Success,False is Fail
    /// 刷卡结果,TRUE表示成功,FALSE表示失败
    /// </summary>
    public bool bStatus;
    /// <summary>
    /// Open Door Method
    /// 开门方式
    /// </summary>
    public EM_ACCESS_DOOROPEN_METHOD emMethod;
    /// <summary>
    /// Door Number,That is CFG_CMD_ACCESS_EVENT Configure Array Subscript
    /// 门号,即CFG_CMD_ACCESS_EVENT配置CFG_ACCESS_EVENT_INFO的数组下标
    /// </summary>
    public int nDoor;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// card reader ID (abandoned)
    /// 读卡器ID (废弃,不再使用)
    /// </summary>
    public int nReaderID;
    /// <summary>
    /// unlock snap upload ftp url
    /// 开锁抓拍上传的FTP地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
    public byte[] szSnapFtpUrl;
    /// <summary>
    /// card reader ID
    /// 读卡器ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szReaderID;
    /// <summary>
    /// Card Type
    /// 卡类型
    /// </summary>
    public EM_ACCESSCTLCARD_TYPE emCardType;
    /// <summary>
    /// Reason of unlock failure, only because it is valid when bStatus is FALSE:
    /// 0x00 no error,0x10 unauthorized,0x11 card lost or cancelled,0x12 no door right,0x13 unlock mode error,0x14 valid period error,0x15 anti sneak into mode,0x16 forced alarm not unlocked
    /// 0x17 door NC status,0x18 AB lock status,0x19 patrol card,0x1A device is under intrusion alarm status,0x20 period error,0x21 unlock period error in holiday period,0x30 first card right check required
    /// 0x40 card correct, input password error,0x41 card correct, input password timed out,0x42 card correct, input fingerprint error,0x42 card correct, input fingerprint error,0x43 card correct, input fingerprint timed out
    /// 0x44 fingerprint correct, input password error, 0x45 fingerprint correct, input password timed out,0x50 group unlock sequence error,0x51 test required for group unlock,0x60 test passed, control unauthorized
    /// 开门失败的原因,仅在bStatus为FALSE时有效:
    /// 0x00 没有错误,0x10 未授权,0x11 卡挂失或注销,0x12 没有该门权限,0x13 开门模式错误,0x14 有效期错误,0x15 防反潜模式,0x16 胁迫报警未打开,0x17 门常闭状态,0x18 AB互锁状态,0x19 巡逻卡,0x1A 设备处于闯入报警状态
    /// 0x20 时间段错误,0x21 假期内开门时间段错误,0x30 需要先验证有首卡权限的卡片,0x40 卡片正确,输入密码错误,0x41 卡片正确,输入密码超时,0x42 卡片正确,输入指纹错误,0x43 卡片正确,输入指纹超时
    /// 0x44 指纹正确,输入密码错误,0x45 指纹正确,输入密码超时,0x50 组合开门顺序错误,0x51 组合开门需要继续验证,0x60 验证通过,控制台未授权
    /// </summary>
    public int nErrorCode;
    /// <summary>
    /// 
    /// 刷卡录像的地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRecordURL;
    /// <summary>
    /// 
    /// 抓图的张数
    /// </summary>
    public int nNumbers;
    /// <summary>
    /// 
    /// 考勤状态 
    /// </summary>
    public EM_ATTENDANCESTATE emAttendanceState;
    /// <summary>
    /// 
    /// 开门方向
    /// </summary>
    public EM_DIRECTION_ACCESS_CTL emDirection;
    /// <summary>
    /// 
    /// 班级（考勤肯尼亚定制）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szClassNumber;
    /// <summary>
    /// 
    /// 电话（考勤肯尼亚定制）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPhoneNumber;
    /// <summary>
    /// 
    /// 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardName;
  }

  /// <summary>
  /// fingerprint collection (corresponding to EM_CtrlType.CAPTURE_FINGER_PRINT command)
  /// 指纹采集(对应EM_CtrlType.CAPTURE_FINGER_PRINT命令)
  /// </summary>
  public struct NET_CTRL_CAPTURE_FINGER_PRINT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// access control no.(start from 0)
    /// 门禁序号(从0开始)
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// card reader ID
    /// 读卡器ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szReaderID;
  }

  /// <summary>
  /// get fingerprint event(corresponding to EM_ALARM_TYPE.ALARM_FINGER_PRINT)
  /// 获取指纹事件(对应DH_ALARM_FINGER_PRINT类型)
  /// </summary>
  public struct NET_ALARM_CAPTURE_FINGER_PRINT_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// door channel no.( from 0)
    /// 门通道号(从0开始)
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event time
    /// 事件时间
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// card reader ID
    /// 门读卡器ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szReaderID;
    /// <summary>
    /// single fingerprint data length
    /// 单个指纹数据包长度
    /// </summary>
    public int nPacketLen;
    /// <summary>
    /// fingerprint data number
    /// 指纹数据包个数
    /// </summary>
    public int nPacketNum;
    /// <summary>
    /// fingerprint data(data total length as nPacketLen*nPacketNum)
    /// 指纹数据(数据总长度即nPacketLen*nPacketNum)
    /// </summary>
    public IntPtr szFingerPrintInfo;
  }

  /// <summary>
  /// remove anti-submarine alarm input parameter
  /// 消除反潜报警入参
  /// </summary>
  public struct NET_IN_CLEAR_REPEAT_ENTER
  {
    /// <summary>
    /// user card number
    /// 用户卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szCardNO;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  }

  /// <summary>
  /// remove anti-submarine alarm output parameter 
  /// 消除反潜报警出参
  /// </summary>
  public struct NET_OUT_CLEAR_REPEAT_ENTER
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;
  }

  /// <summary>
  /// access control status info(QueryDevState port input parameter)
  /// 门禁状态信息(QueryDevState 接口输入参数)
  /// </summary>
  public struct NET_DOOR_STATUS_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// access control channel no.
    /// 门禁通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// access control status info
    /// 门禁状态信息
    /// </summary>
    public EM_NET_DOOR_STATUS_TYPE emStateType;
  }

  /// <summary>
  /// access control status type
  /// 门禁状态类型
  /// </summary>
  public enum EM_NET_DOOR_STATUS_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// door unlock
    /// 门打开
    /// </summary>
    OPEN,
    /// <summary>
    /// door lock
    /// 门关闭
    /// </summary>
    CLOSE,
    /// <summary>
    /// door abnormal unlock
    /// 门异常打开
    /// </summary>
    BREAK,
  }

  /// <summary>
  /// ControlDevice's param: NET_CTRL_ACCESS_OPEN
  /// ControlDevice接口的 ACCESS_OPEN 命令参数
  /// </summary>
  public struct NET_CTRL_ACCESS_OPEN
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Channel ID (start from 0)
    /// 通道号(0开始)
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Target ID, NULL equals to not transmit  
    /// 转发目标设备ID,为NULL表示不转发
    /// </summary>
    public IntPtr szTargetID;
    /// <summary>
    /// remote user id
    /// 远程用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// open door type
    /// 开门方式
    /// </summary>
    public EM_OPEN_DOOR_TYPE emOpenDoorType;
  }

  /// <summary>
  /// Access controller -- Open door type
  /// 门禁控制--开门方式
  /// </summary>
  public enum EM_OPEN_DOOR_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN = 0,
    /// <summary>
    /// Remote
    /// 远程开门
    /// </summary>
    REMOTE,
    /// <summary>
    /// Local_Password
    /// 本地密码开门
    /// </summary>
    LOCAL_PASSWORD,
    /// <summary>
    /// Local_Card
    /// 本地刷卡开门
    /// </summary>
    LOCAL_CARD,
    /// <summary>
    /// Local_Button
    /// 本地按钮开门
    /// </summary>
    LOCAL_BUTTON,
  }

  /// <summary>
  /// ControlDevice's param
  /// ControlDevice接口的 ACCESS_CLOSE 命令参数
  /// </summary>
  public struct NET_CTRL_ACCESS_CLOSE
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Channel ID (start from 0)
    /// 通道号(0开始)
    /// </summary>
    public int nChannelID;
  }

  /// <summary>
  /// input of StartFindFaceInfo
  /// StartFindFaceInfo 输入参数
  /// </summary>
  public struct NET_IN_FACEINFO_START_FIND
  {
    public uint dwSize;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// output of StartFindFaceInfo
  /// StartFindFaceInfo 输出参数
  /// </summary>
  public struct NET_OUT_FACEINFO_START_FIND
  {
    public uint dwSize;
    /// <summary>
    /// total count matching the finding condition
    /// 符合查询条件的总数
    /// </summary>
    public uint nTotalCount;
  }

  /// <summary>
  /// input of DoFindFaceInfo
  /// DoFindFaceInfo 输入参数
  /// </summary>
  public struct NET_IN_FACEINFO_DO_FIND
  {
    public uint dwSize;
    /// <summary>
    /// start number
    /// 起始序号
    /// </summary>
    public int nStartNo;
    /// <summary>
    /// number to query
    /// 本次查询的条数
    /// </summary>
    public int nCount;
  }

  /// <summary>
  /// output of DoFindFaceInfo
  /// DoFindFaceInfo 输出参数
  /// </summary>
  public struct NET_OUT_FACEINFO_DO_FIND
  {
    public uint dwSize;
    /// <summary>
    /// return number
    /// 本次查询到的个数
    /// </summary>
    public int nRetNum;
    /// <summary>
    /// result, user malloc the memroy, apply to sizeof(NET_FACEINFO)*nMaxNum
    /// 查询结果, 用户分配内存,大小为sizeof(NET_FACEINFO)*nMaxNum
    /// </summary>
    public IntPtr pstuInfo;
    /// <summary>
    /// number of user malloced
    /// 用户分配内存的个数
    /// </summary>
    public int nMaxNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] byReserved;
  }

  /// <summary>
  /// face photo info
  /// 人脸信息
  /// </summary>
  public struct NET_FACEINFO
  {
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// number of MD5
    /// 有效的MD5编码数量
    /// </summary>
    public int nMD5;
    /// <summary>
    /// MD5 of face photo
    /// 图片对应的32字节MD5编码加密
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public NET_MD5[] szMD5;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] byReserved;
  }

  public struct NET_MD5
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDM5;
  }

  /// <summary>
  /// the opreate type of face info
  /// 人脸信息记录操作类型
  /// </summary>
  public enum EM_FACEINFO_OPREATE_TYPE
  {
    /// <summary>
    /// add, pInbuf = NET_IN_ADD_FACE_INFO , pOutBuf = NET_OUT_ADD_FACE_INFO
    /// 添加, pInbuf = NET_IN_ADD_FACE_INFO , pOutBuf = NET_OUT_ADD_FACE_INFO
    /// </summary>
    ADD,
    /// <summary>
    /// get, pInBuf = NET_IN_GET_FACE_INFO , pOutBuf = NET_OUT_GET_FACE_INFO
    /// 获取, pInBuf = NET_IN_GET_FACE_INFO , pOutBuf = NET_OUT_GET_FACE_INFO
    /// </summary>
    GET,
    /// <summary>
    /// update, pInbuf = NET_IN_UPDATE_FACE_INFO , pOutBuf = NET_OUT_UPDATE_FACE_INFO
    /// 更新, pInbuf = NET_IN_UPDATE_FACE_INFO , pOutBuf = NET_OUT_UPDATE_FACE_INFO
    /// </summary>
    UPDATE,
    /// <summary>
    /// remove, pInbuf = NET_IN_REMOVE_FACE_INFO , pOutBuf = NET_OUT_REMOVE_FACE_INFO
    /// 删除, pInbuf = NET_IN_REMOVE_FACE_INFO , pOutBuf = NET_OUT_REMOVE_FACE_INFO
    /// </summary>
    REMOVE,
    /// <summary>
    /// clear, pInbuf = NET_IN_CLEAR_FACE_INFO, pOutBuf = NET_OUT_CLEAR_FACE_INFO
    /// 清除, pInbuf = NET_IN_CLEAR_FACE_INFO, pOutBuf = NET_OUT_CLEAR_FACE_INFO
    /// </summary>
    CLEAR,
  }

  /// <summary>
  /// the info of face
  /// 人脸信息
  /// </summary>
  public struct NET_FACE_RECORD_INFO
  {
    /// <summary>
    /// user name
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUserName;
    /// <summary>
    /// count of rooms
    /// 房间个数
    /// </summary>
    public int nRoom;
    /// <summary>
    /// list of rooms
    /// 房间号列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_ROOM[] szRoomNo;
    /// <summary>
    /// count of face data
    /// 人脸模板数据个数
    /// </summary>
    public int nFaceData;
    /// <summary>
    /// face data
    /// 人脸模板数据
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20 * 2048)]
    public byte[] szFaceData;
    /// <summary>
    /// face data len
    /// 人脸模版数据大小
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public int[] nFaceDataLen;
    /// <summary>
    /// count of face photo
    /// 人脸照片个数
    /// </summary>
    public int nFacePhoto;
    /// <summary>
    /// face photo data len
    /// 每张图片的大小
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public int[] nFacePhotoLen;
    /// <summary>
    /// face photo data,max size: 120K
    /// 人脸照片数据,大小不超过120K
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 5)]
    public IntPtr[] pszFacePhoto;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 384)]
    public byte[] byReserved;
  }

  /// <summary>
  /// room
  /// 房间
  /// </summary>
  public struct NET_ROOM
  {
    /// <summary>
    /// room No.
    /// 房间号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szRoomNo;
  }

  /// <summary>
  /// face data
  /// 人脸模板数据
  /// </summary>
  public struct NET_FACE_RECORD_DATA
  {
    /// <summary>
    /// face data
    /// 人脸模板数据
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
    public byte[] byFaceData;
  }

  /// <summary>
  /// the input param of adding face data
  /// 添加人脸记录信息输入参数
  /// </summary>
  public struct NET_IN_ADD_FACE_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// face data
    /// 人脸数据
    /// </summary>
    public NET_FACE_RECORD_INFO stuFaceInfo;
  }

  /// <summary>
  /// the output param of adding face data
  /// 添加人脸记录信息输出参数
  /// </summary>
  public struct NET_OUT_ADD_FACE_INFO
  {
    public uint dwSize;
  }

  /// <summary>
  /// the input param of getting face data
  /// 获取人脸记录信息输入参数
  /// </summary>
  public struct NET_IN_GET_FACE_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// the out param of getting face data
  /// 获取人脸记录信息输出参数
  /// </summary>
  public struct NET_OUT_GET_FACE_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// count of face data
    /// 人脸模板数据个数
    /// </summary>
    public int nFaceData;
    /// <summary>
    /// face data
    /// 人脸模板数据
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048 * 20)]
    public byte[] szFaceData;
  }

  /// <summary>
  /// the input param to updata face data
  /// 更新人脸记录信息输入参数
  /// </summary>
  public struct NET_IN_UPDATE_FACE_INFO
  {
    public uint dwSize;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// the info of face
    /// 人脸数据
    /// </summary>
    public NET_FACE_RECORD_INFO stuFaceInfo;
  }

  /// <summary>
  /// the output param to updata face data
  /// 更新人脸记录信息输出参数
  /// </summary>
  public struct NET_OUT_UPDATE_FACE_INFO
  {
    public uint dwSize;
  }

  /// <summary>
  /// the input param of removing face data
  /// 删除人脸记录信息输入参数
  /// </summary>
  public struct NET_IN_REMOVE_FACE_INFO
  {
    public uint dwSize;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// the output param of removing face data
  /// 删除人脸记录信息输出参数
  /// </summary>
  public struct NET_OUT_REMOVE_FACE_INFO
  {
    public uint dwSize;
  }

  /// <summary>
  /// the input param of clear face data
  /// 清除人脸记录信息输入参数
  /// </summary>
  public struct NET_IN_CLEAR_FACE_INFO
  {
    public uint dwSize;
  }

  /// <summary>
  /// the output param of clear face data
  /// 清除人脸记录信息输出参数
  /// </summary>
  public struct NET_OUT_CLEAR_FACE_INFO
  {
    public uint dwSize;
  }

  #endregion


  #region <<Number State>>
  /// <summary>
  /// The type of rule
  /// 规则类型
  /// </summary>
  public enum EM_RULE_TYPE
  {
    /// <summary>
    /// Unknown
    /// 未知
    /// </summary>
    EM_RULE_UNKNOWN,
    /// <summary>
    /// NumberStat
    /// 人数统计
    /// </summary>
    EM_RULE_NUMBER_STAT,
    /// <summary>
    /// Man number detection
    /// 区域内人数统计
    /// </summary>
    EM_RULE_MAN_NUM_DETECTION,
  }
  /// <summary>
  /// interface(StartFindNumberStat)'s input param
  /// StartFindNumberStat输入参数
  /// </summary>
  public struct NET_IN_FINDNUMBERSTAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel ID
    /// 要进行查询的通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// start time
    /// 开始时间 
    /// </summary>
    public NET_TIME stStartTime;
    /// <summary>
    /// end time
    /// 结束时间
    /// </summary>
    public NET_TIME stEndTime;
    /// <summary>
    /// granularity type, 0:minute,1:hour,2:day,3:week,4:month,5:quarter,6:year
    /// 查询粒度0:分钟,1:小时,2:日,3:周,4:月,5:季,6:年
    /// </summary>
    public int nGranularityType;
    /// <summary>
    /// wait time
    /// 等待接收数据的超时时间
    /// </summary>
    public int nWaittime;
    /// <summary>
    /// Plan ID,Speed Dome use,start from 1
    /// 计划ID,仅球机有效,从1开始
    /// </summary>
    public uint nPlanID;
    /// <summary>
    /// rule type
    /// 规则类型
    /// </summary>
    public EM_RULE_TYPE emRuleType;
    /// <summary>
    /// the minimum stay time，default value is 0; return the number of persons, the stay time of these persons are greater or equal to this time. this parameter is not required when the find type is NumberStat 
    /// 区域人数查询最小滞留时间，不填默认为0，返回滞留时长大于等于该时间的人数信息,NumberStat时不需要此参数
    /// </summary>
    public int nMinStayTime;
  }

  /// <summary>
  /// StartFindNumberStat's output param
  /// StartFindNumberStat输出参数
  /// </summary>
  public struct NET_OUT_FINDNUMBERSTAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// total count
    /// 符合此次查询条件的结果总条数
    /// </summary>
    public uint dwTotalCount;
  }

  /// <summary>
  /// DoFindNumberStat's input param
  /// 接口(DoFindNumberStat)输入参数
  /// </summary>
  public struct NET_IN_DOFINDNUMBERSTAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// [0, totalCount-1]
    /// [0, totalCount-1], 查询起始序号,表示从beginNumber条记录开始,取count条记录返回
    /// </summary>
    public uint nBeginNumber;
    /// <summary>
    /// count
    /// 每次查询的流量统计条数
    /// </summary>
    public uint nCount;
    /// <summary>
    /// wait time
    /// 等待接收数据的超时时间
    /// </summary>
    public int nWaittime;
  }

  /// <summary>
  /// DoFindNumberStat's ouput param
  /// 接口(DoFindNumberStat)输出参数
  /// </summary>
  public struct NET_OUT_DOFINDNUMBERSTAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// count
    /// 查询返回人数统计信息个数
    /// </summary>
    public int nCount;
    /// <summary>
    /// state array, the space application by the user(NET_NUMBERSTAT)
    /// 返回人数统计信息数组(NET_NUMBERSTAT)，由用户申请内存，大小为nBufferLen
    /// </summary>
    public IntPtr pstuNumberStat;
    /// <summary>
    /// the space application yb the user, the length unit is the dwsize of NET_NUMBERSTAT
    /// 用户申请的内存大小,以NET_NUMBERSTAT中的dwsize大小为单位
    /// </summary>
    public int nBufferLen;
    /// <summary>
    /// the minimum stay time when the find type is ManNumDetection
    /// 区域人数查询时指定的最小滞留时间
    /// </summary>
    public int nMinStayTime;
  }

  /// <summary>
  /// number stat
  /// 数字统计
  /// </summary>
  public struct NET_NUMBERSTAT
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel id
    /// 统计通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// rule name
    /// 规则名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szRuleName;
    /// <summary>
    /// start time
    /// 开始时间
    /// </summary>
    public NET_TIME stuStartTime;
    /// <summary>
    /// end time
    /// 结束时间
    /// </summary>
    public NET_TIME stuEndTime;
    /// <summary>
    /// entered total
    /// 进入人数小计
    /// </summary>
    public int nEnteredSubTotal;
    /// <summary>
    /// entered total
    /// 出去人数小计
    /// </summary>
    public int nExitedSubtotal;
    /// <summary>
    /// average number inside
    /// 平均保有人数(除去零值)
    /// </summary>
    public int nAvgInside;
    /// <summary>
    /// max number inside
    /// 最大保有人数
    /// </summary>
    public int nMaxInside;
    /// <summary>
    /// people enter with helmet count
    /// 戴安全帽进入人数小计
    /// </summary>
    public int nEnteredWithHelmet;
    /// <summary>
    /// people enter without helmet count
    /// 不戴安全帽进入人数小计
    /// </summary>
    public int nEnteredWithoutHelmet;
    /// <summary>
    /// people exit with helmet count
    /// 戴安全帽出去人数小计
    /// </summary>
    public int nExitedWithHelmet;
    /// <summary>
    /// people exit without helmet count
    /// 不戴安全帽出去人数小计
    /// </summary>
    public int nExitedWithoutHelmet;
    /// <summary>
    /// 在区域内人数小计
    /// the count of peoples in the region
    /// </summary>
    public int nInsideSubtotal;
  }

  /// <summary>
  /// input param for AttachVideoStatSummary
  /// AttachVideoStatSummary 入参
  /// </summary>
  public struct NET_IN_ATTACH_VIDEOSTAT_SUM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// video channel ID    
    /// 视频通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// video statistical summary callback
    /// 视频统计摘要信息回调
    /// </summary>
    public fVideoStatSumCallBack cbVideoStatSum;
    /// <summary>
    /// user data
    /// 用户数据
    /// </summary>
    public IntPtr dwUser;
  }

  /// <summary>
  /// output param for AttachVideoStatSummary
  /// AttachVideoStatSummary 出参
  /// </summary>
  public struct NET_OUT_ATTACH_VIDEOSTAT_SUM
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// video statistical subtotal
  /// 视频统计小计信息
  /// </summary>
  public struct NET_VIDEOSTAT_SUBTOTAL
  {
    /// <summary>
    /// count since device operation
    /// 设备运行后人数统计总数
    /// </summary>
    public int nTotal;
    /// <summary>
    /// count in the last hour
    /// 小时内的总人数
    /// </summary>
    public int nHour;
    /// <summary>
    /// count for today
    /// 当天的总人数, 不可手动清除
    /// </summary>
    public int nToday;
    /// <summary>
    /// count for today, on screen display 
    /// 统计人数, 用于OSD显示, 可手动清除
    /// </summary>
    public int nOSD;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>   
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 252)]
    public byte[] reserved;
  }

  /// <summary>
  /// video statistical summary
  /// 视频统计摘要信息
  /// </summary>
  public struct NET_VIDEOSTAT_SUMMARY
  {
    /// <summary>
    /// channel ID 
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// rule name
    /// 规则名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szRuleName;
    /// <summary>
    /// time of this statistics
    /// 统计时间
    /// </summary>
    public NET_TIME_EX stuTime;
    /// <summary>
    /// subtotal for the entered
    /// 进入小计
    /// </summary>
    public NET_VIDEOSTAT_SUBTOTAL stuEnteredSubtotal;
    /// <summary>
    /// subtotal for the exited
    /// 出去小计
    /// </summary>
    public NET_VIDEOSTAT_SUBTOTAL stuExitedSubtotal;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] reserved;
  }
  #endregion Number state

  #region <<Face Module>>
  /// <summary>
  /// the describe of EVENT_IVS_FACEDETECT's data
  /// 人脸检测事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_FACEDETECT_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action: 0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] reserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// detect region point number
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// detect region
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON  
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// snapshot current face device address
    /// 抓拍当前人脸的设备地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSnapDevAddress;
    /// <summary>
    /// event trigger accumilated times 
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// sex type
    /// 性别
    /// </summary>
    public EM_DEV_EVENT_FACEDETECT_SEX_TYPE emSex;
    /// <summary>
    /// age, invalid if it is -1
    /// 年龄,-1表示该字段数据无效
    /// </summary>
    public int nAge;
    /// <summary>
    /// invalid number in array emFeature
    /// 人脸特征数组有效个数,与 emFeature 结合使用
    /// </summary>
    public uint nFeatureValidNum;
    /// <summary>
    /// human face features
    /// 人脸特征数组,与 nFeatureValidNum 结合使用
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE[] emFeature;
    /// <summary>
    /// number of stuFaces
    /// 指示stuFaces有效数量
    /// </summary>
    public int nFacesNum;
    /// <summary>
    /// when nFacesNum > 0, stuObject invalid
    /// 多张人脸时使用,此时没有Object
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public NET_FACE_INFO[] stuFaces;
    /// <summary>
    /// public info 
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// race
    /// 种族
    /// </summary>
    public EM_RACE_TYPE emRace;
    /// <summary>
    /// eyes state
    /// 眼睛状态
    /// </summary>
    public EM_EYE_STATE_TYPE emEye;
    /// <summary>
    /// mouth state
    /// 嘴巴状态
    /// </summary>
    public EM_MOUTH_STATE_TYPE emMouth;
    /// <summary>
    /// mask state
    /// 口罩状态
    /// </summary>
    public EM_MASK_STATE_TYPE emMask;
    /// <summary>
    /// beard state
    /// 胡子状态
    /// </summary>
    public EM_BEARD_STATE_TYPE emBeard;
    /// <summary>
    /// Attractive value, -1: invalid, 0:no disringuish,range: 1-100, the higher value, the higher charm
    /// 魅力值, -1表示无效, 0未识别，识别时范围1-100,得分高魅力高
    /// </summary>
    public int nAttractive;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 868)]
    public byte[] bReserved;
  }

  /// <summary>
  /// race type
  /// 种族类型
  /// </summary>
  public enum EM_RACE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知 
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// no disringuish
    /// 未识别
    /// </summary>
    NODISTI,
    /// <summary>
    /// yellow
    /// 黄种人
    /// </summary>
    YELLOW,
    /// <summary>
    /// black
    /// 黑人
    /// </summary>
    BLACK,
    /// <summary>
    /// white
    /// 白人
    /// </summary>
    WHITE,
  }

  /// <summary>
  /// eyes state
  /// 眼睛状态
  /// </summary>
  public enum EM_EYE_STATE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// no disringuish
    /// 未识别
    /// </summary>
    NODISTI,
    /// <summary>
    /// close eyes
    /// 闭眼
    /// </summary>
    CLOSE,
    /// <summary>
    ///open eyes 
    /// 睁眼
    /// </summary>
    OPEN,
  }

  /// <summary>
  /// mouth state
  /// 嘴巴状态
  /// </summary>
  public enum EM_MOUTH_STATE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// no disringuish
    /// 未识别
    /// </summary>
    NODISTI,
    /// <summary>
    /// close mouth
    /// 闭嘴
    /// </summary>
    CLOSE,
    /// <summary>
    /// open nouth
    /// 张嘴
    /// </summary>
    OPEN,
  }

  /// <summary>
  /// mask state
  /// 口罩状态
  /// </summary>
  public enum EM_MASK_STATE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// no disringuish
    /// 未识别
    /// </summary>
    NODISTI,
    /// <summary>
    /// no mask
    /// 没戴口罩
    /// </summary>
    NOMASK,
    /// <summary>
    /// wearing mask
    /// 戴口罩
    /// </summary>
    WEAR,
  }

  /// <summary>
  /// beard state
  /// 胡子状态
  /// </summary>
  public enum EM_BEARD_STATE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// no disringuish
    /// 未识别
    /// </summary>
    NODISTI,
    /// <summary>
    /// no beard
    /// 没胡子
    /// </summary>
    NOBEARD,
    /// <summary>
    /// have beard
    /// 有胡子
    /// </summary>
    HAVEBEARD,
  }

  /// <summary>
  /// sex type of dectected human face
  /// 人脸检测对应性别类型
  /// </summary>
  public enum EM_DEV_EVENT_FACEDETECT_SEX_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// male
    /// 男性
    /// </summary>
    MAN,
    /// <summary>
    /// female
    /// 女性
    /// </summary>
    WOMAN,
  }

  /// <summary>
  /// feature type of detected human face
  /// 人脸检测对应人脸特征类型
  /// </summary>
  public enum EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// wearing glasses
    /// 戴眼镜
    /// </summary>
    WEAR_GLASSES,
    /// <summary>
    /// smile
    /// 微笑
    /// </summary>
    SMILE,
    /// <summary>
    /// anger
    /// 愤怒
    /// </summary>
    ANGER,
    /// <summary>
    /// sadness
    /// 悲伤
    /// </summary>
    SADNESS,
    /// <summary>
    /// disgust
    /// 厌恶
    /// </summary>
    DISGUST,
    /// <summary>
    /// fear
    /// 害怕
    /// </summary>
    FEAR,
    /// <summary>
    /// surprise
    /// 惊讶
    /// </summary>
    SURPRISE,
    /// <summary>
    /// neutral
    /// 正常
    /// </summary>
    NEUTRAL,
    /// <summary>
    /// laugh
    /// 大笑
    /// </summary>
    LAUGH,
    /// <summary>
    /// not wear glasses
    /// 没戴眼镜
    /// </summary>
    NOGLASSES,
    /// <summary>
    /// happy
    /// 高兴
    /// </summary>
    HAPPY,
    /// <summary>
    /// confused
    /// 困惑
    /// </summary>
    CONFUSED,
    /// <summary>
    /// scream
    /// 尖叫
    /// </summary>
    SCREAM,
    /// <summary>
    /// wearing sun glasses
    /// 戴太阳眼镜
    /// </summary>
    WEAR_SUNGLASSES,
  }

  /// <summary>
  /// multi faces detect info
  /// 多人脸检测信息
  /// </summary>
  public struct NET_FACE_INFO
  {
    /// <summary>
    /// object id
    /// 物体ID,每个ID表示一个唯一的物体
    /// </summary>
    public int nObjectID;
    /// <summary>
    /// object type
    /// 物体类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szObjectType;
    /// <summary>
    /// same with the source picture id
    /// 这张人脸抠图所属的大图的ID
    /// </summary>
    public int nRelativeID;
    /// <summary>
    /// bounding box
    /// 包围盒
    /// </summary>
    public NET_RECT BoundingBox;
    /// <summary>
    /// object center
    /// 物体型心
    /// </summary>
    public NET_POINT Center;
  }

  /// <summary>
  /// the describe of EVENT_IVS_FACERECOGNITION's data
  /// 人脸识别对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_FACERECOGNITION_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// candidate number
    /// 当前人脸匹配到的候选对象数量
    /// </summary>
    public int nCandidateNum;
    /// <summary>
    /// candidate info
    /// 当前人脸匹配到的候选对象信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFO[] stuCandidates;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// reserved
    /// 对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved1;
    /// <summary>
    /// The existence panorama
    /// 全景图是否存在
    /// </summary>
    public bool bGlobalScenePic;
    /// <summary>
    /// Panoramic Photos
    /// 全景图片信息
    /// </summary>
    public NET_PIC_INFO stuGlobalScenePicInfo;
    /// <summary>
    /// Snapshot current face aadevice address
    /// 抓拍当前人脸的设备地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szSnapDevAddress;
    /// <summary>
    /// event trigger accumilated times 
    /// 事件触发累计次数
    /// </summary>
    public uint nOccurrenceCount;
    /// <summary>
    /// intelligent things info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// face data
    /// 人脸数据
    /// </summary>
    public NET_FACE_DATA stuFaceData;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUID;          // 抓拍人员写入数据库的唯一标识符
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 300)]
    public byte[] bReserved;
    /// <summary>
    /// the actual return number of stuCandidatesEx
    /// 当前人脸匹配到的候选对象数量实际返回值
    /// </summary>
    public int nRetCandidatesExNum;
    /// <summary>
    /// the expansion of candidate information
    /// 当前人脸匹配到的候选对象信息扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFOEX[] stuCandidatesEx;
  }

  /// <summary>
  /// face data
  /// 人脸数据
  /// </summary>
  public struct NET_FACE_DATA
  {
    /// <summary>
    /// sex type
    /// 性别
    /// </summary>
    public EM_DEV_EVENT_FACEDETECT_SEX_TYPE emSex;
    /// <summary>
    /// age, invalid if it is -1
    /// 年龄,-1表示该字段数据无效
    /// </summary>
    public int nAge;
    /// <summary>
    /// invalid number in array emFeature
    /// 人脸特征数组有效个数,与 emFeature 结合使用
    /// </summary>
    public uint nFeatureValidNum;
    /// <summary>
    /// human face features
    /// 人脸特征数组,与 nFeatureValidNum 结合使用
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE[] emFeature;
    /// <summary>
    /// race
    /// 种族
    /// </summary>
    public EM_RACE_TYPE emRace;
    /// <summary>
    /// eyes state
    /// 眼睛状态
    /// </summary>
    public EM_EYE_STATE_TYPE emEye;
    /// <summary>
    /// mouth state
    /// 嘴巴状态
    /// </summary>
    public EM_MOUTH_STATE_TYPE emMouth;
    /// <summary>
    /// mask state
    /// 口罩状态
    /// </summary>
    public EM_MASK_STATE_TYPE emMask;
    /// <summary>
    /// beard state
    /// 胡子状态
    /// </summary>
    public EM_BEARD_STATE_TYPE emBeard;
    /// <summary>
    /// Attractive value, -1: invalid, 0:no disringuish,range: 1-100, the higher value, the higher charm
    /// 魅力值, -1表示无效, 0未识别，识别时范围1-100,得分高魅力高
    /// </summary>
    public int nAttractive;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] bReserved;
  }

  /// <summary>
  /// cadidate person info
  /// 候选人员信息
  /// </summary>
  public struct NET_CANDIDATE_INFO
  {
    /// <summary>
    /// person info
    /// 人员信息
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFO stPersonInfo;
    /// <summary>
    /// similarity
    /// 和查询图片的相似度
    /// </summary>
    public byte bySimilarity;
    /// <summary>
    /// Range officer's database, see EM_FACE_DB_TYPE
    /// 人员所属数据库范围,详见EM_FACE_DB_TYPE
    /// </summary>
    public byte byRange;
    /// <summary>
    /// Reserved
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved1;
    /// <summary>
    /// When byRange historical database effectively, which means that the query time staff appeared
    /// 当byRange为历史数据库时有效,表示查询人员出现的时间
    /// </summary>
    public NET_TIME stTime;
    /// <summary>
    /// When byRange historical database effectively, which means that people place a query appears
    /// 当byRange为历史数据库时有效,表示查询人员出现的地点 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAddress;
    /// <summary>
    /// Is hit, means the result face has compare result in database
    /// 是否有识别结果,指这个检测出的人脸在库中有没有比对结果
    /// </summary>
    public bool bIsHit;
    /// <summary>
    /// Scene Image
    /// 人脸全景图
    /// </summary>
    public NET_PIC_INFO_EX3 stuSceneImage;
    /// <summary>
    /// channel id
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] byReserved;
  }

  /// <summary>
  /// extend of cadidate person info
  /// 候选人员信息扩展结构体
  /// </summary>
  public struct NET_CANDIDATE_INFOEX
  {
    /// <summary>
    /// Extend of person info
    /// 人员信息扩展
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFOEX stPersonInfo;
    /// <summary>
    /// Similarity in comparison with query image, expressed in percentage, 1~100
    /// 和查询图片的相似度,百分比表示,1~100
    /// </summary>
    public byte bySimilarity;
    /// <summary>
    /// Range officer's database, see EM_FACE_DB_TYPE
    /// 人员所属数据库范围,详见EM_FACE_DB_TYPE
    /// </summary>
    public byte byRange;
    /// <summary>
    /// When byRange historical database effectively, which means that the query time staff appeared
    /// 当byRange为历史数据库时有效,表示查询人员出现的时间
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved1;
    public NET_TIME stTime;
    /// <summary>
    /// When byRange historical database effectively, which means that people place a query appears
    /// 当byRange为历史数据库时有效,表示查询人员出现的地点
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAddress;
    /// <summary>
    /// Is hit, means the result face has compare result in database
    /// 是否有识别结果,指这个检测出的人脸在库中有没有比对结果
    /// </summary>
    public bool bIsHit;
    /// <summary>
    /// Scene Image
    /// 人脸全景图
    /// </summary>
    public NET_PIC_INFO_EX3 stuSceneImage;
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// File path
    /// 文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szFilePathEx;
    /// <summary>
    /// Reserved bytes
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byReserved;
  }

  /// <summary>
  /// person info
  /// 人员信息
  /// </summary>
  public struct NET_FACERECOGNITION_PERSON_INFO
  {
    /// <summary>
    /// name
    /// 姓名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPersonName;
    /// <summary>
    /// birth year
    /// 出生年,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public ushort wYear;
    /// <summary>
    /// birth month
    /// 出生月,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte byMonth;
    /// <summary>
    /// birth day
    /// 出生日,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte byDay;
    /// <summary>
    /// the unicle ID for the person
    /// 人员唯一标示(身份证号码,工号,或其他编号)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szID;
    /// <summary>
    /// importance level,1~10,the higher value the higher level
    /// 人员重要等级,1~10,数值越高越重要,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte bImportantRank;
    /// <summary>
    /// sex, 1-man, 2-female
    /// 性别,1-男,2-女,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte bySex;
    /// <summary>
    /// picture number
    /// 图片张数
    /// </summary>
    public ushort wFacePicNum;
    /// <summary>
    /// picture info
    /// 当前人员对应的图片信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public NET_PIC_INFO[] szFacePicInfo;
    /// <summary>
    /// Personnel types, see EM_PERSON_TYPE
    /// 人员类型,详见 EM_PERSON_TYPE
    /// </summary>
    public byte byType;
    /// <summary>
    /// Document types, see EM_CERTIFICATE_TYPE
    /// 证件类型,详见 EM_CERTIFICATE_TYPE
    /// </summary>
    public byte byIDType;
    /// <summary>
    /// Whether wear glasses or not,0-unknown,1-not wear glasses,2-wear glasses
    /// 是否戴眼镜，0-未知 1-不戴 2-戴
    /// </summary>
    public byte byGlasses;
    /// <summary>
    /// Age,0 means unknown
    /// 年龄,0表示未知
    /// </summary>
    public byte byAge;
    /// <summary>
    /// province
    /// 省份
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szProvince;
    /// <summary>
    /// city
    /// 城市
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCity;
    /// <summary>
    /// Name, the name is too long due to the presence of 16 bytes can not be Storage problems, the increase in this parameter
    /// 姓名,因存在姓名过长,16字节无法存放问题,故增加此参数
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPersonNameEx;
    /// <summary>
    /// person unique ID
    /// 人员唯一标识符,首次由服务端生成,区别于ID字段,修改,删除操作时必填
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUID;
    /// <summary>
    /// country
    /// 国籍
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string szCountry;
    /// <summary>
    /// using person type: 0 using byType, 1 using szPersonName
    /// 人员类型是否为自定义
    /// </summary>
    public byte byIsCustomType;
    /// <summary>
    /// comment info
    /// 备注信息
    /// </summary>
    public IntPtr pszComment;
    /// <summary>
    /// Group ID
    /// 人员所属组ID
    /// </summary>
    public IntPtr pszGroupID;
    /// <summary>
    /// Group Name
    /// 人员所属组名
    /// </summary>
    public IntPtr pszGroupName;
    /// <summary>
    /// the face feature 
    /// 人脸特征 
    /// </summary>
    public IntPtr pszFeatureValue;
    /// <summary>
    /// len of pszGroupID
    /// pszGroupID的长度
    /// </summary>
    public byte bGroupIdLen;
    /// <summary>
    /// len of pszGroupName
    /// pszGroupName的长度
    /// </summary>
    public byte bGroupNameLen;
    /// <summary>
    /// len of pszFeatureValue
    /// pszFeatureValue的长度 128
    /// </summary>
    public byte bFeatureValueLen;
    /// <summary>
    /// len of pszComment
    /// pszComment的长度
    /// </summary>
    public byte bCommentLen;
    /// <summary>
    /// Emotion
    /// 表情
    /// </summary>			
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE emEmotion;
  }

  /// <summary>
  /// picture info
  /// 物体对应图片文件信息
  /// </summary>
  public struct NET_PIC_INFO_EX3
  {
    /// <summary>
    /// current picture file's offset in the binary file, byte
    /// 文件在二进制数据块中的偏移位置, 单位:字节
    /// </summary>
    public uint dwOffSet;
    /// <summary>
    /// current picture file's size, byte
    /// 文件大小, 单位:字节
    /// </summary>
    public uint dwFileLenth;
    /// <summary>
    ///  picture width, pixel
    /// 图片宽度, 单位:像素
    /// </summary>
    public ushort wWidth;
    /// <summary>
    /// picture high, pixel
    /// 图片高度, 单位:像素
    /// </summary>
    public ushort wHeight;
    /// <summary>
    /// File path
    /// 文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szFilePath;
    /// <summary>
    /// When submit to the server, the algorithm has checked the image or not 
    /// 图片是否算法检测出来的检测过的提交识别服务器时，则不需要再时检测定位抠图,1:检测过的,0:没有检测过
    /// </summary>
    public byte bIsDetected;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 11)]
    public byte[] bReserved;
  }

  /// <summary>
  /// ID type
  /// 证件类型
  /// </summary>
  public enum EM_CERTIFICATE_TYPE
  {
    UNKNOWN,
    /// <summary>
    /// IC
    /// 身份证
    /// </summary>
    IC,
    /// <summary>
    /// passport
    /// 护照
    /// </summary>
    PASSPORT,
  }

  #endregion

  /// <summary>
  /// Control type    Corresponding to ControlDevice 
  /// 控制类型,对应ControlDevice接口
  /// </summary>
  public enum EM_CtrlType
  {
    /// <summary>
    /// Reboot device
    /// 重启设备
    /// </summary>
    REBOOT = 0,
    /// <summary>
    /// Shut down device
    /// 关闭设备
    /// </summary>
    SHUTDOWN,
    /// <summary>
    /// HDD management
    /// 硬盘管理
    /// </summary>
    DISK,
    /// <summary>
    /// Network keyboard
    /// 网络键盘
    /// </summary>
    KEYBOARD_POWER = 3,
    /// <summary>
    /// KEYBOARD_ENTER
    /// 键盘回车键
    /// </summary>
    KEYBOARD_ENTER,
    /// <summary>
    /// KEYBOARD_ESC
    /// 键盘退出键
    /// </summary>
    KEYBOARD_ESC,
    /// <summary>
    /// KEYBOARD_UP
    /// 键盘向上键
    /// </summary>
    KEYBOARD_UP,
    /// <summary>
    /// KEYBOARD_DOWN
    /// 键盘向下键
    /// </summary>
    KEYBOARD_DOWN,
    /// <summary>
    /// KEYBOARD_LEFT
    /// 键盘向左键
    /// </summary>
    KEYBOARD_LEFT,
    /// <summary>
    /// KEYBOARD_RIGHT
    /// 键盘向右键
    /// </summary>
    KEYBOARD_RIGHT,
    /// <summary>
    /// KEYBOARD_BTN0
    /// 键盘BTN0键
    /// </summary>
    KEYBOARD_BTN0,
    /// <summary>
    /// KEYBOARD_BTN1
    /// 键盘BTN1键
    /// </summary>
    KEYBOARD_BTN1,
    /// <summary>
    /// KEYBOARD_BTN2
    /// 键盘BTN2键
    /// </summary>
    KEYBOARD_BTN2,
    /// <summary>
    /// KEYBOARD_BTN3
    /// 键盘BTN3键
    /// </summary>
    KEYBOARD_BTN3,
    /// <summary>
    /// KEYBOARD_BTN4
    /// 键盘BTN4键
    /// </summary>
    KEYBOARD_BTN4,
    /// <summary>
    /// KEYBOARD_BTN5
    /// 键盘BTN5键
    /// </summary>
    KEYBOARD_BTN5,
    /// <summary>
    /// KEYBOARD_BTN6
    /// 键盘BTN6键
    /// </summary>
    KEYBOARD_BTN6,
    /// <summary>
    /// KEYBOARD_BTN7
    /// 键盘BTN7键
    /// </summary>
    KEYBOARD_BTN7,
    /// <summary>
    /// KEYBOARD_BTN8
    /// 键盘BTN8键
    /// </summary>
    KEYBOARD_BTN8,
    /// <summary>
    /// KEYBOARD_BTN9
    /// 键盘BTN9键
    /// </summary>
    KEYBOARD_BTN9,
    /// <summary>
    /// KEYBOARD_BTN10
    /// 键盘BTN10键
    /// </summary>
    KEYBOARD_BTN10,
    /// <summary>
    /// KEYBOARD_BTN11
    /// 键盘BTN11键
    /// </summary>
    KEYBOARD_BTN11,
    /// <summary>
    /// KEYBOARD_BTN12
    /// 键盘BTN12键
    /// </summary>
    KEYBOARD_BTN12,
    /// <summary>
    /// KEYBOARD_BTN13
    /// 键盘BTN13键
    /// </summary>
    KEYBOARD_BTN13,
    /// <summary>
    /// KEYBOARD_BTN14
    /// 键盘BTN14键
    /// </summary>
    KEYBOARD_BTN14,
    /// <summary>
    /// KEYBOARD_BTN15
    /// 键盘BTN15键
    /// </summary>
    KEYBOARD_BTN15,
    /// <summary>
    /// KEYBOARD_BTN16
    /// 键盘BTN16键
    /// </summary>
    KEYBOARD_BTN16,
    /// <summary>
    /// KEYBOARD_SPLIT
    /// 键盘分割键
    /// </summary>
    KEYBOARD_SPLIT,
    /// <summary>
    /// KEYBOARD_ONE
    /// 键盘ONE键
    /// </summary>
    KEYBOARD_ONE,
    /// <summary>
    /// KEYBOARD_NINE
    /// 键盘NINE键
    /// </summary>
    KEYBOARD_NINE,
    /// <summary>
    /// KEYBOARD_ADDR
    /// 键盘ADDR键
    /// </summary>
    KEYBOARD_ADDR,
    /// <summary>
    /// KEYBOARD_INFO
    /// 键盘INFO键
    /// </summary>
    KEYBOARD_INFO,
    /// <summary>
    /// KEYBOARD_REC
    /// 键盘REC键
    /// </summary>
    KEYBOARD_REC,
    /// <summary>
    /// KEYBOARD_FN1
    /// 键盘FN1键
    /// </summary>
    KEYBOARD_FN1,
    /// <summary>
    /// KEYBOARD_FN2
    /// 键盘FN2键
    /// </summary>
    KEYBOARD_FN2,
    /// <summary>
    /// KEYBOARD_PLAY
    /// 键盘PLAY键
    /// </summary>
    KEYBOARD_PLAY,
    /// <summary>
    /// KEYBOARD_STOP
    /// 键盘STOP键
    /// </summary>
    KEYBOARD_STOP,
    /// <summary>
    /// KEYBOARD_SLOW
    /// 键盘SLOW键
    /// </summary>
    KEYBOARD_SLOW,
    /// <summary>
    /// KEYBOARD_FAST
    /// 键盘FAST键
    /// </summary>
    KEYBOARD_FAST,
    /// <summary>
    /// KEYBOARD_PREW
    /// 键盘PREW键
    /// </summary>
    KEYBOARD_PREW,
    /// <summary>
    /// KEYBOARD_NEXT
    /// 键盘NEXT键
    /// </summary>
    KEYBOARD_NEXT,
    /// <summary>
    /// KEYBOARD_JMPDOWN
    /// 键盘JMPDOWN键
    /// </summary>
    KEYBOARD_JMPDOWN,
    /// <summary>
    /// KEYBOARD_JMPUP
    /// 键盘JMPUP键
    /// </summary>
    KEYBOARD_JMPUP,
    /// <summary>
    /// KEYBOARD_10PLUS
    /// 键盘10PLUS键
    /// </summary>
    KEYBOARD_10PLUS,
    /// <summary>
    /// KEYBOARD_SHIFT
    /// 键盘SHIFT键
    /// </summary>
    KEYBOARD_SHIFT,
    /// <summary>
    /// KEYBOARD_BACK
    /// 键盘BACK键
    /// </summary>
    KEYBOARD_BACK,
    /// <summary>
    /// KEYBOARD_LOGIN
    /// 键盘LOGIN键
    /// </summary>
    KEYBOARD_LOGIN,
    /// <summary>
    /// KEYBOARD_CHNNEL
    /// 键盘CHNNEL键
    /// </summary>
    KEYBOARD_CHNNEL,
    /// <summary>
    /// Activate alarm input
    /// 触发报警输入
    /// </summary>
    TRIGGER_ALARM_IN = 100,
    /// <summary>
    /// Activate alarm output 
    /// 触发报警输出
    /// </summary>
    TRIGGER_ALARM_OUT,
    /// <summary>
    /// Matrix control 
    /// 矩阵控制
    /// </summary>
    MATRIX,
    /// <summary>
    /// SD card control(for IPC series). Please refer to HDD control
    /// SD卡控制(IPC产品)参数同硬盘控制
    /// </summary>
    SDCARD,
    /// <summary>
    /// Burner control:begin burning
    /// 刻录机控制,开始刻录
    /// </summary>
    BURNING_START,
    /// <summary>
    /// Burner control:stop burning 
    /// 刻录机控制,结束刻录
    /// </summary>
    BURNING_STOP,
    /// <summary>
    /// Burner control:overlay password(The string ended with '\0'. Max length is 8 bits. )
    /// 刻录机控制,叠加密码(以'\0'为结尾的字符串,最大长度8位)
    /// </summary>
    BURNING_ADDPWD,
    /// <summary>
    /// Burner control:overlay head title(The string ended with '\0'. Max length is 1024 bytes. Use '\n' to Enter.)
    /// 刻录机控制,叠加片头(以'\0'为结尾的字符串,最大长度1024字节,支持分行,行分隔符'\n')
    /// </summary>
    BURNING_ADDHEAD,
    /// <summary>
    /// Burner control:overlay dot to the burned information(No parameter) 
    /// 刻录机控制,叠加打点到刻录信息(参数无)
    /// </summary>
    BURNING_ADDSIGN,
    /// <summary>
    /// Burner control:self-defined overlay (The string ended with '\0'. Max length is 1024 bytes. Use '\n' to Enter)
    /// 刻录机控制,自定义叠加(以'\0'为结尾的字符串,最大长度1024字节,支持分行,行分隔符'\n')
    /// </summary>
    BURNING_ADDCURSTOMINFO,
    /// <summary>
    /// restore device default setup 
    /// 恢复设备的默认设置
    /// </summary>
    RESTOREDEFAULT,
    /// <summary>
    /// Activate device snapshot
    /// 触发设备抓图
    /// </summary>
    CAPTURE_START,
    /// <summary>
    /// Clear log
    /// 清除日志
    /// </summary>
    CLEARLOG,
    /// <summary>
    /// Activate wireless alarm (IPC series)
    /// 触发无线报警(IPC产品)
    /// </summary>
    TRIGGER_ALARM_WIRELESS = 200,
    /// <summary>
    /// Mark important record
    /// 标识重要录像文件
    /// </summary>
    MARK_IMPORTANT_RECORD,
    /// <summary>
    /// Network hard disk partition	
    /// 网络硬盘分区
    /// </summary>
    DISK_SUBAREA,
    /// <summary>
    /// Annex burning
    /// 刻录机控制,附件刻录
    /// </summary>
    BURNING_ATTACH,
    /// <summary>
    /// Burn Pause
    /// 刻录暂停
    /// </summary>
    BURNING_PAUSE,
    /// <summary>
    /// Burn Resume
    /// 刻录继续
    /// </summary>
    BURNING_CONTINUE,
    /// <summary>
    /// Burn Postponed
    /// 刻录顺延
    /// </summary>
    BURNING_POSTPONE,
    /// <summary>
    /// OEM control
    /// 报停控制
    /// </summary>
    OEMCTRL,
    /// <summary>
    /// Start to device backup
    /// 设备备份开始
    /// </summary>
    BACKUP_START,
    /// <summary>
    /// Stop to device backup
    /// 设备备份停止
    /// </summary>
    BACKUP_STOP,
    /// <summary>
    /// Add WIFI configuration manually for car device
    /// 车载手动增加WIFI配置
    /// </summary>
    VIHICLE_WIFI_ADD,
    /// <summary>
    /// Delete WIFI configuration manually for car device
    /// 车载手动删除WIFI配置
    /// </summary>
    VIHICLE_WIFI_DEC,
    /// <summary>
    /// Start to buzzer control 
    /// 蜂鸣器控制开始
    /// </summary>
    BUZZER_START,
    /// <summary>
    /// Stop to buzzer control
    /// 蜂鸣器控制结束
    /// </summary>
    BUZZER_STOP,
    /// <summary>
    /// Reject User
    /// 剔除用户
    /// </summary>
    REJECT_USER,
    /// <summary>
    /// Shield User
    /// 屏蔽用户
    /// </summary>
    SHIELD_USER,
    /// <summary>
    /// Rain Brush
    /// 智能交通, 雨刷控制
    /// </summary>
    RAINBRUSH,
    /// <summary>
    /// manual snap (struct NET_MANUAL_SNAP_PARAMETER)
    /// 智能交通, 手动抓拍 (对应结构体NET_MANUAL_SNAP_PARAMETER)
    /// </summary>
    MANUAL_SNAP,
    /// <summary>
    /// manual ntp time adjust
    /// 手动NTP校时
    /// </summary>
    MANUAL_NTP_TIMEADJUST,
    /// <summary>
    /// navigation info and note
    /// 导航信息和短消息
    /// </summary>
    NAVIGATION_SMS,
    /// <summary>
    /// route info
    /// 路线点位信息
    /// </summary>
    ROUTE_CROSSING,
    /// <summary>
    /// backup device format
    /// 格式化备份设备
    /// </summary>
    BACKUP_FORMAT,
    /// <summary>
    /// local preview split
    /// 控制设备端本地预览分割
    /// </summary>
    DEVICE_LOCALPREVIEW_SLIPT,
    /// <summary>
    /// RAID init
    /// RAID初始化
    /// </summary>
    INIT_RAID,
    /// <summary>
    /// RAID control
    /// RAID操作
    /// </summary>
    RAID,
    /// <summary>
    /// sapredisk control
    /// 热备盘操作
    /// </summary>
    SAPREDISK,
    /// <summary>
    /// wifi connect
    /// 手动发起WIFI连接
    /// </summary>
    WIFI_CONNECT,
    /// <summary>
    /// wifi disconnect
    /// 手动断开WIFI连接
    /// </summary>
    WIFI_DISCONNECT,
    /// <summary>
    /// Arm/disarm operation
    /// 布撤防操作
    /// </summary>
    ARMED,
    /// <summary>
    /// IP modify
    /// 修改前端IP
    /// </summary>
    IP_MODIFY,
    /// <summary>
    /// wps connect wifi
    /// wps连接wifi
    /// </summary>
    WIFI_BY_WPS,
    /// <summary>
    /// format pattion
    /// 格式化分区
    /// </summary>
    FORMAT_PATITION,
    /// <summary>
    /// eject storage device
    /// 手动卸载设备
    /// </summary>
    EJECT_STORAGE,
    /// <summary>
    /// load storage device
    /// 手动装载设备
    /// </summary>
    LOAD_STORAGE,
    /// <summary>
    /// close burner
    /// 关闭刻录机光驱门
    /// </summary>
    CLOSE_BURNER,
    /// <summary>
    /// eject burner
    /// 弹出刻录机光驱门
    /// </summary>
    EJECT_BURNER,
    /// <summary>
    /// alarm elimination
    /// 消警
    /// </summary>
    CLEAR_ALARM,
    /// <summary>
    /// TV wall information display
    /// 电视墙信息显示
    /// </summary>
    MONITORWALL_TVINFO,
    /// <summary>
    /// start Intelligent VIDEO analysis
    /// 开始视频智能分析
    /// </summary>
    START_VIDEO_ANALYSE,
    /// <summary>
    /// STOP intelligent VIDEO analysis
    /// 停止视频智能分析
    /// </summary>
    STOP_VIDEO_ANALYSE,
    /// <summary>
    /// Controlled start equipment upgrades, independently complete the upgrade process by the equipment do not need to upgrade file
    /// 控制启动设备升级,由设备独立完成升级过程,不需要传输升级文件
    /// </summary>
    UPGRADE_DEVICE,
    /// <summary>
    /// Multi-channel preview playback channel switching
    /// 切换多通道预览回放的通道
    /// </summary>
    MULTIPLAYBACK_CHANNALES,
    /// <summary>
    /// Turn on the switch power supply timing device output
    /// 电源时序器打开开关量输出口
    /// </summary>
    SEQPOWER_OPEN,
    /// <summary>
    /// Close the switch power supply timing device output
    /// 电源时序器关闭开关量输出口
    /// </summary>
    SEQPOWER_CLOSE,
    /// <summary>
    /// Power timing group open the switch quantity output
    /// 电源时序器打开开关量输出口组
    /// </summary>
    SEQPOWER_OPEN_ALL,
    /// <summary>
    /// Power sequence set close the switch quantity output
    /// 电源时序器关闭开关量输出口组
    /// </summary>
    SEQPOWER_CLOSE_ALL,
    /// <summary>
    /// PROJECTOR up
    /// 投影仪上升
    /// </summary>
    PROJECTOR_RISE,
    /// <summary>
    /// PROJECTOR drop
    /// 投影仪下降
    /// </summary>
    PROJECTOR_FALL,
    /// <summary>
    /// PROJECTOR stop
    /// 投影仪停止
    /// </summary>
    PROJECTOR_STOP,
    /// <summary>
    /// INFRARED buttons
    /// 红外按键
    /// </summary>
    INFRARED_KEY,
    /// <summary>
    /// Device START playback of audio file
    /// 设备开始播放音频文件
    /// </summary>
    START_PLAYAUDIO,
    /// <summary>
    /// Equipment stop playback of audio file
    /// 设备停止播放音频文件
    /// </summary>
    STOP_PLAYAUDIO,
    /// <summary>
    /// open the warning signal
    /// 开启警号
    /// </summary>
    START_ALARMBELL,
    /// <summary>
    /// Close the warning signal
    /// 关闭警号
    /// </summary>
    STOP_ALARMBELL,
    /// <summary>
    /// OPEN ACCESS control NET_CTRL_ACCESS_OPEN
    /// 门禁控制-开门 对应的结构体NET_CTRL_ACCESS_OPEN
    /// </summary>
    ACCESS_OPEN,
    /// <summary>
    /// BYPASS function
    /// 设置旁路功能
    /// </summary>
    SET_BYPASS,
    /// <summary>
    /// Add records to record set number
    /// 添加记录,获得记录集编号
    /// </summary>
    RECORDSET_INSERT,
    /// <summary>
    /// Update a record of the number
    /// 更新某记录集编号的记录
    /// </summary>
    RECORDSET_UPDATE,
    /// <summary>
    /// According to the record set number to delete a record NET_CTRL_RECORDSET_PARAM
    /// 根据记录集编号删除某记录 NET_CTRL_RECORDSET_PARAM
    /// </summary>
    RECORDSET_REMOVE,
    /// <summary>
    /// Remove all RECORDSET information NET_CTRL_RECORDSET_PARAM
    /// 清除所有记录集信息 NET_CTRL_RECORDSET_PARAM
    /// </summary>
    RECORDSET_CLEAR,
    /// <summary>
    /// Entrance guard control - CLOSE (NET_CTRL_ACCESS_CLOSE)
    /// 门禁控制-关门 对应结构体(NET_CTRL_ACCESS_CLOSE)
    /// </summary>
    ACCESS_CLOSE,
    /// <summary>
    /// Alarm sub system activation setup
    /// 报警子系统激活设置
    /// </summary>
    ALARM_SUBSYSTEM_ACTIVE_SET,
    /// <summary>
    /// Disable device open gateway
    /// 禁止设备端开闸
    /// </summary>
    FORBID_OPEN_STROBE,
    /// <summary>
    /// Enable gateway(corresponding to structure  NET_CTRL_OPEN_STROBE)
    /// 开启道闸(对应结构体 NET_CTRL_OPEN_STROBE)
    /// </summary>
    OPEN_STROBE,
    /// <summary>
    /// Talk no response
    /// 对讲拒绝接听
    /// </summary>
    TALKING_REFUSE,
    /// <summary>
    /// arm-disarm operation
    /// 布撤防操作
    /// </summary>
    ARMED_EX,
    /// <summary>
    /// Remote talk control
    /// 远程对讲控制
    /// </summary>
    REMOTE_TALK,
    /// <summary>
    /// Net keyboard control
    /// 网络键盘控制
    /// </summary>
    NET_KEYBOARD = 400,
    /// <summary>
    /// Open air conditioner
    /// 打开空调
    /// </summary>
    AIRCONDITION_OPEN,
    /// <summary>
    /// Close air-conditioner
    /// 关闭空调
    /// </summary>
    AIRCONDITION_CLOSE,
    /// <summary>
    /// Set temperature
    /// 设定空调温度
    /// </summary>
    AIRCONDITION_SET_TEMPERATURE,
    /// <summary>
    /// Adjust temperature
    /// 调节空调温度
    /// </summary>
    AIRCONDITION_ADJUST_TEMPERATURE,
    /// <summary>
    /// Set air work mode
    /// 设置空调工作模式
    /// </summary>
    AIRCONDITION_SETMODE,
    /// <summary>
    /// Set fan mode
    /// 设置空调送风模式
    /// </summary>
    AIRCONDITION_SETWINDMODE,
    /// <summary>
    /// Recover device default and set new protocol
    /// 恢复设备的默认设置新协议
    /// </summary>
    RESTOREDEFAULT_EX,
    /// <summary>
    /// send event to device
    /// 向设备发送事件
    /// </summary>
    NOTIFY_EVENT,
    /// <summary>
    /// mute alarm setup
    /// 无声报警设置
    /// </summary>
    SILENT_ALARM_SET,
    /// <summary>
    /// device start sound report
    /// 设备开始语音播报
    /// </summary>
    START_PLAYAUDIOEX,
    /// <summary>
    /// device stop sound report
    /// 设备停止语音播报
    /// </summary>
    STOP_PLAYAUDIOEX,
    /// <summary>
    /// close gateway
    /// 关闭道闸
    /// </summary>
    CLOSE_STROBE,
    /// <summary>
    /// set parking reservation status
    /// 设置车位预定状态
    /// </summary>
    SET_ORDER_STATE,
    /// <summary>
    /// add fingerprint record, get record no. NET_CTRL_RECORDSET_INSERT_PARAM
    /// 添加指纹记录,获得记录集编号 NET_CTRL_RECORDSET_INSERT_PARAM
    /// </summary>
    RECORDSET_INSERTEX,
    /// <summary>
    /// update finger print record  NET_CTRL_RECORDSET_PARAM
    /// 更新指纹记录集编号的记录  NET_CTRL_RECORDSET_PARAM
    /// </summary>
    RECORDSET_UPDATEEX,
    /// <summary>
    /// fingerprint collection
    /// 指纹采集
    /// </summary>
    CAPTURE_FINGER_PRINT,
    /// <summary>
    /// Parking lot entrance/exit controller LED setup
    /// 停车场出入口控制器LED设置
    /// </summary>
    ECK_LED_SET,
    /// <summary>
    /// Intelligent parking system in/out device IC card info import
    /// 智能停车系统出入口机IC卡信息导入
    /// </summary>
    ECK_IC_CARD_IMPORT,
    /// <summary>
    /// Intelligent parking system in/out device IC card info sync command, receive this command, device will delete original IC card info
    /// 智能停车系统出入口机IC卡信息同步指令,收到此指令后,设备删除原有IC卡信息
    /// </summary>
    ECK_SYNC_IC_CARD,
    /// <summary>
    /// Delete specific wireless device
    /// 删除指定无线设备
    /// </summary>
    LOWRATEWPAN_REMOVE,
    /// <summary>
    /// Modify wireless device info
    /// 修改无线设备信息
    /// </summary>
    LOWRATEWPAN_MODIFY,
    /// <summary>
    /// Set up the vehicle spot information of the machine at the passageway of the intelligent parking system
    /// 智能停车系统出入口机设置车位信息
    /// </summary>
    ECK_SET_PARK_INFO,
    /// <summary>
    /// hang up the video phone
    /// 挂断视频电话
    /// </summary>
    VTP_DISCONNECT,
    /// <summary>
    /// the update of the remote multimedia files
    /// 远程投放多媒体文件更新
    /// </summary>
    UPDATE_FILES,
    /// <summary>
    /// Save up the relationship between the hyponymy matrixes
    /// 保存上下位矩阵输出关系
    /// </summary>
    MATRIX_SAVE_SWITCH,
    /// <summary>
    /// recover the relationship between the hyponymy matrixes
    /// 恢复上下位矩阵输出关系
    /// </summary>
    MATRIX_RESTORE_SWITCH,
    /// <summary>
    /// video talk phone divert ack
    /// 呼叫转发响应
    /// </summary>
    VTP_DIVERTACK,
    /// <summary>
    /// Rain-brush brush one time, efficient when set as manual mode
    /// 雨刷来回刷一次,雨刷模式配置为手动模式时有效
    /// </summary>
    RAINBRUSH_MOVEONCE,
    /// <summary>
    /// Rain-brush brush cyclic, efficient when set as manal mode
    /// 雨刷来回循环刷,雨刷模式配置为手动模式时有效
    /// </summary>
    RAINBRUSH_MOVECONTINUOUSLY,
    /// <summary>
    /// Rain-brush stop, efficient when set as manal mode
    /// 雨刷停止刷,雨刷模式配置为手动模式时有效
    /// </summary>
    RAINBRUSH_STOPMOVE,
    /// <summary>
    /// affirm the alarm event
    /// 报警事件确认
    /// </summary>
    ALARM_ACK,
    /// <summary>
    /// Batch import record set info
    /// 批量导入记录集信息
    /// </summary>
    RECORDSET_IMPORT,
    /// <summary>
    /// Delivery file to the video output port, building intercom use, run at the same time(Corresponding to NET_CTRL_DELIVERY_FILE)
    /// 向视频输出口投放视频和图片文件, 楼宇对讲使用，同一时间投放(对应NET_CTRL_DELIVERY_FILE)
    /// </summary>
    DELIVERY_FILE,
    /// <summary>
    /// Force breaking rule(Corresponding to NET_CTRL_FORCE_BREAKING)
    /// 强制产生违章类型(对应 NET_CTRL_FORCE_BREAKING)
    /// </summary>
    FORCE_BREAKING,
    /// <summary>
    /// Restore the configuration except the prescribed config.
    ///  恢复除指定配置外的其他配置为默认。
    /// </summary>
    RESTORE_EXCEPT,
    /// <summary>
    /// Set park info, platform is set to camera,the content is used for the dot matrix display(corresponding to NET_CTRL_SET_PARK_INFO)
    /// 设置停车信息，平台设置给相机，内容用于点阵屏显示(对应结构体 NET_CTRL_SET_PARK_INFO)
    /// </summary>
    SET_PARK_INFO,
    /// <summary>
    /// clear the statistics for the period and start again from 0 (Corresponding to NET_CTRL_CLEAR_SECTION_STAT_INFO)
    /// 清除当前时间段内人数统计信息, 重新从0开始计算(对应结构体NET_CTRL_CLEAR_SECTION_STAT_INFO)
    /// </summary>
    CLEAR_SECTION_STAT,
    /// <summary>
    /// Send video and image files to video output, Used by car, The ad time is served separately(Corresponding NET_CTRL_DELIVERY_FILE_BYCAR)
    /// 向视频输出口投放视频和图片文件, 车载使用，广告单独时间投放(对应NET_CTRL_DELIVERY_FILE_BYCAR)
    /// </summary>
    DELIVERY_FILE_BYCAR,

    /// <summary>
    /// Enable or disable thermal shutter
    /// 设置热成像快门启用/禁用
    /// </summary>
    THERMO_GRAPHY_ENSHUTTER = 0x10000,
    /// <summary>
    /// set the OSD of the temperature measurement item to be highlighted
    /// 设置测温项的osd为高亮
    /// </summary>
    RADIOMETRY_SETOSDMARK,
    /// <summary>
    /// Enable audio record and get audio name
    /// 开启音频录音并得到录音名
    /// </summary>
    AUDIO_REC_START_NAME,
    /// <summary>
    /// Close audio file and return file name
    /// 关闭音频录音并返回文件名称
    /// </summary>
    AUDIO_REC_STOP_NAME,
    /// <summary>
    /// Manual snap
    /// 即时抓图
    /// </summary>
    SNAP_MNG_SNAP_SHOT,
    /// <summary>
    /// Forcedly sync buffer data to the database and close the database
    /// 强制同步缓存数据到数据库并关闭数据库
    /// </summary>
    LOG_STOP,
    /// <summary>
    /// Resume database
    /// 恢复数据库
    /// </summary>
    LOG_RESUME,
    /// <summary>
    /// Add a POS device
    /// 增加一个Pos设备
    /// </summary>
    POS_ADD,
    /// <summary>
    /// Del a POS device
    /// 删除一个Pos设备
    /// </summary>
    POS_REMOVE,
    /// <summary>
    /// Del several POS device
    /// 批量删除Pos设备
    /// </summary>
    POS_REMOVE_MULTI,
    /// <summary>
    /// Modify a POS device
    /// 修改一个Pos设备
    /// </summary>
    POS_MODIFY,
    /// <summary>
    /// Trigger alarm with sound
    /// 触发有声报警
    /// </summary>
    SET_SOUND_ALARM,
    /// <summary>
    /// audiomatrix silence
    /// 音频举证一键静音控制
    /// </summary>
    AUDIO_MATRIX_SILENCE,
    /// <summary>
    /// manual upload picture
    /// 设置手动上传
    /// </summary>
    MANUAL_UPLOAD_PICTURE,
    /// <summary>
    /// reboot network decoding device
    /// 重启网络解码设备
    /// </summary>
    REBOOT_NET_DECODING_DEV,
    /// <summary>
    /// ParkingControl about setting IC Sender 
    /// ParkingControl 设置发卡设备
    /// </summary>
    SET_IC_SENDER,
    /// <summary>
    /// set the media type ,e.g. audio only,video only , audio & video
    /// 设置监视码流组成,如仅音频,仅视频,音视频
    /// </summary>
    SET_MEDIAKIND,
    /// <summary>
    /// Add wireless device info
    /// 增加无线设备信息
    /// </summary>
    LOWRATEWPAN_ADD,
    /// <summary>
    /// remove all the wireless device info
    /// 删除所有的无线设备信息
    /// </summary>
    LOWRATEWPAN_REMOVEALL,
    /// <summary>
    /// Set the work mode of door
    /// 设置门锁工作模式
    /// </summary>
    SET_DOOR_WORK_MODE,
    /// <summary>
    /// Test Mail
    /// 测试邮件
    /// </summary>
    TEST_MAIL,
    /// <summary>
    /// Control smart switch
    /// 控制智能开关
    /// </summary>
    CONTROL_SMART_SWITCH,
    /// <summary>
    /// Set the work mode of the detector
    /// 设置探测器的工作模式 
    /// </summary>
    LOWRATEWPAN_SETWORKMODE,
  }

  /// <summary>
  /// Manual snap parameter sturct
  /// 手动抓拍参数
  /// </summary>
  public struct NET_MANUAL_SNAP_PARAMETER
  {
    /// <summary>
    /// snap channel,start with 0
    /// 抓图通道,从0开始
    /// </summary>
    public int nChannel;
    /// <summary>
    /// snap sequence string
    /// 抓图序列号字符串
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string bySequence;
    /// <summary>
    /// reserved
    /// 保留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 60)]
    public byte[] byReserved;
  }
  #region<<Monitor Wall>>
  /// <summary>
  /// Matrix sub card list
  /// 矩阵子卡列表
  /// </summary>
  public struct NET_MATRIX_CARD_LIST
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// count
    /// 子卡数量
    /// </summary>
    public int nCount;
    /// <summary>
    /// card info
    /// 子卡列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public NET_MATRIX_CARD[] stuCards;
  }

  /// <summary>
  /// Matrix sub card info
  /// 矩阵子卡信息
  /// </summary>
  public struct NET_MATRIX_CARD
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Valid or not
    /// 是否有效
    /// </summary>
    public bool bEnable;
    /// <summary>
    /// Sub card type
    /// 子卡类型
    /// </summary>
    public uint dwCardType;
    /// <summary>
    /// Signal interface type, "CVBS", "VGA", "DVI"...
    /// 信号接口类型, "CVBS", "VGA", "DVI"...
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szInterface;
    /// <summary>
    /// Device IP or domain name. The sub card that has no network conneciton can be null
    /// 设备ip或域名, 无网络接口的子卡可以为空
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szAddress;
    /// <summary>
    /// Port No. The sub card that has no network conneciton can be 0
    /// 端口号, 无网络接口的子卡可以为0
    /// </summary>
    public int nPort;
    /// <summary>
    /// Definition. 0=standard definition. 1=High definition
    /// 清晰度, 0=标清, 1=高清
    /// </summary>
    public int nDefinition;
    /// <summary>
    /// Video input channel amount
    /// 视频输入通道数
    /// </summary>
    public int nVideoInChn;
    /// <summary>
    /// Audio input channel amount
    /// 音频输入通道数
    /// </summary>
    public int nAudioInChn;
    /// <summary>
    /// Video output channel amount
    /// 视频输出通道数
    /// </summary>
    public int nVideoOutChn;
    /// <summary>
    /// Audio output channel amount
    /// 音频输出通道数
    /// </summary>
    public int nAudioOutChn;
    /// <summary>
    /// Video encode channel amount
    /// 视频编码通道数
    /// </summary>
    public int nVideoEncChn;
    /// <summary>
    /// Audio encode channel amount
    /// 音频编码通道数
    /// </summary>
    public int nAudioEncChn;
    /// <summary>
    /// Video decode channel amount
    /// 视频解码通道数
    /// </summary>
    public int nVideoDecChn;
    /// <summary>
    /// Audio decode channel amount
    /// 音频解码通道数
    /// </summary>
    public int nAudioDecChn;
    /// <summary>
    /// Status: 0-OK, 1-no respond, 2-network disconnection, 3-conflict, 4-upgrading now
    /// 状态: -1-未知, 0-正常, 1-无响应, 2-网络掉线, 3-冲突, 4-正在升级, 5-链路状态异常, 6-子板背板未插好, 7-程序版本出错
    /// </summary>
    public int nStauts;
    /// <summary>
    /// COM amount
    /// 串口数
    /// </summary>
    public int nCommPorts;
    /// <summary>
    /// Video input channel min value
    /// 视频输入通道号最小值
    /// </summary>
    public int nVideoInChnMin;
    /// <summary>
    /// Video input channel max value
    /// 视频输入通道号最大值
    /// </summary>
    public int nVideoInChnMax;
    /// <summary>
    /// Audio input channel min value
    /// 音频输入通道号最小值
    /// </summary>
    public int nAudioInChnMin;
    /// <summary>
    /// Audio input channel max value
    /// 音频输入通道号最大值
    /// </summary>
    public int nAudioInChnMax;
    /// <summary>
    /// Video output channel min value
    /// 视频输出通道号最小值
    /// </summary>
    public int nVideoOutChnMin;
    /// <summary>
    /// Video output channel max value
    /// 视频输出通道号最大值
    /// </summary>
    public int nVideoOutChnMax;
    /// <summary>
    /// Audio output channel min value
    /// 音频输出通道号最小值
    /// </summary>
    public int nAudioOutChnMin;
    /// <summary>
    /// Audio output channel max value
    /// 音频输出通道号最大值
    /// </summary>
    public int nAudioOutChnMax;
    /// <summary>
    /// Video encode channel min value
    /// 视频编码通道号最小值
    /// </summary>
    public int nVideoEncChnMin;
    /// <summary>
    /// Video encode channel max value
    /// 视频编码通道号最大值
    /// </summary>
    public int nVideoEncChnMax;
    /// <summary>
    /// Audio encode channel min value
    /// 音频编码通道号最小值
    /// </summary>
    public int nAudioEncChnMin;
    /// <summary>
    /// Audio encode channel max value
    /// 音频编码通道号最大值
    /// </summary>
    public int nAudioEncChnMax;
    /// <summary>
    /// Video decode channel min value
    /// 视频解码通道号最小值
    /// </summary>
    public int nVideoDecChnMin;
    /// <summary>
    /// Video decode channel max value
    /// 视频解码通道号最大值
    /// </summary>
    public int nVideoDecChnMax;
    /// <summary>
    /// Audio decode channel min value
    /// 音频解码通道号最小值
    /// </summary>
    public int nAudioDecChnMin;
    /// <summary>
    /// Audio decode channel max value
    /// 音频解码通道号最大值
    /// </summary>
    public int nAudioDecChnMax;
    /// <summary>
    /// number of cascade channel
    /// 级联通道数
    /// </summary>
    public int nCascadeChannels;
    /// <summary>
    /// cascade channel bitrate (Mbps)
    /// 级联通道带宽, 单位Mbps
    /// </summary>
    public int nCascadeChannelBitrate;
    /// <summary>
    /// Alarm input channel number 
    /// 报警输入通道数
    /// </summary>
    public int nAlarmInChnCount;
    /// <summary>
    /// Alarm input channel number minimum value
    /// 报警输入通道号最小值
    /// </summary>
    public int nAlarmInChnMin;
    /// <summary>
    /// Alarm input channel number maximum value
    /// 报警输入通道号最大值
    /// </summary>
    public int nAlarmInChnMax;
    /// <summary>
    /// Alarm output channel number 
    /// 报警输出通道数
    /// </summary>
    public int nAlarmOutChnCount;
    /// <summary>
    /// Alarm output channel number minimum value
    /// 报警输入通道号最小值
    /// </summary>
    public int nAlarmOutChnMin;
    /// <summary>
    /// Alarm output channel number maximum value
    /// 报警输入通道号最大值
    /// </summary>
    public int nAlarmOutChnMax;
    /// <summary>
    /// Intelligent analysis of channel number 
    /// 智能分析通道数
    /// </summary>
    public int nVideoAnalyseChnCount;
    /// <summary>
    /// Intelligent analysis of channel number minimum value
    /// 智能分析通道号最小值
    /// </summary>
    public int nVideoAnalyseChnMin;
    /// <summary>
    /// Intelligent analysis of channel number maximum value
    /// 智能分析通道号最大值
    /// </summary>
    public int nVideoAnalyseChnMax;
    /// <summary>
    /// minimum value of serial port number
    /// 串口号最小值
    /// </summary>
    public int nCommPortMin;
    /// <summary>
    /// maximum value of serial port number
    /// 串口号最大值
    /// </summary>
    public int nCommPortMax;
    /// <summary>
    /// Version info
    /// 版本信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szVersion;
    /// <summary>
    /// compile time
    /// 编译时间
    /// </summary>
    public NET_TIME stuBuildTime;
    /// <summary>
    /// BIOS Version
    /// BIOS版本号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szBIOSVersion;
    /// <summary>
    /// MAC address
    /// MAC地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string szMAC;
  }

  /// <summary>
  /// composite screen channel information
  /// 融合屏通道信息
  /// </summary>
  public struct NET_COMPOSITE_CHANNEL
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// monitor wall name
    /// 电视墙名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szMonitorWallName;
    /// <summary>
    /// composite ID
    /// 融合屏ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szCompositeID;
    /// <summary>
    /// virtual channel
    /// 虚拟通道号
    /// </summary>
    public int nVirtualChannel;
  }

  /// <summary>
  /// Split mode
  /// 分割模式
  /// </summary>
  public enum EM_SPLIT_MODE
  {
    /// <summary>
    /// 1-window
    /// 1画面
    /// </summary>
    SPLIT_1 = 1,
    /// <summary>
    /// 2-window
    /// 2画面
    /// </summary>
    SPLIT_2 = 2,
    /// <summary>
    /// 4-window
    /// 4画面
    /// </summary>
    SPLIT_4 = 4,
    /// <summary>
    /// 6-window
    /// 6画面
    /// </summary>
    SPLIT_6 = 6,
    /// <summary>
    /// 8-window
    /// 8画面
    /// </summary>
    SPLIT_8 = 8,
    /// <summary>
    /// 9-window
    /// 9画面
    /// </summary>
    SPLIT_9 = 9,
    /// <summary>
    /// 12-window
    /// 12画面
    /// </summary>
    SPLIT_12 = 12,
    /// <summary>
    /// 16-window
    /// 16画面
    /// </summary>
    SPLIT_16 = 16,
    /// <summary>
    /// 20-window
    /// 20画面
    /// </summary>
    SPLIT_20 = 20,
    /// <summary>
    /// 25-window
    /// 25画面
    /// </summary>
    SPLIT_25 = 25,
    /// <summary>
    /// 36-window
    /// 36画面
    /// </summary>
    SPLIT_36 = 36,
    /// <summary>
    /// 64-window
    /// 64画面
    /// </summary>
    SPLIT_64 = 64,
    /// <summary>
    /// 144-window
    /// 144画面
    /// </summary>
    SPLIT_144 = 144,
    /// <summary>
    /// PIP mode.1-full screen+1-small window
    /// 画中画模式, 1个全屏大画面+1个小画面窗口
    /// </summary>
    PIP_1 = 1000 + 1,
    /// <summary>
    /// PIP mode.1-full screen+3-small window
    /// 画中画模式, 1个全屏大画面+3个小画面窗口
    /// </summary>
    PIP_3 = 1000 + 3,
    /// <summary>
    /// free open window mode,are free to create,close, window position related to the z axis
    /// 自由开窗模式,可以自由创建、关闭窗口,自由设置窗口位置和Z轴次序
    /// </summary>
    SPLIT_FREE = 1000 * 2,
    /// <summary>
    /// integration of a split screen
    /// 融合屏成员1分割
    /// </summary>
    COMPOSITE_SPLIT_1 = 1000 * 3 + 1,
    /// <summary>
    /// fusion of four split screen
    /// 融合屏成员4分割
    /// </summary>
    COMPOSITE_SPLIT_4 = 1000 * 3 + 4,
    /// <summary>
    /// 3-window
    /// 3画面
    /// </summary>
    SPLIT_3 = 10,
    /// <summary>
    /// 3-window(bottom) 
    /// 3画面倒品
    /// </summary>
    SPLIT_3B = 11,
  }

  /// <summary>
  /// split display type
  /// 分割显示类型
  /// </summary>
  public enum EM_SPLIT_DISPLAY_TYPE
  {
    /// <summary>
    /// Common display types
    /// 普通显示类型
    /// </summary>
    GENERAL = 1,
    /// <summary>
    /// PIP Display Type
    /// 画中画显示类型
    /// </summary>
    PIP = 2,
    /// <summary>
    /// Custom Display Type
    /// 自由组合分割模式
    /// </summary>
    CUSTOM = 3,
  }

  /// <summary>
  /// Split capability
  /// 分割能力
  /// </summary>
  public struct NET_SPLIT_CAPS
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// The split amount supported
    /// 支持的分割模式数量
    /// </summary>
    public int nModeCount;
    /// <summary>
    /// The split mode supported
    /// 支持的分割模式
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public EM_SPLIT_MODE[] emSplitMode;
    /// <summary>
    /// Max display source allocation amount
    /// 最大显示源配置数
    /// </summary>
    public int nMaxSourceCount;
    /// <summary>
    /// count of free window support
    /// 支持的最大自由开窗数目
    /// </summary>
    public int nFreeWindowCount;
    /// <summary>
    /// support collection
    /// 是否支持区块收藏
    /// </summary>
    public bool bCollectionSupported;
    /// <summary>
    /// mask means multiple display types, see EM_SPLIT_DISPLAY_TYPE, under each mode in note , displayed content depends on "PicInPic", each mode displayed content by NVD old rule, as depending on DisChntext, Compatible, no this item, default is normal display type as"General"
    /// 掩码表示多个显示类型,具体见EM_SPLIT_DISPLAY_TYPE（注释各模式下显示内容由"PicInPic"决定, 各模式下显示内容按NVD旧有规则决定（即DisChn字段决定）。兼容,没有这一个项时,默认为普通显示类型,即"General"）
    /// </summary>
    public uint dwDisplayType;
    /// <summary>
    /// PIP support split mode quantity
    /// 画中画支持的分割模式数量
    /// </summary>
    public int nPIPModeCount;
    /// <summary>
    /// PIP supported split mode
    /// 画中画支持的分割模式
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public EM_SPLIT_MODE[] emPIPSplitMode;
    /// <summary>
    /// supported input channel
    /// 支持的输入通道
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public int[] nInputChannels;
    /// <summary>
    /// supported input channel quantity, 0 means no input channel limit
    /// 支持的输入通道个数, 0表示没有输入通道限制
    /// </summary>
    public int nInputChannelCount;
    /// <summary>
    /// enable split mode quantity
    /// 启动分割模式数量
    /// </summary>
    public int nBootModeCount;
    /// <summary>
    /// support enable default video split mode
    /// 支持的启动默认画面分割模式
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public EM_SPLIT_MODE[] emBootMode;
  }

  /// <summary>
  /// Split mode info
  /// 一屏幕的分割模式信息
  /// </summary>
  public struct NET_SPLIT_MODE_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Split mode
    /// 分割模式
    /// </summary>
    public EM_SPLIT_MODE emSplitMode;
    /// <summary>
    /// Group SN
    /// 分组序号
    /// </summary>
    public int nGroupID;
    /// <summary>
    /// display type, see EM_SPLIT_DISPLAY_TYPE, under each mode in note , displayed content depends on "PicInPic", each mode displayed content by NVD old rule, as depending on DisChntext, . Compatible, no this item, default is normal display type as"General"
    /// 显示类型；具体见EM_SPLIT_DISPLAY_TYPE（注释各模式下显示内容由"PicInPic"决定, 各模式下显示内容按NVD旧有规则决定（即DisChn字段决定）。兼容,没有这一个项时,默认为普通显示类型,即"General"）
    /// </summary>
    public uint dwDisplayType;
  }

  /// <summary>
  /// OpenSplitWindow's interface input param(open window)
  /// OpenSplitWindow接口输入参数(开窗)
  /// </summary>
  public struct NET_IN_SPLIT_OPEN_WINDOW
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel no.
    /// 通道号(屏号)
    /// </summary>
    public int nChannel;
    /// <summary>
    /// windon position, 0~8192
    /// 窗口位置, 0~8192
    /// </summary>
    public NET_RECT stuRect;
    /// <summary>
    /// coordinate whether meet the confitions
    /// 坐标是否满足直通条件, 直通是指拼接屏方式下,此窗口区域正好为物理屏区域
    /// </summary>
    public bool bDirectable;
  }

  /// <summary>
  /// OpenSplitWindow's interface output param(open window)
  /// OpenSplitWindow接口输出参数(开窗)
  /// </summary>
  public struct NET_OUT_SPLIT_OPEN_WINDOW
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// window ID
    /// 窗口序号
    /// </summary>
    public uint nWindowID;
    /// <summary>
    /// window order
    /// 窗口次序
    /// </summary>
    public uint nZOrder;
  }

  /// <summary>
  /// MatrixGetCameras's interface input param
  /// MatrixGetCameras接口的输入参数
  /// </summary>
  public struct NET_IN_MATRIX_GET_CAMERAS
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// MatrixGetCameras's interface output param
  /// MatrixGetCameras接口的输出参数
  /// </summary>
  public struct NET_OUT_MATRIX_GET_CAMERAS
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// size of source array,the space application by the user,apply to sizeof(NET_MATRIX_CAMERA_INFO)*nMaxCameraCount
    /// 显示源信息数组, 用户分配内存,大小为sizeof(NET_MATRIX_CAMERA_INFO)*nMaxCameraCount
    /// </summary>
    public IntPtr pstuCameras;
    /// <summary>
    /// count
    /// 显示源数组大小
    /// </summary>
    public int nMaxCameraCount;
    /// <summary>
    /// return count
    /// 返回的显示源数量
    /// </summary>
    public int nRetCameraCount;
  }

  /// <summary>
  /// available according to the source of information
  /// 可用的显示源信息
  /// </summary>
  public struct NET_MATRIX_CAMERA_INFO
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// name
    /// 名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// device ID
    /// 设备ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDevID;
    /// <summary>
    /// control ID
    /// 控制ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szControlID;
    /// <summary>
    /// channel ID, DeviceID is unique
    /// 通道号, DeviceID设备内唯一
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// unique channel
    /// 设备内统一编号的唯一通道号
    /// </summary>
    public int nUniqueChannel;
    /// <summary>
    /// support remote device or not
    /// 是否远程设备
    /// </summary>
    public bool bRemoteDevice;
    /// <summary>
    /// info of remote device
    /// 远程设备信息
    /// </summary>
    public NET_REMOTE_DEVICE stuRemoteDevice;
    /// <summary>
    /// stream type
    /// 视频码流类型
    /// </summary>
    public EM_STREAM_TYPE emStreamType;
    /// <summary>
    /// Channel Types 
    /// 通道类型
    /// </summary>
    public EM_LOGIC_CHN_TYPE emChannelType;
  }

  /// <summary>
  /// video stream type
  /// 视频码流类型
  /// </summary>
  public enum EM_STREAM_TYPE
  {
    /// <summary>
    /// Others
    /// 其它
    /// </summary>
    ERR,
    /// <summary>
    /// Main stream
    /// 主码流
    /// </summary>
    MAIN,
    /// <summary>
    /// Extra stream 1
    /// 辅码流1
    /// </summary>
    EXTRA_1,
    /// <summary>
    /// Extra stream 2
    /// 辅码流2
    /// </summary>
    EXTRA_2,
    /// <summary>
    /// Extra stream 3
    /// 辅码流3
    /// </summary>
    EXTRA_3,
    /// <summary>
    /// Snap bit stream
    /// 抓图码流
    /// </summary>
    SNAPSHOT,
    /// <summary>
    /// Object stream
    /// 物体流
    /// </summary>
    OBJECT,
    /// <summary>
    /// Auto
    /// 自动选择合适码流
    /// </summary>
    AUTO,
    /// <summary>
    /// Preview
    /// 预览裸数据码流
    /// </summary>
    PREVIEW,
    /// <summary>
    /// No video stream (audio only)
    /// 无视频码流(纯音频)
    /// </summary>
    NONE,
  }

  /// <summary>
  /// logic chnnel type
  /// 逻辑通道类型
  /// </summary>
  public enum EM_LOGIC_CHN_TYPE
  {
    /// <summary>
    /// Unknow
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// Local channel 
    /// 本地通道
    /// </summary>
    LOCAL,
    /// <summary>
    /// Remote access channel 
    /// 远程通道
    /// </summary>
    REMOTE,
    /// <summary>
    /// Synthesis of channel, for the judicial equipment contains picture in picture channel and mixing channel
    /// 合成通道, 对于庭审设备包含画中画通道和混音通道
    /// </summary>
    COMPOSE,
    /// <summary>
    /// matrix channel, including analog matrix and digital matrix
    /// 模拟矩阵通道
    /// </summary>
    MATRIX,
    /// <summary>
    /// cascading channel
    /// 级联通道
    /// </summary>
    CASCADE,
  }

  /// <summary>
  /// remote device
  /// 远程设备
  /// </summary>
  public struct NET_REMOTE_DEVICE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// enable
    /// 使能
    /// </summary>
    public bool bEnable;
    /// <summary>
    /// IP
    /// IP
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szIp;
    /// <summary>
    /// username
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string szUser;
    /// <summary>
    /// password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string szPwd;
    /// <summary>
    /// port
    /// 端口
    /// </summary>
    public int nPort;
    /// <summary>
    /// definition. 0-standard definition, 1-high definition
    /// 清晰度, 0-标清, 1-高清
    /// </summary>
    public int nDefinition;
    /// <summary>
    /// protocol type
    /// 协议类型
    /// </summary>
    public EM_DEVICE_PROTOCOL emProtocol;
    /// <summary>
    /// device name
    /// 设备名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevName;
    /// <summary>
    /// count channel of video input
    /// 视频输入通道数
    /// </summary>
    public int nVideoInputChannels;
    /// <summary>
    /// count channel of audio input
    /// 音频输入通道数
    /// </summary>
    public int nAudioInputChannels;
    /// <summary>
    /// device type, such as IPC, DVR, NVR
    /// 设备类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevClass;
    /// <summary>
    /// device type, such as IPC-HF3300
    /// 设备具体型号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevType;
    /// <summary>
    /// Http port
    /// Http端口
    /// </summary>
    public int nHttpPort;
    /// <summary>
    /// max count of video input
    /// 视频输入通道最大数
    /// </summary>
    public int nMaxVideoInputCount;
    /// <summary>
    /// return count
    /// 返回实际通道个数
    /// </summary>
    public int nRetVideoInputCount;
    /// <summary>
    /// max count of video input, user malloc the memory,apply to sizeof(NET_VIDEO_INPUTS)*nMaxVideoInputCount
    /// 视频输入通道信息,由用户申请内存，大小为sizeof(NET_VIDEO_INPUTS)*nMaxVideoInputCount
    /// </summary>
    public IntPtr pstuVideoInputs;
    /// <summary>
    /// machine address
    /// 设备部署地
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szMachineAddress;
    /// <summary>
    /// serial no.
    /// 设备序列号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szSerialNo;
    /// <summary>
    /// Rtsp Port
    /// Rtsp端口
    /// </summary>
    public int nRtspPort;
    /// <summary>
    /// username
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserEx;
    /// <summary>
    /// password  
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPwdEx;
  }

  /// <summary>
  /// Device protocol type
  /// 设备协议类型
  /// </summary>
  public enum EM_DEVICE_PROTOCOL
  {
    /// <summary>
    /// private 2nd protocol
    /// 私有2代协议
    /// </summary>
    PRIVATE2,
    /// <summary>
    /// private 3rd protocol
    /// 私有3代协议
    /// </summary>
    PRIVATE3,
    /// <summary>
    /// Onvif
    /// Onvif
    /// </summary>
    ONVIF,
    /// <summary>
    /// virtual network computer
    /// 虚拟网络计算机
    /// </summary>
    VNC,
    /// <summary>
    /// Standard TS
    /// 标准TS
    /// </summary>
    TS,
    /// <summary>
    /// private protocol of private 
    /// 私有协议
    /// </summary>
    PRIVATE = 100,
    /// <summary>
    /// aebell
    /// 美电贝尔
    /// </summary>
    AEBELL,
    /// <summary>
    /// panasonic
    /// 松下
    /// </summary>
    PANASONIC,
    /// <summary>
    /// sony
    /// 索尼
    /// </summary>
    SONY,
    /// <summary>
    /// Dynacolor
    /// Dynacolor
    /// </summary>
    DYNACOLOR,
    /// <summary>
    /// tcsw
    /// 天城威视
    /// </summary>
    TCWS,
    /// <summary>
    /// samsung
    /// 三星
    /// </summary>
    SAMSUNG,
    /// <summary>
    /// YOKO
    /// YOKO
    /// </summary>
    YOKO,
    /// <summary>
    /// axis
    /// 安讯视
    /// </summary>
    AXIS,
    /// <summary>
    /// sanyo
    /// 三洋
    /// </summary>
    SANYO,
    /// <summary>
    /// Bosch
    /// Bosch
    /// </summary>
    BOSH,
    /// <summary>
    /// Peclo
    /// Peclo
    /// </summary>
    PECLO,
    /// <summary>
    /// Provideo
    /// Provideo
    /// </summary>
    PROVIDEO,
    /// <summary>
    /// ACTi
    /// ACTi
    /// </summary>
    ACTI,
    /// <summary>
    /// Vivotek
    /// Vivotek
    /// </summary>
    VIVOTEK,
    /// <summary>
    /// Arecont
    /// Arecont
    /// </summary>
    ARECONT,
    /// <summary>
    /// PrivateEH
    /// PrivateEH
    /// </summary>
    PRIVATEEH,
    /// <summary>
    /// IMatek
    /// IMatek
    /// </summary>
    IMATEK,
    /// <summary>
    /// Shany
    /// Shany
    /// </summary>
    SHANY,
    /// <summary>
    /// videotrec
    /// 动力盈科
    /// </summary>
    VIDEOTREC,
    /// <summary>
    /// Ura
    /// Ura
    /// </summary>
    URA,
    /// <summary>
    /// Bticino
    /// Bticino
    /// </summary>
    BITICINO,
    /// <summary>
    /// Onvif's protocol type, same to NET_PROTOCOL_ONVIF
    /// Onvif协议类型, 同NET_PROTOCOL_ONVIF
    /// </summary>
    ONVIF2,
    /// <summary>
    /// shepherd
    /// 视霸
    /// </summary>
    SHEPHERD,
    /// <summary>
    /// yaan
    /// 亚安
    /// </summary>
    YAAN,
    /// <summary>
    /// Airpop
    /// Airpop
    /// </summary>
    AIRPOINT,
    /// <summary>
    /// TYCO
    /// TYCO
    /// </summary>
    TYCO,
    /// <summary>
    /// xunmei
    /// 讯美
    /// </summary>
    XUNMEI,
    /// <summary>
    /// hikvision
    /// 海康
    /// </summary>
    HIKVISION,
    /// <summary>
    /// LG
    /// LG
    /// </summary>
    LG,
    /// <summary>
    /// aoqiman
    /// 奥奇曼
    /// </summary>
    AOQIMAN,
    /// <summary>
    /// baokang
    /// 宝康
    /// </summary>
    BAOKANG,
    /// <summary>
    /// Watchnet
    /// Watchnet
    /// </summary>
    WATCHNET,
    /// <summary>
    /// Xvision
    /// Xvision
    /// </summary>
    XVISION,
    /// <summary>
    /// fusitsu
    /// 富士通
    /// </summary>
    FUSITSU,
    /// <summary>
    /// Canon
    /// Canon
    /// </summary>
    CANON,
    /// <summary>
    /// GE
    /// GE
    /// </summary>
    GE,
    /// <summary>
    /// basler
    /// 巴斯勒
    /// </summary>
    Basler,
    /// <summary>
    /// patro
    /// 帕特罗
    /// </summary>
    Patro,
    /// <summary>
    /// CPPLUS K series
    /// CPPLUS K系列 
    /// </summary>
    CPKNC,
    /// <summary>
    /// CPPLUS R series
    /// CPPLUS R系列  
    /// </summary>
    CPRNC,
    /// <summary>
    /// CPPLUS U series		
    /// CPPLUS U系列  
    /// </summary>
    CPUNC,
    /// <summary>
    /// CPPLUS IPC	
    /// CPPLUS IPC
    /// </summary>
    CPPLUS,
    /// <summary>
    ///  xunmeis,protocal is Onvif	
    /// 讯美s,实际协议为Onvif
    /// </summary>
    XunmeiS,
    /// <summary>
    /// GDDW
    /// 广东电网
    /// </summary>
    GDDW,
    /// <summary>
    /// PSIA
    /// PSIA
    /// </summary>
    PSIA,
    /// <summary>
    /// GB2818
    /// GB2818
    /// </summary>
    GB2818,
    /// <summary>
    /// GDYX
    /// GDYX
    /// </summary>
    GDYX,
    /// <summary>
    /// others
    /// 由用户自定义
    /// </summary>
    OTHER,
  }

  /// <summary>
  /// channel info of video input
  /// 视频输入通道信息
  /// </summary>
  public struct NET_VIDEO_INPUTS
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel name
    /// 通道名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szChnName;
    /// <summary>
    /// enable
    /// 使能
    /// </summary>
    public bool bEnable;
    /// <summary>
    /// control ID
    /// 控制ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szControlID;
    /// <summary>
    /// main stream url 
    /// 主码流url地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szMainStreamUrl;
    /// <summary>
    /// extra stream url
    /// 辅码流url地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szExtraStreamUrl;
    /// <summary>
    /// spare main stream address quantity
    /// 备用主码流地址数量
    /// </summary>
    public int nOptionalMainUrlCount;
    /// <summary>
    /// spare main stream address list. byte[] is 8*260
    /// 备用主码流地址列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 260)]
    public byte[] szOptionalMainUrls;
    /// <summary>
    /// spare sub stream address quantity
    /// 备用辅码流地址数量
    /// </summary>
    public int nOptionalExtraUrlCount;
    /// <summary>
    /// spare substream address list. byte[] is 8*260   
    /// 备用辅码流地址列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 260)]
    public byte[] szOptionalExtraUrls;
  }

  /// <summary>
  /// Display source
  /// 显示源
  /// </summary>
  public struct NET_SPLIT_SOURCE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Enable
    /// 使能
    /// </summary>
    public bool bEnable;
    /// <summary>
    /// IP, null means there is no setup.
    /// IP, 空表示没有设置
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szIp;
    /// <summary>
    /// User name
    /// 用户名, 建议使用szUserEx
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string szUser;
    /// <summary>
    /// Password
    /// 密码, 建议使用szPwdEx
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 8)]
    public string szPwd;
    /// <summary>
    /// Port
    /// 端口
    /// </summary>
    public int nPort;
    /// <summary>
    /// Channel No.
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Video bit stream. -1-auto, 0-main stream, 1-extra stream 1, 2-extra stream 2, 3-extra stream 3
    /// 视频码流, -1-自动, 0-主码流, 1-辅码流1, 2-辅码流2, 3-辅码流3, 4-snap, 5-预览
    /// </summary>
    public int nStreamType;
    /// <summary>
    /// Definition, 0-standard definition, 1-high definition
    /// 清晰度, 0-标清, 1-高清
    /// </summary>
    public int nDefinition;
    /// <summary>
    /// Protocol type
    /// 协议类型
    /// </summary>
    public EM_DEVICE_PROTOCOL emProtocol;
    /// <summary>
    /// Device name
    /// 设备名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevName;
    /// <summary>
    /// Video input channel amount
    /// 视频输入通道数
    /// </summary>
    public int nVideoChannel;
    /// <summary>
    /// Audio input channel amount,For decoder only
    /// 音频输入通道数
    /// </summary>
    public int nAudioChannel;
    /// <summary>
    /// Decoder or not.
    /// 是否是解码器
    /// </summary>
    public bool bDecoder;
    /// <summary>
    /// 0:TCP;1:UDP;2:multicast
    /// -1: auto, 0：TCP；1：UDP；2：组播
    /// </summary>
    public byte byConnType;
    /// <summary>
    /// 0:connect directly; 1:transfer
    /// 0：直连；1：转发
    /// </summary>
    public byte byWorkMode;
    /// <summary>
    /// isten port, valid with transfer; when byConnType is multicast, it is multiport
    /// 指示侦听服务的端口,转发时有效; byConnType为组播时,则作为多播端口
    /// </summary>
    public short wListenPort;
    /// <summary>
    /// szDevIp extension, front DVR Ip address (enter domain name)
    /// szDevIp扩展,前端DVR的IP地址(可以输入域名)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevIpEx;
    /// <summary>
    /// snapshot mode (valid when nStreamType==4) 0: request for single frame, 1: sechdule sending request
    /// 抓图模式(nStreamType==4时有效) 0：表示请求一帧,1：表示定时发送请求
    /// </summary>
    public byte bySnapMode;
    /// <summary>
    /// Target device manufacturer. Refer to EM_IPC_TYPE for detailed information.
    /// 目标设备的生产厂商, 具体参考EM_IPC_TYPE类
    /// </summary>
    public byte byManuFactory;
    /// <summary>
    /// target device type, 0:IPC
    /// 目标设备的设备类型, 0:IPC
    /// </summary>
    public byte byDeviceType;
    /// <summary>
    /// target device decode policy, 0:compatible with previous,1:real time level high 2: real time level medium,3: real time level low 4: default level 
    /// 5: fluency level high 6: fluency level medium,7: fluency level low
    /// 目标设备的解码策略, 0:兼容以前,1:实时等级高 2:实时等级中,3:实时等级低 4:默认等级,5:流畅等级高 6:流畅等级中,7:流畅等级低
    /// </summary>
    public byte byDecodePolicy;
    /// <summary>
    /// Http port number, 0-65535
    /// Http端口号, 0-65535
    /// </summary>
    public uint dwHttpPort;
    /// <summary>
    /// Rtsp port number, 0-65535
    /// Rtsp端口号, 0-65535
    /// </summary>
    public uint dwRtspPort;
    /// <summary>
    /// Remote channel name, modifiable only when name read is not vacant
    /// 远程通道名称, 只有读取到的名称不为空时才可以修改该通道的名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szChnName;
    /// <summary>
    /// Multicast IP address. Valid only when byConnType is multicast
    /// 多播IP地址, byConnType为组播时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szMcastIP;
    /// <summary>
    /// device ID, ""-null, "Local"  "Remote"
    /// 设备ID, ""-null, "Local"-本地通道, "Remote"-远程通道, 或者填入具体的RemoteDevice中的设备ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDeviceID;
    /// <summary>
    /// is remote channel or not(read only)
    /// 是否远程通道(只读)
    /// </summary>
    public bool bRemoteChannel;
    /// <summary>
    /// remote channel ID (read only), effective when bRemoteChannel=TRUE
    /// 远程通道ID(只读), bRemoteChannel=TRUE时有效
    /// </summary>
    public uint nRemoteChannelID;
    /// <summary>
    /// type of device, such as IPC, DVR, NVR and so on
    /// 设备类型, 如IPC, DVR, NVR等
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevClass;
    /// <summary>
    /// device specific type, such as IPC-HF3300
    /// 设备具体型号, 如IPC-HF3300
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevType;
    /// <summary>
    /// main stream url, effective when byManuFactory =D H_IPC_OTHER
    /// 主码流url地址, byManuFactory为DH_IPC_OTHER时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szMainStreamUrl;
    /// <summary>
    /// extra stream url, effective when byManuFactory =D H_IPC_OTHER
    /// 辅码流url地址, byManuFactory为NET_IPC_OTHER时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szExtraStreamUrl;
    /// <summary>
    /// unique channel ID, read only
    /// 设备内统一编号的唯一通道号, 只读
    /// </summary>
    public int nUniqueChannel;
    /// <summary>
    /// ssascade authemyication, effective when device ID = "Local/Cascade/SerialNo",  SerialNo is device seral no.
    /// 级联认证信息, 设备ID为"Local/Cascade/SerialNo"时有效, 其中SerialNo是设备序列号
    /// </summary>
    public NET_CASCADE_AUTHENTICATOR stuCascadeAuth;
    /// <summary>
    /// 0-normal video source, 1- alarm video source
    /// 0-普通视频源, 1-报警视频源
    /// </summary>
    public int nHint;
    /// <summary>
    /// back main stream address quantity
    /// 备用主码流地址数量
    /// </summary>
    public int nOptionalMainUrlCount;
    /// <summary>
    /// backup main stream address list
    /// 备用主码流地址列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 260)]
    public byte[] szOptionalMainUrls;
    /// <summary>
    /// backup sub stream address quantity
    /// 备用辅码流地址数量
    /// </summary>
    public int nOptionalExtraUrlCount;
    /// <summary>
    /// backup sub stream address list
    /// 备用辅码流地址列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 260)]
    public byte[] szOptionalExtraUrls;
    /// <summary>
    /// tour time intertval	unit:second
    /// 轮巡时间间隔   单位：秒
    /// </summary>
    public int nInterval;
    /// <summary>
    /// user name
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUserEx;
    /// <summary>
    /// password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szPwdEx;
    /// <summary>
    /// type of pushstream,effective when byConnType is TCP-Push or UDP-Push
    /// 推流方式的码流类型,只有byConnType为TCP-Push或UDP-Push才有该字段
    /// </summary>
    public EM_SRC_PUSHSTREAM_TYPE emPushStream;
  }

  /// <summary>
  /// even the authentication information
  /// 级联权限验证信息
  /// </summary>
  public struct NET_CASCADE_AUTHENTICATOR
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// user name
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUser;
    /// <summary>                                                       
    /// passwd                                                          
    /// 密码                                                                
    /// </summary>                                                      
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szPwd;
    /// <summary>                                                       
    /// serial no.                                                      
    /// 设备序列号                                                                
    /// </summary>                                                      
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szSerialNo;
  }

  /// <summary>
  /// src push stream type
  /// </summary>
  public enum EM_SRC_PUSHSTREAM_TYPE
  {
    /// <summary>
    /// device automatic recognition according to bit stream head, default
    /// 设备端根据码流头自动识别，默认值
    /// </summary>
    AUTO,
    /// <summary>
    /// Hikvision private bit stream
    /// 海康私有码流
    /// </summary>
    HIKVISION,
    /// <summary>
    /// PS
    /// PS流
    /// </summary>
    PS,
    /// <summary>
    /// TS
    /// TS流
    /// </summary>
    TS,
    /// <summary>
    /// SVAC
    /// SVAC码流
    /// </summary>
    SVAC,
  }

  /// <summary>
  /// SetSplitSourceEx  The input parameters of the interface 
  /// SetSplitSourceEx 接口的输入参数
  /// </summary>
  public struct NET_IN_SET_SPLIT_SOURCE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Video output control method 
    /// 视频输出控制方式
    /// </summary>
    public EM_VIDEO_OUT_CTRL_TYPE emCtrlType;
    /// <summary>
    /// Video output logical channel number,when the emCtrlType is EM_VIDEO_OUT_CTRL_CHANNEL effective
    /// 视频输出逻辑通道号, emCtrlType为EM_VIDEO_OUT_CTRL_CHANNEL时有效
    /// </summary>
    public int nChannel;
    /// <summary>
    /// Splicing screen ID, when the emCtrlType is EM_VIDEO_OUT_CTRL_CHANNEL effective
    /// 拼接屏ID, emCtrlType为EM_VIDEO_OUT_CTRL_COMPOSITE_ID时有效
    /// </summary>
    public IntPtr pszCompositeID;
    /// <summary>
    /// winder number, -1 means all windows of the current segmentation mode 
    /// 窗口号, -1表示当前分割模式下的所有窗口
    /// </summary>
    public int nWindow;
    /// <summary>
    /// pointer to NET_SPLIT_SOURCE. Video source information, when nWindow=-1, Video source is an array, and the number and the window number,the space application by the user,applt to sizeof(NET_SPLIT_SOURCE)*nSourceCount
    /// 视频源信息, 当nWindow=-1时, 视频源是个数组, 且数量与窗口数一致,由用户申请内存，大小为sizeof(NET_SPLIT_SOURCE)*nSourceCount
    /// </summary>
    public IntPtr pstuSources;
    /// <summary>
    /// Video source number
    /// 视频源数量
    /// </summary>
    public int nSourceCount;
  }

  /// <summary>
  /// Video output control method
  /// 视频输出控制方式
  /// </summary>
  public enum EM_VIDEO_OUT_CTRL_TYPE
  {
    /// <summary>
    /// Logical channel number control mode,effective for physical screen and splicing screen 
    /// 逻辑通道号控制方式, 对物理屏和拼接屏都有效
    /// </summary>
    CHANNEL,
    /// <summary>
    /// Splice screen ID control mode, applies to splice screen only 
    /// 拼接屏ID控制方式, 只对拼接屏有效
    /// </summary>
    COMPOSITE_ID,
  }

  /// <summary>
  /// Set the return result of video source  
  /// 设置视频源的返回结果
  /// </summary>
  public struct NET_SET_SPLIT_SOURCE_RESULT
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Monitor Port Number of Push Flow Pattern Equipment
    /// 推流模式的设备端监听端口号
    /// </summary>
    public int nPushPort;
  }

  /// <summary>
  /// SetSplitSourceEx output parameters of the interface 
  /// SetSplitSourceEx 接口的输出参数
  /// </summary>
  public struct NET_OUT_SET_SPLIT_SOURCE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// pointer to NET_SET_SPLIT_SOURCE_RESULT. returned value after successful setting , corresponding the window array in NET_IN_SET_SPLIT_SOURCE, user allocates memory , apply to sizeof(NET_SET_SPLIT_SOURCE_RESULT)*nMaxResultCount,If don't need can be NULL 
    /// 设置成功后的返回值, 对应NET_IN_SET_SPLIT_SOURCE中的窗口数组, 用户分配内存,大小为sizeof(NET_SET_SPLIT_SOURCE_RESULT)*nMaxResultCount, 如果不需要可以为NULL
    /// </summary>
    public IntPtr pstuResults;
    /// <summary>
    /// The size of the pstuResults array
    /// pstuResults数组的大小
    /// </summary>
    public int nMaxResultCount;
    /// <summary>
    /// The Number Of Return
    /// 返回的数量
    /// </summary>
    public int nRetCount;
  }
  #endregion

  /// <summary>
  /// event type EVENT_IVS_TRAFFIC_PEDESTRAINPRIORITY corresponding data block description info
  /// 斑马线行人优先事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_PEDESTRAINPRIORITY_INFO
  {
    /// <summary>
    /// Channel No.
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// Event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// Vehicle body info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Corresponding lane No.
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// Event initial UTC time 	UTC is the second of the event UTC (1970-1-1 00:00:00)
    /// 事件初始UTC时间    UTC为事件的UTC (1970-1-1 00:00:00)秒数
    /// </summary>
    public double dInitialUTC;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// reserved
    /// 保留字段，对齐用
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// Snap flag(by bit),please refer to NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// The record of the database of the traffic vehicle
    /// 表示交通车辆的数据库记录
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info
    /// GPS信息
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved field for future extension
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 984)]
    public byte[] bReserved;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_TRAFFICSNAPSHOT's data
  /// 事件类型EVENT_TRAFFICSNAPSHOT(交通抓拍事件)对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFICSNAPSHOT_INFO
  {
    /// <summary>
    /// ChannelId
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserv;
    /// <summary>
    /// car way number being snapshotting
    /// 触发抓拍的车道个数
    /// </summary>
    public byte bCarWayCount;
    /// <summary>
    /// car way info being snapshotting
    /// 触发抓拍的车道相关信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public NET_CARWAY_INFO[] stuCarWayInfo;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end;
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// Reserved
    /// 保留字节,留待扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 344)]
    public byte[] bReserved;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// car way info
  /// 每个车道的相关信息
  /// </summary>
  public struct NET_CARWAY_INFO
  {
    /// <summary>
    /// current car way id 
    /// 当前车道号
    /// </summary>
    public byte bCarWayID;
    /// <summary>
    /// reserved
    /// 保留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserve;
    /// <summary>
    /// being snapshotted
    /// 被触发抓拍的个数
    /// </summary>
    public byte bSigCount;
    /// <summary>
    /// the snapshot info
    /// 当前车道上,被触发抓拍对应的抓拍信息 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public NET_SIG_CARWAY_INFO[] stuSigInfo;
    /// <summary>
    /// reserved
    /// 保留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
    public byte[] bReserved;
  }

  /// <summary>
  /// snapshot info
  /// 抓拍信息
  /// </summary>
  public struct NET_SIG_CARWAY_INFO
  {
    /// <summary>
    /// current car speed,km/h
    /// 当前车的速度,km/h
    /// </summary>
    public short snSpeed;
    /// <summary>
    /// current car length, dm
    /// 当前车长,分米为单位
    /// </summary>
    public short snCarLength;
    /// <summary>
    /// current red light time, s.ms
    /// 当前车道红灯时间,秒.毫秒
    /// </summary>
    public float fRedTime;
    /// <summary>
    /// current car way snapshot time, s.ms
    /// 当前车道抓拍时间,秒.毫秒
    /// </summary>
    public float fCapTime;
    /// <summary>
    /// current snapshot Sequence
    /// 当前抓拍序号
    /// </summary>
    public byte bSigSequence;
    /// <summary>
    /// current snapshot type,0: radar up speed limit;1: radar low speed limit;2: car detector up speed limit;3:car detector low speed limit;4: reverse;5: break red light;6: red light on;7: red light off;8: snapshot or traffic gate
    /// 当前车道的抓拍类型,0: 雷达高限速;1: 雷达低限速;2: 车检器高限速;3:车检器低限速,4: 逆向;5: 闯红灯;6: 红灯亮;7: 红灯灭;8: 全部抓拍或者卡口
    /// </summary>
    public byte bType;
    /// <summary>
    /// breaking type :01:left turn;02:straight;03:right
    /// 闯红灯类型:01:左转红灯;02:直行红灯;03:右转红灯
    /// </summary>
    public byte bDirection;
    /// <summary>
    /// current car way traffic light state,0: green, 1: red, 2: yellow
    /// 当前车道的红绿灯状态,0: 绿灯, 1: 红灯, 2: 黄灯
    /// </summary>
    public byte bLightColor;
    /// <summary>
    /// snap flag from device
    /// 设备产生的抓拍标识
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] bSnapFlag;
  }

  /// <summary>
  /// open strobe information
  /// 打开道闸信息
  /// </summary>
  public struct NET_CTRL_OPEN_STROBE
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel number
    /// 通道号
    /// </summary>
    public int nChannelId;
    /// <summary>
    /// plate number
    /// 车牌号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPlateNumber;
  }

  /// <summary>
  /// close gateway parameter
  /// 关闸参数
  /// </summary>
  public struct NET_CTRL_CLOSE_STROBE
  {
    public uint dwSize;
    /// <summary>
    /// channel no.
    /// 通道号
    /// </summary>
    public int nChannelId;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_UTURN's data
  /// 违章调头事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_UTURN_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON 
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息 车载定制
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary> 
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 968)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// GPS Infomation
  /// GPS信息
  /// </summary>
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 4)]
  public struct NET_GPS_INFO
  {
    /// <summary>
    /// Longitude(unit:1/1000000 degree) west Longitude: 0 - 180000000  practical value = 180*1000000 - dwLongitude,east Longitude: 180000000 - 360000000    practical value = dwLongitude - 180*1000000. eg: Longitude:300168866  (300168866 - 180*1000000)/1000000  equal east Longitude 120.168866 degree
    /// 经度(单位是百万分之一度) 西经：0 - 180000000 实际值应为: 180*1000000 – dwLongitude,东经：180000000 - 360000000		实际值应为: dwLongitude – 180*1000000. 如: 300168866应为（300168866 - 180*1000000）/1000000 即东经120.168866度
    /// </summary>
    public uint nLongitude;
    /// <summary>
    /// Latidude(unit:1/1000000 degree)
    /// 纬度(单位是百万分之一度)
    /// </summary>
    public uint nLatidude;
    /// <summary>
    /// altitude,unit:m
    /// 高度,单位为米
    /// </summary>
    public double dbAltitude;
    /// <summary>
    /// Speed,unit:km/H
    /// 速度,单位km/H
    /// </summary>
    public double dbSpeed;
    /// <summary>
    /// Bearing,unit:°
    /// 方向角,单位:°
    /// </summary>
    public double dbBearing;
    /// <summary>
    /// Reserved bytes
    /// 保留字段 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bReserved;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_PARKING's data
  /// 交通违章停车事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_PARKING_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// event file info 
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved bytes
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] reserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// the time of starting parking
    /// 开始停车时间
    /// </summary>
    public NET_TIME_EX stuStartParkingTime;
    /// <summary>
    /// snap index: such as 3,2,1,1 means the last one,0 means there has some exception and snap stop(this param work when bEventAction=2) 
    /// 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束(bEventAction=2时此参数有效)
    /// </summary>
    public int nSequence;
    /// <summary>
    /// interval time of alarm(s) (this is a continuous event,if the interval time of recieving next event go beyond this param, we can judge that this event is over with exception)
    /// 报警时间间隔,单位:秒。(此事件为连续性事件,在收到第一个此事件之后,若在超过间隔时间后未收到此事件的后续事件,则认为此事件异常结束了)
    /// </summary>
    public int nAlarmIntervalTime;
    /// <summary>
    /// the time of legal parking
    /// 允许停车时长,单位：秒
    /// </summary>
    public int nParkingAllowedTime;
    /// <summary>
    /// detect region point number
    /// 规则检测区域顶点数
    /// </summary>
    public int nDetectRegionNum;
    /// <summary>
    /// detect region point number
    /// 规则检测区域
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_POINT[] DetectRegion;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// true:corresponding alarm recording; false: no corresponding alarm recording
    /// true:有对应的报警录像; false:无对应的报警录像
    /// </summary>
    public bool bIsExistAlarmRecord;
    /// <summary>
    /// Video size
    /// 录像大小
    /// </summary>
    public uint dwAlarmRecordSize;
    /// <summary>
    /// Video Path
    /// 录像路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szAlarmRecordPath;
    /// <summary>
    /// FTP path
    /// FTP路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] szFTPPath;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// weather is PreAlarm event,0 :traffic parking event,1 :preAlarm event
    /// 是否为违章预警图片,0 违章停车事件1 预警事件(预警触发后一定时间，车辆还没有离开，才判定为违章)由于此字段会导致事件含义改变，必须和在平台识别预警事件后，才能有此字段, 
    /// </summary>
    public byte byPreAlarm;
    /// <summary>
    /// Reserved
    /// 保留字节,留待扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] bReserved2;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息 车载定制
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 228)]
    public byte[] bReserved;
    /// <summary>
    /// Traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_CROSSLANE's data
  /// 交通违章-违章变道对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_CROSSLANE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// event file info 
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息 车载定制
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 836)]
    public byte[] bReserved;
    /// <summary>
    /// traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stuTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_YELLOWPLATEINLANE's data
  /// 交通违章-黄牌车占道事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_YELLOWPLATEINLANE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// event file info 
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// speed,km/h
    /// 车辆实际速度,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1016)]
    public byte[] bReserved;
    /// <summary>
    /// traffic vehicle info
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stuTrafficCar;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_VEHICLEINROUTE's data
  /// 有车占道事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_VEHICLEINROUTE_INFO
  {
    /// <summary>
    /// channel id
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// PTS(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// the event happen time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// vehicle info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Corresponding Lane number
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// snap index
    /// 抓拍序号
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed
    /// 车速
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// TrafficCar info
    /// 表示交通车辆的数据库记录
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// event file info
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Event action,0 means pulse event,1 means continuous event's begin,2means continuous event's end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved0;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// flag(by bit),see NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// intelli comm info
    /// 智能事件公共信息
    /// </summary>
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 884)]
    public byte[] byReserved;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_VEHICLEINBUSROUTE's data
  /// 占用公交车道事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_VEHICLEINBUSROUTE_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// Event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// Vehicle body info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Corresponding lane No
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// snap index
    /// 抓拍序号
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed km/h
    /// 车速,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// Snap flag(by bit),please refer to NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// The record of the database of the traffic vehicle 
    /// 表示交通车辆的数据库记录
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>
    /// picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息 车载定制
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 980)]
    public byte[] bReserved;
    /// <summary>
    /// public info
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_BACKING's data
  /// 违章倒车事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_IVS_TRAFFIC_BACKING_INFO
  {
    /// <summary>
    /// channel ID
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// byte alignment
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp(ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// Event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// Vehicle body info
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Corresponding lane No.
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// snap index
    /// 抓拍序号
    /// </summary>
    public int nSequence;
    /// <summary>
    /// speed km/h
    /// 车速,km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// Event operation.0=pulse event,1=begin of the durative event,2=end of the durative event
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte bEventAction;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// Snap flag(by bit),please refer to NET_RESERVED_COMMON
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>                                                              
    /// The record of the database of the traffic vehicle                                                                    
    /// 表示交通车辆的数据库记录                                               
    /// </summary>                                                             
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stTrafficCar;
    /// <summary>                                                              
    /// picture resolution                                                                       
    /// 对应图片的分辨率                                                       
    /// </summary>                                                             
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>                                                              
    /// intelli comm info                                                                       
    /// 智能事件公共信息                                                       
    /// </summary>                                                             
    public NET_EVENT_INTELLI_COMM_INFO stuIntelliCommInfo;
    /// <summary>                                                              
    /// GPS info ,use in mobile DVR/NVR                                                                       
    /// GPS信息 车载定制                                                       
    /// </summary>                                                             
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>                                                              
    /// reserved                                                                       
    /// 保留字节                                                               
    /// </summary>                                                             
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 848)]
    public byte[] bReserved;
    /// <summary>                                                              
    /// public info                                                                       
    /// 公共信息                                                               
    /// </summary>                                                             
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// the describe of EVENT_IVS_TRAFFIC_WITHOUT_SAFEBELT's data
  /// 未系安全带事件事件对应的数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_TRAFFIC_WITHOUT_SAFEBELT
  {
    /// <summary>
    /// channel no.
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// event name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;
    /// <summary>
    /// TriggerType:trigger type , 0 vehicle detector, 1 radar, 2 video
    /// TriggerType:触发类型,0车检器,1雷达,2视频
    /// </summary>
    public int nTriggerType;
    /// <summary>
    /// time stamp(unit is ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public uint PTS;
    /// <summary>
    /// event occurred time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// means snaoshot no.
    /// 表示抓拍序号
    /// </summary>
    public int nSequence;
    /// <summary>
    /// event  motion , 0 means pulse event ,1 means  continuity  event  start ,2 means  continuity  event end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public byte byEventAction;
    /// <summary>
    /// picture no., same time(accurate to second)may have multiple pictures , start from 0 
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved1;
    /// <summary>
    /// event corresponding to file info 
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// corresponding to lane no.
    /// 对应车道号
    /// </summary>
    public int nLane;
    /// <summary>
    /// bottom generated trigger snapshot frame mark
    /// 底层产生的触发抓拍帧标记
    /// </summary>
    public int nMark;
    /// <summary>
    /// video analysis frame no.
    /// 视频分析帧序号
    /// </summary>
    public int nFrameSequence;
    /// <summary>
    /// video analysis data source address
    /// 视频分析的数据源地址
    /// </summary>
    public int nSource;
    /// <summary>
    /// detection object 
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// body info 
    /// 车身信息
    /// </summary>
    public NET_MSG_OBJECT stuVehicle;
    /// <summary>
    /// Traffic vehicle info 
    /// 交通车辆信息
    /// </summary>
    public NET_DEV_EVENT_TRAFFIC_TRAFFICCAR_INFO stuTrafficCar;
    /// <summary>
    /// vehicle actual speed,Km/h
    /// 车辆实际速度,Km/h
    /// </summary>
    public int nSpeed;
    /// <summary>
    /// main driver seat belt status 
    /// 主驾驶座位安全带状态
    /// </summary>
    public EM_SAFEBELT_STATE emMainSeat;
    /// <summary>
    /// co-drvier seat belt status
    /// 副驾驶座位安全带状态
    /// </summary>
    public EM_SAFEBELT_STATE emSlaveSeat;
    /// <summary>
    /// snapshot mark(by bit), see NET_RESERVED_COMMON  
    /// 抓图标志(按位),具体见NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// corresponding to picture resolution
    /// 对应图片的分辨率
    /// </summary>
    public NET_RESOLUTION_INFO stuResolution;
    /// <summary>
    /// GPS info ,use in mobile DVR/NVR
    /// GPS信息 车载定制
    /// </summary>
    public NET_GPS_INFO stuGPSInfo;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 984)]
    public byte[] byReserved;
    /// <summary>
    /// public info 
    /// 公共信息
    /// </summary>
    public NET_EVENT_COMM_INFO stCommInfo;
  }

  /// <summary>
  /// 设置停车信息,对应DH_CTRL_SET_PARK_INFO命令参数
  /// Set park info, corresponding DH_CTRL_SET_PARK_INFO command parameter
  /// </summary>
  public struct NET_CTRL_SET_PARK_INFO
  {
    public uint dwSize;
    /// <summary>
    /// Plate number
    /// 车牌号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPlateNumber;
    /// <summary>
    /// park time,Unit:minute
    /// 停车时长,单位:分钟
    /// </summary>
    public uint nParkTime;
    /// <summary>
    /// Master of car
    /// 车主姓名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szMasterofCar;
    /// <summary>
    /// User type,not general,Used in entrance capture machine
    /// monthlyCardUser means monthly card user,yearlyCardUser means yearly card user,longTimeUser means long time user/VIP,casualUser means casual user/Visitor
    /// 用户类型,非通用,用于出入口抓拍一体机
    /// monthlyCardUser表示月卡用户,yearlyCardUser表示年卡用户,longTimeUser表示长期用户/VIP,casualUser表示临时用户/Visitor
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserType;
    /// <summary>
    /// Remain day
    /// 到期天数
    /// </summary>
    public uint nRemainDay;
    /// <summary>
    /// Park charge
    /// 停车费
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szParkCharge;
    /// <summary>
    /// Remain space
    /// 停车库余位数
    /// </summary>
    public uint nRemainSpace;
    /// <summary>
    /// 0:car is not allowed to pass,1:car is allowed to pass
    /// 0:不允许车辆通过 1:允许车辆通过
    /// </summary>
    public uint nPassEnable;
    /// <summary>
    /// car in time
    /// 车辆入场时间
    /// </summary>
    public NET_TIME stuInTime;
    /// <summary>
    /// car out time
    /// 车辆出场时间
    /// </summary>
    public NET_TIME stuOutTime;
    /// <summary>
    /// car pass status
    /// 过车状态
    /// </summary>
    public EM_CARPASS_STATUS emCarStatus;
    /// <summary>
    /// custom field,default:null
    /// 自定义显示字段，默认空 
    /// </summary>							
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szCustom;
    /// <summary>
    /// Sub user type of szUserType
    /// 用户类型（szUserType字段）的子类型 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szSubUserType;
    /// <summary>
    /// Remarks info
    /// 备注信息  
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szRemarks;
  }

  /// <summary>
  /// car pass status
  /// 过车状态
  /// </summary>
  public enum EM_CARPASS_STATUS
  {
    /// <summary>
    /// Unknown status
    /// 未知状态
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// car pass status
    /// 过车状态
    /// </summary>
    CARPASS,
    /// <summary>
    /// no car status
    /// 无车状态
    /// </summary>
    NORMAL,
  }
  #region <<Face Module 2>>
  /// <summary>
  /// OperateFaceRecognitionDB interface input parameters
  /// OperateFaceRecognitionDB接口输入参数
  /// </summary>
  public struct NET_IN_OPERATE_FACERECONGNITIONDB
  {
    public uint dwSize;
    /// <summary>
    /// Type of operation
    /// 操作类型
    /// </summary>
    public EM_OPERATE_FACERECONGNITIONDB_TYPE emOperateType;
    /// <summary>
    /// Personal information
    /// 人员信息
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFO stPersonInfo;
    /// <summary>
    /// UID amount(be used when emOperateType is DELETE_BY_UID, stPeronInfo is invalid)
    /// UID个数(emOperateType操作类型为DELETE_BY_UID时使用,stPeronInfo字段无效)
    /// </summary>
    public uint nUIDNum;
    /// <summary>
    /// Person unique mark. Generated by the server at first. Different from the ID. Alloc by user, sizeof(NET_UID_CHAR)*nUIDNum
    /// 人员唯一标识符,首次由服务端生成,区别于ID字段;由用户申请内存,大小为sizeof(NET_UID_CHAR)*nUIDNum
    /// </summary>
    public IntPtr stuUIDs;
    /// <summary>
    /// Buffer address(Picture binary data)
    /// 缓冲地址(图片二进制数据)
    /// </summary>
    public IntPtr pBuffer;
    /// <summary>
    /// 缓冲数据长度
    /// </summary>
    public int nBufferLen;
    /// <summary>
    /// use stPersonInfoEx when bUsePersonInfoEx is true, otherwise use stPersonInfo
    /// 使用人员扩展信息
    /// </summary>
    public bool bUsePersonInfoEx;
    /// <summary>
    /// expansion of person information
    /// 人员信息扩展
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFOEX stPersonInfoEx;
  }

  /// <summary>
  /// Face recognition database operations
  /// 人脸识别数据库操作
  /// </summary>
  public enum EM_OPERATE_FACERECONGNITIONDB_TYPE
  {
    UNKOWN,
    /// <summary>
    /// Add personnel information and face samples, if researchers already exists, image data and the original data
    /// 添加人员信息和人脸样本,如果人员已经存在,图片数据和原来的数据合并
    /// </summary>
    ADD,
    /// <summary>
    /// Delete the personnel information and face samples
    /// 删除人员信息和人脸样本
    /// </summary>
    DELETE,
    /// <summary>
    /// Modify person info and human face sample, must input person UID
    /// 修改人员信息和人脸样本,人员的UID标识必填
    /// </summary>
    MODIFY,
    /// <summary>
    /// Delete person info and human face via UID
    /// 通过UID删除人员信息和人脸样本
    /// </summary>
    DELETE_BY_UID,
  }

  public struct NET_UID_CHAR
  {
    /// <summary>
    /// UID contents
    /// UID内容
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUID;
  }

  /// <summary>
  /// OperateFaceRecognitionDB interface output parameter
  /// OperateFaceRecognitionDB接口输出参数
  /// </summary>
  public struct NET_OUT_OPERATE_FACERECONGNITIONDB
  {
    public UInt32 dwSize;
    /// <summary>
    /// 人员唯一标识符, 只有在操作类型为NET_FACERECONGNITIONDB_ADD时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUID;
  }

  /// <summary>
  /// DetectFace interface input parameters
  /// DetectFace接口输入参数
  /// </summary>
  public struct NET_IN_DETECT_FACE
  {
    public uint dwSize;
    /// <summary>
    /// Big picture information
    /// 大图信息
    /// </summary>
    public NET_PIC_INFO stPicInfo;
    /// <summary>
    /// Buffer address(Picture binary data)
    /// 缓冲地址(图片二进制数据)
    /// </summary>
    public IntPtr pBuffer;
    /// <summary>
    /// Buffer data length
    /// 缓冲数据长度
    /// </summary>
    public int nBufferLen;
  }

  /// <summary>
  /// DetectFace interface output parameter
  /// DetectFace接口输出参数
  /// </summary>
  public struct NET_OUT_DETECT_FACE
  {
    public uint dwSize;
    /// <summary>
    /// The detected face image information. Alloc by user, sizeof(NET_PIC_INFO)*nMaxPicNum
    /// 检测出的人脸图片信息,由用户申请空间, sizeof(NET_PIC_INFO)*nMaxPicNum
    /// </summary>
    public IntPtr pPicInfo;
    /// <summary>
    /// The maximum number of face image information
    /// 最大人脸图片信息个数
    /// </summary>
    public int nMaxPicNum;
    /// <summary>
    /// The actual number of returned faces pictures
    /// 实际返回的人脸图片个数
    /// </summary>
    public int nRetPicNum;
    /// <summary>
    /// Buffer address. Alloc by user(Picture binary data)
    /// 缓冲地址,由用户申请空间,存放检测出的人脸图片数据(图片二进制数据)
    /// </summary>
    public IntPtr pBuffer;
    /// <summary>
    /// nBufferLen
    /// 缓冲数据长度
    /// </summary>
    public int nBufferLen;
  }

  /// <summary>
  /// NET_FILE_QUERY_FACE Corresponding face recognition service search parameter
  /// 对应的人脸识别服务查询参数
  /// </summary>
  public struct NET_MEDIAFILE_FACERECOGNITION_PARAM
  {
    public UInt32 dwSize;
    // Search filter criteria
    // 查询过滤条件
    /// <summary>
    /// start time 
    /// 开始时间
    /// </summary>
    public NET_TIME stStartTime;
    /// <summary>
    /// closing time
    /// 结束时间
    /// </summary>
    public NET_TIME stEndTime;
    /// <summary>
    /// Place to support fuzzy matching
    /// 地点,支持模糊匹配
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
    public byte[] szMachineAddress;
    /// <summary>
    /// To query the type of alarm, see EM_FACERECOGNITION_ALARM_TYPE
    /// 待查询报警类型,详见 EM_FACERECOGNITION_ALARM_TYPE
    /// </summary>
    public int nAlarmType;
    /// <summary>
    /// staff info is valid or not
    /// 人员信息是否有效
    /// </summary>
    public int abPersonInfo;
    /// <summary>
    /// staff info
    /// 人员信息
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFO stPersonInfo;
    /// <summary>
    /// channel no.  
    /// 通道号
    /// </summary>
    public int nChannelId;
    /// <summary>
    /// staff group
    /// 人员组数 
    /// </summary>
    public int nGroupIdNum;
    /// <summary>
    /// staff group ID
    /// 人员组ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128 * 64)]
    public byte[] szGroupId;
    /// <summary>
    /// stPersonInfoEx is valid or not
    /// 人员信息扩展是否有效
    /// </summary>
    public bool abPersonInfoEx;
    /// <summary>
    /// expansion of person information
    /// 人员信息扩展
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFOEX stPersonInfoEx;
    public bool bSimilaryRangeEnable;           //相似度是否有效
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public int[] nSimilaryRange;              //相似度范围
  }

  /// <summary>
  /// Face recognition event type
  /// 人脸识别事件类型
  /// </summary>
  public enum EM_FACERECOGNITION_ALARM_TYPE
  {
    UNKOWN,
    /// <summary>
    /// blacklist and whitelist
    /// 黑白名单
    /// </summary>
    ALL,
    /// <summary>
    /// The blacklist
    /// 黑名单
    /// </summary>
    BLACKLIST,
    /// <summary>
    /// The whitelist
    /// 白名单
    /// </summary>
    WHITELIST,
  }

  /// <summary>
  /// media file query condition
  /// media文件查询条件
  /// </summary>
  public enum EM_FILE_QUERY_TYPE
  {
    /// <summary>
    /// Vehicle information,corresponding structure is NET_MEDIA_QUERY_TRAFFICCAR_PARAM
    /// 交通车辆信息,对应结构体为NET_MEDIA_QUERY_TRAFFICCAR_PARAM
    /// </summary>
    TRAFFICCAR,
    /// <summary>
    /// ATM information
    /// ATM信息
    /// </summary>
    ATM,
    /// <summary>
    /// ATM transaction information
    /// ATM交易信息 
    /// </summary>
    ATMTXN,
    /// <summary>
    /// Face info, corresponding to NET_MEDIAFILE_FACERECOGNITION_PARAM, NET_MEDIAFILE_FACERECOGNITION_INFO
    /// 人脸信息 NET_MEDIAFILE_FACERECOGNITION_PARAM 和 NET_MEDIAFILE_FACERECOGNITION_INFO
    /// </summary>
    FACE,                                 //   
    /// <summary>
    /// file info, corresponding to NET_IN_MEDIA_QUERY_FILE and NET_OUT_MEDIAFILE_FILE
    /// 文件信息对应 NET_IN_MEDIA_QUERY_FILE 和 NET_OUT_MEDIA_QUERY_FILE
    /// </summary>
    FILE,                                 // 
    /// <summary>
    /// Transportation vehicle information, expand TRAFFICCAR, support more fields,corresponding structure is NET_MEDIA_QUERY_TRAFFICCAR_PARAM_EX
    /// 交通车辆信息, 扩展TRAFFICCAR, 支持更多的字段，对应结构体为NET_MEDIA_QUERY_TRAFFICCAR_PARAM_EX
    /// </summary>
    TRAFFICCAR_EX,                        // 
    /// <summary>
    /// face recognition event info NET_MEDIAFILE_FACE_DETECTION_PARAM and NET_MEDIAFILE_FACE_DETECTION_INFO
    /// 人脸检测事件信息 NET_MEDIAFILE_FACE_DETECTION_PARAM 和 NET_MEDIAFILE_FACE_DETECTION_INFO
    /// </summary>
    FACE_DETECTION,                       //  
    /// <summary>
    /// ivs event info, corresponding to NET_MEDIAFILE_IVS_EVENT_PARAM, NET_MEDIAFILE_IVS_EVENT_INFO
    /// 智能事件信息 NET_MEDIAFILE_IVS_EVENT_PARAM 和 NET_MEDIAFILE_IVS_EVENT_INFO
    /// </summary>
    IVS_EVENT,                            // 
    /// <summary>
    /// analyse object info, corresponding to NET_MEDIAFILE_ANALYSE_OBJECT_PARAM, NET_MEDIAFILE_ANALYSE_OBJECT_INFO
    /// 智能分析其他物体(人和车除外) NET_MEDIAFILE_ANALYSE_OBJECT_PARAM 和 NET_MEDIAFILE_ANALYSE_OBJECT_INFO
    /// </summary>
    ANALYSE_OBJECT,                       // 
    /// <summary>
    /// query mpt record file,corresponding to NET_MEDIAFILE_MPT_RECORD_FILE_PARAM and NET_MEDIAFILE_MPT_RECORD_FILE_INFO
    /// MPT设备的录像文件 NET_MEDIAFILE_MPT_RECORD_FILE_PARAM 和 NET_MEDIAFILE_MPT_RECORD_FILE_INFO
    /// </summary>
    MPT_RECORD_FILE,                      //    
  }

  /// <summary>
  /// type of glassess
  /// 眼镜类型
  /// </summary>
  public enum EM_GLASSES_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// sun glasses
    /// 太阳眼镜
    /// </summary>
    SUNGLASS,
    /// <summary>
    /// normal galsses
    /// 普通眼镜
    /// </summary>
    GLASS,
  }

  /// <summary>
  /// expansion of  personnel information
  /// 人员信息扩展结构体
  /// </summary>
  public struct NET_FACERECOGNITION_PERSON_INFOEX
  {
    /// <summary>
    /// person name
    /// 姓名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPersonName;
    /// <summary>
    /// birth year, fill 0 is invalid, when is as a query condition
    /// 出生年,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public ushort wYear;
    /// <summary>
    /// birth month, fill 0 is invalid, when is as a query condition
    /// 出生月,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte byMonth;
    /// <summary>
    /// birth day, fill 0 is invalid, when is as a query condition
    /// 出生日,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte byDay;

    /// <summary>
    /// sex, 0-man, 1-female. fill 0 is invalid, when is as a query condition
    /// 人员重要等级,1~10,数值越高越重要,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte bImportantRank;
    /// <summary>
    /// the unicle ID for the person
    /// 性别,1-男,2-女,作为查询条件时,此参数填0,则表示此参数无效
    /// </summary>
    public byte bySex;                                    /// <summary>
                                                          /// importance level,1~10,the higher value the higher level. fill 0 is invalid, when is as a query condition
                                                          /// 人员唯一标示(身份证号码,工号,或其他编号)
                                                          /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szID;
    /// <summary>
    /// picture number
    /// 图片张数
    /// </summary>
    public ushort wFacePicNum;
    /// <summary>
    /// picture info
    /// 当前人员对应的图片信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public NET_PIC_INFO[] szFacePicInfo;
    /// <summary>
    /// Personnel types, see EM_PERSON_TYPE
    /// 人员类型,详见 EM_PERSON_TYPE
    /// </summary>
    public byte byType;
    /// <summary>
    /// Document types, see EM_CERTIFICATE_TYPE
    /// 证件类型,详见 EM_CERTIFICATE_TYPE
    /// </summary>
    public byte byIDType;
    /// <summary>
    /// Whether wear glasses or not,0-unknown,1-not wear glasses,2-wear glasses	
    /// 是否戴眼镜，0-未知 1-不戴 2-戴
    /// </summary>
    public byte byGlasses;
    /// <summary>
    /// Age,0 means unknown
    /// 年龄,0表示未知 
    /// </summary>	
    public byte byAge;
    /// <summary>
    /// province
    /// 省份
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szProvince;
    /// <summary>
    /// city
    /// 城市
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCity;
    /// <summary>
    /// person unique ID
    /// 人员唯一标识符,首次由服务端生成,区别于ID字段,修改,删除操作时必填
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUID;
    /// <summary>
    /// country
    ///  国籍,符合ISO3166规范
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 3)]
    public string szCountry;
    /// <summary>
    /// using person type: 0 using byType, 1 using CustomType
    /// 人员类型是否为自定义: 0 使用Type规定的类型 1 自定义,使用szPersonName字段
    /// </summary>
    public byte byIsCustomType;
    /// <summary>
    /// custom type of person	
    /// 人员自定义类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szCustomType;
    /// <summary>
    /// comment info
    /// 备注信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 100)]
    public string szComment;
    /// <summary>
    /// group ID
    /// 人员所属组ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupID;
    /// <summary>
    /// group name
    /// 人员所属组名, 用户自己申请内存的情况时
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szGroupName;
    /// <summary>
    /// Emotion
    /// 表情
    /// </summary>
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE emEmotion;
    /// <summary>
    ///  home address of the person
    /// 注册人员家庭地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szHomeAddress;
    /// <summary>
    /// glasses type
    /// 眼镜类型
    /// </summary>
    public EM_GLASSES_TYPE emGlassesType;
    /// <summary>
    /// race
    /// 种族
    /// </summary>
    public EM_RACE_TYPE emRace;
    /// <summary>
    /// eye state
    /// 眼睛状态
    /// </summary>
    public EM_EYE_STATE_TYPE emEye;
    /// <summary>
    /// mouth state
    /// 嘴巴状态
    /// </summary>
    public EM_MOUTH_STATE_TYPE emMouth;
    /// <summary>
    /// mask state
    /// 口罩状态
    /// </summary>
    public EM_MASK_STATE_TYPE emMask;
    /// <summary>
    /// beard state
    /// 胡子状态
    /// </summary>
    public EM_BEARD_STATE_TYPE emBeard;
    /// <summary>
    /// attractive, -1:invalid, 0:unknown，1-100
    /// 魅力值, -1表示无效, 0未识别，识别时范围1-100,得分高魅力高
    /// </summary>
    public int nAttractive;
    /// <summary>
    /// Reserved bytes
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2048)]
    public byte[] byReserved;
  }

  /// <summary>
  /// face find state call back's info, lAttachHandle is CLIENT_AttachFaceFindState's return value
  /// 人脸查询状态信息回调函数, lAttachHandle是CLIENT_AttachFaceFindState的返回值
  /// </summary>
  public struct NET_CB_FACE_FIND_STATE
  {
    public UInt32 dwSize;
    /// <summary>
    /// Video synopsis task database main key ID 
    /// 视频浓缩任务数据库主键ID
    /// </summary>
    public Int32 nToken;
    /// <summary>
    /// Normal value: 0-100. 1=Searched token does not exist (When subscribe a search that does not exist or already finished)
    /// 正常取值范围：0-100,-1,表示查询token不存在(当订阅一个不存在或结束的查询时)
    /// </summary>
    public Int32 nProgress;
    /// <summary>
    /// The human face amount that match current criteria
    /// 目前符合查询条件的人脸数量
    /// </summary>
    public Int32 nCurrentCount;
  }

  /// <summary>
  ///  AttachFaceFindState interface in parameter 
  ///  AttachFaceFindState接口输入参数
  /// </summary>
  public struct NET_IN_FACE_FIND_STATE
  {
    /// <summary>
    /// Structure size. Must fill in.
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// Search token count. 0=subscribe all searched tasks.
    /// 查询令牌数,为0时,表示订阅所有的查询任务
    /// </summary>
    public Int32 nTokenNum;
    /// <summary>
    /// Search toke,the space application by the user, apply to sizeof(int)*nTokenNum
    /// 查询令牌,由用户申请内存，大小为sizeof(int)*nTokenNum
    /// </summary>
    public IntPtr nTokens;
    /// <summary>
    /// CallBack function 
    /// 回调函数
    /// </summary>
    public fFaceFindStateCallBack cbFaceFindState;
    /// <summary>
    /// User data
    /// 用户数据
    /// </summary>
    public IntPtr dwUser;
  }

  /// <summary>
  /// AttachFaceFindState interface out parameter 
  /// AttachFaceFindState接口输出参数
  /// </summary>
  public struct NET_OUT_FACE_FIND_STATE
  {
    public UInt32 dwSize;
  }

  /// <summary>
  /// StartFindFaceRecognitionInterface input parameters
  /// StartFindFaceRecognition接口输入参数
  /// </summary>
  public struct NET_IN_STARTFIND_FACERECONGNITION
  {
    public UInt32 dwSize;
    /// <summary>
    /// is personal information valid
    /// 人员信息查询条件是否有效
    /// </summary>
    public bool bPersonEnable;
    /// <summary>
    /// personal information
    /// 人员信息查询条件
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFO stPerson;
    /// <summary>
    /// Face Matching Options
    /// 人脸匹配选项
    /// </summary>
    public NET_FACE_MATCH_OPTIONS stMatchOptions;
    /// <summary>
    /// Query filters
    /// 查询过滤条件
    /// </summary>
    public NET_FACE_FILTER_CONDTION stFilterInfo;
    /// <summary>
    /// Buffer address(Picture binary data)
    /// 缓冲地址(图像二进制数据)
    /// </summary>
    public IntPtr pBuffer;
    /// <summary>
    /// Buffer data length
    /// 缓冲数据长度
    /// </summary>
    public Int32 nBufferLen;
    /// <summary>
    /// Channel ID 
    /// 通道号
    /// </summary>
    public Int32 nChannelID;
    /// <summary>
    /// use stPersonInfoEx when bUsePersonInfoEx is true, otherwise use stPersonInfo
    /// 人员信息查询条件是否有效, 并使用扩展结构体
    /// </summary>
    public bool bPersonExEnable;
    /// <summary>
    /// expansion of person information
    /// 人员信息扩展
    /// </summary>
    public NET_FACERECOGNITION_PERSON_INFOEX stPersonInfoEx;
  }

  /// <summary>
  /// 人脸匹配选项
  /// face match options
  /// </summary>
  public struct NET_FACE_MATCH_OPTIONS
  {
    public UInt32 dwSize;
    /// <summary>
    /// Important level 1 to 10 staff, the higher the number the more important (check important level greater than or equal to this level of staff)
    /// 人员重要等级    1~10,数值越高越重要,(查询重要等级大于等于此等级的人员)
    /// </summary>
    public UInt32 nMatchImportant;
    /// <summary>
    /// Face comparison mode, see EM_FACE_COMPARE_MODE
    /// 人脸比对模式,详见EM_FACE_COMPARE_MODE
    /// </summary>
    public EM_FACE_COMPARE_MODE emMode;
    /// <summary>
    /// Face the number of regional
    /// 人脸区域个数
    /// </summary>
    public Int32 nAreaNum;
    /// <summary>
    /// Regional groupings of people face is NET_FACE_COMPARE_MODE_AREA effective when emMode
    /// 人脸区域组合,emMode为NET_FACE_COMPARE_MODE.AREA时有效
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public EM_FACE_AREA_TYPE[] szAreas;
    /// <summary>
    /// Recognition accuracy (ranging from 1 to 10, with the value increases, the detection accuracy is improved, the detection rate of decline. Minimum value of 1 indicates the detection speed priority, the maximum is 10, said detection accuracy preferred. Temporarily valid only for face detection)
    /// 识别精度(取值1~10,随着值增大,检测精度提高,检测速度下降。最小值为1 表示检测速度优先,最大值为10表示检测精度优先。 暂时只对人脸检测有效)
    /// </summary>
    public Int32 nAccuracy;
    /// <summary>
    /// Similarity (must be greater than the degree of acquaintance before the report; expressed as a percentage, from 1 to 100)
    /// 相似度(必须大于该相识度才报告;百分比表示,1~100)
    /// </summary>
    public Int32 nSimilarity;
    /// <summary>
    /// Reported the largest number of candidate (based on similarity to sort candidates to take the maximum number of similarity report)
    /// 报告的最大候选个数(根据相似度进行排序,取相似度最大的候选人数报告)
    /// </summary>
    public Int32 nMaxCandidate;
  }

  /// <summary>
  /// Face contrast pattern
  /// 人脸比对模式
  /// </summary>
  public enum EM_FACE_COMPARE_MODE
  {
    UNKOWN,
    /// <summary>
    /// normal
    /// 正常
    /// </summary>
    NORMAL,
    /// <summary>
    /// Specify the face region combination area
    /// 指定人脸区域组合区域
    /// </summary>
    AREA,
    /// <summary>
    /// Intelligent model, the algorithm according to the situation of facial regions automatically select combination
    /// 智能模式,算法根据人脸各个区域情况自动选取组合 
    /// </summary>
    AUTO,
  }

  /// <summary>
  /// Face region
  /// 人脸区域
  /// </summary>
  public enum EM_FACE_AREA_TYPE
  {
    UNKOWN,
    /// <summary>
    /// eyebrow
    /// 眉毛
    /// </summary>
    EYEBROW,
    /// <summary>
    /// eye
    /// 眼睛
    /// </summary>
    EYE,
    /// <summary>
    /// nose
    /// 鼻子
    /// </summary>
    NOSE,
    /// <summary>
    /// mouth
    /// 嘴巴
    /// </summary>
    MOUTH,
    /// <summary>
    /// face
    /// 脸颊
    /// </summary>
    CHEEK,
  }

  /// <summary>
  /// Query filters
  /// 查询过滤条件
  /// </summary>
  public struct NET_FACE_FILTER_CONDTION
  {
    public UInt32 dwSize;
    /// <summary>
    /// Start time
    /// 开始时间
    /// </summary>
    public NET_TIME stStartTime;
    /// <summary>
    /// End Time
    /// 结束时间
    /// </summary>
    public NET_TIME stEndTime;
    /// <summary>
    /// Place to support fuzzy matching
    /// 地点,支持模糊匹配 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szMachineAddress;
    /// <summary>
    /// The actual number of database
    /// 实际数据库个数
    /// </summary>
    public Int32 nRangeNum;
    /// <summary>
    /// To query the database type, see EM_FACE_DB_TYPE
    /// 待查询数据库类型,详见EM_FACE_DB_TYPE
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] szRange;
    /// <summary>
    /// Face to query types, see EM_FACERECOGNITION_FACE_TYPE
    /// 待查询人脸类型,详见 EM_FACERECOGNITION_FACE_TYPE
    /// </summary>
    public EM_FACERECOGNITION_FACE_TYPE emFaceType;
    /// <summary>
    /// staff group  
    /// 人员组数   
    /// </summary>
    public Int32 nGroupIdNum;
    /// <summary>
    /// staff group ID 
    /// 人员组ID 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public NET_FACE_FILTER_CONDTION_GROUPID[] szGroupId;
    /// <summary>
    /// start birthday time
    /// 生日起始时间
    /// </summary>
    public NET_TIME stBirthdayRangeStart;
    /// <summary>
    /// end birthday time
    /// 生日结束时间
    /// </summary>
    public NET_TIME stBirthdayRangeEnd;
    /// <summary>
    /// Age range, When byAge[0] is 0 and byAge[1] is 0, it means query all age
    /// 年龄区间，当byAge[0]=0与byAge[1]=0时，表示查询全年龄
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byAge;
    /// <summary>
    /// Reserved
    /// 保留字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    /// <summary>
    /// Emotion
    /// 表情条件
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public EM_DEV_EVENT_FACEDETECT_FEATURE_TYPE[] emEmotion;
    /// <summary>
    /// Emotion num
    /// 表情条件的个数
    /// </summary>
    public int nEmotionNum;
  }

  /// <summary>
  /// NET_FACE_FILTER_CONDTION.szGroupId temp variable
  /// NET_FACE_FILTER_CONDTION.szGroupId 临时变量
  /// </summary>
  public struct NET_FACE_FILTER_CONDTION_GROUPID
  {
    /// <summary>
    /// single GroupId
    /// 单个GroupId
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
  }

  /// <summary>
  /// Face recognition face type
  /// 人脸识别人脸类型
  /// </summary>
  public enum EM_FACERECOGNITION_FACE_TYPE
  {
    UNKOWN,
    /// <summary>
    /// All the faces 
    /// 所有人脸  
    /// </summary>
    ALL,
    /// <summary>
    /// recognition success
    /// 识别成功
    /// </summary>
    REC_SUCCESS,
    /// <summary>
    /// recognition fail
    /// 识别失败
    /// </summary>
    REC_FAIL,
  }

  /// <summary>
  /// StartFindFaceRecognition out param
  /// StartFindFaceRecognition接口输出参数
  /// </summary>
  public struct NET_OUT_STARTFIND_FACERECONGNITION
  {
    public UInt32 dwSize;
    /// <summary>
    /// Record number of returns that match the query criteria;-1 means device is querying,will get lately. use CLIENT_AttachFaceFindState to get status
    /// 返回的符合查询条件的记录个数;-1表示总条数未生成,要推迟获取;使用CLIENT_AttachFaceFindState接口获取状态
    /// </summary>
    public Int32 nTotalCount;
    /// <summary>
    /// Query handle
    /// 查询句柄
    /// </summary>
    public IntPtr lFindHandle;
    /// <summary>
    /// The search token received 
    /// 获取到的查询令牌
    /// </summary>
    public Int32 nToken;
  }

  /// <summary>
  /// face data type
  /// 人脸数据类型
  /// </summary>
  public enum EM_FACE_DB_TYPE
  {
    UNKOWN,
    /// <summary>
    /// History database, storage is to detect the human face information, usually does not contain face corresponding personnel information
    /// 历史数据库,存放的是检测出的人脸信息,一般没有包含人脸对应人员信息
    /// </summary>
    HISTORY,
    /// <summary>
    /// The blacklist database
    /// 黑名单数据库
    /// </summary>
    BLACKLIST,
    /// <summary>
    /// The whitelist database
    /// 白名单数据库,废弃
    /// </summary>
    WHITELIST,
    /// <summary>
    /// Alarm library
    /// 报警库
    /// </summary>
    ALARM,
  }

  /// <summary>
  /// DoFindFaceRecognition Interface input parameters
  /// DoFindFaceRecognition 接口输入参数
  /// </summary>
  public struct NET_IN_DOFIND_FACERECONGNITION
  {
    public UInt32 dwSize;
    /// <summary>
    /// Query handle
    /// 查询句柄
    /// </summary>
    public IntPtr lFindHandle;
    /// <summary>
    /// Queries starting serial number
    /// 查询起始序号
    /// </summary>
    public Int32 nBeginNum;
    /// <summary>
    /// The current number of records you want to search for
    /// 当前想查询的记录条数 
    /// </summary>
    public Int32 nCount;
    /// <summary>
    /// the format of the image returned in the query results
    /// 指定查询结果返回图片的格式
    /// </summary>
    public EM_NEEDED_PIC_RETURN_TYPE emDataType;
  }

  /// <summary>
  /// the format of the image returned in the query results
  /// 查询结果返回图片的格式
  /// </summary>
  public enum EM_NEEDED_PIC_RETURN_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知类型
    /// </summary>
    UNKOWN,
    /// <summary>
    /// http url
    /// 返回图片HTTP链接
    /// </summary>
    HTTP_URL,
    /// <summary>
    /// binary data
    /// 返回图片二进制数据
    /// </summary>
    BINARY_DATA,
    /// <summary>
    /// http url and binary data
    /// 返回二进制和HTTP链接
    /// </summary>
    HTTP_AND_BINARY,
  }

  /// <summary>
  /// DoFindFaceRecognition output param
  /// DoFindFaceRecognition接口输出参数
  /// </summary>
  public struct NET_OUT_DOFIND_FACERECONGNITION
  {
    public uint dwSize;
    /// <summary>
    /// The actual number of candidate information structure returned
    /// 实际返回的候选信息结构体个数
    /// </summary>
    public int nCadidateNum;
    /// <summary>
    /// An array of candidate information
    /// 候选信息数组
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CANDIDATE_INFO[] stCadidateInfo;

    /// <summary>
    /// Buffer address(Picture binary data)
    /// 缓冲地址(图片二进制数据)
    /// </summary>
    public IntPtr pBuffer;
    /// <summary>
    /// Buffer data length
    /// 缓冲数据长度
    /// </summary>
    public int nBufferLen;
    /// <summary>
    /// whether or not to use stuCandidatesEx
    /// 是否使用候选对象扩展结构体,若为TRUE, 则表示使用stuCandidatesEx, 且stuCandidates无效, 否则相反
    /// </summary>
    public bool bUseCandidatesEx;
    /// <summary>
    /// the actual return number of stuCandidatesEx
    /// 实际返回的候选信息结构体个数
    /// </summary>
    public int nCadidateExNum;
    /// <summary>
    /// the expansion of candidate information
    /// 当前人脸匹配到的候选对象信息, 实际返回个数同nCandidateNum
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFOEX[] stuCandidatesEx;
  }

  /// <summary>
  /// corresponding facial recognition service  EM_FILE_QUERY_TYPE.FACE FINDNEXT search returned parameter
  /// EM_FILE_QUERY_TYPE.FACE对应的人脸识别服务FINDNEXT查询返回参数
  /// </summary>
  public struct NET_MEDIAFILE_FACERECOGNITION_INFO
  {
    /// <summary>
    /// Structure size
    /// 结构体大小
    /// </summary>
    public UInt32 dwSize;
    /// <summary>
    /// The existence panorama
    /// 全景图是否存在
    /// </summary>
    public int bGlobalScenePic;
    /// <summary>
    /// Panoramic image file path
    /// 全景图片文件路径
    /// </summary>
    public NET_PIC_INFO_EX stGlobalScenePic;
    /// <summary>
    /// the target face object information
    /// 目标人脸物体信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// the target face file path
    /// 目标人脸文件路径
    /// </summary>
    public NET_PIC_INFO_EX stObjectPic;
    /// <summary>
    /// Face Matching the current number of candidates
    /// 当前人脸匹配到的候选对象数量
    /// </summary>
    public int nCandidateNum;
    /// <summary>
    /// Face candidates to match this informatio
    /// 当前人脸匹配到的候选对象信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFO[] stuCandidates;
    /// <summary>
    /// The current face matching candidates to the image file path
    /// 当前人脸匹配到的候选对象图片文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDAT_PIC_PATHS[] stuCandidatesPic;
    /// <summary>
    /// time for an alarm
    /// 报警发生时间 
    /// </summary>
    public NET_TIME stTime;
    /// <summary>
    /// Place for an alarm
    /// 报警发生地点
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAddress;
    /// <summary>
    /// channel no.
    /// 通道号
    /// </summary>
    public int nChannelId;
    /// <summary>
    /// whether or not to use stuCandidatesEx
    /// 是否使用候选对象扩展结构体,若为TRUE, 则表示使用stuCandidatesEx, 且stuCandidates无效, 否则相反
    /// </summary>
    public bool bUseCandidatesEx;
    /// <summary>
    /// the actual return number of stuCandidatesEx
    /// 当前人脸匹配到的候选对象(扩展结构体) 数量
    /// </summary>
    public int nCandidateExNum;
    /// <summary>
    /// the expansion of candidate information
    /// 当前人脸匹配到的候选对象信息, 实际返回个数同nCandidateNum
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFOEX[] stuCandidatesE;
  }

  /// <summary>
  /// file information
  /// 文件信息 
  /// </summary>
  public struct NET_PIC_INFO_EX
  {
    public uint dwSize;
    /// <summary>
    /// file size,unit:bite
    /// 文件大小, 单位:字节
    /// </summary>
    public uint dwFileLenth;
    /// <summary>
    /// file path
    /// 文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szFilePath;
  }

  /// <summary>
  /// candidate's path
  /// 候选对象图片文件路径
  /// </summary>
  public struct NET_CANDIDAT_PIC_PATHS
  {
    public uint dwSize;
    /// <summary>
    /// actual file amount
    /// 实际文件个数
    /// </summary>
    public int nFileCount;
    /// <summary>
    /// file information
    /// 文件信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public NET_PIC_INFO_EX[] stFiles;
  }

  /// <summary>
  /// Enquiry jump condition
  /// 查询跳转条件
  /// </summary>
  public struct NET_FINDING_JUMP_OPTION_INFO
  {
    public UInt32 dwSize;
    /// <summary>
    /// 查询结果偏移量, 是相对于当前查询的第一条查询结果的位置偏移
    /// Query results offset relative to the first query results position offset current query
    /// </summary>
    public int nOffset;
  }

  /// <summary>
  /// FindGroupInfo port input parameter
  /// FindGroupInfo接口输入参数
  /// </summary>
  public struct NET_IN_FIND_GROUP_INFO
  {
    public uint dwSize;
    /// <summary>
    /// Group ID, SN staff, as null means search all staff group info 
    /// 人员组ID,唯一标识一组人员,为空表示查询全部人员组信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
  }

  /// <summary>
  /// FindGroupInfo port output parameter
  /// FindGroupInfo接口输出参数
  /// </summary>
  public struct NET_OUT_FIND_GROUP_INFO
  {
    public uint dwSize;
    /// <summary>
    /// staff group info , apply space by user, apply to sizeof(NET_FACERECONGNITION_GROUP_INFO)*nMaxGroupNum
    /// 人员组信息,由用户申请空间,大小为sizeof(NET_FACERECONGNITION_GROUP_INFO)*nMaxGroupNum
    /// </summary>
    public IntPtr pGroupInfos;
    /// <summary>
    /// current applied group size
    /// 当前申请的数组大小
    /// </summary>
    public int nMaxGroupNum;
    /// <summary>
    /// device returned staff group number 
    /// 设备返回的人员组个数
    /// </summary>
    public int nRetGroupNum;
  }

  /// <summary>
  /// staff group info 
  /// 人员组信息
  /// </summary>
  public struct NET_FACERECONGNITION_GROUP_INFO
  {
    public uint dwSize;
    /// <summary>
    /// staff group type ,  see  EM_FACE_DB_TYPE
    /// 人员组类型,详见 EM_FACE_DB_TYPE
    /// </summary>
    public EM_FACE_DB_TYPE emFaceDBType;
    /// <summary>
    /// staff group ID, SN(cannot modify, invalid when adding operation)
    /// 人员组ID,唯一标识一组人员(不可修改,添加操作时无效)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
    /// <summary>
    /// staff group name 
    /// 人员组名称 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szGroupName;
    /// <summary>
    /// staff group remark info 
    /// 人员组备注信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szGroupRemarks;
    /// <summary>
    /// current group staff number
    /// 当前组内人员数
    /// </summary>
    public int nGroupSize;
    /// <summary>
    /// returned similarity count
    /// 实际返回的库相似度阈值个数
    /// </summary>
    public int nRetSimilarityCount;
    /// <summary>
    /// library similarity threshold
    /// 库相似度阈值，人脸比对高于阈值认为匹配成功
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public int[] nSimilarity;
    /// <summary>
    /// returned channel count
    /// 实际返回的通道号个数
    /// </summary>
    public int nRetChnCount;
    /// <summary>
    /// the list of channels
    /// 当前组绑定到的视频通道号列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public int[] nChannel;
    /// <summary>
    /// 
    ///人脸组建模状态信息: [0]-准备建模的人员数量，不保证一定建模成功;[1]-建模失败的人员数量，图片不符合算法要求，需要更换图片;[2]-已建模成功人员数量，数据可用于算法进行人脸识别;[3]-曾经建模成功，但因算法升级变得不可用的数量，重新建模就可用
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public uint[] nFeatureState;

    public override string ToString()
    {
      return szGroupId;
    }
  }

  /// <summary>
  /// OperateFaceRecognitionGroup interface input parameter
  /// OperateFaceRecognitionGroup接口输入参数
  /// </summary>
  public struct NET_IN_OPERATE_FACERECONGNITION_GROUP
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// operate group type
    /// 操作类型
    /// </summary>
    public EM_OPERATE_FACERECONGNITION_GROUP_TYPE emOperateType;
    /// <summary>
    /// ADD corresponding to NET_ADD_FACERECONGNITION_GROUP_INFO,MODIFY corresponding to NET_MODIFY_FACERECONGNITION_GROUP_INFO,DELETE corresponding to NET_DELETE_FACERECONGNITION_GROUP_INFO
    /// 若操作类型ADD对应结构体为NET_ADD_FACERECONGNITION_GROUP_INFO,MODIFY对应结构体为NET_MODIFY_FACERECONGNITION_GROUP_INFO,DELETE对应结构体为NET_DELETE_FACERECONGNITION_GROUP_INFO
    /// </summary>
    public IntPtr pOPerateInfo;

  }

  /// <summary>
  /// add staff group info
  /// 添加人员组信息
  /// </summary>
  public struct NET_ADD_FACERECONGNITION_GROUP_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// staff group info
    /// 人员组信息
    /// </summary>
    public NET_FACERECONGNITION_GROUP_INFO stuGroupInfo;
  }

  /// <summary>
  /// modify staff group info
  /// 修改人员组信息
  /// </summary>
  public struct NET_MODIFY_FACERECONGNITION_GROUP_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// staff group info
    /// 人员组信息
    /// </summary>
    public NET_FACERECONGNITION_GROUP_INFO stuGroupInfo;
  }


  /// <summary>
  /// delete staff group info
  /// 删除人员组信息
  /// </summary>
  public struct NET_DELETE_FACERECONGNITION_GROUP_INFO
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// staff group ID, SN staff
    /// 人员组ID,唯一标识一组人员
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
  }

  /// <summary>
  /// staff group operation enumeration
  /// 人员组操作枚举
  /// </summary>
  public enum EM_OPERATE_FACERECONGNITION_GROUP_TYPE
  {
    /// <summary>
    /// unknow
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// add staff group info
    /// 添加人员组信息
    /// </summary>
    ADD,
    /// <summary>
    /// modify staff group info 
    /// 修改人员组信息
    /// </summary>
    MODIFY,
    /// <summary>
    /// delete staff group info
    /// 删除人员组信息
    /// </summary>
    DELETE,
  }

  /// <summary>
  /// OperateFaceRecognitionGroup interface output parameter
  /// OperateFaceRecognitionGroup接口输出参数
  /// </summary>
  public struct NET_OUT_OPERATE_FACERECONGNITION_GROUP
  {
    /// <summary>
    /// struct size
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// new record staff group ID, SN staff
    /// 新增记录的人员组ID,唯一标识一组人员
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId; // 
  }


  #endregion

  #region<<Dev State>>

  /// <summary>
  /// Query the Return Data Structure of the HDD Information
  /// </summary>
  public struct NET_HARDDISK_STATE
  {
    public UInt32 dwDiskNum;        // Amount      
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_DEV_DISKSTATE[] stDisks;                // HDD or subarea information 
  }

  /// <summary>
  /// Device HDD State Information
  /// </summary>
  public struct NET_DEV_DISKSTATE
  {
    public uint dwVolume;       // HDD capacity 
    public uint dwFreeSpace;      // HDD free space 
    public byte dwStatus;       // higher 4 byte instruct hdd type, see the enum struct EM_DISK_TYPE; lower four byte instruct HDD status,0-hiberation,1-active,2-malfucntion and etc.;Devide DWORD into four BYTE
    public byte bDiskNum;       // HDD number
    public byte bSubareaNum;      // Subarea number
    public byte bSignal;        // Symbol. 0:local. 1:remote
  }

  public enum EM_DISK_TYPE
  {
    READ_WRITE,                         // 读写驱动器
    READ_ONLY,                          // 只读驱动器
    BACKUP,                             // 备份驱动器或媒体驱动器
    REDUNDANT,                          // 冗余驱动器
    SNAPSHOT,                           // 快照驱动器
  }

  /// <summary>
  /// Camera property
  /// </summary>
  public struct NET_DEV_CAMERA_INFO
  {
    public byte bBrightnessEn;      // Brightness adjustable;1:adjustable,0:can not be adjusted
    public byte bContrastEn;      // Contrast adjustable
    public byte bColorEn;       // Hue adjustable
    public byte bGainEn;        // Gain adjustable
    public byte bSaturationEn;      // Saturation adjustable
    public byte bBacklightEn;     // Backlight compensation adjustable
    public byte bExposureEn;      // Exposure option adjustable
    public byte bColorConvEn;     // Day/night switch 
    public byte bAttrEn;        // Property option; 1:Enable, 0:Disable
    public byte bMirrorEn;        // Mirror;1:support,0:do not support 
    public byte bFlipEn;        // Flip;1:support,0:do not support 
    public byte iWhiteBalance;      // White Balance 1 Support,0 :Do not support
    public byte iSignalFormatMask;    // Signal format mask,Bitwise:0-Inside(Internal input) 1- BT656 2-720p 3-1080i  4-1080p  5-1080sF
    public byte bRotate90;        // 90-degree rotation 1:support,0:do not support 
    public byte bLimitedAutoExposure;   // Support the time limit with automatic exposure 1:support,0:do not support 
    public byte bCustomManualExposure;  // support user-defined manual exposure time 1:support,0:do not support
    public byte bFlashAdjustEn;     // Support the flash lamp adjust
    public byte bNightOptions;      // Support day and night change
    public byte iReferenceLevel;      // Support electric reference setting
    public byte bExternalSyncInput;     // Support external sync Input
    public ushort usMaxExposureTime;      // Max exposure time, unit:ms         
    public ushort usMinExposureTime;      // Min exposure time, unit:ms
    public byte bWideDynamicRange;      // Wide dynamic range,0-present not support,2~n max supported range value
    public byte bDoubleShutter;         // Double Shutter
    public byte byExposureCompensation; // 1 support, 0 not support
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 109)]
    public byte[] bRev;           // reserved 
  }

  /// <summary>
  /// struct of motion alarm
  /// </summary>
  public struct NET_CLIENT_MOTIONDETECT_STATE
  {
    public uint dwSize;
    public int channelcount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public uint[] dwAlarmState;           //DWORD value is the state by bit of 32 channels,0-no alarm,1-alarm
  }

  /// <summary>
  /// struct of blind alarm
  /// </summary>
  public struct NET_CLIENT_VIDEOBLIND_STATE
  {
    public uint dwSize;
    public int channelcount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public uint[] dwAlarmState;           //DWORD value is the state by bit of 32 channels,0-no alarm,1-alarm
  }

  /// <summary>
  /// the IPC types device supported
  /// </summary>
  public struct NET_DEV_IPC_INFO
  {
    public int nTypeCount;          // The IPC type amount supported
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public EM_IPC_TYPE[] bSupportTypes;             // Enumeration value please refer to EM_IPC_TYPE
  }

  /// <summary>
  /// IPC type
  /// </summary>
  public enum EM_IPC_TYPE : byte
  {
    PRIVATE,                             // private
    AEBELL,                              // AEBell
    PANASONIC,                           // panasonic
    SONY,                                // sony
    DYNACOLOR,                           // Dynacolor
    TCWS = 5,                           // TCWS	
    SAMSUNG,                             // Samsung
    YOKO,                                // YOKO
    AXIS,                                // AXIS
    SANYO,                   // sanyo       
    BOSH = 10,               // Bosch
    PECLO,                 // PECLO
    PROVIDEO,              // Provideo
    ACTI,                // ACTi
    VIVOTEK,               // Vivotek
    ARECONT = 15,                        // Arecont
    PRIVATEEH,                       // PrivateEH	
    IMATEK,                      // IMatek
    SHANY,                               // Shany
    VIDEOTREC,                           // videorec
    URA = 20,                            // Ura
    BITICINO,                            // Bticino 
    ONVIF,                               // Onvif protocol type
    SHEPHERD,                            // Shepherd
    YAAN,                                // Yaan
    AIRPOINT = 25,                       // Airpoint
    TYCO,                                // TYCO
    XUNMEI,                // Xunmei
    HIKVISION,               // HIKVISION
    LG,                                  // LG
    AOQIMAN = 30,                        // Aoqiman
    BAOKANG,                             // baokang  
    WATCHNET,                            // Watchnet
    XVISION,                             // Xvision
    FUSITSU,                             // Fisitu
    CANON = 35,              // Canon
    GE,                    // GE
    Basler,                // Basler
    Patro,                 // Patro
    CPKNC,                 // CPPLUS K series
    CPRNC = 40,              // CPPLUS R series
    CPUNC,                 // CPPLUS U series
    CPPLUS,                // cpplus oem 
    XunmeiS,               // XunmeiS
    GDDW,                // guangdong power grid
    PSIA = 45,                           // PSIA
    GB2818,                              // GB2818	
    GDYX,                                // GDYX
    OTHER,                               // custom
    CPUNR,                 // CPPLUS NVR
    CPUAR = 50,              // CPPLUS DVR
    AIRLIVE,                             // Airlive	
    NPE,                 // NPE	
    AXVIEW,                // AXVIEW
    DFWL,                                // DFWL
    HYUNDAI = 56,            // HYUNDAI DVR
    APHD,                // APHD
    WELLTRANS,               // WELLTRANS
    CDJF,                // CDJF
    JVC = 60,                // JVC
    INFINOVA,              // INFINOVA
    ADT,                 // ADT
    SIVIDI,                // SIVIDI
    CPUNP,                 // CPPLUS PTZ
    HX = 65,               // HX
    TJGS,                                // TJGS
    MULTICAST = 79,                      // Multicast
    RVI = 84,              // RVi  
  }

  /// <summary>
  /// RAID info
  /// </summary>
  public struct NET_ALARM_RAID_INFO
  {
    public int nRaidNumber;                // RAID number
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_RAID_STATE_INFO[] stuRaidInfo;            // RAID info
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] reserved;
  }

  /// <summary>
  /// RAID STATE INFO
  /// </summary>
  public struct NET_RAID_STATE_INFO
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szName;             // Raid name
    public byte byType;           // type 1:Jbod     2:Raid0      3:Raid1     4:Raid5
    public byte byStatus;         // status 0:unknown ,1:active,2:degraded,3:inactive,4:recovering
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    public int nCntMem;         // nMember number
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] nMember;           // 1,2,3,.
    public int nCapacity;         // capacity(G)
    public int nRemainSpace;        // remain space(M)
    public int nTank;           // Tank 0:main,1:tank1,2:tank2 ...
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] reserved;
  }

  /// <summary>
  /// Virtual camera status search
  /// </summary>
  public struct NET_DEV_VIRTUALCAMERA_STATE_INFO
  {
    public uint nStructSize;                  // Structure body size
    public int nChannelID;                   // Channel No.
    public EM_CONNECT_STATE emConnectState;               // Connection status
    public uint uiPOEPort;                    // The PoE port the virtual camera connected to. 0=It is not a PoE connection.
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] szDeviceName;                 // Device name
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szDeviceType;                 // Device type
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szSystemType;                 // system type
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] szSerialNo;                   // serial no
    public int nVideoInput;                  // video input number
    public int nAudioInput;                  // audio input number
    public int nAlarmOutput;                 // alarm output number
  }

  /// <summary>
  /// Connect state
  /// </summary>
  public enum EM_CONNECT_STATE
  {
    UNCONNECT = 0,
    CONNECTING,
    CONNECTED,
    ERROR = 255,
  }

  /// <summary>
  /// struct of video loss alarm
  /// </summary>
  public struct NET_CLIENT_VIDEOLOST_STATE
  {
    public uint dwSize;
    public int channelcount;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public uint[] dwAlarmState;           //UINT32 value is the state by bit of 32 channels,0-no alarm,1-alarm
  }

  /// <summary>
  /// front IPC disconnect alarm info
  /// </summary>
  public struct NET_ALARM_FRONTDISCONNET_INFO
  {
    public uint dwSize;                           // struct size
    public int nChannelID;                       // channel id
    public int nAction;                          // 0:start 1:stop
    public NET_TIME stuTime;                          // event happen time
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 260)]
    public byte[] szIpAddress;                      // front IP's address
  }

  #endregion

  #region QueryDevInfo

  /// <summary>
  /// QueryDevInfo , NET_QUERY_DEV_STORAGE_INFOS input param
  /// QueryDevInfo , NET_QUERY_DEV_STORAGE_INFOS接口输入参数
  /// </summary>
  public struct NET_IN_STORAGE_DEV_INFOS
  {
    public uint dwSize;
    /// <summary>
    /// volume type to get
    /// 要获取的卷类型
    /// </summary>
    public EM_VOLUME_TYPE emVolumeType;
  }

  /// <summary>
  /// volume type enumeration
  /// 卷类型
  /// </summary>
  public enum EM_VOLUME_TYPE
  {
    /// <summary>
    /// all volume
    /// 所有卷
    /// </summary>
    ALL = 0,
    /// <summary>
    /// physical volume
    /// 物理卷
    /// </summary>
    PHYSICAL,
    /// <summary>
    /// Raid volume
    /// Raid卷
    /// </summary>
    RAID,
    /// <summary>
    /// VG virtual volume
    /// VG虚拟卷组
    /// </summary>
    VOLUME_GROUP,
    /// <summary>
    /// iSCSI volume
    /// iSCSI卷
    /// </summary>
    ISCSI,
    /// <summary>
    /// independent physical volume, this physical volume, is not added into,  RAID, virtual volume group
    /// 独立物理卷（这个物理盘,没有加入到, RAID,虚拟卷组等等组中）
    /// </summary>
    INVIDUAL_PHY,
    /// <summary>
    /// global hot spare volume
    /// 全局热备卷
    /// </summary>
    GLOBAL_SPARE,
    MAX,
  }

  /// <summary>
  /// QueryDevInfo , NET_QUERY_DEV_STORAGE_INFOS output parameter
  /// QueryDevInfo , NET_QUERY_DEV_STORAGE_INFOS 输出参数
  /// </summary>
  public struct NET_OUT_STORAGE_DEV_INFOS
  {
    public uint dwSize;
    /// <summary>
    /// device storage moduleinfo list to get
    /// 获取到设备的存储模块信息列表
    /// </summary>
    public int nDevInfosNum;
    /// <summary>
    /// device info list, dwsize of NET_STORAGE_DEVICE need to assign value
    /// 设备信息列表, NET_STORAGE_DEVICE的dwsize需赋值
    /// </summary>    			
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public NET_STORAGE_DEVICE[] stuStoregeDevInfos;
  }

  /// <summary>
  /// 
  /// 存储设备信息
  /// </summary>
  public struct NET_STORAGE_DEVICE
  {
    public uint dwSize;
    /// <summary>
    /// name
    /// 名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// Total space, BYTE 
    /// 总空间, byte
    /// </summary>
    public Int64 nTotalSpace;
    /// <summary>
    /// free space, BYTE
    /// 剩余空间, byte
    /// </summary>
    public Int64 nFreeSpace;
    /// <summary>
    /// Media, 0-DISK, 1-CDROM, 2-FLASH medium,  
    /// 介质, 0-DISK, 1-CDROM, 2-FLASH
    /// </summary>
    public byte byMedia;
    /// <summary>
    /// BUS, 0-ATA, 1-SATA, 2-USB, 3-SDIO, 4-SCSI main line 0-ATA, 1-SATA, 2-USB, 3-SDIO, 4-SCSI
    /// 总线, 0-ATA, 1-SATA, 2-USB, 3-SDIO, 4-SCSI
    /// </summary>
    public byte byBUS;
    /// <summary>
    /// volume type, 0-physics, 1-Raid, 2- VG virtual 
    /// 卷类型, 0-物理卷, 1-Raid卷, 2-VG虚拟卷, 3-ISCSI
    /// </summary>
    public byte byVolume;
    /// <summary>
    /// Physics disk state, 0-physics disk offline state 1-physics disk  2- RAID activity 3- RAID sync 4-RAID hotspare 5-RAID invalidation 6- RAID re-creation  7- RAID delete
    /// 物理硬盘状态, 取值为 NET_STORAGE_DEV_OFFLINE 和 NET_STORAGE_DEV_RUNNING 等
    /// </summary>
    public byte byState;
    /// <summary>
    /// storage interface of devices of same type logic number
    /// 同类设备存储接口的物理编号
    /// </summary>
    public int nPhysicNo;
    /// <summary>
    /// storage interface of devices of same type physics number
    /// 同类设备存储接口的逻辑编号
    /// </summary>
    public int nLogicNo;
    /// <summary>
    /// superior storage group name
    /// 上级存储组名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szParent;
    /// <summary>
    /// device module
    /// 设备模块
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szModule;
    /// <summary>
    /// device serial number
    /// 设备序列号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szSerial;
    /// <summary>
    /// Firmware version
    /// 固件版本
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szFirmware;
    /// <summary>
    /// partition number
    /// 分区数
    /// </summary>
    public int nPartitionNum;
    /// <summary>
    /// partition info
    /// 分区信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_STORAGE_PARTITION[] stuPartitions;
    /// <summary>
    /// Raid info, for RAID use only(byVolume == 1) 
    /// RAID信息, 只对RAID有效(byVolume == 1)
    /// </summary>
    public NET_STORAGE_RAID stuRaid;
    /// <summary>
    /// Iscsi info, for iscsi use only (byVolume == 2)
    /// ISCSI信息, 只对ISCSI盘有效(byVolume == 3)
    /// </summary>
    public NET_ISCSI_TARGET stuISCSI;
    /// <summary>
    /// tank enable
    /// 扩展柜使能
    /// </summary>
    public bool abTank;
    /// <summary>
    /// tank info, effectice when abTank = TRUE
    /// 硬盘所在扩展柜信息, abTank为TRUE时有效
    /// </summary>
    public NET_STORAGE_TANK stuTank;
  }

  /// <summary>
  /// Storage partition info
  /// 存储分区信息
  /// </summary>
  public struct NET_STORAGE_PARTITION
  {
    public uint dwSize;
    /// <summary>
    /// 名称
    /// Name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// 总空间
    /// Total space
    /// </summary>
    public Int64 nTotalSpace;
    /// <summary>
    /// free space
    /// 剩余空间
    /// </summary>
    public Int64 nFreeSpace;
    /// <summary>
    /// Mount point
    /// 挂载点
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szMountOn;
    /// <summary>
    /// File system
    /// 文件系统
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szFileSystem;
    /// <summary>
    /// partition state, 0-LV not available, 1-LV available
    /// 分区状态, 0-LV不可用, 1-LV可用
    /// </summary>
    public int nStatus;
  }

  /// <summary>
  /// RAID Info
  /// RAID信息
  /// </summary>
  public struct NET_STORAGE_RAID
  {
    public uint dwSize;
    /// <summary>
    /// level
    /// 等级  
    /// </summary>
    public int nLevel;
    /// <summary>
    /// RAID state combination NET_RAID_STATE_ACTIVE | NET_RAID_STATE_DEGRADED
    /// RAID状态组合, 如 NET_RAID_STATE_ACTIVE | NET_RAID_STATE_DEGRADED
    /// </summary>
    public int nState;
    /// <summary>
    /// member amount
    /// 成员数量
    /// </summary>
    public int nMemberNum;
    /// <summary>
    /// RAID member
    /// RAID成员
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_STORAGE_NAME_LEN_String[] szMembers;
    /// <summary>
    /// Sync percentage, 0~100, RAID status has"Recovering" or "Resyncing" valid
    /// 同步百分比, 0~100, RAID状态中有"Recovering"或"Resyncing"时有效
    /// </summary>
    public float fRecoverPercent;
    /// <summary>
    /// Sync speed, unit MBps, RAID status has"Recovering" or "Resyncing" valid
    /// 同步速度, 单位MBps, RAID状态中有"Recovering"或"Resyncing"时有效
    /// </summary>
    public float fRecoverMBps;
    /// <summary>
    /// Sync remaining time, unit minute, RAID status has "Recovering" or "Resyncing" valid
    /// 同步剩余时间, 单位分钟, RAID状态中有"Recovering"或"Resyncing"时有效
    /// </summary>
    public float fRecoverTimeRemain;
    /// <summary>
    /// RAID member info
    /// RAID成员信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_RAID_MEMBER_INFO[] stuMemberInfos;
    /// <summary>
    /// The number of RAID device
    /// RAID设备个数
    /// </summary>
    public int nRaidDevices;
    /// <summary>
    /// The total count of RAID device
    /// RAID设备总数
    /// </summary>
    public int nTotalDevices;
    /// <summary>
    /// The number of active device
    /// 活动设备个数
    /// </summary>
    public int nActiveDevices;
    /// <summary>
    /// The number of working device
    /// 工作设备个数
    /// </summary>
    public int nWorkingDevices;
    /// <summary>
    /// The number of failed device
    /// 失败设备个数
    /// </summary>
    public int nFailedDevices;
    /// <summary>
    /// The number of hot-spare device
    /// 热备设备个数    
    /// </summary>
    public int nSpareDevices;
  }

  /// <summary>
  /// Store NET_STORAGE_NAME string
  /// 临时放成员名字字符串
  /// </summary>
  public struct NET_STORAGE_NAME_LEN_String
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szSTORAGE_NAME;
  }


  /// <summary>
  /// RAID member info
  /// RAID成员信息
  /// </summary>
  public struct NET_RAID_MEMBER_INFO
  {
    public uint dwSize;
    /// <summary>
    /// disk no., may use to describe disk cabinet slot
    /// 磁盘号, 可用于描述磁盘在磁柜的槽位
    /// </summary>
    public uint dwID;
    /// <summary>
    /// partial hot device, true-partial hot device, false-RAID sub disk
    /// 是否局部热备, true-局部热备, false-RAID子盘
    /// </summary>
    public bool bSpare;
  }

  /// <summary>
  /// ISCSI Target Info
  /// ISCSI Target信息
  /// </summary>
  public struct NET_ISCSI_TARGET
  {
    public uint dwSize;
    /// <summary>
    /// Name
    /// 名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// service address
    /// 服务器地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szAddress;
    /// <summary>
    /// user name
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUser;
    /// <summary>
    /// port
    /// 端口
    /// </summary>
    public int nPort;
    /// <summary>
    /// status, 0- unknow, 1-connected, 2-un connected, 3-connect failed, 4-authentication failed, 5-connect time out	
    /// 状态, 0-未知, 1-已连接, 2-未连接, 3-连接失败, 4-认证失败, 5-连接超时, 6-不存在
    /// </summary>
    public uint nStatus;
  }

  /// <summary>
  /// storage tank info
  /// 扩展柜信息
  /// </summary>
  public struct NET_STORAGE_TANK
  {
    public uint dwSize;
    /// <summary>
    /// level, the host is 0 level
    /// 级别, 主机是第0级,其它下属级别类推
    /// </summary>
    public int nLevel;
    /// <summary>
    /// extend port number from 0
    /// 同一级扩展柜内的扩展口编号, 从0开始
    /// </summary>
    public int nTankNo;
    /// <summary>
    /// Corresponding cabinet board card no., start from 0
    /// 对应主柜上的板卡号, 从0开始编号  
    /// </summary>   
    public int nSlot;
  }
  #endregion

  #region OSD Config

  /// <summary>
  /// Get/Set OSD Config
  /// OSD配置
  /// </summary>
  public enum EM_CFG_OSD_TYPE
  {
    /// <summary>
    /// Encode widget-channel title config, corresponding to struct NET_OSD_CHANNEL_TITLE, emOsdBlendType in struct must be set
    /// 叠加通道标题属性配置，对应结构体 NET_OSD_CHANNEL_TITLE,其中结构体中的emOsdBlendType为必填参数
    /// </summary>
    CHANNELTITLE = 1000,
    /// <summary>
    /// Encode widget-Time title config, corresponding to NET_OSD_TIME_TITLE, emOsdBlendType in struct must be set
    /// 叠加时间标题属性配置，对应结构体 NET_OSD_TIME_TITLE,其中结构体中的emOsdBlendType为必填参数
    /// </summary>
    TIMETITLE,
    /// <summary>
    /// Encode widget-Self-defined title config, corresponding to NET_OSD_CUSTOM_TITLE, emOsdBlendType  in struct must be set
    /// 叠加自定义标题属性配置，对应结构体 NET_OSD_CUSTOM_TITLE,其中结构体中的stuCustomTitle.emOsdBlendType为必填参数
    /// </summary>
    CUSTOMTITLE,
    /// <summary>
    /// Encode widget-Self-defined title alignment config, corresponding to NET_OSD_CUSTOM_TITLE_TEXT_ALIGN
    /// 叠加自定义标题对齐方式属性配置，对应结构体 NET_OSD_CUSTOM_TITLE_TEXT_ALIGN
    /// </summary>
    CUSTOMTITLETEXTALIGN,
    /// <summary>
    /// Encode widget-common info config, corresponding to NET_OSD_COMM_INFO
    /// 叠加公共属性配置，对应结构体 NET_OSD_COMM_INFO
    /// </summary>
    COMMONINFO,
    /// <summary>
    /// Encode widget-PTZ zoom config, corresponding to NET_OSD_PTZZOOM_INFO
    /// 变倍叠加配置，对应结构体 NET_OSD_PTZZOOM_INFO
    /// </summary>
    PTZZOOM,
    /// <summary>
    /// Encode widget-GPS title,corresponding to NET_OSD_GPS_TITLE
    /// 叠加GPS标题显示配置，对应结构体 NET_OSD_GPS_TITLE
    /// </summary>
    GPSTITLE,
    /// <summary>
    /// Configuration of the statistical plane,which about number of people,  use this config when Class type is NumberStatPlan, correspinding to NET_OSD_NUMBER_PLAN
    /// 人数统计计划叠加OSD配置, 支持NumberStatPlan算法大类时(球机)使用，对应结构体NET_OSD_NUMBER_STATPLAN
    /// </summary>
    NUMBERSTATPLAN,
    /// <summary>
    /// GPS Start number OSD config, used by vehicle equipment , corresponding to NET_CFG_GPSSTARNUM_OSD_INFO
    /// GPS搜星数OSD配置, 车载定制需求, 对应结构体 NET_CFG_GPSSTARNUM_OSD_INFO
    /// </summary>
    GPSSTARNUM,
  }

  /// <summary>
  /// Overlay Type
  /// 叠加类型
  /// </summary>
  public enum EM_OSD_BLEND_TYPE
  {
    /// <summary>
    /// unknow overlay type
    /// 未知类型
    /// </summary>
    UNKNOW = 0,
    /// <summary>
    /// Overlay to main stream
    /// 叠加到主码流
    /// </summary>
    MAIN,
    /// <summary>
    /// Overlay to extra stream 1
    /// 叠加到辅码流1
    /// </summary>
    EXTRA1,
    /// <summary>
    /// Overlay to extra stream 2
    /// 叠加到辅码流2
    /// </summary>
    EXTRA2,
    /// <summary>
    /// Overlay to extra stream 3
    /// 叠加到辅码流3
    /// </summary>
    EXTRA3,
    /// <summary>
    /// Overlay to snap
    /// 叠加到抓图
    /// </summary>
    SNAPSHOT,
    /// <summary>
    /// Overlay to preview mode
    /// 叠加到预览视频
    /// </summary>
    PREVIEW
  }

  /// <summary>
  /// Encode widget-channel title
  /// 通道标题OSD配置
  /// </summary>
  public struct NET_OSD_CHANNEL_TITLE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Overlay Type, should set the value whether getting config  or setting config
    /// 叠加类型
    /// </summary>
    public EM_OSD_BLEND_TYPE emOsdBlendType;
    /// <summary>
    /// Overlay or not
    /// 是否叠加
    /// </summary>
    public bool bEncodeBlend;
    /// <summary>
    /// Foreground color
    /// 前景色
    /// </summary>
    public NET_COLOR_RGBA stuFrontColor;
    /// <summary>
    /// Background color
    /// 背景色
    /// </summary>
    public NET_COLOR_RGBA stuBackColor;
    /// <summary>
    /// Zone. The coordinates value ranges from  0 to 8191. Only use left value and top value.The point (left,top) shall be the same as the point(right,bottom).
    /// 区域, 坐标取值[0~8191], 仅使用left和top值, 点(left,top)应和(right,bottom)设置成同样的点
    /// </summary>
    public NET_RECT stuRect;
  }

  /// <summary>
  /// Encode widget-Time title
  /// 时间标题
  /// </summary>
  public struct NET_OSD_TIME_TITLE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Overlay Type, should set the value whether getting config  or setting config
    /// 叠加类型
    /// </summary>
    public EM_OSD_BLEND_TYPE emOsdBlendType;
    /// <summary>
    /// Overlay or not
    /// 是否叠加
    /// </summary>
    public bool bEncodeBlend;
    /// <summary>
    /// Foreground color
    /// 前景色
    /// </summary>
    public NET_COLOR_RGBA stuFrontColor;
    /// <summary>
    /// Background color
    /// 背景色
    /// </summary>
    public NET_COLOR_RGBA stuBackColor;
    /// <summary>
    /// Zone. The coordinates value ranges from  0 to 8191. Only use left value and top value.The point (left,top) shall be the same as the point(right,bottom).
    /// 区域, 坐标取值[0~8191], 仅使用left和top值, 点(left,top)应和(right,bottom)设置成同样的点
    /// </summary>
    public NET_RECT stuRect;
    /// <summary>
    /// Display week or not
    /// 是否显示星期
    /// </summary>
    public bool bShowWeek;
  }

  /// <summary>
  /// Encode widget-User-defined title information
  /// 自定义标题信息
  /// </summary>
  public struct NET_CUSTOM_TITLE_INFO
  {
    /// <summary>
    /// Overlay or not
    /// 是否叠加
    /// </summary>
    public bool bEncodeBlend;
    /// <summary>
    /// Foreground color
    /// 前景色
    /// </summary>
    public NET_COLOR_RGBA stuFrontColor;
    /// <summary>
    /// Background color
    /// 背景色
    /// </summary>
    public NET_COLOR_RGBA stuBackColor;
    /// <summary>
    /// Zone. The coordinates value ranges from  0 to 8191. Only use left value and top value.The point (left,top) shall be the same as the point(right,bottom).
    /// 区域, 坐标取值[0~8191], 仅使用left和top值, 点(left,top)应和(right,bottom)设置成同样的点
    /// </summary>
    public NET_RECT stuRect;
    /// <summary>
    /// Title contents
    /// 标题内容
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
    public string szText;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] byReserved;
  }

  /// <summary>
  /// Encode widget-User-defined title
  /// 自定义标题
  /// </summary>
  public struct NET_OSD_CUSTOM_TITLE
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Overlay Type, should set the value whether getting config  or setting config
    /// 叠加类型
    /// </summary>
    public EM_OSD_BLEND_TYPE emOsdBlendType;
    /// <summary>
    /// User-defined title amount
    /// 自定义标题数量
    /// </summary>
    public int nCustomTitleNum;
    /// <summary>
    /// User-defined title
    /// 自定义标题
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public NET_CUSTOM_TITLE_INFO[] stuCustomTitle;
  }

  /// <summary>
  /// User-defined title text alignment
  /// 自定义标题文本对齐
  /// </summary>
  public struct NET_OSD_CUSTOM_TITLE_TEXT_ALIGN
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// User-defined title amount
    /// 自定义标题数量
    /// </summary>
    public int nCustomTitleNum;
    /// <summary>
    /// User-defined title alignment info
    /// 自定义标题文本对齐方式
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public EM_TITLE_TEXT_ALIGNTYPE[] emTextAlign;
  }

  /// <summary>
  /// title text alignment type
  /// 标题文本对齐方式
  /// </summary>
  public enum EM_TITLE_TEXT_ALIGNTYPE
  {
    /// <summary>
    /// Invalid alignment mathod
    /// 无效的对齐方式
    /// </summary>
    INVALID,
    /// <summary>
    /// Left alignment
    /// 左对齐
    /// </summary>
    LEFT,
    /// <summary>
    /// X coordinate alignment
    /// X坐标中对齐
    /// </summary>
    XCENTER,
    /// <summary>
    /// Y coordinate alignment
    /// Y坐标中对齐
    /// </summary>
    YCENTER,
    /// <summary>
    /// Center
    /// 居中
    /// </summary>
    CENTER,
    /// <summary>
    /// Right alignment
    /// 右对齐
    /// </summary>
    RIGHT,
    /// <summary>
    /// By top alignment
    /// 按照顶部对齐
    /// </summary>
    TOP,
    /// <summary>
    /// By bottom alignment
    /// 按照底部对齐
    /// </summary>
    BOTTOM,
    /// <summary>
    /// By upper left alignment
    /// 按照左上角对齐
    /// </summary>
    LEFTTOP,
    /// <summary>
    /// Next row alignment 
    /// 换行对齐
    /// </summary>
    CHANGELINE,
  }

  /// <summary>
  /// Encode widget common info
  /// 公共配置信息
  /// </summary>
  public struct NET_OSD_COMM_INFO
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// overlay font size scale
    /// 叠加字体大小放大比例
    /// </summary>
    public double fFontSizeScale;
    /// <summary>
    /// global font size overlay to main stream, unit px, default is 24
    /// 叠加到主码流上的全局字体大小
    /// </summary>
    public int nFontSize;
    /// <summary>
    /// global font size overlay to sub stream 1, unit px
    /// 叠加到辅码流1上的全局字体大小
    /// </summary>
    public int nFontSizeExtra1;
    /// <summary>
    /// global font size overlay to sub stream 2, unit px
    /// 叠加到辅码流2上的全局字体大小
    /// </summary>
    public int nFontSizeExtra2;
    /// <summary>
    /// global font size overlay to sub stream 3, unit px
    /// 叠加到辅码流3上的全局字体大小
    /// </summary>
    public int nFontSizeExtra3;
    /// <summary>
    /// global font size overlay to snapshot stream, unit px
    /// 叠加到抓图流上的全局字体大小
    /// </summary>
    public int nFontSizeSnapshot;
    /// <summary>
    /// combination picture overlay to snapshot stream, unit px
    /// 叠加到抓图流上合成图片的字体大小
    /// </summary>
    public int nFontSizeMergeSnapshot;
  }
  #endregion

  #region encode config
  /// <summary>
  /// the configuration about Encode
  /// encode 相关配置
  /// </summary>
  public enum EM_CFG_ENCODE_TYPE
  {
    /// <summary>
    /// Encode-video options config, corresponding to NET_ENCODE_VIDEO_INFO
    /// 编码视频格式属性配置，对应结构体 NET_ENCODE_VIDEO_INFO
    /// </summary>
    VIDEO = 1100,
    /// <summary>
    /// Encode-video pack options config, corresponding to NET_ENCODE_VIDEO_PACK_INFO
    /// 编码视频格式打包模式配置，对应结构体 NET_ENCODE_VIDEO_PACK_INFO
    /// </summary>
    VIDEO_PACK,
    /// <summary>
    /// Encode-video SVC options config, corresponding to NET_ENCODE_VIDEO_SVC_INFO
    /// 编码视频格式SVC配置，对应结构体 NET_ENCODE_VIDEO_SVC_INFO
    /// </summary>
    VIDEO_SVC,
    /// <summary>
    /// Encode-video profile options config, corresponding to NET_ENCODE_VIDEO_PROFILE_INFO
    /// 编码视频格式profile配置，对应结构体 NET_ENCODE_VIDEO_PROFILE_INFO
    /// </summary>
    VIDEO_PROFILE,
    /// <summary>
    /// Encode-video audio compression options config, corresponding to NET_ENCODE_AUDIO_COMPRESSION_INFO
    /// 编码音频压缩格式配置，对应结构体 NET_ENCODE_AUDIO_COMPRESSION_INFO
    /// </summary>
    AUDIO_COMPRESSION,
    /// <summary>
    /// Encode-video audio options config, corresponding to NET_ENCODE_AUDIO_INFO
    /// 编码音频格式配置，对应结构体 NET_ENCODE_AUDIO_INFO
    /// </summary>
    AUDIO_INFO,
    /// <summary>
    /// Encode-video snap options config, corresponding to NET_ENCODE_SNAP_INFO
    /// 编码抓图配置，对应结构体 NET_ENCODE_SNAP_INFO
    /// </summary>
    SNAP_INFO,
    /// <summary>
    /// Encode-video snap time options config, corresponding to NET_ENCODE_SNAP_TIME_INFO
    /// 编码抓图时间相关配置，对应结构体 NET_ENCODE_SNAP_TIME_INFO
    /// </summary>
    SNAPTIME,
    /// <summary>
    /// Encode-video channel title options config, corresponding to NET_ENCODE_CHANNELTITLE_INFO
    /// 通道名称配置，对应结构体 NET_ENCODE_CHANNELTITLE_INFO
    /// </summary>
    CHANNELTITLE,
  }

  /// <summary>
  /// channel title info
  /// 通道名称配置
  /// </summary>
  public struct NET_ENCODE_CHANNELTITLE_INFO
  {
    /// <summary>
    /// struct size 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel title
    /// 通道名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szChannelName;
  }


  #endregion

  /// <summary>
  /// Video split operation type
  /// 视频分割操作类型
  /// </summary>
  public enum EM_NET_SPLIT_OPERATE_TYPE
  {
    /// <summary>
    /// Set background, corresponding NET_IN_SPLIT_SET_BACKGROUND  and NET_OUT_SPLIT_SET_BACKBROUND
    /// 设置背景图片, 对应 NET_IN_SPLIT_SET_BACKGROUND 和 NET_OUT_SPLIT_SET_BACKBROUND
    /// </summary>
    SET_BACKGROUND,
    /// <summary>
    /// get background, corresponding NET_IN_SPLIT_GET_BACKGROUND  and NET_OUT_SPLIT_GET_BACKGROUND
    /// 获取背景图片, 对应 NET_IN_SPLIT_GET_BACKGROUND 和 NET_OUT_SPLIT_GET_BACKGROUND
    /// </summary>
    GET_BACKGROUND,
    /// <summary>
    /// set pre stream srouce, corresponding to NET_IN_SPLIT_SET_PREPULLSRC and NET_OUT_SPLIT_SET_PREPULLSRC
    /// 设置预拉流源, 对应 NET_IN_SPLIT_SET_PREPULLSRC 和 NET_OUT_SPLIT_SET_PREPULLSRC
    /// </summary>
    SET_PREPULLSRC,
    /// <summary>
    /// set source frame brightness switch, corresponding to NET_IN_SPLIT_SET_HIGHLIGHT and NET_OUT_SPLIT_SET_HIGHLIGHT
    /// 设置源边框高亮使能开关, 对应 NET_IN_SPLIT_SET_HIGHLIGHT 和 NET_OUT_SPLIT_SET_HIGHLIGHT
    /// </summary>
    SET_HIGHLIGHT,
    /// <summary>
    /// adjust window Z order, corresponding to NET_IN_SPLIT_SET_ZORDER  and  NET_OUT_SPLIT_SET_ZORDER
    /// 调整窗口Z序, 对应 NET_IN_SPLIT_SET_ZORDER 和 NET_OUT_SPLIT_SET_ZORDER
    /// </summary>
    SET_ZORDER,
    /// <summary>
    /// window tour control, corresponding to NET_IN_SPLIT_SET_TOUR  and  NET_OUT_SPLIT_SET_TOUR
    /// 窗口轮巡控制, 对应 NET_IN_SPLIT_SET_TOUR 和 NET_OUT_SPLIT_SET_TOUR
    /// </summary>
    SET_TOUR,
    /// <summary>
    /// Get window tour status , corresponding to NET_IN_SPLIT_GET_TOUR_STATUS  and  NET_OUT_SPLIT_GET_TOUR_STATUS
    /// 获取窗口轮巡状态, 对应 NET_IN_SPLIT_GET_TOUR_STATUS 和 NET_OUT_SPLIT_GET_TOUR_STATUS
    /// </summary>
    GET_TOUR_STATUS,
    /// <summary>
    /// Get screen window info , corresponding to NET_IN_SPLIT_GET_SCENE  and  NET_OUT_SPLIT_GET_SCENE
    /// 获取屏内窗口信息, 对应 NET_IN_SPLIT_GET_SCENE 和 NET_OUT_SPLIT_GET_SCENE
    /// </summary>
    GET_SCENE,
    /// <summary>
    /// batch window, corresponding to NET_IN_SPLIT_OPEN_WINDOWS  and  NET_OUT_SPLIT_OPEN_WINDOWS
    /// 批量开窗, 对应 NET_IN_SPLIT_OPEN_WINDOWS 和 NET_OUT_SPLIT_OPEN_WINDOWS
    /// </summary>
    OPEN_WINDOWS,
    /// <summary>
    /// set work mode , corresponding to NET_IN_SPLIT_SET_WORK_MODE  and  NET_OUT_SPLIT_SET_WORK_MODE
    /// 设置工作模式, 对应 NET_IN_SPLIT_SET_WORK_MODE 和 NET_OUT_SPLIT_SET_WORK_MODE
    /// </summary>
    SET_WORK_MODE,
    /// <summary>
    /// Get player example, corresponding to NET_IN_SPLIT_GET_PLAYER  and  NET_OUT_SPLIT_GET_PLAYER
    /// 获取播放器实例,对应 NET_IN_SPLIT_GET_PLAYER 和 NET_OUT_SPLIT_GET_PLAYER
    /// </summary>
    GET_PLAYER,
    /// <summary>
    /// Set window working mode, corresponding  NET_IN_WM_SET_WORK_MODE and NET_OUT_WM_SET_WORK_MODE
    /// 设置窗口工作模式,对应 NET_IN_WM_SET_WORK_MODE 和 NET_OUT_WM_SET_WORK_MODE
    /// </summary>
    SET_WM_WORK_MODE,
    /// <summary>
    /// Get window working mode, corresponding  NET_IN_WM_GET_WORK_MODE and NET_OUT_WM_GET_WORK_MODE
    /// 获取窗口工作模式,对应 NET_IN_WM_GET_WORK_MODE 和 NET_OUT_WM_GET_WORK_MODE
    /// </summary>
    GET_WORK_MODE,
    /// <summary>
    /// close batch windows NET_IN_SPLIT_CLOSE_WINDOWS o,a NET_OUT_SPLIT_CLOSE_WINDOWS
    /// 批量关窗, 对应 NET_IN_SPLIT_CLOSE_WINDOWS 和 NET_OUT_SPLIT_CLOSE_WINDOWS
    /// </summary>
    CLOSE_WINDOWS,
    /// <summary>
    /// set the output rules of the fish eyes, corresponding NET_IN_WM_SET_FISH_EYE_PARAM and NET_OUT_WM_SET_FISH_EYE_PARAM
    /// 设置输出屏的鱼眼矫正规则 , 对应NET_IN_WM_SET_FISH_EYE_PARAM 和 NET_OUT_WM_SET_FISH_EYE_PARAM
    /// </summary>
    SET_FISH_EYE_PARAM,
    /// <summary>
    /// set the corridor mode of the window, corresponding NET_IN_WM_SET_CORRIDOR_MODE and NET_OUT_WM_SET_CORRIDOR_MODE
    /// 设置窗口走廊模式，对应NET_IN_WM_SET_CORRIDOR_MODE和NET_OUT_WM_SET_CORRIDOR_MODE
    /// </summary>
    SET_CORRIDOR_MODE,
    /// <summary>
    /// get the corridor mode of the window, corresponding NET_IN_WM_GET_CORRIDOR_MODE and NET_OUT_WM_GET_CORRIDOR_MODE
    /// 获取窗口走廊模式，对应NET_IN_WM_GET_CORRIDOR_MODE和NET_OUT_WM_GET_CORRIDOR_MODE
    /// </summary>
    GET_CORRIDOR_MODE,
    /// <summary>
    /// set volume column enable, corresponding NET_IN_WM_SET_VOLUME_COLUMN and NET_OUT_WM_SET_VOLUME_COLUMN
    /// 设置显示音量柱使能模式，对应NET_IN_WM_SET_VOLUME_COLUMN和NET_OUT_WM_SET_VOLUME_COLUMN
    /// </summary>
    SET_VOLUME_COLUMN,
    /// <summary>
    /// get volume column enable, corresponding NET_IN_WM_GET_VOLUME_COLUMN and NET_OUT_WM_GET_VOLUME_COLUMN
    /// 获取显示音量柱使能模式，对应NET_IN_WM_GET_VOLUME_COLUMN和NET_OUT_WM_GET_VOLUME_COLUMN
    /// </summary>
    GET_VOLUME_COLUMN,
    /// <summary>
    /// set the background of window, corresponding NET_IN_WM_SET_BACKGROUND and NET_OUT_WM_SET_BACKGROUND
    /// 设置窗口背景图片，对应NET_IN_WM_SET_BACKGROUND和NET_OUT_WM_SET_BACKGROUND
    /// </summary>
    SET_WM_BACKGROUND,
    /// <summary>
    /// get the background of window, corresponding NET_IN_WM_GET_BACKGROUND and NET_OUT_WM_GET_BACKGROUND
    /// 获取窗口背景图片，对应NET_IN_WM_GET_BACKGROUND和NET_OUT_WM_GET_BACKGROUND
    /// </summary>
    GET_WM_BACKGROUND,
  }

  /// <summary>
  /// Window Working Mode
  /// 窗口工作模式
  /// </summary>
  public enum EM_NET_WM_WORK_MODE
  {
    /// <summary>
    /// Unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// Preview mode
    /// 预览模式
    /// </summary>
    DISPLAY,
    /// <summary>
    /// Playback mode
    /// 回放模式
    /// </summary>
    REPLAY,
  }

  // 设置窗口工作模式输入参数
  public struct NET_IN_WM_SET_WORK_MODE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Output channel no. or cubeless video wall virtual channel no., when pszCompositeID is NULL. valid
    /// 输出通道号或融合屏虚拟通道号, pszCompositeID为NULL时有效
    /// </summary>
    public int nChannel;
    /// <summary>
    /// Cubeless video wall ID
    /// 融合屏ID
    /// </summary>
    public IntPtr pszCompositeID;
    /// <summary>
    /// Window no.
    /// 窗口号
    /// </summary>
    public int nWindow;
    /// <summary>
    /// Window working mode
    /// 窗口工作模式
    /// </summary>
    public EM_NET_WM_WORK_MODE emMode;
  }

  /// <summary>
  /// Set window working mode output parameter
  /// 设置窗口工作模式输出参数
  /// </summary>
  public struct NET_OUT_WM_SET_WORK_MODE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// player type
  /// 播放器类型
  /// </summary>
  public enum EM_NET_SPLIT_PLAYER_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// file list player
    /// 文件列表播放器
    /// </summary>
    FILE_LIST,
    /// <summary>
    /// file player
    /// 文件播放器
    /// </summary>
    FILE,
  }

  /// <summary>
  /// Get player actual input parameter
  /// 获取播放器实例输入参数
  /// </summary>
  public struct NET_IN_SPLIT_GET_PLAYER
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// output channel no. or cubeless video wall virtual channel no., pszCompositeID is NULL is valid
    /// 输出通道号或融合屏虚拟通道号, pszCompositeID为NULL时有效
    /// </summary>
    public int nChannel;
    /// <summary>
    /// cubeless video wall ID
    /// 融合屏ID
    /// </summary>
    public IntPtr pszCompositeID;
    /// <summary>
    /// player type 
    /// 播放器类型
    /// </summary>
    public EM_NET_SPLIT_PLAYER_TYPE emType;
    /// <summary>
    /// player window no.
    /// 播放器所在的窗口号
    /// </summary>
    public int nWindow;
  }

  /// <summary>
  /// Get player actual output parameter
  /// 获取播放器实例输出参数
  /// </summary>
  public struct NET_OUT_SPLIT_GET_PLAYER
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// player actual ID
    /// 播放器实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }


  /// <summary>
  /// split window play operaton type 
  /// 分割窗口播放操作类型
  /// </summary>
  public enum EM_NET_PLAYER_OPERATE_TYPE
  {
    /// <summary>
    /// open playuer,NET_IN_PLAYER_OPEN
    /// 打开播放器，NET_IN_PLAYER_OPEN
    /// </summary>
    OPEN,
    /// <summary>
    /// close player,NET_IN_PLAYER_CLOSE
    /// 关闭播放器，NET_IN_PLAYER_CLOSE
    /// </summary>
    CLOSE,
    /// <summary>
    /// start play,NET_IN_PLAYER_START
    /// 开始播放，NET_IN_PLAYER_START
    /// </summary>
    START,
    /// <summary>
    /// stop play,NET_IN_PLAYER_STOP
    /// 停止播放，NET_IN_PLAYER_STOP
    /// </summary>
    STOP,
    /// <summary>
    /// pause/restore play,NET_IN_PLAYER_PAUSE
    /// 暂停/恢复播放，NET_IN_PLAYER_PAUSE
    /// </summary>
    PAUSE,
    /// <summary>
    /// go to specific time play,NET_IN_PLAYER_SEEK_TIME
    /// 跳转到指定时间播放，NET_IN_PLAYER_SEEK_TIME
    /// </summary>
    SEEK_TIME,
    /// <summary>
    /// single frame playback, need to be used after pause,NET_IN_PLAYER_STEP_FRAME
    /// 单帧回放, 需要暂停后使用，NET_IN_PLAYER_STEP_FRAME
    /// </summary>
    STEP_FRAME,
    /// <summary>
    /// take current playback status,NET_IN_PLAYER_GET_STATE
    /// 取当前回放状态，NET_IN_PLAYER_GET_STATE
    /// </summary>
    GET_STATE,
    /// <summary>
    /// Get  current playback time,NET_IN_PLAYER_GET_TIME and NET_OUT_PLAYER_GET_TIME
    /// 获取当前回放时间，NET_IN_PLAYER_GET_TIME与NET_OUT_PLAYER_GET_TIME
    /// </summary>
    GET_TIME,
    /// <summary>
    /// Get play speed,NET_IN_PLAYER_GET_SPEED and NET_OUT_PLAYER_GET_SPEED
    /// 获取播放速度，NET_IN_PLAYER_GET_SPEED与NET_OUT_PLAYER_GET_SPEED
    /// </summary>
    GET_SPEED,
    /// <summary>
    /// Set play speed,NET_IN_PLAYER_SET_SPEED
    /// 设置播放速度，NET_IN_PLAYER_SET_SPEED
    /// </summary>
    SET_SPEED,
    /// <summary>
    /// Get volume,NET_IN_PLAYER_GET_VOLUME and NET_OUT_PLAYER_GET_VOLUME
    /// 获取音量，NET_IN_PLAYER_GET_VOLUME与NET_OUT_PLAYER_GET_VOLUME
    /// </summary>
    GET_VOLUME,
    /// <summary>
    /// Set volume,NET_IN_PLAYER_SET_VOLUME
    /// 设置音量，NET_IN_PLAYER_SET_VOLUME
    /// </summary>
    SET_VOLUME,
    /// <summary>
    /// Get file list,NET_IN_PLAYER_GET_PLAYLIST and NET_OUT_PLAYER_GET_PLAYLIST
    /// 获取文件列表，NET_IN_PLAYER_GET_PLAYLIST与NET_OUT_PLAYER_GET_PLAYLIST
    /// </summary>
    GET_PLAYLIST,
    /// <summary>
    /// Get current file list all period info,NET_IN_PLAYER_GET_PLAYLIST_TS and NET_OUT_PLAYER_GET_PLAYLIST_TS
    /// 获取当前文件列表全部时间段信息，NET_IN_PLAYER_GET_PLAYLIST_TS与NET_OUT_PLAYER_GET_PLAYLIST_TS
    /// </summary>
    GET_PLAYLIST_TS,
  }

  /// <summary>
  /// start  play input parameter
  /// 开始播放输入参数
  /// </summary>
  public struct NET_IN_PLAYER_START
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;                      // 播放实例ID
  }

  /// <summary>
  /// start  play  output parameter
  /// 开始播放输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_START
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// pause /recover  play input parameter
  /// 暂停/恢复播放输入参数
  /// </summary>
  public struct NET_IN_PLAYER_PAUSE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
    /// <summary>
    /// pause or not, TRUE- pause  play , FALSE-recover  play
    /// 是否暂停, TRUE-暂停播放, FALSE-恢复播放
    /// </summary>
    public bool bPause;
  }

  /// <summary>
  /// pause /recover  play  output parameter 
  /// 暂停/恢复播放输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_PAUSE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// set play speedinput parameter
  /// 设置播放速度输入参数
  /// </summary>
  public struct NET_IN_PLAYER_SET_SPEED
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
    /// <summary>
    /// play speed, >0 positive direction  play , <0 direction  play   absolute value means speed, =1 normal speed, >1 quick, <1 slow
    /// 播放速度, >0正向播放, <0方向播放、绝对值表示速度, =1正常速度, >1快放, <1慢放
    /// </summary>
    public float fSpeed;
  }

  /// <summary>
  /// set play speed output parameter
  /// 设置播放速度输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_SET_SPEED
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// stop play input parameter
  /// 停止播放输入参数
  /// </summary>
  public struct NET_IN_PLAYER_STOP
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }

  /// <summary>
  /// stop play  output parameter
  /// 停止播放输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_STOP
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// single frame play input parameter
  /// 单帧播放输入参数
  /// </summary>
  public struct NET_IN_PLAYER_STEP_FRAME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
    /// <summary>
    /// positive direction, TRUE-positive direction, FALSE-negative direction
    /// 是否正向, TRUE-正向, FALSE-反向
    /// </summary>
    public bool bForward;
  }

  /// <summary>
  /// single frame play  output parameter
  /// 单帧播放输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_STEP_FRAME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// go to specific time play input parameter
  /// 跳转到指定时间播放输入参数
  /// </summary>
  public struct NET_IN_PLAYER_SEEK_TIME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
    /// <summary>
    /// go to time
    /// 跳转时间
    /// </summary>
    public NET_TIME stuTime;
  }

  /// <summary>
  /// go to specific time play  output parameter
  /// 跳转到指定时间播放输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_SEEK_TIME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// Get current file list all time period info input parameter
  /// 获取当前文件列表全部时间段信息输入参数
  /// </summary>
  public struct NET_IN_PLAYER_GET_PLAYLIST_TS
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }

  /// <summary>
  /// time period info
  /// 时间段信息
  /// </summary>
  public struct NET_PLAYLIST_TIMESECTION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record event type,  currently have EVENT_ALARM_COMMON, EVENT_ALARM_VIDEOBLIND, EVENT_ALARM_VIDEOLOSS,EVENT_ALARM_MOTIONDETECT, EVENT_ALARM_LOCALALARM
    /// 录像事件类型, 目前有 EVENT_ALARM_COMMON, EVENT_ALARM_VIDEOBLIND, EVENT_ALARM_VIDEOLOSS,EVENT_ALARM_MOTIONDETECT, EVENT_ALARM_LOCALALARM
    /// </summary>
    public int nEvent;
    /// <summary>
    /// Time period info   NET_TSECT
    /// 时间段信息  NET_TSECT
    /// </summary>
    public IntPtr pstuTSs;
    /// <summary>
    /// Time period max number
    /// 时间段最大个数
    /// </summary>
    public uint unMaxTS;
    /// <summary>
    /// Actual returned time period number
    /// 实际返回的时间段个数
    /// </summary>
    public uint unRetTS;
  }

  /// <summary>
  /// Get current file list all time period info output parameters
  /// 获取当前文件列表全部时间段信息输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_GET_PLAYLIST_TS
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record type count
    /// 录像类型数量
    /// </summary>
    public uint dwEventNum;
    /// <summary>
    /// Current playback list time period info
    /// 当前回放列表的时间段信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_PLAYLIST_TIMESECTION[] stuTS;
  }

  /// <summary>
  /// Time period structure
  /// 时间段结构
  /// </summary>                                                   
  public struct NET_TSECT
  {
    /// <summary>
    /// Current record period . Bit means the four Enable functions. From the low bit to the high bit:Motion detection record, alarm record and general record, when Motion detection and alarm happened at the same time can record.used in NET_POS_EVENT_LINK, it means enable;
    /// 当表示录像时间段时,按位表示四个使能,从低位到高位分别表示动检录象、报警录象、普通录象、动检和报警同时发生才录像.当表示布撤防时间段时, 表示使能
    /// </summary>
    public int bEnable;
    /// <summary>
    /// BeginHour
    /// 开始小时
    /// </summary>
    public int iBeginHour;
    /// <summary>
    /// BeginMin
    /// 开始分
    /// </summary>
    public int iBeginMin;
    /// <summary>
    /// BeginSec
    /// 开始秒
    /// </summary>
    public int iBeginSec;
    /// <summary>
    /// EndHour
    /// 结束小时
    /// </summary>
    public int iEndHour;
    /// <summary>
    /// EndMin
    /// 结束分
    /// </summary>
    public int iEndMin;
    /// <summary>
    /// EndSec
    /// 结束秒
    /// </summary>
    public int iEndSec;
  }

  /// <summary>
  /// play status 
  /// 播放状态
  /// </summary>
  public enum EM_NET_PLAYER_STATE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// error occur
    /// 有错误发生
    /// </summary>
    ERROR,
    /// <summary>
    /// ready, may start palyabck
    /// 就绪, 可以开启回放
    /// </summary>
    READING,
    /// <summary>
    /// current file playback stop, only can start playback from beginningart
    /// 当前文件回放停止, 只能从头开始重新回放
    /// </summary>
    STANDBY,
    /// <summary>
    /// running
    /// 运行中
    /// </summary>
    RUNNING,
    /// <summary>
    /// paused , may continue from pause point
    /// 已暂停, 可以从暂停点继续回放
    /// </summary>
    PAUSED,
    /// <summary>
    /// closed, cannot play, must open and enter Reading status again
    /// 已关闭, 无法播放, 必须重新open进入Reading状态后才能回放
    /// </summary>
    CLOSED,
  }

  /// <summary>
  /// search  play status input parameter
  /// 查询播放状态输入参数
  /// </summary>
  public struct NET_IN_PLAYER_GET_STATE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }

  /// <summary>
  /// search  play status  output parameter
  /// 查询播放状态输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_GET_STATE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// status
    /// 状态
    /// </summary>
    public EM_NET_PLAYER_STATE emState;
  }

  /// <summary>
  /// Get  current  playback timeinput parameter
  /// 获取当前回放时间输入参数
  /// </summary>
  public struct NET_IN_PLAYER_GET_TIME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }

  /// <summary>
  /// Get  current  playback time output parameter
  /// 获取当前回放时间输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_GET_TIME
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// current  play time
    /// 当前播放时间
    /// </summary>
    public NET_TIME stuTime;
  }

  /// <summary>
  /// Get  play speed input parameter
  /// 获取播放速度输入参数
  /// </summary>
  public struct NET_IN_PLAYER_GET_SPEED
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
  }

  /// <summary>
  /// Get  play speed output parameter
  /// 获取播放速度输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_GET_SPEED
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play speed, >0 positive direction  play , <0 direction  play   absolute value means speed, =1 nornal speed, >1 quick, <1 slow
    /// 播放速度, >0正向播放, <0方向播放  绝对值表示速度, =1正常速度, >1快放, <1慢放
    /// </summary>
    public float fSpeed;
  }

  /// <summary>
  /// video stream type
  /// 视频码流类型
  /// </summary>
  public enum EM_NET_STREAM_TYPE
  {
    /// <summary>
    /// Others
    /// 其它
    /// </summary>
    ERR,
    /// <summary>
    /// Main
    /// 主码流
    /// </summary>
    MAIN,
    /// <summary>
    /// Extra1
    /// 辅码流1
    /// </summary>
    EXTRA_1,
    /// <summary>
    /// Extra2
    /// 辅码流2
    /// </summary>
    EXTRA_2,
    /// <summary>
    /// Extra3
    /// 辅码流3
    /// </summary>
    EXTRA_3,
    /// <summary>
    /// Snapshot
    /// 抓图码流
    /// </summary>
    SNAPSHOT,
    /// <summary>
    /// Object
    /// 物体流
    /// </summary>
    OBJECT,
    /// <summary>
    /// Auto
    /// 自动选择合适码流
    /// </summary>
    AUTO,
    /// <summary>
    /// Preview
    /// 预览裸数据码流
    /// </summary>
    PREVIEW,
    /// <summary>
    /// No video stream
    /// 无视频码流
    /// </summary>
    NONE,
  }

  /// <summary>
  /// play criteria
  /// 播放条件
  /// </summary>
  public struct NET_PLAYER_OPEN_CONDITION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// point remote device
    /// 指明远端的设备
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDevice;
    /// <summary>
    /// channel no.
    /// 通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// start time
    /// 起始时间
    /// </summary>
    public NET_TIME stuStartTime;
    /// <summary>
    /// end time
    /// 结束时间
    /// </summary>
    public NET_TIME stuEndTime;
    /// <summary>
    /// stream type 
    /// 码流类型
    /// </summary>
    public EM_NET_STREAM_TYPE emStreamType;
    /// <summary>
    /// Event type number
    /// 事件类型个数
    /// </summary>
    public int nEventNum;
    /// <summary>
    /// Event type
    /// 事件类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public int[] nEvent;
  }

  /// <summary>
  /// stream transmission mode
  /// 窗口码流发送模式
  /// </summary>
  public enum EM_SPLIT_TRANS_MODE
  {
    /// <summary>
    /// direct
    /// 直连
    /// </summary>
    DIRECT,
    /// <summary>
    /// transfer
    /// 转发
    /// </summary>
    TRANSFER,
  }

  /// <summary>
  /// remotevice of matrix device connect type
  /// 矩阵前端设备连接方式
  /// </summary>
  public enum EM_SPLIT_CONNECT_TYPE
  {
    /// <summary>
    /// tcp
    /// </summary>
    TCP,
    /// <summary>
    /// udp
    /// </summary>
    UDP,
  }

  /// <summary>
  /// open player input parameter
  /// 打开播放器输入参数
  /// </summary>
  public struct NET_IN_PLAYER_OPEN
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// play example ID
    /// 播放实例ID
    /// </summary>
    public IntPtr lPlayerID;
    /// <summary>
    /// take record from local or remote end, as null represents to take record from local,it is valid when bDeviceInfo is FALSE.if from remote device, need to maintain with NET_PLAYER_OPEN_CONDITION szDevice identical
    /// 指明从本地还是远端取录像, 为null代表从本地取录像,bDeviceInfo为FALSE时有效,如果是从远端设备取,需要保持与NET_PLAYER_OPEN_CONDITION的szDevice一致
    /// </summary>
    public IntPtr pszDevice;
    /// <summary>
    /// search criteria 
    /// 查询条件
    /// </summary>
    public NET_PLAYER_OPEN_CONDITION stuCondition;
    /// <summary>
    /// it means that the "stuDeviceInfo" is valid or not
    /// 表示stuDeviceInfo是否有效
    /// </summary>
    public bool bDeviceInfo;
    /// <summary>
    /// device info, it is valid when bDeviceInfo is TRUE
    /// 设备信息, bDeviceInfo为TRUE时deviceInfo有效
    /// </summary>
    public NET_REMOTE_DEVICE stuDeviceInfo;
    /// <summary>
    /// stream transmission mode
    /// 窗口码流发送模式
    /// </summary>
    public EM_SPLIT_TRANS_MODE emTransferMode;
    /// <summary>
    /// connect type, it is effective when emTransferMode is NET_EM_SPLIT_TRANS_TRANSFER, otherwise using pull stream mode
    /// 矩阵前端设备连接类型, 码流发送模式为转发模式下有效, 直连模式下采用默认拉流方式
    /// </summary>
    public EM_SPLIT_CONNECT_TYPE emConnectType;
    /// <summary>
    /// stream type, it is effective when emTransferMode is NET_EM_SPLIT_TRANS_TRANSFER, and emConnectType is TCP or UDP
    /// 推流方式的码流类型,码流发送模式为转发模式, 并且连接类型为TCP或者UDP时有效
    /// </summary>
    public EM_SRC_PUSHSTREAM_TYPE emPushStream;
  }

  /// <summary>
  /// open player  output parameter
  /// 打开播放器输出参数
  /// </summary>
  public struct NET_OUT_PLAYER_OPEN
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// GetSplitWindowsInfo's interface input param
  /// GetSplitWindowsInfo接口输入参数
  /// </summary>
  public struct NET_IN_SPLIT_GET_WINDOWS
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel
    /// 通道号
    /// </summary>
    public int nChannel;
  }

  /// <summary>
  /// GetSplitWindowsInfo's interface output param
  /// GetSplitWindowsInfo接口输出参数
  /// </summary>
  public struct NET_OUT_SPLIT_GET_WINDOWS
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// windows info
    /// 窗口信息
    /// </summary>
    public NET_BLOCK_COLLECTION stuWindows;
  }

  /// <summary>
  /// areas collection
  /// 区块收藏
  /// </summary>
  public struct NET_BLOCK_COLLECTION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// split mode
    /// 分割模式
    /// </summary>
    public EM_SPLIT_MODE emSplitMode;
    /// <summary>
    /// window info array
    /// 窗口信息数组
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public NET_WINDOW_COLLECTION[] stuWnds;
    /// <summary>
    /// count of window
    /// 窗口数量
    /// </summary>
    public int nWndsCount;
    /// <summary>
    /// favorites name
    /// 收藏夹名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName;
    /// <summary>
    /// The output channel number, including the splicing screen
    /// 输出通道号, 包括拼接屏
    /// </summary>
    public int nScreen;
    /// <summary>
    /// splicing video wall ID
    /// 拼接屏ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szCompositeID;
    /// <summary>
    /// Windows information array pointer, the memory assigned by user. Use when the size of stuWnds array is not enough. 
    /// 窗口信息数组指针, 由用户分配内存. 当stuWnds数组大小不够用时可以使用 NET_WINDOW_COLLECTION
    /// </summary>
    public IntPtr pstuWndsEx;
    /// <summary>
    /// The maximum number of windows, filled by user. pstuWndsEx the muber of the array element.
    /// 最大窗口数量, 用户填写. pstuWndsEx数组的元素个数
    /// </summary>
    public int nMaxWndsCountEx;
    /// <summary>
    /// The number of return windows.
    /// 返回窗口数量
    /// </summary>
    public int nRetWndsCountEx;
  }

  /// <summary>
  /// information window areas
  /// 区块窗口信息
  /// </summary>
  public struct NET_WINDOW_COLLECTION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// window ID
    /// 窗口ID
    /// </summary>
    public int nWindowID;
    /// <summary>
    /// enable
    /// 窗口是否有效
    /// </summary>
    public bool bWndEnable;
    /// <summary>
    /// rect, effect when free split mode
    /// 窗口区域, 自由分割模式下有效
    /// </summary>
    public NET_RECT stuRect;
    /// <summary>
    /// coordinate whether meet the conditions
    /// 坐标是否满足直通条件
    /// </summary>
    public bool bDirectable;
    /// <summary>
    /// z order
    /// 窗口Z次序
    /// </summary>
    public int nZOrder;
    /// <summary>
    /// source enable
    /// 显示源是否有效
    /// </summary>
    public bool bSrcEnable;
    /// <summary>
    /// device ID
    /// 设备ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDeviceID;
    /// <summary>
    /// video channel
    /// 视频通道号
    /// </summary>
    public int nVideoChannel;
    /// <summary>
    /// video stream type
    /// 视频码流类型
    /// </summary>
    public int nVideoStream;
    /// <summary>
    /// audio channel
    /// 音频通道
    /// </summary>
    public int nAudioChannel;
    /// <summary>
    /// audio stream type
    /// 音频码流类型
    /// </summary>
    public int nAudioStream;
    /// <summary>
    /// unique channel
    /// 设备内统一编号的唯一通道号
    /// </summary>
    public int nUniqueChannel;
  }

  /// <summary>
  /// input parameter of interface WindowRegionEnlarge
  /// WindowRegionEnlarge接口输入参数
  /// </summary>
  public struct NET_IN_WINDOW_REGION_ENLARGE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// video out channel or virtual channel
    /// 输出通道号或融合屏虚拟通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// window ID
    /// 窗口ID
    /// </summary>
    public int nWindowID;
    /// <summary>
    /// area of windw magnification, the coordinate system is virtual coodinate system.[0~8192]
    /// 画面放大区域，坐标系为虚拟坐标系，0~8192
    /// </summary>
    public NET_RECT stuRect;
  }

  /// <summary>
  /// out parameter of interface WindowRegionEnlarge
  /// WindowRegionEnlarge接口输出参数
  /// </summary>
  public struct NET_OUT_WINDOW_REGION_ENLARGE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// input parameter of interface WindowEnlargeReduction
  /// WindowEnlargeReduction接口输入参数
  /// </summary>
  public struct NET_IN_WINDOW_ENLARGE_REDUCTION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// video out channel or virtual channel
    /// 输出通道号或融合屏虚拟通道号
    /// </summary>
    public int nChannel;
    /// <summary>
    /// window ID
    /// 窗口ID
    /// </summary>
    public int nWindowID;
  }

  /// <summary>
  /// outparameter of interface WindowEnlargeReduction
  /// WindowEnlargeReduction接口输出参数
  /// </summary>
  public struct NET_OUT_WINDOW_ENLARGE_REDUCTION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// Matrix sub card type. Various setups.
  /// 矩阵子卡类型,多种类型可以组合
  /// </summary>
  [Flags]
  public enum EM_MATRIX_CARD_TYPE
  {
    /// <summary>
    /// main card
    /// 主卡
    /// </summary>
    MAIN = 0x10000000,
    /// <summary>
    /// input card 
    /// 输入卡
    /// </summary>
    INPUT = 0x00000001,
    /// <summary>
    /// output card
    /// 输出卡
    /// </summary>
    OUTPUT = 0x00000002,
    /// <summary>
    /// encode card
    /// 编码卡
    /// </summary>
    ENCODE = 0x00000004,
    /// <summary>
    /// decode card
    /// 解码卡
    /// </summary>
    DECODE = 0x00000008,
    /// <summary>
    /// cascade card
    /// 级联卡
    /// </summary>
    CASCADE = 0x00000010,
    /// <summary>
    /// intelligent card
    /// 智能卡
    /// </summary>
    INTELLIGENT = 0x00000020,
    /// <summary>
    /// alarm card
    /// 报警卡
    /// </summary>
    ALARM = 0x00000040,
    /// <summary>
    /// Hdd Raid Card
    /// 硬Raid卡
    /// </summary>
    RAID = 0x00000080,
    /// <summary>
    /// net decode card
    /// 网络解码卡
    /// </summary>
    NET_DECODE = 0x00000100,
  }

  /// <summary>
  /// Query Conditions Of Traffic Black And White List Account Records 
  /// 交通黑白名单账户记录查询条件
  /// </summary>
  public struct NET_FIND_RECORD_TRAFFICREDLIST_CONDITION
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// License Plate Number
    /// 车牌号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumber;
    /// <summary>
    /// License Plate Number Fuzzy Query 
    /// 车牌号码模糊查询
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumberVague;
    /// <summary>
    /// Offset in the query results of first results returned
    /// 第一个条返回结果在查询结果中的偏移量
    /// </summary>
    public int nQueryResultBegin;
    /// <summary>
    /// Whether support the quick query, TRUE: for quick, quick query time don't wait for all add, delete, change operation is completed. The default is non-quick query 
    /// 是否快速查询, TRUE:为快速,快速查询时不等待所有增、删、改操作完成。默认为非快速查询
    /// </summary>
    public bool bRapidQuery;
  }

  /// <summary>
  /// Information of recorded in transportation black and white list
  /// 交通黑白名单记录信息
  /// </summary>
  public struct NET_TRAFFIC_LIST_RECORD
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Queried Record Number
    /// 之前查询到的记录号
    /// </summary>
    public int nRecordNo;
    /// <summary>
    /// Car Owner's Name
    /// 车主姓名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szMasterOfCar;
    /// <summary>
    /// License Plate Number
    /// 车牌号码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumber;
    /// <summary>
    /// License Plate Type 
    /// 车牌类型
    /// </summary>
    public EM_NET_PLATE_TYPE emPlateType;
    /// <summary>
    /// License Plate Color 
    /// 车牌颜色
    /// </summary>
    public EM_NET_PLATE_COLOR_TYPE emPlateColor;
    /// <summary>
    /// Vehicle Type
    /// 车辆类型
    /// </summary>
    public EM_NET_VEHICLE_TYPE emVehicleType;
    /// <summary>
    /// Car Body Color
    /// 车身颜色
    /// </summary>
    public EM_NET_VEHICLE_COLOR_TYPE emVehicleColor;
    /// <summary>
    /// Start Time 
    /// 开始时间
    /// </summary>
    public NET_TIME stBeginTime;
    /// <summary>
    /// Undo Time
    /// 撤销时间
    /// </summary>
    public NET_TIME stCancelTime;
    /// <summary>
    /// Permission Number
    /// 权限个数
    /// </summary>
    public int nAuthrityNum;
    /// <summary>
    /// Permissions List, White List Only
    /// 权限列表 , 白名单仅有
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public NET_AUTHORITY_TYPE[] stAuthrityTypes;
    /// <summary>
    /// Monitor Type, Black List Only
    /// 布控类型 ,黑名单仅有
    /// </summary>
    public EM_NET_TRAFFIC_CAR_CONTROL_TYPE emControlType;
  }

  /// <summary>
  /// License plate type
  /// 车牌类型
  /// </summary>
  public enum EM_NET_PLATE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// Normal
    /// 蓝牌黑牌
    /// </summary>
    NORMAL,
    /// <summary>
    /// Yellow
    /// 黄牌
    /// </summary>
    YELLOW,
    /// <summary>
    /// DoubleYellow
    /// 双层黄尾牌
    /// </summary>
    DOUBLEYELLOW,
    /// <summary>
    /// Police
    /// 警牌
    /// </summary>
    POLICE,
    /// <summary>
    /// Armed
    /// 武警牌
    /// </summary>
    ARMED,
    /// <summary>
    /// Military
    /// 部队号牌
    /// </summary>
    MILITARY,
    /// <summary>
    /// DoubleMilitary
    /// 部队双层
    /// </summary>
    DOUBLEMILITARY,
    /// <summary>
    /// SAR
    /// 港澳特区号牌
    /// </summary>
    SAR,
    /// <summary>
    /// Trainning
    /// 教练车号牌
    /// </summary>
    TRAINNING,
    /// <summary>
    /// Personal
    /// 个性号牌
    /// </summary>
    PERSONAL,
    /// <summary>
    /// Agri
    /// 农用牌
    /// </summary>
    AGRI,
    /// <summary>
    /// Embassy
    /// 使馆号牌
    /// </summary>
    EMBASSY,
    /// <summary>
    /// Moto
    /// 摩托车号牌
    /// </summary>
    MOTO,
    /// <summary>
    /// Tractor
    /// 拖拉机号牌
    /// </summary>
    TRACTOR,
    /// <summary>
    /// OfficialCar
    /// 公务车
    /// </summary>
    OFFICIALCAR,
    /// <summary>
    /// PersonalCar
    /// 私家车
    /// </summary>
    PERSONALCAR,
    /// <summary>
    /// WarCar
    /// 军用
    /// </summary>
    WARCAR,
    /// <summary>
    /// Other
    /// 其他号牌
    /// </summary>
    OTHER,
    /// <summary>
    /// Civilaviation
    /// 民航号牌
    /// </summary>
    CIVILAVIATION,
    /// <summary>
    /// Black
    /// 黑牌
    /// </summary>
    BLACK,
    /// <summary>
    /// PureNewEnergyMicroCar
    /// 纯电动新能源小车
    /// </summary>
    PURENEWENERGYMICROCAR,
    /// <summary>
    /// MixedNewEnergyMicroCar
    /// 混合新能源小车
    /// </summary>
    MIXEDNEWENERGYMICROCAR,
    /// <summary>
    /// PureNewEnergyLargeCar
    /// 纯电动新能源大车
    /// </summary>
    PURENEWENERGYLARGECAR,
    /// <summary>
    /// MixedNewEnergyLargeCar
    /// 混合新能源大车
    /// </summary>
    MIXEDNEWENERGYLARGECAR,
  }

  /// <summary>
  /// plate color type
  /// 车牌颜色
  /// </summary>
  public enum EM_NET_PLATE_COLOR_TYPE
  {
    /// <summary>
    /// Other
    /// 其他颜色
    /// </summary>
    OTHER,
    /// <summary>
    /// Blue
    /// 蓝色
    /// </summary>
    BLUE,
    /// <summary>
    /// Yellow
    /// 黄色
    /// </summary>
    YELLOW,
    /// <summary>
    /// White
    /// 白色
    /// </summary>
    WHITE,
    /// <summary>
    /// Black
    /// 黑色
    /// </summary>
    BLACK,
    /// <summary>
    /// YellowbottomBlackText
    /// 黄底黑字
    /// </summary>
    YELLOW_BOTTOM_BLACK_TEXT,
    /// <summary>
    /// BluebottomWhiteText
    /// 蓝底白字
    /// </summary>
    BLUE_BOTTOM_WHITE_TEXT,
    /// <summary>
    /// BlackBottomWhiteText
    /// 黑底白字
    /// </summary>
    BLACK_BOTTOM_WHITE_TEXT,
    /// <summary>
    /// ShadowGreen
    /// 渐变绿
    /// </summary>
    SHADOW_GREEN,
    /// <summary>
    /// YellowGreen
    /// 黄绿双拼
    /// </summary>
    YELLOW_GREEN,
  }

  /// <summary>
  /// vehicle type
  /// 车辆类型
  /// </summary>
  public enum EM_NET_VEHICLE_TYPE
  {
    /// <summary>
    /// unknown
    /// 未知类型
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// Motor
    /// 机动车
    /// </summary>
    MOTOR,
    /// <summary>
    /// Non-Motor
    /// 非机动车
    /// </summary>
    NON_MOTOR,
    /// <summary>
    /// Bus
    /// 公交车
    /// </summary>
    BUS,
    /// <summary>
    /// Bicycle
    /// 自行车
    /// </summary>
    BICYCLE,
    /// <summary>
    /// Motorcycle
    /// 摩托车
    /// </summary>
    MOTORCYCLE,
    /// <summary>
    /// UnlicensedMotor
    /// 无牌机动车
    /// </summary>
    UNLICENSEDMOTOR,
    /// <summary>
    /// LargeCar
    /// 大型汽车
    /// </summary>
    LARGECAR,
    /// <summary>
    /// MicroCar
    /// 小型汽车
    /// </summary>
    MICROCAR,
    /// <summary>
    /// EmbassyCar
    /// 使馆汽车
    /// </summary>
    EMBASSYCAR,
    /// <summary>
    /// MarginalCar
    /// 领馆汽车
    /// </summary>
    MARGINALCAR,
    /// <summary>
    /// AreaoutCar
    /// 境外汽车
    /// </summary>
    AREAOUTCAR,
    /// <summary>
    /// ForeignCar
    /// 外籍汽车
    /// </summary>
    FOREIGNCAR,
    /// <summary>
    /// DualTriWheelMotorcycle
    /// 两、三轮摩托车
    /// </summary>
    DUALTRIWHEELMOTORCYCLE,
    /// <summary>
    /// LightMotorcycle
    /// 轻便摩托车
    /// </summary>
    LIGHTMOTORCYCLE,
    /// <summary>
    /// EmbassyMotorcycle
    /// 使馆摩托车
    /// </summary>
    EMBASSYMOTORCYCLE,
    /// <summary>
    /// MarginalMotorcycle
    /// 领馆摩托车
    /// </summary>
    MARGINALMOTORCYCLE,
    /// <summary>
    /// AreaoutMotorcycle
    /// 境外摩托车
    /// </summary>
    AREAOUTMOTORCYCLE,
    /// <summary>
    /// ForeignMotorcycle
    /// 外籍摩托车
    /// </summary>
    FOREIGNMOTORCYCLE,
    /// <summary>
    /// FarmTransmitCar
    /// 农用运输车
    /// </summary>
    FARMTRANSMITCAR,
    /// <summary>
    /// Tractor
    /// 拖拉机
    /// </summary>
    TRACTOR,
    /// <summary>
    /// Trailer
    /// 挂车
    /// </summary>
    TRAILER,
    /// <summary>
    /// CoachCar
    /// 教练汽车
    /// </summary>
    COACHCAR,
    /// <summary>
    /// CoachMotorcycle
    /// 教练摩托车
    /// </summary>
    COACHMOTORCYCLE,
    /// <summary>
    /// TrialCar
    /// 试验汽车
    /// </summary>
    TRIALCAR,
    /// <summary>
    /// TrialMotorcycle
    /// 试验摩托车
    /// </summary>
    TRIALMOTORCYCLE,
    /// <summary>
    /// TemporaryEntryCar
    /// 临时入境汽车
    /// </summary>
    TEMPORARYENTRYCAR,
    /// <summary>
    /// TemporaryEntryMotorcycle
    /// 临时入境摩托车
    /// </summary>
    TEMPORARYENTRYMOTORCYCLE,
    /// <summary>
    /// TemporarySteerCar
    /// 临时行驶车
    /// </summary>
    TEMPORARYSTEERCAR,
    /// <summary>
    /// PassengerCar
    /// 客车
    /// </summary>
    PASSENGERCAR,
    /// <summary>
    /// LargeTruck
    /// 大货车
    /// </summary>
    LARGETRUCK,
    /// <summary>
    /// MidTruck
    /// 中货车
    /// </summary>
    MIDTRUCK,
    /// <summary>
    /// SaloonCar
    /// 轿车
    /// </summary>
    SALOONCAR,
    /// <summary>
    /// Microbus
    /// 面包车
    /// </summary>
    MICROBUS,
    /// <summary>
    /// MicroTruck
    /// 小货车
    /// </summary>
    MICROTRUCK,
    /// <summary>
    /// Tricycle
    /// 三轮车
    /// </summary>
    TRICYCLE,
    /// <summary>
    /// Passerby
    /// 行人
    /// </summary>
    PASSERBY,
  }

  /// <summary>
  /// vehicle color type
  /// 车身颜色
  /// </summary>
  public enum EM_NET_VEHICLE_COLOR_TYPE
  {
    /// <summary>
    /// Other
    /// 其他颜色
    /// </summary>
    OTHER,
    /// <summary>
    /// White
    /// 白色
    /// </summary>
    WHITE,
    /// <summary>
    /// Black
    /// 黑色
    /// </summary>
    BLACK,
    /// <summary>
    /// Red
    /// 红色
    /// </summary>
    RED,
    /// <summary>
    /// Yellow
    /// 黄色
    /// </summary>
    YELLOW,
    /// <summary>
    /// Gray
    /// 灰色
    /// </summary>
    GRAY,
    /// <summary>
    /// Blue
    /// 蓝色
    /// </summary>
    BLUE,
    /// <summary>
    /// Green
    /// 绿色
    /// </summary>
    GREEN,
    /// <summary>
    /// Pink
    /// 粉红色
    /// </summary>
    PINK,
    /// <summary>
    /// Purple
    /// 紫色
    /// </summary>
    PURPLE,
    /// <summary>
    /// Brown
    /// 棕色
    /// </summary>
    BROWN,
  }

  /// <summary>
  /// Authority type
  /// 权限类型
  /// </summary>
  public struct NET_AUTHORITY_TYPE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Permission Types
    /// 权限类型
    /// </summary>
    public EM_NET_AUTHORITY_TYPE emAuthorityType;
    /// <summary>
    /// Permission Enabled
    /// 权限使能
    /// </summary>
    public bool bAuthorityEnable;
  }

  /// <summary>
  /// Authority type
  /// 权限类型
  /// </summary>
  public enum EM_NET_AUTHORITY_TYPE
  {
    /// <summary>
    /// UNKNOWN
    /// 未知
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// OPEN GATE
    /// 开闸权限
    /// </summary>
    OPEN_GATE,
  }

  /// <summary>
  /// control type
  /// 布控类型
  /// </summary>
  public enum EM_NET_TRAFFIC_CAR_CONTROL_TYPE
  {
    /// <summary>
    /// other
    /// 其他
    /// </summary>
    OTHER,
    /// <summary>
    /// OverdueNoCheck
    /// 过期未检
    /// </summary>
    OVERDUE_NO_CHECK,
    /// <summary>
    /// BrigandageCar
    /// 盗抢车辆
    /// </summary>
    BRIGANDAGE_CAR,
    /// <summary>
    /// Breaking
    /// 违章
    /// </summary>
    BREAKING,
    /// <summary>
    /// CausetroubleEscape
    /// 肇事逃逸
    /// </summary>
    CAUSETROUBLE_ESCAPE,
  }

  /// <summary>
  /// operate traffic list
  /// 操作交通列表
  /// </summary>
  public struct NET_IN_OPERATE_TRAFFIC_LIST_RECORD
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Operate Type
    /// 操作类型
    /// </summary>
    public EM_RECORD_OPERATE_TYPE emOperateType;
    /// <summary>
    /// record type to operate (Just NET_RECORD_TRAFFICREDLIST and NET_RECORD_TRAFFICBLACKLIST is valid)
    /// 要操作的记录信息类型（仅NET_RECORD_TRAFFICREDLIST和NET_RECORD_TRAFFICBLACKLIST有效）
    /// </summary>
    public EM_NET_RECORD_TYPE emRecordType;
    /// <summary>
    /// the space application by the user,please refer to emOperateType to ensure corresponding structure,then ensure memory size
    /// 由用户申请内存，参照操作类型emOperateType，得到操作类型对应的结构体，进而确定对应的内存大小
    /// </summary>
    public IntPtr pstOpreateInfo;

  }

  /// <summary>
  /// operate traffic list interface outparamter
  /// 现阶段实现的操作接口中,只有返回nRecordNo的操作,stRetRecord暂时不可用
  /// </summary>
  public struct NET_OUT_OPERATE_TRAFFIC_LIST_RECORD
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record Number
    /// 记录号
    /// </summary>
    public int nRecordNo;
  }

  /// <summary>
  /// 
  /// 黑白名单操作类型
  /// </summary>
  public enum EM_RECORD_OPERATE_TYPE
  {
    /// <summary>
    /// insert NET_INSERT_RECORD_INFO 
    /// 增加记录操作 NET_INSERT_RECORD_INFO
    /// </summary>
    INSERT,
    /// <summary>
    /// update NET_UPDATE_RECORD_INFO
    /// 更新记录操作 NET_UPDATE_RECORD_INFO
    /// </summary>
    UPDATE,
    /// <summary>
    /// delete NET_REMOVE_RECORD_INFO
    /// 删除记录操作 NET_REMOVE_RECORD_INFO
    /// </summary>
    REMOVE,
    MAX,
  }

  /// <summary>
  /// file transmit type
  /// 文件传输类型
  /// </summary>
  public enum EM_FIELTRANSMIT_TYPE
  {
    /// <summary>
    /// Begin sending update file(Corresponding structure NET_DEV_UPGRADE_FILE_INFO)
    /// 开始升级文件上传(对应结构体 NET_DEV_UPGRADE_FILE_INFO)
    /// </summary>
    UPGRADEFILETRANS_START = 0x0000,
    /// <summary>
    /// Send update file
    /// 发送升级文件
    /// </summary>
    UPGRADEFILETRANS_SEND = 0x0001,
    /// <summary>
    /// Stop sending update file
    /// 停止发送升级文件
    /// </summary>
    UPGRADEFILETRANS_STOP = 0x0002,
    /// <summary>
    /// begin to send blackwhite list(Corresponding structure NET_DEV_BLACKWHITE_LIST_INFO)
    /// 开始发送黑白名单(对应结构体 NET_DEV_BLACKWHITE_LIST_INFO)
    /// </summary>
    BLACKWHITETRANS_START = 0x0003,
    /// <summary>
    /// send blackwhite list
    /// 发送黑白名单
    /// </summary>
    BLACKWHITETRANS_SEND = 0x0004,
    /// <summary>
    /// stop to send blackwhite list
    /// 停止发送黑白名单
    /// </summary>
    BLACKWHITETRANS_STOP = 0x0005,
    /// <summary>
    /// blackwhite list load (Corresponding structure NET_DEV_LOAD_BLACKWHITE_LIST_INFO)
    /// 下载黑白名单(对应结构体NET_DEV_LOAD_BLACKWHITE_LIST_INFO)
    /// </summary>
    BLACKWHITE_LOAD = 0x0006,
    /// <summary>
    /// blackwhite list load stop
    /// 停止下载黑白名单
    /// </summary>
    BLACKWHITE_LOAD_STOP = 0x0007,
    /// <summary>
    /// Stop file upload
    /// 停止文件上传
    /// </summary>
    FILETRANS_STOP = 0x002B,
    /// <summary>
    /// Burn File Upload
    /// 刻录文件上传
    /// </summary>
    FILETRANS_BURN = 0x002C,
  }

  /// <summary>
  /// upload black-white list
  /// 黑白名单上传
  /// </summary>
  public struct NET_DEV_BLACKWHITE_LIST_INFO
  {
    /// <summary>
    /// path of file
    /// 黑白名单文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 240)]
    public string szFile;
    /// <summary>
    /// size of upgrade file
    /// 升级文件大小
    /// </summary>
    public int nFileSize;
    /// <summary>
    /// type of file.0-black list,1-white list
    /// 当前文件类型,0-黑名单,1-白名单
    /// </summary>
    public byte byFileType;
    /// <summary>
    /// action,0-overload,1-additional
    /// 动作,0-覆盖,1-追加
    /// </summary>
    public byte byAction;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 126)]
    public byte[] byReserved;
  }

  /// <summary>
  /// download black-white list
  /// 黑白名单下载
  /// </summary>
  public struct NET_DEV_LOAD_BLACKWHITE_LIST_INFO
  {
    /// <summary>
    /// path of file
    /// 黑白名单文件保存路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 240)]
    public string szFile;
    /// <summary>
    /// type of file,0-black list,1-white of list
    /// 当前文件类型,0-黑名单,1-白名单
    /// </summary>
    public byte byFileType;
    /// <summary>
    /// reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 127)]
    public byte[] byReserved;
  }

  public struct NET_INSERT_RECORD_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record the content information,the space application by the user,apply to sizeof(NET_TRAFFIC_LIST_RECORD)
    /// 记录内容信息,由用户分配内存，大小为sizeof(NET_TRAFFIC_LIST_RECORD)  
    /// </summary>
    public IntPtr pRecordInfo;
  }

  public struct NET_UPDATE_RECORD_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Record the content information,the space application by the user,apply to sizeof(NET_TRAFFIC_LIST_RECORD)
    /// 记录内容信息,由用户分配内存，大小为sizeof(NET_TRAFFIC_LIST_RECORD) 
    /// </summary>
    public IntPtr pRecordInfo;
  }

  public struct NET_REMOVE_RECORD_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Queried Record Number
    /// 之前查询到的记录号
    /// </summary>
    public int nRecordNo;
  }

  /// <summary>
  /// User info list
  /// 用户信息表
  /// </summary>
  public struct NET_USER_MANAGE_INFO_NEW
  {
    public uint dwSize;
    /// <summary>
    /// Rights info
    /// 权限信息
    /// </summary>
    public uint dwRightNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public NET_OPR_RIGHT_NEW[] rightList;
    public uint dwGroupNum;
    /// <summary>
    /// User group info
    /// 用户组信息,此参数废弃,请使用groupListEx
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_USER_GROUP_INFO_NEW[] groupList;
    /// <summary>
    /// User info
    /// 用户信息
    /// </summary>
    public uint dwUserNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 200)]
    public NET_USER_INFO_NEW[] userList;
    /// <summary>
    /// Sub mask; 0x00000001 - Support account reusable,0x00000002 - Verification needed when change password
    /// 掩码；0x00000001 - 支持用户复用,0x00000002 - 密码修改需要校验
    /// </summary>
    public uint dwFouctionMask;
    /// <summary>
    /// Max user name length supported
    /// 支持的用户名最大长度
    /// </summary>
    public byte byNameMaxLength;
    /// <summary>
    /// Max password length supported
    /// 支持的密码最大长度
    /// </summary>
    public byte byPSWMaxLength;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 254)]
    public byte[] byReserve;
    /// <summary>
    /// User Group Information Expand
    /// 用户组信息扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_USER_GROUP_INFO_EX2[] groupListEx;
  }

  /// <summary>
  /// Rights info
  /// 权限信息
  /// </summary>
  public struct NET_OPR_RIGHT_NEW
  {
    public uint dwSize;
    public uint dwID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string name;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string memo;

    public override string ToString()
    {
      return name;
    }
  }

  /// <summary>
  /// User group info
  /// 用户组信息
  /// </summary>
  public struct NET_USER_GROUP_INFO_NEW
  {
    public uint dwSize;
    public uint dwID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string name;
    public uint dwRightNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public uint[] rights;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string memo;
  }

  /// <summary>
  /// User info
  /// 用户信息
  /// </summary>
  public struct NET_USER_INFO_NEW
  {
    public uint dwSize;
    public uint dwID;
    public uint dwGroupID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string name;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string passWord;
    public uint dwRightNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public uint[] rights;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string memo;
    /// <summary>
    /// Sub mask,0x00000001 - Support account reusable
    /// 掩码,0x00000001 - 支持用户复用
    /// </summary>
    public uint dwFouctionMask;
    /// <summary>
    /// Last Revise Time
    /// 最后修改时间
    /// </summary>
    public NET_TIME stuTime;
    /// <summary>
    /// Whether Can Be Anonymous Login,0=Can't Be Anonymous Login,1=Can be Anonymous Login
    /// 是否可以匿名登录, 0:不可匿名登录, 1: 可以匿名登录
    /// </summary>
    public byte byIsAnonymous;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7)]
    public byte[] byReserve;

    public override string ToString()
    {
      return name;
    }
  }

  /// <summary>
  /// user group information expand,user group lengthen
  /// 用户组信息扩展,用户组名加长
  /// </summary>
  public struct NET_USER_GROUP_INFO_EX2
  {
    public uint dwSize;
    public uint dwID;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string name;
    public uint dwRightNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public uint[] rights;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string memo;

    public override string ToString()
    {
      return name;
    }
  }

  /// <summary>
  /// operate user type
  /// 操作用户类型
  /// </summary>
  public enum EM_OPERATE_USER_TYPE
  {
    ADD_USER_GROUP = 0,
    DEL_USER_GROUP,
    MODIFY_USER_GROUP,
    ADD_USER,
    DEL_USER,
    MODIFY_USER,
    MODIFY_PASSWORD,
  }


  public struct DEVICE_NET_INFO_EX
  {
    /// <summary>
    /// 4 for IPV4, 6 for IPV6
    /// 4 for IPV4, 6 for IPV6
    /// </summary>
    public int iIPVersion;
    /// <summary>
    /// IP IPV4 like"192.168.0.1" IPV6 like "2008::1/64"
    /// IP IPV4形如"192.168.0.1" IPV6形如"2008::1/64"
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szIP;
    /// <summary>
    /// port
    /// tcp端口
    /// </summary>
    public int nPort;
    /// <summary>
    /// Subnet mask(IPV6 do not have subnet mask)
    /// 子网掩码 IPV6无子网掩码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szSubmask;
    /// <summary>
    /// Gateway
    /// 网关
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGateway;
    /// <summary>
    /// MAC address
    /// MAC地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string szMac;
    /// <summary>
    /// Device type
    /// 设备类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDeviceType;
    /// <summary>
    /// device manufactory, see EM_IPC_TYPE
    /// 目标设备的生产厂商,具体参考EM_IPC_TYPE类
    /// </summary>
    public byte byManuFactory;
    /// <summary>
    /// 1-Standard definition 2-High definition
    /// 1-标清 2-高清
    /// </summary>
    public byte byDefinition;
    /// <summary>
    /// Dhcp, true-open, false-close
    /// Dhcp使能状态, true-开, false-关
    /// </summary>
    public byte bDhcpEn;
    /// <summary>
    /// reserved
    /// 字节对齐
    /// </summary>
    public byte byReserved1;
    /// <summary>
    /// ECC data 
    /// 校验数据 通过异步搜索回调获取(在修改设备IP时会用此信息进行校验)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 88)]
    public string verifyData;
    /// <summary>
    /// serial number
    /// 序列号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szSerialNo;
    /// <summary>
    /// device software version    
    /// 设备软件版本号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDevSoftVersion;
    /// <summary>
    /// device detail type
    /// 设备型号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDetailType;
    /// <summary>
    /// OEM type
    /// OEM客户类型
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szVendor;
    /// <summary>
    /// device name
    /// 设备名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevName;
    /// <summary>
    /// user name for log in device(it need be filled when modify device ip)
    /// 登陆设备用户名（在修改设备IP时需要填写）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szUserName;
    /// <summary>
    /// password for log in device(it need be filled when modify device ip)
    /// 登陆设备密码（在修改设备IP时需要填写）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPassWord;
    /// <summary>
    /// HTTP server port
    /// HTTP服务端口号
    /// </summary>
    public ushort nHttpPort;
    /// <summary>
    /// count of video input channel
    /// 视频输入通道数
    /// </summary>
    public ushort wVideoInputCh;
    /// <summary>
    /// count of remote video input
    /// 远程视频输入通道数
    /// </summary>
    public ushort wRemoteVideoInputCh;
    /// <summary>
    /// count of video output channel 
    /// 视频输出通道数
    /// </summary>
    public ushort wVideoOutputCh;
    /// <summary>
    /// count of alarm input
    /// 报警输入通道数
    /// </summary>
    public ushort wAlarmInputCh;
    /// <summary>
    /// count of alarm output
    /// 报警输出通道数
    /// </summary>
    public ushort wAlarmOutputCh;
    /// <summary>
    /// TRUE:szNewPassWord Enable
    /// TRUE使用新密码字段szNewPassWord
    /// </summary>
    public bool bNewWordLen;
    /// <summary>
    /// password for log in device(it need be filled when modify device ip)
    /// 登陆设备密码（在修改设备IP时需要填写）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szNewPassWord;
    /// <summary>
    /// init status
    /// bit0~1：0-old device, can not be init; 1-not init; 2-already init
    /// bit2~3：0-old device,reserved; 1-connect to public network disable; 2-connect to public network enable
    /// bit4~5：0-old device,reserved; 1-connect to cellphone disable; 2-connect to cellphone enable
    /// 设备初始化状态，按位确定初始化状态
    /// bit0~1：0-老设备，没有初始化功能 1-未初始化账号 2-已初始化账户
    /// bit2~3：0-老设备，保留 1-公网接入未使能 2-公网接入已使能
    /// bit4~5：0-老设备，保留 1-手机直连未使能 2-手机直连使能
    /// </summary>
    public byte byInitStatus;
    /// <summary>
    /// the way supported for reset password:make sense when the device is init
    /// bit0-support reset password by cellphone; bit1-support reset password by mail
    /// 支持密码重置方式：按位确定密码重置方式，只在设备有初始化账号时有意义
    /// bit0-支持预置手机号 bit1-支持预置邮箱 
    /// </summary>
    public byte byPwdResetWay;
    /// <summary>
    /// special ability of device ,high eight bit, bit0-2D Code:0 support  1 no support, bit1-PN:0 support  1 no support
    /// 设备初始化能力，按位确定初始化能力,高八位 bit0-2D Code修改IP: 0 不支持 1 支持, bit1-PN制:0 不支持 1支持
    /// </summary>						
    public byte bySpecialAbility;
    /// <summary>
    /// device detail type 
    /// 设备型号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szNewDetailType;
    /// <summary>
    /// TRUE:szNewUserName enable
    /// TRUE表示使用新用户名(szNewUserName)字段
    /// </summary>
    public bool bNewUserName;
    /// <summary>
    /// new user name for login device(it need be filled when modify device ip)
    /// 登陆设备用户名（在修改设备IP时需要填写）
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szNewUserName;
    /// <summary>
    /// reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 41)]
    public byte[] cReserved;
  }

  /// <summary>
  /// DownloadRemoteFile    Interface Input Parameters (the file download)
  /// DownloadRemoteFile 接口输入参数(文件下载)
  /// </summary>
  public struct NET_IN_DOWNLOAD_REMOTE_FILE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// File Name Needs to Download
    /// 需要下载的文件名
    /// </summary>
    public IntPtr pszFileName;
    /// <summary>
    /// File Path
    /// 存放文件路径
    /// </summary>
    public IntPtr pszFileDst;
  }

  /// <summary>
  /// DownloadRemoteFile Interface Output Parameters (the file download) 
  /// DownloadRemoteFile 接口输出参数(文件下载)
  /// </summary>
  public struct NET_OUT_DOWNLOAD_REMOTE_FILE
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// Input parameters of interface DoFindFaceRecognitionRecordEx
  /// DoFindFaceRecognitionRecordEx 输入参数(对应的开始识别人脸多通道查询)
  /// </summary>
  public struct NET_IN_DOFIND_FACERECONGNITIONRECORD_EX
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// The count of needs to be obtained each time
    /// 查询条件的记录个数,-1表示总条数未生成,要推迟获取使用AttachFaceFindState接口状态
    /// </summary>
    public int nTotalCount;
    /// <summary>
    /// Query handle
    /// 查询句柄
    /// </summary>
    public IntPtr lFindHandle;
    /// <summary>
    /// The begin number, it means that start query record from beginNumber, and get nTotalCount records
    /// 查询起始序号，表示从beginNumber条记录开始，取count条记录返回；
    /// </summary>
    public int nBeginNumber;
  }

  /// <summary>
  /// Face Recognition data
  /// 人脸识别信息数据扩展
  /// </summary>
  public struct NET_DOFIND_FACERECONGNITIONRECORD_INFO_EX
  {
    /// <summary>
    /// Dose the global scene picture exist
    /// 全景图是否存在
    /// </summary>
    public bool bGlobalScenePic;
    /// <summary>
    /// The path of the global scene picture
    /// 全景图片文件路径
    /// </summary>
    public NET_PIC_INFO stGlobalScenePic;
    /// <summary>
    /// The target face object information
    /// 目标人脸物体信息
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// The target face file path
    /// 目标人脸文件路径
    /// </summary>
    public NET_PIC_INFO stObjectPic;
    /// <summary>
    /// Face Matching the current number of candidates
    /// 当前人脸匹配到的候选对象数量
    /// </summary>
    public int nCandidateNum;
    /// <summary>
    /// Face candidates to match this informatio
    /// 当前人脸匹配到的候选对象信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDATE_INFOEX[] stuCandidates;
    /// <summary>
    /// The current face matching candidates to the image file path
    /// 当前人脸匹配到的候选对象图片文件路径
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
    public NET_CANDIDAT_PIC_PATHS_EX[] stuCandidatesPic;
    /// <summary>
    /// Time for an alarm
    /// 报警发生时间
    /// </summary>
    public NET_TIME stTime;
    /// <summary>
    /// Place for an alarm
    /// 报警发生地点
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAddress;
    /// <summary>
    /// Channel no 
    /// 通道号
    /// </summary>
    public int nChannelId;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 244)]
    public byte[] bReserved;
  }

  public struct NET_CANDIDAT_PIC_PATHS_EX
  {
    /// <summary>
    /// actual file amount
    /// 实际文件个数
    /// </summary>
    public int nFileCount;
    /// <summary>
    /// file information
    /// 文件信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public NET_PIC_INFO[] stFiles;
    /// <summary>
    /// reserved
    /// 保留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] bReserved;
  }

  /// <summary>
  /// Output parameters of interface DoFindFaceRecognitionRecordEx
  /// DoFindFaceRecognitionRecordEx 输出参数(对应的开始识别人脸多通道查询)
  /// </summary>
  public struct NET_OUT_DOFIND_FACERECONGNITIONRECORD_EX
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Face recongnition data returned(the memory is applied and released by user)
    /// 返回的人脸识别信息数据(内存申请释放由用户管理) 对应该结构体NET_DOFIND_FACERECONGNITIONRECORD_INFO_EX数组
    /// </summary>
    public IntPtr pstResults;
    /// <summary>
    /// The number of memory applications for face recognition information
    /// 申请的人脸识别信息的内存个数
    /// </summary>
    public int nMaxResultNum;
    /// <summary>
    /// Actual number of returns
    /// 实际返回个数
    /// </summary>
    public int nRetResultNum;
  }

  /// <summary>
  /// input parameter of FaceRecognitionPutDisposition
  /// FaceRecognitionPutDisposition 接口输入参数
  /// </summary>
  public struct NET_IN_FACE_RECOGNITION_PUT_DISPOSITION_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// group ID
    /// 人员组ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
    /// <summary>
    /// count of disposition channels
    /// 布控视频通道个数
    /// </summary>
    public int nDispositionChnNum;
    /// <summary>
    /// info of disposition channels
    /// 布控视频通道信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public NET_DISPOSITION_CHANNEL_INFO[] stuDispositionChnInfo;
  }

  /// <summary>
  /// info of disposition channel
  /// 布控的视频通道信息
  /// </summary>
  public struct NET_DISPOSITION_CHANNEL_INFO
  {
    /// <summary>
    /// channel ID
    /// 视频通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// similary, 0-100
    /// 相似度阈值, 0-100
    /// </summary>
    public int nSimilary;
    /// <summary>
    /// Reserved
    /// 保留
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] bReserved;
  }

  /// <summary>
  /// output parameter of FaceRecognitionPutDisposition
  /// FaceRecognitionPutDisposition 接口输出参数
  /// </summary>
  public struct NET_OUT_FACE_RECOGNITION_PUT_DISPOSITION_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// the result count
    /// 通道布控结果个数
    /// </summary>
    public int nReportCnt;
    /// <summary>
    /// the result, TRUE-success, FALSE-failed
    /// 通道布控结果, TRUE追加成功, FALSE追加失败
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public bool[] bReport;
  }

  /// <summary>
  /// input parameter ofFaceRecognitionDelDisposition
  /// FaceRecognitionDelDisposition 接口输入参数
  /// </summary>
  public struct NET_IN_FACE_RECOGNITION_DEL_DISPOSITION_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// group ID
    /// 人员组ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szGroupId;
    /// <summary>
    /// the count of disposition channels
    /// 撤控视频通道个数
    /// </summary>
    public int nDispositionChnNum;
    /// <summary>
    /// the list of disposition channels
    /// 撤控视频通道列表
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public int[] nDispositionChn;
  }

  /// <summary>
  /// output parameter of FaceRecognitionDelDisposition
  /// FaceRecognitionDelDisposition 接口输出参数
  /// </summary>
  public struct NET_OUT_FACE_RECOGNITION_DEL_DISPOSITION_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// the result count
    /// 通道布控结果个数
    /// </summary>
    public int nReportCnt;
    /// <summary>
    /// the result, TRUE-success, FALSE-falied
    /// 通道布控结果, TRUE删除成功, FALSE删除失败
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public bool[] bReport;
  }

  /// <summary>
  /// alarm of face info collect. (Corresponding to event NET_ALARM_FACEINFO_COLLECT_INFO)
  /// 事件类型NET_ALARM_FACEINFO_COLLECT (人脸信息录入事件)对应的数据块描述信息
  /// </summary>
  public struct NET_ALARM_FACEINFO_COLLECT_INFO
  {
    /// <summary>
    /// Event operation. 1=start. 2=stop
    /// 事件动作,1表示持续性事件开始,2表示持续性事件结束;
    /// </summary>
    public int nAction;
    /// <summary>
    /// Event occurrence time 
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX stuTime;
    /// <summary>
    /// Time stamp (Unit is ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double dbPTS;
    /// <summary>
    /// user ID
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// Reserved
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] byReserved;
  }

  /// <summary>
  /// authority
  /// 用户权限
  /// </summary>
  public enum EM_ATTENDANCE_AUTHORITY
  {
    /// <summary>
    /// UnKnow
    /// 未知
    /// </summary>
    UnKnown = -1,
    /// <summary>
    /// customer
    /// 普通用户
    /// </summary>
    Customer,
    /// <summary>
    /// administrators
    /// 管理员
    /// </summary>
    Administrators
  }

  /// <summary>
  /// attendance user info
  /// 考勤用户信息
  /// </summary>
  public struct NET_ATTENDANCE_USERINFO
  {
    /// <summary>
    /// user id  
    /// 用户编号ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// username
    /// 人员姓名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 36)]
    public string szUserName;
    /// <summary>
    /// card no
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// authority
    /// 用户权限
    /// </summary>
    public EM_ATTENDANCE_AUTHORITY emAuthority;
    /// <summary>
    /// password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPassword;
    /// <summary>
    /// photo data len
    /// 照片数据长度
    /// </summary>
    public int nPhotoLength;
    /// <summary>
    /// reserved bytes
    /// 保留字节
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] byReserved;
  }

  /// <summary>
  /// CLIENT_Attendance_AddUser  input parameter
  /// CLIENT_Attendance_AddUser 入参
  /// </summary>
  public struct NET_IN_ATTENDANCE_ADDUSER
  {
    public uint dwSize;
    /// <summary>
    /// user info
    /// 用户信息
    /// </summary>
    public NET_ATTENDANCE_USERINFO stuUserInfo;
    /// <summary>
    /// photo data
    /// 照片数据
    /// </summary>
    public IntPtr pbyPhotoData;
  };

  /// <summary>
  /// CLIENT_Attendance_AddUser output parameter
  /// CLIENT_Attendance_AddUser出参
  /// </summary>
  public struct NET_OUT_ATTENDANCE_ADDUSER
  {
    public uint dwSize;
  }

  /// <summary>
  /// CLIENT_Attendance_DelUser input parameter
  /// CLIENT_Attendance_DelUser 入参
  /// </summary>
  public struct NET_IN_ATTENDANCE_DELUSER
  {
    public uint dwSize;
    /// <summary>
    /// userid
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// CLIENT_Attendance_DelUser output parameter
  /// CLIENT_Attendance_DelUser出参
  /// </summary>
  public struct NET_OUT_ATTENDANCE_DELUSER
  {
    public uint dwSize;
  }

  /// <summary>
  /// CLIENT_Attendance_ModifyUser  input parameter
  /// CLIENT_Attendance_ModifyUser 入参
  /// </summary>
  public struct NET_IN_ATTENDANCE_ModifyUSER
  {
    public uint dwSize;
    /// <summary>
    /// user info
    /// 用户信息
    /// </summary>
    public NET_ATTENDANCE_USERINFO stuUserInfo;
    /// <summary>
    /// photo data
    /// 照片数据
    /// </summary>
    public IntPtr pbyPhotoData;
  }

  /// <summary>
  /// CLIENT_Attendance_ModifyUser output parameter
  /// CLIENT_Attendance_ModifyUser出参
  /// </summary>
  public struct NET_OUT_ATTENDANCE_ModifyUSER
  {
    public uint dwSize;
  }

  /// <summary>
  /// CLIENT_Attendance_GetUser  input parameter
  /// CLIENT_Attendance_GetUser 入参
  /// </summary>
  public struct NET_IN_ATTENDANCE_GetUSER
  {
    public uint dwSize;
    /// <summary>
    /// userid
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// CLIENT_Attendance_GetUser output parameter
  /// CLIENT_Attendance_GetUser出参
  /// </summary>
  public struct NET_OUT_ATTENDANCE_GetUSER
  {
    public uint dwSize;
    /// <summary>
    /// user info 
    /// 用户信息
    /// </summary>
    public NET_ATTENDANCE_USERINFO stuUserInfo;
    /// <summary>
    /// max photo data len
    /// 最大存放照片数据的长度
    /// </summary>
    public int nMaxLength;
    /// <summary>
    /// photo data
    /// 照片数据
    /// </summary>
    public IntPtr pbyPhotoData;
  }

  /// <summary>
  /// CLIENT_Attendance_FindUser input parameter
  /// CLIENT_Attendance_FindUser 入参
  /// </summary>
  public struct NET_IN_ATTENDANCE_FINDUSER
  {
    public uint dwSize;
    /// <summary>
    /// query offset
    /// 查询偏移
    /// </summary>
    public int nOffset;
    /// <summary>
    /// query count，paged query，No more than 100
    /// 查询个数，分页查询，最多不超过100
    /// </summary>
    public int nPagedQueryCount;
  }

  /// <summary>
  /// CLIENT_Attendance_FindUser output parameter
  /// CLIENT_Attendance_FindUser 出参
  /// </summary>
  public struct NET_OUT_ATTENDANCE_FINDUSER
  {
    public uint dwSize;
    /// <summary>
    /// the total of users.
    /// 总的用户数
    /// </summary>
    public int nTotalUser;
    /// <summary>
    /// max number of user infors
    /// 用户信息最大缓存数
    /// </summary>
    public int nMaxUserCount;
    /// <summary>
    /// user information; alloc memory by user, size is (sizeof(NET_ATTENDANCE_USERINFO)*nMaxUserCount) 
    /// 用户信息
    /// </summary>
    public IntPtr stuUserInfo;
    /// <summary>
    /// returned user infor counts.
    /// 实际返回的用户个数
    /// </summary>
    public int nRetUserCount;
    /// <summary>
    /// max photo data len
    /// 照片数据最大长度
    /// </summary>
    public int nMaxPhotoDataLength;
    /// <summary>
    /// returned length of photo data
    /// 实际返回的照片数据长度
    /// </summary>
    public int nRetPhoteLength;
    /// <summary>
    /// photo data
    /// 照片数据
    /// </summary>
    public IntPtr pbyPhotoData;
  }

  //考勤状态
  public enum EM_ATTENDANCESTATE
  {
    UNKNOWN,
    SIGNIN,                    //签入
    GOOUT,                     //外出
    GOOUT_AND_RETRUN,          //外出归来
    SIGNOUT,                   // 签出
    WORK_OVERTIME_SIGNIN,      // 加班签到
    WORK_OVERTIME_SIGNOUT,     // 加班签出
  }
  /// <summary>
  /// Corresponding data description info of event type EVENT_IVS_ACCESS_CTL (Access control info event) 
  /// 事件类型 EVENT_IVS_ACCESS_CTL(门禁事件)对应数据块描述信息
  /// </summary>
  public struct NET_DEV_EVENT_ACCESS_CTL_INFO
  {
    /// <summary>
    /// Door Channel Number
    /// 门通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Entrance Guard Name
    /// 事件名称
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szName;
    /// <summary>
    /// Align byte 
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;
    /// <summary>
    /// Time stamp (Unit:ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// Event occurrence time 
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID 
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// have being detected object
    /// 检测到的物体
    /// </summary>
    public NET_MSG_OBJECT stuObject;
    /// <summary>
    /// The corresponding file info of the event
    /// 事件对应文件信息
    /// </summary>
    public NET_EVENT_FILE_INFO stuFileInfo;
    /// <summary>
    /// Entrance Guard Event Type
    /// 门禁事件类型
    /// </summary>
    public EM_ACCESS_CTL_EVENT_TYPE emEventType;
    /// <summary>
    /// Swing Card Result,True is Success,False is Fail
    /// 刷卡结果,TRUE表示成功,FALSE表示失败
    /// </summary>
    public bool bStatus;
    /// <summary>
    /// Card Type
    /// 卡类型
    /// </summary>
    public EM_ACCESSCTLCARD_TYPE emCardType;
    /// <summary>
    /// Open The Door Method
    /// 开门方式
    /// </summary>
    public EM_ACCESS_DOOROPEN_METHOD emOpenMethod;
    /// <summary>
    /// Card Number
    /// 卡号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCardNo;
    /// <summary>
    /// Password
    /// 密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPwd;
    /// <summary>
    /// Reader ID
    /// 门读卡器ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szReaderID;
    /// <summary>
    /// unlock user
    /// 开门用户
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szUserID;
    /// <summary>
    /// snapshot picture storage address
    /// 抓拍照片存储地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szSnapURL;
    /// <summary>
    /// 
    /// 开门失败的原因,仅在bStatus为FALSE时有效
    /// 0x00 没有错误 0x10 未授权 0x11 卡挂失或注销 0x12 没有该门权限 0x13 开门模式错误 0x14 有效期错误 0x15 防反潜模式 0x17 门常闭状态 0x18 AB互锁状态 0x19 巡逻卡 0x1A 设备处于闯入报警状态 0x20 时间段错误 0x21 假期内开门时间段错误
    /// 0x30 需要先验证有首卡权限的卡片 0x40 卡片正确,输入密码错误 0x41 卡片正确,输入密码超时 0x42 卡片正确,输入指纹错误 0x43 卡片正确,输入指纹超时 0x44 指纹正确,输入密码错误 0x45 指纹正确,输入密码超时 0x50 组合开门顺序错误 0x51 组合开门需要继续验证 0x60 验证通过,控制台未授权
    /// </summary>
    public int nErrorCode;
    /// <summary>
    /// punching record number
    /// 刷卡记录集中的记录编号
    /// </summary>
    public int nPunchingRecNo;
    /// <summary>
    /// picture Numbers
    /// 抓图张数
    /// </summary>
    public int nNumbers;
    /// <summary>
    /// Serial number of the picture, in the same time (accurate to seconds) may have multiple images, starting from 0
    /// 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    /// </summary>
    public byte byImageIndex;
    /// <summary>
    /// Align byte 
    /// 字节对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved;
    /// <summary>
    /// Snap flag(by bit)0 bit:"*",1 bit:"Timing",2 bit:"Manual",3 bit:"Marked",4 bit:"Event",5 bit:"Mosaic",6 bit:"Cutout"
    /// 抓图标志(按位),具体见 NET_RESERVED_COMMON
    /// </summary>
    public uint dwSnapFlagMask;
    /// <summary>
    /// Attendance state 
    /// 考勤状态
    /// </summary>
    public EM_ATTENDANCESTATE emAttendanceState;
    /// <summary>
    /// Class number
    /// 班级
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szClassNumber;
    /// <summary>
    /// Phone number
    /// 电话
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPhoneNumber;
    /// <summary>
    /// Card name
    /// 卡命名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCardName;
    /// <summary>
    /// Reserved string
    /// 保留字节,留待扩展
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 908)]
    public byte[] bReserved;
  }

  /// <summary>
  /// 
  /// CLIENT_Attendance_InsertFingerByUserID 入参
  /// </summary>
  public struct NET_IN_FINGERPRINT_INSERT_BY_USERID
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
    /// <summary>
    /// 
    /// 单个指纹数据包长度
    /// </summary>
    public int nSinglePacketLen;
    /// <summary>
    /// 
    /// 指纹数据包的个数
    /// </summary>
    public int nPacketCount;
    /// <summary>
    /// 
    /// 指纹数据(数据总长度即nSinglePacketLen*nPacketCount)
    /// </summary>
    public IntPtr szFingerPrintInfo;
  }

  /// <summary>
  /// 
  /// Attendance_InsertFingerByUserID 出参
  /// </summary>
  public struct NET_OUT_FINGERPRINT_INSERT_BY_USERID
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 指纹ID数组
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public int[] nFingerPrintID;
    /// <summary>
    /// 
    /// 数组中实际返回的个数
    /// </summary>
    public int nReturnedCount;
    /// <summary>
    /// 
    /// 错误码  0：成功;   1：其他错误;  2：超过本用户下指纹能力的限制.
    /// </summary>
    public int nFailedCode;
  }

  /// <summary>
  /// 
  /// Attendance_RemoveFingerByUserID 入参(removeByUserID)
  /// </summary>
  public struct NET_CTRL_IN_FINGERPRINT_REMOVE_BY_USERID
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// 
  /// Attendance_RemoveFingerByUserID 出参
  /// </summary>
  public struct NET_CTRL_OUT_FINGERPRINT_REMOVE_BY_USERID
  {
    public uint dwSize;
  }

  /// <summary>
  /// 
  /// Attendance_GetFingerByUserID 入参
  /// </summary>
  public struct NET_IN_FINGERPRINT_GETBYUSER
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 用户ID
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;
  }

  /// <summary>
  /// 
  /// Attendance_GetFingerByUserID 出参
  /// </summary>
  public struct NET_OUT_FINGERPRINT_GETBYUSER
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 指纹ID数组
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public int[] nFingerPrintIDs;   // 
    /// <summary>
    /// 
    /// 实际返回的指纹ID个数，即nFingerPrintIDs数组中实际有效个数
    /// </summary>
    public int nRetFingerPrintCount;
    /// <summary>
    /// 
    /// 单个指纹数据包长度
    /// </summary>
    public int nSinglePacketLength;
    /// <summary>
    /// 
    /// 接受指纹数据的缓存的最大长度
    /// </summary>
    public int nMaxFingerDataLength;
    /// <summary>
    /// 
    /// 实际返回的总的指纹数据包的长度
    /// </summary>
    public int nRetFingerDataLength;
    /// <summary>
    /// 
    /// 指纹数据
    /// </summary>
    public IntPtr pbyFingerData;
  }

  /// <summary>
  /// struct SNMP config struct
  /// 设备设备参数
  /// </summary>
  public struct NET_DEVICE_SEARCH_PARAM
  {
    public uint dwSize;
    public bool bUseDefault;
    public ushort wBroadcastLocalPort;
    public ushort wBroadcastRemotePort;
    public ushort wMulticastRemotePort;
  }

  public enum EM_DEVICE_STATE
  {
    /// <summary>
    /// Search general alarm status(including external alarm,video loss, motion detection)
    /// 查询普通报警状态(包括外部报警,视频丢失,动态检测)
    /// </summary>
    COMM_ALARM = 0x0001,
    /// <summary>
    /// Search camera masking alarm status
    /// 查询遮挡报警状态
    /// </summary>
    SHELTER_ALARM = 0x0002,
    /// <summary>
    /// Search record status
    /// 查询录象状态
    /// </summary>
    RECORDING = 0x0003,
    /// <summary>
    /// Search HDD information
    /// 查询硬盘信息  NET_HARDDISK_STATE
    /// </summary>
    DISK = 0x0004,
    /// <summary>
    /// Search system resources status
    /// 查询系统资源状态
    /// </summary>
    RESOURCE = 0x0005,
    /// <summary>
    /// Search channel bit stream 
    /// 查询通道码流
    /// </summary>
    BITRATE = 0x0006,
    /// <summary>
    /// Search device connection status
    /// 查询设备连接状态
    /// </summary>
    CONN = 0x0007,
    /// <summary>
    /// Search network protocol version number , pBuf = int*
    /// 查询网络协议版本号,pBuf = int*
    /// </summary>
    PROTOCAL_VER = 0x0008,
    /// <summary>
    /// Search the audio talk format the device supported. Please refer to structure DHDEV_TALKFORMAT_LIST
    /// 查询设备支持的语音对讲格式列表,见结构体DHDEV_TALKFORMAT_LIST
    /// </summary>
    TALK_ECTYPE = 0x0009,
    /// <summary>
    /// Search SD card information(FOR IPC series)
    /// 查询SD卡信息(IPC类产品)
    /// </summary>
    SD_CARD = 0x000A,
    /// <summary>
    /// Search burner information
    /// 查询刻录机信息
    /// </summary>
    BURNING_DEV = 0x000B,
    /// <summary>
    /// Search burning information
    /// 查询刻录进度
    /// </summary>
    BURNING_PROGRESS = 0x000C,
    /// <summary>
    /// Search the embedded platform the device supported
    /// 查询设备支持的接入平台
    /// </summary>
    PLATFORM = 0x000D,
    /// <summary>
    /// Search camera property information ( for IPC series),pBuf = DHDEV_CAMERA_INFO *,there can be several structure
    /// 查询摄像头属性信息(IPC类产品),pBuf = DHDEV_CAMERA_INFO *,可以有多个结构体
    /// </summary>
    CAMERA = 0x000E,
    /// <summary>
    /// Search device software version information NET_DEV_VERSION_INFO
    /// 查询设备软件版本信息 NET_DEV_VERSION_INFO
    /// </summary>
    SOFTWARE = 0x000F,
    /// <summary>
    /// Search the audio type the device supported 
    /// 查询设备支持的语音种类
    /// </summary>
    LANGUAGE = 0x0010,
    /// <summary>
    /// Search DSP capacity description 
    /// 查询DSP能力描述(对应结构体DHDEV_DSP_ENCODECAP)
    /// </summary>
    DSP = 0x0011,
    /// <summary>
    /// Search OEM information
    /// 查询OEM信息
    /// </summary>
    OEM = 0x0012,
    /// <summary>
    /// Search network running status information
    /// 查询网络运行状态信息
    /// </summary>
    NET = 0x0013,
    /// <summary>
    /// Search function attributes(for IPC serirs)
    /// 查询设备类型
    /// </summary>
    TYPE = 0x0014,
    /// <summary>
    /// Search snapshot function attribute(For IPC series)
    /// 查询功能属性(IPC类产品)
    /// </summary>
    SNAP = 0x0015,
    /// <summary>
    /// Query the first time and the recent video time
    /// 查询最早录像时间和最近录像时间
    /// </summary>
    RECORD_TIME = 0x0016,
    /// <summary>
    /// Query the wireless network signal strength,Please refer to structure DHDEV_WIRELESS_RSS_INFO
    /// 查询无线网络信号强度,见结构体DHDEV_WIRELESS_RSS_INFO
    /// </summary>
    NET_RSSI = 0x0017,
    /// <summary>
    /// Burning options inquiry
    /// 查询附件刻录选项
    /// </summary>
    BURNING_ATTACH = 0x0018,
    /// <summary>
    /// Query the list of backup device
    /// 查询备份设备列表
    /// </summary>
    BACKUP_DEV = 0x0019,
    /// <summary>
    /// Query the backup device information
    /// 查询备份设备详细信息
    /// </summary>
    BACKUP_DEV_INFO = 0x001a,
    /// <summary>
    /// backup rate of progress
    /// 备份进度反馈
    /// </summary>
    BACKUP_FEEDBACK = 0x001b,
    /// <summary>
    /// Query ATM trade type
    /// 查询ATM交易类型
    /// </summary>
    ATM_QUERY_TRADE = 0x001c,
    /// <summary>
    /// Query sip state
    /// 查询sip状态
    /// </summary>
    SIP = 0x001d,
    /// <summary>
    /// Query wifi state of mobile DVR
    /// 查询车载wifi状态
    /// </summary>
    VICHILE_STATE = 0x001e,
    /// <summary>
    /// Query Email Function
    /// 查询邮件配置是否成功
    /// </summary>
    TEST_EMAIL = 0x001f,
    /// <summary>
    /// Query Hard Disk Information
    /// 查询硬盘smart信息
    /// </summary>
    SMART_HARD_DISK = 0x0020,
    /// <summary>
    /// Query Snap Picture Function
    /// 查询抓图设置是否成功
    /// </summary>
    TEST_SNAPPICTURE = 0x0021,
    /// <summary>
    /// Query static alarm state
    /// 查询静态报警状态
    /// </summary>
    STATIC_ALARM = 0x0022,
    /// <summary>
    /// Query submodule information
    /// 查询设备子模块信息
    /// </summary>
    SUBMODULE_INFO = 0x0023,
    /// <summary>
    /// Query hard disk damage ability
    /// 查询硬盘坏道能力
    /// </summary>
    DISKDAMAGE = 0x0024,
    /// <summary>
    /// Query device supported IPC ability,see struct DH_DEV_IPC_INFO 
    /// 查询设备支持的IPC能力, 见结构体DH_DEV_IPC_INFO
    /// </summary>
    IPC = 0x0025,
    /// <summary>
    /// Query alarm arm disarm state
    /// 查询报警布撤防状态
    /// </summary>
    ALARM_ARM_DISARM = 0x0026,
    /// <summary>
    /// Query ACC power off state(return a DWORD type value, 1 means power off,0 means power on)
    /// 查询ACC断电报警状态(返回一个DWORD, 1表示断电,0表示通电)
    /// </summary>
    ACC_POWEROFF_ALARM = 0x0027,
    /// <summary>
    /// FTP server connect test
    /// 测试FTP服务器连接
    /// </summary>
    TEST_FTP_SERVER = 0x0028,
    /// <summary>
    /// Query 3G Flow exceed state info(see struct DHDEV_3GFLOW_EXCEED_STATE_INFO)
    /// 查询3G流量超出阈值状态,(见结构体DHDEV_3GFLOW_EXCEED_STATE_INFO)
    /// </summary>
    DEV_3GFLOW_EXCEED = 0x0029,
    /// <summary>
    /// Query 3G Flow info(see struct DH_DEV_3GFLOW_INFO)
    /// 查询3G网络流量信息,见结构体DH_DEV_3GFLOW_INFO
    /// </summary>
    DEV_3GFLOW_INFO = 0x002a,
    /// <summary>
    /// Vihicle information uploading
    /// 车载自定义信息上传(见结构体ALARM_VEHICLE_INFO_UPLOAD)
    /// </summary>
    VIHICLE_INFO_UPLOAD = 0x002b,
    /// <summary>
    /// Speed limit alarm
    /// 查询限速报警状态(见结构体ALARM_SPEED_LIMIT)
    /// </summary>
    SPEED_LIMIT = 0x002c,
    /// <summary>
    /// Query DSP expended cap(struct DHDEV_DSP_ENCODECAP_EX)
    /// 查询DSP扩展能力描述(对应结构体DHDEV_DSP_ENCODECAP_EX)
    /// </summary>
    DSP_EX = 0x002d,
    /// <summary>
    /// Query 3G module info(struct DH_DEV_3GMODLE_INFO)
    /// 查询3G模块信息(对应结构体DH_DEV_3GMODULE_INFO)
    /// </summary>
    DEV_3GMODULE_INFO = 0x002e,
    /// <summary>
    /// Query multi DDNS status(struct DH_DEV_MULTI_DDNS_INFO)
    /// 查询多DDNS状态信息(对应结构体DH_DEV_MULTI_DDNS_INFO)
    /// </summary>
    MULTI_DDNS = 0x002f,
    /// <summary>
    /// Query Device URL info(struct DH_DEV_URL_INFO)
    /// 查询设备配置URL信息(对应结构体DH_DEV_URL_INFO)
    /// </summary>
    CONFIG_URL = 0x0030,
    /// <summary>
    /// Query Hard key state(struct DHDEV_HARDKEY_STATE)
    /// 查询HardKey状态（对应结构体DHDEV_HARDKEY_STATE)
    /// </summary>
    HARDKEY = 0x0031,
    /// <summary>
    /// Query ISCSI path(struct DHDEV_ISCSI_PATHLIST)
    /// 查询ISCSI路径列表(对应结构体DHDEV_ISCSI_PATHLIST)
    /// </summary>
    ISCSI_PATH = 0x0032,
    /// <summary>
    /// Query local preview split capability(struct DEVICE_LOCALPREVIEW_SLIPT_CAP)
    /// 查询设备本地预览支持的分割模式(对应结构体DEVICE_LOCALPREVIEW_SLIPT_CAP)
    /// </summary>
    DLPREVIEW_SLIPT_CAP = 0x0033,
    /// <summary>
    /// Query wifi capablity(struct DHDEV_WIFI_ROUTE_CAP)
    /// 查询无线路由能力信息(对应结构体DHDEV_WIFI_ROUTE_CAP)
    /// </summary>
    WIFI_ROUTE_CAP = 0x0034,
    /// <summary>
    /// Query device online state(return a DWORD value, 1-online, 0-offline)
    /// 查询设备的在线状态(返回一个DWORD, 1表示在线, 0表示断线)
    /// </summary>
    ONLINE = 0x0035,
    /// <summary>
    /// Query ptz state(struct DH_PTZ_LOCATION_INFO)
    /// 查询云台状态信息(对应结构体 DH_PTZ_LOCATION_INFO)
    /// </summary>
    PTZ_LOCATION = 0x0036,
    /// <summary>
    /// Query monitor state(state DHDEV_MONITOR_INFO)
    /// 画面监控辅助信息(对应结构体DHDEV_MONITOR_INFO)
    /// </summary>
    MONITOR_INFO = 0x0037,
    /// <summary>
    /// Query subdevcie(fan,cpu...) state(struct CFG_DEVICESTATUS_INFO)
    /// 查询子设备(电源, 风扇等)状态(对应结构体CFG_DEVICESTATUS_INFO)
    /// </summary>
    SUBDEVICE = 0x0300,
    /// <summary>
    /// Query RAID state(struct ALARM_RAID_INFO)  
    /// 查询RAID状态(对应结构体ALARM_RAID_INFO)  
    /// </summary>
    RAID_INFO = 0x0038,
    /// <summary>
    /// test DDNS domain enable
    /// 测试DDNS域名是否可用
    /// </summary>
    TEST_DDNSDOMAIN = 0x0039,
    /// <summary>
    /// query virtual camera state(struct NET_VIRTUALCAMERA_STATE_INFO)
    /// 查询虚拟摄像头状态(对应 NET_VIRTUALCAMERA_STATE_INFO)
    /// </summary>
    VIRTUALCAMERA = 0x003a,
    /// <summary>
    /// get device's state of video/coil module(struct DHDEV_TRAFFICWORKSTATE_INFO)
    /// 获取设备工作视频/线圈模式状态等(对应DHDEV_TRAFFICWORKSTATE_INFO)
    /// </summary>
    TRAFFICWORKSTATE = 0x003b,
    /// <summary>
    /// get camera move alarm state(struct ALARM_CAMERA_MOVE_INFO)
    /// 获取摄像机移位报警事件状态(对应ALARM_CAMERA_MOVE_INFO)
    /// </summary>
    ALARM_CAMERA_MOVE = 0x003c,
    /// <summary>
    /// get external alarm(struct NET_CLIENT_ALARM_STATE) 
    /// 获取外部报警状态(对应 NET_CLIENT_ALARM_STATE) 
    /// </summary>
    ALARM = 0x003e,
    /// <summary>
    /// get video loss alarm(struct NET_CLIENT_VIDEOLOST_STATE) 
    /// 获取视频丢失报警状态(对应 NET_CLIENT_VIDEOLOST_STATE)
    /// </summary>
    VIDEOLOST = 0x003f,
    /// <summary>
    /// get motion alarm(struct NET_CLIENT_MOTIONDETECT_STATE)
    /// 获取动态监测报警状态(对应 NET_CLIENT_MOTIONDETECT_STATE)
    /// </summary>
    MOTIONDETECT = 0x0040,
    /// <summary>
    /// get detailed motion alarm(struct NET_CLIENT_DETAILEDMOTION_STATE)
    /// 获取详细的动态监测报警状态(对应 NET_CLIENT_DETAILEDMOTION_STATE)
    /// </summary>
    DETAILEDMOTION = 0x0041,
    /// <summary>
    /// get vehicle device state(struct DHDEV_VEHICLE_INFO)
    /// 获取车载自身各种硬件信息(对应 DHDEV_VEHICLE_INFO)
    /// </summary>
    VEHICLE_INFO = 0x0042,
    /// <summary>
    /// get blind alarm(struct NET_CLIENT_VIDEOBLIND_STATE)
    /// 获取视频遮挡报警状态(对应 NET_CLIENT_VIDEOBLIND_STATE)
    /// </summary>
    VIDEOBLIND = 0x0043,
    /// <summary>
    /// Query 3G state(struct DHDEV_VEHICLE_3GMODULE)
    /// 查询3G模块相关信息(对应结构体DHDEV_VEHICLE_3GMODULE)
    /// </summary>
    DEV_3GSTATE_INFO = 0x0044,
    /// <summary>
    /// Query net interface(struct DHDEV_NETINTERFACE_INFO)
    /// 查询网络接口信息(对应 DHDEV_NETINTERFACE_INFO)
    /// </summary>
    NETINTERFACE = 0x0045,
    /// <summary>
    /// Query picinpic channel(struct DWORD)
    /// 查询画中画通道号(对应DWORD数组)
    /// </summary>
    PICINPIC_CHN = 0x0046,
    /// <summary>
    /// Query splice screen(struct DH_COMPOSITE_CHANNEL)
    /// 查询融合屏通道信息(对应DH_COMPOSITE_CHANNEL数组)
    /// </summary>
    COMPOSITE_CHN = 0x0047,
    /// <summary>
    /// Query whole recording status(struct BOOL),as long as ther is a channel running,it indicates that the overall state
    /// 查询设备整体录像状态(对应BOOL), 只要有一个通道在录像,即为设备整体状态为录像
    /// </summary>
    WHOLE_RECORDING = 0x0048,
    /// <summary>
    /// Query whole encoding(struct BOOL),as long as ther is a channel running,it indicates that the overall state
    /// 查询设备整体编码状态(对应BOOL), 只要有一个通道在编码,即为设备整体状态为编码
    /// </summary>
    WHOLE_ENCODING = 0x0049,
    /// <summary>
    /// Query disk record time(pBuf = DEV_DISK_RECORD_TIME*)
    /// 查询设备硬盘录像时间信息(pBuf = DEV_DISK_RECORD_TIME*,可以有多个结构体)
    /// </summary>
    DISK_RECORDE_TIME = 0x004a,
    /// <summary>
    /// whether have pop-up optical dirve(struct NET_DEVSTATE_BURNERDOOR)
    /// 是否已弹出刻录机光驱门(对应结构体 NET_DEVSTATE_BURNERDOOR)
    /// </summary>
    BURNER_DOOR = 0x004b,
    /// <summary>
    /// get data validation process(struct NET_DEVSTATE_DATA_CHECK)
    /// 查询光盘数据校验进度(对应 NET_DEVSTATE_DATA_CHECK)
    /// </summary>
    GET_DATA_CHECK = 0x004c,
    /// <summary>
    /// Query alarm input channel information(struct NET_ALARM_IN_CHANNEL)
    /// 查询报警输入通道信息(对应NET_ALARM_IN_CHANNEL数组)
    /// </summary>
    ALARM_IN_CHANNEL = 0x004f,
    /// <summary>
    /// Query alarm channel number(struct NET_ALARM_CHANNEL_COUNT)
    /// 查询报警通道数(对应NET_ALARM_CHANNEL_COUNT)
    /// </summary>
    ALARM_CHN_COUNT = 0x0050,
    /// <summary>
    /// Query PTZ view range status(struct DH_OUT_PTZ_VIEW_RANGE_STATUS)
    /// 查询云台可视域状态(对应 DH_OUT_PTZ_VIEW_RANGE_STATUS)
    /// </summary>
    PTZ_VIEW_RANGE = 0x0051,
    /// <summary>
    /// Query device channel information(struct NET_DEV_CHN_COUNT_INFO)
    /// 查询设备通道信息(对应NET_DEV_CHN_COUNT_INFO)
    /// </summary>
    DEV_CHN_COUNT = 0x0052,
    /// <summary>
    /// Query RTSP URL list supported by device, struct DEV_RTSPURL_LIST
    /// 查询设备支持的RTSP URL列表,见结构体DEV_RTSPURL_LIST
    /// </summary>
    RTSP_URL = 0x0053,
    /// <summary>
    /// Query online overtime of device logging in and return a BYTE, UNIT:MIN ,0 means no limite and The non-zero positive integer means restrictions on the number of minutes
    /// 查询设备登录的在线超时时间,返回一个BTYE,（单位：分钟） ,0表示不限制,非零正整数表示限制的分钟数
    /// </summary>
    LIMIT_LOGIN_TIME = 0x0054,
    /// <summary>
    /// get com count (struct NET_GET_COMM_COUNT)
    /// 获取串口数 见结构体NET_GET_COMM_COUNT
    /// </summary>
    GET_COMM_COUNT = 0x0055,
    /// <summary>
    /// Query recording status detail information(pBuf = NET_RECORD_STATE_DETAIL*)
    /// 查询录象状态详细信息(pBuf = NET_RECORD_STATE_DETAIL*)
    /// </summary>
    RECORDING_DETAIL = 0x0056,
    /// <summary>
    /// get state PTZ preset list (struct NET_PTZ_PRESET_LIST)
    /// 获取当前云台的预置点列表(对应结构NET_PTZ_PRESET_LIST)
    /// </summary>
    PTZ_PRESET_LIST = 0x0057,
    /// <summary>
    /// exteral device information (pBuf = NET_EXTERNAL_DEVICE*)
    /// 外接设备信息(pBuf = NET_EXTERNAL_DEVICE*)
    /// </summary>
    EXTERNAL_DEVICE = 0x0058,
    /// <summary>
    /// get device upgrade state(struct DHDEV_UPGRADE_STATE_INFO)
    /// 获取设备升级状态(对应结构DHDEV_UPGRADE_STATE_INFO)
    /// </summary>
    GET_UPGRADE_STATE = 0x0059,
    /// <summary>
    /// get mulipalyback split (struct NET_MULTIPLAYBACK_SPLIT_CAP )
    /// 获取多通道预览分割能力( 对应结构体 NET_MULTIPLAYBACK_SPLIT_CAP )
    /// </summary>
    MULTIPLAYBACK_SPLIT_CAP = 0x005a,
    /// <summary>
    /// get burn session number(pBuf = int*)
    /// 获取刻录会话总数(pBuf = int*)
    /// </summary>
    BURN_SESSION_NUM = 0x005b,
    /// <summary>
    /// Search protective capsule status(corresponding structure ALARM_PROTECTIVE_CAPSULE_INFO)
    /// 查询防护舱状态(对应结构体ALARM_PROTECTIVE_CAPSULE_INFO)
    /// </summary>
    PROTECTIVE_CAPSULE = 0x005c,
    /// <summary>
    /// get access controlmode( corresponding NET_GET_DOORWORK_MODE)
    /// 获取门锁控制模式( 对应 NET_GET_DOORWORK_MODE)
    /// </summary>
    GET_DOORWORK_MODE = 0x005d,
    /// <summary>
    /// Query PTZ optical zoom value( corresponding to DH_OUT_PTZ_ZOOM_INFO )
    /// 查询云台获取光学变倍信息(对应 DH_OUT_PTZ_ZOOM_INFO )
    /// </summary>
    PTZ_ZOOM_INFO = 0x005e,
    /// <summary>
    /// Query power state(struct DH_POWER_STATUS)
    /// 查询电源状态(对应结构体DH_POWER_STATUS)
    /// </summary>
    POWER_STATE = 0x0152,
    /// <summary>
    /// Query alarm channel state(struct NET_CLIENT_ALARM_CHANNELS_STATE)
    /// 查询报警通道状态(对应结构体 NET_CLIENT_ALARM_CHANNELS_STATE)
    /// </summary>
    ALL_ALARM_CHANNELS_STATE = 0x153,
    /// <summary>
    /// Query alarm keyboard count connected on com(struct NET_ALARMKEYBOARD_COUNT)
    /// 查询串口上连接的报警键盘数(对应结构体NET_ALARMKEYBOARD_COUNT)
    /// </summary>
    ALARMKEYBOARD_COUNT = 0x0154,
    /// <summary>
    /// Query mapping relationship of extension alarm module channel (struct NET_EXALARMCHANNELS)
    /// 查询扩展报警模块通道映射关系(对应结构体 NET_EXALARMCHANNELS)
    /// </summary>
    EXALARMCHANNELS = 0x0155,
    /// <summary>
    /// Query channel bypass state(struct NET_DEVSTATE_GET_BYPASS)
    /// 查询通道旁路状态(对应结构体 NET_DEVSTATE_GET_BYPASS)
    /// </summary>
    GET_BYPASS = 0x0156,
    /// <summary>
    /// get active sector information(struct NET_ACTIVATEDDEFENCEAREA)
    /// 获取激活的防区信息(对应结构体 NET_ACTIVATEDDEFENCEAREA)
    /// </summary>
    ACTIVATEDDEFENCEAREA = 0x0157,
    /// <summary>
    /// Query device recording information(struct NET_CTRL_RECORDSET_PARAM)
    /// 查询设备记录集信息(对应 NET_CTRL_RECORDSET_PARAM)
    /// </summary>
    DEV_RECORDSET = 0x0158,
    /// <summary>
    /// Query door access state(struct NET_DOOR_STATUS_INFO)
    /// 查询门禁状态(对应NET_DOOR_STATUS_INFO)
    /// </summary>
    DOOR_STATE = 0x0159,
    /// <summary>
    /// analog alarm input channel mapping (struct NET_ANALOGALARM_CHANNELS)
    /// 模拟量报警输入通道映射关系(对应NET_ANALOGALARM_CHANNELS)
    /// </summary>
    ANALOGALARM_CHANNELS = 0x1560,
    /// <summary>
    /// Get device supported sensor list(corresponding NET_SENSOR_LIST)
    /// 获取设备支持的传感器列表(对应 NET_SENSOR_LIST)
    /// </summary>
    GET_SENSORLIST = 0x1561,
    /// <summary>
    /// Search switch alarm template channel mapping relation(corresponding structure  NET_ALARM_CHANNELS)
    /// 查询开关量报警模块通道映射关系(对应结构体 NET_ALARM_CHANNELS), 如果设备不支持查询扩展报警模块通道,可以用该功能查询扩展通道的逻辑通道号,并当做本地报警通道使用
    /// </summary>
    ALARM_CHANNELS = 0x1562,
    /// <summary>
    /// Get current system enabling status( corresponding NET_GET_ALARM_SUBSYSTEM_ACTIVATE_STATUES)
    /// 获取当前子系统启用状态( 对应 NET_GET_ALARM_SUBSYSTEM_ACTIVATE_STATUES)
    /// </summary>
    GET_ALARM_SUBSYSTEM_ACTIVATESTATUS = 0x1563,
    /// <summary>
    /// Get air conditioning status(corresponding to NET_GET_AIRCONDITION_STATE)
    /// 获取空调工作状态(对应 NET_GET_AIRCONDITION_STATE)
    /// </summary>
    AIRCONDITION_STATE = 0x1564,
    /// <summary>
    /// Get sub system status(corresponding to NET_ALARM_SUBSYSTEM_STATE)
    /// 获取子系统状态(对应NET_ALARM_SUBSYSTEM_STATE)
    /// </summary>
    ALARMSUBSYSTEM_STATE = 0x1565,
    /// <summary>
    /// Get failure status(corresponding to NET_ALARM_FAULT_STATE_INFO)
    /// 获取故障状态(对应 NET_ALARM_FAULT_STATE_INFO)
    /// </summary>
    ALARM_FAULT_STATE = 0x1566,
    /// <summary>
    /// Get zone status(corresponding to NET_DEFENCE_STATE_INFO, and bypass status change event, local alarm event, alarm signal event status description is different, cannot mix, for specific device use only)
    /// 获取防区状态(对应 NET_DEFENCE_STATE_INFO, 和旁路状态变化事件、本地报警事件、报警信号源事件的状态描述有区别,不能混用,仅个别设备使用)
    /// </summary>
    DEFENCE_STATE = 0x1567,
    /// <summary>
    /// Get collection status(corresponding to NET_CLUSTER_STATE_INFO)
    /// 获取集群状态(对应 NET_CLUSTER_STATE_INFO)
    /// </summary>
    CLUSTER_STATE = 0x1568,
    /// <summary>
    /// Get spot chart path info(corresponding to NET_SCADA_POINT_LIST_INFO)
    /// 获取点位表路径信息(对应 NET_SCADA_POINT_LIST_INFO)
    /// </summary>
    SCADA_POINT_LIST = 0x1569,
    /// <summary>
    /// Get monitor spot info(corresponding to NET_SCADA_INFO)
    /// 获取监测点位信息(对应 NET_SCADA_INFO)
    /// </summary>
    SCADA_INFO = 0x156a,
    /// <summary>
    /// Get SCADA capacityset(corresponding to NET_SCADA_CAPS)
    /// 获取SCADA能力集(对应 NET_SCADA_CAPS)
    /// </summary>
    SCADA_CAPS = 0x156b,
    /// <summary>
    /// Get successful code item number(corresponding  NET_GET_CODEID_COUNT)
    /// 获取对码成功的总条数(对应 NET_GET_CODEID_COUNT)
    /// </summary>
    GET_CODEID_COUNT = 0x156c,
    /// <summary>
    /// Search code info(corresponding  NET_GET_CODEID_LIST)
    /// 查询对码信息(对应 NET_GET_CODEID_LIST)
    /// </summary>
    GET_CODEID_LIST = 0x156d,
    /// <summary>
    /// Search analog channel data(corresponding  NET_GET_ANALOGALARM_DATA)
    /// 查询模拟量通道数据(对应 NET_GET_ANALOGALARM_DATA)
    /// </summary>
    ANALOGALARM_DATA = 0x156e,
    /// <summary>
    /// Access the call state of the video phone (Corresponding to NET_GET_VTP_CALLSTATE)
    /// 获取视频电话呼叫状态(对应 NET_GET_VTP_CALLSTATE)
    /// </summary>
    VTP_CALLSTATE = 0x156f,
    /// <summary>
    /// query point info by device id(corresponding to NET_SCADA_INFO_BY_ID)
    /// 通过设备、获取监测点位信息(对应 NET_SCADA_INFO_BY_ID)
    /// </summary>
    SCADA_INFO_BY_ID = 0x1570,
    /// <summary>
    /// query scada device id(corresponding to NET_SCADA_DEVICE_LIST)
    /// 获取当前主机所接入的外部设备ID(对应 NET_SCADA_DEVICE_LIST)
    /// </summary>
    SCADA_DEVICE_LIST = 0x1571,
    /// <summary>
    /// Search device record set info (with binary data) (Corresponding to NET_CTRL_RECORDSET_PARAM)
    /// 查询设备记录集信息(带二进制数据)(对应NET_CTRL_RECORDSET_PARAM)
    /// </summary>
    DEV_RECORDSET_EX = 0x1572,
    /// <summary>
    /// Get door locker software version (Corresponding to NET_ACCESS_LOCK_VER)
    /// 获取门锁软件版本号(对应 NET_ACCESS_LOCK_VER)
    /// </summary>
    ACCESS_LOCK_VER = 0x1573,
    /// <summary>
    /// get monitorwall TV info(Corresponding to NET_CTRL_MONITORWALL_TVINFO)
    /// 获取电视墙显示信息(对应 NET_CTRL_MONITORWALL_TVINFO)
    /// </summary>
    MONITORWALL_TVINFO = 0x1574,
    /// <summary>
    /// get all configuration of users's Pos devices (Corresponding to NET_POS_ALL_INFO)
    /// 获取所有用户可用Pos设备配置信息(对应 NET_POS_ALL_INFO)
    /// </summary>
    GET_ALL_POS = 0x1575,
    /// <summary>
    /// get city and road code info(Corresponding to NET_ROAD_LIST_INFO)
    /// 获取城市及路段编码信息,哥伦比亚项目专用(对应 NET_ROAD_LIST_INFO)
    /// </summary>
    GET_ROAD_LIST = 0x1576,
    /// <summary>
    /// get heatmap information(Corresponding to NET_QUERY_HEAT_MAP)
    /// 获取热度统计信息(对应 NET_QUERY_HEAT_MAP)
    /// </summary>
    GET_HEAT_MAP = 0x1577,
    /// <summary>
    /// get device work state (Corresponding to NET_QUERY_WORK_STATE)
    /// 获取盒子工作状态信息(对应 NET_QUERY_WORK_STATE)
    /// </summary>
    GET_WORK_STATE = 0x1578,
    /// <summary>
    /// get wireless device work state(Corresponding to NET_GET_WIRELESS_DEVICE_STATE)
    /// 获取无线设备状态信息(对应 NET_GET_WIRELESS_DEVICE_STATE)
    /// </summary>
    GET_WIRESSLESS_STATE = 0x1579,
    /// <summary>
    /// get redundance power info(Corresponding to NET_GET_REDUNDANCE_POWER_INFO)
    /// 获取冗余电源信息(对应 NET_GET_REDUNDANCE_POWER_INFO)
    /// </summary>
    GET_REDUNDANCE_POWER_INFO = 0x157a,
  }

  /// <summary>
  /// Configuration type
  /// 配置类型
  /// </summary>
  public enum EM_DEV_CFG_TYPE
  {
    /// <summary>
    /// Device property setup
    /// 设备属性配置
    /// </summary>
    DEVICECFG = 0x0001,
    /// <summary>
    /// Network setup 
    /// 网络配置
    /// </summary>
    NETCFG = 0x0002,
    /// <summary>
    /// Video channel setup
    /// 图象通道配置
    /// </summary>
    CHANNELCFG = 0x0003,
    /// <summary>
    /// Preview parameter setup
    /// 预览参数配置
    /// </summary>
    PREVIEWCFG = 0x0004,
    /// <summary>
    /// Record setup
    /// 录像配置
    /// </summary>
    RECORDCFG = 0x0005,
    /// <summary>
    /// COM property setup
    /// 串口属性配置
    /// </summary>
    COMMCFG = 0x0006,
    /// <summary>
    /// Alarm property setup
    /// 报警属性配置
    /// </summary>
    ALARMCFG = 0x0007,
    /// <summary>
    /// DVR time setup
    /// DVR时间配置
    /// </summary>
    TIMECFG = 0x0008,
    /// <summary>
    /// Audio talk parameter setup 
    /// 对讲参数配置
    /// </summary>
    TALKCFG = 0x0009,
    /// <summary>
    /// Auto matrix setup
    /// 自动维护配置
    /// </summary>
    AUTOMTCFG = 0x000A,
    /// <summary>
    /// Local matrix control strategy setup
    /// 本机矩阵控制策略配置
    /// </summary>
    VEDIO_MARTIX = 0x000B,
    /// <summary>
    /// Multiple DDNS setup
    /// 多ddns服务器配置
    /// </summary>
    MULTI_DDNS = 0x000C,
    /// <summary>
    /// Snapshot corresponding setup 
    /// 抓图相关配置
    /// </summary>
    SNAP_CFG = 0x000D,
    /// <summary>
    /// HTTP path setup 
    /// HTTP路径配置
    /// </summary>
    WEB_URL_CFG = 0x000E,
    /// <summary>
    /// FTP upload setup
    /// FTP上传配置
    /// </summary>
    FTP_PROTO_CFG = 0x000F,
    /// <summary>
    /// Plaform embedded setup. Now the channel parameter represents the platform type.  channel=4:Bell alcatel;channel=10:ZTE Netview;channel=11:U CNC  channel = 51 AMP
    /// 平台接入配置,此时channel参数代表平台类型,channel=4： 代表贝尔阿尔卡特；channel=10：代表中兴力维；channel=11：代表U网通；channel=51：代表天地阳光
    /// </summary>
    INTERVIDEO_CFG = 0x0010,
    /// <summary>
    /// Privacy mask setup
    /// 区域遮挡配置
    /// </summary>
    VIDEO_COVER = 0x0011,
    /// <summary>
    /// Transmission strategy. Video quality\Fluency
    /// 传输策略配置,画质优先\流畅性优先
    /// </summary>
    TRANS_STRATEGY = 0x0012,
    /// <summary>
    /// Record download strategy setup:high-speed\general download
    /// 录象下载策略配置,高速下载\普通下载
    /// </summary>
    DOWNLOAD_STRATEGY = 0x0013,
    /// <summary>
    /// Video watermark setup
    /// 图象水印配置
    /// </summary>
    WATERMAKE_CFG = 0x0014,
    /// <summary>
    /// Wireless network setup
    /// 无线网络配置
    /// </summary>
    WLAN_CFG = 0x0015,
    /// <summary>
    /// Search wireless device setup
    /// 搜索无线设备配置
    /// </summary>
    WLAN_DEVICE_CFG = 0x0016,
    /// <summary>
    /// Auto register parameter setup, NET_DEV_REGISTER_SERVER
    /// 主动注册参数配置,NET_DEV_REGISTER_SERVER
    /// </summary>
    REGISTER_CFG = 0x0017,
    /// <summary>
    /// Camera property setup
    /// 摄像头属性配置
    /// </summary>
    CAMERA_CFG = 0x0018,
    /// <summary>
    /// IR alarm setup
    /// 红外报警配置
    /// </summary>
    INFRARED_CFG = 0x0019,
    /// <summary>
    /// Sniffer setup
    /// Sniffer抓包配置
    /// </summary>
    SNIFFER_CFG = 0x001A,
    /// <summary>
    /// Mail setup 
    /// 邮件配置
    /// </summary>
    MAIL_CFG = 0x001B,
    /// <summary>
    /// DNS setup
    /// DNS服务器配置
    /// </summary>
    DNS_CFG = 0x001C,
    /// <summary>
    /// NTP setup
    /// NTP配置
    /// </summary>
    NTP_CFG = 0x001D,
    /// <summary>
    /// Audio detection setup 
    /// 音频检测配置
    /// </summary>
    AUDIO_DETECT_CFG = 0x001E,
    /// <summary>
    /// Storage position setup 
    /// 存储位置配置
    /// </summary>
    STORAGE_STATION_CFG = 0x001F,
    /// <summary>
    /// PTZ operation property(It is invalid now. Please use CLIENT_GetPtzOptAttr to get PTZ operation property.)
    /// 云台操作属性(已经废除,请使用CLIENT_GetPtzOptAttr获取云台操作属性)
    /// </summary>
    PTZ_OPT_CFG = 0x0020,
    /// <summary>
    /// Daylight Saving Time (DST)setup
    /// 夏令时配置
    /// </summary>
    DST_CFG = 0x0021,
    /// <summary>
    /// Alarm center setup
    /// 报警中心配置
    /// </summary>
    ALARM_CENTER_CFG = 0x0022,
    /// <summary>
    /// VIdeo OSD setup
    /// 视频OSD叠加配置
    /// </summary>
    VIDEO_OSD_CFG = 0x0023,
    /// <summary>
    /// CDMA\GPRS configuration
    /// CDMA\GPRS网络配置
    /// </summary>
    CDMAGPRS_CFG = 0x0024,
    /// <summary>
    /// IP Filter configuration
    /// IP过滤配置
    /// </summary>
    IPFILTER_CFG = 0x0025,
    /// <summary>
    /// Talk encode configuration
    /// 语音对讲编码配置
    /// </summary>
    TALK_ENCODE_CFG = 0x0026,
    /// <summary>
    /// The length of the video package configuration
    /// 录像打包长度配置
    /// </summary>
    RECORD_PACKET_CFG = 0x0027,
    /// <summary>
    /// SMS MMS configuration
    /// 短信MMS配置
    /// </summary>
    MMS_CFG = 0x0028,
    /// <summary>
    /// SMS to activate the wireless connection configuration
    /// 短信激活无线连接配置
    /// </summary>
    SMSACTIVATION_CFG = 0x0029,
    /// <summary>
    /// Dial-up activation of a wireless connection configuration
    /// 拨号激活无线连接配置
    /// </summary>
    DIALINACTIVATION_CFG = 0x002A,
    /// <summary>
    /// Capture network configuration
    /// 网络抓包配置
    /// </summary>
    SNIFFER_CFG_EX = 0x0030,
    /// <summary>
    /// Download speed limit
    /// 下载速度限制
    /// </summary>
    DOWNLOAD_RATE_CFG = 0x0031,
    /// <summary>
    /// Panorama switch alarm configuration
    /// 全景切换报警配置
    /// </summary>
    PANORAMA_SWITCH_CFG = 0x0032,
    /// <summary>
    /// Lose focus alarm configuration
    /// 失去焦点报警配置
    /// </summary>
    LOST_FOCUS_CFG = 0x0033,
    /// <summary>
    /// Alarm decoder configuration
    /// 报警解码器配置
    /// </summary>
    ALARM_DECODE_CFG = 0x0034,
    /// <summary>
    /// Video output configuration
    /// 视频输出参数配置
    /// </summary>
    VIDEOOUT_CFG = 0x0035,
    /// <summary>
    /// Preset enable configuration
    /// 预制点使能配置
    /// </summary>
    POINT_CFG = 0x0036,
    /// <summary>
    /// IP conflication configurationIp
    /// Ip冲突检测报警配置
    /// </summary>
    IP_COLLISION_CFG = 0x0037,
    /// <summary>
    /// OSD overlay enable configuration
    /// OSD叠加使能配置
    /// </summary>
    OSD_ENABLE_CFG = 0x0038,
    /// <summary>
    /// Local alarm configuration(Structure NET_ALARMIN_CFG_EX)
    /// 本地报警配置(结构体NET_ALARMIN_CFG_EX)
    /// </summary>
    LOCALALARM_CFG = 0x0039,
    /// <summary>
    /// Network alarm configuration(Structure NET_ALARMIN_CFG_EX)
    /// 网络报警配置(结构体NET_ALARMIN_CFG_EX)
    /// </summary>
    NETALARM_CFG = 0x003A,
    /// <summary>
    /// Motion detection configuration(Structure NET_MOTION_DETECT_CFG_EX)
    /// 动检报警配置(结构体NET_MOTION_DETECT_CFG_EX)
    /// </summary>
    MOTIONALARM_CFG = 0x003B,
    /// <summary>
    /// Video loss configuration(Structure NET_VIDEO_LOST_CFG_EX)
    /// 视频丢失报警配置(结构体NET_VIDEO_LOST_CFG_EX)
    /// </summary>
    VIDEOLOSTALARM_CFG = 0x003C,
    /// <summary>
    /// Camera masking configuration(Structure NET_BLIND_CFG_EX)
    /// 视频遮挡报警配置(结构体NET_BLIND_CFG_EX)
    /// </summary>
    BLINDALARM_CFG = 0x003D,
    /// <summary>
    /// HDD alarm configuration(Structure NET_DISK_ALARM_CFG_EX)
    /// 硬盘报警配置(结构体NET_DISK_ALARM_CFG_EX)
    /// </summary>
    DISKALARM_CFG = 0x003E,
    /// <summary>
    /// Network disconnection alarm configuration(Structure NET_NETBROKEN_ALARM_CFG_EX)
    /// 网络中断报警配置(结构体NET_NETBROKEN_ALARM_CFG_EX)
    /// </summary>
    NETBROKENALARM_CFG = 0x003F,
    /// <summary>
    /// Digital channel info of front encoders(Hybrid DVR use,Structure DEV_ENCODER_CFG)
    /// 数字通道的前端编码器信息（混合DVR使用,结构体DEV_ENCODER_CFG）
    /// </summary>
    ENCODER_CFG = 0x0040,
    /// <summary>
    /// TV adjust configuration(Now the channel parameter represents the TV numble(from 0), Structure DHDEV_TVADJUST_CFG)
    /// TV调节配置（channel代表TV号(0开始),类型结构体）
    /// </summary>
    TV_ADJUST_CFG = 0x0041,
    /// <summary>
    /// about vehicle configuration
    /// 车载相关配置,北京公交使用
    /// </summary>
    ABOUT_VEHICLE_CFG = 0x0042,
    /// <summary>
    /// ATM ability information
    /// 获取atm叠加支持能力信息
    /// </summary>
    ATM_OVERLAY_ABILITY = 0x0043,
    /// <summary>
    /// ATM overlay configuration
    /// atm叠加配置,新atm特有
    /// </summary>
    ATM_OVERLAY_CFG = 0x0044,
    /// <summary>
    /// Decoder tour configuration
    /// 解码器解码轮巡配置
    /// </summary>
    DECODER_TOUR_CFG = 0x0045,
    /// <summary>
    /// SIP configuration
    /// SIP配置
    /// </summary>
    SIP_CFG = 0x0046,
    /// <summary>
    /// wifi ap configuration
    ///  wifi ap配置
    /// </summary>
    VICHILE_WIFI_AP_CFG = 0x0047,
    /// <summary>
    /// Static
    /// 静态报警配置
    /// </summary>
    STATICALARM_CFG = 0x0048,
    /// <summary>
    /// decode policy configuration(Structure DHDEV_DECODEPOLICY_CFG,channel start with 0)
    /// 设备的解码策略配置(结构体DHDEV_DECODEPOLICY_CFG,channel为解码通道0开始)
    /// </summary>
    DECODE_POLICY_CFG = 0x0049,
    /// <summary>
    /// Device relative config (Structure DHDEV_MACHINE_CFG)
    /// 机器相关的配置(结构体DHDEV_MACHINE_CFG)
    /// </summary>
    MACHINE_CFG = 0x004A,
    /// <summary>
    /// MACconflication configuration(Structure ALARM_MAC_COLLISION_CFG)
    /// MAC冲突检测配置(结构体 ALARM_MAC_COLLISION_CFG)
    /// </summary>
    MAC_COLLISION_CFG = 0x004B,
    /// <summary>
    /// RTSP configuration(structure DHDEV_RTSP_CFG)
    /// RTSP配置(对应结构体DHDEV_RTSP_CFG)
    /// </summary>
    RTSP_CFG = 0x004C,
    /// <summary>
    /// 232 com card signal event configuration(structure COM_CARD_SIGNAL_LINK_CFG)
    /// 232串口卡号信号事件配置(对应结构体COM_CARD_SIGNAL_LINK_CFG)
    /// </summary>
    NET_232_COM_CARD_CFG = 0x004E,
    /// <summary>
    /// 485 com card signal event configuration(structure COM_CARD_SIGNAL_LINK_CFG)
    /// 485串口卡号信号事件配置(对应结构体COM_CARD_SIGNAL_LINK_CFG)
    /// </summary>
    NET_485_COM_CARD_CFG = 0x004F,
    /// <summary>
    /// extend FTP upload setup(Structure DHDEV_FTP_PROTO_CFG_EX)
    /// FTP上传扩展配置(对应结构体DHDEV_FTP_PROTO_CFG_EX)
    /// </summary>
    FTP_PROTO_CFG_EX = 0x0050,
    /// <summary>
    /// SYSLOG remote server config (Structure DHDEV_SYSLOG_REMOTE_SERVER)
    /// SYSLOG 远程服务器配置(对应结构体DHDEV_SYSLOG_REMOTE_SERVER)
    /// </summary>
    SYSLOG_REMOTE_SERVER = 0x0051,
    /// <summary>
    /// Extended com configuration(structure DHDEV_COMM_CFG_EX)
    /// 扩展串口属性配置(对应结构体DHDEV_COMM_CFG_EX)  
    /// </summary>
    COMMCFG_EX = 0x0052,
    /// <summary>
    /// net card configuration(structure DHDEV_NETCARD_CFG)
    /// 卡口信息配置(对应结构体DHDEV_NETCARD_CFG)
    /// </summary>
    NETCARD_CFG = 0x0053,
    /// <summary>
    /// Video backup format(structure DHDEV_BACKUP_VIDEO_FORMAT)
    /// 视频备份格式配置(对应结构体DHDEV_BACKUP_VIDEO_FORMAT)
    /// </summary>
    BACKUP_VIDEO_FORMAT = 0x0054,
    /// <summary>
    /// stream encrypt configuration(structure DHEDV_STREAM_ENCRYPT)
    /// 码流加密配置(对应结构体DHEDV_STREAM_ENCRYPT)
    /// </summary>
    STREAM_ENCRYPT_CFG = 0x0055,
    /// <summary>
    /// IP filter extended configuration(structure DHDEV_IPIFILTER_CFG_EX)
    /// IP过滤配置扩展(对应结构体DHDEV_IPIFILTER_CFG_EX)
    /// </summary>
    IPFILTER_CFG_EX = 0x0056,
    /// <summary>
    /// custom configuration(structure DHDEV_CUSTOM_CFG)
    /// 用户自定义配置(对应结构体DHDEV_CUSTOM_CFG)
    /// </summary>
    CUSTOM_CFG = 0x0057,
    /// <summary>
    /// Search wireless device extended setup(structure DHDEV_WLAN_DEVICE_LIST_EX)
    /// 搜索无线设备扩展配置(对应结构体DHDEV_WLAN_DEVICE_LIST_EX)
    /// </summary>
    WLAN_DEVICE_CFG_EX = 0x0058,
    /// <summary>
    /// ACC power off configuration(structure DHDEV_ACC_POWEROFF_CFG)
    /// ACC断线事件配置(对应结构体DHDEV_ACC_POWEROFF_CFG)
    /// </summary>
    ACC_POWEROFF_CFG = 0x0059,
    /// <summary>
    /// explosion proof alarm configuration(structure DHDEV_EXPLOSION_PROOF_CFG)
    /// 防爆盒报警事件配置(对应结构体DHDEV_EXPLOSION_PROOF_CFG)
    /// </summary>
    EXPLOSION_PROOF_CFG = 0x005a,
    /// <summary>
    /// Network extended setup(struct DHDEV_NET_CFG_EX)
    /// 网络扩展配置(对应结构体DHDEV_NET_CFG_EX)
    /// </summary>
    NETCFG_EX = 0x005b,
    /// <summary>
    /// light control config(struct DHDEV_LIGHTCONTROL_CFG)
    /// 灯光控制配置(对应结构体DHDEV_LIGHTCONTROL_CFG)
    /// </summary>
    LIGHTCONTROL_CFG = 0x005c,
    /// <summary>
    /// 3G flow info config(struct DHDEV_3GFLOW_INFO_CFG)
    /// 3G流量信息配置(对应结构体DHDEV_3GFLOW_INFO_CFG)
    /// </summary>
    NET_3GFLOW_CFG = 0x005d,
    /// <summary>
    /// IPv6 config(struct DHDEV_IPV6_CFG)
    /// IPv6配置(对应结构体DHDEV_IPV6_CFG)
    /// </summary>
    IPV6_CFG = 0x005e,
    /// <summary>
    /// Snmp config(struct DHDEV_NET_SNMP_CFG)
    /// Snmp配置(对应结构体DHDEV_NET_SNMP_CFG), 设置完成后需要重启设备
    /// </summary>
    SNMP_CFG = 0x005f,
    /// <summary>
    /// snap control config(struct DHDEV_SNAP_CONTROL_CFG)
    /// 抓图开关配置(对应结构体DHDEV_SNAP_CONTROL_CFG)
    /// </summary>
    SNAP_CONTROL_CFG = 0x0060,
    /// <summary>
    /// GPS mode config(struct DHDEV_GPS_MODE_CFG)
    /// GPS定位模式配置(对应结构体DHDEV_GPS_MODE_CFG)
    /// </summary>
    GPS_MODE_CFG = 0x0061,
    /// <summary>
    /// Snap upload config(struct DHDEV_SNAP_UPLOAD_CFG)
    /// 图片上传配置信息(对应结构体 DHDEV_SNAP_UPLOAD_CFG)
    /// </summary>
    SNAP_UPLOAD_CFG = 0x0062,
    /// <summary>
    /// Speed limit config(struct DHDEV_SPEED_LIMIT_CFG)
    /// 限速配置信息(对应结构体DHDEV_SPEED_LIMIT_CFG)
    /// </summary>
    SPEED_LIMIT_CFG = 0x0063,
    /// <summary>
    /// iSCSI config(struct DHDEV_ISCSI_CFG), need reboot
    /// iSCSI配置(对应结构体DHDEV_ISCSI_CFG), 设置完成后需要重启设备
    /// </summary>
    ISCSI_CFG = 0x0064,
    /// <summary>
    /// wifi config(struc DHDEV_WIRELESS_ROUTING_CFG)
    /// 无线路由配置(对应结构体DHDEV_WIRELESS_ROUTING_CFG)
    /// </summary>
    WIRELESS_ROUTING_CFG = 0x0065,
    /// <summary>
    /// enclosure config(stuct DHDEV_ENCLOSURE_CFG)
    /// 电子围栏配置(对应结构体DHDEV_ENCLOSURE_CFG)
    /// </summary>
    ENCLOSURE_CFG = 0x0066,
    /// <summary>
    /// enclosure version config(struct DHDEV_ENCLOSURE_VERSION_CFG)
    /// 电子围栏版本号配置(对应结构体DHDEV_ENCLOSURE_VERSION_CFG)
    /// </summary>
    ENCLOSURE_VERSION_CFG = 0x0067,
    /// <summary>
    /// Raid event config(struct DHDEV_RAID_EVENT_CFG)
    /// Raid事件配置(对应结构体DHDEV_RAID_EVENT_CFG)
    /// </summary>
    RIAD_EVENT_CFG = 0x0068,
    /// <summary>
    /// fire alarm config(struct DHDEV_FIRE_ALARM_CFG)
    /// 火警报警配置(对应结构体DHDEV_FIRE_ALARM_CFG)
    /// </summary>
    FIRE_ALARM_CFG = 0x0069,
    /// <summary>
    /// local alarm name config(string like "Name1&&name2&&name3...")
    /// 本地名称报警配置(对应Name1&&name2&&name3...格式字符串)
    /// </summary>
    LOCALALARM_NAME_CFG = 0x006a,
    /// <summary>
    /// urgency storage config(struct DHDEV_URGENCY_RECORD_CFG)
    /// 紧急存储配置(对应结构体DHDEV_URGENCY_RECORD_CFG)
    /// </summary>
    URGENCY_RECORD_CFG = 0x0070,
    /// <summary>
    /// elevator parameter config(struct DHDEV_ELEVATOR_ATTRI_CFG)
    /// 电梯运行参数配置(对应结构体DHDEV_ELEVATOR_ATTRI_CFG)
    /// </summary>
    ELEVATOR_ATTRI_CFG = 0x0071,
    /// <summary>
    /// TM overlay function. For latest ATM series product only.  Support devices of 32-channel or higher.( struct DHDEV_ATM_OVERLAY_CONFIG_EX)
    /// atm叠加配置,新atm特有,支持大于32通道的设备(对应结构体DHDEV_ATM_OVERLAY_CONFIG_EX)
    /// </summary>
    ATM_OVERLAY_CFG_EX = 0x0072,
    /// <summary>
    /// MAC filter config(struct DHDEV_MACFILTER_CFG)
    /// MAC过滤配置(对应结构体DHDEV_MACFILTER_CFG)
    /// </summary>
    MACFILTER_CFG = 0x0073,
    /// <summary>
    /// MAC,IP filter config(need ip,mac one to one corresponding)(struct DHDEV_MACIPFILTER_CFG)
    /// MAC,IP过滤(要求ip,mac是一一对应的)配置(对应结构体DHDEV_MACIPFILTER_CFG)
    /// </summary>
    MACIPFILTER_CFG = 0x0074,
    /// <summary>
    /// stream encrypt(encryot plan)(struct DHEDV_STREAM_ENCRYPT)
    /// 码流加密(加密计划)配置(对应结构体DHEDV_STREAM_ENCRYPT)
    /// </summary>
    STREAM_ENCRYPT_TIME_CFG = 0x0075,
    /// <summary>
    /// limit bit rate config(struct DHDEV_LIMIT_BIT_RATE) 
    /// 限码流配置(对应结构体 DHDEV_LIMIT_BIT_RATE) 
    /// </summary>
    LIMIT_BIT_RATE_CFG = 0x0076,
    /// <summary>
    /// snap extern config(struct DHDEV_SNAP_CFG_EX)
    /// 抓图相关配置扩展(对应结构体 DHDEV_SNAP_CFG_EX)
    /// </summary>
    SNAP_CFG_EX = 0x0077,
    /// <summary>
    /// decoder url config(struct DHDEV_DECODER_URL_CFG)
    /// 解码器url配置(对应结构体DHDEV_DECODER_URL_CFG)
    /// </summary>
    DECODER_URL_CFG = 0x0078,
    /// <summary>
    /// toyr enable config(struct DHDEV_TOUR_ENABLE_CFG)
    /// 轮巡使能配置(对应结构体DHDEV_TOUR_ENABLE_CFG)
    /// </summary>
    TOUR_ENABLE_CFG = 0x0079,
    /// <summary>
    /// wifi ap extern config(struct DHDEV_VEHICLE_WIFI_AP_CFG_EX)
    /// wifi ap配置扩展(对应结构体DHDEV_VEHICLE_WIFI_AP_CFG_EX)
    /// </summary>
    VICHILE_WIFI_AP_CFG_EX = 0x007a,
    /// <summary>
    /// encoder extern config(struct DEV_ENCODER_CFG_EX)
    /// 数字通道的前端编码器信息扩展,(对应结构体 DEV_ENCODER_CFG_EX)
    /// </summary>
    ENCODER_CFG_EX = 0x007b,
    /// <summary>
    /// encoder extern config(struct DEV_ENCODER_CFG_EX2)
    /// 数字通道的前端编码器信息扩展,(对应结构体 DEV_ENCODER_CFG_EX2)
    /// </summary>
    ENCODER_CFG_EX2 = 0x007c,
  }

  /// <summary>
  /// Auto register config parameter
  /// 主动注册参数配置
  /// </summary>
  public struct NET_DEV_SERVER_INFO
  {
    /// <summary>
    /// Registration server IP ; no use it,use szServerIpEx
    /// 注册服务器IP
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szServerIp;
    /// <summary>
    /// Port number
    /// 端口号
    /// </summary>
    public int nServerPort;
    /// <summary>
    /// Reserved
    /// 对齐
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] byReserved;
    /// <summary>
    /// Extend Registration server IP enable, 0-not enable, 1-enable
    /// 注册服务器IP扩展使能,0-表示无效, 1-表示有效
    /// </summary>
    public byte bServerIpExEn;
    /// <summary>
    /// Extend Registration server IP
    /// 注册服务器IP扩展,支持ipv4,ipv6,域名等类型的IP
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 60)]
    public string szServerIpEx;
  }

  public struct NET_DEV_REGISTER_SERVER
  {
    public uint dwSize;
    /// <summary>
    /// The max IP amount supported
    /// 支持的最大ip数
    /// </summary>
    public byte bServerNum;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public NET_DEV_SERVER_INFO[] lstServer;
    /// <summary>
    /// Enable
    /// 使能
    /// </summary>
    public byte bEnable;
    /// <summary>
    /// Device ID
    /// 设备id
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDeviceID;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 94)]
    public byte[] reserved;
  }

  // CLIENT_AttachMotionData 输入参数
  public struct NET_IN_ATTACH_MOTION_DATA
  {
    public uint dwSize;
    public int nChannel;            // 通道号
    public fAttachMotionDataCB cbNotify;            // 回调函数
    public IntPtr dwUser;                         // 用户数据
  }

  // CLIENT_AttachMotionData 输出参数
  public struct NET_OUT_ATTACH_MOTION_DATA
  {
    public uint dwSize;
  }

  // 回调元数据消息
  public struct NET_CB_MOTION_DATA
  {
    public uint dwSize;
    public int nMotionDataCount;              // 动检窗口个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public NET_MOTION_DATA[] stMotionData;                        // 动检数据
    public int nRegionRow;                  // 动态检测区域的行数
    public int nRegionCol;                  // 动态检测区域的列数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_ROW[] byRegion;    // 检测区域, 最多32*32块区域
  }

  public struct NET_ROW
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] byCol;
  }

  // 动检数据
  public struct NET_MOTION_DATA
  {
    public int nRegionID;                 // 动态窗口ID
    public int nThreshold;                                 // 面积阀值, 取值[0, 100]
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] byReserved;             // 保留字节
  }

  /// <summary>
  /// 
  /// SearchDevicesByIPs接口
  /// </summary>
  public struct NET_DEVICE_IP_SEARCH_INFO
  {
    /// <summary>
    /// 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// 
    /// 当前搜索的IP个数
    /// </summary>
    public int nIpNum;
    /// <summary>
    /// 
    /// 具体待搜索的IP信息
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_IPADDRESS[] szIPs;
  }

  /// <summary>
  /// IP Address
  /// IP地址
  /// </summary>
  public struct NET_IPADDRESS
  {
    /// <summary>
    /// IP Address
    /// IP地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szIP;
  }

  // 初始化设备账户输入结构体
  public struct NET_IN_INIT_DEVICE_ACCOUNT
  {
    /// <summary>
    /// 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// 
    /// 设备mac地址
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 40)]
    public string szMac;
    /// <summary>
    /// 
    /// 用户名
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUserName;
    /// <summary>
    /// 
    /// 设备密码
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szPwd;
    /// <summary>
    /// 
    /// 预留手机号
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szCellPhone;
    /// <summary>
    /// 
    /// 预留邮箱
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szMail;
    /// <summary>
    /// 
    /// 此字段已经废弃
    /// </summary>
    public byte byInitStatus;
    /// <summary>
    /// 
    /// 设备支持的密码重置方式：搜索设备接口(SearchDevices、StartSearchDevices的回调函数、SearchDevicesByIPs)返回字段byPwdResetWay的值
    /// </summary>										
    public byte byPwdResetWay;
    /// <summary>
    /// 
    /// 保留字段
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
  }

  /// <summary>
  /// 
  /// 初始化设备账户输出结构体
  /// </summary>
  public struct NET_OUT_INIT_DEVICE_ACCOUNT
  {
    /// <summary>
    /// 
    /// 结构体大小
    /// </summary>
    public uint dwSize;
  }

  /// <summary>
  /// Warning line event (Corresponding to event  EVENT_CROSSLINE_DETECTION)
  /// 警戒线事件(对应事件 EVENT_CROSSLINE_DETECTION)
  /// </summary>
  public struct NET_ALARM_EVENT_CROSSLINE_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// Channel No.
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// Time stamp (Unit is ms)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// Event occurrence time 
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// Event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// Event operation. 0=pulse event.1=continious event begin. 2=continuous event stop
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public int nEventAction;
    /// <summary>
    /// Intrusion direction 
    /// 入侵方向
    /// </summary>
    public EM_CROSSLINE_DIRECTION_INFO emCrossDirection;
    /// <summary>
    /// Triggered amount 
    /// 规则被触发生次数
    /// </summary>
    public int nOccurrenceCount;
    /// <summary>
    /// Event level
    /// 事件级别,GB30147需求项
    /// </summary>
    public int nLevel;
  }

  /// <summary>
  /// Warning line intrusion direction
  /// 警戒线入侵方向
  /// </summary>
  public enum EM_CROSSLINE_DIRECTION_INFO
  {
    UNKNOW = 0,
    /// <summary>
    /// From left to right
    /// 左到右
    /// </summary>
    LEFT2RIGHT,
    /// <summary>
    /// From right to left
    /// 右到左
    /// </summary>
    RIGHT2LEFT,
    ANY,
  }

  /// <summary>
  /// alarm event type EVENT_MOTIONDETECT (video motion detection event) corresponding data description info
  /// 报警事件类型EVENT_MOTIONDETECT(视频移动侦测事件)对应的数据描述信息
  /// </summary>
  public struct NET_ALARM_MOTIONDETECT_INFO
  {
    /// <summary>
    /// size of struct
    /// 结构体大小
    /// </summary>
    public uint dwSize;
    /// <summary>
    /// channel number
    /// 通道号
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// timestamp (unit is millisecond)
    /// 时间戳(单位是毫秒)
    /// </summary>
    public double PTS;
    /// <summary>
    /// event occurrence time
    /// 事件发生的时间
    /// </summary>
    public NET_TIME_EX UTC;
    /// <summary>
    /// event ID
    /// 事件ID
    /// </summary>
    public int nEventID;
    /// <summary>
    /// event action, 0 means pulse event, 1 means continuous event begin, 2 means continuous event end
    /// 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束
    /// </summary>
    public int nEventAction;
  }

  // 主(辅)码流视频格式(f6/f5/bin)
  public struct NET_ENCODE_VIDEO_INFO
  {
    public uint dwSize;
    public EM_FORMAT_TYPE emFormatType;       // 码流类型,设置和获取时都需要设置值
    public bool bVideoEnable;       // 视频使能
    public EM_VIDEO_COMPRESSION emCompression;        // 视频压缩格式
    public int nWidth;            // 视频宽度
    public int nHeight;         // 视频高度
    public EM_BITRATE_CONTROL emBitRateControl;     // 码流控制模式
    public int nBitRate;          // 视频码流(kbps)
    public float nFrameRate;          // 视频帧率
    public int nIFrameInterval;     // I帧间隔(1-100)，比如50表示每49个B帧或P帧，设置一个I帧。
    public EM_IMAGE_QUALITY emImageQuality;       // 图像质量
  }

  // 码流类型
  public enum EM_FORMAT_TYPE
  {
    UNKNOWN,        // 未知类型
    /*主码流*/
    NORMAL,       // 主码流普通编码
    MOVEEXAMINE,      // 主码流动检编码
    ALARM,        // 主码流报警编码
    /*辅码流*/
    EXTRA1,         // 辅码流1
    EXTRA2,         // 辅码流2
    EXTRA3,         // 辅码流3
  }

  // 视频压缩格式
  public enum EM_VIDEO_COMPRESSION
  {
    MPEG4,                // MPEG4
    MS_MPEG4,             // MS-MPEG4
    MPEG2,                // MPEG2
    MPEG1,                // MPEG1
    H263,               // H.263
    MJPG,               // MJPG
    FCC_MPEG4,              // FCC-MPEG4
    H264,               // H.264
    H265,               // H.265
    SVAC,               // SVAC
  }

  // 码流控制模式
  public enum EM_BITRATE_CONTROL
  {
    CBR,                  // 固定码流
    VBR,                  // 可变码流
  }

  // 画质
  public enum EM_IMAGE_QUALITY
  {
    Q10 = 1,              // 图像质量10%
    Q30,                // 图像质量30%
    Q50,                // 图像质量50%
    Q60,                // 图像质量60%
    Q80,                // 图像质量80%
    Q100,               // 图像质量100%
  }

  // 设备能力类型, 对应CLIENT_GetDevCaps接口
  public enum EM_DEVCAP_TYPE
  {
    DEV_CAP_SEQPOWER = 0x01,               // 电源时序器能力, pInBuf=NET_IN_CAP_SEQPOWER*, pOutBuf=NET_OUT_CAP_SEQPOWER*
    ENCODE_CFG_CAPS = 0x02,               // 设备编码配置对应能力, pInBuf=NET_IN_ENCODE_CFG_CAPS*, pOutBuf= NET_OUT_ENCODE_CFG_CAPS*
    VIDEOIN_FISHEYE_CAPS = 0x03,               // 鱼眼能力, pInBuf=NET_IN_VIDEOIN_FISHEYE_CAPS*, pOutBuf=NET_OUT_VIDEOIN_FISHEYE_CAPS*
    COMPOSITE_CAPS = 0x04,               // 根据指定的窗口号预先获取融合后的能力集, pInBuf=NET_IN_COMPOSITE_CAPS*, pOutBuf=NET_OUT_COMPOSITE_CAPS*
    VIDEO_DETECT_CAPS = 0x05,               // 获取视频检测输入能力集,pInBuf=NET_IN_VIDEO_DETECT_CAPS* , pOutBuf=NET_OUT_VIDEO_DETECT_CAPS*
    THERMO_GRAPHY_CAPS = 0x06,               // 热成像摄像头属性能力,pInBuf=NET_IN_THERMO_GETCAPS*, pOutBuf=NET_OUT_THERMO_GETCAPS*
    RADIOMETRY_CAPS = 0x07,               // 热成像测温全局配置能力,pInBuf=NET_IN_RADIOMETRY_GETCAPS*, pOutBuf=NET_OUT_RADIOMETRY_GETCAPS*
    POS_CAPS = 0x08,               // POS机能力,pInBuf = NET_IN_POS_GETCAPS *, pOutBuf = NET_OUT_POS_GETCAPS *
    USER_MNG_CAPS = 0x09,               // 用户管理能力, pInBuf = NET_IN_USER_MNG_GETCAPS *, pOutBuf = NET_OUT_USER_MNG_GETCAPS *
    MEDIAMANAGER_CAPS = 0x0a,               // 获取 VideoInput 的各个能力项,pInBuf=NET_IN_MEDIAMANAGER_GETCAPS*, pOutBuf=NET_OUT_MEDIAMANAGER_GETCAPS*
    VIDEO_MOSAIC_CAPS = 0x0b,       // 获取通道马赛克叠加能力,pInBuf=NET_IN_MEDIA_VIDEOMOSAIC_GETCAPS*, pOutBuf=NET_OUT_MEDIA_VIDEOMOSAIC_GETCAPS*
    SNAP_CFG_CAPS = 0x0c,                // 设备抓图配置对应能力, pInBuf=NET_IN_SNAP_CFG_CAPS*, pOutBuf= NET_OUT_SNAP_CFG_CAPS*
    VIDEOIN_CAPS = 0x0d,                // 设备视频输出能力, pInBUf = NET_IN_VIDEOIN_CAPS*, pOutBuf = NET_OUT_VIDEOIN_CAPS*
    FACE_BOARD_CAPS = 0x0e,                // 面板设备能力集, pInBuf = NET_IN_FACEBOARD_CAPS*, pOutBuf = NET_OUT_FACEBOARD_CAPS*
    EXTERNALSENSOR_CAPS = 0x0f,       // 外部传感器管理能力集，pInBuf = NET_IN_EXTERNALSENSOR_CAPS*, pOutBuf = NET_OUT_EXTERNALSENSOR_CAPS*
    VIDEO_IMAGECONTROL_CAPS = 0x10,       // 图像旋转设置能力, pInBuf = NET_IN_VIDEO_IMAGECONTROL_CAPS*, pOutBuf = NET_OUT_VIDEO_IMAGECONTROL_CAPS*
    VIDEOIN_EXPOSURE_CAPS = 0x11,       // 曝光设置能力, pInBuf = NET_IN_VIDEOIN_EXPOSURE_CAPS*, pOutBuf = NET_OUT_VIDEOIN_EXPOSURE_CAPS*
    VIDEOIN_DENOISE_CAPS = 0x12,        // 降噪能力, pInBuf = NET_IN_VIDEOIN_DENOISE_CAPS*, pOutBuf = NET_OUT_VIDEOIN_DENOISE_CAPS*
    VIDEOIN_BACKLIGHT_CAPS = 0x13,        // 背光设置能力, pInBuf = NET_IN_VIDEOIN_BACKLIGHT_CAPS*, pOutBuf = NET_OUT_VIDEOIN_BACKLIGHT_CAPS*
    VIDEOIN_WHITEBALANCE_CAPS = 0x14,       // 白平衡设置能力, pInBuf = NET_IN_VIDEOIN_WHITEBALANCE_CAPS*, pOutBuf = NET_OUT_VIDEOIN_WHITEBALANCE_CAPS*
    VIDEOIN_DAYNIGHT_CAPS = 0x15,       // 球机机芯日夜设置能力, pInBuf = NET_IN_VIDEOIN_DAYNIGHT_CAPS*, pOutBuf = NET_OUT_VIDEOIN_DAYNIGHT_CAPS*
    VIDEOIN_ZOOM_CAPS = 0x16,       // 变倍设置能力, pInBuf = NET_IN_VIDEOIN_ZOOM_CAPS*, pOutBuf = NET_OUT_VIDEOIN_ZOOM_CAPS*
    VIDEOIN_FOCUS_CAPS = 0x17,        // 聚焦设置能力, pInBuf = NET_IN_VIDEOIN_FOCUS_CAPS*, pOutBuf = NET_OUT_VIDEOIN_FOCUS_CAPS*
    VIDEOIN_SHARPNESS_CAPS = 0x18,        // 锐度设置能力, pInBuf = NET_IN_VIDEOIN_SHARPNESS_CAPS*, pOutBuf = NET_OUT_VIDEOIN_SHARPNESS_CAPS*
    VIDEOIN_COLOR_CAPS = 0x19,        // 图像设置能力, pInBuf = NET_IN_VIDEOIN_COLOR_CAPS*, pOutBuf = NET_OUT_VIDEOIN_COLOR_CAPS*
    GET_MASTERSLAVEGROUP_CAPS = 0x1a,       // 获取跟踪业务能力, pInBuf = NET_IN_GET_MASTERSLAVEGROUP_CAPS*, pOutBuf = NET_OUT_GET_MASTERSLAVEGROUP_CAPS*
    FACERECOGNITIONSE_CAPS = 0x1b,        // 人脸识别服务器能力查询 pInBuf = NET_IN_FACERECOGNITIONSERVER_CAPSBILITYQUERY, pOutBuf = NET_OUT_FACERECOGNITIONSERVER_CAPSBILITYQUERY *
    STORAGE_CAPS = 0x1c,        // 获取存储能力集, pInBuf = NET_IN_STORAGE_CAPS*, pOutBuf = NET_OUT_STORAGE_CAPS*
    VIDEOIN_RAWFRAME_CAPS = 0x1d,       // 获取视频输入扩展能力集, pInBuf = NET_IN_VIDEOIN_RAWFRAME_CAPS*, pOutBuf = NET_OUT_VIDEOIN_RAWFRAME_CAPS*
    COAXIAL_CONTROL_IO_CAPS = 0x1e,       // 获取同轴IO控制能力, pInBuf = NET_IN_GET_COAXIAL_CONTROL_IO_CAPS*, pOutBuf = NET_OUT_GET_COAXIAL_CONTROL_IO_CAPS*
    FACEINFO_CAPS = 0x1f,                // 获得人脸门禁控制器能力集, pInBuf = NET_IN_GET_FACEINFO_CAPS*, pOutBuf = NET_OUT_GET_FACEINFO_CAPS*
  }

  // 获取设备编码配置对应能力输入参数
  public struct NET_IN_ENCODE_CFG_CAPS
  {
    public uint dwSize;
    public int nChannelId;                         // 通道号    
    public int nStreamType;                        // 码流类型,0：主码流；1：辅码流1；2：辅码流2；3：辅码流3；4：抓图码流
                                                   // 此参数可以不填,不论指定什么类型,设备都返回主、辅、抓图码流的能力
    public IntPtr pchEncodeJson;                      // Encode配置,通过调用dhconfigsdk.dll中接口CLIENT_PacketData封装得到
                                                      // 对应的封装命令为 CFG_CMD_ENCODE                 
  }

  // 获取设备编码配置对应能力输出参数
  public struct NET_OUT_ENCODE_CFG_CAPS
  {
    public uint dwSize;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public NET_STREAM_CFG_CAPS[] stuMainFormatCaps;         // 主码流配置对应能力, 如果有多个, 第一个表示普通录像码流, 第二个表示动检录像码流, 第三个表示报警录像码流
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public NET_STREAM_CFG_CAPS[] stuExtraFormatCaps;        // 辅码流配置对应能力, 如果有多个, 第一个表示辅码流1, 第二个表示辅码流2, 第三个表示辅码流3
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public NET_STREAM_CFG_CAPS[] stuSnapFormatCaps;           // 抓图码流配置对应能力, 如果有多个, 第一个表示普通抓图, 第二个表示动检抓图, 第三个表示报警抓图
    public int nMainFormCaps;                              // 有效的主码流配置对应的能力个数
    public int nExtraFormCaps;                             // 有效的辅码流配置对应的能力个数
    public int nSnapFormatCaps;                            // 有效的抓图码流配置对应的能力个数
  }

  // 码流配置对应能力
  public struct NET_STREAM_CFG_CAPS
  {
    public uint dwSize;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public int[] nAudioCompressionTypes; // 支持的音频编码类型,详见DH_TALK_CODING_TYPE
    public int nAudioCompressionTypeNum;                   // 音频压缩格式个数
    public int dwEncodeModeMask;                           // 视频编码模式掩码,详见"编码模式"
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public NET_RESOLUTION_INFO[] stuResolutionTypes;// 支持的视频分辨率
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public int[] nResolutionFPSMax; // 不同分辨率下帧率最大值,下标与nResolutionTypes对应 
    public int nResolutionTypeNum;                         // 视频分辨率个数
    public int nMaxBitRateOptions;                         // 最大视频码流(kbps) 
    public int nMinBitRateOptions;                         // 最小视频码流(kbps)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bH264ProfileRank;          // 支持的H.264 Profile等级,参照枚举类型 EM_H264_PROFILE_RANK;  
    public int nH264ProfileRankNum;                        // 支持的H.264 Profile等级个数
    public int nCifPFrameMaxSize;                          // 当分辨率为cif时最大p帧(Kbps)
    public int nCifPFrameMinSize;                          // 当分辨率为cif时最小p帧(Kbps)
    public int nFPSMax;                                    // 视频帧率最大值,为0时,以nResolutionFPSMax为准
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 64)]
    public NET_RESOLUTION_INFO[] stuIndivResolutionTypes;// 支持的视频分辨率
    public bool abIndivResolution;              // 0: stuResolutionTypes,nResolutionTypeNum 有效 
                                                // 1: stuIndivResolutionTypes, nIndivResolutionNums 有效
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public int[] nIndivResolutionNums;// 不同编码模式分别支持的视频分辨率个数
  }

  // 主(辅)码流视频格式profile配置(f6/bin)
  public struct NET_ENCODE_VIDEO_PROFILE_INFO
  {
    public uint dwSize;
    public EM_FORMAT_TYPE emFormatType;       // 码流类型,设置和获取时都需要设置值
    public EM_H264_PROFILE_RANK emProfile;                  // H.264编码级别
  }

  // H264 编码级别
  public enum EM_H264_PROFILE_RANK
  {
    UNKNOWN,                 // 未知类型
    BASELINE = 1,                       // 提供I/P帧，仅支持progressive(逐行扫描)和CAVLC
    MAIN,                               // 提供I/P/B帧，支持progressiv和interlaced，提供CAVLC或CABAC
    EXTENDED,                           // 提供I/P/B/SP/SI帧，仅支持progressive(逐行扫描)和CAVLC
    HIGH,                               // 即FRExt，Main_Profile基础上新增：8x8 intra prediction(8x8 帧内预测), custom 
                                        // quant(自定义量化), lossless video coding(无损视频编码), 更多的yuv格式
  }

  public enum EM_LISTEN_TYPE
  {
    /// <summary>
    /// 
    /// 验证期间设备断线回调
    /// </summary>
    NET_DVR_DISCONNECT = -1,
    /// <summary>
    /// 
    /// 设备注册携带序列号 对应 char* szDevSerial
    /// </summary>
    NET_DVR_SERIAL_RETURN = 1,
    /// <summary>
    /// 
    /// 设备注册携带序列号和令牌 对应NET_CB_AUTOREGISTER
    /// </summary>
    NET_DEV_AUTOREGISTER_RETURN,
    /// <summary>
    /// 
    /// 设备仅上报IP, 不作为主动注册用, 用户获取ip后只能按照约定的端口按照非主动注册的类型登录
    /// </summary>
    NET_DEV_NOTIFY_IP_RETURN,
  }

  // product definition
  public struct NET_PRODUCTION_DEFNITION
  {
    public uint dwSize;
    public int nVideoInChannel;       // Video input channel amount
    public int nVideoOutChannel;        // Video output channel amount
    public int nRemoteDecChannel;       // Remote decode channel amount
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevType;    // Device type
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szVendor;   // OEM customer
    public int nOEMVersion;         // OEM version
    public int nMajorVerion;          // Main version No.
    public int nMinorVersion;         // SUb version No.
    public int nRevision;           // Revision version
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szWebVerion;  // Web version
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szDefLanguage;  // Default setup
    public NET_TIME stuBuildDateTime;       // Release time. Unit is second.
    public int nAudioInChannel;       // Audio input channel amount
    public int nAudioOutChannel;        // Audio output channel amount
    public bool bGeneralRecord;         // Support schedule storage or not.
    public bool bLocalStore;          // Support local storage or not.
    public bool bRemoteStore;         // Support network storage or not.
    public bool bLocalurgentStore;        // Support emergency local storage or not.
    public bool bRealtimeCompress;        // Support real-time compression storage or not.
    public uint dwVideoStandards;       // The video format supported. bit0-PAL, bit1-NTSC
    public int nDefVideoStandard;       // Default video format, 0-PAL, 1-NTSC
    public int nMaxExtraStream;       // Max extra stream channel amount
    public int nRemoteRecordChannel;      // Remote record channel amount
    public int nRemoteSnapChannel;        // Remote snap channel amount
    public int nRemoteVideoAnalyseChannel;    // Remote video analysis channel amount
    public int nRemoteTransmitChannel;      // Remote real-time stream transmit max channel amount
    public int nRemoteTransmitFileChannel;    // Remote transmit file channel amount
    public int nStreamTransmitChannel;      // Max network transmit channel amount
    public int nStreamReadChannel;        // Max read file channel amount
    public int nMaxStreamSendBitrate;     // Max bit stream network send capability, kbps
    public int nMaxStreamRecvBitrate;     // Max bit stream network interface capability, kbps
    public bool bCompressOldFile;       // Old compression file or not. Delete P frame and save I frame.
    public bool bRaid;              // Support RAID or not.
    public int nMaxPreRecordTime;       // Max pre-record time.Unit is second.
    public bool bPtzAlarm;            // Support PTZ alarm or not.
    public bool bPtz;             // Support PTZ or not.
    public bool bATM;             // Support corresponding function of the ATM or not.
    public bool b3G;              // Support 3G module or not.
    public bool bNumericKey;          // With number button or not.
    public bool bShiftKey;            // With Shift button or not.
    public bool bCorrectKeyMap;         // Number character map sheet is right or not.
    public bool bNewATM;            // The new 2nd ATM front panel.
    public bool bDecoder;           // Decoder or not
    public NET_DEV_DECODER_INFO stuDecoderInfo;         // Decoder info. Valid when bDecoder=true.bDecoder=true
    public int nVideoOutputCompositeChannels; // integration ceiling screen output channel
    public bool bSupportedWPS;                  // support WPS or not
    public int nVGAVideoOutputChannels;   // VGA video output channel number
    public int nTVVideoOutputChannels;      // TV video output channel number
    public int nMaxRemoteInputChannels;   // max number of remote channels
    public int nMaxMatrixInputChannels;   // max number of matrix channels
    public int nMaxRoadWays;                   // max counts of road ways 1~6
    public int nMaxParkingSpaceScreen;         // max counts of screen when docking with the camera 0~20
    public int nPtzHorizontalAngleMin;      // PTZ'horizontal minimum Angle, [0-360]
    public int nPtzHorizontalAngleMax;      // PTZ'horizontal maximum Angle, [0-360]
    public int nPtzVerticalAngleMin;      // PTZ'vertical  minimum Angle, [-90,90]
    public int nPtzVerticalAngleMax;      // PTZ'vertical  maximum Angle, [-90,90]
    public bool bPtzFunctionMenu;       // Whether to support PTZ's function menu 
    public bool bLightingControl;       // Whether to support lighting control 
    public uint dwLightingControlMode;      // Manual lighting control mode,bitwise,see NET_LIGHTING_CTRL_ON_OFF
    public int nNearLightNumber;        // dipped headlight group number, 0 means no support 
    public int nFarLightNumber;       // High beam group number, 0 means no support
    public bool bFocus;             // Whether to support control focus 
    public bool bIris;              // Whether to support control aperture 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 1024)]
    public string szPtzProtocolList;  // PTZ support agreement list, can be more, each with '; 'delimited 
    public bool bRainBrushControl;        // Whether to support wiper control 
    public int nBrushNumber;          // Number of wiper, 0 means no support
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public int[] nLowerMatrixInputChannels;   // inferior video matrix input channel, the subscript corresponding matrix number 
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public int[] nLowerMatrixOutputChannels;  // inferior video matrix output channel, the subscript corresponding matrix number 
    public bool bSupportVideoAnalyse;           // support intelligent analuysis or not
    public bool bSupportIntelliTracker;         // support intelligen tracking or not
    public uint nSupportBreaking;               // device supported violation type mask(by bit Get )                                               
    public uint nSupportBreaking1;              // 0-driver call 1-trafic-pedestrian redlight running 2-Traffic Jam Forbid Into 3-Pass Not In Order
    public NET_PD_VIDEOANALYSE stuVideoAnalyse;                // IVS
    public bool bTalkTransfer;                  // support talk-transfer or not
    public bool bCameraAttribute;       // support video in options or not
    public bool bPTZFunctionViaApp;       // support PTZ function or not
    public bool bAudioProperties;       // support audio properties or not
    public bool bIsCameraIDOsd;         // support camera id osd or not
    public bool bIsPlaceOsd;          // support place osd or not
    public uint nMaxGeographyTitleLine;     // the max geography title line
    public EM_AUDIO_CHANNEL_TYPE emAudioChannel;        // the audio channel type
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szVendorAbbr;                                     // 厂商缩写 Vendor abbreviation
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szTypeVersion;              // 软件发布类型 Software release type
  }

  // intelligent analysis
  public struct NET_PD_VIDEOANALYSE
  {
    public bool bSupport;                   // whether supported 
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_SUPPROTSCENE[] szSupportScenes;   // supported scenes name
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public NET_SUPPORTRULE[] szSupportRules;       // supported rules name
  }

  public struct NET_SUPPROTSCENE
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName; //supported scene name
  }

  public struct NET_SUPPORTRULE
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName; //supported rule name
  }

  // audio channel type
  public enum EM_AUDIO_CHANNEL_TYPE
  {
    SINGLE,   // single
    DOUBLE,   // double
  }

  // Decoder information
  public struct NET_DEV_DECODER_INFO
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDecType;      // type
    public int nMonitorNum;     // TV number
    public int nEncoderNum;     // Decoder channel number
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] szSplitMode;    // Supported by a number of TV screen partition
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public byte[] bMonitorEnable;   // TV enable
    public byte bTVTipDisplay;          // TV tip display enable 0:not support 1:support.
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 3)]
    public byte[] reserved1;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 48)]
    public byte[] byLayoutEnable;     // every channel's tip display enable
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public uint[] dwLayoutEnMask;      // Each decoding channel displays overlay info enable mask, from low to high support 64 channels, while dwLayoutEnMask[0] is low 32 bit
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] reserved;
  }

  // Device software version information. Corresponding to CLIENT_QueryDevState
  public struct NET_DEV_VERSION_INFO
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szDevSerialNo;  // Serial number 
    public byte byDevType;              // Device type, please refer to NET_DEVICE_TYPE
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevType;      // Device detailed type. String format. It may be null.
    public int nProtocalVer;            // Protocol version number 
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szSoftWareVersion;
    public uint dwSoftwareBuildDate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szPeripheralSoftwareVersion;// From the Slice Version Information, The String Format, May Be Empty
    public uint dwPeripheralSoftwareBuildDate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szGeographySoftwareVersion; // Geographical Iinformation Positioning Chip Version Information, The String Format, May Be empty
    public uint dwGeographySoftwareBuildDate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szHardwareVersion;
    public uint dwHardwareDate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szWebVersion;
    public uint dwWebBuildDate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDetailType;          // Device detailed type. String format. It may be null.
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 192)]
    public byte[] reserved;
  }

  // NTP setup 
  public struct NET_DEV_NTP_CFG
  {
    public bool bEnable;        // Enable or not
    public int nHostPort;       // NTP  server default port is 123
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szHostIp;     // Host IP
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDomainName;   // Domain name 
    public int nType;         // Read only ,0:IP,1:domain name ,2:IP and domain name 
    public int nUpdateInterval;   // Update time(minute)
    public EM_TIME_ZONE_TYPE emTimeZone;        // Please refer to EM_TIME_ZONE_TYPE
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] reserved;
  }

  public enum EM_TIME_ZONE_TYPE
  {
    ZONE_0,               // {0, 0*3600,"GMT+00:00"}
    ZONE_1,               // {1, 1*3600,"GMT+01:00"}
    ZONE_2,               // {2, 2*3600,"GMT+02:00"}
    ZONE_3,               // {3, 3*3600,"GMT+03:00"}
    ZONE_4,               // {4, 3*3600+1800,"GMT+03:30"}
    ZONE_5,               // {5, 4*3600,"GMT+04:00"}
    ZONE_6,               // {6, 4*3600+1800,"GMT+04:30"}
    ZONE_7,               // {7, 5*3600,"GMT+05:00"}
    ZONE_8,               // {8, 5*3600+1800,"GMT+05:30"}
    ZONE_9,               // {9, 5*3600+1800+900,"GMT+05:45"}
    ZONE_10,              // {10, 6*3600,"GMT+06:00"}
    ZONE_11,              // {11, 6*3600+1800,"GMT+06:30"}
    ZONE_12,              // {12, 7*3600,"GMT+07:00"}
    ZONE_13,              // {13, 8*3600,"GMT+08:00"}
    ZONE_14,              // {14, 9*3600,"GMT+09:00"}
    ZONE_15,              // {15, 9*3600+1800,"GMT+09:30"}
    ZONE_16,              // {16, 10*3600,"GMT+10:00"}
    ZONE_17,              // {17, 11*3600,"GMT+11:00"}
    ZONE_18,              // {18, 12*3600,"GMT+12:00"}
    ZONE_19,              // {19, 13*3600,"GMT+13:00"}
    ZONE_20,              // {20, -1*3600,"GMT-01:00"}
    ZONE_21,              // {21, -2*3600,"GMT-02:00"}
    ZONE_22,              // {22, -3*3600,"GMT-03:00"}
    ZONE_23,              // {23, -3*3600-1800,"GMT-03:30"}
    ZONE_24,              // {24, -4*3600,"GMT-04:00"}
    ZONE_25,              // {25, -5*3600,"GMT-05:00"}
    ZONE_26,              // {26, -6*3600,"GMT-06:00"}
    ZONE_27,              // {27, -7*3600,"GMT-07:00"}
    ZONE_28,              // {28, -8*3600,"GMT-08:00"}
    ZONE_29,              // {29, -9*3600,"GMT-09:00"}
    ZONE_30,              // {30, -10*3600,"GMT-10:00"}
    ZONE_31,              // {31, -11*3600,"GMT-11:00"}
    ZONE_32,              // {32, -12*3600,"GMT-12:00"}
  }

  //High decibel alarm info, corresponding to DH_ALARM_HIGH_DECIBEL alarm
  public struct NET_ALARM_HIGH_DECIBEL_INFO
  {
    public int nAudioChannel;                  // Audio channel NO. 
    public int nAction;                        // -1:unknown, 0:pulse, 1:start, 2:stop
    public NET_TIME_EX stuTime;                        // Event occurrence time
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byReserved;               // reserved
  }

  // Recording-changed alarm information(DH_ALARM_RECORD_CHANGED_EX)
  public struct NET_ALARM_RECORD_CHANGED_INFO_EX
  {
    public int nAction;                             // 0:start 1:stop
    public int nChannel;                            // channel
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szStoragePoint;                     // StoragePoint
    public EM_STREAM_TYPE emStreamType;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]           // stream type
    public string szUser;                         // username
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 828)]
    public byte[] byReserved;           // reserved 
  }

  // Alarm of record schedule change (Corresponding to ALARM_RECORD_SCHEDULE_CHANGE_INFO)
  public struct NET_ALARM_RECORD_SCHEDULE_CHANGE_INFO
  {
    public int nChannelID;                // Channel ID
    public int nEventID;                // Event ID
    public double dbPTS;                  // Time stamp (Unit:ms)
    public NET_TIME_EX stuTime;               // Event occurrence time 				
    public int nEventAction;              // Event operation. 0=pulse event.1=continues event begin. 2=continuous event stop
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUser;                             // Username
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byReserved;                   // Reserved
  }

  // Alarm of NTP change (Corresponding to ALARM_NTP_CHANGE_INFO)
  public struct NET_ALARM_NTP_CHANGE_INFO
  {
    public int nEventID;                // Event ID
    public int nEventAction;              // Event operation. 0=pulse event.1=continues event begin. 2=continuous event stop
    public double dbPTS;                  // Time stamp (Unit:ms)
    public NET_TIME_EX stuTime;               // Event occurrence time 	
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szUser;     // Username
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] byReserved;           // Reserved
  }

  public enum EM_QUERY_DEV_INFO
  {
    STORAGE_NAMES = 0x01,
    STORAGE_INFOS,
    RECENCY_JNNCTION_CAR_INFO,
    LANES_STATE,                                       // 查询车道信息,pInBuf = NET_IN_GET_LANES_STATE , pOutBuf = NET_OUT_GET_LANES_STATE
    FISHEYE_WININFO,                               // 查询鱼眼窗口信息 , pInBuf= NET_IN_FISHEYE_WININFO*, pOutBuf=NET_OUT_FISHEYE_WININFO *
    REMOTE_DEVICE_INFO,                           // 查询远程设备信息 , pInBuf= NET_IN_GET_DEVICE_INFO*, pOutBuf= NET_OUT_GET_DEVICE_INFO *
    SYSTEM_INFO,                                      // 查询设备系统信息 , pInBuf= NET_IN_SYSTEM_INFO*, pOutBuf= NET_OUT_SYSTEM_INFO*
    REG_DEVICE_NET_INFO,                              // 查询主动注册设备的网络连接 , pInBuf=NET_IN_REGDEV_NET_INFO * , pOutBuf=NET_OUT_REGDEV_NET_INFO *
    THERMO_GRAPHY_PRESET,                          // 查询热成像预设信息 , pInBuf= NET_IN_THERMO_GET_PRESETINFO*, pOutBuf= NET_OUT_THERMO_GET_PRESETINFO *
    THERMO_GRAPHY_OPTREGION,                       // 查询热成像感兴趣区域信息,pInBuf= NET_IN_THERMO_GET_OPTREGION*, pOutBuf= NET_OUT_THERMO_GET_OPTREGION *
    THERMO_GRAPHY_EXTSYSINFO,                     // 查询热成像外部系统信息, pInBuf= NET_IN_THERMO_GET_EXTSYSINFO*, pOutBuf= NET_OUT_THERMO_GET_EXTSYSINFO *
    RADIOMETRY_POINT_TEMPER,                       // 查询测温点的参数值, pInBuf= NET_IN_RADIOMETRY_GETPOINTTEMPER*, pOutBuf= NET_OUT_RADIOMETRY_GETPOINTTEMPER *
    RADIOMETRY_TEMPER,                             // 查询测温项的参数值, pInBuf= NET_IN_RADIOMETRY_GETTEMPER*, pOutBuf= NET_OUT_RADIOMETRY_GETTEMPER *
    GET_CAMERA_STATE,                                  // 获取摄像机状态, pInBuf= NET_IN_GET_CAMERA_STATEINFO*, pOutBuf= NET_OUT_GET_CAMERA_STATEINFO *
    GET_REMOTE_CHANNEL_AUDIO_ENCODE,                   // 获取远程通道音频编码方式, pInBuf= NET_IN_GET_REMOTE_CHANNEL_AUDIO_ENCODEINFO*, pOutBuf= NET_OUT_GET_REMOTE_CHANNEL_AUDIO_ENCODEINFO *
    GET_COMM_PORT_INFO,                                // 获取设备串口信息, pInBuf=NET_IN_GET_COMM_PORT_INFO* , pOutBuf=NET_OUT_GET_COMM_PORT_INFO* 
    GET_LINKCHANNELS,                                 // 查询某视频通道的关联通道列表,pInBuf=NET_IN_GET_LINKCHANNELS* , pOutBuf=NET_OUT_GET_LINKCHANNELS*
    GET_VIDEOOUTPUTCHANNELS,                           // 获取解码通道数量统计信息, pInBuf=NET_IN_GET_VIDEOOUTPUTCHANNELS*, pOutBuf=NET_OUT_GET_VIDEOOUTPUTCHANNELS*
    GET_VIDEOINFO,                                     // 获取解码通道信息, pInBuf=NET_IN_GET_VIDEOINFO*, pOutBuf=NET_OUT_GET_VIDEOINFO*
    GET_ALLLINKCHANNELS,                              // 查询全部视频关联通道列表,pInBuf=NET_IN_GET_ALLLINKCHANNELS* , pOutBuf=NET_OUT_GET_ALLLINKCHANNELS*
    VIDEOCHANNELSINFO,                                 // 查询视频通道信息,pInBuf=NET_IN_GET_VIDEOCHANNELSINFO* , pOutBuf=NET_OUT_GET_VIDEOCHANNELSINFO*
    TRAFFICRADAR_VERSION,                              // 查询雷达设备版本,pInBuf=NET_IN_TRAFFICRADAR_VERSION* , pOutBuf=NET_OUT_TRAFFICRADAR_VERSION*
    WORKGROUP_NAMES,                                   // 查询所有的工作目录组名,pInBuf=NET_IN_WORKGROUP_NAMES* , pOutBuf=NET_OUT_WORKGROUP_NAMES*
    WORKGROUP_INFO,                                   // 查询工作组信息,pInBuf=NET_IN_WORKGROUP_INFO* , pOutBuf=NET_OUT_WORKGROUP_INFO*
    WLAN_ACCESSPOINT,                                  // 查询无线网络接入点信息,pInBuf=NET_IN_WLAN_ACCESSPOINT* , pOutBuf=NET_OUT_WLAN_ACCESSPOINT*
    GPS_INFO,                     // 查询设备GPS信息,pInBuf=NET_IN_DEV_GPS_INFO* , pOutBuf=NET_OUT_DEV_GPS_INFO*
    IVS_REMOTE_DEVICE_INFO,                            // 查询IVS的前端设备所关联的远程设备信息, pInBuf = NET_IN_IVS_REMOTE_DEV_INFO*, pOutBuf = NET_OUT_IVS_REMOTE_DEV_INFO*
    SMART_SWITCH_INFO,                                 // 查询智能插座信息, pInBuf = NET_IN_SMART_SWITCH_INFO*,  pOutBuf = NET_OUT_SMART_SWITCH_INFO*
    UPGRADE_STATE,                                     // 查询升级状态信息, pInBuf = NET_IN_UPGRADE_STATE*, pOutBuf = NET_OUT_UPGRADE_STATE* 
    VIDEO_ENCODE_CAPS,                  // 获取视频编码能力集, pInBuf = NET_IN_VIDEO_ENCODE_CAPS*, pOutBuf = NET_OUT_VIDEO_ENCODE_CAPS* 
    AUDIO_ENCODE_CAPS,                  // 获取音频编码能力集, pInBuf = NET_IN_AUDIO_ENCODE_CAPS*, pOutBuf = NET_OUT_AUDIO_ENCODE_CAPS* 
    AUDIO_IN_CAPS,                    // 获取音频输入通道能力集, pInBuf = NET_IN_AUDIO_IN_CAPS*, pOutBuf = NET_OUT_AUDIO_IN_CAPS* 
    SMART_ENCODE_CAPS,                  // 查询Smart编码能力集, pInBuf = NET_IN_SMART_ENCODE_CAPS*, pOutBuf = NET_OUT_SMART_ENCODE_CAPS* 
    HARDDISK_TEMPERATURE,               // 获取硬盘温度,pInBuf = NET_IN_HDD_TEMPERATURE*, pOutBuf = NET_OUT_HDD_TEMPERATURE*
    RAWFRAMEDATA,                   // 获取指定格式的YUV数据, pInBuf = NET_IN_RAWFRAMEDATA*, pOutBuf = NET_OUT_RAWFRAMEDARA*
  }

  // CLIENT_QueryDevInfo 接口 NET_QUERY_DEV_RADIOMETRY_POINT_TEMPER 命令入参
  public struct NET_IN_RADIOMETRY_GETPOINTTEMPER
  {
    public uint dwSize;
    public int nChannel;                           // 通道号
    public NET_POINT stCoordinate;                       // 测温点的坐标,坐标值 0~8192
  };

  // CLIENT_QueryDevInfo 接口 NET_QUERY_DEV_RADIOMETRY_POINT_TEMPER 命令出参
  public struct NET_OUT_RADIOMETRY_GETPOINTTEMPER
  {
    public uint dwSize;
    public NET_RADIOMETRYINFO stPointTempInfo;                    // 获取测温点的参数值
  }

  // 测温模式的类型
  public enum EM_RADIOMETRY_METERTYPE
  {
    UNKNOWN,
    SPOT,                          // 点
    LINE,                          // 线
    AREA,                          // 区域
  }

  // 获取测温项温度的条件   
  public struct NET_RADIOMETRY_CONDITION
  {
    public int nPresetId;                          // 预置点编号    
    public int nRuleId;                            // 规则编号 
    public int nMeterType;                         // 测温项类别,见EM_RADIOMETRY_METERTYPE
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName;                         // 测温项的名称,从测温配置规则名字中选取
    public int nChannel;                           // 通道号
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] reserved;
  }

  // CLIENT_QueryDevInfo 接口 NET_QUERY_DEV_RADIOMETRY_TEMPER 命令入参
  public struct NET_IN_RADIOMETRY_GETTEMPER
  {
    public uint dwSize;
    public NET_RADIOMETRY_CONDITION stCondition;                // 获取测温项温度的条件
  };

  // CLIENT_QueryDevInfo 接口 NET_QUERY_DEV_RADIOMETRY_TEMPER 命令出参
  public struct NET_OUT_RADIOMETRY_GETTEMPER
  {
    public uint dwSize;
    public NET_RADIOMETRYINFO stTempInfo;                         // 获取测温参数值
  }

  /// <summary>
  /// QueryDevInfo 接口 NET_IN_GET_CAMERA_STATEINFO 命令入参
  /// </summary>
  public struct NET_IN_GET_CAMERA_STATEINFO
  {
    public uint dwSize;
    /// <summary>
    /// 是否查询所有摄像机状态,若该成员为 TRUE,则 nChannels 成员无需设置
    /// if it is to check all the cameras status, if the member is TRUE, then nChannels member is unnecessary to set.
    /// </summary>
    public bool bGetAllFlag;
    /// <summary>
    /// 该成员,bGetAllFlag 为 FALSE时有效,表示 nChannels 成员有效个数
    /// the member is valid when bGetAllFlag is FALSE, which means valid number of nChannels member
    /// </summary>
    public int nValidNum;
    /// <summary>
    /// 该成员,bGetAllFlag 为 FALSE时有效,将需要查询的通道号依次填入
    /// The member is valid when bGetAllFlag is FALSE, it is to fill in the channel numbers in turn which needs inquiry. 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public int[] nChannels;
  }

  public enum EM_CAMERA_STATE_TYPE
  {
    /// <summary>
    /// 未知
    /// unknown
    /// </summary>
    UNKNOWN,
    /// <summary>
    /// 正在连接
    /// connecting
    /// </summary>
    CONNECTING,
    /// <summary>
    /// 已连接
    /// connected
    /// </summary>
    CONNECTED,
    /// <summary>
    /// 未连接
    /// unconnected
    /// </summary>
    UNCONNECT,
    /// <summary>
    /// 通道未配置,无信息
    /// channel is not configured, no info
    /// </summary>
    EMPTY,
    /// <summary>
    /// 通道有配置,但被禁用
    /// channel is configured, but it is forbidden. 
    /// </summary>
    DISABLE,
  }

  public struct NET_CAMERA_STATE_INFO
  {
    /// <summary>
    /// 摄像机通道号, -1表示通道号无效
    /// camera channel number, -1 means invalid channel number
    /// </summary>
    public int nChannel;
    /// <summary>
    /// 连接状态
    /// connection state
    /// </summary>
    public EM_CAMERA_STATE_TYPE emConnectionState;
    /// <summary>
    /// 保留字节
    /// byte reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] szReserved;
  }

  /// <summary>
  /// QueryDevInfo 接口 NET_QUERY_GET_CAMERA_STATE 命令出参
  /// </summary>
  public struct NET_OUT_GET_CAMERA_STATEINFO
  {
    public uint dwSize;
    /// <summary>
    /// 查询到的摄像机通道状态有效个数,由sdk返回
    /// valid number of camera channel state, returned by sdk
    /// </summary>
    public int nValidNum;
    /// <summary>
    /// pCameraStateInfo 数组最大个数,由用户填写
    /// max number of array, filled in by user
    /// </summary>
    public int nMaxNum;
    /// <summary>
    /// 摄像机通道信息数组,由用户分配,大小为sizeof(NET_CAMERA_STATE_INFO)*nMaxNum
    /// camera channel info array, distributed by user,apply to sizeof(NET_CAMERA_STATE_INFO)*nMaxNum
    /// </summary>
    public IntPtr pCameraStateInfo;
  }


  /// <summary>
  /// 虚拟摄像头状态查询
  /// Virtual camera status search
  /// </summary>
  public struct NET_VIRTUALCAMERA_STATE_INFO
  {
    /// <summary>
    /// 结构体大小
    /// Structure body size
    /// </summary>
    public uint nStructSize;
    /// <summary>
    /// 通道号
    /// Channel No.
    /// </summary>
    public int nChannelID;
    /// <summary>
    /// 连接状态
    /// Connection status
    /// </summary>
    public EM_CONNECT_STATE emConnectState;
    /// <summary>
    /// 此虚拟摄像头所连接的POE端口号,0表示不是POE连接
    /// The PoE port the virtual camera connected to. 0=It is not a PoE connection.
    /// </summary>
    public uint uiPOEPort;
    /// <summary>
    /// 设备名称
    /// Device name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDeviceName;
    /// <summary>
    /// 设备类型
    /// Device type
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szDeviceType;
    /// <summary>
    /// 系统版本
    /// system type
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szSystemType;
    /// <summary>
    /// 序列号
    /// serial no
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 48)]
    public string szSerialNo;
    /// <summary>
    /// 视频输入
    /// video input number
    /// </summary>
    public int nVideoInput;
    /// <summary>
    /// 音频输入
    /// audio input number
    /// </summary>
    public int nAudioInput;
    /// <summary>
    /// 外部报警
    /// alarm output number
    /// </summary>
    public int nAlarmOutput;
  }

  /// <summary>
  /// CLIENT_AttachCameraState()输入参数
  /// AttachCameraState()input param
  /// </summary>
  public struct NET_IN_CAMERASTATE
  {
    public uint dwSize;
    /// <summary>
    /// 观察的通道号,数组元素中,有一个是-1,则观察所有通道 由用户申请内存，大小为sizeof(int)*nChannels
    /// observation of the channel, if the value = -1,is boservate all channel, the space application by the user,apply to  sizeof(int)*nChannels
    /// </summary>
    public IntPtr pChannels;
    /// <summary>
    /// pChannels指针长度
    /// length of pChannels pointer
    /// </summary>
    public int nChannels;
    /// <summary>
    /// 状态回调函数
    /// state of callback function
    /// </summary>
    public fCameraStateCallBack cbCamera;
    /// <summary>
    /// 用户数据
    /// user's data
    /// </summary>
    public IntPtr dwUser;
  }

  /// <summary>
  /// 委托fCameraStateCallBack的参数结构体
  /// </summary>
  public struct NET_CB_CAMERASTATE
  {
    public uint dwSize;
    /// <summary>
    /// 通道
    /// channel
    /// </summary>
    public int nChannel;
    /// <summary>
    /// 连接状态
    /// state of connect
    /// </summary>
    public EM_CONNECT_STATE emConnectState;
  }

  public struct NET_OUT_CAMERASTATE
  {
    public uint dwSize;
    /// <summary>
    /// 物体ID,每个ID表示一个唯一的物体
    /// Object ID,each ID represent a unique object
    /// </summary>
    public int nObjectID;
  }

  /// <summary>
  /// GetSoftwareVersion 入参
  /// GetSoftwareVersion input parameter
  /// </summary>
  public struct NET_IN_GET_SOFTWAREVERSION_INFO
  {
    public uint dwSize;
  }
  /// <summary>
  /// GetSoftwareVersion 出参
  /// GetSoftwareVersion output parameter
  /// </summary>
  public struct NET_OUT_GET_SOFTWAREVERSION_INFO
  {
    public uint dwSize;
    /// <summary>
    /// 软件版本
    /// software version
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szVersion;
    /// <summary>
    /// 日期
    /// version build date,exact to the second
    /// </summary>
    public NET_TIME stuBuildDate;
    /// <summary>
    /// web软件信息
    /// web version info
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szWebVersion;
  }
  /// <summary>
  /// GetDeviceType 入参
  /// GetDeviceType input parameter
  /// </summary>
  public struct NET_IN_GET_DEVICETYPE_INFO
  {
    public uint dwSize;
  }

  /// <summary>
  /// GetDeviceType 出参
  /// GetDeviceType output parameter
  /// </summary>
  public struct NET_OUT_GET_DEVICETYPE_INFO
  {
    public uint dwSize;
    /// <summary>
    /// 设备类型
    /// Device Types
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string sztype;
  }

  /// <summary>
  /// SDK全局日志打印信息
  /// SDK global log print
  /// </summary>
  public struct NET_LOG_SET_PRINT_INFO
  {
    public uint dwSize;
    /// <summary>
    /// 是否重设日志路径
    /// reset log path
    /// </summary>
    public int bSetFilePath;
    /// <summary>
    /// 日志路径(默认"./sdk_log/sdk_log.log")
    /// log path(default"./sdk_log/sdk_log.log")
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szLogFilePath;
    /// <summary>
    /// 是否重设日志文件大小
    /// reset log size
    /// </summary>
    public int bSetFileSize;
    /// <summary>
    /// 每个日志文件的大小(默认大小10240), 单位:比特
    /// each log file size(default size 10240), unit:bit
    /// </summary>
    public uint nFileSize;
    /// <summary>
    /// 是否重设日志文件个数
    /// reset log file number
    /// </summary>
    public int bSetFileNum;
    /// <summary>
    /// 绕接日志文件个数(默认大小10)
    /// log file quantity(default size 10)
    /// </summary>
    public uint nFileNum;
    /// <summary>
    /// 是否重设日志打印输出策略
    /// reset log print strategy
    /// </summary>
    public int bSetPrintStrategy;
    /// <summary>
    /// 日志输出策略, 0:输出到文件(默认); 1:输出到窗口
    /// log out strategy, 0: output to file(defualt); 1:output to window
    /// </summary>
    public uint nPrintStrategy;
  }


  //CLIENT_Attendance_GetFingerRecord 入参
  public struct NET_CTRL_IN_FINGERPRINT_GET
  {
    public uint dwSize;
    public int nFingerPrintID;              //指纹编号
  }

  //CLIENT_Attendance_GetFingerRecord 出参
  public struct NET_CTRL_OUT_FINGERPRINT_GET
  {
    public uint dwSize;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szUserID;     // 所属用户的用户ID
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szFingerPrintName; // 指纹名称
    public int nFingerPrintID;              // 指纹ID
    public int nRetLength;                // 实际返回的二进制指纹数据长度
    public int nMaxFingerDataLength;          // 二进制指纹数据的最大长度
    public IntPtr szFingerPrintInfo;            // 指纹数据
  }

  //CLIENT_Attendance_RemoveFingerRecord 入参(remove) 
  public struct NET_CTRL_IN_FINGERPRINT_REMOVE
  {
    public uint dwSize;
    public int nFingerPrintID;              //指纹编号
  }

  //CLIENT_Attendance_RemoveFingerRecord 出参
  public struct NET_CTRL_OUT_FINGERPRINT_REMOVE
  {
    public uint dwSize;
  }

  // 指纹信息操作类型
  public enum EM_ACCESS_CTL_FINGERPRINT_SERVICE
  {
    INSERT = 0,                               // 添加, pInbuf = NET_IN_ACCESS_FINGERPRINT_SERVICE_INSERT , pOutBuf = NET_OUT_ACCESS_FINGERPRINT_SERVICE_INSERT
    GET,                                      // 获取, pInbuf = NET_IN_ACCESS_FINGERPRINT_SERVICE_GET , pOutBuf = NET_OUT_ACCESS_FINGERPRINT_SERVICE_GET
    UPDATE,                                   // 更新, pInbuf = NET_IN_ACCESS_FINGERPRINT_SERVICE_UPDATE , pOutBuf = NET_OUT_ACCESS_FINGERPRINT_SERVICE_UPDATE
    REMOVE,                                   // 删除, pInbuf = NET_IN_ACCESS_FINGERPRINT_SERVICE_REMOVE , pOutBuf = NET_OUT_ACCESS_FINGERPRINT_SERVICE_REMOVE
    CLEAR,                                    // 清空, pInbuf = NET_IN_ACCESS_FINGERPRINT_SERVICE_CLEAR , pOutBuf = NET_OUT_ACCESS_FINGERPRINT_SERVICE_CLEAR
  }

  // 指纹信息
  public struct NET_ACCESS_FINGERPRINT_INFO
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szUserID;                 // 用户ID
    public int nPacketLen;                                     // 单个指纹数据包长度
    public int nPacketNum;                                     // 指纹数据包个数
    public IntPtr szFingerPrintInfo;                              // 指纹数据(数据总长度即nPacketLen*nPacketNum),用户分配释放内存
    public int nDuressIndex;                                   // 胁迫指纹序号,取值范围[1,nPacketNum] 非法取值的话，该字段无效
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4096)]
    public byte[] byReserved;                               // 保留字节
  }

  // 插入指纹信息入参
  public struct NET_IN_ACCESS_FINGERPRINT_SERVICE_INSERT
  {
    public uint dwSize;                                     // 结构体大小
    public int nFpNum;                                     // 指纹信息的数量
    public IntPtr pFingerPrintInfo;                           // 指纹信息,用户分配释放内存 NET_ACCESS_FINGERPRINT_INFO
  }

  // 插入指纹信息出参
  public struct NET_OUT_ACCESS_FINGERPRINT_SERVICE_INSERT
  {
    public uint dwSize;                                     // 结构体大小
    public int nMaxRetNum;                                 // 返回信息数量,不小于NET_IN_ACCESS_FINGERPRINT_SERVICE_INSERT 中 nFpNum
    public IntPtr pFailCode;                                  // 用户分配释放内存,插入失败时，对应插入的每一项的结果,返回个数同NET_IN_ACCESS_FINGERPRINT_SERVICE_INSERT 中nFpNum  对应的错误参考EM_FAILCODE
  }

  // 更新指纹信息入参
  public struct NET_IN_ACCESS_FINGERPRINT_SERVICE_UPDATE
  {
    public uint dwSize;                                     // 结构体大小
    public int nFpNum;                                     // 指纹信息的数量
    public IntPtr pFingerPrintInfo;                           // 指纹信息,用户分配释放内存 NET_ACCESS_FINGERPRINT_INFO
  }

  // 更新指纹信息出参
  public struct NET_OUT_ACCESS_FINGERPRINT_SERVICE_UPDATE
  {
    public uint dwSize;                                     // 结构体大小
    public int nMaxRetNum;                                 // 最大返回信息数量,不小于 NET_IN_ACCESS_FINGERPRINT_SERVICE_UPDATE中nFpNum
    public IntPtr pFailCode;                                  // 用户分配释放内存,插入失败时，对应插入的每一项的结果,返回个数同NET_IN_ACCESS_FINGERPRINT_SERVICE_UPDATE中nFpNum  对应的错误参考EM_FAILCODE
  }

  // 获取指纹信息入参
  public struct NET_IN_ACCESS_FINGERPRINT_SERVICE_GET
  {
    public uint dwSize;                                     // 结构体大小
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szUserID;             // 用户ID
  }
  // 获取指纹信息出参
  public struct NET_OUT_ACCESS_FINGERPRINT_SERVICE_GET
  {
    public uint dwSize;                                     // 结构体大小
    public int nRetFingerPrintCount;              // 实际返回的指纹个数
    public int nSinglePacketLength;             // 单个指纹数据包长度
    public int nDuressIndex;                               // 胁迫指纹序号
    public int nMaxFingerDataLength;              // 接受指纹数据的缓存的最大长度
    public int nRetFingerDataLength;              // 实际返回的总的指纹数据包的长度
    public IntPtr pbyFingerData;                            // 用户分配释放内存,指纹数据
  }

  // 删除用户指纹信息入参
  public struct NET_IN_ACCESS_FINGERPRINT_SERVICE_REMOVE
  {
    public uint dwSize;                                     // 结构体大小
    public int nUserNum;                                   // 删除的用户数量
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
    public NET_USERID[] szUserIDs;                          // 用户ID
  }

  public struct NET_USERID
  {
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szUserID;
  }

  // 删除用户指纹信息出参
  public struct NET_OUT_ACCESS_FINGERPRINT_SERVICE_REMOVE
  {
    public uint dwSize;                                     // 结构体大小
    public int nMaxRetNum;                                 // 最大返回数量,不小于 NET_IN_ACCESS_FINGERPRINT_SERVICE_REMOVE中nUserNum
    public IntPtr pFailCode;                                  // 用户分配释放内存,删除失败时，对应插入的每一项的结果,返回个数同NET_IN_ACCESS_FINGERPRINT_SERVICE_REMOVE中nUserNum 对应的错误参考EM_FAILCODE
  }

  // 清除所有指纹信息入参
  public struct NET_IN_ACCESS_FINGERPRINT_SERVICE_CLEAR
  {
    public uint dwSize;                                         // 结构体大小
  }

  // 清除所有指纹信息出参
  public struct NET_OUT_ACCESS_FINGERPRINT_SERVICE_CLEAR
  {
    public uint dwSize;                                         // 结构体大小
  }

  // 操作错误码
  public enum EM_FAILCODE
  {
    NOERROR,                                                // 没有错误
    UNKNOWN,                                                // 未知错误
    INVALID_PARAM,                                          // 参数错误
    INVALID_PASSWORD,                                       // 无效密码
    INVALID_FP,                                             // 无效指纹数据
    INVALID_FACE,                                           // 无效人脸数据
    INVALID_CARD,                                           // 无效卡数据
    INVALID_USER,                                           // 无效人数据
    FAILED_GET_SUBSERVICE,                                  // 能力集子服务获取失败
    FAILED_GET_METHOD,                                      // 获取组件的方法集失败
    FAILED_GET_SUBCAPS,                                     // 获取资源实体能力集失败
    ERROR_INSERT_LIMIT,                                     // 已达插入上限
    ERROR_MAX_INSERT_RATE,                                  // 已达最大插入速度
    FAILED_ERASE_FP,                    // 清除指纹数据失败
    FAILED_ERASE_FACE,                    // 清除人脸数据失败
    FAILED_ERASE_CARD,                    // 清除卡数据失败
    NO_RECORD,                        // 没有记录
    NOMORE_RECORD,                      // 查找到最后，没有更多记录
    RECORD_ALREADY_EXISTS,                  // 下发卡或指纹时，数据重复
    MAX_FP_PERUSER,                     // 超过个人最大指纹记录数
    MAX_CARD_PERUSER,                   // 超过个人最大卡片记录数
  }

  // 折线的端点信息
  public struct NET_CFG_POLYLINE
  {
    public int nX; //0~8191
    public int nY;
  };

  // 云台联动类型
  public enum EM_CFG_LINK_TYPE
  {
    LINK_TYPE_NONE,                                 // 无联动
    LINK_TYPE_PRESET,                               // 联动预置点
    LINK_TYPE_TOUR,                                 // 联动巡航
    LINK_TYPE_PATTERN,                              // 联动轨迹
  }

  // 联动云台信息
  public struct NET_CFG_PTZ_LINK
  {
    public EM_CFG_LINK_TYPE emType;                       // 联动类型
    public int nValue;                     // 联动取值分别对应预置点号，巡航号等等
  }

  // 联动云台信息扩展
  public struct NET_CFG_PTZ_LINK_EX
  {
    public EM_CFG_LINK_TYPE emType;               // 联动类型 
    public int nParam1;            // 联动参数1
    public int nParam2;            // 联动参数2
    public int nParam3;            // 联动参数3
    public int nChannelID;         // 所联动云台通道
  }

  // RGBA信息
  public struct NET_CFG_RGBA
  {
    public int nRed;
    public int nGreen;
    public int nBlue;
    public int nAlpha;
  };

  public struct NET_CFG_SIZE
  {
    public float nWidth;       // 宽
    public float nHeight;      // 高
  }

  // 事件标题内容结构体
  public struct NET_CFG_EVENT_TITLE
  {
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szText;
    public NET_CFG_POLYGON stuPoint;           // 标题左上角坐标, 采用0-8191相对坐标系
    public NET_CFG_SIZE stuSize;           // 标题的宽度和高度,采用0-8191相对坐标系，某项或者两项为0表示按照字体自适应宽高
    public NET_CFG_RGBA stuFrontColor;     // 前景颜色
    public NET_CFG_RGBA stuBackColor;      // 背景颜色
  }

  // 邮件附件类型
  public enum EM_CFG_ATTACHMENT_TYPE
  {
    PIC,                            // 图片附件
    VIDEO,                          // 视频附件
    NUM,                            // 附件类型总数
  }

  // 邮件详细内容
  public struct NET_CFG_MAIL_DETAIL
  {
    public EM_CFG_ATTACHMENT_TYPE emAttachType;                 // 附件类型
    public int nMaxSize;                     // 文件大小上限，单位kB
    public int nMaxTimeLength;               // 最大录像时间长度，单位秒，对video有效
  }

  // 分割模式
  public enum EM_CFG_SPLITMODE
  {
    SPLITMODE_1 = 1,                        // 1画面
    SPLITMODE_2 = 2,                        // 2画面
    SPLITMODE_4 = 4,                        // 4画面
    SPLITMODE_6 = 6,                        // 6画面
    SPLITMODE_8 = 8,                        // 8画面
    SPLITMODE_9 = 9,                        // 9画面
    SPLITMODE_12 = 12,                      // 12画面
    SPLITMODE_16 = 16,                      // 16画面
    SPLITMODE_20 = 20,                      // 20画面
    SPLITMODE_25 = 25,                      // 25画面
    SPLITMODE_36 = 36,                      // 36画面
    SPLITMODE_64 = 64,                      // 64画面
    SPLITMODE_144 = 144,                    // 144画面
    SPLITMODE_PIP = 1000,                   // 画中画分割模式基础值
    SPLITMODE_PIP1 = SPLITMODE_PIP + 1,     // 画中画模式, 1个全屏大画面+1个小画面窗口
    SPLITMODE_PIP3 = SPLITMODE_PIP + 3,     // 画中画模式, 1个全屏大画面+3个小画面窗口
    SPLITMODE_FREE = SPLITMODE_PIP * 2, // 自由开窗模式，可以自由创建、关闭窗口，自由设置窗口位置和Z轴次序
    SPLITMODE_COMPOSITE_1 = SPLITMODE_PIP * 3 + 1,  // 融合屏成员1分割
    SPLITMODE_COMPOSITE_4 = SPLITMODE_PIP * 3 + 4,  // 融合屏成员4分割
    SPLITMODE_3 = 10,                       // 3画面
    SPLITMODE_3B = 11,                      // 3画面倒品
    SPLITMODE_EOF,                          // 结束标识
  }

  // 轮巡联动配置
  public struct NET_CFG_TOURLINK
  {
    public bool bEnable;                        // 轮巡使能
    public EM_CFG_SPLITMODE emSplitMode;                   // 轮巡时的分割模式
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public int[] nChannels;  // 轮巡通道号列表
    public int nChannelCount;                   // 轮巡通道数量
  }

  // 门禁操作类型
  public enum EM_CFG_ACCESSCONTROLTYPE
  {
    NULL = 0,                  // 不做操作
    AUTO,                      // 自动
    OPEN,                      // 开门
    CLOSE,                     // 关门
    OPENALWAYS,                // 永远开启
    CLOSEALWAYS,               // 永远关闭
  };

  // 语音呼叫发起方
  public enum EM_CALLER_TYPE
  {
    DEVICE = 0,                               // 设备发起
  };

  // 呼叫协议
  public enum EM_CALLER_PROTOCOL_TYPE
  {
    CELLULAR = 0,                    // 手机方式
  };

  /// <summary>
  /// 语音呼叫联动信息
  /// Voice Call Linkage Information
  /// </summary>
  public struct NET_CFG_TALKBACK_INFO
  {
    /// <summary>
    /// 语音呼叫使能
    /// Voice Call Enable
    /// </summary>
    public bool bCallEnable;
    /// <summary>
    /// 语音呼叫发起方
    /// Voice Calls Originating
    /// </summary>
    public EM_CALLER_TYPE emCallerType;
    /// <summary>
    /// 语音呼叫协议
    /// Voice Call Protocol
    /// </summary>
    public EM_CALLER_PROTOCOL_TYPE emCallerProtocol;
  };

  /// <summary>
  /// 电话报警中心联动信息
  /// Telephone Alarm Center Linkage Information
  /// </summary>
  public struct NET_CFG_PSTN_ALARM_SERVER
  {
    /// <summary>
    /// 是否上报至电话报警中心
    /// Whether to Report to the Call Center
    /// </summary>
    public bool bNeedReport;
    /// <summary>
    /// 电话报警服务器个数
    /// The Number of Telephone Alarm Server
    /// </summary>
    public int nServerCount;
    /// <summary>
    /// 上报的报警中心下标,详见配置CFG_PSTN_ALARM_CENTER_INFO
    /// Report to the Alarm Center Subscript,See the Configuration CFG_PSTN_ALARM_CENTER_INFO
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] byDestination;
  };

  /// <summary>
  /// Each video channel respond envent rule: pRuleBuf point to a buffer with multiple event rule info, each event rule info contain CFG_RULE_INFO + stucte of respond rule configuration struct
  /// </summary>
  public struct NET_CFG_ANALYSERULES_INFO
  {
    /// <summary>
    /// 事件规则个数
    /// Video analyse rule number
    /// </summary>
    public int nRuleCount;
    /// <summary>
    /// 每个视频输入通道对应的视频分析事件规则配置缓冲
    /// Ach video input chennel's rule configuration buffer
    /// </summary>
    public IntPtr pRuleBuf;
    /// <summary>
    /// 缓冲大小
    /// Buffer size
    /// </summary>
    public int nRuleLen;
  }

  public struct NET_CFG_RULE_INFO
  {
    /// <summary>
    /// 事件类型，详见dhnetsdk.h中"智能分析事件类型"
    /// Event type,see "intelligent analyse event type" in dhnetsdk.h 
    /// </summary>
    public uint dwRuleType;
    /// <summary>
    /// 该事件类型规则配置结构体大小
    /// This envent type rule configuration struct size
    /// </summary>
    public int nRuleSize;
    /// <summary>
    /// 规则通用信息
    /// the common of the tule
    /// </summary>
    public NET_CFG_RULE_COMM_INFO stuRuleCommInfo;
  }

  /// <summary>
  /// 规则通用信息
  /// rule common info 
  /// </summary>
  public struct NET_CFG_RULE_COMM_INFO
  {
    /// <summary>
    /// 规则编号
    /// the ID of rule
    /// </summary>
    public byte bRuleId;
    /// <summary>
    /// 规则所属的场景
    /// the scene of  rule 
    /// </summary>
    public EM_SCENE_TYPE emClassType;
    /// <summary>
    /// 保留字节
    /// reserved field
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] bReserved;
  }

  /// <summary>
  /// the scene type
  /// </summary>
  public enum EM_SCENE_TYPE
  {
    EM_SCENE_UNKNOW,            // 未知
    EM_SCENE_NORMAL,            // "Normal" 普通场景
    EM_SCENE_TRAFFIC,           // "Traffic" 交通场景
    EM_SCENE_TRAFFIC_PATROL,    // "TrafficPatrol" 交通巡视
    EM_SCENE_FACEDETECTION,     // "FaceDetection" 人脸检测/人脸识别
    EM_SCENE_ATM,               // "ATM"
    EM_SCENE_INDOOR,            // "Indoor"  室内行为分析，和普通规则相同，对室内场景的算法优化版
    EM_SCENE_FACERECOGNITION,   // "FaceRecognition" 人脸识别
    EM_SCENE_PRISON,            // "Prison" 监狱
    EM_SCENE_NUMBERSTAT,        // "NumberStat" 客流量统计
    EM_SCENE_HEAT_MAP,          // "HeatMap" 热度图
    EM_SCENE_VIDEODIAGNOSIS,    // "VideoDiagnosis" 视频诊断
    EM_SCENE_VEHICLEANALYSE,    // "VehicleAnalyse" 车辆特征检测分析
    EM_SCENE_COURSERECORD,      // "CourseRecord" 自动录播
    EM_SCENE_VEHICLE,           // "Vehicle" 车载场景(车载行业用，不同于智能交通的Traffic)
    EM_SCENE_STANDUPDETECTION,  // "StandUpDetection" 起立检测
    EM_SCENE_GATE,              // "Gate" 卡口
    EM_SCENE_SDFACEDETECTION,   // "SDFaceDetect"  多预置点人脸检测，配置一条规则但可以在不同预置点下生效
    EM_SCENE_HEAT_MAP_PLAN,     // "HeatMapPlan" 球机热度图计划
    EM_SCENE_NUMBERSTAT_PLAN,   // "NumberStatPlan"	球机客流量统计计划
    EM_SCENE_ATMFD,             // "ATMFD"金融人脸检测，包括正常人脸、异常人脸、相邻人脸、头盔人脸等针对ATM场景特殊优化
    EM_SCENE_HIGHWAY,           // "Highway" 高速交通事件检测
    EM_SCENE_CITY,              // "City" 城市交通事件检测
    EM_SCENE_LETRACK,           // "LeTrack" 民用简易跟踪
    EM_SCENE_SCR,               // "SCR"打靶相机
    EM_SCENE_STEREO_VISION,     // "StereoVision"立体视觉(双目)
    EM_SCENE_HUMANDETECT,       // "HumanDetect"人体检测
    EM_SCENE_FACEANALYSIS,      // "FaceAnalysis" 人脸分析(同时支持人脸检测、人脸识别、人脸属性等综合型业务)
    EM_SCENE_XRAY_DETECTION,    // "XRayDetection" X光检测
    EM_SCENE_STEREO_NUMBER,     // "StereoNumber" 双目相机客流量统计
    EM_SCENE_CROWD_DISTRI_MAP,  // "CrowdDistriMap" 人群分布图
    EM_SCENE_OBJECTDETECT,      // "ObjectDetect" 目标检测(含人机非等物体)
    EM_SCENE_FACEATTRIBUTE,     // "FaceAttribute" IVSS人脸检测
    EM_SCENE_FACECOMPARE,       // "FaceCompare" IVSS人脸识别
    EM_SCENE_STEREO_BEHAVIOR,   // "StereoBehavior" 立体行为分析(典型场景ATM舱)
    EM_SCENE_INTELLICITYMANAGER,// "IntelliCityManager" 智慧城管
    EM_SCENE_PROTECTIVECABIN,   // "ProtectiveCabin" 防护舱（ATM舱内）
  }

  /// <summary>
  /// 时间表信息
  /// Schedule Information
  /// </summary>
  public struct NET_CFG_TIME_SCHEDULE
  {
    /// <summary>
    /// 是否支持节假日配置，默认为不支持，除非获取配置后返回为TRUE，不要使能假日配置
    /// whether holiday config is enabled, default value is FALSE, DO NOT enable it unless you get TRUE after get config
    /// </summary>
    public bool bEnableHoliday;
    /// <summary>
    /// 第一维前7个元素对应每周7天，第8个元素对应节假日，每天最多6个时间段
    /// The First Dimension Before the 7 Elements Corresponding 7 Days a week, Eighth Elements Corresponding Holiday, Up to Six Time Periods Per Day
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8 * 6)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
  }

  /// <summary>
  /// 报警联动信息
  /// Alarm activation information
  /// </summary>
  public struct NET_CFG_ALARM_MSG_HANDLE
  {
    //能力 Competence 
    public byte abRecordMask;
    public byte abRecordEnable;
    public byte abRecordLatch;
    public byte abAlarmOutMask;
    public byte abAlarmOutEn;
    public byte abAlarmOutLatch;
    public byte abExAlarmOutMask;
    public byte abExAlarmOutEn;
    public byte abPtzLinkEn;
    public byte abTourMask;
    public byte abTourEnable;
    public byte abSnapshot;
    public byte abSnapshotEn;
    public byte abSnapshotPeriod;
    public byte abSnapshotTimes;
    public byte abTipEnable;
    public byte abMailEnable;
    public byte abMessageEnable;
    public byte abBeepEnable;
    public byte abVoiceEnable;
    public byte abMatrixMask;
    public byte abMatrixEnable;
    public byte abEventLatch;
    public byte abLogEnable;
    public byte abDelay;
    public byte abVideoMessageEn;
    public byte abMMSEnable;
    public byte abMessageToNetEn;
    public byte abTourSplit;
    public byte abSnapshotTitleEn;

    public byte abChannelCount;
    public byte abAlarmOutCount;
    public byte abPtzLinkEx;
    public byte abSnapshotTitle;
    public byte abMailDetail;
    public byte abVideoTitleEn;
    public byte abVideoTitle;
    public byte abTour;
    public byte abDBKeys;
    public byte abJpegSummary;
    public byte abFlashEn;
    public byte abFlashLatch;
    //信息 Information
    /// <summary>
    /// 设备的视频通道数
    /// The video channel of the device
    /// </summary>
    public int nChannelCount;
    /// <summary>
    /// 设备的报警输出个数
    /// The alarm output amount of the device
    /// </summary>
    public int nAlarmOutCount;
    /// <summary>
    /// 录像通道掩码(按位)
    /// Subnet mask of the recording channel(use the bit to represent)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwRecordMask;
    /// <summary>
    /// 录像使能
    /// Record enable
    /// </summary>
    public bool bRecordEnable;
    /// <summary>
    /// 录像延时时间(秒)
    /// Record delay time(s)
    /// </summary>
    public int nRecordLatch;
    /// <summary>
    /// 报警输出通道掩码
    /// Subnet mask of alarm output channel 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwAlarmOutMask;
    /// <summary>
    /// 报警输出使能
    /// Alarm output enable
    /// </summary>
    public bool bAlarmOutEn;
    /// <summary>
    /// 报警输出延时时间(秒)
    /// Alarm output delay time (s)
    /// </summary>
    public int nAlarmOutLatch;
    /// <summary>
    /// 扩展报警输出通道掩码
    /// Subnet mask of extension alarm output channel 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwExAlarmOutMask;
    /// <summary>
    /// 扩展报警输出使能
    /// Extension alarm output enable
    /// </summary>
    public bool bExAlarmOutEn;
    /// <summary>
    /// 云台联动项
    /// PTZ activation item
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_CFG_PTZ_LINK[] stuPtzLink;
    /// <summary>
    /// 云台联动使能
    /// PTZ activation enable
    /// </summary>
    public bool bPtzLinkEn;
    /// <summary>
    /// 轮询通道掩码
    /// Subnet mask of tour channel 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwTourMask;
    /// <summary>
    /// 轮询使能
    /// Tour enable
    /// </summary>
    public bool bTourEnable;
    /// <summary>
    /// 快照通道号掩码
    /// Snapshot channel subnet mask
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwSnapshot;
    /// <summary>
    /// 快照使能
    /// Snapshot enable
    /// </summary>
    public bool bSnapshotEn;
    /// <summary>
    /// 连拍周期(秒)
    /// Snapshot period(s)
    /// </summary>
    public int nSnapshotPeriod;
    /// <summary>
    /// 连拍次数
    /// Snapshot times
    /// </summary>
    public int nSnapshotTimes;
    /// <summary>
    /// 本地消息框提示
    /// Local prompt dialogue box
    /// </summary>
    public bool bTipEnable;
    /// <summary>
    /// 发送邮件，如果有图片，作为附件
    /// Send out emali. The image is sent out as the attachment. 
    /// </summary>
    public bool bMailEnable;
    /// <summary>
    /// 上传到报警服务器
    /// Upload to the alarm server 
    /// </summary>
    public bool bMessageEnable;
    /// <summary>
    /// 蜂鸣
    /// Buzzer
    /// </summary>
    public bool bBeepEnable;
    /// <summary>
    /// 语音提示
    /// Audio prompt
    /// </summary>
    public bool bVoiceEnable;
    /// <summary>
    /// 联动视频矩阵通道掩码
    /// Subnet mask of the activated video channel
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
    public uint[] dwMatrixMask;
    /// <summary>
    /// 联动视频矩阵
    /// Activate the video matrix
    /// </summary>
    public bool bMatrixEnable;
    /// <summary>
    /// 联动开始延时时间(秒)，0－15
    /// Activation delay time (s),0-15
    /// </summary>
    public int nEventLatch;
    /// <summary>
    /// 是否记录日志
    /// Record log or not
    /// </summary>
    public bool bLogEnable;
    /// <summary>
    /// 设置时先延时再生效，单位为秒
    /// Delay first and then becomes valid when set. Unit is second.
    /// </summary>
    public int nDelay;
    /// <summary>
    /// 叠加提示字幕到视频。叠加的字幕包括事件类型，通道号，秒计时。
    /// Overlay the prompt character to the video. The overlay character includes the event type, channel number. The unit is second.
    /// </summary>
    public bool bVideoMessageEn;
    /// <summary>
    /// 发送彩信使能
    /// Enable MMS
    /// </summary>
    public bool bMMSEnable;
    /// <summary>
    /// 消息上传给网络使能
    /// Send the message to the network enable
    /// </summary>
    public bool bMessageToNetEn;
    /// <summary>
    /// 轮巡时的分割模式 0: 1画面; 1: 8画面
    /// Tour split mod 0: 1tour; 1: 8tour
    /// </summary>
    public int nTourSplit;
    /// <summary>
    /// 是否叠加图片标题
    /// Enble osd
    /// </summary>
    public bool bSnapshotTitleEn;
    /// <summary>
    /// 云台配置数
    /// PTZ link configuration number
    /// </summary>
    public int nPtzLinkExNum;
    /// <summary>
    /// 扩展云台信息
    /// PTZ extend information
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_CFG_PTZ_LINK_EX[] stuPtzLinkEx;
    /// <summary>
    /// 图片标题内容数
    /// Number of picture title
    /// </summary>
    public int nSnapTitleNum;
    /// <summary>
    /// 图片标题内容
    /// Picture title content
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_CFG_EVENT_TITLE[] stuSnapshotTitle;
    /// <summary>
    /// 邮件详细内容
    /// Mail detial
    /// </summary>
    public NET_CFG_MAIL_DETAIL stuMailDetail;
    /// <summary>
    /// 是否叠加视频标题，主要指主码流
    /// Whether overlay video title, mainly refers to the main stream
    /// </summary>
    public bool bVideoTitleEn;
    /// <summary>
    /// 视频标题内容数目
    /// Video title num
    /// </summary>
    public int nVideoTitleNum;
    /// <summary>
    /// 视频标题内容
    /// Video title
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_CFG_EVENT_TITLE[] stuVideoTitle;
    /// <summary>
    /// 轮询联动数目
    ///  Tour num
    /// </summary>
    public int nTourNum;
    /// <summary>
    /// 轮询联动配置
    /// Tour configuration
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_CFG_TOURLINK[] stuTour;
    /// <summary>
    /// 指定数据库关键字的有效数
    /// Specify the db keyword on the number of effective
    /// </summary>
    public int nDBKeysNum;
    /// <summary>
    /// 指定事件详细信息里需要写到数据库的关键字
    /// The specify event detail information need write the BD keyword
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64 * 64)]
    public byte[] szDBKeys;
    /// <summary>
    /// 叠加到JPEG图片的摘要信息
    /// The summary information of the jpeg image
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] byJpegSummary;
    /// <summary>
    /// 是否使能补光灯
    /// Whether enable flash
    /// </summary>
    public bool bFlashEnable;
    /// <summary>
    /// 补光灯延时时间(秒),延时时间范围：[10,300]
    /// Flash delay time (s),the time range:[10,300]
    /// </summary>
    public int nFlashLatch;

    public byte abAudioFileName;
    public byte abAlarmBellEn;
    public byte abAccessControlEn;
    public byte abAccessControl;
    /// <summary>
    /// 联动语音文件绝对路径
    /// The Absolute Path to the Linkage Audio Files
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szAudioFileName;
    /// <summary>
    /// 警号使能
    /// Warning Signal Enable
    /// </summary>
    public bool bAlarmBellEn;
    /// <summary>
    /// 门禁使能
    /// Entrance Guard Enable
    /// </summary>
    public bool bAccessControlEn;

    /// <summary>
    /// 门禁组数
    /// Class Number of Entrance Guard
    /// </summary>
    public uint dwAccessControl;
    /// <summary>
    /// 门禁联动操作信息
    /// Entrance Guard Linkage Operation Information
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public EM_CFG_ACCESSCONTROLTYPE[] emAccessControlType;

    public byte abTalkBack;
    /// <summary>
    /// 语音呼叫联动信息
    ///  Voice Call Linkage Information
    /// </summary>
    public NET_CFG_TALKBACK_INFO stuTalkback;

    public byte abPSTNAlarmServer;
    /// <summary>
    /// 电话报警中心联动信息
    /// Telephone Alarm Center Linkage Information
    /// </summary>
    public NET_CFG_PSTN_ALARM_SERVER stuPSTNAlarmServer;
    /// <summary>
    /// 事件响应时间表
    /// Event Response Timetable
    /// </summary>
    public NET_CFG_TIME_SCHEDULE stuTimeSection;
    public byte abAlarmBellLatch;
    /// <summary>
    /// 警号输出延时时间(10-300秒)
    /// Police no. output delay time(10-300 s)
    /// </summary>
    public int nAlarmBellLatch;
  }

  /// <summary>
  /// 时间段信息
  /// Period information
  /// </summary>
  public struct NET_CFG_TIME_SECTION
  {
    /// <summary>
    /// 录像掩码，按位分别为动态检测录像、报警录像、定时录像、Bit3~Bit15保留、Bit16动态检测抓图、Bit17报警抓图、Bit18定时抓图
    /// Record subnet mask. The bit represents motion detect reocrd, alarm record, schedule record. Bit3~Bit15 is reserved. Bit 16 motion detect snapshot, Bit 17 alarm snapshot, Bit18 schedule snapshot
    /// </summary>
    public uint dwRecordMask;
    public int nBeginHour;
    public int nBeginMin;
    public int nBeginSec;
    public int nEndHour;
    public int nEndMin;
    public int nEndSec;
  };

  /// <summary>
  /// 校准框信息
  /// Calibrate box info
  /// </summary>
  public struct NET_CFG_CALIBRATEBOX_INFO
  {
    /// <summary>
    /// 校准框中心点坐标(点的坐标归一化到[0,8191]区间)
    /// Calibrate box center point(0,8191)
    /// </summary>
    public NET_CFG_POLYGON stuCenterPoint;
    /// <summary>
    /// 相对基准校准框的比率(比如1表示基准框大小，0.5表示基准框大小的一半)
    /// The relative ratio of the calibrate box(such as 1 means the calibrate box,0.5 means the half size of the calibrate box)
    /// </summary>
    public float fRatio;
  };


  /// <summary>
  ///  尺寸过滤器
  ///  Size filter
  /// </summary>
  public struct NET_CFG_SIZEFILTER_INFO
  {
    /// <summary>
    /// 校准框个数
    /// Calibration pane number
    /// </summary>
    public int nCalibrateBoxNum;
    /// <summary>
    /// 校准框(远端近端标定模式下有效)
    /// Calibration box (far and near-end calibration mode only)
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public NET_CFG_CALIBRATEBOX_INFO[] stuCalibrateBoxs;
    /// <summary>
    /// 计量方式参数是否有效
    /// Measurement mode enabled or not 
    /// </summary>
    public byte bMeasureModeEnable;
    /// <summary>
    /// 计量方式,0-像素，不需要远端、近端标定, 1-实际长度，单位：米, 2-远端近端标定后的像素
    /// Measurement mode, 0-pixel, far and near-end calibration not necessary, 1- real length, unit: meter, 2- pixel after far and near-end calibration
    /// </summary>
    public byte bMeasureMode;
    /// <summary>
    /// 过滤类型参数是否有效
    /// Filter type enabled or not 
    /// </summary>
    public byte bFilterTypeEnable;
    /// <summary>
    /// ByArea,ByRatio仅作兼容，使用独立的ByArea和ByRatio选项代替 2012/03/06
    /// ByArea,ByRatio as compatible only, with independent ByArea and ByRatio alternatives as substitute 2012/03/06
    /// 过滤类型:0:"ByLength",1:"ByArea", 2"ByWidthHeight"
    /// Filter type:0:"ByLength",1:"ByArea", 2"ByWidthHeight"
    /// </summary>
    public byte bFilterType;
    /// <summary>
    /// 保留字段
    /// Reserved field
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 物体最小尺寸参数是否有效
    /// Min object size parameter is valid or not  
    /// </summary>
    public byte bFilterMinSizeEnable;
    /// <summary>
    /// 物体最大尺寸参数是否有效
    /// Max object size parameter is valid or not 
    /// </summary>
    public byte bFilterMaxSizeEnable;
    /// <summary>
    /// 物体最小尺寸 "ByLength"模式下表示宽高的尺寸，"ByArea"模式下宽表示面积，高无效(远端近端标定模式下表示基准框的宽高尺寸)。
    /// Min object size      size of length ratio under "ByLength" Mode,size of area under "ByArea" mode, invalid height (size of standard box lengths under far and near-end calibration mode)
    /// </summary>
    public NET_CFG_SIZE stuFilterMinSize;
    /// <summary>
    /// 物体最大尺寸 "ByLength"模式下表示宽高的尺寸，"ByArea"模式下宽表示面积，高无效(远端近端标定模式下表示基准框的宽高尺寸)。
    /// Max object size size of length ratio under "ByLength" mode, size of area under "ByArea" mode", invalid height (size of standard box lengths under far and near-end calibration mode)
    /// </summary>
    public NET_CFG_SIZE stuFilterMaxSize;

    public byte abByArea;
    public byte abMinArea;
    public byte abMaxArea;
    public byte abMinAreaSize;
    public byte abMaxAreaSize;
    /// <summary>
    /// 是否按面积过滤 通过能力ComplexSizeFilter判断是否可用
    ///  Filter by area or not. You can use ComplexSizeFilter to see it works or not. 
    /// </summary>
    public byte bByArea;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved1;
    /// <summary>
    /// 最小面积
    /// Min area
    /// </summary>
    public float nMinArea;
    /// <summary>
    /// 最大面积
    /// Max area
    /// </summary>
    public float nMaxArea;
    /// <summary>
    /// 最小面积矩形框尺寸 "计量方式"为"像素"时，表示最小面积矩形框的宽高尺寸；"计量方式"为"远端近端标定模式"时，表示基准框的最小宽高尺寸；
    /// Min area rectangle box.   When  "measurement method" is "pixel", it represents its sizes of lengths; when "measurement method" is "far and near-end calibration mode", it represents the min sizes of lengths of standard box
    /// </summary>
    public NET_CFG_SIZE stuMinAreaSize;
    /// <summary>
    /// 最大面积矩形框尺寸, 同上
    /// Max area rectangle box, same as above
    /// </summary>
    public NET_CFG_SIZE stuMaxAreaSize;

    public byte abByRatio;
    public byte abMinRatio;
    public byte abMaxRatio;
    public byte abMinRatioSize;
    public byte abMaxRatioSize;
    /// <summary>
    /// 是否按宽高比过滤 通过能力ComplexSizeFilter判断是否可用
    /// Filter by length ratio or not   . You can use ComplexSizeFilter to see it works or not. 
    /// </summary>
    public byte bByRatio;
    /// <summary>
    /// 最小宽高比
    /// Min W/H ratio
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved2;
    public double dMinRatio;
    /// <summary>
    /// 最大宽高比
    /// Max W/H ratio
    /// </summary>
    public double dMaxRatio;
    /// <summary>
    /// 最小宽高比矩形框尺寸，最小宽高比对应矩形框的宽高尺寸。
    /// Min W/H ratio rectangle box size, min W/H ratio corresponding to sizes of lengths of rectangle box
    /// </summary>
    public NET_CFG_SIZE stuMinRatioSize;
    /// <summary>
    /// 最大宽高比矩形框尺寸，同上
    /// Max W/H ratio rectangle box size. See above information.
    /// </summary>
    public NET_CFG_SIZE stuMaxRatioSize;
    /// <summary>
    /// 面积校准框个数
    /// Area calibration box number
    /// </summary>
    public int nAreaCalibrateBoxNum;
    /// <summary>
    /// 面积校准框
    /// Area calibration box
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public NET_CFG_CALIBRATEBOX_INFO[] stuAreaCalibrateBoxs;
    /// <summary>
    ///  宽高校准框个数
    ///   W/H calibration box number
    /// </summary>
    public int nRatioCalibrateBoxs;
    /// <summary>
    /// 宽高校准框
    ///  W/H calibration box number
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
    public NET_CFG_CALIBRATEBOX_INFO[] stuRatioCalibrateBoxs;
    /// <summary>
    /// 长宽过滤使能参数是否有效 
    /// Valid filter by L/H ration parameter enabled or not 
    /// </summary>
    public byte abBySize;
    /// <summary>
    /// 长宽过滤使能
    /// L/W filter enabled
    /// </summary>
    public byte bBySize;
  };

  // 视频分析事件规则配置
  // Video analyse rule configuration
  /// <summary>
  /// 事件类型 EVENT_IVS_CROSSLINEDETECTION (警戒线事件)对应的规则配置
  /// Rule type:EVENT_IVS_CROSSLINEDETECTION configuration
  /// </summary>
  public struct NET_CFG_CROSSLINE_INFO
  {
    /// <summary>
    /// 规则名称,不同规则不能重名
    /// Rule name,different rule mast have different name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRuleName;
    /// <summary>
    /// 规则使能
    /// Rule enable
    /// </summary>
    public byte bRuleEnable;
    /// <summary>
    /// 触发跟踪使能,仅对绊线，入侵规则有效
    /// Trigger tracking enabled, only the tripwire, intrusion rule is valid
    /// </summary>
    public byte bTrackEnable;
    /// <summary>
    /// 保留字段 
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 相应物体类型个数
    /// Current object's number
    /// </summary>
    public int nObjectTypeNum;
    /// <summary>
    /// 相应物体类型列表
    /// Current object list
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 128)]
    public byte[] szObjectTypes;
    /// <summary>
    /// 检测方向:0:由左至右;1:由右至左;2:两者都可以
    /// Detect direction:0:lefttoright;1:righttoleft;2:both
    /// </summary>
    public int nDirection;
    /// <summary>
    /// 警戒线顶点数
    /// Detect line point number
    /// </summary>
    public int nDetectLinePoint;
    /// <summary>
    /// 警戒线
    /// Detect line
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CFG_POLYLINE[] stuDetectLine;
    /// <summary>
    /// 报警联动
    /// Alarm event handler
    /// </summary>
    public NET_CFG_ALARM_MSG_HANDLE stuEventHandler;
    /// <summary>
    /// 事件响应时间段
    /// Event respond time section
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 * 10)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
    /// <summary>
    /// stuTimeSection字段是否禁用，默认FALSE：不禁用，TRUE：禁用，用户控制 
    /// stuTimeSection ,default FALSE:not disable,TRUE:disable,user control
    /// </summary>
    public bool bDisableTimeSection;
    /// <summary>
    /// 云台预置点编号	0~65535
    /// PTZ preset Id 0~65535
    /// </summary>
    public int nPtzPresetId;
    /// <summary>
    /// 规则特定的尺寸过滤器是否有效
    /// Size filter enable
    /// </summary>
    public bool bSizeFileter;
    /// <summary>
    /// 规则特定的尺寸过滤器
    /// Size filter info
    /// </summary>
    public NET_CFG_SIZEFILTER_INFO stuSizeFileter;
    /// <summary>
    /// 触发报警位置数
    /// Trigger possition number
    /// </summary>
    public int nTriggerPosition;
    /// <summary>
    /// 触发报警位置,0-目标外接框中心, 1-目标外接框左端中心, 2-目标外接框顶端中心, 3-目标外接框右端中心, 4-目标外接框底端中心
    /// Trigger possition,0-object out frame center, 1-object out frame left center, 2-object out frame top center, 3-object out frame right center, 4-object out frame bottom center
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bTriggerPosition;
    /// <summary>
    /// 跟踪持续时间,0秒:一直跟踪,1~300秒:跟踪持续时间
    /// Track Duration,0 second:keep tracking,1~300se:track duration
    /// </summary>
    public int nTrackDuration;
  }

  /// <summary>
  /// 区域顶点信息
  /// Zone point info
  /// </summary>
  public struct NET_CFG_POLYGON
  {
    public int nX; //0~8191
    public int nY;
  }
  /// <summary>
  /// 事件类型EVENT_IVS_CROSSREGIONDETECTION(警戒区事件)对应的规则配置
  /// Rule type:EVENT_IVS_CROSSREGIONDETECTION configuration
  /// </summary>
  public struct NET_CFG_CROSSREGION_INFO
  {
    /// <summary>
    /// 规则名称,不同规则不能重名
    /// Rule name,different rule mast have different name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRuleName;
    /// <summary>
    /// 规则使能
    /// Rule enable
    /// </summary>
    public byte bRuleEnable;
    /// <summary>
    /// 触发跟踪使能,仅对绊线，入侵规则有效
    /// Trigger tracking enabled, only the tripwire, intrusion rule is valid
    /// </summary>
    public byte bTrackEnable;
    /// <summary>
    /// 保留字段
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 相应物体类型个数
    /// Current object's number
    /// </summary>
    public int nObjectTypeNum;
    /// <summary>
    /// 相应物体类型列表
    /// Current object list
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 128)]
    public byte[] szObjectTypes;
    /// <summary>
    /// 检测方向:0:Enter;1:Leave;2:Both
    /// Detect direction:0:Enter;1:Leave;2:Both
    /// </summary>
    public int nDirection;
    /// <summary>
    /// 警戒区顶点数
    /// Detect line point number
    /// </summary>
    public int nDetectRegionPoint;
    /// <summary>
    /// 警戒区
    ///  Detect line
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CFG_POLYGON[] stuDetectRegion;
    /// <summary>
    /// 报警联动 
    /// Alarm event handler
    /// </summary>
    public NET_CFG_ALARM_MSG_HANDLE stuEventHandler;
    /// <summary>
    /// 事件响应时间段
    /// Event respond time section
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 * 10)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
    /// <summary>
    /// stuTimeSection字段是否禁用，默认FALSE：不禁用，TRUE：禁用，用户控制 
    /// stuTimeSection ,default FALSE:not disable,TRUE:disable,user control
    /// </summary>
    public byte bDisableTimeSection;
    /// <summary>
    /// 云台预置点编号	0~65535
    /// PTZ preset Id 0~65535
    /// </summary>
    public int nPtzPresetId;
    /// <summary>
    /// Size filter enable
    /// </summary>
    public bool bSizeFileter;
    /// <summary>
    /// 规则特定的尺寸过滤器
    /// Size filter info
    /// </summary>
    public NET_CFG_SIZEFILTER_INFO stuSizeFileter;
    /// <summary>
    /// 检测动作数
    /// Action type number
    /// </summary>
    public int nActionType;
    /// <summary>
    /// 检测动作列表,0-出现 1-消失 2-在区域内 3-穿越区域
    /// Action type list,0-apaer 1-disapaer 2-in area 3-cross area
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bActionType;
    /// <summary>
    /// 最小目标个数(当bActionType中包含"2-在区域内"时有效)
    /// The min object number(it will work when bActionType = 2 )
    /// </summary>
    public int nMinTargets;
    /// <summary>
    ///  最大目标个数(当bActionType中包含"2-在区域内"时有效)
    ///  The max object number(it will work when bActionType = 2 )
    /// </summary>
    public int nMaxTargets;
    /// <summary>
    /// 最短持续时间， 单位秒(当bActionType中包含"2-在区域内"时有效)
    /// Min duration, s(it will work when bActionType = 2 )
    /// </summary>
    public int nMinDuration;
    /// <summary>
    /// 报告时间间隔， 单位秒(当bActionType中包含"2-在区域内"时有效)
    /// Report interval time, s(it will work when bActionType = 2 )
    /// </summary>
    public int nReportInterval;
    /// <summary>
    /// 跟踪持续时间,0秒:一直跟踪,1~300秒:跟踪持续时间	
    /// the duration of track
    /// </summary>
    public int nTrackDuration;
  }

  /// <summary>
  /// 事件类型EVENT_IVS_LEFTDETECTION(物品遗留事件)对应的规则配置
  /// Rule type:EVENT_IVS_LEFTDETECTION configuration
  /// </summary>
  public struct NET_CFG_LEFT_INFO
  {
    /// <summary>
    /// 规则名称,不同规则不能重名
    /// Rule name,different rule mast have different name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRuleName;
    /// <summary>
    /// 规则使能
    /// Rule enable
    /// </summary>
    public byte bRuleEnable;
    /// <summary>
    /// 触发跟踪使能,仅对绊线，入侵规则有效
    /// track enable
    /// </summary>
    public byte bTrackEnable;
    /// <summary>
    /// 保留字段
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 相应物体类型个数
    /// Current object's number
    /// </summary>
    public int nObjectTypeNum;
    /// <summary>
    /// 相应物体类型列表
    /// Current object list
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 128)]
    public byte[] szObjectTypes;
    /// <summary>
    /// 最短持续时间	单位：秒，0~65535
    /// Minimal duration,	0~65535(s)
    /// </summary>
    public int nMinDuration;
    /// <summary>
    /// 检测区域顶点数
    /// Detect region point number
    /// </summary>
    public int nDetectRegionPoint;
    /// <summary>
    /// 检测区域
    /// Detect region
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CFG_POLYGON[] stuDetectRegion;
    /// <summary>
    /// 报警联动
    /// Alarm event handler
    /// </summary>
    public NET_CFG_ALARM_MSG_HANDLE stuEventHandler;
    /// <summary>
    /// 事件响应时间段
    /// Event respond time section
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 * 10)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
    /// <summary>
    /// 云台预置点编号	0~65535
    /// PTZ preset Id 0~65535
    /// </summary>
    public int nPtzPresetId;
    /// <summary>
    /// 触发报警位置数
    /// Trigger possition number
    /// </summary>
    public int nTriggerPosition;
    /// <summary>
    /// 触发报警位置,0-目标外接框中心, 1-目标外接框左端中心, 2-目标外接框顶端中心, 3-目标外接框右端中心, 4-目标外接框底端中心
    /// Trigger possition,0-object out frame center, 1-object out frame left center, 2-object out frame top center, 3-object out frame right center, 4-object out frame bottom center
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bTriggerPosition;
    /// <summary>
    /// 规则特定的尺寸过滤器是否有效
    /// Size filter enable
    /// </summary>
    public bool bSizeFileter;
    /// <summary>
    /// 规则特定的尺寸过滤器
    /// Size filter info
    /// </summary>
    public NET_CFG_SIZEFILTER_INFO stuSizeFileter;
    /// <summary>
    /// 跟踪持续时间,0秒:一直跟踪,1~300秒:跟踪持续时间	
    /// the duration of track
    /// </summary>
    public int nTrackDuration;
  }

  /// <summary>
  /// 事件类型EVENT_IVS_TAKENAWAYDETECTION(物品搬移规则配置)对应的规则配置
  /// Rule type:EVENT_IVS_TAKENAWAYDETECTION configuration
  /// </summary>
  public struct NET_CFG_TAKENAWAYDETECTION_INFO
  {
    /// <summary>
    /// 规则名称,不同规则不能重名
    /// Rule name,different rule mast have different name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRuleName;
    /// <summary>
    /// 规则使能
    /// Rule enable
    /// </summary>
    public byte bRuleEnable;
    /// <summary>
    /// 触发跟踪使能
    /// track enable
    /// </summary>
    public byte bTrackEnable;
    /// <summary>
    /// 保留字段
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 相应物体类型个数
    /// Current object's number
    /// </summary>
    public int nObjectTypeNum;
    /// <summary>
    /// 相应物体类型列表
    ///  Current object list
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 128)]
    public byte[] szObjectTypes;
    /// <summary>
    /// 最短持续时间	单位：秒，0~65535
    /// Min duration, s,0~65535
    /// </summary>
    public int nMinDuration;
    /// <summary>
    /// 检测区域顶点数
    /// Detect region point number
    /// </summary>
    public int nDetectRegionPoint;
    /// <summary>
    /// 检测区域
    /// Detect region
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CFG_POLYGON[] stuDetectRegion;
    /// <summary>
    /// 报警联动
    /// Alarm event handler
    /// </summary>
    public NET_CFG_ALARM_MSG_HANDLE stuEventHandler;
    /// <summary>
    /// 事件响应时间段
    /// Event respond time section
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 * 10)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
    /// <summary>
    /// 云台预置点编号	0~65535
    /// PTZ preset Id 0~65535
    /// </summary>
    public int nPtzPresetId;
    /// <summary>
    /// 触发报警位置数
    /// Trigger possition number
    /// </summary>
    public int nTriggerPosition;
    /// <summary>
    /// 触发报警位置,0-目标外接框中心, 1-目标外接框左端中心, 2-目标外接框顶端中心, 3-目标外接框右端中心, 4-目标外接框底端中心
    /// Trigger possition,0-object out frame center, 1-object out frame left center, 2-object out frame top center, 3-object out frame right center, 4-object out frame bottom center
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
    public byte[] bTriggerPosition;
    /// <summary>
    /// 规则特定的尺寸过滤器是否有效
    /// Size filter enable
    /// </summary>
    public byte bSizeFileter;
    /// <summary>
    /// 规则特定的尺寸过滤器
    /// Size filter info
    /// </summary>
    public NET_CFG_SIZEFILTER_INFO stuSizeFileter;
    /// <summary>
    /// 跟踪持续时间,0秒:一直跟踪,1~300秒:跟踪持续时间
    /// the duration of track
    /// </summary>
    public int nTrackDuration;
  }

  /// <summary>
  /// 事件类型EVENT_IVS_VIDEOABNORMALDETECTION(视频异常)对应的规则配置
  /// Rule type EVENT_IVS_VIDEOABNORMALDETECTION configuration
  /// </summary>

  public struct NET_CFG_VIDEOABNORMALDETECTION_INFO
  {
    /// <summary>
    /// 规则名称,不同规则不能重名
    /// Rule name,different rule mast have different name
    /// </summary>
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szRuleName;
    /// <summary>
    /// 规则使能
    /// Rule enable
    /// </summary>
    public byte bRuleEnable;
    /// <summary>
    /// 灵敏度, 取值1-10，值越小灵敏度越低(只对检测类型视频遮挡，过亮，过暗，场景变化有效)
    /// Sensitivity, 1-10,the lower value the lower sensitivity)
    /// </summary>
    public byte bSensitivity;
    /// <summary>
    /// 保留字段
    /// Reserved
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] bReserved;
    /// <summary>
    /// 相应物体类型个数
    /// Current object's number
    /// </summary>
    public int nObjectTypeNum;
    /// <summary>
    /// 相应物体类型列表
    /// Current object list
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16 * 128)]
    public byte[] szObjectTypes;
    /// <summary>
    /// 云台预置点编号	0~65535
    /// PTZ preset Id 0~65535
    /// </summary>
    public int nPtzPresetId;
    /// <summary>
    /// 检测类型数
    /// Detect type
    /// </summary>
    public int nDetectType;
    /// <summary>
    /// 检测类型,0-视频丢失, 1-视频遮挡, 2-画面冻结, 3-过亮, 4-过暗, 5-场景变化,6-条纹检测 , 7-噪声检测 , 8-偏色检测 , 9-视频模糊检测 , 10-对比度异常检测,11-视频运动 , 12-视频闪烁 , 13-视频颜色 , 14-虚焦检测 , 15-过曝检测
    /// Detect type,0-video lost, 1-video blind, 2-video freeze, 3- too light, 4-too dark, 5-sence change, 6-stripe detect, 7-noise detect, 8-color cast detect, 9-video blur detect, 10-constrast abnormal, 11-video motion, 12-video flash , 13-video color , 14- , 15-over expose
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] bDetectType;
    /// <summary>
    /// 最短持续时间	单位：秒，0~65535
    /// Min duration s 0~65535
    /// </summary>
    public int nMinDuration;
    /// <summary>
    /// 报警联动
    ///  Alarm event handler
    /// </summary>
    public NET_CFG_ALARM_MSG_HANDLE stuEventHandler;
    /// <summary>
    /// 事件响应时间段
    /// Event respond time section
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 7 * 10)]
    public NET_CFG_TIME_SECTION[] stuTimeSection;
    /// <summary>
    /// 检测区顶点数
    /// Detect region point
    /// </summary>
    public int nDetectRegionPoint;
    /// <summary>
    /// 检测区
    /// Detect region 
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
    public NET_CFG_POLYGON[] stuDetectRegion;
    /// <summary>
    /// 异常检测阈值数量
    /// the counts of threshold 
    /// </summary>
    public int nThresholdNum;
    /// <summary>
    /// 异常检测阈值,范围1~100
    /// the threshold data, 1~100
    /// </summary>
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] nThreshold;                 // 

  }

  // 布撤防状态变化事件的信息
  public struct NET_ALARM_ARMMODE_CHANGE_INFO
  {
    public uint dwSize;
    public NET_TIME stuTime;        // 报警事件发生的时间
    public EM_ALARM_MODE emAlarmMode;    // 变化后的状态
    public EM_SCENE_MODE emSceneMode;    // 情景模式
    public uint dwID;           // ID号, 遥控器编号或键盘地址, emTriggerMode为NET_EM_TRIGGER_MODE_NET类型时为0
    public EM_TRIGGER_MODE emTriggerMode;  // 触发方式
  }

  // 布撤防模式
  public enum EM_ALARM_MODE
  {
    UNKNOWN = -1,        // 未知
    DISARMING,           // 撤防
    ARMING,              // 布防
    FORCEON,             // 强制布防
    PARTARMING,          // 部分布防
  }

  // 布撤防场景模式
  public enum EM_SCENE_MODE
  {
    UNKNOWN,             // 未知场景
    OUTDOOR,             // 外出模式
    INDOOR,              // 室内模式
    WHOLE,               // 全局模式
    RIGHTNOW,            // 立即模式
    SLEEPING,            // 就寝模式
    CUSTOM,              // 自定义模式
  }

  // 触发方式
  public enum EM_TRIGGER_MODE
  {
    UNKNOWN = 0,
    NET,            // 网络用户(平台或Web)
    KEYBOARD,       // 键盘
    REMOTECONTROL,  // 遥控器
  }

  // 报警输入源事件详情(只要有输入就会产生改事件,不论防区当前的模式,无法屏蔽)
  public struct NET_ALARM_INPUT_SOURCE_SIGNAL_INFO
  {
    public uint dwSize;
    public int nChannelID;                         // 通道号
    public int nAction;                            // 0:开始 1:停止
    public NET_TIME stuTime;                            // 报警事件发生的时间
  }

  // 防区布撤防状态改变事件详情
  public struct NET_ALARM_DEFENCE_ARMMODECHANGE_INFO
  {
    public EM_DEFENCEMODE emDefenceStatus;            //布撤防状态
    public int nDefenceID;                 //防区号
    public NET_TIME_EX stuTime;                    //时间
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] reserved;              //预留
  }

  // 防区布防撤防状态类型
  public enum EM_DEFENCEMODE
  {
    UNKNOWN,             // "unknown"   未知
    ARMING,              // "Arming"    布防
    DISARMING,           // "Disarming" 撤防
  }

  // CLIENT_SCADAAlarmAttachInfo()接口输入参数
  public struct NET_IN_SCADA_ALARM_ATTACH_INFO
  {
    public uint dwSize;
    public fSCADAAlarmAttachInfoCallBack cbCallBack;                 // 数据回调函数
    public IntPtr dwUser;                     // 用户定义参数
  }

  // CLIENT_SCADAAlarmAttachInfo()接口输出参数
  public struct NET_OUT_SCADA_ALARM_ATTACH_INFO
  {
    public uint dwSize;
  }

  // CLIENT_SCADAAttachInfo()接口输入参数
  public struct NET_IN_SCADA_ATTACH_INFO
  {
    public uint dwSize;
    public fSCADAAttachInfoCallBack cbCallBack;                 // 数据回调函数
    public EM_NET_SCADA_POINT_TYPE emPointType;                // 点位类型
    public IntPtr dwUser;                     // 用户定义参数
  }

  // 点位类型
  public enum EM_NET_SCADA_POINT_TYPE
  {
    UNKNOWN = 0,                       // 未知
    ALL,                               // 所有类型
    YC,                                // 遥测 模拟量输入
    YX,                                // 遥信 开关量输入
    YT,                                // 遥调 模拟量输出
    YK,                                // 遥控 开关量输出
  }

  // CLIENT_SCADAAttachInfo()接口输出参数
  public struct NET_OUT_SCADA_ATTACH_INFO
  {
    public uint dwSize;
  }

  // 检测采集设备报警事件, 对应事件类型 NET_ALARM_SCADA_DEV_INFO
  public struct NET_ALARM_SCADA_DEV_INFO
  {
    public uint dwSize;
    public int nChannel;                           // 通道号
    public NET_TIME stuTime;                            // 事件发生的时间
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevName;     // 故障设备名称
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szDesc;       // 报警描述
    public int nAction;                            // -1:未知 0:脉冲 1:开始 2:停止
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szID;          // 点位ID, 目前使用16字节
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szSensorID;    // 探测器ID, 目前使用16字节
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szDevID;       // 设备ID, 目前使用16字节
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPointName;   // 点位名,与点表匹配
    public int nAlarmFlag;                         // 0:开始, 1:结束
  }

  // 监测点位报警信息列表
  public struct NET_SCADA_NOTIFY_POINT_ALARM_INFO_LIST
  {
    public uint dwSize;
    public int nList;                                          // 监测点位报警信息个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_SCADA_NOTIFY_POINT_ALARM_INFO[] stuList;   // 监测点位报警信息
  }

  //监测点位报警信息
  public struct NET_SCADA_NOTIFY_POINT_ALARM_INFO
  {
    public uint dwSize;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szDevID;               // 设备ID
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szPointID;            // 点位ID
    public bool bAlarmFlag;                                 // 报警标志
    public NET_TIME stuAlarmTime;                               // 报警时间
    public int nAlarmLevel;                                // 报警级别（0~6）
    public int nSerialNo;                                  // 报警编号,同一个告警的开始和结束的编号是相同的。
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szAlarmDesc;          // 报警描述
  }

  // 监测点位信息
  public struct NET_SCADA_NOTIFY_POINT_INFO
  {
    public uint dwSize;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szDevName;     // 设备名称,与getInfo获取的名称一致
    public EM_NET_SCADA_POINT_TYPE emPointType;                        // 点位类型
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szPointName;   // 点位名,与点位表的取值一致
    public float fValue;                             // Type为YC时为浮点数
    public int nValue;                             // Type为YX时为整数
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szFSUID;       // 现场监控单元ID(Field Supervision Unit), 即设备本身
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szID;          // 点位ID
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szSensorID;    // 探测器ID
    public NET_TIME_EX stuCollectTime;                     // 采集时间
  }

  // 监测点位信息列表
  public struct NET_SCADA_NOTIFY_POINT_INFO_LIST
  {
    public uint dwSize;
    public int nList;                        // 监测点位信息个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public NET_SCADA_NOTIFY_POINT_INFO[] stuList; // 监测点位信息
  }

  public struct NET_ALARM_FIREWARNING_INFO
  {
    public int nPresetId;                          // 该字段废弃，请由DH_ALARM_FIREWARNING_INFO事件获取此信息
    public int nState;                             // 0 - 开始,1 - 结束,-1:无意义
    public NET_RECT stBoundingBox;                      // 该字段废弃,请由DH_ALARM_FIREWARNING_INFO事件获取此信息	
    public int nTemperatureUnit;                   // 该字段废弃,请由DH_ALARM_FIREWARNING_INFO事件获取此信息
    public float fTemperature;                       // 该字段废弃,请由DH_ALARM_FIREWARNING_INFO事件获取此信息 
    public uint nDistance;                          // 该字段废弃,请由DH_ALARM_FIREWARNING_INFO事件获取此信息
    public NET_GPS_POINT stGpsPoint;                         // 该字段废弃,请由DH_ALARM_FIREWARNING_INFO事件获取此信息
    public int nChannel;                           // 对应视频通道号
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 252)]
    public byte[] reserved;
  }

  public struct NET_GPS_POINT
  {
    public uint dwLongitude;                      // 经度(单位是百万分之度,范围0-360度)如东经120.178274度表示为300178274
    public uint dwLatidude;                       // 纬度(单位是百万分之度,范围0-180度)如北纬30.183382度表示为120183382
                                                  // 经纬度的具体转换方式可以参考结构体 NET_WIFI_GPS_INFO 中的注释
  }


  // 热成像火情报警信息上报事件
  public struct ALARM_FIREWARNING_INFO_DETAIL
  {
    public int nChannel;                                           // 对应视频通道号
    public int nWarningInfoCount;                                  // 报警信息个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public NET_FIREWARNING_INFO[] stuFireWarningInfo;       // 具体报警信息
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] reserved;
  }

  //热成像火情报警信息
  public struct NET_FIREWARNING_INFO
  {
    public int nPresetId;                          // 预置点编号	从测温规则配置CFG_RADIOMETRY_RULE_INFO中选择
    public NET_RECT stuBoundingBox;                     // 着火点矩形框	
    public int nTemperatureUnit;                   // 温度单位(当前配置的温度单位),见 EM_TEMPERATURE_UNIT
    public float fTemperature;                       // 最高点温度值	同帧检测和差分检测提供
    public uint nDistance;                          // 着火点距离,单位米 0表示无效
    public NET_GPS_POINT stuGpsPoint;                        // 着火点经纬度
    public NET_PTZ_POSITION_UNIT stuPTZPosition;                     // 云台运行信息
    public float fAltitude;                          // 高度(单位：米)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 208)]
    public byte[] reserved;
  }

  //云台控制坐标单元
  public struct NET_PTZ_POSITION_UNIT
  {
    public int nPositionX;                        // 云台水平方向角度,归一化到-1~1
    public int nPositionY;                        // 云台垂直方向角度,归一化到-1~1
    public int nZoom;                             // 云台光圈放大倍率,归一化到 0~1
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public byte[] szReserve;                          // 预留32字节
  }


  // 热成像火情报警信息上报事件
  public struct NET_ALARM_FIREWARNING_INFO_DETAIL
  {
    public int nChannel;                                           // 对应视频通道号
    public int nWarningInfoCount;                                  // 报警信息个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public NET_FIREWARNING_INFO[] stuFireWarningInfo;       // 具体报警信息
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] reserved;
  }

  // 温度单位
  public enum EM_TEMPERATURE_UNIT
  {
    UNKNOWN,
    CENTIGRADE,                // 摄氏度
    FAHRENHEIT,                // 华氏度
  }

  /// <summary>
  /// 
  /// 清除当前时间段内人数统计信息, 重新从0开始计算
  /// </summary>
  public struct NET_CTRL_CLEAR_SECTION_STAT_INFO
  {
    public uint dwSize;
    /// <summary>
    /// 
    /// 视频通道号
    /// </summary>
    public int nChannel;
  }

  //事件类型EVENT_IVS_TRAFFIC_PEDESTRAINRUNREDLIGHT(交通-行人闯红灯事件)对应的数据块描述信息
  public struct NET_DEV_EVENT_TRAFFIC_PEDESTRAINRUNREDLIGHT_INFO
  {
    public int nChannelID;                                 // 通道号
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public byte[] szName;                                // 事件名称
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
    public byte[] bReserved1;                              // 字节对齐
    public double PTS;                                        // 时间戳(单位是毫秒)
    public NET_TIME_EX UTC;                                        // 事件发生的时间
    public int nEventID;                                   // 事件ID
    public int nLane;                                      // 对应车道号
    public NET_MSG_OBJECT stuObject;                                  // 行人信息
    public NET_EVENT_FILE_INFO stuFileInfo;                                // 事件对应文件信息 
    public int nSequence;                                  // 表示抓拍序号,如3,2,1,1表示抓拍结束,0表示异常结束
    public byte bEventAction;                               // 事件动作,0表示脉冲事件,1表示持续性事件开始,2表示持续性事件结束;
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
    public byte[] byReserved;
    public byte byImageIndex;                               // 图片的序号, 同一时间内(精确到秒)可能有多张图片, 从0开始
    public uint dwSnapFlagMask;                             // 抓图标志(按位),具体见NET_RESERVED_COMMON    
    public NET_RESOLUTION_INFO stuResolution;                              // 对应图片的分辨率
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1024)]
    public byte[] bReserved;                            // 保留字节
    public NET_EVENT_COMM_INFO stCommInfo;                                 // 公共信息
  }

  public struct NET_MEDIA_QUERY_TRAFFICCAR_PARAM
  {
    public int nChannelID;                     // 通道号从0开始,-1表示查询所有通道
    public NET_TIME StartTime;                      // 开始时间    
    public NET_TIME EndTime;                        // 结束时间
    public int nMediaType;                     // 文件类型,0:任意类型, 1:jpg图片, 2:dav文件
    public int nEventType;                     // 事件类型,详见"智能分析事件类型", 0:表示查询任意事件,此参数废弃,请使用pEventTypes
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumber;              // 车牌号, "\0"则表示查询任意车牌号
    public int nSpeedUpperLimit;               // 查询的车速范围; 速度上限 单位: km/h
    public int nSpeedLowerLimit;               // 查询的车速范围; 速度下限 单位: km/h 
    public bool bSpeedLimit;                    // 是否按速度查询; TRUE:按速度查询,nSpeedUpperLimit和nSpeedLowerLimit有效。
    public uint dwBreakingRule;                 // 违章类型：
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateType;                // 车牌类型
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPlateColor;               // 车牌颜色, "Blue"蓝色,"Yellow"黄色, "White"白色,"Black"黑色
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szVehicleColor;             // 车身颜色:"White"白色, "Black"黑色, "Red"红色, "Yellow"黄色, "Gray"灰色, "Blue"蓝色,"Green"绿色
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szVehicleSize;              // 车辆大小类型:"Light-duty":小型车;"Medium":中型车; "Oversize":大型车; "Unknown": 未知
    public int nGroupID;                       // 事件组编号(此值>=0时有效)
    public short byLane;                         // 车道号(此值>=0时表示具体车道,-1表示所有车道,即不下发此字段)
    public byte byFileFlag;                     // 文件标志, 0xFF-使用nFileFlagEx, 0-表示所有录像, 1-定时文件, 2-手动文件, 3-事件文件, 4-重要文件, 5-合成文件
    public byte byRandomAccess;                 // 是否需要在查询过程中随意跳转,0-不需要,1-需要
    public int nFileFlagEx;                    // 文件标志, 按位表示: bit0-定时文件, bit1-手动文件, bit2-事件文件, bit3-重要文件, bit4-合成文件, bit5-黑名单图片 0xFFFFFFFF-所有录像
    public int nDirection;                     // 车道方向（车开往的方向）    0-北 1-东北 2-东 3-东南 4-南 5-西南 6-西 7-西北 8-未知 -1-所有方向
    public IntPtr szDirs;                         // 工作目录列表,一次可查询多个目录,为空表示查询所有目录。目录之间以分号分隔,如“/mnt/dvr/sda0;/mnt/dvr/sda1”,szDirs==null 或"" 表示查询所有char*
    public IntPtr pEventTypes;                    // 待查询的事件类型数组指针,事件类型,详见"智能分析事件类型",若为NULL则认为查询所有事件（缓冲需由用户申请）int类型
    public int nEventTypeNum;                  // 事件类型数组大小
    public IntPtr pszDeviceAddress;               // 设备地址, NULL表示该字段不起作用 char*
    public IntPtr pszMachineAddress;              // 机器部署地点, NULL表示该字段不起作用 char*
    public IntPtr pszVehicleSign;                 // 车辆标识, 例如 "Unknown"-未知, "Audi"-奥迪, "Honda"-本田... NULL表示该字段不起作用 char*
    public ushort wVehicleSubBrand;               // 车辆子品牌 需要通过映射表得到真正的子品牌 映射表详见开发手册
    public ushort wVehicleYearModel;              // 车辆品牌年款 需要通过映射表得到真正的年款 映射表详见开发手册
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 28)]
    public int[] bReserved;                  // 保留字段
  }


  // TRAFFICCAR_EX对应的查询条件
  public struct NET_MEDIA_QUERY_TRAFFICCAR_PARAM_EX
  {
    public uint dwSize;
    public NET_MEDIA_QUERY_TRAFFICCAR_PARAM stuParam;                  // 基本查询参数
  }

  // TRAFFICCAR_EX查询出来的文件信息
  public struct NET_MEDIAFILE_TRAFFICCAR_INFO_EX
  {
    public uint dwSize;
    public NET_MEDIAFILE_TRAFFICCAR_INFO stuInfo;                          // 基本信息
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
    public string szDeviceAddr;     // 设备地址
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szVehicleSign;     // 车辆标识, 例如 "Unknown"-未知, "Audi"-奥迪, "Honda"-本田...
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szCustomParkNo;    // 自定义车位号（停车场用）
    public ushort wVehicleSubBrand;                       // 车辆子品牌，需要通过映射表得到真正的子品牌
    public ushort wVehicleYearModel;                      // 车辆年款，需要通过映射表得到真正的年款
    public NET_TIME stuEleTagInfoUTC;           // 对应电子车牌标签信息中的过车时间(ThroughTime)
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
    public EM_RECORD_SNAP_FLAG_TYPE[] emFalgLists;    // 录像或抓图文件标志 
    public int nFalgCount;                // 标志总数 
  }

  // DH_MEDIA_QUERY_TRAFFICCAR查询出来的media文件信息
  public struct NET_MEDIAFILE_TRAFFICCAR_INFO
  {
    public uint ch;                                 // 通道号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
    public string szFilePath;                    // 文件路径
    public uint size;                               // 文件长度,该字段废弃，请使用sizeEx
    public NET_TIME starttime;                          // 开始时间
    public NET_TIME endtime;                            // 结束时间
    public uint nWorkDirSN;                         // 工作目录编号                                    
    public byte nFileType;                          // 文件类型  1:图片 2:视频
    public byte bHint;                              // 文件定位索引
    public byte bDriveNo;                           // 磁盘号
    public byte bReserved2;
    public uint nCluster;                           // 簇号
    public byte byPictureType;                      // 图片类型或文件标记, 0-普通, 1-合成, 2-抠图。更多文件标记信息请参考 MEDIAFILE_TRAFFICCAR_INFO_EX 的 emFalgLists 字段
    public byte byVideoStream;            // 视频码流 0-未知 1-主码流 2-辅码流1 3-辅码流2 4-辅码流
    public byte byPartition;            // 精确定位号
    public byte bReserved;                          // 保留字段
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateNumber;                  // 车牌号码
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szPlateType;                    // 号牌类型
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szPlateColor;                   // 车牌颜色:"Blue","Yellow", "White","Black"
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szVehicleColor;                 // 车身颜色:"White", "Black", "Red", "Yellow", "Gray", "Blue","Green"
    public int nSpeed;                             // 车速,单位Km/H
    public int nEventsNum;                         // 关联的事件个数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public int[] nEvents;                        // 关联的事件列表,数组值表示相应的事件,详见"智能分析事件类型"        
    public uint dwBreakingRule;                     // 具体违章类型掩码,第一位:闯红灯; 第二位:不按规定车道行驶;第三位:逆行; 第四位：违章掉头;否则默认为:交通路口事件
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szVehicleSize;                  // 车辆大小类型:"Light-duty":小型车;"Medium":中型车; "Oversize":大型车
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string szChannelName;                  // 本地或远程的通道名称
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 16)]
    public string szMachineName;                  // 本地或远程设备名称
    public int nSpeedUpperLimit;                   // 速度上限 单位: km/h
    public int nSpeedLowerLimit;                   // 速度下限 单位: km/h    
    public int nGroupID;                           // 事件里的组编号
    public byte byCountInGroup;                     // 一个事件组内的抓拍张数
    public byte byIndexInGroup;                     // 一个事件组内的抓拍序号
    public byte byLane;                             // 车道,参见MEDIA_QUERY_TRAFFICCAR_PARAM
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 21)]
    public byte[] bReserved1;                     // 保留
    public NET_TIME stSnapTime;                          // 抓拍时间
    public int nDirection;                         // 车道方向,参见NET_MEDIA_QUERY_TRAFFICCAR_PARAM
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
    public string szMachineAddress;         // 机器部署地点
    public Int64 sizeEx;                             // 文件长度扩展，支持文件长度大于4G，单位字节
  }

  public enum EM_RECORD_SNAP_FLAG_TYPE
  {
    TIMING,                  //定时文件
    MANUAL,                  //手动文件
    MARKED,                  //重要文件
    EVENT,                  //事件文件
    MOSAIC,                  //合成图片
    CUTOUT,                  //抠图图片
    LEAVE_WORD,              //留言文件
    TALKBACK_LOCAL_SIDE,     //对讲本地方文件
    TALKBACK_REMOTE_SIDE,    //对讲远程方文件
    SYNOPSIS_VIDEO,          //浓缩视频
    ORIGINAL_VIDEO,          //原始视频
    PRE_ORIGINAL_VIDEO,      //已经预处理的原始视频
    BLACK_PLATE,             //黑名单图片
    ORIGINAL_PIC,            //原始图片
    CARD,                     //卡号录像
    MAX = 128,
  }

  /// <summary>
  ///  设备信息类型,对应 CLIENT_StartFind CLIENT_DoFind CLIENT_StopFind 接口
  ///  
  /// </summary>
  public enum EM_FIND
  {
    /// <summary>
    /// 热成像温度查询, pInBuf= NET_IN_RADIOMETRY_*FIND*, pOutBuf= NET_OUT_RADIOMETRY_*FIND*
    /// thermal temperature query, pInBuf= NET_IN_RADIOMETRY_*FIND*, pOutBuf= NET_OUT_RADIOMETRY_*FIND*
    /// </summary>
    RADIOMETRY,
    /// <summary>
    /// POS交易信息查询,pInBuf = NET_IN_POSEXCHANGE_*FIND*,pOutBuf= NET_OUT_POSEXCHANGE_*FIND*
    /// POS Exchange Info Find,pInBuf = NET_IN_POSEXCHANGE_*FIND*,pOutBuf= NET_OUT_POSEXCHANGE_*FIND*
    /// </summary>
    NET_FIND_POS_EXCHANGE,
  }

  //热成像查询保存周期
  public enum EM_RADIOMETRY_PERIOD
  {
    PERIOD_UNKNOWN,     // 未知
    PERIOD_5 = 5,     // 5分钟记录表，默认
    PERIOD_10 = 10,           // 10分钟记录表
    PERIOD_15 = 15,           // 15分钟记录表
    PERIOD_30 = 30,           // 30分钟记录表
  }

  // CLIENT_StartFind 接口 NET_FIND_RADIOMETRY 命令入参
  public struct NET_IN_RADIOMETRY_STARTFIND
  {
    public uint dwSize;
    public NET_TIME stStartTime;                       // 查询开始时间
    public NET_TIME stEndTime;                         // 查询结束时间
    public int nMeterType;                        // 查询类别,见枚举EM_RADIOMETRY_METERTYPE
    public int nChannel;                          // 通道号
    public EM_RADIOMETRY_PERIOD emPeriod;                          // 所查询表的保存周期
  }

  // CLIENT_StartFind 接口 NET_FIND_RADIOMETRY 命令出参
  public struct NET_OUT_RADIOMETRY_STARTFIND
  {
    public uint dwSize;
    public int nFinderHanle;                      // 取到的查询句柄
    public int nTotalCount;                       // 符合此次查询条件的结果总条数
  }

  // CLIENT_DoFind 接口 NET_FIND_RADIOMETRY 命令入参
  public struct NET_IN_RADIOMETRY_DOFIND
  {
    public uint dwSize;
    public int nFinderHanle;                      // 查询句柄
    public int nBeginNumber;                      // 本次查询开始的索引号
    public int nCount;                            // 本次查询条数,最大为NET_IN_RADIOMETRY_DOFIND_MAX
  }

  // 测温信息
  public struct NET_RADIOMETRYINFO
  {
    public int nMeterType;                         // 返回测温类型,见EM_RADIOMETRY_METERTYPE
    public int nTemperUnit;                        // 温度单位(当前配置的温度单位),见 EM_TEMPERATURE_UNIT
    public float fTemperAver;                        // 点的温度或者平均温度   点的时候 只返回此字段
    public float fTemperMax;                         // 最高温度 
    public float fTemperMin;                         // 最低温度 
    public float fTemperMid;                         // 中间温度值    
    public float fTemperStd;                         // 标准方差值
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 64)]
    public byte[] reserved;
  }

  // 返回查询结果
  public struct NET_RADIOMETRY_QUERY
  {
    public NET_TIME stTime;                            // 记录时间
    public int nPresetId;                         // 预置点编号
    public int nRuleId;                           // 规则编号
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szName;                        // 查询项名称
    public NET_POINT stCoordinate;                      // 查询测温点坐标
    public int nChannel;                          // 通道号
    public NET_RADIOMETRYINFO stTemperInfo;                      // 测温信息,目前nTemperMid, nTemperStd 成员无效
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] reserved;
  }

  // CLIENT_DoFind 接口 NET_FIND_RADIOMETRY 命令出参
  public struct NET_OUT_RADIOMETRY_DOFIND
  {
    public uint dwSize;
    public int nFound;                             // 实际查询到的点数
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
    public NET_RADIOMETRY_QUERY[] stInfo;  // 温度统计信息
  }

  // CLIENT_StopFind 接口 NET_FIND_RADIOMETRY 命令入参
  public struct NET_IN_RADIOMETRY_STOPFIND
  {
    public uint dwSize;
    public int nFinderHanle;                       // 查询句柄
  }

  // CLIENT_StopFind 接口 NET_FIND_RADIOMETRY 命令出参
  public struct NET_OUT_RADIOMETRY_STOPFIND
  {
    public uint dwSize;
  }

  // 热图元数据信息
  public struct NET_RADIOMETRY_METADATA
  {
    public int nHeight;                            // 高
    public int nWidth;                             // 宽
    public int nChannel;                           // 通道
    public NET_TIME stTime;                             // 获取数据时间
    public int nLength;                            // 数据大小
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 64)]
    public string szSensorType;                   // 机芯类型
    public int nUnzipParamR;                       // 解压缩参数R
    public int nUnzipParamB;                       // 解压缩参数B
    public int nUnzipParamF;                       // 解压缩参数F
    public int nUnzipParamO;                       // 解压缩参数O
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 256)]
    public byte[] Reserved;
  };

  // 热图数据
  public struct NET_RADIOMETRY_DATA
  {
    public NET_RADIOMETRY_METADATA stMetaData;                 // 元数据
    public IntPtr pbDataBuf;                  // 热图数据缓冲区（压缩过的数据,里面是每个像素点的温度数据,可以使用元数据信息解压）
    public uint dwBufSize;                  // 热图数据缓冲区大小
    [MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
    public byte[] reserved;
  }

  // CLIENT_RadiometryAttach 入参
  public struct NET_IN_RADIOMETRY_ATTACH
  {
    public uint dwSize;
    public int nChannel;                           // 视频通道号	-1 表示全部
    public fRadiometryAttachCB cbNotify;                           // 状态回调函数指针
    public IntPtr dwUser;                             // 用户数据
  };

  // CLIENT_RadiometryAttach 出参
  public struct NET_OUT_RADIOMETRY_ATTACH
  {
    public uint dwSize;
  };

  // CLIENT_RadiometryFetch 入参
  public struct NET_IN_RADIOMETRY_FETCH
  {
    public uint dwSize;
    public int nChannel;                           // 通道号, 通道号要与订阅时一致, -1除外
  };

  // CLIENT_RadiometryFetch 出参
  public struct NET_OUT_RADIOMETRY_FETCH
  {
    public uint dwSize;
    public int nStatus;                            // 0: 未知, 1: 空闲, 2: 获取热图中
  }

}



