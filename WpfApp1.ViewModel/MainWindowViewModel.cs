﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp1.DataModels;
using WpfApp1.DataModels.Enums;

namespace WpfApp1.ViewModel;
public class MainWindowViewModel : BaseViewModel
{
    private PageModel activePage = null;
    private ObservableCollection<PageModel> pages = null;

    public MainWindowViewModel()
    {
        InitializeData();
    }

    private void InitializeData()
    {
        pages = new ObservableCollection<PageModel>();
        pages.Add(new PageModel(typeof(StartViewModel), Page.StartView));
        pages.Add(new PageModel(typeof(SoraViewModel), Page.SoraView));
    }

    public ObservableCollection<PageModel> Pages
    {
        get { return pages; }
        set { if (pages != value) { pages = value; NotifyPropertyChanged(); } }
    }

    public PageModel ActivePage
    {
        get { return activePage; }
        set { if (activePage != value) { activePage = value; NotifyPropertyChanged(); } }
    }
}