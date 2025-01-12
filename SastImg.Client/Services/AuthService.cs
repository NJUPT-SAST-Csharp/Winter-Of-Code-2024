﻿using System;
using System.Threading.Tasks;

namespace SastImg.Client.Services;

/// <summary>
/// 用于管理用户登录状态的服务
/// </summary>
public class AuthService ( )
{
    private string? _token;
    private bool _isLoggedIn;
    private string? _username;

    public string? Token => _token;
    public bool IsLoggedIn => _isLoggedIn;
    public string? Username => _username;

    /// <summary>
    /// 登录，如果登录成功则返回 true，登录状态会保存在该Service中
    /// </summary>
    public async Task<bool> LoginAsync (string username, string password)
    {
        _token = null;
        _username = null;
        _isLoggedIn = false;

        try
        {
            var result = await App.API!.Login(new() { Username = username, Password = password });
            _token = result.Token;
            _username = username;
            _isLoggedIn = true;
            LoginStateChanged?.Invoke(true, username); // 触发登陆成功事件
        }
        catch
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// 登出
    /// </summary>
    public void Logout ( )
    {
        _token = null;
        _isLoggedIn = false;
        _isLoggedIn = false;
        LoginStateChanged?.Invoke(false, null); // 触发登出事件
    }

    public event Action<bool,string?>? LoginStateChanged; // 当登录状态改变时触发事件。传递的第一个参数表示是否登录，第二个参数表示登录的用户名
}