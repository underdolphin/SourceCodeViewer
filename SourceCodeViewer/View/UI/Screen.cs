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
using SharpDX.Windows;
using SharpDX.Direct2D1;

namespace SourceCodeViewer.View.UI
{
    public class Screen : RenderForm
    {
        public WindowRenderTarget render;

        public Screen()
        {
            InitializeScreen();
        }

        bool InitializeScreen()
        {
            render = new WindowRenderTarget(
                new Factory(),
                new RenderTargetProperties
                {
                    DpiX = 96,
                    DpiY = 96,
                    MinLevel = FeatureLevel.Level_10,
                    Type = RenderTargetType.Default
                },
                new HwndRenderTargetProperties
                {
                    Hwnd = this.Handle,
                    PixelSize = new SharpDX.Size2(this.Width, this.Height),
                }
                );
            return true;
        }
    }
}
