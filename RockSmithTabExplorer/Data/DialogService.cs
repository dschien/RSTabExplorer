﻿/*
 * This file is part of alphaTab.
 * Copyright c 2013, Daniel Kuschny and Contributors, All rights reserved.
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 3.0 of the License, or at your option any later version.
 * 
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library.
 */
using System.Windows;
using alphatab.model;
using AlphaTab.Wpf.Share.ViewModel;
using Microsoft.Win32;

namespace AlphaTab.Wpf.Share.Data
{
    /// <summary>
    /// This DialogService implementation opens uses WPF dialogs
    /// </summary>
    public class DialogService :IDialogService
    {
        public string OpenFile()
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Filter = "RockSmith 2014 Song Archive (*.psarc)|*.psarc"
            };
            if (dialog.ShowDialog(Application.Current.MainWindow).GetValueOrDefault())
            {
                return dialog.FileName;
            }
            return null;
        }

        public void ShowScoreInfo(Score score)
        {
            ScoreInfoViewModel viewModel = new ScoreInfoViewModel(score);
            ScoreInfoWindow window = new ScoreInfoWindow();
            window.DataContext = viewModel;
            window.ShowDialog();
        }
    }
}
