using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.Resources.chatting;

namespace UtilsClass
{
    public static class Utils
    {
        //Label 컨트롤의 텍스트 높이를 계산하는 메서드
        public static int GetTextHeight(System.Windows.Forms.Label lbl)
        {
            //label 컨트롤에서 graphics 객체를 생성하고 이를 사용하는 블록
            //블록은 graphic객체를 사용후 자동으로 자원을 해제함
            using (Graphics g = lbl.CreateGraphics())
            {
                //MeasureString 메서드를 사용하여 텍스트의 크기를 측정해야함
                //495는 텍스트를 그릴 최대 너비
                SizeF size = g.MeasureString(lbl.Text, lbl.Font, 250);

                return (int)Math.Ceiling(size.Height); //측정된 텍스트의 높이를 반올림하여 정수로 변환후 반환
            }
        }

        //label name 텍스트 가로 길이 계산하는 메서드
        public static int GetnameWidth(System.Windows.Forms.Label lbl)
        {
            using (Graphics gr = lbl.CreateGraphics())
            {
                SizeF size = gr.MeasureString(lbl.Text, lbl.Font, 250);

                return (int)Math.Ceiling(size.Width);
            }
        }
    }
}
