using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator_Application
{
    public enum Theme
    {
        Light,
        Dark
    }

    public static class ThemeManager
    {
        private static Theme currentTheme = Theme.Light;
        private static string settingsFilePath;

        static ThemeManager()
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string appFolder = Path.Combine(appDataPath, "Calculator Application");
            Directory.CreateDirectory(appFolder);
            settingsFilePath = Path.Combine(appFolder, "settings.txt");
            LoadTheme();
        }

        public static Theme CurrentTheme => currentTheme;

        public static void ToggleTheme()
        {
            currentTheme = currentTheme == Theme.Light ? Theme.Dark : Theme.Light;
            SaveTheme();
        }

        public static void SetTheme(Theme theme)
        {
            currentTheme = theme;
            SaveTheme();
        }

        private static void LoadTheme()
        {
            try
            {
                if (File.Exists(settingsFilePath))
                {
                    string[] lines = File.ReadAllLines(settingsFilePath);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("Theme="))
                        {
                            string themeStr = line.Substring(6).Trim();
                            if (Enum.TryParse<Theme>(themeStr, out Theme theme))
                            {
                                currentTheme = theme;
                            }
                        }
                    }
                }
            }
            catch
            {
                // Default to Light theme if loading fails
                currentTheme = Theme.Light;
            }
        }

        private static void SaveTheme()
        {
            try
            {
                File.WriteAllText(settingsFilePath, $"Theme={currentTheme}");
            }
            catch
            {
                // Silently fail
            }
        }

        public static ThemeColors GetColors()
        {
            return currentTheme == Theme.Light ? LightColors : DarkColors;
        }

        public static ThemeColors LightColors = new ThemeColors
        {
            FormBackColor = SystemColors.Control,
            TextBoxBackColor = Color.White,
            TextBoxForeColor = Color.Black,
            LabelForeColor = Color.Black,
            ListBoxBackColor = Color.White,
            ListBoxForeColor = Color.Black,
            NumberButtonBackColor = Color.FromArgb(240, 240, 240),
            NumberButtonForeColor = Color.Black,
            OperatorButtonBackColor = Color.FromArgb(52, 152, 219),
            FunctionButtonBackColor = Color.FromArgb(156, 136, 255),
            MemoryButtonBackColor = Color.FromArgb(155, 89, 182),
            ClearButtonBackColor = Color.FromArgb(255, 159, 64),
            ClearHistoryButtonBackColor = Color.FromArgb(192, 57, 43),
            ConstantButtonBackColor = Color.FromArgb(241, 196, 15),
            UndoRedoButtonBackColor = Color.FromArgb(52, 73, 94),
            EqualsButtonBackColor = Color.FromArgb(46, 125, 50),
            ButtonForeColor = Color.White,
            HighlightColor = Color.LightBlue
        };

        public static ThemeColors DarkColors = new ThemeColors
        {
            FormBackColor = Color.FromArgb(30, 30, 30),
            TextBoxBackColor = Color.FromArgb(45, 45, 45),
            TextBoxForeColor = Color.White,
            LabelForeColor = Color.White,
            ListBoxBackColor = Color.FromArgb(45, 45, 45),
            ListBoxForeColor = Color.White,
            NumberButtonBackColor = Color.FromArgb(60, 60, 60),
            NumberButtonForeColor = Color.White,
            OperatorButtonBackColor = Color.FromArgb(41, 128, 185),
            FunctionButtonBackColor = Color.FromArgb(142, 68, 173),
            MemoryButtonBackColor = Color.FromArgb(155, 89, 182),
            ClearButtonBackColor = Color.FromArgb(230, 126, 34),
            ClearHistoryButtonBackColor = Color.FromArgb(192, 57, 43),
            ConstantButtonBackColor = Color.FromArgb(241, 196, 15),
            UndoRedoButtonBackColor = Color.FromArgb(44, 62, 80),
            EqualsButtonBackColor = Color.FromArgb(39, 174, 96),
            ButtonForeColor = Color.White,
            HighlightColor = Color.FromArgb(100, 149, 237)
        };
    }

    public class ThemeColors
    {
        public Color FormBackColor { get; set; }
        public Color TextBoxBackColor { get; set; }
        public Color TextBoxForeColor { get; set; }
        public Color LabelForeColor { get; set; }
        public Color ListBoxBackColor { get; set; }
        public Color ListBoxForeColor { get; set; }
        public Color NumberButtonBackColor { get; set; }
        public Color NumberButtonForeColor { get; set; }
        public Color OperatorButtonBackColor { get; set; }
        public Color FunctionButtonBackColor { get; set; }
        public Color MemoryButtonBackColor { get; set; }
        public Color ClearButtonBackColor { get; set; }
        public Color ClearHistoryButtonBackColor { get; set; }
        public Color ConstantButtonBackColor { get; set; }
        public Color UndoRedoButtonBackColor { get; set; }
        public Color EqualsButtonBackColor { get; set; }
        public Color ButtonForeColor { get; set; }
        public Color HighlightColor { get; set; }
    }
}

