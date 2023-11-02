﻿using AAAcasino.ViewModels.Base;
using System.Reflection;
using System;

namespace AAAcasino.Models
{
    internal class UserModel : ViewModel
    {
        private int _id;
        public int Id 
        {
            get => _id;
            set => Set(ref _id, value);
        }
        private string? _username;
        public string? Username
        {
            get => _username;
            set => Set(ref _username, value);
        }
        private string? _password;
        public string? Password
        {
            get => _password;
            set => Set(ref _password, value);
        }
        private int _balance;
        public int Balance
        {
            get => _balance; 
            set => Set(ref _balance, value);
        }
        private HistoryModel? _history;
        public HistoryModel? History
        {
            get => _history; 
            set => Set(ref _history, value);
        }
        public UserModel(string username, string password)
        {
            _username = username;
            _password = password;
            _balance = 0;
            _history = new HistoryModel();
        }
    }
}
