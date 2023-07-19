using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Dock.Avalonia.Controls;

/// <summary>
/// Interaction logic for <see cref="DocumentDockControl"/> xaml.
/// </summary>
public class DocumentDockControl : TemplatedControl
{
    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        var cc = e.NameScope.Get<DocumentControl>("PART_DocumentControl");
        LogicalChildren.Add(cc);
    }
}
