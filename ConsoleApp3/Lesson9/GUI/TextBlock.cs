﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Lesson9.GUI
{
    sealed class TextBlock : GuiObject
    {
        private List<TextLine> textBlocks = new List<TextLine>();

        public TextBlock(int x, int y, int width, List<string> textList) : base(x, y, width, 0)
        {
            for (int i = 0; i < textList.Count; i++)
            {
                textBlocks.Add(new TextLine(x, y + i, width, textList[i]));
            }
        }

        override public void Render()
        {
            for (int i = 0; i < textBlocks.Count; i++)
            {
                textBlocks[i].Render();
            }
        }
    }
}