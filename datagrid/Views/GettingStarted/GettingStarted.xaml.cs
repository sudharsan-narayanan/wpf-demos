#region Copyright Syncfusion Inc. 2001 - 2015
// Copyright Syncfusion Inc. 2001 - 2015. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using syncfusion.demoscommon.wpf;
using Syncfusion.Windows.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace syncfusion.datagriddemos.wpf
{

    /// <summary>
    /// Interaction logic for GettingStarted.xaml
    /// </summary>
    public partial class GettingStarted : DemoControl
    {
        public GettingStarted(string themename) : base(themename)
        {
            InitializeComponent();            
        }

        protected override void Dispose(bool disposing)
        {
            this.Resources.Clear();

            if (this.DataContext != null)
                this.DataContext = null;

            //Release all managed resources
            if (this.sfgrid != null)
            {
                this.sfgrid.Dispose();
                this.sfgrid = null;
            }
            base.Dispose(disposing);
        }
    }
}
