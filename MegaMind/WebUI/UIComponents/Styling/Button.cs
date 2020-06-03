using System.Collections.Generic;

namespace MegaMind.WebUI.UIComponents.Styling
{
    public static class ButtonStyling
    {
        public static IReadOnlyDictionary<string, object> Attributes = new Dictionary<string, object>()
        {
            { "class", "bg-white hover:bg-gray-100 text-gray-800 font-semibold py-2 px-4 border border-gray-400 rounded shadow" }
        };
    }
}
