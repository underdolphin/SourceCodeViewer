/* Copyright 2016- underdolphin(masato sueda)

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using SharpDX.Mathematics.Interop;

namespace SourceCodeViewer.View.UI
{
    public class Theme
    {
        public class Global
        {
            public RawColor4 BackgroundColor { get; set; } = Color.Black;
            public RawColor4 BorderColor { get; set; } = Color.White;
            public Thickness BorderThickness { get; set; } = new Thickness(2);

            public string FontName { get; set; } = "Yu Gothic UI";
            public int FontSize { get; set; } = 16;
            public int FontStyle { get; set; } = FontStyles.Normal;
            public int FontWeight { get; set; } = FontWeights.Normal;

            public RawColor4 ForegroundColor = Color.White;
        }

        public class Button : Global
        {
            public bool IsGradient { get; set; } = false;
            public RawColor4 FocusedBackgroundColor { get; set; } = Color.StateGray;
            public RawColor4? UnFocusedBackgroudColor { get; set; } = null; 

        }

        public class TextBox : Global
        {
            public TextBox() : base() { }
            public RawColor4? TextBoxBackground { get; set; } = null;
            public RawColor4? TextBoxForeground { get; set; } = null;
        }
    }

    public static class FontStyles
    {
        public const int Normal = 0;
        public const int Italic = 1;
        public const int Oblique = 2;
    }

    public static class FontWeights
    {
        public const int Black = 0;
        public const int Bold = 1;
        public const int DemiBold = 2;
        public const int ExtraBlack = 3;
        public const int ExtraBold = 4;
        public const int ExtraLight = 5;
        public const int Heavy = 6;
        public const int Light = 7;
        public const int Medium = 8;
        public const int Normal = 9;
        public const int Regular = 10;
        public const int SemiBold = 11;
        public const int Thin = 12;
        public const int UltraBlack = 13;
        public const int UltraBold = 14;
        public const int UltraLight = 15;
    }

    public struct Thickness
    {
        public float Bottom { get; set; }
        public float Left { get; set; }
        public float Right { get; set; }
        public float Top { get; set; }

        public Thickness(int uniformLength)
        {
            Bottom = uniformLength;
            Left = uniformLength;
            Right = uniformLength;
            Top = uniformLength;
        }

        public Thickness(int left, int top, int right, int bottom)
        {
            Bottom = bottom;
            Left = left;
            Right = right;
            Top = top;
        }
    }
}
