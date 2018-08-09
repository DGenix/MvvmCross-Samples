﻿using MvvmCross.Forms.Presenters.Attributes;
using MvvmCross.Forms.Views;
using StarWarsSample.Core.ViewModels;

namespace StarWarsSample.Forms.UI.Views
{
    [MvxMasterDetailPagePresentation(MasterDetailPosition.Detail, WrapInNavigationPage = true)]
    public partial class PeoplePage : MvxContentPage<PeopleViewModel>
    {
        public PeoplePage()
        {
            InitializeComponent();
        }
    }
}