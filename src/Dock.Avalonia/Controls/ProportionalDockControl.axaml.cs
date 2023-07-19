using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Dock.Avalonia.Controls;

/// <summary>
/// Interaction logic for <see cref="ProportionalDockControl"/> xaml.
/// </summary>
public class ProportionalDockControl : TemplatedControl
{
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        var cc = e.NameScope.Get<ItemsControl>("PART_ContentControl");
        LogicalChildren.Add(cc);
    }
}
