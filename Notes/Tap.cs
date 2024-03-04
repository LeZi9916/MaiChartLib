using MaiChartLib.Enum;
using MaiChartLib.Exceptions;
using MaiChartLib.Interfaces;
using MaiChartLib.SyntaxModule;
using System;

namespace MaiChartLib.Notes
{
    internal class Tap : INote<Tap>
    {
        public int StartPoint { get; set; }
        public NoteType Type { get => NoteType.Tap; }
        public bool IsBreak { get; set; }
        public bool IsHanabi { get; set; }
        public double HSpeed { get; set; }
        
        /// <summary>
        /// 将指定Simai语句转换为Note实例
        /// </summary>
        /// <param name="noteStr"></param>
        /// <returns>
        /// 返回一个Simai实例，包括星星头与正常Tap</returns>
        //输入的Simai语句不应该包含"/"或"`"
        public static Tap[]? Parse(string s)
        {
            int index;
            bool isSlide = false;
            bool isBreak = false;
            bool isHanabi = false;

            if (string.IsNullOrEmpty(s))
                return null;
            else if (!int.TryParse(s[0..1], out index) || !SyntaxChecker.PointCheck(index))//总是检查第1位 错误键位直接返回
                throw new FormatException($"无法将{s}解析为SimaiNote实例，因为他不是有效的Simai语句");

            if (s.Contains("$"))// 1$$
            {
                var f = s.IndexOf("$");
                var l = s.LastIndexOf("$");

                if (f == l && s[1] == '$')
                    s = s.Remove(1, 1);
                else if (Math.Abs(f - l) == 1 && s[1..3] == "$$")
                    s = s.Remove(1, 2);
                else
                    throw new FormatException($"无法将{s}解析为SimaiNote实例，因为他不是有效的Simai语句");
                isSlide = true;
            }

            if (s.Length == 1)
                return isSlide ? new Tap[] { Init<Slide>(index) }: new Tap[] { Init<Tap>(index) };
            else if (s.Length == 2)// e.g. 28 , 2b , 2x
            {
                if (s[1] is 'b')
                    isBreak = true;
                else if (s[1] is 'x')
                    isHanabi = true;
                else if(int.TryParse(s, out int i) && (SyntaxChecker.PointCheck(i % 10) && SyntaxChecker.PointCheck(i / 10)) && !isSlide)
                {
                    int x = i % 10;
                    int y = i / 10;
                    Tap[] taps = new Tap[2];
                    taps[0] = Init<Tap>(x);
                    taps[1] = Init<Tap>(y);

                    return taps;
                }
                else
                    throw new FormatException($"无法将{s}解析为SimaiNote实例，因为他不是有效的Simai语句");

                if(isSlide)
                    return new Tap[]
                    {
                        new Slide()
                        {
                            StartPoint = index,
                            IsHanabi = isHanabi,
                            IsBreak = isBreak
                        }
                    };
                else
                    return new Tap[]
                    {
                        new Tap()
                        {
                            StartPoint = index,
                            IsHanabi = isHanabi,
                            IsBreak = isBreak
                        }
                    };

            }
            else if (s.Length == 3)// e.g. 2bx
            {
                isBreak = s[1] is 'b' || s[2] is 'b';
                isHanabi = s[1] is 'x' || s[2] is 'x';

                if(isBreak && isHanabi)
                {
                    if (isSlide)
                        return new Tap[]
                        {
                        new Slide()
                        {
                            StartPoint = index,
                            IsHanabi = isHanabi,
                            IsBreak = isBreak
                        }
                        };
                    else
                        return new Tap[]
                        {
                        new Tap()
                        {
                            StartPoint = index,
                            IsHanabi = isHanabi,
                            IsBreak = isBreak
                        }
                        };
                }
                else
                    throw new FormatException($"无法将{s}解析为SimaiNote实例，因为他不是有效的Simai语句");
            }
           
            return null;
        }
        public static INote[]? ToNote(string noteStr) => Parse(noteStr);
        public static T Init<T>(int point) where T:Tap,new() => new T()
        {
            StartPoint = point,
            IsBreak = false,
            IsHanabi = false
        };
    }
}
