using System;
using Avalonia.Controls;
using Avalonia.Input;

namespace Dock.Avalonia.Controls;

public class ItemsControlWorkaround : ItemsControl
{
    protected override Type StyleKeyOverride => typeof(ItemsControl);

    protected override void OnGotFocus(GotFocusEventArgs e)
    {
        base.OnGotFocus(e);
        KeyboardNavigation.SetTabOnceActiveElement(this, null); // <-- otherwise it was leaking ;__;
    }
}
