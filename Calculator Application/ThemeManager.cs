using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator_Application
{
    public enum Theme
    {
        Rustic,  // Modern clean + old school rustic (default)
        Light,
        Dark
    }

    public static class ThemeManager
    {
        private static Theme currentTheme = Theme.Rustic;
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
            currentTheme = currentTheme switch
            {
                Theme.Rustic => Theme.Light,
                Theme.Light => Theme.Dark,
                Theme.Dark => Theme.Rustic,
                _ => Theme.Rustic
            };
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
                // Default to Rustic theme if loading fails
                currentTheme = Theme.Rustic;
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
            return currentTheme switch
            {
                Theme.Rustic => RusticColors,
                Theme.Light => LightColors,
                Theme.Dark => DarkColors,
                _ => RusticColors
            };
        }

        // Modern Clean + Old School Rustic Theme
        public static ThemeColors RusticColors = new ThemeColors
        {
            FormBackColor = Color.FromArgb(245, 238, 220),
            TextBoxBackColor = Color.FromArgb(255, 250, 240),
            TextBoxForeColor = Color.FromArgb(60, 45, 35),
            LabelForeColor = Color.FromArgb(100, 75, 60),
            ListBoxBackColor = Color.FromArgb(250, 243, 230),
            ListBoxForeColor = Color.FromArgb(60, 45, 35),

            NeutralButtonBackColor = Color.FromArgb(220, 200, 180),
            NeutralButtonForeColor = Color.FromArgb(50, 35, 25),

            OperatorButtonBackColor = Color.FromArgb(120, 140, 120),
            OperatorButtonForeColor = Color.FromArgb(255, 245, 235),

            FunctionButtonBackColor = Color.FromArgb(180, 100, 80),
            FunctionButtonForeColor = Color.FromArgb(255, 245, 235),

            SpecialButtonBackColor = Color.FromArgb(90, 80, 70),
            SpecialButtonForeColor = Color.FromArgb(245, 235, 220),

            ButtonForeColor = Color.FromArgb(255, 245, 235),
            HighlightColor = Color.FromArgb(220, 190, 150)
        };

        public static ThemeColors LightColors = new ThemeColors
        {
            FormBackColor = SystemColors.Control,
            TextBoxBackColor = Color.White,
            TextBoxForeColor = Color.Black,
            LabelForeColor = Color.Black,
            ListBoxBackColor = Color.White,
            ListBoxForeColor = Color.Black,

            NeutralButtonBackColor = Color.FromArgb(240, 240, 240),
            NeutralButtonForeColor = Color.Black,

            OperatorButtonBackColor = Color.FromArgb(52, 152, 219),
            OperatorButtonForeColor = Color.White,

            FunctionButtonBackColor = Color.FromArgb(156, 136, 255),
            FunctionButtonForeColor = Color.White,

            SpecialButtonBackColor = Color.FromArgb(230, 126, 34),
            SpecialButtonForeColor = Color.White,

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

            NeutralButtonBackColor = Color.FromArgb(60, 60, 60),
            NeutralButtonForeColor = Color.White,

            OperatorButtonBackColor = Color.FromArgb(41, 128, 185),
            OperatorButtonForeColor = Color.White,

            FunctionButtonBackColor = Color.FromArgb(142, 68, 173),
            FunctionButtonForeColor = Color.White,

            SpecialButtonBackColor = Color.FromArgb(39, 174, 96),
            SpecialButtonForeColor = Color.White,

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

        public Color NeutralButtonBackColor { get; set; }
        public Color NeutralButtonForeColor { get; set; }

        public Color OperatorButtonBackColor { get; set; }
        public Color OperatorButtonForeColor { get; set; }

        public Color FunctionButtonBackColor { get; set; }
        public Color FunctionButtonForeColor { get; set; }

        public Color SpecialButtonBackColor { get; set; }
        public Color SpecialButtonForeColor { get; set; }

        public Color ButtonForeColor { get; set; }
        public Color HighlightColor { get; set; }
    }
}

