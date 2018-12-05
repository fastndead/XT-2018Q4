using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace TASK2.FontAdjustment
{
    public static class Font
    {
        private enum FontType
        {
            None         = 0,
            Bold         = 1,
            Italic       = 2,
            Underline    = 3,
        }
        
        private static HashSet<FontType>  types = new HashSet<FontType>();

        public static void GetTypes()
        {
            foreach (var type in types)
            {
                Console.Write(type + ", ");
            }

            Console.WriteLine();
        }

        public static void SetType(int type)
        {
            switch (type)
            {
                    case 0 :
                        types.Clear();
                        break;
                    case 1:
                        if (!types.Contains(FontType.Bold))
                        {
                            types.Add(FontType.Bold);
                        }
                        else
                        {
                            types.Remove(FontType.Bold);
                        }
                        break;
                    case 2:
                        if (!types.Contains(FontType.Italic))
                        {
                            types.Add(FontType.Italic);
                        }
                        else
                        {
                            types.Remove(FontType.Italic);
                        }
                        break;
                    case 3:
                        if (!types.Contains(FontType.Underline))
                        {
                            types.Add(FontType.Underline);
                        }
                        else
                        {
                            types.Remove(FontType.Underline);
                        }
                        break;
            }

            if (types.Count == 0)
            {
                types.Add(FontType.None);
            }
            else
            {
                if (types.Contains(FontType.None))
                {
                    types.Remove(FontType.None);
                }
            }
        }

    }

}