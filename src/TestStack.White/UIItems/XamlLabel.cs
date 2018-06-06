using System.Windows.Automation;
using TestStack.White.UIItems.Actions;
using TestStack.White.UIItems.Finders;

namespace TestStack.White.UIItems
{
    [PlatformSpecificItem]
    public class XamlLabel : Label
    {
        protected XamlLabel() {}
        public XamlLabel(AutomationElement automationElement, IActionListener actionListener) : base(automationElement, actionListener) {}

        public virtual Hyperlink Hyperlink(string text)
        {
            return (Hyperlink) factory.Create(SearchCriteria.ByText(text).AndControlType(typeof (Hyperlink), Framework), actionListener);
        }
    }
}