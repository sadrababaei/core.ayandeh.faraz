﻿using Xamarin.Forms.Internals;

namespace Ayandeh.Faraz.Behaviors
{
    [Preserve(AllMembers = true)]
    public interface IAction
    {
        bool Execute(object sender, object parameter);
    }
}