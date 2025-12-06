using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Calculator_241439P
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

            // Numbers - warm beige
            NeutralButtonBackColor = Color.FromArgb(226, 210, 193),
            NeutralButtonForeColor = Color.FromArgb(55, 40, 30),

            // Operators - sage green (all basic operations, Undo, Redo, Theme, Audio, Speech)
            OperatorButtonBackColor = Color.FromArgb(118, 138, 120),
            OperatorButtonForeColor = Color.FromArgb(250, 245, 235),

            // Control buttons - red (C, CE, Backspace, Clear History)
            ControlButtonBackColor = Color.FromArgb(200, 80, 80),
            ControlButtonForeColor = Color.White,

            // Functions - warm brown/rust (all advanced functions, memory, constants, etc.)
            FunctionButtonBackColor = Color.FromArgb(172, 108, 92),
            FunctionButtonForeColor = Color.FromArgb(255, 245, 235),

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

            // Numbers - light gray
            NeutralButtonBackColor = Color.FromArgb(240, 240, 240),
            NeutralButtonForeColor = Color.Black,

            // Operators - blue (all basic operations, Undo, Redo, Theme, Audio, Speech)
            OperatorButtonBackColor = Color.FromArgb(52, 152, 219),
            OperatorButtonForeColor = Color.White,

            // Control buttons - red (C, CE, Backspace, Clear History)
            ControlButtonBackColor = Color.FromArgb(231, 76, 60),
            ControlButtonForeColor = Color.White,

            // Functions - purple (all advanced functions, memory, constants, etc.)
            FunctionButtonBackColor = Color.FromArgb(155, 89, 182),
            FunctionButtonForeColor = Color.White,

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

            // Numbers - dark gray
            NeutralButtonBackColor = Color.FromArgb(60, 60, 60),
            NeutralButtonForeColor = Color.White,

            // Operators - blue (all basic operations, Undo, Redo, Theme, Audio, Speech)
            OperatorButtonBackColor = Color.FromArgb(41, 128, 185),
            OperatorButtonForeColor = Color.White,

            // Control buttons - red (C, CE, Backspace, Clear History)
            ControlButtonBackColor = Color.FromArgb(192, 57, 43),
            ControlButtonForeColor = Color.White,

            // Functions - purple (all advanced functions, memory, constants, etc.)
            FunctionButtonBackColor = Color.FromArgb(142, 68, 173),
            FunctionButtonForeColor = Color.White,

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

        // Number buttons (0-9, decimal point)
        public Color NeutralButtonBackColor { get; set; }
        public Color NeutralButtonForeColor { get; set; }

        // Basic operators (+, -, ×, ÷, =, ±, %, Undo, Redo, Theme, Audio, Speech)
        public Color OperatorButtonBackColor { get; set; }
        public Color OperatorButtonForeColor { get; set; }

        // Control buttons (C, CE, Backspace, Clear History)
        public Color ControlButtonBackColor { get; set; }
        public Color ControlButtonForeColor { get; set; }

        // Function buttons (sin, cos, log, sqrt, memory, constants, copy, all advanced functions)
        public Color FunctionButtonBackColor { get; set; }
        public Color FunctionButtonForeColor { get; set; }

        public Color ButtonForeColor { get; set; }
        public Color HighlightColor { get; set; }
    }
}

