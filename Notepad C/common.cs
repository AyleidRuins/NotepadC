using System.Drawing;

namespace Notepad_C
{
    public static class Common
    {
        public static bool fileSaved = false; // was the current document saved so far in this session?

        public static string oldText = string.Empty;
        public static string newText = string.Empty;

        public static Color ForegroundColour = Color.Black;
        public static Color BackgroundColour = Color.White;

        public static float RichTextBoxZoom = 1.0f;


        public static string currentFolder = string.Empty;
        public static string currentFileName = "Untitled";
        public static string currentFileType = string.Empty;

        public static bool changeMade = false;

        internal static bool zoomInSelectedOnViewMenu;
        internal static bool zoomOutSelectedOnViewMenu;
        internal static bool StatusBarVisible;
    }
}